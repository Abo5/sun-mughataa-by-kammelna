using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class SeasonChampionClanFeedData : ClanFeedData
{
	private DateTime <Month>k__BackingField;

	public DateTime Month
	{
		get
		{
			return <Month>k__BackingField;
		}
		set
		{
			<Month>k__BackingField = value;
		}
	}
}
