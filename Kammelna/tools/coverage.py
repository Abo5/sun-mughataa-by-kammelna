# -*- coding: utf-8 -*-
"""
قياس تغطية الأرشيف — كم من كود اللعبة موثَّق فعلًا؟

يعزل كود اللعبة (KammenlaAssembly) عن كود المكتبات، ثمّ يقيس كم من دوالّه
له عنوان مذكور في أي فصل من الأرشيف.

التشغيل:  /opt/homebrew/bin/python3 tools/coverage.py [--md]
    بلا وسائط  → تقرير نصّيّ في الطرفيّة
    --md       → يكتب tools/coverage-report.md

لماذا أداة لا رقم في README: الرقم يتعفّن. قِسه، لا تنقله.
(الرقم في README كان «~٢٠٪» وهو في الواقع ٢٦–٣٤٪ بحسب المقياس.)

ثلاثة مقاييس، والفرق بينها مقصود:
  • خام            — كل نسخة جينيريكيّة تُحتسب. يعاقب الأرشيف على تكرار لا وجود له.
  • فريد           — النسخ المولَّدة من مصدر واحد مدموجة. المقياس الأصدق.
  • منطق حقيقيّ     — فريد وبحجم ≥256B. يستبعد دوالّ الوصول والبواني التافهة.
"""
import re, io, json, os, sys, collections, gzip

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
GAME_MAX_TDI = 4253   # آخر نوع في KammenlaAssembly؛ ما بعده mscorlib (Interop…)
                      # تحقّق: TDI 4253 = Util.Addressables.InitializationAction

def game_types():
    """أسماء أنواع كود اللعبة كاملةً، كما تظهر في script.json قبل $$."""
    ns, out, root_ns = '', set(), {}
    tdi = re.compile(r'// TypeDefIndex: (\d+)\s*$')
    decl = re.compile(r'\b(class|struct|interface|enum)\s+([^\s:<]+)')
    rows = []
    with io.open(f'{ROOT}/il2cpp-dump/dump.cs', encoding='utf-8', errors='replace') as f:
        for line in f:
            if line.startswith('// Namespace: '):
                ns = line[len('// Namespace: '):].strip()
            m = tdi.search(line.rstrip('\n'))
            if m:
                d = decl.search(line)
                rows.append((int(m.group(1)), ns, d.group(2) if d else None))
    # الأنواع المتداخلة تُطبع بفضاء أسماء فارغ واسمٍ «خارجيّ.داخليّ» ⇒ نحلّ الفضاء من الخارجيّ
    for _, n, nm in rows:
        if nm and '.' not in nm and n:
            root_ns.setdefault(nm, n)
    for t, n, nm in rows:
        if t > GAME_MAX_TDI or not nm:
            continue
        if n:
            out.add(f'{n}.{nm}')
        else:
            r = nm.split('.')[0]
            out.add(f'{root_ns[r]}.{nm}' if r in root_ns else nm)
    total = sum(1 for t, _, nm in rows if t <= GAME_MAX_TDI and nm)
    return out, total

def documented_addresses():
    """كل عنوان hex ذُكر في أي فصل من أي أرشيف."""
    pat = re.compile(r'0x([0-9A-Fa-f]{6,8})')
    hits = set()
    for spec in sorted(os.listdir(ROOT)):
        p = os.path.join(ROOT, spec)
        if not (spec.endswith('-spec') and os.path.isdir(p)):
            continue
        for r, _, fs in os.walk(p):
            for fn in fs:
                if not fn.endswith('.md'):
                    continue
                txt = io.open(os.path.join(r, fn), encoding='utf-8', errors='replace').read()
                for m in pat.finditer(txt):
                    a = int(m.group(1), 16)
                    if 0x400000 <= a <= 0x9500000:
                        hits.add(a)
    return hits

_strip = re.compile(r'<[^<>]*>')
def norm(s):
    """يجرّد وسائط الجينيريك تكرارًا حتى الاستقرار (وسائط متداخلة)."""
    prev = None
    while prev != s:
        prev, s = s, _strip.sub('', s)
    return s

