using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class FloatMaterialTweenAnim : MaterialTweenAnim
{
	private float _float;

	public override Tween tween
	{
		get
		{
			if ((object)_renderer != null)
			{
				Material material = _renderer.material;
				return ShortcutExtensions.DOFloat(material, _float, propertyName, Duration);
			}
			return (Tween)(object)new NullReferenceException();
		}
	}
}
