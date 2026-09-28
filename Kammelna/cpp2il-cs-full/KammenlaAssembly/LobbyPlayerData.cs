using System;
using Cpp2ILInjected;
using Sfs2X.Entities;

[Serializable]
public class LobbyPlayerData
{
	public User User;

	public int Team;

	public int ID => SFSKammelnaUserExtensions.GetIntDbId(User);

	public LobbyPlayerData(User user)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public LobbyPlayerData(User user, int team)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
