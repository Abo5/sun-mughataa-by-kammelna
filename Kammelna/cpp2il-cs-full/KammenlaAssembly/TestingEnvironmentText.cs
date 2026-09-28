using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine;

public class TestingEnvironmentText : MonoBehaviour
{
	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_00f1: Expected I, but got O
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		gameObject.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (Config.IsInitialized)
			{
				goto IL_0076;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isInitialized = Config.IsInitialized;
			bool flag = !isInitialized;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_0076;
			}
		}
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)1544;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(1f, action);
		return;
		IL_0076:
		<Start>g__InitEnvironmentText|0_0();
	}

	private unsafe void <Start>g__InitEnvironmentText|0_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0106: Expected O, but got I4
		//IL_004a: Expected O, but got Ref
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = (nint)0 + (nint)152;
		object obj3 = "1.2.840.113549.1.12.1.5" + 1496;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ServerEnvironment environment = Config.Environment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj6 = default(object);
		string text = ((Enum)(&obj6)).ToString();
		string backendURL = Config.BackendURL;
		string text2 = text + (string)obj3 + backendURL;
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X8_v6+558] (should have been resolved before IL gen)");
		GameObject gameObject = base.gameObject;
		bool flag2 = EnvironmentExtensions.IsProduction(environment);
		bool active = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}
}
