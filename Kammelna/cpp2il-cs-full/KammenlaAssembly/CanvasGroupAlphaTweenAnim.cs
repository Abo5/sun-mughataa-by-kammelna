using System;
using DG.Tweening;

[Serializable]
public class CanvasGroupAlphaTweenAnim : CanvasGroupTweenAnim
{
	private float finalValue;

	public override Tween tween => DOTweenModuleUI.DOFade(_canvasGroup, finalValue, Duration);
}
