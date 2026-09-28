using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanSubscriptionModel
{
	public string Status;

	public DateTime ExpiresAt;

	public bool AutoRenewal;

	public int VaultBalance;
}
