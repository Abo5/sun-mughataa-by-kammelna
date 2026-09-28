using System;
using System.IO;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;

class Program
{
    static int ok = 0, skip = 0;

    static void DecompileOne(string dll, string outRoot, string refDir)
    {
        string asmName = Path.GetFileNameWithoutExtension(dll);
        string outDir = Path.Combine(outRoot, asmName);
        Directory.CreateDirectory(outDir);

        var resolver = new UniversalAssemblyResolver(dll, false, null);
        resolver.AddSearchDirectory(refDir);
        resolver.AddSearchDirectory(Path.GetDirectoryName(dll));

        var settings = new ICSharpCode.Decompiler.DecompilerSettings();
        var dec = new CSharpDecompiler(dll, resolver, settings);

        foreach (var t in dec.TypeSystem.MainModule.TypeDefinitions)
        {
            string name = t.FullName;
            if (string.IsNullOrEmpty(name))
                continue;
            string rel = name.Replace('+', '.').Replace('/', '.');
            foreach (var c in Path.GetInvalidFileNameChars())
                rel = rel.Replace(c, '_');
            if (rel.Length > 220)
                rel = rel.Substring(0, 220);
            string file = Path.Combine(outDir, rel + ".cs");
            try
            {
                string code = dec.DecompileTypeAsString(t.FullTypeName);
                Directory.CreateDirectory(Path.GetDirectoryName(file));
                File.WriteAllText(file, code);
                ok++;
            }
            catch (Exception)
            {
                skip++;
            }
        }
    }

    static void Main(string[] args)
    {
        string inDir = args[0];
        string outRoot = args[1];
        string refDir = args.Length > 2 ? args[2] : inDir;
        Directory.CreateDirectory(outRoot);
        string[] dlls = Directory.GetFiles(inDir, "*.dll");
        Console.WriteLine("decompiling " + dlls.Length + " assemblies (refs: " + refDir + ")...");
        foreach (var dll in dlls)
        {
            try { DecompileOne(dll, outRoot, refDir); }
            catch (Exception e) { Console.WriteLine("FAIL " + Path.GetFileName(dll) + " : " + e.Message); }
        }
        Console.WriteLine("done. OK=" + ok + " SKIP=" + skip);
    }
}
