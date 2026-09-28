using System;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardGiftBombItem : ListViewItem<LeaderboardBombItemHolder, int>
{
	private AvatarInitializer avatar;

	private Image bombTypeIcon;

	private TextMeshProUGUI shardCount;

	private TextMeshProUGUI shardValue;

	private DateTimeText sinceText;

	private Sprite subsBombIcon;

	private Sprite acesBombIcon;

	private GiftBombData _giftBombData;

	public unsafe override void Setup(LeaderboardBombItemHolder datum, bool firstTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0059: Expected O, but got Ref
		//IL_0077: Expected O, but got I4
		//IL_0029: Expected O, but got Ref
		//IL_003b: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		int num = default(int);
		object obj2 = default(object);
		bool flag = ((ValueType)(&num)).Equals(obj2);
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			base.Setup((LeaderboardBombItemHolder)(&num), firstTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardGiftBombItem)+50]");
			Populate((GiftBombData)0);
		}
	}

	private void Populate(GiftBombData giftBombData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0133: Expected O, but got I4
		object obj = this + 200;
		obj = giftBombData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v1+18]");
		AvatarData avatarData = (PlayerInfo)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X20_v2-38]");
		((AvatarInitializer)0).Initialize(avatarData);
		int num = default(int);
		string text = num.ToString();
		shardValue.text = text;
		int num2 = default(int);
		string text2 = num2.ToString();
		shardCount.text = text2;
		GiftBombData giftBombData2 = _giftBombData;
		sinceText.SetDate(giftBombData2.<DateCreated>k__BackingField);
		GiftBombData giftBombData3 = _giftBombData;
		object sprite;
		object obj4;
		if (giftBombData3.<Category>k__BackingField != GiftBombType.Subscription)
		{
			bool flag = giftBombData3.<Category>k__BackingField == GiftBombType.Currency;
			object obj3 = !flag;
			if (obj3 != null)
			{
				sprite = bombTypeIcon + 216;
				goto IL_016a;
			}
			obj4 = 192;
		}
		else
		{
			obj4 = 184;
		}
		sprite = (object)this + obj4;
		goto IL_016a;
		IL_016a:
		bombTypeIcon.sprite = (Sprite)sprite;
	}

	public void ShowPlayerProfile()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		int num = default(int);
		string dbId = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MiniProfilePopup.Show(dbId, TrackingPlacement.RecentBombersList);
	}
}
