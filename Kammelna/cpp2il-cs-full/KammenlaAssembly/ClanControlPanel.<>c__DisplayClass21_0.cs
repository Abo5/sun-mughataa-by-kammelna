using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UI.UI_Themeing;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanControlPanel : MonoBehaviour
{
	private sealed class <>c__DisplayClass21_0
	{
		public ClanControlPanel <>4__this;

		public bool isOn;

		internal void <OnAutoRenewalChanged>b__0(bool succeeded)
		{
			ClanControlPanel clanControlPanel = <>4__this;
			if (succeeded)
			{
				ClanModel clan = clanControlPanel._clan;
				clan.AutoRenewal = isOn;
			}
		}
	}

	private TextMeshProUGUI clanTitle;

	private TextMeshProUGUI membershipDateText;

	private TextMeshProUGUI membershipPriceText;

	private ClanMembersListView clanMembersList;

	private Button transferOwnershipButton;

	private Button leaveButton;

	private Toggle autoRenewalToggle;

	private UiToggler autoRenewalToggler;

	private ClansSerializedUtils clanUtils;

	private ClanModel _clan;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = transferOwnershipButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = leaveButton;
		object obj3 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

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
		//IL_00df: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj2 = (nint)0 + (nint)872;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)896;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnClanRosterChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
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
		//IL_00df: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj2 = (nint)0 + (nint)872;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)896;
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnClanRosterChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00e5: Expected I, but got O
		Button button = transferOwnershipButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = leaveButton;
		object obj3 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.RemoveListener(unityAction2);
		Toggle toggle = autoRenewalToggle;
		object obj4 = typeof(TypeConverter<ushort, char>) + 360;
		object obj5 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction3 = default(UnityAction<bool>);
		unityAction3..ctor((object)this, (IntPtr)obj5);
		toggle.onValueChanged.RemoveListener(unityAction3);
	}

	public void Initialize(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0045: Expected O, but got I4
		//IL_00bb: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 104;
		obj2 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3-48]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0096;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3-48]");
			if ((UnityEngine.Object)0 != null)
			{
				goto IL_0096;
			}
		}
		goto IL_00af;
		IL_00af:
		object obj5 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
		slideAnimationHelper.SlideIn();
		autoRenewalToggle.SetIsOnWithoutNotify(clan.AutoRenewal);
		autoRenewalToggler.ToggleManual(clan.AutoRenewal);
		SubscribeAutoRenewalToggle();
		SetMembershipDate(clan.DateSubscriptionExpires);
		SetMembershipPrice();
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!(clanMembersList != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clanMembersList != null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				return;
			}
		}
		IEnumerable<ClanUserModel> getMembers = clan.GetMembers;
		clanMembersList.Initialize(getMembers);
		return;
		IL_0096:
		TextMeshProExtensions.FixArabic(clanTitle, clan.Name);
		goto IL_00af;
	}

	private void OnClanRosterChanged(ClanModel clan)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0075: Expected O, but got I
		if (clan == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 104;
		obj2 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v5-30]");
			if (!((UnityEngine.Object)0 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v5-30]");
			bool flag = (UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		IEnumerable<ClanUserModel> getMembers = clan.GetMembers;
		clanMembersList.Initialize(getMembers);
	}

	private void InitializeMembershipInfo(ClanModel clan)
	{
		SetMembershipDate(clan.DateSubscriptionExpires);
		SetMembershipPrice();
	}

	private void SetMembershipDate(DateTime? expiresAt)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8757]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = membershipDateText;
			obj6 = membershipDateText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = membershipDateText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = membershipDateText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0166;
		IL_0166:
		object obj10 = (??)expiresAt & 1;
		string text2;
		if (obj10 != null)
		{
			object obj11 = (nint)0 + (nint)2296;
			DateTime? dateTime = default(DateTime?);
			DateTime value = dateTime.Value;
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj15 = typeof(DataRelation) + 712;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj18 = "utf-32" + 3016;
			DateTime dateTime2 = default(DateTime);
			string text = dateTime2.ToString((string)obj18, invariantCulture);
			text2 = text;
		}
		else
		{
			object obj19 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v5+90]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+B8]");
			object obj21 = 0;
			text2 = (string)obj21;
		}
		TextMeshProExtensions.FixArabic(membershipDateText, text2);
		return;
		IL_0091:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		obj9 = 0;
		if (!flag8)
		{
			return;
		}
		goto IL_0166;
	}

	private void SetMembershipPrice()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8758]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = membershipPriceText;
			obj6 = membershipPriceText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = membershipPriceText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = membershipPriceText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 == null)
		{
			goto IL_0174;
		}
		return;
		IL_0174:
		object obj11 = typeof(RegisteredWaitHandle) + 56;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		if (current.<Clans>k__BackingField != null)
		{
			TextMeshProExtensions.SetPriceText(membershipPriceText, <Clans>k__BackingField.RenewalCost, useCommas: true);
		}
		return;
		IL_0091:
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		obj9 = 0;
		obj10 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0174;
	}

	private void InitializeAutoRenewal(bool enabled)
	{
		autoRenewalToggle.SetIsOnWithoutNotify(enabled);
		autoRenewalToggler.ToggleManual(enabled);
		SubscribeAutoRenewalToggle();
	}

	private void SubscribeAutoRenewalToggle()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_0087: Expected I, but got O
		Toggle toggle = autoRenewalToggle;
		object obj = typeof(TypeConverter<ushort, char>) + 360;
		object obj2 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)848;
		toggle.onValueChanged.RemoveListener(unityAction);
		Toggle toggle2 = autoRenewalToggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj2);
		toggle2.onValueChanged.AddListener(unityAction2);
	}

	private void OnAutoRenewalChanged(bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_00b9: Expected O, but got I4
		//IL_0100: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(Queue<string>) + 728;
		object obj5 = (nint)0 + (nint)1976;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj7 = (nint)0 + (nint)3472;
		autoRenewalToggler.ToggleManual(isOn);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.SetAutoRenewal(enabled: false, action);
	}

	private void ApplyAutoRenewalResult(bool requested, bool succeeded)
	{
		if (succeeded)
		{
			ClanModel clan = _clan;
			clan.AutoRenewal = requested;
		}
	}

	private void OnTransferOwnershipClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_00ba: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj3 = (nint)0 + (nint)856;
		ITrackEvent trackEvent = TrackerLibrary.ClanOwnershipTransferViewed();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		clanUtils.OpenClanTransferOwnershipPopup(action);
	}

	private void OnLeaveClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0053: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)848;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj4 = (nint)0 + (nint)856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		ClanLeaveFlow.Run(clanUtils, _clan, action, action2);
	}

	private void CloseSelf()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
		slideAnimationHelper.SlideOut();
	}
}
