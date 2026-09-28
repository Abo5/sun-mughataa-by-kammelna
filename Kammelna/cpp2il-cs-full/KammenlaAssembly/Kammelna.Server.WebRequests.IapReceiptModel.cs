using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class IapReceiptModel
{
	private SalesChannel <Channel>k__BackingField;

	private string <Receipt>k__BackingField;

	private string <TransactionID>k__BackingField;

	private long? <RecipientID>k__BackingField;

	private string <GiftMessage>k__BackingField;

	public SalesChannel Channel
	{
		get
		{
			return <Channel>k__BackingField;
		}
		set
		{
			<Channel>k__BackingField = value;
		}
	}

	public string Receipt
	{
		get
		{
			return <Receipt>k__BackingField;
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

	public string TransactionID
	{
		get
		{
			return <TransactionID>k__BackingField;
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

	public long? RecipientID
	{
		get
		{
			return <RecipientID>k__BackingField;
		}
		set
		{
			<RecipientID>k__BackingField = value;
		}
	}

	public string GiftMessage
	{
		get
		{
			return <GiftMessage>k__BackingField;
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
}
