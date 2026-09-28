using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct ClanJoinRequestDataHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly ClanUserModel <User>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public ClanUserModel User => <User>k__BackingField;

	public unsafe ClanJoinRequestDataHolder(ClanUserModel user, string templateName)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0037: Expected O, but got Ref
		<index>k__BackingField = user.UserId;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj2 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
