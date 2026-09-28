using Kammelna.Server.Models.Clans;
using ListView;

public class ClanEventStrip_FriendlyChallengeResult : ClanEventStrip_LiveActivityResult
{
	private const string RESULT_KEY = "clan_feed_friendly_challenge_result";

	private AvatarInitializer _loserAvatar1;

	private AvatarInitializer _loserAvatar2;

	protected override void Populate(LiveActivityResultClanFeedData data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3568;
		TextMeshProExtensions.Localize(text, (string)obj);
		ClanEventStrip_LiveActivityResult.BindAvatar(avatar, data.<WinnerUserIds>k__BackingField, 0);
		ClanEventStrip_LiveActivityResult.BindAvatar(base._avatarInitializer2, data.<WinnerUserIds>k__BackingField, 1);
		ClanEventStrip_LiveActivityResult.BindAvatar(_loserAvatar1, data.<LoserUserIds>k__BackingField, 0);
		ClanEventStrip_LiveActivityResult.BindAvatar(_loserAvatar2, data.<LoserUserIds>k__BackingField, 1);
	}

	public ClanEventStrip_FriendlyChallengeResult()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
