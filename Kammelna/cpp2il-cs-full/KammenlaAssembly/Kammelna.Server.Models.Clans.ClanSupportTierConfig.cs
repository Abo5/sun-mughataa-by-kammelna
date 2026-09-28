using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanSupportTierConfig
{
	public VaultSupportTier Tier;

	public int Threshold;
}
