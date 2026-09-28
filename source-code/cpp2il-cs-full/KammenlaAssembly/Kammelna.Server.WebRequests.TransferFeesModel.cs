namespace Kammelna.Server.WebRequests;

public class TransferFeesModel
{
	private int <MonthlyThreshold>k__BackingField;

	private int <Spent>k__BackingField;

	private decimal <AppliedFees>k__BackingField;

	private decimal <FeesAfterThreshold>k__BackingField;

	public int MonthlyThreshold
	{
		get
		{
			return <MonthlyThreshold>k__BackingField;
		}
		set
		{
			<MonthlyThreshold>k__BackingField = value;
		}
	}

	public int Spent
	{
		get
		{
			return <Spent>k__BackingField;
		}
		set
		{
			<Spent>k__BackingField = value;
		}
	}

	public decimal AppliedFees
	{
		get
		{
			return <AppliedFees>k__BackingField;
		}
		set
		{
			<AppliedFees>k__BackingField = value;
		}
	}

	public decimal FeesAfterThreshold
	{
		get
		{
			return <FeesAfterThreshold>k__BackingField;
		}
		set
		{
			<FeesAfterThreshold>k__BackingField = value;
		}
	}
}
