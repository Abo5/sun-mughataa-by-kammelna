using System.Collections.Generic;
using Cpp2ILInjected;

namespace Server.Coordinator.Models;

public class ContentDeltaModel<TModel, TId>
{
	private List<TModel> <Upserts>k__BackingField;

	private List<TId> <RemovedIds>k__BackingField;

	private long <Cursor>k__BackingField;

	public List<TModel> Upserts
	{
		get
		{
			return <Upserts>k__BackingField;
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

	public List<TId> RemovedIds
	{
		get
		{
			return <RemovedIds>k__BackingField;
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

	public long Cursor
	{
		get
		{
			return <Cursor>k__BackingField;
		}
		set
		{
			<Cursor>k__BackingField = value;
		}
	}
}
