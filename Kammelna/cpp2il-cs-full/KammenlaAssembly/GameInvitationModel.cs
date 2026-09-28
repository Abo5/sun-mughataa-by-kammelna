using System;

[Serializable]
public class GameInvitationModel
{
	public string serverId;

	public int userId;

	public int roomId;

	public int tournamentId;

	public string password;

	public Games game;
}
