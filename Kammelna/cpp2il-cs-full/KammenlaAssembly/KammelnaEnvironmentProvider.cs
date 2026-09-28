using Cpp2ILInjected;
using UnityEngine;

public class KammelnaEnvironmentProvider : ScriptableObject
{
	private ServerEnvironment environment;

	private string localHostURL;

	public string LocalHostURL
	{
		get
		{
			return localHostURL;
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

	public ServerEnvironment Environment => environment;

	public void SetEnvironment(ServerEnvironment value)
	{
		environment = value;
	}

	public KammelnaEnvironmentProvider()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "getSecondRescanTask" + 3400;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
