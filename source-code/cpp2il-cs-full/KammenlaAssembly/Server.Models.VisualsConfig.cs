using Cpp2ILInjected;

namespace Server.Models;

public class VisualsConfig
{
	private bool <IsEid>k__BackingField;

	private string <MiniGameButtonImage>k__BackingField;

	public bool IsEid
	{
		get
		{
			return <IsEid>k__BackingField;
		}
		set
		{
			<IsEid>k__BackingField = value;
		}
	}

	public string MiniGameButtonImage
	{
		get
		{
			return <MiniGameButtonImage>k__BackingField;
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

	public VisualsConfig()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		object obj2 = this + 24;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
