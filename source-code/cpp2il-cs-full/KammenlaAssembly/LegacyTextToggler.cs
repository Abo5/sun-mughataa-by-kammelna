using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class LegacyTextToggler : BaseToggler
{
	private List<TextMeshProUGUI> textReferences;

	private Color alternativeColor = (Color)0;

	private Color originalColor;

	private void Awake()
	{
		//IL_0011: Expected O, but got I
		//IL_0032: Expected I, but got O
		object obj = (nint)0 + (nint)704;
		object obj2 = ((List<object>)(object)textReferences).get_Item(0);
		nint num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ X8_v6 (Il2CppClass<System.Object>)+298] (should have been resolved before IL gen)");
		Color color = default(Color);
		originalColor = color;
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			List<object> list = (List<object>)(object)textReferences;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag = list._size < items.Length;
			object obj3 = !flag;
			object obj6 = default(object);
			if (obj3 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj4 = items + list._size;
				object obj5 = obj4 + 32;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize(obj6);
			}
		}
	}

	protected override void ToggleOn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj2 = (nint)0 + (nint)728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)textReferences).ForEach(action);
	}

	protected override void ToggleOff()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj2 = (nint)0 + (nint)736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)textReferences).ForEach(action);
	}

	private void SetOriginal(TextMeshProUGUI text)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+54]");
		object obj2 = 0;
		Color color = originalColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+4C]");
		object obj3 = 0;
		nint num = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void SetAlternative(TextMeshProUGUI text)
	{
		//IL_0010: Expected O, but got I
		//IL_0020: Expected O, but got I
		//IL_003a: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+44]");
		object obj2 = 0;
		Color color = alternativeColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LegacyTextToggler)+3C]");
		object obj3 = 0;
		nint num = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
