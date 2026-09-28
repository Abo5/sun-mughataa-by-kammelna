import struct, collections, os
ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))   # archive/
REPO = os.path.dirname(ROOT)                                          # repo root
P = os.path.join(REPO, 'extracted/Payload/كملنا.app/Data/Raw/aa/catalog.bin')
d=open(P,'rb').read(); N=len(d)
def u(p): return struct.unpack_from('<I',d,p)[0] if 0<=p<=N-4 else None
MASK=0x0FFFFFFF
def lp_str(sp):
    "length-prefixed string: u32 len at sp, body at sp+4"
    n=u(sp)
    if n is None or not(0<n<2048) or sp+4+n>N: return None
    try: return d[sp+4:sp+4+n].decode('utf-8')
    except: return None
def dyn_str(ref, depth=0):
    """object at M(ref): +0 parent, +4 sep?, +8 len, +0xc body.
       tag 0x40000000 => segmented: value = dyn(parent) + sep + body"""
    if depth>12: return None
    p=ref & MASK
    s=lp_str(p+8)
    if s is None: return None
    par=u(p)
    if (ref & 0x40000000) and par is not None and (par & MASK)!=p:
        head=dyn_str(par, depth+1)
        if head: return head+s
    return s
KEYS=[(u(0x24+8*i), u(0x28+8*i)) for i in range(2505)]
def key_name(K,A):
    sp = K+12+u(K+8) if K+12==A else K+8
    return lp_str(sp)
def dep_list(A):
    n=u(A-4)
    if n is None or n%4 or n>8192 or A+n>N: return []
    return [u(A+4*i) for i in range(n//4)]
def loc(L):
    L&=MASK
    f=[u(L+4*i) for i in range(8)]
    return dict(internalId=f[0], provider=f[2], deps=f[3], type=f[5], primaryKey=f[6])

# ---------------------------------------------------------------- resolve + map
def body_at(p):
    n = u(p - 4)
    if n is None or not (0 < n < 2048) or p + n > N: return None
    try: return d[p:p + n].decode('utf-8')
    except UnicodeDecodeError: return None

def text(ref):
    "InternalId / key text: body-at-ref first, then object form (+8 len, +0xc body)"
    if ref is None or ref == 0xFFFFFFFF: return None
    p = ref & MASK
    return body_at(p) or lp_str(p + 8)

def build():
    """-> (guid2bundle, bundles, labels). Validated: 85/85 GameComponentsStore GUIDs."""
    guids, bundles, labels = {}, {}, {}
    for K, A in KEYS:
        nm = key_name(K, A)
        if not nm: continue
        ls = dep_list(A)
        if nm.endswith('.bundle'):
            bundles[nm] = ls
        elif len(nm) == 32 and all(c in '0123456789abcdef' for c in nm):
            out = []
            for l in ls:
                L = loc(l)
                if L['deps'] in (None, 0xFFFFFFFF): continue
                for dref in dep_list(L['deps'] & MASK):
                    b = text(loc(dref)['internalId'])
                    if b and b not in out: out.append(b)
            if out: guids[nm] = out
        else:
            labels[nm] = ls
    return guids, bundles, labels

if __name__ == '__main__':
    import json, sys
    g, b, l = build()
    print('keys %d | guids mapped %d | bundles %d | labels %d'
          % (len(KEYS), len(g), len(b), len(l)), file=sys.stderr)
    json.dump({k: v[0] for k, v in g.items()}, open('guid2bundle.json', 'w'),
              indent=0, sort_keys=True)   # الحزمة الأساسيّة لكل معرّف
