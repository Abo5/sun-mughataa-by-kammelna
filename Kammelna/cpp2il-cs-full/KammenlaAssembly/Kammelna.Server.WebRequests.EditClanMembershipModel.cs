using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class EditClanMembershipModel
{
	public long TargetUserId;

	public string RoleTitle;

	public ClanPermissions Permissions;
}
