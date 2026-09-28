using Cpp2ILInjected;

public class GrantTitleTournamentAddon : TournamentAddonModel
{
	private string <GrantTitle>k__BackingField;

	public override int Priority => 0;

	public override TournamentAddonType Type => TournamentAddonType.GrantTitle;

	public override string SerializedData => <GrantTitle>k__BackingField;

	private string GrantTitle
	{
		get
		{
			return <GrantTitle>k__BackingField;
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

	public GrantTitleTournamentAddon(string title)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
