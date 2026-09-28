using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class GameObjectCloner : MonoBehaviour
{
	private GameObject _gameObject;

	private Transform newParent;

	private unsafe void Start()
	{
		//IL_0011: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_0068: Expected O, but got I4
		object obj = (nint)0 + (nint)1816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj3 = default(object);
		bool flag = obj3 == null;
		Behaviour behaviour = default(Behaviour);
		bool flag2 = (byte)(&behaviour) != 0;
		if (!flag)
		{
			behaviour.enabled = false;
			flag2 = false;
			obj2 = 0;
		}
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = (nint)0 + (nint)920;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
	}
}
