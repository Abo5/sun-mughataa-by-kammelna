using System;
using System.Data;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using SFSLitJson;

namespace Social;

public class TweetModel
{
	public string Id;

	public string UserId;

	public DateTime CreatedAt;

	public string Text;

	public TweetModel(JsonData jsonData)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		object name = "https://www.kammelna.com/Home/Terms" + 424;
		object defaultValue = (nint)0 + (nint)2000;
		base..ctor();
		string text = LitJsonExtensions.Get(jsonData, (string)name, (string)defaultValue);
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object prop_name = "tournament_participate_warning_body_with_tickets_warning_daily" + 3904;
		object name2 = "com.unity.services.authentication.profile" + 1992;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj3 = typeof(DataRelation) + 712;
		string text2 = LitJsonExtensions.Get(jsonData.get_Item((string)prop_name), (string)name, (string)defaultValue);
		object obj4 = this + 24;
		obj4 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string s = LitJsonExtensions.Get(jsonData, (string)name2, (string)defaultValue);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object format = "com.unity.services.authentication.profile" + 3320;
		object name3 = "startPosition" + 2688;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v21+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CreatedAt = DateTime.ParseExact(s, (string)format, invariantCulture);
		string text3 = LitJsonExtensions.Get(jsonData, (string)name3, (string)defaultValue);
		object obj7 = this + 40;
		obj7 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
