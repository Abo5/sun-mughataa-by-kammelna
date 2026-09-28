using UnityEngine;

public class LogoLayerConfig : ScriptableObject
{
	public ClanLogoLayer Layer;

	public bool Rotatable;

	public bool Sizable;

	public float MinSize = 0f;

	public float MaxSize;

	public bool Movable;

	public bool Colorizable;

	public int MinInstances;

	public int MaxInstances;

	public bool InitBaseLayer;
}
