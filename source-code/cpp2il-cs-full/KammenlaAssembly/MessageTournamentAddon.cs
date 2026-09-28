using Cpp2ILInjected;

public class MessageTournamentAddon : TournamentAddonModel
{
	private string <message>k__BackingField;

	public override int Priority => 0;

	public override TournamentAddonType Type => TournamentAddonType.Message;

	public override string SerializedData => <message>k__BackingField;

	public string message
	{
		get
		{
			return <message>k__BackingField;
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

	public MessageTournamentAddon(string message)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
