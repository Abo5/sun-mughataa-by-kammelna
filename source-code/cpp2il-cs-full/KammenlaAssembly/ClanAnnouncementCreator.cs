using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanAnnouncementCreator : MonoBehaviour
{
	private InputFieldTMProUGUI _titleInput;

	private InputFieldTMProUGUI _messageInput;

	private Toggle _pinToggle;

	private TextMeshProUGUI _priceTag;

	private PopupUI _popup;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 64;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnEnable()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008e: Expected I, but got O
		_titleInput.Text = null;
		_messageInput.Text = null;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)720;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		_pinToggle.isOn = false;
		ApplyConfig();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			RemoteConfig.OnChanged += action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfig.OnChanged += action;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)720;
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

	private void ApplyConfig()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_0267: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		int num = 152993792;
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj5 = !flag2;
		int num2;
		if (obj5 == null)
		{
			num2 = 152993792;
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_0165:
		UnityEngine.Object priceTag;
		if ((bool)priceTag)
		{
			goto IL_018b;
		}
		return;
		IL_008b:
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		num2 = <Clans>k__BackingField.PaidAnnouncementCost;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F3]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		obj = 152993792;
		UnityEngine.Object priceTag2;
		int num3;
		if (!flag3)
		{
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			priceTag = _priceTag;
			priceTag2 = _priceTag;
			num3 = <Clans>k__BackingField.PaidAnnouncementCost;
			if (!flag4)
			{
				goto IL_0165;
			}
		}
		else
		{
			_ = 1;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			priceTag = _priceTag;
			priceTag2 = _priceTag;
			num3 = num2;
			if (obj9 != null)
			{
				goto IL_0165;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = priceTag2;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		num2 = num3;
		if (obj10 == null)
		{
			return;
		}
		goto IL_018b;
		IL_007d:
		current = RemoteConfig.Current;
		goto IL_008b;
		IL_018b:
		TextMeshProExtensions.SetPriceText(_priceTag, num2, useCommas: true);
	}

	public void Send()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_0091: Expected I, but got O
		if (ValidateInput() && ValidateAfford())
		{
			string text = _titleInput.Text;
			string text2 = _messageInput.Text;
			Toggle pinToggle = _pinToggle;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)728;
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj2);
			KammelnaRequests.CreateClanAnnouncement(text, text2, pinToggle.m_IsOn, action);
			_popup.SlideToBottom();
		}
	}

	public void Open()
	{
		_popup.SlideFromBottom();
		_titleInput.Text = null;
		_messageInput.Text = null;
		_pinToggle.isOn = false;
	}

	private void ClearInput()
	{
		_titleInput.Text = null;
		_messageInput.Text = null;
		_pinToggle.isOn = false;
	}

	private bool ValidateInput()
	{
		//IL_00e3: Expected I4, but got O
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		if ((object)_titleInput != null)
		{
			string text = _titleInput.Text;
			object text2;
			if (string.IsNullOrWhiteSpace(text))
			{
				text2 = "Drop Menu Toggle" + 3184;
			}
			else
			{
				if ((object)_messageInput == null)
				{
					goto IL_00d5;
				}
				string text3 = _messageInput.Text;
				if (!string.IsNullOrWhiteSpace(text3))
				{
					return true;
				}
				text2 = "Drop Menu Toggle" + 3176;
			}
			LocalizableText text4 = TextMeshProExtensions.Localize((string)text2);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text4, (Vector2)0, 0f);
			return false;
		}
		goto IL_00d5;
		IL_00d5:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool ValidateAfford()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_02ee: Expected I4, but got O
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_022c: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_0363: Expected O, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86B0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a3;
		}
		goto IL_02e0;
		IL_0350:
		LocalizableText localizableText;
		Toast.Show(localizableText, (Vector2)0, 0f);
		bool result = false;
		goto IL_02ee;
		IL_024b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LocalizableText localizableText2;
		localizableText = localizableText2;
		goto IL_0350;
		IL_02ee:
		return result;
		IL_007d:
		current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_00a3;
		}
		goto IL_02e0;
		IL_02e0:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00a3:
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		object obj11;
		object obj13;
		if (current.<Clans>k__BackingField != null && <Clans>k__BackingField.PaidAnnouncementCost > 0)
		{
			long balance;
			bool flag3 = TryGetVaultBalance(out balance);
			bool flag4 = !flag3;
			result = true;
			if (!flag4)
			{
				bool flag5 = balance >= <Clans>k__BackingField.PaidAnnouncementCost;
				result = true;
				if (!flag5)
				{
					ITrackEvent trackEvent = TrackerLibrary.ClanActivityCreateNotEnoughVault(ClanActivityType.Announcement);
					object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v18+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Tracker.DesignEvent(trackEvent);
					object text = "Network Authentication Required" + 2120;
					localizableText = TextMeshProExtensions.Localize((string)text);
					obj11 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v10+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						obj13 = 0;
						localizableText2 = localizableText;
						goto IL_024b;
					}
					goto IL_0350;
				}
			}
			goto IL_02ee;
		}
		object text2 = "Picking audio files is not supported on iOS" + 616;
		localizableText2 = TextMeshProExtensions.Localize((string)text2);
		obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj14 = !flag8;
		obj13 = 0;
		localizableText = localizableText2;
		if (obj14 == null)
		{
			goto IL_024b;
		}
		goto IL_0350;
	}

	private static bool TryGetVaultBalance(out long balance)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86B1]");
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
		return long.TryParse(current, out balance);
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

	private static void OnAnnouncementSent(KammelnaResponseModel<long> response)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0284: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_02a5: Expected O, but got I4
		if (response.Succeeded)
		{
			ClanServerConnector.NotifyActivityCreated(ClanActivityType.Announcement);
			object text = "WhiteSmoke" + 2144;
			LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text2, (Vector2)0, 0f);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X0 (KammelnaResponseModel`1<System.Int64>)+14]");
		ITrackEvent trackEvent;
		object obj7;
		ITrackEvent trackEvent2;
		object obj8 = default(object);
		if ((nint)0 == 13023)
		{
			trackEvent = TrackerLibrary.ClanActivityCreateNotEnoughVault(ClanActivityType.Announcement);
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				obj7 = obj8;
				string text3 = null;
				trackEvent2 = trackEvent;
				goto IL_01e2;
			}
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			trackEvent2 = TrackerLibrary.ClanActivityCreateError(ClanActivityType.Announcement, errorMessage);
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj5 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj7 = 0;
			string text3 = errorMessage;
			obj8 = 0;
			trackEvent = trackEvent2;
			if (obj10 == null)
			{
				goto IL_01e2;
			}
		}
		goto IL_0224;
		IL_01e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj7;
		trackEvent = trackEvent2;
		goto IL_0224;
		IL_0224:
		Tracker.DesignEvent(trackEvent);
		object obj11 = (nint)0 + (nint)1256;
		string errorMessage2 = response.ErrorMessage;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(errorMessage2, (Vector2)0, 0f);
	}

	private void SetPriceTag(int price)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F3]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object priceTag;
		UnityEngine.Object priceTag2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			priceTag = _priceTag;
			priceTag2 = _priceTag;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			priceTag = _priceTag;
			priceTag2 = _priceTag;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = priceTag2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		TextMeshProExtensions.SetPriceText(_priceTag, price, useCommas: true);
		return;
		IL_0091:
		if ((bool)priceTag)
		{
			goto IL_00b7;
		}
	}
}
