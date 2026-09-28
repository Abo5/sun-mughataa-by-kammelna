using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class StoreRoomThemesGroup : UiGridView<StoreDataHolder, ListViewItem<StoreDataHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__0_0;

		public static Func<StoreItem, int> <>9__0_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Populate>b__0_0(StoreItem theme)
		{
			//IL_008f: Expected I4, but got O
			if (theme != null)
			{
				if (!theme.<isActive>k__BackingField || theme.<isAdvertisement>k__BackingField)
				{
					return false;
				}
				return GamesFlagExtensions.MatchesCurrentGame(theme.<targetGames>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Populate>b__0_1(StoreItem theme)
		{
			//IL_0035: Expected I4, but got O
			if (theme != null)
			{
				return theme.<Order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public unsafe void Populate(List<StoreItem> Themes, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_0045: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		//IL_0087: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		//IL_03d1: Expected O, but got I
		//IL_03f3: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_01d9: Expected O, but got I
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da9: Expected O, but got Unknown
		//IL_0dbf: Expected O, but got I
		//IL_0dd0: Expected I, but got O
		//IL_0dee: Expected O, but got I
		//IL_0e05: Expected I, but got O
		//IL_0433: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_04e3: Expected O, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0522: Expected O, but got Ref
		//IL_052b: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0278: Expected I, but got O
		//IL_0288: Expected O, but got I
		//IL_0e86: Expected O, but got I
		//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Expected O, but got Unknown
		//IL_0eb0: Expected O, but got I
		//IL_0ec1: Expected I, but got O
		//IL_0ec1: Expected O, but got I
		//IL_0ec9: Expected I, but got O
		//IL_0edf: Expected O, but got I
		//IL_034a: Expected O, but got I4
		//IL_035a: Expected O, but got Ref
		//IL_0363: Expected O, but got I4
		//IL_036c: Expected O, but got I4
		//IL_049b: Expected O, but got I4
		//IL_04a0: Expected I, but got O
		//IL_04a8: Expected O, but got I
		//IL_04ad: Expected I, but got O
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0588: Expected O, but got I
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05a5: Expected O, but got I4
		//IL_0638: Expected I, but got O
		//IL_0648: Expected O, but got I
		//IL_038c: Expected O, but got I4
		//IL_0e2a: Expected O, but got I
		//IL_06f7: Expected O, but got I4
		//IL_0f42: Expected O, but got I
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_09aa: Expected O, but got I4
		//IL_09b3: Expected O, but got I4
		//IL_09bc: Expected O, but got I4
		//IL_09dd: Expected O, but got I4
		//IL_0a1e: Expected O, but got I4
		//IL_0a27: Expected O, but got I4
		//IL_0f06: Expected O, but got I
		//IL_0fd4: Expected O, but got I4
		//IL_0746: Expected I, but got O
		//IL_0756: Expected O, but got I
		//IL_0709: Expected O, but got I4
		//IL_071b: Expected O, but got I
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected O, but got Unknown
		//IL_0a59: Expected I, but got O
		//IL_0a69: Expected O, but got I
		//IL_0815: Expected O, but got I4
		//IL_06b4: Expected O, but got I
		//IL_0b08: Expected O, but got I4
		//IL_1066: Expected O, but got I
		//IL_10f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected O, but got Unknown
		//IL_0f87: Expected O, but got I
		//IL_0b86: Expected O, but got I4
		//IL_102a: Expected O, but got I
		//IL_0827: Expected O, but got I4
		//IL_0839: Expected O, but got I
		//IL_0842: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected O, but got Unknown
		//IL_0c7c: Expected O, but got I4
		//IL_0cb5: Expected O, but got I4
		//IL_0b1a: Expected O, but got I4
		//IL_0b2c: Expected O, but got I
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_07d2: Expected O, but got I
		//IL_0acd: Expected O, but got I
		//IL_0d14: Expected O, but got I4
		//IL_0900: Expected O, but got I4
		//IL_0920: Expected O, but got I4
		//IL_05c2: Expected O, but got I
		//IL_05e2: Expected O, but got I
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3576;
		object obj2 = (nint)0 + (nint)2800;
		object obj3 = typeof(SkeletonBinary.SkeletonInput) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v87+E4]");
		object obj6;
		Func<object, bool> predicate;
		object obj8;
		object obj5;
		if ((nint)0 != 0)
		{
			obj5 = (nint)0 + (nint)3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v87+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v64+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v64+8]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				obj8 = obj5;
				goto IL_0118;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			obj8 = (nint)0 + (nint)3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v87+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v64+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v64+8]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj5 = obj8;
			if (obj9 == null)
			{
				goto IL_0118;
			}
		}
		goto IL_016f;
		IL_0bef:
		throw new NullReferenceException();
		IL_025c:
		object obj10 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3752;
		IOrderedEnumerable<object> orderedEnumerable;
		nint num = (nint)orderedEnumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_031c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+B0]");
		int num2 = (int)((nint)0 + (nint)8);
		bool flag4 = default(bool);
		bool flag3 = flag4;
		object obj12 = default(object);
		object obj13;
		object obj14 = default(object);
		int num3 = default(int);
		nint num4;
		nint num5 = default(nint);
		object obj15;
		object obj16;
		NullReferenceException ex;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X10_v31 (System.Int32)-8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X10_v31 (System.Int32)-8]");
			bool flag5 = 0 == (nint)obj10;
			obj13 = obj14;
			flag4 = flag3;
			num3 = num2;
			num4 = num5;
			obj15 = obj16;
			ex = (NullReferenceException)orderedEnumerable;
			if (flag5)
			{
				break;
			}
			num3 = num2 + 16;
			obj11--;
			flag4 = (nint)obj11 != 1;
			flag3 = flag4;
			num2 = num3;
			if (flag4)
			{
				continue;
			}
			goto IL_031c;
		}
		goto IL_04d1;
		IL_04d1:
		object obj17 = num + ((int*)num3)->m_value;
		object obj18 = obj17 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X8_v41] (should have been resolved before IL gen)");
		Func<object, int> func = default(Func<object, int>);
		bool flag6 = func == null;
		obj14 = obj13;
		Func<object, int> func2 = func;
		int? num6 = (int?)(object)(&func2);
		object obj19 = 0;
		num5 = num4;
		func2 = func;
		obj19 = 0;
		if (!flag6)
		{
			goto IL_0554;
		}
		goto IL_0bef;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v87+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v70+B8]");
			obj6 = 0;
		}
		obj14 = obj6;
		object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1704;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj6, (IntPtr)obj23);
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v69+B8]");
		object obj25 = (nint)0 + (nint)8;
		obj25 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num5 = unchecked((nint)null);
		obj5 = obj8;
		predicate = func3;
		goto IL_016f;
		IL_04c3:
		ex = new NullReferenceException();
		goto IL_04d1;
		IL_020e:
		object obj26;
		obj16 = obj26;
		IEnumerable<object> source;
		Func<object, int> keySelector;
		orderedEnumerable = Enumerable.OrderBy(source, keySelector);
		bool flag8 = orderedEnumerable == null;
		obj13 = obj14;
		num4 = num5;
		obj15 = obj26;
		if (!flag8)
		{
			goto IL_025c;
		}
		goto IL_04c3;
		IL_016f:
		source = Enumerable.Where(Themes, predicate);
		object obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v67+E4]");
		object obj28;
		nint num7;
		if ((nint)0 != 0)
		{
			obj26 = (nint)0 + (nint)2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v67+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+10]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+10]");
			bool flag9 = (nint)0 == 0;
			obj28 = obj26;
			num7 = num;
			if (!flag9)
			{
				goto IL_020e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj3;
			obj26 = (nint)0 + (nint)2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v67+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+10]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+10]");
			bool flag10 = (nint)0 == 0;
			object obj29 = !flag10;
			obj28 = obj26;
			num7 = num;
			if (obj29 != null)
			{
				goto IL_020e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v67+E4]");
		bool flag11 = (nint)0 == 0;
		object obj30 = !flag11;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v51+B8]");
			num7 = 0;
		}
		obj14 = num7;
		object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)1712;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor((object)num7, (IntPtr)obj33);
		num = (nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v39 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+B8]");
		object obj34 = (nint)0 + (nint)16;
		obj34 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = obj28;
		orderedEnumerable = Enumerable.OrderBy(source, func4);
		bool flag12 = orderedEnumerable == null;
		object obj35 = !flag12;
		num5 = unchecked((nint)null);
		obj13 = num7;
		num4 = unchecked((nint)null);
		obj15 = obj28;
		if (obj35 != null)
		{
			goto IL_025c;
		}
		goto IL_04c3;
		IL_0554:
		object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj37 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1184;
		object obj38 = (nint)0 + (nint)2808;
		object obj39 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		object obj40 = 0;
		Func<object, int> func5 = func;
		object obj42 = default(object);
		object obj45 = default(object);
		object obj47 = default(object);
		object obj49 = default(object);
		object obj56 = default(object);
		object obj72 = default(object);
		while (true)
		{
			nint num8 = (nint)func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
			object[] array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+B0]");
			int num9 = (int)((nint)0 + (nint)8);
			bool flag13 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v25 (System.Int32)-8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v25 (System.Int32)-8]");
				if (0 == (nint)obj36)
				{
					break;
				}
				num3 = num9 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v21 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
				array = (object[])(-1);
				flag4 = (nint)array != 1;
				flag13 = flag4;
				num9 = num3;
				if (flag4)
				{
					continue;
				}
				goto IL_06e4;
			}
			array = (object[])((int*)num9)->m_value;
			object obj41 = num8 + ((int*)num9)->m_value;
			obj42 = obj41 + 312;
			flag4 = flag13;
			num3 = num9;
			goto IL_0f2a;
			IL_0a3d:
			object obj43 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			Func<object, int> func6;
			nint num10 = (nint)func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v15 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v15 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0af5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v15 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+B0]");
			int num11 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X10_v10 (System.Int32)-8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X10_v10 (System.Int32)-8]");
				if (0 == (nint)obj43)
				{
					break;
				}
				num3 = num11 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v15 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
				array = (object[])(-1);
				bool flag14 = (nint)array != 1;
				num11 = num3;
				if (flag14)
				{
					continue;
				}
				goto IL_0af5;
			}
			array = (object[])((int*)num11)->m_value;
			object obj44 = num10 + ((int*)num11)->m_value;
			obj45 = obj44 + 312;
			num3 = num11;
			object obj46 = obj15;
			goto IL_104e;
			IL_0802:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj46 = 0;
			goto IL_0fab;
			IL_0fab:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v869 @ X0_v39] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj47..ctor();
			object obj48 = obj47 + 64;
			obj48 = obj49;
			_ = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((StoreDataHolder)obj47).SetTemplate();
			bool flag15 = list == null;
			int? num12 = tempId;
			if (!flag15)
			{
				num12 = (int?)obj38;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					num3 = list._size;
					obj12 = items.Length;
					bool flag16 = list._size < items.Length;
					object obj50 = !flag16;
					if (obj50 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v6 (System.Nullable`1<System.Int32>)+20]");
						object obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X8_v34+C0]");
						int num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v33 (System.Int32)+70]");
						obj15 = 0;
						list.AddWithResize(obj47);
					}
					else
					{
						int num13 = list._size + 1;
						list._size = num13;
						object obj52 = list._items + list._size;
						object obj53 = obj52 + 32;
						obj53 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj15 = obj46;
					}
					obj40++;
					bool flag17 = func2 == null;
					obj14 = obj49;
					func5 = func2;
					if (flag17)
					{
						break;
					}
					continue;
				}
			}
			throw new NullReferenceException();
			IL_06e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj15 = 0;
			goto IL_0f2a;
			IL_0f2a:
			int? num14 = (int?)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v35+8]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ X0_v35] (should have been resolved before IL gen)");
			object obj55 = obj56 & 1;
			object obj57;
			int num16;
			if (obj55 != null)
			{
				nint num15 = (nint)func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v24 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
				object[] items = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v24 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
				bool flag18 = (nint)0 == 0;
				obj57 = obj12;
				num16 = num3;
				if (flag18)
				{
					goto IL_0802;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v24 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+B0]");
				int num17 = (int)((nint)0 + (nint)8);
				bool flag19 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X10_v20 (System.Int32)-8]");
					obj57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X10_v20 (System.Int32)-8]");
					if (0 == (nint)obj37)
					{
						break;
					}
					num16 = num17 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v24 (Il2CppClass<System.Func`2<System.Object, System.Int32>>)+12E]");
					items = (object[])(-1);
					flag4 = (nint)items != 1;
					flag19 = flag4;
					num17 = num16;
					if (flag4)
					{
						continue;
					}
					goto IL_0802;
				}
				items = (object[])((int*)num17)->m_value;
				object obj58 = num15 + ((int*)num17)->m_value;
				object obj59 = obj58 + 312;
				flag4 = flag19;
				num16 = num17;
				obj46 = obj15;
				goto IL_0fab;
			}
			bool flag20 = func2 == null;
			object obj60 = 152985600;
			object obj61 = 6;
			object obj62 = 0;
			func6 = func2;
			object obj63 = obj14;
			obj57 = obj12;
			object obj64 = 152985600;
			object obj65 = obj37;
			object obj66 = obj36;
			object obj67 = obj40;
			int? num18 = num6;
			num16 = num3;
			IntPtr intPtr = num5;
			obj46 = obj15;
			object obj68 = 6;
			object obj69 = 0;
			Func<object, int> func7 = func5;
			if (!flag20)
			{
				goto IL_0a3d;
			}
			goto IL_0fba;
			IL_0fba:
			while (true)
			{
				bool flag21 = obj69 == null;
				object obj70 = !flag21;
				obj37 = obj65;
				obj36 = obj66;
				obj40 = obj67;
				num6 = num18;
				num5 = intPtr;
				object[] items = array;
				num12 = num14;
				if (obj70 == null)
				{
					if ((nint)obj68 != 6)
					{
						bool flag22 = obj68 == null;
						object obj71 = !flag22;
						if (obj71 != null)
						{
							return;
						}
					}
					base.data = (List<StoreDataHolder>)(object)list;
					return;
				}
				OutOfMemoryException ex2 = new OutOfMemoryException();
				if ((nint)obj54 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj62 = obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag23 = func2 == null;
					object obj73 = !flag23;
					obj14 = obj63;
					obj12 = obj57;
					obj60 = obj64;
					obj19 = obj72;
					num3 = num16;
					obj15 = obj46;
					obj61 = 0;
					func5 = func7;
					func6 = func2;
					if (obj73 != null)
					{
						break;
					}
					obj65 = obj37;
					obj66 = obj36;
					obj67 = obj40;
					num18 = num6;
					obj19 = obj72;
					intPtr = num5;
					array = items;
					obj68 = 0;
					obj69 = obj72;
					num14 = num12;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			goto IL_0a3d;
			IL_104e:
			num14 = (int?)obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X0_v27+8]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v883 @ X0_v27] (should have been resolved before IL gen)");
			obj63 = obj14;
			obj57 = obj12;
			obj64 = obj60;
			obj65 = obj37;
			obj66 = obj36;
			obj67 = obj40;
			num18 = num6;
			num16 = num3;
			intPtr = num5;
			obj68 = obj61;
			obj69 = obj62;
			func7 = func5;
			goto IL_0fba;
			IL_0af5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj46 = 0;
			goto IL_104e;
		}
		goto IL_0bef;
		IL_031c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X0_v80] (should have been resolved before IL gen)");
		bool flag24 = func == null;
		object obj74 = !flag24;
		func2 = func;
		num6 = (int?)(object)(&func2);
		obj19 = 0;
		obj15 = 0;
		if (obj74 != null)
		{
			goto IL_0554;
		}
		func2 = func;
		obj19 = 0;
		goto IL_0bef;
	}

	public StoreRoomThemesGroup()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
