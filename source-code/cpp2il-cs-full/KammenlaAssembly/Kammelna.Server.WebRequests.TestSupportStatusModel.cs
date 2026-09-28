using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public sealed class TestSupportStatusModel
{
	private string <Environment>k__BackingField;

	private bool <DevTestingEnabled>k__BackingField;

	private string <RunId>k__BackingField;

	private List<TestAccountStatusModel> <Accounts>k__BackingField;

	public string Environment
	{
		get
		{
			return <Environment>k__BackingField;
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

	public bool DevTestingEnabled
	{
		get
		{
			return <DevTestingEnabled>k__BackingField;
		}
		set
		{
			<DevTestingEnabled>k__BackingField = value;
		}
	}

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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<TestAccountStatusModel> Accounts
	{
		get
		{
			return <Accounts>k__BackingField;
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
