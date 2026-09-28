using System;
using Cpp2ILInjected;
using ListView;

public class PlayerInfoWrapper : IListViewItemData<int>
{
	private readonly string <template>k__BackingField;

	private readonly PlayerInfo <player>k__BackingField;

	public int index
	{
		get
		{
			//IL_0041: Expected I4, but got O
			PlayerInfo playerInfo = <player>k__BackingField;
			if (<player>k__BackingField != null)
			{
				return playerInfo.<DBID>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public string template => <template>k__BackingField;

	public PlayerInfo player => <player>k__BackingField;

	public PlayerInfoWrapper(PlayerInfo player, string template)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 24;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 16;
		obj2 = template;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
