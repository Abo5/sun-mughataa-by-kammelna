using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities.Data;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TVCreateGameInvitePopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public int tvUserId;

		internal void <Show>b__0(TVCreateGameInvitePopup instance)
		{
			instance.Initialize(tvUserId);
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public int claimedTvUserId;

		public TVCreateGameInvitePopup <>4__this;

		internal void <OnClaimResponse>b__0()
		{
			SFS.TvGameCreationUnclaim(claimedTvUserId);
		}

		internal void <OnClaimResponse>b__1(CreateGamePopup createGamePopup)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_004c: Expected O, but got I
			//IL_0058: Expected O, but got I
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_00a7: Expected I, but got O
			//IL_00d6: Expected I, but got O
			//IL_0120: Expected O, but got I4
			object obj = <>4__this + 96;
			obj = createGamePopup;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)40;
			object obj4 = (nint)0 + (nint)32;
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			createGamePopup.Popup(isVoiceChatVersion: false, claimedTvUserId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(<>4__this, (IntPtr)obj3);
			createGamePopup.OnRoomCreated += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(<>4__this, (IntPtr)obj4);
			createGamePopup.OnPopupClosed += action2;
			ITrackEvent trackEvent = TrackerLibrary.TVCreateGamePopupViewed();
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
		}
	}

	private static readonly AddressReference<TVCreateGameInvitePopup> Address;

	private ComponentReference<CreateGamePopup> createGamePopupRefMobile;

	private ComponentReference<CreateGamePopup> createGamePopupRefTablet;

	private PopupUI popup;

	private TextMeshProUGUI title;

	private TextMeshProUGUI subtitle;

	private GameObject acceptButton;

	private TextMeshProUGUI rejectButtonLabel;

	private Sprite tvIcon;

	private CreateGamePopup _createGamePopup;

	private int _tvUserId;

	private Action _leave;

	public static void Show(int tvUserId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0090: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_0148: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3680;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3632;
		object obj5 = (nint)0 + (nint)2560;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj9 = (nint)0 + (nint)2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Initialize(int tvUserId)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)16;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = this + 112;
		object obj5 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ X8_v3+18] (should have been resolved before IL gen)");
		}
		_leave = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_tvUserId = tvUserId;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.TvGameCreationCheck(lifecycle, tvUserId, action);
		ITrackEvent trackEvent = TrackerLibrary.TVInviteCheckRequested();
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015f: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_01a7: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_022a: Expected I, but got O
		//IL_0264: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79C0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0125;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object createGamePopup = _createGamePopup;
		UnityEngine.Object createGamePopup2 = _createGamePopup;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0177;
		IL_01b5:
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		_createGamePopup.OnRoomCreated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)32;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		_createGamePopup.OnPopupClosed -= action2;
		Action leave = _leave;
		bool flag2 = _leave == null;
		object obj8 = !flag2;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00f4;
		IL_0091:
		bool flag3 = createGamePopup;
		bool flag4 = !flag3;
		object obj10 = !flag4;
		object obj11 = 0;
		if (obj10 == null)
		{
			goto IL_00cb;
		}
		goto IL_01b5;
		IL_00cb:
		leave = _leave;
		if (_leave != null)
		{
			goto IL_00f4;
		}
		return;
		IL_00f4:
		IntPtr invoke_impl = ((Delegate)leave).invoke_impl;
		IntPtr method_code = ((Delegate)leave).method_code;
		IntPtr method = ((Delegate)leave).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v8 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0125;
		IL_0125:
		_ = 1;
		createGamePopup = _createGamePopup;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		createGamePopup2 = _createGamePopup;
		if (obj12 != null)
		{
			goto IL_0091;
		}
		goto IL_0177;
		IL_0177:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = createGamePopup2;
		bool flag7 = !flag6;
		obj11 = 0;
		if (flag7)
		{
			goto IL_00cb;
		}
		goto IL_01b5;
	}

	private void OnCheckResponse(ISFSObject par)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004b: Expected I, but got O
		//IL_005b: Expected O, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_015d: Expected O, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04cb: Expected O, but got I4
		//IL_045c: Expected O, but got I
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected I4, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0345: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		string text = SFSExtensions.Get(par, (string)varName, (string)defaultValue);
		if (string.IsNullOrEmpty(text))
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3400;
			nint num = (nint)par;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00d7;
			}
			object obj5 = obj4 + 11;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_044c;
		}
		object obj8 = "startPosition" + 1152;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		string text2;
		if (text == (string)obj8)
		{
			object obj9 = typeof(MemberAchievementClanFeedData) + 3448;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			OnlyForSubscribersPopup.Show(TrackingFeature.KammelnaTV, tvIcon);
			trackEvent = TrackerLibrary.TVInviteSubscribersOnlyViewed();
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 != null)
			{
				goto IL_03c6;
			}
			GameObject gameObject = null;
			text2 = null;
			Sprite sprite = tvIcon;
			trackEvent2 = trackEvent;
			goto IL_03d0;
		}
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		object obj18 = "Drop Menu Toggle" + 3600;
		object buttonText = "Network Authentication Required" + 3128;
		object obj19 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)obj18, (string)message, (string)buttonText);
		return;
		IL_03c6:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_03d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_044c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v37+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X0_v37] (should have been resolved before IL gen)");
		object obj21 = default(object);
		bool canCreate = (byte)(obj21 ^ 1) != 0;
		SetupPopup(canCreate);
		popup.SlideFromBottom();
		object obj22 = obj21 & 1;
		if (obj22 != null)
		{
			trackEvent = TrackerLibrary.TVInviteBusyViewed();
			object obj23 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj13 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v3+E4]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			if (obj24 != null)
			{
				goto IL_03c6;
			}
			GameObject gameObject = null;
			Sprite sprite = null;
			trackEvent2 = trackEvent;
		}
		else
		{
			trackEvent = TrackerLibrary.TVInviteAvailableViewed();
			object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj13 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v3+E4]");
			bool flag6 = (nint)0 == 0;
			GameObject gameObject = null;
			Sprite sprite = null;
			trackEvent2 = trackEvent;
			if (!flag6)
			{
				goto IL_03c6;
			}
		}
		goto IL_03d0;
		IL_00d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_044c;
	}

	private void SetupPopup(bool canCreate)
	{
		//IL_0033: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		acceptButton.SetActive(canCreate);
		bool flag = !canCreate;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
		}
		rejectButtonLabel.color = (Color)0;
		object text = "Read object reference Id '{0}' for {1}." + 1144;
		object obj3 = "Error reading data from socket: " + 1016;
		bool flag2 = !canCreate;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		if (obj5 != null)
		{
			text = obj3;
		}
		rejectButtonLabel.text = (string)text;
		TextMeshProExtensions.Localize(rejectButtonLabel);
		object text2 = "SubscribeGroup request Error" + 2808;
		object obj6 = "Complete" + 2952;
		bool flag3 = !canCreate;
		object obj7 = !flag3;
		object obj8 = ~obj7;
		if (obj8 != null)
		{
			text2 = obj6;
		}
		title.text = (string)text2;
		TextMeshProExtensions.Localize(title);
		object text3 = "SubscribeGroup request Error" + 2800;
		object obj9 = "SubscribeGroup request Error" + 2792;
		bool flag4 = !canCreate;
		object obj10 = !flag4;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			text3 = obj9;
		}
		subtitle.text = (string)text3;
		TextMeshProExtensions.Localize(subtitle);
	}

	private void OnRoomCreated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = this + 112;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		ITrackEvent trackEvent = TrackerLibrary.TVRoomCreated(friendlyName);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	private void OnPopupClose()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)40;
		_createGamePopup.OnPopupClosed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		_createGamePopup.OnRoomCreated -= action2;
		object obj5 = this + 112;
		object obj6 = obj5;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ X8_v3+18] (should have been resolved before IL gen)");
		}
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ITrackEvent trackEvent = TrackerLibrary.TVCreateGamePopupClosed();
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void Accept()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_006b: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideToBottom();
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.TvGameCreationCheck(lifecycle, _tvUserId, action);
		ITrackEvent trackEvent = TrackerLibrary.TVInviteAcceptClicked();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnAcceptCheckResponse(ISFSObject par)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f7: Expected I, but got O
		//IL_0107: Expected O, but got I
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0456: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_03ff: Expected O, but got I4
		//IL_0408: Expected O, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0347: Expected O, but got I
		//IL_036b: Expected O, but got I4
		//IL_0383: Expected O, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0497: Expected O, but got I
		//IL_04a5: Expected I, but got O
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0546: Expected O, but got I
		//IL_0554: Expected I, but got O
		//IL_041f: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		//IL_04e2: Expected I, but got O
		//IL_04ff: Expected O, but got I4
		//IL_0508: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = "startPosition" + 1152;
		string text = SFSExtensions.Get(par, (string)varName, (string)defaultValue);
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		string text3;
		string text2;
		object obj6;
		Action action;
		if (text == (string)obj)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 3448;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			OnlyForSubscribersPopup.Show(TrackingFeature.KammelnaTV, tvIcon);
			trackEvent = TrackerLibrary.TVInviteSubscribersOnlyViewed();
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v3+E4]");
			bool flag2 = (nint)0 == 0;
			action = null;
			text2 = null;
			text3 = (string)(object)tvIcon;
			trackEvent2 = trackEvent;
			if (!flag2)
			{
				goto IL_008a;
			}
			goto IL_02f5;
		}
		bool flag3 = string.IsNullOrEmpty(text);
		bool flag4 = !flag3;
		object obj7 = 0;
		object obj8 = 0;
		object obj10;
		object obj18;
		object obj19;
		if (!flag4)
		{
			object obj9 = typeof(System.IOAsyncCallback) + 976;
			obj10 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3400;
			nint num = (nint)par;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0183;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X10_v8-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj12 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_0183;
			}
			object obj13 = obj12 + 11;
			object obj14 = num + obj13;
			object obj15 = obj14 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v44+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X0_v44] (should have been resolved before IL gen)");
			object obj16 = default(object);
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			obj8 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v44+8]");
			obj18 = 0;
			obj19 = obj10;
			if (obj17 == null)
			{
				goto IL_0399;
			}
		}
		goto IL_01e4;
		IL_0399:
		object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v21+E4]");
		object obj24;
		if ((nint)0 != 0)
		{
			bool flag6 = _createGamePopup;
			bool flag7 = !flag6;
			object obj22 = !flag7;
			object obj23 = 0;
			if (obj22 != null)
			{
				goto IL_046d;
			}
			obj24 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = _createGamePopup;
			bool flag9 = !flag8;
			object obj23 = 0;
			obj24 = 0;
			if (!flag9)
			{
				goto IL_046d;
			}
		}
		goto IL_050d;
		IL_046d:
		object obj25 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)40;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj26);
		_createGamePopup.OnRoomCreated -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)32;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj27);
		_createGamePopup.OnPopupClosed -= action3;
		obj24 = 0;
		obj18 = 0;
		goto IL_050d;
		IL_050d:
		GameObject lifecycle = base.gameObject;
		object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)24;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj29);
		SFS.TvGameCreationClaim(lifecycle, _tvUserId, action4);
		return;
		IL_01e4:
		object obj30 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = "Complete" + 2952;
		object obj34 = "SubscribeGroup request Error" + 2792;
		text3 = (string)obj34;
		object obj35 = "Network Authentication Required" + 3128;
		text2 = (string)obj35;
		PopupWindow.ShowError((string)obj33, (string)obj34, (string)obj35);
		trackEvent = TrackerLibrary.TVInviteClaimRaceLost();
		object obj36 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		obj6 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v3+E4]");
		bool flag11 = (nint)0 == 0;
		object obj37 = !flag11;
		action = null;
		trackEvent2 = trackEvent;
		if (obj37 != null)
		{
			goto IL_008a;
		}
		goto IL_02f5;
		IL_02f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_008a:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0183:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v41+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v335 @ X0_v41] (should have been resolved before IL gen)");
		object obj38 = default(object);
		bool flag12 = obj38 == null;
		obj8 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v41+8]");
		obj18 = 0;
		obj19 = obj10;
		if (!flag12)
		{
			goto IL_01e4;
		}
		goto IL_0399;
	}

	private void OnClaimResponse(ISFSObject par)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0369: Expected O, but got I
		//IL_037a: Expected I, but got O
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text = SFSExtensions.Get(par, (string)varName, (string)defaultValue);
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (string.IsNullOrEmpty(text))
		{
			_ = _tvUserId;
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2568;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj5);
			object obj6 = this + 112;
			obj6 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool isTablet = ScreenUtility.IsTablet;
			bool flag = !isTablet;
			object obj7 = !flag;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				object obj9 = 40;
			}
			else
			{
				object obj9 = 32;
			}
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2576;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj11);
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj15 = (nint)0 + (nint)2016;
			Action action3 = (Action)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
			trackEvent = TrackerLibrary.TVInviteClaimSucceeded();
			object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 != null)
			{
				goto IL_0304;
			}
			string text2 = (string)(object)action2;
			object obj19 = 0;
			trackEvent2 = trackEvent;
		}
		else
		{
			object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj22 = !flag4;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj23 = "Complete" + 2952;
			object message = "SubscribeGroup request Error" + 2792;
			object obj24 = "Network Authentication Required" + 3128;
			string text2 = (string)obj24;
			PopupWindow.ShowError((string)obj23, (string)message, (string)obj24);
			trackEvent = TrackerLibrary.TVInviteClaimError(text);
			object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj17 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v3+E4]");
			bool flag5 = (nint)0 == 0;
			Action action3 = null;
			object obj19 = 0;
			trackEvent2 = trackEvent;
			if (!flag5)
			{
				goto IL_0304;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0304:
		Tracker.DesignEvent(trackEvent);
	}

	public void Reject()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideToBottom();
		object obj2 = this + 112;
		object obj3 = obj2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ X8_v3+18] (should have been resolved before IL gen)");
		}
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ITrackEvent trackEvent = TrackerLibrary.TVInviteRejectClicked();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	static TVCreateGameInvitePopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "SubscribeGroup request Error" + 2816;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3200;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
