using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ChallengeInfoGameEndWidget : GameEndWidget
{
	private ChallengeHistoryStrip challengeHistoryStrip;

	private CriteriaSection criteriaSection;

	private TextMeshProUGUI challengeStatusText;

	private GameObject challengePrizeContainer;

	private TextMeshProUGUI challengePrizeText;

	private ChallengeStateData _state;

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_0061: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0172: Expected O, but got I4
		//IL_019b: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_030f: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = criteriaSection.gameObject;
		gameObject2.SetActive(value: true);
		criteriaSection.InitPerformanceVars(rankReport);
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
		object obj2 = (nint)0 & (nint)1;
		CardGame cardGame;
		object obj3;
		if (obj2 != null)
		{
			obj3 = this + 32;
			cardGame = (CardGame)obj3;
			if (obj3 != null)
			{
				goto IL_00c4;
			}
		}
		else
		{
			_ = 1;
			obj3 = this + 32;
			cardGame = (CardGame)obj3;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_00c4;
			}
		}
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v29+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGame cardGame2 = default(CardGame);
		obj3 = cardGame2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		cardGame = cardGame2;
		goto IL_01c9;
		IL_00c4:
		bool flag3 = (object)criteriaSection == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01c9;
		IL_01c9:
		criteriaSection.PrepareCheatAndCatch(cardGame);
		FriendlyChallengeExtraGameResult <FriendlyChallengeGameResult>k__BackingField = rankReport.<FriendlyChallengeGameResult>k__BackingField;
		ChallengeStateData challengeStateData2;
		if (rankReport.<FriendlyChallengeGameResult>k__BackingField != null)
		{
			bool flag4 = ((ChallengeInfoGameEndWidget)(object)criteriaSection).UserIsTheChallenger(rankReport.<FriendlyChallengeGameResult>k__BackingField);
			if (flag4)
			{
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 560;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ChallengeStateData challengeStateData = default(ChallengeStateData);
				challengeStateData..ctor();
				object obj11 = challengeStateData + 16;
				obj11 = <FriendlyChallengeGameResult>k__BackingField.<Challenger>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj12 = challengeStateData + 24;
				obj12 = <FriendlyChallengeGameResult>k__BackingField.<Defender>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = <FriendlyChallengeGameResult>k__BackingField.<ChallengeLevel>k__BackingField;
				_ = <FriendlyChallengeGameResult>k__BackingField.<IsLocked>k__BackingField;
				challengeStateData2 = challengeStateData;
			}
			else
			{
				ChallengeStateData challengeStateData3 = ((ChallengeInfoGameEndWidget)flag4).StateDataForDefender(rankReport.<FriendlyChallengeGameResult>k__BackingField);
				challengeStateData2 = challengeStateData3;
			}
		}
		else
		{
			challengeStateData2 = null;
		}
		object obj13 = this + 80;
		obj13 = challengeStateData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v5-28]");
		((ChallengeHistoryStrip)0).Populate(_state, interactable: false);
		SetPrizeText(rankReport);
		SetStatusText(_state);
	}

	private ChallengeStateData ConvertToChallengeState(FriendlyChallengeExtraGameResult report)
	{
		//IL_0069: Expected O, but got I4
		//IL_0051: Expected O, but got I4
		if (report != null)
		{
			bool flag = UserIsTheChallenger(report);
			if (flag)
			{
				return ((ChallengeInfoGameEndWidget)flag).StateDataForChallenger(report);
			}
			return ((ChallengeInfoGameEndWidget)flag).StateDataForDefender(report);
		}
		return null;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0064: Expected I, but got O
		//IL_00ad: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3520;
		object obj4 = (nint)0 + (nint)3528;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval(sequence, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence sequence3 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
		Sequence sequence4 = TweenSettingsExtensions.AppendInterval(sequence, 1.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence sequence5 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback2);
		return sequence;
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_00ca: Expected I4, but got O
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		return kGame.IsChallenge;
	}

	private bool UserIsTheChallenger(FriendlyChallengeExtraGameResult report)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ef: Expected I4, but got O
		//IL_01cd: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6761]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_01e1;
		IL_01e1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0150:
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (report != null)
		{
			PlayerInfo <Challenger>k__BackingField = report.<Challenger>k__BackingField;
			if (report.<Challenger>k__BackingField != null)
			{
				object obj8 = intDbId - <Challenger>k__BackingField.<DBID>k__BackingField;
				return obj8 == null;
			}
		}
		goto IL_01e1;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_0150;
		}
		goto IL_01e1;
	}

	private ChallengeStateData StateDataForChallenger(FriendlyChallengeExtraGameResult report)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChallengeStateData challengeStateData = default(ChallengeStateData);
		challengeStateData..ctor();
		if (report != null && challengeStateData != null)
		{
			object obj2 = challengeStateData + 16;
			obj2 = report.<Challenger>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = challengeStateData + 24;
			obj3 = report.<Defender>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			challengeStateData.ChallengeLevel = report.<ChallengeLevel>k__BackingField;
			challengeStateData.IsLocked = report.<IsLocked>k__BackingField;
			return challengeStateData;
		}
		return (ChallengeStateData)(object)new NullReferenceException();
	}

	private ChallengeStateData StateDataForDefender(FriendlyChallengeExtraGameResult report)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChallengeStateData challengeStateData = default(ChallengeStateData);
		challengeStateData..ctor();
		if (report != null && challengeStateData != null)
		{
			object obj2 = challengeStateData + 16;
			obj2 = report.<Defender>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj3 = challengeStateData + 24;
			obj3 = report.<Challenger>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int challengeLevel = -report.<ChallengeLevel>k__BackingField;
			challengeStateData.ChallengeLevel = challengeLevel;
			challengeStateData.IsLocked = report.<IsLocked>k__BackingField;
			return challengeStateData;
		}
		return (ChallengeStateData)(object)new NullReferenceException();
	}

	private void SetStatusText(ChallengeStateData state)
	{
		//IL_001c: Expected I4, but got I8
		//IL_0036: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		int num = (int)(state.ChallengeLevel & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		object text;
		if (obj == null)
		{
			if (state.ChallengeLevel <= 1)
			{
				if (state.ChallengeLevel != 0)
				{
					if (state.ChallengeLevel != 1)
					{
						goto IL_01df;
					}
					text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2744;
				}
				else
				{
					text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2792;
				}
			}
			else if (state.ChallengeLevel != 2)
			{
				if (state.ChallengeLevel != 3)
				{
					goto IL_01df;
				}
				text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2760;
			}
			else
			{
				text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2752;
			}
		}
		else
		{
			object obj2 = state.ChallengeLevel + 3;
			if (obj2 != null)
			{
				object obj3 = state.ChallengeLevel + 2;
				if (obj3 != null)
				{
					object obj4 = state.ChallengeLevel + 1;
					bool flag2 = obj4 == null;
					object obj5 = !flag2;
					if (obj5 != null)
					{
						goto IL_01df;
					}
					text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2768;
				}
				else
				{
					text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2776;
				}
			}
			else
			{
				text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2784;
			}
		}
		TextMeshProExtensions.Localize(challengeStatusText, (string)text);
		return;
		IL_01df:
		string text2 = challengeStatusText.text;
		TextMeshProExtensions.Localize(challengeStatusText, text2);
	}

	private void SetPrizeText(CardGameEndScores rankReport)
	{
		//IL_01c0: Expected O, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0239: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		FriendlyChallengeExtraGameResult <FriendlyChallengeGameResult>k__BackingField = rankReport.<FriendlyChallengeGameResult>k__BackingField;
		GameObject gameObject;
		bool flag5;
		if (rankReport.<FriendlyChallengeGameResult>k__BackingField != null && <FriendlyChallengeGameResult>k__BackingField.<PrizeAmount>k__BackingField >= 1)
		{
			object obj = this + 32;
			CardGame cardGame = (CardGame)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v13+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj6 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			int myTeamIndex = cardGame.MyTeamIndex;
			object obj7 = rankReport.<WinnerTeamIndex>k__BackingField - myTeamIndex;
			bool flag3 = obj7 == null;
			gameObject = challengePrizeContainer;
			bool flag4 = (object)challengePrizeContainer == null;
			object obj8 = !flag4;
			flag5 = flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			gameObject = challengePrizeContainer;
			flag5 = false;
		}
		gameObject.SetActive(flag5);
		GameObject gameObject2 = challengeStatusText.gameObject;
		bool flag6 = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(flag6);
		bool flag7 = !flag6;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			FriendlyChallengeExtraGameResult <FriendlyChallengeGameResult>k__BackingField2 = rankReport.<FriendlyChallengeGameResult>k__BackingField;
			TextMeshProExtensions.SetNumber(challengePrizeText, <FriendlyChallengeGameResult>k__BackingField2.<PrizeAmount>k__BackingField, useCommas: true);
		}
	}

	private void <AnimatedPopulate>b__9_0()
	{
		criteriaSection.AnimatePerformanceStamps();
	}

	private void <AnimatedPopulate>b__9_1()
	{
		criteriaSection.AnimateOverallStamps();
	}
}
