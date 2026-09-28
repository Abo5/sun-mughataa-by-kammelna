using Cpp2ILInjected;

namespace Features.GameReplay;

public class EndRoundEvent : ReplayEvent
{
	private BalootRoundScore <BalootRoundScore>k__BackingField;

	public BalootRoundScore BalootRoundScore
	{
		get
		{
			return <BalootRoundScore>k__BackingField;
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

	public EndRoundEvent()
	{
	}

	public EndRoundEvent(BalootRoundScore balootRoundScore)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = balootRoundScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253538]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
