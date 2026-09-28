using System;
using Cpp2ILInjected;

public static class MonthlyTournamentEligibilityExtensions
{
	public static TournamentSubType? ToTournamentSubType(MonthlyTournamentEligibilityType type)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DD9]");
		object obj2 = (nint)0 & (nint)1;
		System.Int32Enum int32Enum;
		TournamentSubType? result;
		if (obj2 != null)
		{
			int32Enum = (System.Int32Enum)(type - 1);
			bool flag = int32Enum < (System.Int32Enum)3;
			object obj3 = !flag;
			object obj4 = int32Enum - 3;
			bool flag2 = obj4 == null;
			object obj5 = ~obj3;
			object obj6 = obj5 | flag2;
			result = (TournamentSubType?)(object)0;
			if (obj6 == null)
			{
				goto IL_00ae;
			}
		}
		else
		{
			_ = 1;
			int32Enum = (System.Int32Enum)(type - 1);
			bool flag3 = int32Enum < (System.Int32Enum)3;
			object obj7 = !flag3;
			object obj8 = int32Enum - 3;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			object obj10 = obj7 & obj9;
			result = (TournamentSubType?)(object)0;
			if (obj10 != null)
			{
				goto IL_00ae;
			}
		}
		return (TournamentSubType?)new System.Int32Enum?(int32Enum);
		IL_00ae:
		return result;
	}

	public static bool IsOverQualified(TournamentSubType userQualification, TournamentSubType tournamentSubType)
	{
		//IL_000d: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = userQualification - tournamentSubType;
		bool flag = (nint)obj < 0;
		object obj2 = userQualification ^ tournamentSubType;
		object obj3 = userQualification ^ obj;
		object obj4 = obj2 & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		return !flag3;
	}

	public static bool IsNotEligible(MonthlyTournamentEligibilityType type)
	{
		return type == MonthlyTournamentEligibilityType.NotEligible;
	}

	public static bool IsPlatinum(MonthlyTournamentEligibilityType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 1;
		return obj == null;
	}

	public static bool IsGold(MonthlyTournamentEligibilityType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 2;
		return obj == null;
	}

	public static bool IsSilver(MonthlyTournamentEligibilityType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 3;
		return obj == null;
	}

	public static bool IsBronze(MonthlyTournamentEligibilityType type)
	{
		//IL_000e: Expected O, but got I4
		object obj = type - 4;
		return obj == null;
	}
}
