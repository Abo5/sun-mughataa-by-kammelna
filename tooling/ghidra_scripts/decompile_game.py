# -*- coding: utf-8 -*-
# Headless Ghidra script: decompile game methods (from script.json) to C.
# Usage: decompile_game.py <script.json> <output.c> [max_count]
import json
import sys

from ghidra.app.decompiler import DecompInterface
from ghidra.util.task import ConsoleTaskMonitor

args = getScriptArgs()
if len(args) < 2:
    print("Usage: decompile_game.py <script.json> <output.c> [max_count]")
    sys.exit(1)

script_json = args[0]
outfile = args[1]
maxcount = int(args[2]) if len(args) > 2 else 0

data = json.loads(open(script_json, 'rb').read().decode('utf-8'))
sm = data.get("ScriptMethod", [])
base = currentProgram.getImageBase()
fm = currentProgram.getFunctionManager()

decomp = DecompInterface()
decomp.openProgram(currentProgram)
mon = ConsoleTaskMonitor()

count = 0
with open(outfile, 'w') as fh:
    for m in sm:
        func = fm.getFunctionAt(base.add(m["Address"]))
        if func is None:
            continue
        res = decomp.decompileFunction(func, 30, mon)
        if res is not None and res.decompileCompleted():
            c = res.getDecompiledFunction().getC()
            fh.write("// ===== %s @ %s =====\n" % (m["Name"], func.getEntryPoint()))
            fh.write(c)
            fh.write("\n\n")
        count += 1
        if maxcount and count >= maxcount:
            break

print("decompile_game.py: decompiled %d functions -> %s" % (count, outfile))
