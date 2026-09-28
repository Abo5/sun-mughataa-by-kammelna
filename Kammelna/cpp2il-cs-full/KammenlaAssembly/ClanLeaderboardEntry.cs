using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class ClanLeaderboardEntry : MonoBehaviour
{
	private ClanEmblemLoader Logo;

	private TextMeshProUGUI Name;

	private TextMeshProUGUI Score;

	private ClansSerializedUtils clanUtils;

	private int _clanId;

	public void Populate(InterClanLeaderboardEntryModel entry)
	{
		_clanId = entry.ClanId;
		TextMeshProExtensions.FixArabic(Name, entry.ClanName);
		TextMeshProExtensions.SetNumber(Score, entry.Score, useCommas: true);
		Logo.Load(entry.ClanId, entry.Emblem);
	}

	public void OpenClanProfile()
	{
		clanUtils.OpenClanInfoPopup(_clanId);
	}

	private void LoadEmblem(InterClanLeaderboardEntryModel entry)
	{
		Logo.Load(entry.ClanId, entry.Emblem);
	}
}
