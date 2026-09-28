using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server;

public static class Coordinator
{
	public static class Scopes
	{
		public const string CLAN = "clan";
	}

	public static class Variables
	{
		public const string VAULT_BALANCE = "vault_balance";
	}

	private static CoordinatorVariableBinder _binder;

	public static CoordinatorVariableBinder Binder
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (CoordinatorVariableBinder)0;
		}
	}

	public static void InitializeBinding()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3176;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CoordinatorVariableBinder coordinatorVariableBinder = default(CoordinatorVariableBinder);
		coordinatorVariableBinder..ctor();
		object obj3 = obj2;
		object obj4 = coordinatorVariableBinder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
