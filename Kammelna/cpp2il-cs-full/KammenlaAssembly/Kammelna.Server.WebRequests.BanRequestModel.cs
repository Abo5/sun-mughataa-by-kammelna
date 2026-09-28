using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class BanRequestModel
{
	private long <UserID>k__BackingField;

	private int <Duration>k__BackingField;

	private string <Reason>k__BackingField;

	private string <Comment>k__BackingField;

	private string <ServerID>k__BackingField;

	private string <RoomName>k__BackingField;

	private string <ChatBuffer>k__BackingField;

	public long UserID
	{
		get
		{
			return <UserID>k__BackingField;
		}
		set
		{
			<UserID>k__BackingField = value;
		}
	}

	public int Duration
	{
		get
		{
			return <Duration>k__BackingField;
		}
		set
		{
			<Duration>k__BackingField = value;
		}
	}

	public string Reason
	{
		get
		{
			return <Reason>k__BackingField;
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

	public string Comment
	{
		get
		{
			return <Comment>k__BackingField;
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

	public string ServerID
	{
		get
		{
			return <ServerID>k__BackingField;
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

	public string RoomName
	{
		get
		{
			return <RoomName>k__BackingField;
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

	public string ChatBuffer
	{
		get
		{
			return <ChatBuffer>k__BackingField;
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
