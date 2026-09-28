namespace Server.Coordinator.Models;

public enum ClanMembershipChangeType
{
	Joined = 1,
	Left,
	Kicked,
	Disbanded,
	RoleChanged,
	JoinRequested
}
