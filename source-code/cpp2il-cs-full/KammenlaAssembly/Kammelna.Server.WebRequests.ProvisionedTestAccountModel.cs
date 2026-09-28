using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class ProvisionedTestAccountModel
{
	private string <Role>k__BackingField;

	private long <UserId>k__BackingField;

	private string <Email>k__BackingField;

	private string <Password>k__BackingField;

	private int <Aces>k__BackingField;

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
			object obj = this + 32;
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
			object obj = this + 40;
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
}
