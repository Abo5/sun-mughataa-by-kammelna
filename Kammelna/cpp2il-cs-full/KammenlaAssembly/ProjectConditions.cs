using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

public struct ProjectConditions
{
	private readonly ProjectType <Type>k__BackingField;

	private readonly Rank <MaxRank>k__BackingField;

	private readonly Rank <MinRank>k__BackingField;

	private readonly int <Size>k__BackingField;

	public ProjectType Type => <Type>k__BackingField;

	public Rank MaxRank => <MaxRank>k__BackingField;

	public Rank MinRank => <MinRank>k__BackingField;

	public int Size => <Size>k__BackingField;

	public ProjectConditions(ProjectType type, Rank maxRank, Rank minRank, int size)
	{
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		//IL_0038: Expected O, but got I
		//IL_02bd: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_007a: Expected O, but got I
		//IL_009a: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		bool flag = size < 2;
		ProjectType projectType = type;
		Type typeFromHandle;
		string[] array;
		ProjectType projectType2;
		if (!flag)
		{
			object handle = typeof(IAsyncEnumerable<>) + 2832;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X25_v3+E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v16+E4]");
			Type enumType;
			if ((nint)0 != 0)
			{
				typeFromHandle = System.Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X25_v3+98]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = 0;
				enumType = typeFromHandle;
				if (!flag2)
				{
					goto IL_00b0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				typeFromHandle = System.Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X25_v3+98]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+E4]");
				object obj5 = (nint)0 != 0;
				object obj4 = 0;
				enumType = typeFromHandle;
				if (obj5 != null)
				{
					goto IL_00b0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			string[] names = Enum.GetNames(enumType);
			object obj6 = names != null;
			projectType = ProjectType.RankSequence;
			array = names;
			projectType2 = ProjectType.RankSequence;
			if (obj6 != null)
			{
				goto IL_00ec;
			}
			goto IL_0246;
		}
		goto IL_0259;
		IL_00b0:
		array = Enum.GetNames(typeFromHandle);
		bool flag3 = array == null;
		projectType = ProjectType.RankSequence;
		projectType2 = ProjectType.RankSequence;
		if (!flag3)
		{
			goto IL_00ec;
		}
		goto IL_0246;
		IL_0259:
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = "setMimeType" + 2664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName);
		object obj9 = (nint)0 + (nint)3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_00ec:
		if (size <= array.Length && (type != ProjectType.SuitsGroup || (object)(size >= 5) == null))
		{
			<Type>k__BackingField = type;
			<MaxRank>k__BackingField = maxRank;
			<MinRank>k__BackingField = minRank;
			<Size>k__BackingField = size;
			return;
		}
		goto IL_0259;
		IL_0246:
		projectType = projectType2;
		throw new NullReferenceException();
	}

	public ProjectConditions(ProjectType type, Rank rank, int size)
		: this(type, rank, rank, size)
	{
	}
}
