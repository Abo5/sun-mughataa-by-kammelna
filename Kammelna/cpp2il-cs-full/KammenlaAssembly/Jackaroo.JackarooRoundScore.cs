using Sfs2X.Entities.Data;

namespace Jackaroo;

public class JackarooRoundScore : CardGameRoundScore
{
	private const string C_RoundBid = "rndB";

	private int <RoundBid>k__BackingField;

	public int RoundBid
	{
		get
		{
			return <RoundBid>k__BackingField;
		}
		private set
		{
			<RoundBid>k__BackingField = value;
		}
	}

	public bool BidderWon
	{
		get
		{
			//IL_0011: Expected O, but got I4
			object obj = base.<WinnerTeamIndex>k__BackingField - base.<Bidder>k__BackingField;
			return obj == null;
		}
	}

	public override void Record(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object varName = "rightCtrl" + 248;
		base.Record(data);
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<RoundBid>k__BackingField = num;
	}
}
