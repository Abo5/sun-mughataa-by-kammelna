using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
	public Image ItemImage;

	public Image ItemTitleImage;

	public GameObject LoadingIndicator;

	private bool <isDefaultItem>k__BackingField;

	private StoreOwnedItem <OwnedItem>k__BackingField;

	protected InventoryItemSelection Manager;

	private bool isPendingActivatiion;

	private bool _isHighlighted;

	public bool isDefaultItem
	{
		get
		{
			return <isDefaultItem>k__BackingField;
		}
		set
		{
			<isDefaultItem>k__BackingField = value;
		}
	}

	public StoreOwnedItem OwnedItem
	{
		get
		{
			return <OwnedItem>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool isHighlighted
	{
		get
		{
			return _isHighlighted;
		}
		set
		{
			//IL_000f: Expected I, but got O
			//IL_001f: Expected O, but got I
			//IL_002f: Expected O, but got I
			_isHighlighted = value;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<InventoryItem>)+1A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<InventoryItem>)+1B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public void ActivateItem()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !_isHighlighted;
		object obj = !flag;
		if (obj == null && !isPendingActivatiion)
		{
			isPendingActivatiion = true;
			LoadingIndicator.SetActive(value: true);
			if (<isDefaultItem>k__BackingField)
			{
				Manager.ResetItemToDefault();
			}
			else
			{
				Manager.SendActivation(<OwnedItem>k__BackingField);
			}
		}
	}

	public void FinalizeActivation(bool isSuccess)
	{
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0069: Expected O, but got I
		isPendingActivatiion = false;
		LoadingIndicator.SetActive(value: false);
		if (isSuccess)
		{
			_isHighlighted = true;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2 (Il2CppClass<InventoryItem>)+1A8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v2 (Il2CppClass<InventoryItem>)+1B0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v36 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	public virtual void PopulateAsDefault(InventoryItemSelection manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_00a4: Expected O, but got I4
		//IL_002a: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 72;
		InventoryItemSelection inventoryItemSelection = default(InventoryItemSelection);
		obj2 = inventoryItemSelection;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-20]");
			if (!(UnityEngine.Object)0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v3-20]");
			bool flag = (UnityEngine.Object)0;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		GameObject gameObject = ItemTitleImage.gameObject;
		gameObject.SetActive(value: false);
	}

	public virtual void PopulateInfo(StoreOwnedItem ownedItem, int itemIndex, InventoryItemSelection manager)
	{
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_0107: Expected I4, but got O
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0231: Expected I, but got O
		//IL_02a2: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_02b3: Expected I, but got O
		//IL_02ca: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_034b: Expected I, but got O
		//IL_0353: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_019d: Expected I, but got O
		object obj = this + 72;
		InventoryItemSelection inventoryItemSelection = default(InventoryItemSelection);
		obj = inventoryItemSelection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 64;
		obj2 = ownedItem;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isActiveItem = ownedItem.IsActiveItem;
		_isHighlighted = isActiveItem;
		UpdateHighlighting();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		LoadingIndicator.SetActive(value: true);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v15+E4]");
		int num;
		if ((nint)0 != 0)
		{
			bool flag = ItemImage;
			bool flag2 = !flag;
			object obj5 = !flag2;
			num = 0;
			int num2 = 0;
			if (obj5 == null)
			{
				goto IL_00bd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = ItemImage;
			bool flag4 = !flag3;
			num = 0;
			int num2 = 0;
			if (flag4)
			{
				goto IL_00bd;
			}
		}
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v10 (Il2CppClass<InventoryItem>)+1A0]");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)0);
		UIExtensions.LoadItemImage(ItemImage, ownedItem.<itemId>k__BackingField, ImageCacher.ItemImageType.InGame, FilterMode.Point, action);
		UnityEngine.Object itemTitleImage = ItemTitleImage;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		object obj9 = 0;
		nint num4 = (nint)action;
		inventoryItemSelection = null;
		ImageCacher.ItemImageType itemImageType = ImageCacher.ItemImageType.InGame;
		object obj10 = 0;
		Action<bool> action2 = action;
		FilterMode filterMode = FilterMode.Point;
		ImageCacher.ItemImageType itemImageType2 = ImageCacher.ItemImageType.InGame;
		num = ownedItem.<itemId>k__BackingField;
		UnityEngine.Object itemTitleImage2 = ItemTitleImage;
		if (obj8 != null)
		{
			goto IL_0128;
		}
		goto IL_0309;
		IL_014e:
		GameObject gameObject = ItemTitleImage.gameObject;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1928;
		Action<bool> action3 = default(Action<bool>);
		action3..ctor((object)gameObject, (IntPtr)obj12);
		UIExtensions.LoadItemImage(ItemTitleImage, ownedItem.<itemId>k__BackingField, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action3);
		return;
		IL_0128:
		if ((bool)itemTitleImage)
		{
			goto IL_014e;
		}
		return;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = itemTitleImage2;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		obj9 = obj10;
		num4 = (nint)action2;
		inventoryItemSelection = (InventoryItemSelection)filterMode;
		itemImageType = itemImageType2;
		if (obj13 == null)
		{
			return;
		}
		goto IL_014e;
		IL_00bd:
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v17+E4]");
		bool flag8 = (nint)0 == 0;
		itemImageType = ImageCacher.ItemImageType.InGame;
		itemTitleImage = ItemTitleImage;
		obj10 = obj9;
		action2 = (Action<bool>)num4;
		filterMode = (FilterMode)inventoryItemSelection;
		itemImageType2 = ImageCacher.ItemImageType.InGame;
		itemTitleImage2 = ItemTitleImage;
		if (!flag8)
		{
			goto IL_0128;
		}
		goto IL_0309;
	}

	protected virtual void AddItemSprite(bool success)
	{
		if (success)
		{
			LoadingIndicator.SetActive(value: false);
		}
	}

	protected virtual void UpdateHighlighting()
	{
		//IL_002b: Expected O, but got I4
		//IL_005d: Expected F8, but got I4
		//IL_006a: Expected I, but got O
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		Image itemImage = ItemImage;
		bool flag = !_isHighlighted;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			double num = 1.0;
		}
		else
		{
			double num = 1059481190.0;
		}
		nint num2 = (nint)itemImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
