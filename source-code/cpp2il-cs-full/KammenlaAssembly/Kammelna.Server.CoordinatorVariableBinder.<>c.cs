using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server;

public class CoordinatorVariableBinder
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<BindAction> <>9__13_2;

		public static Func<KeyValuePair<string, List<BindAction>>, IEnumerable<BindAction>> <>9__13_3;

		public static Func<KeyValuePair<string, IDictionary<string, List<BindAction>>>, bool> <>9__13_0;

		public static Func<KeyValuePair<string, IDictionary<string, List<BindAction>>>, string> <>9__13_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ClearNulls>b__13_2(BindAction go)
		{
			//IL_0093: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (go != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = go.<GameObject>k__BackingField;
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ClearNulls>b__13_0(KeyValuePair<string, IDictionary<string, List<BindAction>>> d)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_018f: Expected O, but got I
			//IL_01b1: Expected O, but got I4
			//IL_0094: Expected O, but got I
			//IL_0052: Expected O, but got I4
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_011f: Expected O, but got I
			//IL_0130: Expected I, but got O
			//IL_014e: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(CardUtils.<>c) + 2624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+10]");
			Func<KeyValuePair<object, object>, IEnumerable<object>> selector = (Func<KeyValuePair<object, object>, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3648;
				Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)16;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = (Func<KeyValuePair<object, object>, IEnumerable<object>>)func;
			}
			IntPtr intPtr = default(IntPtr);
			IEnumerable<object> source = Enumerable.SelectMany((IEnumerable<KeyValuePair<object, object>>)(nint)intPtr, selector);
			bool flag4 = Enumerable.Any(source);
			return (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
		}

		internal IEnumerable<BindAction> <ClearNulls>b__13_3(KeyValuePair<string, List<BindAction>> b)
		{
			//IL_000a: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<BindAction>)(nint)intPtr;
		}

		internal string <ClearNulls>b__13_1(KeyValuePair<string, IDictionary<string, List<BindAction>>> d)
		{
			return (string)d;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public GameObject gameObject;

		public Predicate<BindAction> <>9__0;

		internal bool <Unbind>b__0(BindAction go)
		{
			//IL_008b: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (go != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return go.<GameObject>k__BackingField == gameObject;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public string scope;

		internal bool <ClearCached>b__0((string, string) k)
		{
			return (string)k == scope;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public BindAction bindAction;

		internal bool <BindInternal>b__0(BindAction b)
		{
			//IL_00b7: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			if (b != null)
			{
				BindAction bindAction = this.bindAction;
				if (this.bindAction != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return b.<GameObject>k__BackingField == bindAction.<GameObject>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private readonly IDictionary<string, IDictionary<string, List<BindAction>>> _binds;

	private readonly IDictionary<(string, string), string> _latestValues;

	public CoordinatorVariableBinder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00a7: Expected I, but got O
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2048;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 288;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 976;
		object obj4 = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = this + 16;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<(object, object), object> dictionary2 = default(Dictionary<(object, object), object>);
		dictionary2..ctor();
		object obj6 = this + 24;
		obj6 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object, object> action = default(Action<object, object, object>);
		action..ctor((object)this, (IntPtr)obj4);
		CoordinatorService.OnVariableUpdate += action;
	}

	private void OnVariableUpdate(string scope, string key, string valueJson)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3936;
		IDictionary<(string, string), string> latestValues = _latestValues;
		(object, object) tuple = (scope, key);
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2360;
		nint num = (nint)latestValues;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00b9;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_013a;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_013a;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X0_v4] (should have been resolved before IL gen)");
		DispatchUpdate(scope, key);
	}

	public void Bind(BindAction bindAction, string scope, string variableName)
	{
		//IL_0027: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(scope);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		bool flag3 = string.IsNullOrEmpty(variableName);
		bool flag4 = !flag3;
		object obj2 = !flag4;
		if (obj2 != null)
		{
			return;
		}
		BindInternal(bindAction, scope, variableName);
		if (bindAction != null)
		{
			Action <Action>k__BackingField = bindAction.<Action>k__BackingField;
			if (bindAction.<Action>k__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v35.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				return;
			}
			NullReferenceException ex = new NullReferenceException();
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public unsafe void Unbind(GameObject gameObject)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0e7e: Expected O, but got I4
		//IL_0e91: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009d: Expected I, but got O
		//IL_00ad: Expected O, but got I
		//IL_017c: Expected I, but got O
		//IL_0f0a: Expected O, but got I
		//IL_0f31: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_0eba: Expected O, but got I
		//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed1: Expected O, but got Unknown
		//IL_0d60: Expected O, but got Ref
		//IL_0d69: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0215: Expected O, but got I
		//IL_0221: Expected O, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_12dd: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_02dd: Expected I, but got O
		//IL_0f9f: Expected O, but got I
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_0b28: Expected O, but got Ref
		//IL_0b47: Expected O, but got Ref
		//IL_0b50: Expected O, but got I4
		//IL_0b59: Expected O, but got I4
		//IL_0b61: Expected O, but got Ref
		//IL_0b71: Expected O, but got Ref
		//IL_0b82: Expected O, but got I4
		//IL_0bd3: Expected O, but got I4
		//IL_0bdb: Expected O, but got Ref
		//IL_0f4f: Expected O, but got I
		//IL_0f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f66: Expected O, but got Unknown
		//IL_1348: Expected O, but got I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0c15: Expected O, but got I
		//IL_0d0d: Expected O, but got Ref
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_027a: Expected O, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0cb0: Expected I, but got O
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0363: Expected O, but got I
		//IL_1402: Expected O, but got I
		//IL_0c50: Expected O, but got I
		//IL_0432: Expected I, but got O
		//IL_13ce: Expected O, but got I
		//IL_1034: Expected O, but got I
		//IL_039e: Expected O, but got I
		//IL_0cd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Expected O, but got Unknown
		//IL_0d23: Expected O, but got Ref
		//IL_0fe4: Expected O, but got I
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffb: Expected O, but got Unknown
		//IL_0dbf: Expected O, but got I4
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c79: Expected O, but got I
		//IL_0477: Expected I, but got O
		//IL_0487: Expected O, but got I
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0556: Expected I, but got O
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03cf: Expected O, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_10c3: Expected O, but got I
		//IL_04c2: Expected O, but got I
		//IL_08d5: Expected O, but got Ref
		//IL_08de: Expected O, but got I4
		//IL_0916: Expected O, but got Ref
		//IL_1073: Expected O, but got I
		//IL_1085: Unknown result type (might be due to invalid IL or missing references)
		//IL_108a: Expected O, but got Unknown
		//IL_059b: Expected I, but got O
		//IL_05ab: Expected O, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_067a: Expected I, but got O
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_1172: Expected O, but got I
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected O, but got Unknown
		//IL_05e6: Expected O, but got I
		//IL_1122: Expected O, but got I
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_0d39: Expected O, but got Ref
		//IL_0d42: Expected O, but got I4
		//IL_0d52: Expected O, but got Ref
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0937: Expected I, but got O
		//IL_0947: Expected O, but got I
		//IL_0b02: Expected O, but got Ref
		//IL_0b0b: Expected O, but got I4
		//IL_0b1b: Expected O, but got Ref
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0617: Expected O, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0a16: Expected I, but got O
		//IL_06dc: Expected I, but got O
		//IL_06ec: Expected O, but got I
		//IL_12b6: Expected O, but got I
		//IL_0982: Expected O, but got I
		//IL_07bb: Expected I, but got O
		//IL_1266: Expected O, but got I
		//IL_1278: Unknown result type (might be due to invalid IL or missing references)
		//IL_127d: Expected O, but got Unknown
		//IL_1207: Expected O, but got I
		//IL_1221: Expected O, but got I
		//IL_1243: Expected O, but got I4
		//IL_0727: Expected O, but got I
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a30: Expected O, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_11b7: Expected O, but got I
		//IL_11c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ce: Expected O, but got Unknown
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		//IL_09b3: Expected O, but got I
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_0ad3: Expected O, but got Ref
		//IL_0adc: Expected O, but got I4
		//IL_0aec: Expected O, but got Ref
		//IL_0813: Expected I, but got O
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected O, but got Unknown
		//IL_085b: Expected I, but got O
		//IL_0886: Expected O, but got I4
		//IL_08a6: Expected I, but got O
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_083e: Expected O, but got I4
		//IL_0846: Expected I, but got O
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0758: Expected O, but got I
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = 0;
		GameObject gameObject2 = null;
		GameObject gameObject3 = null;
		object obj4 = 152993792;
		object obj9 = default(object);
		bool flag4 = default(bool);
		object obj11 = default(object);
		object obj7;
		if (!flag)
		{
			object obj5 = obj2 + 16;
			obj5 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
			bool flag2 = _binds == null;
			obj3 = 0;
			gameObject2 = null;
			gameObject3 = gameObject;
			obj4 = 152993792;
			if (!flag2)
			{
				object obj6 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2744;
				nint num = (nint)binds;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_016d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
				object obj8 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X10_v57-8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X10_v57-8]");
					object obj10 = 0 - obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X10_v57-8]");
					if (0 == (nint)obj6)
					{
						break;
					}
					obj11 = obj8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
					obj7 = -1;
					obj10 = obj7 - 1;
					bool flag5 = obj10 == null;
					flag4 = (nint)obj7 != 1;
					flag3 = flag4;
					obj8 = obj11;
					if (flag4)
					{
						continue;
					}
					goto IL_016d;
				}
				obj7 = obj8;
				object obj12 = num + obj8;
				object obj13 = obj12 + 312;
				flag4 = flag3;
				obj11 = obj8;
				goto IL_0efa;
			}
		}
		goto IL_0e9f;
		IL_1024:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v41+8]");
		gameObject3 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v846 @ X0_v41] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v41+8]");
		object obj15;
		if ((nint)0 != 0)
		{
			nint num2 = (nint)gameObject3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v32 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v32 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0547;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v32 (Il2CppClass<UnityEngine.GameObject>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag6 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X10_v42-8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X10_v42-8]");
				object obj10 = 0 - obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X10_v42-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj11 = obj14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X8_v32 (Il2CppClass<UnityEngine.GameObject>)+12E]");
				obj7 = -1;
				obj10 = obj7 - 1;
				bool flag5 = obj10 == null;
				flag4 = (nint)obj7 != 1;
				flag6 = flag4;
				obj14 = obj11;
				if (flag4)
				{
					continue;
				}
				goto IL_0547;
			}
			obj7 = obj14;
			object obj16 = num2 + obj14;
			object obj17 = obj16 + 312;
			flag4 = flag6;
			obj11 = obj14;
			goto IL_10b3;
		}
		NullReferenceException ex = new NullReferenceException();
		obj4 = (object)(&gameObject2);
		goto IL_0d57;
		IL_0e9f:
		throw new NullReferenceException();
		IL_0ca1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num3 = unchecked((nint)null);
		goto IL_13f2;
		IL_13f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v21+8]");
		gameObject3 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v789 @ X0_v21] (should have been resolved before IL gen)");
		object obj19 = default(object);
		object obj18 = obj19;
		object obj21;
		object obj20 = obj21;
		object obj22 = obj9;
		object obj24 = default(object);
		object obj23 = obj24;
		object obj26;
		object obj25 = obj26;
		object obj28;
		object obj27 = obj28;
		object obj30;
		object obj29 = obj30;
		object obj32;
		object obj31 = obj32;
		object obj33 = obj15;
		object obj35;
		object obj34 = obj35;
		object obj36 = obj11;
		object obj38;
		object obj37 = obj38;
		object obj39 = obj4;
		goto IL_132e;
		IL_132e:
		object obj41 = default(object);
		object obj42;
		object obj44;
		nint num4 = default(nint);
		while (true)
		{
			bool flag7 = obj37 == null;
			object obj40 = !flag7;
			obj19 = obj18;
			obj21 = obj20;
			obj9 = obj22;
			obj24 = obj23;
			obj26 = obj25;
			obj28 = obj27;
			obj30 = obj29;
			obj32 = obj31;
			obj15 = obj33;
			obj35 = obj34;
			num4 = num3;
			obj11 = obj36;
			obj4 = obj39;
			if (obj40 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			if ((nint)gameObject3 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj38 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj42 = obj21;
				bool flag8 = obj21 == null;
				object obj43 = !flag8;
				obj44 = obj41;
				if (obj43 != null)
				{
					break;
				}
				obj18 = obj19;
				obj20 = obj21;
				obj22 = obj9;
				obj44 = obj41;
				obj23 = obj24;
				obj25 = obj26;
				obj27 = obj28;
				obj29 = obj30;
				obj31 = obj32;
				obj33 = obj15;
				obj34 = obj35;
				num3 = num4;
				obj36 = obj11;
				obj37 = obj41;
				obj39 = obj4;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_0be9;
		IL_0d28:
		OutOfMemoryException ex3 = new OutOfMemoryException();
		obj19 = (object)(&gameObject2);
		object obj45 = 0;
		GameObject gameObject4 = default(GameObject);
		gameObject2 = gameObject4;
		obj4 = (object)(&gameObject2);
		goto IL_0d57;
		IL_016d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_0efa;
		IL_0efa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v30+8]");
		gameObject3 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X0_v30] (should have been resolved before IL gen)");
		object obj46 = default(object);
		bool flag9 = obj46 == null;
		gameObject2 = null;
		obj4 = 152993792;
		if (!flag9)
		{
			obj35 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj15 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2752;
			obj32 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 56;
			obj30 = typeof(List<Tween>) + 3096;
			obj28 = (nint)0 + (nint)3656;
			obj26 = (nint)0 + (nint)1920;
			gameObject2 = null;
			object obj47 = obj46;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v23+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v23+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v23+B0]");
			object obj49 = (nint)0 + (nint)8;
			bool flag10 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v52-8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v52-8]");
				object obj10 = 0 - obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v52-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj11 = obj49 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v23+12E]");
				obj7 = -1;
				obj10 = obj7 - 1;
				bool flag5 = obj10 == null;
				flag4 = (nint)obj7 != 1;
				flag10 = flag4;
				obj49 = obj11;
				if (flag4)
				{
					continue;
				}
				goto IL_02ce;
			}
			obj7 = obj49;
			object obj50 = obj48 + obj49;
			object obj51 = obj50 + 312;
			flag4 = flag10;
			obj11 = obj49;
			goto IL_0f8f;
		}
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0d57;
		IL_0ac2:
		NullReferenceException ex5 = new NullReferenceException();
		obj19 = (object)(&gameObject2);
		obj45 = 0;
		gameObject2 = gameObject4;
		obj4 = (object)(&gameObject2);
		goto IL_0d57;
		IL_0d57:
		obj21 = (object)(&obj3);
		obj44 = 0;
		goto IL_0e9f;
		IL_08c4:
		NullReferenceException ex6 = new NullReferenceException();
		obj19 = (object)(&gameObject2);
		obj45 = 0;
		object obj52;
		obj9 = obj52;
		gameObject2 = gameObject4;
		object obj53;
		obj24 = obj53;
		nint num5;
		num4 = num5;
		object obj54;
		obj11 = obj54;
		GameObject gameObject5;
		gameObject3 = gameObject5;
		obj4 = (object)(&gameObject2);
		goto IL_0d57;
		IL_10b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v45+8]");
		gameObject5 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v921 @ X0_v45] (should have been resolved before IL gen)");
		bool flag11 = (object)gameObject4 == null;
		GameObject gameObject6 = gameObject4;
		obj52 = obj9;
		obj53 = obj24;
		num5 = num4;
		obj54 = obj11;
		if (flag11)
		{
			goto IL_08c4;
		}
		object obj59 = default(object);
		Predicate<object> predicate2 = default(Predicate<object>);
		while (true)
		{
			nint num6 = (nint)gameObject6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_066b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<UnityEngine.GameObject>)+B0]");
			object obj55 = (nint)0 + (nint)8;
			bool flag12 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X10_v37-8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X10_v37-8]");
				object obj10 = 0 - obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v996 @ X10_v37-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj11 = obj55 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<UnityEngine.GameObject>)+12E]");
				obj7 = -1;
				obj10 = obj7 - 1;
				bool flag5 = obj10 == null;
				flag4 = (nint)obj7 != 1;
				flag12 = flag4;
				obj55 = obj11;
				if (flag4)
				{
					continue;
				}
				goto IL_066b;
			}
			obj7 = obj55;
			object obj56 = num6 + obj55;
			object obj57 = obj56 + 312;
			flag4 = flag12;
			obj11 = obj55;
			goto IL_1162;
			IL_1162:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X0_v51+8]");
			gameObject3 = (GameObject)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1011 @ X0_v51] (should have been resolved before IL gen)");
			object obj58 = obj59 & 1;
			if (obj58 == null)
			{
				break;
			}
			if ((object)gameObject4 == null)
			{
				goto IL_0af1;
			}
			nint num7 = (nint)gameObject4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v47 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v47 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07ac;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v47 (Il2CppClass<UnityEngine.GameObject>)+B0]");
			object obj60 = (nint)0 + (nint)8;
			bool flag13 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X10_v32-8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X10_v32-8]");
				object obj10 = 0 - obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X10_v32-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj11 = obj60 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1018 @ X8_v47 (Il2CppClass<UnityEngine.GameObject>)+12E]");
				obj7 = -1;
				obj10 = obj7 - 1;
				bool flag5 = obj10 == null;
				flag4 = (nint)obj7 != 1;
				flag13 = flag4;
				obj60 = obj11;
				if (flag4)
				{
					continue;
				}
				goto IL_07ac;
			}
			obj7 = obj60;
			object obj61 = num7 + obj60;
			object obj62 = obj61 + 312;
			flag4 = flag13;
			obj11 = obj60;
			goto IL_11f7;
			IL_11f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1132 @ X0_v64+8]");
			gameObject3 = (GameObject)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1132 @ X0_v64] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
			Predicate<object> predicate = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
			bool flag14 = (nint)0 == 0;
			object obj63 = !flag14;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				predicate2..ctor(obj2, (IntPtr)obj28);
				object obj64 = obj2 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj24 = 0;
				num4 = (nint)obj28;
				predicate = predicate2;
			}
			if ((object)gameObject3 != null)
			{
				num4 = (nint)obj26;
				int num8 = ((List<object>)(object)gameObject3).RemoveAll(predicate);
				bool flag15 = (object)gameObject4 == null;
				object obj65 = !flag15;
				gameObject6 = gameObject4;
				obj52 = obj9;
				obj53 = obj24;
				num5 = (nint)obj26;
				obj54 = obj11;
				gameObject5 = (GameObject)(object)predicate;
				if (obj65 != null)
				{
					continue;
				}
				goto IL_08c4;
			}
			goto IL_0ac2;
			IL_07ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_11f7;
			IL_066b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_1162;
		}
		if ((object)gameObject4 != null)
		{
			object obj66 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num9 = (nint)gameObject4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v43 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v43 (Il2CppClass<UnityEngine.GameObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a07;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v43 (Il2CppClass<UnityEngine.GameObject>)+B0]");
			object obj67 = (nint)0 + (nint)8;
			bool flag16 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X10_v26-8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X10_v26-8]");
				object obj10 = 0 - obj66;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X10_v26-8]");
				if (0 == (nint)obj66)
				{
					break;
				}
				obj11 = obj67 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X8_v43 (Il2CppClass<UnityEngine.GameObject>)+12E]");
				obj7 = -1;
				obj10 = obj7 - 1;
				bool flag5 = obj10 == null;
				flag4 = (nint)obj7 != 1;
				flag16 = flag4;
				obj67 = obj11;
				if (flag4)
				{
					continue;
				}
				goto IL_0a07;
			}
			obj7 = obj67;
			object obj68 = num9 + obj67;
			object obj69 = obj68 + 312;
			flag4 = flag16;
			obj11 = obj67;
			goto IL_12a6;
		}
		goto IL_0d28;
		IL_0547:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_10b3;
		IL_0af1:
		NullReferenceException ex7 = new NullReferenceException();
		obj19 = (object)(&gameObject2);
		obj45 = 0;
		gameObject2 = gameObject4;
		obj4 = (object)(&gameObject2);
		goto IL_0d57;
		IL_02ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_0f8f;
		IL_0f8f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v37+8]");
		gameObject3 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ X0_v37] (should have been resolved before IL gen)");
		object obj71 = default(object);
		object obj70 = obj71 & 1;
		if (obj70 != null)
		{
			if (obj3 != null)
			{
				object obj72 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 32;
				object obj73 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v29+12E]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0423;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v29+B0]");
				object obj74 = (nint)0 + (nint)8;
				bool flag17 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X10_v47-8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X10_v47-8]");
					object obj10 = 0 - obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X10_v47-8]");
					if (0 == (nint)obj72)
					{
						break;
					}
					obj11 = obj74 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v29+12E]");
					obj7 = -1;
					obj10 = obj7 - 1;
					bool flag5 = obj10 == null;
					flag4 = (nint)obj7 != 1;
					flag17 = flag4;
					obj74 = obj11;
					if (flag4)
					{
						continue;
					}
					goto IL_0423;
				}
				obj7 = obj74;
				object obj75 = obj73 + obj74;
				object obj76 = obj75 + 312;
				flag4 = flag17;
				obj11 = obj74;
				goto IL_1024;
			}
			NullReferenceException ex8 = new NullReferenceException();
			obj4 = (object)(&gameObject2);
			goto IL_0d57;
		}
		object obj77 = (object)(&obj3);
		obj42 = obj77;
		bool flag18 = obj77 == null;
		obj21 = (object)(&obj3);
		obj44 = 0;
		obj38 = 0;
		obj4 = (object)(&gameObject2);
		obj18 = obj19;
		obj20 = (object)(&obj3);
		obj22 = obj9;
		obj44 = 0;
		obj23 = obj24;
		obj25 = obj26;
		obj27 = obj28;
		obj29 = obj30;
		obj31 = obj32;
		obj33 = obj15;
		obj34 = obj35;
		num3 = num4;
		obj36 = obj11;
		obj37 = 0;
		obj39 = (object)(&gameObject2);
		if (!flag18)
		{
			goto IL_0be9;
		}
		goto IL_132e;
		IL_0423:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_1024;
		IL_0be9:
		object obj78 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj79 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v10+12E]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ca1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v10+B0]");
		object obj80 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X10_v9-8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X10_v9-8]");
			if (0 == (nint)obj78)
			{
				break;
			}
			obj11 = obj80 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v10+12E]");
			obj7 = -1;
			bool flag19 = (nint)obj7 != 1;
			obj80 = obj11;
			if (flag19)
			{
				continue;
			}
			goto IL_0ca1;
		}
		obj7 = obj80;
		object obj81 = obj79 + obj80;
		object obj82 = obj81 + 312;
		num3 = num4;
		obj11 = obj80;
		goto IL_13f2;
		IL_0a07:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_12a6;
		IL_12a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X0_v57+8]");
		gameObject3 = (GameObject)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1174 @ X0_v57] (should have been resolved before IL gen)");
		goto IL_0d28;
	}

	public string GetCurrent(string scope, string variableName)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_019d: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3936;
		IDictionary<(string, string), string> latestValues = _latestValues;
		(object, object) tuple = (scope, variableName);
		if (_latestValues != null)
		{
			object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2360;
			nint num = (nint)latestValues;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v5-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 7;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0179;
		}
		return (string)(object)new NullReferenceException();
		IL_0179:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v4] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		object obj9 = !flag;
		object obj10 = ~obj9;
		string result = default(string);
		if (obj10 == null)
		{
			return result;
		}
		return null;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0179;
	}

	public void ClearCached(string scope)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00be: Expected I, but got O
		//IL_00ce: Expected O, but got I
		//IL_04fd: Expected I, but got O
		//IL_0505: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0224: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I4
		//IL_02b2: Expected I, but got O
		//IL_02c2: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		object scope2 = typeof(CardUtils.<>c) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		string text = null;
		object obj2;
		object obj4;
		object obj5;
		object obj6 = default(object);
		if (!flag)
		{
			scope2 = obj + 16;
			scope2 = scope;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IDictionary<(string, string), string> latestValues = _latestValues;
			bool flag2 = _latestValues == null;
			text = scope;
			if (!flag2)
			{
				obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2360;
				object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3928;
				obj4 = (nint)0 + (nint)3664;
				obj5 = (nint)0 + (nint)3224;
				obj6 = (nint)0 + (nint)1784;
				nint num = (nint)latestValues;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0186;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+B0]");
				object obj8 = (nint)0 + (nint)8;
				bool flag4 = default(bool);
				bool flag3 = flag4;
				object obj10;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X10_v14-8]");
					object obj9 = 0 - obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X10_v14-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj10 = obj8 + 16;
					obj7--;
					obj9 = obj7 - 1;
					bool flag5 = obj9 == null;
					flag4 = (nint)obj7 != 1;
					flag3 = flag4;
					obj8 = obj10;
					if (flag4)
					{
						continue;
					}
					goto IL_0186;
				}
				object obj11 = obj8 + 2;
				object obj12 = num + obj11;
				object obj13 = obj12 + 312;
				flag4 = flag3;
				obj10 = obj8;
				goto IL_04d8;
			}
		}
		goto IL_0489;
		IL_03a3:
		DispatchAllForScope((string)scope2);
		return;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = 2;
		goto IL_04d8;
		IL_04d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X0_v22] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<(object, object), bool> func = default(Func<(object, object), bool>);
		func..ctor(obj, (IntPtr)obj4);
		num2 = (nint)obj5;
		IEnumerable<(object, object)> source2 = default(IEnumerable<(object, object)>);
		IEnumerable<(object, object)> source = Enumerable.Where(source2, func);
		text = (string)obj6;
		List<(object, object)> list = Enumerable.ToList(source);
		bool flag6 = list == null;
		object obj14 = 0;
		List<(object, object)>.Enumerator enumerator2 = default(List<(object, object)>.Enumerator);
		if (!flag6)
		{
			object obj15 = (nint)0 + (nint)2776;
			obj6 = (nint)0 + (nint)2768;
			List<(object, object)>.Enumerator enumerator = list.GetEnumerator();
			obj14 = 0;
			IntPtr intPtr = default(IntPtr);
			while (true)
			{
				text = (string)obj15;
				if (!enumerator2.MoveNext())
				{
					break;
				}
				IDictionary<(string, string), string> latestValues2 = _latestValues;
				if (_latestValues != null)
				{
					nint num3 = (nint)latestValues2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v12 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.ValueTuple`2<System.String, System.String>, System.String>>)+B0]");
						object obj10 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X10_v9-8]");
							object obj9 = 0 - obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X10_v9-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj10 += 16;
							obj16--;
							obj9 = obj16 - 1;
							bool flag5 = obj9 == null;
							if ((nint)obj16 != 1)
							{
								continue;
							}
							goto IL_024b;
						}
						object obj17 = obj10 + 6;
						object obj18 = num3 + obj17;
						object obj19 = obj18 + 312;
						goto IL_025a;
					}
					goto IL_024b;
				}
				goto IL_03ae;
				IL_025a:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v37+8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ X0_v37] (should have been resolved before IL gen)");
				num2 = intPtr;
				continue;
				IL_024b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_025a;
			}
			enumerator2.Dispose();
			goto IL_03a3;
		}
		goto IL_0489;
		IL_03ae:
		NullReferenceException ex = new NullReferenceException();
		object obj20 = 0;
		goto IL_0489;
		IL_0489:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag7 = (nint)text != 1;
		NullReferenceException ex3 = ex2;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			text = (string)obj6;
			enumerator2.Dispose();
			object obj21 = default(object);
			if (obj21 == null)
			{
				goto IL_03a3;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj20 = obj21;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C784");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void ReWire(string newScope, string oldScope)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010d: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0158: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		object obj2 = (nint)0 + (nint)2104;
		nint num = (nint)binds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00b9;
		}
		object obj5 = obj4 + 6;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_020a;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_020a;
		IL_020a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X0_v4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D23A18");
		object obj8 = default(object);
		if (obj8 == null)
		{
			return;
		}
		IDictionary<string, IDictionary<string, List<BindAction>>> binds2 = _binds;
		nint num2 = (nint)binds2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0199;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0199;
		}
		object obj11 = obj10 + 5;
		object obj12 = num2 + obj11;
		object obj13 = obj12 + 312;
		goto IL_025f;
		IL_025f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v10] (should have been resolved before IL gen)");
		DispatchAllForScope(newScope);
		return;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_025f;
	}

	private unsafe void BindInternal(BindAction bindAction, string scope, string variableName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0064: Expected I, but got O
		//IL_0074: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0139: Expected O, but got Ref
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0241: Expected I, but got O
		//IL_0251: Expected O, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0326: Expected I, but got O
		//IL_0336: Expected O, but got I
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_01d7: Expected O, but got Ref
		//IL_01ef: Expected O, but got I
		//IL_03cc: Expected O, but got I
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03fb: Expected O, but got Ref
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_07a7: Expected O, but got I
		//IL_028c: Expected O, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0371: Expected O, but got I
		//IL_0514: Expected I, but got O
		//IL_0524: Expected O, but got I
		//IL_0421: Expected O, but got I
		//IL_0429: Expected O, but got Ref
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_07fa: Expected O, but got I
		//IL_0806: Expected O, but got I
		//IL_0821: Expected I, but got O
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_046f: Expected O, but got I
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_04a1: Expected O, but got I4
		//IL_04a9: Expected O, but got Ref
		//IL_04c1: Expected O, but got I
		//IL_04c9: Expected O, but got Ref
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_086b: Expected O, but got I
		//IL_055f: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_06bd: Expected O, but got I4
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0625: Expected O, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_065a: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = bindAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
		object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		nint num = (nint)binds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X10_v28-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00f0;
		}
		object obj7 = obj6 + 7;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v52+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X0_v52] (should have been resolved before IL gen)");
		object obj12 = default(object);
		object obj11 = obj12 & 1;
		bool flag = obj11 == null;
		object obj13 = !flag;
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		object obj14 = (object)(&dictionary);
		string text = scope;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v52+8]");
		object obj15 = 0;
		if (obj13 == null)
		{
			goto IL_01fd;
		}
		goto IL_030a;
		IL_02cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0797;
		IL_0797:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X0_v42+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ X0_v42] (should have been resolved before IL gen)");
		goto IL_030a;
		IL_030a:
		object obj16 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		nint num2 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03b2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X10_v16-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_03b2;
		}
		object obj19 = obj18 + 7;
		object obj20 = num2 + obj19;
		object obj21 = obj20 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v36+8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v502 @ X0_v36] (should have been resolved before IL gen)");
		object obj24 = default(object);
		object obj23 = obj24 & 1;
		bool flag2 = obj23 == null;
		object obj25 = !flag2;
		List<object> list2 = default(List<object>);
		List<object> list = (List<object>)(&list2);
		string text2 = variableName;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v36+8]");
		object obj26 = 0;
		List<object> list3 = (List<object>)(&list2);
		string text3 = variableName;
		if (obj25 == null)
		{
			goto IL_04df;
		}
		goto IL_07da;
		IL_085b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X0_v26+8]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v651 @ X0_v26] (should have been resolved before IL gen)");
		List<object> list4 = default(List<object>);
		list3 = list4;
		text3 = variableName;
		goto IL_07da;
		IL_00f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v49+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v317 @ X0_v49] (should have been resolved before IL gen)");
		object obj28 = default(object);
		object obj27 = obj28 & 1;
		bool flag3 = obj27 == null;
		obj14 = (object)(&dictionary);
		text = scope;
		if (flag3)
		{
			goto IL_01fd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v49+8]");
		obj15 = 0;
		goto IL_030a;
		IL_01fd:
		object obj29 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		dictionary2..ctor();
		IDictionary<string, IDictionary<string, List<BindAction>>> binds2 = _binds;
		nint num3 = (nint)binds2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X10_v23-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_02cd;
		}
		object obj32 = obj31 + 5;
		object obj33 = num3 + obj32;
		object obj34 = obj33 + 312;
		goto IL_0797;
		IL_05a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_085b;
		IL_03b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v33+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v435 @ X0_v33] (should have been resolved before IL gen)");
		object obj36 = default(object);
		object obj35 = obj36 & 1;
		bool flag4 = obj35 == null;
		list = (List<object>)(&list2);
		text2 = variableName;
		if (flag4)
		{
			goto IL_04df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v33+8]");
		obj26 = 0;
		list3 = (List<object>)(&list2);
		text3 = variableName;
		goto IL_07da;
		IL_04df:
		object obj37 = typeof(List<AdaptivePerformanceScaler>) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		list4..ctor();
		nint num4 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v24 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v24 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05a0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v24 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+B0]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X10_v11-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj39 += 16;
			obj38--;
			if ((nint)obj38 != 1)
			{
				continue;
			}
			goto IL_05a0;
		}
		object obj40 = obj39 + 5;
		object obj41 = num4 + obj40;
		object obj42 = obj41 + 312;
		goto IL_085b;
		IL_07da:
		object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 328;
		object obj44 = (nint)0 + (nint)3672;
		object obj45 = (nint)0 + (nint)656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj44);
		object obj46 = Enumerable.FirstOrDefault(list4, func);
		if (obj46 != null)
		{
			object obj47 = obj3;
			object obj48 = obj46 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v17+18]");
			obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj49 = obj3;
			object obj50 = obj46 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v18+10]");
			obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
		}
		int version = list4._version + 1;
		list4._version = version;
		object[] items = list4._items;
		bool flag5 = list4._size < items.Length;
		object obj51 = !flag5;
		if (obj51 == null)
		{
			int size = list4._size + 1;
			list4._size = size;
			object obj52 = items + list4._size;
			object obj53 = obj52 + 32;
			obj53 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list4.AddWithResize(obj3);
		}
	}

	private void DispatchUpdate(string scope, string variableName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		ClearNulls();
		IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		nint num = (nint)binds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v13-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 7;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v21+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ X0_v21] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if (obj8 == null)
		{
			return;
		}
		goto IL_015a;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v18+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X0_v18] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		if (obj10 == null)
		{
			return;
		}
		goto IL_015a;
		IL_015a:
		object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
		object obj13 = default(object);
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v10+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0202;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v10+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X10_v7-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0202;
		}
		object obj16 = obj15 + 7;
		object obj17 = obj12 + obj16;
		object obj18 = obj17 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v340 @ X0_v13] (should have been resolved before IL gen)");
		object obj19 = default(object);
		if (obj19 == null)
		{
			return;
		}
		goto IL_0288;
		IL_0288:
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> bindActions = Enumerable.ToList(source);
		SafelyDispatchBindActions((List<BindAction>)(object)bindActions);
		return;
		IL_0202:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v324 @ X0_v10] (should have been resolved before IL gen)");
		object obj20 = default(object);
		if (obj20 == null)
		{
			return;
		}
		goto IL_0288;
	}

	private unsafe void DispatchAllForScope(string scope)
	{
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected O, but got Unknown
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Expected O, but got Unknown
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Expected O, but got Unknown
		//IL_0130: Expected I, but got O
		//IL_0140: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0a8c: Expected O, but got I
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae4: Expected O, but got Unknown
		//IL_061e: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b0: Expected I, but got O
		//IL_01c0: Expected O, but got I
		//IL_071a: Expected I, but got O
		//IL_0337: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0ce6: Expected O, but got I
		//IL_0cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected O, but got Unknown
		//IL_0659: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_08d9: Expected O, but got I4
		//IL_08e2: Expected O, but got I4
		//IL_0c61: Expected O, but got I
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected O, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cc: Expected I, but got O
		//IL_03dc: Expected O, but got I
		//IL_0b10: Expected O, but got I
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected O, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0787: Expected O, but got I
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_075a: Expected O, but got I
		//IL_04e0: Expected I, but got O
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0556: Expected I, but got O
		//IL_057a: Expected O, but got I4
		//IL_058a: Expected O, but got I
		//IL_0dee: Expected O, but got I4
		//IL_088b: Expected I, but got O
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_068a: Expected O, but got I
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_0417: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_0913: Expected O, but got I
		//IL_07d2: Expected O, but got I
		//IL_0b94: Expected O, but got I
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected O, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected O, but got Unknown
		//IL_09ae: Expected I, but got O
		//IL_0d2b: Expected O, but got I
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_0d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6e: Expected O, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected O, but got Unknown
		//IL_0e30: Expected O, but got I
		//IL_094e: Expected O, but got I
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_04ab: Expected O, but got I
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_0803: Expected O, but got I
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected O, but got Unknown
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0977: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E82BB]");
		nint num = 0;
		ClearNulls();
		IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
		bool flag2 = default(bool);
		object obj4 = default(object);
		object obj9 = default(object);
		nint num3 = default(nint);
		object obj15 = default(object);
		object obj13;
		object obj8 = default(object);
		object obj7 = default(object);
		object obj6 = default(object);
		bool flag3 = default(bool);
		object obj5 = default(object);
		if (_binds != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
			nint num2 = (nint)binds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_011e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v43-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v43-8]");
				obj5 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v43-8]");
				flag3 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v43-8]");
				obj6 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v43-8]");
				obj7 = 0 ^ obj5;
				obj8 = obj6 & obj7;
				if (flag3)
				{
					break;
				}
				obj9 = obj3 + 16;
				obj2--;
				obj5 = obj2 - 1;
				flag3 = obj5 == null;
				obj6 = obj2 ^ 1;
				obj7 = obj2 ^ obj5;
				obj8 = obj6 & obj7;
				flag2 = (nint)obj2 != 1;
				flag = flag2;
				obj3 = obj9;
				if (flag2)
				{
					continue;
				}
				goto IL_011e;
			}
			object obj10 = obj3 + 7;
			object obj11 = num2 + obj10;
			object obj12 = obj11 + 312;
			num = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v59+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v305 @ X0_v59] (should have been resolved before IL gen)");
			object obj14 = default(object);
			bool flag4 = obj14 == null;
			num3 = (nint)(&obj15);
			flag2 = flag;
			obj9 = obj3;
			if (!flag4)
			{
				goto IL_01ff;
			}
			return;
		}
		goto IL_05d8;
		IL_05d8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05e6;
		IL_03b0:
		object obj16 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2824;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04c9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj9 = (nint)0 + (nint)8;
		bool flag5;
		flag2 = flag5;
		nint num4;
		object obj18;
		object obj19;
		bool flag6;
		object obj20;
		object obj21;
		object obj22;
		object obj23;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			obj5 = 0 - obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			flag3 = 0 == (nint)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			obj6 = 0 ^ obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			obj7 = 0 ^ obj5;
			obj8 = obj6 & obj7;
			num3 = num4;
			if (flag3)
			{
				break;
			}
			obj18 = obj9 + 16;
			obj17--;
			obj19 = obj17 - 1;
			flag6 = obj19 == null;
			obj20 = obj17 ^ 1;
			obj21 = obj17 ^ obj19;
			obj22 = obj20 & obj21;
			flag5 = (nint)obj17 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X10_v20-8]");
			obj23 = 0;
			flag2 = flag5;
			obj9 = obj18;
			if (flag5)
			{
				continue;
			}
			goto IL_04c9;
		}
		goto IL_05e6;
		IL_05e6:
		object obj24 = num + obj9;
		object obj25 = obj24 + 312;
		goto IL_0c10;
		IL_0c10:
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X8_v3] (should have been resolved before IL gen)");
		object obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj28 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 152;
		object obj29 = default(object);
		object obj36;
		object obj38 = default(object);
		object obj44;
		List<BindAction> bindActions = default(List<BindAction>);
		while (true)
		{
			object obj32;
			object obj35;
			nint num5;
			if (obj29 != null)
			{
				object obj30 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+12E]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0703;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+B0]");
				obj32 = (nint)0 + (nint)8;
				bool flag7 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
					obj5 = 0 - obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
					flag3 = 0 == (nint)obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
					obj6 = 0 ^ obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
					obj7 = 0 ^ obj5;
					obj8 = obj6 & obj7;
					if (flag3)
					{
						break;
					}
					obj9 = obj32 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+12E]");
					obj31 = -1;
					obj5 = obj31 - 1;
					flag3 = obj5 == null;
					obj6 = obj31 ^ 1;
					obj7 = obj31 ^ obj5;
					obj8 = obj6 & obj7;
					flag2 = (nint)obj31 != 1;
					flag7 = flag2;
					obj32 = obj9;
					if (flag2)
					{
						continue;
					}
					goto IL_0703;
				}
				obj31 = obj32;
				object obj33 = obj30 + obj32;
				object obj34 = obj33 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v6-8]");
				obj35 = 0;
				num5 = num3;
				flag2 = flag7;
				goto IL_0cd5;
			}
			throw new NullReferenceException();
			IL_0703:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj35 = obj4;
			num5 = unchecked((nint)null);
			obj32 = obj9;
			goto IL_0cd5;
			IL_0cd5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v27+8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v27] (should have been resolved before IL gen)");
			object obj37 = obj38 & 1;
			if (obj37 != null)
			{
				object obj39 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v19+12E]");
				obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v19+12E]");
				bool flag8 = (nint)0 == 0;
				obj4 = obj35;
				obj9 = obj32;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v19+B0]");
					object obj40 = (nint)0 + (nint)8;
					bool flag9 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X10_v18-8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X10_v18-8]");
						obj5 = 0 - obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X10_v18-8]");
						flag3 = 0 == (nint)obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X10_v18-8]");
						obj6 = 0 ^ obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X10_v18-8]");
						obj7 = 0 ^ obj5;
						obj8 = obj6 & obj7;
						if (flag3)
						{
							break;
						}
						obj9 = obj40 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v19+12E]");
						obj26 = -1;
						obj5 = obj26 - 1;
						flag3 = obj5 == null;
						obj6 = obj26 ^ 1;
						obj7 = obj26 ^ obj5;
						obj8 = obj6 & obj7;
						flag2 = (nint)obj26 != 1;
						flag9 = flag2;
						obj40 = obj9;
						if (flag2)
						{
							continue;
						}
						goto IL_087c;
					}
					obj26 = obj40;
					object obj41 = obj39 + obj40;
					object obj42 = obj41 + 312;
					num3 = num5;
					flag2 = flag9;
					obj9 = obj40;
					goto IL_0d9f;
				}
				goto IL_087c;
			}
			object obj43 = 0;
			obj44 = 0;
			break;
			IL_0d9f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v789 @ X0_v31] (should have been resolved before IL gen)");
			SafelyDispatchBindActions(bindActions);
			continue;
			IL_087c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = unchecked((nint)null);
			goto IL_0d9f;
		}
		object obj51 = default(object);
		while (true)
		{
			if (obj29 == null)
			{
				goto IL_0dd4;
			}
			object obj45 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj46 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v11+12E]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v11+12E]");
			if ((nint)0 == 0)
			{
				goto IL_099f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v11+B0]");
			object obj47 = (nint)0 + (nint)8;
			object obj32;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X10_v10-8]");
				if (0 == (nint)obj45)
				{
					break;
				}
				obj32 = obj47 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v11+12E]");
				obj31 = -1;
				bool flag10 = (nint)obj31 != 1;
				obj47 = obj32;
				if (flag10)
				{
					continue;
				}
				goto IL_099f;
			}
			obj31 = obj47;
			object obj48 = obj46 + obj47;
			object obj49 = obj48 + 312;
			obj32 = obj47;
			goto IL_0e20;
			IL_0dd4:
			bool flag11 = obj44 == null;
			object obj50 = !flag11;
			if (obj50 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)obj36 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj44 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj43 = obj51;
			continue;
			IL_099f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num5 = unchecked((nint)null);
			goto IL_0e20;
			IL_0e20:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v19+8]");
			obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v817 @ X0_v19] (should have been resolved before IL gen)");
			goto IL_0dd4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_04c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj4 = obj23;
		num3 = unchecked((nint)null);
		flag2 = flag5;
		obj8 = obj22;
		obj7 = obj21;
		obj6 = obj20;
		flag3 = flag6;
		obj5 = obj19;
		obj9 = obj18;
		object obj52 = default(object);
		obj25 = obj52;
		goto IL_0c10;
		IL_011e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj53 = default(object);
		num = (nint)obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v56+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v56] (should have been resolved before IL gen)");
		object obj54 = default(object);
		bool flag12 = obj54 == null;
		object obj55 = !flag12;
		num3 = (nint)(&obj15);
		if (obj55 == null)
		{
			return;
		}
		goto IL_01ff;
		IL_01ff:
		if (obj15 != null)
		{
			object obj56 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
			object obj57 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+12E]");
			object obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0325;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v35+B0]");
			obj18 = (nint)0 + (nint)8;
			flag5 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
				obj19 = 0 - obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
				flag6 = 0 == (nint)obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
				obj20 = 0 ^ obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
				obj21 = 0 ^ obj19;
				obj22 = obj20 & obj21;
				if (flag6)
				{
					break;
				}
				obj9 = obj18 + 16;
				obj58--;
				obj5 = obj58 - 1;
				flag3 = obj5 == null;
				obj6 = obj58 ^ 1;
				obj7 = obj58 ^ obj5;
				obj8 = obj6 & obj7;
				flag2 = (nint)obj58 != 1;
				flag5 = flag2;
				obj18 = obj9;
				if (flag2)
				{
					continue;
				}
				goto IL_0325;
			}
			object obj59 = obj18 + 3;
			object obj60 = obj57 + obj59;
			object obj61 = obj60 + 312;
			num = (nint)obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ X0_v52] (should have been resolved before IL gen)");
			bool flag13 = ex == null;
			object obj62 = !flag13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X10_v30-8]");
			obj23 = 0;
			num4 = num3;
			flag2 = flag5;
			obj8 = obj22;
			obj7 = obj21;
			obj6 = obj20;
			flag3 = flag6;
			obj5 = obj19;
			obj9 = obj18;
			if (obj62 != null)
			{
				goto IL_03b0;
			}
		}
		goto IL_05d8;
		IL_0325:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj63 = default(object);
		num = (nint)obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v49] (should have been resolved before IL gen)");
		bool flag14 = ex == null;
		obj23 = obj4;
		num4 = 3;
		flag5 = flag2;
		obj22 = obj8;
		obj21 = obj7;
		obj20 = obj6;
		flag6 = flag3;
		obj19 = obj5;
		obj18 = obj9;
		num3 = 3;
		if (!flag14)
		{
			goto IL_03b0;
		}
		goto IL_05d8;
	}

	private static void SafelyDispatchBindActions(List<BindAction> bindActions)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_00b3: Expected O, but got I4
		//IL_005d: Expected O, but got I
		//IL_00da: Expected O, but got I4
		if (bindActions != null)
		{
			object obj = (nint)0 + (nint)3472;
			object obj2 = (nint)0 + (nint)3464;
			List<object>.Enumerator enumerator = ((List<object>)(object)bindActions).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj4 = default(object);
			NullReferenceException ex;
			List<object>.Enumerator enumerator3;
			object obj3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				obj3 = obj;
				if (enumerator2.MoveNext())
				{
					List<object>.Enumerator enumerator5;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ stack_-68+18]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ stack_-68+18]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v94 @ X8_v13+18] (should have been resolved before IL gen)");
							continue;
						}
						ex = new NullReferenceException();
						enumerator3 = enumerator4;
						enumerator5 = enumerator4;
						enumerator4 = (List<object>.Enumerator)0;
						break;
					}
					ex = new NullReferenceException();
					enumerator3 = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					break;
				}
				enumerator2.Dispose();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag = (nint)obj3 != 1;
			NullReferenceException ex2 = ex;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj3 = obj2;
				enumerator3.Dispose();
				object obj6 = default(object);
				if (obj6 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				ex2 = (NullReferenceException)(object)ex3;
				enumerator4 = (List<object>.Enumerator)obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223C7C4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		throw new NullReferenceException();
	}

	private unsafe void ClearNulls()
	{
		//IL_1565: Expected O, but got I4
		//IL_156e: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_15db: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Expected O, but got Unknown
		//IL_1612: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_131d: Expected O, but got Ref
		//IL_1326: Expected O, but got I4
		//IL_158c: Expected O, but got I
		//IL_159e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a3: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_1a1c: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_1693: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_0c2e: Expected O, but got Ref
		//IL_0c4d: Expected O, but got Ref
		//IL_0c56: Expected O, but got I4
		//IL_0c5e: Expected O, but got Ref
		//IL_0c6c: Expected O, but got I4
		//IL_0c7a: Expected O, but got I4
		//IL_0c92: Expected O, but got Ref
		//IL_0c9b: Expected O, but got I4
		//IL_0cd3: Expected O, but got Ref
		//IL_0ce1: Expected O, but got I4
		//IL_0d07: Expected O, but got I4
		//IL_1630: Expected O, but got I
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_1647: Expected O, but got Unknown
		//IL_1a87: Expected O, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0d24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d29: Expected O, but got Unknown
		//IL_0d41: Expected O, but got I
		//IL_1341: Expected O, but got Ref
		//IL_134a: Expected O, but got I4
		//IL_1352: Expected O, but got Ref
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_0d7c: Expected O, but got I
		//IL_0f43: Expected O, but got I
		//IL_0f53: Expected O, but got I
		//IL_0f63: Expected O, but got I
		//IL_0f85: Expected O, but got I4
		//IL_0e81: Expected O, but got I4
		//IL_1b0d: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_1042: Expected O, but got I4
		//IL_0ec8: Expected O, but got I
		//IL_0ed8: Expected O, but got I
		//IL_0ee8: Expected O, but got I
		//IL_0f0a: Expected O, but got I4
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_136d: Expected O, but got Ref
		//IL_1376: Expected O, but got I4
		//IL_137e: Expected O, but got Ref
		//IL_16c5: Expected O, but got I
		//IL_16d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dc: Expected O, but got Unknown
		//IL_1483: Expected O, but got I4
		//IL_149c: Expected O, but got I4
		//IL_1c6d: Expected O, but got I
		//IL_1c79: Expected O, but got I
		//IL_1c89: Expected O, but got I
		//IL_1c99: Expected O, but got I
		//IL_1cbb: Expected O, but got I4
		//IL_0fab: Expected O, but got I
		//IL_0fcd: Expected O, but got I4
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d97: Expected O, but got Unknown
		//IL_0dad: Expected O, but got I
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_040b: Expected O, but got I
		//IL_041b: Expected O, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_10d6: Expected I, but got O
		//IL_10ef: Expected I, but got O
		//IL_1be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bec: Expected O, but got Unknown
		//IL_1c02: Expected O, but got I
		//IL_1c13: Expected I, but got O
		//IL_1c31: Expected O, but got I
		//IL_1c4c: Expected O, but got I4
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_034b: Expected O, but got I
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_153b: Expected O, but got I4
		//IL_1077: Expected O, but got I
		//IL_1099: Expected O, but got I4
		//IL_0ffd: Expected O, but got I
		//IL_0456: Expected O, but got I
		//IL_1ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce5: Expected O, but got Unknown
		//IL_1cfb: Expected O, but got I
		//IL_1d0c: Expected I, but got O
		//IL_1d2a: Expected O, but got I
		//IL_1d45: Expected O, but got I4
		//IL_098d: Expected O, but got Ref
		//IL_0996: Expected O, but got I4
		//IL_09ae: Expected O, but got Ref
		//IL_09b7: Expected O, but got I4
		//IL_09cf: Expected O, but got Ref
		//IL_1754: Expected O, but got I
		//IL_1766: Unknown result type (might be due to invalid IL or missing references)
		//IL_176b: Expected O, but got Unknown
		//IL_1183: Expected O, but got I
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_1197: Expected O, but got Unknown
		//IL_11a3: Expected O, but got I
		//IL_10c9: Expected O, but got I
		//IL_0543: Expected O, but got I
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_1d65: Expected I, but got O
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0487: Expected O, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_186e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1873: Expected O, but got Unknown
		//IL_057e: Expected O, but got I
		//IL_180b: Expected O, but got I
		//IL_181d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1822: Expected O, but got Unknown
		//IL_13ee: Expected O, but got Ref
		//IL_13f7: Expected O, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_121a: Expected I, but got O
		//IL_122a: Expected O, but got I
		//IL_1399: Expected O, but got Ref
		//IL_13a2: Expected O, but got I4
		//IL_13b2: Expected O, but got Ref
		//IL_13bb: Expected O, but got I4
		//IL_13c3: Expected O, but got Ref
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected O, but got Unknown
		//IL_0a1d: Expected O, but got I
		//IL_0bf2: Expected O, but got Ref
		//IL_0bfb: Expected O, but got I4
		//IL_0c0b: Expected O, but got Ref
		//IL_0c14: Expected O, but got I4
		//IL_0c1c: Expected O, but got Ref
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected O, but got Unknown
		//IL_05af: Expected O, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_0688: Expected O, but got I
		//IL_1265: Expected O, but got I
		//IL_0a58: Expected O, but got I
		//IL_1d9f: Expected O, but got I
		//IL_1db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db6: Expected O, but got Unknown
		//IL_19a5: Expected O, but got I
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bc: Expected O, but got Unknown
		//IL_06c3: Expected O, but got I
		//IL_12d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dd: Expected O, but got Unknown
		//IL_12e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ea: Expected O, but got Unknown
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected O, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_081f: Expected O, but got I
		//IL_082f: Expected O, but got I
		//IL_0851: Expected O, but got I4
		//IL_18a0: Expected O, but got I
		//IL_18b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b7: Expected O, but got Unknown
		//IL_1273: Unknown result type (might be due to invalid IL or missing references)
		//IL_1278: Expected O, but got Unknown
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		//IL_1286: Expected O, but got Unknown
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected O, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected O, but got Unknown
		//IL_0a89: Expected O, but got I
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected O, but got Unknown
		//IL_07a8: Expected O, but got I
		//IL_07b8: Expected O, but got I
		//IL_07da: Expected O, but got I4
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_0bad: Expected O, but got Ref
		//IL_0bb6: Expected O, but got I4
		//IL_0bc6: Expected O, but got Ref
		//IL_0bcf: Expected O, but got I4
		//IL_0bd7: Expected O, but got Ref
		//IL_087f: Expected O, but got I
		//IL_08a1: Expected O, but got I4
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06f4: Expected O, but got I
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_0903: Expected I, but got O
		//IL_0918: Expected O, but got I
		//IL_0936: Expected O, but got I4
		//IL_095e: Expected I, but got O
		//IL_096e: Expected I, but got O
		//IL_1931: Expected I, but got O
		//IL_1942: Expected I, but got O
		//IL_1960: Expected O, but got I
		//IL_197b: Expected O, but got I4
		//IL_1983: Expected I, but got O
		//IL_08d1: Expected O, but got I
		IDictionary<string, IDictionary<string, List<BindAction>>> binds = _binds;
		bool flag = _binds == null;
		object obj = 0;
		object obj2 = 0;
		bool flag3 = default(bool);
		object obj4;
		object obj6 = default(object);
		object obj8 = default(object);
		if (!flag)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2744;
			nint num = (nint)binds;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v50 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v50 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00f1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v50 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X10_v65-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X10_v65-8]");
				object obj7 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X10_v65-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj8 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v50 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag2 = flag3;
				obj5 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_00f1;
			}
			obj4 = obj5;
			object obj9 = num + obj5;
			object obj10 = obj9 + 312;
			flag3 = flag2;
			obj8 = obj5;
			goto IL_15cc;
		}
		goto IL_1d52;
		IL_0ddd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = 0;
		goto IL_1b31;
		IL_1b31:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X0_v62+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v930 @ X0_v62] (should have been resolved before IL gen)");
		object obj12 = default(object);
		object obj11 = obj12;
		object obj13 = obj6;
		object obj15;
		object obj14 = obj15;
		object obj17 = default(object);
		object obj16 = obj17;
		object obj19;
		object obj18 = obj19;
		object obj21 = default(object);
		object obj20 = obj21;
		object obj23;
		object obj22 = obj23;
		object obj25;
		object obj24 = obj25;
		object obj27;
		object obj26 = obj27;
		object obj29;
		object obj28 = obj29;
		CoordinatorVariableBinder coordinatorVariableBinder2;
		CoordinatorVariableBinder coordinatorVariableBinder = coordinatorVariableBinder2;
		object obj31;
		object obj30 = obj31;
		bool flag5 = flag3;
		object obj32 = obj8;
		CoordinatorVariableBinder coordinatorVariableBinder4;
		CoordinatorVariableBinder coordinatorVariableBinder3 = coordinatorVariableBinder4;
		object obj34;
		object obj33 = obj34;
		goto IL_1a6d;
		IL_1a6d:
		object obj36 = default(object);
		object obj37;
		nint num4 = default(nint);
		object obj39;
		while (true)
		{
			bool flag6 = obj30 == null;
			object obj35 = !flag6;
			obj12 = obj11;
			obj6 = obj13;
			obj15 = obj14;
			obj17 = obj16;
			obj19 = obj18;
			obj21 = obj20;
			obj23 = obj22;
			obj25 = obj24;
			obj27 = obj26;
			obj29 = obj28;
			num4 = num2;
			obj8 = obj32;
			coordinatorVariableBinder4 = coordinatorVariableBinder3;
			if (obj35 != null)
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				flag3 = num3 != 1;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj31 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj37 = obj15;
					bool flag7 = obj15 == null;
					object obj38 = !flag7;
					obj39 = obj36;
					coordinatorVariableBinder2 = coordinatorVariableBinder4;
					obj34 = 0;
					if (obj38 == null)
					{
						obj11 = obj12;
						obj13 = obj6;
						obj14 = obj15;
						obj39 = obj36;
						obj16 = obj17;
						obj18 = obj19;
						obj20 = obj21;
						obj22 = obj23;
						obj24 = obj25;
						obj26 = obj27;
						obj28 = obj29;
						coordinatorVariableBinder = coordinatorVariableBinder4;
						obj30 = obj36;
						num2 = num4;
						flag5 = flag3;
						obj32 = obj8;
						coordinatorVariableBinder3 = coordinatorVariableBinder4;
						obj33 = 0;
						continue;
					}
					goto IL_0d15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		object obj40 = obj33 - 7;
		if ((nint)obj33 != 7)
		{
			bool flag8 = obj33 == null;
			object obj41 = !flag8;
			if (obj41 != null)
			{
				return;
			}
		}
		object obj42 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v37+E4]");
		object obj44;
		Func<KeyValuePair<object, object>, bool> predicate;
		object obj46;
		object obj43;
		if ((nint)0 != 0)
		{
			obj43 = (nint)0 + (nint)3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v37+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v28+18]");
			predicate = (Func<KeyValuePair<object, object>, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v28+18]");
			bool flag9 = (nint)0 == 0;
			object obj45 = !flag9;
			if (obj45 == null)
			{
				obj46 = obj43;
				goto IL_0f9b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj42 = obj18;
			obj46 = (nint)0 + (nint)3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v37+B8]");
			obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v28+18]");
			predicate = (Func<KeyValuePair<object, object>, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v28+18]");
			bool flag10 = (nint)0 == 0;
			object obj47 = !flag10;
			obj43 = obj46;
			if (obj47 == null)
			{
				goto IL_0f9b;
			}
		}
		goto IL_1002;
		IL_0add:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_19e5;
		IL_0f9b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v37+E4]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ X0_v37+E4]");
		bool flag11 = (nint)0 == 0;
		object obj48 = !flag11;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj49 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X8_v34+B8]");
			obj44 = 0;
		}
		obj16 = obj44;
		object obj50 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)3624;
		Func<KeyValuePair<object, object>, bool> func = default(Func<KeyValuePair<object, object>, bool>);
		func..ctor(obj44, (IntPtr)obj51);
		object obj52 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v33+B8]");
		object obj53 = (nint)0 + (nint)24;
		obj53 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj20 = 0;
		obj43 = obj46;
		predicate = func;
		goto IL_1002;
		IL_00f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_15cc;
		IL_15cc:
		obj19 = typeof(CardUtils.<>c) + 2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v68+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v68] (should have been resolved before IL gen)");
		object obj54 = default(object);
		bool flag12 = obj54 == null;
		obj2 = 0;
		object obj55;
		if (!flag12)
		{
			obj55 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj27 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 56;
			object obj56 = typeof(List<Tween>) + 3096;
			obj25 = (nint)0 + (nint)3640;
			obj23 = (nint)0 + (nint)1920;
			obj2 = 0;
			object obj57 = obj54;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v56+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v56+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0246;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v56+B0]");
			object obj59 = (nint)0 + (nint)8;
			bool flag13 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v60-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v60-8]");
				object obj7 = 0 - obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v60-8]");
				if (0 == (nint)obj55)
				{
					break;
				}
				obj8 = obj59 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v56+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag13 = flag3;
				obj59 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0246;
			}
			obj4 = obj59;
			object obj60 = obj58 + obj59;
			object obj61 = obj60 + 312;
			flag3 = flag13;
			obj8 = obj59;
			goto IL_1670;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj15 = (object)(&obj);
		obj39 = 0;
		coordinatorVariableBinder4 = this;
		goto IL_1d52;
		IL_0be1:
		NullReferenceException ex3 = new NullReferenceException();
		obj12 = (object)(&obj2);
		object obj62 = 0;
		object obj63 = default(object);
		obj2 = obj63;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		coordinatorVariableBinder4 = this;
		goto IL_1d52;
		IL_04db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_1794;
		IL_1794:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v82+8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1103 @ X0_v82] (should have been resolved before IL gen)");
		bool flag14 = obj63 == null;
		object obj64 = obj63;
		object obj65 = obj6;
		object obj66 = obj17;
		object obj67 = obj21;
		nint num6 = num4;
		object obj68 = obj8;
		if (flag14)
		{
			goto IL_097c;
		}
		Predicate<object> predicate3 = default(Predicate<object>);
		object obj82 = default(object);
		while (true)
		{
			object obj69 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v72+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v72+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0603;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v72+B0]");
			object obj70 = (nint)0 + (nint)8;
			bool flag15 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v45-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v45-8]");
				object obj7 = 0 - obj55;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X10_v45-8]");
				if (0 == (nint)obj55)
				{
					break;
				}
				obj8 = obj70 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X8_v72+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag15 = flag3;
				obj70 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0603;
			}
			obj4 = obj70;
			object obj71 = obj69 + obj70;
			object obj72 = obj71 + 312;
			flag3 = flag15;
			obj8 = obj70;
			goto IL_184b;
			IL_0748:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = 0;
			goto IL_18e0;
			IL_18e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1402 @ X0_v101] (should have been resolved before IL gen)");
			object obj73 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X0_v109+E4]");
			object obj74;
			Predicate<object> predicate2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X0_v109+B8]");
				obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1527 @ X8_v88+8]");
				predicate2 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1527 @ X8_v88+8]");
				bool flag16 = (nint)0 == 0;
				object obj75 = !flag16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X0_v101+8]");
				num3 = 0;
				if (obj75 == null)
				{
					goto IL_086f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj73 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X0_v109+B8]");
				obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1527 @ X8_v88+8]");
				predicate2 = (Predicate<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1527 @ X8_v88+8]");
				bool flag17 = (nint)0 == 0;
				object obj76 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X0_v101+8]");
				num3 = 0;
				if (obj76 == null)
				{
					goto IL_086f;
				}
			}
			goto IL_08d6;
			IL_086f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X0_v109+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1519 @ X0_v109+E4]");
			bool flag18 = (nint)0 == 0;
			object obj77 = !flag18;
			if (obj77 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj78 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v90+B8]");
				obj74 = 0;
			}
			obj17 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num4 = (nint)obj25;
			predicate3..ctor(obj74, (IntPtr)obj25);
			object obj79 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X8_v89+B8]");
			object obj80 = (nint)0 + (nint)8;
			obj80 = predicate3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj21 = 0;
			num3 = (nint)predicate3;
			predicate2 = predicate3;
			goto IL_08d6;
			IL_0603:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = 0;
			goto IL_184b;
			IL_184b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X0_v88+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1251 @ X0_v88] (should have been resolved before IL gen)");
			object obj81 = obj82 & 1;
			if (obj81 == null)
			{
				break;
			}
			if (obj63 == null)
			{
				goto IL_0be1;
			}
			object obj83 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1283 @ X8_v82+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1283 @ X8_v82+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0748;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1283 @ X8_v82+B0]");
			object obj84 = (nint)0 + (nint)8;
			bool flag19 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X10_v40-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X10_v40-8]");
				object obj7 = 0 - obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X10_v40-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj8 = obj84 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1283 @ X8_v82+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag19 = flag3;
				obj84 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0748;
			}
			obj4 = obj84;
			object obj85 = obj83 + obj84;
			object obj86 = obj85 + 312;
			flag3 = flag19;
			obj8 = obj84;
			goto IL_18e0;
			IL_08d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X0_v101+8]");
			if ((nint)0 != 0)
			{
				num4 = (nint)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X0_v101+8]");
				int num7 = ((List<object>)0).RemoveAll(predicate2);
				bool flag20 = obj63 == null;
				object obj87 = !flag20;
				obj64 = obj63;
				obj65 = obj6;
				obj66 = obj17;
				obj67 = obj21;
				num6 = (nint)obj23;
				obj68 = obj8;
				num5 = (nint)predicate2;
				if (obj87 != null)
				{
					continue;
				}
				goto IL_097c;
			}
			goto IL_0b9c;
		}
		if (obj63 != null)
		{
			object obj88 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj89 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v78+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v78+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0add;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v78+B0]");
			object obj90 = (nint)0 + (nint)8;
			bool flag21 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ X10_v34-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ X10_v34-8]");
				object obj7 = 0 - obj88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1421 @ X10_v34-8]");
				if (0 == (nint)obj88)
				{
					break;
				}
				obj8 = obj90 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v78+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag21 = flag3;
				obj90 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0add;
			}
			obj4 = obj90;
			object obj91 = obj89 + obj90;
			object obj92 = obj91 + 312;
			flag3 = flag21;
			obj8 = obj90;
			goto IL_19e5;
		}
		goto IL_1388;
		IL_1705:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v78+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v940 @ X0_v78] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v78+8]");
		if ((nint)0 != 0)
		{
			object obj93 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2752;
			object obj94 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v67+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v67+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04db;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v67+B0]");
			object obj95 = (nint)0 + (nint)8;
			bool flag22 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X10_v50-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X10_v50-8]");
				object obj7 = 0 - obj93;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X10_v50-8]");
				if (0 == (nint)obj93)
				{
					break;
				}
				obj8 = obj95 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X8_v67+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag22 = flag3;
				obj95 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_04db;
			}
			obj4 = obj95;
			object obj96 = obj94 + obj95;
			object obj97 = obj96 + 312;
			flag3 = flag22;
			obj8 = obj95;
			goto IL_1794;
		}
		NullReferenceException ex4 = new NullReferenceException();
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		coordinatorVariableBinder4 = this;
		goto IL_1d52;
		IL_19e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X0_v94+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1470 @ X0_v94] (should have been resolved before IL gen)");
		goto IL_1388;
		IL_1388:
		OutOfMemoryException ex5 = new OutOfMemoryException();
		obj12 = (object)(&obj2);
		obj62 = 0;
		obj2 = obj63;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		coordinatorVariableBinder4 = this;
		goto IL_1d52;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_1670;
		IL_1670:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v74+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ X0_v74] (should have been resolved before IL gen)");
		object obj99 = default(object);
		object obj98 = obj99 & 1;
		if (obj98 != null)
		{
			if (obj != null)
			{
				object obj100 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 32;
				object obj101 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v62+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v62+12E]");
				if ((nint)0 == 0)
				{
					goto IL_039f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v62+B0]");
				object obj102 = (nint)0 + (nint)8;
				bool flag23 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X10_v55-8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X10_v55-8]");
					object obj7 = 0 - obj100;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v908 @ X10_v55-8]");
					if (0 == (nint)obj100)
					{
						break;
					}
					obj8 = obj102 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v62+12E]");
					obj4 = -1;
					obj7 = obj4 - 1;
					bool flag4 = obj7 == null;
					flag3 = (nint)obj4 != 1;
					flag23 = flag3;
					obj102 = obj8;
					if (flag3)
					{
						continue;
					}
					goto IL_039f;
				}
				obj4 = obj102;
				object obj103 = obj101 + obj102;
				object obj104 = obj103 + 312;
				flag3 = flag23;
				obj8 = obj102;
				goto IL_1705;
			}
			NullReferenceException ex6 = new NullReferenceException();
			obj15 = (object)(&obj);
			obj39 = 0;
			obj29 = (object)(&obj2);
			coordinatorVariableBinder4 = this;
			goto IL_1d52;
		}
		object obj105 = (object)(&obj);
		obj37 = obj105;
		bool flag24 = obj105 == null;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		coordinatorVariableBinder2 = this;
		obj31 = 0;
		coordinatorVariableBinder4 = this;
		obj34 = 7;
		obj11 = obj12;
		obj13 = obj6;
		obj14 = (object)(&obj);
		obj39 = 0;
		obj16 = obj17;
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj23;
		obj24 = obj25;
		obj26 = obj27;
		obj28 = (object)(&obj2);
		coordinatorVariableBinder = this;
		obj30 = 0;
		num2 = num4;
		flag5 = flag3;
		obj32 = obj8;
		coordinatorVariableBinder3 = this;
		obj33 = 7;
		if (!flag24)
		{
			goto IL_0d15;
		}
		goto IL_1a6d;
		IL_039f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = 0;
		goto IL_1705;
		IL_0d15:
		object obj106 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj107 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v44+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v44+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ddd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v44+B0]");
		object obj108 = (nint)0 + (nint)8;
		bool flag25 = flag3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X10_v18-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X10_v18-8]");
			if (0 == (nint)obj106)
			{
				break;
			}
			obj8 = obj108 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v44+12E]");
			obj4 = -1;
			flag3 = (nint)obj4 != 1;
			flag25 = flag3;
			obj108 = obj8;
			if (flag3)
			{
				continue;
			}
			goto IL_0ddd;
		}
		obj4 = obj108;
		object obj109 = obj107 + obj108;
		object obj110 = obj109 + 312;
		num2 = num4;
		flag3 = flag25;
		obj8 = obj108;
		goto IL_1b31;
		IL_097c:
		NullReferenceException ex7 = new NullReferenceException();
		obj12 = (object)(&obj2);
		obj62 = 0;
		obj6 = obj65;
		obj2 = obj63;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj17 = obj66;
		obj21 = obj67;
		obj29 = (object)(&obj2);
		num4 = num6;
		obj8 = obj68;
		coordinatorVariableBinder4 = this;
		num3 = num5;
		goto IL_1d52;
		IL_1002:
		IEnumerable<KeyValuePair<object, object>> source = Enumerable.Where((IEnumerable<KeyValuePair<object, object>>)coordinatorVariableBinder._binds, predicate);
		object obj111 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v11+E4]");
		bool flag26 = (nint)0 == 0;
		object obj112 = !flag26;
		if (obj112 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj111 = obj18;
		}
		obj27 = (nint)0 + (nint)2768;
		object obj113 = (nint)0 + (nint)2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v11+B8]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v19+20]");
		Func<KeyValuePair<object, object>, object> selector = (Func<KeyValuePair<object, object>, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ X8_v19+20]");
		bool flag27 = (nint)0 == 0;
		object obj115 = !flag27;
		if (obj115 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v11+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v11+E4]");
			bool flag28 = (nint)0 == 0;
			object obj116 = !flag28;
			if (obj116 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj117 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ X8_v25+B8]");
				obj114 = 0;
			}
			obj16 = obj114;
			object obj118 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj119 = (nint)0 + (nint)3632;
			Func<KeyValuePair<object, object>, object> func2 = default(Func<KeyValuePair<object, object>, object>);
			func2..ctor(obj114, (IntPtr)obj119);
			object obj120 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ X8_v24+B8]");
			object obj121 = (nint)0 + (nint)32;
			obj121 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			selector = func2;
		}
		num4 = (nint)obj27;
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		num3 = (nint)obj113;
		List<object> list = Enumerable.ToList(source2);
		bool flag29 = list == null;
		obj12 = obj11;
		obj6 = obj13;
		obj15 = obj14;
		obj17 = obj16;
		obj19 = obj18;
		obj21 = obj20;
		obj23 = obj22;
		obj25 = obj24;
		obj29 = obj28;
		obj8 = obj32;
		coordinatorVariableBinder4 = coordinatorVariableBinder3;
		if (!flag29)
		{
			object obj122 = (nint)0 + (nint)1872;
			obj19 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
			obj17 = (nint)0 + (nint)1864;
			List<object>.Enumerator enumerator = list.GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			while (true)
			{
				num3 = (nint)obj122;
				if (enumerator2.MoveNext())
				{
					IDictionary<string, IDictionary<string, List<BindAction>>> binds2 = coordinatorVariableBinder._binds;
					if (coordinatorVariableBinder._binds == null)
					{
						break;
					}
					nint num8 = (nint)binds2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
						obj32 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X10_v9-8]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X10_v9-8]");
							obj40 = 0 - obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X10_v9-8]");
							if (0 == (nint)obj19)
							{
								break;
							}
							obj32 += 16;
							obj4--;
							obj40 = obj4 - 1;
							bool flag30 = obj40 == null;
							if ((nint)obj4 != 1)
							{
								continue;
							}
							goto IL_11b5;
						}
						obj4 = obj32 + 6;
						object obj123 = num8 + obj4;
						object obj124 = obj123 + 312;
						goto IL_11c4;
					}
					goto IL_11b5;
				}
				enumerator2.Dispose();
				return;
				IL_11b5:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_11c4;
				IL_11c4:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1496 @ X0_v23+8]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1496 @ X0_v23] (should have been resolved before IL gen)");
			}
			NullReferenceException ex8 = new NullReferenceException();
			obj12 = obj11;
			obj6 = obj13;
			obj15 = (object)(&enumerator2);
			obj39 = 0;
			obj21 = obj20;
			obj23 = obj22;
			obj25 = obj24;
			obj29 = obj28;
			obj8 = obj32;
			coordinatorVariableBinder4 = coordinatorVariableBinder3;
		}
		goto IL_1d52;
		IL_0b9c:
		NullReferenceException ex9 = new NullReferenceException();
		obj12 = (object)(&obj2);
		obj62 = 0;
		obj2 = obj63;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		coordinatorVariableBinder4 = this;
		goto IL_1d52;
		IL_1d52:
		throw new NullReferenceException();
	}
}
