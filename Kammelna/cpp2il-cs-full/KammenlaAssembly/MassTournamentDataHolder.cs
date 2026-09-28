using Cpp2ILInjected;
using ListView;
using Sfs2X.Entities;

public class MassTournamentDataHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly Room <Room>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => "ThisIsFakeReceiptData" + 1344;

	public Room Room => <Room>k__BackingField;

	public MassTournamentDataHolder(Room room, int index)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
