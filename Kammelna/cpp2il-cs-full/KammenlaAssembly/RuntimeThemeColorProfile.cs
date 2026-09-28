using System;
using Cpp2ILInjected;
using UnityEngine;

public class RuntimeThemeColorProfile : IThemeColorProfile
{
	private readonly ThemeColorPalette <Colors>k__BackingField;

	public ThemeColorPalette Colors
	{
		get
		{
			return <Colors>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Color GetColor(PaletteColor color)
	{
		if (<Colors>k__BackingField != null)
		{
			return <Colors>k__BackingField.GetColor(color);
		}
		return (Color)new NullReferenceException();
	}
}
