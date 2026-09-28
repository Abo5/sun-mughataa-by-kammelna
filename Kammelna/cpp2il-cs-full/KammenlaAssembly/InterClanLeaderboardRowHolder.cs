using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public struct InterClanLeaderboardRowHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	private readonly InterClanLeaderboardEntryModel <Entry>k__BackingField;

	private readonly bool <IsMyClan>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => <template>k__BackingField;

	public InterClanLeaderboardEntryModel Entry => <Entry>k__BackingField;

	public bool IsMyClan => <IsMyClan>k__BackingField;

	public unsafe InterClanLeaderboardRowHolder(InterClanLeaderboardEntryModel entry, bool isMyClan, string templateName)
	{
		//IL_000b: Expected O, but got Ref
		//IL_0041: Expected O, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = entry;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = entry.ClanId;
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj2 = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
