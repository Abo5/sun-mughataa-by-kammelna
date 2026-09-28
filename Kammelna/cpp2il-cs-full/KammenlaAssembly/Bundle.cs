using System;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class Bundle
{
	private DateTime <ExpirationDate>k__BackingField;

	private int <ProductId>k__BackingField;

	private Color <PrimaryColor>k__BackingField;

	private Color <SecondaryColor>k__BackingField;

	private Color <PrimaryEffect>k__BackingField;

	private Color <SecondaryEffect>k__BackingField;

	private IThemeColorProfile _cachedTheme;

	public DateTime ExpirationDate
	{
		get
		{
			return <ExpirationDate>k__BackingField;
		}
		set
		{
			<ExpirationDate>k__BackingField = value;
		}
	}

	public int ProductId
	{
		get
		{
			return <ProductId>k__BackingField;
		}
		set
		{
			<ProductId>k__BackingField = value;
		}
	}

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

	public Color PrimaryEffect
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<PrimaryEffect>k__BackingField = color;
		}
	}

	public Color SecondaryEffect
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<SecondaryEffect>k__BackingField = color;
		}
	}

	public IThemeColorProfile GenerateTheme()
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		object obj = this + 96;
		if (obj != null)
		{
			return (IThemeColorProfile)obj;
		}
		object obj2 = typeof(RegisteredWaitHandle) + 1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RuntimeThemeColorProfile runtimeThemeColorProfile = default(RuntimeThemeColorProfile);
		runtimeThemeColorProfile..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ThemeColorPalette themeColorPalette = default(ThemeColorPalette);
		themeColorPalette..ctor();
		if (themeColorPalette != null)
		{
			themeColorPalette.PrimaryColor = <PrimaryColor>k__BackingField;
			themeColorPalette.SecondaryColor = <SecondaryColor>k__BackingField;
			themeColorPalette.PrimaryEffectColor = <PrimaryEffect>k__BackingField;
			themeColorPalette.SecondaryEffectColor = <SecondaryEffect>k__BackingField;
			if (runtimeThemeColorProfile != null)
			{
				object obj4 = runtimeThemeColorProfile + 16;
				obj4 = themeColorPalette;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj = runtimeThemeColorProfile;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return runtimeThemeColorProfile;
			}
		}
		return (IThemeColorProfile)new NullReferenceException();
	}
}
