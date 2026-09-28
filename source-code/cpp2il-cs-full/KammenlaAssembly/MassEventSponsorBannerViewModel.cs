using System;
using Cpp2ILInjected;

[Serializable]
public class MassEventSponsorBannerViewModel
{
	private int <Id>k__BackingField;

	private RoutingCommand <RoutingCommand>k__BackingField;

	private string <RoutingParam>k__BackingField;

	private FileInfoModel <Image>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public RoutingCommand RoutingCommand
	{
		get
		{
			return <RoutingCommand>k__BackingField;
		}
		set
		{
			<RoutingCommand>k__BackingField = value;
		}
	}

	public string RoutingParam
	{
		get
		{
			return <RoutingParam>k__BackingField;
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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
