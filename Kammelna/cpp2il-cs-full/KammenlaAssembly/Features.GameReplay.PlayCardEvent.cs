using Cpp2ILInjected;

namespace Features.GameReplay;

public class PlayCardEvent : ReplayEvent
{
	private Card <Card>k__BackingField;

	public Card Card
	{
		get
		{
			return <Card>k__BackingField;
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

	public PlayCardEvent()
	{
	}

	public PlayCardEvent(int playerIndex, Card card)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = card;
		_ = 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
