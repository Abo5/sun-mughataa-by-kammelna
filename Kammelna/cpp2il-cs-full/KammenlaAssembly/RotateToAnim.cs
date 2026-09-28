using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class RotateToAnim : TransformTweenAnim
{
	private bool isLocal;

	public override Tween tween
	{
		get
		{
			//IL_005e: Expected F4, but got O
			//IL_005e: Expected O, but got I4
			//IL_003a: Expected F4, but got O
			//IL_003a: Expected O, but got I4
			if (isLocal)
			{
				return ShortcutExtensions.DOLocalRotate(_transform, (Vector3)0, (float)_changeValue);
			}
			return ShortcutExtensions.DORotate(_transform, (Vector3)0, (float)_changeValue);
		}
	}
}
