public static class TournamentTypeExtensions
{
	public static bool IsPublic(TournamentType type)
	{
		return type == TournamentType.Public;
	}

	public static bool IsPrivate(TournamentType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 1;
		return obj == null;
	}

	public static bool IsMass(TournamentType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 2;
		return obj == null;
	}

	public static bool IsOfficial(TournamentType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 3;
		return obj == null;
	}

	public static bool IsOfficialMonthly(TournamentType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 4;
		return obj == null;
	}
}
