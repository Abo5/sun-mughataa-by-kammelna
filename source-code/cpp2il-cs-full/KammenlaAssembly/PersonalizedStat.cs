using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

[Serializable]
public class PersonalizedStat
{
	public PerformanceReportType Metric;

	public int Value;

	public int PreviousValue;

	public int ValueDifference()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Math.Max(PreviousValue, 0);
		return Value - num;
	}
}
