using System.Buffers.Text;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;

namespace Kammelna.Server.WebRequests;

public class ResetFeaturedSlotRequest : BaseWebRequest<bool>
{
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
			object obj2 = "alignContent" + 1312;
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

	protected override void OnSuccess()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		base.OnSuccess();
		SFS.SendRefreshInventory();
		User mySelf = SFS.MySelf;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RaiseFeaturedSlotChanged(intDbId, null);
		SFS.SendRefreshStatus();
		PlayerProfilesHandler.RemoveMyselfFromCache();
	}
}
