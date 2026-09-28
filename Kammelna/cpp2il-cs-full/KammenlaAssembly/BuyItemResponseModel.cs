using Cpp2ILInjected;

public class BuyItemResponseModel
{
	private long[] <recipients>k__BackingField;

	private StoreOwnedItem <ownedItem>k__BackingField;

	public long[] recipients
	{
		get
		{
			return <recipients>k__BackingField;
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

	public StoreOwnedItem ownedItem
	{
		get
		{
			return <ownedItem>k__BackingField;
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
}
