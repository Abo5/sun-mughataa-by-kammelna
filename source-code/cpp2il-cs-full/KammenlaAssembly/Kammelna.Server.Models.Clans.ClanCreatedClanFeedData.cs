using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class ClanCreatedClanFeedData : ClanFeedData
{
	private long <FounderUserId>k__BackingField;

	private string <FounderName>k__BackingField;

	public long FounderUserId
	{
		get
		{
			return <FounderUserId>k__BackingField;
		}
		set
		{
			<FounderUserId>k__BackingField = value;
		}
	}

	public string FounderName
	{
		get
		{
			return <FounderName>k__BackingField;
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
