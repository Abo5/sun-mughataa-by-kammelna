using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ForfeiterWarningPopup : MonoBehaviour
{
	private PopupUI popup;

	private GameObject rankedPenalty;

	private GameObject friendlyPenalty;

	private GameObject fastTrackPenalty;

	private GameObject tournamentPenalty;

	private TextMeshProUGUI rankedText;

	private GameEventsChannel gameEventsChannel;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2208;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 88;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		gameEventsChannel.ShowForfeitWarning += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.ShowForfeitWarning -= action;
	}

	public void ShowPopup()
	{
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		Room room = game.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		bool active = GameTypeExtensions.IsRanked(gameType);
		rankedPenalty.SetActive(active);
		bool active2 = GameTypeExtensions.IsFriendly(gameType);
		friendlyPenalty.SetActive(active2);
		bool active3 = GameTypeExtensions.IsFastTrack(gameType);
		fastTrackPenalty.SetActive(active3);
		bool active4 = GameTypeExtensions.IsTournament(gameType);
		tournamentPenalty.SetActive(active4);
		if (GameTypeExtensions.IsRanked(gameType))
		{
			SetupRankedView();
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popup.SlideFromBottom();
		ITrackEvent trackEvent = TrackerLibrary.GameForfeitWindowViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void Close()
	{
		popup.SlideToBottom();
	}

	public void OnConfirm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj2 = !flag;
		if (obj2 == null)
		{
			KGame.SendForfeitGame();
			Room room = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			if (GameTypeExtensions.IsFastTrack(gameType))
			{
				ITrackEvent trackEvent = TrackerLibrary.FastTrackForfeitMatchAfterWarningClicked();
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
			}
		}
		game.ExitGame();
		popup.SlideToBottom();
		ITrackEvent trackEvent2 = TrackerLibrary.GameForfeitConfirmClicked();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent2);
		Room room2 = game.Room;
		int teamScore = SFSKammelnaRoomExtensions.GetTeamScore(room2, 1);
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Room room3 = game.Room;
		int teamScore2 = SFSKammelnaRoomExtensions.GetTeamScore(room3, 2);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool balancedGame = game.IsGameBalanced();
		KPlayer myPlayer = game.MyPlayer;
		int num = teamScore - teamScore2;
		int pointsDifference = ((teamScore >= teamScore2) ? num : (-num));
		int forfeitingPenalty = myPlayer.ForfeitingPenalty;
		FirebaseTrack.AbandonGame(pointsDifference, balancedGame, forfeitingPenalty);
	}

	private void SetupRankedView()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_004c: Expected I4, but got I8
		//IL_0066: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ba: Expected I8, but got I4
		//IL_00e0: Expected I8, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016d: Expected O, but got I
		//IL_0197: Expected O, but got I4
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0222: Expected O, but got I
		//IL_024c: Expected O, but got I4
		KPlayer myPlayer = game.MyPlayer;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		int forfeitingPenalty = myPlayer.ForfeitingPenalty;
		int num = (int)(forfeitingPenalty & 0x80000000L);
		bool flag = num == 0;
		object obj2 = !flag;
		string text;
		if (obj2 == null)
		{
			object input = "WhiteSmoke" + 2112;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = LocalizationUtil.Localize((string)input);
			long num2 = 0L;
		}
		else
		{
			KPlayer myPlayer2 = game.MyPlayer;
			int forfeitingPenalty2 = myPlayer2.ForfeitingPenalty;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input2 = "{0} color encoding is currently unsupported for outputting to HDR." + 272;
			long num3 = -forfeitingPenalty2;
			text = LocalizationUtil.Localize((string)input2, num3);
			long num2 = num3;
		}
		object obj7 = typeof(Queue<string>) + 848;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int winningStreak = SFSKammelnaUserExtensions.GetWinningStreak(localUser);
		bool flag5 = winningStreak < 1;
		string text2 = text;
		if (!flag5)
		{
			object input3 = "Added Tournament Prizes And Features" + 1560;
			object obj11 = (nint)0 + (nint)3072;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = LocalizationUtil.Localize((string)input3);
			string text4 = text + (string)obj11 + text3;
			text2 = text4;
		}
		TextMeshProExtensions.FixArabic(rankedText, text2);
	}
}
