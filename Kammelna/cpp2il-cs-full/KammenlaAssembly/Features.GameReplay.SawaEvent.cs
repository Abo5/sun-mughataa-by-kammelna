namespace Features.GameReplay;

public class SawaEvent : ReplayEvent
{
	public SawaEvent()
	{
	}

	public SawaEvent(int playerIndex)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.Sawa;
	}
}
