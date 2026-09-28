using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class AnnouncementClanFeedData : ClanFeedData
{
	private string <Title>k__BackingField;

	private string <Body>k__BackingField;

	private long <UserId>k__BackingField;

	private DateTime? <UserAvatarDate>k__BackingField;

	private string <UserName>k__BackingField;

	public string Title
	{
		get
		{
			return <Title>k__BackingField;
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

	public string Body
	{
		get
		{
			return <Body>k__BackingField;
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

	public long UserId
	{
		get
		{
			return <UserId>k__BackingField;
		}
		set
		{
			<UserId>k__BackingField = value;
		}
	}

	public DateTime? UserAvatarDate
	{
		get
		{
			return <UserAvatarDate>k__BackingField;
		}
		set
		{
			<UserAvatarDate>k__BackingField = value;
		}
	}

	public string UserName
	{
		get
		{
			return <UserName>k__BackingField;
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

	public override AvatarData AvatarData
	{
		get
		{
			long userId = <UserId>k__BackingField;
			string userName = <UserName>k__BackingField;
			DateTime? avatarDate = <UserAvatarDate>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.Models.Clans.AnnouncementClanFeedData)+38]");
			return ClanFeedData.BuildAvatarData(userId, userName, avatarDate);
		}
	}
}
