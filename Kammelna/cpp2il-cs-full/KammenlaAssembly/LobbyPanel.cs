using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Jackaroo;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class LobbyPanel : MonoBehaviour
{
	public delegate void LobbyChangedDel();

	private sealed class <>c__DisplayClass43_0
	{
		public LobbyPanel <>4__this;

		public int playerID;

		internal void <SendKickCommand>b__0()
		{
			//IL_0033: Expected I, but got O
			//IL_0043: Expected O, but got I
			//IL_0053: Expected O, but got I
			LobbyPanel lobbyPanel = <>4__this;
			LobbyServerConnector serverConnector = lobbyPanel._serverConnector;
			int num = playerID;
			nint num2 = (nint)serverConnector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X9_v1 (Il2CppClass<LobbyServerConnector>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X9_v1 (Il2CppClass<LobbyServerConnector>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public LobbyPanel <>4__this;

		public JackarooAllowedRules customRules;

		public Action<JackarooCustomRulesPreview> <>9__1;

		internal void <SetButtonsCommands>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d5: Expected I, but got O
			//IL_00fa: Expected O, but got I
			//IL_0124: Expected O, but got I4
			//IL_0055: Expected O, but got I
			LobbyPanel lobbyPanel = <>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = this + 32;
			Action<object> action = (Action<object>)obj2;
			Action<object> action2;
			object obj5;
			object obj3;
			if (obj2 != null)
			{
				obj3 = (nint)0 + (nint)2088;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				action2 = action;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_0092;
				}
			}
			else
			{
				object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)4000;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj7);
				<>9__1 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj3 = (nint)0 + (nint)2088;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				action = action3;
				action2 = action3;
				obj5 = obj3;
				if (obj8 != null)
				{
					goto IL_0092;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			obj3 = obj5;
			goto IL_0092;
			IL_0092:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		}

		internal void <SetButtonsCommands>b__1(JackarooCustomRulesPreview pop)
		{
			pop.Populate(customRules);
		}
	}

	private bool <PlayerIsTheOwner>k__BackingField;

	private LobbyChangedDel m_OnPlayerListChanged;

	private GameObject panelArea;

	private GameObject lobbyPlayerStrip_prefab;

	private GameObject inTeamPlayerStrip_prefab;

	private Transform playersTransformParent;

	private Transform teamOneTransformParent;

	private Transform teamTwoTransformParent;

	private LobbyStartButton playNowButton;

	private InvitePanel invitePanel;

	private GameObject pickTeam1Button;

	private GameObject pickTeam2Button;

	private GameObject cancelPick;

	private Button customRulesButton;

	private GameEventsChannel gameEventsChannel;

	private ComponentReference<JackarooCustomRulesPreview> jackarooCustomRulesPreview;

	private KGame game;

	private LobbyServerConnector _serverConnector;

	private readonly List<LobbyPlayerData> _playersInLobby;

	private readonly List<LobbyPlayerStrip> _spectatorsOnline;

	private readonly List<InTeamPlayerStrip> _playersInTeamOne;

	private readonly List<InTeamPlayerStrip> _playersInTeamTwo;

	private const string LeavingRoomTitle = "Leaving Room";

	private const string LeavingRoomMsg = "Are you sure you want to leave the room";

	private const string KickUserMsg = "Are you sure you want to kick this user";

	private int _currentPlayerBeingSet;

	public bool PlayerIsTheOwner
	{
		get
		{
			return <PlayerIsTheOwner>k__BackingField;
		}
		set
		{
			<PlayerIsTheOwner>k__BackingField = value;
		}
	}

	public List<LobbyPlayerData> PlayersInLobby => _playersInLobby;

	public event LobbyChangedDel OnPlayerListChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2192;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2192;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected I4, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = (nint)0 + (nint)3928;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 160;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj8 = this + 168;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v5-48]");
		((LobbyStartButton)0).Initialize(this);
		SetButtonsCommands();
		if (<PlayerIsTheOwner>k__BackingField)
		{
			List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			object obj10 = playersInTeamOne._size + playersInTeamTwo._size;
			bool flag2 = (nint)obj10 < 0;
			bool flag3 = obj10 == null;
			object obj11 = obj10 ^ obj10;
			object obj12 = obj10 & obj11;
			bool flag4 = (nint)obj12 < 0;
			bool flag5 = flag2 == flag4;
			object obj13 = !flag3;
			bool ready = (byte)((flag5 & obj13) ? 1 : 0) != 0;
			playNowButton.SetReady(ready);
		}
	}

	public void ExitLobby()
	{
		//IL_0015: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I4
		//IL_004b: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0164: Expected I, but got O
		object obj = invitePanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v2 (System.Object)+20]");
		PopupUI popupUI = (PopupUI)0;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			object obj2 = (nint)0 + (nint)3224;
			object obj3 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj, (IntPtr)obj2);
			popupUI.ShrinkToParent(action);
			return;
		}
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)1544;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object msgTitle = "LAK" + 944;
		object msgBody = "Added Tournament Prizes And Features" + 2192;
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action2);
	}

	public void ShowInvitePanel()
	{
		InvitePanel invitePanel = this.invitePanel;
		invitePanel.popup.PopFromCenter();
		invitePanel.OnOpen();
	}

	public void SetServerConnector(LobbyServerConnector c)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 168;
		obj = c;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetOwnerView(bool isOwner)
	{
		<PlayerIsTheOwner>k__BackingField = isOwner;
		playNowButton.SetWaitingForHost();
		RefreshTeamsArea();
		RefreshSpectatorsArea();
	}

	public void StartGame()
	{
		_serverConnector.SendStartGame();
		panelArea.SetActive(value: false);
	}

	public void Show()
	{
		panelArea.SetActive(value: true);
	}

	public void Hide()
	{
		panelArea.SetActive(value: false);
	}

	public void SetPlayers(List<LobbyPlayerData> data)
	{
		//IL_02d2: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_002a: Expected O, but got I
		//IL_0221: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		ClearEverything();
		List<LobbyPlayerData> list = default(List<LobbyPlayerData>);
		bool flag = list == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)3088;
			object obj3 = (nint)0 + (nint)3272;
			obj = (nint)0 + (nint)3080;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			while (true)
			{
				list = (List<LobbyPlayerData>)obj2;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				List<object> playersInLobby = (List<object>)(object)_playersInLobby;
				if (_playersInLobby != null)
				{
					object obj4 = obj3;
					int version = playersInLobby._version + 1;
					playersInLobby._version = version;
					object[] items = playersInLobby._items;
					bool flag2 = playersInLobby._items == null;
					list = null;
					if (!flag2)
					{
						bool flag3 = playersInLobby._size < items.Length;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v11+20]");
							object obj6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v13+C0]");
							object obj7 = 0;
							((List<object>)(object)_playersInLobby).AddWithResize((object)null);
						}
						else
						{
							int size = playersInLobby._size + 1;
							playersInLobby._size = size;
							object obj8 = playersInLobby._items + playersInLobby._size;
							object obj9 = obj8 + 32;
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						continue;
					}
				}
				goto IL_020e;
			}
			list = (List<LobbyPlayerData>)obj;
			enumerator2.Dispose();
			goto IL_01c5;
		}
		goto IL_02e0;
		IL_02e0:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = (nint)list != 1;
		NullReferenceException ex2 = ex;
		object obj11;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<LobbyPlayerData>)obj;
			enumerator2.Dispose();
			object obj10 = default(object);
			if (obj10 == null)
			{
				goto IL_01c5;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj11 = obj10;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EE78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_01c5:
		RefreshTeamsArea();
		RefreshSpectatorsArea();
		LobbyChangedDel onPlayerListChanged = this.OnPlayerListChanged;
		if (this.OnPlayerListChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v227.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		return;
		IL_020e:
		NullReferenceException ex4 = new NullReferenceException();
		obj11 = 0;
		goto IL_02e0;
	}

	public void SendKickCommand(int playerID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3984;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3968;
		object msgBody = "Added Tournament Prizes And Features" + 2184;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	public void SendSetTeamCommand(int playerID, int team)
	{
		_serverConnector.SendSetTeamCommand(playerID, team);
		pickTeam1Button.SetActive(value: false);
		pickTeam2Button.SetActive(value: false);
		cancelPick.SetActive(value: false);
	}

	public void ShowAvailableSeats(int playerID)
	{
		if (<PlayerIsTheOwner>k__BackingField)
		{
			_currentPlayerBeingSet = playerID;
			List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
			if (playersInTeamOne._size <= 1)
			{
				pickTeam1Button.SetActive(value: true);
			}
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			if (playersInTeamTwo._size <= 1)
			{
				pickTeam2Button.SetActive(value: true);
			}
			cancelPick.SetActive(value: true);
		}
	}

	private void SetButtonsCommands()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_008e: Expected I, but got O
		//IL_00a8: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00e0: Expected I, but got O
		//IL_00fa: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_0132: Expected I, but got O
		//IL_014c: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_022f: Expected O, but got I4
		//IL_0268: Expected O, but got I
		//IL_0283: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj6 = (nint)0 + (nint)1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v10+100]");
		((UnityEvent)0).AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj7 = (nint)0 + (nint)1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v15+100]");
		((UnityEvent)0).AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj8 = (nint)0 + (nint)1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v20+100]");
		((UnityEvent)0).AddListener(unityAction3);
		GameObject gameObject = customRulesButton.gameObject;
		gameObject.SetActive(value: false);
		Room room = game.Room;
		if (SFSKammelnaRoomExtensions.GetJackarooCustomRules(room) != JackarooAllowedRules.DEFAULT)
		{
			GameObject gameObject2 = customRulesButton.gameObject;
			object obj9 = typeof(SqlSingle[]) + 3912;
			gameObject2.SetActive(value: true);
			RectTransform rectTransform = UIExtensions.rectTransform(customRulesButton);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			Transform rect = rectTransform;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				rect = rectTransform;
			}
			AnimationExtensions.AnimEmphasise(rect, 2);
			Button button = customRulesButton;
			object obj12 = (nint)0 + (nint)3992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction4 = default(UnityAction);
			unityAction4..ctor(obj2, (IntPtr)obj12);
			button.m_OnClick.AddListener(unityAction4);
		}
		pickTeam1Button.SetActive(value: false);
		pickTeam2Button.SetActive(value: false);
		cancelPick.SetActive(value: false);
	}

	private void CheckIfGameReadyToStart()
	{
		//IL_004d: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I4, but got Unknown
		if (<PlayerIsTheOwner>k__BackingField)
		{
			List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			object obj = playersInTeamOne._size + playersInTeamTwo._size;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			object obj2 = obj ^ obj;
			object obj3 = obj & obj2;
			bool flag3 = (nint)obj3 < 0;
			bool flag4 = flag == flag3;
			object obj4 = !flag2;
			bool ready = (byte)((flag4 & obj4) ? 1 : 0) != 0;
			playNowButton.SetReady(ready);
		}
	}

	private void ExitGame()
	{
		game.ExitGame();
	}

	private void SetSelectedPlayerToTeam1()
	{
		SendSetTeamCommand(_currentPlayerBeingSet, 1);
	}

	private void SetSelectedPlayerToTeam2()
	{
		SendSetTeamCommand(_currentPlayerBeingSet, 2);
	}

	private void CancelPick()
	{
		pickTeam1Button.SetActive(value: false);
		pickTeam2Button.SetActive(value: false);
		cancelPick.SetActive(value: false);
	}

	private void HidePickTeamButtons()
	{
		pickTeam1Button.SetActive(value: false);
		pickTeam2Button.SetActive(value: false);
		cancelPick.SetActive(value: false);
	}

	private bool Team1HasSlots()
	{
		//IL_0094: Expected I4, but got O
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
		if (_playersInTeamOne != null)
		{
			object obj = playersInTeamOne._size - 2;
			bool flag = (nint)obj < 0;
			int num = playersInTeamOne._size ^ 2;
			int num2 = playersInTeamOne._size ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			return !flag3;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool Team2HasSlots()
	{
		//IL_0094: Expected I4, but got O
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
		if (_playersInTeamTwo != null)
		{
			object obj = playersInTeamTwo._size - 2;
			bool flag = (nint)obj < 0;
			int num = playersInTeamTwo._size ^ 2;
			int num2 = playersInTeamTwo._size ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			return !flag3;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool TeamsAreFull()
	{
		//IL_00e0: Expected I4, but got O
		//IL_0048: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_00c0: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I4, but got Unknown
		List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
		if (_playersInTeamOne != null)
		{
			if (playersInTeamOne._size < 2)
			{
				return false;
			}
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			if (_playersInTeamTwo != null)
			{
				object obj = playersInTeamTwo._size - 1;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				int num = playersInTeamTwo._size ^ 1;
				int num2 = playersInTeamTwo._size ^ obj;
				int num3 = num & num2;
				bool flag3 = num3 < 0;
				bool flag4 = flag == flag3;
				object obj2 = !flag2;
				return (byte)((flag4 & obj2) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void Refresh()
	{
		RefreshTeamsArea();
		RefreshSpectatorsArea();
	}

	private unsafe void RefreshSpectatorsArea()
	{
		//IL_0010: Expected O, but got I
		//IL_001c: Expected O, but got I
		//IL_027b: Expected O, but got I4
		//IL_002f: Expected O, but got I
		//IL_003b: Expected O, but got I
		//IL_0052: Expected O, but got Ref
		//IL_00cc: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_0192: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C86]");
		object obj = 0;
		object obj2 = (nint)0 + (nint)1512;
		LobbyPlayerData lobbyPlayerData = (LobbyPlayerData)(object)_spectatorsOnline;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		bool flag = _playersInLobby == null;
		object obj3 = 152993792;
		object obj4 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			obj3 = (nint)0 + (nint)1696;
			obj4 = (nint)0 + (nint)3080;
			List<object>.Enumerator enumerator = ((List<object>)(object)_playersInLobby).GetEnumerator();
			obj = (object)(&enumerator2);
			object obj5;
			if (!enumerator2.MoveNext())
			{
				lobbyPlayerData = (LobbyPlayerData)obj4;
				enumerator2.Dispose();
				obj5 = 0;
				goto IL_00d2;
			}
			LobbyPlayerData lobbyPlayerData2 = null;
			NullReferenceException ex = new NullReferenceException();
			obj5 = 0;
			lobbyPlayerData = null;
		}
		goto IL_0289;
		IL_0289:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)lobbyPlayerData != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			lobbyPlayerData = (LobbyPlayerData)obj4;
			enumerator2.Dispose();
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			object obj5 = obj6;
			if (flag3)
			{
				goto IL_00d2;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EE78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00d2:
		IEnumerable<object> spectatorsOnline = _spectatorsOnline;
		if (_spectatorsOnline != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v19 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			if ((nint)0 <= (nint)0)
			{
				return;
			}
			lobbyPlayerData = (LobbyPlayerData)obj3;
			object obj7 = Enumerable.Last((IEnumerable<object>)_spectatorsOnline);
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v21 (System.Object)+70]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v21 (System.Object)+70]");
					((Behaviour)0).enabled = false;
					return;
				}
			}
		}
		goto IL_0289;
	}

	private void ShowPlayerInSpectators(LobbyPlayerData player)
	{
		//IL_000c: Expected O, but got I
		//IL_0065: Expected O, but got I4
		//IL_00e6: Expected I, but got O
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_0123: Expected O, but got I
		//IL_0182: Expected O, but got I
		object obj = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB5740");
		List<object> spectatorsOnline = (List<object>)(object)_spectatorsOnline;
		int version = spectatorsOnline._version + 1;
		spectatorsOnline._version = version;
		object[] items = spectatorsOnline._items;
		bool flag = spectatorsOnline._size < items.Length;
		object obj2 = !flag;
		object obj5 = default(object);
		if (obj2 == null)
		{
			int size = spectatorsOnline._size + 1;
			spectatorsOnline._size = size;
			object obj3 = items + spectatorsOnline._size;
			object obj4 = obj3 + 32;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			spectatorsOnline.AddWithResize(obj5);
		}
		nint num = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ X8_v8 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+30]");
		LobbyPanel lobbyPanel = default(LobbyPanel);
		bool flag2 = lobbyPanel.PlayerIsOwnerOfRoom(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+28]");
		((Behaviour)0).enabled = flag2;
		List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
		if (playersInTeamOne._size >= 2)
		{
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			if (playersInTeamTwo._size >= 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+50]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
			}
		}
	}

	private T CreateStrip<T>(GameObject prefab, Transform parent)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0071: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject = default(GameObject);
		if ((object)gameObject != null)
		{
			return gameObject.GetComponent<T>();
		}
		return (T)new NullReferenceException();
	}

	private void RefreshTeamsArea()
	{
		//IL_026a: Expected O, but got I
		//IL_0013: Expected O, but got I
		//IL_0093: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		LobbyPlayerData lobbyPlayerData = (LobbyPlayerData)(object)_playersInTeamTwo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (_playersInLobby != null)
		{
			object obj2 = (nint)0 + (nint)3080;
			List<object>.Enumerator enumerator = ((List<object>)(object)_playersInLobby).GetEnumerator();
			object obj3;
			if (!enumerator2.MoveNext())
			{
				lobbyPlayerData = (LobbyPlayerData)obj2;
				enumerator2.Dispose();
				obj3 = 0;
				goto IL_0099;
			}
			LobbyPlayerData lobbyPlayerData2 = null;
			NullReferenceException ex = new NullReferenceException();
			obj3 = 0;
			lobbyPlayerData = null;
		}
		goto IL_026f;
		IL_026f:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = (nint)lobbyPlayerData != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8000]");
			lobbyPlayerData = (LobbyPlayerData)0;
			enumerator2.Dispose();
			object obj4 = default(object);
			bool flag2 = obj4 == null;
			object obj3 = obj4;
			if (flag2)
			{
				goto IL_0099;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EE78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0099:
		if (!<PlayerIsTheOwner>k__BackingField)
		{
			return;
		}
		List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
		if (_playersInTeamOne != null)
		{
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			if (_playersInTeamTwo != null && (object)playNowButton != null)
			{
				object obj5 = playersInTeamOne._size + playersInTeamTwo._size;
				bool flag3 = (nint)obj5 < 0;
				bool flag4 = obj5 == null;
				object obj6 = obj5 ^ obj5;
				object obj7 = obj5 & obj6;
				bool flag5 = (nint)obj7 < 0;
				bool flag6 = flag3 == flag5;
				object obj8 = !flag4;
				bool ready = (byte)((flag6 & obj8) ? 1 : 0) != 0;
				playNowButton.SetReady(ready);
				return;
			}
		}
		goto IL_026f;
	}

	private void ClearTeams()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
	}

	private void ClearStripList<T>(ICollection<T> list) where T : MonoBehaviour
	{
		//IL_003c: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_0788: Expected I, but got O
		//IL_0798: Expected O, but got I
		//IL_0153: Expected I, but got O
		//IL_080e: Expected O, but got I
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_07d5: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I4
		//IL_01d8: Expected O, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_02a7: Expected I, but got O
		//IL_0898: Expected O, but got I
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		//IL_04a5: Expected O, but got I4
		//IL_04ae: Expected O, but got I4
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_085e: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_099c: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04e7: Expected O, but got I
		//IL_030d: Expected O, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0335: Expected O, but got I4
		//IL_05c3: Expected O, but got I
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Expected O, but got Unknown
		//IL_05eb: Expected O, but got I4
		//IL_0582: Expected I, but got O
		//IL_08e5: Expected O, but got I
		//IL_09f5: Expected I, but got O
		//IL_0a05: Expected O, but got I
		//IL_09de: Expected O, but got I
		//IL_0522: Expected O, but got I
		//IL_040a: Expected I, but got O
		//IL_095b: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_062c: Expected O, but got I
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_0921: Expected O, but got I
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_054b: Expected O, but got I
		//IL_047e: Expected O, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_069b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Expected O, but got Unknown
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		bool flag = list == null;
		ICollection<T> collection = list;
		object obj = 0;
		if (flag)
		{
			goto IL_0775;
		}
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		nint num = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
		}
		nint num2 = (nint)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v23 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v23 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0144;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v23 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		bool flag4 = default(bool);
		bool flag3 = flag4;
		object obj8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v35-8]");
			object obj7 = -num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v35-8]");
			if (0 == num)
			{
				break;
			}
			obj8 = obj6 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v23 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			obj5 = -1;
			obj7 = obj5 - 1;
			bool flag5 = obj7 == null;
			flag4 = (nint)obj5 != 1;
			flag3 = flag4;
			obj6 = obj8;
			if (flag4)
			{
				continue;
			}
			goto IL_0144;
		}
		obj5 = obj6;
		object obj9 = num2 + obj6;
		object obj10 = obj9 + 312;
		flag4 = flag3;
		obj8 = obj6;
		goto IL_07fe;
		IL_0775:
		throw new NullReferenceException();
		IL_07fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v32+8]");
		collection = (ICollection<T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X0_v32] (should have been resolved before IL gen)");
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj13 = default(object);
		Component component = default(Component);
		object obj22 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		object obj41 = default(object);
		object obj30;
		nint num3;
		while (true)
		{
			if (obj13 != null)
			{
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+12E]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0298;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+B0]");
				object obj15 = (nint)0 + (nint)8;
				bool flag6 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X10_v30-8]");
					object obj7 = 0 - obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X10_v30-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj8 = obj15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v29+12E]");
					obj5 = -1;
					obj7 = obj5 - 1;
					bool flag5 = obj7 == null;
					flag4 = (nint)obj5 != 1;
					flag6 = flag4;
					obj15 = obj8;
					if (flag4)
					{
						continue;
					}
					goto IL_0298;
				}
				obj5 = obj15;
				object obj16 = obj14 + obj15;
				object obj17 = obj16 + 312;
				flag4 = flag6;
				obj8 = obj15;
				goto IL_0887;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0a4e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v670 @ X0_v5] (should have been resolved before IL gen)");
			return;
			IL_066d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 3;
			goto IL_0a4e;
			IL_094a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v43+8]");
			collection = (ICollection<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v698 @ X0_v43] (should have been resolved before IL gen)");
			if ((object)component != null)
			{
				GameObject obj18 = component.gameObject;
				object obj19 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v48+E4]");
				bool flag7 = (nint)0 == 0;
				object obj20 = !flag7;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				UnityEngine.Object.Destroy(obj18);
				collection = null;
				continue;
			}
			NullReferenceException ex2 = new NullReferenceException();
			break;
			IL_03fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = unchecked((nint)null);
			goto IL_094a;
			IL_0298:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = unchecked((nint)null);
			goto IL_0887;
			IL_0887:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v38+8]");
			collection = (ICollection<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v496 @ X0_v38] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				if (obj13 != null)
				{
					object obj23 = (nint)0 + (nint)309;
					object obj24 = obj23 & 1;
					bool flag8 = obj24 == null;
					object obj25 = !flag8;
					nint num4 = 0;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num4 = intPtr2;
					}
					object obj26 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v35+12E]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v35+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v35+B0]");
					object obj27 = (nint)0 + (nint)8;
					bool flag9 = flag4;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X10_v25-8]");
						object obj7 = -num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X10_v25-8]");
						if (0 == num4)
						{
							break;
						}
						obj8 = obj27 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v35+12E]");
						obj5 = -1;
						obj7 = obj5 - 1;
						bool flag5 = obj7 == null;
						flag4 = (nint)obj5 != 1;
						flag9 = flag4;
						obj27 = obj8;
						if (flag4)
						{
							continue;
						}
						goto IL_03fb;
					}
					obj5 = obj27;
					object obj28 = obj26 + obj27;
					object obj29 = obj28 + 312;
					flag4 = flag9;
					obj8 = obj27;
					goto IL_094a;
				}
				NullReferenceException ex3 = new NullReferenceException();
				break;
			}
			obj30 = 0;
			object obj31 = 0;
			obj = obj13;
			nint num5;
			while (true)
			{
				if (obj == null)
				{
					goto IL_0982;
				}
				object obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj33 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v14+12E]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v14+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0573;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v14+B0]");
				object obj34 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X10_v13-8]");
					if (0 == (nint)obj32)
					{
						break;
					}
					obj8 = obj34 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v14+12E]");
					obj5 = -1;
					bool flag10 = (nint)obj5 != 1;
					obj34 = obj8;
					if (flag10)
					{
						continue;
					}
					goto IL_0573;
				}
				obj5 = obj34;
				object obj35 = obj33 + obj34;
				object obj36 = obj35 + 312;
				obj8 = obj34;
				goto IL_09ce;
				IL_0982:
				bool flag11 = obj31 == null;
				object obj37 = !flag11;
				if (obj37 == null)
				{
					object obj38 = (nint)0 + (nint)309;
					object obj39 = obj38 & 1;
					bool flag12 = obj39 == null;
					object obj40 = !flag12;
					num5 = 0;
					if (obj40 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num5 = intPtr3;
					}
					break;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if ((nint)collection == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj31 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj30 = obj41;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
				IL_0573:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num3 = unchecked((nint)null);
				goto IL_09ce;
				IL_09ce:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v13+8]");
				collection = (ICollection<T>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v13] (should have been resolved before IL gen)");
				goto IL_0982;
			}
			nint num6 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v8 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v8 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_066d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v8 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+B0]");
			object obj43 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X10_v7-8]");
				if (0 == num5)
				{
					break;
				}
				obj43 += 16;
				obj42--;
				if ((nint)obj42 != 1)
				{
					continue;
				}
				goto IL_066d;
			}
			object obj44 = obj43 + 3;
			object obj45 = num6 + obj44;
			object obj46 = obj45 + 312;
			goto IL_0a4e;
		}
		obj30 = 0;
		obj = obj13;
		goto IL_0775;
		IL_0144:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = unchecked((nint)null);
		goto IL_07fe;
	}

	private bool PlayerIsInTeam(LobbyPlayerData player)
	{
		//IL_0066: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0053: Expected I4, but got O
		if (player != null)
		{
			object obj = player.Team - 1;
			bool flag = (nint)obj < 2;
			object obj2 = !flag;
			return (byte)(int)(~obj2) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ShowPlayerInTeam(LobbyPlayerData playerData)
	{
		//IL_0011: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_01c1: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_0173: Expected I, but got O
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I
		object obj = (nint)0 + (nint)1520;
		object obj2;
		if (playerData.Team != 1)
		{
			if (playerData.Team != 2)
			{
				obj2 = 0;
				goto IL_01db;
			}
			object obj3 = 88;
		}
		else
		{
			object obj3 = 80;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LobbyPanel)+v160 @ X9_v9]");
		obj2 = 0;
		goto IL_01db;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB5740");
		if (playerData.Team == 1)
		{
			object obj4 = 192;
		}
		else
		{
			object obj4 = 200;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LobbyPanel)+v134 @ X8_v8]");
		List<object> list = (List<object>)0;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj5 = !flag;
		object obj8 = default(object);
		if (obj5 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj6 = items + list._size;
			object obj7 = obj6 + 32;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj8);
		}
		nint num = (nint)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ X8_v13 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v5 (System.Object)+30]");
		LobbyPanel lobbyPanel = default(LobbyPanel);
		bool flag2 = lobbyPanel.PlayerIsOwnerOfRoom(0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v5 (System.Object)+28]");
		((Behaviour)0).enabled = flag2;
	}

	private Transform getPlayerArea(int team)
	{
		//IL_005c: Expected O, but got I4
		//IL_0069: Expected O, but got I
		//IL_0046: Expected O, but got I4
		//IL_0053: Expected O, but got I
		switch (team)
		{
		case 2:
		{
			object obj2 = 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LobbyPanel)+v23 @ X8_v2]");
			return (Transform)0;
		}
		case 1:
		{
			object obj = 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LobbyPanel)+v20 @ X8_v1]");
			return (Transform)0;
		}
		default:
			return null;
		}
	}

	private List<InTeamPlayerStrip> GetTeamList(int team)
	{
		//IL_0037: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0029: Expected O, but got I4
		if (team == 1)
		{
			object obj = 192;
		}
		else
		{
			object obj = 200;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LobbyPanel)+v15 @ X8_v2]");
		return (List<InTeamPlayerStrip>)0;
	}

	private void ClearEverything()
	{
		//IL_0335: Expected O, but got I
		//IL_0364: Expected I4, but got O
		//IL_0388: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_00e4: Expected I4, but got O
		//IL_00f7: Expected O, but got I4
		//IL_02e1: Expected I4, but got O
		//IL_011f: Expected O, but got I4
		//IL_026b: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		object obj = (nint)0 + (nint)1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		List<InTeamPlayerStrip> list = _playersInTeamTwo;
		int num = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EB53CC");
		bool flag = _spectatorsOnline == null;
		object obj2 = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		int num2;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)3112;
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			obj2 = (nint)0 + (nint)3104;
			List<object>.Enumerator enumerator = ((List<object>)(object)_spectatorsOnline).GetEnumerator();
			list = (List<InTeamPlayerStrip>)obj3;
			object obj5;
			if (!enumerator2.MoveNext())
			{
				num2 = (int)obj2;
				enumerator2.Dispose();
				obj5 = 0;
				goto IL_00fc;
			}
			NullReferenceException ex = new NullReferenceException();
			obj5 = 0;
		}
		goto IL_033a;
		IL_033a:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)list != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<InTeamPlayerStrip>)obj2;
			enumerator2.Dispose();
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			object obj5 = obj6;
			num2 = (int)obj2;
			if (flag3)
			{
				goto IL_00fc;
			}
			ex3 = new OutOfMemoryException();
			obj5 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223F130");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00fc:
		List<LobbyPlayerStrip> spectatorsOnline = _spectatorsOnline;
		bool flag4 = _spectatorsOnline == null;
		list = (List<InTeamPlayerStrip>)num2;
		if (!flag4)
		{
			num = spectatorsOnline._size;
			int version = spectatorsOnline._version + 1;
			spectatorsOnline._size = 0;
			spectatorsOnline._version = version;
			if (spectatorsOnline._size >= 1)
			{
				Array.Clear(spectatorsOnline._items, 0, spectatorsOnline._size);
				num2 = 0;
			}
			List<LobbyPlayerData> playersInLobby = _playersInLobby;
			bool flag5 = _playersInLobby == null;
			list = (List<InTeamPlayerStrip>)num2;
			if (!flag5)
			{
				int version2 = playersInLobby._version + 1;
				playersInLobby._size = 0;
				playersInLobby._version = version2;
				if (playersInLobby._size >= 1)
				{
					Array.Clear(playersInLobby._items, 0, playersInLobby._size);
				}
				return;
			}
		}
		goto IL_033a;
	}

	private bool GameHaveEnoughPlayers()
	{
		//IL_00c5: Expected I4, but got O
		//IL_0045: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected I4, but got Unknown
		List<InTeamPlayerStrip> playersInTeamOne = _playersInTeamOne;
		if (_playersInTeamOne != null)
		{
			List<InTeamPlayerStrip> playersInTeamTwo = _playersInTeamTwo;
			if (_playersInTeamTwo != null)
			{
				object obj = playersInTeamTwo._size + playersInTeamOne._size;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				object obj2 = obj ^ obj;
				object obj3 = obj & obj2;
				bool flag3 = (nint)obj3 < 0;
				bool flag4 = flag == flag3;
				object obj4 = !flag2;
				return (byte)((flag4 & obj4) ? 1 : 0) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool PlayerIsOwnerOfRoom(int playerId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0199: Expected I4, but got O
		//IL_017d: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C88]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		KGame kGame = default(KGame);
		bool flag3 = (object)kGame == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_018b;
		IL_00b8:
		Room room = kGame.Room;
		int roomOwnerId = SFSKammelnaRoomExtensions.GetRoomOwnerId(room);
		object obj9 = roomOwnerId - playerId;
		return obj9 == null;
		IL_018b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		if ((object)kGame != null)
		{
			goto IL_00b8;
		}
		goto IL_018b;
	}

	public void ShowChat()
	{
		gameEventsChannel.TriggerShowChat();
	}

	public LobbyPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2136;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2144;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 176;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj5 = this + 184;
		obj5 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj6 = this + 192;
		obj6 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		object obj7 = this + 200;
		obj7 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
