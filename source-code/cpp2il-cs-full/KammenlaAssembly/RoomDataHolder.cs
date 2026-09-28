using Cpp2ILInjected;
using ListView;

public class RoomDataHolder : IListViewItemData<int>
{
	private readonly GameRoomData <Room>k__BackingField;

	private readonly int <index>k__BackingField;

	private readonly string <template>k__BackingField;

	public GameRoomData Room
	{
		get
		{
			return <Room>k__BackingField;
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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected RoomDataHolder()
	{
	}

	public RoomDataHolder(GameRoomData room, int i)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object obj = "Read object reference Id '{0}' for {1}." + 3352;
		object obj2 = "Read object reference Id '{0}' for {1}." + 3344;
		base..ctor();
		object obj3 = this + 16;
		obj3 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<index>k__BackingField = i;
		bool isTablet = ScreenUtility.IsTablet;
		object obj4 = ((~(object)isTablet != null) ? obj2 : obj);
		object obj5 = this + 32;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
