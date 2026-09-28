using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanVaultSupporterModel
{
	public long UserId;

	public string Name;

	public DateTime? AvatarDate;

	public int TotalAmount;

	public DateTime LastTransactionDate;
}
