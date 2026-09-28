using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

namespace Kammelna.Server.WebRequests;

public class GetVaultSupportRequestSupportersRequest : BaseWebRequest<List<ClanVaultSupporterModel>>
{
	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

	private readonly long <FeedId>k__BackingField;

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
			object obj2 = "alignContent" + 960;
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

	protected override Dictionary<string, object> QueryParams => <QueryParams>k__BackingField;

	public long FeedId => <FeedId>k__BackingField;

	public GetVaultSupportRequestSupportersRequest(long feedId)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0035: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3728;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		((BaseWebRequest<object>)(object)this)..ctor();
		<FeedId>k__BackingField = feedId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object key = "destinationTimeZone" + 4080;
		object obj4 = (nint)0 + (nint)56;
		object value = default(object);
		dictionary.set_Item(key, value);
		object obj5 = this + 48;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
