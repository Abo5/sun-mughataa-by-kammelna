using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class FriendInClanEntry : MonoBehaviour
{
	private AvatarInitializer avatar;

	private TextMeshProUGUI clanName;

	private ClanTierIcon clanIcon;

	public void Populate(int userId, ClanBadgeModel clan)
	{
		int num = default(int);
		string dbId = num.ToString();
		avatar.InitializeFriendWithDbId(dbId);
		TextMeshProExtensions.FixArabic(clanName, clan.Name);
		clanIcon.SetTier(clan.Tier);
	}
}
