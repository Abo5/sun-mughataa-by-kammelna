using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;

public static class GameTypeExtensions
{
	public static bool IsRanked(GameType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 1;
		return obj == null;
	}

	public static bool IsFriendly(GameType type)
	{
		return type == GameType.Friendly;
	}

	public static bool IsFastTrack(GameType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 3;
		return obj == null;
	}

	public static bool IsTournament(GameType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 2;
		return obj == null;
	}

	public static bool IsChallenge(GameType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 4;
		return obj == null;
	}

	public static bool IsVisible(GameType type)
	{
		//IL_001a: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		bool flag = type < GameType.Tournament;
		object obj = !flag;
		return (byte)(int)(~obj) != 0;
	}

	public static string GetLocalizableName(GameType gameType)
	{
		//IL_00f6: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		bool flag = gameType < (GameType)5;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 139821056 + 3176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+gameType @ X0 (GameType)*8]");
			return (string)0;
		}
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "fetch_products" + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}
}
