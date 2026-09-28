using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class PasswordEditor : MonoBehaviour
{
	private sealed class <>c__DisplayClass9_0
	{
		public bool showOldPassword;

		internal void <SetupUi>b__0(GameObject o)
		{
			o.SetActive(showOldPassword);
		}
	}

	private TextMeshProUGUI successLabel;

	private GameObject successContainer;

	private TextMeshProUGUI errorLabel;

	private GameObject errorContainer;

	private InputFieldTMProUGUI currentPasswordInput;

	private InputFieldTMProUGUI newPasswordInput;

	private InputFieldTMProUGUI newPasswordConfirmationInput;

	private GameObject[] oldPasswordObject;

	private GameObject loadingIndicator;

	public void SetupUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_016a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object text = (nint)0 + (nint)2000;
		newPasswordConfirmationInput.Text = (string)text;
		newPasswordInput.Text = (string)text;
		currentPasswordInput.Text = (string)text;
		successContainer.SetActive(value: false);
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		errorContainer.SetActive(value: false);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag2 = SFSKammelnaUserExtensions.IsSocialConnected(localUser);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj8 = (nint)0 + (nint)336;
		object obj9 = (flag2 ? 1 : 0) ^ 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		ArraysExtensions.ForEach(oldPasswordObject, action);
	}

	private void OnPasswordChange(KammelnaResponseModel<bool> response)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		loadingIndicator.SetActive(value: false);
		if (response.Succeeded)
		{
			object message = "not" + 3568;
			ShowSuccess((string)message);
			return;
		}
		string errorMessage = response.ErrorMessage;
		object obj = "utf-32" + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
		string errorMessage2 = (string)(((nint)0 != 2000) ? errorMessage : obj);
		ShowError(errorMessage2);
	}

	public void OnOKClick()
	{
		if (ValidateInput(out var errorMessage))
		{
			successContainer.SetActive(value: false);
			errorContainer.SetActive(value: false);
			SendChangePassword();
		}
		else
		{
			ShowError(errorMessage);
		}
	}

	private unsafe bool ValidateInput(out string errorMessage)
	{
		//IL_029d: Expected I4, but got O
		//IL_0011: Expected O, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		object obj6;
		bool result;
		object obj11;
		if ((object)currentPasswordInput != null)
		{
			object obj = (nint)0 + (nint)2000;
			string text = currentPasswordInput.Text;
			if (text == (string)obj)
			{
				object obj2 = typeof(Queue<string>) + 848;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel == null)
				{
					goto IL_028f;
				}
				User localUser = sessionModel.LocalUser;
				if (!SFSKammelnaUserExtensions.IsSocialConnected(localUser))
				{
					obj6 = "Drop Menu Toggle" + 3256;
					object obj7 = 0;
					result = false;
					goto IL_02bc;
				}
			}
			if ((object)newPasswordInput != null)
			{
				string text2 = newPasswordInput.Text;
				if (text2 == (string)obj)
				{
					obj6 = "Drop Menu Toggle" + 3216;
					object obj7 = 0;
					result = false;
					goto IL_02bc;
				}
				if ((object)newPasswordInput != null)
				{
					string text3 = newPasswordInput.Text;
					if ((object)newPasswordConfirmationInput != null)
					{
						string text4 = newPasswordConfirmationInput.Text;
						bool flag2 = text3 != text4;
						object obj8 = "October" + 3400;
						bool flag3 = !flag2;
						object obj9 = !flag3;
						object obj10 = ~obj9;
						obj11 = ((obj10 != null) ? ((object)0) : obj8);
						result = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
						object obj7 = 0;
						goto IL_02e5;
					}
				}
			}
		}
		goto IL_028f;
		IL_02e5:
		ref string reference = ref *(string*)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return result;
		IL_02bc:
		obj11 = obj6;
		goto IL_02e5;
		IL_028f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void SendChangePassword()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_007a: Expected I, but got O
		loadingIndicator.SetActive(value: true);
		string text = newPasswordInput.Text;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)2880;
		string text2 = currentPasswordInput.Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.ChangePassword(text, text2, action);
	}

	private void ShowSuccess(string message)
	{
		successContainer.SetActive(value: false);
		errorContainer.SetActive(value: false);
		TextMeshProExtensions.Localize(successLabel, message);
		successContainer.SetActive(value: true);
	}

	private void ShowError(string errorMessage)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		successContainer.SetActive(value: false);
		errorContainer.SetActive(value: false);
		TextMeshProExtensions.Localize(errorLabel, errorMessage);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		errorContainer.SetActive(value: true);
		ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordError(errorMessage);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void HideMessage()
	{
		successContainer.SetActive(value: false);
		errorContainer.SetActive(value: false);
	}
}
