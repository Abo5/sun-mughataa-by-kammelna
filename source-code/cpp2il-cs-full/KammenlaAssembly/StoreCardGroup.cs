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

public class StoreCardGroup : UiGridView<StoreDataHolder, ListViewItem<StoreDataHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__0_0;

		public static Func<StoreItem, int> <>9__0_1;

		public static Func<StoreItem, int> <>9__0_3;

		public static Func<IGrouping<int, StoreItem>, int> <>9__0_2;

		public static Func<StoreItem, bool> <>9__0_4;

		public static Func<StoreItem, bool> <>9__0_5;

		public static Func<StoreItem, int> <>9__0_6;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetData>b__0_0(StoreItem i)
		{
			//IL_007c: Expected I4, but got O
			//IL_0055: Expected O, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			if (i != null)
			{
				if (i.<isActive>k__BackingField)
				{
					object obj = (i.<isAdvertisement>k__BackingField ? 1 : 0) ^ 1;
					return (byte)(obj & 1) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <SetData>b__0_1(StoreItem item)
		{
			//IL_0035: Expected I4, but got O
			if (item != null)
			{
				return item.<pack>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <SetData>b__0_2(IGrouping<int, StoreItem> pack)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011e: Expected O, but got I4
			//IL_0091: Expected O, but got I
			//IL_00a1: Expected O, but got I
			//IL_00b1: Expected O, but got I
			//IL_00d3: Expected O, but got I4
			//IL_0152: Expected O, but got I
			//IL_0162: Expected O, but got I
			//IL_0172: Expected O, but got I
			//IL_0194: Expected O, but got I4
			//IL_01cc: Expected O, but got I4
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Expected O, but got Unknown
			//IL_023a: Expected O, but got I
			//IL_024b: Expected I, but got O
			//IL_0269: Expected O, but got I
			//IL_01fc: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1400;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A0A]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
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
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)1936;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+18]");
			Func<object, int> func = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+18]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = obj7;
			if (obj9 == null)
			{
				goto IL_01aa;
			}
			goto IL_0201;
			IL_01aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)1440;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)24;
			obj16 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			func = func2;
			goto IL_0201;
			IL_0201:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCB9C8");
			int result = default(int);
			return result;
			IL_0085:
			obj10 = (nint)0 + (nint)1936;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+18]");
			func = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				obj7 = obj10;
				goto IL_01aa;
			}
			goto IL_0201;
		}

		internal int <SetData>b__0_3(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<Order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <SetData>b__0_4(StoreItem i)
		{
			//IL_0060: Expected I4, but got O
			if (i != null)
			{
				if (i.<isActive>k__BackingField)
				{
					return i.<isAdvertisement>k__BackingField;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SetData>b__0_5(StoreItem i)
		{
			//IL_007c: Expected I4, but got O
			//IL_0055: Expected O, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected I4, but got Unknown
			if (i != null)
			{
				if (i.<isActive>k__BackingField)
				{
					object obj = (i.<isAdvertisement>k__BackingField ? 1 : 0) ^ 1;
					return (byte)(obj & 1) != 0;
				}
				return false;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <SetData>b__0_6(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<virtualPrice>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public unsafe void SetData(IEnumerable<IGrouping<string, StoreItem>> groups)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_2185: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Expected I, but got O
		//IL_0051: Expected O, but got I
		//IL_0138: Expected I, but got O
		//IL_23f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f8: Expected O, but got Unknown
		//IL_2407: Unknown result type (might be due to invalid IL or missing references)
		//IL_240c: Expected O, but got Unknown
		//IL_241b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2420: Expected O, but got Unknown
		//IL_242f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2434: Expected O, but got Unknown
		//IL_2440: Expected O, but got I
		//IL_2450: Expected O, but got I
		//IL_2468: Expected O, but got I4
		//IL_2471: Expected O, but got I4
		//IL_2385: Expected O, but got I
		//IL_23a6: Expected O, but got I4
		//IL_23b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bb: Expected O, but got Unknown
		//IL_20d3: Expected O, but got Ref
		//IL_20dc: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_015c: Expected O, but got I
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_027e: Expected I, but got O
		//IL_24fa: Expected O, but got I
		//IL_250d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2512: Expected O, but got Unknown
		//IL_1f5b: Expected O, but got I4
		//IL_248b: Expected O, but got I
		//IL_24ac: Expected O, but got I4
		//IL_24bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c1: Expected O, but got Unknown
		//IL_29d2: Expected O, but got Ref
		//IL_29f1: Expected O, but got Ref
		//IL_29fa: Expected O, but got I4
		//IL_2a0a: Expected O, but got Ref
		//IL_2a33: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_2274: Expected O, but got I4
		//IL_2285: Expected O, but got I4
		//IL_30f9: Expected O, but got I4
		//IL_20fa: Expected O, but got Ref
		//IL_2103: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_1f6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f74: Expected O, but got Unknown
		//IL_1f8c: Expected O, but got I
		//IL_02fa: Expected O, but got I
		//IL_2027: Expected I, but got O
		//IL_230c: Expected O, but got I4
		//IL_03e1: Expected I, but got O
		//IL_3050: Expected O, but got I
		//IL_25ae: Expected O, but got I
		//IL_301c: Expected O, but got I
		//IL_20a5: Expected O, but got I4
		//IL_2121: Expected O, but got Ref
		//IL_212a: Expected O, but got I4
		//IL_253f: Expected O, but got I
		//IL_2560: Expected O, but got I4
		//IL_2570: Unknown result type (might be due to invalid IL or missing references)
		//IL_2575: Expected O, but got Unknown
		//IL_2039: Expected O, but got I4
		//IL_2046: Unknown result type (might be due to invalid IL or missing references)
		//IL_204b: Expected O, but got Unknown
		//IL_2054: Unknown result type (might be due to invalid IL or missing references)
		//IL_2059: Expected O, but got Unknown
		//IL_0430: Expected I, but got O
		//IL_0440: Expected O, but got I
		//IL_03f3: Expected O, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_1ff0: Expected O, but got I
		//IL_0527: Expected I, but got O
		//IL_0366: Expected O, but got I
		//IL_0380: Expected O, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_2654: Expected O, but got I
		//IL_25e5: Expected O, but got I
		//IL_2606: Expected O, but got I4
		//IL_2616: Unknown result type (might be due to invalid IL or missing references)
		//IL_261b: Expected O, but got Unknown
		//IL_0539: Expected O, but got I4
		//IL_054b: Expected O, but got I
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0612: Expected O, but got I
		//IL_0622: Expected O, but got I
		//IL_0644: Expected O, but got I4
		//IL_04ac: Expected O, but got I
		//IL_04c6: Expected O, but got I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_06c1: Expected I, but got O
		//IL_05ab: Expected O, but got I
		//IL_05bb: Expected O, but got I
		//IL_05dd: Expected O, but got I4
		//IL_0662: Expected O, but got I
		//IL_0684: Expected O, but got I4
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_2692: Unknown result type (might be due to invalid IL or missing references)
		//IL_2697: Expected O, but got Unknown
		//IL_26ad: Expected O, but got I
		//IL_26be: Expected I, but got O
		//IL_26dc: Expected O, but got I
		//IL_26f7: Expected O, but got I4
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I
		//IL_2148: Expected O, but got Ref
		//IL_2151: Expected O, but got I4
		//IL_077f: Expected O, but got I
		//IL_07ed: Expected O, but got I4
		//IL_080d: Expected O, but got I4
		//IL_0821: Expected O, but got I4
		//IL_08af: Expected O, but got I
		//IL_08bf: Expected O, but got I
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_08fd: Expected I, but got O
		//IL_090d: Expected O, but got I
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_09f4: Expected I, but got O
		//IL_27a0: Expected O, but got I
		//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Expected O, but got Unknown
		//IL_27c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cc: Expected O, but got Unknown
		//IL_2731: Expected O, but got I
		//IL_2752: Expected O, but got I4
		//IL_2762: Unknown result type (might be due to invalid IL or missing references)
		//IL_2767: Expected O, but got Unknown
		//IL_1de6: Expected O, but got Ref
		//IL_1def: Expected O, but got I4
		//IL_1df7: Expected O, but got Ref
		//IL_1e00: Expected O, but got I4
		//IL_0a0b: Expected O, but got I
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a36: Expected O, but got I4
		//IL_0a43: Expected I, but got O
		//IL_0a53: Expected O, but got I
		//IL_0979: Expected O, but got I
		//IL_0993: Expected O, but got I4
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected O, but got Unknown
		//IL_0b3a: Expected I, but got O
		//IL_2850: Expected O, but got I
		//IL_2863: Unknown result type (might be due to invalid IL or missing references)
		//IL_2868: Expected O, but got Unknown
		//IL_27e1: Expected O, but got I
		//IL_2802: Expected O, but got I4
		//IL_2812: Unknown result type (might be due to invalid IL or missing references)
		//IL_2817: Expected O, but got Unknown
		//IL_2950: Expected O, but got Ref
		//IL_2959: Expected O, but got I4
		//IL_2961: Expected O, but got Ref
		//IL_296a: Expected O, but got I4
		//IL_0b4c: Expected O, but got I4
		//IL_0b5e: Expected O, but got I
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected O, but got Unknown
		//IL_0d6d: Expected I, but got O
		//IL_0d7d: Expected O, but got I
		//IL_1e5e: Expected O, but got Ref
		//IL_1e67: Expected O, but got I4
		//IL_1e6f: Expected O, but got Ref
		//IL_1e78: Expected O, but got I4
		//IL_0abf: Expected O, but got I
		//IL_0ad9: Expected O, but got I4
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		//IL_0e28: Expected I, but got O
		//IL_0ba6: Expected I, but got O
		//IL_0bb6: Expected O, but got I
		//IL_29bb: Expected O, but got I
		//IL_0c9d: Expected I, but got O
		//IL_2987: Expected O, but got I
		//IL_2904: Expected O, but got I
		//IL_0e3a: Expected O, but got I4
		//IL_0e4c: Expected O, but got I
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_1e9e: Expected O, but got Ref
		//IL_1ea7: Expected O, but got I4
		//IL_1eaf: Expected O, but got Ref
		//IL_1eb8: Expected O, but got I4
		//IL_2895: Expected O, but got I
		//IL_28b6: Expected O, but got I4
		//IL_28c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cb: Expected O, but got Unknown
		//IL_0de9: Expected O, but got I
		//IL_0d06: Expected O, but got I4
		//IL_0caf: Expected O, but got I4
		//IL_0cc1: Expected O, but got I
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0c22: Expected O, but got I
		//IL_0c3c: Expected O, but got I4
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected O, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3576;
		object obj2 = (nint)0 + (nint)2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = (Func<object, bool>)obj2;
		List<object> list = default(List<object>);
		list..ctor();
		bool flag2 = default(bool);
		object obj4 = default(object);
		int num3 = default(int);
		if (groups != null)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2696;
			nint num = (nint)groups;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<System.String, StoreItem>>>)+12E]");
			object[] array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<System.String, StoreItem>>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0129;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<System.String, StoreItem>>>)+B0]");
			int num2 = (int)((nint)0 + (nint)8);
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v90 (System.Int32)-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v90 (System.Int32)-8]");
				bool flag3 = 0 < (nint)obj3;
				object obj5 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v90 (System.Int32)-8]");
				object obj6 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v90 (System.Int32)-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				num3 = num2 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Linq.IGrouping`2<System.String, StoreItem>>>)+12E]");
				array = (object[])(-1);
				bool flag4 = (nint)array < 1;
				obj5 = !flag4;
				obj6 = array - 1;
				bool flag5 = obj6 == null;
				flag2 = (nint)array != 1;
				flag = flag2;
				num2 = num3;
				if (flag2)
				{
					continue;
				}
				goto IL_0129;
			}
			array = (object[])((int*)num2)->m_value;
			object obj7 = num + ((int*)num2)->m_value;
			object obj8 = obj7 + 312;
			flag2 = flag;
			num3 = num2;
			goto IL_23e4;
		}
		NullReferenceException ex = new NullReferenceException();
		Func<object, bool> func2 = null;
		object obj9 = 0;
		goto IL_218a;
		IL_23e4:
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4064;
		object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1544;
		object obj13 = typeof(SkeletonBinary.SkeletonInput) + 1400;
		obj = (nint)0 + (nint)2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v33+8]");
		func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v324 @ X0_v33] (should have been resolved before IL gen)");
		func2 = null;
		obj9 = 0;
		object obj14 = 0;
		object obj15 = null;
		object obj16 = default(object);
		nint num6;
		object obj28 = default(object);
		object obj30;
		object obj32;
		object obj33;
		object obj34;
		object obj35;
		object obj36;
		object obj37;
		object obj39;
		object obj40;
		object obj41;
		Func<object, bool> func3;
		int num8;
		object obj43;
		object obj44;
		Func<object, bool> func5 = default(Func<object, bool>);
		object obj50 = default(object);
		Func<object, bool> func6 = default(Func<object, bool>);
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		object obj62 = default(object);
		object obj82 = default(object);
		object obj88 = default(object);
		object obj21;
		object obj31 = default(object);
		object obj20;
		object obj38 = default(object);
		object obj42 = default(object);
		Func<object, bool> func4 = default(Func<object, bool>);
		nint num7 = default(nint);
		while (true)
		{
			object[] array;
			if (obj16 != null)
			{
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v25+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v25+12E]");
				if ((nint)0 == 0)
				{
					goto IL_026f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v25+B0]");
				int num4 = (int)((nint)0 + (nint)8);
				bool flag6 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v85 (System.Int32)-8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v85 (System.Int32)-8]");
					bool flag7 = 0 < (nint)obj10;
					object obj5 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v85 (System.Int32)-8]");
					object obj6 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X10_v85 (System.Int32)-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					num3 = num4 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v25+12E]");
					array = (object[])(-1);
					bool flag8 = (nint)array < 1;
					obj5 = !flag8;
					obj6 = array - 1;
					bool flag5 = obj6 == null;
					flag2 = (nint)array != 1;
					flag6 = flag2;
					num4 = num3;
					if (flag2)
					{
						continue;
					}
					goto IL_026f;
				}
				array = (object[])((int*)num4)->m_value;
				object obj18 = obj17 + ((int*)num4)->m_value;
				object obj19 = obj18 + 312;
				flag2 = flag6;
				num3 = num4;
				goto IL_24ea;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj20 = (object)(&obj16);
			obj21 = 0;
			OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
			goto IL_30d0;
			IL_1f60:
			object obj22 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj24;
			object obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v14+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v14+12E]");
			if ((nint)0 == 0)
			{
				goto IL_2018;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v14+B0]");
			int num5 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v10 (System.Int32)-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X10_v10 (System.Int32)-8]");
				if (0 == (nint)obj22)
				{
					break;
				}
				num3 = num5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v14+12E]");
				array = (object[])(-1);
				bool flag9 = (nint)array != 1;
				num5 = num3;
				if (flag9)
				{
					continue;
				}
				goto IL_2018;
			}
			array = (object[])((int*)num5)->m_value;
			object obj25 = obj23 + ((int*)num5)->m_value;
			object obj26 = obj25 + 312;
			num6 = num7;
			num3 = num5;
			goto IL_3040;
			IL_30d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			object obj29;
			if ((nint)func == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj24 = obj20;
				bool flag10 = obj20 == null;
				object obj27 = !flag10;
				obj21 = obj28;
				obj29 = 0;
				if (obj27 == null)
				{
					obj30 = obj31;
					obj32 = obj20;
					obj33 = obj13;
					obj34 = obj12;
					obj35 = obj11;
					obj36 = obj10;
					obj21 = obj28;
					obj37 = obj38;
					obj39 = obj14;
					obj40 = obj4;
					obj41 = obj42;
					func3 = func4;
					num6 = num7;
					num8 = num3;
					obj43 = 0;
					obj44 = obj;
					break;
				}
				goto IL_1f60;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0518:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_2644;
			IL_2644:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v47+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1111 @ X0_v47] (should have been resolved before IL gen)");
			if (func5 == null)
			{
				continue;
			}
			object obj45 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v206+E4]");
			object obj46;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v206+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v186+8]");
				func4 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v186+8]");
				bool flag11 = (nint)0 == 0;
				object obj47 = !flag11;
				if (obj47 == null)
				{
					goto IL_0652;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj45 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v206+B8]");
				obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v186+8]");
				func4 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1164 @ X8_v186+8]");
				bool flag12 = (nint)0 == 0;
				object obj48 = !flag12;
				if (obj48 == null)
				{
					goto IL_0652;
				}
			}
			goto IL_06b9;
			IL_026f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_24ea;
			IL_24ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v38+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v38] (should have been resolved before IL gen)");
			object obj49 = obj50 & 1;
			if (obj49 != null)
			{
				if (obj16 != null)
				{
					object obj51 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v30+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v30+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03d2;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v30+B0]");
					int num9 = (int)((nint)0 + (nint)8);
					bool flag13 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X10_v80 (System.Int32)-8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X10_v80 (System.Int32)-8]");
						bool flag14 = 0 < (nint)obj11;
						object obj5 = !flag14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X10_v80 (System.Int32)-8]");
						object obj6 = 0 - obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X10_v80 (System.Int32)-8]");
						if (0 == (nint)obj11)
						{
							break;
						}
						num3 = num9 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v30+12E]");
						array = (object[])(-1);
						bool flag15 = (nint)array < 1;
						obj5 = !flag15;
						obj6 = array - 1;
						bool flag5 = obj6 == null;
						flag2 = (nint)array != 1;
						flag13 = flag2;
						num9 = num3;
						if (flag2)
						{
							continue;
						}
						goto IL_03d2;
					}
					array = (object[])((int*)num9)->m_value;
					object obj52 = obj51 + ((int*)num9)->m_value;
					object obj53 = obj52 + 312;
					flag2 = flag13;
					num3 = num9;
					goto IL_259e;
				}
				NullReferenceException ex4 = new NullReferenceException();
				obj20 = (object)(&obj16);
				obj21 = 0;
				ex3 = (OutOfMemoryException)(object)ex4;
				goto IL_30d0;
			}
			obj29 = 15;
			object obj54 = (object)(&obj16);
			obj24 = obj54;
			bool flag16 = obj54 == null;
			obj20 = (object)(&obj16);
			obj21 = 0;
			obj30 = obj31;
			obj32 = (object)(&obj16);
			obj33 = obj13;
			obj34 = obj12;
			obj35 = obj11;
			obj36 = obj10;
			obj21 = 0;
			obj37 = obj38;
			obj39 = obj14;
			obj40 = obj4;
			obj41 = obj42;
			func3 = func4;
			num6 = num7;
			num8 = num3;
			obj43 = obj29;
			obj44 = obj;
			if (flag16)
			{
				break;
			}
			goto IL_1f60;
			IL_0652:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v206+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X0_v206+E4]");
			bool flag17 = (nint)0 == 0;
			object obj55 = !flag17;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj56 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v192+B8]");
				obj46 = 0;
			}
			obj38 = obj46;
			object obj57 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj58 = (nint)0 + (nint)1416;
			func6..ctor(obj46, (IntPtr)obj58);
			object obj59 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v191+B8]");
			object obj60 = (nint)0 + (nint)8;
			obj60 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj42 = 0;
			func4 = func6;
			goto IL_06b9;
			IL_2018:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_3040;
			IL_09e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_2790;
			IL_3040:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X0_v27+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1045 @ X0_v27] (should have been resolved before IL gen)");
			obj30 = obj31;
			obj32 = obj20;
			obj33 = obj13;
			obj34 = obj12;
			obj35 = obj11;
			obj36 = obj10;
			obj37 = obj38;
			obj39 = obj14;
			obj40 = obj4;
			obj41 = obj42;
			func3 = func4;
			num8 = num3;
			obj43 = obj29;
			obj44 = obj;
			break;
			IL_06b9:
			num7 = (nint)obj;
			bool flag18 = Enumerable.Any(enumerable, func4);
			bool flag19 = !flag18;
			func = func4;
			if (flag19)
			{
				continue;
			}
			object obj61 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj62..ctor();
			object obj63 = obj62 + 120;
			obj63 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((StoreDataHolder)obj62).SetTemplate();
			if (list != null)
			{
				object obj64 = (nint)0 + (nint)2808;
				object obj65 = obj64;
				int version = list._version + 1;
				list._version = version;
				array = list._items;
				if (list._items != null)
				{
					num3 = list._size;
					obj4 = array.Length;
					bool flag20 = list._size < array.Length;
					object obj66 = !flag20;
					object obj67 = list._size - array.Length;
					bool flag21 = obj67 == null;
					if (obj66 == null)
					{
						int num10 = list._size + 1;
						list._size = num10;
						object obj68 = list._items + list._size;
						object obj69 = obj68 + 32;
						obj69 = obj62;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1200 @ X8_v43+20]");
						object obj70 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v182+C0]");
						object obj71 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X8_v183+70]");
						num7 = 0;
						list.AddWithResize(obj62);
					}
					object obj72 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3752;
					nint num11 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v47 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v47 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_09e5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v47 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
					int num12 = (int)((nint)0 + (nint)8);
					bool flag22 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X10_v70 (System.Int32)-8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X10_v70 (System.Int32)-8]");
						bool flag23 = 0 < (nint)obj72;
						obj66 = !flag23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X10_v70 (System.Int32)-8]");
						obj67 = 0 - obj72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X10_v70 (System.Int32)-8]");
						if (0 == (nint)obj72)
						{
							break;
						}
						num3 = num12 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1232 @ X8_v47 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
						array = (object[])(-1);
						bool flag24 = (nint)array < 1;
						obj66 = !flag24;
						obj67 = array - 1;
						flag21 = obj67 == null;
						flag2 = (nint)array != 1;
						flag22 = flag2;
						num12 = num3;
						if (flag2)
						{
							continue;
						}
						goto IL_09e5;
					}
					object obj73 = num11 + ((int*)num12)->m_value;
					object obj74 = obj73 + 312;
					flag2 = flag22;
					num3 = num12;
					array = (object[])((int*)num12)->m_value;
					goto IL_2790;
				}
			}
			NullReferenceException ex5 = new NullReferenceException();
			obj20 = (object)(&obj16);
			obj21 = 0;
			func4 = (Func<object, bool>)obj62;
			func = func5;
			ex3 = (OutOfMemoryException)(object)ex5;
			goto IL_30d0;
			IL_03d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num7 = unchecked((nint)null);
			goto IL_259e;
			IL_259e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1001 @ X0_v43] (should have been resolved before IL gen)");
			if (enumerable != null)
			{
				nint num13 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0518;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
				int num14 = (int)((nint)0 + (nint)8);
				bool flag25 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X10_v75 (System.Int32)-8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X10_v75 (System.Int32)-8]");
					bool flag26 = 0 < (nint)obj12;
					object obj5 = !flag26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X10_v75 (System.Int32)-8]");
					object obj6 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X10_v75 (System.Int32)-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					num3 = num14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X8_v33 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
					array = (object[])(-1);
					bool flag27 = (nint)array < 1;
					obj5 = !flag27;
					obj6 = array - 1;
					bool flag5 = obj6 == null;
					flag2 = (nint)array != 1;
					flag25 = flag2;
					num14 = num3;
					if (flag2)
					{
						continue;
					}
					goto IL_0518;
				}
				array = (object[])((int*)num14)->m_value;
				object obj75 = num13 + ((int*)num14)->m_value;
				object obj76 = obj75 + 312;
				flag2 = flag25;
				num3 = num14;
				goto IL_2644;
			}
			NullReferenceException ex6 = new NullReferenceException();
			obj20 = (object)(&obj16);
			obj21 = 0;
			ex3 = (OutOfMemoryException)(object)ex6;
			goto IL_30d0;
			IL_2790:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1302 @ X0_v63+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1302 @ X0_v63] (should have been resolved before IL gen)");
			obj38 = obj15 + 1;
			object obj77 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1184;
			while (true)
			{
				if (func2 != null)
				{
					nint num15 = (nint)func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v52 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v52 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0b2b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v52 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
					int num16 = (int)((nint)0 + (nint)8);
					bool flag28 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v65 (System.Int32)-8]");
						obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v65 (System.Int32)-8]");
						bool flag29 = 0 < (nint)obj10;
						object obj66 = !flag29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v65 (System.Int32)-8]");
						object obj67 = 0 - obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ X10_v65 (System.Int32)-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						num3 = num16 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v52 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						array = (object[])(-1);
						bool flag30 = (nint)array < 1;
						obj66 = !flag30;
						obj67 = array - 1;
						bool flag21 = obj67 == null;
						flag2 = (nint)array != 1;
						flag28 = flag2;
						num16 = num3;
						if (flag2)
						{
							continue;
						}
						goto IL_0b2b;
					}
					array = (object[])((int*)num16)->m_value;
					object obj78 = num15 + ((int*)num16)->m_value;
					object obj79 = obj78 + 312;
					flag2 = flag28;
					num3 = num16;
					goto IL_2840;
				}
				NullReferenceException ex7 = new NullReferenceException();
				obj31 = (object)(&func2);
				object obj80 = 0;
				obj20 = (object)(&obj16);
				obj21 = 0;
				func4 = (Func<object, bool>)obj62;
				ex3 = (OutOfMemoryException)(object)ex7;
				break;
				IL_2948:
				obj31 = (object)(&func2);
				obj80 = 0;
				obj20 = (object)(&obj16);
				obj21 = 0;
				func4 = func2;
				ex3 = new OutOfMemoryException();
				break;
				IL_29ab:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1529 @ X0_v183+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1529 @ X0_v183] (should have been resolved before IL gen)");
				goto IL_2948;
				IL_0e19:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num7 = unchecked((nint)null);
				goto IL_29ab;
				IL_0c8e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num7 = unchecked((nint)null);
				goto IL_28f4;
				IL_0b2b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num7 = unchecked((nint)null);
				goto IL_2840;
				IL_2840:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ X0_v68+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1377 @ X0_v68] (should have been resolved before IL gen)");
				object obj81 = obj82 & 1;
				if (obj81 != null)
				{
					if (func2 != null)
					{
						nint num17 = (nint)func2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v173 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						array = (object[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v173 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0c8e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v173 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
						int num18 = (int)((nint)0 + (nint)8);
						bool flag31 = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v60 (System.Int32)-8]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v60 (System.Int32)-8]");
							bool flag32 = 0 < (nint)obj77;
							object obj66 = !flag32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v60 (System.Int32)-8]");
							object obj67 = 0 - obj77;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X10_v60 (System.Int32)-8]");
							if (0 == (nint)obj77)
							{
								break;
							}
							num3 = num18 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ X8_v173 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
							array = (object[])(-1);
							bool flag33 = (nint)array < 1;
							obj66 = !flag33;
							obj67 = array - 1;
							bool flag21 = obj67 == null;
							flag2 = (nint)array != 1;
							flag31 = flag2;
							num18 = num3;
							if (flag2)
							{
								continue;
							}
							goto IL_0c8e;
						}
						array = (object[])((int*)num18)->m_value;
						object obj83 = num17 + ((int*)num18)->m_value;
						object obj84 = obj83 + 312;
						flag2 = flag31;
						num3 = num18;
						goto IL_28f4;
					}
					NullReferenceException ex8 = new NullReferenceException();
					obj31 = (object)(&func2);
					obj80 = 0;
					obj20 = (object)(&obj16);
					obj21 = 0;
					func4 = (Func<object, bool>)obj62;
					ex3 = (OutOfMemoryException)(object)ex8;
					break;
				}
				if (func2 == null)
				{
					goto IL_2948;
				}
				object obj85 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num19 = (nint)func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v169 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v169 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0e19;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v169 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
				int num20 = (int)((nint)0 + (nint)8);
				bool flag34 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X10_v54 (System.Int32)-8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X10_v54 (System.Int32)-8]");
					if (0 == (nint)obj85)
					{
						break;
					}
					num3 = num20 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v169 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					array = (object[])(-1);
					flag2 = (nint)array != 1;
					flag34 = flag2;
					num20 = num3;
					if (flag2)
					{
						continue;
					}
					goto IL_0e19;
				}
				array = (object[])((int*)num20)->m_value;
				object obj86 = num19 + ((int*)num20)->m_value;
				object obj87 = obj86 + 312;
				flag2 = flag34;
				num3 = num20;
				goto IL_29ab;
				IL_28f4:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ X0_v190+8]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1522 @ X0_v190] (should have been resolved before IL gen)");
				if (obj88 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1313 @ X0_v192+68]");
					bool flag35 = (nint)0 == 0;
					object obj89 = !flag35;
					if (obj89 == null)
					{
						object obj90 = obj14 - 1;
						obj14 = obj90;
					}
					continue;
				}
				NullReferenceException ex9 = new NullReferenceException();
				obj31 = (object)(&func2);
				obj80 = 0;
				obj20 = (object)(&obj16);
				obj21 = 0;
				func4 = (Func<object, bool>)obj62;
				ex3 = (OutOfMemoryException)(object)ex9;
				break;
			}
			goto IL_30d0;
		}
		bool flag36 = obj21 == null;
		object obj91 = !flag36;
		obj31 = obj30;
		obj20 = obj32;
		obj13 = obj33;
		obj12 = obj34;
		obj11 = obj35;
		obj10 = obj36;
		obj38 = obj37;
		obj14 = obj39;
		obj4 = obj40;
		obj42 = obj41;
		func4 = func3;
		num7 = num6;
		num3 = num8;
		obj = obj44;
		if (obj91 == null)
		{
			if ((nint)obj43 != 15)
			{
				bool flag37 = obj43 == null;
				object obj92 = !flag37;
				if (obj92 != null)
				{
					return;
				}
			}
			base.data = (List<StoreDataHolder>)(object)list;
			return;
		}
		goto IL_218a;
		IL_0129:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num7 = unchecked((nint)null);
		goto IL_23e4;
		IL_218a:
		throw new OutOfMemoryException();
	}

	public void Populate(IEnumerable<IGrouping<string, StoreItem>> groups)
	{
		SetData(groups);
	}

	public StoreCardGroup()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
