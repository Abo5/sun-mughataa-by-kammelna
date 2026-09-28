namespace Kammelna.Server.WebRequests;

public class PredictMatchResultRequestModel
{
	private int <MatchId>k__BackingField;

	private int <HomeTeamScore>k__BackingField;

	private int <AwayTeamScore>k__BackingField;

	public int MatchId
	{
		get
		{
			return <MatchId>k__BackingField;
		}
		set
		{
			<MatchId>k__BackingField = value;
		}
	}

	public int HomeTeamScore
	{
		get
		{
			return <HomeTeamScore>k__BackingField;
		}
		set
		{
			<HomeTeamScore>k__BackingField = value;
		}
	}

	public int AwayTeamScore
	{
		get
		{
			return <AwayTeamScore>k__BackingField;
		}
		set
		{
			<AwayTeamScore>k__BackingField = value;
		}
	}
}
