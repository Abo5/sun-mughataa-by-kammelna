using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class GetWeeklyPersonalizedStatsList : BaseWebRequest<PersonalizedStatReport>
{
	private readonly Games _game;

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
			object obj2 = "alignContent" + 1544;
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
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, object> dictionary = default(Dictionary<object, object>);
			dictionary..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			if (dictionary != null)
			{
				object key = "fetch_products" + 2352;
				object value = default(object);
				dictionary.Add(key, value);
				return (Dictionary<string, object>)(object)dictionary;
			}
			return (Dictionary<string, object>)(object)new NullReferenceException();
		}
	}

	public GetWeeklyPersonalizedStatsList(Games game)
	{
		((BaseWebRequest<object>)(object)this)..ctor();
		_game = game;
	}
}
