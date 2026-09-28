using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;

public static class SFSKammelnaUserExtensions
{
	private sealed class <>c__DisplayClass35_0
	{
		public TicketType type;

		internal bool <GetTickets>b__0(TicketRecord record)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (record != null)
			{
				object obj = record.<Type>k__BackingField - type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static string GetUserName(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "m_StencilDeferredPS" + 2848;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static bool IsNew(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "https://www.kammelna.com/Home/Terms" + 3000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, defaultValue: false);
	}

	public static bool IsSubscribed(User user, bool includeTempSubscription = true)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94600D4");
		bool result = default(bool);
		return result;
	}

	public static bool IsVerified(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "https://www.kammelna.com/Home/Terms" + 4016;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, defaultValue: false);
	}

	public static bool IsSubscribedUsingDate(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		object obj = "rightCtrl" + 1480;
		object obj2 = typeof(DataRelation) + 712;
		User user2 = default(User);
		DateTime? variable = SFSExtensions.GetVariable(user2, (string)obj, (DateTime?)(object)0);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		DateTime now;
		if ((nint)0 != 0)
		{
			now = DateTime.Now;
			object obj4 = (??)variable & 1;
			if (obj4 != null)
			{
				goto IL_005c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			now = DateTime.Now;
			object obj5 = (??)variable & 1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_005c;
			}
		}
		return false;
		IL_005c:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return (DateTime)obj > now;
	}

	public static SubscriptionStatus GetSubscriptionStatus(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "setMimeType" + 3808;
		object obj2 = (nint)0 + (nint)360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
		SubscriptionStatus result = default(SubscriptionStatus);
		return result;
	}

