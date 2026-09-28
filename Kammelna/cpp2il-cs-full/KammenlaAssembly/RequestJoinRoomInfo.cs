using Cpp2ILInjected;

public class RequestJoinRoomInfo
{
	private readonly int <RoomId>k__BackingField;

	private readonly int? <Seat>k__BackingField;

	private readonly string <Password>k__BackingField;

	public int RoomId
	{
		get
		{
			return <RoomId>k__BackingField;
		}
		set
		{
			<RoomId>k__BackingField = value;
		}
	}

	public int? Seat
	{
		get
		{
			return <Seat>k__BackingField;
		}
		set
		{
			<Seat>k__BackingField = value;
		}
	}

	public string Password
	{
		get
		{
			return <Password>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
