public static class PlayerPerformanceExtensions
{
	public static float GetStrength(PlayerPerformance pp)
	{
		return 5f - (float)pp;
	}
}
