using Cpp2ILInjected;
using UnityEngine;

public static class ColorExtension
{
	public unsafe static Color ApplyHsvMultiplier(Color targetColor, float HueShift, float saturation, float value, float alpha = 1f)
	{
		//IL_0012: Expected O, but got Ref
		object obj = default(object);
		Color.RGBToHSV((Color)(&obj), out var H, out var S, out *(float*)null);
		object obj2 = default(object);
		float h = (float)obj2 + (float)obj;
		object obj3 = default(object);
		float s = (float)obj3 * H;
		object obj4 = default(object);
		float v = (float)obj4 * S;
		return Color.HSVToRGB(h, s, v, hdr: true);
	}

	public unsafe static Color ApplyHsvMultiplier(Color targetColor, Vector4 HSVa)
	{
		//IL_0012: Expected O, but got Ref
		object obj = default(object);
		Color.RGBToHSV((Color)(&obj), out var H, out var S, out *(float*)null);
		object obj2 = default(object);
		float h = (float)obj2 + (float)obj;
		object obj3 = default(object);
		float s = (float)obj3 * H;
		object obj4 = default(object);
		float v = (float)obj4 * S;
		return Color.HSVToRGB(h, s, v, hdr: true);
	}

	public static int ToPackedRgba(Color color)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2847CD0");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction REV not yet implemented.\"");
		int result = default(int);
		return result;
	}

	public static Color FromPackedRgba(int packed)
	{
		//IL_000f: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction REV not yet implemented.\"");
		return (Color)packed;
	}
}
