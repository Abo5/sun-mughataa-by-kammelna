namespace DataTracking;

public interface ITrackEvent
{
	string GetEventString();

	string GetEventLabel();

	TrackingContext GetContext();

	TrackingFeature GetFeature();

	TrackingPlacement GetPlacement();

	TrackingOutcome GetOutcome();

	float? GetEventValue();
}
