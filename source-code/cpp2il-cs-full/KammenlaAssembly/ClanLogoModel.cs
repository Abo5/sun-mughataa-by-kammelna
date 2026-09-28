using System;
using System.Collections.Generic;

[Serializable]
public class ClanLogoModel
{
	public const float RIM_INTERIOR_RATIO = 0.6f;

	public ClanLogoRim Rim;

	public List<ClanLogoIcon> Icons;
}
