using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;

public class GetProfileGiftsSendersListRequest : BaseWebRequest<ProfileGiftsSenderModel[]>
{
	private readonly long <UserId>k__BackingField;

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
			object format = "alignContent" + 1728;
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

	public long UserId => <UserId>k__BackingField;

	protected override Dictionary<string, object> QueryParams
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_00ed: Expected O, but got I4
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0077: Expected O, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
			object obj2 = (nint)0 + (nint)4072;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			object obj7 = "Complete" + 3480;
			object obj8 = (nint)0 + (nint)2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			if (dictionary != null)
			{
				object key = "fetch_products" + 2352;
				object value = default(object);
				dictionary.set_Item(key, value);
				return (Dictionary<string, object>)(object)dictionary;
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	public GetProfileGiftsSendersListRequest(long userId)
	{
		((BaseWebRequest<object>)(object)this)..ctor();
		<UserId>k__BackingField = userId;
	}
}
