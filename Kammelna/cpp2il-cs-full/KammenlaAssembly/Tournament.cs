using System;

[Serializable]
public class Tournament
{
	public long id;

	public Games gameID;

	public long? creatorID;

	public string tournamentName;

	public string organizer;

	public int size;

	public int bestOf;

	public int? finalBestOf;

	public TournamentPrizeType prizeType;

	public int prize;

	public int? secondaryPrize;

	public int? tertiaryPrize;

	public DateTime creationTime;

	public DateTime startingTime;

	public DateTime finishTime;

	public int currentRound;

	public int? roomThemeID;

	public int? cardBacksID;
}
