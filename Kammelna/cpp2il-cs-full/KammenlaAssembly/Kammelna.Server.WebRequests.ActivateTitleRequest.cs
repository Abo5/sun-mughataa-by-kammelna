using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class ActivateTitleRequest : BaseWebRequest<bool>
{
	private readonly string <TitleId>k__BackingField;

	protected override HttpMethod Method => HttpMethod.PUT;

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
			object obj2 = "alignContent" + 1656;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			return backendURL + (string)obj2 + <TitleId>k__BackingField;
		}
	}

	public string TitleId => <TitleId>k__BackingField;

	public ActivateTitleRequest(string titleId)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		object obj = this + 48;
		obj = titleId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void OnSuccess()
	{
		base.OnSuccess();
		SFS.SendRefreshStatus();
	}
}
