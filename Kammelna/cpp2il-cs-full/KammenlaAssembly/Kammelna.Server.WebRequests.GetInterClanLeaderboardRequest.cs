using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;

namespace Kammelna.Server.WebRequests;

public class GetInterClanLeaderboardRequest : BaseWebRequest<List<InterClanLeaderboardEntryModel>>
{
	private readonly Dictionary<string, object> <QueryParams>k__BackingField;

	private readonly DateTime <FirstDayOfTheMonth>k__BackingField;

	private readonly Games <Game>k__BackingField;

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
			object obj2 = "alignContent" + 1064;
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

	public DateTime FirstDayOfTheMonth => <FirstDayOfTheMonth>k__BackingField;

	public Games Game => <Game>k__BackingField;

	public GetInterClanLeaderboardRequest(DateTime firstDayOfTheMonth, Games game)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3768;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2656;
		object obj3 = (nint)0 + (nint)4072;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj5 = typeof(DataRelation) + 712;
		((BaseWebRequest<object>)(object)this)..ctor();
		<FirstDayOfTheMonth>k__BackingField = firstDayOfTheMonth;
		<Game>k__BackingField = game;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = "utf-32" + 2904;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		string value = dateTime.ToString((string)obj7, invariantCulture);
		object key = "fetch_products" + 352;
		object obj9 = (nint)0 + (nint)56;
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object key2 = "fetch_products" + 2352;
		dictionary.set_Item(key, (object)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		dictionary.set_Item(key2, value2);
		object obj11 = this + 48;
		obj11 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
