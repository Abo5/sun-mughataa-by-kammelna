using System.Collections.Generic;

public interface ICardUtils
{
	void SortCards(List<Card> cards, List<Suit> suitOrder);

	int GetValue(Card card);
}
