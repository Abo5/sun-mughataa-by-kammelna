using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct FriendListSeparatorHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly int <NumberOfFriendsInSeparator>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public int NumberOfFriendsInSeparator => <NumberOfFriendsInSeparator>k__BackingField;

	public unsafe FriendListSeparatorHolder(int countInSeparator, int i, string templateName)
	{
		//IL_001f: Expected O, but got Ref
		<NumberOfFriendsInSeparator>k__BackingField = countInSeparator;
		<index>k__BackingField = i;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
