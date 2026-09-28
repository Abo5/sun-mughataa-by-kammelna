using ListView;
using UnityEngine;

public class ProfileGiftDataHolder : IListViewItemData<int>
{
	private readonly long <GiftId>k__BackingField;

	private int <Quantity>k__BackingField;

	private float <Width>k__BackingField;

	private bool <AnimateAddedItem>k__BackingField;

	private readonly bool <Clickable>k__BackingField;

	private readonly float <Rotation>k__BackingField;

	public int index => (int)<GiftId>k__BackingField;

	public long GiftId => <GiftId>k__BackingField;

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

	public string template => "Picking audio files is not supported on iOS" + 2208;

	public float Width
	{
		get
		{
			return <Width>k__BackingField;
		}
		set
		{
			<Width>k__BackingField = value;
		}
	}

	public bool AnimateAddedItem
	{
		get
		{
			return <AnimateAddedItem>k__BackingField;
		}
		set
		{
			<AnimateAddedItem>k__BackingField = value;
		}
	}

	public bool Clickable => <Clickable>k__BackingField;

	public float Rotation => <Rotation>k__BackingField;

	public ProfileGiftDataHolder(ProfileGiftQuantityPair profileGiftQuantityPair, bool clickable, float width = 400f, bool animate = false)
	{
		//IL_005a: Expected I4, but got I8
		//IL_0068: Expected F4, but got I4
		<Quantity>k__BackingField = profileGiftQuantityPair.<Quantity>k__BackingField;
		<GiftId>k__BackingField = profileGiftQuantityPair.<GiftId>k__BackingField;
		<Width>k__BackingField = width;
		<AnimateAddedItem>k__BackingField = animate;
		<Clickable>k__BackingField = clickable;
		int num = Random.Range(-10, 10);
		<Rotation>k__BackingField = num;
	}
}
