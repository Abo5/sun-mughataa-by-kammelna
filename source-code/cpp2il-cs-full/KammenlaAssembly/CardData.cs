using System;

[Serializable]
public struct CardData
{
	private Rank _rank;

	private Suit _suit;

	public Rank Rank => _rank;

	public Suit Suit => _suit;

	public CardData(Rank rank, Suit suit)
	{
		_rank = rank;
		_suit = suit;
	}
}
