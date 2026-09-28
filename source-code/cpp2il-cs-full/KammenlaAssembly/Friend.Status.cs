using System;
using Kammelna.Server.Models.Clans;

[Serializable]
public class Friend
{
	public enum Status
	{
		PendingAccept,
		PendingResponse,
		Accepted,
		Blocked
	}

	public int id;

	public string name;

	public Status status;

	public DateTime? avatarDate;

	public bool isSubscribed;

	public bool isVerified;

	public ClanBadgeModel ActiveClan;
}
