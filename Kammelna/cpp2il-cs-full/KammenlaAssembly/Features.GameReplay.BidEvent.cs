using Cpp2ILInjected;

namespace Features.GameReplay;

public class BidEvent : ReplayEvent
{
	private string <Bid>k__BackingField;

	private BalootGame.BalootGameMode <GameMode>k__BackingField;

	private BalootGame.BalootExtraGameMode <ExtraGameMode>k__BackingField;

	private int <RoundDoubler>k__BackingField;

	private Suit <TrumpSuit>k__BackingField;

	private int <RoundBidder>k__BackingField;

	private bool <IsHokomClosed>k__BackingField;

	public string Bid
	{
		get
		{
			return <Bid>k__BackingField;
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

	public BalootGame.BalootGameMode GameMode
	{
		get
		{
			return <GameMode>k__BackingField;
		}
		private set
		{
			<GameMode>k__BackingField = value;
		}
	}

	public BalootGame.BalootExtraGameMode ExtraGameMode
	{
		get
		{
			return <ExtraGameMode>k__BackingField;
		}
		private set
		{
			<ExtraGameMode>k__BackingField = value;
		}
	}

	public int RoundDoubler
	{
		get
		{
			return <RoundDoubler>k__BackingField;
		}
		private set
		{
			<RoundDoubler>k__BackingField = value;
		}
	}

	public Suit TrumpSuit
	{
		get
		{
			return <TrumpSuit>k__BackingField;
		}
		private set
		{
			<TrumpSuit>k__BackingField = value;
		}
	}

	public int RoundBidder
	{
		get
		{
			return <RoundBidder>k__BackingField;
		}
		private set
		{
			<RoundBidder>k__BackingField = value;
		}
	}

	public bool IsHokomClosed
	{
		get
		{
			return <IsHokomClosed>k__BackingField;
		}
		private set
		{
			<IsHokomClosed>k__BackingField = value;
		}
	}

	public BidEvent()
	{
	}

	public unsafe BidEvent(int playerIndex, string bid, BalootGame.BalootGameMode gameMode, BalootGame.BalootExtraGameMode extraGameMode, int roundDoubler, Suit trumpSuit, int roundBidder, bool isHokomClosed)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		((object)this)..ctor();
		object obj3 = this + 24;
		obj3 = bid;
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
	}
}
