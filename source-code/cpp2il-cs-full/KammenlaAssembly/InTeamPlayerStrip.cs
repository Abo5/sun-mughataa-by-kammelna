using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InTeamPlayerStrip : PlayerStrip
{
	private Button rightButton;

	private Button leftButton;

	private Button pickTeam;

	public override void SetPlayer(LobbyPlayerData player, LobbyPanel pnl, bool showControlButtons)
	{
		base.SetPlayer(player, pnl, showControlButtons);
		ShowKickButtons(player.Team, showControlButtons);
		SetClickListeners();
	}

	private void ShowKickButtons(int team, bool showOwnerControls)
	{
		//IL_0054: Expected O, but got I4
		//IL_00c5: Expected O, but got I4
		if (!showOwnerControls)
		{
			return;
		}
		LobbyPlayerData lobbyPlayerData = base.<playerData>k__BackingField;
		bool flag = SFSKammelnaUserExtensions.IsTV(lobbyPlayerData.User);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		Component component;
		GameObject gameObject;
		switch (team)
		{
		case 1:
		{
			component = rightButton;
			bool flag3 = (object)rightButton == null;
			object obj2 = !flag3;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00e8;
		}
		case 2:
			{
				component = leftButton;
				goto IL_00e8;
			}
			IL_00e8:
			gameObject = component.gameObject;
			gameObject.SetActive(value: true);
			break;
		}
	}

	private void SetClickListeners()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_007b: Expected I, but got O
		//IL_00ad: Expected O, but got I
		//IL_00c5: Expected I, but got O
		Button button = rightButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = leftButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj2);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = pickTeam;
		object obj3 = (nint)0 + (nint)2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj3);
		button3.m_OnClick.AddListener(unityAction3);
	}

	private void RemoveFromTeam()
	{
		_panel.SendSetTeamCommand(base.<Id>k__BackingField, 0);
	}

	private void PickTeam()
	{
		_panel.ShowAvailableSeats(base.<Id>k__BackingField);
	}

	private void ShowKickButton(Button b)
	{
		GameObject gameObject = b.gameObject;
		gameObject.SetActive(value: true);
	}
}
