using System;
using Kammelna.Server.Models.Clans;

[Serializable]
public class ClanTournamentsLeaderboardSource : ClanInternalLeaderboardSource
{
	public override string Name => "Cannot populate JSON object onto type '{0}'." + 3016;

	public override string Title => "ThisIsFakeReceiptData" + 1456;

	protected override InternalLeaderboardKind Kind => InternalLeaderboardKind.Tournaments;

	public ClanTournamentsLeaderboardSource(int clanId)
	{
		base.<ClanId>k__BackingField = clanId;
	}
}
