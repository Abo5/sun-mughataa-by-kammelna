using System;
using System.Data;
using Cpp2ILInjected;
using Util;

[Serializable]
public class DayOfWeekTimeFormat : DateTimeFormat
{
	private readonly bool <IsCountDown>k__BackingField;

	public override bool IsCountDown => <IsCountDown>k__BackingField;

	protected override string FormatDate(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		object obj = typeof(DataRelation) + 824;
		object separator = "{0} color encoding is currently unsupported for outputting to HDR." + 2176;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return DateTimeUtil.GetDayOfWeekTimeFormat(dateTime, (string)separator);
	}
}
