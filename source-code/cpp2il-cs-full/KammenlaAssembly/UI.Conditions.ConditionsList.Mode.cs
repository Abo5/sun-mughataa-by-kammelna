using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.TextCore;

namespace UI.Conditions;

[Serializable]
public class ConditionsList : ICondition
{
	public enum Mode
	{
		All,
		Any
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ICondition, bool> <>9__7_0;

		public static Func<ICondition, bool> <>9__7_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_Satisfied>b__7_0(ICondition condition)
		{
			//IL_0132: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_011a: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (condition != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
				num = (nint)condition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0124;
			IL_0124:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 2;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0124;
		}

		internal bool <get_Satisfied>b__7_1(ICondition condition)
		{
			//IL_0132: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_011a: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (condition != null)
			{
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
				num = (nint)condition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<UI.Conditions.ICondition>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0124;
			IL_0124:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 2;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0124;
		}
	}

	public Mode mode;

	public List<ICondition> conditions;

	private Action m_OnConditionChanged;

	public bool Satisfied
	{
		get
		{
			//IL_033a: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0193: Expected O, but got I
			//IL_01a3: Expected O, but got I
			//IL_01b3: Expected O, but got I
			//IL_01d5: Expected O, but got I4
			//IL_0118: Expected O, but got I
			//IL_0128: Expected O, but got I
			//IL_0138: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_020d: Expected O, but got I4
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected O, but got Unknown
			//IL_038d: Expected O, but got I
			//IL_039e: Expected I, but got O
			//IL_03bc: Expected O, but got I
			//IL_027c: Expected O, but got I
			//IL_028c: Expected O, but got I
			//IL_02ae: Expected O, but got I4
			//IL_023d: Expected O, but got I
			//IL_009a: Expected O, but got I
			//IL_00aa: Expected O, but got I
			//IL_00cc: Expected O, but got I4
			//IL_02de: Expected O, but got I4
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Expected O, but got Unknown
			//IL_040d: Expected O, but got I
			//IL_041e: Expected I, but got O
			//IL_043c: Expected O, but got I
			//IL_030e: Expected O, but got I
			IEnumerable<object> enumerable = conditions;
			object obj;
			object obj3;
			Func<object, bool> predicate;
			object obj8;
			Func<object, bool> predicate2;
			object obj10;
			object obj7;
			if (conditions != null)
			{
				obj = typeof(CardUtils.<>c) + 2152;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X19_v2 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				if ((nint)0 >= (nint)1 && mode != Mode.All)
				{
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+B8]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+10]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+10]");
						bool flag = (nint)0 == 0;
						object obj4 = !flag;
						if (obj4 == null)
						{
							goto IL_02bc;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+B8]");
						obj3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+10]");
						predicate = (Func<object, bool>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v24+10]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							goto IL_02bc;
						}
					}
					goto IL_0313;
				}
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v7+E4]");
				if ((nint)0 != 0)
				{
					obj7 = (nint)0 + (nint)1872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v7+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+8]");
					predicate2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+8]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						obj10 = obj7;
						goto IL_01eb;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj;
					obj10 = (nint)0 + (nint)1872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v7+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+8]");
					predicate2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v8+8]");
					bool flag4 = (nint)0 == 0;
					object obj11 = !flag4;
					obj7 = obj10;
					if (obj11 == null)
					{
						goto IL_01eb;
					}
				}
				goto IL_0242;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0313:
			return Enumerable.Any(conditions, predicate);
			IL_02bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v30+B8]");
				obj3 = 0;
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)1576;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj3, (IntPtr)obj15);
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v29+B8]");
			object obj17 = (nint)0 + (nint)16;
			obj17 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
			goto IL_0313;
			IL_01eb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14+B8]");
				obj8 = 0;
			}
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj21 = (nint)0 + (nint)1568;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj8, (IntPtr)obj21);
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v13+B8]");
			object obj23 = (nint)0 + (nint)8;
			obj23 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = obj10;
			predicate2 = func2;
			goto IL_0242;
			IL_0242:
			return Enumerable.All(conditions, predicate2);
		}
	}

	public event Action OnConditionChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void Setup(GameObject gm)
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_03ea: Expected I, but got O
		//IL_0402: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		object obj5 = default(object);
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		GameObject gameObject = default(GameObject);
		if (conditions != null)
		{
			object obj = (nint)0 + (nint)1480;
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)1744;
			obj5 = (nint)0 + (nint)1472;
			List<object>.Enumerator enumerator = ((List<object>)(object)conditions).GetEnumerator();
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			object obj6 = default(object);
			bool flag2 = default(bool);
			Action action = default(Action);
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					if (obj6 == null)
					{
						break;
					}
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0171;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+B0]");
					object obj9 = (nint)0 + (nint)8;
					bool flag = flag2;
					object obj11;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v14-8]");
						object obj10 = 0 - obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v14-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj11 = obj9 + 16;
						obj8--;
						obj10 = obj8 - 1;
						bool flag3 = obj10 == null;
						flag2 = (nint)obj8 != 1;
						flag = flag2;
						obj9 = obj11;
						if (flag2)
						{
							continue;
						}
						goto IL_0171;
					}
					object obj12 = obj9 + 3;
					object obj13 = obj7 + obj12;
					object obj14 = obj13 + 312;
					flag2 = flag;
					obj11 = obj9;
					goto IL_03c8;
				}
				enumerator2.Dispose();
				return;
				IL_0171:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_03c8;
				IL_03c8:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X0_v23] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(this, (IntPtr)obj4);
				object obj15 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v14+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v14+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v14+B0]");
					object obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v9-8]");
						object obj10 = 0 - obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X10_v9-8]");
						if (0 == (nint)obj2)
						{
							break;
						}
						obj11 += 16;
						obj16--;
						obj10 = obj16 - 1;
						bool flag3 = obj10 == null;
						flag2 = (nint)obj16 != 1;
						if (flag2)
						{
							continue;
						}
						goto IL_0066;
					}
					object obj17 = obj15 + obj11;
					object obj18 = obj17 + 312;
					goto IL_0075;
				}
				goto IL_0066;
				IL_0066:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				goto IL_0075;
				IL_0075:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v441 @ X0_v29] (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			gameObject = (GameObject)obj;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = (nint)gameObject != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			gameObject = (GameObject)obj5;
			enumerator3.Dispose();
			object obj19 = default(object);
			if (obj19 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void TriggerConditionChanged()
	{
		Actions.SafeInvoke(this.OnConditionChanged);
	}

	public void Teardown()
	{
		//IL_022c: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_01cd: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_017f: Expected O, but got I4
		bool flag = conditions == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1480;
			object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1688;
			obj = (nint)0 + (nint)1472;
			List<object>.Enumerator enumerator = ((List<object>)(object)conditions).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj4 = 0;
			NullReferenceException ex = new NullReferenceException();
			object obj5 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj5 = obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B2F0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public ConditionsList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1432;
		mode = Mode.Any;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 24;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
