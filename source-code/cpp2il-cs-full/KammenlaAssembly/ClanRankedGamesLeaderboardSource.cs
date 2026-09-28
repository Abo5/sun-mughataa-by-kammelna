using System;
using Kammelna.Server.Models.Clans;

[Serializable]
public class ClanRankedGamesLeaderboardSource : ClanInternalLeaderboardSource
{
	public override string Name => "Cannot populate JSON object onto type '{0}'." + 3000;

	public override string Title => "Picking audio files is not supported on iOS" + 776;

	protected override InternalLeaderboardKind Kind => InternalLeaderboardKind.RankedGames;

	public ClanRankedGamesLeaderboardSource(int clanId)
	{
		base.<ClanId>k__BackingField = clanId;
	}
}
