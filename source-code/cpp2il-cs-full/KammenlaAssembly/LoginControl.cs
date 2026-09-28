using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class LoginControl : MonoBehaviour
{
	public CanvasGroup registerForm;

	public CanvasGroup loginForm;

	public CanvasGroup resetPasswordForm;

	public CanvasGroup forceResetPasswordForm;

	public RectTransform formsSection;

	public RectTransform welcomeSection;

	public bool animateLogo = true;

	public GameObject Logo;

	private SocialUser _user;

	private LoginForm _loginForm;

	private RegisterForm _registerForm;

	private CanvasGroup[] _allForms;

	private RectTransform[] _allSections;

	private void Awake()
	{
		//IL_0011: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00db: Expected O, but got I
		//IL_00ff: Expected O, but got I8
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I8
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02ac: Expected O, but got I
		//IL_02d0: Expected O, but got I8
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_0363: Expected O, but got I
		//IL_03cc: Expected I, but got O
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0388: Expected O, but got I
		//IL_03f8: Expected I, but got O
		object obj = (nint)0 + (nint)3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 104;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)4048;
		object obj5 = typeof(TypeConverter<ushort, char>) + 1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj6 = this + 112;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+18]");
		if ((nint)0 != 0)
		{
			object obj9 = default(object);
			object obj8 = obj9 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X21_v3-50]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X21_v6-8]");
			object obj10 = 0 & 0xFFFFFFFEL;
			if (obj10 != null)
			{
				object obj11 = obj9 + 40;
				obj11 = loginForm;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X21_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj12 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X21_v8-10]");
				object obj13 = -2;
				bool flag2 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag2;
				if (obj15 == null)
				{
					object obj16 = obj9 + 48;
					obj16 = resetPasswordForm;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X21_v10-18]");
					object obj17 = 0 & 0xFFFFFFFCL;
					if (obj17 != null)
					{
						object obj18 = typeof(TypeConverter<ushort, char>) + 3648;
						object obj19 = obj9 + 56;
						obj19 = forceResetPasswordForm;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj20 = this + 120;
						obj20 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v28+18]");
						if ((nint)0 != 0)
						{
							object obj22 = default(object);
							object obj21 = obj22 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X21_v12-38]");
							obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X21_v14-8]");
							object obj23 = 0 & 0xFFFFFFFEL;
							if (obj23 != null)
							{
								object obj24 = obj22 + 40;
								obj24 = welcomeSection;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj25 = this + 128;
								obj25 = obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								RegisterEvents();
								object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
								object obj27 = (nint)0 + (nint)2064;
								object obj28 = (nint)0 + (nint)2080;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								Action<object> action = default(Action<object>);
								action..ctor((object)this, (IntPtr)obj27);
								ArraysExtensions.ForEach(_allForms, action);
								object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
								object obj30 = (nint)0 + (nint)2072;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								Action<object> action2 = default(Action<object>);
								action2..ctor((object)this, (IntPtr)obj30);
								ArraysExtensions.ForEach(_allSections, action2);
								Logo.SetActive(value: false);
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_01d2: Expected I, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CA1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		bool isLoggedIn = sessionModel.IsLoggedIn;
		bool flag4 = !isLoggedIn;
		object obj9 = !flag4;
		if (obj9 == null && !Authentication.CanLogin())
		{
			object obj10 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2080;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj11);
			SplashAnimation.Interrupt(action);
		}
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0236: Expected I, but got O
		//IL_0260: Expected O, but got I4
		//IL_0054: Expected O, but got I
		//IL_007a: Expected I, but got O
		//IL_00af: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		//IL_0125: Expected I, but got O
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0286: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj2 = (nint)0 + (nint)2104;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1944;
		object obj5 = (nint)0 + (nint)2120;
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)2128;
		object obj8 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)2112;
		SocialUtilities.OnRetrievedSocialToken += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		SocialUtilities.OnSigninFailure += action2;
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj7);
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action3, persistent: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj11);
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3088;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v6+B8]");
		object obj16 = 0;
		Delegate obj17 = (Delegate)obj16;
		bool flag3;
		Delegate obj20 = default(Delegate);
		do
		{
			Delegate obj18 = Delegate.Combine(obj17, action4);
			if ((object)obj18 == null || obj18 == obj6)
			{
				object obj19 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag3 = (object)obj20 == obj17;
				obj17 = obj20;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag3);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017e: Expected O, but got I
		//IL_0196: Expected I, but got O
		//IL_01c0: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj2 = (nint)0 + (nint)2104;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1944;
		object obj5 = (nint)0 + (nint)2120;
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)2112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SocialUtilities.OnRetrievedSocialToken -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		SocialUtilities.OnSigninFailure -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj7);
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3088;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6+B8]");
		object obj12 = 0;
		Delegate obj13 = (Delegate)obj12;
		bool flag2;
		Delegate obj16 = default(Delegate);
		do
		{
			Delegate obj14 = Delegate.Remove(obj13, action3);
			if ((object)obj14 == null || obj14 == obj6)
			{
				object obj15 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj16 == obj13;
				obj13 = obj16;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag2);
	}

	private void SwitchToWelcomeSection()
	{
		ShowSection(welcomeSection);
		MoveLogoLower();
	}

	public void SwitchToLoginForm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ShowSection(formsSection);
		ShowForm(loginForm);
		MoveLogoHigher();
		ITrackEvent trackEvent = TrackerLibrary.AccountLoginViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void SwitchToForgotPasswordForm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_00a3: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2096;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		GameObject popup = resetPasswordForm.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		ShowForm(resetPasswordForm);
		ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordViewed();
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void SwitchToForceResetPasswordForm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_00a3: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2088;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		GameObject popup = forceResetPasswordForm.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		ShowForm(forceResetPasswordForm);
		ITrackEvent trackEvent = TrackerLibrary.AccountRestPasswordViewed();
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void SwitchToRegisterForm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		//IL_00a3: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2128;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		GameObject popup = registerForm.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		ShowSection(formsSection);
		ShowForm(registerForm);
		MoveLogoHigher();
		ITrackEvent trackEvent = TrackerLibrary.AccountRegisterViewed();
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void MoveLogoHigher()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		Logo.SetActive(value: true);
		if (animateLogo)
		{
			Transform target = Logo.transform;
			int num = ShortcutExtensions.DOKill(target);
			Transform go = Logo.transform;
			RectTransform target2 = UIExtensions.rectTransform(go);
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tween tween = AnimationExtensions.DOOffsetMinY(target2, 610f, 0.3f);
			Transform target3 = Logo.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target3, 0.5f, 0.3f);
		}
	}

	private void MoveLogoLower()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		Logo.SetActive(value: true);
		if (animateLogo)
		{
			Transform target = Logo.transform;
			int num = ShortcutExtensions.DOKill(target);
			Transform go = Logo.transform;
			RectTransform target2 = UIExtensions.rectTransform(go);
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tween tween = AnimationExtensions.DOOffsetMinY(target2, 390f, 0.3f);
			Transform target3 = Logo.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target3, 0.5f, 0.3f);
		}
	}

	private void DoneSocialLogin(SocialUser user)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		object obj = this + 96;
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object password = (nint)0 + (nint)2000;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		RegisterSuccess(user.<Email>k__BackingField, (string)password);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		ITrackEvent trackEvent = TrackerLibrary.AccountSocialConnected(user.<Platform>k__BackingField);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnSigninFailure(Exception exception)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CA9]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "Index = {0} position = {1}" + 1736;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Index = {0} position = {1}" + 1736;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowError((string)message);
		return;
		IL_0094:
		PopupWindow.ShowError((string)obj4);
	}

	private void FailedSocialLogin()
	{
		if (_user != null)
		{
			SwitchToRegisterForm();
			_registerForm.RegisterSocial(_user);
		}
	}

	public void RegisterSuccess(string username = "", string password = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 40;
		ShowForm(loginForm);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserCredentials userCredentials = default(UserCredentials);
		userCredentials..ctor();
		object obj2 = userCredentials + 16;
		obj2 = username;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = userCredentials + 24;
		obj3 = password;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SocialUser user = _user;
		string text = ((_user == null) ? null : user.<Id>k__BackingField);
		object obj4 = userCredentials + 32;
		obj4 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string deviceId = UserDeviceIDRecorder.DeviceId;
		object obj5 = userCredentials + 40;
		obj5 = deviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_loginForm.StartLogin(userCredentials);
	}

	private void ShowSection(RectTransform section, float time = 0.35f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0096: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
		object obj2 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(_allSections, action);
		int num = ShortcutExtensions.DOKill(section);
		GameObject gameObject = section.gameObject;
		gameObject.SetActive(value: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(section, 0f, time);
	}

	private void HideAllSections()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
		object obj2 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(_allSections, action);
	}

	private void HideSection(RectTransform section, float time = 0.2f)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2504;
		int num = ShortcutExtensions.DOKill(section);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(section, -1800f, time);
		TweenCallback tweenCallback = TweenHelpers.Disable(section);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void ShowForm(CanvasGroup form, float time = 0.2f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00a3: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
		object obj2 = (nint)0 + (nint)2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(_allForms, action);
		int num = ShortcutExtensions.DOKill(form, complete: true);
		GameObject gameObject = form.gameObject;
		gameObject.SetActive(value: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(form, 1f, time);
		form.blocksRaycasts = true;
	}

	private void HideAllForms()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
		object obj2 = (nint)0 + (nint)2064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(_allForms, action);
	}

	private void HideForm(CanvasGroup form, float time = 0.2f)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		int num = ShortcutExtensions.DOKill(form, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(form, 0f, time);
		TweenCallback tweenCallback = TweenHelpers.Disable(form);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <Start>b__14_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CAD]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string email = UserInfo.Email;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		string value = email;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_01d1;
		IL_0102:
		ShowSection(welcomeSection);
		MoveLogoLower();
		return;
		IL_0216:
		SwitchToLoginForm();
		return;
		IL_00d7:
		if (StringsExtensions.IsNullOrEmpty(email))
		{
			goto IL_0102;
		}
		goto IL_0216;
		IL_0099:
		email = UserInfo.Email;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v3+E4]");
		bool flag4 = (nint)0 == 0;
		value = email;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_01d1;
		IL_01d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = StringsExtensions.IsNullOrEmpty(value);
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 != null)
		{
			goto IL_0102;
		}
		goto IL_0216;
	}

	private void <SwitchToForgotPasswordForm>b__19_0()
	{
		SwitchToLoginForm();
	}

	private void <SwitchToForceResetPasswordForm>b__20_0()
	{
		SwitchToLoginForm();
	}

	private void <HideAllSections>b__29_0(RectTransform section)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2504;
		int num = ShortcutExtensions.DOKill(section);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(section, -1800f, 0.2f);
		TweenCallback tweenCallback = TweenHelpers.Disable(section);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <HideAllForms>b__32_0(CanvasGroup form)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		int num = ShortcutExtensions.DOKill(form, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(form, 0f, 0.2f);
		TweenCallback tweenCallback = TweenHelpers.Disable(form);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}
}
