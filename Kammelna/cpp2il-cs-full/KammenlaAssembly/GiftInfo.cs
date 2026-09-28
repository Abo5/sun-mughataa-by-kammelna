using Cpp2ILInjected;

public class GiftInfo
{
	private int <RecipientId>k__BackingField;

	private string <Message>k__BackingField;

	public int RecipientId
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
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GiftInfo(int recipientId, string message = null)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override string ToString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0024: Expected O, but got I4
		object format = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3120;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg, <Message>k__BackingField);
	}
}
