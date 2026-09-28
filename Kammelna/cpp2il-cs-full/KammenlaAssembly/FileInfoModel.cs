using System;
using Cpp2ILInjected;

[Serializable]
public class FileInfoModel
{
	private string <url>k__BackingField;

	private DateTime <lastModified>k__BackingField;

	public string url
	{
		get
		{
			return <url>k__BackingField;
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

	public DateTime lastModified
	{
		get
		{
			return <lastModified>k__BackingField;
		}
		set
		{
			<lastModified>k__BackingField = value;
		}
	}
}
