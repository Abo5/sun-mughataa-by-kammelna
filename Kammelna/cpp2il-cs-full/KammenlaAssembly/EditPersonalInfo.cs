using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;
using Util.SystemHelpers;

public class EditPersonalInfo : MonoBehaviour
{
	private const string UsernameInvalidMessage = "invalid_user_name";

	private const string EmailInvalidMessage = "Invalid email";

	private const string SuccessMessage = "nickname_changed_successfully";

	private const string SuccessMessageEmail = "email_changed_successfully";

	private InputFieldTMProUGUI userName;

	private InputFieldTMProUGUI email;

	private RectTransform successContainer;

	private RectTransform successContainerEmail;

	private TextMeshProUGUI successText;

	private TextMeshProUGUI successTextEmail;

	private RectTransform errorContainer;

	private RectTransform errorContainerEmail;

	private TextMeshProUGUI errorText;

	private TextMeshProUGUI errorTextEmail;

	private Sprite changeEmailIcon;

	private GameObject loadingIndicator;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0450: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0244: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0437: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj2 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj2);
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		userName.OnValidateInput += onValidateInput;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string text = SFSKammelnaUserExtensions.GetUserName(localUser);
		LocalizableText placeholder = TextMeshProExtensions.FixOnly(text);
		object obj7 = typeof(UsageHint) + 72;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		userName.SetPlaceholder(placeholder);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v15+E4]");
		string text2;
		string value;
		if ((nint)0 != 0)
		{
			text2 = UserInfo.Email;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			value = text2;
			if (!flag2)
			{
				goto IL_017d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text2 = UserInfo.Email;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			value = text2;
			if (obj11 != null)
			{
				goto IL_017d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = StringsExtensions.IsNullOrEmpty(value);
		InputFieldTMProUGUI inputFieldTMProUGUI = email;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		object obj13 = 0;
		InputFieldTMProUGUI inputFieldTMProUGUI2 = email;
		if (obj12 != null)
		{
			goto IL_01c4;
		}
		goto IL_02bb;
		IL_017d:
		bool flag6 = StringsExtensions.IsNullOrEmpty(text2);
		inputFieldTMProUGUI = email;
		bool flag7 = !flag6;
		obj13 = 0;
		inputFieldTMProUGUI2 = email;
		if (!flag7)
		{
			goto IL_01c4;
		}
		goto IL_02bb;
		IL_02bb:
		if ((object)inputFieldTMProUGUI2 != null)
		{
			object obj14 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v30+E4]");
			bool flag8 = (nint)0 == 0;
			object obj15 = !flag8;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = UserInfo.Email;
			LocalizableText placeholder2 = TextMeshProExtensions.FixOnly(text3);
			inputFieldTMProUGUI2.SetPlaceholder(placeholder2);
		}
		goto IL_034c;
		IL_034c:
		GameObject gameObject = errorContainer.gameObject;
		gameObject.SetActive(value: true);
		errorContainer.localScale = (Vector3)0;
		GameObject gameObject2 = successContainer.gameObject;
		gameObject2.SetActive(value: true);
		successContainer.localScale = (Vector3)0;
		GameObject gameObject3 = errorContainerEmail.gameObject;
		gameObject3.SetActive(value: true);
		errorContainerEmail.localScale = (Vector3)0;
		GameObject gameObject4 = successContainerEmail.gameObject;
		gameObject4.SetActive(value: true);
		successContainerEmail.localScale = (Vector3)0;
		return;
		IL_01c4:
		if ((object)inputFieldTMProUGUI != null)
		{
			object placeholder3 = "Cannot populate JSON object onto type '{0}'." + 2088;
			inputFieldTMProUGUI.SetPlaceholder((string)placeholder3);
		}
		goto IL_034c;
	}

	public void OnSubmit()
	{
		//IL_0037: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0398: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_030f: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_0339: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01b9: Expected I, but got O
		HideMessages();
		bool flag = (object)userName == null;
		string text = (string)(object)userName;
		if (!flag)
		{
			string text2 = userName.Text;
			text = text2.Trim();
		}
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(System.IOAsyncCallback) + 3096;
		string input = (string)((text != null) ? text : obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = InputSanitizer.SanitizeHtmlTags(input);
		string text4 = TextMeshProExtensions.SanitizeHasCharacter(successText, text3);
		bool flag3 = (object)email == null;
		string text5 = (string)(object)email;
		if (!flag3)
		{
			string text6 = email.Text;
			text5 = text6.Trim();
		}
		string value = (string)((text5 != null) ? text5 : obj);
		bool flag4 = string.IsNullOrEmpty(text4);
		bool flag5 = !flag4;
		object obj5 = !flag5;
		string text7 = null;
		object obj7;
		if (obj5 == null)
		{
			if (text4._stringLength <= 2)
			{
				object message = "https://www.kammelna.com/Home/Terms" + 2216;
				ShowError((string)message);
				bool flag6 = string.IsNullOrEmpty(value);
				bool flag7 = !flag6;
				object obj6 = !flag7;
				text7 = null;
				obj7 = 0;
				if (obj6 != null)
				{
					return;
				}
				goto IL_0266;
			}
			loadingIndicator.SetActive(value: true);
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)232;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj9);
			KammelnaRequests.ChangeNickName(text4, action);
			text7 = null;
		}
		bool flag8 = string.IsNullOrEmpty(value);
		bool flag9 = !flag8;
		obj7 = 0;
		if (!flag9)
		{
			return;
		}
		goto IL_0266;
		IL_02d2:
		ChangeEmail();
		return;
		IL_0266:
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			if (StringUtil.IsValidEmail(value))
			{
				goto IL_02d2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = StringUtil.IsValidEmail(value);
			bool flag11 = !flag10;
			object obj12 = !flag11;
			if (obj12 != null)
			{
				goto IL_02d2;
			}
		}
		object text8 = "Index = {0} position = {1}" + 3264;
		object obj13 = (nint)0 + (nint)2904;
		TextMeshProExtensions.Localize(errorTextEmail, (string)text8);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(errorContainerEmail, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ChangeEmail()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0078: Expected I, but got O
		loadingIndicator.SetActive(value: true);
		string text = email.Text;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)240;
		string newEmail = text.Trim();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.ChangeEmail(newEmail, action);
	}

	private void ChangeResponse(KammelnaResponseModel<string> response)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0116: Expected O, but got I4
		//IL_0144: Expected F8, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0200: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I4
		loadingIndicator.SetActive(value: false);
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object text = "m_StencilDeferredPS" + 3640;
			TextMeshProExtensions.Localize(successText, (string)text);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(successContainer, 1f, 0.3f);
			object obj = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
		else if (response.<Error>k__BackingField == KammelnaError.TimeLimit)
		{
			object obj2 = (nint)0 + (nint)1520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AEA314");
			object obj3 = typeof(DataRelation) + 824;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v11+10]");
			DateTime dateTime = DateTimeUtil.FromTimeStamp(0.0);
			object obj6 = typeof(DataRelation) + 712;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = dateTime - now;
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalDays = timeSpan2.TotalDays;
			object obj12 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 4040;
			object obj13 = "utf-32" + 2904;
			if (!(totalDays < 1.0))
			{
				obj12 = obj13;
			}
			object obj14 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v25+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime2 = default(DateTime);
			string extra = dateTime2.ToString((string)obj12);
			string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			ShowError(errorMessage, extra);
		}
		else
		{
			string errorMessage2 = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
			ShowError(errorMessage2);
		}
	}

	private void ChangeResponseEmail(KammelnaResponseModel<bool> response)
	{
		//IL_0027: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		loadingIndicator.SetActive(value: false);
		object obj = (nint)0 + (nint)2904;
		if (response.Succeeded)
		{
			object text = "destinationTimeZone" + 1904;
			TextMeshProExtensions.Localize(successTextEmail, (string)text);
			object obj2 = 56;
		}
		else
		{
			string errorMessage = response.ErrorMessage;
			TextMeshProExtensions.Localize(errorTextEmail, errorMessage);
			object obj2 = 88;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (EditPersonalInfo)+v119 @ X8_v5]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY((Transform)0, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ShowError(string message, string extra = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_004a: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		//IL_0110: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		TextMeshProExtensions.Localize(errorText, message);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		object obj3;
		object obj5;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2904;
			bool flag = StringsExtensions.IsNullOrEmpty(extra);
			bool flag2 = !flag;
			object obj4 = 0;
			if (flag2)
			{
				goto IL_00c6;
			}
			obj5 = obj3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = (nint)0 + (nint)2904;
			bool flag3 = StringsExtensions.IsNullOrEmpty(extra);
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj4 = 0;
			obj5 = obj3;
			if (obj6 == null)
			{
				goto IL_00c6;
			}
		}
		goto IL_0170;
		IL_0170:
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(errorContainer, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_00c6:
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj8 = (nint)0 + (nint)3072;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize(message);
		string text2 = text + (string)obj8 + extra;
		TextMeshProExtensions.FixArabic(errorText, text2);
		obj5 = obj3;
		goto IL_0170;
	}

	private void ShowErrorEmail(string message)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2904;
		string text = default(string);
		TextMeshProExtensions.Localize(errorTextEmail, text);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(errorContainerEmail, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void HideMessages()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2904;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(successContainer, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScaleY(errorContainer, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScaleY(successContainerEmail, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScaleY(errorContainerEmail, 0f, 0.1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}
}
