using System;
using Cpp2ILInjected;

namespace Jackaroo;

[Serializable]
public class JackarooMarble
{
	private readonly int <PlayerIndex>k__BackingField;

	private JackarooMarbleMono <MarbleMono>k__BackingField;

	private JackarooNode <Node>k__BackingField;

	public int PlayerIndex => <PlayerIndex>k__BackingField;

	public JackarooMarbleMono MarbleMono
	{
		get
		{
			return <MarbleMono>k__BackingField;
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

	public JackarooNode Node
	{
		get
		{
			return <Node>k__BackingField;
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

	public void SetMarbleMono(JackarooMarbleMono marbleMono)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 24;
		obj = marbleMono;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public JackarooMarble(int playerIndex, JackarooMarbleMono marbleMono)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = marbleMono;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetNode(JackarooNode node)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 32;
		obj = node;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
