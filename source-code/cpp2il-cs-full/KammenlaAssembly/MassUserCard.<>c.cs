using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MassUserCard : MassWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<LeaderBoardPlayer, bool> <>9__34_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe bool <Success>b__34_0(LeaderBoardPlayer p)
		{
			//IL_010e: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected I4, but got Unknown
			//IL_006a: Expected O, but got I4
			if (p != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				int num = p + 44;
				string text = ((int*)num)->ToString();
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v6+E4]");
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
					string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
					if (text != null)
					{
						return text.Equals(dbId);
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private MassStagePointsWidget stagePoints;

	private GameObject tries;

	private Button stagesButt;

	private Button leaderBoardButt;

	private GameObject extraTxtDeep;

	private TextMeshProUGUI eligibilityInstructionsTxt;

	private TournamentEligibilityIndicator eligibilityIndicator;

	private TextMeshProUGUI participationIdLabel;

	private DiscreteProgressIndicator triesIndicator;

	private DateTimeText timeTillNextTicket;

	private MassEligibilityInfoPopup _eligibilityInfoPopup;

	private MassTournamentPlayerState _playerState;

	private bool HasMaxTries
	{
		get
		{
			//IL_00eb: Expected I4, but got O
			//IL_007c: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00b9: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00d8: Expected I4, but got O
			if ((object)_connector != null)
			{
				MassEventStageViewModel activeStage = _connector.GetActiveStage();
				if (activeStage != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (Server.Models.MassEventStageViewModel)+24]");
					bool flag = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (Server.Models.MassEventStageViewModel)+24]");
					bool flag2 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (Server.Models.MassEventStageViewModel)+24]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (Server.Models.MassEventStageViewModel)+24]");
					object obj = num ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (Server.Models.MassEventStageViewModel)+24]");
					object obj2 = 0 & obj;
					bool flag3 = (nint)obj2 < 0;
					bool flag4 = flag == flag3;
					object obj3 = !flag2;
					object obj4 = flag4 & obj3;
					return (byte)(obj4 & (object?)activeStage.<MaxTrails>k__BackingField) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool IsNotLastStage
	{
		get
		{
			//IL_00b4: Expected I4, but got O
			//IL_0075: Expected O, but got I4
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			if ((object)_connector != null)
			{
				int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
				MassEventModel tournamentData = TournamentData;
				if (TournamentData != null)
				{
					List<MassEventStageViewModel> <Stages>k__BackingField = tournamentData.<Stages>k__BackingField;
					if (tournamentData.<Stages>k__BackingField != null)
					{
						object obj = activeStageId + 1;
						object obj2 = obj - <Stages>k__BackingField._size;
						bool flag = obj2 == null;
						return !flag;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	protected override void Initialize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0050: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00e9: Expected I, but got O
		//IL_00ff: Expected O, but got I
		GameObject gameObject = base.gameObject;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3688;
		gameObject.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged += action;
		Button button = stagesButt;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj4 = (nint)0 + (nint)3704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj4);
		button.m_OnClick.AddListener(unityAction);
		MassTournamentServerConnector connector = _connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		object obj5 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged -= action;
	}

	public void ShowEligibilityInfoPopup()
	{
		MassEligibilityInfoPopup eligibilityInfoPopup = _eligibilityInfoPopup;
		eligibilityInfoPopup.popup.PopFromCenter();
	}

	private void stagesClicked()
	{
		eventChannel.TriggerStagesButtonClicked();
	}

	private void Reload(MassTournamentPlayerState player)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		object obj = this + 144;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Component component;
		if (player.<IsRegistered>k__BackingField)
		{
			MassTournamentServerConnector massTournamentServerConnector = default(MassTournamentServerConnector);
			int activeStageId = massTournamentServerConnector.GetActiveStageId();
			if (player.<LastStageReached>k__BackingField >= activeStageId || player.<NextStageEligibility>k__BackingField == MassEventNextStageEligibility.EligibleToReserve)
			{
				_eligibilityInfoPopup.PopulateEligibilityInfoBubble(_connector);
				GameObject gameObject = base.gameObject;
				gameObject.SetActive(value: true);
				SetCard();
				MassEventStageViewModel upcomingStage = _connector.GetUpcomingStage();
				if (upcomingStage != null)
				{
					return;
				}
				component = stagePoints;
				bool flag = (object)stagePoints == null;
				object obj2 = !flag;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0157;
			}
		}
		component = this;
		goto IL_0157;
		IL_0157:
		GameObject gameObject2 = component.gameObject;
		gameObject2.SetActive(value: false);
	}

	private bool TournamentIsWaiting(MassTournamentPlayerState player)
	{
		//IL_00db: Expected I4, but got O
		//IL_00a2: Expected O, but got I4
		if (player != null)
		{
			if (!player.<IsRegistered>k__BackingField)
			{
				return true;
			}
			if ((object)_connector != null)
			{
				int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
				if (player.<LastStageReached>k__BackingField < activeStageId)
				{
					object obj = player.<NextStageEligibility>k__BackingField - 2;
					bool flag = obj == null;
					return !flag;
				}
				return false;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void SetCard()
	{
		MassTournamentPlayerState playerState = _playerState;
		if (playerState.<IsRegistered>k__BackingField)
		{
			SetWidgetArea();
			FillEligibilityInstructionText();
			HandleExtraText();
			if (_connector.IsWaitingToStart())
			{
				ShowCardAsWaitingToStart();
			}
			else
			{
				ShowCardStartedView();
			}
		}
	}

	private void SetWidgetArea()
	{
		//IL_00be: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		MassTournamentPlayerState playerState = _playerState;
		participationIdLabel.SetText(playerState.<UniqueId>k__BackingField);
		MassTournamentPlayerState playerState2 = _playerState;
		int activeStageId = ((MassTournamentServerConnector)(object)participationIdLabel).GetActiveStageId();
		MassEventStageViewModel activeStage = _connector.GetActiveStage();
		MassEventStageViewModel activeStage2 = _connector.GetActiveStage();
		int activeStageId2 = ((MassTournamentServerConnector)(object)activeStage2).GetActiveStageId();
		MassEventModel tournamentData = TournamentData;
		List<MassEventStageViewModel> <Stages>k__BackingField = tournamentData.<Stages>k__BackingField;
		MassTournamentPlayerState playerState3 = _playerState;
		object obj = activeStageId2 + 1;
		object obj2 = obj - <Stages>k__BackingField._size;
		bool flag = obj2 == null;
		bool isNotLastStage = !flag;
		stagePoints.SetWidget(playerState2.<ChampionshipPoints>k__BackingField, activeStageId, activeStage.<Type>k__BackingField, activeStage2.<FilterValue>k__BackingField, isNotLastStage, playerState3.<NextStageEligibility>k__BackingField);
		MassTournamentPlayerState playerState4 = _playerState;
		SetTries(playerState4.<TriesLeft>k__BackingField);
		eligibilityIndicator.Initialize(_playerState);
	}

	private void SetTextArea()
	{
		FillEligibilityInstructionText();
		HandleExtraText();
	}

	private void FillEligibilityInstructionText()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_018f: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_0237: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6102]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v31+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v31+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		bool flag3 = TournamentStatusExtensions.IsFinished(tournamentStatus);
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			Room currentRoom2 = sessionModel2.CurrentRoom;
			TournamentStatus tournamentStatus2 = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
			bool flag6 = TournamentStatusExtensions.IsScheduled(tournamentStatus2);
			bool flag7 = !flag6;
			obj9 = 0;
			if (flag7)
			{
				CraftInstructionsText(_playerState);
				return;
			}
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		TournamentStatus tournamentStatus3 = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom3);
		if (TournamentStatusExtensions.IsScheduled(tournamentStatus3))
		{
			object text = "ThisIsFakeReceiptData" + 1264;
			TextMeshProExtensions.Localize(eligibilityInstructionsTxt, (string)text);
		}
		else
		{
			CraftEndOfTournamentText();
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag9 = (object)sessionModel == null;
		object obj14 = !flag9;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void HandleExtraText()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		MassTournamentPlayerState playerState = _playerState;
		bool active;
		if (playerState.<TriesLeft>k__BackingField > 0)
		{
			bool flag = (object)extraTxtDeep == null;
			object obj = !flag;
			active = false;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			MassEventStageViewModel activeStage = _connector.GetActiveStage();
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = playerState.<NextTicketTime>k__BackingField < activeStage.<FinishDate>k__BackingField;
			active = flag3;
		}
		extraTxtDeep.SetActive(active);
		MassTournamentPlayerState playerState2 = _playerState;
		if (playerState2.<TriesLeft>k__BackingField > 0)
		{
			return;
		}
		MassEventStageViewModel activeStage2 = _connector.GetActiveStage();
		object obj5 = typeof(DataRelation) + 712;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			if (!(playerState2.<NextTicketTime>k__BackingField < activeStage2.<FinishDate>k__BackingField))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = playerState2.<NextTicketTime>k__BackingField < activeStage2.<FinishDate>k__BackingField;
			bool flag5 = !flag4;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				return;
			}
		}
		MassTournamentPlayerState playerState3 = _playerState;
		timeTillNextTicket.SetDate(playerState3.<NextTicketTime>k__BackingField);
	}

	private void SetTries(int triesLeft)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01ea: Expected I4, but got O
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6103]");
		object obj2 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject gameObject2;
		if (obj2 != null)
		{
			gameObject = tries;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6100]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			gameObject2 = tries;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			gameObject = tries;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6100]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			gameObject2 = tries;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		MassTournamentServerConnector connector = _connector;
		gameObject = gameObject2;
		goto IL_0131;
		IL_0131:
		MassEventStageViewModel activeStage = connector.GetActiveStage();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Server.Models.MassEventStageViewModel)+24]");
		bool flag3 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Server.Models.MassEventStageViewModel)+24]");
		bool flag4 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Server.Models.MassEventStageViewModel)+24]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Server.Models.MassEventStageViewModel)+24]");
		object obj6 = num ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Server.Models.MassEventStageViewModel)+24]");
		object obj7 = 0 & obj6;
		bool flag5 = (nint)obj7 < 0;
		bool flag6 = flag3 == flag5;
		object obj8 = !flag4;
		object obj9 = flag6 & obj8;
		bool active = (byte)(obj9 & (object?)activeStage.<MaxTrails>k__BackingField) != 0;
		gameObject.SetActive(active);
		MassEventStageViewModel activeStage2 = _connector.GetActiveStage();
		DiscreteProgressIndicator discreteProgressIndicator = triesIndicator;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v7 (Server.Models.MassEventStageViewModel)+24]");
		discreteProgressIndicator.MaxProgress = 0;
		triesIndicator.CurrentProgress = triesLeft;
		return;
		IL_0083:
		connector = _connector;
		bool flag7 = (object)_connector == null;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0131;
	}

	private void HandleIsWaitingToStartState()
	{
		if (_connector.IsWaitingToStart())
		{
			ShowCardAsWaitingToStart();
		}
		else
		{
			ShowCardStartedView();
		}
	}

	private void ShowCardAsWaitingToStart()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0105: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0142: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01eb: Expected I, but got O
		//IL_0215: Expected O, but got I4
		GameObject gameObject = stagePoints.gameObject;
		gameObject.SetActive(value: false);
		tries.SetActive(value: false);
		GameObject gameObject2 = leaderBoardButt.gameObject;
		gameObject2.SetActive(value: false);
		eligibilityIndicator.InitializeAsRegistered();
		GameObject gameObject3 = stagesButt.gameObject;
		gameObject3.SetActive(value: true);
		MassEventStageViewModel activeStage = _connector.GetActiveStage();
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3664;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = activeStage.<StartingDate>k__BackingField - now;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v25+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)totalSeconds, action);
	}

	private void ShowCardStartedView()
	{
		GameObject gameObject = stagePoints.gameObject;
		gameObject.SetActive(value: true);
		tries.SetActive(value: true);
		GameObject gameObject2 = leaderBoardButt.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = stagesButt.gameObject;
		gameObject3.SetActive(value: false);
	}

	private void CraftScheduledTournamentText()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "ThisIsFakeReceiptData" + 1264;
		TextMeshProExtensions.Localize(eligibilityInstructionsTxt, (string)text);
	}

	private void CraftEndOfTournamentText()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2408;
		object obj2 = (nint)0 + (nint)3680;
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2392;
		object obj4 = (nint)0 + (nint)3696;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentError tournamentError = default(SFS.TournamentError);
		tournamentError..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.MassWinnersListSuccess massWinnersListSuccess = default(SFS.MassWinnersListSuccess);
		massWinnersListSuccess..ctor(this, (IntPtr)obj4);
		SFS.GetMassWinnersList(lifecycle, tournamentError, massWinnersListSuccess);
	}

	private void OnError(string error)
	{
		GameObject gameObject = eligibilityInstructionsTxt.gameObject;
		gameObject.SetActive(value: false);
	}

	private unsafe void Success(List<MassEventWinner> l)
	{
		//IL_03ba: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_039b: Expected O, but got I4
		//IL_0495: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0220: Expected O, but got I4
		//IL_051a: Expected I, but got O
		//IL_0538: Expected O, but got I
		//IL_0257: Expected O, but got I4
		//IL_025f: Expected O, but got Ref
		//IL_01b7: Expected O, but got I
		//IL_0284: Expected O, but got Ref
		//IL_03ff: Expected O, but got I4
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		List<MassEventWinner> list = default(List<MassEventWinner>);
		if (list != null)
		{
			object obj = (nint)0 + (nint)3304;
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3192;
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2248;
			object obj4 = (nint)0 + (nint)1048;
			object obj5 = (nint)0 + (nint)2656;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			object obj6 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			while (true)
			{
				list = (List<MassEventWinner>)obj;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				object obj8;
				Func<object, bool> predicate;
				if (obj6 != null)
				{
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v47+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v47+B8]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+8]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+8]");
						bool flag = (nint)0 == 0;
						object obj9 = !flag;
						if (obj9 == null)
						{
							goto IL_0165;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj7 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v47+B8]");
						obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+8]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+8]");
						bool flag2 = (nint)0 == 0;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							goto IL_0165;
						}
					}
					goto IL_01bc;
				}
				goto IL_0379;
				IL_0165:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v47+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v37+B8]");
					obj8 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func..ctor(obj8, (IntPtr)obj4);
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v36+B8]");
				object obj14 = (nint)0 + (nint)8;
				obj14 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
				goto IL_01bc;
				IL_01bc:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ stack_-88+20]");
				if (!Enumerable.Any((IEnumerable<object>)0, predicate))
				{
					continue;
				}
				goto IL_01f2;
			}
			enumerator2.Dispose();
			goto IL_0355;
		}
		NullReferenceException ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		goto IL_03bf;
		IL_03bf:
		NullReferenceException ex2 = new NullReferenceException();
		List<object>.Enumerator enumerator3 = enumerator2;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		goto IL_0448;
		IL_0379:
		NullReferenceException ex4 = new NullReferenceException();
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		enumerator3 = enumerator4;
		List<object>.Enumerator enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		ex3 = (OutOfMemoryException)(object)ex4;
		goto IL_0448;
		IL_0355:
		object text = "HH:mm:ss.ffZ" + 848;
		TextMeshProExtensions.Localize(eligibilityInstructionsTxt, (string)text);
		return;
		IL_0448:
		bool flag4 = (nint)list != 1;
		OutOfMemoryException ex5 = ex3;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj15 = (nint)0 + (nint)3296;
			list = (List<MassEventWinner>)obj15;
			enumerator3.Dispose();
			object obj16 = default(object);
			if (obj16 == null)
			{
				goto IL_0355;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj16;
			ex5 = ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237294");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_01f2:
		object obj17 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag5 = array == null;
		enumerator2 = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		object obj19 = default(object);
		list = (List<MassEventWinner>)(&obj19);
		if (flag5)
		{
			goto IL_03bf;
		}
		object obj20 = default(object);
		bool flag6 = obj20 == null;
		list = (List<MassEventWinner>)(&obj19);
		if (!flag6)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
			list = (List<MassEventWinner>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj21 = default(object);
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
				ex3 = new OutOfMemoryException();
				enumerator3 = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				list = null;
				goto IL_0448;
			}
		}
		if (array.Length != 0)
		{
			object obj22 = array + 32;
			obj22 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text2 = "Complete" + 320;
			TextMeshProExtensions.Localize(eligibilityInstructionsTxt, (string)text2, array);
			enumerator2.Dispose();
			return;
		}
		IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
		enumerator3 = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		ex3 = (OutOfMemoryException)(object)ex7;
		goto IL_0448;
	}

	private void CraftInstructionsText(MassTournamentPlayerState player)
	{
		//IL_004c: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_043c: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0996: Expected O, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected O, but got Unknown
		//IL_05d7: Expected O, but got I4
		//IL_04c1: Expected I, but got O
		//IL_04d1: Expected O, but got I
		//IL_04fa: Expected O, but got I
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0645: Expected O, but got I4
		//IL_064a: Expected I, but got O
		//IL_0a1b: Expected I, but got O
		//IL_0a2b: Expected O, but got I
		//IL_0a54: Expected O, but got I
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0676: Expected I, but got O
		//IL_027b: Expected I, but got O
		//IL_028b: Expected O, but got I
		//IL_02b4: Expected O, but got I
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0b1b: Expected O, but got I4
		//IL_06c5: Expected O, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0b54: Expected I8, but got I4
		//IL_0b6f: Expected O, but got I4
		//IL_06ff: Expected I, but got O
		//IL_0be5: Expected O, but got I8
		//IL_0bf9: Expected I, but got O
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Expected O, but got Unknown
		//IL_0c8d: Expected O, but got I4
		//IL_0b85: Expected I, but got O
		//IL_0b95: Expected O, but got I
		//IL_0bb3: Expected I, but got O
		//IL_0bc3: Expected O, but got I
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_0817: Expected O, but got I4
		//IL_0736: Expected I, but got O
		//IL_0743: Expected I, but got O
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0d12: Expected I, but got O
		//IL_0d22: Expected O, but got I
		//IL_0d4b: Expected O, but got I
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected O, but got Unknown
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected O, but got Unknown
		//IL_08a4: Expected I, but got O
		//IL_08b4: Expected O, but got I
		//IL_08e5: Expected O, but got I
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		bool flag = (object)_connector == null;
		MassTournamentPlayerState massTournamentPlayerState = player;
		TextMeshProUGUI textMesh;
		object text;
		object[] formattedArguments;
		nint num3;
		object text2;
		nint num2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
			MassEventModel tournamentData = TournamentData;
			bool flag2 = TournamentData == null;
			massTournamentPlayerState = player;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)1712;
				massTournamentPlayerState = (MassTournamentPlayerState)obj;
				object obj2 = Enumerable.Last((IEnumerable<object>)tournamentData.<Stages>k__BackingField);
				if (obj2 != null && (object)_connector != null)
				{
					int activeStageId2 = ((MassTournamentServerConnector)obj2).GetActiveStageId();
					MassEventModel tournamentData2 = TournamentData;
					if (TournamentData != null)
					{
						List<MassEventStageViewModel> <Stages>k__BackingField = tournamentData2.<Stages>k__BackingField;
						if (tournamentData2.<Stages>k__BackingField != null && player != null)
						{
							if (player.<NextStageEligibility>k__BackingField != MassEventNextStageEligibility.NotEligible)
							{
								if (player.<NextStageEligibility>k__BackingField != MassEventNextStageEligibility.EligibleToReserve)
								{
									if (player.<NextStageEligibility>k__BackingField != MassEventNextStageEligibility.Eligible)
									{
										return;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v11 (System.Object)+10]");
									if ((nint)activeStageId == 0)
									{
										textMesh = eligibilityInstructionsTxt;
										object obj3 = typeof(TypeConverter<ushort, char>) + 3400;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										bool flag3 = (object)_connector == null;
										massTournamentPlayerState = (MassTournamentPlayerState)1;
										if (!flag3)
										{
											MassEventStageViewModel activeStage = _connector.GetActiveStage();
											string massTournamentFilterCriteria = ((MassUserCard)(object)activeStage).GetMassTournamentFilterCriteria(activeStage);
											object[] array = default(object[]);
											bool flag4 = array == null;
											massTournamentPlayerState = (MassTournamentPlayerState)(object)activeStage;
											if (!flag4)
											{
												bool flag5 = massTournamentFilterCriteria == null;
												MassTournamentPlayerState massTournamentPlayerState2 = (MassTournamentPlayerState)(object)activeStage;
												if (!flag5)
												{
													nint num = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
													massTournamentPlayerState2 = (MassTournamentPlayerState)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag6 = ex == null;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v67 (Il2CppClass<System.Object[]>)+40]");
													massTournamentPlayerState = (MassTournamentPlayerState)0;
													if (flag6)
													{
														goto IL_0dd8;
													}
												}
												bool flag7 = array.Length == 0;
												massTournamentPlayerState = massTournamentPlayerState2;
												if (flag7)
												{
													goto IL_0dca;
												}
												object obj4 = array + 32;
												obj4 = massTournamentFilterCriteria;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												text = "Complete" + 344;
												formattedArguments = array;
												goto IL_0e15;
											}
										}
									}
									else if ((object)_connector != null)
									{
										MassEventStageViewModel activeStage2 = _connector.GetActiveStage();
										object obj5 = typeof(DataRelation) + 712;
										object obj6 = obj5;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v55+E4]");
										bool flag8 = (nint)0 == 0;
										object obj7 = !flag8;
										if (obj7 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										DateTime now = DateTime.Now;
										if (activeStage2 != null)
										{
											MassEventPlayWindowViewModel massEventPlayWindowViewModel = activeStage2.NextPlayWindow(now);
											bool flag9 = massEventPlayWindowViewModel == null;
											object obj8 = !flag9;
											num2 = unchecked((nint)null);
											massTournamentPlayerState = (MassTournamentPlayerState)now;
											if (obj8 != null)
											{
												goto IL_0751;
											}
											bool flag10 = (object)_connector == null;
											num2 = unchecked((nint)null);
											massTournamentPlayerState = (MassTournamentPlayerState)now;
											if (!flag10)
											{
												MassEventStageViewModel activeStage3 = _connector.GetActiveStage();
												object obj9 = obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v89+E4]");
												bool flag11 = (nint)0 == 0;
												object obj10 = !flag11;
												if (obj10 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												DateTime now2 = DateTime.Now;
												bool flag12 = activeStage3 == null;
												num2 = unchecked((nint)null);
												massTournamentPlayerState = (MassTournamentPlayerState)now;
												if (!flag12)
												{
													bool flag13 = activeStage3.WithinPlayPeriod(now2);
													bool flag14 = !flag13;
													num2 = unchecked((nint)null);
													massTournamentPlayerState = (MassTournamentPlayerState)now2;
													num3 = unchecked((nint)null);
													if (!flag14)
													{
														goto IL_0751;
													}
													goto IL_07cd;
												}
											}
										}
									}
								}
								else
								{
									object obj11 = activeStageId2 + 1;
									textMesh = eligibilityInstructionsTxt;
									if ((nint)obj11 == <Stages>k__BackingField._size)
									{
										text2 = "Unsupported map type" + 3944;
										goto IL_0e27;
									}
									object obj12 = typeof(TypeConverter<ushort, char>) + 3400;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									bool flag15 = (object)_connector == null;
									massTournamentPlayerState = (MassTournamentPlayerState)1;
									if (!flag15)
									{
										MassEventStageViewModel activeStage4 = _connector.GetActiveStage();
										string massTournamentFilterCriteria2 = ((MassUserCard)(object)activeStage4).GetMassTournamentFilterCriteria(activeStage4);
										object[] array2 = default(object[]);
										bool flag16 = array2 == null;
										massTournamentPlayerState = (MassTournamentPlayerState)(object)activeStage4;
										if (!flag16)
										{
											bool flag17 = massTournamentFilterCriteria2 == null;
											MassTournamentPlayerState massTournamentPlayerState3 = (MassTournamentPlayerState)(object)activeStage4;
											if (!flag17)
											{
												nint num4 = (nint)array2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
												massTournamentPlayerState3 = (MassTournamentPlayerState)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag18 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
												massTournamentPlayerState = (MassTournamentPlayerState)0;
												if (flag18)
												{
													goto IL_0dd8;
												}
											}
											bool flag19 = array2.Length == 0;
											massTournamentPlayerState = massTournamentPlayerState3;
											if (flag19)
											{
												goto IL_0dca;
											}
											object obj13 = array2 + 32;
											obj13 = massTournamentFilterCriteria2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											text = "WhiteSmoke" + 1600;
											formattedArguments = array2;
											goto IL_0e15;
										}
									}
								}
							}
							else if ((object)_connector != null)
							{
								MassEventStageViewModel activeStage5 = _connector.GetActiveStage();
								if (activeStage5 != null)
								{
									textMesh = eligibilityInstructionsTxt;
									if (activeStage5.<Type>k__BackingField == MassEventStageType.TournamentWinnersFilter)
									{
										text2 = "WhiteSmoke" + 40;
										goto IL_0e27;
									}
									object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									bool flag20 = (object)_connector == null;
									massTournamentPlayerState = (MassTournamentPlayerState)2;
									if (!flag20)
									{
										MassEventStageViewModel activeStage6 = _connector.GetActiveStage();
										string massTournamentFilterCriteria3 = ((MassUserCard)(object)activeStage6).GetMassTournamentFilterCriteria(activeStage6);
										object[] array3 = default(object[]);
										bool flag21 = array3 == null;
										massTournamentPlayerState = (MassTournamentPlayerState)(object)activeStage6;
										if (!flag21)
										{
											bool flag22 = massTournamentFilterCriteria3 == null;
											MassTournamentPlayerState massTournamentPlayerState4 = (MassTournamentPlayerState)(object)activeStage6;
											if (!flag22)
											{
												nint num5 = (nint)array3;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
												massTournamentPlayerState4 = (MassTournamentPlayerState)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag23 = ex == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v29 (Il2CppClass<System.Object[]>)+40]");
												massTournamentPlayerState = (MassTournamentPlayerState)0;
												if (flag23)
												{
													goto IL_0dd8;
												}
											}
											bool flag24 = array3.Length == 0;
											massTournamentPlayerState = massTournamentPlayerState4;
											if (!flag24)
											{
												object obj15 = array3 + 32;
												obj15 = massTournamentFilterCriteria3;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												bool flag25 = (object)_connector == null;
												massTournamentPlayerState = (MassTournamentPlayerState)(object)massTournamentFilterCriteria3;
												if (flag25)
												{
													goto IL_0dbc;
												}
												MassTournamentServerConnector massTournamentServerConnector = default(MassTournamentServerConnector);
												int massTournamentPointsToPass = massTournamentServerConnector.GetMassTournamentPointsToPass();
												object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
												object obj17 = obj16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v29+E4]");
												bool flag26 = (nint)0 == 0;
												object obj18 = !flag26;
												if (obj18 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object input = "Picking audio files is not supported on iOS" + 776;
												string text3 = LocalizationUtil.Localize((string)input, massTournamentPointsToPass);
												bool flag27 = text3 == null;
												MassTournamentPlayerState massTournamentPlayerState5 = (MassTournamentPlayerState)massTournamentPointsToPass;
												if (!flag27)
												{
													nint num6 = (nint)array3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
													massTournamentPlayerState5 = (MassTournamentPlayerState)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag28 = ex == null;
													num2 = unchecked((nint)null);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v28 (Il2CppClass<System.Object[]>)+40]");
													massTournamentPlayerState = (MassTournamentPlayerState)0;
													if (flag28)
													{
														goto IL_0dd8;
													}
												}
												object obj19 = array3.Length & 0xFFFFFFFEL;
												bool flag29 = obj19 == null;
												num2 = unchecked((nint)null);
												massTournamentPlayerState = massTournamentPlayerState5;
												if (!flag29)
												{
													object obj20 = array3 + 40;
													obj20 = text3;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													text = "WhiteSmoke" + 48;
													formattedArguments = array3;
													goto IL_0e15;
												}
											}
											goto IL_0dca;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0dbc;
		IL_0dd8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0e27:
		TextMeshProExtensions.Localize(textMesh, (string)text2);
		return;
		IL_0e15:
		TextMeshProExtensions.Localize(textMesh, (string)text, formattedArguments);
		return;
		IL_0751:
		if ((object)_connector != null)
		{
			MassEventStageViewModel activeStage7 = _connector.GetActiveStage();
			if (activeStage7 != null)
			{
				bool flag30 = player.<LastStageReached>k__BackingField <= activeStage7.<Id>k__BackingField;
				num3 = num2;
				if (!flag30)
				{
					goto IL_07cd;
				}
				textMesh = eligibilityInstructionsTxt;
				object obj21 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag31 = (object)_connector == null;
				massTournamentPlayerState = (MassTournamentPlayerState)1;
				if (!flag31)
				{
					MassEventStageViewModel activeStage8 = _connector.GetActiveStage();
					string massTournamentFilterCriteria4 = ((MassUserCard)(object)activeStage8).GetMassTournamentFilterCriteria(activeStage8);
					object[] array4 = default(object[]);
					bool flag32 = array4 == null;
					massTournamentPlayerState = (MassTournamentPlayerState)(object)activeStage8;
					if (!flag32)
					{
						bool flag33 = massTournamentFilterCriteria4 == null;
						MassTournamentPlayerState massTournamentPlayerState6 = (MassTournamentPlayerState)(object)activeStage8;
						if (!flag33)
						{
							nint num7 = (nint)array4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
							massTournamentPlayerState6 = (MassTournamentPlayerState)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag34 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
							massTournamentPlayerState = (MassTournamentPlayerState)0;
							if (flag34)
							{
								goto IL_0dd8;
							}
						}
						bool flag35 = array4.Length == 0;
						massTournamentPlayerState = massTournamentPlayerState6;
						if (flag35)
						{
							goto IL_0dca;
						}
						object obj22 = array4 + 32;
						obj22 = massTournamentFilterCriteria4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						text = "WhiteSmoke" + 1688;
						formattedArguments = array4;
						goto IL_0e15;
					}
				}
			}
		}
		goto IL_0dbc;
		IL_07cd:
		textMesh = eligibilityInstructionsTxt;
		object obj23 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag36 = (object)_connector == null;
		num2 = num3;
		massTournamentPlayerState = (MassTournamentPlayerState)1;
		if (!flag36)
		{
			MassEventStageViewModel activeStage9 = _connector.GetActiveStage();
			string massTournamentFilterCriteria5 = ((MassUserCard)(object)activeStage9).GetMassTournamentFilterCriteria(activeStage9);
			object[] array5 = default(object[]);
			bool flag37 = array5 == null;
			num2 = num3;
			massTournamentPlayerState = (MassTournamentPlayerState)(object)activeStage9;
			if (!flag37)
			{
				bool flag38 = massTournamentFilterCriteria5 == null;
				MassTournamentPlayerState massTournamentPlayerState7 = (MassTournamentPlayerState)(object)activeStage9;
				if (!flag38)
				{
					nint num8 = (nint)array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
					massTournamentPlayerState7 = (MassTournamentPlayerState)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag39 = ex == null;
					num2 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v50 (Il2CppClass<System.Object[]>)+40]");
					massTournamentPlayerState = (MassTournamentPlayerState)0;
					if (flag39)
					{
						goto IL_0dd8;
					}
				}
				bool flag40 = array5.Length == 0;
				num2 = num3;
				massTournamentPlayerState = massTournamentPlayerState7;
				if (flag40)
				{
					goto IL_0dca;
				}
				object obj24 = array5 + 32;
				obj24 = massTournamentFilterCriteria5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				text = "WhiteSmoke" + 1680;
				formattedArguments = array5;
				goto IL_0e15;
			}
		}
		goto IL_0dbc;
		IL_0dca:
		ex = new IndexOutOfRangeException();
		goto IL_0dd8;
		IL_0dbc:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0dca;
	}

	private unsafe string GetMassTournamentFilterCriteria(MassEventStageViewModel activeStage)
	{
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0348: Expected O, but got Ref
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_04e1: Expected O, but got Ref
		//IL_036d: Expected O, but got Ref
		//IL_0699: Expected O, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01af: Expected O, but got Ref
		//IL_0506: Expected O, but got Ref
		//IL_0383: Expected I, but got O
		//IL_0393: Expected O, but got I
		//IL_03bc: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_044f: Expected O, but got I4
		//IL_01d4: Expected O, but got Ref
		//IL_051c: Expected I, but got O
		//IL_052c: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05e8: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_01ea: Expected I, but got O
		//IL_01fa: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		MassEventStageViewModel massEventStageViewModel = default(MassEventStageViewModel);
		if (massEventStageViewModel == null)
		{
			goto IL_0621;
		}
		int? num = default(int?);
		object input2;
		object[] formattedArguments;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (massEventStageViewModel.<Type>k__BackingField > MassEventStageType.ConstantPointsFilter)
		{
			if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.PlayersRatioFilter)
			{
				if (massEventStageViewModel.<Type>k__BackingField == MassEventStageType.Physical)
				{
					goto IL_02ef;
				}
				if (massEventStageViewModel.<Type>k__BackingField == MassEventStageType.TournamentWinnersFilter)
				{
					object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v61+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object input = "not" + 3776;
					return LocalizationUtil.Localize((string)input);
				}
				goto IL_0657;
			}
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj5 = typeof(List<Tween>) + 2432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array = default(object[]);
			bool flag2 = array == null;
			massEventStageViewModel = (MassEventStageViewModel)(&num);
			if (flag2)
			{
				goto IL_0621;
			}
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			MassEventStageViewModel massEventStageViewModel2 = (MassEventStageViewModel)(&num);
			if (!flag3)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
				massEventStageViewModel2 = (MassEventStageViewModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
				massEventStageViewModel = (MassEventStageViewModel)0;
				if (flag4)
				{
					goto IL_063d;
				}
			}
			bool flag5 = array.Length == 0;
			massEventStageViewModel = massEventStageViewModel2;
			if (flag5)
			{
				goto IL_062f;
			}
			object obj7 = array + 32;
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v56+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			input2 = "startPosition" + 2960;
			formattedArguments = array;
		}
		else
		{
			if (massEventStageViewModel.<Type>k__BackingField == MassEventStageType.ConstantPlayersFilter)
			{
				goto IL_02ef;
			}
			if (massEventStageViewModel.<Type>k__BackingField != MassEventStageType.ConstantPointsFilter)
			{
				goto IL_0657;
			}
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj12 = typeof(List<Tween>) + 2432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array2 = default(object[]);
			bool flag7 = array2 == null;
			massEventStageViewModel = (MassEventStageViewModel)(&num);
			if (flag7)
			{
				goto IL_0621;
			}
			object obj13 = default(object);
			bool flag8 = obj13 == null;
			MassEventStageViewModel massEventStageViewModel3 = (MassEventStageViewModel)(&num);
			if (!flag8)
			{
				nint num3 = (nint)array2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				massEventStageViewModel3 = (MassEventStageViewModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag9 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v34 (Il2CppClass<System.Object[]>)+40]");
				massEventStageViewModel = (MassEventStageViewModel)0;
				if (flag9)
				{
					goto IL_063d;
				}
			}
			bool flag10 = array2.Length == 0;
			massEventStageViewModel = massEventStageViewModel3;
			if (flag10)
			{
				goto IL_062f;
			}
			object obj14 = array2 + 32;
			obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v43+E4]");
			bool flag11 = (nint)0 == 0;
			object obj17 = !flag11;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			input2 = "not" + 3768;
			formattedArguments = array2;
		}
		goto IL_06d3;
		IL_062f:
		ex = new IndexOutOfRangeException();
		goto IL_063d;
		IL_0621:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_062f;
		IL_06d3:
		return LocalizationUtil.Localize((string)input2, formattedArguments);
		IL_0657:
		object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex3 = default(ArgumentOutOfRangeException);
		ex3..ctor();
		object obj19 = (nint)0 + (nint)3672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
		IL_02ef:
		object obj20 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj21 = typeof(List<Tween>) + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array3 = default(object[]);
		bool flag12 = array3 == null;
		massEventStageViewModel = (MassEventStageViewModel)(&num);
		if (flag12)
		{
			goto IL_0621;
		}
		object obj22 = default(object);
		bool flag13 = obj22 == null;
		MassEventStageViewModel massEventStageViewModel4 = (MassEventStageViewModel)(&num);
		if (!flag13)
		{
			nint num4 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
			massEventStageViewModel4 = (MassEventStageViewModel)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag14 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v21 (Il2CppClass<System.Object[]>)+40]");
			massEventStageViewModel = (MassEventStageViewModel)0;
			if (flag14)
			{
				goto IL_063d;
			}
		}
		bool flag15 = array3.Length == 0;
		massEventStageViewModel = massEventStageViewModel4;
		if (flag15)
		{
			goto IL_062f;
		}
		object obj23 = array3 + 32;
		obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v30+E4]");
		bool flag16 = (nint)0 == 0;
		object obj26 = !flag16;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		input2 = "startPosition" + 2968;
		formattedArguments = array3;
		goto IL_06d3;
		IL_063d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		massEventStageViewModel = null;
		throw new OutOfMemoryException();
	}

	private void <ShowCardAsWaitingToStart>b__29_0()
	{
		Reload(_playerState);
	}
}
