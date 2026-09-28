using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Util.Extensions;

public static class SplineExtensions
{
	public static Vector2 FirstPoint(Spline spline)
	{
		return (Vector2)(((object?)spline?.GetPosition(0)) ?? ((object)new NullReferenceException()));
	}

	public static Vector2 LastPoint(Spline spline)
	{
		if (spline != null)
		{
			int pointCount = spline.GetPointCount();
			int index = pointCount - 1;
			return spline.GetPosition(index);
		}
		return (Vector2)new NullReferenceException();
	}
}
