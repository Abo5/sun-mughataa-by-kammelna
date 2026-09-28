using Cpp2ILInjected;

namespace Jackaroo;

public class JackarooServerMove
{
	private Card <Card>k__BackingField;

	private JackarooServerActions <Action>k__BackingField;

	private int <P1>k__BackingField;

	private int <P2>k__BackingField;

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
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public JackarooServerActions Action
	{
		get
		{
			return <Action>k__BackingField;
		}
		private set
		{
			<Action>k__BackingField = value;
		}
	}

	public int P1
	{
		get
		{
			return <P1>k__BackingField;
		}
		private set
		{
			<P1>k__BackingField = value;
		}
	}

	public int P2
	{
		get
		{
			return <P2>k__BackingField;
		}
		private set
		{
			<P2>k__BackingField = value;
		}
	}

	public JackarooServerMove(Card card, JackarooServerActions action, int p1, int p2)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
