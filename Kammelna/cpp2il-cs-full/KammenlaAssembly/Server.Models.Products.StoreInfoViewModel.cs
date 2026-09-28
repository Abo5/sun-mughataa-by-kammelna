using System.Collections.Generic;
using Cpp2ILInjected;

namespace Server.Models.Products;

public class StoreInfoViewModel
{
	private List<StoreItem> <items>k__BackingField;

	private List<ProductViewModel> <products>k__BackingField;

	private List<ProfileGiftModel> <profileGifts>k__BackingField;

	private List<ItemGroup> <itemGroups>k__BackingField;

	public List<StoreItem> items
	{
		get
		{
			return <items>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<ProductViewModel> products
	{
		get
		{
			return <products>k__BackingField;
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

	public List<ProfileGiftModel> profileGifts
	{
		get
		{
			return <profileGifts>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<ItemGroup> itemGroups
	{
		get
		{
			return <itemGroups>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