def measure():
    GAME, ntypes = game_types()
    doc  = documented_addresses()
    d  = json.load(gzip.open(f'{ROOT}/il2cpp-dump/script.json.gz', 'rt', encoding='utf-8'))
    sm = sorted(d['ScriptMethod'], key=lambda m: m['Address'])
    ad = [m['Address'] for m in sm]
    size = lambda i: (ad[i + 1] - ad[i]) if i + 1 < len(ad) else 0

    raw = []                                        # (حجم، موثّق؟)
    uniq = {}                                       # اسم مُجرَّد → [أكبر حجم، موثّق؟، نسخ، طبقة]
    bands = [(0, 32), (32, 128), (128, 512), (512, 2048), (2048, 1 << 30)]
    band_lbl = ['≤32B وصول/كعب', '33–128B', '129–512B', '513B–2KB', '>2KB منطق ثقيل']
    per_band = [[0, 0, 0, 0] for _ in bands]        # دوالّ موثّقة، كلّها، بايتات موثّقة، كلّها
    gap_type = collections.Counter()

    for i, m in enumerate(sm):
        t = norm(m['Name'].split('$$')[0])
        if t not in GAME:
            continue
        s, isdoc = size(i), ad[i] in doc
        raw.append((s, isdoc))
        for bi, (lo, hi) in enumerate(bands):
            if lo <= s < hi:
                b = per_band[bi]; b[1] += 1; b[3] += s
                if isdoc: b[0] += 1; b[2] += s
                break
        k = norm(m['Name'])
        e = uniq.get(k)
        if e is None:
            uniq[k] = [s, isdoc, 1, t]
        else:
            e[0] = max(e[0], s); e[1] = e[1] or isdoc; e[2] += 1
        if not isdoc and s >= 512:
            gap_type[t] += s

    rb  = sum(s for s, _ in raw);          rdb = sum(s for s, x in raw if x)
    rn  = len(raw);                        rdn = sum(1 for _, x in raw if x)
    ub  = sum(v[0] for v in uniq.values()); udb = sum(v[0] for v in uniq.values() if v[1])
    un  = len(uniq);                       udn = sum(1 for v in uniq.values() if v[1])
    big = [v for v in uniq.values() if v[0] >= 256]
    bb  = sum(v[0] for v in big);          bdb = sum(v[0] for v in big if v[1])
    bn  = len(big);                        bdn = sum(1 for v in big if v[1])
    return dict(raw=(rdn, rn, rdb, rb), uniq=(udn, un, udb, ub), logic=(bdn, bn, bdb, bb),
                bands=list(zip(band_lbl, per_band)), gaps=gap_type.most_common(25),
                names=len(GAME), types=ntypes, docaddr=len(doc))

def pct(a, b): return 100.0 * a / b if b else 0.0

def report(r, md=False):
    L = []
    w = L.append
    if md:
        w('# تقرير التغطية — مُولَّد آليًّا')
        w('')
        w('> `python3 tools/coverage.py --md` · **لا تنقل هذه الأرقام إلى مكان آخر — أعِد توليدها.**')
        w('')
    w(f"أنواع كود اللعبة: **{r['types']:,}** (منها {r['names']:,} اسمًا فريدًا مطابَقًا في `script.json`)")
    w('')
    w(f"عناوين موثّقة في الأرشيف: **{r['docaddr']:,}**")
    w('')
    w('> حدّ القياس: المطابقة بالاسم الكامل، فالأنواع المتداخلة التي لا يُحلّ فضاء أسمائها'
      ' تُستبعَد من الطرفين (البسط والمقام) — الانحياز صغير ومتّجهٌ نحو **التقليل** لا المبالغة.')
    w('')
    w('| المقياس | دوالّ | % | بايتات | % |')
    w('|---|---|---|---|---|')
    for lbl, key in (('خام (كل نسخة جينيريكيّة)', 'raw'),
                     ('فريد (النسخ مدموجة)', 'uniq'),
                     ('**منطق حقيقيّ** (فريد ≥256B)', 'logic')):
        dn, n, db, b = r[key]
        w(f'| {lbl} | {dn:,}/{n:,} | {pct(dn,n):.1f}% | {db:,}/{b:,} | **{pct(db,b):.1f}%** |')
    w('')
    w('## التغطية بحسب حجم الدالّة')
    w('')
    w('كلّما كبرت الدالّة ارتفعت التغطية — أي أنّ ما بقي غير موثّق أكثره دوالّ وصول لا منطق.')
    w('')
    w('| النطاق | دوالّ | % | بايتات | % |')
    w('|---|---|---|---|---|')
    for lbl, (dn, n, db, b) in r['bands']:
        w(f'| {lbl} | {dn:,}/{n:,} | {pct(dn,n):.1f}% | {db:,}/{b:,} | **{pct(db,b):.1f}%** |')
    w('')
    w('## أكبر الفجوات (بايتات غير موثّقة في دوالّ ≥512B)')
    w('')
    w('⚠️ الأصناف الجينيريكيّة تظهر أكبر ممّا هي: نسخٌ كثيرة لمصدر واحد.')
    w('')
    w('| الصنف | غير موثّق |')
    w('|---|---|')
    for t, v in r['gaps']:
        w(f'| `{t}` | {v:,} |')
    return '\n'.join(L)

if __name__ == '__main__':
    r = measure()
    out = report(r, md='--md' in sys.argv)
    if '--md' in sys.argv:
        p = f'{ROOT}/tools/coverage-report.md'
        io.open(p, 'w', encoding='utf-8').write(out + '\n')
        print('wrote', p)
    else:
        print(out)
