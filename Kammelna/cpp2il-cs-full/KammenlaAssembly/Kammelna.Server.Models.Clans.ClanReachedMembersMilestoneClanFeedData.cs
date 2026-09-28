using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanReachedMembersMilestoneClanFeedData : ClanFeedData
{
	private int <MembersCount>k__BackingField;

	public int MembersCount
	{
		get
		{
			return <MembersCount>k__BackingField;
		}
		set
		{
			<MembersCount>k__BackingField = value;
		}
	}
}
