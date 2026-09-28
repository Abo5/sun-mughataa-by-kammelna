using System;
using Cpp2ILInjected;
using UnityEngine.Purchasing.Telemetry;

namespace Util.Extensions;

public static class TimeSpanExtension
{
	public static bool IsBetween(TimeSpan timeSpan, TimeSpan start, TimeSpan end)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_018a: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected I4, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8731]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		object obj6 = 0;
		bool flag2 = start > end;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		object obj8 = 0;
		if (flag2)
		{
			goto IL_00c3;
		}
		goto IL_0198;
		IL_00c3:
		if (obj6 != null)
		{
			if (start <= timeSpan)
			{
				goto IL_01fc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (start <= timeSpan)
			{
				goto IL_01fc;
			}
		}
		goto IL_0231;
		IL_022b:
		return false;
		IL_01fc:
		return true;
		IL_0074:
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		obj6 = 0;
		bool flag3 = start <= end;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		obj8 = 0;
		if (!flag3)
		{
			goto IL_00c3;
		}
		goto IL_0198;
		IL_0198:
		if (obj8 != null)
		{
			if (start > timeSpan)
			{
				goto IL_022b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (start > timeSpan)
			{
				goto IL_022b;
			}
		}
		goto IL_0231;
		IL_0231:
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = end - timeSpan;
		bool flag5 = (nint)obj11 < 0;
		bool flag6 = obj11 == null;
		object obj12 = (object)end ^ (object)timeSpan;
		object obj13 = (object)end ^ obj11;
		object obj14 = obj12 & obj13;
		bool flag7 = (nint)obj14 < 0;
		bool flag8 = flag5 == flag7;
		object obj15 = !flag6;
		return (byte)((flag8 & obj15) ? 1 : 0) != 0;
	}
}
