using System;

[Serializable]
public class FriendsTournamentPointsLeaderboardSource : FriendsLeaderboardSource
{
	public override string Name => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1496;

	public override string Title => "ThisIsFakeReceiptData" + 1456;

	protected override int GetPoints(FriendLeaderboardModel sourcePlayer)
	{
		//IL_0035: Expected I4, but got O
		if (sourcePlayer != null)
		{
			return sourcePlayer.<tournamentPoints>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	protected override int GetPoints(PlayerProfileModel sourcePlayer)
	{
		//IL_006a: Expected I4, but got O
		if (sourcePlayer != null)
		{
			TournamentRankingModel <tournamentRanking>k__BackingField = sourcePlayer.<tournamentRanking>k__BackingField;
			if (sourcePlayer.<tournamentRanking>k__BackingField != null)
			{
				return <tournamentRanking>k__BackingField.<currentMonthPoints>k__BackingField;
			}
			return 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
