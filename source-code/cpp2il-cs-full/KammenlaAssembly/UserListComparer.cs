using System;
using System.ComponentModel;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Server.Models;
using Sfs2X.Entities;

public static class UserListComparer
{
	private static int UsersComparator(PlayerInfo user1, PlayerInfo user2)
	{
		//IL_011a: Expected I4, but got O
		if (user1 != null)
		{
			bool hasAvatar = user1.HasAvatar();
			float socialScore = GetSocialScore(user1.<DBID>k__BackingField, hasAvatar, user1.<ActiveGameTitle>k__BackingField, user1.<ActiveCardBack>k__BackingField, user1.<IsModerator>k__BackingField, user1.<IsSubscribed>k__BackingField, user1.<PlayerRank>k__BackingField, user1.<IsVerified>k__BackingField);
			if (user2 != null)
			{
				bool hasAvatar2 = user2.HasAvatar();
				float socialScore2 = GetSocialScore(user2.<DBID>k__BackingField, hasAvatar2, user2.<ActiveGameTitle>k__BackingField, user2.<ActiveCardBack>k__BackingField, user2.<IsModerator>k__BackingField, user2.<IsSubscribed>k__BackingField, user2.<PlayerRank>k__BackingField, user2.<IsVerified>k__BackingField);
				float num = default(float);
				return num.CompareTo(socialScore);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static float GetUserScore(User user)
	{
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		bool hasAvatar = SFSKammelnaUserExtensions.HasAvatar(user);
		string title = SFSKammelnaUserExtensions.GetTitle(user);
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		bool isModerator = SFSKammelnaUserExtensions.Can(user, UserPermission.HaveChatColor);
		bool isSubscribed = SFSKammelnaUserExtensions.IsSubscribed(user);
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		bool isVerified = SFSKammelnaUserExtensions.IsVerified(user);
		return GetSocialScore(intDbId, hasAvatar, title, activeCardbackID, isModerator, isSubscribed, rank, isVerified);
	}

	public static float GetUserScore(PlayerInfo user)
	{
		bool hasAvatar = user.HasAvatar();
		return GetSocialScore(user.<DBID>k__BackingField, hasAvatar, user.<ActiveGameTitle>k__BackingField, user.<ActiveCardBack>k__BackingField, user.<IsModerator>k__BackingField, user.<IsSubscribed>k__BackingField, user.<PlayerRank>k__BackingField, user.<IsVerified>k__BackingField);
	}

	private static float GetSocialScore(int dbid, bool hasAvatar, string title, int cardBack, bool isModerator, bool isSubscribed, PlayerRank rank, bool isVerified)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_04d5: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_014d: Expected F8, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected I4, but got Unknown
		//IL_034b: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_0416: Expected O, but got I4
		//IL_046d: Expected I8, but got I4
		//IL_049f: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6134]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(title);
		bool flag3 = rank == null;
		object obj5 = !flag3;
		object obj6 = 0;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008f;
		IL_0074:
		flag2 = StringsExtensions.IsNullOrEmpty(title);
		obj6 = 0;
		goto IL_008f;
		IL_008f:
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		bool flag4 = !rank.<IsNew>k__BackingField;
		object obj8 = !flag4;
		double num = 1.0;
		if (obj8 == null)
		{
			object obj9 = (int)rank.<Rank>k__BackingField + (int)rank.<Rank>k__BackingField;
			object obj10 = obj9 + rank.<SubRanksCount>k__BackingField;
			double num2 = (double)obj10 - 4.0;
			num = num2;
		}
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = !hasAvatar;
		object obj13 = !flag6;
		object obj14 = ~obj13;
		double num3 = ((obj14 != null) ? 0.0 : 9.0);
		double num4 = num3 + 13.0;
		bool flag7 = !flag2;
		object obj15 = !flag7;
		object obj16 = ~obj15;
		if (obj16 != null)
		{
			num3 = num4;
		}
		double num5 = num3 + 9.0;
		object obj17 = cardBack - 1;
		bool flag8 = (nint)obj17 < 0;
		int num6 = cardBack ^ 1;
		int num7 = cardBack ^ obj17;
		int num8 = num6 & num7;
		bool flag9 = num8 < 0;
		bool flag10 = flag8 == flag9;
		object obj18 = !flag10;
		object obj19 = ~obj18;
		if (obj19 != null)
		{
			num3 = num5;
		}
		double num9 = num3 + 20.0;
		bool flag11 = !isModerator;
		object obj20 = !flag11;
		object obj21 = ~obj20;
		if (obj21 == null)
		{
			num3 = num9;
		}
		double num10 = num3 + 1123024896.0;
		bool flag12 = !isVerified;
		object obj22 = !flag12;
		object obj23 = ~obj22;
		if (obj23 == null)
		{
			num3 = num10;
		}
		double num11 = num3 + 12.0;
		bool flag13 = !isSubscribed;
		object obj24 = !flag13;
		object obj25 = ~obj24;
		if (obj25 == null)
		{
			num3 = num11;
		}
		double num12 = num / 30.0;
		double num13 = num12 * 13.0;
		double num14 = num3 + num13;
		bool flag14 = FriendsManager.IsFriend(dbid);
		double num15 = num14 + 25.0;
		bool flag15 = !flag14;
		object obj26 = !flag15;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			return (float)num15;
		}
		return (float)num14;
	}

	private static int GetRankValue(PlayerRank rank)
	{
		//IL_008f: Expected I4, but got O
		//IL_005c: Expected O, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected I4, but got Unknown
		if (rank != null)
		{
			if (rank.<IsNew>k__BackingField)
			{
				return 1;
			}
			object obj = (int)rank.<Rank>k__BackingField + (int)rank.<Rank>k__BackingField;
			object obj2 = obj + rank.<SubRanksCount>k__BackingField;
			return obj2 - 4;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
