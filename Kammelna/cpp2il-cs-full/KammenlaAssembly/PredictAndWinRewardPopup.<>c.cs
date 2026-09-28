using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Server.Models;
using UnityEngine;
using UnityEngine.UI;

public class PredictAndWinRewardPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PredictAndWinRewardItem> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__11_0(PredictAndWinRewardItem reward)
		{
			reward.highlight.SetActive(value: false);
		}
	}

	private PopupUI popupUI;

	private RectTransform rewardsContainer;

	private PredictAndWinRewardItem rewardPrefab;

	private GameObject separatorPrefab;

	private GameObject sponsor;

	private Image sponsorImage;

	private ElegantLoadingIndicator loadingIndicator;

	private Dictionary<PredictionRewardType, PredictAndWinRewardItem> _rewards;

	public void Open(MatchPredictionModel model)
	{
		Populate(model);
		popupUI.PopFromCenter();
	}

	public void Open(UserMatchPredictionModel userMatchPredictionModel)
	{
		Populate(userMatchPredictionModel.<predictionMatch>k__BackingField);
		Populate(userMatchPredictionModel);
		popupUI.PopFromCenter();
	}

	private void Populate(MatchPredictionModel model)
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0409: Expected O, but got I
		//IL_0419: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_0457: Expected O, but got I4
		//IL_0467: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_04c9: Expected O, but got I
		//IL_04d9: Expected O, but got I
		//IL_04ef: Expected O, but got I
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_04a1: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0159: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_052a: Expected O, but got I
		//IL_039e: Expected O, but got I4
		//IL_06bd: Expected O, but got I4
		//IL_06c6: Expected O, but got I4
		//IL_06ec: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_0781: Expected O, but got I4
		//IL_0898: Expected O, but got I4
		//IL_05d6: Expected O, but got I4
		//IL_0850: Expected O, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_0801: Expected O, but got I4
		//IL_08a9: Expected O, but got I
		//IL_08d3: Expected O, but got I4
		//IL_0630: Expected O, but got I4
		//IL_0639: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_066d: Expected O, but got I4
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_093d: Expected O, but got I4
		//IL_0973: Expected O, but got I
		//IL_0323: Expected O, but got I4
		object obj = (nint)0 + (nint)384;
		object obj2 = (nint)0 + (nint)3120;
		((Dictionary<System.Int32Enum, object>)(object)_rewards).Clear();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v4+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+10]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v6+10]");
			object obj8 = 0;
			if (!flag)
			{
				goto IL_00c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v4+38]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+10]");
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v13+10]");
			object obj8 = 0;
			if (obj12 != null)
			{
				goto IL_00c6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_00eb;
		}
		goto IL_04af;
		IL_067a:
		int aces;
		int num;
		int num2;
		AddReward(PredictionRewardType.CorrectScore, aces, num, num2);
		int <correctWinnerAces>k__BackingField = model.<correctWinnerAces>k__BackingField;
		bool flag4 = model.<correctWinnerAces>k__BackingField == 0;
		object obj14 = !flag4;
		object obj15 = 0;
		int num3 = num;
		int num4 = num2;
		int aces2 = model.<correctWinnerAces>k__BackingField;
		object obj16 = 0;
		int num6;
		int num5 = num6;
		if (obj14 == null)
		{
			goto IL_0702;
		}
		goto IL_0759;
		IL_05af:
		int num7 = num3 | num4;
		bool flag5 = num7 == 0;
		object obj17 = !flag5;
		num = num3;
		num2 = num4;
		int <correctScoreAces>k__BackingField;
		aces = <correctScoreAces>k__BackingField;
		num6 = num5;
		if (obj17 != null)
		{
			goto IL_067a;
		}
		aces2 = model.<correctWinnerAces>k__BackingField;
		bool flag6 = model.<correctWinnerAces>k__BackingField == 0;
		object obj18 = !flag6;
		obj16 = 1;
		if (obj18 == null)
		{
			num = num3;
			num2 = num4;
			<correctWinnerAces>k__BackingField = model.<correctWinnerAces>k__BackingField;
			obj15 = 1;
			num6 = num5;
			goto IL_0702;
		}
		goto IL_0759;
		IL_0702:
		int num8 = model.<correctWinnerSubDays>k__BackingField | num6;
		bool flag7 = num8 == 0;
		num3 = num;
		num4 = num2;
		aces2 = <correctWinnerAces>k__BackingField;
		obj16 = obj15;
		num5 = num6;
		if (!flag7)
		{
			goto IL_0759;
		}
		goto IL_0824;
		IL_00c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00eb;
		}
		goto IL_04af;
		IL_04af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v4+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v8+10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v8+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		if (obj22 == null)
		{
			goto IL_0167;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v8+10]");
		object obj23 = 0;
		goto IL_0176;
		IL_0759:
		object obj24 = obj16 & 1;
		bool flag8 = obj24 == null;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			object obj26 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj27 = (nint)0 + (nint)920;
			object obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v34+E4]");
			bool flag9 = (nint)0 == 0;
			object obj29 = !flag9;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			aces2 = model.<correctWinnerAces>k__BackingField;
		}
		num = model.<correctWinnerSubDays>k__BackingField;
		AddReward(PredictionRewardType.CorrectWinner, aces2, model.<correctWinnerSubDays>k__BackingField, num5);
		num2 = num5;
		obj15 = 0;
		goto IL_0824;
		IL_00eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X22_v4+38]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v49+10]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v49+10]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag10 = obj32 == null;
		object obj33 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v49+10]");
		obj23 = 0;
		if (obj33 == null)
		{
			goto IL_0167;
		}
		goto IL_0176;
		IL_0167:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0176;
		IL_0176:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v13+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(rewardsContainer, (GameObject[])except);
		LoadSponsor(model);
		if (model.<isSeasonMatch>k__BackingField)
		{
			object obj34 = typeof(RegisteredWaitHandle) + 56;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v52+E4]");
			bool flag11 = (nint)0 == 0;
			object obj36 = !flag11;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			PredictionsConfig <Predictions>k__BackingField = current.<Predictions>k__BackingField;
			num4 = <Predictions>k__BackingField.<SeasonCorrectScorePoints>k__BackingField;
			if (model.<isSeasonMatch>k__BackingField)
			{
				object obj37 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v56+E4]");
				bool flag12 = (nint)0 == 0;
				object obj38 = !flag12;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RemoteConfigModel current2 = RemoteConfig.Current;
				PredictionsConfig <Predictions>k__BackingField2 = current2.<Predictions>k__BackingField;
				num6 = <Predictions>k__BackingField2.<SeasonCorrectWinnerPoints>k__BackingField;
				num = model.<correctScoreSubDays>k__BackingField;
				aces = model.<correctScoreAces>k__BackingField;
				bool flag13 = model.<correctScoreAces>k__BackingField == 0;
				object obj39 = !flag13;
				num2 = num4;
				if (obj39 == null)
				{
					num3 = model.<correctScoreSubDays>k__BackingField;
					<correctScoreAces>k__BackingField = model.<correctScoreAces>k__BackingField;
					num5 = <Predictions>k__BackingField2.<SeasonCorrectWinnerPoints>k__BackingField;
					goto IL_05af;
				}
			}
			else
			{
				num3 = model.<correctScoreSubDays>k__BackingField;
				<correctScoreAces>k__BackingField = model.<correctScoreAces>k__BackingField;
				bool flag14 = model.<correctScoreAces>k__BackingField == 0;
				object obj40 = !flag14;
				num5 = 0;
				num = model.<correctScoreSubDays>k__BackingField;
				num2 = <Predictions>k__BackingField.<SeasonCorrectScorePoints>k__BackingField;
				aces = model.<correctScoreAces>k__BackingField;
				num6 = 0;
				if (obj40 == null)
				{
					goto IL_05af;
				}
			}
		}
		else
		{
			num = model.<correctScoreSubDays>k__BackingField;
			aces = model.<correctScoreAces>k__BackingField;
			bool flag15 = model.<correctScoreAces>k__BackingField == 0;
			object obj41 = !flag15;
			num2 = 0;
			num6 = 0;
			if (obj41 == null)
			{
				num3 = model.<correctScoreSubDays>k__BackingField;
				num4 = 0;
				<correctScoreAces>k__BackingField = model.<correctScoreAces>k__BackingField;
				num5 = 0;
				goto IL_05af;
			}
		}
		goto IL_067a;
		IL_0824:
		int <participationAces>k__BackingField = model.<participationAces>k__BackingField;
		bool flag16 = model.<participationAces>k__BackingField == 0;
		object obj42 = !flag16;
		if (obj42 == null && model.<participationSubDays>k__BackingField == 0)
		{
			return;
		}
		object obj43 = obj15 & 1;
		bool flag17 = obj43 == null;
		object obj44 = !flag17;
		if (obj44 == null)
		{
			object obj45 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v25+E4]");
			bool flag18 = (nint)0 == 0;
			object obj47 = !flag18;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj48 = (nint)0 + (nint)920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			<participationAces>k__BackingField = model.<participationAces>k__BackingField;
		}
		AddReward(PredictionRewardType.Participation, <participationAces>k__BackingField, model.<participationSubDays>k__BackingField, 0);
	}

	private void Populate(UserMatchPredictionModel model)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_0072: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0259: Expected I, but got O
		//IL_0277: Expected O, but got I
		//IL_0198: Expected O, but got I
		//IL_0215: Expected O, but got I
		object obj = (nint)0 + (nint)408;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3072;
		Dictionary<System.Int32Enum, object>.ValueCollection values = ((Dictionary<System.Int32Enum, object>)(object)_rewards).Values;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v13+E4]");
		object obj4;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v13+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v13+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v13+8]");
			if ((nint)0 != 0)
			{
				goto IL_00a8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v13+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v13+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v13+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_00a8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v19+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1656;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v18+B8]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(values, action2);
		goto IL_01af;
		IL_00a8:
		ArraysExtensions.ForEach(values, action);
		bool flag3 = model == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01af;
		IL_01af:
		if (((Dictionary<System.Int32Enum, object>)(object)_rewards).ContainsKey((System.Int32Enum)model.<predictionReward>k__BackingField))
		{
			object obj13 = ((Dictionary<System.Int32Enum, object>)(object)_rewards).get_Item((System.Int32Enum)model.<predictionReward>k__BackingField);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v11 (System.Object)+28]");
			((GameObject)0).SetActive(value: true);
		}
	}

	private void AddReward(PredictionRewardType type, int aces, int subDays, int points)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0053: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6492]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)992;
			RectTransform rectTransform = rewardsContainer;
			PredictAndWinRewardItem predictAndWinRewardItem = rewardPrefab;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			RectTransform rectTransform2 = rewardsContainer;
			object obj5 = obj3;
			PredictAndWinRewardItem predictAndWinRewardItem2 = rewardPrefab;
			if (!flag)
			{
				goto IL_00b0;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)992;
			RectTransform rectTransform = rewardsContainer;
			PredictAndWinRewardItem predictAndWinRewardItem = rewardPrefab;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			RectTransform rectTransform2 = rewardsContainer;
			object obj5 = obj3;
			PredictAndWinRewardItem predictAndWinRewardItem2 = rewardPrefab;
			if (obj6 != null)
			{
				goto IL_00b0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		goto IL_017a;
		IL_017a:
		PredictAndWinRewardItem predictAndWinRewardItem3 = default(PredictAndWinRewardItem);
		predictAndWinRewardItem3.Populate(type, aces, subDays, points);
		((Dictionary<System.Int32Enum, object>)(object)_rewards).set_Item((System.Int32Enum)type, (object)predictAndWinRewardItem3);
		return;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		bool flag3 = (object)predictAndWinRewardItem3 == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_017a;
	}

	private void AddHeader()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
	}

	private void LoadSponsor(MatchPredictionModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0193: Expected O, but got I
		//IL_01a1: Expected I, but got O
		if (model != null)
		{
			FileInfoModel <sponsorImage>k__BackingField = model.<sponsorImage>k__BackingField;
			if (model.<sponsorImage>k__BackingField != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = StringsExtensions.IsNullOrEmpty(<sponsorImage>k__BackingField.<url>k__BackingField);
				bool value = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
				bool? flag3 = value;
				object obj4 = (??)flag3 & 0x100;
				bool flag4 = obj4 == null;
				object obj5 = !flag4;
				if (obj5 != null)
				{
					GameObject gameObject = sponsor.gameObject;
					gameObject.SetActive(value: true);
					GameObject gameObject2 = sponsorImage.gameObject;
					gameObject2.SetActive(value: false);
					object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj7 = (nint)0 + (nint)1648;
					Action<bool> action = default(Action<bool>);
					action..ctor((object)this, (IntPtr)obj7);
					UIExtensions.LoadPredictAndWinImage(sponsorImage, model, ImageCacher.PredictAndWinImageType.SponsorImage, setNative: false, action, loadingIndicator);
					return;
				}
			}
		}
		GameObject gameObject3 = sponsor.gameObject;
		gameObject3.SetActive(value: false);
	}

	public PredictAndWinRewardPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj2 = this + 88;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <LoadSponsor>b__14_0(bool isSuccess)
	{
		GameObject gameObject = sponsorImage.gameObject;
		gameObject.SetActive(isSuccess);
	}
}
