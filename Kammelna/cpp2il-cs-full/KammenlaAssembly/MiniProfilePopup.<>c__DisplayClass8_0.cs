using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MiniProfilePopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass8_0
	{
		public string dbId;

		internal void <Show>b__0(MiniProfilePopup instance)
		{
			instance.Populate(dbId);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public PlayerProfileModel model;

		internal void <Show>b__0(MiniProfilePopup instance)
		{
			instance.Populate(model);
		}
	}

	private static readonly AddressReference<MiniProfilePopup> Address;

	private static TrackingPlacement _trackingPlacement;

	private PopupUI popup;

	private PlayerProfileControls profile;

	private PlayerProfileControls celebrationProfile;

	private CanvasGroup blockerGroup;

	private RotatingLoadingIndicator loadingIndicator;

	private string _userDbId;

	public static void Show(string dbId, TrackingPlacement placement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_04e6: Expected O, but got I
		//IL_04f6: Expected O, but got I
		//IL_0525: Expected O, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0141: Expected O, but got I4
		//IL_0379: Expected I8, but got I4
		//IL_0398: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_029c: Expected I8, but got I4
		//IL_02b4: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_059f: Expected O, but got I
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_05c9: Expected O, but got I
		//IL_05da: Expected I, but got O
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0618: Expected O, but got I4
		//IL_0543: Expected O, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0581: Expected O, but got I4
		//IL_0422: Expected O, but got I
		//IL_0444: Expected O, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 840;
		object obj4 = typeof(Queue<string>) + 848;
		object obj5 = obj2 + 16;
		obj5 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		object obj8 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v9+B8]");
		object obj9 = 0;
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId2 = SFSKammelnaUserExtensions.GetDbId(localUser);
		if ((string)obj5 == dbId2)
		{
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v50+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			string dbId3 = SFSKammelnaUserExtensions.GetDbId(localUser2);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v40+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v40+B8]");
			object obj16 = 0;
			object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v44+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v41+8]");
			PlayerProfile.ShowDetailProfile(dbId3, TrackingPlacement.Background);
			PreloadProfilePopups();
			return;
		}
		object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Convert.ToInt32((string)obj5);
		object obj23 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = FriendsManager.IsBlocked(num);
			bool flag8 = !flag7;
			object obj25 = 0;
			object obj26 = 0;
			if (!flag8)
			{
				goto IL_02cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = FriendsManager.IsBlocked(num);
			bool flag10 = !flag9;
			object obj27 = !flag10;
			object obj25 = 0;
			object obj26 = 0;
			if (obj27 != null)
			{
				goto IL_02cb;
			}
		}
		object obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v25+E4]");
		bool flag11 = (nint)0 == 0;
		object obj29 = !flag11;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X0_v25+B8]");
		object obj30 = 0;
		object obj31 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = (nint)0 + (nint)1944;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj32);
		object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v28+E4]");
		bool flag12 = (nint)0 == 0;
		object obj35 = !flag12;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj36 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		object obj37 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v24+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v25+8]");
		ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileViewed(TrackingPlacement.Background);
		object obj39 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v28+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_02cb:
		object obj41 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v43+E4]");
		bool flag13 = (nint)0 == 0;
		object obj43 = !flag13;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object title = "Unsupported map type" + 608;
		object message = "Cannot populate JSON object onto type '{0}'." + 1160;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	public static void Show(PlayerProfileModel model, TrackingPlacement placement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_04ea: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0276: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_0569: Expected I8, but got I
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0379: Expected I8, but got I4
		//IL_0398: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_029c: Expected I8, but got I4
		//IL_02b4: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_050c: Expected O, but got I
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_054a: Expected O, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_05be: Expected O, but got I
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_05e8: Expected O, but got I
		//IL_05f9: Expected I, but got O
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0637: Expected O, but got I4
		//IL_0422: Expected O, but got I
		//IL_0444: Expected O, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 840;
		object obj4 = obj2 + 16;
		obj4 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v9+B8]");
		object obj7 = 0;
		object obj8 = obj4;
		object obj9 = typeof(Queue<string>) + 848;
		object obj10 = (nint)0 + (nint)2200;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6+68]");
		if ((nint)0 == intDbId)
		{
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v49+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser2);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v42+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v42+B8]");
			object obj17 = 0;
			object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v46+E4]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v43+8]");
			PlayerProfile.ShowDetailProfile(dbId, TrackingPlacement.Background);
			PreloadProfilePopups();
			return;
		}
		object obj21 = obj4;
		object obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+68]");
		int num = Convert.ToInt32(0L);
		object obj25 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = FriendsManager.IsBlocked(num);
			bool flag8 = !flag7;
			object obj27 = 0;
			object obj28 = 0;
			if (!flag8)
			{
				goto IL_02cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = FriendsManager.IsBlocked(num);
			bool flag10 = !flag9;
			object obj29 = !flag10;
			object obj27 = 0;
			object obj28 = 0;
			if (obj29 != null)
			{
				goto IL_02cb;
			}
		}
		object obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v22+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v22+B8]");
		object obj32 = 0;
		object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)1952;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj34);
		object obj35 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v25+E4]");
		bool flag12 = (nint)0 == 0;
		object obj37 = !flag12;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj38 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		object obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v26+B8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v27+8]");
		ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileViewed(TrackingPlacement.Background);
		object obj41 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v30+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_02cb:
		object obj43 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v40+E4]");
		bool flag13 = (nint)0 == 0;
		object obj45 = !flag13;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object title = "Unsupported map type" + 608;
		object message = "Cannot populate JSON object onto type '{0}'." + 1160;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	private void Populate(string dbId)
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_001f: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_0101: Expected I, but got O
		//IL_012b: Expected O, but got I4
		object obj = this + 72;
		obj = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v3-28]");
		((PopupUI)0).PopFromCenter(1f);
		StartLoading();
		GameObject gameObject = profile.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = celebrationProfile.gameObject;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj3 = (nint)0 + (nint)2944;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
		object obj5 = (nint)0 + (nint)2952;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		gameObject2.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action, (Action<KammelnaError>)(object)action2);
	}

	private void Populate(PlayerProfileModel model)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		long num = default(long);
		string text = num.ToString();
		object obj = this + 72;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X21_v4-28]");
		((PopupUI)0).PopFromCenter(1f);
		GameObject gameObject = profile.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = celebrationProfile.gameObject;
		gameObject2.SetActive(value: false);
		StopLoading();
		UserAchievementModel monthlyTrophy = model.GetMonthlyTrophy();
		if (monthlyTrophy == null)
		{
			object obj2 = 40;
		}
		else
		{
			object obj2 = 48;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniProfilePopup)+v110 @ X8_v6]");
		GameObject gameObject3 = ((UnityEngine.Component)0).gameObject;
		object obj3 = typeof(MemberAchievementClanFeedData) + 840;
		gameObject3.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MiniProfilePopup)+v110 @ X8_v6]");
		((PlayerProfileControls)0).Populate(model);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			PreloadProfilePopups();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PreloadProfilePopups();
	}

	private void StartLoading()
	{
		int num = ShortcutExtensions.DOKill(blockerGroup);
		GameObject gameObject = blockerGroup.gameObject;
		gameObject.SetActive(value: true);
		blockerGroup.alpha = 1f;
		loadingIndicator.StartLoading();
	}

	private void ShowError(KammelnaError error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		popup.ShrinkToParent(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(friendlyName);
	}

	private void StopLoading()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2480;
		int num = ShortcutExtensions.DOKill(blockerGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(blockerGroup, 0f, 0.3f);
		TweenCallback tweenCallback = TweenHelpers.Disable(blockerGroup);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		loadingIndicator.FinishLoading();
	}

	public void ShowFullProfile()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I
		//IL_0130: Expected O, but got I4
		//IL_0076: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		popup.ShrinkToParent(null);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		TrackingPlacement placement;
		TrackingPlacement trackingPlacement;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+8]");
			placement = TrackingPlacement.Background;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+8]");
			trackingPlacement = TrackingPlacement.Background;
			if (!flag)
			{
				goto IL_00c3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+8]");
			placement = TrackingPlacement.Background;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+8]");
			trackingPlacement = TrackingPlacement.Background;
			if (obj8 != null)
			{
				goto IL_00c3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		placement = trackingPlacement;
		goto IL_00c3;
		IL_00c3:
		PlayerProfile.ShowDetailProfile(_userDbId, placement);
	}

	public void Hide()
	{
		popup.ShrinkToParent(null);
	}

	private static void PreloadProfilePopups()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			object obj2 = "Picking audio files is not supported on iOS" + 400;
			object obj3 = array + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			List<string> labels = AddressablesUtil.GetLabels(array);
			AddressablesUtil.PreloadAssets(labels);
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	static MiniProfilePopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Material with texture name \"" + 1624;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3072;
		object obj3 = typeof(MemberAchievementClanFeedData) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
