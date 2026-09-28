using System;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;

public static class BalootGameModeExtensions
{
	public static bool IsSunOrAshkal(BalootGame.BalootGameMode gameMode)
	{
		//IL_0012: Expected O, but got I8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (long)gameMode & 0xFFFFFFFDL;
		object obj2 = obj - 1;
		return obj2 == null;
	}

	public static string ToClientString(BalootGame.BalootGameMode gameMode)
	{
		//IL_00ea: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		object obj = gameMode - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 139821056 + 3336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X9_v2+v39 @ X8_v3*8]");
			return (string)0;
		}
		object obj4 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = "fetch_products" + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj7 = (nint)0 + (nint)2240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	public static string ToClientString(BalootGame.BalootExtraGameMode extraGameMode)
	{
		//IL_002d: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0061: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		object obj = extraGameMode - 1;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v2+90]");
		object result = (nint)0 + (nint)184;
		object obj3 = 139821056 + 3360;
		object result2 = obj3 + obj;
		bool flag = (nint)obj < 4;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return (string)result2;
		}
		return (string)result;
	}
}
