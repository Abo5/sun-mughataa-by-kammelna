using System;
using KammelnaOffline.Baloot;

[Serializable]
public struct AiBidding
{
	private int _playerIndex;

	private int _biddingState;

	private BalootBiddingOption _balootBiddingOption;

	private BalootBiddingOption _bid;

	public int PlayerIndex => _playerIndex;

	public int BiddingState => _biddingState;

	public BalootBiddingOption BalootBiddingOption => _balootBiddingOption;

	public BalootBiddingOption Bid => _bid;
}
