using System;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class CoinsTournamentPrizeUserFeedItemIcon : UserFeedItemIcon
{
	private Image rankImage;

	private Image moneyImage;

	private RankPlaceSprites rankSprites;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0176: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected I4, but got Unknown
		UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField != null)
		{
			object obj = typeof(UsageHint) + 2208;
			object obj2 = obj;
			nint num = (nint)<Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v3 (Il2CppClass<Server.Models.UserFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X9_v3 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X9_v5-8]");
				if (0 == (nint)obj2)
				{
					RankPlaceSprites rankPlaceSprites = rankSprites;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+14]");
					Sprite rankImageSprite = rankPlaceSprites.GetRankImageSprite(0);
					rankImage.sprite = rankImageSprite;
					GameObject gameObject = moneyImage.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+24]");
					bool flag2 = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+24]");
					bool flag3 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+24]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+24]");
					object obj6 = num4 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v3 (Server.Models.UserFeedData)+24]");
					object obj7 = 0 & obj6;
					bool flag4 = (nint)obj7 < 0;
					bool flag5 = flag2 == flag4;
					object obj8 = !flag3;
					bool active = (byte)((flag5 & obj8) ? 1 : 0) != 0;
					gameObject.SetActive(active);
					Actions.SafeInvoke(onReady);
					return;
				}
			}
		}
		Actions.SafeInvoke(onReady);
	}
}
