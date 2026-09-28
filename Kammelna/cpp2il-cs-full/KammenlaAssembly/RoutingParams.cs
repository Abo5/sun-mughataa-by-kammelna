using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Firebase.Messaging;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

[Serializable]
public class RoutingParams
{
	public string MessageTitle;

	public string MessageBody;

	public RoutingCommand Command;

	public string Payload;

	public Games Game;

	private const string TitleKey = "title";

	private const string BodyKey = "body";

	private const string CommandKey = "command";

	private const string PayloadKey = "payload";

	private const string GameKey = "game";

	public RoutingParams(MessageReceivedEventArgs e)
	{
		//IL_0036: Expected O, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e0: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d2: Expected I, but got O
		//IL_02e2: Expected O, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_031d: Expected O, but got I
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03c4: Expected I, but got O
		//IL_03d4: Expected O, but got I
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0651: Expected O, but got I
		//IL_065d: Expected O, but got I
		//IL_0676: Expected O, but got I4
		//IL_0686: Expected O, but got I
		//IL_06a8: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0513: Expected O, but got I4
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_055f: Expected O, but got I4
		FirebaseMessage <Message>k__BackingField = e.<Message>k__BackingField;
		if ((object)<Message>k__BackingField.<NotificationOpened>k__BackingField == null)
		{
			FirebaseNotification <Notification>k__BackingField = <Message>k__BackingField.<Notification>k__BackingField;
			string text;
			if (<Message>k__BackingField.<Notification>k__BackingField != null)
			{
				text = <Notification>k__BackingField.<Title>k__BackingField;
				if ((object)(this != null) == null)
				{
					goto IL_058f;
				}
			}
			else
			{
				text = null;
			}
			object obj = this + 16;
			obj = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			FirebaseMessage <Message>k__BackingField2 = e.<Message>k__BackingField;
			FirebaseNotification <Notification>k__BackingField2 = <Message>k__BackingField2.<Notification>k__BackingField;
			if (<Message>k__BackingField2.<Notification>k__BackingField != null)
			{
				object obj2 = this + 24;
				obj2 = <Notification>k__BackingField2.<Body>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<Message>k__BackingField = e.<Message>k__BackingField;
				if ((object)(e.<Message>k__BackingField != null) == null)
				{
					goto IL_058f;
				}
			}
			else
			{
				object obj3 = this + 24;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<Message>k__BackingField = e.<Message>k__BackingField;
			}
		}
		IDictionary<string, string> <Data>k__BackingField = <Message>k__BackingField.<Data>k__BackingField;
		object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2520;
		object obj5 = "com.unity.services.authentication.profile" + 120;
		nint num = (nint)<Data>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_026c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v18-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_026c;
		}
		object obj8 = (object)(num + (object)(obj7 + 7)) + 312;
		goto IL_05c5;
		IL_058f:
		throw new NullReferenceException();
		IL_026c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05c5;
		IL_0645:
		object obj9 = (nint)0 + (nint)1016;
		object obj10 = (nint)0 + (nint)992;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v446 @ X0_v12] (should have been resolved before IL gen)");
		object obj11 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v24+98]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
		object obj15 = this + 40;
		object obj16 = default(object);
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = obj15 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D7088C");
		object obj18 = default(object);
		if ((object)((object)(obj18 & 1) != null) == null)
		{
			object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v24+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
		}
		return;
		IL_0450:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0645;
		IL_035e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0605;
		IL_05c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v308 @ X0_v6] (should have been resolved before IL gen)");
		FirebaseMessage <Message>k__BackingField3 = e.<Message>k__BackingField;
		IDictionary<string, string> <Data>k__BackingField2 = <Message>k__BackingField3.<Data>k__BackingField;
		object obj20 = "not" + 3664;
		nint num2 = (nint)<Data>k__BackingField2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_035e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v14 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v13-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_035e;
		}
		object obj23 = (object)(num2 + (object)(obj22 + 7)) + 312;
		goto IL_0605;
		IL_0605:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v379 @ X0_v9] (should have been resolved before IL gen)");
		FirebaseMessage <Message>k__BackingField4 = e.<Message>k__BackingField;
		IDictionary<string, string> <Data>k__BackingField3 = <Message>k__BackingField4.<Data>k__BackingField;
		object obj24 = "fetch_products" + 2352;
		nint num3 = (nint)<Data>k__BackingField3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0450;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v20 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+B0]");
		object obj26 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X10_v8-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj26 += 16;
			obj25--;
			if ((nint)obj25 != 1)
			{
				continue;
			}
			goto IL_0450;
		}
		object obj27 = (object)(num3 + (object)(obj26 + 7)) + 312;
		goto IL_0645;
	}

	public RoutingParams(Dictionary<string, object> e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_012e: Expected I, but got O
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_0283: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_020e: Expected I, but got O
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0259: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		object key = "startPosition" + 3352;
		object obj = (nint)0 + (nint)32;
		if (((Dictionary<object, object>)(object)e).TryGetValue(key, out object value))
		{
			string text = value.ToString();
			object obj2 = this + 16;
			obj2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		if (((Dictionary<object, object>)(object)e).TryGetValue((object)("because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 696), out object value2))
		{
			string text2 = value2.ToString();
			object obj3 = this + 24;
			obj3 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		if (((Dictionary<object, object>)(object)e).TryGetValue((object)("com.unity.services.authentication.profile" + 120), out object value3))
		{
			nint num = (nint)value3;
			string value4 = value3.ToString();
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v35+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int command = Convert.ToInt32(value4);
			Command = (RoutingCommand)command;
		}
		object key2 = "not" + 3664;
		if (((Dictionary<object, object>)(object)e).TryGetValue(key2, out object value5))
		{
			string text3 = value5.ToString();
			object obj5 = this + 40;
			obj5 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		if (((Dictionary<object, object>)(object)e).TryGetValue((object)("fetch_products" + 2352), out object value6))
		{
			nint num2 = (nint)value6;
			string value7 = value6.ToString();
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v28+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int game = Convert.ToInt32(value7);
			Game = (Games)game;
			object obj7 = (nint)0 + (nint)1544;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
			object obj10 = default(object);
			object obj9 = obj10 & 1;
			if (obj9 != null)
			{
				return;
			}
		}
		else
		{
			object obj8 = (nint)0 + (nint)1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D70F1C");
			object obj11 = default(object);
			if ((object)((object)(obj11 & 1) != null) != null)
			{
				return;
			}
		}
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v20+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Game = Preferences.CurrentGame;
	}

	public RoutingParams()
	{
	}

	public RoutingParams(string messageTitle, string messageBody, RoutingCommand command, string payload, Games game)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = this + 16;
		obj = messageTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = messageBody;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 40;
		obj3 = payload;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
