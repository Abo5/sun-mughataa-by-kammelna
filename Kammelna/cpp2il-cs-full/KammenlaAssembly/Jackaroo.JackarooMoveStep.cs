using System;
using Cpp2ILInjected;

namespace Jackaroo;

public class JackarooMoveStep
{
	private readonly JackarooMarble <MarbleToKill>k__BackingField;

	private readonly JackarooNode <GraveyardNode>k__BackingField;

	private readonly Action <PreDeathAction>k__BackingField;

	private readonly Action <DeathAnimationAction>k__BackingField;

	public JackarooMarble MarbleToKill => <MarbleToKill>k__BackingField;

	public JackarooNode GraveyardNode => <GraveyardNode>k__BackingField;

	public Action PreDeathAction => <PreDeathAction>k__BackingField;

	public Action DeathAnimationAction => <DeathAnimationAction>k__BackingField;

	public JackarooMoveStep(JackarooMarble marbleToKill, JackarooNode graveyardNode, Action deathAnimationAction, Action preDeathAction = null)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		object obj = this + 16;
		obj = marbleToKill;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = graveyardNode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 40;
		obj3 = deathAnimationAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 32;
		obj4 = preDeathAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
