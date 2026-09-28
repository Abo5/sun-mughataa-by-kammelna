using Cpp2ILInjected;

public class UserReferralRewardModel
{
	private int <rewardID>k__BackingField;

	private string <name>k__BackingField;

	private int <aces>k__BackingField;

	private int <subscriptionDays>k__BackingField;

	private int <itemID>k__BackingField;

	private int <referralsNeeded>k__BackingField;

	private bool <isClaimed>k__BackingField;

	public int rewardID
	{
		get
		{
			return <rewardID>k__BackingField;
		}
		set
		{
			<rewardID>k__BackingField = value;
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

	public int aces
	{
		get
		{
			return <aces>k__BackingField;
		}
		set
		{
			<aces>k__BackingField = value;
		}
	}

	public int subscriptionDays
	{
		get
		{
			return <subscriptionDays>k__BackingField;
		}
		set
		{
			<subscriptionDays>k__BackingField = value;
		}
	}

	public int itemID
	{
		get
		{
			return <itemID>k__BackingField;
		}
		set
		{
			<itemID>k__BackingField = value;
		}
	}

	public int referralsNeeded
	{
		get
		{
			return <referralsNeeded>k__BackingField;
		}
		set
		{
			<referralsNeeded>k__BackingField = value;
		}
	}

	public bool isClaimed
	{
		get
		{
			return <isClaimed>k__BackingField;
		}
		set
		{
			<isClaimed>k__BackingField = value;
		}
	}
}
