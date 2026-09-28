using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Mono.Btls;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PredictionLeaderboard : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PredictionSeasonRewardPopup> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShowMorePopup>b__12_0(PredictionSeasonRewardPopup popup)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0040: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1568;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object source = 0;
			IEnumerable<object> models = Enumerable.Skip((IEnumerable<object>)source, 3);
			popup.Show((IEnumerable<PredictionSeasonRewardModel>)models);
		}
	}

	public static List<PredictionSeasonRewardModel> Rewards;

	private GameObject rewardsContainer;

	private LeaderBoardUI leaderboard;

	private Button morePrizesButton;

	private ComponentReference<PredictionSeasonRewardPopup> morePrizesPopup;

	private GameObject onePrizeContainer;

	private PredictionTopPrize onePrizeTemplate;

	private GameObject twoPrizesContainer;

	private PredictionTopPrize[] twoPrizesTemplates;

	private GameObject threePrizesContainer;

	private PredictionTopPrize[] threePrizesTemplates;

	private void Awake()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_0102: Expected I, but got O
		//IL_00a6: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_015c: Expected I, but got O
		leaderboard.Initialize();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1568;
		rewardsContainer.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+B8]");
		object obj3 = 0;
		List<PredictionSeasonRewardModel> rewards = (List<PredictionSeasonRewardModel>)obj3;
		Button button;
		if (obj3 != null)
		{
			PopulateRewards(rewards);
			button = morePrizesButton;
			bool flag = (object)morePrizesButton == null;
			object obj4 = !flag;
			nint num = 0;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1720;
			nint num = (nint)obj6;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj6);
			KammelnaRequests.GetPredictionSeason(action);
			button = morePrizesButton;
			rewards = null;
		}
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button.m_OnClick.AddListener(unityAction);
	}

	private void ShowMorePopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64FB]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<PredictionSeasonRewardPopup> componentReference2;
		object obj4;
		ComponentReference<PredictionSeasonRewardPopup> componentReference;
		if (obj3 != null)
		{
			componentReference = morePrizesPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = morePrizesPopup;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = morePrizesPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = morePrizesPopup;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2272;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)1712;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2272;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	private void OnRewardsLoaded(KammelnaResponseModel<PredictionSeasonModel> response)
	{
		//IL_005a: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			PredictionSeasonModel <Model>k__BackingField = response.<Model>k__BackingField;
			PopulateRewards(<Model>k__BackingField.<Rewards>k__BackingField);
			return;
		}
		object obj = (nint)0 + (nint)1336;
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.ShowError(errorMessage);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowError(errorMessage);
	}

	private void PopulateRewards(List<PredictionSeasonRewardModel> rewards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected I4, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I4, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I4, but got Unknown
		//IL_01e4: Expected O, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected I4, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_029d: Expected O, but got I
		//IL_02d1: Expected O, but got I4
		//IL_0384: Expected O, but got I
		//IL_03b8: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1568;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!Enumerable.Any((IEnumerable<object>)rewards))
		{
			return;
		}
		rewardsContainer.SetActive(value: true);
		GameObject gameObject = morePrizesButton.gameObject;
		object obj3 = rewards._size - 3;
		bool flag = (nint)obj3 < 0;
		bool flag2 = obj3 == null;
		int num = rewards._size ^ 3;
		int num2 = rewards._size ^ obj3;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		bool active = (byte)((flag4 & obj4) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		object obj5 = rewards._size - 1;
		bool active2 = obj5 == null;
		onePrizeContainer.SetActive(active2);
		object obj6 = rewards._size - 2;
		bool active3 = obj6 == null;
		twoPrizesContainer.SetActive(active3);
		object obj7 = rewards._size - 2;
		bool flag5 = (nint)obj7 < 0;
		bool flag6 = obj7 == null;
		int num4 = rewards._size ^ 2;
		int num5 = rewards._size ^ obj7;
		int num6 = num4 & num5;
		bool flag7 = num6 < 0;
		bool flag8 = flag5 == flag7;
		object obj8 = !flag6;
		bool active4 = (byte)((flag8 & obj8) ? 1 : 0) != 0;
		threePrizesContainer.SetActive(active4);
		if (rewards._size != 1)
		{
			if (rewards._size == 2)
			{
				PredictionTopPrize[] array = twoPrizesTemplates;
				int num7 = 0;
				object obj10;
				do
				{
					if (num7 < array.Length)
					{
						object obj9 = array + num7;
						object reward = ((List<object>)(object)rewards).get_Item(num7);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v19+20]");
						((PredictionTopPrize)0).Populate((PredictionSeasonRewardModel)reward);
						array = twoPrizesTemplates;
						num7++;
						bool flag9 = twoPrizesTemplates == null;
						obj10 = !flag9;
						continue;
					}
					return;
				}
				while (obj10 != null);
			}
			else
			{
				if (rewards._size < 3)
				{
					return;
				}
				PredictionTopPrize[] array2 = threePrizesTemplates;
				int num8 = 0;
				object obj12;
				do
				{
					if (num8 < array2.Length)
					{
						object obj11 = array2 + num8;
						object reward2 = ((List<object>)(object)rewards).get_Item(num8);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v15+20]");
						((PredictionTopPrize)0).Populate((PredictionSeasonRewardModel)reward2);
						array2 = threePrizesTemplates;
						num8++;
						bool flag10 = threePrizesTemplates == null;
						obj12 = !flag10;
						continue;
					}
					return;
				}
				while (obj12 != null);
			}
			throw new NullReferenceException();
		}
		object reward3 = ((List<object>)(object)rewards).get_Item(0);
		onePrizeTemplate.Populate((PredictionSeasonRewardModel)reward3);
	}
}
