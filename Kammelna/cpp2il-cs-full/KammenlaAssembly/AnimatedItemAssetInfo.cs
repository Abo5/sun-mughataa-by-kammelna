using System;
using UnityEngine;

[Serializable]
public struct AnimatedItemAssetInfo
{
	public GameAction gameAction;

	public bool useParentCanvas;

	public CanvasLayer parentCanvas;

	public GameObject prefab;

	public bool isChildComponent;

	public bool isReusable;

	public bool isAnimatedGift;

	private bool ShowParentCanvasOption()
	{
		return useParentCanvas;
	}
}
