using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class TestAccountResetResultModel
{
	private string <Role>k__BackingField;

	private long <UserId>k__BackingField;

	private bool <Succeeded>k__BackingField;

	private string <Error>k__BackingField;

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

	public bool Succeeded
	{
		get
		{
			return <Succeeded>k__BackingField;
		}
		set
		{
			<Succeeded>k__BackingField = value;
		}
	}

	public string Error
	{
		get
		{
			return <Error>k__BackingField;
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
}
