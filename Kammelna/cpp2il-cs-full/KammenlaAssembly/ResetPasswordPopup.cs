using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ResetPasswordPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public string email;

		public string confirmationCode;

		public Action<ResetPasswordPopup> <>9__1;

		internal void <Show>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_017a: Expected O, but got I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_01ac: Expected O, but got I
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00ae: Expected O, but got I
			//IL_00bc: Expected I, but got O
			//IL_00e1: Expected O, but got I
			//IL_010b: Expected O, but got I4
			//IL_003c: Expected O, but got I
			object obj = typeof(RegisteredWaitHandle) + 840;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
			object obj5 = 0;
			object obj6 = this + 32;
			Action<object> action = (Action<object>)obj6;
			Action<object> action2;
			object obj9;
			object obj7;
			if (obj6 != null)
			{
				obj7 = (nint)0 + (nint)2328;
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				action2 = action;
				obj9 = obj7;
				if (!flag2)
				{
					goto IL_0079;
				}
			}
			else
			{
				object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3320;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)4032;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj11);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj7 = (nint)0 + (nint)2328;
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v4+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				action = action3;
				action2 = action3;
				obj9 = obj7;
				if (obj12 != null)
				{
					goto IL_0079;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			obj7 = obj9;
			goto IL_0079;
			IL_0079:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		}

		internal void <Show>b__1(ResetPasswordPopup instance)
		{
			instance.Open(email, confirmationCode);
		}
	}

	private static readonly AddressReference<ResetPasswordPopup> Address;

	private PopupUI popup;

	private TextMeshProUGUI titleLabel;

	private TextMeshProUGUI bodyLabel;

	private InputFieldTMProUGUI newPasswordInput;

	private InputFieldTMProUGUI confirmPasswordInput;

	private GameObject errorContainer;

	private TextMeshProUGUI errorLabel;

	private Button submitButton;

	private Button cancelButton;

	private string _email;

	private string _confirmationCode;

	public static void Show(string email, string confirmationCode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00dc: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4024;
		object obj5 = typeof(RegisteredWaitHandle) + 3136;
		object obj6 = obj2 + 16;
		obj6 = email;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = confirmationCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.WaitForScene(Scenes.Login, action);
	}

	private void Open(string email, string confirmationCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0053: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_014b: Expected O, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I
		//IL_0215: Expected I, but got O
		//IL_0264: Expected O, but got I
		//IL_027c: Expected I, but got O
		object text = "Read object reference Id '{0}' for {1}." + 2744;
		object text2 = "Drop Menu Toggle" + 3240;
		object obj = this + 104;
		string text3 = default(string);
		obj = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 112;
		obj2 = confirmationCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v3-48]");
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v3-40]");
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, (string)text2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X21_v3-28]");
		((GameObject)0).SetActive(value: false);
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X20_v4+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v4+B8]");
		object text4 = 0;
		newPasswordInput.Text = (string)text4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X20_v4+90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v6+B8]");
		object text5 = 0;
		confirmPasswordInput.Text = (string)text5;
		object placeholder = "Network Authentication Required" + 88;
		newPasswordInput.SetPlaceholder((string)placeholder);
		object placeholder2 = "Complete" + 280;
		confirmPasswordInput.SetPlaceholder((string)placeholder2);
		newPasswordInput.ContentType = InputField.ContentType.Password;
		confirmPasswordInput.ContentType = InputField.ContentType.Password;
		object obj6 = (nint)0 + (nint)288;
		object text6 = "Complete" + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text6);
		object text7 = "COORDINATE_TYPE_GCJ_02" + 1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh2 = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh2, (string)text7);
		submitButton.interactable = true;
		Button button = submitButton;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = submitButton;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button2.m_OnClick.AddListener(unityAction);
		Button button3 = cancelButton;
		button3.m_OnClick.RemoveAllListeners();
		Button button4 = cancelButton;
		object obj9 = (nint)0 + (nint)1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj9);
		button4.m_OnClick.AddListener(unityAction2);
		popup.SlideFromTop();
	}

	private void Submit()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0125: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_01e0: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text = newPasswordInput.Text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsValidPassword(text))
			{
				goto IL_007f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringUtil.IsValidPassword(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_007f;
			}
		}
		GameObject gameObject = errorContainer;
		object text2 = "October" + 3408;
		goto IL_0203;
		IL_0203:
		gameObject.SetActive(value: true);
		TextMeshProExtensions.Localize(errorLabel, (string)text2);
		return;
		IL_007f:
		string text3 = newPasswordInput.Text;
		string text4 = confirmPasswordInput.Text;
		bool flag3 = text3 != text4;
		gameObject = errorContainer;
		if (flag3)
		{
			text2 = "October" + 3416;
			goto IL_0203;
		}
		errorContainer.SetActive(value: false);
		submitButton.interactable = false;
		string text5 = newPasswordInput.Text;
		string text6 = confirmPasswordInput.Text;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)1000;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		KammelnaRequests.ResetPassword(_email, text5, text6, _confirmationCode, action);
	}

	private void ShowError(string message)
	{
		errorContainer.SetActive(value: true);
		TextMeshProExtensions.Localize(errorLabel, message);
	}

	private void Dismiss()
	{
		popup.SlideToBottom();
	}

	static ResetPasswordPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Picking audio files is not supported on iOS" + 912;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3160;
		object obj3 = typeof(RegisteredWaitHandle) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Submit>b__14_0(KammelnaResponseModel<bool> response)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_011d: Expected O, but got I
		if (response.Succeeded)
		{
			popup.SlideToBottom();
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "Read object reference Id '{0}' for {1}." + 2744;
			object body = "not" + 3568;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v15+E4]");
			LoginControl loginControl = default(LoginControl);
			if ((nint)0 != 0)
			{
				object obj6 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				if ((object)loginControl == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = (nint)0 + (nint)168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				bool flag2 = (object)loginControl == null;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					return;
				}
			}
			loginControl.SwitchToLoginForm();
		}
		else
		{
			submitButton.interactable = true;
			string errorMessage = response.ErrorMessage;
			errorContainer.SetActive(value: true);
			TextMeshProExtensions.Localize(errorLabel, errorMessage);
		}
	}
}
