using System;
using UnityEngine;

public class TicketsConsumptionConfirmation : MonoBehaviour
{
	private DiscreteProgressIndicator triesIndicator;

	private DateTimeText datetime;

	public void Initialize(int maxTrails, int tries, DateTime time)
	{
		triesIndicator.MaxProgress = maxTrails;
		triesIndicator.CurrentProgress = tries;
		datetime.SetDate(time);
	}
}
