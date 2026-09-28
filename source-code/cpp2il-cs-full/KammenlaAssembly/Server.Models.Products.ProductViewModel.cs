using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

namespace Server.Models.Products;

[Serializable]
public class ProductViewModel
{
	private int <id>k__BackingField;

	private string <name>k__BackingField;

	private int <coins>k__BackingField;

	private int <days>k__BackingField;

	private FileInfoModel <image>k__BackingField;

	private List<long> <itemIds>k__BackingField;

	private List<ProductListingModel> <listings>k__BackingField;

	public int id
	{
		get
		{
			return <id>k__BackingField;
		}
		set
		{
			<id>k__BackingField = value;
		}
	}

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
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int coins
	{
		get
		{
			return <coins>k__BackingField;
		}
		set
		{
			<coins>k__BackingField = value;
		}
	}

	public int days
	{
		get
		{
			return <days>k__BackingField;
		}
		set
		{
			<days>k__BackingField = value;
		}
	}

	public FileInfoModel image
	{
		get
		{
			return <image>k__BackingField;
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

	public List<long> itemIds
	{
		get
		{
			return <itemIds>k__BackingField;
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

	public List<ProductListingModel> listings
	{
		get
		{
			return <listings>k__BackingField;
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

	public bool IsSubscription
	{
		get
		{
			if (<days>k__BackingField >= 1)
			{
				return <coins>k__BackingField == 0;
			}
			return false;
		}
	}

	public bool IsCoins
	{
		get
		{
			if (<coins>k__BackingField >= 1)
			{
				return <days>k__BackingField == 0;
			}
			return false;
		}
	}

	public ProductViewModel(ProductViewModel product, IEnumerable<ProductListingModel> listings)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		<id>k__BackingField = product.<id>k__BackingField;
		object obj = this + 24;
		obj = product.<name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<coins>k__BackingField = product.<coins>k__BackingField;
		object obj2 = this + 40;
		obj2 = product.<image>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 48;
		obj3 = product.<itemIds>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<object> list = Enumerable.ToList((IEnumerable<object>)listings);
		object obj4 = this + 56;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ProductViewModel()
	{
	}
}
