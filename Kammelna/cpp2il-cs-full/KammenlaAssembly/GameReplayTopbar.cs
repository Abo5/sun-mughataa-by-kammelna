using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class GameReplayTopbar : MonoBehaviour
{
	private GameObject _menuContent;

	private GameObject _gameContent;

	private GameEventsChannel _gameEventsChannel;

	private KGame _game;

	private void Start()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f5: Expected I, but got O
		_menuContent.SetActive(value: true);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2336;
		_gameContent.SetActive(value: false);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 56;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		((KGame)obj7).OnGameInitialized += action;
	}

	private void HandleGameInitialized()
	{
		_menuContent.SetActive(value: false);
		_gameContent.SetActive(value: true);
	}

	public void ShowChat()
	{
		_gameEventsChannel.TriggerShowChat();
	}

	public void ExitGame()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1552;
		_gameEventsChannel.TriggerExitGame();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.GameReplay, null, (Games?)(object)0);
	}

	public void ShareGame()
	{
	}
}
