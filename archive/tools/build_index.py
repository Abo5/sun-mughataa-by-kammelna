import os, re, json, bisect, io, collections, gzip
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))   # archive/
REPO = os.path.dirname(ROOT)                                          # repo root
d=json.load(gzip.open(f"{REPO}/source-code/il2cpp-dump/script.json.gz", 'rt', encoding='utf-8'))
sm=sorted(d['ScriptMethod'], key=lambda m:m['Address'])
addrs=[m['Address'] for m in sm]
exact={m['Address']:m['Name'] for m in sm}
def owner(a):
    i=bisect.bisect_right(addrs,a)-1
    if i<0: return None,None
    base=sm[i]['Address']; nxt=addrs[i+1] if i+1<len(addrs) else base
    return (sm[i]['Name'], base) if base<=a<nxt else (None,None)

PAT=re.compile(r'0x([0-9A-Fa-f]{6,8})')
hits=collections.defaultdict(set)   # addr -> {(spec, file)}
for spec in sorted(os.listdir(ROOT)):
    p=os.path.join(ROOT,spec)
    if not (spec.endswith('-spec') and os.path.isdir(p)): continue
    for r,_,fs in os.walk(p):
        for fn in fs:
            if not fn.endswith('.md'): continue
            rel=os.path.relpath(os.path.join(r,fn), ROOT)
            try: txt=io.open(os.path.join(r,fn),encoding='utf-8').read()
            except Exception: continue
            for m in PAT.finditer(txt):
                a=int(m.group(1),16)
                if 0x400000 <= a <= 0x9500000:
                    hits[a].add((spec,rel))

rows=[]
for a in sorted(hits):
    nm = exact.get(a)
    kind="method"
    if nm is None:
        o,base = owner(a)
        if o: nm, kind = o, f"inside (+0x{a-base:X})"
        else: nm, kind = "—", "data/other"
    rows.append((a,nm,kind,sorted(hits[a])))

meth=sum(1 for r in rows if r[2]=="method")
ins =sum(1 for r in rows if r[2].startswith("inside"))
oth =sum(1 for r in rows if r[2]=="data/other")
print(f"total unique addresses: {len(rows)}   exact-method: {meth}   inside-method: {ins}   data/other: {oth}")
per=collections.Counter()
for a,nm,k,locs in rows:
    for s,_ in locs: per[s]+=1
print("per archive:", dict(per))
json.dump([(a,nm,k,locs) for a,nm,k,locs in rows], open(f"{ROOT}/gidx.json","w"), ensure_ascii=False)

# ---------------------------------------------------------- write INDEX file
NAMES = {'baloot-spec':'بلوت','jackaroo-spec':'جكارو','tarneeb-spec':'طرنيب','lobby-spec':'ردهة',
 'economy-spec':'اقتصاد','social-spec':'اجتماعي','config-spec':'إعدادات','identity-spec':'هوية',
 'auth-spec':'مصادقة','leaderboards-spec':'صدارة','modes-spec':'أنماط','predictions-spec':'توقّعات',
 'notifications-spec':'إشعارات','data-spec':'بيانات','ads-spec':'إعلانات','cosmetics-spec':'تجميليات',
 'voice-spec':'صوتيّة','prefs-spec':'تفضيلات','l10n-spec':'تعريب','ui-spec':'واجهة',
 'replay-spec':'إعادة','sound-spec':'صوت'}
def ar(n):  # arabic-indic digits for the prose counts only
    return str(n).translate(str.maketrans('0123456789','٠١٢٣٤٥٦٧٨٩'))

out = [io.open('/tmp/idx_head.txt', encoding='utf-8').read().rstrip('\n')]
# rebuild stats block in place of the old one
head = out[0].split('## الإحصاء')[0].rstrip('\n')
stats = ['## الإحصاء','','| البند | العدد |','|---|---|',
 f'| عناوين فريدة موثّقة | **{len(rows)}** |',
 f'| منها نقاط دخول دوالّ مطابقة | **{meth}** |',
 f'| مواضع داخل دوالّ | {ins} |',
 f'| جداول/بيانات | {oth} |','',
 '| الأرشيف | عناوين |','|---|---|']
for s,c in per.most_common():
    stats.append(f'| [{NAMES.get(s,s)}]({s}/README.md) | {c} |')
stats += ['','## الجدول','','| العنوان | الدالّة | النوع | موثَّق في |','|---|---|---|---|']
body = []
for a,nm,k,locs in rows:
    l = ' · '.join(f'[{NAMES.get(s,s)}]({rel})' for s,rel in locs)
    body.append(f'| `0x{a:07X}` | `{nm.replace("$$","::")}` | {k} | {l} |')
foot = io.open('/tmp/idx_foot.txt', encoding='utf-8').read().rstrip('\n')
io.open(f'{ROOT}/INDEX-العناوين.md','w',encoding='utf-8').write(
    head + '\n\n' + '\n'.join(stats) + '\n' + '\n'.join(body) + '\n\n' + foot + '\n')
print('wrote INDEX-العناوين.md:', len(body), 'rows')
