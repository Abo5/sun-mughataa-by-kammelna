using System;
using System.Buffers.Text;
using Cpp2ILInjected;

[Serializable]
public class UserMatchPredictionModel
{
	private int <awayTeamScore>k__BackingField;

	private int <homeTeamScore>k__BackingField;

	private DateTime <createdOn>k__BackingField;

	private PredictionRewardType <predictionReward>k__BackingField;

	private MatchPredictionModel <predictionMatch>k__BackingField;

	public int awayTeamScore
	{
		get
		{
			return <awayTeamScore>k__BackingField;
		}
		set
		{
			<awayTeamScore>k__BackingField = value;
		}
	}

	public int homeTeamScore
	{
		get
		{
			return <homeTeamScore>k__BackingField;
		}
		set
		{
			<homeTeamScore>k__BackingField = value;
		}
	}

	public DateTime createdOn
	{
		get
		{
			return <createdOn>k__BackingField;
		}
		set
		{
			<createdOn>k__BackingField = value;
		}
	}

	public PredictionRewardType predictionReward
	{
		get
		{
			return <predictionReward>k__BackingField;
		}
		set
		{
			<predictionReward>k__BackingField = value;
		}
	}

	public MatchPredictionModel predictionMatch
	{
		get
		{
			return <predictionMatch>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1584;
		object format = "placementId" + 3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg, <predictionMatch>k__BackingField);
	}
}
