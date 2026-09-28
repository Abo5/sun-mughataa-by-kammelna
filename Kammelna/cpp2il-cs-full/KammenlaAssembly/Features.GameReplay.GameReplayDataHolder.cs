using Cpp2ILInjected;
using ListView;

namespace Features.GameReplay;

public class GameReplayDataHolder : IListViewItemData<int>
{
	private readonly GameReplayCardData <GameReplayCardData>k__BackingField;

	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly GameReplayListUI <GameReplayListUI>k__BackingField;

	public GameReplayCardData GameReplayCardData => <GameReplayCardData>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public GameReplayListUI GameReplayListUI => <GameReplayListUI>k__BackingField;

	public GameReplayDataHolder(GameReplayListUI gameReplayListUI, GameReplayCardData gameReplayCardData, int i)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "Read object reference Id '{0}' for {1}." + 2264;
		base..ctor();
		object obj2 = this + 40;
		obj2 = gameReplayListUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 16;
		obj3 = gameReplayCardData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 32;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
