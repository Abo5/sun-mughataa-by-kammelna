using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanPendingMembershipViewModel
{
	public long UserId;

	public string Name;

	public DateTime? AvatarDate;

	public ClanPendingDirection Direction;

	public long InitiatorUserId;

	public DateTime CreatedAt;
}
