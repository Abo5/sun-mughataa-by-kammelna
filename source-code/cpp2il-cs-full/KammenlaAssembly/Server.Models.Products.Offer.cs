using Cpp2ILInjected;

namespace Server.Models.Products;

public class Offer
{
	private int <Id>k__BackingField;

	private string <StoreOfferId>k__BackingField;

	private OfferType <Type>k__BackingField;

	private decimal <Price>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public string StoreOfferId
	{
		get
		{
			return <StoreOfferId>k__BackingField;
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

	public OfferType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public decimal Price
	{
		get
		{
			return <Price>k__BackingField;
		}
		set
		{
			<Price>k__BackingField = value;
		}
	}
}
