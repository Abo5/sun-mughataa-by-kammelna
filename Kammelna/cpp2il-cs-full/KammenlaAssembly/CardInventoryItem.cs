using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class CardInventoryItem : InventoryItem
{
	public Image[] ItemImages;

	public GameObject SelectionIndicator;

	public CardBackSetter cardBackSetter;

	public override void PopulateAsDefault(InventoryItemSelection manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_006b: Expected O, but got I4
		//IL_00d4: Expected I, but got O
		//IL_00e4: Expected O, but got I
		//IL_00f4: Expected O, but got I
		InventoryItemSelection manager2 = default(InventoryItemSelection);
		SessionModel sessionModel = default(SessionModel);
		while (true)
		{
			base.PopulateAsDefault(manager2);
			GameObject gameObject = base.gameObject;
			object obj = "Cannot populate JSON object onto type '{0}'." + 1672;
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			gameObject.name = (string)obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			User localUser = sessionModel.LocalUser;
			int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
			bool flag2 = activeCardbackID == 0;
			base._isHighlighted = flag2;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v8 (Il2CppClass<CardInventoryItem>)+1A8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v8 (Il2CppClass<CardInventoryItem>)+1B0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public override void PopulateInfo(StoreOwnedItem ownedItem, int itemIndex, InventoryItemSelection manager)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Expected I, but got O
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		InventoryItemSelection manager2 = default(InventoryItemSelection);
		base.PopulateInfo(ownedItem, itemIndex, manager2);
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<CardInventoryItem>)+1A0]");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)0);
		object obj2 = "Cannot populate JSON object onto type '{0}'." + 1664;
		cardBackSetter.AssignCardBack(ownedItem.<itemId>k__BackingField, isMyCard: false, action);
		GameObject gameObject = base.gameObject;
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = (string)obj2 + text;
		gameObject.name = text2;
	}

	protected override void UpdateHighlighting()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_021d: Expected F8, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C0F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object selectionIndicator;
		UnityEngine.Object selectionIndicator2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			selectionIndicator = SelectionIndicator;
			selectionIndicator2 = SelectionIndicator;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			selectionIndicator = SelectionIndicator;
			selectionIndicator2 = SelectionIndicator;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = selectionIndicator2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_00b7;
		}
		goto IL_015b;
		IL_00b7:
		SelectionIndicator.SetActive(base._isHighlighted);
		return;
		IL_015b:
		Image[] itemImages = ItemImages;
		if (ItemImages == null || itemImages.Length < 1)
		{
			return;
		}
		object obj7 = ItemImages + 32;
		object obj8 = 0;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X22_v4+v156 @ X21_v7*8]");
			object obj9 = 0;
			obj8++;
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
			object obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X8_v8+2A8] (should have been resolved before IL gen)");
		}
		while ((nint)obj8 < itemImages.Length);
		return;
		IL_0091:
		if ((bool)selectionIndicator)
		{
			goto IL_00b7;
		}
		goto IL_015b;
	}
}
