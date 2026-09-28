using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public static class MarketingGrantHandler
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<KammelnaResponseModel<bool>> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Redeem>b__6_0(KammelnaResponseModel<bool> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0296: Expected O, but got I
			//IL_029f: Expected O, but got I4
			//IL_0123: Expected O, but got I8
			//IL_013d: Expected O, but got I4
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_0165: Expected O, but got I4
			//IL_01a0: Expected O, but got I
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01eb: Expected O, but got I4
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected O, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02ff: Expected O, but got I4
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_00ee: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3664;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
			object obj3 = 0;
			obj3 = 0;
			ITrackEvent trackEvent;
			ITrackEvent trackEvent2;
			if (response.Succeeded)
			{
				object key = "October" + 3728;
				PlayerPrefs.DeleteKey((string)key);
				PlayerPrefs.Save();
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object title = "Complete" + 352;
				object obj7 = "LAK" + 3840;
				string text = (string)obj7;
				object obj8 = "Network Authentication Required" + 3128;
				string text2 = (string)obj8;
				PopupWindow.ShowInfo((string)title, (string)obj7, (string)obj8);
				trackEvent = TrackerLibrary.MarketingGrantRedeemed();
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 != null)
				{
					goto IL_025b;
				}
				trackEvent2 = trackEvent;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6014]");
				object obj12 = 0 + 4294953296L;
				bool flag3 = (nint)obj12 < 4;
				object obj13 = !flag3;
				object obj14 = obj12 - 4;
				bool flag4 = obj14 == null;
				object obj15 = !flag4;
				object obj16 = obj13 & obj15;
				if (obj16 == null)
				{
					object key2 = "October" + 3728;
					PlayerPrefs.DeleteKey((string)key2);
					PlayerPrefs.Save();
				}
				object obj17 = (nint)0 + (nint)1024;
				string errorMessage = response.ErrorMessage;
				object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj20 = !flag5;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError(errorMessage);
				string errorMessage2 = response.ErrorMessage;
				trackEvent = TrackerLibrary.MarketingGrantRedeemError(errorMessage2);
				object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj10 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7+E4]");
				bool flag6 = (nint)0 == 0;
				string text2 = null;
				string text = null;
				trackEvent2 = trackEvent;
				if (!flag6)
				{
					goto IL_025b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent2);
			return;
			IL_025b:
			Tracker.DesignEvent(trackEvent);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public string token;

		internal void <RedeemWhenInLobby>b__0()
		{
			Redeem(token);
		}
	}

	private const string PendingTokenKey = "PendingMarketingGrantToken";

	private static bool _redeeming;

	private static bool IsTerminalError(KammelnaError error)
	{
		//IL_0012: Expected O, but got I8
		//IL_002c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		object obj = (long)error + 4294953296L;
		bool flag = (nint)obj < 5;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}

	public static void Handle(string token)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_011c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E603A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(token);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_012a;
		IL_012a:
		object key = "October" + 3728;
		PlayerPrefs.SetString((string)key, token);
		PlayerPrefs.Save();
		RedeemWhenInLobby(token);
		return;
		IL_007d:
		if (StringsExtensions.IsNullOrEmpty(token))
		{
			return;
		}
		goto IL_012a;
	}

	public static void RedeemPendingGrant()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		object key = "October" + 3728;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = PlayerPrefs.GetString((string)key, null);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
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
		RedeemWhenInLobby(text);
	}

	private static void RedeemWhenInLobby(string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0268: Expected I, but got O
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0297: Expected O, but got I4
		//IL_0154: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj4 = obj2 + 16;
		obj4 = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v8+E4]");
		string text;
		if ((nint)0 != 0)
		{
			bool isInitialized = Config.IsInitialized;
			bool flag = !isInitialized;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_00ed;
			}
			text = token;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isInitialized2 = Config.IsInitialized;
			bool flag2 = !isInitialized2;
			text = token;
			if (!flag2)
			{
				goto IL_00ed;
			}
		}
		goto IL_0219;
		IL_0219:
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)632;
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.WaitForScene(Scenes.Menu, action);
		return;
		IL_00ed:
		object obj12 = typeof(Queue<string>) + 848;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool isConnected = sessionModel.IsConnected;
		bool flag5 = !isConnected;
		text = null;
		if (!flag5)
		{
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			bool isInLobby = sessionModel2.IsInLobby;
			bool flag7 = !isInLobby;
			text = null;
			if (!flag7)
			{
				Redeem((string)obj4);
				return;
			}
		}
		goto IL_0219;
	}

	private static void Redeem(string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0037: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00eb: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01ed: Expected O, but got I
		//IL_01fe: Expected I, but got O
		//IL_021c: Expected O, but got I
		//IL_016d: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3664;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3 & 1;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2832;
		obj3 = 1;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v5+E4]");
		object obj7;
		Action<KammelnaResponseModel<bool>> callback;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v5+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+8]");
			callback = (Action<KammelnaResponseModel<bool>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+8]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				goto IL_011b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v5+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+8]");
			callback = (Action<KammelnaResponseModel<bool>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				goto IL_011b;
			}
		}
		goto IL_0172;
		IL_011b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)624;
		Action<object> action = default(Action<object>);
		action..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v13+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		callback = action;
		goto IL_0172;
		IL_0172:
		KammelnaRequests.RedeemMarketingGrant(token, callback);
	}

	private static void ClearToken()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object key = "October" + 3728;
		PlayerPrefs.DeleteKey((string)key);
		PlayerPrefs.Save();
	}
}
