using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class MemberAchievementClanFeedData : ClanFeedData
{
	private long <UserId>k__BackingField;

	private DateTime? <UserAvatarDate>k__BackingField;

	private string <UserName>k__BackingField;

	private string <AchievementId>k__BackingField;

	private int <LevelId>k__BackingField;

	private long? <ActiveCardBackId>k__BackingField;

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
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string AchievementId
	{
		get
		{
			return <AchievementId>k__BackingField;
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

	public int LevelId
	{
		get
		{
			return <LevelId>k__BackingField;
		}
		set
		{
			<LevelId>k__BackingField = value;
		}
	}

	public long? ActiveCardBackId
	{
		get
		{
			return <ActiveCardBackId>k__BackingField;
		}
		set
		{
			<ActiveCardBackId>k__BackingField = value;
		}
	}

	public override AvatarData AvatarData
	{
		get
		{
			long userId = <UserId>k__BackingField;
			string userName = <UserName>k__BackingField;
			DateTime? avatarDate = <UserAvatarDate>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.Models.Clans.MemberAchievementClanFeedData)+28]");
			return ClanFeedData.BuildAvatarData(userId, userName, avatarDate);
		}
	}
}
