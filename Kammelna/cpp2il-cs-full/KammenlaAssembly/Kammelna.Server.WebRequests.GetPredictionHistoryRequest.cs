using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class GetPredictionHistoryRequest : BaseWebRequest<List<UserMatchPredictionModel>>
{
	private int <Page>k__BackingField;

	public int Page
	{
		get
		{
			return <Page>k__BackingField;
		}
		set
		{
			<Page>k__BackingField = value;
		}
	}

	protected override HttpMethod Method => HttpMethod.GET;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object format = "alignContent" + 1384;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			object obj4 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			return backendURL + text;
		}
	}

	public GetPredictionHistoryRequest(int page)
	{
		((BaseWebRequest<object>)(object)this)..ctor();
		<Page>k__BackingField = page;
	}
}
