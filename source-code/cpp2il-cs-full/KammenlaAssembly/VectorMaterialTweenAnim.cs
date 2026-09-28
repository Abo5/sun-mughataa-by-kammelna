using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class VectorMaterialTweenAnim : MaterialTweenAnim
{
	private Vector4 _vector;

	public override Tween tween
	{
		get
		{
			//IL_0044: Expected F4, but got O
			if ((object)_renderer != null)
			{
				Material material = _renderer.material;
				return ShortcutExtensions.DOVector(material, (Vector4)propertyName, null, (float)_vector);
			}
			return (Tween)(object)new NullReferenceException();
		}
	}
}
