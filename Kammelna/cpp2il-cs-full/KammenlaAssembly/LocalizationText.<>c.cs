using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public static class LocalizationText
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, string> <>9__16_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <CleanText>b__16_0(string s)
		{
			if (s != null)
			{
				return s.Trim();
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private static IDictionary<string, string> _content;

	private static string _language;

	private static string Language
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
			object obj = 152981504;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CA8]");
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
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (string)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_014e: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00a1: Expected O, but got I
			//IL_00b9: Expected O, but got I4
			//IL_0186: Expected O, but got I
			//IL_019b: Expected O, but got I
			//IL_00f9: Expected O, but got I4
			//IL_01ba: Expected O, but got I4
			//IL_01c3: Expected O, but got I4
			//IL_01f0: Expected O, but got I
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CA9]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+8]");
			bool flag3 = (string)0 != value;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			string text = value;
			if (obj8 == null)
			{
				return;
			}
			goto IL_00cf;
			IL_00cf:
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v13+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			CreateContent();
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v10+8]");
			bool flag6 = (string)0 != value;
			bool flag7 = !flag6;
			obj9 = 0;
			text = value;
			if (!flag7)
			{
				goto IL_00cf;
			}
		}
	}

	private static IDictionary<string, string> Content
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0146: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_00a9: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01b0: Expected O, but got I
			//IL_02a8: Expected O, but got I4
			//IL_0247: Expected O, but got I4
			//IL_02e8: Expected O, but got I
			//IL_012f: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CB0]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2496;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2496;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v26+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v12+B8]");
			object list = 0;
			object obj10 = obj7;
			bool flag3 = ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, object>>)list);
			bool flag4 = !flag3;
			object obj11 = obj7;
			if (flag4)
			{
				goto IL_00ea;
			}
			goto IL_01eb;
			IL_011f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v22+B8]");
			return (IDictionary<string, string>)0;
			IL_00ea:
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = obj12;
			if (!flag5)
			{
				goto IL_011f;
			}
			goto IL_02c6;
			IL_02c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v3+B8]");
			return (IDictionary<string, string>)0;
			IL_0099:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v26+B8]");
			object list2 = 0;
			obj10 = obj4;
			bool flag6 = ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, object>>)list2);
			bool flag7 = !flag6;
			object obj15 = !flag7;
			obj11 = obj4;
			if (obj15 == null)
			{
				goto IL_00ea;
			}
			goto IL_01eb;
			IL_01eb:
			object obj16 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				CreateContent();
				obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v22+E4]");
				bool flag8 = (nint)0 == 0;
				object obj17 = !flag8;
				if (obj17 != null)
				{
					goto IL_011f;
				}
				obj10 = obj11;
				obj13 = obj12;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				CreateContent();
				obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v22+E4]");
				bool flag9 = (nint)0 == 0;
				object obj18 = !flag9;
				obj10 = obj11;
				obj13 = obj12;
				if (obj18 != null)
				{
					goto IL_011f;
				}
			}
			goto IL_02c6;
		}
	}

	static LocalizationText()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e0: Expected I, but got O
		//IL_00f0: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2752;
		object obj4 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = obj2;
		object obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v5+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1872;
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		nint num = (nint)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v9 (Il2CppClass<System.Object>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v5-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_016c;
		}
		object obj16 = obj15 + 3;
		object obj17 = num + obj16;
		object obj18 = obj17 + 312;
		goto IL_0218;
		IL_016c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0218;
		IL_0218:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v12+8]");
		Action action = default(Action);
		action..ctor(obj11, (IntPtr)0);
		object obj19 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj20 = !flag;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged += action;
	}

	public static string GetText(string key, GameObject go = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0203: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		//IL_0238: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_0134: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0430: Expected O, but got I
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_050b: Expected O, but got I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		object obj = 152981504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CAB]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj4;
		if (obj2 != null)
		{
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			bool flag = key == null;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_0075;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			bool flag2 = key == null;
			object obj5 = !flag2;
			obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0075;
			}
		}
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X9_v11+90]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v12+B8]");
		object obj8 = 0;
		string text = (string)obj8;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		nint num2 = 0;
		string text2 = (string)obj8;
		if (obj10 != null)
		{
			goto IL_00da;
		}
		goto IL_02b8;
		IL_0316:
		object obj13 = default(object);
		object obj12 = obj13 + 7;
		object obj14 = num + obj12;
		object obj15 = obj14 + 312;
		text = text2;
		goto IL_0488;
		IL_01b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IDictionary<string, string> content;
		NullReferenceException ex = (NullReferenceException)content;
		object obj16 = default(object);
		obj15 = obj16;
		goto IL_0488;
		IL_0488:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X8_v2] (should have been resolved before IL gen)");
		string text3 = default(string);
		if (string.IsNullOrEmpty(text3))
		{
			object obj17 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag5 = go;
			object obj20 = "Network Authentication Required" + 1176;
			string text5;
			if (flag5)
			{
				string path = UIExtensions.GetPath(go);
				object obj21 = "&action=sign-up" + 3584;
				string text4 = (string)obj21 + path;
				text5 = text4;
			}
			else
			{
				object obj22 = (nint)0 + (nint)2000;
				text5 = (string)obj22;
			}
			string text6 = (string)obj20 + text + text5;
			object obj23 = typeof(DataRelation) + 856;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			object message = text6;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text6;
			}
			Debug.LogWarning(message, go);
			return text;
		}
		return text3;
		IL_0075:
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		bool flag7 = (nint)0 == 0;
		text = key;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v56+E4]");
		num2 = 0;
		text2 = key;
		if (!flag7)
		{
			goto IL_00da;
		}
		goto IL_02b8;
		IL_02b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		content = Content;
		bool flag8 = content == null;
		object obj26 = !flag8;
		text = text2;
		num = num2;
		if (obj26 != null)
		{
			goto IL_0108;
		}
		goto IL_0308;
		IL_00da:
		content = Content;
		bool flag9 = content == null;
		text2 = text;
		if (!flag9)
		{
			goto IL_0108;
		}
		goto IL_0308;
		IL_0308:
		ex = new NullReferenceException();
		goto IL_0316;
		IL_0108:
		object obj27 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2520;
		num = (nint)content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v2-8]");
			bool flag10 = 0 == (nint)obj27;
			ex = (NullReferenceException)content;
			text2 = text;
			if (flag10)
			{
				break;
			}
			obj13 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_01b0;
		}
		goto IL_0316;
	}

	public static string GetText(string key, long n)
	{
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_0026: Expected O, but got I8
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0325: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		bool flag = n < 3;
		object obj2 = !flag;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction SMULH not yet implemented.\"");
			object obj3 = -6640827866535438581L + n;
			object obj4 = obj3 >> 6;
			object obj5 = obj4 + obj3;
			object obj6 = obj5 * 100;
			object obj7 = n - obj6;
			object obj8 = obj7 - 3;
			object obj9 = obj7 - 10;
			bool flag2 = (nint)obj9 < 0;
			bool flag3 = obj9 == null;
			object obj10 = obj7 ^ 0xA;
			object obj11 = obj7 ^ obj9;
			object obj12 = obj10 & obj11;
			bool flag4 = (nint)obj12 < 0;
			bool flag5 = flag2 == flag4;
			object obj13 = !flag5;
			object obj14 = obj13 | flag3;
			object obj15 = ~obj14;
			if (obj15 == null)
			{
			}
			bool flag6 = (nint)obj8 < 8;
			object obj16 = !flag6;
			object obj17 = ~obj16;
			object obj18 = ~obj17;
			if (obj18 != null)
			{
			}
		}
		int num = default(int);
		string text = num.ToString();
		string key2 = key + text;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = Exists(key2);
			bool flag8 = !flag7;
			object obj20 = !flag8;
			if (obj20 == null)
			{
				goto IL_0151;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Exists(key2))
			{
				goto IL_0151;
			}
		}
		string text2 = num.ToString();
		string text3 = key + text2;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v6+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		string s = text3;
		object obj23 = 0;
		string text4 = text2;
		string text5 = text3;
		if (obj22 != null)
		{
			goto IL_01a0;
		}
		goto IL_026c;
		IL_026c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		s = text5;
		goto IL_01a0;
		IL_0151:
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v6+E4]");
		bool flag10 = (nint)0 == 0;
		s = key;
		obj23 = 0;
		text4 = text;
		text5 = key;
		if (!flag10)
		{
			goto IL_01a0;
		}
		goto IL_026c;
		IL_01a0:
		return <GetText>g__SafeFormat|7_0(s, n);
	}

	public static string GetOrdinalText(string key, int n)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		int num = default(int);
		string text = num.ToString();
		string key2 = key + text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			if (Exists(key2))
			{
				goto IL_0043;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = Exists(key2);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0043;
			}
		}
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = GetText(key);
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format(text2, arg);
		IL_0043:
		string text3 = num.ToString();
		string key3 = key + text3;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return GetText(key3);
	}

	public static string GetLanguage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_01fd: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4587]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+8]");
		return (string)0;
		IL_01ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+8]");
		return (string)0;
		IL_00b0:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = obj11;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4587]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_0188:
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		obj12 = obj11;
		if (obj14 != null)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
	}

	public static void SetLanguage(string language)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CAE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Language = language;
		return;
		IL_007d:
		Language = language;
	}

	public static bool Exists(string key)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_029c: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_0195: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CAF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_019f;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		nint num2 = 0;
		if (!flag)
		{
			goto IL_00a5;
		}
		goto IL_0205;
		IL_0205:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IDictionary<string, string> content = Content;
		bool flag2 = content == null;
		object obj6 = !flag2;
		num = num2;
		if (obj6 != null)
		{
			goto IL_00cb;
		}
		goto IL_024d;
		IL_00a5:
		content = Content;
		if (content != null)
		{
			goto IL_00cb;
		}
		goto IL_024d;
		IL_00cb:
		object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2520;
		num = (nint)content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v2 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v2 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v2 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.String>>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		goto IL_02a6;
		IL_024d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_025b;
		IL_02a6:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X10_v1-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		goto IL_025b;
		IL_025b:
		object obj10 = obj9 + 4;
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v148 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_02a6;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj16 = default(object);
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v169 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_019f;
		IL_019f:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v17+E4]");
		num2 = 0;
		if (obj18 != null)
		{
			goto IL_00a5;
		}
		goto IL_0205;
	}

	private unsafe static void ParseSection(XmlNode xNode)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_13e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e7: Expected O, but got Unknown
		//IL_1417: Expected O, but got I4
		//IL_006c: Expected O, but got Ref
		//IL_008a: Expected I, but got O
		//IL_009a: Expected O, but got I
		//IL_00d4: Expected I, but got O
		//IL_00e4: Expected O, but got I
		//IL_0104: Expected O, but got Ref
		//IL_1297: Expected I4, but got O
		//IL_12ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Expected O, but got Unknown
		//IL_1265: Expected O, but got Ref
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_18e4: Expected O, but got I4
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_12ff: Expected O, but got I
		//IL_0278: Expected O, but got I4
		//IL_138e: Expected O, but got I4
		//IL_1472: Expected O, but got I
		//IL_1485: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Expected O, but got Unknown
		//IL_14a1: Expected O, but got Ref
		//IL_0224: Expected O, but got I
		//IL_1926: Expected O, but got I
		//IL_133a: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_13b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_1348: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Expected O, but got Unknown
		//IL_1356: Unknown result type (might be due to invalid IL or missing references)
		//IL_135b: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_14f5: Expected O, but got I
		//IL_032d: Expected O, but got I
		//IL_03c4: Expected I, but got O
		//IL_03ed: Expected O, but got I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0421: Expected O, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_01a4: Expected O, but got I
		//IL_04ab: Expected I, but got O
		//IL_04bb: Expected O, but got I
		//IL_1238: Expected O, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_0504: Expected I, but got O
		//IL_0514: Expected O, but got I
		//IL_0576: Expected O, but got I4
		//IL_058b: Expected O, but got I
		//IL_064d: Expected I, but got O
		//IL_065d: Expected O, but got I
		//IL_06ec: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_1551: Expected O, but got I
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_1569: Expected O, but got Unknown
		//IL_0698: Expected O, but got I
		//IL_0fcf: Expected O, but got I4
		//IL_17c3: Expected O, but got Ref
		//IL_17d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d7: Expected O, but got Unknown
		//IL_17f1: Expected O, but got Ref
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_114d: Expected O, but got I4
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_124f: Expected O, but got I4
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe8: Expected O, but got Unknown
		//IL_1000: Expected O, but got I
		//IL_0736: Expected I, but got O
		//IL_0746: Expected O, but got I
		//IL_108f: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_1893: Expected O, but got I
		//IL_103b: Expected O, but got I
		//IL_15bb: Expected O, but got I
		//IL_0781: Expected O, but got I
		//IL_116c: Expected O, but got I4
		//IL_10b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b7: Expected O, but got Unknown
		//IL_0818: Expected I, but got O
		//IL_0841: Expected O, but got I4
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Expected O, but got Unknown
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Expected O, but got Unknown
		//IL_112e: Expected O, but got I4
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected O, but got Unknown
		//IL_0875: Expected O, but got I
		//IL_08d3: Expected O, but got I4
		//IL_15f2: Expected O, but got I
		//IL_1607: Expected O, but got I
		//IL_162b: Expected O, but got I4
		//IL_163b: Expected O, but got I
		//IL_0900: Expected I, but got O
		//IL_0910: Expected O, but got I
		//IL_118b: Expected O, but got I4
		//IL_1194: Expected O, but got I4
		//IL_0942: Expected I, but got O
		//IL_0974: Expected I, but got O
		//IL_0984: Expected O, but got I
		//IL_0603: Expected O, but got I4
		//IL_11ab: Expected O, but got I4
		//IL_11b4: Expected O, but got I4
		//IL_09b6: Expected I, but got O
		//IL_09c6: Expected O, but got I
		//IL_09f3: Expected O, but got I4
		//IL_0a01: Expected O, but got I4
		//IL_0d23: Expected O, but got I4
		//IL_0a17: Expected I, but got O
		//IL_0a27: Expected O, but got I
		//IL_0ab6: Expected O, but got I4
		//IL_167e: Expected O, but got I
		//IL_1691: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Expected O, but got Unknown
		//IL_0a62: Expected O, but got I
		//IL_1825: Unknown result type (might be due to invalid IL or missing references)
		//IL_182a: Expected O, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected O, but got Unknown
		//IL_1769: Expected O, but got I4
		//IL_0f9a: Expected O, but got I4
		//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected O, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_11cb: Expected O, but got I4
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Expected O, but got Unknown
		//IL_0dca: Expected O, but got I
		//IL_0b01: Expected I, but got O
		//IL_0b11: Expected O, but got I
		//IL_0e59: Expected O, but got I4
		//IL_0ba0: Expected O, but got I4
		//IL_0ecb: Expected O, but got I4
		//IL_17ac: Expected O, but got I
		//IL_0e05: Expected O, but got I
		//IL_16e8: Expected O, but got I
		//IL_0b4c: Expected O, but got I
		//IL_0fb9: Expected O, but got I4
		//IL_0f16: Expected O, but got I4
		//IL_0e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected O, but got Unknown
		//IL_0be3: Expected I, but got O
		//IL_0c0c: Expected O, but got I4
		//IL_0bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Expected O, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected O, but got Unknown
		//IL_0f49: Expected O, but got I4
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e26: Expected O, but got Unknown
		//IL_0f7b: Expected O, but got I4
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		//IL_0c40: Expected O, but got I
		//IL_0c9f: Expected O, but got I4
		//IL_0d5c: Expected O, but got I4
		//IL_0d94: Expected O, but got I4
		//IL_0ced: Expected O, but got I4
		//IL_172a: Expected O, but got I4
		//IL_1738: Expected O, but got I4
		//IL_1741: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		_ = 0;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		bool flag2 = xNode == null;
		Games games = default(Games);
		string text = (string)(&games);
		games = currentGame;
		object obj7;
		object obj8;
		object obj9;
		object obj10;
		object obj11;
		object obj12 = default(object);
		IEnumerator enumerator2;
		IEnumerator enumerator3;
		XmlNode xmlNode = default(XmlNode);
		object obj13;
		object obj21;
		object obj22;
		object obj14 = default(object);
		if (!flag2)
		{
			nint num = (nint)xNode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v16 (Il2CppClass<System.Xml.XmlNode>)+1F0]");
			text = (string)0;
			XmlNodeList childNodes = xNode.ChildNodes;
			bool flag3 = childNodes == null;
			games = currentGame;
			if (!flag3)
			{
				nint num2 = (nint)childNodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v17 (Il2CppClass<System.Xml.XmlNodeList>)+1C0]");
				text = (string)0;
				IEnumerator enumerator = childNodes.GetEnumerator();
				obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
				if (enumerator == null)
				{
					goto IL_11ee;
				}
				obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				obj9 = typeof(UsageHint) + 3672;
				obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				obj11 = "DNQUALIFIER" + 2040;
				obj12 = 0;
				enumerator2 = null;
				enumerator3 = null;
				obj13 = obj14;
				IEnumerator enumerator4 = enumerator;
				object obj20 = default(object);
				while (true)
				{
					nint num3 = (nint)enumerator4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0265;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj16 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v79-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj16 += 16;
						obj15--;
						if ((nint)obj15 != 1)
						{
							continue;
						}
						goto IL_0265;
					}
					object obj17 = num3 + obj16;
					object obj18 = obj17 + 312;
					obj14 = obj13;
					goto IL_1462;
					IL_1462:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v40+8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v717 @ X0_v40] (should have been resolved before IL gen)");
					object obj19 = obj20 & 1;
					bool flag4 = obj19 == null;
					obj21 = (object)(&obj12);
					obj22 = obj7;
					games = Games.Baloot;
					if (flag4)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
					if ((nint)0 == 0)
					{
						goto IL_120a;
					}
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v26+12E]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v26+12E]");
					if ((nint)0 == 0)
					{
						goto IL_036e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v26+B0]");
					object obj26 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X10_v74-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj26 += 16;
						obj25--;
						if ((nint)obj25 != 1)
						{
							continue;
						}
						goto IL_036e;
					}
					object obj27 = obj26 + 1;
					object obj28 = obj24 + obj27;
					object obj29 = obj28 + 312;
					goto IL_14e5;
					IL_14e5:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X0_v44+8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1013 @ X0_v44] (should have been resolved before IL gen)");
					if (xmlNode != null)
					{
						text = (string)obj9;
						nint num4 = (nint)xmlNode;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v29 (Il2CppClass<System.Xml.XmlNode>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
						bool flag5 = num5 < 0;
						object obj30 = !flag5;
						object obj31 = ~obj30;
						if (obj31 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v29 (Il2CppClass<System.Xml.XmlNode>)+C8]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
							object obj32 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1058 @ X9_v23-8]");
							if (0 == (nint)text)
							{
								string localName = xmlNode.LocalName;
								object obj33 = "SubscribeGroup request Error" + 3648;
								text = (string)obj33;
								bool flag6 = localName == (string)obj33;
								bool flag7 = !flag6;
								obj13 = 0;
								if (flag7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
									enumerator4 = (IEnumerator)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
									bool flag8 = (nint)0 == 0;
									obj14 = obj13;
									if (!flag8)
									{
										continue;
									}
									goto IL_11ee;
								}
								goto IL_04a3;
							}
						}
						goto IL_11e0;
					}
					goto IL_11fc;
					IL_036e:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj14 = 1;
					goto IL_14e5;
					IL_0265:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj14 = 0;
					goto IL_1462;
				}
				goto IL_129c;
			}
		}
		goto IL_1425;
		IL_11ee:
		NullReferenceException ex = new NullReferenceException();
		goto IL_125c;
		IL_123d:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		object obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_04a3:
		nint num7 = (nint)xmlNode;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v32 (Il2CppClass<System.Xml.XmlNode>)+220]");
		text = (string)0;
		XmlAttributeCollection attributes = xmlNode.Attributes;
		XmlNode xmlNode3;
		object obj97;
		if (attributes != null)
		{
			object obj35 = "m_StencilDeferredPS" + 2872;
			text = (string)obj35;
			nint num8 = (nint)attributes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v35 (Il2CppClass<System.Xml.XmlAttributeCollection>)+190]");
			obj14 = 0;
			XmlNode namedItem = attributes.GetNamedItem((string)obj35);
			if (namedItem != null)
			{
				string value = namedItem.Value;
				IEnumerator enumerator5 = xmlNode.GetEnumerator();
				bool flag9 = enumerator5 == null;
				object obj36 = !flag9;
				text = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v35 (Il2CppClass<System.Xml.XmlAttributeCollection>)+190]");
				obj13 = 0;
				IEnumerator enumerator6 = enumerator5;
				if (obj36 == null)
				{
					goto IL_05a1;
				}
				XmlNode xmlNode2 = default(XmlNode);
				XmlNode xmlNode5 = default(XmlNode);
				object obj61 = default(object);
				object obj63 = default(object);
				object obj70 = default(object);
				object obj82 = default(object);
				object obj78;
				while (true)
				{
					nint num9 = (nint)enumerator6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v40 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v40 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_06d9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v40 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj38 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X10_v67-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj38 += 16;
						obj37--;
						if ((nint)obj37 != 1)
						{
							continue;
						}
						goto IL_06d9;
					}
					object obj39 = num9 + obj38;
					object obj40 = obj39 + 312;
					goto IL_1541;
					IL_07c2:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj13 = 1;
					goto IL_15ab;
					IL_15ab:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1323 @ X0_v76+8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1323 @ X0_v76] (should have been resolved before IL gen)");
					XmlNode xmlNode4;
					string text2;
					if (xmlNode2 != null)
					{
						text = (string)obj9;
						nint num10 = (nint)xmlNode2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v59 (Il2CppClass<System.Xml.XmlNode>)+130]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
						bool flag10 = num11 < 0;
						object obj41 = !flag10;
						object obj42 = ~obj41;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v59 (Il2CppClass<System.Xml.XmlNode>)+C8]");
							nint num12 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
							object obj43 = num12 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X9_v45-8]");
							if (0 == (nint)text)
							{
								string localName2 = xmlNode2.LocalName;
								object obj44 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1410 @ X0_v85+E4]");
								bool flag11 = (nint)0 == 0;
								object obj45 = !flag11;
								if (obj45 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj44 = obj10;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1410 @ X0_v85+B8]");
								object obj46 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v61+8]");
								bool flag12 = localName2 == (string)0;
								bool flag13 = !flag12;
								text2 = localName2;
								obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v61+8]");
								xmlNode3 = (XmlNode)0;
								if (!flag13)
								{
									nint num13 = (nint)xmlNode2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v62 (Il2CppClass<System.Xml.XmlNode>)+1F0]");
									text = (string)0;
									XmlNodeList childNodes2 = xmlNode2.ChildNodes;
									if (childNodes2 == null)
									{
										goto IL_1179;
									}
									nint num14 = (nint)childNodes2;
									int count = childNodes2.Count;
									if (count >= 2)
									{
										nint num15 = (nint)xmlNode2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v64 (Il2CppClass<System.Xml.XmlNode>)+1F0]");
										text = (string)0;
										XmlNodeList childNodes3 = xmlNode2.ChildNodes;
										if (childNodes3 != null)
										{
											nint num16 = (nint)childNodes3;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1440 @ X8_v65 (Il2CppClass<System.Xml.XmlNodeList>)+1C0]");
											text = (string)0;
											IEnumerator enumerator7 = childNodes3.GetEnumerator();
											bool flag14 = enumerator7 == null;
											IEnumerator enumerator8 = enumerator7;
											obj13 = 0;
											xmlNode4 = null;
											obj14 = 0;
											if (flag14)
											{
												goto IL_0d11;
											}
											while (true)
											{
												nint num17 = (nint)enumerator8;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v70 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
												object obj47 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v70 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0aa3;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v70 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
												object obj48 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1533 @ X10_v56-8]");
													if (0 == (nint)obj8)
													{
														break;
													}
													obj48 += 16;
													obj47--;
													if ((nint)obj47 != 1)
													{
														continue;
													}
													goto IL_0aa3;
												}
												object obj49 = num17 + obj48;
												object obj50 = obj49 + 312;
												goto IL_166e;
												IL_16d8:
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1654 @ X0_v117+8]");
												text = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1654 @ X0_v117] (should have been resolved before IL gen)");
												if (xmlNode5 != null)
												{
													text = (string)obj9;
													nint num18 = (nint)xmlNode5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v88 (Il2CppClass<System.Xml.XmlNode>)+130]");
													nint num19 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
													bool flag15 = num19 < 0;
													object obj51 = !flag15;
													object obj52 = ~obj51;
													if (obj52 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v88 (Il2CppClass<System.Xml.XmlNode>)+C8]");
														nint num20 = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X1_v2 (System.String)+130]");
														object obj53 = num20 + 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1726 @ X9_v69-8]");
														if (0 == (nint)text)
														{
															string name = xmlNode5.Name;
															bool flag16 = name == friendlyName;
															bool flag17 = !flag16;
															object obj54 = !flag17;
															if (obj54 == null)
															{
																string name2 = xmlNode5.Name;
																text = (string)obj11;
																bool flag18 = name2 == (string)obj11;
																bool flag19 = !flag18;
																object obj55 = !flag19;
																object obj56 = ~obj55;
																if (obj56 == null)
																{
																	xmlNode4 = xmlNode5;
																}
																bool flag20 = 0 == 0;
																object obj57 = !flag20;
																enumerator8 = null;
																obj13 = 0;
																obj14 = 0;
																if (obj57 != null)
																{
																	continue;
																}
																goto IL_0d11;
															}
															object obj58 = obj10;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ X0_v126+E4]");
															bool flag21 = (nint)0 == 0;
															object obj59 = !flag21;
															if (obj59 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
															}
															AddContent(value, xmlNode5);
															text2 = null;
															obj13 = 0;
															xmlNode4 = null;
															goto IL_1816;
														}
													}
													goto IL_0f69;
												}
												goto IL_0fa7;
												IL_0e46:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
												obj13 = 0;
												object obj60 = obj61;
												goto IL_179c;
												IL_179c:
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1681 @ X8_v81+8]");
												xmlNode3 = (XmlNode)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1681 @ X8_v81] (should have been resolved before IL gen)");
												goto IL_174f;
												IL_0aa3:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
												obj13 = 0;
												goto IL_166e;
												IL_166e:
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X0_v99+8]");
												text = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1548 @ X0_v99] (should have been resolved before IL gen)");
												object obj62 = obj63 & 1;
												if (obj62 != null)
												{
													if (0 == 0)
													{
														break;
													}
													nint num21 = (nint)enumerator2;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v85 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
													object obj64 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v85 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
													if ((nint)0 == 0)
													{
														goto IL_0b8d;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1556 @ X8_v85 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
													object obj65 = (nint)0 + (nint)8;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X10_v51-8]");
														if (0 == (nint)obj8)
														{
															break;
														}
														obj65 += 16;
														obj64--;
														if ((nint)obj64 != 1)
														{
															continue;
														}
														goto IL_0b8d;
													}
													object obj66 = obj65 + 1;
													object obj67 = num21 + obj66;
													object obj68 = obj67 + 312;
													goto IL_16d8;
												}
												text2 = null;
												goto IL_1816;
												IL_0b8d:
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
												obj13 = 1;
												goto IL_16d8;
												IL_1816:
												object obj69 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
												xmlNode3 = (XmlNode)obj69;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												if (obj70 == null)
												{
													goto IL_174f;
												}
												object obj71 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
												object obj72 = obj70;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v80+12E]");
												object obj73 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v80+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0e46;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X8_v80+B0]");
												object obj74 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1740 @ X10_v42-8]");
													if (0 == (nint)obj71)
													{
														break;
													}
													obj74 += 16;
													obj73--;
													if ((nint)obj73 != 1)
													{
														continue;
													}
													goto IL_0e46;
												}
												object obj75 = obj72 + obj74;
												obj60 = obj75 + 312;
												goto IL_179c;
											}
											goto IL_0f88;
										}
										goto IL_1199;
									}
									object obj76 = obj10;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X0_v139+E4]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									AddContent(value, xmlNode2);
									text2 = localName2;
									obj14 = 0;
									xmlNode3 = xmlNode2;
								}
								goto IL_0610;
							}
						}
						goto IL_111c;
					}
					goto IL_115a;
					IL_174f:
					bool flag22 = text2 == null;
					object obj77 = !flag22;
					if (obj77 == null)
					{
						bool flag23 = xmlNode4 == null;
						obj78 = 10;
						obj12 = obj70;
						obj14 = obj13;
						if (!flag23)
						{
							object obj79 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1766 @ X0_v108+E4]");
							bool flag24 = (nint)0 == 0;
							object obj80 = !flag24;
							if (obj80 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							AddContent(value, xmlNode4);
							obj78 = 10;
							obj12 = obj70;
							obj14 = obj13;
							xmlNode3 = xmlNode4;
						}
						goto IL_0610;
					}
					goto IL_11b9;
					IL_06d9:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj13 = 0;
					goto IL_1541;
					IL_1541:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X0_v62+8]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1196 @ X0_v62] (should have been resolved before IL gen)");
					object obj81 = obj82 & 1;
					if (obj81 == null)
					{
						break;
					}
					if (enumerator3 == null)
					{
						goto IL_113b;
					}
					nint num22 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v56 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v56 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_07c2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ X8_v56 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj84 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X10_v62-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj84 += 16;
						obj83--;
						if ((nint)obj83 != 1)
						{
							continue;
						}
						goto IL_07c2;
					}
					object obj85 = obj84 + 1;
					object obj86 = num22 + obj85;
					object obj87 = obj86 + 312;
					goto IL_15ab;
					IL_0610:
					bool flag25 = enumerator3 == null;
					text = (string)(object)xmlNode3;
					obj13 = obj14;
					enumerator6 = enumerator3;
					if (!flag25)
					{
						continue;
					}
					goto IL_05a1;
				}
				obj78 = 2;
				object obj88 = (object)(&enumerator3);
				object obj89 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				text = (string)obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj90 = (object)(&obj12);
				object obj91 = default(object);
				obj90 = obj91;
				if (obj91 != null)
				{
					object obj92 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					object obj93 = obj91;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v51+12E]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v51+12E]");
					if ((nint)0 == 0)
					{
						goto IL_107c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1295 @ X8_v51+B0]");
					object obj95 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1378 @ X10_v27-8]");
						if (0 == (nint)obj92)
						{
							break;
						}
						obj95 += 16;
						obj94--;
						if ((nint)obj94 != 1)
						{
							continue;
						}
						goto IL_107c;
					}
					object obj96 = obj93 + obj95;
					obj97 = obj96 + 312;
					goto IL_1883;
				}
				goto IL_123d;
			}
			NullReferenceException ex3 = new NullReferenceException();
		}
		else
		{
			NullReferenceException ex4 = new NullReferenceException();
			obj14 = 0;
		}
		goto IL_125c;
		IL_0f69:
		InvalidCastException ex5 = new InvalidCastException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_107c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj13 = 0;
		object obj98 = default(object);
		obj97 = obj98;
		goto IL_1883;
		IL_1179:
		NullReferenceException ex6 = new NullReferenceException();
		obj34 = 0;
		obj14 = 0;
		goto IL_125c;
		IL_18ca:
		bool flag26 = games == Games.Baloot;
		object obj99 = !flag26;
		if (obj99 == null)
		{
			return;
		}
		OutOfMemoryException ex7 = new OutOfMemoryException();
		OutOfMemoryException ex8 = ex7;
		goto IL_1944;
		IL_129c:
		object obj100 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		text = (string)obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj101 = default(object);
		obj21 = obj101;
		if (obj101 == null)
		{
			goto IL_18ca;
		}
		object obj102 = obj101;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v11+12E]");
		object obj103 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_137b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v11+B0]");
		object obj104 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X10_v9-8]");
			if (0 == (nint)obj100)
			{
				break;
			}
			obj104 += 16;
			obj103--;
			if ((nint)obj103 != 1)
			{
				continue;
			}
			goto IL_137b;
		}
		object obj105 = obj102 + obj104;
		object obj106 = obj105 + 312;
		goto IL_1916;
		IL_111c:
		InvalidCastException ex9 = new InvalidCastException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_11b9:
		OutOfMemoryException ex10 = new OutOfMemoryException();
		obj34 = 0;
		obj14 = obj13;
		text = (string)(object)xmlNode3;
		goto IL_125c;
		IL_0f88:
		NullReferenceException ex11 = new NullReferenceException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_1883:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v52+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1315 @ X8_v52] (should have been resolved before IL gen)");
		goto IL_123d;
		IL_115a:
		NullReferenceException ex12 = new NullReferenceException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_120a:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_125c;
		IL_1425:
		NullReferenceException ex14 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		bool flag27 = (nint)text != 1;
		OutOfMemoryException ex15 = default(OutOfMemoryException);
		ex8 = ex15;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj107 = default(object);
			games = (Games)obj107;
			goto IL_129c;
		}
		goto IL_1944;
		IL_125c:
		obj21 = (object)(&obj12);
		obj22 = obj7;
		games = Games.Baloot;
		goto IL_1425;
		IL_1944:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_05a1:
		NullReferenceException ex16 = new NullReferenceException();
		obj34 = 0;
		goto IL_125c;
		IL_137b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj14 = 0;
		object obj108 = default(object);
		obj106 = obj108;
		goto IL_1916;
		IL_1916:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v12+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v901 @ X8_v12] (should have been resolved before IL gen)");
		goto IL_18ca;
		IL_0d11:
		NullReferenceException ex17 = new NullReferenceException();
		obj34 = 0;
		goto IL_125c;
		IL_11fc:
		NullReferenceException ex18 = new NullReferenceException();
		goto IL_125c;
		IL_1199:
		NullReferenceException ex19 = new NullReferenceException();
		obj34 = 0;
		obj14 = 0;
		goto IL_125c;
		IL_113b:
		NullReferenceException ex20 = new NullReferenceException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
		IL_11e0:
		InvalidCastException ex21 = new InvalidCastException();
		goto IL_125c;
		IL_0fa7:
		NullReferenceException ex22 = new NullReferenceException();
		obj34 = 0;
		obj14 = obj13;
		goto IL_125c;
	}

	private static void AddContent(string key, XmlNode langNode)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0124: Expected O, but got I4
		//IL_065d: Expected I, but got O
		//IL_0694: Expected O, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0046: Expected I, but got O
		//IL_08cb: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I
		//IL_037a: Expected O, but got I4
		//IL_0795: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I
		//IL_0705: Expected O, but got I
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_07ef: Expected O, but got I
		//IL_03f2: Expected O, but got I
		//IL_0758: Expected O, but got I
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0308: Expected O, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0488: Expected O, but got I
		//IL_083f: Expected O, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0587: Expected O, but got I
		//IL_04c3: Expected O, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_05c2: Expected O, but got I
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		XmlAttributeCollection attributes = langNode.Attributes;
		object obj;
		string text;
		object obj2;
		string text2;
		nint num2;
		if (attributes != null)
		{
			object name = "fetch_products" + 1072;
			nint num = (nint)attributes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v44 (Il2CppClass<System.Xml.XmlAttributeCollection>)+190]");
			num2 = 0;
			XmlNode namedItem = attributes.GetNamedItem((string)name);
			if (namedItem != null)
			{
				string value = namedItem.Value;
				obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				bool flag = string.IsNullOrEmpty(value);
				bool flag2 = !flag;
				text = value;
				if (flag2)
				{
					goto IL_0147;
				}
				obj2 = obj;
				text2 = key;
				goto IL_0655;
			}
		}
		obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		bool flag3 = string.IsNullOrEmpty(null);
		bool flag4 = !flag3;
		object obj3 = !flag4;
		text = null;
		obj2 = obj;
		text2 = key;
		if (obj3 == null)
		{
			goto IL_0147;
		}
		goto IL_0655;
		IL_07d7:
		object obj5 = default(object);
		object obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v18+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v207 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_07f9;
		IL_06c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ X0_v11] (should have been resolved before IL gen)");
		object obj7 = obj2;
		object obj8 = default(object);
		object obj15;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v15+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v18+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0349;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v18+B0]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X10_v25-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj14 += 16;
				obj13--;
				if ((nint)obj13 != 1)
				{
					continue;
				}
				goto IL_0349;
			}
			object obj16 = obj14 + 6;
			object obj17 = obj12 + obj16;
			object obj18 = obj17 + 312;
			goto IL_0736;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v15+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v15+B8]");
		object obj20 = 0;
		object obj21 = obj20;
		string innerText;
		string text3 = CleanText(text2, innerText);
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v14+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0433;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v14+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X10_v7-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj24 += 16;
			obj23--;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_0433;
		}
		object obj25 = obj24 + 5;
		object obj26 = obj22 + obj25;
		obj5 = obj26 + 312;
		goto IL_07d7;
		IL_0736:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v498 @ X0_v26] (should have been resolved before IL gen)");
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v21+B8]");
		object obj28 = 0;
		object obj29 = obj28;
		object obj30 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1000;
		string text4 = text2 + (string)obj30;
		object obj31 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v25+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v25+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0504;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v25+B0]");
		object obj33 = (nint)0 + (nint)8;
		goto IL_07f9;
		IL_0147:
		string text5 = key + text;
		obj2 = obj;
		num2 = unchecked((nint)null);
		text2 = text5;
		goto IL_0655;
		IL_0349:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0736;
		IL_0655:
		nint num3 = (nint)langNode;
		innerText = langNode.InnerText;
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj35 = !flag7;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v10+B8]");
		object obj36 = 0;
		object obj37 = obj36;
		obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2520;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v9+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0231;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v9+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v30-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj40 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_0231;
		}
		object obj41 = obj40 + 4;
		object obj42 = obj38 + obj41;
		object obj43 = obj42 + 312;
		goto IL_06c6;
		IL_07f9:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X10_v20-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_0504;
		}
		object obj44 = obj33 + 5;
		object obj45 = obj31 + obj44;
		object obj46 = obj45 + 312;
		goto IL_081d;
		IL_0603:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0870;
		IL_0504:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_081d;
		IL_0870:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v662 @ X0_v34] (should have been resolved before IL gen)");
		object obj47 = typeof(DataRelation) + 856;
		object obj48 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v35+E4]");
		object message = default(object);
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
		return;
		IL_0433:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07d7;
		IL_081d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v597 @ X0_v31] (should have been resolved before IL gen)");
		object obj49 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v28+B8]");
		object obj50 = 0;
		object obj51 = obj50;
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v30+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v30+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0603;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v30+B0]");
		object obj54 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X10_v15-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj54 += 16;
			obj53--;
			if ((nint)obj53 != 1)
			{
				continue;
			}
			goto IL_0603;
		}
		object obj55 = obj52 + obj54;
		object obj56 = obj55 + 312;
		goto IL_0870;
		IL_0231:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06c6;
	}

	private static string CleanText(string key, string text)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_0075: Expected O, but got I
		//IL_0085: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_029e: Expected O, but got I
		//IL_02af: Expected I, but got O
		//IL_02cd: Expected O, but got I
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I
		object obj;
		string[] source;
		object obj5;
		Func<object, object> selector;
		string separator;
		object obj7;
		string text2;
		object obj4;
		if (text != null)
		{
			obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2216;
			object obj2 = (nint)0 + (nint)2336;
			source = text.Split('\n');
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				obj4 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v15+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+8]");
				selector = (Func<object, object>)0;
				separator = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+8]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					obj7 = obj4;
					text2 = (string)obj2;
					goto IL_0168;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
				obj7 = (nint)0 + (nint)72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v15+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+8]");
				selector = (Func<object, object>)0;
				text2 = (string)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+8]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj4 = obj7;
				separator = (string)obj2;
				if (obj8 == null)
				{
					goto IL_0168;
				}
			}
			goto IL_01bf;
		}
		return (string)(object)new NullReferenceException();
		IL_01bf:
		IEnumerable<object> values = Enumerable.Select(source, selector);
		string text3 = string.Join(separator, (IEnumerable<string>)values);
		if (string.IsNullOrEmpty(text3))
		{
			object obj9 = "Network Authentication Required" + 416;
			object obj10 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 928;
			return (string)obj9 + key + (string)obj10;
		}
		return text3;
		IL_0168:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v14+B8]");
			obj5 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)4016;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj5, (IntPtr)obj14);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v13+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		obj4 = obj7;
		separator = text2;
		goto IL_01bf;
	}

	private unsafe static void CreateContent()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0127: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Expected O, but got Unknown
		//IL_0e83: Expected O, but got I4
		//IL_0e93: Expected O, but got I
		//IL_0ec5: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0257: Expected O, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0351: Expected I, but got O
		//IL_0361: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_039a: Expected O, but got I4
		//IL_0c01: Expected O, but got I4
		//IL_03ce: Expected O, but got I
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_1119: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e: Expected O, but got Unknown
		//IL_10a2: Expected O, but got I4
		//IL_0c3c: Expected O, but got I4
		//IL_0ae0: Expected O, but got I
		//IL_0462: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_04a9: Expected O, but got I4
		//IL_0b77: Expected O, but got I4
		//IL_0ee3: Expected O, but got I
		//IL_10e4: Expected O, but got I
		//IL_0b1b: Expected O, but got I
		//IL_1155: Expected I, but got O
		//IL_1165: Expected O, but got I
		//IL_1175: Expected O, but got I
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected O, but got Unknown
		//IL_04e6: Expected O, but got I
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected I, but got Unknown
		//IL_05fc: Expected I, but got O
		//IL_060c: Expected O, but got I
		//IL_05b1: Expected O, but got I4
		//IL_0d7f: Expected I, but got O
		//IL_0d96: Expected O, but got I4
		//IL_0da9: Expected O, but got I4
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0521: Expected O, but got I
		//IL_0d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Expected O, but got Unknown
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected O, but got Unknown
		//IL_0d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_0d62: Expected O, but got I4
		//IL_066d: Expected I, but got O
		//IL_067d: Expected O, but got I
		//IL_068d: Expected O, but got I
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0bc1: Expected O, but got I4
		//IL_0712: Expected O, but got I
		//IL_07e5: Expected O, but got I4
		//IL_0fa1: Expected I, but got O
		//IL_0fb1: Expected O, but got I
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_074d: Expected O, but got I
		//IL_0aba: Expected O, but got I4
		//IL_0ac3: Expected O, but got I4
		//IL_0f6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f70: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected O, but got Unknown
		//IL_0be2: Expected O, but got I4
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_077e: Expected O, but got I
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected O, but got Unknown
		//IL_0857: Expected O, but got I
		//IL_092a: Expected O, but got I4
		//IL_1036: Expected O, but got I
		//IL_107a: Expected O, but got I4
		//IL_0892: Expected O, but got I
		//IL_0ff8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffd: Expected O, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_09a9: Expected I, but got O
		//IL_09b9: Expected O, but got I
		//IL_09c9: Expected O, but got I
		//IL_09f2: Expected O, but got I4
		//IL_09fb: Expected I4, but got O
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_08c3: Expected O, but got I
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Expected O, but got Unknown
		//IL_0aa2: Expected O, but got I4
		//IL_0a2e: Expected O, but got I
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CB4]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj5;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v135+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v135+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			obj5 = 0;
			obj6 = 0;
			if (obj8 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v106+B8]");
		nint num = 0;
		object obj10 = num;
		if (num != 0)
		{
			goto IL_019f;
		}
		goto IL_0c06;
		IL_0aaf:
		object obj11 = 0;
		object obj12 = 0;
		goto IL_110a;
		IL_110a:
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		Type type = (Type)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj14 = default(object);
		if (obj14 == null)
		{
			goto IL_1088;
		}
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v6+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v6+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b64;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v6+B0]");
		object obj17 = (nint)0 + (nint)8;
		object obj18;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X10_v7-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj18 = obj17 + 16;
			obj16--;
			bool flag3 = (nint)obj16 != 1;
			obj17 = obj18;
			if (flag3)
			{
				continue;
			}
			goto IL_0b64;
		}
		object obj19 = obj15 + obj17;
		num = (nint)(obj19 + 312);
		obj18 = obj17;
		goto IL_10d4;
		IL_0c14:
		NullReferenceException ex = new NullReferenceException();
		InvalidCastException ex2 = (InvalidCastException)(object)ex;
		goto IL_0dae;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v135+B8]");
		num = 0;
		obj10 = num;
		bool flag4 = num == 0;
		object obj20 = !flag4;
		if (obj20 != null)
		{
			goto IL_019f;
		}
		goto IL_0c06;
		IL_019f:
		object obj21 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1872;
		object obj22 = typeof(UsageHint) + 3424;
		object handle = typeof(SqlDouble) + 456;
		object obj23 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v17+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v17+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v41-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj18 = obj25 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v17+12E]");
			obj24 = -1;
			bool flag5 = (nint)obj24 != 1;
			obj25 = obj18;
			if (flag5)
			{
				continue;
			}
			goto IL_027f;
		}
		obj24 = obj25 + 3;
		object obj26 = obj23 + obj24;
		object obj27 = obj26 + 312;
		obj18 = obj25;
		goto IL_0e48;
		IL_1088:
		bool flag6 = obj12 == null;
		object obj28 = !flag6;
		if (obj28 == null)
		{
			return;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		bool flag7 = (nint)type != 1;
		InvalidCastException ex4 = (InvalidCastException)(object)ex3;
		object obj38;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj29 = typeof(DataRelation) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj31 = default(object);
			object obj30 = obj31;
			object obj32 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
			object obj33 = default(object);
			bool flag8 = obj33 == null;
			object obj34 = obj31;
			if (!flag8)
			{
				obj34 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj35 = typeof(DataRelation) + 856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D040");
				object obj36 = "Complete" + 2800;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				object message = default(object);
				Debug.LogError(message);
				obj32 = 0;
				throw new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
			num = (nint)obj34;
			object obj37 = obj34;
			type = (Type)(139026432 + 4064);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
			obj38 = 0;
			goto IL_0dae;
		}
		goto IL_0dc6;
		IL_10d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v3 (Il2CppClass<UnityEngine.Object>)+8]");
		type = (Type)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v457 @ X8_v3 (Il2CppClass<UnityEngine.Object>)] (should have been resolved before IL gen)");
		goto IL_1088;
		IL_0b64:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj38 = 0;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_10d4;
		IL_0c06:
		NullReferenceException ex5 = new NullReferenceException();
		goto IL_0c14;
		IL_027f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj38 = 3;
		goto IL_0e48;
		IL_0e48:
		object path = "LAK" + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v47] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		XmlDocument xmlDocument = default(XmlDocument);
		xmlDocument..ctor();
		object obj39 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v21+E0]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v52+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v52+E4]");
		bool flag9 = (nint)0 == 0;
		object obj41 = !flag9;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		UnityEngine.Object obj42 = Resources.Load((string)path, typeFromHandle);
		bool flag10 = (object)obj42 == null;
		obj38 = 0;
		type = typeFromHandle;
		bool flag13;
		if (!flag10)
		{
			object obj43 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 176;
			type = (Type)obj43;
			num = (nint)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v3 (Il2CppClass<UnityEngine.Object>)+130]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v3 (Il2CppClass<UnityEngine.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
			bool flag11 = num2 < 0;
			object obj44 = !flag11;
			object obj45 = ~obj44;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v3 (Il2CppClass<UnityEngine.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
				object obj46 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v28-8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v28-8]");
				object obj47 = 0 - type;
				bool flag12 = obj47 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v28-8]");
				flag13 = 0 != (nint)type;
				if (!flag13)
				{
					string text = ((TextAsset)obj42).text;
					if (xmlDocument != null)
					{
						nint num4 = (nint)xmlDocument;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ X8_v30 (Il2CppClass<System.Xml.XmlDocument>)+5F0]");
						obj38 = 0;
						xmlDocument.LoadXml(text);
						object obj48 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v64+E4]");
						bool flag14 = (nint)0 == 0;
						object obj49 = !flag14;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj48 = obj2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v64+B8]");
						object obj50 = 0;
						object obj51 = obj50;
						if (obj50 != null)
						{
							object obj52 = obj51;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v56+12E]");
							object obj53 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v56+12E]");
							if ((nint)0 == 0)
							{
								goto IL_059e;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v56+B0]");
							object obj54 = (nint)0 + (nint)8;
							bool flag15 = flag13;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X10_v36-8]");
								obj47 = 0 - obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X10_v36-8]");
								if (0 == (nint)obj21)
								{
									break;
								}
								obj18 = obj54 + 16;
								obj53--;
								obj47 = obj53 - 1;
								flag12 = obj47 == null;
								flag13 = (nint)obj53 != 1;
								flag15 = flag13;
								obj54 = obj18;
								if (flag13)
								{
									continue;
								}
								goto IL_059e;
							}
							object obj55 = obj54 + 3;
							object obj56 = obj52 + obj55;
							object obj57 = obj56 + 312;
							flag13 = flag15;
							obj18 = obj54;
							goto IL_0f49;
						}
						goto IL_114d;
					}
					NullReferenceException ex6 = new NullReferenceException();
					obj38 = 0;
					type = (Type)(object)text;
					ex2 = (InvalidCastException)(object)ex6;
					goto IL_0dae;
				}
			}
			InvalidCastException ex7 = new InvalidCastException();
			obj38 = 0;
			goto IL_0c06;
		}
		goto IL_0c14;
		IL_0a8e:
		ex2 = new InvalidCastException();
		obj11 = 0;
		nint num5;
		num = num5;
		goto IL_0dae;
		IL_0dae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		ex4 = ex2;
		goto IL_0dc6;
		IL_059e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj38 = 3;
		goto IL_0f49;
		IL_114d:
		nint num6 = (nint)xmlDocument;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v34 (Il2CppClass<System.Xml.XmlDocument>)+1E8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v34 (Il2CppClass<System.Xml.XmlDocument>)+1F0]");
		type = (Type)0;
		XmlNodeList childNodes = xmlDocument.ChildNodes;
		bool flag16 = childNodes == null;
		num = num6;
		if (flag16)
		{
			goto IL_0c06;
		}
		nint num7 = (nint)childNodes;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v35 (Il2CppClass<System.Xml.XmlNodeList>)+1A0]");
		obj38 = 0;
		XmlNode xmlNode = childNodes.Item(1);
		if (xmlNode == null)
		{
			return;
		}
		XmlNodeList childNodes2 = xmlNode.ChildNodes;
		if (childNodes2 == null)
		{
			return;
		}
		nint num8 = (nint)childNodes2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v37 (Il2CppClass<System.Xml.XmlNodeList>)+1B8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v37 (Il2CppClass<System.Xml.XmlNodeList>)+1C0]");
		type = (Type)0;
		IEnumerator enumerator = childNodes2.GetEnumerator();
		object obj58 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj21 = typeof(UsageHint) + 3672;
		num = (nint)(&obj6);
		object obj62 = default(object);
		object obj64 = default(object);
		XmlNode xmlNode2 = default(XmlNode);
		for (; obj5 != null; ParseSection(xmlNode2))
		{
			object obj59 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v41+12E]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v41+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07d2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v41+B0]");
			object obj60 = (nint)0 + (nint)8;
			bool flag17 = flag13;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v30-8]");
				object obj47 = 0 - obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v30-8]");
				if (0 == (nint)obj58)
				{
					break;
				}
				obj18 = obj60 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v41+12E]");
				obj24 = -1;
				obj47 = obj24 - 1;
				bool flag12 = obj47 == null;
				flag13 = (nint)obj24 != 1;
				flag17 = flag13;
				obj60 = obj18;
				if (flag13)
				{
					continue;
				}
				goto IL_07d2;
			}
			obj24 = obj60;
			object obj61 = obj59 + obj60;
			obj62 = obj61 + 312;
			flag13 = flag17;
			obj18 = obj60;
			goto IL_0f99;
			IL_0f99:
			num = (nint)obj62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v73+8]");
			type = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v879 @ X0_v73] (should have been resolved before IL gen)");
			object obj63 = obj64 & 1;
			if (obj63 == null)
			{
				goto IL_0aaf;
			}
			if (obj5 == null)
			{
				goto IL_0bce;
			}
			object obj65 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v44+12E]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v44+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0917;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v44+B0]");
			object obj66 = (nint)0 + (nint)8;
			bool flag18 = flag13;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v25-8]");
				object obj47 = 0 - obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v25-8]");
				if (0 == (nint)obj58)
				{
					break;
				}
				obj18 = obj66 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v44+12E]");
				obj24 = -1;
				obj47 = obj24 - 1;
				bool flag12 = obj47 == null;
				flag13 = (nint)obj24 != 1;
				flag18 = flag13;
				obj66 = obj18;
				if (flag13)
				{
					continue;
				}
				goto IL_0917;
			}
			obj24 = obj66 + 1;
			object obj67 = obj65 + obj24;
			object obj68 = obj67 + 312;
			flag13 = flag18;
			obj18 = obj66;
			goto IL_1026;
			IL_1026:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X0_v77+8]");
			type = (Type)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v957 @ X0_v77] (should have been resolved before IL gen)");
			object obj69 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v80+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X0_v80+E4]");
			bool flag19 = (nint)0 == 0;
			object obj70 = !flag19;
			if (obj70 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if (xmlNode2 == null)
			{
				continue;
			}
			type = (Type)obj21;
			nint num9 = (nint)xmlNode2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v48 (Il2CppClass<System.Xml.XmlNode>)+130]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v48 (Il2CppClass<System.Xml.XmlNode>)+130]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
			bool flag20 = num10 < 0;
			object obj71 = !flag20;
			flag13 = (byte)(int)(~obj71) != 0;
			num5 = num9;
			if (!flag13)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X8_v48 (Il2CppClass<System.Xml.XmlNode>)+C8]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X1_v11 (System.Type)+130]");
				object obj72 = num11 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v51-8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v51-8]");
				object obj47 = 0 - type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v51-8]");
				bool flag12 = 0 == (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v51-8]");
				num5 = 0;
				if (flag12)
				{
					continue;
				}
			}
			goto IL_0a8e;
			IL_0917:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj38 = 1;
			goto IL_1026;
			IL_07d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj38 = 0;
			goto IL_0f99;
		}
		NullReferenceException ex8 = new NullReferenceException();
		obj11 = 0;
		ex2 = (InvalidCastException)(object)ex8;
		goto IL_0dae;
		IL_0f49:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v776 @ X0_v92] (should have been resolved before IL gen)");
		goto IL_114d;
		IL_0dc6:
		InvalidCastException ex9 = default(InvalidCastException);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			if ((nint)type == 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
			ex4 = ex9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		object obj73 = default(object);
		obj12 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		obj11 = obj73;
		goto IL_110a;
		IL_0bce:
		NullReferenceException ex10 = new NullReferenceException();
		obj11 = 0;
		ex2 = (InvalidCastException)(object)ex10;
		goto IL_0dae;
	}

	internal static string <GetText>g__SafeFormat|7_0(string s, long i)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = GetText(s);
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format(text, arg);
	}
}
