using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanCardModel
{
	public int ClanId;

	public string Name;

	public int Tier;

	public FileInfoModel Emblem;

	public int ActiveEmblemTier;

	public int MembersCount;

	public int MaxMembers;

	public long MonthlyPoints;
}
