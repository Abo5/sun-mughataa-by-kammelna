using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanFeedModel
{
	public long Id;

	public int ClanId;

	public string ClanName;

	public FileInfoModel Emblem;

	public ClanFeedType Type;

	public ClanFeedScope Scope;

	public bool Pinned;

	public FeedInteractionsSummary Interactions;

	public bool IsPinnable;

	public bool IsLikeable;

	public long? UserId;

	public DateTime DateCreated;

	public DateTime? DateCompleted;

	public ClanFeedData Data;

	public bool IsSynthetic => (byte)(Id >> 63) != 0;
}
