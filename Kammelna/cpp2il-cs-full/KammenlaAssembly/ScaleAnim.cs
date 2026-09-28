using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ScaleAnim : TransformTweenAnim
{
	public override Tween tween => ShortcutExtensions.DOScale(_transform, (Vector3)0, (float)_changeValue);
}
