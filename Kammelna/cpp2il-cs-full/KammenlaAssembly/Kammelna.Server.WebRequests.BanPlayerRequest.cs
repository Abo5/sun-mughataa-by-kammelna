using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class BanPlayerRequest : JsonWebRequest<BanRequestModel, bool>
{
	private readonly BanRequestModel <PostData>k__BackingField;

	protected override HttpMethod Method => HttpMethod.POST;

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
			object obj2 = "alignContent" + 1416;
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

	protected override BanRequestModel PostData => <PostData>k__BackingField;

	public BanPlayerRequest(BanRequestModel banRequestModel)
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D12340");
		object obj2 = this + 48;
		obj2 = banRequestModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4290BB4");
		BanRequestModel postData = PostData;
		SFS.SendRefreshBanStatus(postData.<UserID>k__BackingField);
	}
}
