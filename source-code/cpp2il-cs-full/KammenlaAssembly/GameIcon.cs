using System.Buffers.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class GameIcon : MonoBehaviour
{
	public Button BalootButton;

	public Button TarneebButton;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		GameObject gameObject = BalootButton.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		bool active = currentGame == Games.Baloot;
		gameObject.SetActive(active);
		GameObject gameObject2 = TarneebButton.gameObject;
		Games currentGame2 = Preferences.CurrentGame;
		object obj4 = currentGame2 - 1;
		bool active2 = obj4 == null;
		gameObject2.SetActive(active2);
	}
}
