using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace CardDistribution;

[Serializable]
public class CardsStack
{
	private CanvasGroup <CanvasGroup>k__BackingField;

	private Image[] <Cards>k__BackingField;

	public CanvasGroup CanvasGroup
	{
		get
		{
			return <CanvasGroup>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Image[] Cards
	{
		get
		{
			return <Cards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SnapAlpha(float alpha)
	{
		int num = ShortcutExtensions.DOKill(<CanvasGroup>k__BackingField);
		<CanvasGroup>k__BackingField.alpha = alpha;
	}

	public void FadeAlpha(float alpha, float duration)
	{
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(<CanvasGroup>k__BackingField, alpha, duration);
	}
}
