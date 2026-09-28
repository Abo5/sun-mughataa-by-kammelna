using System;
using Cpp2ILInjected;

public class FriendlyNameAttribute : Attribute
{
	private string <FriendlyName>k__BackingField;

	public string FriendlyName
	{
		get
		{
			return <FriendlyName>k__BackingField;
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

	public FriendlyNameAttribute(string friendlyName)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = friendlyName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
