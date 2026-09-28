using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Features.GameReplay;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util.SystemHelpers;

public class RegisterForm : MonoBehaviour
{
	private sealed class <>c__DisplayClass19_0
	{
		public RegisterForm <>4__this;

		public SocialUser user;

		internal unsafe void <RegisterSocial>b__0(KammelnaResponseModel<RegisteredUserModel> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got Unknown
			//IL_0250: Expected O, but got I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_0087: Expected O, but got I4
			//IL_02e7: Expected O, but got Ref
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected O, but got Unknown
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected O, but got Unknown
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			//IL_02b4: Expected O, but got I4
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Expected O, but got Unknown
			//IL_0344: Expected O, but got I4
			//IL_034d: Expected O, but got I4
			//IL_00db: Expected O, but got I
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_01a3: Expected O, but got I4
			//IL_01ba: Expected O, but got I4
			//IL_01c3: Expected O, but got I4
			object obj = (nint)0 + (nint)1392;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				RegisteredUserModel <Model>k__BackingField = response.<Model>k__BackingField;
				object obj2 = typeof(UsageHint) + 72;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UserInfo.Email = <Model>k__BackingField.email;
				RegisterForm registerForm = <>4__this;
				string email = UserInfo.Email;
				object password = (nint)0 + (nint)2000;
				registerForm.LoginControl.RegisterSuccess(email, (string)password);
				object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
				object action = "Read object reference Id '{0}' for {1}." + 1200;
				FirebaseTrack.Event((string)action, friendlyName);
				SocialUser socialUser = user;
				trackEvent = TrackerLibrary.AccountSocialRegisterSucceeded(socialUser.<Platform>k__BackingField);
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					object obj9 = 0;
					object obj10 = 0;
					string text = null;
					trackEvent2 = trackEvent;
					goto IL_036b;
				}
			}
			else
			{
				RegisterForm registerForm2 = <>4__this;
				if (response.<Error>k__BackingField == KammelnaError.EmailAlreadyUsed)
				{
					registerForm2.LoginControl.SwitchToLoginForm();
					object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v18+E4]");
					bool flag3 = (nint)0 == 0;
					object obj13 = !flag3;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object title = "SetRoomVariables request error" + 1584;
					object body = "java.io.FileOutputStream" + 536;
					object buttonText = "Network Authentication Required" + 3128;
					PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
					object obj9 = 0;
				}
				else
				{
					<>4__this.ParseError(response);
				}
				SocialUser socialUser2 = user;
				SocialPlatform socialPlatform = default(SocialPlatform);
				string text2 = ((Enum)(&socialPlatform)).ToString();
				trackEvent2 = TrackerLibrary.AccountSocialRegisterError(socialUser2.<Platform>k__BackingField, text2);
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj7 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				object obj10 = 0;
				string text = text2;
				trackEvent = trackEvent2;
				if (obj15 == null)
				{
					goto IL_036b;
				}
			}
			goto IL_0382;
			IL_0382:
			Tracker.DesignEvent(trackEvent);
			return;
			IL_036b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			trackEvent = trackEvent2;
			goto IL_0382;
		}
	}

	public InputField EmailInput;

	public GameObject EmailError;

	public InputField PasswordInput;

	public GameObject PasswordError;

	public InputField PasswordConfirmationInput;

	public GameObject PasswordConfirmationError;

	public InputField UserNameInput;

	public GameObject UserNameError;

	public InputField PhoneInput;

	public GameObject PhoneError;

	public Toggle TermsAndConditions_toggle;

	public GameObject TermsAndConditions_error;

	public TextMeshProUGUI ErrorLabel;

	public GameObject ErrorContainer;

	public GameObject SuggestedUsernameInfo;

	public Button RegisterButton;

	public LoginControl LoginControl;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0083: Expected O, but got I
		//IL_009b: Expected I, but got O
		//IL_00ac: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_0123: Expected O, but got I
		//IL_013b: Expected I, but got O
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_0199: Expected I, but got O
		//IL_0218: Expected O, but got I
		//IL_0230: Expected I, but got O
		//IL_0262: Expected O, but got I
		//IL_027a: Expected I, but got O
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		//IL_02d8: Expected I, but got O
		//IL_02e9: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		Button registerButton = RegisterButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		registerButton.m_OnClick.AddListener(unityAction);
		InputField emailInput = EmailInput;
		object obj3 = typeof(TypeConverter<ushort, char>) + 464;
		object obj4 = (nint)0 + (nint)2832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1208;
		((UnityEvent<object>)(object)emailInput.m_OnDidEndEdit).AddListener(unityAction2);
		InputField passwordInput = PasswordInput;
		object obj6 = (nint)0 + (nint)2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction3 = default(UnityAction<object>);
		unityAction3..ctor((object)this, (IntPtr)obj6);
		((UnityEvent<object>)(object)passwordInput.m_OnDidEndEdit).AddListener(unityAction3);
		InputField passwordConfirmationInput = PasswordConfirmationInput;
		object obj7 = (nint)0 + (nint)2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction4 = default(UnityAction<object>);
		unityAction4..ctor((object)this, (IntPtr)obj7);
		((UnityEvent<object>)(object)passwordConfirmationInput.m_OnDidEndEdit).AddListener(unityAction4);
		InputField userNameInput = UserNameInput;
		object obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj9 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj9);
		Delegate obj10 = Delegate.Combine(userNameInput.m_OnValidateInput, onValidateInput);
		if ((object)obj10 == null || obj10 == obj8)
		{
			userNameInput.onValidateInput = (InputField.OnValidateInput)obj10;
			InputField userNameInput2 = UserNameInput;
			object obj11 = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<object> unityAction5 = default(UnityAction<object>);
			unityAction5..ctor((object)this, (IntPtr)obj11);
			((UnityEvent<object>)(object)userNameInput2.m_OnDidEndEdit).AddListener(unityAction5);
			InputField phoneInput = PhoneInput;
			object obj12 = (nint)0 + (nint)2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<object> unityAction6 = default(UnityAction<object>);
			unityAction6..ctor((object)this, (IntPtr)obj12);
			((UnityEvent<object>)(object)phoneInput.m_OnDidEndEdit).AddListener(unityAction6);
			Toggle termsAndConditions_toggle = TermsAndConditions_toggle;
			object obj13 = typeof(TypeConverter<ushort, char>) + 360;
			object obj14 = (nint)0 + (nint)2864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<bool> unityAction7 = default(UnityAction<bool>);
			unityAction7..ctor((object)this, (IntPtr)obj14);
			object obj15 = (nint)0 + (nint)832;
			object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			termsAndConditions_toggle.onValueChanged.AddListener(unityAction7);
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				Platform platform = KUtil.GetPlatform();
				if (platform != Platform.IOS)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Platform platform2 = KUtil.GetPlatform();
				if (platform2 != Platform.IOS)
				{
					return;
				}
			}
			GameObject gameObject = PhoneInput.gameObject;
			gameObject.SetActive(value: false);
			return;
		}
		throw new InvalidCastException();
	}

	private void SubmitRegisterForm()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0095: Expected O, but got I
		//IL_00bb: Expected I, but got O
		GameObject gameObject = RegisterButton.gameObject;
		gameObject.SetActive(value: false);
		InputField emailInput = EmailInput;
		InputField passwordInput = PasswordInput;
		InputField userNameInput = UserNameInput;
		string nickname = userNameInput.m_Text.Trim();
		InputField phoneInput = PhoneInput;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 592;
		object obj2 = (nint)0 + (nint)2808;
		string deviceId = UserDeviceIDRecorder.DeviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.Register(emailInput.m_Text, passwordInput.m_Text, nickname, phoneInput.m_Text, deviceId, action);
	}

	public void RegisterSocial(SocialUser user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00b1: Expected I, but got O
		//IL_0106: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0106: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 592;
		object obj7 = (nint)0 + (nint)3720;
		string deviceId = UserDeviceIDRecorder.DeviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+30]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+10]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+38]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+18]");
		KammelnaRequests.RegisterSocial((string)num, (string)num2, (string)num3, (string)num4, (SocialPlatform)num5, (string)0, deviceId, action);
	}

	private void ParseError(KammelnaResponseModel<RegisteredUserModel> response)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_00f6: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		ITrackEvent trackEvent = TrackerLibrary.AccountRegisterError(errorMessage);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		string errorMessage2 = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		ErrorContainer.SetActive(value: true);
		TextMeshProExtensions.Localize(ErrorLabel, errorMessage2);
		if (response.<Error>k__BackingField == KammelnaError.NickNameAlreadyUsed)
		{
			object obj4 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AEA314");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v13+10]");
			UpdateUsername((string)0);
		}
	}

	private void UpdateUsername(string alternativeUsername)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_01c7: Expected F4, but got I
		//IL_01c7: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_0204: Expected F4, but got O
		//IL_0204: Expected O, but got I4
		//IL_014d: Expected I, but got O
		object obj = typeof(System.IOAsyncCallback) + 3096;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = InputSanitizer.SanitizeHtmlTags(alternativeUsername);
		UserNameInput.text = text;
		Transform transform = SuggestedUsernameInfo.transform;
		object obj4 = typeof(UsageHint) + 816;
		transform.localScale = (Vector3)0;
		SuggestedUsernameInfo.SetActive(value: true);
		Transform target = SuggestedUsernameInfo.transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj5 = (nint)0 + (nint)2904;
		Transform target2 = SuggestedUsernameInfo.transform;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, (Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj8 = (nint)0 + (nint)2776;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2816;
		object obj11 = (nint)0 + (nint)2504;
		Transform target3 = SuggestedUsernameInfo.transform;
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v15+B8]");
		object obj13 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target3, (Vector3)0, (float)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void RegisterOnClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FF3]");
		object obj2 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj2 != null)
		{
			trackEvent = TrackerLibrary.AccountRegisterClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
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
			trackEvent = TrackerLibrary.AccountRegisterClicked();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+E4]");
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
		bool flag3 = (object)ErrorContainer == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_009d;
		IL_0085:
		Tracker.DesignEvent(trackEvent);
		errorContainer = ErrorContainer;
		goto IL_009d;
		IL_009d:
		errorContainer.SetActive(value: false);
		ValidateAll();
		if (IsValid())
		{
			SubmitRegisterForm();
		}
	}

	private void ShowError(string error)
	{
		ErrorContainer.SetActive(value: true);
		TextMeshProExtensions.Localize(ErrorLabel, error);
	}

	private void ValidateEmail(string email)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FF4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringUtil.IsValidEmail(email);
		GameObject emailError = EmailError;
		bool flag3 = flag2;
		goto IL_0133;
		IL_0133:
		GameObject gameObject = emailError.gameObject;
		bool active = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		return;
		IL_0074:
		bool flag4 = StringUtil.IsValidEmail(email);
		emailError = EmailError;
		bool flag5 = (object)EmailError == null;
		object obj5 = !flag5;
		flag3 = flag4;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void ValidatePassword(string password)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		GameObject gameObject = PasswordError.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = StringUtil.IsValidPassword(password);
		bool active = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}

	private void ValidatePasswordConfirmation(string password)
	{
		GameObject gameObject = PasswordConfirmationError.gameObject;
		InputField passwordInput = PasswordInput;
		bool active = password != passwordInput.m_Text;
		gameObject.SetActive(active);
	}

	private void ValidateUserName(string login)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected I4, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 3096;
		string input = login.Trim();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = InputSanitizer.SanitizeHtmlTags(input);
		string text2 = TextMeshProExtensions.SanitizeHasCharacter(ErrorLabel, text);
		UserNameInput.text = text2;
		GameObject gameObject = UserNameError.gameObject;
		InputField userNameInput = UserNameInput;
		string text3 = userNameInput.m_Text;
		object obj4 = text3._stringLength - 3;
		bool flag2 = (nint)obj4 < 0;
		int num = text3._stringLength ^ 3;
		int num2 = text3._stringLength ^ obj4;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag2 == flag3;
		bool active = !flag4;
		gameObject.SetActive(active);
	}

	private void ValidatePhone(string phone)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string value = phone.Trim();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+E4]");
		GameObject phoneError;
		GameObject phoneError2;
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(value);
			phoneError = PhoneError;
			bool flag2 = !flag;
			phoneError2 = PhoneError;
			if (!flag2)
			{
				goto IL_008d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(value);
			phoneError = PhoneError;
			bool flag4 = !flag3;
			object obj3 = !flag4;
			phoneError2 = PhoneError;
			if (obj3 != null)
			{
				goto IL_008d;
			}
		}
		GameObject gameObject = phoneError2.gameObject;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = StringUtil.IsValidPhone(phone);
		bool active = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
		return;
		IL_008d:
		GameObject gameObject2 = phoneError.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void ValidateTermsAndConditions(bool isOn)
	{
		GameObject gameObject = TermsAndConditions_error.gameObject;
		bool active = (byte)((isOn ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}

	private void ValidateAll()
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_033b: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_048a: Expected O, but got I4
		InputField emailInput = EmailInput;
		ValidateEmail(emailInput.m_Text);
		InputField passwordInput = PasswordInput;
		ValidatePassword(passwordInput.m_Text);
		InputField passwordConfirmationInput = PasswordConfirmationInput;
		GameObject gameObject = PasswordConfirmationError.gameObject;
		InputField passwordInput2 = PasswordInput;
		bool active = passwordConfirmationInput.m_Text != passwordInput2.m_Text;
		gameObject.SetActive(active);
		InputField userNameInput = UserNameInput;
		ValidateUserName(userNameInput.m_Text);
		InputField phoneInput = PhoneInput;
		ValidatePhone(phoneInput.m_Text);
		Toggle termsAndConditions_toggle = TermsAndConditions_toggle;
		GameObject gameObject2 = TermsAndConditions_error.gameObject;
		bool active2 = (byte)((termsAndConditions_toggle.m_IsOn ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active2);
		if (PhoneError.activeInHierarchy)
		{
			RectTransform rect = UIExtensions.rectTransform(PhoneInput);
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v34+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect);
			double num = 0.5;
			double num2 = 15.0;
		}
		if (PasswordError.activeInHierarchy)
		{
			RectTransform rect2 = UIExtensions.rectTransform(PasswordInput);
			object obj4 = typeof(SqlSingle[]) + 3912;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect2);
			double num = 0.5;
			double num2 = 15.0;
		}
		if (PasswordConfirmationError.activeInHierarchy)
		{
			RectTransform rect3 = UIExtensions.rectTransform(PasswordConfirmationInput);
			object obj7 = typeof(SqlSingle[]) + 3912;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect3);
			double num = 0.5;
			double num2 = 15.0;
		}
		if (UserNameError.activeInHierarchy)
		{
			RectTransform rect4 = UIExtensions.rectTransform(UserNameInput);
			object obj10 = typeof(SqlSingle[]) + 3912;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v25+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect4);
			double num = 0.5;
			double num2 = 15.0;
		}
		if (EmailError.activeInHierarchy)
		{
			RectTransform rect5 = UIExtensions.rectTransform(EmailInput);
			object obj13 = typeof(SqlSingle[]) + 3912;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect5);
			double num = 0.5;
			double num2 = 15.0;
		}
		Component termsAndConditions_toggle2 = TermsAndConditions_toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v30 (UnityEngine.Component)+120]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 == null)
		{
			Transform go = termsAndConditions_toggle2.transform;
			RectTransform rect6 = UIExtensions.rectTransform(go);
			object obj17 = typeof(SqlSingle[]) + 3912;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect6);
		}
	}

	private bool IsValid()
	{
		//IL_01d6: Expected I4, but got O
		if ((object)PhoneError != null)
		{
			if (PhoneError.activeInHierarchy)
			{
				return false;
			}
			if ((object)PasswordError != null)
			{
				if (PasswordError.activeInHierarchy)
				{
					return false;
				}
				if ((object)PasswordConfirmationError != null)
				{
					if (PasswordConfirmationError.activeInHierarchy)
					{
						return false;
					}
					if ((object)UserNameError != null)
					{
						if (UserNameError.activeInHierarchy)
						{
							return false;
						}
						if ((object)EmailError != null)
						{
							if (EmailError.activeInHierarchy)
							{
								return false;
							}
							Toggle termsAndConditions_toggle = TermsAndConditions_toggle;
							if ((object)TermsAndConditions_toggle != null)
							{
								return termsAndConditions_toggle.m_IsOn;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <SubmitRegisterForm>b__18_0(KammelnaResponseModel<RegisteredUserModel> response)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		GameObject gameObject = RegisterButton.gameObject;
		gameObject.SetActive(value: true);
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object action = "Read object reference Id '{0}' for {1}." + 1200;
			FirebaseTrack.Event((string)action, friendlyName);
			ITrackEvent trackEvent = TrackerLibrary.AccountRegisterSucceeded();
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			InputField emailInput = EmailInput;
			InputField passwordInput = PasswordInput;
			LoginControl.RegisterSuccess(emailInput.m_Text, passwordInput.m_Text);
		}
		else
		{
			ParseError(response);
		}
	}

	private void <UpdateUsername>b__21_0()
	{
		SuggestedUsernameInfo.SetActive(value: false);
	}
}
