using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kammelna.Server;

[Serializable]
public class ServerConfiguration
{
	private string <ID>k__BackingField;

	private string <Name>k__BackingField;

	private int <MaxUsers>k__BackingField;

	private int <OnlineUsers>k__BackingField;

	private string <IP>k__BackingField;

	private int <Port>k__BackingField;

	private int <WebPort>k__BackingField;

	private bool <IsMain>k__BackingField;

	private bool <IsOnline>k__BackingField;

	private bool <IsFastTrack>k__BackingField;

	private bool <IsRestricted>k__BackingField;

	private List<GameConfiguration> <Games>k__BackingField;

	public string ID
	{
		get
		{
			return <ID>k__BackingField;
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

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
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

	public int MaxUsers
	{
		get
		{
			return <MaxUsers>k__BackingField;
		}
		set
		{
			<MaxUsers>k__BackingField = value;
		}
	}

	public int OnlineUsers
	{
		get
		{
			return <OnlineUsers>k__BackingField;
		}
		set
		{
			<OnlineUsers>k__BackingField = value;
		}
	}

	public string IP
	{
		get
		{
			return <IP>k__BackingField;
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

	public int Port
	{
		get
		{
			return <Port>k__BackingField;
		}
		set
		{
			<Port>k__BackingField = value;
		}
	}

	public int WebPort
	{
		get
		{
			return <WebPort>k__BackingField;
		}
		set
		{
			<WebPort>k__BackingField = value;
		}
	}

	public bool IsMain
	{
		get
		{
			return <IsMain>k__BackingField;
		}
		set
		{
			<IsMain>k__BackingField = value;
		}
	}

	public bool IsOnline
	{
		get
		{
			return <IsOnline>k__BackingField;
		}
		set
		{
			<IsOnline>k__BackingField = value;
		}
	}

	public bool IsFastTrack
	{
		get
		{
			return <IsFastTrack>k__BackingField;
		}
		set
		{
			<IsFastTrack>k__BackingField = value;
		}
	}

	public bool IsRestricted
	{
		get
		{
			return <IsRestricted>k__BackingField;
		}
		set
		{
			<IsRestricted>k__BackingField = value;
		}
	}

	public List<GameConfiguration> Games
	{
		get
		{
			return <Games>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
