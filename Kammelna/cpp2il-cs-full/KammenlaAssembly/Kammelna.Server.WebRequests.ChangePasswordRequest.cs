using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class ChangePasswordRequest : JsonWebRequest<ChangePasswordRequestModel, bool>
{
	private readonly ChangePasswordRequestModel <PostData>k__BackingField;

	protected override HttpMethod Method => HttpMethod.PUT;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0085: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = "alignContent" + 1688;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2;
		}
	}

	protected override ChangePasswordRequestModel PostData => <PostData>k__BackingField;

	public ChangePasswordRequest(string oldPassword, string newPassword)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		object obj = (nint)0 + (nint)208;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj3 + 16;
		obj4 = oldPassword;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3 + 24;
		obj5 = newPassword;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = this + 48;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
