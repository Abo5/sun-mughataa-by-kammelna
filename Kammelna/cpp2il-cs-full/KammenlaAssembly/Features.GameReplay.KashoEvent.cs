namespace Features.GameReplay;

public class KashoEvent : ReplayEvent
{
	public KashoEvent()
	{
	}

	public KashoEvent(int playerIndex)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.Kasho;
	}
}
