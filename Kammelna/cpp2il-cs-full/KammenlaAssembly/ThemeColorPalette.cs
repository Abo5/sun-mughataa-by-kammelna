using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;

[Serializable]
public class ThemeColorPalette
{
	public Color PrimaryColor = (Color)0;

	public Color PrimaryEffectColor;

	public Color SecondaryColor;

	public Color SecondaryEffectColor;

	public Color AccessoryColorOne;

	public Color AccessoryColorTwo;

	public Color PrimaryTextColor;

	public Color SecondaryTextColor;

	public Color GetColor(PaletteColor color)
	{
		//IL_001a: Expected O, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		bool flag = color < (PaletteColor)8;
		object obj = !flag;
		if (obj == null)
		{
			return (Color)this;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = "clear_mass_tournaments" + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj5 = (nint)0 + (nint)2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Color)new OutOfMemoryException();
	}

	public ThemeColorPalette()
	{
		//IL_000b: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_00d0: Expected O, but got I
		Color grey = Color.grey;
		PrimaryEffectColor = (Color)0;
		SecondaryColor = (Color)0;
		Color grey2 = Color.grey;
		SecondaryEffectColor = (Color)0;
		Color gray = Color.gray;
		AccessoryColorOne = (Color)0;
		Color gray2 = Color.gray;
		AccessoryColorTwo = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DC520]");
		PrimaryTextColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DC520]");
		SecondaryTextColor = (Color)0;
		base..ctor();
	}
}
