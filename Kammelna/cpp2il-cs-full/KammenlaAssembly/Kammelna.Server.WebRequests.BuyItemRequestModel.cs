using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class BuyItemRequestModel
{
	private int <ItemId>k__BackingField;

	private int? <TemplateId>k__BackingField;

	private long[] <Recipients>k__BackingField;

	public int ItemId
	{
		get
		{
			return <ItemId>k__BackingField;
		}
		set
		{
			<ItemId>k__BackingField = value;
		}
	}

	public int? TemplateId
	{
		get
		{
			return <TemplateId>k__BackingField;
		}
		set
		{
			<TemplateId>k__BackingField = value;
		}
	}

	public long[] Recipients
	{
		get
		{
			return <Recipients>k__BackingField;
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
