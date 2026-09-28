using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Social;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SettingAccountsSection : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, bool> <>9__14_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Unlink>b__14_0(string t)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0072: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(t);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public SocialPlatform platform;

		internal void <LinkRequest>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0083: Expected O, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_011c: Expected O, but got I4
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0180: Expected O, but got I4
			if (response.Succeeded)
			{
				SFS.SendRefreshStatus();
				ITrackEvent trackEvent = TrackerLibrary.AccountSocialLinked(platform);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v31+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.DismissMessage();
				return;
			}
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(friendlyName);
			string errorMessage = response.ErrorMessage;
			ITrackEvent trackEvent2 = TrackerLibrary.AccountSocialLinkedError(platform, errorMessage);
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public SocialPlatform platform;

		internal void <UnlinkRequest>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0083: Expected O, but got I4
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_011c: Expected O, but got I4
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0180: Expected O, but got I4
			if (response.Succeeded)
			{
				SFS.SendRefreshStatus();
				ITrackEvent trackEvent = TrackerLibrary.AccountSocialUnLinked(platform);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v31+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.DismissMessage();
				return;
			}
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(friendlyName);
			string errorMessage = response.ErrorMessage;
			ITrackEvent trackEvent2 = TrackerLibrary.AccountSocialUnlinkedError(platform, errorMessage);
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public SocialPlatform platform;

		internal void <Unlink>g__SocialLogout|1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00cb: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6973]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SocialUtilities.ClearSessions();
			UnlinkRequest(platform);
			return;
			IL_0085:
			SocialUtilities.ClearSessions();
			UnlinkRequest(platform);
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public BaseToggler toggle;

		public User user;

		public string varName;

		internal void <BindToggle>b__0()
		{
			//IL_000c: Expected O, but got I
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_0087: Expected O, but got I4
			object defaultValue = (nint)0 + (nint)2000;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string variable = SFSExtensions.GetVariable(user, varName, (string)defaultValue);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isON = StringsExtensions.IsNullOrEmpty(variable);
			toggle.ToggleManual(isON);
		}
	}

	private Button googleButton;

	private Button twitterButton;

	private Button facebookButton;

	private Button appleButton;

	private static Dictionary<SocialPlatform, string> _tokens
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0026: Expected O, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0046: Expected O, but got I
			//IL_0055: Expected O, but got I4
			//IL_0065: Expected O, but got I
			//IL_0075: Expected O, but got I
			//IL_008b: Expected I4, but got I8
			//IL_00b5: Expected O, but got I4
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
			dictionary..ctor();
			if (dictionary != null)
			{
				object obj2 = (nint)0 + (nint)824;
				object obj3 = typeof(Queue<string>) + 848;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+90]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+B8]");
				object value = 0;
				dictionary.Add((System.Int32Enum)(-1), value);
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					string userGoogleID = SFSKammelnaUserExtensions.GetUserGoogleID(localUser);
					dictionary.Add((System.Int32Enum)2, userGoogleID);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					if ((object)sessionModel2 != null)
					{
						User localUser2 = sessionModel2.LocalUser;
						string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser2);
						dictionary.Add((System.Int32Enum)1, userTwitterID);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel3 = default(SessionModel);
						if ((object)sessionModel3 != null)
						{
							User localUser3 = sessionModel3.LocalUser;
							string userFacebookID = SFSKammelnaUserExtensions.GetUserFacebookID(localUser3);
							dictionary.Add((System.Int32Enum)0, userFacebookID);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel4 = default(SessionModel);
							if ((object)sessionModel4 != null)
							{
								User localUser4 = sessionModel4.LocalUser;
								string userAppleID = SFSKammelnaUserExtensions.GetUserAppleID(localUser4);
								dictionary.Add((System.Int32Enum)3, userAppleID);
								return (Dictionary<SocialPlatform, string>)(object)dictionary;
							}
						}
					}
				}
			}
			return (Dictionary<SocialPlatform, string>)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0117: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_004a: Expected I, but got O
		//IL_0070: Expected I, but got O
		//IL_00a1: Expected I, but got O
		//IL_00d0: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj3 = (nint)0 + (nint)3112;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1944;
		object obj5 = (nint)0 + (nint)3104;
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)3152;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SocialUtilities.InitAuth();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SocialUtilities.OnRetrievedSocialToken += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		SocialUtilities.OnSigninFailure += action2;
		HandleSocialMediaButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj7);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy.WaitForEndOfFrame(action3);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_00df: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj2 = (nint)0 + (nint)3112;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1944;
		object obj5 = (nint)0 + (nint)3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SocialUtilities.OnRetrievedSocialToken -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		SocialUtilities.OnSigninFailure -= action2;
	}

	private void OnSigninFailure(Exception exception)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
	}

	private void OnSocialLogin(SocialUser user)
	{
		LinkRequest(user.<Platform>k__BackingField, user.<Id>k__BackingField, user.<UserId>k__BackingField);
	}

	private static void LinkRequest(SocialPlatform platform, string firebaseToken, string twitterId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.LinkSocialPlatform(platform, firebaseToken, twitterId, action);
	}

	private static void UnlinkRequest(SocialPlatform platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005c: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_00d6: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj5 = (nint)0 + (nint)1904;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+10]");
		KammelnaRequests.UnlinkSocialPlatform(SocialPlatform.Facebook, action);
	}

	private static void ShowError(KammelnaError error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
	}

	private void Link(SocialPlatform platform)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		//IL_0282: Expected O, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0563: Expected O, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0419: Expected O, but got I
		//IL_0433: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_018b: Expected O, but got I
		//IL_0479: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E696D]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object msgBody;
		if (obj3 != null)
		{
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			msgBody = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "LAK" + 2136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			msgBody = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.ShowLoading((string)msgBody);
		bool flag3 = platform <= SocialPlatform.Twitter;
		object obj7 = 0;
		bool flag4 = true;
		object obj8 = 0;
		bool flag5 = true;
		if (flag3)
		{
			goto IL_00e3;
		}
		goto IL_0299;
		IL_04b1:
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = "placementId" + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj12 = "LAK" + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		string message = default(string);
		ex..ctor(paramName, actualValue, message);
		object obj13 = (nint)0 + (nint)3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
		IL_00e3:
		object obj17;
		object obj16;
		switch (platform)
		{
		case SocialPlatform.Twitter:
		{
			object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v43+E4]");
			object obj21;
			if ((nint)0 != 0)
			{
				obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6979]");
				object obj20 = (nint)0 & (nint)1;
				bool flag6 = obj20 == null;
				obj21 = obj17;
				if (!flag6)
				{
					goto IL_01b0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6979]");
				object obj22 = (nint)0 & (nint)1;
				bool flag7 = obj22 == null;
				object obj23 = !flag7;
				obj21 = obj17;
				if (obj23 != null)
				{
					goto IL_01b0;
				}
			}
			_ = 1;
			obj16 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v44+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 != null)
			{
				goto IL_01dd;
			}
			goto IL_0487;
		}
		case SocialPlatform.Facebook:
			{
				object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v41+E4]");
				if ((nint)0 != 0)
				{
					SocialUtilities.FacebookLogin();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				SocialUtilities.FacebookLogin();
				return;
			}
			IL_0487:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterRequests.Login();
			return;
			IL_01b0:
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v44+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01dd;
			}
			goto IL_0487;
			IL_01dd:
			TwitterRequests.Login();
			return;
		}
		goto IL_04b1;
		IL_0299:
		if (platform != SocialPlatform.Google)
		{
			bool flag9 = platform != SocialPlatform.Apple;
			obj7 = obj8;
			flag4 = flag5;
			if (!flag9)
			{
				object obj25 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					SocialUtilities.AppleLogin();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				SocialUtilities.AppleLogin();
				return;
			}
			goto IL_04b1;
		}
		object obj27 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			SocialUtilities.GoogleLogin();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SocialUtilities.GoogleLogin();
		return;
		IL_0094:
		PopupWindow.ShowLoading((string)obj4);
		bool flag10 = platform > SocialPlatform.Twitter;
		obj7 = 0;
		flag4 = true;
		obj8 = 0;
		flag5 = true;
		if (!flag10)
		{
			goto IL_00e3;
		}
		goto IL_0299;
	}

	private void Unlink(SocialPlatform platform)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0753: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_00ba: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected O, but got Unknown
		//IL_07b7: Expected O, but got I
		//IL_07c8: Expected I, but got O
		//IL_07e6: Expected O, but got I
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		//IL_0263: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_0878: Expected O, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0398: Expected O, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I
		//IL_03e9: Expected I, but got O
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected I, but got Unknown
		//IL_041d: Expected O, but got I
		//IL_0439: Expected O, but got I4
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected I, but got Unknown
		//IL_0463: Expected O, but got I
		//IL_047f: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04b8: Expected I, but got O
		//IL_04c8: Expected O, but got I
		//IL_0578: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05aa: Expected I, but got O
		//IL_05ba: Expected O, but got I
		//IL_0658: Expected O, but got I
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected I, but got Unknown
		//IL_06e5: Expected O, but got I4
		//IL_06f6: Expected O, but got I4
		//IL_05f5: Expected O, but got I
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0840: Expected O, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E696E]");
		nint num = 0;
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3096;
		object obj2 = default(object);
		Func<object, bool> func2 = default(Func<object, bool>);
		object obj17 = default(object);
		object obj21 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj25 = default(object);
		IntPtr intPtr = default(IntPtr);
		SessionModel sessionModel = default(SessionModel);
		Action action = default(Action);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			Dictionary<System.Int32Enum, object>.ValueCollection values;
			object obj6;
			Func<object, bool> func;
			object obj16;
			Func<object, bool> func3;
			if (obj2 != null)
			{
				Dictionary<SocialPlatform, string> tokens = _tokens;
				if (tokens != null)
				{
					object obj3 = (nint)0 + (nint)840;
					object obj4 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3072;
					values = ((Dictionary<System.Int32Enum, object>)(object)tokens).Values;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v40+E4]");
					object obj7;
					object obj8;
					if ((nint)0 != 0)
					{
						obj6 = (nint)0 + (nint)3600;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v40+B8]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v47+8]");
						func = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v47+8]");
						bool flag = (nint)0 == 0;
						obj8 = obj6;
						if (!flag)
						{
							goto IL_0107;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj5 = obj4;
						obj6 = (nint)0 + (nint)3600;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v40+B8]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v47+8]");
						func = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v47+8]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						obj8 = obj6;
						if (obj9 != null)
						{
							goto IL_0107;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v40+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj11 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v53+B8]");
						obj7 = 0;
					}
					object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)1888;
					func2..ctor(obj7, (IntPtr)obj13);
					object obj14 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v52+B8]");
					object obj15 = (nint)0 + (nint)8;
					obj15 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj16 = obj8;
					int num2 = Enumerable.Count(values, func2);
					bool flag4 = num2 != 1;
					obj17 = 0;
					func3 = func2;
					object obj18 = 0;
					object obj19 = obj8;
					Func<object, bool> func4 = func2;
					if (flag4)
					{
						break;
					}
					goto IL_0292;
				}
			}
			goto IL_0704;
			IL_0107:
			obj16 = obj6;
			int num3 = Enumerable.Count(values, func);
			bool flag5 = num3 == 1;
			func3 = func;
			if (!flag5)
			{
				object obj18 = obj17;
				object obj19 = obj6;
				Func<object, bool> func4 = func;
				break;
			}
			goto IL_0292;
			IL_0636:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v33+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v284 @ X2_v12 (should have been resolved before IL gen)");
			break;
			IL_058e:
			object obj23 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj25 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X10_v9-8]");
					bool flag6 = 0 == (nint)obj23;
					obj17 = 0;
					if (flag6)
					{
						break;
					}
					obj25 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_0636;
				}
				goto IL_0712;
			}
			goto IL_0636;
			IL_054c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v35 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag7 = ex == null;
			obj17 = 0;
			num = intPtr;
			if (!flag7)
			{
				goto IL_058e;
			}
			goto IL_0704;
			IL_0292:
			object obj26 = typeof(Queue<string>) + 848;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v20+E4]");
			bool flag8 = (nint)0 == 0;
			object obj28 = !flag8;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				string email = SFSKammelnaUserExtensions.GetEmail(localUser);
				if (email != null)
				{
					object obj29 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1256;
					bool flag9 = email.EndsWith((string)obj29);
					bool flag10 = !flag9;
					object obj18 = obj17;
					object obj19 = 0;
					Func<object, bool> func4 = (Func<object, bool>)obj29;
					if (flag10)
					{
						break;
					}
					object obj30 = typeof(SqlSingle[]) + 2376;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj31 = (nint)0 + (nint)1912;
					action..ctor(obj2, (IntPtr)obj31);
					object confirmText = "UInt16" + 3536;
					num = (nint)("AvailableVoices" + 768);
					PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)confirmText, (string)num);
					bool flag11 = popupWindowBuilder == null;
					obj17 = 0;
					if (!flag11)
					{
						num = (nint)("Unsupported map type" + 3592);
						IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
						bool flag12 = popupWindowBuilderNeedsBody == null;
						obj17 = 0;
						if (!flag12)
						{
							object obj32 = typeof(System.IOAsyncCallback) + 384;
							object obj33 = "HH:mm:ss.ffZ" + 3360;
							nint num4 = (nint)popupWindowBuilderNeedsBody;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v37 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
							object obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v37 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_054c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v37 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
							object obj35 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X10_v12-8]");
								if (0 == (nint)obj32)
								{
									break;
								}
								obj25 = obj35 + 16;
								obj34--;
								bool flag13 = (nint)obj34 != 1;
								obj35 = obj25;
								if (flag13)
								{
									continue;
								}
								goto IL_054c;
							}
							object obj36 = num4 + obj35;
							num = (nint)(obj36 + 312);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
							bool flag14 = ex == null;
							object obj37 = !flag14;
							obj25 = obj35;
							obj17 = 0;
							if (obj37 != null)
							{
								goto IL_058e;
							}
						}
					}
				}
			}
			goto IL_0704;
			IL_0712:
			object obj38 = obj25 + 9;
			object obj39 = num + obj38;
			object obj40 = obj39 + 312;
			object obj41 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v5+8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v223 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0704:
			ex = new NullReferenceException();
			goto IL_0712;
		}
		object obj43 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v13+E4]");
		bool flag15 = (nint)0 == 0;
		object obj45 = !flag15;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SocialUtilities.ClearSessions();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+10]");
		UnlinkRequest(SocialPlatform.Facebook);
	}

	private void HandleSocialMediaButtons()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_011b: Expected I, but got O
		Button button = googleButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = twitterButton;
		object obj3 = (nint)0 + (nint)3144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = facebookButton;
		object obj4 = (nint)0 + (nint)3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.AddListener(unityAction3);
		Button button4 = appleButton;
		object obj5 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj5);
		button4.m_OnClick.AddListener(unityAction4);
	}

	public void OnButtonLogoutClick()
	{
		SFS.Logout();
	}

	private void PopulateToggles()
	{
		//IL_0011: Expected O, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_0092: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName = "rightCtrl" + 864;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		BaseToggler toggle = default(BaseToggler);
		BindToggle(toggle, localUser, (string)varName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "rightCtrl" + 904;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		BaseToggler toggle2 = default(BaseToggler);
		BindToggle(toggle2, localUser2, (string)varName2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName3 = "rightCtrl" + 912;
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		BaseToggler toggle3 = default(BaseToggler);
		BindToggle(toggle3, localUser3, (string)varName3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName4 = "rightCtrl" + 896;
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		BaseToggler toggle4 = default(BaseToggler);
		BindToggle(toggle4, localUser4, (string)varName4);
	}

	private static void BindToggle(BaseToggler toggle, User user, string varName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00d0: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_00f6: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = toggle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = varName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)1920;
		GameObject go = ((Component)obj3).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+20]");
		VariableBinderExtensions.Bind(go, (User)num, (string)0, action);
	}

	public void OnToggleGoogle()
	{
		ToggleLink(SocialPlatform.Google);
	}

	public void OnToggleFacebook()
	{
		ToggleLink(SocialPlatform.Facebook);
	}

	public void OnToggleTwitter()
	{
		ToggleLink(SocialPlatform.Twitter);
	}

	public void OnToggleApple()
	{
		ToggleLink(SocialPlatform.Apple);
	}

	public void ToggleLink(SocialPlatform platform)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_004a: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(DigitalContDownFormat) & 1;
		object obj3;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6970]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6970]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6970]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6970]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_007d;
			}
		}
		_ = 1;
		Dictionary<SocialPlatform, string> tokens = _tokens;
		bool flag2 = tokens == null;
		object obj7 = !flag2;
		Dictionary<System.Int32Enum, object> dictionary = (Dictionary<System.Int32Enum, object>)(object)tokens;
		obj3 = 1;
		if (obj7 != null)
		{
			goto IL_00ab;
		}
		goto IL_0201;
		IL_0268:
		SettingAccountsSection settingAccountsSection;
		SocialPlatform platform2;
		settingAccountsSection.Unlink(platform2);
		return;
		IL_0150:
		SettingAccountsSection settingAccountsSection2;
		SocialPlatform socialPlatform = default(SocialPlatform);
		settingAccountsSection2.Link(socialPlatform);
		return;
		IL_020f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException value;
		bool flag3 = StringsExtensions.IsNullOrEmpty((string)(object)value);
		bool flag4 = !flag3;
		object obj8 = !flag4;
		settingAccountsSection2 = (SettingAccountsSection)flag3;
		platform2 = socialPlatform;
		settingAccountsSection = (SettingAccountsSection)flag3;
		if (obj8 != null)
		{
			goto IL_0150;
		}
		goto IL_0268;
		IL_007d:
		Dictionary<SocialPlatform, string> tokens2 = _tokens;
		bool flag5 = tokens2 == null;
		dictionary = (Dictionary<System.Int32Enum, object>)(object)tokens2;
		if (!flag5)
		{
			goto IL_00ab;
		}
		goto IL_0201;
		IL_0201:
		value = new NullReferenceException();
		goto IL_020f;
		IL_00ab:
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj10 = (nint)0 + (nint)832;
		object obj11 = dictionary.get_Item((System.Int32Enum)socialPlatform);
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v3+E4]");
		bool flag6 = (nint)0 == 0;
		value = (NullReferenceException)obj11;
		if (flag6)
		{
			goto IL_020f;
		}
		bool flag7 = StringsExtensions.IsNullOrEmpty((string)obj11);
		bool flag8 = !flag7;
		settingAccountsSection2 = (SettingAccountsSection)flag7;
		platform2 = socialPlatform;
		settingAccountsSection = (SettingAccountsSection)flag7;
		if (!flag8)
		{
			goto IL_0150;
		}
		goto IL_0268;
	}

	private static string GetToken(SocialPlatform platform)
	{
		Dictionary<SocialPlatform, string> tokens = _tokens;
		SocialPlatform key = default(SocialPlatform);
		if (tokens != null)
		{
			return (string)((Dictionary<System.Int32Enum, object>)(object)tokens).get_Item((System.Int32Enum)key);
		}
		return (string)(object)new NullReferenceException();
	}
}
