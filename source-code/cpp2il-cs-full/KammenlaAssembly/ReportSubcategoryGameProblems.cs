using System;
using System.ComponentModel;
using Cpp2ILInjected;
using ReportEnums;

public class ReportSubcategoryGameProblems : BaseDropMenu<GameProblems>
{
	protected override string ItemName(GameProblems item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public ReportSubcategoryGameProblems()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E2356C");
	}
}
