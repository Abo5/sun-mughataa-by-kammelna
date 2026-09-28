using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class LastActionInfo
{
	public const string ACTION = "action";

	public const string ACTION_PLAYER = "ap";

	private readonly int <ActionPlayer>k__BackingField;

	private readonly string <Action>k__BackingField;

	public int ActionPlayer
	{
		get
		{
			return <ActionPlayer>k__BackingField;
		}
		protected set
		{
			<ActionPlayer>k__BackingField = value;
		}
	}

	public string Action => <Action>k__BackingField;

	protected LastActionInfo(ISFSObject lastActionParams)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		if (lastActionParams != null)
		{
			object varName = "alignContent" + 680;
			object varName2 = "___# Content push apply failed [{0}]: {1}" + 3152;
			object defaultValue = (nint)0 + (nint)2000;
			<ActionPlayer>k__BackingField = SFSExtensions.Get(lastActionParams, (string)varName, 0);
			string text = SFSExtensions.Get(lastActionParams, (string)varName2, (string)defaultValue);
			object obj = this + 24;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public LastActionInfo(LastActionInfo lastActionInfo)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		object obj = this + 24;
		obj = lastActionInfo.<Action>k__BackingField;
		_ = lastActionInfo.<ActionPlayer>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
