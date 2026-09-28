using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

public class LobbyFakeServerConnector : LobbyServerConnector
{
	private LobbyFakeServer _fakeServer;

	protected override void AddServerListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)152;
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2160;
		object obj4 = (nint)0 + (nint)1496;
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
		LobbyFakeServer.ServerUpdateDel serverUpdateDel = default(LobbyFakeServer.ServerUpdateDel);
		serverUpdateDel..ctor(this, (IntPtr)obj4);
		object obj9 = obj7 + 40;
		Delegate obj10 = (Delegate)obj9;
		bool flag2;
		Delegate obj12 = default(Delegate);
		do
		{
			Delegate obj11 = Delegate.Combine(obj10, serverUpdateDel);
			if ((object)obj11 == null || obj11 == obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj10;
				obj10 = obj12;
				continue;
			}
			throw new InvalidCastException();
		}
		while (!flag2);
	}

	public override void SendKickCommand(int playerId)
	{
		_fakeServer.KickPlayer(playerId);
	}

	public override void SendSetTeamCommand(int playerId, int team)
	{
		_fakeServer.SetPlayerTeam(playerId, team);
	}

	public override void SendStartGame()
	{
		LobbyFakeServer fakeServer = _fakeServer;
		LobbyFakeServer.VoidDelegate gameStarted = fakeServer.GameStarted;
		if (fakeServer.GameStarted != null)
		{
			IntPtr invoke_impl = ((Delegate)gameStarted).invoke_impl;
			IntPtr method_code = ((Delegate)gameStarted).method_code;
			IntPtr method = ((Delegate)gameStarted).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v26 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void UpdateLobby(List<LobbyPlayerData> players)
	{
		LobbyPanel lobbyPanel = panel;
		lobbyPanel.<PlayerIsTheOwner>k__BackingField = true;
		lobbyPanel.playNowButton.SetWaitingForHost();
		lobbyPanel.RefreshTeamsArea();
		lobbyPanel.RefreshSpectatorsArea();
		panel.SetPlayers(players);
	}

	private void SetOwnerView()
	{
		LobbyPanel lobbyPanel = panel;
		lobbyPanel.<PlayerIsTheOwner>k__BackingField = true;
		lobbyPanel.playNowButton.SetWaitingForHost();
		lobbyPanel.RefreshTeamsArea();
		lobbyPanel.RefreshSpectatorsArea();
	}
}
