public static class TournamentStatusExtensions
{
	public static bool IsScheduled(TournamentStatus status)
	{
		return status == TournamentStatus.Scheduled;
	}

	public static bool IsStarted(TournamentStatus status)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		object obj = status - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}

	public static bool IsRunning(TournamentStatus status)
	{
		//IL_000e: Expected O, but got I4
		object obj = status - 1;
		return obj == null;
	}

	public static bool IsFinalCountdown(TournamentStatus status)
	{
		//IL_000e: Expected O, but got I4
		object obj = status - 5;
		return obj == null;
	}

	public static bool IsFinished(TournamentStatus status)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		object obj = status - 2;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}
}
