using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LoginForm : MonoBehaviour
{
	private sealed class <>c__DisplayClass28_0
	{
		public AssetReferenceGameObject popupRef;

		public CanvasLayer canvas;

		internal void <LoadPopup>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0064: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(popupRef, canvas);
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public LoginForm <>4__this;

		public LoginError loginError;

		internal void <ShowKickError>b__0()
		{
			LoginForm loginForm = <>4__this;
			LoginError loginError = this.loginError;
			loginForm.kickInfopopup.ShowErrorPopup(loginError.<KickErrorMessage>k__BackingField, loginError.<KickErrorDuration>k__BackingField);
		}
	}

	public Button loginButton;

	public InputField loginInput;

	public InputField passwordInput;

	public GameObject loginPanel;

	public GameObject errorContainer;

	public ConnectionIndicator loading;

	public TextMeshProUGUI errorLabel;

	public TextMeshProUGUI statusLabel;

	public KickInfoPopup kickInfopopup;

	private AssetReferenceGameObject gameSwitcherRef;

	public LoginControl LoginControl;

	public List<GameObject> hideWhileLogin;

	private LoginControl _loginControl;

	public static event Action OnLoginSocialFailed
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3088;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3088;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_0105: Expected I, but got O
		//IL_0190: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)168;
		object obj3 = typeof(UsageHint) + 72;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 128;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string email = UserInfo.Email;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X20_v4-58]");
		((InputField)0).text = email;
		InputField inputField = loginInput;
		object obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj11 = (nint)0 + (nint)1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj11);
		Delegate obj12 = Delegate.Combine(inputField.m_OnValidateInput, onValidateInput);
		if ((object)obj12 == null || obj12 == obj10)
		{
			inputField.onValidateInput = (InputField.OnValidateInput)obj12;
			InputField inputField2 = passwordInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			InputField.OnValidateInput onValidateInput2 = default(InputField.OnValidateInput);
			onValidateInput2..ctor(null, (IntPtr)obj11);
			Delegate obj13 = Delegate.Combine(inputField2.m_OnValidateInput, onValidateInput2);
			if ((object)obj13 == null || obj13 == obj10)
			{
				inputField2.onValidateInput = (InputField.OnValidateInput)obj13;
				RegisterSFSSceneCallbacks();
				return;
			}
		}
		throw new InvalidCastException();
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0078: Expected O, but got I4
		if (Authentication.CanLogin())
		{
			object obj = typeof(RegisteredWaitHandle) + 1552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5+B8]");
				object obj3 = 0;
				object obj4 = obj3;
				bool flag = obj3 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_00d8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v11+B8]");
				object obj7 = 0;
				object obj4 = obj7;
				if (obj7 != null)
				{
					goto IL_00d8;
				}
			}
			goto IL_0107;
		}
		SplashAnimation.AnimateTransition();
		return;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+10]");
		if ((nint)0 == 2001)
		{
			ShowLoginError();
			return;
		}
		goto IL_0107;
		IL_0107:
		StartLogin();
	}

	private void OnDestroy()
	{
		UnregisterSFSSceneCallbacks();
	}

	private void OnDisable()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		errorLabel.text = (string)text;
		errorContainer.SetActive(value: false);
	}

	private void RegisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj2 = (nint)0 + (nint)2152;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)2160;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
		object obj6 = (nint)0 + (nint)2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		SfsConnectionManager.OnConnectionStateChange += (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SfsConnectionManager.OnUpdateStatusText += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		SfsConnectionManager.OnLoginError += action3;
	}

	private void UnregisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj2 = (nint)0 + (nint)2152;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)2160;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
		object obj6 = (nint)0 + (nint)2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		SfsConnectionManager.OnConnectionStateChange -= (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SfsConnectionManager.OnUpdateStatusText -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		SfsConnectionManager.OnLoginError -= action3;
	}

	private void OnLoginStatusChange(LoginStatus status)
	{
		//IL_0168: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_0013: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I
		//IL_00e6: Expected I, but got O
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		bool flag = status < LoginStatus.ConnectionLost;
		object obj = !flag;
		object obj2 = status - 9;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = 1 << (int)status;
		object obj6 = obj5 & 0x230;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = obj5 & 0x44;
			if (obj8 != null)
			{
				object text = (nint)0 + (nint)2000;
				errorLabel.text = (string)text;
				errorContainer.SetActive(value: false);
				object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)1960;
				Action<object> action = default(Action<object>);
				action..ctor((object)null, (IntPtr)obj10);
				((List<object>)(object)hideWhileLogin).ForEach(action);
				object text2 = "LAK" + 2360;
				ShowLoading((string)text2);
			}
			else if (status == LoginStatus.LoginFailed)
			{
				ShowLoginError();
			}
		}
		else
		{
			ShowConnectionFail(resetAuth: false);
		}
	}

	private void OnUpdateStatusText(string status)
	{
		ChangeStatusMessageTo(status);
	}

	private void OnLoginError(LoginError loginError)
	{
		//IL_0018: Expected O, but got I4
		//IL_0032: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_009a: Expected O, but got I
		object obj = loginError.<Error>k__BackingField - 1;
		bool flag = (nint)obj < 11;
		object obj2 = !flag;
		object obj3 = obj - 11;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 119877632 + 1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v2+v49 @ X8_v4]");
			object obj7 = (nint)87282748 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X10_v2 (should have been resolved before IL gen)");
		}
		ShowConnectionFail(resetAuth: true);
		SplashAnimation.AnimateTransition();
	}

	public void StartLogin()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_01d4: Expected O, but got I
		object obj = typeof(UsageHint) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserCredentials userCredentials = default(UserCredentials);
		userCredentials..ctor();
		InputField inputField = loginInput;
		object obj2 = userCredentials + 16;
		obj2 = inputField.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InputField inputField2 = passwordInput;
		object obj3 = userCredentials + 24;
		obj3 = inputField2.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string deviceId = UserDeviceIDRecorder.DeviceId;
		object obj4 = userCredentials + 40;
		obj4 = deviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!Authentication.CanLogin() || userCredentials.IsValid())
		{
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			StartLogin(userCredentials);
			ITrackEvent trackEvent = TrackerLibrary.AccountLoginClicked();
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
		}
		object obj7 = typeof(Queue<string>) + 856;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v28+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		sfsConnectionManager.Login();
	}

	public void StartLogin(UserCredentials userCredentials)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_00e0: Expected I, but got O
		if (userCredentials.IsValid())
		{
			object obj = typeof(UsageHint) + 72;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UserInfo.Email = userCredentials.<Email>k__BackingField;
			OnLoginStatusChange(LoginStatus.Connecting);
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2136;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj5);
			KammelnaRequests.GetAuthTokens(userCredentials, action);
		}
		else
		{
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LoginError loginError = default(LoginError);
			loginError..ctor(LoginErrorCode.IncorrectInfo);
			OnLoginError(loginError);
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "WhiteSmoke" + 528;
			Toast.Show((string)message, (Vector2)0, 0f);
		}
	}

	private static LoginError KickLoginError(KammelnaResponseModel<AuthModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00c3: Expected O, but got I
		KammelnaResponseModel<AuthModel> kammelnaResponseModel = default(KammelnaResponseModel<AuthModel>);
		if (kammelnaResponseModel != null)
		{
			object obj = (nint)0 + (nint)944;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2AEA314");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LoginError loginError = default(LoginError);
			loginError..ctor(LoginErrorCode.Kicked);
			object obj3 = default(object);
			if (obj3 != null && loginError != null)
			{
				object obj4 = loginError + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+18]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+10]");
				loginError.<KickErrorDuration>k__BackingField = (DateTime)0;
				return loginError;
			}
		}
		return (LoginError)(object)new NullReferenceException();
	}

	private static void LoadPopup(AssetReferenceGameObject popupRef, CanvasLayer canvas = CanvasLayer.MainCanvas)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)16;
		object obj5 = obj2 + 16;
		obj5 = popupRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		SplashAnimation.Interrupt(action);
	}

	private void ShowLoginError()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_01cd: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CB7]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
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
			obj4 = (nint)0 + (nint)2216;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
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
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+30]");
		if ((nint)0 != 0)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v8+30]");
			OnLoginError((LoginError)0);
		}
		else
		{
			ShowConnectionFail(resetAuth: false);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj10 = default(object);
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void ShowLoading(string text = null)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		loginPanel.SetActive(value: false);
		GameObject gameObject = loading.gameObject;
		gameObject.SetActive(value: true);
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		loading.StartLoading();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		TextMeshProExtensions.Localize(statusLabel, text);
		GameObject gameObject2 = statusLabel.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void HideLoading()
	{
		loginPanel.SetActive(value: true);
		GameObject gameObject = loading.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = statusLabel.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void ShowError(string message)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Expected I, but got O
		//IL_00a2: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_00c2: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1976;
		errorContainer.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		((List<object>)(object)hideWhileLogin).ForEach(action);
		GameObject gameObject = statusLabel.gameObject;
		gameObject.SetActive(value: false);
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v8+B8]");
		object text = 0;
		passwordInput.text = (string)text;
		TextMeshProExtensions.Localize(errorLabel, message);
		HideLoading();
	}

	private void ShowKickError(LoginError loginError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)24;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = loginError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		SplashAnimation.Interrupt(action);
		HideLoading();
	}

	private void HideError()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		errorLabel.text = (string)text;
		errorContainer.SetActive(value: false);
	}

	private void ShowConnectionFail(bool resetAuth)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		object message = "Complete" + 392;
		_loginControl.SwitchToLoginForm();
		ShowError((string)message);
		GameObject gameObject = loginInput.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = passwordInput.gameObject;
		gameObject2.SetActive(value: true);
		InputField inputField = passwordInput;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(inputField.m_Text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_013c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (StringsExtensions.IsNullOrEmpty(inputField.m_Text))
			{
				goto IL_013c;
			}
		}
		goto IL_01b6;
		IL_01b6:
		SplashAnimation.AnimateTransition();
		if (resetAuth)
		{
			object reason = "LAK" + 2392;
			Authentication.Clear((string)reason);
		}
		return;
		IL_013c:
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3088;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v11+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X8_v13+18] (should have been resolved before IL gen)");
		}
		goto IL_01b6;
	}

	private void ShowLockDownMessage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		object message = "Complete" + 392;
		_loginControl.SwitchToLoginForm();
		ShowError((string)message);
		GameObject gameObject = loginInput.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = passwordInput.gameObject;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "SetRoomVariables request error" + 1584;
		object body = "SERVICE_DISABLED" + 3408;
		object buttonText = "Network Authentication Required" + 3128;
		gameObject2.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
	}

	private void ChangeStatusMessageTo(string message)
	{
		GameObject gameObject = errorContainer.gameObject;
		if (!gameObject.activeSelf)
		{
			GameObject gameObject2 = statusLabel.gameObject;
			gameObject2.SetActive(value: true);
			TextMeshProExtensions.Localize(statusLabel, message);
		}
	}

	private unsafe void <StartLogin>b__26_0(KammelnaResponseModel<AuthModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_025f: Expected O, but got I4
		//IL_02cc: Expected O, but got Ref
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_0320: Expected O, but got I4
		//IL_0105: Expected O, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)984;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				if (Preferences.HasPreferredGame)
				{
					goto IL_009e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool hasPreferredGame = Preferences.HasPreferredGame;
				bool flag = !hasPreferredGame;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_009e;
				}
			}
			LoadPopup(gameSwitcherRef);
			return;
		}
		LoginErrorCode error;
		LoginError loginError;
		LoginError loginError2 = default(LoginError);
		if (response.<Error>k__BackingField != KammelnaError.UserNotFound)
		{
			if (response.<Error>k__BackingField == KammelnaError.RequiresPasswordReset)
			{
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				error = LoginErrorCode.ResetPasswordRequired;
				loginError = loginError2;
				goto IL_0356;
			}
			if (response.<Error>k__BackingField == KammelnaError.UserKicked)
			{
				LoginError loginError3 = KickLoginError(response);
				loginError = loginError3;
				goto IL_02b2;
			}
		}
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		error = LoginErrorCode.IncorrectInfo;
		loginError = loginError2;
		goto IL_0356;
		IL_009e:
		object obj7 = typeof(Queue<string>) + 856;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v29+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		sfsConnectionManager.Login();
		ITrackEvent trackEvent = TrackerLibrary.AccountLoginSucceeded();
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v29+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0356:
		loginError2..ctor(error);
		goto IL_02b2;
		IL_02b2:
		OnLoginError(loginError);
		object obj13 = default(object);
		string error2 = ((Enum)(&obj13)).ToString();
		ITrackEvent trackEvent2 = TrackerLibrary.AccountLoginError(error2);
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent2);
	}
}
