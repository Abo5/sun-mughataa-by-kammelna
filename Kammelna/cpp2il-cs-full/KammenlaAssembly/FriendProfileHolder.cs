using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct FriendProfileHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly FriendProfile <FriendProfile>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public FriendProfile FriendProfile => <FriendProfile>k__BackingField;

	public unsafe FriendProfileHolder(FriendProfile profile, int i, string templateName)
	{
		//IL_000b: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = profile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = i;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj2 = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
