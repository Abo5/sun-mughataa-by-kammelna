public class MassEventStagesStatus
{
	public int CurrentStage;

	public int PlayerLastStageReached;

	public bool IsRegistered;

	public MassEventNextStageEligibility IsEligible;

	public bool IsPlayerPlaying()
	{
		//IL_0011: Expected O, but got I4
		object obj = PlayerLastStageReached - CurrentStage;
		return obj == null;
	}

	public bool IsPlayerPromoted()
	{
		//IL_0011: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		object obj = PlayerLastStageReached - CurrentStage;
		bool flag = (nint)obj < 0;
		int num = PlayerLastStageReached ^ CurrentStage;
		int num2 = PlayerLastStageReached ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		return flag == flag2;
	}

	public bool PlayerIsReserving()
	{
		//IL_0010: Expected O, but got I4
		object obj = IsEligible - 2;
		return obj == null;
	}

	public bool IsPlayerKnockedOut()
	{
		//IL_0011: Expected O, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		object obj = CurrentStage - PlayerLastStageReached;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = CurrentStage ^ PlayerLastStageReached;
		int num2 = CurrentStage ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		return (byte)((flag4 & obj2) ? 1 : 0) != 0;
	}

	public bool PlayerIsNotRegistered()
	{
		return !IsRegistered;
	}

	public void SetData(int current, int playerLastStageReached, bool isRegistered, MassEventNextStageEligibility isEligible)
	{
		CurrentStage = current;
		PlayerLastStageReached = playerLastStageReached;
		IsRegistered = isRegistered;
		IsEligible = isEligible;
	}
}
