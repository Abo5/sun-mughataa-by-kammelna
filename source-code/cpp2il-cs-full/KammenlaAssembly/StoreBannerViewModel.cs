using System;
using Cpp2ILInjected;

[Serializable]
public class StoreBannerViewModel
{
	private string <id>k__BackingField;

	private string <name>k__BackingField;

	private RoutingCommand <routingCommand>k__BackingField;

	private string <routingParam>k__BackingField;

	private Games? <routingGame>k__BackingField;

	private ImageInfoModel<ImageCacher.BannerSize> <image>k__BackingField;

	public string id
	{
		get
		{
			return <id>k__BackingField;
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

	public string name
	{
		get
		{
			return <name>k__BackingField;
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

	public RoutingCommand routingCommand
	{
		get
		{
			return <routingCommand>k__BackingField;
		}
		set
		{
			<routingCommand>k__BackingField = value;
		}
	}

	public string routingParam
	{
		get
		{
			return <routingParam>k__BackingField;
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

	public Games? routingGame
	{
		get
		{
			return <routingGame>k__BackingField;
		}
		set
		{
			<routingGame>k__BackingField = value;
		}
	}

	public ImageInfoModel<ImageCacher.BannerSize> image
	{
		get
		{
			return <image>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
