using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public static class CounterBubbleManager
{
	public delegate void CounterUpdated(CounterBubbleType type, int newCount, string extra);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KeyValuePair<string, int>, int> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <UpdateCounter>b__6_0(KeyValuePair<string, int> pair)
		{
			IntPtr intPtr = default(IntPtr);
			return (int)(nint)intPtr;
		}
	}

	private static readonly Dictionary<CounterBubbleType, int> recentCounters;

	private static readonly Dictionary<CounterBubbleType, Dictionary<string, int>> extraCounters;

	public static event CounterUpdated OnCounterUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_013c: Expected O, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_00e5: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(CardUtils.<>c) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj11 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj11 == obj6;
				obj6 = obj11;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_013c: Expected O, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_00e5: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(CardUtils.<>c) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj11 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj11 == obj6;
				obj6 = obj11;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static void UpdateCounter(CounterBubbleType type, int newCount, string extra = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_0871: Expected O, but got I
		//IL_003b: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_085c: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_08b0: Expected O, but got I
		//IL_08bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_0646: Expected O, but got I
		//IL_0886: Expected O, but got I
		//IL_02c5: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0310: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_067b: Expected O, but got I
		//IL_068b: Expected O, but got I
		//IL_069b: Expected O, but got I
		//IL_07e2: Expected O, but got I
		//IL_0804: Expected O, but got I4
		//IL_089b: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_06c7: Expected O, but got I
		//IL_0369: Expected O, but got I
		//IL_037e: Expected O, but got I
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_04bf: Expected O, but got I4
		//IL_04cf: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_0246: Expected I4, but got O
		//IL_070e: Expected O, but got I4
		//IL_042c: Expected O, but got I
		//IL_0458: Expected O, but got I4
		//IL_03d3: Expected O, but got I
		//IL_03e3: Expected O, but got I
		//IL_040a: Expected O, but got I
		//IL_0759: Expected O, but got I
		//IL_0791: Expected O, but got I4
		//IL_07aa: Expected O, but got I4
		//IL_0563: Expected O, but got I
		//IL_0584: Expected O, but got I
		//IL_0507: Expected O, but got I4
		//IL_073e: Expected O, but got I
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_0907: Expected O, but got I
		//IL_0918: Expected I, but got O
		//IL_0936: Expected O, but got I
		//IL_05c1: Expected O, but got I
		//IL_05e3: Expected O, but got I4
		//IL_0548: Expected O, but got I
		//IL_0537: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		bool flag = string.IsNullOrEmpty(extra);
		object obj2 = obj;
		object obj7;
		int num;
		System.Int32Enum int32Enum;
		object obj6;
		object obj9;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v14+B8]");
			object obj4 = 0;
			object obj5 = (nint)0 + (nint)2368;
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v69+8]");
			((Dictionary<System.Int32Enum, int>)0).set_Item((System.Int32Enum)type, newCount);
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_0636;
			}
			num = newCount;
			int32Enum = (System.Int32Enum)type;
			obj9 = obj7;
			goto IL_07c0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v14+B8]");
		object obj11 = 0;
		object obj12 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v13+10]");
		bool flag5 = ((Dictionary<System.Int32Enum, object>)0).ContainsKey((System.Int32Enum)type);
		object obj13 = obj;
		object obj22;
		object obj19;
		object obj18;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v55+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v55+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v63+10]");
			object obj16 = ((Dictionary<System.Int32Enum, object>)0).get_Item((System.Int32Enum)type);
			object obj17 = (nint)0 + (nint)3352;
			obj18 = obj17;
			((Dictionary<object, int>)obj16).set_Item((object)extra, newCount);
			obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v18+E4]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				object obj21 = newCount;
				System.Int32Enum int32Enum2 = (System.Int32Enum)extra;
				obj22 = obj17;
				object obj23 = obj19;
				goto IL_033e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v55+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v55+B8]");
			object obj25 = 0;
			object obj26 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Dictionary<object, int> dictionary = default(Dictionary<object, int>);
			dictionary..ctor();
			dictionary.Add(extra, newCount);
			object obj27 = (nint)0 + (nint)2328;
			obj22 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v53+10]");
			((Dictionary<System.Int32Enum, object>)0).set_Item((System.Int32Enum)type, (object)dictionary);
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v52+E4]");
			bool flag9 = (nint)0 == 0;
			object obj28 = !flag9;
			object obj21 = dictionary;
			System.Int32Enum int32Enum2 = (System.Int32Enum)type;
			obj18 = obj27;
			obj19 = obj23;
			if (obj28 == null)
			{
				goto IL_033e;
			}
		}
		goto IL_088b;
		IL_088b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v18+B8]");
		object obj29 = 0;
		object obj30 = (nint)0 + (nint)2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v18+10]");
		object obj31 = ((Dictionary<System.Int32Enum, object>)0).get_Item((System.Int32Enum)type);
		object obj32 = typeof(CardUtils.<>c) + 2768;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v38+E4]");
		object obj34;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v38+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			bool flag10 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			object obj36 = 0;
			object obj37 = obj31;
			if (!flag10)
			{
				goto IL_0420;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v38+B8]");
			obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			bool flag11 = (nint)0 == 0;
			object obj38 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v12+8]");
			object obj36 = 0;
			object obj37 = obj31;
			if (obj38 != null)
			{
				goto IL_0420;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v38+E4]");
		bool flag12 = (nint)0 == 0;
		object obj39 = !flag12;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj40 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v47+B8]");
			obj34 = 0;
		}
		object obj41 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj42 = (nint)0 + (nint)3784;
		Func<KeyValuePair<object, int>, int> func = default(Func<KeyValuePair<object, int>, int>);
		func..ctor(obj34, (IntPtr)obj42);
		object obj43 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v44+B8]");
		object obj44 = (nint)0 + (nint)8;
		obj44 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj45 = (nint)0 + (nint)672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE36B8");
		goto IL_0557;
		IL_06a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v24+B8]");
		object obj47 = 0;
		object obj48 = obj47;
		if (obj47 == null)
		{
			goto IL_05f1;
		}
		goto IL_06ec;
		IL_05f1:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v13+E4]");
		bool flag13 = (nint)0 == 0;
		int num2 = default(int);
		num = num2;
		int32Enum = (System.Int32Enum)type;
		obj9 = obj7;
		if (!flag13)
		{
			goto IL_0636;
		}
		goto IL_07c0;
		IL_0557:
		object obj49 = (nint)0 + (nint)2368;
		obj6 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v18+8]");
		((Dictionary<System.Int32Enum, int>)0).set_Item((System.Int32Enum)type, num2);
		obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v24+E4]");
		if ((nint)0 == 0)
		{
			goto IL_06a5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v24+B8]");
		obj47 = 0;
		obj48 = obj47;
		bool flag14 = obj47 == null;
		object obj50 = !flag14;
		if (obj50 == null)
		{
			goto IL_05f1;
		}
		goto IL_06ec;
		IL_066b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+18]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+40]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9+28]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v234 @ X5_v1 (should have been resolved before IL gen)");
		goto IL_06a5;
		IL_07c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj54 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v10+B8]");
		object obj55 = 0;
		object obj56 = obj55;
		bool flag15 = obj55 == null;
		object obj57 = !flag15;
		if (obj57 == null)
		{
			return;
		}
		goto IL_066b;
		IL_0420:
		object obj58 = (nint)0 + (nint)672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE36B8");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v18+8]");
		bool flag16 = (nint)0 == 0;
		object obj59 = !flag16;
		if (obj59 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0557;
		IL_06ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v24+E4]");
		bool flag17 = (nint)0 == 0;
		object obj60 = !flag17;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj61 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v32+B8]");
			obj47 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v27+8]");
		int num3 = ((Dictionary<System.Int32Enum, int>)0).get_Item((System.Int32Enum)type);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X22_v11+18] (should have been resolved before IL gen)");
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v13+E4]");
		bool flag18 = (nint)0 == 0;
		object obj62 = !flag18;
		num = num3;
		int32Enum = (System.Int32Enum)type;
		obj6 = 0;
		obj9 = obj7;
		if (obj62 != null)
		{
			goto IL_0636;
		}
		goto IL_07c0;
		IL_0636:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v13+B8]");
		object obj63 = 0;
		obj56 = obj63;
		if (obj63 != null)
		{
			goto IL_066b;
		}
		return;
		IL_033e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj19 = obj;
		obj18 = obj22;
		goto IL_088b;
	}

	public static int GetCount(CounterBubbleType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_01d9: Expected I4, but got O
		//IL_018b: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_00f1: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A66]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+8]");
		Dictionary<System.Int32Enum, int> dictionary = (Dictionary<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00c1;
		}
		goto IL_01cb;
		IL_00c1:
		int value;
		bool flag4 = dictionary.TryGetValue((System.Int32Enum)type, out value);
		bool flag5 = !flag4;
		object obj9 = !flag5;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			return value;
		}
		return 0;
		IL_01cb:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v19+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v12+8]");
		dictionary = (Dictionary<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v12+8]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		goto IL_01cb;
	}

	public static int GetCount(CounterBubbleType type, string extra)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_0232: Expected I4, but got O
		//IL_01f2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79FA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v24+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v24+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v12+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v11+10]");
		Dictionary<System.Int32Enum, object> dictionary = (Dictionary<System.Int32Enum, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v11+10]");
		if ((nint)0 != 0)
		{
			goto IL_016e;
		}
		goto IL_0224;
		IL_0224:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_016e:
		object value;
		bool flag3 = dictionary.TryGetValue((System.Int32Enum)type, out value);
		bool flag4 = !flag3;
		int result = (flag3 ? 1 : 0);
		if (!flag4)
		{
			if (value == null)
			{
				goto IL_0224;
			}
			int value2;
			bool flag5 = ((Dictionary<object, int>)value).TryGetValue((object)extra, out value2);
			bool flag6 = !flag5;
			object obj8 = !flag6;
			object obj9 = ~obj8;
			result = ((obj9 == null) ? value2 : 0);
		}
		return result;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v24+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v15+10]");
		dictionary = (Dictionary<System.Int32Enum, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v15+10]");
		bool flag7 = (nint)0 == 0;
		object obj11 = !flag7;
		if (obj11 != null)
		{
			goto IL_016e;
		}
		goto IL_0224;
	}

	public static void ResetCounters()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_0170: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_0187: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79FB]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v19+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v19+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v7+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v11+8]");
		Dictionary<System.Int32Enum, int> dictionary = (Dictionary<System.Int32Enum, int>)0;
		goto IL_014e;
		IL_014e:
		dictionary.Clear();
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v6+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v7+10]");
		((Dictionary<System.Int32Enum, object>)0).Clear();
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v19+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v15+8]");
		dictionary = (Dictionary<System.Int32Enum, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v15+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_014e;
	}

	static CounterBubbleManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_0079: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 536;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary = default(Dictionary<System.Int32Enum, int>);
		dictionary..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+B8]");
		object obj5 = (nint)0 + (nint)8;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary2 = default(Dictionary<System.Int32Enum, object>);
		dictionary2..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)16;
		obj7 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
