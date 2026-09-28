using Cpp2ILInjected;
using UnityEngine;

public class MonthlyTournamentTrophySprites : ScriptableObject
{
	public Sprite PlatinumFirst;

	public Sprite PlatinumSecond;

	public Sprite GoldFirst;

	public Sprite GoldSecond;

	public Sprite SilverFirst;

	public Sprite SilverSecond;

	public Sprite BronzeFirst;

	public Sprite BronzeSecond;

	public Sprite GetMonthlySprite(TournamentSubType type, PrizeLevel place)
	{
		//IL_009f: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		switch (place)
		{
		case PrizeLevel.First:
		{
			bool flag3 = type < (TournamentSubType)4;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				object obj8 = 24;
				object obj9 = this + type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v2+v55 @ X8_v2]");
				return (Sprite)0;
			}
			break;
		}
		case PrizeLevel.Second:
		{
			bool flag = type < TournamentSubType.Bronze;
			object obj = !flag;
			object obj2 = type - 3;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				object obj5 = 32;
				object obj6 = this + type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X9_v1+v51 @ X8_v1]");
				return (Sprite)0;
			}
			break;
		}
		}
		return null;
	}
}
