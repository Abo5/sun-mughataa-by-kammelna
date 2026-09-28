namespace Server.Coordinator.Models;

public class ConnectionStatusUpdate
{
	private int <UserId>k__BackingField;

	private bool <IsOnline>k__BackingField;

	public int UserId
	{
		get
		{
			return <UserId>k__BackingField;
		}
		set
		{
			<UserId>k__BackingField = value;
		}
	}

	public bool IsOnline
	{
		get
		{
			return <IsOnline>k__BackingField;
		}
		set
		{
			<IsOnline>k__BackingField = value;
		}
	}
}
