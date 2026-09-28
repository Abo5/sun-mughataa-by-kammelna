using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayTimeCounter : MonoBehaviour
{
	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0048: Invalid comparison between F4 and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		//IL_006c: Expected F4, but got I8
		object obj = typeof(UsageHint) + 72;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int timePlayed = UserInfo.TimePlayed;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		float num = ((timeSinceLevelLoad != 2.139095E+09f) ? timeSinceLevelLoad : 2.1474836E+09f);
		int timePlayed2 = (int)(num + timePlayed);
		UserInfo.TimePlayed = timePlayed2;
	}
}
