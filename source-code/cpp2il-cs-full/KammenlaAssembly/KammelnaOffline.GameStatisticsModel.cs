namespace KammelnaOffline;

public class GameStatisticsModel
{
	public int PlayedGames;

	public int Wins;

	public int Loses()
	{
		return PlayedGames - Wins;
	}

	public float WinRatio()
	{
		//IL_00a7: Invalid comparison between F8 and I4
		//IL_00b6: Invalid comparison between F8 and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I4, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected I4, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_005d: Expected I4, but got F8
		//IL_0085: Expected F4, but got I4
		//IL_0078: Expected F4, but got I4
		int num = Wins / PlayedGames;
		int num2 = ((PlayedGames != Wins) ? num : PlayedGames);
		double num3 = (double)num2 - 1.0;
		bool flag = num3 < 0.0;
		bool flag2 = num3 == 0.0;
		int num4 = num2 ^ 1.0;
		int num5 = num2 ^ num3;
		int num6 = num4 & num5;
		bool flag3 = num6 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		object obj2 = flag4 & obj;
		object obj3 = ~obj2;
		int num7 = ((obj3 != null) ? num2 : 1);
		if (num2 < 0)
		{
			return 0f;
		}
		return num7;
	}
}
