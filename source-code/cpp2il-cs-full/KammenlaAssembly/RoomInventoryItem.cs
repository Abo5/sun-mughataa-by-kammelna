using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class RoomInventoryItem : InventoryItem
{
	public DateTimeText TimeLeft;

	public GameObject KammelnaText;

	private bool displayTimeLeft = true;

	private Button selectButton;

	private BaseToggler labelColorToggler;

	public override void PopulateAsDefault(InventoryItemSelection manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_00b9: Expected O, but got I4
		//IL_0122: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_0142: Expected O, but got I
		InventoryItemSelection manager2 = default(InventoryItemSelection);
		SessionModel sessionModel = default(SessionModel);
		while (true)
		{
			base.PopulateAsDefault(manager2);
			GameObject gameObject = base.gameObject;
			object obj = "Read object reference Id '{0}' for {1}." + 3400;
			gameObject.name = (string)obj;
			GameObject gameObject2 = TimeLeft.gameObject;
			gameObject2.SetActive(value: false);
			GameObject gameObject3 = KammelnaText.gameObject;
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			gameObject3.SetActive(value: true);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			User localUser = sessionModel.LocalUser;
			int activeRoomThemeID = SFSKammelnaUserExtensions.GetActiveRoomThemeID(localUser);
			bool flag2 = activeRoomThemeID == 0;
			base._isHighlighted = flag2;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8 (Il2CppClass<RoomInventoryItem>)+1A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v8 (Il2CppClass<RoomInventoryItem>)+1B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v117 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	public override void PopulateInfo(StoreOwnedItem ownedItem, int itemIndex, InventoryItemSelection manager)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		object obj = "Read object reference Id '{0}' for {1}." + 3392;
		InventoryItemSelection manager2 = default(InventoryItemSelection);
		base.PopulateInfo(ownedItem, itemIndex, manager2);
		GameObject gameObject = base.gameObject;
		int num = default(int);
		string text = num.ToString();
		string text2 = (string)obj + text;
		gameObject.name = text2;
		if (displayTimeLeft)
		{
			GameObject gameObject2 = TimeLeft.gameObject;
			gameObject2.SetActive(value: true);
		}
		GameObject gameObject3 = KammelnaText.gameObject;
		gameObject3.SetActive(value: false);
		object obj2 = (??)ownedItem.<expirationDate>k__BackingField & 1;
		if (obj2 != null)
		{
			DateTime? dateTime = default(DateTime?);
			DateTime value = dateTime.Value;
			TimeLeft.SetDate(value);
		}
	}

	protected override void UpdateHighlighting()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_01f7: Expected F8, but got I4
		//IL_00d6: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected I4, but got Unknown
		//IL_0204: Expected I, but got O
		//IL_0214: Expected O, but got I
		//IL_0224: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C25]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectButton;
			obj6 = selectButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selectButton;
			obj6 = selectButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_019a;
		IL_00b7:
		GameObject gameObject = selectButton.gameObject;
		object obj9 = ~(base._isHighlighted ? 1 : 0);
		bool active = (byte)(1 & obj9) != 0;
		gameObject.SetActive(active);
		labelColorToggler.ToggleManual(base._isHighlighted);
		return;
		IL_019a:
		Image itemImage = ItemImage;
		bool flag5 = !base._isHighlighted;
		object obj10 = !flag5;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			double num = 1.0;
		}
		else
		{
			double num = 1059481190.0;
		}
		nint num2 = (nint)itemImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v155 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		goto IL_019a;
	}
}
