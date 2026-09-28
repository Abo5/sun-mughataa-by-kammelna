using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class StcPaymentAuthorizeRequestModel
{
	private string <MobileNumber>k__BackingField;

	private string <MerchantNote>k__BackingField;

	private long <ProductListingId>k__BackingField;

	private long? <RecipientId>k__BackingField;

	public string MobileNumber
	{
		get
		{
			return <MobileNumber>k__BackingField;
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

	public string MerchantNote
	{
		get
		{
			return <MerchantNote>k__BackingField;
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

	public long ProductListingId
	{
		get
		{
			return <ProductListingId>k__BackingField;
		}
		set
		{
			<ProductListingId>k__BackingField = value;
		}
	}

	public long? RecipientId
	{
		get
		{
			return <RecipientId>k__BackingField;
		}
		set
		{
			<RecipientId>k__BackingField = value;
		}
	}
}
