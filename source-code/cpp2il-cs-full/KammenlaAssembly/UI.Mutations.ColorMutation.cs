using System;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Mutations;

[Serializable]
public class ColorMutation : IMutation
{
	private Color alternativeColor = (Color)0;

	private Graphic[] graphicReferences;

	private bool manualOriginalColor;

	private float animationDuration;

	private Color originalColor = (Color)0;

	public void Setup(GameObject gm)
	{
		//IL_001c: Expected O, but got I4
		bool flag = !manualOriginalColor;
		object obj = !flag;
		if (obj == null)
		{
			Graphic[] array = graphicReferences;
			if (graphicReferences == null || (object)array[0] == null)
			{
				NullReferenceException ex = new NullReferenceException();
				throw new IndexOutOfRangeException();
			}
			Color color = array[0].color;
			Color color2 = default(Color);
			originalColor = color2;
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
		object obj2 = (nint)0 + (nint)2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(graphicReferences, action);
	}

	public void UndoMutation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2184;
		object obj2 = (nint)0 + (nint)2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(graphicReferences, action);
	}

	private void SetOriginal(Graphic text)
	{
		//IL_0014: Expected F4, but got O
		//IL_0014: Expected O, but got I4
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(text, (Color)0, (float)originalColor);
	}

	private void SetAlternative(Graphic text)
	{
		//IL_0014: Expected F4, but got O
		//IL_0014: Expected O, but got I4
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(text, (Color)0, (float)alternativeColor);
	}
}
