using System;

[Serializable]
public class FriendsPointsLeaderboardSource : FriendsLeaderboardSource
{
	public override string Name => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1488;

	public override string Title => "Picking audio files is not supported on iOS" + 776;

	protected override int GetPoints(FriendLeaderboardModel sourcePlayer)
	{
		//IL_0035: Expected I4, but got O
		//IL_0027: Expected I4, but got I8
		if (sourcePlayer == null)
		{
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		return (int)sourcePlayer.<currentMonthPoints>k__BackingField;
	}

	protected override int GetPoints(PlayerProfileModel sourcePlayer)
	{
		//IL_006a: Expected I4, but got O
		if (sourcePlayer != null)
		{
			PlayerRankingModel <ranking>k__BackingField = sourcePlayer.<ranking>k__BackingField;
			if (sourcePlayer.<ranking>k__BackingField != null)
			{
				return <ranking>k__BackingField.<currentMonthPoints>k__BackingField;
			}
			return 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
