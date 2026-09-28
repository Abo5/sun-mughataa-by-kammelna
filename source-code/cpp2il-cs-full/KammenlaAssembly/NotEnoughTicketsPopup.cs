using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Server.Models.Products;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class NotEnoughTicketsPopup : MonoBehaviour
{
	private PopupUI popup;

	public TextMeshProUGUI TicketPrice;

	public TextMeshProUGUI PurchaseSuccessful;

	public Button BuyTicketButton;

	public GridLayoutGroup GoldenCardsGrid;

	public StoreProductUi productPrefab;

	public TextMeshProUGUI CurrencyStatus;

	private bool isStoreItemsInitialized;

	private void Start()
	{
		AssignButtonListeners();
		RegisterEventListeners();
		InitGoldenCards();
		InitBuyTicketButton();
		InitTitle();
	}

	private void OnDestroy()
	{
		UnRegisterEventListeners();
	}

	private void CheckTicketsOwned()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0168: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77B1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		int fTTicketsOwned = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser);
		if (fTTicketsOwned >= 1)
		{
			StartSuccessfullPurchaseAnimation();
		}
	}

	private void StartSuccessfullPurchaseAnimation()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_008f: Expected I, but got O
		object obj = (nint)0 + (nint)2904;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3408;
		object obj4 = (nint)0 + (nint)2504;
		Transform target = BuyTicketButton.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, 0.7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0292: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00c4: Expected I, but got O
		//IL_0109: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_0159: Expected I, but got O
		//IL_016a: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01bc: Expected I, but got O
		//IL_01e6: Expected O, but got I4
		//IL_0227: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_025f: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3440;
		object varName = "___# Content push apply failed [{0}]: {1}" + 2920;
		object obj7 = typeof(Queue<string>) + 752;
		object obj8 = (nint)0 + (nint)2024;
		object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3448;
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)3432;
		object obj14 = typeof(UsageHint) + 72;
		object obj15 = typeof(RegisteredWaitHandle) + 56;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseFailed += iAPFailure;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj13);
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)3440;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj18);
		object obj19 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action3;
	}

	private void Init()
	{
		InitGoldenCards();
		InitBuyTicketButton();
		InitTitle();
	}

	private void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_01e6: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d2: Expected I, but got O
		//IL_00fc: Expected O, but got I4
		//IL_013f: Expected I, but got O
		//IL_0169: Expected O, but got I4
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj4 = (nint)0 + (nint)3448;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj4);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3432;
		object obj9 = typeof(UsageHint) + 72;
		object obj10 = (nint)0 + (nint)3440;
		object obj11 = typeof(RegisteredWaitHandle) + 56;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseFailed -= iAPFailure;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
	}

	private void InitBuyTicketButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_025d: Expected F8, but got I4
		//IL_0274: Expected O, but got I4
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected I4, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_02fe: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77B5]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI text;
		TextMeshProUGUI ticketPrice;
		if (obj3 != null)
		{
			text = TicketPrice;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			ticketPrice = TicketPrice;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			text = TicketPrice;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			ticketPrice = TicketPrice;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		text = ticketPrice;
		goto IL_013e;
		IL_013e:
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		TextMeshProExtensions.SetPriceText(text, <FastTrack>k__BackingField.<TicketPrice>k__BackingField);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		RemoteConfigModel current2 = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField2 = current2.<FastTrack>k__BackingField;
		double num = ((aces < <FastTrack>k__BackingField2.<TicketPrice>k__BackingField) ? 1053609165.0 : 1.0);
		object obj10 = aces - <FastTrack>k__BackingField2.<TicketPrice>k__BackingField;
		bool flag4 = (nint)obj10 < 0;
		int num2 = aces ^ <FastTrack>k__BackingField2.<TicketPrice>k__BackingField;
		int num3 = aces ^ obj10;
		int num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool interactable = flag4 == flag5;
		BuyTicketButton.interactable = interactable;
		TicketPrice.color = (Color)0;
		object obj11 = (nint)0 + (nint)3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		CanvasGroup canvasGroup = default(CanvasGroup);
		canvasGroup.alpha = (float)num;
		return;
		IL_0091:
		current = RemoteConfig.Current;
		bool flag6 = current == null;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013e;
	}

	private void InitTitle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0243: Expected O, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0338: Expected I, but got O
		//IL_0348: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02d9: Expected I, but got O
		//IL_02e9: Expected O, but got I
		//IL_02f9: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77B6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object currencyStatus;
		UnityEngine.Object currencyStatus2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			currencyStatus = CurrencyStatus;
			currencyStatus2 = CurrencyStatus;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			currencyStatus = CurrencyStatus;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			currencyStatus2 = CurrencyStatus;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = currencyStatus2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj13 = typeof(RegisteredWaitHandle) + 56;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		if (aces < <FastTrack>k__BackingField.<TicketPrice>k__BackingField)
		{
			object text = "Network Authentication Required" + 728;
			TextMeshProExtensions.Localize(CurrencyStatus, (string)text);
			TextMeshProUGUI currencyStatus3 = CurrencyStatus;
			nint num = (nint)currencyStatus3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v160 @ X2_v6 (should have been resolved before IL gen)");
		}
		object text2 = "AvailableVoices" + 3120;
		TextMeshProExtensions.Localize(CurrencyStatus, (string)text2);
		TextMeshProUGUI currencyStatus4 = CurrencyStatus;
		nint num2 = (nint)currencyStatus4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v14 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0091:
		bool flag7 = currencyStatus == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0170;
	}

	private void InitGoldenCards()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0307: Expected O, but got I
		//IL_0315: Expected I, but got O
		//IL_032f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77B7]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object goldenCardsGrid;
		UnityEngine.Object goldenCardsGrid2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			goldenCardsGrid = GoldenCardsGrid;
			goldenCardsGrid2 = GoldenCardsGrid;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			goldenCardsGrid = GoldenCardsGrid;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			goldenCardsGrid2 = GoldenCardsGrid;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = goldenCardsGrid2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = productPrefab == null;
			bool flag6 = !flag5;
			object obj10 = !flag6;
			if (obj10 != null)
			{
				return;
			}
			object obj11 = 0;
			UnityEngine.Object obj12 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = productPrefab == null;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			object obj11 = 0;
			UnityEngine.Object obj12 = null;
			if (obj13 != null)
			{
				return;
			}
		}
		bool flag9 = !isStoreItemsInitialized;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			object obj15 = typeof(Queue<string>) + 752;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v4+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = (nint)0 + (nint)2024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj19 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)3400;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj20);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v7+20]");
			((OneShotEvent)0).CallWhenReady(action);
			isStoreItemsInitialized = true;
		}
		return;
		IL_0091:
		bool flag11 = goldenCardsGrid == null;
		bool flag12 = !flag11;
		obj7 = 0;
		obj8 = null;
		if (!flag12)
		{
			return;
		}
		goto IL_0170;
	}

	private void OnBackButtonClick()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0091: Expected O, but got I
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			object obj = typeof(Queue<string>) + 840;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ScreenManager screenManager = default(ScreenManager);
			screenManager.Back();
		}
	}

	private void AssignButtonListeners()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button buyTicketButton = BuyTicketButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(null, (IntPtr)obj2);
		buyTicketButton.m_OnClick.AddListener(unityAction);
	}

	private static void BuyFTTicket()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77BA]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		if (aces < <FastTrack>k__BackingField.<TicketPrice>k__BackingField)
		{
			return;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int fTTicketsOwned = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		int fTMaximumTicketsAllowed = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser3);
		if (fTTicketsOwned < fTMaximumTicketsAllowed)
		{
			object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				Store.BuyFTTicket();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Store.BuyFTTicket();
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private void OnIAPPurchaseFailed(ProductListingModel product, string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(error);
	}

	public static void OpenPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77BC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NotEnoughTicketsPopupManager.ShowPopup();
		return;
		IL_007c:
		NotEnoughTicketsPopupManager.ShowPopup();
	}

	private void <StartSuccessfullPurchaseAnimation>b__11_0()
	{
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_00fb: Expected I, but got O
		GameObject gameObject = PurchaseSuccessful.gameObject;
		gameObject.SetActive(value: true);
		Transform transform = PurchaseSuccessful.transform;
		object obj = (nint)0 + (nint)2904;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3416;
		object obj4 = (nint)0 + (nint)2504;
		object obj5 = typeof(UsageHint) + 816;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v8+B8]");
		object obj7 = 0;
		transform.localScale = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensionsTMPText.DOScale(PurchaseSuccessful, 1f, 1.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <StartSuccessfullPurchaseAnimation>b__11_1()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object methodName = "October" + 288;
		Invoke((string)methodName, 0.5f);
	}

	private void <InitGoldenCards>b__17_0()
	{
		//IL_000d: Expected O, but got I
		//IL_067f: Expected O, but got I4
		//IL_0691: Expected O, but got I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002e: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_0733: Expected O, but got I
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		//IL_075f: Expected O, but got I
		//IL_0773: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_0575: Expected I4, but got O
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_05bf: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0195: Expected O, but got I
		//IL_046d: Expected O, but got I4
		//IL_0476: Expected O, but got I4
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_08b0: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0493: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_04ce: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_0811: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I4
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04f7: Expected O, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0307: Expected O, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_058b: Expected I4, but got O
		object obj = (nint)0 + (nint)880;
		IEnumerable<ProductViewModel> goldenCards = IAPController.GoldenCards;
		GiftInfo giftInfo = (GiftInfo)obj;
		IEnumerable<object> enumerable = Enumerable.Take((IEnumerable<object>)goldenCards, 4);
		bool flag = enumerable == null;
		object obj2 = 0;
		int num = 4;
		StoreProductUi storeProductUi = (StoreProductUi)152989696;
		if (flag)
		{
			goto IL_069f;
		}
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3640;
		nint num2 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
			object obj6 = 0 - obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj7 = obj5 + 16;
			obj4--;
			obj6 = obj4 - 1;
			bool flag4 = obj6 == null;
			flag3 = (nint)obj4 != 1;
			flag2 = flag3;
			obj5 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_00f6;
		}
		object obj8 = num2 + obj5;
		object obj9 = obj8 + 312;
		flag3 = flag2;
		obj7 = obj5;
		goto IL_06eb;
		IL_06eb:
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1072;
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj13 = (nint)0 + (nint)728;
		object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v14+8]");
		ProductViewModel productViewModel = (ProductViewModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v297 @ X8_v14] (should have been resolved before IL gen)");
		storeProductUi = (StoreProductUi)152989696;
		object obj16 = default(object);
		StoreProductUi storeProductUi2 = default(StoreProductUi);
		ProductViewModel productViewModel2 = default(ProductViewModel);
		object obj24 = default(object);
		object obj36 = default(object);
		object obj29;
		while (true)
		{
			if (obj16 != null)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v18+12E]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_021a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v18+B0]");
				object obj18 = (nint)0 + (nint)8;
				bool flag5 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v24-8]");
					object obj6 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X10_v24-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj7 = obj18 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v18+12E]");
					obj15 = -1;
					obj6 = obj15 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj15 != 1;
					flag5 = flag3;
					obj18 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_021a;
				}
				obj15 = obj18;
				object obj19 = obj17 + obj18;
				object obj20 = obj19 + 312;
				flag3 = flag5;
				obj7 = obj18;
				goto IL_07b9;
			}
			NullReferenceException ex = new NullReferenceException();
			num = (int)productViewModel;
			break;
			IL_021a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo = null;
			goto IL_07b9;
			IL_083f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v34+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v665 @ X0_v34] (should have been resolved before IL gen)");
			if ((object)GoldenCardsGrid != null)
			{
				storeProductUi = productPrefab;
				Transform transform = GoldenCardsGrid.transform;
				object obj21 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v40+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				giftInfo = (GiftInfo)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				if ((object)storeProductUi2 != null)
				{
					storeProductUi2.PopulateProduct(productViewModel2);
					productViewModel = productViewModel2;
					giftInfo = null;
					continue;
				}
				NullReferenceException ex2 = new NullReferenceException();
				num = (int)transform;
				break;
			}
			NullReferenceException ex3 = new NullReferenceException();
			break;
			IL_035b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo = null;
			goto IL_083f;
			IL_07b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v30+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X0_v30] (should have been resolved before IL gen)");
			object obj23 = obj24 & 1;
			if (obj23 != null)
			{
				if (obj16 != null)
				{
					object obj25 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v21+12E]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v21+12E]");
					if ((nint)0 == 0)
					{
						goto IL_035b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v21+B0]");
					object obj26 = (nint)0 + (nint)8;
					bool flag7 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X10_v19-8]");
						object obj6 = 0 - obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X10_v19-8]");
						if (0 == (nint)obj11)
						{
							break;
						}
						obj7 = obj26 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v21+12E]");
						obj15 = -1;
						obj6 = obj15 - 1;
						bool flag4 = obj6 == null;
						flag3 = (nint)obj15 != 1;
						flag7 = flag3;
						obj26 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_035b;
					}
					obj15 = obj26;
					object obj27 = obj25 + obj26;
					object obj28 = obj27 + 312;
					flag3 = flag7;
					obj7 = obj26;
					goto IL_083f;
				}
				NullReferenceException ex4 = new NullReferenceException();
				break;
			}
			obj2 = obj16;
			obj29 = 0;
			object obj30 = 0;
			while (true)
			{
				if (obj2 == null)
				{
					goto IL_0896;
				}
				object obj31 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v5+12E]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v5+12E]");
				if ((nint)0 == 0)
				{
					goto IL_051f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v5+B0]");
				object obj32 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X10_v7-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					obj7 = obj32 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v5+12E]");
					obj15 = -1;
					bool flag8 = (nint)obj15 != 1;
					obj32 = obj7;
					if (flag8)
					{
						continue;
					}
					goto IL_051f;
				}
				obj15 = obj32;
				object obj33 = obj31 + obj32;
				object obj34 = obj33 + 312;
				obj7 = obj32;
				goto IL_08e2;
				IL_0896:
				bool flag9 = obj30 == null;
				object obj35 = !flag9;
				if (obj35 == null)
				{
					return;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if (num != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj30 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj29 = obj36;
				continue;
				IL_051f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo = null;
				goto IL_08e2;
				IL_08e2:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v7+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v7] (should have been resolved before IL gen)");
				goto IL_0896;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		obj2 = obj16;
		obj29 = 0;
		goto IL_069f;
		IL_069f:
		throw new NullReferenceException();
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		giftInfo = null;
		object obj37 = default(object);
		obj9 = obj37;
		goto IL_06eb;
	}
}
