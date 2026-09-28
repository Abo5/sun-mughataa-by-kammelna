using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using GoogleMobileAds.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class LogoScript : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<AdInspectorError> <>9__37_0;

		public static Action<KammelnaResponseModel<AuthModel>> <>9__39_0;

		public static Action <>9__42_0;

		public static Action <>9__43_0;

		public static Action <>9__44_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <TestMediation>b__37_0(AdInspectorError error)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0058: Expected O, but got I4
			//IL_0088: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			nint num = (nint)error;
			string message = error.ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Debug(message, (Vector2)0, 0f);
		}

		internal void <SwitchToUser>b__39_0(KammelnaResponseModel<AuthModel> _)
		{
			SFS.ResetEnvironment();
		}

		internal void <EnterTheVoid>b__42_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0167: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7308]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ServerEnvironment environment = Config.Environment;
			if (environment == ServerEnvironment.Staging)
			{
				return;
			}
			goto IL_011a;
			IL_011a:
			object methodName = "Drop Menu Toggle" + 3296;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Config.Environment = ServerEnvironment.Staging;
			SFS.ResetEnvironment();
			ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
			IL_007d:
			ServerEnvironment environment2 = Config.Environment;
			if (environment2 == ServerEnvironment.Staging)
			{
				return;
			}
			goto IL_011a;
		}

		internal void <ExitTheVoid>b__43_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0195: Expected O, but got I4
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00f0: Expected O, but got I4
			//IL_01d5: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7309]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ServerEnvironment environment = Config.Environment;
			bool flag2 = environment == ServerEnvironment.Production;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				return;
			}
			goto IL_00a3;
			IL_00a3:
			object methodName = "Error reading data from socket: " + 1024;
			object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Config.Environment = ServerEnvironment.Production;
			SFS.ResetEnvironment();
			ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
			IL_007d:
			if (Config.Environment != ServerEnvironment.Production)
			{
				goto IL_00a3;
			}
		}

		internal void <BeTheVoid>b__44_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I4
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected O, but got Unknown
			//IL_0167: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E730A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ServerEnvironment environment = Config.Environment;
			if (environment == ServerEnvironment.Development)
			{
				return;
			}
			goto IL_011a;
			IL_011a:
			object methodName = "AvailableVoices" + 1312;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Config.Environment = ServerEnvironment.Development;
			SFS.ResetEnvironment();
			ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			return;
			IL_007d:
			ServerEnvironment environment2 = Config.Environment;
			if (environment2 == ServerEnvironment.Development)
			{
				return;
			}
			goto IL_011a;
		}
	}

	private sealed class <>c__DisplayClass31_0
	{
		public string email;

		internal bool <get_IsTestAccount>b__0(string domain)
		{
			//IL_004a: Expected I4, but got O
			if (email != null)
			{
				return email.EndsWith(domain, StringComparison.OrdinalIgnoreCase);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public IPopupWindowBuilderAttributes builder;

		public LogoScript <>4__this;

		internal void <DebugButtons>b__0(string cmd)
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
			//IL_00b2: Expected I, but got O
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e9: Expected I, but got O
			//IL_00f9: Expected O, but got I
			//IL_01f8: Expected O, but got I
			//IL_0134: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)512;
			object obj5 = obj2 + 24;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 16;
			obj6 = cmd;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = builder;
			LocalizableText label = TextMeshProExtensions.FixOnly((string)obj6);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			PopupButton popupButton = PopupButton.Neutral(label, action);
			object obj7 = typeof(System.IOAsyncCallback) + 368;
			nint num = (nint)popupWindowBuilderAttributes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0175;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X10_v5-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj9 += 16;
				obj8--;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_0175;
			}
			object obj10 = num + obj9;
			object obj11 = obj10 + 312;
			goto IL_01e0;
			IL_0175:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01e0;
			IL_01e0:
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v17+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v137 @ X3_v4 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass34_1
	{
		public string cmd;

		public <>c__DisplayClass34_0 CS$<>8__locals1;

		internal void <DebugButtons>b__1()
		{
			<>c__DisplayClass34_0 cS$<>8__locals = CS$<>8__locals1;
			cS$<>8__locals.<>4__this.VerifyCode(cmd);
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public IPopupWindowBuilderAttributes builder;

		internal void <ShowFrontEndPicker>b__0(string host)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0090: Expected I, but got O
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00cc: Expected I, but got O
			//IL_00dc: Expected O, but got I
			//IL_01db: Expected O, but got I
			//IL_0117: Expected O, but got I
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)528;
			object obj5 = obj2 + 16;
			obj5 = host;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = builder;
			LocalizableText label = TextMeshProExtensions.FixOnly((string)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			PopupButton popupButton = PopupButton.Neutral(label, action, dismiss: true);
			object obj6 = typeof(System.IOAsyncCallback) + 368;
			nint num = (nint)popupWindowBuilderAttributes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0158;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v5 (Il2CppClass<IPopupWindowBuilderAttributes>)+B0]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v5-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_0158;
			}
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			goto IL_01c3;
			IL_0158:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01c3;
			IL_01c3:
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v14+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v135 @ X3_v4 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass52_1
	{
		public string host;

		internal void <ShowFrontEndPicker>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00cc: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E730D]");
			object obj2 = (nint)0 & (nint)1;
			string frontEnd;
			string frontEnd2;
			if (obj2 != null)
			{
				frontEnd = host;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				frontEnd2 = host;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				frontEnd = host;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				frontEnd2 = host;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ApplyFrontEnd(frontEnd2);
			return;
			IL_0088:
			ApplyFrontEnd(frontEnd);
		}
	}

	private GameObject consolePrefab;

	private GameObject graphyPrefab;

	private GameObject testingPanelPrefab;

	private AdsController adsController;

	private int ClickCounter;

	private static bool _fps2;

	private static GameObject _graphy;

	private const string Activate_Console = "console";

	private const string Activate_FormChange = "formChange";

	private const string Activate_DebuggerOverload = "debuggerOverload";

	private const string Activate_EnterTheVoid = "enterTheVoid";

	private const string Activate_ExitTheVoid = "exitTheVoid";

	private const string Activate_BeTheVoid = "beTheVoid";

	private const string Activate_PrintFCMToken = "FCMT";

	private const string Activate_CachePath = "cacheP";

	private const string Activate_FPS = "FPS";

	private const string Activate_FPS2 = "FPS2";

	private const string Activate_MediationTest = "test mediation";

	private const string Activate_ChangeFrontEnd = "fe-";

	private const string Activate_JustForMe = "jfm";

	private const string Activate_DevTesting = "devtest";

	private const string Activate_AD_AdMob_R_1 = "ad.r.1";

	private const string Activate_AD_AdMob_R_2 = "ad.r.2";

	private const string Activate_AD_AdMob_R_T = "ad.r.t";

	private const string Activate_AD_AdMob_I_1 = "ad.i.1";

	private const string Activate_AD_AdMob_I_2 = "ad.i.2";

	private const string Activate_AD_AdMob_I_T = "ad.i.t";

	private const string ActivateCustomCommand = "acc";

	private static readonly string[] _commands;

	private static readonly string[] _testAccountDomains;

	private static bool IsTestAccount
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_01ca: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_0210: Expected O, but got I4
			//IL_018d: Expected I4, but got O
			//IL_00b7: Expected O, but got I4
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_0119: Expected O, but got I
			//IL_0125: Expected O, but got I
			//IL_014f: Expected O, but got I4
			//IL_026b: Expected O, but got I
			//IL_0286: Expected I, but got O
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2696;
			object obj2 = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "Complete" + 3512;
			object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = Prefs.GetString((string)key, null);
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = StringsExtensions.IsNullOrEmpty(text);
			if (obj3 != null)
			{
				bool flag4 = !flag3;
				object obj9 = !flag4;
				object obj10 = ~obj9;
				string text2 = ((obj10 != null) ? text : null);
				object obj11 = obj3 + 16;
				obj11 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj11 != null)
				{
					object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
					object obj13 = typeof(List<Tween>) + 3496;
					object obj14 = (nint)0 + (nint)496;
					object obj15 = (nint)0 + (nint)3432;
					object obj16 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v18+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj12;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v18+B8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Predicate<object> predicate = default(Predicate<object>);
					predicate..ctor(obj3, (IntPtr)obj14);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @317FA8C");
					bool result = default(bool);
					return result;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public void OnLogoScriptPressed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_02bf: Expected I, but got O
		//IL_016d: Expected I, but got O
		//IL_01c8: Expected O, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_026c: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72EB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Config.IsInitialized)
		{
			goto IL_0115;
		}
		goto IL_017c;
		IL_017c:
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool isInitialized = Config.IsInitialized;
			bool flag2 = !isInitialized;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Config.IsInitialized)
			{
				return;
			}
		}
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			bool isTestAccount = IsTestAccount;
			bool flag3 = !isTestAccount;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!IsTestAccount)
			{
				return;
			}
		}
		if (++ClickCounter >= 7)
		{
			DebugButtons();
			ClickCounter = 0;
			ITrackEvent trackEvent = TrackerLibrary.DevLogoScriptShown();
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v12+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		return;
		IL_0115:
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			ServerEnvironment environment = Config.Environment;
			bool flag4 = EnvironmentExtensions.IsProduction(environment);
			bool flag5 = !flag4;
			nint num = unchecked((nint)null);
			if (!flag5)
			{
				goto IL_017c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ServerEnvironment environment2 = Config.Environment;
			bool flag6 = EnvironmentExtensions.IsProduction(environment2);
			bool flag7 = !flag6;
			object obj13 = !flag7;
			nint num = unchecked((nint)null);
			if (obj13 != null)
			{
				goto IL_017c;
			}
		}
		DebugButtons();
		return;
		IL_0074:
		bool isInitialized2 = Config.IsInitialized;
		bool flag8 = !isInitialized2;
		object obj14 = !flag8;
		if (obj14 != null)
		{
			goto IL_0115;
		}
		goto IL_017c;
	}

	private void PromptCode()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_049f: Expected I, but got O
		//IL_008e: Expected O, but got I4
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00cf: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_059b: Expected I, but got O
		//IL_04e4: Expected I, but got O
		//IL_04f4: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_026a: Expected I, but got O
		//IL_027a: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_020f: Expected O, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e9: Expected I, but got O
		//IL_02f9: Expected O, but got I
		//IL_0388: Expected O, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c6: Expected I, but got O
		//IL_03d6: Expected O, but got I
		//IL_03fa: Expected O, but got I4
		//IL_0412: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72EC]");
		nint num = 0;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)2368;
		object primaryText = "Network Authentication Required" + 3128;
		object text = "{0} color encoding is currently unsupported for outputting to HDR." + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		IPopupWindowBuilderInput inputData = PopupInput.From(InputField.ContentType.Standard, action);
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreatePrompt(inputData, (string)primaryText);
		LocalizableText localizableText = TextMeshProExtensions.FixOnly((string)text);
		bool flag = popupWindowBuilderNeedsTitle == null;
		object obj3 = 0;
		Action<object> action2 = action;
		if (flag)
		{
			goto IL_0428;
		}
		object obj4 = typeof(System.IOAsyncCallback) + 392;
		object text2 = "{0} color encoding is currently unsupported for outputting to HDR." + 1976;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0163;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		object obj7 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X10_v19-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj7 = obj6 + 16;
			obj5--;
			bool flag2 = (nint)obj5 != 1;
			obj6 = obj7;
			if (flag2)
			{
				continue;
			}
			goto IL_0163;
		}
		object obj8 = obj6 + 1;
		object obj9 = num2 + obj8;
		object obj10 = obj9 + 312;
		obj7 = obj6;
		goto IL_04dc;
		IL_0428:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0436;
		IL_02b9:
		object obj11 = typeof(System.IOAsyncCallback) + 368;
		action2 = (Action<object>)(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0375;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj7 = (nint)0 + (nint)8;
		object obj13;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v11-8]");
			bool flag3 = 0 == (nint)obj11;
			obj3 = obj13;
			if (flag3)
			{
				break;
			}
			obj7 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0375;
		}
		goto IL_0436;
		IL_0436:
		object obj14 = obj7 + 9;
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		goto IL_0580;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj3 = 9;
		object obj17 = default(object);
		obj16 = obj17;
		goto IL_0580;
		IL_0580:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X8_v3] (should have been resolved before IL gen)");
		ITrackEvent trackEvent = TrackerLibrary.DevDebugButtons();
		nint num3 = (nint)action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v4 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0163:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04dc;
		IL_04dc:
		num = (nint)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v20+8]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X0_v20] (should have been resolved before IL gen)");
		LocalizableText localizableText2 = TextMeshProExtensions.FixOnly((string)text2);
		object obj18 = default(object);
		bool flag4 = obj18 == null;
		action2 = (Action<object>)(object)localizableText;
		if (!flag4)
		{
			object obj19 = typeof(System.IOAsyncCallback) + 384;
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v16+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0258;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v16+B0]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v14-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj7 = obj22 + 16;
				obj21--;
				bool flag5 = (nint)obj21 != 1;
				obj22 = obj7;
				if (flag5)
				{
					continue;
				}
				goto IL_0258;
			}
			object obj23 = obj22 + 1;
			object obj24 = obj20 + obj23;
			object obj25 = obj24 + 312;
			num = (nint)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v32+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ X0_v32] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			object obj26 = !flag6;
			obj7 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v32+8]");
			obj3 = 0;
			action2 = (Action<object>)(object)localizableText2;
			if (obj26 != null)
			{
				goto IL_02b9;
			}
		}
		goto IL_0428;
		IL_0258:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		num = (nint)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v29+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ X0_v29] (should have been resolved before IL gen)");
		bool flag7 = ex == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v29+8]");
		obj3 = 0;
		action2 = (Action<object>)(object)localizableText2;
		if (!flag7)
		{
			goto IL_02b9;
		}
		goto IL_0428;
	}

	private void DebugButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_0234: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0544: Expected O, but got I
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0599: Expected O, but got I4
		//IL_02fa: Expected O, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_05b7: Expected O, but got I
		//IL_05d2: Expected I, but got O
		//IL_05e7: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0628: Expected O, but got I
		//IL_03ff: Expected O, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object text = "HH:mm:ss.ffZ" + 1864;
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Info);
		LocalizableText localizableText = TextMeshProExtensions.FixOnly((string)text);
		object obj4 = typeof(System.IOAsyncCallback) + 392;
		object text2 = "HH:mm:ss.ffZ" + 616;
		nint num = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0121;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v6 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v24-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0121;
		}
		object obj7 = obj6 + 1;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_04c0;
		IL_033b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj11 = default(object);
		object obj10 = obj11;
		goto IL_0524;
		IL_0440:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0610;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X0_v39] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag = obj12 == null;
		object obj13 = !flag;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_027f;
		IL_0524:
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj15 = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v467 @ X8_v14] (should have been resolved before IL gen)");
		object obj16 = obj2 + 16;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19;
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj20 = !flag2;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v25+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v17+10]");
		ArraysExtensions.ForEach((IEnumerable<object>)0, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+10]");
		object obj22 = 0;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v18+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0440;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v18+B0]");
		object obj25 = (nint)0 + (nint)8;
		object obj26;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X10_v9-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_0440;
		}
		object obj27 = obj25 + 9;
		object obj28 = obj23 + obj27;
		object obj29 = obj28 + 312;
		goto IL_0610;
		IL_0121:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04c0;
		IL_04c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v337 @ X0_v13] (should have been resolved before IL gen)");
		LocalizableText localizableText2 = TextMeshProExtensions.FixOnly((string)text2);
		object obj30 = typeof(System.IOAsyncCallback) + 384;
		object obj32 = default(object);
		object obj31 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0206;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v11+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v19-8]");
			if (0 == (nint)obj30)
			{
				break;
			}
			obj34 += 16;
			obj33--;
			if ((nint)obj33 != 1)
			{
				continue;
			}
			goto IL_0206;
		}
		object obj35 = obj34 + 1;
		object obj36 = obj31 + obj35;
		object obj37 = obj36 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ X0_v42] (should have been resolved before IL gen)");
		goto IL_027f;
		IL_027f:
		obj26 = typeof(System.IOAsyncCallback) + 368;
		obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
		object obj38 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v13+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v13+12E]");
		if ((nint)0 == 0)
		{
			goto IL_033b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v13+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X10_v14-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj40 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_033b;
		}
		object obj41 = obj40 + 5;
		object obj42 = obj38 + obj41;
		obj10 = obj42 + 312;
		goto IL_0524;
		IL_0610:
		object obj43 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v29+8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v222 @ X2_v10 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void VerifyCode(string soSecret)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_059c: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_00ee: Expected O, but got I8
		//IL_0108: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_0391: Expected O, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Expected O, but got Unknown
		//IL_0c39: Expected O, but got I4
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected O, but got Unknown
		//IL_0cde: Expected O, but got I4
		//IL_047b: Expected O, but got I4
		//IL_0489: Expected O, but got I4
		//IL_04a3: Expected O, but got I4
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected O, but got Unknown
		//IL_0be3: Expected O, but got I4
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_09c1: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_0dd1: Expected O, but got I4
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected O, but got Unknown
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected O, but got Unknown
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0a6f: Expected O, but got I4
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Expected O, but got Unknown
		//IL_0b3a: Expected O, but got I4
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0d48: Expected O, but got I4
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected O, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_0ca3: Expected O, but got I4
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7f: Expected O, but got Unknown
		//IL_0937: Expected O, but got I4
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0986: Expected O, but got I4
		//IL_0663: Expected O, but got I4
		//IL_07be: Expected O, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_0867: Expected O, but got I4
		//IL_0abe: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0551: Expected O, but got I4
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72EE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		bool flag2 = soSecret == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_009f;
		}
		goto IL_02f8;
		IL_0d8f:
		string adType;
		ShowAD(adType);
		return;
		IL_0d9a:
		string text;
		int result;
		bool flag3 = int.TryParse(text, out result);
		if (flag3)
		{
			((LogoScript)flag3).SwitchToUser(result);
		}
		return;
		IL_030e:
		NullReferenceException ex;
		bool flag4 = (long)ex < 3236649860L;
		object obj7 = !flag4;
		object obj8 = ex - 3236649860L;
		bool flag5 = obj8 == null;
		object obj9 = !flag5;
		object obj10 = obj7 & obj9;
		if (obj10 == null)
		{
			bool flag6 = (long)ex < 2791766456L;
			object obj11 = !flag6;
			object obj12 = ex - 2791766456L;
			bool flag7 = obj12 == null;
			object obj13 = !flag7;
			object obj14 = obj11 & obj13;
			if (obj14 == null)
			{
				if ((long)ex != 2434223153L)
				{
					if ((long)ex == 2791766456L)
					{
						object obj15 = "destinationTimeZone" + 160;
						if (text == (string)obj15)
						{
							ActivateDevTesting();
							return;
						}
					}
				}
				else
				{
					object obj16 = "___# Content push apply failed [{0}]: {1}" + 3256;
					bool flag8 = text == (string)obj16;
					bool flag9 = !flag8;
					object obj17 = !flag9;
					adType = text;
					if (obj17 != null)
					{
						goto IL_0d8f;
					}
				}
			}
			else if ((long)ex != 2968975163L)
			{
				if ((long)ex != 3075051499L)
				{
					if ((long)ex == 3236649860L)
					{
						object obj18 = "java.io.FileOutputStream" + 296;
						bool flag10 = text == (string)obj18;
						if (flag10)
						{
							((LogoScript)flag10).JustForMe();
							return;
						}
					}
				}
				else
				{
					object obj19 = "startPosition" + 2632;
					if (text == (string)obj19)
					{
						object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v24+E4]");
						bool flag11 = (nint)0 == 0;
						object obj22 = !flag11;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TestMediation();
						return;
					}
				}
			}
			else
			{
				object obj23 = "___# Content push apply failed [{0}]: {1}" + 3248;
				bool flag12 = text == (string)obj23;
				bool flag13 = !flag12;
				object obj24 = !flag13;
				adType = text;
				if (obj24 != null)
				{
					goto IL_0d8f;
				}
			}
		}
		else
		{
			bool flag14 = (long)ex < 3966541230L;
			object obj25 = !flag14;
			object obj26 = ex - 3966541230L;
			bool flag15 = obj26 == null;
			object obj27 = !flag15;
			object obj28 = obj25 & obj27;
			if (obj28 == null)
			{
				if ((long)ex != 3558323626L)
				{
					if ((long)ex != 3781233590L)
					{
						if ((long)ex == 3966541230L)
						{
							object obj29 = "destinationTimeZone" + 3328;
							bool flag16 = text == (string)obj29;
							if (flag16)
							{
								((LogoScript)flag16).ExitTheVoid();
								return;
							}
						}
					}
					else
					{
						object obj30 = "destinationTimeZone" + 2464;
						bool flag17 = text == (string)obj30;
						if (flag17)
						{
							((LogoScript)flag17).EnterTheVoid();
							return;
						}
					}
				}
				else
				{
					object obj31 = "___# Content push apply failed [{0}]: {1}" + 3272;
					bool flag18 = text == (string)obj31;
					bool flag19 = !flag18;
					object obj32 = !flag19;
					adType = text;
					if (obj32 != null)
					{
						goto IL_0d8f;
					}
				}
			}
			else if ((long)ex != 4093075636L)
			{
				if ((long)ex != 4143408493L)
				{
					if ((long)ex == 4281824629L)
					{
						object obj33 = "alignContent" + 4072;
						bool flag20 = text == (string)obj33;
						if (flag20)
						{
							((LogoScript)flag20).BeTheVoid();
							return;
						}
					}
				}
				else
				{
					object obj34 = "___# Content push apply failed [{0}]: {1}" + 3240;
					bool flag21 = text == (string)obj34;
					bool flag22 = !flag21;
					object obj35 = !flag22;
					adType = text;
					if (obj35 != null)
					{
						goto IL_0d8f;
					}
				}
			}
			else
			{
				object obj36 = "___# Content push apply failed [{0}]: {1}" + 3232;
				bool flag23 = text == (string)obj36;
				bool flag24 = !flag23;
				adType = text;
				if (!flag24)
				{
					goto IL_0d8f;
				}
			}
		}
		goto IL_0d9a;
		IL_007d:
		PopupWindow.DismissMessage();
		if (soSecret != null)
		{
			goto IL_009f;
		}
		goto IL_02f8;
		IL_02f8:
		ex = new NullReferenceException();
		text = soSecret;
		goto IL_030e;
		IL_009f:
		string text2 = soSecret.Trim();
		uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text2);
		bool flag25 = (int)num < 2383890296L;
		object obj37 = !flag25;
		object obj38 = (int)num - 2383890296L;
		bool flag26 = obj38 == null;
		object obj39 = !flag26;
		object obj40 = obj37 & obj39;
		ex = (NullReferenceException)num;
		text = text2;
		if (obj40 != null)
		{
			goto IL_030e;
		}
		bool flag27 = (int)num < 775068458;
		object obj41 = !flag27;
		object obj42 = num - 775068458;
		bool flag28 = obj42 == null;
		object obj43 = !flag28;
		object obj44 = obj41 & obj43;
		if (obj44 == null)
		{
			bool flag29 = (int)num < 183581838;
			object obj45 = !flag29;
			object obj46 = num - 183581838;
			bool flag30 = obj46 == null;
			object obj47 = !flag30;
			object obj48 = obj45 & obj47;
			if (obj48 == null)
			{
				if (num != 11362760)
				{
					bool flag31 = num != 183581838;
					text = text2;
					if (!flag31)
					{
						object obj49 = "Error reading data from socket: " + 2824;
						bool flag32 = text2 == (string)obj49;
						bool flag33 = !flag32;
						text = text2;
						if (!flag33)
						{
							FPS2();
							return;
						}
					}
				}
				else
				{
					object obj50 = "Error reading data from socket: " + 2808;
					bool flag34 = text2 == (string)obj50;
					bool flag35 = !flag34;
					text = text2;
					if (!flag35)
					{
						((LogoScript)flag34).FPS();
						return;
					}
				}
			}
			else
			{
				switch (num)
				{
				default:
				{
					bool flag38 = num != 775068458;
					text = text2;
					if (!flag38)
					{
						object obj52 = "com.unity.services.authentication.profile" + 648;
						bool flag39 = text2 == (string)obj52;
						bool flag40 = !flag39;
						text = text2;
						if (!flag40)
						{
							ActivateConsole();
							return;
						}
					}
					break;
				}
				case 725883095u:
				{
					object obj53 = "Error reading data from socket: " + 2408;
					bool flag41 = text2 == (string)obj53;
					bool flag42 = !flag41;
					text = text2;
					if (!flag42)
					{
						((LogoScript)flag41).PrintFCMToken();
						return;
					}
					break;
				}
				case 444307951u:
				{
					object obj51 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2072;
					bool flag36 = text2 == (string)obj51;
					bool flag37 = !flag36;
					text = text2;
					if (!flag37)
					{
						((LogoScript)flag36).PrintCachePath();
						return;
					}
					break;
				}
				}
			}
		}
		else
		{
			bool flag43 = (int)num < 1826076931;
			object obj54 = !flag43;
			object obj55 = num - 1826076931;
			bool flag44 = obj55 == null;
			object obj56 = !flag44;
			object obj57 = obj54 & obj56;
			if (obj57 == null)
			{
				if (num != 1112172186)
				{
					bool flag45 = num != 1826076931;
					text = text2;
					if (!flag45)
					{
						object obj58 = "fetch_products" + 1088;
						bool flag46 = text2 == (string)obj58;
						bool flag47 = !flag46;
						text = text2;
						if (!flag47)
						{
							((LogoScript)flag46).KammelnaFormChange();
							return;
						}
					}
				}
				else
				{
					object obj59 = "___# Content push apply failed [{0}]: {1}" + 2816;
					bool flag48 = text2 == (string)obj59;
					bool flag49 = !flag48;
					text = text2;
					if (!flag49)
					{
						PromptCode();
						return;
					}
				}
			}
			else if ((int)num != 2184564328L)
			{
				if ((int)num != 2281853915L)
				{
					bool flag50 = (int)num != 2383890296L;
					text = text2;
					if (!flag50)
					{
						object obj60 = "___# Content push apply failed [{0}]: {1}" + 3264;
						bool flag51 = text2 == (string)obj60;
						bool flag52 = !flag51;
						object obj61 = !flag52;
						adType = text2;
						if (obj61 != null)
						{
							goto IL_0d8f;
						}
						text = text2;
					}
				}
				else
				{
					object obj62 = "destinationTimeZone" + 4064;
					bool flag53 = text2 == (string)obj62;
					bool flag54 = !flag53;
					text = text2;
					if (!flag54)
					{
						ChangeFrontEnd();
						return;
					}
				}
			}
			else
			{
				object obj63 = "com.unity.services.authentication.profile" + 3488;
				bool flag55 = text2 == (string)obj63;
				bool flag56 = !flag55;
				text = text2;
				if (!flag56)
				{
					((LogoScript)flag55).DebuggerOverload();
					return;
				}
			}
		}
		goto IL_0d9a;
	}

	private void JustForMe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "___# Content push apply failed [{0}]: {1}" + 456;
		object methodName = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3344;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private static void TestMediation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_0255: Expected I, but got O
		//IL_0273: Expected O, but got I
		//IL_00dc: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "___# Content push apply failed [{0}]: {1}" + 792;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object methodName = "SubscribeGroup request Error" + 3448;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v4+8]");
		Action<AdInspectorError> adInspectorClosedAction = (Action<AdInspectorError>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X9_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v14+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)488;
			Action<object> action = default(Action<object>);
			action..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v13+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			adInspectorClosedAction = action;
		}
		MobileAds.OpenAdInspector(adInspectorClosedAction);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void ShowAD(string adType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0343: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "_InputUv1BufferOffset" + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		AdsController adsController = this.adsController;
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 3256;
		adsController.<IsTestingMode>k__BackingField = true;
		AdsController adsController2;
		AdPlace adPlace;
		if (adType == (string)obj4)
		{
			adsController2 = this.adsController;
			adPlace = AdPlace.MiniGame;
		}
		else
		{
			object obj5 = "___# Content push apply failed [{0}]: {1}" + 3264;
			if (adType == (string)obj5)
			{
				adsController2 = this.adsController;
				adPlace = AdPlace.RankedPlay;
			}
			else
			{
				object obj6 = "___# Content push apply failed [{0}]: {1}" + 3272;
				if (!(adType == (string)obj6))
				{
					object obj7 = "___# Content push apply failed [{0}]: {1}" + 3232;
					AdsController adsController3;
					AdPlace adPlace2;
					if (adType == (string)obj7)
					{
						adsController3 = this.adsController;
						adPlace2 = AdPlace.MiniGame;
					}
					else
					{
						object obj8 = "___# Content push apply failed [{0}]: {1}" + 3240;
						if (adType == (string)obj8)
						{
							adsController3 = this.adsController;
							adPlace2 = AdPlace.RankedPlay;
						}
						else
						{
							object obj9 = "___# Content push apply failed [{0}]: {1}" + 3248;
							if (!(adType == (string)obj9))
							{
								goto IL_0166;
							}
							adsController3 = this.adsController;
							adPlace2 = AdPlace.Testing;
						}
					}
					adsController3.ShowVidAds(adPlace2);
					goto IL_0166;
				}
				adsController2 = this.adsController;
				adPlace = AdPlace.Testing;
			}
		}
		adsController2.ShowRewardedAd(adPlace);
		goto IL_0166;
		IL_0166:
		object obj10 = "SetRoomVariables request error" + 616;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		string adType2 = (string)obj10 + adType;
		ITrackEvent trackEvent = TrackerLibrary.DevShowTestAd(adType2);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void SwitchToUser(int number)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_0447: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_0416: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_02fc: Expected O, but got I4
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0492: Expected O, but got I
		//IL_04a2: Expected O, but got I
		//IL_04c4: Expected O, but got I4
		//IL_03c1: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04fc: Expected O, but got I
		//IL_050d: Expected I, but got O
		//IL_052b: Expected O, but got I
		//IL_0373: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72F2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Config.Environment != ServerEnvironment.Production)
		{
			goto IL_011d;
		}
		return;
		IL_011d:
		object format = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3088;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object reason = "SubscribeGroup request Error" + 416;
		object obj6 = typeof(UsageHint) + 40;
		object format2 = "startPosition" + 2664;
		object obj7 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string message = string.Format((string)format, arg);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug(message, (Vector2)0, 0f);
		Authentication.Clear((string)reason);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserCredentials userCredentials = default(UserCredentials);
		userCredentials..ctor();
		string text;
		if (number != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg2 = default(object);
			text = string.Format((string)format2, arg2);
			object obj10 = 0;
		}
		else
		{
			object arg3 = (nint)0 + (nint)2000;
			text = string.Format((string)format2, arg3);
			bool flag3 = userCredentials == null;
			object obj11 = !flag3;
			object obj10 = 0;
			if (obj11 == null)
			{
				throw new NullReferenceException();
			}
		}
		object obj12 = "startPosition" + 2624;
		object obj13 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
		object obj14 = userCredentials + 16;
		obj14 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = userCredentials + 24;
		obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string deviceId = UserDeviceIDRecorder.DeviceId;
		object obj16 = userCredentials + 40;
		obj16 = deviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj13;
		}
		object methodName = "SubscribeGroup request Error" + 408;
		object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v13+10]");
		Action<KammelnaResponseModel<AuthModel>> callback = (Action<KammelnaResponseModel<AuthModel>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v13+10]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v19+B8]");
				obj20 = 0;
			}
			object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)480;
			Action<object> action = default(Action<object>);
			action..ctor(obj20, (IntPtr)obj25);
			object obj26 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v18+B8]");
			object obj27 = (nint)0 + (nint)16;
			obj27 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			callback = action;
		}
		KammelnaRequests.GetAuthTokens(userCredentials, callback);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj28 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj29 = !flag7;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0074:
		ServerEnvironment environment = Config.Environment;
		bool flag8 = environment == ServerEnvironment.Production;
		object obj30 = !flag8;
		if (obj30 == null)
		{
			return;
		}
		goto IL_011d;
	}

	private void PrintFCMToken()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_008f: Expected O, but got I8
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I4
		//IL_020c: Expected O, but got I8
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0281: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02c0: Expected O, but got I
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_03af: Expected O, but got I4
		//IL_03c5: Expected O, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0404: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0466: Expected O, but got I8
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0507: Expected O, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_055a: Expected O, but got I4
		//IL_0584: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj2 = "Error reading data from socket: " + 2416;
			object obj3 = array + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string fcmToken = NotificationPermissionUtils.FcmToken;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X20_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = fcmToken;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X20_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = (nint)0 + (nint)2384;
					object obj11 = typeof(Queue<string>) + 848;
					object obj12 = (nint)0 + (nint)2200;
					object obj13 = array + 48;
					obj13 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v17+E4]");
					bool flag3 = (nint)0 == 0;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					User localUser = sessionModel.LocalUser;
					string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser);
					object obj16 = array.Length & 0xFFFFFFFCL;
					if (obj16 != null)
					{
						object obj17 = array + 56;
						obj17 = userTwitterID;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X20_v12-20]");
						bool flag4 = (nint)0 < (nint)4;
						object obj18 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X20_v12-20]");
						object obj19 = -4;
						bool flag5 = obj19 == null;
						object obj20 = ~obj18;
						object obj21 = obj20 | flag5;
						if (obj21 == null)
						{
							object obj22 = (nint)0 + (nint)2376;
							object obj23 = array + 64;
							obj23 = obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel2 = default(SessionModel);
							User localUser2 = sessionModel2.LocalUser;
							string userGoogleID = SFSKammelnaUserExtensions.GetUserGoogleID(localUser2);
							bool flag6 = array.Length < 5;
							object obj24 = !flag6;
							object obj25 = array.Length - 5;
							bool flag7 = obj25 == null;
							object obj26 = ~obj24;
							object obj27 = obj26 | flag7;
							if (obj27 == null)
							{
								object obj28 = array + 72;
								obj28 = userGoogleID;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X20_v14-30]");
								bool flag8 = (nint)0 < (nint)6;
								object obj29 = !flag8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X20_v14-30]");
								object obj30 = -6;
								bool flag9 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag9;
								if (obj32 == null)
								{
									object obj33 = (nint)0 + (nint)2368;
									object obj34 = array + 80;
									obj34 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel3 = default(SessionModel);
									User localUser3 = sessionModel3.LocalUser;
									string userFacebookID = SFSKammelnaUserExtensions.GetUserFacebookID(localUser3);
									object obj35 = array.Length & 0xFFFFFFF8L;
									if (obj35 != null)
									{
										object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
										object obj37 = typeof(DataRelation) + 856;
										object obj38 = array + 88;
										obj38 = userFacebookID;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										string message = string.Concat(array);
										object obj39 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v46+E4]");
										bool flag10 = (nint)0 == 0;
										object obj40 = !flag10;
										if (obj40 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object methodName = "Picking audio files is not supported on iOS" + 1832;
										object obj41 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
										Toast.Debug(message, (Vector2)0, 0f);
										object obj42 = obj37;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v49+E4]");
										bool flag11 = (nint)0 == 0;
										object obj43 = !flag11;
										if (obj43 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Debug.Log(message);
										ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
										object obj44 = obj41;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v24+E4]");
										if ((nint)0 != 0)
										{
											Tracker.DesignEvent(trackEvent);
											return;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										Tracker.DesignEvent(trackEvent);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void PrintCachePath()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		//IL_0102: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = "COORDINATE_TYPE_GCJ_02" + 472;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = typeof(DataRelation) + 856;
		string cachePath = Config.CachePath;
		string message = (string)obj2 + cachePath;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object methodName = "Picking audio files is not supported on iOS" + 1824;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Toast.Debug(message, (Vector2)0, 0f);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void EnterTheVoid()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_01be: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f0: Expected I, but got O
		//IL_030e: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3024;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		object obj6;
		object obj7;
		Action action;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
			bool flag2 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_00c9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj8 = obj6;
			if (obj9 != null)
			{
				goto IL_00c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)464;
		Action action2 = default(Action);
		action2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+B8]");
		object obj15 = (nint)0 + (nint)24;
		obj15 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		action = action2;
		Vector2 vector = (Vector2)action2;
		Action action3 = action2;
		if (obj17 != null)
		{
			goto IL_0107;
		}
		goto IL_0243;
		IL_0107:
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		return;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		goto IL_0107;
		IL_00c9:
		obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		vector = (Vector2)0;
		action3 = action;
		if (!flag6)
		{
			goto IL_0107;
		}
		goto IL_0243;
	}

	private void ExitTheVoid()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_01be: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f0: Expected I, but got O
		//IL_030e: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3040;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		object obj6;
		object obj7;
		Action action;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
			bool flag2 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_00c9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+20]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj8 = obj6;
			if (obj9 != null)
			{
				goto IL_00c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)472;
		Action action2 = default(Action);
		action2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+B8]");
		object obj15 = (nint)0 + (nint)32;
		obj15 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		action = action2;
		Vector2 vector = (Vector2)action2;
		Action action3 = action2;
		if (obj17 != null)
		{
			goto IL_0107;
		}
		goto IL_0243;
		IL_0107:
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		return;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		goto IL_0107;
		IL_00c9:
		obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		vector = (Vector2)0;
		action3 = action;
		if (!flag6)
		{
			goto IL_0107;
		}
		goto IL_0243;
	}

	private void BeTheVoid()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_01be: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f0: Expected I, but got O
		//IL_030e: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2992;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2688;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		object obj6;
		object obj7;
		Action action;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+28]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+28]");
			bool flag2 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_00c9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+28]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+28]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj8 = obj6;
			if (obj9 != null)
			{
				goto IL_00c9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)456;
		Action action2 = default(Action);
		action2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12+B8]");
		object obj15 = (nint)0 + (nint)40;
		obj15 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		action = action2;
		Vector2 vector = (Vector2)action2;
		Action action3 = action2;
		if (obj17 != null)
		{
			goto IL_0107;
		}
		goto IL_0243;
		IL_0107:
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		return;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action3;
		goto IL_0107;
		IL_00c9:
		obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		vector = (Vector2)0;
		action3 = action;
		if (!flag6)
		{
			goto IL_0107;
		}
		goto IL_0243;
	}

	private unsafe void DebuggerOverload()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0238: Expected O, but got I4
		//IL_003b: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_024f: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_031f: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_035a: Expected O, but got Ref
		//IL_039d: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3008;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
		object obj7;
		object obj8;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
			obj7 = 0;
			bool flag2 = (nint)obj6 != 5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
			obj8 = 0;
			obj9 = obj5;
			if (!flag2)
			{
				goto IL_00c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
			obj7 = 0;
			bool flag3 = (nint)obj6 == 5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
			obj8 = 0;
			obj9 = obj5;
			if (flag3)
			{
				goto IL_00c0;
			}
		}
		bool flag4 = obj8 == null;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj2;
		}
		object obj11 = 5;
		obj5 = obj9;
		goto IL_02c2;
		IL_02c2:
		obj6 = obj11;
		object obj12 = "___# Content push apply failed [{0}]: {1}" + 464;
		object obj13 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		object obj14 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object methodName = "DNQUALIFIER" + 1704;
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj17 = default(object);
		string text = ((Enum)(&obj17)).ToString();
		string text2 = (string)obj12 + text + (string)obj13;
		object obj18 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		object message2 = text2;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text2;
		}
		Debug.Log(message2);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		return;
		IL_00c0:
		bool flag8 = obj7 == null;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v6+B8]");
			obj6 = 0;
		}
		obj11 = 1;
		goto IL_02c2;
	}

	private void ActivateConsole()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_007b: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3064;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2320;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object methodName = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3536;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Toast.Debug((string)message, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void ActivateDevTesting()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_007b: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3016;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2328;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object methodName = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3544;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Toast.Debug((string)message, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void KammelnaFormChange()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016e: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01b8: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_01d4: Expected I, but got O
		//IL_01fe: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3072;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1056;
		object obj4 = (nint)0 + (nint)1064;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object methodName = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3624;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Toast.Debug((string)message, (Vector2)0, 0f);
		bool isTablet = ScreenUtility.IsTablet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		bool flag2 = !isTablet;
		object obj9 = !flag2;
		object obj10 = ~obj9;
		object obj11 = ((obj10 != null) ? obj4 : obj3);
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj11);
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void FPS()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0047: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3048;
		object obj2 = typeof(Queue<string>) + 744;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2008;
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object methodName = "Error reading data from socket: " + 2808;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v10+20]");
		object obj9 = (nint)0 ^ (nint)1;
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void FPS2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_045c: Expected O, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0510: Expected O, but got I
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0550: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_006a: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_04c3: Expected O, but got I
		//IL_04e3: Expected F8, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_023c: Expected O, but got I
		//IL_0266: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_00d3: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_04ae: Expected F8, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0300: Expected O, but got I
		//IL_0308: Expected I, but got O
		//IL_0316: Expected I, but got O
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0359: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_02bf: Expected O, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_047a: Expected O, but got I
		//IL_048a: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+B8]");
		object obj5 = 0;
		object obj6 = obj5 ^ 1;
		obj5 = obj6;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+B8]");
		object obj10 = 0;
		UnityEngine.Object obj12;
		object obj19;
		object obj20;
		if ((nint)obj10 == 1)
		{
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
			UnityEngine.Object obj14;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
				obj12 = (UnityEngine.Object)0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+E4]");
				bool flag3 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
				obj14 = (UnityEngine.Object)0;
				if (!flag3)
				{
					goto IL_0110;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v24+B8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v25+8]");
				obj12 = (UnityEngine.Object)0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v26+E4]");
				bool flag4 = (nint)0 == 0;
				object obj17 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v25+8]");
				obj14 = (UnityEngine.Object)0;
				if (obj17 != null)
				{
					goto IL_0110;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj14;
			bool flag6 = !flag5;
			object obj18 = !flag6;
			obj19 = 0;
			obj20 = 0;
			if (obj18 != null)
			{
				goto IL_0148;
			}
			goto IL_02d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v13+B8]");
			obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
		GameObject gameObject = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+8]");
		bool flag8 = (nint)0 == 0;
		double num = 0.0;
		if (flag8)
		{
			goto IL_039e;
		}
		bool active = false;
		goto IL_048f;
		IL_0148:
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v34+E4]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v34+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v29+8]");
		gameObject = (GameObject)0;
		active = true;
		goto IL_048f;
		IL_048f:
		gameObject.SetActive(active);
		nint num2 = 0;
		num = 0.0;
		goto IL_039e;
		IL_02d6:
		object obj26 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2336;
		num2 = (nint)obj27;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj27);
		object obj28 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v21+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
		num = 0.5;
		goto IL_039e;
		IL_039e:
		object methodName = "Error reading data from socket: " + 2824;
		object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v11+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0110:
		bool flag11 = obj12;
		bool flag12 = !flag11;
		obj19 = 0;
		obj20 = 0;
		if (!flag12)
		{
			goto IL_0148;
		}
		goto IL_02d6;
	}

	private void ChangeFrontEnd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_02dd: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_013d: Expected I, but got O
		//IL_0182: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object methodName = "Cannot populate JSON object onto type '{0}'." + 2104;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ServerEnvironment environment = Config.Environment;
		if (EnvironmentExtensions.IsDevelopment(environment))
		{
			object message = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3080;
			object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 880;
			object obj7 = (nint)0 + (nint)2360;
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Debug((string)message, (Vector2)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj7);
			LanBackendScanner.Scan(action);
			ITrackEvent trackEvent = TrackerLibrary.DevMethods((string)methodName);
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			return;
		}
		object obj12 = typeof(RegisteredWaitHandle) + 3776;
		object format = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3032;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ServerEnvironment environment2 = Config.Environment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string message2 = string.Format((string)format, arg);
		object obj15 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug(message2, (Vector2)0, 0f);
		ITrackEvent trackEvent2 = TrackerLibrary.DevMethods((string)methodName);
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent2);
	}

	private unsafe void ShowFrontEndPicker(List<string> hosts)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected I4, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00fd: Expected I, but got O
		//IL_010d: Expected O, but got I
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Expected I4, but got Unknown
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Expected I4, but got Unknown
		//IL_0ae4: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_0208: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_0b04: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0265: Expected O, but got I
		//IL_02fb: Expected I4, but got O
		//IL_030b: Expected O, but got I
		//IL_032f: Expected O, but got I4
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		//IL_02a0: Expected O, but got I
		//IL_049d: Expected O, but got I4
		//IL_04a6: Expected O, but got I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_056e: Expected O, but got I4
		//IL_0426: Expected O, but got I
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037b: Expected I4, but got O
		//IL_038b: Expected O, but got I
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected I4, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0652: Expected O, but got I
		//IL_0668: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_0689: Expected I, but got O
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected I4, but got Unknown
		//IL_06bc: Expected O, but got I4
		//IL_05d9: Expected O, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_06fe: Expected O, but got I
		//IL_0600: Expected O, but got I
		//IL_061e: Expected O, but got I4
		//IL_0bab: Expected I4, but got O
		//IL_0bf5: Expected O, but got I4
		//IL_0739: Expected O, but got I
		//IL_07c1: Expected I, but got O
		//IL_07d1: Expected O, but got I
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_0867: Expected I4, but got O
		//IL_0891: Expected O, but got I4
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_080c: Expected O, but got I
		//IL_08af: Expected I, but got O
		//IL_08bf: Expected O, but got I
		//IL_094e: Expected O, but got I4
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0960: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Expected O, but got Unknown
		//IL_0976: Expected I4, but got O
		//IL_09a2: Expected O, but got I4
		//IL_09ab: Expected O, but got I4
		//IL_0c7c: Expected O, but got I
		//IL_08fa: Expected O, but got I
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0828: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_0c4e: Expected O, but got I4
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72FF]");
		int num = 0;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2720;
		object text = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		if (hosts != null)
		{
			num = hosts._size;
			object obj3 = hosts._size - 1;
			bool flag = (nint)obj3 < 0;
			int num2 = hosts._size ^ 1;
			int num3 = hosts._size ^ obj3;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			object obj4 = !flag3;
			obj5 = obj4;
		}
		else
		{
			obj5 = 1;
		}
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		LocalizableText localizableText = TextMeshProExtensions.FixOnly((string)text);
		bool flag4 = popupWindowBuilderNeedsTitle == null;
		LogoScript logoScript = this;
		if (flag4)
		{
			goto IL_09b9;
		}
		object obj6 = typeof(System.IOAsyncCallback) + 392;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		nint num5 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0191;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X10_v37-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj10 = obj9 + 16;
			obj8--;
			bool flag5 = (nint)obj8 != 1;
			obj9 = obj10;
			if (flag5)
			{
				continue;
			}
			goto IL_0191;
		}
		object obj11 = obj9 + 1;
		object obj12 = num5 + obj11;
		object obj13 = obj12 + 312;
		obj10 = obj9;
		goto IL_0a92;
		IL_093b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj14 = 0;
		goto IL_0c64;
		IL_0c64:
		object obj16 = default(object);
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v8+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v497 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0ba3:
		object obj18 = default(object);
		num = (int)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v763 @ X0_v35] (should have been resolved before IL gen)");
		object obj19;
		logoScript = (LogoScript)obj19;
		object text2;
		LocalizableText label = TextMeshProExtensions.FixOnly((string)text2);
		PopupButton popupButton = PopupButton.Neutral(label, null, dismiss: true);
		bool flag6 = obj19 == null;
		obj14 = 0;
		object obj20;
		obj10 = obj20;
		object obj22;
		LogoScript logoScript2;
		if (!flag6)
		{
			nint num6 = (nint)logoScript;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v27 (Il2CppClass<LogoScript>)+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v27 (Il2CppClass<LogoScript>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0855;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v27 (Il2CppClass<LogoScript>)+B0]");
			obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v29-8]");
				if (0 == (nint)obj22)
				{
					break;
				}
				obj20 = obj10 + 16;
				obj21--;
				bool flag7 = (nint)obj21 != 1;
				obj10 = obj20;
				if (flag7)
				{
					continue;
				}
				goto IL_0855;
			}
			object obj23 = num6 + obj10;
			object obj24 = obj23 + 312;
			num = (int)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v48] (should have been resolved before IL gen)");
			logoScript2 = (LogoScript)obj19;
			bool flag8 = obj19 == null;
			object obj25 = !flag8;
			obj14 = 0;
			if (obj25 != null)
			{
				goto IL_08a7;
			}
		}
		goto IL_09b9;
		IL_046f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v642.m_value (System.Int32) (should have been resolved before IL gen)");
		bool flag9 = obj2 == null;
		object obj26 = !flag9;
		object obj27 = 4;
		if (obj26 != null)
		{
			goto IL_0526;
		}
		obj10 = obj20;
		int num7 = default(int);
		num = num7;
		goto IL_09b9;
		IL_0526:
		obj19 = obj2 + 16;
		object obj28 = default(object);
		obj19 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj29 = obj5 & 1;
		bool flag10 = obj29 == null;
		object obj30 = !flag10;
		if (obj30 == null)
		{
			object obj31 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (int)((nint)0 + (nint)520);
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)((int*)num)->m_value);
			bool flag11 = hosts == null;
			obj14 = 0;
			obj10 = obj20;
			logoScript = this;
			if (flag11)
			{
				goto IL_09b9;
			}
			object obj32 = (nint)0 + (nint)3136;
			obj27 = obj32;
			((List<object>)(object)hosts).ForEach(action);
			obj14 = 0;
		}
		num = (int)("LAK" + 3688);
		object obj33 = typeof(SqlSingle[]) + 2376;
		object obj34 = (nint)0 + (nint)2352;
		object obj35 = obj19;
		LocalizableText label2 = TextMeshProExtensions.FixOnly((string)((int*)num)->m_value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj34);
		PopupButton popupButton2 = PopupButton.Neutral(label2, action2, dismiss: true);
		bool flag12 = obj19 == null;
		obj14 = 0;
		obj10 = obj20;
		logoScript = this;
		if (flag12)
		{
			goto IL_09b9;
		}
		text2 = "COORDINATE_TYPE_GCJ_02" + 1864;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v24+12E]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0782;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v24+B0]");
		object obj38 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X10_v22-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj20 = obj38 + 16;
			obj37--;
			bool flag13 = (nint)obj37 != 1;
			obj38 = obj20;
			if (flag13)
			{
				continue;
			}
			goto IL_0782;
		}
		object obj39 = obj36 + obj38;
		obj18 = obj39 + 312;
		obj20 = obj38;
		goto IL_0ba3;
		IL_0855:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		num = (int)obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v791 @ X0_v45] (should have been resolved before IL gen)");
		logoScript2 = (LogoScript)obj19;
		bool flag14 = obj19 == null;
		obj14 = 0;
		obj10 = obj20;
		if (!flag14)
		{
			goto IL_08a7;
		}
		goto IL_09b9;
		IL_09b9:
		throw new NullReferenceException();
		IL_08a7:
		nint num8 = (nint)logoScript2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v29 (Il2CppClass<LogoScript>)+12E]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v29 (Il2CppClass<LogoScript>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_093b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v29 (Il2CppClass<LogoScript>)+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v29-8]");
			bool flag15 = 0 == (nint)obj22;
			obj14 = 0;
			num = (int)num8;
			if (flag15)
			{
				break;
			}
			obj10 += 16;
			obj41--;
			if ((nint)obj41 != 1)
			{
				continue;
			}
			goto IL_093b;
		}
		object obj42 = obj10 + 9;
		object obj43 = num + obj42;
		obj16 = obj43 + 312;
		goto IL_0c64;
		IL_0191:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a92;
		IL_0a92:
		int num9 = (int)("Network Authentication Required" + 592);
		int num10 = (int)("October" + 4080);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v530 @ X0_v14] (should have been resolved before IL gen)");
		object obj44 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj45 = !flag16;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string backendURL = Config.BackendURL;
		bool flag17 = obj5 == null;
		object obj46 = !flag17;
		object obj47 = ~obj46;
		num = ((obj47 != null) ? num10 : num9);
		string text3 = (string)((int*)num)->m_value + backendURL;
		LocalizableText localizableText2 = TextMeshProExtensions.FixOnly(text3);
		object obj48 = default(object);
		bool flag18 = obj48 == null;
		logoScript = this;
		object obj55 = default(object);
		if (!flag18)
		{
			object obj49 = typeof(System.IOAsyncCallback) + 384;
			object obj50 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v17+12E]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v17+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X8_v17+B0]");
			obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v14-8]");
				if (0 == (nint)obj49)
				{
					break;
				}
				obj10 = obj20 + 16;
				obj51--;
				bool flag19 = (nint)obj51 != 1;
				obj20 = obj10;
				if (flag19)
				{
					continue;
				}
				goto IL_02e9;
			}
			object obj52 = obj20 + 1;
			object obj53 = obj50 + obj52;
			object obj54 = obj53 + 312;
			num = (int)obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v65+8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v65] (should have been resolved before IL gen)");
			bool flag20 = obj55 == null;
			obj10 = obj20;
			logoScript = this;
			if (!flag20)
			{
				goto IL_03bf;
			}
		}
		goto IL_09b9;
		IL_03bf:
		obj22 = typeof(System.IOAsyncCallback) + 368;
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v19+12E]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_046f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v19+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v29-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj20 = obj10 + 16;
			obj57--;
			bool flag21 = (nint)obj57 != 1;
			obj10 = obj20;
			if (flag21)
			{
				continue;
			}
			goto IL_046f;
		}
		object obj58 = obj10 + 4;
		object obj59 = obj56 + obj58;
		num = obj59 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v421.m_value (System.Int32) (should have been resolved before IL gen)");
		bool flag22 = obj2 == null;
		obj20 = obj10;
		logoScript = this;
		if (!flag22)
		{
			goto IL_0526;
		}
		goto IL_09b9;
		IL_02e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj60 = default(object);
		num = (int)obj60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X0_v62+8]");
		obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ X0_v62] (should have been resolved before IL gen)");
		bool flag23 = obj55 == null;
		object obj61 = !flag23;
		obj20 = obj10;
		if (obj61 != null)
		{
			goto IL_03bf;
		}
		goto IL_09b9;
		IL_0782:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ba3;
	}

	private void PromptFrontEndManual()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00db: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)2344;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1552;
		object msgBody = "Unsupported map type" + 3640;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		IPopupWindowBuilderInput inputData = PopupInput.From(InputField.ContentType.Standard, action);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private static void ApplyFrontEnd(string frontEnd)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3000;
		object obj3 = (nint)0 + (nint)3272;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.SetDevelopmentHost(frontEnd);
		SFS.ResetEnvironment();
		string message = (string)obj2 + frontEnd + (string)obj3;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug(message, (Vector2)0, 0f);
	}

	static LogoScript()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0087: Expected O, but got I8
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0187: Expected O, but got I8
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		//IL_020b: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_028f: Expected O, but got I4
		//IL_02a5: Expected O, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0329: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I8
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_0429: Expected O, but got I4
		//IL_043f: Expected O, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_04c3: Expected O, but got I4
		//IL_04d9: Expected O, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected O, but got Unknown
		//IL_055d: Expected O, but got I4
		//IL_0573: Expected O, but got I
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I4
		//IL_060d: Expected O, but got I
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0691: Expected O, but got I4
		//IL_06a7: Expected O, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_072b: Expected O, but got I4
		//IL_0741: Expected O, but got I
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_07c5: Expected O, but got I4
		//IL_07db: Expected O, but got I
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_086f: Expected O, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected O, but got Unknown
		//IL_0907: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj2 = "___# Content push apply failed [{0}]: {1}" + 2816;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X20_v4-8]");
			object obj5 = 0 & 0xFFFFFFFEL;
			if (obj5 != null)
			{
				object obj6 = "destinationTimeZone" + 4064;
				object obj7 = obj4 + 40;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v6-10]");
				bool flag = (nint)0 < (nint)2;
				object obj8 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X20_v6-10]");
				object obj9 = -2;
				bool flag2 = obj9 == null;
				object obj10 = ~obj8;
				object obj11 = obj10 | flag2;
				if (obj11 == null)
				{
					object obj12 = "com.unity.services.authentication.profile" + 648;
					object obj13 = obj4 + 48;
					obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X20_v8-18]");
					object obj14 = 0 & 0xFFFFFFFCL;
					if (obj14 != null)
					{
						object obj15 = "fetch_products" + 1088;
						object obj16 = obj4 + 56;
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj17 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X20_v10-20]");
						object obj18 = -4;
						bool flag4 = obj18 == null;
						object obj19 = ~obj17;
						object obj20 = obj19 | flag4;
						if (obj20 == null)
						{
							object obj21 = "com.unity.services.authentication.profile" + 3488;
							object obj22 = obj4 + 64;
							obj22 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X20_v12-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj23 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X20_v12-28]");
							object obj24 = -5;
							bool flag6 = obj24 == null;
							object obj25 = ~obj23;
							object obj26 = obj25 | flag6;
							if (obj26 == null)
							{
								object obj27 = "destinationTimeZone" + 2464;
								object obj28 = obj4 + 72;
								obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X20_v14-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj29 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X20_v14-30]");
								object obj30 = -6;
								bool flag8 = obj30 == null;
								object obj31 = ~obj29;
								object obj32 = obj31 | flag8;
								if (obj32 == null)
								{
									object obj33 = "destinationTimeZone" + 3328;
									object obj34 = obj4 + 80;
									obj34 = obj33;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v16-38]");
									object obj35 = 0 & 0xFFFFFFF8L;
									if (obj35 != null)
									{
										object obj36 = "alignContent" + 4072;
										object obj37 = obj4 + 88;
										obj37 = obj36;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X20_v18-40]");
										bool flag9 = (nint)0 < (nint)8;
										object obj38 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X20_v18-40]");
										object obj39 = -8;
										bool flag10 = obj39 == null;
										object obj40 = ~obj38;
										object obj41 = obj40 | flag10;
										if (obj41 == null)
										{
											object obj42 = "Error reading data from socket: " + 2408;
											object obj43 = obj4 + 96;
											obj43 = obj42;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X20_v20-48]");
											bool flag11 = (nint)0 < (nint)9;
											object obj44 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X20_v20-48]");
											object obj45 = -9;
											bool flag12 = obj45 == null;
											object obj46 = ~obj44;
											object obj47 = obj46 | flag12;
											if (obj47 == null)
											{
												object obj48 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2072;
												object obj49 = obj4 + 104;
												obj49 = obj48;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X20_v22-50]");
												bool flag13 = (nint)0 < (nint)10;
												object obj50 = !flag13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X20_v22-50]");
												object obj51 = -10;
												bool flag14 = obj51 == null;
												object obj52 = ~obj50;
												object obj53 = obj52 | flag14;
												if (obj53 == null)
												{
													object obj54 = "Error reading data from socket: " + 2808;
													object obj55 = obj4 + 112;
													obj55 = obj54;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v24-58]");
													bool flag15 = (nint)0 < (nint)11;
													object obj56 = !flag15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X20_v24-58]");
													object obj57 = -11;
													bool flag16 = obj57 == null;
													object obj58 = ~obj56;
													object obj59 = obj58 | flag16;
													if (obj59 == null)
													{
														object obj60 = "Error reading data from socket: " + 2824;
														object obj61 = obj4 + 120;
														obj61 = obj60;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X20_v26-60]");
														bool flag17 = (nint)0 < (nint)12;
														object obj62 = !flag17;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X20_v26-60]");
														object obj63 = -12;
														bool flag18 = obj63 == null;
														object obj64 = ~obj62;
														object obj65 = obj64 | flag18;
														if (obj65 == null)
														{
															object obj66 = "startPosition" + 2632;
															object obj67 = obj4 + 128;
															obj67 = obj66;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X20_v28-68]");
															bool flag19 = (nint)0 < (nint)13;
															object obj68 = !flag19;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X20_v28-68]");
															object obj69 = -13;
															bool flag20 = obj69 == null;
															object obj70 = ~obj68;
															object obj71 = obj70 | flag20;
															if (obj71 == null)
															{
																object obj72 = "java.io.FileOutputStream" + 296;
																object obj73 = obj4 + 136;
																obj73 = obj72;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v30-70]");
																bool flag21 = (nint)0 < (nint)14;
																object obj74 = !flag21;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X20_v30-70]");
																object obj75 = -14;
																bool flag22 = obj75 == null;
																object obj76 = ~obj74;
																object obj77 = obj76 | flag22;
																if (obj77 == null)
																{
																	object obj78 = "destinationTimeZone" + 160;
																	object obj79 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
																	object obj80 = obj4 + 144;
																	obj80 = obj78;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	object obj81 = obj79;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v50+B8]");
																	object obj82 = (nint)0 + (nint)16;
																	obj82 = obj4;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v43+18]");
																	if ((nint)0 != 0)
																	{
																		object obj83 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1280;
																		object obj85 = default(object);
																		object obj84 = obj85 + 32;
																		obj84 = obj83;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		object obj86 = obj79;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v54+B8]");
																		object obj87 = (nint)0 + (nint)24;
																		obj87 = obj85;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		return;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void <ActivateConsole>b__46_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
	}

	private void <ActivateDevTesting>b__47_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
	}

	private void <FPS2>b__50_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3128;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v7+B8]");
		object obj8 = (nint)0 + (nint)8;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
