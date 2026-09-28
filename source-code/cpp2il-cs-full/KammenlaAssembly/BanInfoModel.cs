using System;
using Cpp2ILInjected;

[Serializable]
public class BanInfoModel
{
	private string <banReason>k__BackingField;

	private DateTime? <mutedUntil>k__BackingField;

	private DateTime? <bannedUntil>k__BackingField;

	public string banReason
	{
		get
		{
			return <banReason>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime? mutedUntil
	{
		get
		{
			return <mutedUntil>k__BackingField;
		}
		set
		{
			<mutedUntil>k__BackingField = value;
		}
	}

	public DateTime? bannedUntil
	{
		get
		{
			return <bannedUntil>k__BackingField;
		}
		set
		{
			<bannedUntil>k__BackingField = value;
		}
	}
}
