using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ShakeRotationAnim : ShakeTransformAnim
{
	public override Tween tween => ShortcutExtensions.DOShakeRotation(_transform, Duration, (Vector3)Vibrato, FadeOut ? 1 : 0, (float)_changeValue, fadeOut: false);

	public ShakeRotationAnim()
	{
		Randomness = 90f;
		FadeOut = true;
		((object)this)..ctor();
	}
}
