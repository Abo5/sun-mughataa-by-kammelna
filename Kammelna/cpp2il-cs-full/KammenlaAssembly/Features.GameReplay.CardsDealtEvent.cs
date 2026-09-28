using Cpp2ILInjected;

namespace Features.GameReplay;

public class CardsDealtEvent : ReplayEvent
{
	private long[] <BidHandCards>k__BackingField;

	private long[] <FullHandCards>k__BackingField;

	public long[] BidHandCards
	{
		get
		{
			return <BidHandCards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public long[] FullHandCards
	{
		get
		{
			return <FullHandCards>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardsDealtEvent()
	{
	}

	public CardsDealtEvent(long[] bidHandCards, long[] fullHandCards)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253530]");
		base.<PlayerIndex>k__BackingField = 0;
		object obj = this + 24;
		obj = bidHandCards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = fullHandCards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
