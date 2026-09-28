using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class GetUserFriendlyChallenges : BaseWebRequest<FriendlyChallengeEntryModel[]>
{
	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

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
			object format = "alignContent" + 1720;
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

	protected override Dictionary<string, object> QueryParams => <QueryParams>k__BackingField;

	private long UserId => <UserId>k__BackingField;

	public GetUserFriendlyChallenges(long userId, Games game)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3880;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		((BaseWebRequest<object>)(object)this)..ctor();
		<UserId>k__BackingField = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object key = "fetch_products" + 2352;
		object obj4 = (nint)0 + (nint)56;
		object value = default(object);
		dictionary.set_Item(key, value);
		object obj5 = this + 48;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
