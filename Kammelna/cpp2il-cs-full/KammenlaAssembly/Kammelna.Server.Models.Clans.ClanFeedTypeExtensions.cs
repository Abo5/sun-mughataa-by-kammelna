using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

public static class ClanFeedTypeExtensions
{
	public static Type GetFeedDataType(ClanFeedType feedType)
	{
		//IL_011c: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		object obj2 = 0;
		bool flag = feedType < ClanFeedType.MemberRankedTopLeaderboard;
		object obj3 = !flag;
		object obj4 = feedType - 14;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		if (obj6 == null)
		{
			object obj7 = 119877632 + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X10_v2+feedType @ X0 (Kammelna.Server.Models.Clans.ClanFeedType)]");
			object obj8 = (nint)86495008 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X11_v2 (should have been resolved before IL gen)");
		}
		RuntimeTypeHandle handle;
		if (feedType == ClanFeedType.ClanUpgradedCallToAction)
		{
			object obj9 = 147423232 + 2008;
			handle = (RuntimeTypeHandle)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				goto IL_00a0;
			}
		}
		else
		{
			object obj11 = 147423232 + 1944;
			handle = (RuntimeTypeHandle)obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				goto IL_00a0;
			}
		}
		goto IL_00af;
		IL_00a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00af;
		IL_00af:
		return Type.GetTypeFromHandle(handle);
	}
}
