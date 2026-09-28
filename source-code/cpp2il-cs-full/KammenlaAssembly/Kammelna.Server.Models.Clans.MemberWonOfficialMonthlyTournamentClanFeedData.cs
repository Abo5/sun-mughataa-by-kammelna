using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class MemberWonOfficialMonthlyTournamentClanFeedData : ClanFeedData
{
	private long <UserId>k__BackingField;

	private DateTime? <UserAvatarDate>k__BackingField;

	private string <UserName>k__BackingField;

	private int <SubType>k__BackingField;

	private int <Game>k__BackingField;

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

	public int SubType
	{
		get
		{
			return <SubType>k__BackingField;
		}
		set
		{
			<SubType>k__BackingField = value;
		}
	}

	public int Game
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

	public override AvatarData AvatarData
	{
		get
		{
			long userId = <UserId>k__BackingField;
			string userName = <UserName>k__BackingField;
			DateTime? avatarDate = <UserAvatarDate>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.Models.Clans.MemberWonOfficialMonthlyTournamentClanFeedData)+28]");
			return ClanFeedData.BuildAvatarData(userId, userName, avatarDate);
		}
	}
}
