using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanVaultTransactionModel
{
	public long Id;

	public DateTime Time;

	public ClanVaultTransactionType Type;

	public bool IsRefund;

	public int Delta;

	public int NewBalance;

	public long? UserId;

	public int? SupportRequestId;

	public string Reason;
}
