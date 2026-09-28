# -*- coding: utf-8 -*-
# Headless Ghidra script: apply Il2CppDumper names/strings/functions to a Unity IL2CPP binary.
# Usage: apply_names.py <script.json>
import json
import sys

from ghidra.app.util.cparser.C import CParserUtils
from ghidra.app.cmd.function import ApplyFunctionSignatureCmd

args = getScriptArgs()
if len(args) < 1:
    print("Usage: apply_names.py <script.json> [apply_signatures=1]")
    sys.exit(1)

script_json = args[0]
apply_sigs = len(args) > 1 and args[1] == "1"

fm = currentProgram.getFunctionManager()
base = currentProgram.getImageBase()
UD = ghidra.program.model.symbol.SourceType.USER_DEFINED


def a(off):
    return base.add(off)


def sanitize(name):
    return name.replace(' ', '-')


def set_name(a, name):
    nm = sanitize(name)
    if not nm:
        return
    try:
        createLabel(a, nm, True, UD)
    except Exception:
        pass
    f = getFunctionAt(a)
    if f is not None:
        try:
            f.setName(nm, UD)
        except Exception:
            pass


def make_function(start):
    if getFunctionAt(start) is None:
        try:
            createFunction(start, None)
        except Exception:
            pass


print("Loading %s ..." % script_json)
data = json.loads(open(script_json, 'rb').read().decode('utf-8'))

sm = data.get("ScriptMethod", [])
monitor.initialize(len(sm))
monitor.setMessage("Naming methods")
for m in sm:
    set_name(a(m["Address"]), m["Name"])
    monitor.incrementProgress(1)

ss = data.get("ScriptString", [])
monitor.initialize(len(ss))
monitor.setMessage("Labeling strings")
i = 1
for s in ss:
    addr = a(s["Address"])
    try:
        createLabel(addr, "StringLiteral_%d" % i, True, UD)
        setEOLComment(addr, s["Value"])
    except Exception:
        pass
    i += 1
    monitor.incrementProgress(1)

md = data.get("ScriptMetadata", [])
monitor.initialize(len(md))
monitor.setMessage("Metadata")
for m in md:
    addr = a(m["Address"])
    try:
        createLabel(addr, sanitize(m["Name"]), True, UD)
        setEOLComment(addr, m["Name"])
    except Exception:
        pass
    monitor.incrementProgress(1)

addrs = data.get("Addresses", [])
monitor.initialize(len(addrs))
monitor.setMessage("Creating functions")
for off in addrs:
    make_function(a(off))
    monitor.incrementProgress(1)

if apply_sigs:
    monitor.initialize(len(sm))
    monitor.setMessage("Applying signatures")
    for m in sm:
        sig = m.get("Signature")
        if sig:
            sig = sig[:-1] if sig.endswith(';') else sig
            addr = a(m["Address"])
            try:
                ts = CParserUtils.parseSignature(None, currentProgram, sig, False)
            except Exception:
                ts = None
            if ts is not None:
                try:
                    ts.setName("sub_" + str(m["Address"]))
                    ApplyFunctionSignatureCmd(addr, ts, UD, False, True).applyTo(currentProgram)
                except Exception:
                    pass
        monitor.incrementProgress(1)

print("apply_names.py finished")
