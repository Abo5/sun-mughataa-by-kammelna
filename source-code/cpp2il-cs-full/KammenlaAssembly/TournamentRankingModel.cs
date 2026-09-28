using Cpp2ILInjected;

public class TournamentRankingModel
{
	private int <currentMonthPoints>k__BackingField;

	private int <currentMonthRank>k__BackingField;

	private MonthlyTournamentEligibilityType <currentRankTier>k__BackingField;

	private int <lastMonthPoints>k__BackingField;

	private int <lastMonthRank>k__BackingField;

	private int <secondLastMonthRank>k__BackingField;

	private MonthlyTournamentEligibilityType <lastRankTier>k__BackingField;

	public int currentMonthPoints
	{
		get
		{
			return <currentMonthPoints>k__BackingField;
		}
		set
		{
			<currentMonthPoints>k__BackingField = value;
		}
	}

	public int currentMonthRank
	{
		get
		{
			return <currentMonthRank>k__BackingField;
		}
		set
		{
			<currentMonthRank>k__BackingField = value;
		}
	}

	public MonthlyTournamentEligibilityType currentRankTier
	{
		get
		{
			return <currentRankTier>k__BackingField;
		}
		set
		{
			<currentRankTier>k__BackingField = value;
		}
	}

	public int lastMonthPoints
	{
		get
		{
			return <lastMonthPoints>k__BackingField;
		}
		set
		{
			<lastMonthPoints>k__BackingField = value;
		}
	}

	public int lastMonthRank
	{
		get
		{
			return <lastMonthRank>k__BackingField;
		}
		set
		{
			<lastMonthRank>k__BackingField = value;
		}
	}

	public int secondLastMonthRank
	{
		get
		{
			return <secondLastMonthRank>k__BackingField;
		}
		set
		{
			<secondLastMonthRank>k__BackingField = value;
		}
	}

	public MonthlyTournamentEligibilityType lastRankTier
	{
		get
		{
			return <lastRankTier>k__BackingField;
		}
		set
		{
			<lastRankTier>k__BackingField = value;
		}
	}

	public override string ToString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0024: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1248;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}
}
