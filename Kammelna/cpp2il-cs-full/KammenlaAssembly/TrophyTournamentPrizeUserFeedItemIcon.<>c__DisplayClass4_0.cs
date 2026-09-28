using System;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class TrophyTournamentPrizeUserFeedItemIcon : UserFeedItemIcon
{
	private sealed class <>c__DisplayClass4_0
	{
		public TrophyTournamentPrizeUserFeedItemIcon <>4__this;

		public Action onReady;

		internal void <Populate>b__0(bool success)
		{
			TrophyTournamentPrizeUserFeedItemIcon trophyTournamentPrizeUserFeedItemIcon = <>4__this;
			GameObject gameObject = trophyTournamentPrizeUserFeedItemIcon.trophyImage.gameObject;
			gameObject.SetActive(success);
			Actions.SafeInvoke(onReady);
		}
	}

	private Image rankImage;

	private Image moneyImage;

	private Image trophyImage;

	private RankPlaceSprites rankSprites;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ae: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected I4, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I
		//IL_0307: Expected O, but got I4
		//IL_0310: Expected O, but got I4
		//IL_0295: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0359: Expected I, but got O
		//IL_0385: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = onReady;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UserFeedData <Data>k__BackingField = feedItem.<Data>k__BackingField;
		if (feedItem.<Data>k__BackingField != null)
		{
			object obj5 = typeof(UsageHint) + 2208;
			object obj6 = obj5;
			nint num = (nint)<Data>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v3 (Il2CppClass<Server.Models.UserFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+130]");
			bool flag = num2 < 0;
			object obj7 = !flag;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X9_v3 (Il2CppClass<Server.Models.UserFeedData>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v7+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X9_v5-8]");
				if (0 == (nint)obj6)
				{
					RankPlaceSprites rankPlaceSprites = rankSprites;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+14]");
					Sprite rankImageSprite = rankPlaceSprites.GetRankImageSprite(0);
					rankImage.sprite = rankImageSprite;
					GameObject gameObject = moneyImage.gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+24]");
					bool flag2 = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+24]");
					bool flag3 = (nint)0 == 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+24]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+24]");
					object obj10 = num4 ^ 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+24]");
					object obj11 = 0 & obj10;
					bool flag4 = (nint)obj11 < 0;
					bool flag5 = flag2 == flag4;
					object obj12 = !flag3;
					bool active = (byte)((flag5 & obj12) ? 1 : 0) != 0;
					gameObject.SetActive(active);
					GameObject gameObject2 = trophyImage.gameObject;
					gameObject2.SetActive(value: false);
					object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v11+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+28]");
						bool flag6 = StringsExtensions.IsNullOrEmpty((string)0);
						bool flag7 = !flag6;
						object obj15 = 0;
						if (!flag7)
						{
							goto IL_02bf;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+28]");
						bool flag8 = StringsExtensions.IsNullOrEmpty((string)0);
						bool flag9 = !flag8;
						object obj16 = !flag9;
						object obj15 = 0;
						if (obj16 != null)
						{
							goto IL_02bf;
						}
					}
					object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj18 = (nint)0 + (nint)776;
					Action<bool> action = default(Action<bool>);
					action..ctor(obj2, (IntPtr)obj18);
					Image img = trophyImage;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+28]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v3 (Server.Models.UserFeedData)+30]");
					UIExtensions.LoadAchievementImage(img, (string)num5, 0, action);
					return;
				}
			}
		}
		goto IL_02bf;
		IL_02bf:
		Actions.SafeInvoke((Action)obj4);
	}
}
