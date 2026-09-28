using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RequestFundsPopup : MonoBehaviour, IInitializable
{
	private InputField amountInput;

	private Button confirmButton;

	private int durationDays = 7;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_009b: Expected I, but got O
		//IL_013d: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		Button button = confirmButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		InputField inputField = amountInput;
		object obj3 = typeof(TypeConverter<ushort, char>) + 464;
		object obj4 = (nint)0 + (nint)776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj4);
		((UnityEvent<object>)(object)inputField.m_OnValueChanged).AddListener(unityAction2);
		InputField inputField2 = amountInput;
		int result;
		bool flag = int.TryParse(inputField2.m_Text, out result);
		bool flag2 = result < 0;
		bool flag3 = result == 0;
		int num = result ^ result;
		int num2 = result & num;
		bool flag4 = num2 < 0;
		bool flag5 = flag2 == flag4;
		object obj5 = !flag5;
		object obj6 = obj5 | flag3;
		object obj7 = ~obj6;
		bool interactable = obj7 != null && flag;
		confirmButton.interactable = interactable;
	}

	public void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8640]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			trackEvent = TrackerLibrary.ClanSupportRequestViewed();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.ClanSupportRequestViewed();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_008e:
		Tracker.DesignEvent(trackEvent);
	}

	private void OnAmountChanged(string value)
	{
		//IL_008a: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		InputField inputField = amountInput;
		int result;
		bool flag = int.TryParse(inputField.m_Text, out result);
		bool flag2 = result < 0;
		bool flag3 = result == 0;
		int num = result ^ result;
		int num2 = result & num;
		bool flag4 = num2 < 0;
		bool flag5 = flag2 == flag4;
		object obj = !flag5;
		object obj2 = obj | flag3;
		object obj3 = ~obj2;
		bool interactable = obj3 != null && flag;
		confirmButton.interactable = interactable;
	}

	private void UpdateConfirmInteractable()
	{
		//IL_008a: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		InputField inputField = amountInput;
		int result;
		bool flag = int.TryParse(inputField.m_Text, out result);
		bool flag2 = result < 0;
		bool flag3 = result == 0;
		int num = result ^ result;
		int num2 = result & num;
		bool flag4 = num2 < 0;
		bool flag5 = flag2 == flag4;
		object obj = !flag5;
		object obj2 = obj | flag3;
		object obj3 = ~obj2;
		bool interactable = obj3 != null && flag;
		confirmButton.interactable = interactable;
	}

	private void OnConfirm()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_02a7: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_023d: Expected O, but got I
		//IL_024b: Expected I, but got O
		if (CanRequestDonations())
		{
			InputField inputField = amountInput;
			int result;
			bool flag = int.TryParse(inputField.m_Text, out result);
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			bool flag3;
			bool flag4;
			bool flag5;
			if (obj2 == null)
			{
				flag3 = result < 0;
				flag4 = result == 0;
				int num = result ^ result;
				int num2 = result & num;
				flag5 = num2 < 0;
			}
			else
			{
				flag5 = false;
				flag4 = true;
				flag3 = false;
			}
			bool flag6 = flag3 == flag5;
			object obj3 = !flag4;
			object obj4 = flag6 & obj3;
			if (obj4 == null)
			{
				object title = "Index = {0} position = {1}" + 2672;
				object content = "Drop Menu Toggle" + 3136;
				PopupWindowBuilder.ShowError((string)title, (string)content);
				return;
			}
			ITrackEvent trackEvent = TrackerLibrary.ClanSupportRequestClicked(result, durationDays);
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj7 = !flag7;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			confirmButton.interactable = false;
			object obj8 = typeof(Queue<string>) + 728;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v12+E4]");
			bool flag8 = (nint)0 == 0;
			object obj10 = !flag8;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)792;
			Action<bool, System.Int32Enum> action = default(Action<bool, System.Int32Enum>);
			action..ctor((object)this, (IntPtr)obj13);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.CreateVaultSupportRequest(result, durationDays, (Action<bool, KammelnaError>)(object)action);
		}
		else
		{
			object title2 = "Network Authentication Required" + 1960;
			object content2 = "WhiteSmoke" + 1864;
			PopupWindowBuilder.ShowError((string)title2, (string)content2);
		}
	}

	private static bool CanRequestDonations()
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8642]");
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

	private void OnRequestCreated(bool success, KammelnaError error)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0029: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_023f: Expected O, but got I4
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0277: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0073;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0073;
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
		goto IL_011c;
		IL_011c:
		InputField inputField = amountInput;
		int result;
		bool flag4 = int.TryParse(inputField.m_Text, out result);
		bool flag5 = result < 0;
		bool flag6 = result == 0;
		int num = result ^ result;
		int num2 = result & num;
		bool flag7 = num2 < 0;
		bool flag8 = flag5 == flag7;
		object obj7 = !flag8;
		object obj8 = obj7 | flag6;
		object obj9 = ~obj8;
		bool interactable = obj9 != null && flag4;
		confirmButton.interactable = interactable;
		if (success)
		{
			object text = "SubscribeGroup request Error" + 232;
			LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v24+E4]");
			bool flag9 = (nint)0 == 0;
			object obj12 = !flag9;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text2, (Vector2)0, 0f);
			object obj13 = typeof(Queue<string>) + 840;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v15+E4]");
			bool flag10 = (nint)0 == 0;
			object obj15 = !flag10;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj16 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ScreenManager screenManager = default(ScreenManager);
			screenManager.Back();
		}
		else if (error == KammelnaError.SupportRequestAlreadyOpen)
		{
			object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v8+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "Unsupported map type" + 3592;
			object body = "WhiteSmoke" + 1792;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
		}
		else
		{
			object title2 = "Error reading data from socket: " + 2976;
			object content = "Complete" + 2512;
			PopupWindowBuilder.ShowError((string)title2, (string)content);
		}
		return;
		IL_0073:
		if (this == null)
		{
			return;
		}
		goto IL_011c;
	}
}
