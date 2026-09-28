using System;
using Kammelna.Server.Models.Clans;

[Serializable]
public class ClanContributionLeaderboardSource : ClanInternalLeaderboardSource
{
	public override string Name => "Cannot populate JSON object onto type '{0}'." + 2928;

	public override string Title => "Cannot populate JSON object onto type '{0}'." + 2888;

	protected override InternalLeaderboardKind Kind => InternalLeaderboardKind.InterClanContribution;

	public ClanContributionLeaderboardSource(int clanId)
	{
		base.<ClanId>k__BackingField = clanId;
	}
}
