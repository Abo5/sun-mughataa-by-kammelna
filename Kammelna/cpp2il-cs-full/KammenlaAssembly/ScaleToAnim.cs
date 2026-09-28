using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ScaleToAnim : TransformTweenAnim
{
	public override Tween tween => ShortcutExtensions.DOScale(_transform, (Vector3)0, (float)_changeValue);
}
