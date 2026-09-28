using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RankedPlayManager : MonoBehaviour
{
	public enum PlayError
	{
		NotEnoughAces,
		CannotShowAd
	}

	public delegate void PlayRankedGameShowAdLoading();

	public delegate void PlayRankedGameCallback(bool skipAd);

	public delegate void PlayRankedGameErrorCallback(PlayError error);

	private sealed class <>c__DisplayClass36_0
	{
		public PlayRankedGameShowAdLoading loadingAction;

		public PlayRankedGameCallback playAction;

		public PlayRankedGameErrorCallback errorCallback;

		public RankedPlayManager <>4__this;

		public Action<bool> <>9__2;

		internal void <PlayRanked>b__1()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_007a: Expected I, but got O
			PlayRankedGameShowAdLoading playRankedGameShowAdLoading = loadingAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			object obj = this + 48;
			if (obj != null)
			{
				MenuAdsHandler.ShowAd((Action<bool>)obj);
				return;
			}
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)3168;
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj3);
			<>9__2 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			MenuAdsHandler.ShowAd(action);
		}

		internal void <PlayRanked>b__2(bool success)
		{
			if (success)
			{
				PlayRankedGameCallback playRankedGameCallback = playAction;
				IntPtr invoke_impl = ((Delegate)playRankedGameCallback).invoke_impl;
				IntPtr method_code = ((Delegate)playRankedGameCallback).method_code;
				IntPtr method = ((Delegate)playRankedGameCallback).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v13 @ X3_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
			PlayRankedGameErrorCallback playRankedGameErrorCallback = errorCallback;
			IntPtr invoke_impl2 = ((Delegate)playRankedGameErrorCallback).invoke_impl;
			IntPtr method_code2 = ((Delegate)playRankedGameErrorCallback).method_code;
			IntPtr method2 = ((Delegate)playRankedGameErrorCallback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v36 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <PlayRanked>g__PayToSkipAds|0()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_008e: Expected O, but got I4
			//IL_00b7: Expected O, but got I
			//IL_00ef: Expected F8, but got I4
			//IL_0119: Expected O, but got I4
			//IL_0183: Expected O, but got I4
			//IL_01eb: Expected I8, but got I4
			PlayRankedGameCallback playRankedGameCallback = playAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			RankedPlayManager rankedPlayManager = <>4__this;
			object obj = "October" + 3632;
			object obj2 = "October" + 3640;
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = typeof(Queue<string>) + 848;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = (nint)0 + (nint)2200;
			string itemId = Tracker.ItemId(ResourceItemId.AdSkip);
			int joinGamePrice = JoinGamePrice;
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, joinGamePrice, ResourceCurrency.Aces);
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
			bool flag3 = !rankedPlayManager.adsAvailable;
			object obj10 = !flag3;
			object obj11 = ~obj10;
			string action = (string)((obj11 != null) ? obj2 : obj);
			string rankName = rank.RankName;
			int joinGamePrice2 = JoinGamePrice;
			FirebaseTrack.CurrencyEvent(action, rankName, joinGamePrice2);
		}
	}

	private bool isFriendly;

	private bool adsAvailable = true;

	private Button playButton;

	private GameObject normal;

	private GameObject counter;

	private GameObject watchAd;

	private GameObject payToPlay;

	private Image payToPlayImage;

	private TextMeshProUGUI joinPriceText;

	private PayToSkipPopup skipAdPopup;

	private Image watchAdImage;

	private DiscreteProgressIndicator <remainingTrials>k__BackingField;

	private static RankedPlayCondition State
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017d: Expected I4, but got O
			//IL_0161: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6366]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.GetPlayingCondition(localUser);
			IL_016f:
			NullReferenceException ex = new NullReferenceException();
			return (RankedPlayCondition)ex;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	private static int RemainingTrials
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017d: Expected I4, but got O
			//IL_0161: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6367]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.GetJoinsAllowed(localUser);
			IL_016f:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	private static int AllowedFreeJoins
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017d: Expected I4, but got O
			//IL_0161: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6368]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.GetMaxFreeJoins(localUser);
			IL_016f:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	private static int JoinGamePrice
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_00ca: Expected I4, but got O
			int state = (int)State;
			if (state != 0)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					return SFSKammelnaUserExtensions.GetJoinRankedGamePrice(localUser);
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
			return state;
		}
	}

	private DiscreteProgressIndicator remainingTrials
	{
		get
		{
			return <remainingTrials>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Start()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0116: Expected I, but got O
		//IL_0156: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0171: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01af: Expected I, but got O
		//IL_01e2: Expected I, but got O
		//IL_0211: Expected O, but got I4
		object obj = (nint)0 + (nint)1520;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		object obj4 = this + 112;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1472;
		object varName = "https://www.kammelna.com/Home/Terms" + 4048;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = (nint)0 + (nint)1480;
		object varName2 = "not" + 3704;
		object obj11 = (nint)0 + (nint)1464;
		object obj12 = typeof(RegisteredWaitHandle) + 56;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		VariableBinderExtensions.Bind(go2, localUser2, (string)varName2, action2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj11);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v29+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action3;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1464;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void OnConfigChanged()
	{
		RankedPlayCondition state = State;
		UpdatePlayingCondition(state);
	}

	public void EnablePlayButton()
	{
		playButton.interactable = true;
	}

	public void DisablePlayButton()
	{
		playButton.interactable = false;
	}

	public void ShowRankedState()
	{
		isFriendly = false;
		RankedPlayCondition state = State;
		UpdatePlayingCondition(state);
	}

	public void ShowFriendlyState()
	{
		isFriendly = true;
		RankedPlayCondition state = State;
		UpdatePlayingCondition(state);
	}

	private void UpdateJoinsAllowed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E636C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <remainingTrials>k__BackingField;
			obj6 = <remainingTrials>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = <remainingTrials>k__BackingField;
			obj6 = <remainingTrials>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		int currentProgress = RemainingTrials;
		<remainingTrials>k__BackingField.CurrentProgress = currentProgress;
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	private void UpdateAllowedFreeJoins()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C7]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <remainingTrials>k__BackingField;
			obj6 = <remainingTrials>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = <remainingTrials>k__BackingField;
			obj6 = <remainingTrials>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		int allowedFreeJoins = AllowedFreeJoins;
		<remainingTrials>k__BackingField.MaxProgress = allowedFreeJoins;
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	public void PlayRanked(PlayRankedGameCallback playAction, PlayRankedGameShowAdLoading loadingAction, PlayRankedGameErrorCallback errorCallback)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_01bc: Expected F8, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0537: Expected O, but got I
		//IL_0547: Expected O, but got I
		//IL_0557: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_0223: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_028c: Expected I8, but got I4
		object typeFromHandle = typeof(<>c__DisplayClass36_0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		object obj2 = obj + 16;
		obj2 = loadingAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj + 24;
		obj3 = playAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj + 32;
		obj4 = errorCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj + 40;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RankedPlayCondition state = State;
		if (state != RankedPlayCondition.CanPlay)
		{
			int num = RemainingTrials;
			if (num <= 0)
			{
				if (state == RankedPlayCondition.MustPay)
				{
					object obj6 = typeof(Queue<string>) + 848;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v61+E4]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					User localUser = sessionModel.LocalUser;
					int aces = SFSKammelnaUserExtensions.GetAces(localUser);
					int joinGamePrice = JoinGamePrice;
					if (aces >= joinGamePrice)
					{
						goto IL_00e9;
					}
				}
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+18]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+40]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v247 @ X3_v4 (should have been resolved before IL gen)");
				((<>c__DisplayClass36_0)obj).<PlayRanked>g__PayToSkipAds|0();
				return;
			}
		}
		goto IL_00e9;
		IL_00e9:
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ X8_v5+18] (should have been resolved before IL gen)");
		RankedPlayCondition state2 = State;
		if (state2 == RankedPlayCondition.MustPay)
		{
			object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string itemId = Tracker.ItemId(ResourceItemId.RoomJoin);
			int joinGamePrice2 = JoinGamePrice;
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, joinGamePrice2, ResourceCurrency.Aces);
			object obj18 = typeof(Queue<string>) + 848;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v27+E4]");
			bool flag3 = (nint)0 == 0;
			object obj20 = !flag3;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj21 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser2);
			string rankName = rank.RankName;
			int joinGamePrice3 = JoinGamePrice;
			object action = "October" + 3624;
			FirebaseTrack.CurrencyEvent((string)action, rankName, joinGamePrice3);
		}
	}

	private unsafe Image GetButtonImage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_02b4: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected I4, but got Unknown
		//IL_0296: Expected O, but got I4
		//IL_02d8: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_013a: Expected O, but got I
		object obj = 152985600;
		int num = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E636E]");
		object obj2 = (nint)0 & (nint)1;
		int num2;
		int num3;
		if (obj2 != null)
		{
			num2 = (int)((nint)0 + (nint)2200);
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6 (System.Int32)+E4]");
			bool flag = (nint)0 == 0;
			num3 = num2;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			num2 = (int)((nint)0 + (nint)2200);
			int value = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6 (System.Int32)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			num3 = num2;
			if (obj3 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj4 = !flag3;
		num2 = num3;
		if (obj4 != null)
		{
			goto IL_00bd;
		}
		goto IL_01da;
		IL_01e8:
		RankedPlayCondition state = State;
		bool flag4;
		bool flag5;
		if (state == RankedPlayCondition.ShouldPay)
		{
			object obj5 = num - num2;
			flag4 = (nint)obj5 < 0;
			int num4 = num ^ num2;
			int num5 = num ^ obj5;
			int num6 = num4 & num5;
			flag5 = num6 < 0;
		}
		else
		{
			flag5 = false;
			flag4 = false;
		}
		bool flag6 = flag4 == flag5;
		object obj6 = !flag6;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			object obj8 = 104;
		}
		else
		{
			object obj8 = 80;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RankedPlayManager)+v193 @ X8_v4]");
		return (Image)0;
		IL_00bd:
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		int joinGamePrice = JoinGamePrice;
		RankedPlayCondition state2 = State;
		bool flag7 = state2 != RankedPlayCondition.ShouldWatchAds;
		num = aces;
		num2 = joinGamePrice;
		if (!flag7)
		{
			object obj9 = 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RankedPlayManager)+v159 @ X8_v12]");
			return (Image)0;
		}
		goto IL_01e8;
		IL_01da:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e8;
		IL_0096:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00bd;
		}
		goto IL_01da;
	}

	public void UpdatePlayingCondition()
	{
		RankedPlayCondition state = State;
		UpdatePlayingCondition(state);
	}

	public unsafe void UpdatePlayingCondition(RankedPlayCondition condition)
	{
		//IL_086f: Expected I4, but got O
		//IL_001d: Expected I, but got O
		//IL_0036: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_00ff: Expected I, but got O
		//IL_021f: Expected I4, but got O
		//IL_0117: Expected I, but got O
		//IL_01c4: Expected O, but got I4
		//IL_01c9: Expected I, but got O
		//IL_01db: Expected I, but got O
		//IL_0241: Expected I, but got O
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected I4, but got Unknown
		//IL_0284: Expected O, but got I4
		//IL_028c: Expected I4, but got O
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_0305: Expected O, but got I4
		//IL_031b: Expected O, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036e: Expected O, but got I
		//IL_037a: Expected O, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_03b9: Expected I, but got O
		//IL_03c1: Expected I, but got O
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I4
		//IL_04f9: Expected O, but got I4
		//IL_0501: Expected I4, but got O
		//IL_0421: Expected O, but got I4
		//IL_0429: Expected I4, but got O
		//IL_0439: Expected I4, but got O
		//IL_045c: Expected I, but got O
		//IL_055d: Expected O, but got I4
		//IL_0566: Expected O, but got I4
		//IL_056e: Expected I4, but got O
		//IL_05a1: Expected O, but got I4
		//IL_05a9: Expected I4, but got O
		//IL_05e5: Expected O, but got I4
		//IL_07bf: Expected O, but got I4
		//IL_062e: Expected O, but got I4
		//IL_0637: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C8]");
		bool flag = false;
		TextMeshProUGUI textMeshProUGUI = joinPriceText;
		int joinGamePrice = JoinGamePrice;
		int num = default(int);
		string text = num.ToString();
		bool flag2 = (object)joinPriceText == null;
		Action<object> action = null;
		int num2 = (int)joinPriceText;
		UnityEngine.Object obj3;
		nint num6;
		bool flag6;
		nint num5;
		if (!flag2)
		{
			nint num3 = (nint)textMeshProUGUI;
			joinPriceText.text = text;
			object obj = 152985600;
			int num4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C7]");
			object obj2 = (nint)0 & (nint)1;
			bool flag4;
			UnityEngine.Object obj4;
			if (obj2 != null)
			{
				int value = ((int*)num4)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				flag = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				bool flag3 = (byte)(~(nuint)0u) != 0;
				obj3 = <remainingTrials>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				flag4 = false;
				obj4 = <remainingTrials>k__BackingField;
				if (!flag3)
				{
					goto IL_00dd;
				}
			}
			else
			{
				_ = 1;
				int value = ((int*)num4)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				flag = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				bool flag5 = (byte)(~(nuint)0u) != 0;
				object obj5 = !flag5;
				obj3 = <remainingTrials>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v45 (System.Int32)+E4]");
				flag4 = false;
				obj4 = <remainingTrials>k__BackingField;
				if (obj5 != null)
				{
					goto IL_00dd;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag6 = obj4 == null;
			bool flag7 = !flag6;
			object obj6 = !flag7;
			num5 = unchecked((nint)null);
			action = null;
			flag = flag4;
			num6 = unchecked((nint)null);
			obj3 = obj4;
			if (obj6 == null)
			{
				goto IL_01f1;
			}
			goto IL_0246;
		}
		goto IL_065a;
		IL_06f5:
		GameObject gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_0760:
		gameObject = watchAd;
		bool flag8 = (object)watchAd == null;
		object obj7 = !flag8;
		if (obj7 == null)
		{
			goto IL_065a;
		}
		goto IL_06f5;
		IL_06cc:
		gameObject = normal;
		if ((object)normal == null)
		{
			goto IL_065a;
		}
		goto IL_06f5;
		IL_0246:
		flag = (byte)(typeof(TypeConverter<ushort, char>) + 2568) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag9 = enumerable == null;
		num5 = num6;
		action = (Action<object>)3;
		num2 = (int)obj3;
		if (!flag9)
		{
			object obj8 = enumerable + 32;
			obj8 = normal;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = enumerable + 40;
			obj9 = counter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X22_v12-10]");
			bool flag10 = (nint)0 < (nint)2;
			object obj10 = !flag10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X22_v12-10]");
			object obj11 = -2;
			bool flag11 = obj11 == null;
			object obj12 = ~obj10;
			object obj13 = obj12 | flag11;
			if (obj13 != null)
			{
				throw new IndexOutOfRangeException();
			}
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
			object obj15 = (nint)0 + (nint)1960;
			object obj16 = (nint)0 + (nint)2160;
			object obj17 = enumerable + 48;
			obj17 = payToPlay;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)null, (IntPtr)obj15);
			num5 = (nint)obj16;
			ArraysExtensions.ForEach(enumerable, action2);
			flag = adsAvailable;
			bool flag12 = !adsAvailable;
			action = action2;
			object obj18;
			int num4;
			if (!flag12)
			{
				bool flag13 = (object)watchAd == null;
				obj18 = 0;
				num4 = (int)action2;
				action = action2;
				num2 = (int)enumerable;
				if (flag13)
				{
					goto IL_065a;
				}
				watchAd.SetActive(value: false);
				num5 = unchecked((nint)null);
				action = null;
			}
			object obj19 = typeof(Queue<string>) + 848;
			num2 = (int)((nint)0 + (nint)2200);
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v31+E4]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v31+E4]");
			bool flag14 = (byte)(~(nuint)0u) != 0;
			object obj21 = !flag14;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag15 = (object)sessionModel == null;
			obj18 = 0;
			num4 = (int)action2;
			if (!flag15)
			{
				User localUser = sessionModel.LocalUser;
				int aces = SFSKammelnaUserExtensions.GetAces(localUser);
				int joinGamePrice2 = JoinGamePrice;
				flag = isFriendly;
				bool flag16 = !isFriendly;
				object obj22 = !flag16;
				obj18 = 0;
				num4 = (int)action2;
				action = null;
				num2 = aces;
				if (obj22 == null)
				{
					bool flag17 = condition == RankedPlayCondition.CanPlay;
					obj18 = 0;
					num4 = (int)action2;
					action = null;
					num2 = aces;
					if (!flag17)
					{
						int num7 = RemainingTrials;
						flag12 = num7 < 1;
						obj18 = 0;
						num4 = joinGamePrice2;
						action = null;
						num2 = aces;
						if (!flag12)
						{
							gameObject = counter;
							bool flag18 = (object)counter == null;
							object obj23 = !flag18;
							obj18 = 0;
							num4 = joinGamePrice2;
							action = null;
							num2 = aces;
							if (obj23 == null)
							{
								goto IL_065a;
							}
						}
						else
						{
							bool flag20;
							bool flag21;
							if (condition != RankedPlayCondition.ShouldWatchAds)
							{
								if (condition != RankedPlayCondition.ShouldPay)
								{
									bool flag19 = condition == RankedPlayCondition.MustPay;
									flag20 = flag12;
									flag21 = flag;
									if (!flag19)
									{
										goto IL_06cc;
									}
								}
								else
								{
									flag20 = num2 >= num4;
									flag21 = flag;
									if (!flag20)
									{
										flag = adsAvailable;
										bool flag22 = (byte)(~(adsAvailable ? 1u : 0u)) != 0;
										flag12 = flag20;
										flag21 = adsAvailable;
										if (!flag22)
										{
											goto IL_0760;
										}
									}
								}
							}
							else
							{
								flag = adsAvailable;
								bool flag23 = !adsAvailable;
								object obj24 = !flag23;
								flag20 = flag12;
								flag21 = adsAvailable;
								if (obj24 != null)
								{
									goto IL_0760;
								}
							}
							gameObject = payToPlay;
							bool flag24 = (object)payToPlay == null;
							object obj25 = !flag24;
							if (obj25 == null)
							{
								flag12 = flag20;
								flag = flag21;
								goto IL_065a;
							}
						}
						goto IL_06f5;
					}
				}
				goto IL_06cc;
			}
		}
		goto IL_065a;
		IL_00dd:
		flag6 = obj3 == null;
		bool flag25 = !flag6;
		num5 = unchecked((nint)null);
		action = null;
		if (flag25)
		{
			goto IL_01f1;
		}
		num6 = unchecked((nint)null);
		goto IL_0246;
		IL_01f1:
		obj3 = <remainingTrials>k__BackingField;
		int allowedFreeJoins = AllowedFreeJoins;
		bool flag26 = (object)<remainingTrials>k__BackingField == null;
		num2 = (int)<remainingTrials>k__BackingField;
		if (!flag26)
		{
			<remainingTrials>k__BackingField.MaxProgress = allowedFreeJoins;
			num6 = unchecked((nint)null);
			goto IL_0246;
		}
		goto IL_065a;
		IL_065a:
		throw new NullReferenceException();
	}

	public bool RequiredForAds(object obj)
	{
		//IL_001a: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~(adsAvailable ? 1 : 0);
		object obj4 = obj2 | obj3;
		return (byte)(obj4 & 1) != 0;
	}
}
