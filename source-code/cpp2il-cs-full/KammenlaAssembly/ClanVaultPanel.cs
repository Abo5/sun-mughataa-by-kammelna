using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanVaultPanel : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanVaultTransactionModel, int, VaultTransactionDataHolder> <>9__36_0;

		public static Func<ClanVaultTransactionModel, long> <>9__36_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal VaultTransactionDataHolder <RenderTransactions>b__36_0(ClanVaultTransactionModel model, int index)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (VaultTransactionDataHolder)obj2;
		}

		internal long <RenderTransactions>b__36_1(ClanVaultTransactionModel t)
		{
			//IL_0035: Expected I8, but got O
			if (t != null)
			{
				return t.Id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	private const string REQUEST_PENDING_KEY = "clan_support_request_pending";

	private Image balanceImage;

	private TextMeshProUGUI balanceText;

	private Sprite emptySprite;

	private Sprite mediumSprite;

	private Sprite fullSprite;

	private Image secondaryBalanceImage;

	private Sprite secondaryEmptySprite;

	private Sprite secondaryMediumSprite;

	private Sprite secondaryFullSprite;

	private float fadeDuration;

	private VaultTransactionListView transactionsListView;

	private int transactionsLimit;

	private Button requestDonationsButton;

	private TextMeshProUGUI _requestDonationsLabel;

	private readonly string REQUEST_DONATIONS_KEY;

	private List<ClanVaultVisualTierConfig> _visualTiers;

	private int _lastBalance;

	private bool _reloadingTransactions;

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00f3: Expected I, but got O
		//IL_007f: Expected I, but got O
		//IL_00a9: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		object obj2 = (nint)0 + (nint)1720;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1712;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		Initialize(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action2;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01db: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1472;
		object obj2 = (nint)0 + (nint)1720;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1712;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnClanFeedAdded -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
		int num = ShortcutExtensions.DOKill(balanceImage);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			if (secondaryBalanceImage != null)
			{
				goto IL_0135;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = secondaryBalanceImage != null;
			bool flag3 = !flag2;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0135;
			}
		}
		goto IL_014e;
		IL_0135:
		int num2 = ShortcutExtensions.DOKill(secondaryBalanceImage);
		goto IL_014e;
		IL_014e:
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
	}

	public void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E862D]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			bool canManage = CanManageVault();
			trackEvent = TrackerLibrary.ClanVaultViewed(canManage);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			_ = 1;
			bool canManage2 = CanManageVault();
			trackEvent = TrackerLibrary.ClanVaultViewed(canManage2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			trackEvent2 = trackEvent;
			if (obj6 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_00a9:
		Tracker.DesignEvent(trackEvent);
	}

	public void Initialize(int currentBalance)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_005b: Expected I, but got O
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0144: Expected I, but got O
		//IL_0186: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1728;
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		CoordinatorVariableBinderExtensions.Bind(go2, (string)scope, (string)variableName, action);
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		GameObject go3 = requestDonationsButton.gameObject;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = (nint)0 + (nint)1704;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3304;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		VariableBinderExtensions.Bind(go3, localUser, (string)varName, action2, this);
		int balance;
		bool flag2 = TryGetBoundBalance(out balance);
		bool flag3 = !flag2;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		UpdateBalanceDisplay(balance);
		LoadVisualTiers();
		ApplyPermissions();
		LoadTransactions();
	}

	public void Reload()
	{
		LoadTransactions();
	}

	private void OnFeedAdded(ClanFeedModel feed)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0152: Expected O, but got I
		if (feed == null)
		{
			return;
		}
		ClanFeedData data = feed.Data;
		if (feed.Data == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 136;
		object obj2 = obj;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v2+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v2+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X11_v6-8]");
			if (0 == (nint)obj2)
			{
				goto IL_0177;
			}
		}
		object obj6 = typeof(UsageHint) + 712;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v6+130]");
		bool flag2 = num4 < 0;
		object obj8 = !flag2;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v6+130]");
			object obj10 = num5 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8-8]");
			if (0 != (nint)obj7)
			{
				return;
			}
			goto IL_0177;
		}
		return;
		IL_0177:
		RefreshRequestDonationsInteractable();
	}

	private void OnVaultBalancePushed()
	{
		if (TryGetBoundBalance(out var balance))
		{
			UpdateBalanceDisplay(balance, animate: true);
		}
		LoadTransactions();
	}

	private void LoadVisualTiers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8630]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_019f:
		throw new NullReferenceException();
		IL_0100:
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		List<ClanVaultVisualTierConfig> list;
		if (current.<Clans>k__BackingField != null)
		{
			list = <Clans>k__BackingField.VaultVisualTiers;
		}
		else
		{
			bool flag2 = (object)this == null;
			object obj5 = !flag2;
			list = null;
			if (obj5 == null)
			{
				goto IL_019f;
			}
		}
		object obj6 = this + 152;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateBalanceDisplay(_lastBalance);
		return;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag3 = current == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_0100;
		}
		goto IL_019f;
	}

	private void ApplyPermissions()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8631]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			obj5 = requestDonationsButton;
			obj6 = requestDonationsButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = requestDonationsButton;
			obj6 = requestDonationsButton;
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
		GameObject gameObject = requestDonationsButton.gameObject;
		bool active = CanManageVault();
		gameObject.SetActive(active);
		RefreshRequestDonationsInteractable();
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	private void RefreshRequestDonationsInteractable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_0212: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8632]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = requestDonationsButton;
			obj6 = requestDonationsButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = requestDonationsButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = requestDonationsButton;
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
		requestDonationsButton.interactable = true;
		object obj9 = typeof(Queue<string>) + 728;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1696;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj14);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.HasOpenVaultSupportRequest(action);
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	private static bool CanManageVault()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01aa: Expected I4, but got O
		//IL_00dc: Expected I4, but got O
		//IL_018b: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8633]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			object obj4 = (nint)0 + (nint)1976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		bool flag3 = (object)clanServerConnector == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_0199;
		IL_01af:
		bool result;
		return result;
		IL_00b8:
		ClanUserModel myMembership = clanServerConnector.GetMyMembership();
		bool flag4 = myMembership == null;
		result = (byte)(int)myMembership != 0;
		if (!flag4)
		{
			return ClanPermissionsExtensions.Can(myMembership.Permissions, ClanPermissions.ManageVault);
		}
		goto IL_01af;
		IL_0199:
		NullReferenceException ex = new NullReferenceException();
		result = (byte)(int)ex != 0;
		goto IL_01af;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)clanServerConnector != null)
		{
			goto IL_00b8;
		}
		goto IL_0199;
	}

	private static bool TryGetBoundBalance(out int balance)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01d2: Expected I4, but got O
		//IL_0194: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8634]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v5+B8]");
		object obj9 = 0;
		CoordinatorVariableBinder coordinatorVariableBinder = (CoordinatorVariableBinder)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00c8;
		}
		goto IL_01c4;
		IL_00c8:
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		string current = coordinatorVariableBinder.GetCurrent((string)scope, (string)variableName);
		return int.TryParse(current, out balance);
		IL_01c4:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_008b:
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v13+B8]");
		object obj12 = 0;
		coordinatorVariableBinder = (CoordinatorVariableBinder)obj12;
		if (obj12 != null)
		{
			goto IL_00c8;
		}
		goto IL_01c4;
	}

	private void UpdateBalanceDisplay(int balance, bool animate = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_0185: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		object obj = "Material with texture name \"" + 3224;
		_lastBalance = balance;
		TextMeshProUGUI textMeshProUGUI = balanceText;
		int balance2 = default(int);
		string text = balance2.ToString((string)obj);
		textMeshProUGUI.text = text;
		ClanVaultVisualTier clanVaultVisualTier = ResolveTier(balance2);
		object obj2 = clanVaultVisualTier - 2;
		bool flag = obj2 == null;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ((obj4 != null) ? ((object)64) : ((object)48));
		object obj6 = !flag;
		object obj7 = ~obj6;
		object obj8 = ((obj7 != null) ? ((object)96) : ((object)80));
		if (clanVaultVisualTier == ClanVaultVisualTier.Tier2)
		{
			object obj9 = 56;
		}
		else
		{
			object obj9 = obj5;
		}
		if (clanVaultVisualTier == ClanVaultVisualTier.Tier2)
		{
			object obj10 = 88;
		}
		else
		{
			object obj10 = obj8;
		}
		Image image = balanceImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanVaultPanel)+v137 @ X9_v3]");
		SetSprite(image, (Sprite)0, animate);
		Image image2 = secondaryBalanceImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanVaultPanel)+v165 @ X21_v3]");
		SetSprite(image2, (Sprite)0, animate);
	}

	private void SetSprite(Image image, Sprite sprite, bool animate)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_0127: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_022a: Expected I, but got O
		//IL_0252: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8636]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = image == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 == null)
		{
			goto IL_0143;
		}
		return;
		IL_0143:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (image.m_Sprite == sprite)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = image.m_Sprite == sprite;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				return;
			}
		}
		int num = ShortcutExtensions.DOKill(image);
		image.sprite = sprite;
		Color color = image.color;
		nint num2 = (nint)image;
		if (animate)
		{
			image.color = (Color)0;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(image, 1f, fadeDuration);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v135 @ X8_v6 (Il2CppClass<UnityEngine.UI.Image>)+2A8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0074:
		bool flag6 = image == null;
		bool flag7 = !flag6;
		obj6 = 0;
		obj7 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0143;
	}

	private ClanVaultVisualTier ResolveTier(int balance)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_003a: Expected O, but got I8
		//IL_0051: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		ClanVaultVisualTier result;
		if (_visualTiers != null)
		{
			object obj = (nint)0 + (nint)40;
			object obj2 = (nint)0 + (nint)32;
			List<object>.Enumerator enumerator = ((List<object>)(object)_visualTiers).GetEnumerator();
			object obj3 = 2147483648L;
			result = ClanVaultVisualTier.Tier1;
			object obj4 = obj;
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			if (enumerator2.MoveNext())
			{
				object obj5 = 0;
				NullReferenceException ex = new NullReferenceException();
				bool flag = (nint)obj != 1;
				object obj6 = 0;
				NullReferenceException ex2 = ex;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj4 = obj2;
					enumerator2.Dispose();
					object obj7 = default(object);
					if (obj7 == null)
					{
						goto IL_0288;
					}
					OutOfMemoryException ex3 = new OutOfMemoryException();
					obj6 = obj7;
					ex2 = (NullReferenceException)(object)ex3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DA08");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				ClanVaultVisualTier result2 = default(ClanVaultVisualTier);
				return result2;
			}
			enumerator2.Dispose();
		}
		else
		{
			result = ClanVaultVisualTier.Tier1;
		}
		goto IL_0288;
		IL_0288:
		return result;
	}

	private static Sprite SelectTierSprite(ClanVaultVisualTier tier, Sprite tier1, Sprite tier2, Sprite tier3)
	{
		Sprite result = ((tier != ClanVaultVisualTier.Tier3) ? tier1 : tier3);
		if (tier == ClanVaultVisualTier.Tier2)
		{
			return tier2;
		}
		return result;
	}

	private void LoadTransactions()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_007b: Expected O, but got I4
		//IL_00bf: Expected I, but got O
		if (!_reloadingTransactions)
		{
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 768;
			object obj4 = (nint)0 + (nint)1688;
			_reloadingTransactions = true;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj4);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetClanVaultTransactions(transactionsLimit, action);
		}
	}

	private void RenderTransactions(List<ClanVaultTransactionModel> transactions)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_03e9: Expected O, but got I
		//IL_03f9: Expected O, but got I
		//IL_041b: Expected O, but got I4
		//IL_00b2: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02ff: Expected O, but got I
		//IL_0310: Expected I, but got O
		//IL_032e: Expected O, but got I
		//IL_0349: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01ec: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0380: Expected O, but got I
		//IL_0391: Expected I, but got O
		//IL_03af: Expected O, but got I
		//IL_03ca: Expected O, but got I4
		//IL_024c: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1592;
		VaultTransactionListView vaultTransactionListView = transactionsListView;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v28+8]");
		Func<object, int, object> selector = (Func<object, int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v28+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		object obj12;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v34+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)848;
			Func<object, int, object> func = default(Func<object, int, object>);
			func..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v33+B8]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = 0;
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(transactions, selector);
		List<object> data = Enumerable.ToList(source);
		nint num = (nint)vaultTransactionListView;
		vaultTransactionListView.data = (List<VaultTransactionDataHolder>)(object)data;
		int balance;
		bool flag4 = TryGetBoundBalance(out balance);
		bool flag5 = !flag4;
		object obj13 = !flag5;
		if (obj13 != null || transactions._size < 1)
		{
			return;
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v21+E4]");
		object obj15;
		Func<object, long> keySelector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v21+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+10]");
			keySelector = (Func<object, long>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+10]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				goto IL_01fa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v21+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+10]");
			keySelector = (Func<object, long>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17+10]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				goto IL_01fa;
			}
		}
		goto IL_0251;
		IL_01fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v23+B8]");
			obj15 = 0;
		}
		object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)856;
		Func<object, long> func2 = default(Func<object, long>);
		func2..ctor(obj15, (IntPtr)obj21);
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v22+B8]");
		object obj23 = (nint)0 + (nint)16;
		obj23 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = 0;
		keySelector = func2;
		goto IL_0251;
		IL_0251:
		IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(transactions, keySelector);
		object obj24 = Enumerable.First(source2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v19 (System.Object)+2C]");
		UpdateBalanceDisplay(0);
	}

	public ClanVaultPanel()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		object obj = "Read object reference Id '{0}' for {1}." + 2416;
		fadeDuration = 0.75f;
		transactionsLimit = 50;
		object obj2 = this + 144;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <RefreshRequestDonationsInteractable>b__28_0(bool hasOpen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E863B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 == null)
		{
			goto IL_013d;
		}
		return;
		IL_013d:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (requestDonationsButton == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = requestDonationsButton == null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			if (obj9 != null)
			{
				return;
			}
		}
		bool interactable = (byte)((hasOpen ? 1u : 0u) ^ 1u) != 0;
		requestDonationsButton.interactable = interactable;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (_requestDonationsLabel == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = _requestDonationsLabel == null;
			bool flag7 = !flag6;
			object obj11 = !flag7;
			if (obj11 != null)
			{
				return;
			}
		}
		object text = this + 144;
		object obj12 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3992;
		bool flag8 = !hasOpen;
		object obj13 = !flag8;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			text = obj12;
		}
		TextMeshProExtensions.Localize(_requestDonationsLabel, (string)text);
		return;
		IL_0074:
		bool flag9 = this == null;
		bool flag10 = !flag9;
		obj6 = 0;
		obj7 = null;
		if (!flag10)
		{
			return;
		}
		goto IL_013d;
	}

	private void <LoadTransactions>b__35_0(List<ClanVaultTransactionModel> transactions)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E863C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			_reloadingTransactions = false;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			_reloadingTransactions = false;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_013e;
		IL_013e:
		RenderTransactions(transactions);
		return;
		IL_0088:
		if (this == null)
		{
			return;
		}
		goto IL_013e;
	}
}
