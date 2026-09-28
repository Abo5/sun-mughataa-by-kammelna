using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class RemoteConfigHost : MonoBehaviour
{
	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		GameObject target = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0060;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Object.DontDestroyOnLoad(target);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0060;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfig.Initialize();
		return;
		IL_0060:
		RemoteConfig.Initialize();
	}
}
