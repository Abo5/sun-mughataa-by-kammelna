using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class AdvancedHokomButtonScriptableBehaviorLogic : ScriptableBehaviorLogic
{
	public override void RunLogic(MonoBehaviour monoBehaviour)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0059: Expected O, but got I4
		object obj = (nint)0 + (nint)3640;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool finishedHokomTutorial = UserInfo.FinishedHokomTutorial;
		Selectable selectable = default(Selectable);
		selectable.interactable = finishedHokomTutorial;
	}
}
