using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace Jackaroo;

public class JackarooLastActionInfo : CardGameLastActionInfo
{
	public const string JACKAROO_ACTION = "a";

	private const string PIECE_POSITION1 = "p1";

	private const string PIECE_POSITION2 = "p2";

	private readonly Card <Card>k__BackingField;

	private readonly JackarooActions <JackarooAction>k__BackingField;

	private readonly int <P1>k__BackingField;

	private readonly int <P2>k__BackingField;

	public Card Card => <Card>k__BackingField;

	public JackarooActions JackarooAction => <JackarooAction>k__BackingField;

	public int P1 => <P1>k__BackingField;

	public int P2 => <P2>k__BackingField;

	public JackarooLastActionInfo(ISFSObject lastActionParams, Card card)
		: base(lastActionParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_0173: Expected I4, but got I8
		//IL_0101: Expected I4, but got I8
		if (lastActionParams != null)
		{
			object varName = "___# Content push apply failed [{0}]: {1}" + 2608;
			object obj = (nint)0 + (nint)976;
			object varName2 = "not" + 2928;
			object varName3 = "not" + 2936;
			object obj2 = this + 48;
			obj2 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = SFSExtensions.Get(lastActionParams, (string)varName, 0);
			int num2 = default(int);
			string text = num2.ToString();
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+98]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v6+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70454");
			JackarooServerActions action = default(JackarooServerActions);
			JackarooActions jackarooActions = JackarooActionsExtensions.ToJackarooAction(action);
			<JackarooAction>k__BackingField = jackarooActions;
			int num3 = SFSExtensions.Get(lastActionParams, (string)varName2, -1);
			<P1>k__BackingField = num3;
			<P2>k__BackingField = SFSExtensions.Get(lastActionParams, (string)varName3, -1);
		}
	}

	public JackarooLastActionInfo(JackarooLastActionInfo gameJackarooLastAction)
		: base(gameJackarooLastAction)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		object obj = this + 48;
		obj = gameJackarooLastAction.<Card>k__BackingField;
		_ = ((LastActionInfo)gameJackarooLastAction).<ActionPlayer>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = gameJackarooLastAction.<JackarooAction>k__BackingField;
		_ = gameJackarooLastAction.<P2>k__BackingField;
	}

	public bool Equals(JackarooLastActionInfo other)
	{
		//IL_00f7: Expected O, but got I4
		if (other != null)
		{
			bool flag;
			if (((LastActionInfo)this).<Action>k__BackingField != ((LastActionInfo)other).<Action>k__BackingField)
			{
				flag = false;
			}
			else
			{
				flag = object.Equals(<Card>k__BackingField, other.<Card>k__BackingField);
				if (flag)
				{
					if (<JackarooAction>k__BackingField == other.<JackarooAction>k__BackingField && <P1>k__BackingField == other.<P1>k__BackingField)
					{
						object obj = <P2>k__BackingField - other.<P2>k__BackingField;
						return obj == null;
					}
					return false;
				}
			}
			return flag;
		}
		return false;
	}
}
