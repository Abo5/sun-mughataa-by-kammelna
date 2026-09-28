"""حلّ مراجع الأصول المُسلسَلة في حزم Addressables إلى أسماء ملفّاتها الأصليّة.

المشكلة: `m_FileID` في أي مرجع مُسلسَل هو فهرس ١-أساس في جدول `externals` للملفّ
المسلسل، وكل مدخل فيه `archive:/CAB-<هاش>/…` — لا مسار أصل. واسم الحزمة على القرص
يحمل مسار الأصل، فيكفي ربط `CAB → حزمة` لتُقرأ الشجرة كلّها.

    m_FileID == 0   ⇒ الأصل داخل الحزمة نفسها (استعمل m_PathID محليًّا)
    m_FileID >= 1   ⇒ externals[m_FileID - 1] ⇒ CAB ⇒ حزمة ⇒ مسار الأصل

مُتحقَّق عليه: الألبومات الستّة في `sound-spec/01 §٧ب` (٥٤ مسارًا).
يتطلّب: /opt/homebrew/bin/python3 (فيه UnityPy).
"""
import os, re, glob, functools
import UnityPy

UnityPy.config.FALLBACK_UNITY_VERSION = "6000.3.8f1"
ROOT = os.path.join(os.path.dirname(os.path.abspath(__file__)), '..')
BUNDLES = os.path.join(ROOT, 'extracted/Payload/كملنا.app/Data/Raw/aa/iOS')
_CAB = re.compile(rb'CAB-[0-9a-f]{32}')


@functools.lru_cache(maxsize=1)
def cab_map():
    """{'CAB-<هاش>': 'اسم الحزمة'} — يُقرأ من أوّل 4 ك.ب من كل حزمة، أقلّ من ثانية."""
    out = {}
    for p in glob.glob(os.path.join(BUNDLES, '*.bundle')):
        with open(p, 'rb') as f:
            head = f.read(4096)
        for m in _CAB.finditer(head):
            out.setdefault(m.group().decode(), os.path.basename(p))
    return out


def asset_path(bundle_name):
    """اسم الحزمة ⇒ مسار الأصل المقروء (تُحذف بادئة المجموعة ولاحقة الهاش)."""
    b = re.sub(r'_[0-9a-f]{32}\.bundle$', '', bundle_name)
    return re.sub(r'^(duplicateassetisolation_assets_assets_|[a-z]+_assets_)', '', b)


def open_bundle(bundle_name):
    """-> (env, externals) حيث externals قائمة معرّفات CAB بترتيب m_FileID."""
    env = UnityPy.load(os.path.join(BUNDLES, bundle_name))
    sf = list(list(env.files.values())[0].files.values())[0]
    ext = [_CAB.search(e.path.encode()).group().decode() for e in sf.externals]
    return env, ext


def resolve(ref, externals, cab=None):
    """مرجع {m_FileID, m_PathID} ⇒ مسار الأصل، أو None إن كان داخليًّا."""
    fid = ref.get('m_FileID', 0)
    if not fid:
        return None                      # داخل الحزمة نفسها
    if not 1 <= fid <= len(externals):
        return '?'
    return asset_path((cab or cab_map()).get(externals[fid - 1], '?'))


if __name__ == '__main__':
    import sys
    bn = sys.argv[1] if len(sys.argv) > 1 else (
        'duplicateassetisolation_assets_assets_scripts_managers_sounds'
        '_soundalbum_albums_gamesounds_gamesoundalbum.asset'
        '_3598a62f64f0ca8b993cb6aadc5aa236.bundle')
    env, ext = open_bundle(bn)
    cab = cab_map()
    print(f'{len(cab)} CAB entries; {len(ext)} externals in {asset_path(bn)}')
    for o in env.objects:
        if o.type.name != 'MonoBehaviour':
            continue
        t = o.read_typetree()
        print('--', t.get('m_Name') or '(unnamed)')
        for k, v in t.items():
            if isinstance(v, dict) and 'm_FileID' in v and k != 'm_Script':
                print(f'   {k:22} -> {resolve(v, ext, cab)}')
            elif isinstance(v, list) and v and isinstance(v[0], dict):
                for e in v:
                    for kk, vv in e.items():
                        if isinstance(vv, dict) and 'm_FileID' in vv:
                            print(f'   {k}[{list(e.values())[0]}].{kk} -> {resolve(vv, ext, cab)}')
