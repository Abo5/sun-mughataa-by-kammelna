using System.Collections.Generic;

namespace KammelnaOffline.Common;

public abstract class AbstractAiLogic
{
	public abstract Card PlayCard(List<Card> cards, int playerIndex);

	public abstract string Bid(int biddingState, List<Card> cards, int playerIndex);

	public virtual string GetAction(int playerIndex)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return "___# Content push apply failed [{0}]: {1}" + 2664;
	}
}
