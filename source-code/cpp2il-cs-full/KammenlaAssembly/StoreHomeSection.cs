using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class StoreHomeSection
{
	private string <name>k__BackingField;

	private StoreHomeSectionType <type>k__BackingField;

	private List<StoreBannerViewModel> <banners>k__BackingField;

	private List<int> <featuredSubscriptions>k__BackingField;

	private List<int> <featuredCurrency>k__BackingField;

	private List<int> <featuredCards>k__BackingField;

	private List<int> <featuredRoomThemes>k__BackingField;

	private UniqueStoreItem <UniqueItem>k__BackingField;

	private Bundle <Bundle>k__BackingField;

	public string name
	{
		get
		{
			return <name>k__BackingField;
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

	public StoreHomeSectionType type
	{
		get
		{
			return <type>k__BackingField;
		}
		set
		{
			<type>k__BackingField = value;
		}
	}

	public List<StoreBannerViewModel> banners
	{
		get
		{
			return <banners>k__BackingField;
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

	public List<int> featuredSubscriptions
	{
		get
		{
			return <featuredSubscriptions>k__BackingField;
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

	public List<int> featuredCurrency
	{
		get
		{
			return <featuredCurrency>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> featuredCards
	{
		get
		{
			return <featuredCards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<int> featuredRoomThemes
	{
		get
		{
			return <featuredRoomThemes>k__BackingField;
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

	public UniqueStoreItem UniqueItem
	{
		get
		{
			return <UniqueItem>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Bundle Bundle
	{
		get
		{
			return <Bundle>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
