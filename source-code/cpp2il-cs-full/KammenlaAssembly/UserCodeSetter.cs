using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

public class UserCodeSetter : MonoBehaviour
{
	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		object obj = (nint)0 + (nint)152;
		object obj2 = typeof(Queue<string>) + 848;
		SessionModel sessionModel = default(SessionModel);
		object obj7 = default(object);
		while (true)
		{
			object obj3 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			User localUser = sessionModel.LocalUser;
			string userCode = SFSKammelnaUserExtensions.GetUserCode(localUser);
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+558]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4+560]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X3_v1 (should have been resolved before IL gen)");
		}
	}
}
