using Cpp2ILInjected;

namespace PredictAndWinModel;

public class League
{
	public enum Score
	{
		Open,
		BestOf,
		NumberOfGames
	}

	private int <id>k__BackingField;

	private string <leagueName>k__BackingField;

	private Score <scoreType>k__BackingField;

	private int <scoreValue>k__BackingField;

	public int id
	{
		get
		{
			return <id>k__BackingField;
		}
		set
		{
			<id>k__BackingField = value;
		}
	}

	public string leagueName
	{
		get
		{
			return <leagueName>k__BackingField;
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

	public Score scoreType
	{
		get
		{
			return <scoreType>k__BackingField;
		}
		set
		{
			<scoreType>k__BackingField = value;
		}
	}

	public int scoreValue
	{
		get
		{
			return <scoreValue>k__BackingField;
		}
		set
		{
			<scoreValue>k__BackingField = value;
		}
	}
}
