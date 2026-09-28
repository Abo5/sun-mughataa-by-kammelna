using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Server.Models;

[Serializable]
public class InGameHintModel : IClientFilterable
{
	private int <Id>k__BackingField;

	private Games? <Game>k__BackingField;

	private string <Hint>k__BackingField;

	private List<ClientFilter> <Filters>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public Games? Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public string Hint
	{
		get
		{
			return <Hint>k__BackingField;
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

	public List<ClientFilter> Filters
	{
		get
		{
			return <Filters>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
