using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class ColorController : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<AbstractColorSetter> <>9__3_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnGUI>b__3_0(AbstractColorSetter setter)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			object format = "utf-32" + 3720;
			string nameBase = setter.NameBase;
			object target = setter.Target;
			string text = string.Format((string)format, nameBase, target);
			object obj = setter + 16;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private Color _color;

	private List<AbstractColorSetter> _setters;

	public void SetColor(Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0067: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 992;
		object obj2 = (nint)0 + (nint)2616;
		Color color2 = default(Color);
		_color = color2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)_setters).ForEach(action);
	}

	private void OnGUI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0286: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_02b5: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_0218: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(CardUtils.<>c) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A8A]");
		object obj3 = (nint)0 & (nint)1;
		List<AbstractColorSetter> list;
		List<AbstractColorSetter> list2;
		object obj4;
		if (obj3 != null)
		{
			list = _setters;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = _setters;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = _setters;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = _setters;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01c6;
		IL_00f3:
		List<object> list3;
		list3.ForEach(action);
		return;
		IL_00e6:
		list3 = (List<object>)(object)list;
		goto IL_00f3;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1176;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = list2 == null;
		object obj15 = !flag5;
		action = action2;
		list3 = (List<object>)(object)list2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f3;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+8]");
		bool flag6 = (nint)0 == 0;
		list2 = list;
		if (!flag6)
		{
			goto IL_00e6;
		}
		goto IL_01c6;
	}

	private void UpdateColors()
	{
		//IL_000a: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		SetColor((Color)(nint)intPtr);
	}

	private void AddGraphicHsvSetter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_0136: Expected I, but got O
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3272;
		List<object> setters = (List<object>)(object)_setters;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71360F0]");
		_ = 0;
		object obj2 = default(object);
		obj2..ctor();
		object format = "utf-32" + 3720;
		nint num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X8_v6 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
		nint num2 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X8_v7 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj3 = obj2 + 16;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int version = setters._version + 1;
		setters._version = version;
		object[] items = setters._items;
		bool flag = setters._size < items.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			int size = setters._size + 1;
			setters._size = size;
			object obj5 = items + setters._size;
			object obj6 = obj5 + 32;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			setters.AddWithResize(obj2);
		}
	}

	private void AddPsHsvSetter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_0136: Expected I, but got O
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 24;
		List<object> setters = (List<object>)(object)_setters;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [71360F0]");
		_ = 0;
		object obj2 = default(object);
		obj2..ctor();
		object format = "utf-32" + 3720;
		nint num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X8_v6 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
		nint num2 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v73 @ X8_v7 (Il2CppClass<System.Object>)+188] (should have been resolved before IL gen)");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj3 = obj2 + 16;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int version = setters._version + 1;
		setters._version = version;
		object[] items = setters._items;
		bool flag = setters._size < items.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			int size = setters._size + 1;
			setters._size = size;
			object obj5 = items + setters._size;
			object obj6 = obj5 + 32;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			setters.AddWithResize(obj2);
		}
	}

	private void AddPsRandomSetter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 40;
		List<object> setters = (List<object>)(object)_setters;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ParticleSystemRandomColorSetter particleSystemRandomColorSetter = default(ParticleSystemRandomColorSetter);
		particleSystemRandomColorSetter..ctor();
		int version = setters._version + 1;
		setters._version = version;
		object[] items = setters._items;
		bool flag = setters._size < items.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			int size = setters._size + 1;
			setters._size = size;
			object obj3 = items + setters._size;
			object obj4 = obj3 + 32;
			obj4 = particleSystemRandomColorSetter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			setters.AddWithResize((object)particleSystemRandomColorSetter);
		}
	}

	private void <SetColor>b__2_0(AbstractColorSetter setter)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ColorController)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ColorController)+2C]");
		object obj2 = 0;
		Color color = _color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ColorController)+24]");
		object obj3 = 0;
		nint num = (nint)setter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<AbstractColorSetter>)+198]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<AbstractColorSetter>)+1A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
