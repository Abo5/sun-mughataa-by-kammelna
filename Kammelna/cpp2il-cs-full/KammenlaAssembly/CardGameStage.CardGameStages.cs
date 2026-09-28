using System;

public class CardGameStage
{
	public enum CardGameStages
	{
		None,
		Bidding,
		Playing,
		WaitingForEating,
		InCheatCatch,
		MoveNextRequired
	}

	private CardGameStages <CurrentStage>k__BackingField;

	public CardGameStages CurrentStage
	{
		get
		{
			return <CurrentStage>k__BackingField;
		}
		private set
		{
			<CurrentStage>k__BackingField = value;
		}
	}

	public bool IsBidding
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <CurrentStage>k__BackingField - 1;
			return obj == null;
		}
	}

	public bool IsPlaying
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <CurrentStage>k__BackingField - 2;
			return obj == null;
		}
	}

	public bool IsWaitingForEating
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <CurrentStage>k__BackingField - 3;
			return obj == null;
		}
	}

	public bool IsCheatCatch
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <CurrentStage>k__BackingField - 4;
			return obj == null;
		}
	}

	public bool IsMoveNextRequired
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <CurrentStage>k__BackingField - 5;
			return obj == null;
		}
	}

	public void SetStage(CardGameStages stage)
	{
		<CurrentStage>k__BackingField = stage;
	}

	public unsafe string GetStageName()
	{
		//IL_0010: Expected O, but got Ref
		object obj = default(object);
		return ((Enum)(&obj)).ToString();
	}
}
