using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanMemberViewModel
{
	public long UserId;

	public string Name;

	public DateTime? AvatarDate;

	public string RoleTitle;

	public ClanPermissions Permissions;

	public DateTime JoinedAt;

	public bool IsOwner;
}
