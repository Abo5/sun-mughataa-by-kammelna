namespace Features.GameReplay;

public class LeaveEvent : ReplayEvent
{
	private int <DbId>k__BackingField;

	public int DbId
	{
		get
		{
			return <DbId>k__BackingField;
		}
		private set
		{
			<DbId>k__BackingField = value;
		}
	}

	public LeaveEvent()
	{
	}

	public LeaveEvent(int playerIndex, int dbId)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.Leave;
		<DbId>k__BackingField = dbId;
	}
}
