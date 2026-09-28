using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class ShakeScaleAnim : ShakeTransformAnim
{
	public override Tween tween => ShortcutExtensions.DOShakeScale(_transform, Duration, (Vector3)Vibrato, FadeOut ? 1 : 0, (float)_changeValue, fadeOut: false);

	public ShakeScaleAnim()
	{
		Randomness = 90f;
		FadeOut = true;
		((object)this)..ctor();
	}
}
