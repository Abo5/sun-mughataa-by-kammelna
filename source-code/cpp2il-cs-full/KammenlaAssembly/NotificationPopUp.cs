using System;
using System.Data;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class NotificationPopUp : MonoBehaviour
{
	private static readonly TimeSpan ShowFrequency;

	private const string NotificationPopupShownKey = "notification_popup_shown";

	private Button enableNotification;

	private Button laterNotification;

	private PopupUI popup;

	private DateTime LastNotificationPopupShown
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "not" + 176;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+20]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "not" + 176;
			DateTime value2 = default(DateTime);
			Prefs.SetDate((string)key, value2);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0232: Expected O, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0279: Expected O, but got I
		//IL_0287: Expected I, but got O
		//IL_02c3: Expected O, but got I
		//IL_02d1: Expected I, but got O
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_04cf: Expected O, but got I
		//IL_04e9: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0546: Expected O, but got I4
		//IL_03d9: Expected O, but got I
		//IL_03ee: Expected O, but got I
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0446: Expected O, but got I4
		//IL_05e8: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_05c9: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CFD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v54+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v54+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a2;
		IL_0375:
		object obj7 = "not" + 176;
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj7;
		object obj11 = obj8;
		DateTime dateTime2;
		DateTime dateTime = dateTime2;
		if (!flag3)
		{
			goto IL_03c9;
		}
		goto IL_056c;
		IL_056c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj9;
		obj7 = obj10;
		dateTime2 = dateTime;
		goto IL_03c9;
		IL_03c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+B8]");
		object obj12 = 0;
		object key = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v18+20]");
		DateTime date = Prefs.GetDate((string)key, (DateTime)0);
		TimeSpan timeSpan = dateTime2 - date;
		object obj13 = typeof(MemberAchievementClanFeedData) + 2696;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v20+B8]");
		object obj16 = 0;
		object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v24+E4]");
		if ((nint)0 != 0)
		{
			if (!(timeSpan > (TimeSpan)obj16))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = timeSpan > (TimeSpan)obj16;
			bool flag6 = !flag5;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				return;
			}
		}
		popup.PopFromCenter();
		return;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a2;
		IL_01a2:
		_ = 1;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v78+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		object obj23 = obj21;
		if (obj22 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e8;
		IL_00a7:
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v78+E4]");
		bool flag8 = (nint)0 == 0;
		obj23 = obj21;
		if (!flag8)
		{
			goto IL_00dc;
		}
		goto IL_01e8;
		IL_01e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v48+B8]");
		object obj25 = 0;
		object obj26 = obj25 & 1;
		bool flag9 = obj26 == null;
		object obj27 = !flag9;
		if (obj27 == null)
		{
			goto IL_0240;
		}
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v78+B8]");
		object obj28 = 0;
		object obj29 = obj28 & 1;
		if (obj29 != null)
		{
			return;
		}
		goto IL_0240;
		IL_0240:
		Button button = enableNotification;
		object obj30 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)3552;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj31);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = laterNotification;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)3544;
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj32);
		button2.m_OnClick.AddListener(unityAction2);
		obj9 = typeof(DataRelation) + 712;
		object obj33 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			DateTime now = DateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CFB]");
			object obj34 = (nint)0 & (nint)1;
			bool flag10 = obj34 == null;
			dateTime2 = now;
			dateTime = now;
			if (!flag10)
			{
				goto IL_0375;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now2 = DateTime.Now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CFB]");
			object obj35 = (nint)0 & (nint)1;
			bool flag11 = obj35 == null;
			object obj36 = !flag11;
			dateTime2 = now2;
			dateTime = now2;
			if (obj36 != null)
			{
				goto IL_0375;
			}
		}
		_ = 1;
		obj7 = "not" + 176;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+E4]");
		bool flag12 = (nint)0 == 0;
		object obj37 = !flag12;
		dateTime2 = dateTime;
		obj10 = obj7;
		obj11 = obj8;
		if (obj37 != null)
		{
			goto IL_03c9;
		}
		goto IL_056c;
	}

	private void OnPopupConfirmed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		object key = "not" + 176;
		Prefs.SetDate((string)key, now);
		NotificationPermissionUtils.RequestPermission();
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.ShrinkToParent();
		ITrackEvent trackEvent = TrackerLibrary.PushNotificationEnabledButtonClicked();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnLaterButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(DataRelation) + 856;
		DateTime now = DateTime.Now;
		object key = "not" + 176;
		object message = "Unsupported map type" + 656;
		Prefs.SetDate((string)key, now);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		popup.ShrinkToParent();
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.ShrinkToParent();
		ITrackEvent trackEvent = TrackerLibrary.PushNotificationAskLaterButtonClicked();
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void ShowPopup()
	{
		popup.PopFromCenter();
	}

	private void HidePopup()
	{
		popup.ShrinkToParent();
	}

	static NotificationPopUp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0052: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2696;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromDays(4.000000000698492);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+B8]");
		object obj6 = 0;
		obj6 = timeSpan;
	}
}
