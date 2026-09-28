using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

public class GameReplayTabletTopbar : MonoBehaviour
{
	private GameEventsChannel _gameEventsChannel;

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
