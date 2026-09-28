using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

public class ThemeColorPaletteToggler : BaseToggler
{
	private List<ThemeableGraphic> themeableGraphicReferences;

	private PaletteColor onColor;

	private Color onColorMultiplier = (Color)0;

	private PaletteColor offColor;

	private Color offColorMultiplier = (Color)0;

	protected override void ToggleOn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3696;
		object obj2 = (nint)0 + (nint)2472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)themeableGraphicReferences).ForEach(action);
	}

	protected override void ToggleOff()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3696;
		object obj2 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)themeableGraphicReferences).ForEach(action);
	}

	private void SetOriginal(ThemeableGraphic graphic)
	{
		//IL_0014: Expected O, but got I4
		graphic.SetValues(onColor, (Color)0);
	}

	private void SetAlternative(ThemeableGraphic graphic)
	{
		//IL_0014: Expected O, but got I4
		graphic.SetValues(offColor, (Color)0);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			List<object> list = (List<object>)(object)themeableGraphicReferences;
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
}
