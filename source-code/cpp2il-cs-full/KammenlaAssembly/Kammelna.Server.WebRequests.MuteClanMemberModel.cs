using System;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class MuteClanMemberModel
{
	public long UserId;

	public int DurationSeconds;

	public string Reason;
}
