using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Server.Coordinator.Models;

namespace Kammelna.Server.WebRequests;

public class ContentSinceRequest<TModel, TId> : BaseWebRequest<ContentDeltaModel<TModel, TId>>
{
	private readonly string _path;

	private readonly long _cursor;

	protected override HttpMethod Method => HttpMethod.GET;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007e: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.ContentSinceRequest`2<TModel, TId>)+30]");
			return backendURL + (string)0;
		}
	}

	protected override Dictionary<string, object> QueryParams
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_008e: Expected O, but got I4
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			if (dictionary != null)
			{
				object key = "com.unity.services.authentication.profile" + 2624;
				object value = default(object);
				dictionary.set_Item(key, value);
				return (Dictionary<string, object>)(object)dictionary;
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	public ContentSinceRequest(string path, long cursor)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((BaseWebRequest<object>)(object)this)..ctor();
		object obj = this + 48;
		obj = path;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
