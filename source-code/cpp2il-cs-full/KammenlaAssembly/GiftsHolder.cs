using System;
using System.ComponentModel;
using Cpp2ILInjected;
using ListView;
using Unity.Services.Authentication.Shared;

public class GiftsHolder : IGridViewItemData<int>, IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly int <columns>k__BackingField;

	private readonly StoreItem <Gift>k__BackingField;

	public int index => <index>k__BackingField;

	public string template
	{
		get
		{
			return <template>k__BackingField;
		}
		private set
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
		private set
		{
			<columns>k__BackingField = value;
		}
	}

	public StoreItem Gift => <Gift>k__BackingField;

	private GiftsHolder(int index)
	{
		<index>k__BackingField = index;
	}

	public GiftsHolder(StoreItem storeItem, int index)
	{
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		object obj = this + 40;
		StoreItem storeItem2 = default(StoreItem);
		obj = storeItem2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		object obj4;
		switch (((StoreItem)obj).GetCategory())
		{
		case ItemCategory.AnimatedGifts:
			obj4 = "Added Tournament Prizes And Features" + 1616;
			break;
		case ItemCategory.Gifts:
			obj4 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3128;
			break;
		default:
		{
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj3 = (nint)0 + (nint)3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
		}
		object obj5 = this + 24;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static GiftsHolder Separator(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2912;
		object obj2 = "Unsupported map type" + 2608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 4294967295L;
		return (GiftsHolder)obj3;
	}
}
