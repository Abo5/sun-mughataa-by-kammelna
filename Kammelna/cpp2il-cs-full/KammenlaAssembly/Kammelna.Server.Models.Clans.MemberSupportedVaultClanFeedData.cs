using System;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class MemberSupportedVaultClanFeedData : ClanFeedData
{
	private long <UserId>k__BackingField;

	private DateTime? <UserAvatarDate>k__BackingField;

	private string <UserName>k__BackingField;

	private int <Amount>k__BackingField;

	private VaultSupportTier <Tier>k__BackingField;

	private int <VaultTotal>k__BackingField;

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

	public int Amount
	{
		get
		{
			return <Amount>k__BackingField;
		}
		set
		{
			<Amount>k__BackingField = value;
		}
	}

	public VaultSupportTier Tier
	{
		get
		{
			return <Tier>k__BackingField;
		}
		set
		{
			<Tier>k__BackingField = value;
		}
	}

	public int VaultTotal
	{
		get
		{
			return <VaultTotal>k__BackingField;
		}
		set
		{
			<VaultTotal>k__BackingField = value;
		}
	}

	public override AvatarData AvatarData
	{
		get
		{
			long userId = <UserId>k__BackingField;
			string userName = <UserName>k__BackingField;
			DateTime? avatarDate = <UserAvatarDate>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.Models.Clans.MemberSupportedVaultClanFeedData)+28]");
			return ClanFeedData.BuildAvatarData(userId, userName, avatarDate);
		}
	}
}
