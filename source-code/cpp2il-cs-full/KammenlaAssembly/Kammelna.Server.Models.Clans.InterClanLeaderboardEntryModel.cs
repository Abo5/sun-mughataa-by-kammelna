using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class InterClanLeaderboardEntryModel
{
	public int Rank;

	public int ClanId;

	public string ClanName;

	public int Tier;

	public int Score;

	public FileInfoModel Emblem;
}
