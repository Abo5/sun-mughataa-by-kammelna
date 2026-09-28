namespace Server.Models;

public class AutoClickersConfig
{
	private int <ClicksPeriod>k__BackingField;

	private int <MaxAllowedClicksPerPeriod>k__BackingField;

	private bool <DeleteCredentials>k__BackingField;

	public int ClicksPeriod
	{
		get
		{
			return <ClicksPeriod>k__BackingField;
		}
		set
		{
			<ClicksPeriod>k__BackingField = value;
		}
	}

	public int MaxAllowedClicksPerPeriod
	{
		get
		{
			return <MaxAllowedClicksPerPeriod>k__BackingField;
		}
		set
		{
			<MaxAllowedClicksPerPeriod>k__BackingField = value;
		}
	}

	public bool DeleteCredentials
	{
		get
		{
			return <DeleteCredentials>k__BackingField;
		}
		set
		{
			<DeleteCredentials>k__BackingField = value;
		}
	}
}
