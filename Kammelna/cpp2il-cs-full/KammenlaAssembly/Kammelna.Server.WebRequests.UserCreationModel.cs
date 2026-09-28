using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class UserCreationModel
{
	private string <Email>k__BackingField;

	private string <NickName>k__BackingField;

	private string <Password>k__BackingField;

	private string <Phone>k__BackingField;

	private Platform <Platform>k__BackingField;

	private string <DeviceId>k__BackingField;

	public string Email
	{
		get
		{
			return <Email>k__BackingField;
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

	public string NickName
	{
		get
		{
			return <NickName>k__BackingField;
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

	public string Password
	{
		get
		{
			return <Password>k__BackingField;
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

	public string Phone
	{
		get
		{
			return <Phone>k__BackingField;
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

	public Platform Platform
	{
		get
		{
			return <Platform>k__BackingField;
		}
		set
		{
			<Platform>k__BackingField = value;
		}
	}

	public string DeviceId
	{
		get
		{
			return <DeviceId>k__BackingField;
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
