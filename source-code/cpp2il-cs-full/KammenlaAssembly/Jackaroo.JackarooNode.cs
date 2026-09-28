using Cpp2ILInjected;

namespace Jackaroo;

public class JackarooNode
{
	private JackarooNodeType <Type>k__BackingField;

	private JackarooNodeMono <NodeMono>k__BackingField;

	private JackarooMarble <Marble>k__BackingField;

	public JackarooNodeType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		private set
		{
			<Type>k__BackingField = value;
		}
	}

	public JackarooNodeMono NodeMono
	{
		get
		{
			return <NodeMono>k__BackingField;
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

	public JackarooMarble Marble
	{
		get
		{
			return <Marble>k__BackingField;
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

	public JackarooNode(JackarooNodeType type)
	{
		<Type>k__BackingField = type;
	}

	public void SetType(JackarooNodeType type)
	{
		<Type>k__BackingField = type;
	}

	public void SetNodeMono(JackarooNodeMono nodeMono)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 24;
		obj = nodeMono;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetMarble(JackarooMarble marble = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 32;
		obj = marble;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
