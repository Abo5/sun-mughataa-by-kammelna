using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LobbyPlayerStrip : PlayerStrip
{
	private Button kickButton;

	private Button setTeamButton;

	private GameObject pickTeamsButtonArea;

	private Button Team1SetButton;

	private Button Team2SetButton;

	private Image SeparatorLine;

	public override void SetPlayer(LobbyPlayerData player, LobbyPanel pnl, bool showControlButtons)
	{
		base.SetPlayer(player, pnl, showControlButtons);
		SetClickListeners();
		SetControlsVisibility(showControlButtons);
	}

	public void DisablePickingTeam()
	{
		GameObject gameObject = setTeamButton.gameObject;
		gameObject.SetActive(value: false);
	}

	public void HideSeparatorLine()
	{
		SeparatorLine.enabled = false;
	}

	private void SetClickListeners()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_011b: Expected I, but got O
		Button button = setTeamButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = kickButton;
		object obj3 = (nint)0 + (nint)1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button team1SetButton = Team1SetButton;
		object obj4 = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		team1SetButton.m_OnClick.AddListener(unityAction3);
		Button team2SetButton = Team2SetButton;
		object obj5 = (nint)0 + (nint)1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj5);
		team2SetButton.m_OnClick.AddListener(unityAction4);
	}

	private void SetControlsVisibility(bool showControlButtons)
	{
		if (showControlButtons)
		{
			LobbyPlayerData lobbyPlayerData = base.<playerData>k__BackingField;
			if (!SFSKammelnaUserExtensions.IsTV(lobbyPlayerData.User))
			{
				return;
			}
		}
		GameObject gameObject = kickButton.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = setTeamButton.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void SetTeamClicked()
	{
		_panel.ShowAvailableSeats(base.<Id>k__BackingField);
	}

	private void KickClicked()
	{
		_panel.SendKickCommand(base.<Id>k__BackingField);
	}

	private void SetPlayerToTeam1()
	{
		_panel.SendSetTeamCommand(base.<Id>k__BackingField, 1);
	}

	private void SetPlayerToTeam2()
	{
		_panel.SendSetTeamCommand(base.<Id>k__BackingField, 2);
	}

	private void ShowTeamOptions()
	{
		pickTeamsButtonArea.SetActive(value: true);
	}
}
