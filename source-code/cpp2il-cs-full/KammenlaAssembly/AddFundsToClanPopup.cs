using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class AddFundsToClanPopup : MonoBehaviour, IInitializable
{
	private InputField amountInput;

	private Button confirmButton;

	private TextMeshProUGUI availableBalanceText;

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
		object obj2 = (nint)0 + (nint)3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		InputField inputField = amountInput;
		object obj3 = typeof(TypeConverter<ushort, char>) + 464;
		object obj4 = (nint)0 + (nint)3152;
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

	private void OnEnable()
	{
		RefreshAvailableBalance();
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8626]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			trackEvent = TrackerLibrary.ClanVaultDepositViewed();
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
			trackEvent = TrackerLibrary.ClanVaultDepositViewed();
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

	private void RefreshAvailableBalance()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8627]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = availableBalanceText;
			obj6 = availableBalanceText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = availableBalanceText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = availableBalanceText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj6 != null))
		{
			return;
		}
		goto IL_014c;
		IL_014c:
		object obj8 = "Material with texture name \"" + 3224;
		int availableBalance = GetAvailableBalance();
		int num = default(int);
		string text = num.ToString((string)obj8);
		availableBalanceText.text = text;
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			return;
		}
		goto IL_014c;
	}

	private static int GetAvailableBalance()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0165: Expected I4, but got O
		//IL_01ac: Expected O, but got I4
		//IL_0227: Expected I4, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8628]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_0219;
		IL_0219:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0158:
		int num = (int)sessionModel.LocalUser;
		if (num != 0)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				User localUser = sessionModel2.LocalUser;
				return SFSKammelnaUserExtensions.GetAces(localUser);
			}
			goto IL_0219;
		}
		return num;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			goto IL_0158;
		}
		goto IL_0219;
	}

	private void OnConfirm()
	{
		//IL_0035: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0229: Expected O, but got I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0252: Expected O, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_0299: Expected I, but got O
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
		string title;
		object content;
		if (obj4 == null)
		{
			object obj5 = "Index = {0} position = {1}" + 2672;
			title = (string)obj5;
			content = "Drop Menu Toggle" + 3136;
		}
		else
		{
			int availableBalance = GetAvailableBalance();
			if (result <= availableBalance)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanVaultDepositClicked(result);
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+E4]");
				bool flag7 = (nint)0 == 0;
				object obj8 = !flag7;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				confirmButton.interactable = false;
				object obj9 = typeof(Queue<string>) + 728;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v12+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj12 = (nint)0 + (nint)1976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)3168;
				Action<bool> action = default(Action<bool>);
				action..ctor((object)this, (IntPtr)obj14);
				ClanServerConnector clanServerConnector = default(ClanServerConnector);
				clanServerConnector.DepositToVault(result, action);
				return;
			}
			ITrackEvent trackEvent2 = TrackerLibrary.ClanVaultDepositNotEnoughAces(result);
			object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v21+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
			object obj18 = "Network Authentication Required" + 2120;
			title = (string)obj18;
			content = "WhiteSmoke" + 1856;
		}
		PopupWindowBuilder.ShowError(title, (string)content);
	}

	private void OnDepositDone(bool success)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0283: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0379: Expected O, but got I4
		//IL_02bb: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E862A]");
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
		if (obj5 != null)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		InputField inputField = amountInput;
		int result;
		bool flag4 = int.TryParse(inputField.m_Text, out result);
		bool flag5 = result < 0;
		bool flag6 = result == 0;
		int num = result ^ result;
		int num2 = result & num;
		bool flag7 = num2 < 0;
		bool flag8 = flag5 == flag7;
		object obj6 = !flag8;
		object obj7 = obj6 | flag6;
		object obj8 = ~obj7;
		bool interactable = obj8 != null && flag4;
		confirmButton.interactable = interactable;
		if (success)
		{
			object obj9 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v11+90]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v12+B8]");
			object text = 0;
			amountInput.text = (string)text;
			object text2 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1624;
			LocalizableText text3 = TextMeshProExtensions.Localize((string)text2);
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v18+E4]");
			bool flag9 = (nint)0 == 0;
			object obj13 = !flag9;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show(text3, (Vector2)0, 0f);
			object obj14 = typeof(Queue<string>) + 840;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v12+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ScreenManager screenManager = default(ScreenManager);
			screenManager.Back();
		}
		else
		{
			object title = "Error reading data from socket: " + 2976;
			object content = "Complete" + 1896;
			PopupWindowBuilder.ShowError((string)title, (string)content);
		}
		return;
		IL_0074:
		if (this == null)
		{
			return;
		}
		goto IL_011d;
	}
}
