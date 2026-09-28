using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Properties;

internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	private struct MonoScriptData
	{
		public byte[] FilePathsData;

		public byte[] TypesData;

		public int TotalTypes;

		public int TotalFiles;

		public bool IsEditorOnly;
	}

	[MethodImpl((MethodImplOptions)256)]
	private unsafe static MonoScriptData Get()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_005b: Expected O, but got Ref
		//IL_006d: Expected native int or pointer, but got O
		//IL_007b: Expected native int or pointer, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 1880;
		object fldHandle = (nint)0 + (nint)2456;
		object fldHandle2 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array2 = default(Array);
		RuntimeHelpers.InitializeArray(array2, (RuntimeFieldHandle)fldHandle2);
		byte[] filePathsData = default(byte[]);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref filePathsData, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		MonoScriptData monoScriptData = default(MonoScriptData);
		System.Runtime.CompilerServices.Unsafe.Write(&((MonoScriptData*)(nint)monoScriptData)->FilePathsData, filePathsData);
		((MonoScriptData*)(nint)monoScriptData)->TotalTypes = 2;
		MonoScriptData result = default(MonoScriptData);
		return result;
	}
}