	public static int GetFreeSubscriptionDays(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1552;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetSubscriptionDays(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "rightCtrl" + 1384;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static string GetDbId(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		nint num;
		object obj3 = default(object);
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			goto IL_00d9;
		}
		goto IL_0124;
		IL_0124:
		return (string)(object)new NullReferenceException();
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj5 = default(object);
		object obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_00d9;
		IL_00d9:
		object obj7 = obj3 + 1;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0124;
	}

	public static int GetIntDbId(User user)
	{
		//IL_01de: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0165: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj2;
		string value;
		string text = default(string);
		object obj8;
		object obj9;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00c1;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v14+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v14] (should have been resolved before IL gen)");
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			value = text;
			if (obj10 != null)
			{
				goto IL_011a;
			}
			goto IL_01af;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_01af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Convert.ToInt32(value);
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v11+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X0_v11] (should have been resolved before IL gen)");
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		value = text;
		if (!flag2)
		{
			goto IL_011a;
		}
		goto IL_01af;
		IL_011a:
		return Convert.ToInt32(text);
	}

	public static bool IsTV(User user)
	{
		//IL_001b: Expected O, but got I4
		int intDbId = GetIntDbId(user);
		object obj = intDbId + 1;
		bool flag = (nint)obj < 0;
		bool flag2 = !flag;
		return !flag2;
	}

	public static string GetEmail(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "destinationTimeZone" + 1040;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static string GetUserCode(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 1136;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static PlayerRank GetRank(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object varName = "placementId" + 1552;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		int variable = SFSExtensions.GetVariable(user, (string)varName, 0);
		object varName2 = "https://www.kammelna.com/Home/Terms" + 3000;
		bool variable2 = SFSExtensions.GetVariable(user, (string)varName2, defaultValue: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(variable, variable2);
		return playerRank;
	}

	public static UserPermission GetUserPermissions(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "not" + 3744;
		User user2 = default(User);
		return (UserPermission)SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static bool Can(User user, UserPermission permission)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @946056C");
		bool result = default(bool);
		return result;
	}

	public static string GetTitle(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "___# Content push apply failed [{0}]: {1}" + 3976;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static int GetTitleLevel(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "alignContent" + 3040;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 1);
	}

	public static ChatInk GetChatInk(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "https://www.kammelna.com/Home/Terms" + 752;
		object obj2 = (nint)0 + (nint)320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
		ChatInk result = default(ChatInk);
		return result;
	}

	public static bool HasTrophyCelebration(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "getSecondRescanTask" + 3352;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, defaultValue: false);
	}

	public static bool HasAvatar(User user)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected I4, but got Unknown
		object obj = 152981504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F91]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F92]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_006f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F92]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_006f;
			}
		}
		_ = 1;
		bool flag2 = user == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_008c;
		}
		goto IL_0136;
		IL_008c:
		object varName = "___# Content push apply failed [{0}]: {1}" + 3224;
		DateTime? variable = SFSExtensions.GetVariable(user, (string)varName, (DateTime?)(object)0);
		return (byte)((??)variable & 1) != 0;
		IL_0136:
		return false;
		IL_006f:
		if (user != null)
		{
			goto IL_008c;
		}
		goto IL_0136;
	}

	public static DateTime? GetAvatarDate(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		if (user != null)
		{
			object varName = "___# Content push apply failed [{0}]: {1}" + 3224;
			return SFSExtensions.GetVariable(user, (string)varName, (DateTime?)(object)0);
		}
		return (DateTime?)user;
	}

	public static DateTime? GetRegistrationDate(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		object varName = "rightCtrl" + 640;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (DateTime?)(object)0);
	}

	public static RankedPlayCondition GetPlayingCondition(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "not" + 3704;
		object obj2 = (nint)0 + (nint)352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
		RankedPlayCondition result = default(RankedPlayCondition);
		return result;
	}

	public static int GetJoinRankedGamePrice(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "java.io.FileOutputStream" + 368;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetJoinsAllowed(User user)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460128");
		int result = default(int);
		return result;
	}

	public static int GetMaxFreeJoins(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "m_StencilDeferredPS" + 2040;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetMiniGameTrials(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "m_StencilDeferredPS" + 1440;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetWinningStreak(User user)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94605C0");
		int result = default(int);
		return result;
	}

	public static MuteStatus GetMuteStatus(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "m_StencilDeferredPS" + 2520;
		object obj2 = (nint)0 + (nint)344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
		MuteStatus result = default(MuteStatus);
		return result;
	}

	public static DateTime? GetMutedUntil(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		object varName = "m_StencilDeferredPS" + 2704;
		User user2 = default(User);
		DateTime? dateTime = SFSExtensions.GetVariable(user2, (string)varName, (DateTime?)(object)0);
		object obj = (??)dateTime & 1;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)2296;
			object obj3 = typeof(DataRelation) + 712;
			DateTime? dateTime2 = default(DateTime?);
			DateTime value = dateTime2.Value;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			bool flag2 = value < now;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			dateTime = (DateTime?)(object)0;
			if (obj6 == null)
			{
				dateTime = dateTime2;
			}
		}
		return dateTime;
	}

	public static int GetTournamentPoints(User user)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460614");
		int result = default(int);
		return result;
	}

	public static MonthlyTournamentEligibilityType GetMonthlyTournamentEligibility(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object obj = "m_StencilDeferredPS" + 2688;
		object obj2 = (nint)0 + (nint)336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
		MonthlyTournamentEligibilityType result = default(MonthlyTournamentEligibilityType);
		return result;
	}

	public static int GetTournamentJoiningDiscount(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "startPosition" + 2408;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static List<TicketRecord> GetAllTickets(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0284: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_03b0: Expected I, but got O
		//IL_0230: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		object obj2;
		object obj9 = default(object);
		object obj10;
		Func<object, object> func;
		object obj8;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 104;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 21;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v20+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v20] (should have been resolved before IL gen)");
			bool flag = obj9 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v20+8]");
			obj10 = 0;
			func = (Func<object, object>)obj2;
			if (!flag)
			{
				goto IL_019d;
			}
			goto IL_02e9;
		}
		return (List<TicketRecord>)(object)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v17+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v17] (should have been resolved before IL gen)");
		bool flag2 = obj9 == null;
		object obj11 = !flag2;
		if (obj11 != null)
		{
			goto IL_019d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v17+8]");
		obj10 = 0;
		func = (Func<object, object>)obj2;
		goto IL_02e9;
		IL_038e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X8_v13] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func2 = default(Func<object, object>);
		object obj12;
		func2..ctor((object)null, (IntPtr)obj12);
		object obj13;
		obj10 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		List<TicketRecord> list = default(List<TicketRecord>);
		bool flag3 = list == null;
		func = func2;
		if (!flag3)
		{
			return list;
		}
		goto IL_02e9;
		IL_019d:
		object obj14 = typeof(UsageHint) + 664;
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1680;
		obj12 = (nint)0 + (nint)3712;
		obj13 = (nint)0 + (nint)512;
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v12+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0271;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v12+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v7-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_0271;
		}
		object obj19 = obj18 + 8;
		object obj20 = obj16 + obj19;
		object obj21 = obj20 + 312;
		goto IL_038e;
		IL_02e9:
		object obj22 = typeof(List<AdaptivePerformanceScaler>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		return (List<TicketRecord>)(object)list2;
		IL_0271:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 8;
		object obj23 = default(object);
		obj21 = obj23;
		goto IL_038e;
	}

	public static TicketRecord GetTickets(User user, TicketType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_0084: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			TicketRecord allTickets = (TicketRecord)(object)GetAllTickets(user);
			if (allTickets != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3808;
				object obj4 = (nint)0 + (nint)1440;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return (TicketRecord)Enumerable.FirstOrDefault((IEnumerable<object>)allTickets, func);
			}
			return allTickets;
		}
		return (TicketRecord)(object)new NullReferenceException();
	}

	public static TicketRecord GetTournamentTickets(User user, TournamentType type)
	{
		TicketType ticketType = TicketTypeExtensions.GetTicketType(type);
		return GetTickets(user, ticketType);
	}

	public static int GetLikes(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "java.io.FileOutputStream" + 2864;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetAchievementCount(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "___# Content push apply failed [{0}]: {1}" + 2960;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static bool IsVoiceMuted(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "m_StencilDeferredPS" + 2112;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, defaultValue: false);
	}

	public static int GetClanId(User user)
	{
		//IL_003e: Expected I4, but got I8
		return GetClanMembership(user)?.ClanId ?? (-1);
	}

	public static string GetClanName(User user)
	{
		ClanUserModel clanMembership = GetClanMembership(user);
		bool flag = clanMembership == null;
		string result = (string)(object)clanMembership;
		if (!flag)
		{
			result = clanMembership.ClanName;
		}
		return result;
	}

	public static int GetClanTier(User user)
	{
		//IL_0024: Expected I4, but got O
		ClanUserModel clanMembership = GetClanMembership(user);
		bool flag = clanMembership == null;
		int result = (int)clanMembership;
		if (!flag)
		{
			result = clanMembership.ClanTier;
		}
		return result;
	}

	public static ClanSubscriptionStatus? GetClanSubscriptionStatusOrNull(User user)
	{
		User user2 = default(User);
		ClanUserModel clanMembership = GetClanMembership(user2);
		bool flag = clanMembership == null;
		ClanSubscriptionStatus? result = (ClanSubscriptionStatus?)clanMembership;
		if (!flag)
		{
			System.Int32Enum? int32Enum = (System.Int32Enum)clanMembership.SubscriptionStatus;
			result = (ClanSubscriptionStatus?)int32Enum;
		}
		return result;
	}

	public static ClanUserModel GetClanMembership(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0199: Expected I, but got O
		//IL_01a9: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_01e4: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		ClanUserModel clanUserModel = default(ClanUserModel);
		ClanUserModel clanUserModel2;
		object obj8;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3304;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v12-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 21;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v17+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v17] (should have been resolved before IL gen)");
			bool flag = clanUserModel == null;
			clanUserModel2 = clanUserModel;
			if (flag)
			{
				goto IL_0110;
			}
			goto IL_017d;
		}
		return (ClanUserModel)(object)new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v14+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X0_v14] (should have been resolved before IL gen)");
		bool flag2 = clanUserModel == null;
		object obj9 = !flag2;
		clanUserModel2 = clanUserModel;
		if (obj9 == null)
		{
			goto IL_0110;
		}
		goto IL_017d;
		IL_02ef:
		object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanUserModel clanUserModel3 = default(ClanUserModel);
		ClanUserModel clanUserModel4 = default(ClanUserModel);
		clanUserModel3..ctor((ISFSObject)clanUserModel4);
		return clanUserModel3;
		IL_017d:
		object obj11 = typeof(UsageHint) + 664;
		nint num2 = (nint)clanUserModel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<ClanUserModel>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<ClanUserModel>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0225;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9 (Il2CppClass<ClanUserModel>)+B0]");
		object obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v6-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj13 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0225;
		}
		object obj14 = obj13 + 7;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X8_v15] (should have been resolved before IL gen)");
		bool flag3 = clanUserModel == null;
		clanUserModel4 = clanUserModel;
		if (flag3)
		{
			goto IL_0110;
		}
		goto IL_02ef;
		IL_0225:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v8+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X0_v8] (should have been resolved before IL gen)");
		bool flag4 = clanUserModel4 == null;
		object obj18 = !flag4;
		obj8 = 7;
		if (obj18 == null)
		{
			return clanUserModel4;
		}
		goto IL_02ef;
		IL_0110:
		return clanUserModel;
	}

	public static int GetAces(User user)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9460518");
		int result = default(int);
		return result;
	}

	public static int GetActiveRoomThemeID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "placementId" + 2064;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetActiveCardbackID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetActivePatternID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "placementId" + 1536;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static FeaturedSlotModel GetFeaturedSlot(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object varName;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			varName = "fetch_products" + 1544;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 24;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v208 @ X0_v17] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_01cf;
		}
		return (FeaturedSlotModel)(object)new NullReferenceException();
		IL_01cf:
		return null;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v14] (should have been resolved before IL gen)");
		object obj9 = default(object);
		if (obj9 != null)
		{
			goto IL_00ed;
		}
		goto IL_01cf;
		IL_00ed:
		object defaultValue = ", stale={0}" + 3424;
		string variable = SFSExtensions.GetVariable(user, (string)varName, (string)defaultValue);
		object varName2 = "fetch_products" + 1560;
		int variable2 = SFSExtensions.GetVariable(user, (string)varName2, 0);
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FeaturedSlotModel featuredSlotModel = default(FeaturedSlotModel);
		featuredSlotModel..ctor(variable, variable2);
		return featuredSlotModel;
	}

	public static List<StoreOwnedItem> GetOwnedCards(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 160;
		object obj2 = (nint)0 + (nint)64;
		object obj3 = "not" + 936;
		object obj4 = (nint)0 + (nint)312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F7C0");
		List<StoreOwnedItem> result = default(List<StoreOwnedItem>);
		return result;
	}

	public static List<StoreOwnedItem> GetOwnedRoomThemes(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 160;
		object obj2 = (nint)0 + (nint)64;
		object obj3 = "not" + 2632;
		object obj4 = (nint)0 + (nint)312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F7C0");
		List<StoreOwnedItem> result = default(List<StoreOwnedItem>);
		return result;
	}

	public static List<StoreOwnedItem> GetOwnedPatterns(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 160;
		object obj2 = (nint)0 + (nint)64;
		object obj3 = "not" + 1976;
		object obj4 = (nint)0 + (nint)312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F7C0");
		List<StoreOwnedItem> result = default(List<StoreOwnedItem>);
		return result;
	}

	public static IEnumerable<StoreOwnedItem> GetOwnedGifts(User user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 160;
		object obj2 = (nint)0 + (nint)64;
		object obj3 = "not" + 1152;
		object obj4 = (nint)0 + (nint)312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F7C0");
		IEnumerable<StoreOwnedItem> result = default(IEnumerable<StoreOwnedItem>);
		return result;
	}

	public static bool HasPaidRoomTheme(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "getSecondRescanTask" + 3280;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, defaultValue: false);
	}

	public static int GetFTLevel(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1576;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTStage(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1608;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTTopStage(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1624;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTRoundsWon(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1600;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTRoundsLost(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1592;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetNumberOfFTStarted(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1688;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetNumberOfFTWon(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1696;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTTicketsOwned(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1616;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static DateTime? GetFTNextTicketTime(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0026: Expected O, but got I4
		object varName = "fetch_products" + 1584;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (DateTime?)(object)0);
	}

	public static int GetFTMaximumTicketsAllowed(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "m_StencilDeferredPS" + 2672;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, 0);
	}

	public static int GetFTHearts(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "fetch_products" + 1592;
		User user2 = default(User);
		int variable = SFSExtensions.GetVariable(user2, (string)varName, 0);
		return 5 - variable;
	}

	public static string GetUserFacebookID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "rightCtrl" + 896;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static string GetUserTwitterID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "rightCtrl" + 912;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static string GetUserTwitterUserID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "rightCtrl" + 920;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static string GetUserGoogleID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "rightCtrl" + 904;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static string GetUserAppleID(User user)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		object varName = "rightCtrl" + 864;
		object defaultValue = (nint)0 + (nint)2000;
		User user2 = default(User);
		return SFSExtensions.GetVariable(user2, (string)varName, (string)defaultValue);
	}

	public static bool IsSocialConnected(User user)
	{
		//IL_0038: Expected O, but got I4
		if (user != null)
		{
			SocialPlatform socialPlatform = GetSocialPlatform(user);
			object obj = socialPlatform + 1;
			bool flag = obj == null;
			return !flag;
		}
		return true;
	}

	public static SocialPlatform GetSocialPlatform(User user)
	{
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_0028: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object varName = "rightCtrl" + 896;
		object defaultValue = (nint)0 + (nint)2000;
		string variable = SFSExtensions.GetVariable(user, (string)varName, (string)defaultValue);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+E4]");
		SocialPlatform result;
		if ((nint)0 != 0)
		{
			bool flag = string.IsNullOrEmpty(variable);
			bool flag2 = !flag;
			object obj3 = !flag2;
			result = (flag ? SocialPlatform.Twitter : SocialPlatform.Facebook);
			if (obj3 == null)
			{
				goto IL_003e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = string.IsNullOrEmpty(variable);
			bool flag4 = !flag3;
			result = (flag3 ? SocialPlatform.Twitter : SocialPlatform.Facebook);
			if (flag4)
			{
				goto IL_003e;
			}
		}
		object varName2 = "rightCtrl" + 912;
		string variable2 = SFSExtensions.GetVariable(user, (string)varName2, (string)defaultValue);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			if (string.IsNullOrEmpty(variable2))
			{
				goto IL_00ba;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = string.IsNullOrEmpty(variable2);
			bool flag6 = !flag5;
			object obj5 = !flag6;
			if (obj5 != null)
			{
				goto IL_00ba;
			}
		}
		return SocialPlatform.Twitter;
		IL_00ba:
		object varName3 = "rightCtrl" + 904;
		string variable3 = SFSExtensions.GetVariable(user, (string)varName3, (string)defaultValue);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11+E4]");
		if ((nint)0 != 0)
		{
			if (string.IsNullOrEmpty(variable3))
			{
				goto IL_00f4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = string.IsNullOrEmpty(variable3);
			bool flag8 = !flag7;
			object obj7 = !flag8;
			if (obj7 != null)
			{
				goto IL_00f4;
			}
		}
		return SocialPlatform.Google;
		IL_003e:
		return result;
		IL_00f4:
		object varName4 = "rightCtrl" + 864;
		string variable4 = SFSExtensions.GetVariable(user, (string)varName4, (string)defaultValue);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v14+E4]");
		bool flag9 = (nint)0 == 0;
		object obj9 = !flag9;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!string.IsNullOrEmpty(variable4))
		{
			return SocialPlatform.Apple;
		}
		return SocialPlatform.None;
	}
}
