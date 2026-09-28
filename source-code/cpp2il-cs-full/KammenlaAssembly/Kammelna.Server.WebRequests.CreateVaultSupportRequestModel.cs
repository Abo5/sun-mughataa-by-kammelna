using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class CreateVaultSupportRequestModel
{
	public int TargetAmount;

	public int DurationDays;
}
