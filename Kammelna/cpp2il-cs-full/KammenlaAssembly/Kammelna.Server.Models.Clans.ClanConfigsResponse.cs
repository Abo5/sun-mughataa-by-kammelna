using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanConfigsResponse
{
	private sealed class <>c__DisplayClass15_0
	{
		public int tier;

		internal bool <GetTier>b__0(ClanTierConfig t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.Tier - tier;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int CreationCost;

	public int RenewalCost;

	public int PaidAnnouncementCost;

	public int InterClanTopXCount;

	public int CreationPeriodDays;

	public int RenewalPeriodDays;

	public int GracePeriodDays;

	public int SubscriptionWarningLeadTimeDays;

	public int RollbackDays;

	public ClanXpGainMode XpGainMode;

	public float XpGainValue;

	public List<ClanTierConfig> Tiers;

	public List<ClanSupportTierConfig> SupportTiers;

	public List<ClanVaultVisualTierConfig> VaultVisualTiers;

	public List<string> EmblemColorPresets;

	public ClanTierConfig GetTier(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0079: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			if (Tiers != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 728;
				object obj4 = (nint)0 + (nint)3464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return (ClanTierConfig)Enumerable.FirstOrDefault(Tiers, func);
			}
			return null;
		}
		return (ClanTierConfig)(object)new NullReferenceException();
	}
}
