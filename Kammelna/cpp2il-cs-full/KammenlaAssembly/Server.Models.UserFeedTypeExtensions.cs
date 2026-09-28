using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;

namespace Server.Models;

public static class UserFeedTypeExtensions
{
	public static Type GetFeedDataType(UserFeedType feedType)
	{
		//IL_00ad: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_00e5: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v4+E0]");
		object obj2 = 0;
		bool flag = feedType < UserFeedType.ClanJoined;
		object obj3 = !flag;
		object obj4 = feedType - 28;
		bool flag2 = obj4 == null;
		object obj5 = !flag2;
		object obj6 = obj3 & obj5;
		object handle = default(object);
		if (obj6 == null)
		{
			object obj7 = 119877632 + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X10_v2+feedType @ X0 (Server.Models.UserFeedType)]");
			object obj8 = (nint)85521664 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X11_v2 (should have been resolved before IL gen)");
		}
		else
		{
			handle = typeof(SqlDouble) + 976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_0043;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0043;
		IL_0043:
		return Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
	}
}
