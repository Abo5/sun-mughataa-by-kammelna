using System;
using System.Collections.Generic;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanViewModel
{
	public int Id;

	public string Name;

	public string Description;

	public string Rules;

	public long OwnerId;

	public int Tier;

	public int PurchasedEmblemTier;

	public int ActiveEmblemTier;

	public int Xp;

	public long MonthlyPoints;

	public ClanStatus Status;

	public DateTime DateCreated;

	public FileInfoModel Emblem;

	public List<ClanMemberViewModel> Members;

	public DateTime? DateSubscriptionExpires;

	public bool? AutoRenewal;

	public List<ClanPendingMembershipViewModel> PendingMemberships;

	public ClanLogoModel LogoModel;

	public ClanDeletionSource? DeletionSource;

	public DateTime? SoftDeletedAt;
}
