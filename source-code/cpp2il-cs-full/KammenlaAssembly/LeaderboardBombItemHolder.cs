using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;

public struct LeaderboardBombItemHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly GiftBombData <GiftBombData>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public GiftBombData GiftBombData => <GiftBombData>k__BackingField;

	public unsafe LeaderboardBombItemHolder(GiftBombData giftBombData, string templateName)
	{
		//IL_000b: Expected O, but got Ref
		//IL_0031: Expected I4, but got I8
		//IL_003c: Expected O, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = giftBombData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = (int)giftBombData.<Id>k__BackingField;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj2 = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
