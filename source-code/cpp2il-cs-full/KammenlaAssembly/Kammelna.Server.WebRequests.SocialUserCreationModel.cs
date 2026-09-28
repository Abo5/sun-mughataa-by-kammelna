using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class SocialUserCreationModel
{
	private string <Email>k__BackingField;

	private string <NickName>k__BackingField;

	private string <FirebaseId>k__BackingField;

	private string <TwitterId>k__BackingField;

	private SocialPlatform <FirebasePlatform>k__BackingField;

	private string <Phone>k__BackingField;

	private Games <Game>k__BackingField;

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

	public string FirebaseId
	{
		get
		{
			return <FirebaseId>k__BackingField;
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

	public string TwitterId
	{
		get
		{
			return <TwitterId>k__BackingField;
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

	public SocialPlatform FirebasePlatform
	{
		get
		{
			return <FirebasePlatform>k__BackingField;
		}
		set
		{
			<FirebasePlatform>k__BackingField = value;
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
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Games Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
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
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
