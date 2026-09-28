using System;
using Cpp2ILInjected;

public class AcesChange
{
	private long <userID>k__BackingField;

	private DateTime <time>k__BackingField;

	private string <type>k__BackingField;

	private string <itemID>k__BackingField;

	private long <difference>k__BackingField;

	private long <newTotal>k__BackingField;

	private long? <otherUser>k__BackingField;

	private string <adminName>k__BackingField;

	public long userID
	{
		get
		{
			return <userID>k__BackingField;
		}
		set
		{
			<userID>k__BackingField = value;
		}
	}

	public DateTime time
	{
		get
		{
			return <time>k__BackingField;
		}
		set
		{
			<time>k__BackingField = value;
		}
	}

	public string type
	{
		get
		{
			return <type>k__BackingField;
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

	public string itemID
	{
		get
		{
			return <itemID>k__BackingField;
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

	public long difference
	{
		get
		{
			return <difference>k__BackingField;
		}
		set
		{
			<difference>k__BackingField = value;
		}
	}

	public long newTotal
	{
		get
		{
			return <newTotal>k__BackingField;
		}
		set
		{
			<newTotal>k__BackingField = value;
		}
	}

	public long? otherUser
	{
		get
		{
			return <otherUser>k__BackingField;
		}
		set
		{
			<otherUser>k__BackingField = value;
		}
	}

	public string adminName
	{
		get
		{
			return <adminName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
