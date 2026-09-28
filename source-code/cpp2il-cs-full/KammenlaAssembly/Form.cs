using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Form : MonoBehaviour
{
	private List<InputField> inputs;

	public Button submit;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_009a: Expected O, but got I
		object obj = (nint)0 + (nint)704;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list = Enumerable.ToList(source);
		object obj3 = this + 32;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 40;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4 == null;
			bool flag2 = !flag;
			object obj6 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj6 = 0;
			if (obj7 == null)
			{
				return;
			}
		}
		object obj8 = (nint)0 + (nint)224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		Button button = default(Button);
		submit = button;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Update()
	{
		//IL_01e9: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		bool flag = InputUtil.KeyPressedThisFrame(Key.Enter);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = 0;
		if (obj == null)
		{
			bool flag3 = InputUtil.KeyPressedThisFrame(Key.NumpadEnter);
			bool flag4 = !flag3;
			obj2 = 0;
			if (flag4)
			{
				goto IL_00aa;
			}
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v16+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = submit != null;
			bool flag6 = !flag5;
			object obj5 = !flag6;
			if (obj5 == null)
			{
				goto IL_00aa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(submit != null))
			{
				goto IL_00aa;
			}
		}
		Button button = submit;
		button.m_OnClick.Invoke();
		if (InputUtil.KeyPressedThisFrame(Key.Tab))
		{
			goto IL_0164;
		}
		return;
		IL_00aa:
		bool flag7 = InputUtil.KeyPressedThisFrame(Key.Tab);
		bool flag8 = !flag7;
		object obj6 = !flag8;
		if (obj6 == null)
		{
			return;
		}
		goto IL_0164;
		IL_0164:
		List<object> list = (List<object>)(object)inputs;
		if (list._size != 0)
		{
			int nextFieldIndex = GetNextFieldIndex();
			object obj7 = list.get_Item(nextFieldIndex);
			((InputField)obj7).ActivateInputField();
		}
	}

	private int GetNextFieldIndex()
	{
		//IL_0062: Expected O, but got I
		//IL_007c: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		List<object> list = (List<object>)(object)inputs;
		if (inputs == null)
		{
			goto IL_00c2;
		}
		int num = 1;
		NullReferenceException ex;
		while (true)
		{
			int num2 = num - 1;
			bool flag = num2 >= list._size;
			ex = (NullReferenceException)(object)list;
			if (flag)
			{
				break;
			}
			object obj = list.get_Item(num2);
			if (obj != null)
			{
				list = (List<object>)(object)inputs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v11 (System.Object)+1D0]");
				object obj2 = (nint)0 & (nint)1;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_00e6;
				}
				num++;
				bool flag3 = inputs == null;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					continue;
				}
			}
			goto IL_00c2;
		}
		goto IL_00d0;
		IL_00e6:
		if (inputs == null)
		{
			goto IL_00c2;
		}
		goto IL_0105;
		IL_0105:
		if (num == list._size)
		{
			return 0;
		}
		return num;
		IL_00c2:
		ex = new NullReferenceException();
		goto IL_00d0;
		IL_00d0:
		list = (List<object>)(object)ex;
		num = 0;
		goto IL_0105;
	}
}
