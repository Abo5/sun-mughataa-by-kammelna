using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class TournamentCardRoomThemeSetter : MonoBehaviour
{
	private Image roomThemeLogo;

	private Image cardSolidColor;

	private Color defaultColor;

	private Sprite defaultLogo;

	public void Initialize(int roomThemeId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0305: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_03d3: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D52]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = roomThemeLogo;
			obj6 = roomThemeLogo;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = roomThemeLogo;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = roomThemeLogo;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		bool flag3 = obj6;
		bool flag4 = !flag3;
		int num = 0;
		object obj9 = obj8;
		if (flag4)
		{
			goto IL_00e7;
		}
		goto IL_0228;
		IL_0313:
		StoreItem storeItem;
		object obj10 = (??)storeItem.<Color>k__BackingField & 1;
		if (obj10 != null)
		{
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((bool)cardSolidColor)
			{
				Color? color = default(Color?);
				Color value = color.Value;
				cardSolidColor.color = (Color)0;
			}
		}
		return;
		IL_0134:
		storeItem = Store.GetStoreItem(roomThemeId);
		bool flag6 = storeItem == null;
		object obj13 = !flag6;
		ImageCacher.ItemImageType itemImageType = ImageCacher.ItemImageType.StoreTitle;
		object obj14 = 0;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0313;
		IL_02b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		storeItem = Store.GetStoreItem(roomThemeId);
		bool flag7 = storeItem == null;
		object obj16;
		object obj15 = obj16;
		Action<bool> action2;
		Action<bool> action = action2;
		FilterMode filterMode2;
		FilterMode filterMode = filterMode2;
		obj14 = 0;
		if (flag7)
		{
			return;
		}
		goto IL_0313;
		IL_0091:
		obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj17 = !flag9;
		num = 0;
		obj9 = obj8;
		if (obj17 == null)
		{
			goto IL_00e7;
		}
		goto IL_0228;
		IL_0228:
		UIExtensions.LoadItemImage(roomThemeLogo, roomThemeId, ImageCacher.ItemImageType.StoreTitle);
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		obj15 = 0;
		action = null;
		filterMode = FilterMode.Point;
		obj16 = 0;
		action2 = null;
		filterMode2 = FilterMode.Point;
		itemImageType = ImageCacher.ItemImageType.StoreTitle;
		num = roomThemeId;
		if (obj19 != null)
		{
			goto IL_0134;
		}
		goto IL_02b9;
		IL_00e7:
		obj18 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag11 = (nint)0 == 0;
		obj16 = obj15;
		action2 = action;
		filterMode2 = filterMode;
		IntPtr intPtr = default(IntPtr);
		itemImageType = (ImageCacher.ItemImageType)(nint)intPtr;
		if (!flag11)
		{
			goto IL_0134;
		}
		goto IL_02b9;
	}

	public void resetUI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_03c9: Expected O, but got I4
		//IL_0285: Expected O, but got I
		//IL_0295: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_02b7: Expected I, but got O
		//IL_02c7: Expected O, but got I
		//IL_02d7: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D53]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = roomThemeLogo;
			obj6 = roomThemeLogo;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = roomThemeLogo;
			obj6 = roomThemeLogo;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (!flag4)
		{
			goto IL_0188;
		}
		goto IL_01f7;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = defaultLogo != null;
		bool flag6 = !flag5;
		obj10 = 0;
		obj11 = null;
		if (flag6)
		{
			goto IL_01f7;
		}
		goto IL_0327;
		IL_0266:
		Image image = cardSolidColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCardRoomThemeSetter)+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCardRoomThemeSetter)+3C]");
		object obj13 = 0;
		Color color = defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentCardRoomThemeSetter)+34]");
		object obj14 = 0;
		nint num = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v6 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v6 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v168 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_02e1;
		IL_0240:
		UnityEngine.Object obj17;
		if ((bool)obj17)
		{
			goto IL_0266;
		}
		return;
		IL_0091:
		bool flag7 = obj5 != null;
		bool flag8 = !flag7;
		object obj18 = !flag8;
		obj8 = 0;
		obj9 = null;
		if (obj18 != null)
		{
			goto IL_0188;
		}
		obj10 = 0;
		obj11 = null;
		goto IL_01f7;
		IL_0188:
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v16+E4]");
		if ((nint)0 == 0)
		{
			goto IL_02e1;
		}
		bool flag9 = defaultLogo != null;
		bool flag10 = !flag9;
		object obj20 = !flag10;
		obj10 = 0;
		obj11 = null;
		if (obj20 == null)
		{
			goto IL_01f7;
		}
		goto IL_0327;
		IL_0397:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj21;
		bool flag11 = obj21;
		bool flag12 = !flag11;
		object obj22 = !flag12;
		if (obj22 == null)
		{
			return;
		}
		goto IL_0266;
		IL_0327:
		Sprite sprite = defaultLogo;
		roomThemeLogo.sprite = defaultLogo;
		obj17 = cardSolidColor;
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		obj10 = 0;
		obj21 = cardSolidColor;
		if (obj24 != null)
		{
			goto IL_0240;
		}
		goto IL_0397;
		IL_01f7:
		obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+E4]");
		bool flag14 = (nint)0 == 0;
		obj17 = cardSolidColor;
		sprite = (Sprite)obj11;
		obj21 = cardSolidColor;
		if (!flag14)
		{
			goto IL_0240;
		}
		goto IL_0397;
	}
}
