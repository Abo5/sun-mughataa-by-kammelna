using Cpp2ILInjected;

public class GameReplayFilterModel
{
	private string <Text>k__BackingField;

	private GameType? <GameType>k__BackingField;

	private bool? <CheatingAllowed>k__BackingField;

	private int? <PlayingSpeed>k__BackingField;

	private bool? <IsLocked>k__BackingField;

	public string Text
	{
		get
		{
			return <Text>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GameType? GameType
	{
		get
		{
			return <GameType>k__BackingField;
		}
		set
		{
			<GameType>k__BackingField = value;
		}
	}

	public bool? CheatingAllowed
	{
		get
		{
			return <CheatingAllowed>k__BackingField;
		}
		set
		{
			<CheatingAllowed>k__BackingField = value;
		}
	}

	public int? PlayingSpeed
	{
		get
		{
			return <PlayingSpeed>k__BackingField;
		}
		set
		{
			<PlayingSpeed>k__BackingField = value;
		}
	}

	public bool? IsLocked
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
}
