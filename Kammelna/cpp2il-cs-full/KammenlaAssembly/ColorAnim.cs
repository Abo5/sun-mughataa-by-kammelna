using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ColorAnim : GraphicTweenAnim
{
	private Color _color;

	public override Tween tween => DOTweenModuleUI.DOColor(_graphic, (Color)0, (float)_color);
}
