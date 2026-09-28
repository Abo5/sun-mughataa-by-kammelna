using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ScrollSnapProximityBehavior
{
	public abstract void OnProximityUpdated(IReadOnlyList<ScrollSnapItemProximity> items, RectTransform nearestItem);
}
