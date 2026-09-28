using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanRollbackConfirmPopup : MonoBehaviour
{
	private const string WINDOW_EXPIRED_KEY = "clan_rollback_window_expired";

	private const string RESTORE_FAILED_KEY = "clan_rollback_failed";

	private ClanCard clanCard;

	private TextMeshProUGUI countdownText;

	private Button confirmButton;

	private PopupUI popup;

	private RollbackInfoModel prompt;

	private Action onRestored;

	private float nextCountdownTick;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = confirmButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	private void Update()
	{
		//IL_00c9: Expected I, but got O
		//IL_00d9: Expected O, but got I
		//IL_00e9: Expected O, but got I
		if (prompt == null)
		{
			return;
		}
		float unscaledTime = Time.unscaledTime;
		if (!(unscaledTime < nextCountdownTick))
		{
			float unscaledTime2 = Time.unscaledTime;
			float num = unscaledTime2 + 1f;
			nextCountdownTick = num;
			RollbackInfoModel rollbackInfoModel = prompt;
			if (!ClanRollbackCountdown.TryApply(countdownText, rollbackInfoModel.ExpiresAt))
			{
				PopupUI popupUI = popup;
				nint num2 = (nint)popupUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4 (Il2CppClass<PopupUI>)+198]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4 (Il2CppClass<PopupUI>)+1A0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X2_v1 (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = confirmButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
	}

	public void Initialize(RollbackInfoModel info, Action restoredCallback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = this + 64;
		obj2 = info;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 72;
		obj3 = restoredCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ITrackEvent trackEvent = TrackerLibrary.ClanRollbackConfirmViewed();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		ClanModel clanModel = info.Clan;
		bool flag2 = clanModel == null;
		object obj6 = !flag2;
		ClanModel clanModel2 = clanModel;
		if (obj6 == null)
		{
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ClanModel clanModel3 = default(ClanModel);
			clanModel3..ctor();
			clanModel3.ClanId = info.ClanId;
			object obj8 = typeof(List<AdaptivePerformanceScaler>) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			object obj9 = clanModel3 + 96;
			obj9 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			clanModel2 = clanModel3;
		}
		object obj10 = clanModel2 + 24;
		obj10 = info.OriginalName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		clanCard.Initialize(clanModel2);
		confirmButton.interactable = true;
		popup.SlideFromBottom();
	}

	private void Confirm()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_005c: Expected I, but got O
		confirmButton.interactable = false;
		RollbackInfoModel rollbackInfoModel = prompt;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.RollbackClan(rollbackInfoModel.ClanId, action);
	}

	private static string RestoreFailureKey(KammelnaError error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object result = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3944;
		object result2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3936;
		if (error == KammelnaError.ClanRollbackWindowExpired)
		{
			return (string)result;
		}
		return (string)result2;
	}

	private void CloseSelf()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<PopupUI>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <Confirm>b__13_0(KammelnaResponseModel<bool> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_0301: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05d5: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0682: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_06a3: Expected O, but got I4
		//IL_06c1: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected O, but got Unknown
		//IL_0532: Expected I, but got O
		//IL_0542: Expected O, but got I
		//IL_0552: Expected O, but got I
		//IL_019a: Expected I8, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_0454: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_041c: Expected O, but got I4
		object obj = (nint)0 + (nint)1048;
		object obj2 = obj;
		if (response.Succeeded)
		{
			ITrackEvent trackEvent = TrackerLibrary.ClanRollbackRestored();
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v42+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SessionModel sessionModel = default(SessionModel);
			SessionModel sessionModel2 = default(SessionModel);
			while (true)
			{
				Tracker.DesignEvent(trackEvent);
				Action action = onRestored;
				bool flag2 = onRestored == null;
				nint num = 0;
				if (!flag2)
				{
					num = ((Delegate)action).method;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v274.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				object obj6 = typeof(Queue<string>) + 848;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v57+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				User localUser = sessionModel.LocalUser;
				bool flag4 = localUser == null;
				object obj10 = 0;
				if (!flag4)
				{
					object obj11 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v71+E4]");
					bool flag5 = (nint)0 == 0;
					object obj12 = !flag5;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					User localUser2 = sessionModel2.LocalUser;
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
					SFS.RefreshClanMembership(intDbId);
					obj10 = 0;
				}
				object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v63+E4]");
				if ((nint)0 != 0)
				{
					bool flag6 = this != null;
					bool flag7 = !flag6;
					object obj15 = !flag7;
					if (obj15 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (!(this != null))
					{
						break;
					}
				}
				PopupUI popupUI = popup;
				nint num2 = (nint)popupUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v49 (Il2CppClass<PopupUI>)+198]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v49 (Il2CppClass<PopupUI>)+1A0]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v207 @ X2_v10 (should have been resolved before IL gen)");
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
		ITrackEvent trackEvent2;
		ITrackEvent trackEvent3;
		if ((nint)0 == 13034)
		{
			trackEvent2 = TrackerLibrary.ClanRollbackWindowExpired();
			object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v30+E4]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			if (obj20 == null)
			{
				trackEvent3 = trackEvent2;
				goto IL_0320;
			}
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			trackEvent3 = TrackerLibrary.ClanRollbackError(errorMessage);
			object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj19 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v30+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			obj2 = 0;
			trackEvent2 = trackEvent3;
			if (obj22 == null)
			{
				goto IL_0320;
			}
		}
		goto IL_05e3;
		IL_0320:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		trackEvent2 = trackEvent3;
		goto IL_05e3;
		IL_05e3:
		Tracker.DesignEvent(trackEvent2);
		object obj23 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3944;
		object obj24 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
		object text = (((nint)0 != 13034) ? obj24 : obj23);
		LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
		object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text2, (Vector2)0, 0f);
		string errorMessage2 = response.ErrorMessage;
		object obj28 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "WhiteSmoke" + 3024;
		object arg = default(object);
		string text3 = string.Format((string)format, errorMessage2, arg);
		object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v24+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		object obj32 = text3;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj32 = text3;
		}
		KLogger.LogWarning(obj32);
		object obj33 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			if (!(this != null))
			{
				return;
			}
			object obj35 = 0;
			UnityEngine.Object obj36 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag12 = this != null;
			bool flag13 = !flag12;
			object obj35 = 0;
			UnityEngine.Object obj36 = null;
			if (flag13)
			{
				return;
			}
		}
		object obj37 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v20+E4]");
		bool flag14 = (nint)0 == 0;
		object obj38 = !flag14;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (confirmButton != null)
		{
			confirmButton.interactable = true;
		}
	}
}
