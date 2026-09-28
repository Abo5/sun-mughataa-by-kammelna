using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanUpgradedClanFeedData : ClanFeedData
{
	private int <NewTier>k__BackingField;

	public int NewTier
	{
		get
		{
			return <NewTier>k__BackingField;
		}
		set
		{
			<NewTier>k__BackingField = value;
		}
	}
}
