using System.Buffers.Text;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RankPanel : RankSetter
{
	private RankColors rankColors;

	private RankFonts fonts;

	private Image rankImage;

	private TextMeshProUGUI rankTitle;

	private TextMeshProUGUI rankTitleDouble;

	public override void SetRank(PlayerRank playerRank, bool alsoAnimate = false)
	{
		//IL_017a: Expected O, but got I
		//IL_01a2: Expected I, but got O
		//IL_01b2: Expected O, but got I
		//IL_01bd: Expected O, but got I
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_00f3: Invalid comparison between F4 and I4
		//IL_0102: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_0248: Expected O, but got I4
		//IL_01ce: Expected O, but got I
		//IL_02a9: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_02d2: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03fe: Expected O, but got I4
		//IL_0433: Expected O, but got I
		//IL_0459: Expected I, but got O
		float num2 = default(float);
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		while (playerRank != null)
		{
			object obj9;
			Color color4;
			if (alsoAnimate)
			{
				Color color = rankImage.color;
				object obj = (nint)0 + (nint)2000;
				Color color2 = rankColors.GetFor(playerRank);
				float num = num2 - num2;
				object obj2 = obj3 - obj3;
				obj4 -= obj4;
				obj5 -= obj5;
				float num3 = num * num;
				object obj6 = obj2 * obj2;
				float num4 = num3 + (float)obj6;
				object obj7 = obj4 * obj4;
				float num5 = (float)obj7 + num4;
				object obj8 = obj5 * obj5;
				num2 = (float)obj8 + num5;
				bool flag = num2 < 786163460f;
				obj3 = 786163454;
				if (!flag)
				{
					int num6 = ShortcutExtensions.DOKill(rankImage);
					obj9 = obj;
					Color color3 = rankColors.GetFor(playerRank);
					TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(rankImage, (Color)0, num2);
					obj3 = 786163454;
					color4 = (Color)0;
					goto IL_0499;
				}
			}
			Image image = rankImage;
			object obj10 = (nint)0 + (nint)2000;
			obj9 = obj10;
			Color color5 = rankColors.GetFor(playerRank);
			nint num7 = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v17 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
			color4 = (Color)0;
			image.color = (Color)0;
			goto IL_0499;
			IL_0499:
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = this + 72;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v4+E4]");
			object obj14;
			object obj15;
			if ((nint)0 != 0)
			{
				obj14 = (nint)0 + (nint)2024;
				if (!(Object)obj12)
				{
					goto IL_025e;
				}
				obj15 = obj14;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = (nint)0 + (nint)2024;
				bool flag2 = (Object)obj12;
				bool flag3 = !flag2;
				object obj16 = !flag3;
				obj15 = obj14;
				if (obj16 == null)
				{
					goto IL_025e;
				}
			}
			goto IL_032f;
			IL_025e:
			Transform transform = rankTitle.transform;
			Transform parent = transform.parent;
			object obj17 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj19 = (nint)0 + (nint)768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			rankTitleDouble = textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object fontMaterial = ((RanksData<object>)(object)fonts).GetFor(PlayerRank.Ranks.AI, isNew: false);
			rankTitleDouble.fontMaterial = (Material)fontMaterial;
			obj15 = obj14;
			goto IL_032f;
			IL_032f:
			string rankName = playerRank.RankName;
			TextMeshProExtensions.Localize(rankTitle, rankName);
			object fontMaterial2 = ((RanksData<object>)(object)fonts).GetFor(playerRank.<Rank>k__BackingField, isNew: false);
			rankTitle.fontMaterial = (Material)fontMaterial2;
			string rankName2 = playerRank.RankName;
			TextMeshProExtensions.Localize(rankTitleDouble, rankName2);
			object obj20 = typeof(System.Formats.Asn1.SetOfValueComparer) + 160;
			TextMeshProUGUI textMeshProUGUI2 = rankTitleDouble;
			Material fontMaterial3 = rankTitle.fontMaterial;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj23 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v7+B8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v8+8]");
			Color color6 = fontMaterial3.GetColor(0);
			nint num8 = (nint)textMeshProUGUI2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v225 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8] (should have been resolved before IL gen)");
		}
	}

	private void AnimateRank(PlayerRank playerRank)
	{
		//IL_002d: Expected O, but got I4
		int num = ShortcutExtensions.DOKill(rankImage);
		Color color = rankColors.GetFor(playerRank);
		float duration = default(float);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(rankImage, (Color)0, duration);
	}

	public override void SetAlpha(float alphaValue)
	{
		UIExtensions.SetAlpha(rankImage, alphaValue);
		UIExtensions.SetAlpha(rankTitle, alphaValue);
		UIExtensions.SetAlpha(rankTitleDouble, alphaValue);
	}

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0012: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0032: Expected O, but got I
		PlayerRank <Rank>k__BackingField = avatarData.<Rank>k__BackingField;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<RankPanel>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<RankPanel>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Initialize(User userData)
	{
		//IL_0012: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0032: Expected O, but got I
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(userData);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankPanel>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<RankPanel>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v18 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Expected I, but got O
		//IL_004b: Expected O, but got I
		//IL_005b: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(PlayerRank.Ranks.Beginner, isNew: true);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<RankPanel>)+1A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (Il2CppClass<RankPanel>)+1B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
