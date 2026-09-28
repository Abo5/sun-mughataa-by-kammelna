using System;
using UnityEngine;

[Serializable]
public class AppTheme
{
	private Color <PrimaryColor>k__BackingField;

	private Color <PrimaryEffectColor>k__BackingField;

	private Color <SecondaryColor>k__BackingField;

	private Color <SecondaryEffectColor>k__BackingField;

	private Color <PrimaryTextColor>k__BackingField;

	private Color <SecondaryTextColor>k__BackingField;

	public Color PrimaryColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<PrimaryColor>k__BackingField = color;
		}
	}

	public Color PrimaryEffectColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<PrimaryEffectColor>k__BackingField = color;
		}
	}

	public Color SecondaryColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<SecondaryColor>k__BackingField = color;
		}
	}

	public Color SecondaryEffectColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<SecondaryEffectColor>k__BackingField = color;
		}
	}

	public Color PrimaryTextColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<PrimaryTextColor>k__BackingField = color;
		}
	}

	public Color SecondaryTextColor
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<SecondaryTextColor>k__BackingField = color;
		}
	}
}
