using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class FindFriendRequest : BaseWebRequest<PlayerProfileModel>
{
	private readonly string <CodeOrEmail>k__BackingField;

	protected override HttpMethod Method => HttpMethod.GET;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_008b: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "alignContent" + 1176;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2 + <CodeOrEmail>k__BackingField;
		}
	}

	public string CodeOrEmail => <CodeOrEmail>k__BackingField;

	public FindFriendRequest(string codeOrEmail)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		((BaseWebRequest<object>)(object)this)..ctor();
		object obj = this + 48;
		obj = codeOrEmail;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
