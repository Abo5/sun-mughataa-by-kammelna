using System;

public class GamePhase
{
	public enum GamePhases
	{
		Initializing,
		LookingForPlayers,
		Started,
		Finished
	}

	private GamePhases currentPhase;

	public bool IsInitializing => currentPhase == GamePhases.Initializing;

	public bool IsLookingForPlayers
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = currentPhase - 1;
			return obj == null;
		}
	}

	public bool IsGameStarted
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = currentPhase - 2;
			return obj == null;
		}
	}

	public bool IsGameFinished
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = currentPhase - 3;
			return obj == null;
		}
	}

	public void SetPhase(GamePhases phase)
	{
		currentPhase = phase;
	}

	public unsafe string GetPhaseName()
	{
		//IL_0010: Expected O, but got Ref
		object obj = default(object);
		return ((Enum)(&obj)).ToString();
	}
}
