using System.Collections.Generic;
using Cpp2ILInjected;
using ListView;
using Server.Models.Products;

public class StoreDataHolder : IGridViewItemData<int>, IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private string <template>k__BackingField;

	private int <columns>k__BackingField;

	private readonly ItemCategory <category>k__BackingField;

	public readonly List<StoreItem> CardsItem;

	public readonly List<StoreBannerViewModel> BannerList;

	public readonly StoreBannerViewModel BannerItem;

	public readonly StoreItem RoomItem;

	public readonly StoreItem PatternItem;

	public readonly ProductViewModel GoldenCards;

	public readonly ProductViewModel Subscription;

	public readonly UniqueStoreItem UniqueItem;

	public readonly Bundle BundleStoreItem;

	public readonly ImageCacher.BannerSize Type;

	private readonly string <titleText>k__BackingField;

	private readonly int? <tempId>k__BackingField;

	public int index => <index>k__BackingField;

	public string template
	{
		get
		{
			return <template>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int columns
	{
		get
		{
			return <columns>k__BackingField;
		}
		set
		{
			<columns>k__BackingField = value;
		}
	}

	public ItemCategory category => <category>k__BackingField;

	public string titleText => <titleText>k__BackingField;

	public int? tempId => <tempId>k__BackingField;

	public StoreDataHolder(ProductViewModel item, int i, StoreHomeSectionType sectionType)
	{
		//IL_0065: Expected O, but got I4
		//IL_0057: Expected O, but got I4
		<index>k__BackingField = i;
		object obj;
		if (sectionType != StoreHomeSectionType.Subscriptions)
		{
			if (sectionType != StoreHomeSectionType.Currency)
			{
				goto IL_006a;
			}
			obj = 80;
		}
		else
		{
			obj = 88;
		}
		object obj2 = (object)this + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_006a;
		IL_006a:
		SetTemplate();
	}

	public StoreDataHolder(List<StoreBannerViewModel> item, ImageCacher.BannerSize type, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 48;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Type = type;
		SetTemplate();
	}

	public StoreDataHolder(StoreBannerViewModel item, ImageCacher.BannerSize type, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 56;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Type = type;
		SetTemplate();
	}

	public StoreDataHolder(List<StoreItem> items, int i, int? tempId)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		<tempId>k__BackingField = tempId;
		<index>k__BackingField = i;
		object obj = this + 40;
		obj = items;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	public StoreDataHolder(StoreItem item, int i, int? tempId, ItemCategory cat)
	{
		//IL_0079: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		<tempId>k__BackingField = tempId;
		<category>k__BackingField = cat;
		<index>k__BackingField = i;
		object obj;
		if (cat != ItemCategory.Patterns)
		{
			if (cat != ItemCategory.Rooms)
			{
				goto IL_007e;
			}
			obj = 64;
		}
		else
		{
			obj = 72;
		}
		object obj2 = (object)this + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_007e;
		IL_007e:
		SetTemplate();
	}

	public StoreDataHolder(string title, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 120;
		obj = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	public StoreDataHolder(UniqueStoreItem item, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 96;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	public StoreDataHolder(Bundle item, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 104;
		obj = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetTemplate();
	}

	private void SetTemplate()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I8
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0107: Expected O, but got I8
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I8
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0143: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017f: Expected O, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028e: Expected O, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0225: Expected O, but got I8
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I8
		if (BannerItem == null)
		{
			goto IL_006b;
		}
		object obj2;
		if (Type != ImageCacher.BannerSize.Wide)
		{
			bool flag = Type == ImageCacher.BannerSize.Normal;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_006b;
			}
			obj2 = "SetRoomVariables request error" + 3248;
			object obj3 = 6;
		}
		else
		{
			obj2 = "SetRoomVariables request error" + 3280;
			object obj3 = 4294967295L;
		}
		goto IL_02f2;
		IL_006b:
		if (BannerList != null)
		{
			obj2 = "SetRoomVariables request error" + 3216;
			object obj3 = 4294967295L;
		}
		else if (<titleText>k__BackingField != null)
		{
			obj2 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2664;
			object obj3 = 4294967295L;
		}
		else if (CardsItem != null)
		{
			obj2 = "SetRoomVariables request error" + 3232;
			object obj3 = 4;
		}
		else if (RoomItem != null)
		{
			obj2 = "SetRoomVariables request error" + 3272;
			object obj3 = 6;
		}
		else
		{
			bool flag2 = GoldenCards == null;
			object obj4 = !flag2;
			if (obj4 != null || Subscription != null)
			{
				obj2 = "SetRoomVariables request error" + 3264;
				object obj3 = 4;
			}
			else if (UniqueItem != null)
			{
				obj2 = "UInt16" + 2640;
				object obj3 = 4294967295L;
			}
			else
			{
				bool flag3 = PatternItem == null;
				object obj5 = !flag3;
				if (obj5 != null || <category>k__BackingField == ItemCategory.Patterns)
				{
					obj2 = "SetRoomVariables request error" + 3256;
					object obj3 = 6;
				}
				else
				{
					if (BundleStoreItem == null)
					{
						return;
					}
					obj2 = "SetRoomVariables request error" + 3224;
					object obj3 = 4294967292L;
				}
			}
		}
		goto IL_02f2;
		IL_02f2:
		object obj6 = this + 24;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
