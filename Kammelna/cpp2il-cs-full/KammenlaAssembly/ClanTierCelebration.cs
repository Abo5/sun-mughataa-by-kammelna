public static class ClanTierCelebration
{
	private const string CELEBRATED_TIER_KEY_PREFIX = "clan_celebrated_tier_";

	public static bool TryClaim(int clanId, int tier)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		bool flag = clanId < 1;
		bool result = false;
		if (!flag)
		{
			bool flag2 = tier < 1;
			result = false;
			if (!flag2)
			{
				object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3488;
				int num = default(int);
				string text = num.ToString();
				string key = (string)obj + text;
				bool flag3 = Prefs.HasKey(key);
				if (flag3)
				{
					int num2 = Prefs.GetInt(key);
					bool flag4 = tier <= num2;
					result = false;
					if (flag4)
					{
						goto IL_00d7;
					}
				}
				Prefs.SetInt(key, tier);
				Prefs.Save();
				result = flag3;
			}
		}
		goto IL_00d7;
		IL_00d7:
		return result;
	}

	public static void Reset(int clanId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3488;
		int num = default(int);
		string text = num.ToString();
		string key = (string)obj + text;
		Prefs.DeleteKey(key);
		Prefs.Save();
	}

	private static void Save(string key, int tier)
	{
		Prefs.SetInt(key, tier);
		Prefs.Save();
	}

	private static string Key(int clanId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3488;
		int num = default(int);
		string text = num.ToString();
		return (string)obj + text;
	}
}
