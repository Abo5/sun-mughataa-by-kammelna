using System;

namespace Kammelna.Server.Models.Presence;

[Serializable]
public class PresenceEntry
{
	public long UserId;

	public PresenceState State;
}
