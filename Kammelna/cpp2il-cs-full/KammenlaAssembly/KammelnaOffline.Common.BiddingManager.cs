namespace KammelnaOffline.Common;

public abstract class BiddingManager
{
	private int <Bidder>k__BackingField;

	public int Bidder
	{
		get
		{
			return <Bidder>k__BackingField;
		}
		protected set
		{
			<Bidder>k__BackingField = value;
		}
	}

	public abstract int[] GetNextBidding(int bidderIndex, string bid);

	public abstract int[] StartBidding();
}
