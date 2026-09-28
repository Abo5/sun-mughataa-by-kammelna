using System;

namespace Kammelna.Server.Models.Presence;

[Serializable]
public class PresenceState
{
	public PresenceKind Kind;

	public GameCategory Game;

	public GameType? GameType;

	public long? TournamentId;

	public int? RoomId;

	public DateTime Since;

	public string ServerId;
}
