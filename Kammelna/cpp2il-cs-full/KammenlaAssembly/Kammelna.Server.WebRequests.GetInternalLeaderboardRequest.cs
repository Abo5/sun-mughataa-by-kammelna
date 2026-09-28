using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

namespace Kammelna.Server.WebRequests;

public class GetInternalLeaderboardRequest : BaseWebRequest<List<InternalLeaderboardEntryModel>>
{
	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

	private readonly InternalLeaderboardKind <Kind>k__BackingField;

	private readonly Games <Game>k__BackingField;

	private readonly int <ClanId>k__BackingField;

	protected override HttpMethod Method => HttpMethod.GET;

	public override string EndPoint
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00ba: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.IOAsyncCallback) + 3552;
			object format = "alignContent" + 1072;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string backendURL = Config.BackendURL;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			return backendURL + text;
		}
	}

	protected override Dictionary<string, object> QueryParams => <QueryParams>k__BackingField;

	public InternalLeaderboardKind Kind => <Kind>k__BackingField;

	public Games Game => <Game>k__BackingField;

	public int ClanId => <ClanId>k__BackingField;

	public GetInternalLeaderboardRequest(InternalLeaderboardKind kind, Games game, int clanId)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3776;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		((BaseWebRequest<object>)(object)this)..ctor();
		<Kind>k__BackingField = kind;
		<Game>k__BackingField = game;
		<ClanId>k__BackingField = clanId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object key = "fetch_products" + 2352;
		object obj4 = (nint)0 + (nint)56;
		object key2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3464;
		object value = default(object);
		dictionary.set_Item(key, value);
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.set_Item(key2, value2);
		object obj6 = this + 48;
		obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
