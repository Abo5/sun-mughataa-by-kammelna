using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanTierConfig
{
	public int Tier;

	public int XpThreshold;

	public int MaxMembers;

	public int EmblemUpgradeCost;
}
