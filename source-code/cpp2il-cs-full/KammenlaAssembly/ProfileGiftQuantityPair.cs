public class ProfileGiftQuantityPair
{
	private long <GiftId>k__BackingField;

	private int <Quantity>k__BackingField;

	public long GiftId
	{
		get
		{
			return <GiftId>k__BackingField;
		}
		set
		{
			<GiftId>k__BackingField = value;
		}
	}

	public int Quantity
	{
		get
		{
			return <Quantity>k__BackingField;
		}
		set
		{
			<Quantity>k__BackingField = value;
		}
	}

	public ProfileGiftQuantityPair(long giftId, int quantity)
	{
		<GiftId>k__BackingField = giftId;
		<Quantity>k__BackingField = quantity;
	}
}
