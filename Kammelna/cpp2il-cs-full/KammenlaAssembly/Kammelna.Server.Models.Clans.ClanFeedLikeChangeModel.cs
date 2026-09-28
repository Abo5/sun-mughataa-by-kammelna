using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanFeedLikeChangeModel
{
	public long FeedId;

	public long UserId;

	public bool Liked;
}
