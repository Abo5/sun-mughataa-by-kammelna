using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Mutations;

public class LayoutElementMutation : IMutation
{
	private LayoutElement layoutElement;

	private bool togglePreferredHeight;

	private float preferredHeight;

	private bool togglePreferredWidth;

	private float preferredWidth;

	private float tweenDuration;

	private float originalHeight;

	private float originalWidth;

	public void Setup(GameObject gm)
	{
		float num = layoutElement.preferredHeight;
		float num2 = default(float);
		originalHeight = num2;
		float num3 = layoutElement.preferredWidth;
		originalWidth = num2;
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_003e: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_00bf: Expected F4, but got I
		//IL_00bf: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		if (togglePreferredHeight)
		{
			bool flag = !togglePreferredWidth;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				object obj3 = 36;
			}
			else
			{
				object obj3 = 48;
			}
		}
		else
		{
			if (~(togglePreferredWidth ? 1u : 0u) != 0)
			{
				return;
			}
			object obj3 = 36;
		}
		LayoutElement target = layoutElement;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.LayoutElementMutation)+v46 @ X8_v2]");
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(target, (Vector2)0, 0f);
	}

	public void UndoMutation()
	{
		//IL_001b: Expected O, but got I4
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(layoutElement, (Vector2)0, originalWidth);
	}
}
