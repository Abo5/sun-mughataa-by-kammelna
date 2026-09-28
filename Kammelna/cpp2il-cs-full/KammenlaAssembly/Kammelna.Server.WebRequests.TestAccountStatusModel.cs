using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class TestAccountStatusModel
{
	private string <Role>k__BackingField;

	private bool <Exists>k__BackingField;

	private long? <UserId>k__BackingField;

	private string <Email>k__BackingField;

	private int <Aces>k__BackingField;

	private int <MiniGameTrials>k__BackingField;

	private int? <ClanId>k__BackingField;

	private bool <HasActiveTokens>k__BackingField;

	public string Role
	{
		get
		{
			return <Role>k__BackingField;
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

	public bool Exists
	{
		get
		{
			return <Exists>k__BackingField;
		}
		set
		{
			<Exists>k__BackingField = value;
		}
	}

	public long? UserId
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
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int Aces
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

	public int MiniGameTrials
	{
		get
		{
			return <MiniGameTrials>k__BackingField;
		}
		set
		{
			<MiniGameTrials>k__BackingField = value;
		}
	}

	public int? ClanId
	{
		get
		{
			return <ClanId>k__BackingField;
		}
		set
		{
			<ClanId>k__BackingField = value;
		}
	}

	public bool HasActiveTokens
	{
		get
		{
			return <HasActiveTokens>k__BackingField;
		}
		set
		{
			<HasActiveTokens>k__BackingField = value;
		}
	}
}
