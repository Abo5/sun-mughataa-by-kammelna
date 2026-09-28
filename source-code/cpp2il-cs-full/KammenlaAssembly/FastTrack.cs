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
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class FastTrack : MonoBehaviour
{
	public DateTimeText timeUntilNextTicket;

	public GameObject nextTicketInfo;

	public GameObject ticketsFullIndicator;

	public GameObject ticketsInfoForNewRanks;

	public GameObject ticketsNumber;

	public GameObject TicketIsNotNeeded;

	public GameObject TicketIsNeeded;

	public TextMeshProUGUI ticketPrice;

	public Button buyTicketsButton;

	public Image BuyTicketPanel;

	public Sprite ticketEmptyPanel;

	public Sprite ticketFullPanel;

	public DOTweenAnimation BuyTicketAnimation;

	public DiscreteProgressIndicator TicketsIndicator;

	public Timer matchMeTimer;

	public TextMeshProUGUI MatchingInProgressText;

	public TextMeshProUGUI FTSlogan;

	public Image RoundsBackgroundPanel;

	public GameObject HangingMatchSection;

	public GameObject ClaimRankSection;

	public GameObject StopMatchingSection;

	public GameObject FTClosedSection;

	public GameObject FTClosedForMaintenance;

	public RankUI rankAward;

	public Button continueTheCup;

	public Button matchMeButton;

	public TextMeshProUGUI openWindow;

	public DateTimeText UntilOpenDateToText;

	public DateTimeText UntilCloseDateToText;

	private GenericSoundAlbum soundAlbum;

	private bool hideMatchMeButtonOnce;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_015b: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2376;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = typeof(Queue<string>) + 848;
		GameObject popup = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = (nint)0 + (nint)2200;
		ScreenManager.PushPopup(popup, action);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if (!sessionModel.IsInLobby)
		{
			SFS.JoinLobby();
		}
	}

	private void Start()
	{
		RegisterEventsCallbacks();
		UpdateFastTrackInfo();
	}

	private void OnDestroy()
	{
		UnRegisterEventsCallbacks();
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1864;
		ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
		string command = SFSExtensions.GetCommand(evt);
		if (command == (string)obj)
		{
			BuyTicketsCallBack(responseParams);
			return;
		}
		object obj2 = "fetch_products" + 272;
		if (command == (string)obj2)
		{
			FindMatch(responseParams);
			return;
		}
		object obj3 = "m_StencilDeferredPS" + 2136;
		if (command == (string)obj3)
		{
			GoToMatch(responseParams);
			return;
		}
		object obj4 = "not" + 624;
		if (command == (string)obj4)
		{
			ParseNextStage(responseParams);
			return;
		}
		object obj5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
		if (command == (string)obj5)
		{
			ParseClaim(responseParams);
		}
	}

	private void RegisterEventsCallbacks()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_022e: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0180: Expected I, but got O
		//IL_01aa: Expected O, but got I4
		//IL_01ed: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2392;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2400;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj6 = (nint)0 + (nint)2408;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2416;
		object obj9 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse += eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinGameRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj6);
		SFS.OnJoinRoomFailed += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj10 = typeof(UsageHint) + 72;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = (nint)0 + (nint)2384;
		UserInfo.OnFastTrackRecordUpdated += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj8);
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj13);
		matchMeTimer.onTimeIsUp += action5;
	}

	private void UnRegisterEventsCallbacks()
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_022e: Expected I, but got O
		//IL_009d: Expected I, but got O
		//IL_00c8: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0180: Expected I, but got O
		//IL_01aa: Expected O, but got I4
		//IL_01ed: Expected I, but got O
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2392;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2400;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj6 = (nint)0 + (nint)2408;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2416;
		object obj9 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinGameRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj6);
		SFS.OnJoinRoomFailed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj10 = typeof(UsageHint) + 72;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = (nint)0 + (nint)2384;
		UserInfo.OnFastTrackRecordUpdated -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj8);
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj13);
		matchMeTimer.onTimeIsUp -= action5;
	}

	private void BuyTicketsCallBack(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object obj = "not" + 104;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			ResetMatchMeButton();
			NotEnoughTicketsPopup.OpenPopup();
		}
		ITrackEvent trackEvent = TrackerLibrary.FastTrackBuyTicketError(TrackingPlacement.FastTrackHome, text);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void FindMatch(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object obj = "not" + 120;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			ResetMatchMeButton();
			NotEnoughTicketsPopup.OpenPopup();
			ITrackEvent trackEvent = TrackerLibrary.FastTrackNotEnoughTickets(TrackingPlacement.FastTrackHome);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private void GoToMatch(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object obj = "rightCtrl" + 2072;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			ResetMatchMeButton();
			HideFTClosedSection();
			return;
		}
		object obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 4024;
		if (text == (string)obj2)
		{
			ShowHangingMatchSection();
			return;
		}
		object obj3 = "utf-32" + 1712;
		if (text == (string)obj3)
		{
			ResetMatchMeButton();
			object obj4 = typeof(Queue<string>) + 856;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj7 = (nint)0 + (nint)2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object serverId = ", stale={0}" + 3424;
			SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
			sfsConnectionManager.SwitchServerAndReloadScene((string)serverId);
			return;
		}
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v9+E4]");
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
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			bool flag3 = !flag2;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				return;
			}
		}
		object obj11 = "___# Content push apply failed [{0}]: {1}" + 56;
		string text2 = (string)obj11 + text;
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj15 = text2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = text2;
		}
		KLogger.LogError(obj15);
		ResetMatchMeButton();
	}

	private void OnJoinRoom(Room _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_004c: Invalid comparison between F4 and I4
		//IL_007d: Expected I4, but got F4
		//IL_00cd: Expected O, but got I4
		//IL_0070: Expected I4, but got I8
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object action = "Picking audio files is not supported on iOS" + 360;
		object type = (nint)0 + (nint)2000;
		float pastTime = matchMeTimer.PastTime;
		int seconds = (int)((pastTime != 2.139095E+09f) ? ((int)pastTime) : 2147483648L);
		ITrackEvent trackEvent = TrackerLibrary.FastTrackMatchSeconds(TrackingPlacement.FastTrackHome, seconds);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		FirebaseTrack.Event((string)action, (string)type);
	}

	private void ParseNextStage(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object obj = "setMimeType" + 3856;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			HideClaimRankSection();
			HideHangingMatchSection();
			HideStopMatchingSection();
			ResetMatchMeButton(resetHideButtonFlag: true);
		}
	}

	private void ParseClaim(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object obj = "setMimeType" + 3856;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			HideClaimRankSection();
			HideHangingMatchSection();
			HideStopMatchingSection();
			ResetMatchMeButton(resetHideButtonFlag: true);
		}
	}

	private void OnJoinRoomFailed(Room room, string s)
	{
		HideHangingMatchSection();
	}

	private void UpdateFastTrackInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		UpdateTicketsInfo();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTRoundsWon = SFSKammelnaUserExtensions.GetFTRoundsWon(localUser);
		if (fTRoundsWon == 5)
		{
			ShowClaimRankSection();
			HideFTClosedSection();
			return;
		}
		HideClaimRankSection();
		HideHangingMatchSection();
		HideStopMatchingSection();
		ResetMatchMeButton(resetHideButtonFlag: true);
		HideFTClosedSection();
	}

	private void UpdateFTCloseSection()
	{
		HideFTClosedSection();
	}

	private void ShowBuyTickets()
	{
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		Transform target = ((Component)(object)BuyTicketAnimation).transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj = (nint)0 + (nint)2776;
		object obj2 = (nint)0 + (nint)2904;
		Transform target2 = ((Component)(object)BuyTicketAnimation).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target2, 45f, 0.6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void HideBuyTickets()
	{
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		Transform target = ((Component)(object)BuyTicketAnimation).transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj = (nint)0 + (nint)2776;
		object obj2 = (nint)0 + (nint)2904;
		Transform target2 = ((Component)(object)BuyTicketAnimation).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target2, 165f, 0.6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private unsafe void UpdateTicketsInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
		//IL_0dba: Expected O, but got I
		//IL_0ddc: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00d0: Expected I, but got O
		//IL_00dd: Expected O, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_0124: Expected O, but got I
		//IL_014b: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_01b5: Expected I, but got O
		//IL_01fd: Expected O, but got I4
		//IL_0202: Expected I, but got O
		//IL_0247: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_02ae: Expected I, but got O
		//IL_02f3: Expected O, but got I4
		//IL_02fc: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_0362: Expected I, but got O
		//IL_04b0: Expected O, but got I4
		//IL_04b9: Expected O, but got I4
		//IL_04be: Expected I, but got O
		//IL_04c6: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_03db: Expected O, but got I4
		//IL_03e0: Expected I, but got O
		//IL_03e8: Expected O, but got I4
		//IL_0508: Expected O, but got I
		//IL_052a: Expected O, but got I4
		//IL_0533: Expected O, but got I4
		//IL_053d: Expected I, but got O
		//IL_0546: Expected O, but got I4
		//IL_0550: Expected I, but got O
		//IL_0560: Expected O, but got I
		//IL_05b8: Expected O, but got I4
		//IL_042a: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0455: Expected O, but got I4
		//IL_045f: Expected I, but got O
		//IL_0476: Expected O, but got I4
		//IL_0480: Expected I, but got O
		//IL_0490: Expected O, but got I
		//IL_0604: Expected I, but got O
		//IL_0645: Expected O, but got I4
		//IL_068f: Expected O, but got I4
		//IL_0694: Expected I, but got O
		//IL_06d5: Expected O, but got I4
		//IL_06da: Expected I, but got O
		//IL_071b: Expected O, but got I4
		//IL_0720: Expected I, but got O
		//IL_076e: Expected O, but got I4
		//IL_0773: Expected I, but got O
		//IL_07cb: Expected O, but got I4
		//IL_07d0: Expected I, but got O
		//IL_0821: Expected I, but got O
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09bd: Expected O, but got I4
		//IL_0c93: Expected O, but got I4
		//IL_0847: Expected O, but got I
		//IL_0869: Expected O, but got I4
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a18: Expected O, but got I
		//IL_0a3a: Expected O, but got I4
		//IL_08b1: Expected O, but got I4
		//IL_08b6: Expected I, but got O
		//IL_0a8a: Expected O, but got I4
		//IL_0a92: Expected I, but got O
		//IL_0d08: Expected I, but got O
		//IL_0908: Expected I, but got O
		//IL_0ac3: Expected O, but got I4
		//IL_0d3c: Expected O, but got I4
		//IL_0d42: Expected I, but got O
		//IL_0931: Expected O, but got I4
		//IL_0936: Expected I, but got O
		//IL_0b04: Expected O, but got I4
		//IL_096f: Expected O, but got I4
		//IL_0b2b: Expected O, but got I4
		//IL_0b67: Expected O, but got I4
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected O, but got Unknown
		//IL_0be1: Expected O, but got I4
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0c37: Invalid comparison between F8 and I8
		//IL_0c57: Expected F4, but got I4
		int num = typeof(RegisteredWaitHandle) + 56;
		TextMeshProUGUI textMeshProUGUI = ticketPrice;
		int value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (System.Int32)+E4]");
		FastTrackConfig fastTrackConfig = (FastTrackConfig)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (System.Int32)+E4]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		DateTime? dateTime = (DateTime?)(object)0;
		int num2 = 0;
		object obj2;
		object obj9;
		nint num5;
		FastTrackConfig fastTrackConfig2;
		object obj4;
		nint num3;
		if (!flag2)
		{
			fastTrackConfig = current.<FastTrack>k__BackingField;
			bool flag3 = current.<FastTrack>k__BackingField == null;
			dateTime = (DateTime?)(object)0;
			num2 = 0;
			if (!flag3)
			{
				string text = num2.ToString();
				bool flag4 = (object)ticketPrice == null;
				dateTime = (DateTime?)(object)0;
				num3 = unchecked((nint)null);
				fastTrackConfig = (FastTrackConfig)fastTrackConfig.<TicketPrice>k__BackingField;
				if (!flag4)
				{
					obj2 = typeof(Queue<string>) + 848;
					object obj3 = (nint)0 + (nint)2200;
					nint num4 = (nint)textMeshProUGUI;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
					obj4 = 0;
					ticketPrice.text = text;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v15+E4]");
					fastTrackConfig = (FastTrackConfig)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v15+E4]");
					bool flag5 = (nint)0 == 0;
					object obj6 = !flag5;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel = default(SessionModel);
					bool flag6 = (object)sessionModel == null;
					dateTime = (DateTime?)(object)0;
					num3 = (nint)text;
					if (!flag6)
					{
						User localUser = sessionModel.LocalUser;
						int fTTicketsOwned = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser);
						bool flag7 = (object)TicketsIndicator == null;
						dateTime = (DateTime?)(object)0;
						num3 = unchecked((nint)null);
						if (!flag7)
						{
							TicketsIndicator.CurrentProgress = fTTicketsOwned;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel2 = default(SessionModel);
							bool flag8 = (object)sessionModel2 == null;
							dateTime = (DateTime?)(object)0;
							obj4 = 0;
							num3 = fTTicketsOwned;
							if (!flag8)
							{
								User localUser2 = sessionModel2.LocalUser;
								int fTMaximumTicketsAllowed = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser2);
								bool flag9 = (object)TicketsIndicator == null;
								dateTime = (DateTime?)(object)0;
								obj4 = 0;
								num3 = unchecked((nint)null);
								if (!flag9)
								{
									TicketsIndicator.MaxProgress = fTMaximumTicketsAllowed;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel3 = default(SessionModel);
									bool flag10 = (object)sessionModel3 == null;
									dateTime = (DateTime?)(object)0;
									obj4 = 0;
									num3 = fTMaximumTicketsAllowed;
									if (!flag10)
									{
										User localUser3 = sessionModel3.LocalUser;
										int fTTicketsOwned2 = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser3);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
										SessionModel sessionModel4 = default(SessionModel);
										bool flag11 = (object)sessionModel4 == null;
										dateTime = (DateTime?)(object)0;
										obj4 = 0;
										num3 = unchecked((nint)null);
										if (!flag11)
										{
											User localUser4 = sessionModel4.LocalUser;
											int fTMaximumTicketsAllowed2 = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser4);
											if (fTTicketsOwned2 == fTMaximumTicketsAllowed2)
											{
												bool flag12 = (object)BuyTicketPanel == null;
												dateTime = (DateTime?)(object)0;
												obj4 = 0;
												num3 = unchecked((nint)null);
												fastTrackConfig = (FastTrackConfig)fTMaximumTicketsAllowed2;
												if (!flag12)
												{
													BuyTicketPanel.sprite = ticketFullPanel;
													HideBuyTickets();
													object obj7 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
													fastTrackConfig = (FastTrackConfig)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
													bool flag13 = (nint)0 == 0;
													object obj8 = !flag13;
													obj4 = 0;
													num3 = (nint)ticketFullPanel;
													if (obj8 == null)
													{
														obj9 = 0;
														num5 = (nint)ticketFullPanel;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
														fastTrackConfig2 = (FastTrackConfig)0;
														goto IL_056e;
													}
													goto IL_0595;
												}
											}
											else
											{
												bool flag14 = (object)BuyTicketPanel == null;
												dateTime = (DateTime?)(object)0;
												obj4 = 0;
												num3 = unchecked((nint)null);
												fastTrackConfig = (FastTrackConfig)fTMaximumTicketsAllowed2;
												if (!flag14)
												{
													BuyTicketPanel.sprite = ticketEmptyPanel;
													ShowBuyTickets();
													object obj7 = obj2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
													fastTrackConfig2 = (FastTrackConfig)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
													bool flag15 = (nint)0 == 0;
													object obj10 = !flag15;
													obj9 = 0;
													num5 = (nint)ticketEmptyPanel;
													obj4 = 0;
													num3 = (nint)ticketEmptyPanel;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v98+E4]");
													fastTrackConfig = (FastTrackConfig)0;
													if (obj10 == null)
													{
														goto IL_056e;
													}
													goto IL_0595;
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
		goto IL_0d50;
		IL_0997:
		DateTime? fTNextTicketTime;
		object obj11 = (??)fTNextTicketTime & 1;
		bool flag16 = obj11 == null;
		obj4 = 0;
		int fTTicketsOwned3;
		num = fTTicketsOwned3;
		if (!flag16)
		{
			num = (int)((nint)0 + (nint)2296);
			DateTime value2 = dateTime.Value;
			object obj12 = typeof(DataRelation) + 712;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v66+E4]");
			fastTrackConfig = (FastTrackConfig)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v66+E4]");
			bool flag17 = (nint)0 == 0;
			object obj14 = !flag17;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			bool flag18 = value2 > now;
			bool flag19 = !flag18;
			obj4 = 0;
			num3 = (nint)now;
			if (!flag19)
			{
				bool flag20 = (object)nextTicketInfo == null;
				dateTime = fTNextTicketTime;
				obj4 = 0;
				if (!flag20)
				{
					nextTicketInfo.SetActive(value: true);
					bool flag21 = (object)timeUntilNextTicket == null;
					dateTime = fTNextTicketTime;
					obj4 = 0;
					num3 = 1;
					if (!flag21)
					{
						timeUntilNextTicket.SetDate((DateTime)0);
						DateTime value3 = dateTime.Value;
						object obj15 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v76+E4]");
						bool flag22 = (nint)0 == 0;
						object obj16 = !flag22;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime now2 = DateTime.Now;
						TimeSpan timeSpan = value3 - now2;
						object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v82+E4]");
						bool flag23 = (nint)0 == 0;
						object obj19 = !flag23;
						if (obj19 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan timeSpan2 = default(TimeSpan);
						double totalSeconds = timeSpan2.TotalSeconds;
						object methodName = "Read object reference Id '{0}' for {1}." + 1112;
						double num6 = totalSeconds + 1.0;
						float time = ((totalSeconds != 9.218868437227405E+18) ? ((float)num6) : 207f);
						Invoke((string)methodName, time);
						return;
					}
				}
				goto IL_0d50;
			}
		}
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v56+E4]");
		bool flag24 = (nint)0 == 0;
		object obj21 = !flag24;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		if ((object)sessionModel5 != null)
		{
			User localUser5 = sessionModel5.LocalUser;
			bool flag25 = SFSKammelnaUserExtensions.IsNew(localUser5);
			bool flag26 = !flag25;
			num3 = unchecked((nint)null);
			GameObject gameObject;
			if (!flag26)
			{
				gameObject = ticketsInfoForNewRanks;
				bool flag27 = (object)ticketsInfoForNewRanks == null;
				object obj22 = !flag27;
				num3 = unchecked((nint)null);
				if (obj22 == null)
				{
					goto IL_0d50;
				}
			}
			else
			{
				gameObject = ticketsNumber;
				if ((object)ticketsNumber == null)
				{
					goto IL_0d50;
				}
			}
			gameObject.SetActive(value: true);
			return;
		}
		goto IL_0d50;
		IL_0595:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel6 = default(SessionModel);
		bool flag28 = (object)sessionModel6 == null;
		dateTime = (DateTime?)(object)0;
		if (!flag28)
		{
			User localUser6 = sessionModel6.LocalUser;
			fTNextTicketTime = SFSKammelnaUserExtensions.GetFTNextTicketTime(localUser6);
			bool flag29 = (object)buyTicketsButton == null;
			dateTime = fTNextTicketTime;
			num3 = unchecked((nint)null);
			if (!flag29)
			{
				buyTicketsButton.interactable = true;
				bool flag30 = (object)ticketsNumber == null;
				dateTime = fTNextTicketTime;
				obj4 = 0;
				num3 = 1;
				if (!flag30)
				{
					ticketsNumber.SetActive(value: false);
					bool flag31 = (object)nextTicketInfo == null;
					dateTime = fTNextTicketTime;
					obj4 = 0;
					num3 = unchecked((nint)null);
					if (!flag31)
					{
						nextTicketInfo.SetActive(value: false);
						bool flag32 = (object)ticketsFullIndicator == null;
						dateTime = fTNextTicketTime;
						obj4 = 0;
						num3 = unchecked((nint)null);
						if (!flag32)
						{
							ticketsFullIndicator.SetActive(value: false);
							bool flag33 = (object)ticketsInfoForNewRanks == null;
							dateTime = fTNextTicketTime;
							obj4 = 0;
							num3 = unchecked((nint)null);
							if (!flag33)
							{
								ticketsInfoForNewRanks.SetActive(value: false);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
								SessionModel sessionModel7 = default(SessionModel);
								bool flag34 = (object)sessionModel7 == null;
								dateTime = fTNextTicketTime;
								obj4 = 0;
								num3 = unchecked((nint)null);
								if (!flag34)
								{
									User localUser7 = sessionModel7.LocalUser;
									fTTicketsOwned3 = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser7);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel8 = default(SessionModel);
									bool flag35 = (object)sessionModel8 == null;
									dateTime = fTNextTicketTime;
									obj4 = 0;
									num3 = unchecked((nint)null);
									num = fTTicketsOwned3;
									if (!flag35)
									{
										User localUser8 = sessionModel8.LocalUser;
										int fTMaximumTicketsAllowed3 = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser8);
										bool flag36 = fTTicketsOwned3 < fTMaximumTicketsAllowed3;
										num3 = unchecked((nint)null);
										if (flag36)
										{
											goto IL_0997;
										}
										object obj23 = obj2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v89+E4]");
										fastTrackConfig = (FastTrackConfig)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v89+E4]");
										bool flag37 = (nint)0 == 0;
										object obj24 = !flag37;
										if (obj24 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
										SessionModel sessionModel9 = default(SessionModel);
										bool flag38 = (object)sessionModel9 == null;
										dateTime = fTNextTicketTime;
										obj4 = 0;
										num3 = unchecked((nint)null);
										num = fTTicketsOwned3;
										if (!flag38)
										{
											User localUser9 = sessionModel9.LocalUser;
											int fTMaximumTicketsAllowed4 = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser9);
											flag36 = fTMaximumTicketsAllowed4 < 1;
											num3 = unchecked((nint)null);
											if (flag36)
											{
												goto IL_0997;
											}
											bool flag39 = (object)ticketsFullIndicator == null;
											obj4 = 0;
											num3 = unchecked((nint)null);
											if (!flag39)
											{
												ticketsFullIndicator.SetActive(value: true);
												bool flag40 = (object)buyTicketsButton == null;
												obj4 = 0;
												num3 = 1;
												if (!flag40)
												{
													buyTicketsButton.interactable = false;
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
		goto IL_0d50;
		IL_056e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj9;
		num3 = num5;
		fastTrackConfig = fastTrackConfig2;
		goto IL_0595;
		IL_0d50:
		throw new NullReferenceException();
	}

	public void ShowHangingMatchSection()
	{
		//IL_00c6: Expected O, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0185: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		if (!HangingMatchSection.activeSelf)
		{
			GameObject gameObject = FTSlogan.gameObject;
			gameObject.SetActive(value: false);
			GameObject gameObject2 = matchMeButton.gameObject;
			gameObject2.SetActive(value: false);
			RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
			RectTransform rectTransform2 = RoundsBackgroundPanel.rectTransform;
			Vector2 offsetMin = rectTransform2.offsetMin;
			object obj = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			RectTransform rectTransform3 = default(RectTransform);
			Rect rect = rectTransform3.rect;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			RectTransform rectTransform4 = default(RectTransform);
			Rect rect2 = rectTransform4.rect;
			object obj7 = default(object);
			object obj6 = obj7 - obj7;
			rectTransform.offsetMin = (Vector2)0;
			HangingMatchSection.SetActive(value: true);
			ITrackEvent trackEvent = TrackerLibrary.FastTrackHasUnfinishedMatchesError();
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v13+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private void HideHangingMatchSection()
	{
		//IL_007e: Expected O, but got I4
		if (HangingMatchSection.activeSelf)
		{
			GameObject gameObject = FTSlogan.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
			Vector2 offsetMin = rectTransform.offsetMin;
			rectTransform.offsetMin = (Vector2)0;
			HangingMatchSection.SetActive(value: false);
			ResetMatchMeButton();
		}
	}

	private void ShowClaimRankSection()
	{
		//IL_002e: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_040b: Expected O, but got I4
		//IL_0434: Expected O, but got I
		//IL_0470: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		bool activeSelf = ClaimRankSection.activeSelf;
		bool flag = !activeSelf;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		if (fTLevel == 1)
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v63+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			if (fTStage == 6)
			{
				((FastTrack)fTStage).Claim();
				return;
			}
		}
		GameObject gameObject = matchMeButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = continueTheCup.gameObject;
		gameObject2.SetActive(value: true);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		int fTLevel2 = SFSKammelnaUserExtensions.GetFTLevel(localUser4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		User localUser5 = sessionModel5.LocalUser;
		int fTStage2 = SFSKammelnaUserExtensions.GetFTStage(localUser5);
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v32+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRank playerRank = PlayerRank.FastTrackAward(fTLevel2, fTStage2);
		if (rank.<Points>k__BackingField < playerRank.<Points>k__BackingField)
		{
			GameObject gameObject3 = FTSlogan.gameObject;
			gameObject3.SetActive(value: false);
			RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
			RectTransform rectTransform2 = RoundsBackgroundPanel.rectTransform;
			Vector2 offsetMin = rectTransform2.offsetMin;
			object obj13 = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			RectTransform rectTransform3 = default(RectTransform);
			Rect rect = rectTransform3.rect;
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v46+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			RectTransform rectTransform4 = default(RectTransform);
			Rect rect2 = rectTransform4.rect;
			object obj19 = default(object);
			object obj18 = obj19 - obj19;
			rectTransform.offsetMin = (Vector2)0;
			object obj20 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v52+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRank playerRank2 = PlayerRank.FastTrackClaimAward();
			rankAward.SetRank(playerRank2);
			ClaimRankSection.SetActive(value: true);
		}
	}

	private void HideClaimRankSection()
	{
		//IL_00a5: Expected O, but got I4
		GameObject gameObject = continueTheCup.gameObject;
		gameObject.SetActive(value: false);
		if (ClaimRankSection.activeSelf)
		{
			GameObject gameObject2 = FTSlogan.gameObject;
			gameObject2.SetActive(value: true);
			RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
			Vector2 offsetMin = rectTransform.offsetMin;
			rectTransform.offsetMin = (Vector2)0;
			ClaimRankSection.SetActive(value: false);
			ResetMatchMeButton();
		}
	}

	private void ShowFTCloseSection()
	{
		ShowFTCloseSection(closedIndefinitely: false);
	}

	private void ShowFTCloseSection(bool closedIndefinitely)
	{
		//IL_0127: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0274: Expected O, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		if ((object)FTClosedSection != null)
		{
			if (FTClosedSection.activeSelf)
			{
				return;
			}
			if ((object)matchMeButton != null)
			{
				GameObject gameObject = matchMeButton.gameObject;
				if ((object)gameObject != null)
				{
					gameObject.SetActive(value: false);
					if ((object)FTClosedSection != null)
					{
						FTClosedSection.SetActive(value: true);
						if ((object)FTSlogan != null)
						{
							GameObject gameObject2 = FTSlogan.gameObject;
							if ((object)gameObject2 != null)
							{
								gameObject2.SetActive(value: false);
								bool flag = !closedIndefinitely;
								object obj = 0;
								if (!flag)
								{
									if ((object)FTClosedForMaintenance == null)
									{
										goto IL_0348;
									}
									FTClosedForMaintenance.SetActive(value: true);
									obj = 0;
								}
								if ((object)RoundsBackgroundPanel != null)
								{
									RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
									if ((object)RoundsBackgroundPanel != null)
									{
										RectTransform rectTransform2 = RoundsBackgroundPanel.rectTransform;
										if ((object)rectTransform2 != null)
										{
											Vector2 offsetMin = rectTransform2.offsetMin;
											RectTransform rectTransform3 = UIExtensions.rectTransform(matchMeButton);
											if ((object)rectTransform3 != null)
											{
												Rect rect = rectTransform3.rect;
												object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
												object obj3 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v22+E4]");
												bool flag2 = (nint)0 == 0;
												object obj4 = !flag2;
												if (obj4 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												if ((object)FTClosedSection != null)
												{
													Transform transform = FTClosedSection.transform;
													if ((object)transform != null)
													{
														object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
														if (transform != obj5)
														{
															goto IL_0356;
														}
														Rect rect2 = ((RectTransform)transform).rect;
														if ((object)rectTransform != null)
														{
															rectTransform.offsetMin = (Vector2)0;
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
		goto IL_0348;
		IL_0356:
		throw new InvalidCastException();
		IL_0348:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0356;
	}

	private void HideFTClosedSection()
	{
		//IL_00a8: Expected O, but got I4
		if (FTClosedSection.activeSelf)
		{
			FTClosedSection.SetActive(value: false);
			FTClosedForMaintenance.SetActive(value: false);
			GameObject gameObject = FTSlogan.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = RoundsBackgroundPanel.rectTransform;
			Vector2 offsetMin = rectTransform.offsetMin;
			rectTransform.offsetMin = (Vector2)0;
			ResetMatchMeButton();
		}
	}

	private void ShowStopMatchingSection()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0059: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I4
		//IL_0115: Expected F4, but got I4
		object obj = (nint)0 + (nint)4040;
		object obj2 = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform rect = default(Transform);
		AnimationExtensions.AnimPulsing(rect);
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		StopMatchingSection.SetActive(value: true);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		int matchMakerTimerSeconds = current.<FastTrack>k__BackingField.MatchMakerTimerSeconds;
		matchMeTimer.StartTimer(matchMakerTimerSeconds);
	}

	private void HideStopMatchingSection()
	{
		//IL_0012: Expected O, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		if (!IsFirstTimeMatchingAfterPayingTicket())
		{
			object obj = (nint)0 + (nint)4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj2 = typeof(SqlSingle[]) + 3912;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Transform rect = default(Transform);
			AnimationExtensions.AnimEndAnimation(rect);
			StopMatchingSection.SetActive(value: false);
		}
	}

	private void ResetMatchMeButton(bool resetHideButtonFlag = false)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		if (IsFirstTimeMatchingAfterPayingTicket())
		{
			GameObject gameObject = matchMeButton.gameObject;
			gameObject.SetActive(value: false);
			if (resetHideButtonFlag)
			{
				hideMatchMeButtonOnce = false;
			}
			return;
		}
		GameObject gameObject2 = matchMeButton.gameObject;
		gameObject2.SetActive(value: true);
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser);
		bool flag2 = fTStage == 0;
		bool active = !flag2;
		TicketIsNotNeeded.SetActive(active);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int fTStage2 = SFSKammelnaUserExtensions.GetFTStage(localUser2);
		bool active2 = fTStage2 == 0;
		TicketIsNeeded.SetActive(active2);
	}

	private void ShowFTDefaultView()
	{
		HideClaimRankSection();
		HideHangingMatchSection();
		HideStopMatchingSection();
		ResetMatchMeButton(resetHideButtonFlag: true);
	}

	private bool IsFirstTimeMatchingAfterPayingTicket()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00e5: Expected I4, but got O
		if (hideMatchMeButtonOnce)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser);
				bool flag2 = fTStage == 0;
				return !flag2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private void RequestedToMatchBeforePayingTickets()
	{
		hideMatchMeButtonOnce = true;
	}

	private void CanceledMatching()
	{
		hideMatchMeButtonOnce = false;
	}

	public void MatchMe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_031a: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0367: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_03b0: Expected O, but got I
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04e7: Expected O, but got I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89E4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v47+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig currentSFS = Config.CurrentSFS;
		goto IL_0100;
		IL_0484:
		throw new NullReferenceException();
		IL_0207:
		GenericSoundAlbum genericSoundAlbum = soundAlbum;
		bool flag2 = (object)soundAlbum == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_03a4;
		}
		goto IL_0484;
		IL_03a4:
		object obj6 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		object obj7 = "___# Content push apply failed [{0}]: {1}" + 912;
		SFS.SendFindMatch(GameType.FastTrack);
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj7);
		GameObject gameObject = matchMeButton.gameObject;
		gameObject.SetActive(value: false);
		ShowStopMatchingSection();
		ITrackEvent trackEvent = TrackerLibrary.FastTrackStartMatchingClicked();
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v31+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0074:
		currentSFS = Config.CurrentSFS;
		bool flag4 = currentSFS == null;
		object obj13 = !flag4;
		if (obj13 != null)
		{
			goto IL_0100;
		}
		goto IL_0484;
		IL_0100:
		if (currentSFS.<IsFastTrack>k__BackingField)
		{
			object obj14 = typeof(Queue<string>) + 848;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.GetFTStage(localUser) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89EC]");
				object obj18 = (nint)0 & (nint)1;
				if (obj18 != null)
				{
					goto IL_0207;
				}
			}
			else
			{
				hideMatchMeButtonOnce = true;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89EC]");
				object obj19 = (nint)0 & (nint)1;
				bool flag6 = obj19 == null;
				object obj20 = !flag6;
				if (obj20 != null)
				{
					goto IL_0207;
				}
			}
			_ = 1;
			genericSoundAlbum = soundAlbum;
			goto IL_03a4;
		}
		object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = "___# Content push apply failed [{0}]: {1}" + 488;
		KLogger.LogWarning(obj24);
		object obj25 = typeof(Queue<string>) + 856;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj27 = !flag8;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj28 = (nint)0 + (nint)2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object serverId = ", stale={0}" + 3424;
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		sfsConnectionManager.SwitchServerAndReloadScene((string)serverId);
	}

	public static void SendRequestMatchMe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 912;
		SFS.SendFindMatch(GameType.FastTrack);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			KLogger.LogAnalytics(obj2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogAnalytics(obj2);
	}

	public void StopMatching()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_007c: Expected I, but got O
		//IL_0099: Expected I, but got O
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2352;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)2360;
		matchMeButton.interactable = false;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj7 = "___# Content push apply failed [{0}]: {1}" + 984;
		SFS.SendStopFindMatch(lifecycle, action, action2);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj7);
		ITrackEvent trackEvent = TrackerLibrary.FastTrackEndMatchingFromMenuClicked();
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public static void SendRequestStopMatching(GameObject lifeCycle, Action onSuccess, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 984;
		GameObject lifecycle = default(GameObject);
		Action onSuccess2 = default(Action);
		Action<string> onError2 = default(Action<string>);
		SFS.SendStopFindMatch(lifecycle, onSuccess2, onError2);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj2);
	}

	public static void SendRequestLeaveFTGame()
	{
		KGame.SendForfeitGame();
	}

	public void Claim()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0226: Expected I4, but got I8
		//IL_0255: Expected I4, but got I8
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8996]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
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
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_031b;
		IL_031b:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0158:
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			User localUser2 = sessionModel2.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int[] nearestFTAwardStage = PlayerRank.GetNearestFTAwardStage(-1);
			if (nearestFTAwardStage != null)
			{
				int[] nearestFTAwardStage2 = PlayerRank.GetNearestFTAwardStage(-1);
				if (nearestFTAwardStage2 != null)
				{
					object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					ITrackEvent trackEvent = TrackerLibrary.FastTrackClaimRankClicked(TrackingPlacement.FastTrackHome, fTLevel, fTStage, nearestFTAwardStage[0], nearestFTAwardStage2[1]);
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v8+E4]");
					if ((nint)0 != 0)
					{
						Tracker.DesignEvent(trackEvent);
						SendRequestClaim();
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Tracker.DesignEvent(trackEvent);
						SendRequestClaim();
					}
					return;
				}
			}
		}
		goto IL_031b;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_0158;
		}
		goto IL_031b;
	}

	public static void SendRequestClaim()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3392;
		object command = "fetch_products" + 1568;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = "___# Content push apply failed [{0}]: {1}" + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj3);
	}

	public void NextStage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0226: Expected I4, but got I8
		//IL_0255: Expected I4, but got I8
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8998]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
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
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_031b;
		IL_031b:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0158:
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			User localUser2 = sessionModel2.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int[] nearestFTAwardStage = PlayerRank.GetNearestFTAwardStage(-1);
			if (nearestFTAwardStage != null)
			{
				int[] nearestFTAwardStage2 = PlayerRank.GetNearestFTAwardStage(-1);
				if (nearestFTAwardStage2 != null)
				{
					object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					ITrackEvent trackEvent = TrackerLibrary.FastTrackNextStageClicked(TrackingPlacement.FastTrackHome, fTLevel, fTStage, nearestFTAwardStage[0], nearestFTAwardStage2[1]);
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v8+E4]");
					if ((nint)0 != 0)
					{
						Tracker.DesignEvent(trackEvent);
						SendRequestNextStage();
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Tracker.DesignEvent(trackEvent);
						SendRequestNextStage();
					}
					return;
				}
			}
		}
		goto IL_031b;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_0158;
		}
		goto IL_031b;
	}

	public static void SendRequestNextStage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "not" + 624;
		object command = "fetch_products" + 1568;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = "___# Content push apply failed [{0}]: {1}" + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj3);
	}

	public void WatchRoom()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 1224;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Return);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj2);
		ITrackEvent trackEvent = TrackerLibrary.FastTrackWatchUnfinishedMatchClicked();
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void ForfeitGame()
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = "___# Content push apply failed [{0}]: {1}" + 920;
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Forfeit);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj3);
		HideHangingMatchSection();
		ITrackEvent trackEvent = TrackerLibrary.FastTrackForfeitClicked();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public static void SendRequestForfeitGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 920;
		SFS.SendLockedRoomRequest(LockedRoomRequestSubCommand.Forfeit);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			KLogger.LogAnalytics(obj2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogAnalytics(obj2);
	}

	public void BuyTickets()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_0378: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_0485: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89EA]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v46+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0343:
		Store.BuyFTTicket();
		return;
		IL_0137:
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		bool flag4 = aces < <FastTrack>k__BackingField.<TicketPrice>k__BackingField;
		object obj10 = 0;
		if (!flag4)
		{
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int fTTicketsOwned = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			int fTMaximumTicketsAllowed = SFSKammelnaUserExtensions.GetFTMaximumTicketsAllowed(localUser3);
			bool flag6 = fTTicketsOwned >= fTMaximumTicketsAllowed;
			obj10 = 0;
			if (!flag6)
			{
				object obj13 = 152993792;
				object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89EB]");
				object obj15 = (nint)0 & (nint)1;
				if (obj15 != null)
				{
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v34+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0343;
					}
				}
				else
				{
					_ = 1;
					object obj16 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v34+E4]");
					bool flag7 = (nint)0 == 0;
					object obj17 = !flag7;
					if (obj17 != null)
					{
						goto IL_0343;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Store.BuyFTTicket();
				return;
			}
		}
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel4 = default(SessionModel);
		User localUser4 = sessionModel4.LocalUser;
		int aces2 = SFSKammelnaUserExtensions.GetAces(localUser4);
		object obj20 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v17+E4]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current2 = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField2 = current2.<FastTrack>k__BackingField;
		if (aces2 < <FastTrack>k__BackingField2.<TicketPrice>k__BackingField)
		{
			NotEnoughTicketsPopup.OpenPopup();
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel == null;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private static void SendRequestBuyTickets()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89EB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Store.BuyFTTicket();
		return;
		IL_0074:
		Store.BuyFTTicket();
	}

	public void RefreshTickets()
	{
		SendRequestRefreshTickets();
	}

	private static void SendRequestRefreshTickets()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "placementId" + 2792;
		object command = "fetch_products" + 1568;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = "___# Content push apply failed [{0}]: {1}" + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj3);
	}

	public void GoBackToMenu()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(Queue<string>) + 856;
		ITrackEvent trackEvent = TrackerLibrary.FastTrackBackToMainMenuClicked();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2216;
		Tracker.DesignEvent(trackEvent);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object serverId = ", stale={0}" + 3424;
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		sfsConnectionManager.SwitchServerAndReloadScene((string)serverId);
	}

	public void TrackFastTrackLogoClicks()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E899D]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			trackEvent = TrackerLibrary.FastTrackLogoClicked();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.FastTrackLogoClicked();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_008e:
		Tracker.DesignEvent(trackEvent);
	}

	public void MatchMeTimerIsUp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E899E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_0100:
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		int matchMakerTimerSeconds = current.<FastTrack>k__BackingField.MatchMakerTimerSeconds;
		ITrackEvent trackEvent = TrackerLibrary.FastTrackUnmatchedAfterTimeUp(TrackingPlacement.FastTrackHome, matchMakerTimerSeconds);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0074:
		current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0100;
	}

	private void PlaySound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void <StopMatching>b__65_0()
	{
		matchMeButton.interactable = true;
		hideMatchMeButtonOnce = false;
		HideStopMatchingSection();
		ResetMatchMeButton();
	}

	private void <StopMatching>b__65_1(string error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, 10f, action);
	}

	private void <StopMatching>b__65_2()
	{
		matchMeButton.interactable = true;
	}
}
