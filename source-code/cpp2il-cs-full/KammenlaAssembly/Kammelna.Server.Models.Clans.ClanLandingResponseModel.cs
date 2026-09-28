using System;
using System.Collections.Generic;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanLandingResponseModel
{
	public List<InterClanLeaderboardEntryModel> Top3;

	public List<ClanSummaryModel> MostActive;

	public List<ClanFeedModel> LandingFeed;

	public RollbackInfoModel Rollback;
}
