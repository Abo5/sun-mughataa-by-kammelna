using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct LeaderBoardPlayerHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly LeaderBoardPlayer <Player>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public LeaderBoardPlayer Player => <Player>k__BackingField;

	public unsafe LeaderBoardPlayerHolder(LeaderBoardPlayer player, string templateName)
	{
		//IL_000b: Expected O, but got Ref
		//IL_003c: Expected O, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = player.Id;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj2 = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
