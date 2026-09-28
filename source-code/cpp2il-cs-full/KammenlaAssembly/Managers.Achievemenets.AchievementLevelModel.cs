using Cpp2ILInjected;

namespace Managers.Achievemenets;

public class AchievementLevelModel
{
	private int <levelId>k__BackingField;

	private int <levelCap>k__BackingField;

	private int <points>k__BackingField;

	private string <description>k__BackingField;

	private FileInfoModel <image>k__BackingField;

	public int levelId
	{
		get
		{
			return <levelId>k__BackingField;
		}
		set
		{
			<levelId>k__BackingField = value;
		}
	}

	public int levelCap
	{
		get
		{
			return <levelCap>k__BackingField;
		}
		set
		{
			<levelCap>k__BackingField = value;
		}
	}

	public int points
	{
		get
		{
			return <points>k__BackingField;
		}
		set
		{
			<points>k__BackingField = value;
		}
	}

	public string description
	{
		get
		{
			return <description>k__BackingField;
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

	public FileInfoModel image
	{
		get
		{
			return <image>k__BackingField;
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
}
