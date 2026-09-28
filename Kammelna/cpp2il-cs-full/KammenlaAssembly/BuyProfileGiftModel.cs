using Cpp2ILInjected;

public class BuyProfileGiftModel
{
	private long <GiftId>k__BackingField;

	private string <GiftMessage>k__BackingField;

	private string <RecipientId>k__BackingField;

	public long GiftId
	{
		get
		{
			return <GiftId>k__BackingField;
		}
		set
		{
			<GiftId>k__BackingField = value;
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
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string RecipientId
	{
		get
		{
			return <RecipientId>k__BackingField;
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
}
