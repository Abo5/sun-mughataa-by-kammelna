using System;
using Cpp2ILInjected;

public class FriendLeaderboardModel
{
	private long <userDbId>k__BackingField;

	private string <userName>k__BackingField;

	private bool <isSubscribed>k__BackingField;

	private bool <isVerified>k__BackingField;

	private int <activeCardback>k__BackingField;

	private DateTime? <avatar>k__BackingField;

	private bool <IsNew>k__BackingField;

	private int <points>k__BackingField;

	private long <currentMonthPoints>k__BackingField;

	private int <tournamentPoints>k__BackingField;

	private int <placement>k__BackingField;

	public long userDbId
	{
		get
		{
			return <userDbId>k__BackingField;
		}
		set
		{
			<userDbId>k__BackingField = value;
		}
	}

	public string userName
	{
		get
		{
			return <userName>k__BackingField;
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

	public bool isSubscribed
	{
		get
		{
			return <isSubscribed>k__BackingField;
		}
		set
		{
			<isSubscribed>k__BackingField = value;
		}
	}

	public bool isVerified
	{
		get
		{
			return <isVerified>k__BackingField;
		}
		set
		{
			<isVerified>k__BackingField = value;
		}
	}

	public int activeCardback
	{
		get
		{
			return <activeCardback>k__BackingField;
		}
		set
		{
			<activeCardback>k__BackingField = value;
		}
	}

	public DateTime? avatar
	{
		get
		{
			return <avatar>k__BackingField;
		}
		set
		{
			<avatar>k__BackingField = value;
		}
	}

	public bool IsNew
	{
		get
		{
			return <IsNew>k__BackingField;
		}
		set
		{
			<IsNew>k__BackingField = value;
		}
	}

	public int points
	{
		get
		{
			return <points>k__BackingField;
		}
		set
		{
			<points>k__BackingField = value;
		}
	}

	public long currentMonthPoints
	{
		get
		{
			return <currentMonthPoints>k__BackingField;
		}
		set
		{
			<currentMonthPoints>k__BackingField = value;
		}
	}

	public int tournamentPoints
	{
		get
		{
			return <tournamentPoints>k__BackingField;
		}
		set
		{
			<tournamentPoints>k__BackingField = value;
		}
	}

	public int placement
	{
		get
		{
			return <placement>k__BackingField;
		}
		set
		{
			<placement>k__BackingField = value;
		}
	}
}
