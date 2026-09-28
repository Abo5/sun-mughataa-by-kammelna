using System;
using UnityEngine;

public class ThemeColorProfile : ScriptableObject, IThemeColorProfile
{
	private ThemeColorPalette colors;

	public Color GetColor(PaletteColor color)
	{
		if (colors != null)
		{
			return colors.GetColor(color);
		}
		return (Color)new NullReferenceException();
	}
}
