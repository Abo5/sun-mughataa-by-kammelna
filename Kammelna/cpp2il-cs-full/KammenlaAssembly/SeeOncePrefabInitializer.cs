using System.Buffers.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

public class SeeOncePrefabInitializer : PrefabInitializer
{
	private BoolPlayerPref sawThisPopup;

	private UnityEvent onInitialize;

	private void Start()
	{
		//IL_0037: Expected O, but got I4
		BoolPlayerPref boolPlayerPref = sawThisPopup;
		bool value = boolPlayerPref.Value;
		bool flag = !value;
		object obj = !flag;
		if (obj == null)
		{
			Initialize();
			if (onInitialize != null)
			{
				onInitialize.Invoke();
			}
		}
	}

	public SeeOncePrefabInitializer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D67]");
		if ((object)((nint)0 & (nint)1) != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((object)((nint)0 != 0) != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		((MonoBehaviour)this)..ctor();
		return;
		IL_007d:
		((MonoBehaviour)this)..ctor();
	}
}
