using Cpp2ILInjected;
using UnityEngine;

public class ScriptableLogicRunner : MonoBehaviour
{
	private ScriptableBehaviorLogic[] _scriptableBehaviorsLogic;

	private void Start()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		ScriptableBehaviorLogic[] scriptableBehaviorsLogic = _scriptableBehaviorsLogic;
		if (scriptableBehaviorsLogic.Length >= 1)
		{
			object obj = scriptableBehaviorsLogic + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X22_v4+v43 @ X21_v5*8]");
				object obj3 = 0;
				obj2++;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X8_v5+178] (should have been resolved before IL gen)");
			}
			while ((nint)obj2 < scriptableBehaviorsLogic.Length);
		}
	}
}
