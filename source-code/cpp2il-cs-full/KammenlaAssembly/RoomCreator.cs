using System;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine.Purchasing.Telemetry;

public static class RoomCreator
{
	public static void CreateRoom(RoomParameters p)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_00b2: Expected I4, but got O
		//IL_00e3: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_0260: Expected F8, but got I4
		object action = "Complete" + 3176;
		object type = (nint)0 + (nint)2000;
		object obj = "Unsupported map type" + 3184;
		object obj2 = "Network Authentication Required" + 1632;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SFS.CreateRoom(p.roomName, p.password, p.minRank, p.playSpeed, p.isCheatingEnabled, p.isVoiceRoom, p.isVoiceChatEnabledForSpectators, p.jackarooCustomRules, p.tvUserId, (int)p.testDeckCsv);
		FirebaseTrack.Event((string)action, (string)type);
		bool flag = !p.isVoiceRoom;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object obj6 = ((obj5 != null) ? obj2 : obj);
		ITrackEvent trackEvent = TrackerLibrary.MenuRoomCreated((string)obj6);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v6+E4]");
		object obj8;
		string text;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			if (p.clanId >= 1)
			{
				goto IL_019d;
			}
			obj8 = 0;
			text = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			bool flag2 = p.clanId < 1;
			obj8 = 0;
			text = null;
			if (!flag2)
			{
				goto IL_019d;
			}
		}
		goto IL_01f8;
		IL_019d:
		ClanServerConnector.NotifyActivityCreated(ClanActivityType.FriendlyRoom, (string)obj6);
		bool flag3 = p.clanId > 0;
		obj8 = 0;
		text = (string)obj6;
		int num = 0;
		object obj9 = 0;
		string text2 = (string)obj6;
		if (!flag3)
		{
			goto IL_01f8;
		}
		goto IL_02a5;
		IL_02a5:
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string itemId = Tracker.ItemId(ResourceItemId.RoomCreate);
		Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, num, ResourceCurrency.Aces);
		TrackAnimatedRoomThemeOnRoomCreated();
		return;
		IL_01f8:
		int roomCreationPrice = GetRoomCreationPrice(p.isVoiceRoom);
		num = roomCreationPrice;
		obj9 = obj8;
		text2 = text;
		goto IL_02a5;
	}

	private static void TrackAnimatedRoomThemeOnRoomCreated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		User mySelf = SFS.MySelf;
		int activeRoomThemeID = SFSKammelnaUserExtensions.GetActiveRoomThemeID(mySelf);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+E4]");
		StoreItem storeItem2;
		if ((nint)0 != 0)
		{
			StoreItem storeItem = Store.GetStoreItem(activeRoomThemeID);
			bool flag = StoreItemExtensions.IsAnimatedRoomTheme(storeItem);
			bool flag2 = !flag;
			object obj3 = !flag2;
			storeItem2 = storeItem;
			if (obj3 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			StoreItem storeItem3 = Store.GetStoreItem(activeRoomThemeID);
			bool flag3 = StoreItemExtensions.IsAnimatedRoomTheme(storeItem3);
			bool flag4 = !flag3;
			storeItem2 = storeItem3;
			if (flag4)
			{
				return;
			}
		}
		if (GamesFlagExtensions.MatchesCurrentGame(storeItem2.<targetGames>k__BackingField))
		{
			ITrackEvent trackEvent = TrackerLibrary.RoomCreatedWithAnimatedTheme(storeItem2.<id>k__BackingField, storeItem2.<name>k__BackingField);
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	public static int GetRoomCreationPrice(bool voiceChat)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_015a: Expected O, but got I4
		//IL_01e4: Expected I4, but got O
		User mySelf = SFS.MySelf;
		if (SFSKammelnaUserExtensions.IsSubscribed(mySelf))
		{
			return 0;
		}
		if (voiceChat)
		{
			object obj = typeof(RegisteredWaitHandle) + 56;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
				if (current.<Economy>k__BackingField != null)
				{
					return <Economy>k__BackingField.<CreateVoiceRoomPrice>k__BackingField;
				}
			}
		}
		else
		{
			User mySelf2 = SFS.MySelf;
			if (SFSKammelnaUserExtensions.HasPaidRoomTheme(mySelf2))
			{
				return 0;
			}
			object obj4 = typeof(RegisteredWaitHandle) + 56;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current2 = RemoteConfig.Current;
			if (current2 != null)
			{
				EconomyConfig <Economy>k__BackingField2 = current2.<Economy>k__BackingField;
				if (current2.<Economy>k__BackingField != null)
				{
					return <Economy>k__BackingField2.<CreateRoomPrice>k__BackingField;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int GetChallengeCreationFees(int prizeAmount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_0277: Expected I4, but got O
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01ef: Expected O, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected I4, but got Unknown
		//IL_0257: Expected F4, but got I8
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71C7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_012d;
		}
		goto IL_0269;
		IL_0269:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_012d:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current.<FriendlyChallenge>k__BackingField;
		if (current.<FriendlyChallenge>k__BackingField != null)
		{
			RemoteConfigModel current2 = RemoteConfig.Current;
			if (current2 != null)
			{
				FriendlyChallengeConfig <FriendlyChallenge>k__BackingField2 = current2.<FriendlyChallenge>k__BackingField;
				if (current2.<FriendlyChallenge>k__BackingField != null)
				{
					object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4008;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v5+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num = <FriendlyChallenge>k__BackingField2.<PercentageFee>k__BackingField * (float)prizeAmount;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					object obj9 = default(object);
					float num2 = (((nint)obj9 != 2139095040) ? num : 2.1474836E+09f);
					return (int)(num2 + <FriendlyChallenge>k__BackingField.<FixedFee>k__BackingField);
				}
			}
		}
		goto IL_0269;
		IL_007c:
		current = RemoteConfig.Current;
		bool flag4 = current == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_012d;
		}
		goto IL_0269;
	}

	public static int GetChallengeCreationPrice(int prizeAmount)
	{
		int challengeCreationFees = GetChallengeCreationFees(prizeAmount);
		return challengeCreationFees + prizeAmount;
	}
}
