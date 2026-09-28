using System;
using UnityEngine;

[Serializable]
public struct AnimationVectorParameter
{
	public Vector3 vector;

	public bool useCurve;

	public AnimationCurveInfo AnimationCurveInfo;

	private bool ShowCurve()
	{
		return useCurve;
	}
}
