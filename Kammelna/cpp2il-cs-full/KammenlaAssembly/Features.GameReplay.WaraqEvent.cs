using Cpp2ILInjected;

namespace Features.GameReplay;

public class WaraqEvent : ReplayEvent
{
	private Card <FloorCard>k__BackingField;

	private int <Team1Score>k__BackingField;

	private int <Team2Score>k__BackingField;

	public Card FloorCard
	{
		get
		{
			return <FloorCard>k__BackingField;
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

	public int Team1Score
	{
		get
		{
			return <Team1Score>k__BackingField;
		}
		private set
		{
			<Team1Score>k__BackingField = value;
		}
	}

	public int Team2Score
	{
		get
		{
			return <Team2Score>k__BackingField;
		}
		private set
		{
			<Team2Score>k__BackingField = value;
		}
	}

	public WaraqEvent()
	{
	}

	public WaraqEvent(int playerIndex, Card floorCard, int team1Score, int team2Score)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = floorCard;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
