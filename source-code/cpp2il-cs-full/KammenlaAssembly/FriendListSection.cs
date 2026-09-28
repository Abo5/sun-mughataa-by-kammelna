using System.Collections.Generic;
using Cpp2ILInjected;

public class FriendListSection
{
	public string Header;

	public IEnumerable<FriendProfile> Friends;

	public FriendListSection(string header, IEnumerable<FriendProfile> friends)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = header;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = friends;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
