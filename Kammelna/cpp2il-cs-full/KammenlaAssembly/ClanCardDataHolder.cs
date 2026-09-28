using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public class ClanCardDataHolder : IListViewItemData<int>
{
	public const string Template = "Clan Info Card";

	private readonly int <index>k__BackingField;

	private readonly ClanCardModel <Model>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => "Cannot populate JSON object onto type '{0}'." + 2880;

	public ClanCardModel Model => <Model>k__BackingField;

	public ClanCardDataHolder(int index, ClanCardModel model)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
