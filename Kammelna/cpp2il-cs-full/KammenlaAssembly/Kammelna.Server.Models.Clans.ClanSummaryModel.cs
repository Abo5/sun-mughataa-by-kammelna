using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanSummaryModel
{
	public int ClanId;

	public string Name;

	public int Tier;

	public int MemberCount;

	public FileInfoModel Emblem;
}
