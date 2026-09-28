using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanUpgradedEmblemClanFeedData : ClanFeedData
{
	private int <NewEmblemTier>k__BackingField;

	public int NewEmblemTier
	{
		get
		{
			return <NewEmblemTier>k__BackingField;
		}
		set
		{
			<NewEmblemTier>k__BackingField = value;
		}
	}
}
