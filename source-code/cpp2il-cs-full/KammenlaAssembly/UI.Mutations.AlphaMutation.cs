using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Mutations;

[Serializable]
public class AlphaMutation : IMutation
{
	private float alpha;

	private Graphic[] graphic;

	private float originalAlpha;

	public void Setup(GameObject gm)
	{
		//IL_00ba: Expected O, but got I4
		bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)graphic);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			Graphic[] array = graphic;
			if (graphic == null || (object)array[0] == null)
			{
				NullReferenceException ex = new NullReferenceException();
				throw new IndexOutOfRangeException();
			}
			Color color = array[0].color;
			float num = default(float);
			originalAlpha = num;
		}
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj2 = (nint)0 + (nint)3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(graphic, action);
	}

	public void UndoMutation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj2 = (nint)0 + (nint)3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(graphic, action);
	}

	private void <PerformMutation>b__5_0(Graphic g)
	{
		UIExtensions.SetAlpha(g, alpha);
	}

	private void <UndoMutation>b__6_0(Graphic g)
	{
		UIExtensions.SetAlpha(g, originalAlpha);
	}
}
