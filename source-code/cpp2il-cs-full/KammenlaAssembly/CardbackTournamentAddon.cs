using System.Runtime.CompilerServices;

public class CardbackTournamentAddon : TournamentAddonModel, ICardbackAddon
{
	private int <CardbackId>k__BackingField;

	public override int Priority => 20;

	public override TournamentAddonType Type => TournamentAddonType.Cardback;

	public unsafe override string SerializedData
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = <CardbackId>k__BackingField;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
			return ((int*)num)->ToString();
		}
	}

	public int CardbackId
	{
		get
		{
			return <CardbackId>k__BackingField;
		}
		set
		{
			<CardbackId>k__BackingField = value;
		}
	}

	public CardbackTournamentAddon(string cardbackId)
	{
		int num = int.Parse(cardbackId);
		<CardbackId>k__BackingField = num;
	}
}
