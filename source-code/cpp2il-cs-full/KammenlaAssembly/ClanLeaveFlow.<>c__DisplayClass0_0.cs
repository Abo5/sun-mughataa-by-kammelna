using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public static class ClanLeaveFlow
{
	private sealed class <>c__DisplayClass0_0
	{
		public Action onLeft;

		internal void <Run>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_003e: Expected I, but got O
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
			object obj2 = (nint)0 + (nint)632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
			action..ctor((object)null, (IntPtr)obj2);
			Leave(onLeft, (Action<KammelnaError>)(object)action);
		}

		internal void <Run>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_003e: Expected I, but got O
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
			object obj2 = (nint)0 + (nint)632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
			action..ctor((object)null, (IntPtr)obj2);
			Leave(onLeft, (Action<KammelnaError>)(object)action);
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public Action onSuccess;

		public Action<KammelnaError> onError;

		public long newOwnerId;

		internal void <TransferAndLeave>b__0(ClanResult result)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0036: Expected O, but got I4
			//IL_0069: Expected I4, but got O
			ClanResult clanResult = default(ClanResult);
			if (clanResult.Succeeded)
			{
				Leave(onSuccess, onError);
				return;
			}
			object format = "tournament_participate_warning_body_with_tickets_warning_daily" + 328;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string label = string.Format((string)format, arg);
			ReportFailure(label, (KammelnaError)clanResult, onError);
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public Action onSuccess;

		public Action<KammelnaError> onError;

		internal void <Leave>b__0(ClanResult result)
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0064: Expected I4, but got O
			ClanResult clanResult = default(ClanResult);
			if (clanResult.Succeeded)
			{
				ClanRollbackBanner.Invalidate();
				Action action = onSuccess;
				if (onSuccess != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			else
			{
				object label = "LAK" + 896;
				ReportFailure((string)label, (KammelnaError)clanResult, onError);
			}
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public int ownerId;

		internal bool <IsSoloOwner>b__0(ClanUserModel m)
		{
			//IL_005e: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (m != null)
			{
				object obj = m.UserId - ownerId;
				bool flag = obj == null;
				return !flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static void Run(ClansSerializedUtils utils, ClanModel clan, Action onLeft = null, Action<ClanModel> onClanRefreshed = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I4
		//IL_0220: Expected O, but got I4
		//IL_0229: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0272: Expected O, but got I
		//IL_0284: Expected I, but got O
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I
		//IL_02e1: Expected I, but got O
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = obj2 + 16;
		obj4 = onLeft;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = IsMyselfOwnerOf(clan);
		object obj5;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		object obj12;
		if (flag)
		{
			bool flag2 = IsSoloOwner(clan);
			obj5 = (flag2 ? 1 : 0) ^ 1;
			object role = "October" + 1640;
			object obj6 = "SetRoomVariables request error" + 1536;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				role = obj6;
			}
			trackEvent = TrackerLibrary.ClanLeaveClicked((string)role);
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_0179;
			}
			object obj11 = 0;
			trackEvent2 = trackEvent;
			obj12 = obj5;
		}
		else
		{
			object role2 = "Material with texture name \"" + 448;
			trackEvent = TrackerLibrary.ClanLeaveClicked((string)role2);
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v12+E4]");
			bool flag5 = (nint)0 == 0;
			obj5 = 1;
			object obj11 = 0;
			trackEvent2 = trackEvent;
			obj12 = 1;
			if (!flag5)
			{
				goto IL_0179;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		bool flag6 = !flag;
		object obj13 = !flag6;
		object obj14 = 0;
		obj5 = obj12;
		object obj15 = 0;
		if (obj13 != null)
		{
			goto IL_01b1;
		}
		goto IL_0248;
		IL_0179:
		Tracker.DesignEvent(trackEvent);
		bool flag7 = !flag;
		obj14 = 0;
		obj15 = 0;
		if (!flag7)
		{
			goto IL_01b1;
		}
		goto IL_0248;
		IL_0248:
		object obj16 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3888;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj17);
		object bodyKey = "java.io.FileOutputStream" + 2080;
		Action onConfirm = action;
		goto IL_035f;
		IL_035f:
		LeaveClanPopups.ShowLeaveConfirm((string)bodyKey, onConfirm);
		return;
		IL_01b1:
		object obj18 = obj5 & 1;
		if (obj18 != null)
		{
			utils.OpenLeaveClanPopup((Action)obj4, onClanRefreshed);
			return;
		}
		object obj19 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)3896;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj20);
		bodyKey = "java.io.FileOutputStream" + 2096;
		onConfirm = action2;
		goto IL_035f;
	}

	public static void TransferAndLeave(long newOwnerId, Action onSuccess, Action<KammelnaError> onError = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0114: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1568;
		object obj6 = (nint)0 + (nint)3904;
		object obj7 = obj2 + 16;
		obj7 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ClanResult> action = default(Action<ClanResult>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+20]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.TransferOwnership(0, action);
	}

	private static void LeaveAndNotify(Action onLeft)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj2 = (nint)0 + (nint)632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)null, (IntPtr)obj2);
		Leave(onLeft, (Action<KammelnaError>)(object)action);
	}

	private static void Leave(Action onSuccess, Action<KammelnaError> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_010f: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1568;
		object obj6 = (nint)0 + (nint)3912;
		object obj7 = obj2 + 16;
		obj7 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ClanResult> action = default(Action<ClanResult>);
		action..ctor(obj2, (IntPtr)obj6);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.LeaveClan(action);
	}

	private static bool IsMyselfOwnerOf(ClanModel clan)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_011b: Expected I4, but got O
		//IL_00f3: Expected O, but got I4
		if (clan != null)
		{
			ClanUserModel owner = clan.Owner;
			if (clan.Owner != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
					object obj5 = owner.UserId - intDbId;
					return obj5 == null;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		return false;
	}

	private static bool IsSoloOwner(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f4: Expected I4, but got O
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_00bd: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (clan != null)
		{
			ClanUserModel owner = clan.Owner;
			if (clan.Owner != null && obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
				object obj4 = (nint)0 + (nint)3920;
				_ = owner.UserId;
				IEnumerable<ClanUserModel> getMembers = clan.GetMembers;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				bool flag = Enumerable.Any(getMembers, func);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static void ReportFailure(string label, KammelnaError error, Action<KammelnaError> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object format = "WhiteSmoke" + 2872;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, label, arg, arg2);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object obj6 = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = text;
		}
		KLogger.LogError(obj6);
		if (onError != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onError @ X2 (System.Action`1<KammelnaError>)+18] (should have been resolved before IL gen)");
		}
	}
}
