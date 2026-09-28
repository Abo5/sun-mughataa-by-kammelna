using Sfs2X.Entities.Data;

public class ChallengeStatusData
{
	private static class Constants
	{
		public const string ChallengeLevel = "fcl";

		public const string IsLocked = "fcstal";
	}

	private int <ChallengeLevel>k__BackingField;

	private bool <IsLocked>k__BackingField;

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

	public ChallengeStatusData(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 3992;
		object varName2 = "destinationTimeZone" + 4048;
		base..ctor();
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<ChallengeLevel>k__BackingField = num;
		bool flag = SFSExtensions.Get(data, (string)varName2, defaultValue: false);
		<IsLocked>k__BackingField = flag;
	}
}
