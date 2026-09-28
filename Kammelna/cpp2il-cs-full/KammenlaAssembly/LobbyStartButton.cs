using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LobbyStartButton : MonoBehaviour
{
	private TextMeshProUGUI shownText;

	private TextMeshProUGUI waitingForHost;

	private LobbyPanel panel;

	public void Initialize(LobbyPanel panel)
	{
		//IL_000c: Expected O, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		object obj = (nint)0 + (nint)3640;
		object obj2 = this + 48;
		LobbyPanel lobbyPanel = default(LobbyPanel);
		obj2 = lobbyPanel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj4 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v6+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private void Clicked()
	{
		LobbyPanel lobbyPanel = panel;
		lobbyPanel._serverConnector.SendStartGame();
		lobbyPanel.panelArea.SetActive(value: false);
	}

	public void SetWaitingForHost()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable = default(Selectable);
		selectable.interactable = false;
		GameObject gameObject = waitingForHost.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = shownText.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void SetReady(bool isReady)
	{
		//IL_004c: Expected O, but got I
		GameObject gameObject = shownText.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = waitingForHost.gameObject;
		object obj = (nint)0 + (nint)3640;
		gameObject2.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Selectable selectable = default(Selectable);
		selectable.interactable = isReady;
	}
}
