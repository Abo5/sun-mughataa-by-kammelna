using System;
using Cpp2ILInjected;

[Serializable]
public class RegisteredUserErrorModel
{
	private string <SuggestedName>k__BackingField;

	public string SuggestedName
	{
		get
		{
			return <SuggestedName>k__BackingField;
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
}
