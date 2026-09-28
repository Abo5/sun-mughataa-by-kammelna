using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class InternalLeaderboardEntryModel
{
	public int Rank;

	public long UserId;

	public string UserName;

	public DateTime? AvatarDate;

	public long? ActiveCardBackId;

	public long Score;

	public string RoleTitle;

	public bool IsOwner;
}
