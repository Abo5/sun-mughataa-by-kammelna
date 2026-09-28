using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ScaleByAnim : TransformTweenAnim
{
	public override Tween tween => ShortcutExtensions.DOBlendableScaleBy(_transform, (Vector3)0, (float)_changeValue);
}
