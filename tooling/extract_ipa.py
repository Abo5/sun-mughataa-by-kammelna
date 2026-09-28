#!/usr/bin/env python3
# استخراج كامل ملف IPA مع الحفاظ على الأسماء العربية (UTF-8)
import zipfile, os, sys

IPA = "/Users/qppn/Downloads/ipa-1h37p27m.ipa"
REPO = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))   # repo root
DEST = os.path.join(REPO, "extracted")

os.makedirs(DEST, exist_ok=True)

z = zipfile.ZipFile(IPA)
total = len(z.infolist())
count = 0
errors = []
for info in z.infolist():
    # sanitize: strip any path traversal
    name = info.filename
    # avoid absolute paths / ..
    safe = name.replace("\\", "/").lstrip("/")
    if safe.startswith("..") or os.path.isabs(safe):
        errors.append(name)
        continue
    target = os.path.join(DEST, safe)
    if info.is_dir():
        os.makedirs(target, exist_ok=True)
        continue
    os.makedirs(os.path.dirname(target), exist_ok=True)
    with z.open(info) as src, open(target, "wb") as dst:
        dst.write(src.read())
    count += 1

print(f"extracted {count}/{total} files to {DEST}")
if errors:
    print("skipped:", errors)
