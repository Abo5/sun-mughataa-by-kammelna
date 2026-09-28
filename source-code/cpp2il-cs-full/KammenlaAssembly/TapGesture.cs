using UnityEngine;

public struct TapGesture
{
	public readonly Vector2 PressPosition;

	public readonly Vector2 ReleasePosition;

	public readonly double TapDuration;

	public readonly float TapDrift;

	public readonly double TimeStamp;

	internal TapGesture(ActiveGesture gesture)
	{
		PressPosition = gesture.StartPosition;
		ReleasePosition = gesture.EndPosition;
		double tapDuration = gesture.EndTime - gesture.StartTime;
		TapDuration = tapDuration;
		TapDrift = gesture.TravelDistance;
		TimeStamp = gesture.EndTime;
	}
}
