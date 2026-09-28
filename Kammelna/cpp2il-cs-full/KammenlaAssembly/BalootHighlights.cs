using System;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;

public class BalootHighlights : CardGameHighlights
{
	public override string GetHighlightsName(string key)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2672;
		int result;
		bool flag = int.TryParse(key, out result);
		bool flag2 = !flag;
		object obj2 = !flag2;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	private BalootStatistics.BalootStat GetBalootHighlights(int key)
	{
		return (BalootStatistics.BalootStat)key;
	}
}
