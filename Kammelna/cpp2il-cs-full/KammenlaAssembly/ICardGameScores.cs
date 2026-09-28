using System.Collections.Generic;

public interface ICardGameScores : IGameScores
{
	ICardGameRoundScore LastCardGameRoundScore { get; }

	List<ICardGameRoundScore> RoundsScores { get; }
}
