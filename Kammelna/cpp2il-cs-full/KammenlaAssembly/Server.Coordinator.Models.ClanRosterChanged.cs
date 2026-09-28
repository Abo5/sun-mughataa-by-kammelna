using System;

namespace Server.Coordinator.Models;

[Serializable]
public class ClanRosterChanged
{
	public int ClanId;

	public ClanMembershipChangeType ChangeType;

	public long UserId;

	public string DisplayName;
}
