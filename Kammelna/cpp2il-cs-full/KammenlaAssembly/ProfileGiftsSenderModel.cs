using System;
using Cpp2ILInjected;

public class ProfileGiftsSenderModel
{
	private long <UserId>k__BackingField;

	private string <UserName>k__BackingField;

	private DateTime? <AvatarTimestamp>k__BackingField;

	private long <Points>k__BackingField;

	private ProfileGiftQuantityPair[] <SentGifts>k__BackingField;

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
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime? AvatarTimestamp
	{
		get
		{
			return <AvatarTimestamp>k__BackingField;
		}
		set
		{
			<AvatarTimestamp>k__BackingField = value;
		}
	}

	public long Points
	{
		get
		{
			return <Points>k__BackingField;
		}
		set
		{
			<Points>k__BackingField = value;
		}
	}

	public ProfileGiftQuantityPair[] SentGifts
	{
		get
		{
			return <SentGifts>k__BackingField;
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
