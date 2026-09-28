using Cpp2ILInjected;
using ListView;

public class ChallengeHistoryListData : IListViewItemData<int>
{
	private readonly ChallengeEntry <ChallengeEntry>k__BackingField;

	private readonly ChallengeStateData <ChallengeData>k__BackingField;

	private readonly int <index>k__BackingField;

	public ChallengeEntry ChallengeEntry => <ChallengeEntry>k__BackingField;

	public ChallengeStateData ChallengeData => <ChallengeData>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1448;

	public ChallengeHistoryListData(ChallengeEntry challengeEntry, ChallengeStateData challengeData, int index)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = challengeEntry;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = challengeData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
