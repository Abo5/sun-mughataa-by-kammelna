using Cpp2ILInjected;

namespace PredictAndWinModel;

public class Tweet
{
	private FileInfoModel <image>k__BackingField;

	private int <id>k__BackingField;

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
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

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
}
