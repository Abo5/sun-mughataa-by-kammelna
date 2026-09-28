using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class TestAccountProvisionResultModel
{
	private string <RunId>k__BackingField;

	private int <RetiredAccounts>k__BackingField;

	private List<ProvisionedTestAccountModel> <Accounts>k__BackingField;

	public string RunId
	{
		get
		{
			return <RunId>k__BackingField;
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

	public int RetiredAccounts
	{
		get
		{
			return <RetiredAccounts>k__BackingField;
		}
		set
		{
			<RetiredAccounts>k__BackingField = value;
		}
	}

	public List<ProvisionedTestAccountModel> Accounts
	{
		get
		{
			return <Accounts>k__BackingField;
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
}
