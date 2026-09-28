namespace KammelnaOffline;

public class OfflineGameState
{
	public bool Valid = true;

	public int Team1Score;

	public int Team2Score;

	public int Dealer;

	public OfflineGameState()
	{
	}

	public OfflineGameState(int team1Score, int team2Score, int dealer)
	{
		Team1Score = team1Score;
		Team2Score = team2Score;
		Dealer = dealer;
	}
}
