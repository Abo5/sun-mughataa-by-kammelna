using Sfs2X.Entities.Data;

public interface ICardGameRoundScore
{
	int WinnerTeamIndex { get; }

	int Team1Score { get; }

	int Team2Score { get; }

	void Record(ISFSObject data);
}
