using System;
using Cpp2ILInjected;

[Serializable]
public class AuthErrorModel
{
	private DateTime <KickedUntil>k__BackingField;

	private string <KickReason>k__BackingField;

	public DateTime KickedUntil
	{
		get
		{
			return <KickedUntil>k__BackingField;
		}
		set
		{
			<KickedUntil>k__BackingField = value;
		}
	}

	public string KickReason
	{
		get
		{
			return <KickReason>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
