using Cpp2ILInjected;
using Sfs2X.Entities;

public class TournamentModel
{
	private readonly Room <Room>k__BackingField;

	private readonly TournamentData <Info>k__BackingField;

	public Room Room => <Room>k__BackingField;

	public TournamentData Info => <Info>k__BackingField;

	public TournamentModel(Room room, TournamentData info)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = info;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe void Deconstruct(out Room room, out TournamentData info)
	{
		ref Room reference = ref *(Room*)<Room>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ref TournamentData reference2 = ref *(TournamentData*)<Info>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
