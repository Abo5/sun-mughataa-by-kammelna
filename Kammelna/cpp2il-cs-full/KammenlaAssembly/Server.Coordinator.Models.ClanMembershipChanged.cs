using System;

namespace Server.Coordinator.Models;

[Serializable]
public class ClanMembershipChanged
{
	public ClanMembershipChangeType ChangeType;

	public int? ClanId;
}
