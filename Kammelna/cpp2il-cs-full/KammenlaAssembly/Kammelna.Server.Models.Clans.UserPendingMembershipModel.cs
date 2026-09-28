using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class UserPendingMembershipModel
{
	public int ClanId;

	public string ClanName;

	public int ClanTier;

	public ClanPendingDirection Direction;

	public long InitiatorUserId;

	public DateTime CreatedAt;
}
