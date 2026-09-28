using System;

namespace KammelnaOffline;

public class CachedUserInfoModel
{
	public string DbId;

	public string UserName;

	public string TitleId;

	public int TitleLevel;

	public int ActiveCardback;

	public int UserPoints;

	public int UserTournamentPoints;

	public bool IsNew;

	public DateTime? AvatarDate;

	public Games Game;

	public SubscriptionStatus SubscriptionStatus;

	public bool IsVerified;

	public GameStatisticsModel GameStatistics;
}
