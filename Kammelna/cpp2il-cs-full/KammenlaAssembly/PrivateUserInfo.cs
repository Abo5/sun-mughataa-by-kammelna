using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class PrivateUserInfo
{
	private string <Email>k__BackingField;

	private string <LastName>k__BackingField;

	private long <Aces>k__BackingField;

	private List<AcesChange> <AcesHistory>k__BackingField;

	private int <KickCount>k__BackingField;

	private int <MuteCount>k__BackingField;

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

	public string LastName
	{
		get
		{
			return <LastName>k__BackingField;
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

	public long Aces
	{
		get
		{
			return <Aces>k__BackingField;
		}
		set
		{
			<Aces>k__BackingField = value;
		}
	}

	public List<AcesChange> AcesHistory
	{
		get
		{
			return <AcesHistory>k__BackingField;
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

	public int KickCount
	{
		get
		{
			return <KickCount>k__BackingField;
		}
		set
		{
			<KickCount>k__BackingField = value;
		}
	}

	public int MuteCount
	{
		get
		{
			return <MuteCount>k__BackingField;
		}
		set
		{
			<MuteCount>k__BackingField = value;
		}
	}
}
