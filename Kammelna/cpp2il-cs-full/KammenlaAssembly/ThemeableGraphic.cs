using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class ThemeableGraphic : ThemeableElement
{
	private Graphic themeable;

	private PaletteColor color;

	private Color multiplier = (Color)0;

	private float saturation = 0f;

	private float value;

	protected override void OnThemeUpdated(IThemeColorProfile colorProfile)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 1712;
		nint num = (nint)colorProfile;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IThemeColorProfile>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IThemeColorProfile>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IThemeColorProfile>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		goto IL_010e;
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v4] (should have been resolved before IL gen)");
		object obj4 = default(object);
		float hueShift = (float)obj4 * (float)multiplier;
		object obj5 = default(object);
		float num2 = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ThemeableGraphic)+38]");
		float num3 = num2 * 0f;
		object obj6 = default(object);
		float num4 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ThemeableGraphic)+3C]");
		float num5 = num4 * 0f;
		object obj7 = default(object);
		float num6 = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ThemeableGraphic)+40]");
		float alpha = num6 * 0f;
		float num7 = saturation;
		float num8 = value;
		Color color = ColorExtension.ApplyHsvMultiplier((Color)0, hueShift, num3, num5, alpha);
		Graphic graphic = themeable;
		nint num9 = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v9 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v9 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v179 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_010e;
		IL_010e:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj10 = num + obj3;
		object obj11 = obj10 + 312;
		goto IL_0132;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0132;
	}

	public void SetValues(PaletteColor newColor, Color newMultiplier)
	{
		this.color = newColor;
		Color color = default(Color);
		multiplier = color;
		UpdateTheme();
	}
}
