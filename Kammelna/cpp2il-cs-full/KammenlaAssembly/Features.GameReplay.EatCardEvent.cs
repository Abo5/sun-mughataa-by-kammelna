namespace Features.GameReplay;

public class EatCardEvent : ReplayEvent
{
	public EatCardEvent()
	{
	}

	public EatCardEvent(int playerIndex)
	{
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.EatCard;
	}
}
