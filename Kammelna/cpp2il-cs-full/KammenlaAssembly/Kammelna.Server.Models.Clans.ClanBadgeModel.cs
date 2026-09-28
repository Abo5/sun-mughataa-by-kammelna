using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanBadgeModel
{
	public int ClanId;

	public string Name;

	public int Tier;

	public FileInfoModel Emblem;
}
