using System;

namespace Server.Models.StcPay;

[Serializable]
public class StcRecurringPayment
{
	public int id;

	public int repeatCount;

	public bool active;

	public string referenceNumber;

	public DateTime renewTime;
}
