namespace Kammelna.Server.WebRequests;

public sealed class TestDataCleanupResultModel
{
	private int <ClansDeleted>k__BackingField;

	private int <FriendshipsDeleted>k__BackingField;

	private int <JoinRequestsDeleted>k__BackingField;

	public int ClansDeleted
	{
		get
		{
			return <ClansDeleted>k__BackingField;
		}
		set
		{
			<ClansDeleted>k__BackingField = value;
		}
	}

	public int FriendshipsDeleted
	{
		get
		{
			return <FriendshipsDeleted>k__BackingField;
		}
		set
		{
			<FriendshipsDeleted>k__BackingField = value;
		}
	}

	public int JoinRequestsDeleted
	{
		get
		{
			return <JoinRequestsDeleted>k__BackingField;
		}
		set
		{
			<JoinRequestsDeleted>k__BackingField = value;
		}
	}
}
