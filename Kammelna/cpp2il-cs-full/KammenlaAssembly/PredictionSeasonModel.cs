using System.Collections.Generic;
using Cpp2ILInjected;

public class PredictionSeasonModel
{
	private string <Description>k__BackingField;

	private FileInfoModel <Image>k__BackingField;

	private List<PredictionSeasonRewardModel> <Rewards>k__BackingField;

	public string Description
	{
		get
		{
			return <Description>k__BackingField;
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

	public FileInfoModel Image
	{
		get
		{
			return <Image>k__BackingField;
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

	public List<PredictionSeasonRewardModel> Rewards
	{
		get
		{
			return <Rewards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
