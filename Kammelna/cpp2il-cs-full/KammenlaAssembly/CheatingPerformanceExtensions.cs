public static class CheatingPerformanceExtensions
{
	public static float GetStrength(CheatingPerformance cp)
	{
		//IL_000e: Expected O, but got I4
		//IL_001c: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		object obj = cp + 2;
		object obj2 = cp + 5;
		bool flag = (nint)obj < 0;
		object obj3 = obj ^ obj;
		object obj4 = obj & obj3;
		bool flag2 = (nint)obj4 < 0;
		bool flag3 = flag == flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			obj = obj2;
		}
		object obj7 = 3 - obj;
		return (float)obj7 * 1.0708897E+09f;
	}
}
