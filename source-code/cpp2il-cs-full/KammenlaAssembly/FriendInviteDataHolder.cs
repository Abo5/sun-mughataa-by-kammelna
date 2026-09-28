using Cpp2ILInjected;
using ListView;

public class FriendInviteDataHolder : IListViewItemData<int>
{
	private readonly FriendProfile <Friend>k__BackingField;

	private bool <IsInvited>k__BackingField;

	private bool <IsInGame>k__BackingField;

	private bool <IsInTournament>k__BackingField;

	private float <InvitationTimestamp>k__BackingField;

	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	public FriendProfile Friend
	{
		get
		{
			return <Friend>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsInvited
	{
		get
		{
			return <IsInvited>k__BackingField;
		}
		set
		{
			<IsInvited>k__BackingField = value;
		}
	}

	public bool IsInGame
	{
		get
		{
			return <IsInGame>k__BackingField;
		}
		set
		{
			<IsInGame>k__BackingField = value;
		}
	}

	public bool IsInTournament
	{
		get
		{
			return <IsInTournament>k__BackingField;
		}
		set
		{
			<IsInTournament>k__BackingField = value;
		}
	}

	public float InvitationTimestamp
	{
		get
		{
			return <InvitationTimestamp>k__BackingField;
		}
		set
		{
			<InvitationTimestamp>k__BackingField = value;
		}
	}

	public int index
	{
		get
		{
			return <index>k__BackingField;
		}
		protected set
		{
			<index>k__BackingField = value;
		}
	}

	public string template
	{
		get
		{
			return <template>k__BackingField;
		}
		protected set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected FriendInviteDataHolder()
	{
	}

	public FriendInviteDataHolder(FriendProfile friend, int i)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		object obj = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 744;
		base..ctor();
		object obj2 = this + 16;
		obj2 = friend;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 40;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
