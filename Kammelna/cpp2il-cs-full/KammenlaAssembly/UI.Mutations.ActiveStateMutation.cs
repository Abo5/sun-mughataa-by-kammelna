using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.Mutations;

[Serializable]
public class ActiveStateMutation : IMutation
{
	private enum ActiveMode
	{
		Enable,
		Disable
	}

	private ActiveMode mode;

	private GameObject[] objects;

	public void Setup(GameObject gm)
	{
	}

	public void Teardown()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		//IL_024c: Expected O, but got I
		//IL_025c: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_02b2: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0191: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_031c: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_0342: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_037d: Expected O, but got I
		object obj = 152989696;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DC7]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v9+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v9+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_008d;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v9+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v9+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_008d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v2+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v9+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v9+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v9+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_00f6;
		}
		goto IL_02c0;
		IL_019f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_01ae;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v9+38]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v18+10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v18+10]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v18+10]");
		object obj19 = 0;
		if (obj18 == null)
		{
			goto IL_019f;
		}
		goto IL_01ae;
		IL_01ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+B8]");
		object obj20 = 0;
		object obj21 = this + 24;
		obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_008d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v23+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v23+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag5 = obj23 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v23+10]");
		obj13 = 0;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_00f6;
		}
		goto IL_02c0;
		IL_02c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		obj4 = obj6;
		if (obj24 != null)
		{
			goto IL_0123;
		}
		goto IL_0302;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		obj6 = obj4;
		if (!flag7)
		{
			goto IL_0123;
		}
		goto IL_0302;
		IL_0302:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v2+38]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v3+10]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v3+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		if (obj27 == null)
		{
			goto IL_019f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v3+10]");
		obj19 = 0;
		goto IL_01ae;
	}

	public void PerformMutation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(objects, action);
	}

	public void UndoMutation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(objects, action);
	}

	private void <PerformMutation>b__5_0(GameObject go)
	{
		bool active = mode == ActiveMode.Enable;
		go.SetActive(active);
	}

	private void <UndoMutation>b__6_0(GameObject go)
	{
		bool flag = mode == ActiveMode.Enable;
		bool active = !flag;
		go.SetActive(active);
	}
}
