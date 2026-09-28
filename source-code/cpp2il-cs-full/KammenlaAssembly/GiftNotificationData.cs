using Cpp2ILInjected;

public class GiftNotificationData
{
	private string <SenderId>k__BackingField;

	private int <ProductDbId>k__BackingField;

	private GiftsHandler.GiftType <ItemType>k__BackingField;

	private int <Amount>k__BackingField;

	private string <Message>k__BackingField;

	public string SenderId
	{
		get
		{
			return <SenderId>k__BackingField;
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

	public int ProductDbId
	{
		get
		{
			return <ProductDbId>k__BackingField;
		}
		set
		{
			<ProductDbId>k__BackingField = value;
		}
	}

	public GiftsHandler.GiftType ItemType
	{
		get
		{
			return <ItemType>k__BackingField;
		}
		set
		{
			<ItemType>k__BackingField = value;
		}
	}

	public int Amount
	{
		get
		{
			return <Amount>k__BackingField;
		}
		set
		{
			<Amount>k__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return <Message>k__BackingField;
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
