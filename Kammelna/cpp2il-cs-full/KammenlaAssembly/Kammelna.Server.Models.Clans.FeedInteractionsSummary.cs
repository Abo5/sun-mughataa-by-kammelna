using System;
using System.Collections.Generic;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class FeedInteractionsSummary
{
	public List<long> Likes;

	public Dictionary<int, List<long>> Votes;
}
