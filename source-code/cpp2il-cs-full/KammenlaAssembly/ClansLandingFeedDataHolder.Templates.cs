using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public class ClansLandingFeedDataHolder : IListViewItemData<int>
{
	public static class Templates
	{
		public const string Generic = "Global clan feed strip";
	}

	private readonly int <index>k__BackingField;

	private readonly ClanFeedModel <Model>k__BackingField;

	public int index => <index>k__BackingField;

	public ClanFeedModel Model => <Model>k__BackingField;

	public string template => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3176;

	public ClansLandingFeedDataHolder(int index, ClanFeedModel model)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
