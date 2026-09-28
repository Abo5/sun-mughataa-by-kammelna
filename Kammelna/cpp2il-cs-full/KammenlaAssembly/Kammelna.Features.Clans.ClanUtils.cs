using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;

namespace Kammelna.Features.Clans;

public static class ClanUtils
{
	public static string GetClanChatTag(int clanId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4008;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	public static bool IsClanChatTag(string tag)
	{
		//IL_003d: Expected I4, but got O
		//IL_0034: Expected I4, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if ((int)(~tag) == 0)
		{
			object value = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3472;
			return tag.StartsWith((string)value, StringComparison.Ordinal);
		}
		return (byte)(int)tag != 0;
	}

	public static bool IsMe(ClanUserModel user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_018c: Expected I4, but got O
		//IL_00b3: Expected I4, but got O
		//IL_00eb: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		if (user != null)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj5 = default(object);
			if (obj5 != null)
			{
				User mySelf = SFS.MySelf;
				bool flag2 = mySelf == null;
				bool result = (byte)(int)mySelf != 0;
				if (!flag2)
				{
					object obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					object obj8 = default(object);
					if (obj8 == null)
					{
						goto IL_017e;
					}
					User mySelf2 = SFS.MySelf;
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf2);
					object obj9 = user.UserId - intDbId;
					bool flag4 = obj9 == null;
					result = flag4;
				}
				return result;
			}
			goto IL_017e;
		}
		return false;
		IL_017e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool MatchesSearch(ClanUserModel user, string query)
	{
		//IL_00f4: Expected I4, but got O
		if (string.IsNullOrWhiteSpace(query))
		{
			return true;
		}
		bool flag = user == null;
		ClanUserModel clanUserModel = user;
		if (!flag)
		{
			clanUserModel = (ClanUserModel)(object)user.Name;
		}
		if (string.IsNullOrEmpty((string)(object)clanUserModel))
		{
			return false;
		}
		if (query != null)
		{
			string value = query.Trim();
			if (clanUserModel != null)
			{
				int num = ((string)(object)clanUserModel).IndexOf(value, StringComparison.OrdinalIgnoreCase);
				int num2 = ~num;
				return (byte)(num2 >> 31) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
