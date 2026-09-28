using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;

public static class ClanModelExtensions
{
	public static bool IsFull(ClanModel clan)
	{
		//IL_0017: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected I4, but got Unknown
		bool flag = clan == null;
		bool result = (byte)(int)clan != 0;
		if (!flag)
		{
			if (clan.MaxPlayers < 1)
			{
				return false;
			}
			object obj = clan.ParticipantCount - clan.MaxPlayers;
			bool flag2 = (nint)obj < 0;
			int num = clan.ParticipantCount ^ clan.MaxPlayers;
			int num2 = clan.ParticipantCount ^ obj;
			int num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag2 == flag3;
			result = flag4;
		}
		return result;
	}

	public static int AvailableSlots(ClanModel clan)
	{
		//IL_0056: Expected O, but got I4
		//IL_006c: Expected I4, but got O
		if (clan != null && clan.MaxPlayers >= 1)
		{
			object obj = clan.MaxPlayers - clan.ParticipantCount;
			object obj2 = ~obj;
			return obj & obj2;
		}
		return 2147483647;
	}

	public static bool IsOwnedBy(ClanModel clan, int userId)
	{
		//IL_0017: Expected I4, but got O
		//IL_0066: Expected O, but got I4
		bool flag = clan == null;
		bool result = (byte)(int)clan != 0;
		if (!flag)
		{
			ClanUserModel owner = clan.Owner;
			if (clan.Owner != null)
			{
				object obj = owner.UserId - userId;
				return obj == null;
			}
			result = false;
		}
		return result;
	}

	public static bool IsOwnedByMe(ClanModel clan)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017c: Expected I4, but got O
		//IL_01b4: Expected O, but got I4
		//IL_02a5: Expected I4, but got O
		//IL_0275: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E893F]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_0297;
		IL_02a5:
		bool result;
		return result;
		IL_0297:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0158:
		User localUser = sessionModel.LocalUser;
		bool flag4 = localUser == null;
		result = (byte)(int)localUser != 0;
		if (!flag4)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				User localUser2 = sessionModel2.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
				if (clan != null)
				{
					ClanUserModel owner = clan.Owner;
					if (clan.Owner != null)
					{
						object obj10 = owner.UserId - intDbId;
						bool flag6 = obj10 == null;
						result = flag6;
						goto IL_02a5;
					}
				}
				return false;
			}
			goto IL_0297;
		}
		goto IL_02a5;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj11 = !flag7;
		if (obj11 != null)
		{
			goto IL_0158;
		}
		goto IL_0297;
	}

	public static ClanUserModel GetMyMembership(ClanModel clan)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8940]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_0244;
		IL_0244:
		return (ClanUserModel)(object)new NullReferenceException();
		IL_0158:
		User localUser = sessionModel.LocalUser;
		if (clan != null && localUser != null)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				User localUser2 = sessionModel2.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
				return clan.GetClanMemberByDbid(intDbId);
			}
			goto IL_0244;
		}
		return null;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			goto IL_0158;
		}
		goto IL_0244;
	}

	public static bool ContainsMe(ClanModel clan)
	{
		//IL_0024: Expected I4, but got O
		//IL_0045: Expected O, but got I4
		ClanUserModel myMembership = GetMyMembership(clan);
		bool flag = myMembership == null;
		bool result = (byte)(int)myMembership != 0;
		if (!flag)
		{
			object obj = myMembership.Status - 1;
			bool flag2 = obj == null;
			result = flag2;
		}
		return result;
	}

	public static bool MemberCan(ClanModel clan, int userId, ClanPermissions required)
	{
		//IL_0017: Expected I4, but got O
		//IL_004d: Expected I4, but got O
		//IL_0099: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		bool flag = clan == null;
		bool result = (byte)(int)clan != 0;
		if (!flag)
		{
			ClanUserModel clanMemberByDbid = clan.GetClanMemberByDbid(userId);
			bool flag2 = clanMemberByDbid == null;
			result = (byte)(int)clanMemberByDbid != 0;
			if (!flag2)
			{
				if (clanMemberByDbid.IsOwner)
				{
					result = true;
				}
				else
				{
					object obj = ~clanMemberByDbid.Permissions;
					object obj2 = required & obj;
					bool flag3 = obj2 == null;
					result = flag3;
				}
			}
		}
		return result;
	}
}
