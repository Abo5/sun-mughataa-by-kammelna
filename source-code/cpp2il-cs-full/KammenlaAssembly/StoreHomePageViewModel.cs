using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class StoreHomePageViewModel
{
	private int? <templateId>k__BackingField;

	private string <name>k__BackingField;

	private List<StoreHomeSection> <sections>k__BackingField;

	public int? templateId
	{
		get
		{
			return <templateId>k__BackingField;
		}
		set
		{
			<templateId>k__BackingField = value;
		}
	}

	public string name
	{
		get
		{
			return <name>k__BackingField;
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

	public List<StoreHomeSection> sections
	{
		get
		{
			return <sections>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
