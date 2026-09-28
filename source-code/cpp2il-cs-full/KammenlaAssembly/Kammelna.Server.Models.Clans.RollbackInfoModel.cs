using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class RollbackInfoModel
{
	public int ClanId;

	public string OriginalName;

	public ClanDeletionSource Source;

	public ClanBadgeModel Clan;

	public DateTime SoftDeletedAt;

	public DateTime ExpiresAt;
}
