using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server;

public class VariableBinder
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Predicate<BindAction> <>9__15_2;

		public static Func<KeyValuePair<string, List<BindAction>>, IEnumerable<BindAction>> <>9__15_3;

		public static Func<KeyValuePair<string, IDictionary<string, List<BindAction>>>, bool> <>9__15_0;

		public static Func<KeyValuePair<string, IDictionary<string, List<BindAction>>>, string> <>9__15_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ClearNulls>b__15_2(BindAction go)
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

		internal bool <ClearNulls>b__15_0(KeyValuePair<string, IDictionary<string, List<BindAction>>> u)
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
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1672;
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
				object obj9 = (nint)0 + (nint)2472;
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

		internal IEnumerable<BindAction> <ClearNulls>b__15_3(KeyValuePair<string, List<BindAction>> a)
		{
			//IL_000a: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<BindAction>)(nint)intPtr;
		}

		internal string <ClearNulls>b__15_1(KeyValuePair<string, IDictionary<string, List<BindAction>>> e)
		{
			return (string)e;
		}
	}

	private sealed class <>c__DisplayClass8_0
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

	private sealed class <>c__DisplayClass9_0
	{
		public BindAction bindAction;

		internal bool <Bind>b__0(BindAction bAction)
		{
			//IL_0158: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I4
			bool flag;
			if (bAction != null)
			{
				BindAction bindAction = this.bindAction;
				if (this.bindAction != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
					if ((nint)0 != 0)
					{
						flag = bAction.<GameObject>k__BackingField == bindAction.<GameObject>k__BackingField;
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 == null)
						{
							goto IL_00ae;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = bAction.<GameObject>k__BackingField == bindAction.<GameObject>k__BackingField;
						if (!flag)
						{
							goto IL_00ae;
						}
					}
					BindAction bindAction2 = this.bindAction;
					if (this.bindAction != null)
					{
						object obj4 = bAction.<Owner>k__BackingField - bindAction2.<Owner>k__BackingField;
						return obj4 == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ae:
			return flag;
		}
	}

	private IDictionary<string, IDictionary<string, List<BindAction>>> binds;

	private string GetBindID(User user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj2;
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			obj2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1096;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
				goto IL_00bc;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_013a;
		}
		return (string)(object)new NullReferenceException();
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X0_v3] (should have been resolved before IL gen)");
		int num2 = default(int);
		string text = num2.ToString();
		return (string)obj2 + text;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_013a;
	}

	private string GetBindID(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj2;
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			obj2 = "placementId" + 2064;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v5-8]");
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
				goto IL_00bc;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_013a;
		}
		return (string)(object)new NullReferenceException();
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X0_v3] (should have been resolved before IL gen)");
		int num2 = default(int);
		string text = num2.ToString();
		return (string)obj2 + text;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_013a;
	}

	public VariableBinder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0094: Expected I, but got O
		//IL_00ba: Expected I, but got O
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2048;
		object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 784;
		object obj3 = (nint)0 + (nint)1648;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 640;
		object obj5 = (nint)0 + (nint)1640;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj6 = this + 16;
		obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnUserVariableUpdate += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj5);
		SFS.OnRoomVariableUpdate += action2;
	}

	private void OnUserVariableUpdate(User user, List<string> changedVars)
	{
		string bindID = GetBindID(user);
		DispatchUpdate(bindID, changedVars);
	}

	private void OnRoomVariableUpdate(Room room, List<string> changedVars)
	{
		string bindID = GetBindID(room);
		DispatchUpdate(bindID, changedVars);
	}

	public void Bind(BindAction bindAction, User user, string variableName)
	{
		if (user != null)
		{
			string bindID = GetBindID(user);
			Bind(bindAction, bindID, variableName);
			Action <Action>k__BackingField = bindAction.<Action>k__BackingField;
			IntPtr invoke_impl = ((Delegate)<Action>k__BackingField).invoke_impl;
			IntPtr method_code = ((Delegate)<Action>k__BackingField).method_code;
			IntPtr method = ((Delegate)<Action>k__BackingField).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Bind(BindAction bindAction, Room room, string variableName)
	{
		if (room != null)
		{
			string bindID = GetBindID(room);
			Bind(bindAction, bindID, variableName);
			Action <Action>k__BackingField = bindAction.<Action>k__BackingField;
			IntPtr invoke_impl = ((Delegate)<Action>k__BackingField).invoke_impl;
			IntPtr method_code = ((Delegate)<Action>k__BackingField).method_code;
			IntPtr method = ((Delegate)<Action>k__BackingField).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
		}
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
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1680;
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
			IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = binds;
			bool flag2 = binds == null;
			obj3 = 0;
			gameObject2 = null;
			gameObject3 = gameObject;
			obj4 = 152993792;
			if (!flag2)
			{
				object obj6 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2744;
				nint num = (nint)dictionary;
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
			obj28 = (nint)0 + (nint)2480;
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

	private void Bind(BindAction bindAction, string id, string variableName)
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
		//IL_012e: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_01c8: Expected I, but got O
		//IL_01d8: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04c7: Expected I, but got O
		//IL_04d7: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0376: Expected I, but got O
		//IL_0386: Expected O, but got I
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0a5b: Expected O, but got I
		//IL_0a67: Expected O, but got I
		//IL_0a77: Expected O, but got I
		//IL_0512: Expected O, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I
		//IL_030c: Expected O, but got I4
		//IL_041c: Expected O, but got I
		//IL_0440: Expected O, but got I4
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_0757: Expected I, but got O
		//IL_0767: Expected O, but got I
		//IL_0598: Expected I, but got O
		//IL_05a8: Expected O, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_063e: Expected O, but got I
		//IL_0662: Expected O, but got I4
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_0b2f: Expected O, but got I
		//IL_07a2: Expected O, but got I
		//IL_0ae5: Expected I, but got O
		//IL_05e3: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_0830: Expected O, but got I
		//IL_0690: Expected O, but got I
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected O, but got Unknown
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06c8: Expected O, but got I
		//IL_06ec: Expected O, but got I4
		//IL_0704: Expected O, but got I
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_07be: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_0911: Expected O, but got I4
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected O, but got Unknown
		//IL_086b: Expected O, but got I
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_098b: Expected O, but got I
		//IL_0892: Expected O, but got I
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08b0: Expected O, but got I
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_096f: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = bindAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = binds;
		object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v4 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v39-8]");
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
		object obj7 = obj6 + 4;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v66+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v66] (should have been resolved before IL gen)");
		object obj11 = default(object);
		bool flag = obj11 == null;
		string text = id;
		if (!flag)
		{
			goto IL_01b1;
		}
		goto IL_0332;
		IL_0332:
		object obj12 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		dictionary2..ctor();
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary3 = binds;
		nint num2 = (nint)dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v33 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v33 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0402;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v33 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X10_v28-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0402;
		}
		object obj15 = obj14 + 5;
		object obj16 = num2 + obj15;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v51+8]");
		string text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v600 @ X0_v51] (should have been resolved before IL gen)");
		Dictionary<object, object> dictionary4 = dictionary2;
		goto IL_04ab;
		IL_0722:
		object obj18 = typeof(List<AdaptivePerformanceScaler>) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		nint num3 = (nint)dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v21 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v21 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07e3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X8_v21 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		object obj21;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X10_v12-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_07e3;
		}
		object obj22 = obj20 + 5;
		object obj23 = num3 + obj22;
		object obj24 = obj23 + 312;
		goto IL_0b1f;
		IL_0624:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v35+8]");
		List<object> list2 = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v710 @ X0_v35] (should have been resolved before IL gen)");
		List<object> list3 = default(List<object>);
		bool flag2 = list3 == null;
		object obj25 = !flag2;
		string text3 = variableName;
		List<object> list4 = list3;
		List<object> list5;
		string text4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v35+8]");
			list5 = (List<object>)0;
			text4 = variableName;
			goto IL_0722;
		}
		goto IL_0aca;
		IL_07e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0b1f;
		IL_00f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v63+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v355 @ X0_v63] (should have been resolved before IL gen)");
		object obj26 = default(object);
		bool flag3 = obj26 == null;
		object obj27 = !flag3;
		if (obj27 != null)
		{
			goto IL_01b1;
		}
		text = id;
		goto IL_0332;
		IL_01b1:
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary5 = binds;
		nint num4 = (nint)dictionary5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v38 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v38 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0254;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v38 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X10_v34-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj29 += 16;
			obj28--;
			if ((nint)obj28 != 1)
			{
				continue;
			}
			goto IL_0254;
		}
		object obj30 = num4 + obj29;
		object obj31 = obj30 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v59+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ X0_v59] (should have been resolved before IL gen)");
		Dictionary<object, object> dictionary6 = default(Dictionary<object, object>);
		bool flag4 = dictionary6 == null;
		object obj32 = !flag4;
		text = id;
		text2 = variableName;
		dictionary4 = dictionary6;
		if (obj32 == null)
		{
			goto IL_0332;
		}
		goto IL_04ab;
		IL_0b1f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X0_v28+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v819 @ X0_v28] (should have been resolved before IL gen)");
		list2 = list;
		text3 = variableName;
		list4 = list;
		goto IL_0aca;
		IL_0402:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v48+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X0_v48] (should have been resolved before IL gen)");
		bool flag5 = dictionary2 == null;
		object obj33 = !flag5;
		dictionary4 = dictionary2;
		if (obj33 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_04ab;
		IL_04ab:
		obj21 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
		nint num5 = (nint)dictionary4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0553;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v6 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X10_v22-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0553;
		}
		object obj36 = obj35 + 4;
		object obj37 = num5 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0a3b;
		IL_0aca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		object obj39;
		func..ctor(obj2, (IntPtr)obj39);
		object obj40 = Enumerable.FirstOrDefault(list4, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		object obj41 = 0;
		if (obj40 != null)
		{
			object obj42 = obj40 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X1_v12 (System.Object)+18]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj43 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+10]");
			obj41 = 0;
			object obj44 = obj40 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+10]");
			obj44 = 0;
			object obj45 = obj44;
		}
		else
		{
			int version = list4._version + 1;
			list4._version = version;
			object[] items = list4._items;
			bool flag6 = list4._size < items.Length;
			object obj46 = !flag6;
			if (obj46 != null)
			{
				List<object> list6 = list4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
				list6.AddWithResize((object)0);
				return;
			}
			int size = list4._size + 1;
			list4._size = size;
			object obj47 = items + list4._size;
			object obj45 = obj47 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
			obj45 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0254:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v56+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v56] (should have been resolved before IL gen)");
		Dictionary<object, object> dictionary7 = default(Dictionary<object, object>);
		bool flag7 = dictionary7 == null;
		object obj48 = !flag7;
		text2 = variableName;
		dictionary4 = dictionary7;
		if (obj48 == null)
		{
			text = id;
			goto IL_0332;
		}
		goto IL_04ab;
		IL_0a3b:
		object obj49 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 328;
		obj39 = (nint)0 + (nint)2488;
		object obj50 = (nint)0 + (nint)656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X0_v9+8]");
		list5 = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v620 @ X0_v9] (should have been resolved before IL gen)");
		object obj51 = default(object);
		bool flag8 = obj51 == null;
		text4 = variableName;
		if (!flag8)
		{
			nint num6 = (nint)dictionary4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v25 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v25 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0624;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v25 (Il2CppClass<System.Collections.Generic.Dictionary`2<System.Object, System.Object>>)+B0]");
			object obj53 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X10_v17-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				obj53 += 16;
				obj52--;
				if ((nint)obj52 != 1)
				{
					continue;
				}
				goto IL_0624;
			}
			object obj54 = num6 + obj53;
			object obj55 = obj54 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v38+8]");
			list5 = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v732 @ X0_v38] (should have been resolved before IL gen)");
			List<object> list7 = default(List<object>);
			bool flag9 = list7 == null;
			object obj56 = !flag9;
			text4 = variableName;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v38+8]");
			list2 = (List<object>)0;
			text3 = variableName;
			list4 = list7;
			if (obj56 != null)
			{
				goto IL_0aca;
			}
		}
		goto IL_0722;
		IL_0553:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a3b;
	}

	private void DispatchUserUpdate(User user, IEnumerable<string> changedVars)
	{
		string bindID = GetBindID(user);
		DispatchUpdate(bindID, changedVars);
	}

	private void DispatchRoomUpdate(Room room, IEnumerable<string> changedVars)
	{
		string bindID = GetBindID(room);
		DispatchUpdate(bindID, changedVars);
	}

	private void DispatchUpdate(string bindId, IEnumerable<string> changedVars)
	{
		//IL_0b7f: Expected O, but got I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0be9: Expected O, but got I
		//IL_0c0c: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Expected O, but got Unknown
		//IL_0acc: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01fe: Expected I, but got O
		//IL_020e: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0c6c: Expected O, but got I
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Expected O, but got Unknown
		//IL_0249: Expected O, but got I
		//IL_091e: Expected O, but got I4
		//IL_0936: Expected O, but got I
		//IL_093f: Expected O, but got I4
		//IL_0c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0f75: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_027a: Expected O, but got I
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0960: Expected I, but got O
		//IL_0970: Expected O, but got I
		//IL_033f: Expected I, but got O
		//IL_034f: Expected O, but got I
		//IL_0fb7: Expected O, but got I
		//IL_09ab: Expected O, but got I
		//IL_0cf3: Expected O, but got I
		//IL_038a: Expected O, but got I
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0463: Expected I, but got O
		//IL_0473: Expected O, but got I
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected O, but got Unknown
		//IL_09d4: Expected O, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_0d78: Expected O, but got I
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_04ae: Expected O, but got I
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3e: Expected O, but got Unknown
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0aa4: Expected O, but got I
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04df: Expected O, but got I
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_05b1: Expected I, but got O
		//IL_05c1: Expected O, but got I
		//IL_0e07: Expected O, but got I
		//IL_05fc: Expected O, but got I
		//IL_0dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Expected O, but got Unknown
		//IL_06d0: Expected I, but got O
		//IL_06e0: Expected O, but got I
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_062d: Expected O, but got I
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0e90: Expected O, but got I
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected O, but got Unknown
		//IL_071b: Expected O, but got I
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Expected O, but got Unknown
		//IL_07f5: Expected I, but got O
		//IL_0805: Expected O, but got I
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_074c: Expected O, but got I
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0f26: Expected O, but got I
		//IL_0840: Expected O, but got I
		//IL_0ee8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected O, but got Unknown
		//IL_0871: Expected O, but got I
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		ClearNulls();
		IEnumerable<string> enumerable = default(IEnumerable<string>);
		bool flag = enumerable == null;
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = (IDictionary<string, IDictionary<string, List<BindAction>>>)152993792;
		if (flag)
		{
			goto IL_0b8d;
		}
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3760;
		nint num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj5 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v55-8]");
			object obj4 = 0 - obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v55-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj3 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			obj2 = -1;
			obj4 = obj2 - 1;
			bool flag4 = obj4 == null;
			flag3 = (nint)obj2 != 1;
			flag2 = flag3;
			obj3 = obj5;
			if (flag3)
			{
				continue;
			}
			goto IL_00f2;
		}
		obj2 = obj3;
		object obj6 = num + obj3;
		object obj7 = obj6 + 312;
		IEnumerable<string> enumerable2 = enumerable;
		flag3 = flag2;
		obj5 = obj3;
		goto IL_0bd9;
		IL_0a4f:
		NullReferenceException ex = new NullReferenceException();
		enumerable2 = enumerable;
		object obj8;
		obj5 = obj8;
		goto IL_0ab9;
		IL_0a8b:
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v38+8]");
		enumerable2 = (IEnumerable<string>)0;
		obj5 = obj8;
		string text2 = default(string);
		string text = text2;
		goto IL_0ab9;
		IL_0a41:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0ab9;
		IL_0b8d:
		throw new NullReferenceException();
		IL_0ab9:
		IEnumerable<string> enumerable4 = default(IEnumerable<string>);
		IEnumerable<string> enumerable3 = enumerable4;
		object obj9 = 0;
		enumerable = enumerable2;
		text2 = text;
		goto IL_0b8d;
		IL_00f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		enumerable2 = null;
		goto IL_0bd9;
		IL_0bd9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v23+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ X0_v23] (should have been resolved before IL gen)");
		bool flag5 = enumerable4 == null;
		dictionary = (IDictionary<string, IDictionary<string, List<BindAction>>>)152993792;
		if (flag5)
		{
			goto IL_0a41;
		}
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1192;
		object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
		object obj14 = (nint)0 + (nint)1864;
		enumerable = enumerable2;
		obj8 = obj5;
		IEnumerable<string> enumerable5 = enumerable4;
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary2 = default(IDictionary<string, IDictionary<string, List<BindAction>>>);
		object obj22 = default(object);
		object obj32 = default(object);
		IEnumerable<object> source = default(IEnumerable<object>);
		object obj34 = default(object);
		object obj42 = default(object);
		IEnumerable<string> enumerable6 = default(IEnumerable<string>);
		while (true)
		{
			nint num2 = (nint)enumerable5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+B0]");
			object obj15 = (nint)0 + (nint)8;
			bool flag6 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X10_v50-8]");
				object obj4 = 0 - obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X10_v50-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj8 = obj15 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag4 = obj4 == null;
				flag3 = (nint)obj2 != 1;
				flag6 = flag3;
				obj15 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_02ce;
			}
			obj2 = obj15;
			object obj16 = num2 + obj15;
			object obj17 = obj16 + 312;
			flag3 = flag6;
			obj8 = obj15;
			goto IL_0c5b;
			IL_0681:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0df6;
			IL_0df6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v42+8]");
			enumerable = (IEnumerable<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v885 @ X0_v42] (should have been resolved before IL gen)");
			bool flag7 = dictionary2 == null;
			text = text2;
			dictionary = dictionary2;
			if (flag7)
			{
				goto IL_01c1;
			}
			nint num3 = (nint)dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v34 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v34 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07a0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v34 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj18 = (nint)0 + (nint)8;
			bool flag8 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X10_v29-8]");
				object obj4 = 0 - obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X10_v29-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj8 = obj18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X8_v34 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag4 = obj4 == null;
				flag3 = (nint)obj2 != 1;
				flag8 = flag3;
				obj18 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_07a0;
			}
			obj2 = obj18 + 4;
			object obj19 = num3 + obj2;
			object obj20 = obj19 + 312;
			flag3 = flag8;
			obj8 = obj18;
			goto IL_0e7f;
			IL_08c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0f16;
			IL_02ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_0c5b;
			IL_0c5b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v30+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v516 @ X0_v30] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				if (enumerable4 == null)
				{
					break;
				}
				nint num4 = (nint)enumerable4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_040f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+B0]");
				object obj23 = (nint)0 + (nint)8;
				bool flag9 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v45-8]");
					object obj4 = 0 - obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v45-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj8 = obj23 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
					obj2 = -1;
					obj4 = obj2 - 1;
					bool flag4 = obj4 == null;
					flag3 = (nint)obj2 != 1;
					flag9 = flag3;
					obj23 = obj8;
					if (flag3)
					{
						continue;
					}
					goto IL_040f;
				}
				obj2 = obj23;
				object obj24 = num4 + obj23;
				object obj25 = obj24 + 312;
				flag3 = flag9;
				obj8 = obj23;
				goto IL_0ce2;
			}
			enumerable3 = enumerable4;
			obj9 = 0;
			obj5 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v30+8]");
			text2 = (string)0;
			object obj26 = 0;
			while (true)
			{
				if (enumerable3 == null)
				{
					goto IL_0f5b;
				}
				object obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num5 = (nint)enumerable3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_09fc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+B0]");
				object obj28 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v7-8]");
					if (0 == (nint)obj27)
					{
						break;
					}
					obj5 = obj28 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.String>>)+12E]");
					obj2 = -1;
					bool flag10 = (nint)obj2 != 1;
					obj28 = obj5;
					if (flag10)
					{
						continue;
					}
					goto IL_09fc;
				}
				obj2 = obj28;
				object obj29 = num5 + obj28;
				object obj30 = obj29 + 312;
				obj5 = obj28;
				goto IL_0fa7;
				IL_0f5b:
				bool flag11 = obj26 == null;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					return;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if ((nint)text2 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj26 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj9 = obj32;
				continue;
				IL_09fc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				enumerable = null;
				goto IL_0fa7;
				IL_0fa7:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X0_v5+8]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X0_v5] (should have been resolved before IL gen)");
				goto IL_0f5b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0533:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0d67;
			IL_0f16:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v48+8]");
			enumerable = (IEnumerable<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1010 @ X0_v48] (should have been resolved before IL gen)");
			text = (string)obj14;
			List<object> bindActions = Enumerable.ToList(source);
			SafelyDispatchBindActions((List<BindAction>)(object)bindActions);
			dictionary = dictionary2;
			goto IL_01c1;
			IL_01c1:
			bool flag12 = enumerable4 == null;
			enumerable5 = enumerable4;
			enumerable2 = enumerable;
			obj5 = obj8;
			if (!flag12)
			{
				continue;
			}
			goto IL_0a41;
			IL_0d67:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v38+8]");
			enumerable = (IEnumerable<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v767 @ X0_v38] (should have been resolved before IL gen)");
			object obj33 = obj34 & 1;
			bool flag13 = obj33 == null;
			text = text2;
			if (flag13)
			{
				goto IL_01c1;
			}
			dictionary = binds;
			if (binds == null)
			{
				goto IL_0a8b;
			}
			nint num6 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0681;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj35 = (nint)0 + (nint)8;
			bool flag14 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X10_v34-8]");
				object obj4 = 0 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X10_v34-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj8 = obj35 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag4 = obj4 == null;
				flag3 = (nint)obj2 != 1;
				flag14 = flag3;
				obj35 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0681;
			}
			obj2 = obj35;
			object obj36 = num6 + obj35;
			object obj37 = obj36 + 312;
			flag3 = flag14;
			obj8 = obj35;
			goto IL_0df6;
			IL_07a0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0e7f;
			IL_040f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_0ce2;
			IL_0ce2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v34+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X0_v34] (should have been resolved before IL gen)");
			dictionary = binds;
			if (binds == null)
			{
				goto IL_0a4f;
			}
			nint num7 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0533;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj38 = (nint)0 + (nint)8;
			bool flag15 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v40-8]");
				object obj4 = 0 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X10_v40-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj8 = obj38 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag4 = obj4 == null;
				flag3 = (nint)obj2 != 1;
				flag15 = flag3;
				obj38 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_0533;
			}
			obj2 = obj38 + 4;
			object obj39 = num7 + obj2;
			object obj40 = obj39 + 312;
			flag3 = flag15;
			obj8 = obj38;
			goto IL_0d67;
			IL_0e7f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v45+8]");
			enumerable = (IEnumerable<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v948 @ X0_v45] (should have been resolved before IL gen)");
			object obj41 = obj42 & 1;
			bool flag16 = obj41 == null;
			text = (string)(object)enumerable6;
			dictionary = dictionary2;
			if (flag16)
			{
				goto IL_01c1;
			}
			nint num8 = (nint)dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj43 = (nint)0 + (nint)8;
			bool flag17 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X10_v24-8]");
				object obj4 = 0 - obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X10_v24-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj8 = obj43 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v37 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
				obj2 = -1;
				obj4 = obj2 - 1;
				bool flag4 = obj4 == null;
				flag3 = (nint)obj2 != 1;
				flag17 = flag3;
				obj43 = obj8;
				if (flag3)
				{
					continue;
				}
				goto IL_08c5;
			}
			obj2 = obj43;
			object obj44 = num8 + obj43;
			object obj45 = obj44 + 312;
			flag3 = flag17;
			obj8 = obj43;
			goto IL_0f16;
		}
		NullReferenceException ex5 = new NullReferenceException();
		enumerable2 = enumerable;
		obj5 = obj8;
		goto IL_0ab9;
	}

	private void DispatchAllBoundedVars(string bindId)
	{
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Expected O, but got Unknown
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0e52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e57: Expected O, but got Unknown
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected O, but got Unknown
		//IL_0130: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0c28: Expected O, but got I
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected O, but got Unknown
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected O, but got Unknown
		//IL_0c7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Expected O, but got Unknown
		//IL_07ba: Expected O, but got I
		//IL_0220: Expected I, but got O
		//IL_0230: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a8: Expected I, but got O
		//IL_08b6: Expected I, but got O
		//IL_034b: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0f06: Expected O, but got I
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1e: Expected O, but got Unknown
		//IL_07f5: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_0a75: Expected O, but got I4
		//IL_0a7e: Expected O, but got I4
		//IL_0e81: Expected O, but got I
		//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e98: Expected O, but got Unknown
		//IL_0ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec4: Expected O, but got Unknown
		//IL_0ed4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed9: Expected O, but got Unknown
		//IL_0cac: Expected O, but got I
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Expected O, but got Unknown
		//IL_0cea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected O, but got Unknown
		//IL_0923: Expected O, but got I
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_08f6: Expected O, but got I
		//IL_0427: Expected O, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected O, but got Unknown
		//IL_100e: Expected O, but got I4
		//IL_0a27: Expected I, but got O
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_0826: Expected O, but got I
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_0570: Expected I, but got O
		//IL_0580: Expected O, but got I
		//IL_0d30: Expected O, but got I
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Expected O, but got Unknown
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aaf: Expected O, but got I
		//IL_096e: Expected O, but got I
		//IL_0684: Expected I, but got O
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected I, but got Unknown
		//IL_0716: Expected O, but got I4
		//IL_0726: Expected O, but got I
		//IL_0b4a: Expected I, but got O
		//IL_0f4b: Expected O, but got I
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Expected O, but got Unknown
		//IL_0f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8e: Expected O, but got Unknown
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_1050: Expected O, but got I
		//IL_0aea: Expected O, but got I
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0db4: Expected O, but got I
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcb: Expected O, but got Unknown
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_099f: Expected O, but got I
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Expected O, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_064f: Expected O, but got I
		//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		//IL_0b13: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83C2]");
		nint num = 0;
		ClearNulls();
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = binds;
		object obj;
		bool flag2 = default(bool);
		object obj4 = default(object);
		object obj9 = default(object);
		nint num3 = default(nint);
		object obj5 = default(object);
		bool flag3 = default(bool);
		object obj6 = default(object);
		object obj7 = default(object);
		object obj8 = default(object);
		if (binds != null)
		{
			obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
			nint num2 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v29 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v29 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_011e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v29 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v49-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v49-8]");
				obj5 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v49-8]");
				flag3 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v49-8]");
				obj6 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v49-8]");
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
			object obj10 = obj3 + 4;
			object obj11 = num2 + obj10;
			object obj12 = obj11 + 312;
			num = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v64+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v64] (should have been resolved before IL gen)");
			object obj13 = default(object);
			bool flag4 = obj13 == null;
			flag2 = flag;
			obj9 = obj3;
			if (!flag4)
			{
				goto IL_01ef;
			}
			return;
		}
		goto IL_0774;
		IL_066d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj14;
		obj4 = obj14;
		num3 = unchecked((nint)null);
		bool flag5;
		flag2 = flag5;
		object obj15;
		obj8 = obj15;
		object obj16;
		obj7 = obj16;
		object obj17;
		obj6 = obj17;
		bool flag6;
		flag3 = flag6;
		object obj18;
		obj5 = obj18;
		object obj19;
		obj9 = obj19;
		object obj21 = default(object);
		object obj20 = obj21;
		goto IL_0e30;
		IL_0782:
		object obj22 = num + obj9;
		obj20 = obj22 + 312;
		goto IL_0e30;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v54+8]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v54] (should have been resolved before IL gen)");
		object obj23 = default(object);
		bool flag7 = obj23 == null;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			return;
		}
		goto IL_03c0;
		IL_03c0:
		object obj25 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2408;
		object obj26 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v35+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v35+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04c9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v35+B0]");
		obj19 = (nint)0 + (nint)8;
		flag5 = flag2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
			obj18 = 0 - obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
			flag6 = 0 == (nint)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
			obj17 = 0 ^ obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
			obj16 = 0 ^ obj18;
			obj15 = obj17 & obj16;
			if (flag6)
			{
				break;
			}
			obj9 = obj19 + 16;
			obj27--;
			obj5 = obj27 - 1;
			flag3 = obj5 == null;
			obj6 = obj27 ^ 1;
			obj7 = obj27 ^ obj5;
			obj8 = obj6 & obj7;
			flag2 = (nint)obj27 != 1;
			flag5 = flag2;
			obj19 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_04c9;
		}
		object obj28 = obj19 + 3;
		object obj29 = obj26 + obj28;
		num = (nint)(obj29 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X8_v25 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag8 = ex == null;
		object obj30 = !flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X10_v31-8]");
		obj14 = 0;
		num3 = num4;
		flag2 = flag5;
		obj8 = obj15;
		obj7 = obj16;
		obj6 = obj17;
		flag3 = flag6;
		obj5 = obj18;
		obj9 = obj19;
		if (obj30 != null)
		{
			goto IL_0554;
		}
		goto IL_0774;
		IL_0e30:
		object obj31 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X8_v3] (should have been resolved before IL gen)");
		object obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj33 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 152;
		object obj34 = default(object);
		object obj41;
		object obj43 = default(object);
		object obj49;
		List<BindAction> bindActions = default(List<BindAction>);
		while (true)
		{
			object obj37;
			object obj40;
			nint num5;
			if (obj34 != null)
			{
				object obj35 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v16+12E]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_089f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v16+B0]");
				obj37 = (nint)0 + (nint)8;
				bool flag9 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
					obj5 = 0 - obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
					flag3 = 0 == (nint)obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
					obj6 = 0 ^ obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
					obj7 = 0 ^ obj5;
					obj8 = obj6 & obj7;
					if (flag3)
					{
						break;
					}
					obj9 = obj37 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v16+12E]");
					obj36 = -1;
					obj5 = obj36 - 1;
					flag3 = obj5 == null;
					obj6 = obj36 ^ 1;
					obj7 = obj36 ^ obj5;
					obj8 = obj6 & obj7;
					flag2 = (nint)obj36 != 1;
					flag9 = flag2;
					obj37 = obj9;
					if (flag2)
					{
						continue;
					}
					goto IL_089f;
				}
				obj36 = obj37;
				object obj38 = obj35 + obj37;
				object obj39 = obj38 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X10_v6-8]");
				obj40 = 0;
				num5 = num3;
				flag2 = flag9;
				goto IL_0ef5;
			}
			throw new NullReferenceException();
			IL_089f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj40 = obj4;
			num5 = unchecked((nint)null);
			obj37 = obj9;
			goto IL_0ef5;
			IL_0ef5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v27+8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v27] (should have been resolved before IL gen)");
			object obj42 = obj43 & 1;
			if (obj42 != null)
			{
				object obj44 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v19+12E]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v19+12E]");
				bool flag10 = (nint)0 == 0;
				obj4 = obj40;
				obj9 = obj37;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v19+B0]");
					object obj45 = (nint)0 + (nint)8;
					bool flag11 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X10_v18-8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X10_v18-8]");
						obj5 = 0 - obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X10_v18-8]");
						flag3 = 0 == (nint)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X10_v18-8]");
						obj6 = 0 ^ obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X10_v18-8]");
						obj7 = 0 ^ obj5;
						obj8 = obj6 & obj7;
						if (flag3)
						{
							break;
						}
						obj9 = obj45 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v19+12E]");
						obj31 = -1;
						obj5 = obj31 - 1;
						flag3 = obj5 == null;
						obj6 = obj31 ^ 1;
						obj7 = obj31 ^ obj5;
						obj8 = obj6 & obj7;
						flag2 = (nint)obj31 != 1;
						flag11 = flag2;
						obj45 = obj9;
						if (flag2)
						{
							continue;
						}
						goto IL_0a18;
					}
					obj31 = obj45;
					object obj46 = obj44 + obj45;
					object obj47 = obj46 + 312;
					num3 = num5;
					flag2 = flag11;
					obj9 = obj45;
					goto IL_0fbf;
				}
				goto IL_0a18;
			}
			object obj48 = 0;
			obj49 = 0;
			break;
			IL_0fbf:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ X0_v31] (should have been resolved before IL gen)");
			SafelyDispatchBindActions(bindActions);
			continue;
			IL_0a18:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = unchecked((nint)null);
			goto IL_0fbf;
		}
		object obj56 = default(object);
		while (true)
		{
			if (obj34 == null)
			{
				goto IL_0ff4;
			}
			object obj50 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj51 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v11+12E]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v11+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0b3b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v11+B0]");
			object obj52 = (nint)0 + (nint)8;
			object obj37;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X10_v10-8]");
				if (0 == (nint)obj50)
				{
					break;
				}
				obj37 = obj52 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v11+12E]");
				obj36 = -1;
				bool flag12 = (nint)obj36 != 1;
				obj52 = obj37;
				if (flag12)
				{
					continue;
				}
				goto IL_0b3b;
			}
			obj36 = obj52;
			object obj53 = obj51 + obj52;
			object obj54 = obj53 + 312;
			obj37 = obj52;
			goto IL_1040;
			IL_0ff4:
			bool flag13 = obj49 == null;
			object obj55 = !flag13;
			if (obj55 == null)
			{
				return;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)obj41 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj49 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj48 = obj56;
			continue;
			IL_0b3b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			nint num5 = unchecked((nint)null);
			goto IL_1040;
			IL_1040:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X0_v19+8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v896 @ X0_v19] (should have been resolved before IL gen)");
			goto IL_0ff4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_011e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj57 = default(object);
		num = (nint)obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v61+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v61] (should have been resolved before IL gen)");
		object obj58 = default(object);
		bool flag14 = obj58 == null;
		object obj59 = !flag14;
		if (obj59 == null)
		{
			return;
		}
		goto IL_01ef;
		IL_01ef:
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary2 = binds;
		if (binds != null)
		{
			nint num6 = (nint)dictionary2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_030d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v31 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj61 = (nint)0 + (nint)8;
			bool flag15 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v44-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v44-8]");
				obj5 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v44-8]");
				flag3 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v44-8]");
				obj6 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X10_v44-8]");
				obj7 = 0 ^ obj5;
				obj8 = obj6 & obj7;
				if (flag3)
				{
					break;
				}
				obj9 = obj61 + 16;
				obj60--;
				obj5 = obj60 - 1;
				flag3 = obj5 == null;
				obj6 = obj60 ^ 1;
				obj7 = obj60 ^ obj5;
				obj8 = obj6 & obj7;
				flag2 = (nint)obj60 != 1;
				flag15 = flag2;
				obj61 = obj9;
				if (flag2)
				{
					continue;
				}
				goto IL_030d;
			}
			object obj62 = num6 + obj61;
			object obj63 = obj62 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X0_v57+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v606 @ X0_v57] (should have been resolved before IL gen)");
			bool flag16 = obj23 == null;
			flag2 = flag15;
			obj9 = obj61;
			if (!flag16)
			{
				goto IL_03c0;
			}
			return;
		}
		goto IL_0774;
		IL_04c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v667 @ X0_v49 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag17 = ex == null;
		obj14 = obj4;
		num4 = 3;
		flag5 = flag2;
		obj15 = obj8;
		obj16 = obj7;
		obj17 = obj6;
		flag6 = flag3;
		obj18 = obj5;
		obj19 = obj9;
		num3 = 3;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag17)
		{
			goto IL_0554;
		}
		goto IL_0774;
		IL_0774:
		ex = new NullReferenceException();
		goto IL_0782;
		IL_0554:
		object obj64 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2824;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_066d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v25 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj9 = (nint)0 + (nint)8;
		flag2 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			obj5 = 0 - obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			flag3 = 0 == (nint)obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			obj6 = 0 ^ obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			obj7 = 0 ^ obj5;
			obj8 = obj6 & obj7;
			num3 = num4;
			if (flag3)
			{
				break;
			}
			obj19 = obj9 + 16;
			obj65--;
			obj18 = obj65 - 1;
			flag6 = obj18 == null;
			obj17 = obj65 ^ 1;
			obj16 = obj65 ^ obj18;
			obj15 = obj17 & obj16;
			flag5 = (nint)obj65 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v36-8]");
			obj14 = 0;
			flag2 = flag5;
			obj9 = obj19;
			if (flag5)
			{
				continue;
			}
			goto IL_066d;
		}
		goto IL_0782;
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
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = binds;
		bool flag = binds == null;
		object obj = 0;
		object obj2 = 0;
		bool flag3 = default(bool);
		object obj4;
		object obj6 = default(object);
		object obj8 = default(object);
		if (!flag)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2744;
			nint num = (nint)dictionary;
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
		VariableBinder variableBinder2;
		VariableBinder variableBinder = variableBinder2;
		object obj31;
		object obj30 = obj31;
		bool flag5 = flag3;
		object obj32 = obj8;
		VariableBinder variableBinder4;
		VariableBinder variableBinder3 = variableBinder4;
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
			variableBinder4 = variableBinder3;
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
					variableBinder2 = variableBinder4;
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
						variableBinder = variableBinder4;
						obj30 = obj36;
						num2 = num4;
						flag5 = flag3;
						obj32 = obj8;
						variableBinder3 = variableBinder4;
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
		object obj51 = (nint)0 + (nint)2448;
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
		obj19 = typeof(TrackedDeviceRaycaster.<>c) + 1672;
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
			obj25 = (nint)0 + (nint)2464;
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
		variableBinder4 = this;
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
		variableBinder4 = this;
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
		variableBinder4 = this;
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
		variableBinder4 = this;
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
			variableBinder4 = this;
			goto IL_1d52;
		}
		object obj105 = (object)(&obj);
		obj37 = obj105;
		bool flag24 = obj105 == null;
		obj15 = (object)(&obj);
		obj39 = 0;
		obj29 = (object)(&obj2);
		variableBinder2 = this;
		obj31 = 0;
		variableBinder4 = this;
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
		variableBinder = this;
		obj30 = 0;
		num2 = num4;
		flag5 = flag3;
		obj32 = obj8;
		variableBinder3 = this;
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
		variableBinder4 = this;
		num3 = num5;
		goto IL_1d52;
		IL_1002:
		IEnumerable<KeyValuePair<object, object>> source = Enumerable.Where((IEnumerable<KeyValuePair<object, object>>)variableBinder.binds, predicate);
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
			object obj119 = (nint)0 + (nint)2456;
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
		variableBinder4 = variableBinder3;
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
					IDictionary<string, IDictionary<string, List<BindAction>>> dictionary2 = variableBinder.binds;
					if (variableBinder.binds == null)
					{
						break;
					}
					nint num8 = (nint)dictionary2;
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
			variableBinder4 = variableBinder3;
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
		variableBinder4 = this;
		goto IL_1d52;
		IL_1d52:
		throw new NullReferenceException();
	}

	public void ReWire(User newUser, User oldUser)
	{
		string bindID = GetBindID(newUser);
		string bindID2 = ((VariableBinder)(object)bindID).GetBindID(oldUser);
		ReWire(bindID, bindID2);
	}

	public void ReWire(Room newRoom, Room oldRoom)
	{
		string bindID = GetBindID(newRoom);
		string bindID2 = ((VariableBinder)(object)bindID).GetBindID(oldRoom);
		ReWire(bindID, bindID2);
	}

	private void ReWire(string newID, string oldID)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_00fb: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0119: Expected I, but got O
		//IL_01bf: Expected I, but got O
		//IL_01cf: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_014f: Expected I, but got O
		//IL_0178: Expected I, but got O
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_08a3: Expected I, but got O
		//IL_020a: Expected O, but got I
		//IL_02a0: Expected I, but got O
		//IL_02b0: Expected O, but got I
		//IL_0346: Expected I, but got O
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d8: Expected I, but got O
		//IL_04fc: Expected O, but got I4
		//IL_03ae: Expected I, but got O
		//IL_03be: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0454: Expected I, but got O
		//IL_0484: Expected O, but got I4
		//IL_0581: Expected I, but got O
		//IL_0591: Expected O, but got I
		//IL_03f9: Expected O, but got I
		//IL_0627: Expected I, but got O
		//IL_05cc: Expected O, but got I
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0536: Expected I, but got O
		//IL_067c: Expected I, but got O
		//IL_068c: Expected O, but got I
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected O, but got Unknown
		//IL_0758: Expected I, but got O
		//IL_0788: Expected O, but got I4
		//IL_06c7: Expected O, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E83C5]");
		nint num = 0;
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary = binds;
		bool flag = binds == null;
		string text = oldID;
		if (flag)
		{
			goto IL_07a8;
		}
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2400;
		nint num2 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v8 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		object obj4 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj3 + 16;
			obj2--;
			bool flag2 = (nint)obj2 != 1;
			obj3 = obj4;
			if (flag2)
			{
				continue;
			}
			goto IL_00c5;
		}
		object obj5 = obj3 + 4;
		object obj6 = num2 + obj5;
		object obj7 = obj6 + 312;
		num = (nint)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X0_v49] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		obj4 = obj3;
		nint num3 = (nint)obj7;
		if (!flag3)
		{
			goto IL_0186;
		}
		goto IL_0836;
		IL_0579:
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary2;
		nint num4 = (nint)dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0615;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v30-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 = obj4 + 16;
			obj9--;
			bool flag4 = (nint)obj9 != 1;
			obj4 = obj3;
			if (flag4)
			{
				continue;
			}
			goto IL_0615;
		}
		object obj10 = obj4 + 6;
		object obj11 = num4 + obj10;
		object obj12 = obj11 + 312;
		num = (nint)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X0_v21] (should have been resolved before IL gen)");
		string text2 = (string)(object)binds;
		bool flag5 = binds == null;
		object obj13 = !flag5;
		IDictionary<string, IDictionary<string, List<BindAction>>> dictionary3 = default(IDictionary<string, IDictionary<string, List<BindAction>>>);
		dictionary = dictionary3;
		text = (string)(object)binds;
		if (obj13 != null)
		{
			goto IL_0674;
		}
		goto IL_07a8;
		IL_0836:
		dictionary = binds;
		bool flag6 = binds == null;
		obj4 = obj3;
		num = num3;
		text = oldID;
		if (!flag6)
		{
			nint num5 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0334;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X10_v27-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 = obj15 + 16;
				obj14--;
				bool flag7 = (nint)obj14 != 1;
				obj15 = obj3;
				if (flag7)
				{
					continue;
				}
				goto IL_0334;
			}
			object obj16 = obj15 + 4;
			object obj17 = num5 + obj16;
			object obj18 = obj17 + 312;
			num = (nint)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X0_v35] (should have been resolved before IL gen)");
			object obj19 = default(object);
			bool flag8 = obj19 == null;
			object obj20 = !flag8;
			obj3 = obj15;
			if (obj20 == null)
			{
				return;
			}
			goto IL_036d;
		}
		goto IL_07a8;
		IL_095a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ X0_v2] (should have been resolved before IL gen)");
		DispatchAllBoundedVars(newID);
		return;
		IL_0442:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj21 = default(object);
		num = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v25] (should have been resolved before IL gen)");
		dictionary2 = binds;
		bool flag9 = binds == null;
		object obj22 = !flag9;
		if (obj22 != null)
		{
			goto IL_0579;
		}
		obj4 = obj3;
		text = oldID;
		goto IL_07a8;
		IL_0674:
		num = (nint)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v5 (Il2CppClass<System.String>)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v5 (Il2CppClass<System.String>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0708;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v5 (Il2CppClass<System.String>)+B0]");
		obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v30-8]");
			bool flag10 = 0 == (nint)obj;
			dictionary = dictionary3;
			text = text2;
			if (flag10)
			{
				break;
			}
			obj4 += 16;
			obj23--;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_0708;
		}
		object obj24 = obj4 + 5;
		object obj25 = num + obj24;
		object obj26 = obj25 + 312;
		goto IL_095a;
		IL_00c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		num = (nint)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X0_v46] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag11 = obj28 == null;
		object obj29 = !flag11;
		if (obj29 != null)
		{
			goto IL_0186;
		}
		obj3 = obj4;
		num3 = (nint)obj27;
		goto IL_0836;
		IL_0186:
		dictionary = binds;
		bool flag12 = binds == null;
		text = oldID;
		if (flag12)
		{
			goto IL_07a8;
		}
		nint num6 = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0253;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v34-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj31 + 16;
			obj30--;
			bool flag13 = (nint)obj30 != 1;
			obj31 = obj4;
			if (flag13)
			{
				continue;
			}
			goto IL_0253;
		}
		object obj32 = obj31 + 6;
		object obj33 = num6 + obj32;
		object obj34 = obj33 + 312;
		obj4 = obj31;
		goto IL_089b;
		IL_0615:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj35 = default(object);
		num = (nint)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v659 @ X0_v18] (should have been resolved before IL gen)");
		text2 = (string)(object)binds;
		bool flag14 = binds == null;
		obj4 = obj3;
		dictionary = dictionary3;
		text = (string)(object)binds;
		if (!flag14)
		{
			goto IL_0674;
		}
		goto IL_07a8;
		IL_0708:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		dictionary = dictionary3;
		text = text2;
		goto IL_095a;
		IL_0334:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj36 = default(object);
		num = (nint)obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v515 @ X0_v32] (should have been resolved before IL gen)");
		object obj37 = default(object);
		if (obj37 != null)
		{
			goto IL_036d;
		}
		return;
		IL_036d:
		dictionary = binds;
		bool flag15 = binds == null;
		obj4 = obj3;
		text = oldID;
		if (!flag15)
		{
			nint num7 = (nint)dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0442;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v13 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.IDictionary`2<System.String, System.Collections.Generic.List`1<Kammelna.Server.BindAction>>>>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v30-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 = obj4 + 16;
				obj38--;
				bool flag16 = (nint)obj38 != 1;
				obj4 = obj3;
				if (flag16)
				{
					continue;
				}
				goto IL_0442;
			}
			object obj39 = num7 + obj4;
			object obj40 = obj39 + 312;
			num = (nint)obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v621 @ X0_v28] (should have been resolved before IL gen)");
			dictionary2 = binds;
			bool flag17 = binds == null;
			obj3 = obj4;
			text = oldID;
			if (!flag17)
			{
				goto IL_0579;
			}
		}
		goto IL_07a8;
		IL_07a8:
		throw new NullReferenceException();
		IL_0253:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_089b;
		IL_089b:
		num3 = (nint)obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v570 @ X0_v39] (should have been resolved before IL gen)");
		obj3 = obj4;
		goto IL_0836;
	}
}
