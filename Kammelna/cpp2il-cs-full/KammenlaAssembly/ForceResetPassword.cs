using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.WebRequests;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ForceResetPassword : MonoBehaviour
{
	private InputField emailInput;

	private InputField oldPasswordInput;

	private InputField newPasswordInput;

	private GameObject newPasswordError;

	private InputField newPasswordConfirmInput;

	private GameObject newPasswordConfirmError;

	private GameObject errorContainer;

	private TextMeshProUGUI errorLabel;

	private Button resetPasswordButton;

	private GameObject loadingIndicator;

	public LoginControl LoginControl;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_01e8: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C98]");
		object obj3 = (nint)0 & (nint)1;
		InputField inputField;
		InputField inputField2;
		if (obj3 != null)
		{
			inputField = emailInput;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			inputField2 = emailInput;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			inputField = emailInput;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			inputField2 = emailInput;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string email = UserInfo.Email;
		inputField = inputField2;
		goto IL_013e;
		IL_013e:
		inputField.text = email;
		InputField inputField3 = newPasswordInput;
		object obj6 = typeof(TypeConverter<ushort, char>) + 464;
		object obj7 = (nint)0 + (nint)2048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1208;
		((UnityEvent<object>)(object)inputField3.m_OnDidEndEdit).AddListener(unityAction);
		InputField inputField4 = newPasswordConfirmInput;
		object obj9 = (nint)0 + (nint)2056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj9);
		((UnityEvent<object>)(object)inputField4.m_OnDidEndEdit).AddListener(unityAction2);
		return;
		IL_0091:
		email = UserInfo.Email;
		bool flag3 = (object)inputField == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013e;
	}

	private void OnDisable()
	{
		errorContainer.SetActive(value: false);
	}

	private void ShowSuccess()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		errorContainer.SetActive(value: false);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Network Authentication Required" + 320;
		object body = "not" + 3568;
		object buttonText = "Network Authentication Required" + 3128;
		LoginControl.SwitchToLoginForm();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
	}

	private void ShowError(string errorMessage)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		TextMeshProExtensions.Localize(errorLabel, errorMessage);
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		errorContainer.SetActive(value: true);
		ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordError(errorMessage);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void ResetPasswordOnClick()
	{
		//IL_0047: Expected O, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_022e: Expected O, but got I
		//IL_023c: Expected I, but got O
		InputField inputField = newPasswordInput;
		bool flag = ValidateNewPassword(inputField.m_Text);
		InputField inputField2 = newPasswordConfirmInput;
		bool flag2 = ValidateNewPasswordConfirmation(inputField2.m_Text);
		object obj = flag && flag2;
		if ((nint)obj != 1)
		{
			return;
		}
		errorContainer.SetActive(value: false);
		loadingIndicator.SetActive(value: true);
		GameObject gameObject = resetPasswordButton.gameObject;
		gameObject.SetActive(value: false);
		InputField inputField3 = newPasswordInput;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = StringUtil.IsValidPassword(inputField3.m_Text);
			bool flag4 = !flag3;
			object obj4 = 0;
			if (!flag4)
			{
				goto IL_0137;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringUtil.IsValidPassword(inputField3.m_Text);
			bool flag6 = !flag5;
			object obj5 = !flag6;
			object obj4 = 0;
			if (obj5 != null)
			{
				goto IL_0137;
			}
		}
		loadingIndicator.SetActive(value: false);
		GameObject gameObject2 = resetPasswordButton.gameObject;
		gameObject2.SetActive(value: true);
		newPasswordError.SetActive(value: true);
		return;
		IL_0137:
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ForcePasswordChangeRequestModel forcePasswordChangeRequestModel = default(ForcePasswordChangeRequestModel);
		forcePasswordChangeRequestModel..ctor();
		InputField inputField4 = emailInput;
		object obj7 = forcePasswordChangeRequestModel + 16;
		obj7 = inputField4.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InputField inputField5 = oldPasswordInput;
		object obj8 = forcePasswordChangeRequestModel + 24;
		obj8 = inputField5.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InputField inputField6 = newPasswordInput;
		object obj9 = forcePasswordChangeRequestModel + 32;
		obj9 = inputField6.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2040;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj11);
		KammelnaRequests.ForcePasswordChange(forcePasswordChangeRequestModel, action);
	}

	private bool ValidateAll()
	{
		//IL_0098: Expected I4, but got O
		InputField inputField = newPasswordInput;
		if ((object)newPasswordInput != null)
		{
			bool flag = ValidateNewPassword(inputField.m_Text);
			InputField inputField2 = newPasswordConfirmInput;
			if ((object)newPasswordConfirmInput != null)
			{
				bool flag2 = ValidateNewPasswordConfirmation(inputField2.m_Text);
				return flag && flag2;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool ValidateNewPassword(string password)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_0237: Expected I4, but got O
		//IL_01ac: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C9C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringUtil.IsValidPassword(password);
		GameObject gameObject = newPasswordError;
		bool flag3 = (object)newPasswordError == null;
		bool flag4 = flag2;
		if (!flag3)
		{
			goto IL_014d;
		}
		goto IL_0229;
		IL_0229:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_014d:
		GameObject gameObject2 = gameObject.gameObject;
		if ((object)gameObject2 != null)
		{
			bool active = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
			gameObject2.SetActive(active);
			bool flag5 = !flag4;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				RectTransform rect = UIExtensions.rectTransform(newPasswordInput);
				object obj6 = typeof(SqlSingle[]) + 3912;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v7+E4]");
				bool flag6 = (nint)0 == 0;
				object obj8 = !flag6;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AnimationExtensions.ErrorFeedback(rect);
			}
			return flag4;
		}
		goto IL_0229;
		IL_0074:
		bool flag7 = StringUtil.IsValidPassword(password);
		gameObject = newPasswordError;
		bool flag8 = (object)newPasswordError == null;
		object obj9 = !flag8;
		flag4 = flag7;
		if (obj9 != null)
		{
			goto IL_014d;
		}
		goto IL_0229;
	}

	private bool ValidateNewPasswordConfirmation(string password)
	{
		//IL_0126: Expected I4, but got O
		//IL_009b: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		InputField inputField = newPasswordInput;
		if ((object)newPasswordInput != null)
		{
			bool flag = password == inputField.m_Text;
			if ((object)newPasswordConfirmError != null)
			{
				GameObject gameObject = newPasswordConfirmError.gameObject;
				if ((object)gameObject != null)
				{
					bool active = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
					gameObject.SetActive(active);
					bool flag2 = !flag;
					object obj = !flag2;
					if (obj == null)
					{
						RectTransform rect = UIExtensions.rectTransform(newPasswordConfirmInput);
						object obj2 = typeof(SqlSingle[]) + 3912;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+E4]");
						bool flag3 = (nint)0 == 0;
						object obj4 = !flag3;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						AnimationExtensions.ErrorFeedback(rect);
					}
					return flag;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <Start>b__11_0(string str)
	{
		bool flag = ValidateNewPassword(str);
	}

	private void <Start>b__11_1(string str)
	{
		bool flag = ValidateNewPasswordConfirmation(str);
	}

	private void <ResetPasswordOnClick>b__15_0(KammelnaResponseModel<bool> response)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I8
		loadingIndicator.SetActive(value: false);
		GameObject gameObject = resetPasswordButton.gameObject;
		gameObject.SetActive(value: true);
		if (response.Succeeded)
		{
			ShowSuccess();
			return;
		}
		string errorMessage = response.ErrorMessage;
		object obj = "utf-32" + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+14]");
		object obj2 = 0 & 0xFFFFFFFEL;
		string errorMessage2 = (string)(((nint)obj2 != 2000) ? errorMessage : obj);
		ShowError(errorMessage2);
	}
}
