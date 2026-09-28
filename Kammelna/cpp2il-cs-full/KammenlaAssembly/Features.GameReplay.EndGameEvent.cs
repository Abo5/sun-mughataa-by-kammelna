using Cpp2ILInjected;

namespace Features.GameReplay;

public class EndGameEvent : ReplayEvent
{
	private CardGameEndScores <CardGameEndScores>k__BackingField;

	public CardGameEndScores CardGameEndScores
	{
		get
		{
			return <CardGameEndScores>k__BackingField;
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

	public EndGameEvent()
	{
	}

	public EndGameEvent(CardGameEndScores cardGameEndScores)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = cardGameEndScores;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253540]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
