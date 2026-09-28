using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct LeaderboardFriendHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly FriendLeaderboardModel <Friend>k__BackingField;

	private readonly bool <IsTournamentPointView>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public FriendLeaderboardModel Friend => <Friend>k__BackingField;

	public bool IsTournamentPointView => <IsTournamentPointView>k__BackingField;

	public unsafe LeaderboardFriendHolder(int i, string templateName, FriendLeaderboardModel friendLbModel, bool isTournamentPointView)
	{
		//IL_0015: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		<index>k__BackingField = i;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj2 = friendLbModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
