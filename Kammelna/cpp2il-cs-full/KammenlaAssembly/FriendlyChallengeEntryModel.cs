using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class FriendlyChallengeEntryModel
{
	private long <DefenderId>k__BackingField;

	private string <UserName>k__BackingField;

	private DateTime? <AvatarTimestamp>k__BackingField;

	private int? <ActiveCardBackId>k__BackingField;

	private string <ActiveTitle>k__BackingField;

	private int <Points>k__BackingField;

	private List<ChallengeEntry> <History>k__BackingField;

	private bool <IsLocked>k__BackingField;

	private int <ChallengeLevel>k__BackingField;

	public long DefenderId
	{
		get
		{
			return <DefenderId>k__BackingField;
		}
		set
		{
			<DefenderId>k__BackingField = value;
		}
	}

	public string UserName
	{
		get
		{
			return <UserName>k__BackingField;
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

	public DateTime? AvatarTimestamp
	{
		get
		{
			return <AvatarTimestamp>k__BackingField;
		}
		set
		{
			<AvatarTimestamp>k__BackingField = value;
		}
	}

	public int? ActiveCardBackId
	{
		get
		{
			return <ActiveCardBackId>k__BackingField;
		}
		set
		{
			<ActiveCardBackId>k__BackingField = value;
		}
	}

	public string ActiveTitle
	{
		get
		{
			return <ActiveTitle>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int Points
	{
		get
		{
			return <Points>k__BackingField;
		}
		set
		{
			<Points>k__BackingField = value;
		}
	}

	public List<ChallengeEntry> History
	{
		get
		{
			return <History>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsLocked
	{
		get
		{
			return <IsLocked>k__BackingField;
		}
		set
		{
			<IsLocked>k__BackingField = value;
		}
	}

	public int ChallengeLevel
	{
		get
		{
			return <ChallengeLevel>k__BackingField;
		}
		set
		{
			<ChallengeLevel>k__BackingField = value;
		}
	}
}
