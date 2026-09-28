using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Server.Models;

namespace Kammelna.Server.WebRequests;

public class GetStoreHomePageRequest : BaseWebRequest<StoreHomePageViewModel>
{
	protected override HttpMethod Method => HttpMethod.GET;

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
			object obj2 = "alignContent" + 1264;
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

	protected override Dictionary<string, object> QueryParams
	{
		get
		{
			FilterableClientModel filterableClientModel = FilterableClientModel.Current();
			if (filterableClientModel != null)
			{
				return filterableClientModel.ToQueryParams();
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	protected override void OnSuccess()
	{
		//IL_0011: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.GetStoreHomePageRequest)+20]");
		if (((KammelnaResponseModel<object>)0).CachedModelUpdated)
		{
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Store.HasNewStoreSinceLastVisit = true;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Store.HasNewStoreSinceLastVisit = true;
		}
	}

	public GetStoreHomePageRequest()
	{
		((BaseWebRequest<object>)(object)this)..ctor();
	}
}
