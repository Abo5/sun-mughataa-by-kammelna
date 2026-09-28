using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public static class ClientCapabilities
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KeyValuePair<ClientCapability, string>, string> <>9__9_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ComputeValue>b__9_1(KeyValuePair<ClientCapability, string> pair)
		{
			//IL_000a: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (string)(nint)intPtr;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public ClientCapability capabilities;

		internal bool <ComputeValue>b__0(KeyValuePair<ClientCapability, string> pair)
		{
			//IL_0010: Expected O, but got I4
			object obj = ~capabilities;
			object obj2 = (object)pair & obj;
			return obj2 == null;
		}
	}

	public const string HEADER_NAME = "X-Km-Caps";

	private static readonly Dictionary<ClientCapability, string> WIRE_TOKENS;

	private static ClientCapability enabled;

	private static string cachedValue;

	public static ClientCapability Enabled
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E844A]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (ClientCapability)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (ClientCapability)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_0078: Expected O, but got I
			//IL_00a8: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			string text = ComputeValue(value);
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+B8]");
			object obj6 = (nint)0 + (nint)16;
			obj6 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static string Value
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E844C]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return (string)0;
		}
	}

	private static string ComputeValue(ClientCapability capabilities)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_02e8: Expected I, but got O
		//IL_0185: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0321: Expected O, but got I
		//IL_0332: Expected I, but got O
		//IL_0350: Expected O, but got I
		//IL_023f: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj7;
		object obj14;
		Func<KeyValuePair<System.Int32Enum, object>, object> selector;
		string separator;
		object obj16;
		string text;
		object obj13;
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
			object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3456;
			object obj5 = (nint)0 + (nint)1112;
			object obj6 = (nint)0 + (nint)3152;
			obj7 = typeof(CardUtils.<>c) + 1760;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			object obj10 = "&action=sign-up" + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<KeyValuePair<System.Int32Enum, object>, bool> func = default(Func<KeyValuePair<System.Int32Enum, object>, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DEA618");
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				obj13 = (nint)0 + (nint)2744;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+8]");
				selector = (Func<KeyValuePair<System.Int32Enum, object>, object>)0;
				separator = (string)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+8]");
				bool flag2 = (nint)0 == 0;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					obj16 = obj13;
					text = (string)obj10;
					goto IL_01ed;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj7;
				obj16 = (nint)0 + (nint)2744;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+8]");
				selector = (Func<KeyValuePair<System.Int32Enum, object>, object>)0;
				text = (string)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+8]");
				bool flag3 = (nint)0 == 0;
				object obj17 = !flag3;
				obj13 = obj16;
				separator = (string)obj10;
				if (obj17 == null)
				{
					goto IL_01ed;
				}
			}
			goto IL_0244;
		}
		return (string)(object)new NullReferenceException();
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v14+B8]");
			obj14 = 0;
		}
		object obj20 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)1104;
		Func<KeyValuePair<System.Int32Enum, object>, object> func2 = default(Func<KeyValuePair<System.Int32Enum, object>, object>);
		func2..ctor(obj14, (IntPtr)obj21);
		object obj22 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v13+B8]");
		object obj23 = (nint)0 + (nint)8;
		obj23 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj16;
		selector = func2;
		separator = text;
		goto IL_0244;
		IL_0244:
		IEnumerable<KeyValuePair<System.Int32Enum, object>> source = default(IEnumerable<KeyValuePair<System.Int32Enum, object>>);
		IEnumerable<object> values = Enumerable.Select(source, selector);
		return string.Join(separator, (IEnumerable<string>)values);
	}

	static ClientCapabilities()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_0178: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object value = "startPosition" + 192;
		object obj2 = (nint)0 + (nint)2080;
		object value2 = "placementId" + 1664;
		object value3 = "alignContent" + 3736;
		object value4 = "com.unity.services.authentication.profile" + 400;
		object value5 = "startPosition" + 552;
		object value6 = "https://www.kammelna.com/Home/Terms" + 1736;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1488;
		dictionary.Add((System.Int32Enum)1, value);
		dictionary.Add((System.Int32Enum)2, value2);
		dictionary.Add((System.Int32Enum)4, value3);
		dictionary.Add((System.Int32Enum)8, value4);
		dictionary.Add((System.Int32Enum)16, value5);
		dictionary.Add((System.Int32Enum)32, value6);
		object obj4 = obj3;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6+B8]");
		object obj7 = 0;
		_ = 63;
		string text = ComputeValue((ClientCapability)63);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+B8]");
		object obj9 = (nint)0 + (nint)16;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
