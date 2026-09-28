using System;
using Cpp2ILInjected;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class MonthlyTournamentUserFeedItemIcon : UserFeedItemIcon
{
	private Image trophyImage;

	private Sprite platinum1;

	private Sprite platinum2;

	private Sprite gold1;

	private Sprite gold2;

	private Sprite silver1;

	private Sprite silver2;

	private Sprite bronze1;

	private Sprite bronze2;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0176: Expected O, but got I4
		WonTournamentFeedData <Data>k__BackingField = (WonTournamentFeedData)feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField != null)
		{
			object obj = typeof(UsageHint) + 2208;
			object obj2 = obj;
			nint num = (nint)<Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v3 (Il2CppClass<Server.Models.WonTournamentFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v3 (Il2CppClass<Server.Models.WonTournamentFeedData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X9_v5-8]");
				if (0 == (nint)obj2)
				{
					Sprite trophyImageSprite = GetTrophyImageSprite((WonTournamentFeedData)feedItem.<Data>k__BackingField);
					trophyImage.sprite = trophyImageSprite;
					RectTransform rectTransform = trophyImage.rectTransform;
					int num4 = <Data>k__BackingField.<Place>k__BackingField << 4;
					object obj6 = num4 - <Data>k__BackingField.<Place>k__BackingField;
					float value = (float)obj6 - 55f;
					float? y = value;
					UIExtensions.MoveTo(rectTransform, isWorldPositions: false, (float?)(object)0, y);
				}
			}
		}
		Actions.SafeInvoke(onReady);
	}

	private Sprite GetTrophyImageSprite(WonTournamentFeedData tournamentFeedData)
	{
		//IL_0243: Expected O, but got I4
		//IL_0250: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_023a: Expected O, but got I
		//IL_02be: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_0224: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_027c: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_01c7: Expected O, but got I
		//IL_0259: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_00b9: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		if (tournamentFeedData.<Prize>k__BackingField <= 1)
		{
			if (tournamentFeedData.<Prize>k__BackingField != 0)
			{
				if (tournamentFeedData.<Prize>k__BackingField == 1)
				{
					if (tournamentFeedData.<Place>k__BackingField == 1)
					{
						object obj = 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v191 @ X8_v9]");
						return (Sprite)0;
					}
					if (tournamentFeedData.<Place>k__BackingField == 2)
					{
						object obj2 = 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v237 @ X8_v10]");
						return (Sprite)0;
					}
				}
			}
			else
			{
				if (tournamentFeedData.<Place>k__BackingField == 1)
				{
					object obj3 = 40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v166 @ X8_v7]");
					return (Sprite)0;
				}
				if (tournamentFeedData.<Place>k__BackingField == 2)
				{
					object obj4 = 48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v197 @ X8_v8]");
					return (Sprite)0;
				}
			}
		}
		else if (tournamentFeedData.<Prize>k__BackingField != 2)
		{
			if (tournamentFeedData.<Prize>k__BackingField == 3)
			{
				if (tournamentFeedData.<Place>k__BackingField == 1)
				{
					object obj5 = 88;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v240 @ X8_v5]");
					return (Sprite)0;
				}
				if (tournamentFeedData.<Place>k__BackingField == 2)
				{
					object obj6 = 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v238 @ X8_v6]");
					return (Sprite)0;
				}
			}
		}
		else
		{
			if (tournamentFeedData.<Place>k__BackingField == 1)
			{
				object obj7 = 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v182 @ X8_v3]");
				return (Sprite)0;
			}
			if (tournamentFeedData.<Place>k__BackingField == 2)
			{
				object obj8 = 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTournamentUserFeedItemIcon)+v239 @ X8_v4]");
				return (Sprite)0;
			}
		}
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj10 = (nint)0 + (nint)208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Sprite)(object)new OutOfMemoryException();
	}
}
