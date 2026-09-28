using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public abstract class KGameUiControls : MonoBehaviour
{
	protected ElegantLoadingIndicator loadingIndicator;

	protected HintsPopup hintsPopup;

	private GameComponentsLoader componentLoader;

	private GameEventsChannel gameEventsChannel;

	private SlideAnimationHelper uiSlider;

	private const string LastJoinedRoomId = "LastJoinedRoomId";

	protected KGame game;

	private TournamentMatchInfo matchInfo
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b2: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E678C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
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
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
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
			TournamentMatchInfo result = default(TournamentMatchInfo);
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result2 = default(TournamentMatchInfo);
			return result2;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)136;
		ScreenManager.PreventLoadingPreviousScene();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 72;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Init();
		RegisterEvents();
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0211: Expected I, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a2: Expected I, but got O
		//IL_00e0: Expected I, but got O
		//IL_011e: Expected I, but got O
		//IL_015c: Expected I, but got O
		//IL_0183: Expected O, but got I
		//IL_01af: Expected I, but got O
		//IL_01d7: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<KGameUiControls>)+180]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		game.OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5 (Il2CppClass<KGameUiControls>)+190]");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)0);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v6 (Il2CppClass<KGameUiControls>)+1A0]");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)0);
		game.OnMatchMakerEvent += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v7 (Il2CppClass<KGameUiControls>)+1C0]");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)0);
		game.OnGameExiting += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8 (Il2CppClass<KGameUiControls>)+1D0]");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)0);
		game.OnGameEnd += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num6 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9 (Il2CppClass<KGameUiControls>)+1B0]");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)0);
		object obj4 = (nint)0 + (nint)3312;
		hintsPopup.OnMatchMakingCancel += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj4);
		gameEventsChannel.ExitGame += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num7 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v10 (Il2CppClass<KGameUiControls>)+220]");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)0);
		gameEventsChannel.ShowOfflineUi += action7;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008b: Expected I, but got O
		//IL_0048: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.ExitGame -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4 (Il2CppClass<KGameUiControls>)+220]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		gameEventsChannel.ShowOfflineUi -= action2;
	}

	protected virtual void OnGameStateUpdated()
	{
		//IL_003b: Expected O, but got I4
		//IL_00d5: Expected I, but got O
		//IL_00e5: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_013e: Expected I, but got O
		//IL_014e: Expected O, but got I
		//IL_015e: Expected O, but got I
		KGame kGame = game;
		bool isInitializing = kGame.<GamePhase>k__BackingField.IsInitializing;
		bool flag = !isInitializing;
		object obj = !flag;
		if (obj == null)
		{
			KGame kGame2 = game;
			bool isLookingForPlayers = kGame2.<GamePhase>k__BackingField.IsLookingForPlayers;
			bool flag2 = !isLookingForPlayers;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				KGame kGame3 = game;
				if (!kGame3.<GamePhase>k__BackingField.IsGameFinished)
				{
					goto IL_00ff;
				}
			}
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (Il2CppClass<KGameUiControls>)+1E8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (Il2CppClass<KGameUiControls>)+1F0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v70 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00ff;
		IL_00ff:
		KGame kGame4 = game;
		if (kGame4.<GamePhase>k__BackingField.IsGameStarted)
		{
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8 (Il2CppClass<KGameUiControls>)+1E8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8 (Il2CppClass<KGameUiControls>)+1F0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnPlayerSwitchSeat(int i, string error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (error != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(error);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError(error);
		}
	}

	protected virtual void OnMatchMakerEvent(ISFSObject message)
	{
		HideLoader();
		HideControls();
		hintsPopup.Open();
	}

	protected virtual void OnMatchMakingCancel()
	{
		game.CancelMatchMaking();
	}

	protected virtual void OnExitGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)this;
		HideControls();
		SplashAnimation.StartLoading();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.DismissMessage();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
	}

	protected virtual void OnGameEnd(ISFSObject _)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGameUiControls>)+208]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGameUiControls>)+210]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnButtonExitClick()
	{
		//IL_002e: Expected O, but got I4
		//IL_0033: Expected I, but got O
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I4
		//IL_02a9: Expected I, but got O
		//IL_02bc: Expected I, but got O
		//IL_0095: Expected I, but got O
		//IL_02cf: Expected I, but got O
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I4
		//IL_02e2: Expected I, but got O
		//IL_0229: Expected O, but got I4
		if ((object)game != null)
		{
			bool isSpectator = game.IsSpectator;
			bool flag = !isSpectator;
			object obj = !flag;
			nint num = unchecked((nint)null);
			if (obj != null)
			{
				goto IL_00a3;
			}
			if ((object)game != null)
			{
				Room room = game.Room;
				bool flag2 = SFSKammelnaRoomExtensions.IsOffline(room);
				bool flag3 = !flag2;
				num = unchecked((nint)null);
				if (!flag3)
				{
					goto IL_00a3;
				}
				if ((object)gameEventsChannel != null)
				{
					gameEventsChannel.TriggerShowForfeitWarning();
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				nint num2 = unchecked((nint)null);
			}
			else
			{
				NullReferenceException ex2 = new NullReferenceException();
				nint num2 = unchecked((nint)null);
			}
		}
		else
		{
			NullReferenceException ex3 = new NullReferenceException();
		}
		goto IL_0317;
		IL_0317:
		NullReferenceException ex4 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00a3:
		ITrackEvent trackEvent = TrackerLibrary.GameSafeExitClicked();
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj4 = !flag4;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		if ((object)game != null)
		{
			if (game.IsTutorial)
			{
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2264;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v23+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RoutingCommand tutorialTransitionMessage = Tutorial.GetTutorialTransitionMessage();
				object obj8 = typeof(RegisteredWaitHandle) + 1552;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v27+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RoutingManager.Route(tutorialTransitionMessage, null, (Games?)(object)0);
				return;
			}
			if ((object)game != null)
			{
				game.ExitGame();
				return;
			}
			NullReferenceException ex5 = new NullReferenceException();
			nint num2 = unchecked((nint)null);
		}
		else
		{
			NullReferenceException ex6 = new NullReferenceException();
			nint num2 = unchecked((nint)null);
		}
		goto IL_0317;
	}

	protected virtual void Init()
	{
		//IL_006f: Expected I, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0051: Expected I, but got O
		nint num = (nint)this;
		SetGameToLoading(isLoading: true);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3304;
		Room room = game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		componentLoader.LoadComponents(room, action);
	}

	protected virtual void SetGameToLoading(bool isLoading)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_04cc: Expected I, but got O
		//IL_04dc: Expected O, but got I
		//IL_04ec: Expected O, but got I
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0273: Expected I, but got O
		//IL_0283: Expected O, but got I
		//IL_009f: Expected O, but got I4
		//IL_02be: Expected O, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_038c: Expected O, but got I
		//IL_03b6: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_0424: Expected O, but got I4
		object obj9 = default(object);
		nint num;
		object obj12;
		object obj13;
		for (; isLoading; num = (nint)this, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20 (Il2CppClass<KGameUiControls>)+208]"), obj12 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20 (Il2CppClass<KGameUiControls>)+210]"), obj13 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v166 @ X2_v6 (should have been resolved before IL gen)"))
		{
			Room room = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			bool flag = GameTypeExtensions.IsTournament(gameType);
			Room room2 = game.Room;
			if (room2 == null)
			{
				continue;
			}
			Room room3 = game.Room;
			bool flag2 = SFSKammelnaRoomExtensions.IsOffline(room3);
			bool flag3 = !flag2;
			object obj = !flag3;
			if (obj != null)
			{
				continue;
			}
			if (flag)
			{
				object obj2 = 152985600;
				object obj3 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E678C]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					object obj5 = (nint)0 + (nint)2248;
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v46+E4]");
					bool flag4 = (nint)0 == 0;
					object obj7 = obj5;
					if (!flag4)
					{
						goto IL_0157;
					}
				}
				else
				{
					_ = 1;
					object obj5 = (nint)0 + (nint)2248;
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v46+E4]");
					bool flag5 = (nint)0 == 0;
					object obj8 = !flag5;
					object obj7 = obj5;
					if (obj8 != null)
					{
						goto IL_0157;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if (obj9 == null)
				{
					continue;
				}
				goto IL_0402;
			}
			goto IL_0432;
			IL_0432:
			HideLoader();
			hintsPopup.Close();
			KGame kGame = game;
			if (kGame.<GamePhase>k__BackingField.IsInitializing && game.HasActivePlayers)
			{
				gameEventsChannel.TriggerShowAnimation();
			}
			else
			{
				ShowLoader();
			}
			continue;
			IL_0402:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v45+40]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 != null)
			{
				continue;
			}
			goto IL_0432;
			IL_0157:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = obj9 == null;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				continue;
			}
			goto IL_0402;
		}
		object obj14 = typeof(Queue<string>) + 848;
		object obj15 = (nint)0 + (nint)2200;
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj18 = "LAK" + 504;
		string key = (string)((currentRoom != null) ? obj18 : null);
		object obj23;
		if (currentRoom != null)
		{
			object obj19 = typeof(RegisteredWaitHandle) + 1376;
			nint num2 = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ff;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj21 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v7-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj21 += 16;
				obj20--;
				if ((nint)obj20 != 1)
				{
					continue;
				}
				goto IL_02ff;
			}
			object obj22 = num2 + obj21;
			obj23 = obj22 + 312;
			goto IL_0550;
		}
		string value = null;
		key = (string)obj18;
		goto IL_0574;
		IL_02ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj24 = default(object);
		obj23 = obj24;
		goto IL_0550;
		IL_0574:
		Prefs.SetString(key, value);
		gameEventsChannel.TriggerHideAnimation();
		HideLoader();
		hintsPopup.Close();
		SplashAnimation.StopLoading();
		ShowControls();
		return;
		IL_0550:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X8_v15] (should have been resolved before IL gen)");
		int num3 = default(int);
		string text = num3.ToString();
		value = text;
		goto IL_0574;
	}

	protected virtual void ShowControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6722]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_015e;
		IL_015e:
		gameEventsChannel.TriggerShowUi();
		return;
		IL_014e:
		uiSlider.SlideIn();
		goto IL_015e;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_014e;
		}
		goto IL_015e;
	}

	protected virtual void HideControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6723]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_015e;
		IL_015e:
		gameEventsChannel.TriggerHideUi();
		return;
		IL_014e:
		uiSlider.SlideOut();
		goto IL_015e;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_014e;
		}
		goto IL_015e;
	}

	protected virtual void ShowOfflineUi()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6724]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			SplashAnimation.StopLoading();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			SplashAnimation.StopLoading();
			obj5 = uiSlider;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = uiSlider;
			if (obj7 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00bc;
		IL_00bc:
		uiSlider.SlideIn();
		return;
		IL_0096:
		if ((bool)obj5)
		{
			goto IL_00bc;
		}
	}

	private void ShowLoader()
	{
		GameObject gameObject = loadingIndicator.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			GameObject gameObject2 = loadingIndicator.gameObject;
			gameObject2.SetActive(value: true);
			Transform target = loadingIndicator.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.3f);
		}
	}

	private void HideLoader()
	{
		//IL_0021: Expected O, but got I
		loadingIndicator.Freeze();
		object obj = (nint)0 + (nint)2504;
		Transform target = loadingIndicator.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, 0.26f);
		TweenCallback tweenCallback = TweenHelpers.Disable(loadingIndicator);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void ShowHints()
	{
		hintsPopup.Open();
	}

	private void HideHints()
	{
		hintsPopup.Close();
	}

	private void <Init>b__19_0(bool success)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_001c: Expected I, but got O
		//IL_002c: Expected O, but got I
		//IL_003c: Expected O, but got I
		if (success)
		{
			KGame kGame = game;
			nint num = (nint)kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7 (Il2CppClass<KGame>)+2B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v7 (Il2CppClass<KGame>)+2C0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v2 (should have been resolved before IL gen)");
		}
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj4 = "Read object reference Id '{0}' for {1}." + 3408;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogError(obj4);
		gameEventsChannel.TriggerLeaveRoom(LeaveReason.RoomClosed);
	}
}
