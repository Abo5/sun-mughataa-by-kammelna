using Cpp2ILInjected;

public class ItemGroup
{
	private int <Id>k__BackingField;

	private string <Name>k__BackingField;

	private int <Order>k__BackingField;

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

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
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

	public int Order
	{
		get
		{
			return <Order>k__BackingField;
		}
		set
		{
			<Order>k__BackingField = value;
		}
	}
}
