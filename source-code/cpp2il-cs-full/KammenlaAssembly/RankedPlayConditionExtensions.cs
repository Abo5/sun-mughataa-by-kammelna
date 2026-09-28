public static class RankedPlayConditionExtensions
{
	public static bool CanWatchAds(RankedPlayCondition playCondition)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		object obj = playCondition - 1;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}
}
