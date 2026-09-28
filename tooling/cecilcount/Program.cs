using System;
using System.Linq;
using Mono.Cecil;

class P
{
    static int total = 0;

    static void Count(TypeDefinition t)
    {
        total++;
        foreach (var n in t.NestedTypes) Count(n);
    }

    static void Main(string[] args)
    {
        var asm = AssemblyDefinition.ReadAssembly(args[0]);
        foreach (var t in asm.MainModule.Types) Count(t);
        Console.WriteLine("assembly=" + asm.Name.Name);
        Console.WriteLine("total_types=" + total);
        var groups = asm.MainModule.Types
            .GroupBy(t => string.IsNullOrEmpty(t.Namespace) ? "(global)" : t.Namespace)
            .OrderByDescending(g => g.Count())
            .Take(50);
        foreach (var g in groups)
            Console.WriteLine(g.Count() + "\t" + g.Key);
    }
}
