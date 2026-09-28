using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

namespace Kammelna.Server.WebRequests;

public class SearchClansRequest : BaseWebRequest<ClanSearchResponse>
{
	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

	private readonly ClanSearchRequestModel <Model>k__BackingField;

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
			object obj2 = "alignContent" + 1088;
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

	public ClanSearchRequestModel Model => <Model>k__BackingField;

	public SearchClansRequest(ClanSearchRequestModel model)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		((BaseWebRequest<object>)(object)this)..ctor();
		object obj2 = this + 56;
		obj2 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object value = model.Query;
		object obj3 = 153100288 + 1024;
		if ((object)(model.Query != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X24_v5+90]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+B8]");
			value = 0;
		}
		object key = "placementId" + 1928;
		object obj5 = (nint)0 + (nint)56;
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1368;
		object key2 = "setMimeType" + 3248;
		object key3 = "not" + 3136;
		object key4 = "not" + 3176;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		dictionary.set_Item(key, value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.set_Item(key2, value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value3 = default(object);
		dictionary.set_Item(key3, value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value4 = default(object);
		dictionary.set_Item(key4, value4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value5 = default(object);
		dictionary.set_Item((object)("fetch_products" + 2352), value5);
		object obj8 = this + 48;
		obj8 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
