using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kammelna.Server;

[Serializable]
public class ConfigsModel
{
	private List<ServerConfiguration> <Servers>k__BackingField;

	private MaintenanceInfo <Maintenance>k__BackingField;

	private PlatformConfiguration <ForcedVersion>k__BackingField;

	private PlatformConfiguration <DownMessage>k__BackingField;

	private string <BlobHost>k__BackingField;

	private string <SignalRServerUrl>k__BackingField;

	public List<ServerConfiguration> Servers
	{
		get
		{
			return <Servers>k__BackingField;
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

	public MaintenanceInfo Maintenance
	{
		get
		{
			return <Maintenance>k__BackingField;
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

	public PlatformConfiguration ForcedVersion
	{
		get
		{
			return <ForcedVersion>k__BackingField;
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

	public PlatformConfiguration DownMessage
	{
		get
		{
			return <DownMessage>k__BackingField;
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

	public string BlobHost
	{
		get
		{
			return <BlobHost>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string SignalRServerUrl
	{
		get
		{
			return <SignalRServerUrl>k__BackingField;
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
