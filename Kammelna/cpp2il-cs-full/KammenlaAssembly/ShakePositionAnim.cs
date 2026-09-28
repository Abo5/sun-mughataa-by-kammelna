using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ShakePositionAnim : ShakeTransformAnim
{
	protected bool Snapping;

	public override Tween tween => ShortcutExtensions.DOShakePosition(_transform, Duration, (Vector3)Vibrato, Snapping ? 1 : 0, (float)_changeValue, FadeOut, fadeOut: false);

	public ShakePositionAnim()
	{
		Randomness = 90f;
		FadeOut = true;
		((object)this)..ctor();
	}
}
