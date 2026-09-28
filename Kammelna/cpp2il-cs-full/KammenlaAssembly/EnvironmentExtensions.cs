public static class EnvironmentExtensions
{
	public static bool IsProduction(ServerEnvironment env)
	{
		return env == ServerEnvironment.Production;
	}

	public static bool IsStaging(ServerEnvironment env)
	{
		//IL_000e: Expected O, but got I4
		object obj = env - 1;
		return obj == null;
	}

	public static bool IsDevelopment(ServerEnvironment env)
	{
		//IL_000e: Expected O, but got I4
		object obj = env - 2;
		return obj == null;
	}
}
