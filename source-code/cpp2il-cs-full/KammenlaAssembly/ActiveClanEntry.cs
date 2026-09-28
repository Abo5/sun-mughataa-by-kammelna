using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class ActiveClanEntry : MonoBehaviour
{
	private ClanEmblemLoader logo;

	private TextMeshProUGUI clanName;

	private ClanTierIcon tierIcon;

	private ClansSerializedUtils clanUtils;

	private int _clanId;

	public void Populate(ClanSummaryModel summary)
	{
		_clanId = summary.ClanId;
		TextMeshProExtensions.FixArabic(clanName, summary.Name);
		tierIcon.SetTier(summary.Tier);
		logo.Load(summary.ClanId, summary.Emblem);
	}
}
