using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ResetPassword : MonoBehaviour
{
	public InputField EmailInput;

	public GameObject ErrorContainer;

	public TextMeshProUGUI ErrorLabel;

	public Button resetPasswordButton;

	public GameObject loadingIndicator;

	private void ShowError(string errorMessage)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FFB]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			trackEvent = TrackerLibrary.AccountRestPasswordError(errorMessage);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.AccountRestPasswordError(errorMessage);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			trackEvent2 = trackEvent;
			if (obj6 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		GameObject errorContainer = ErrorContainer;
		bool flag3 = (object)ErrorContainer == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b3;
		IL_009b:
		Tracker.DesignEvent(trackEvent);
		errorContainer = ErrorContainer;
		goto IL_00b3;
		IL_00b3:
		errorContainer.SetActive(value: true);
		TextMeshProExtensions.Localize(ErrorLabel, errorMessage);
	}

	private void OnDisable()
	{
		ErrorContainer.SetActive(value: false);
	}

	public void ResetPasswordOnClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_0202: Expected O, but got I4
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_0257: Expected I, but got O
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FFC]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.AccountRestPasswordClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v13+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.AccountRestPasswordClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			trackEvent2 = trackEvent;
			if (obj4 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		GameObject errorContainer = ErrorContainer;
		goto IL_0142;
		IL_0210:
		InputField emailInput = EmailInput;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)992;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		KammelnaRequests.ForgotPassword(emailInput.m_Text, action);
		return;
		IL_0142:
		errorContainer.SetActive(value: false);
		loadingIndicator.SetActive(value: true);
		GameObject gameObject = resetPasswordButton.gameObject;
		gameObject.SetActive(value: false);
		InputField emailInput2 = EmailInput;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = StringUtil.IsValidEmail(emailInput2.m_Text);
			bool flag4 = !flag3;
			object obj9 = 0;
			if (!flag4)
			{
				goto IL_0210;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringUtil.IsValidEmail(emailInput2.m_Text);
			bool flag6 = !flag5;
			object obj10 = !flag6;
			object obj9 = 0;
			if (obj10 != null)
			{
				goto IL_0210;
			}
		}
		loadingIndicator.SetActive(value: false);
		GameObject gameObject2 = resetPasswordButton.gameObject;
		gameObject2.SetActive(value: true);
		object errorMessage = "Index = {0} position = {1}" + 3264;
		ShowError((string)errorMessage);
		return;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		errorContainer = ErrorContainer;
		bool flag7 = (object)ErrorContainer == null;
		object obj11 = !flag7;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0142;
	}

	private void <ResetPasswordOnClick>b__7_0(KammelnaResponseModel<bool> response)
	{
		//IL_004d: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		loadingIndicator.SetActive(value: false);
		GameObject gameObject = resetPasswordButton.gameObject;
		gameObject.SetActive(value: true);
		object obj = (nint)0 + (nint)1048;
		if (response.Succeeded)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "SERVICE_DISABLED" + 3040;
			object body = "Picking audio files is not supported on iOS" + 544;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
			ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordSucceeded();
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v18+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			ShowError(errorMessage);
		}
	}
}
