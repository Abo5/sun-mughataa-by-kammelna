using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;

public class KammelnaLobbyServerConnector : LobbyServerConnector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, LobbyPlayerData> <>9__12_0;

		public static Func<int, LobbyPlayerData> <>9__12_1;

		public static Func<int, LobbyPlayerData> <>9__12_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal LobbyPlayerData <GetDistributedPlayers>b__12_0(int id)
		{
			return GetPlayerData(id, 0);
		}

		internal LobbyPlayerData <GetDistributedPlayers>b__12_1(int id)
		{
			return GetPlayerData(id, 1);
		}

		internal LobbyPlayerData <GetDistributedPlayers>b__12_2(int id)
		{
			return GetPlayerData(id, 2);
		}
	}

	public static KammelnaLobbyServerConnector Instance;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1184;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void Initialize()
	{
		base.Initialize();
		ShowPanelIfNeeded();
		LobbyPanel lobbyPanel = panel;
		bool <PlayerIsTheOwner>k__BackingField = UserIsCurrentOwner();
		lobbyPanel.<PlayerIsTheOwner>k__BackingField = <PlayerIsTheOwner>k__BackingField;
		lobbyPanel.playNowButton.SetWaitingForHost();
		lobbyPanel.RefreshTeamsArea();
		lobbyPanel.RefreshSpectatorsArea();
	}

	public override void SendKickCommand(int playerId)
	{
		GameLobbyRequest.SendKick(playerId);
	}

	public override void SendSetTeamCommand(int playerId, int team)
	{
		if (team != 0)
		{
			GameLobbyRequest.SendJoinTeam(playerId, team);
		}
		else
		{
			GameLobbyRequest.SendJoinSpectators(playerId);
		}
	}

	public override void SendStartGame()
	{
		GameLobbyRequest.SendStartGame();
	}

	public void ShowPanelIfNeeded()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_0062: Expected I, but got O
		KGame kGame = game;
		if (kGame.<IsInitialized>k__BackingField)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)3480;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			kGame.OnGameInitialized += action;
		}
		else
		{
			<ShowPanelIfNeeded>g__ShowPanelHelper|7_0();
		}
	}

	protected override void AddServerListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016c: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2088;
		object obj4 = (nint)0 + (nint)3496;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 40;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3488;
		((KGame)obj7).OnGameLobbyUpdate += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj10);
		game.OnGameStateUpdated += action2;
		GameObject go = base.gameObject;
		object obj11 = (nint)0 + (nint)3504;
		object varName = "Network Authentication Required" + 2856;
		Room room = game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj11);
		VariableBinderExtensions.Bind(go, room, (string)varName, action3);
	}

	private void LobbyUpdate(GameLobbyState obj)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_016e: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		LobbyPanel lobbyPanel = panel;
		bool <PlayerIsTheOwner>k__BackingField = UserIsCurrentOwner();
		lobbyPanel.<PlayerIsTheOwner>k__BackingField = <PlayerIsTheOwner>k__BackingField;
		lobbyPanel.playNowButton.SetWaitingForHost();
		lobbyPanel.RefreshTeamsArea();
		lobbyPanel.RefreshSpectatorsArea();
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6+E4]");
		KammelnaLobbyServerConnector kammelnaLobbyServerConnector;
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(obj.Error);
			bool flag2 = !flag;
			kammelnaLobbyServerConnector = (KammelnaLobbyServerConnector)flag;
			if (!flag2)
			{
				goto IL_00b9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(obj.Error);
			bool flag4 = !flag3;
			object obj4 = !flag4;
			kammelnaLobbyServerConnector = (KammelnaLobbyServerConnector)flag3;
			if (obj4 != null)
			{
				goto IL_00b9;
			}
		}
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object title = "Index = {0} position = {1}" + 1744;
		object buttonText = "Network Authentication Required" + 3128;
		PopupWindow.ShowError((string)title, obj.Error, (string)buttonText);
		return;
		IL_00b9:
		List<LobbyPlayerData> distributedPlayers = kammelnaLobbyServerConnector.GetDistributedPlayers(obj);
		panel.SetPlayers(distributedPlayers);
	}

	private void SetOwnerView()
	{
		LobbyPanel lobbyPanel = panel;
		bool <PlayerIsTheOwner>k__BackingField = UserIsCurrentOwner();
		lobbyPanel.<PlayerIsTheOwner>k__BackingField = <PlayerIsTheOwner>k__BackingField;
		lobbyPanel.playNowButton.SetWaitingForHost();
		lobbyPanel.RefreshTeamsArea();
		lobbyPanel.RefreshSpectatorsArea();
	}

	private void CheckForStartGame()
	{
		KGame kGame = game;
		if (kGame.<GamePhase>k__BackingField.IsGameStarted)
		{
			LobbyPanel lobbyPanel = panel;
			lobbyPanel.panelArea.SetActive(value: false);
		}
	}

	private List<LobbyPlayerData> GetDistributedPlayers(GameLobbyState lobbyState)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0473: Expected O, but got I
		//IL_0484: Expected I, but got O
		//IL_04a2: Expected O, but got I
		//IL_04bd: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04fc: Expected O, but got I
		//IL_050d: Expected I, but got O
		//IL_052b: Expected O, but got I
		//IL_0556: Expected O, but got I4
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Expected O, but got Unknown
		//IL_057b: Expected O, but got I
		//IL_058d: Expected O, but got I
		//IL_059d: Expected O, but got I
		//IL_05bf: Expected O, but got I4
		//IL_02f0: Expected O, but got I
		//IL_03f6: Expected I, but got O
		//IL_039c: Expected O, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I
		//IL_0608: Expected I, but got O
		//IL_0626: Expected O, but got I
		//IL_03db: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		object obj;
		object obj4;
		Func<int, object> selector;
		object obj6;
		object obj3;
		if (lobbyState != null)
		{
			obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v44+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v44+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v30+8]");
				selector = (Func<int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v30+8]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0125;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)3496;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v44+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v30+8]");
				selector = (Func<int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v30+8]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0125;
				}
			}
			goto IL_017c;
		}
		return (List<LobbyPlayerData>)(object)new NullReferenceException();
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v44+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v36+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3256;
		Func<int, object> func = default(Func<int, object>);
		func..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v35+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = 0;
		selector = func;
		obj3 = obj6;
		goto IL_017c;
		IL_017c:
		IEnumerable<object> first = Enumerable.Select(lobbyState.<Spectators>k__BackingField, selector);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v34+E4]");
		object obj16;
		object obj17;
		Func<int, object> selector2;
		object obj19;
		if ((nint)0 != 0)
		{
			obj16 = (nint)0 + (nint)3008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v34+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+10]");
			selector2 = (Func<int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+10]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				obj19 = obj16;
				goto IL_029e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj;
			obj19 = (nint)0 + (nint)3008;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v34+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+10]");
			selector2 = (Func<int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v19+10]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			obj16 = obj19;
			if (obj20 == null)
			{
				goto IL_029e;
			}
		}
		goto IL_02f5;
		IL_029e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v34+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v25+B8]");
			obj17 = 0;
		}
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)3264;
		Func<int, object> func2 = default(Func<int, object>);
		func2..ctor(obj17, (IntPtr)obj24);
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24+B8]");
		object obj26 = (nint)0 + (nint)16;
		obj26 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector2 = func2;
		obj16 = obj19;
		obj14 = 0;
		goto IL_02f5;
		IL_02f5:
		IEnumerable<object> second = Enumerable.Select(lobbyState.<Team1Players>k__BackingField, selector2);
		IEnumerable<object> first2 = Enumerable.Union(first, second);
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			object obj28 = obj16;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj;
			object obj28 = obj16;
		}
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2280;
		object obj30 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v14+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+18]");
		Func<int, object> selector3 = (Func<int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v10+18]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v14+E4]");
			bool flag8 = (nint)0 == 0;
			object obj33 = !flag8;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj34 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v16+B8]");
				obj31 = 0;
			}
			object obj35 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj36 = (nint)0 + (nint)3272;
			Func<int, object> func3 = default(Func<int, object>);
			func3..ctor(obj31, (IntPtr)obj36);
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v15+B8]");
			object obj38 = (nint)0 + (nint)24;
			obj38 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj14 = 0;
			selector3 = func3;
		}
		IEnumerable<object> second2 = Enumerable.Select(lobbyState.<Team2Players>k__BackingField, selector3);
		IEnumerable<object> source = Enumerable.Union(first2, second2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor((object)null, (IntPtr)obj30);
		IEnumerable<object> source2 = Enumerable.Where(source, func4);
		return (List<LobbyPlayerData>)(object)Enumerable.ToList(source2);
	}

	private static LobbyPlayerData GetPlayerData(int id, int team)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010f: Expected O, but got I
		//IL_0139: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		int num = default(int);
		string userDbId = num.ToString();
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User onlineUser = sessionModel.GetOnlineUser(userDbId);
			bool flag2 = onlineUser == null;
			LobbyPlayerData result = (LobbyPlayerData)onlineUser;
			if (!flag2)
			{
				object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = default(object);
				obj6..ctor();
				object obj7 = obj6 + 16;
				obj7 = onlineUser;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				result = (LobbyPlayerData)obj6;
			}
			return result;
		}
		return (LobbyPlayerData)(object)new NullReferenceException();
	}

	private bool UserIsCurrentOwner()
	{
		//IL_0102: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		if ((object)game != null)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			Room room = game.Room;
			int roomOwnerId = SFSKammelnaRoomExtensions.GetRoomOwnerId(room);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
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
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				object obj5 = roomOwnerId - intDbId;
				return obj5 == null;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <ShowPanelIfNeeded>g__ShowPanelHelper|7_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_010f: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		game.OnGameInitialized -= action;
		Room room = game.Room;
		if (SFSKammelnaRoomExtensions.IsPrivate(room))
		{
			KGame kGame = game;
			if (!kGame.<GamePhase>k__BackingField.IsGameStarted)
			{
				LobbyPanel lobbyPanel = panel;
				lobbyPanel.panelArea.SetActive(value: true);
				return;
			}
		}
		LobbyPanel lobbyPanel2 = panel;
		lobbyPanel2.panelArea.SetActive(value: false);
	}
}
