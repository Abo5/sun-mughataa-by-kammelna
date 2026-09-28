using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.TextCore;

public static class ArraysExtensions
{
	private class Grouping<TKey, TElement> : List<TElement>, IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
	{
		private readonly TKey <Key>k__BackingField;

		public TKey Key
		{
			get
			{
				//IL_000d: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ArraysExtensions+Grouping`2<TKey, TElement>)+28]");
				return (TKey)0;
			}
		}

		public Grouping(TKey key)
		{
			//IL_0016: Expected O, but got I
			//IL_002c: Expected O, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0054: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((List<object>)(object)this)..ctor();
		}

		public Grouping(TKey key, int capacity)
		{
			//IL_0016: Expected O, but got I
			//IL_002c: Expected O, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0054: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((List<object>)(object)this)..ctor(capacity);
		}

		public Grouping(TKey key, IEnumerable<TElement> collection)
		{
			//IL_0016: Expected O, but got I
			//IL_002c: Expected O, but got I
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0054: Expected O, but got I4
			//IL_0093: Expected O, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2 (Il2CppRgctx<ArraysExtensions+Grouping`2>)+18]");
			if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v2+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((List<object>)(object)this)..ctor((IEnumerable<object>)collection);
		}
	}

	[Serializable]
	private sealed class <>c__1<T>
	{
		public static readonly <>c__1<T> <>9;

		public static Func<T, float> <>9__1_0;

		static <>c__1()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__1`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal float <Shuffled>b__1_0(T _)
		{
			return UnityEngine.Random.value;
		}
	}

	[Serializable]
	private sealed class <>c__19<T>
	{
		public static readonly <>c__19<T> <>9;

		public static Func<T, string> <>9__19_0;

		static <>c__19()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__19`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <JoinToString>b__19_0(T obj)
		{
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (obj != null)
			{
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<T>)+168]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<T>)+170]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}
	}

	[Serializable]
	private sealed class <>c__2<T>
	{
		public static readonly <>c__2<T> <>9;

		public static Func<T, string> <>9__2_0;

		static <>c__2()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__2`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ToPrettyString>b__2_0(T s)
		{
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (s != null)
			{
				nint num = (nint)s;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<T>)+168]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<T>)+170]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}
	}

	[Serializable]
	private sealed class <>c__3<T, J>
	{
		public static readonly <>c__3<T, J> <>9;

		public static Func<KeyValuePair<T, J>, string> <>9__3_0;

		static <>c__3()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__3`2>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ToPrettyString>b__3_0(KeyValuePair<T, J> keyValuePair)
		{
			//IL_0059: Expected O, but got I
			//IL_002c: Expected O, but got I
			object obj = (nint)0 + (nint)3704;
			bool flag = (object)keyValuePair == null;
			KeyValuePair<T, J> keyValuePair2 = keyValuePair;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ X8_v6+168] (should have been resolved before IL gen)");
				KeyValuePair<T, J> keyValuePair3 = default(KeyValuePair<T, J>);
				keyValuePair2 = keyValuePair3;
			}
			IntPtr intPtr = default(IntPtr);
			string text;
			if (intPtr != (IntPtr)0)
			{
				object obj2 = (nint)intPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ X8_v5+168] (should have been resolved before IL gen)");
				string text2 = default(string);
				text = text2;
			}
			else
			{
				text = null;
			}
			return (string)keyValuePair2 + (string)obj + text;
		}
	}

	[Serializable]
	private sealed class <>c__33<T>
	{
		public static readonly <>c__33<T> <>9;

		public static Func<List<T>, IEnumerable<T>> <>9__33_0;

		static <>c__33()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__33`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<T> <Flatten>b__33_0(List<T> x)
		{
			return x;
		}
	}

	[Serializable]
	private sealed class <>c__6<T>
	{
		public static readonly <>c__6<T> <>9;

		public static Func<T, float> <>9__6_0;

		static <>c__6()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ArraysExtensions+<>c__6`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal float <Shuffle>b__6_0(T a)
		{
			return UnityEngine.Random.value;
		}
	}

	private sealed class <>c__DisplayClass14_0<T>
	{
		public Func<T, IComparable> func;

		internal T <MaxBy>b__0(T l, T r)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_008b: Expected O, but got I
			//IL_0215: Expected O, but got I4
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected O, but got Unknown
			//IL_00c6: Expected O, but got I
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			Func<T, IComparable> func = this.func;
			if (this.func != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ X8_v3 (System.Func`2<T, System.IComparable>)+18] (should have been resolved before IL gen)");
				Func<T, IComparable> func2 = this.func;
				if (this.func != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ X8_v5 (System.Func`2<T, System.IComparable>)+18] (should have been resolved before IL gen)");
					object obj = default(object);
					if (obj != null)
					{
						object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1640;
						object obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+12E]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0107;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+B0]");
						object obj5 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X10_v5-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj5 += 16;
							obj4--;
							if ((nint)obj4 != 1)
							{
								continue;
							}
							goto IL_0107;
						}
						object obj6 = obj3 + obj5;
						object obj7 = obj6 + 312;
						goto IL_01ab;
					}
				}
			}
			return (T)new NullReferenceException();
			IL_01ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ X0_v8] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = (nint)obj8 < 0;
			bool flag2 = obj8 == null;
			object obj9 = obj8 ^ obj8;
			object obj10 = obj8 & obj9;
			bool flag3 = (nint)obj10 < 0;
			bool flag4 = flag == flag3;
			object obj11 = !flag2;
			object obj12 = flag4 & obj11;
			object obj13 = ~obj12;
			if (obj13 == null)
			{
				return l;
			}
			return r;
			IL_0107:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01ab;
		}
	}

	private sealed class <>c__DisplayClass15_0<T>
	{
		public Func<T, IComparable> func;

		internal T <MinBy>b__0(T l, T r)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_008b: Expected O, but got I
			//IL_0206: Expected O, but got I4
			//IL_00c6: Expected O, but got I
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected O, but got Unknown
			Func<T, IComparable> func = this.func;
			if (this.func != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ X8_v3 (System.Func`2<T, System.IComparable>)+18] (should have been resolved before IL gen)");
				Func<T, IComparable> func2 = this.func;
				if (this.func != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ X8_v5 (System.Func`2<T, System.IComparable>)+18] (should have been resolved before IL gen)");
					object obj = default(object);
					if (obj != null)
					{
						object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1640;
						object obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+12E]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0107;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v8+B0]");
						object obj5 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v5-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj5 += 16;
							obj4--;
							if ((nint)obj4 != 1)
							{
								continue;
							}
							goto IL_0107;
						}
						object obj6 = obj3 + obj5;
						object obj7 = obj6 + 312;
						goto IL_01ab;
					}
				}
			}
			return (T)new NullReferenceException();
			IL_01ab:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X0_v8] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = (nint)obj8 < 0;
			object obj9 = obj8 ^ obj8;
			object obj10 = obj8 & obj9;
			bool flag2 = (nint)obj10 < 0;
			bool flag3 = flag == flag2;
			object obj11 = !flag3;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
				return l;
			}
			return r;
			IL_0107:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01ab;
		}
	}

	private sealed class <>c__DisplayClass17_0<T>
	{
		public List<T> list;

		internal IEnumerable<T> <GetPowerSet>b__0(int m)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00fa: Expected O, but got I
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0122: Expected O, but got I4
			//IL_0058: Expected O, but got I
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_00bd: Expected O, but got I4
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01cd: Expected O, but got I
			//IL_023e: Expected O, but got I
			//IL_0254: Expected O, but got I
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_027c: Expected O, but got I4
			object obj = 152961024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0CB1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				nint num = 0;
				IntPtr intPtr = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				IntPtr intPtr2 = num;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				nint num2 = 0;
				IntPtr intPtr = num2;
				object obj5 = num2 + 309;
				object obj6 = obj5 & 1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				IntPtr intPtr2 = num2;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = default(object);
			obj8..ctor();
			bool flag3 = obj8 == null;
			object obj9 = obj8;
			if (!flag3)
			{
				goto IL_017f;
			}
			goto IL_02db;
			IL_02db:
			return (IEnumerable<T>)new NullReferenceException();
			IL_017f:
			List<T> list = this.list;
			if (this.list != null)
			{
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
				object obj11 = (nint)0 + (nint)3520;
				IEnumerable<int> source = Enumerable.Range(0, list._size);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num3 = 0;
				object obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass17_0`1>)+28]");
				Func<int, bool> func = default(Func<int, bool>);
				func..ctor(obj12, (IntPtr)0);
				IEnumerable<int> source2 = Enumerable.Where(source, func);
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass17_0`1>)+38]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass17_0`1>)+38]");
				object obj14 = (nint)0 + (nint)309;
				object obj15 = obj14 & 1;
				bool flag4 = obj15 == null;
				object obj16 = !flag4;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass17_0`1>)+30]");
				Func<int, ProjectsUtility<System.Int32Enum>.Project> func2 = default(Func<int, ProjectsUtility<System.Int32Enum>.Project>);
				func2..ctor((object)this, (IntPtr)0);
				return (IEnumerable<T>)Enumerable.Select(source2, func2);
			}
			goto IL_02db;
			IL_008b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = default(object);
			obj17..ctor();
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			obj9 = obj17;
			if (obj18 != null)
			{
				goto IL_017f;
			}
			goto IL_02db;
		}

		internal T <GetPowerSet>b__2(int i)
		{
			if (list != null)
			{
				return (T)((List<ProjectsUtility<System.Int32Enum>.Project>)(object)list).get_Item(i);
			}
			return (T)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass17_1<T>
	{
		public int m;

		internal bool <GetPowerSet>b__1(int i)
		{
			int num = m >> i;
			return (byte)(num & 1) != 0;
		}
	}

	private sealed class <>c__DisplayClass25_0<TSource1, TSource2>
	{
		public IEnumerable<TSource2> source2;

		public Func<TSource1, TSource2, bool> predicate;

		internal unsafe bool <Intersect>b__0(TSource1 s1)
		{
			//IL_0008: Expected O, but got Ref
			//IL_0018: Expected O, but got I
			//IL_0038: Expected O, but got I
			//IL_004e: Expected O, but got I
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_006d: Expected O, but got Ref
			//IL_0083: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_00ab: Expected O, but got I4
			//IL_00e8: Expected O, but got I
			//IL_012d: Expected O, but got I
			//IL_0143: Expected O, but got I
			//IL_0163: Expected O, but got I
			//IL_0197: Expected O, but got I
			//IL_01cb: Expected O, but got I
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected O, but got Unknown
			//IL_01fd: Expected O, but got Ref
			//IL_0216: Expected O, but got I4
			//IL_0326: Expected O, but got I
			//IL_033c: Expected O, but got I
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected O, but got Unknown
			//IL_0364: Expected O, but got I4
			//IL_0261: Expected O, but got I
			//IL_029b: Expected O, but got I
			//IL_02c4: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X9_v1+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj8 = default(object);
			object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
			IntPtr intPtr = num;
			object obj9 = num + 309;
			object obj10 = obj9 & 1;
			bool flag = obj10 == null;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v9 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ X1_v2] (should have been resolved before IL gen)");
			object obj13 = default(object);
			if (obj13 != null)
			{
				nint num3 = 0;
				IntPtr intPtr2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v14 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>>)+80]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v14 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>>)+80]");
				object obj15 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v14 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>>)+80]");
				object obj16 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X25_v3 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+18]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v16+28]");
				bool flag2 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v16+28]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v16+28]");
				object obj18 = num5 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v16+28]");
				object obj19 = 0 & obj18;
				bool flag3 = (nint)obj19 < 0;
				TSource1 val = (TSource1)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
				bool flag4 = flag2 == flag3;
				object obj20 = !flag4;
				object obj21 = ~obj20;
				if (obj21 == null)
				{
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				IntPtr intPtr3 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17E0");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v21 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+30]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v21 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+30]");
				object obj23 = (nint)0 + (nint)309;
				object obj24 = obj23 & 1;
				bool flag5 = obj24 == null;
				object obj25 = !flag5;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v25 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+38]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ X3_v1] (should have been resolved before IL gen)");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v27 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_0`2>)+40]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X2_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				bool flag6 = obj27 != null;
				object obj28 = default(object);
				obj12 = obj28;
				bool flag7 = default(bool);
				NullReferenceException ex = (NullReferenceException)flag7;
				if (!flag6)
				{
					return flag7;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			bool result = default(bool);
			return result;
		}
	}

	private sealed class <>c__DisplayClass25_1<TSource1, TSource2>
	{
		public TSource1 s1;

		public <>c__DisplayClass25_0<TSource1, TSource2> CS$<>8__locals1;

		internal unsafe bool <Intersect>b__1(TSource2 s2)
		{
			//IL_0008: Expected O, but got Ref
			//IL_0018: Expected O, but got I
			//IL_0038: Expected O, but got I
			//IL_0048: Expected O, but got I
			//IL_005e: Expected O, but got I
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_007d: Expected O, but got Ref
			//IL_0093: Expected O, but got I
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00b2: Expected O, but got Ref
			//IL_00d0: Expected O, but got I
			//IL_013c: Expected O, but got I
			//IL_0170: Expected O, but got I
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Expected O, but got Unknown
			//IL_01a2: Expected O, but got Ref
			//IL_01bb: Expected O, but got I4
			//IL_01e7: Expected O, but got I
			//IL_01f7: Expected O, but got I
			//IL_0211: Expected O, but got I8
			//IL_022b: Expected O, but got I4
			//IL_02de: Expected O, but got I8
			//IL_02f8: Expected O, but got I4
			//IL_031e: Expected O, but got Ref
			//IL_032c: Expected O, but got Ref
			//IL_0346: Expected O, but got I
			//IL_037f: Expected O, but got I
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>)+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X9_v1+FC]");
			object obj6 = (nint)0 + (nint)15;
			object obj7 = obj6 & 0x1FFFFFFF0L;
			object obj9 = default(object);
			object obj8 = (ref *(?*)(&obj9)) - (ref *(?*)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X10_v1+FC]");
			object obj10 = (nint)0 + (nint)15;
			object obj11 = obj10 & 0x1FFFFFFF0L;
			object obj12 = (ref *(?*)(&obj9)) - (ref *(?*)obj11);
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>>)+80]");
			TSource2 val = (TSource2)((nint)0 + (nint)32);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj14 = default(object);
			object obj13 = obj14;
			NullReferenceException ex;
			if (obj14 != null)
			{
				nint num2 = 0;
				IntPtr intPtr2 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v4 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>)+20]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+28]");
				bool flag = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+28]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+28]");
				object obj16 = num4 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+28]");
				object obj17 = 0 & obj16;
				bool flag2 = (nint)obj17 < 0;
				TSource2 val2 = (TSource2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				bool flag3 = flag == flag2;
				object obj18 = !flag3;
				object obj19 = ~obj18;
				if (obj19 == null)
				{
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+18]");
				bool flag4 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X10_v1+FC]");
				nint num5 = 0;
				val = val2;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v4 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>)+28]");
					val = (TSource2)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X25_v4 (Il2CppRgctx<ArraysExtensions+<>c__DisplayClass25_1`2>)+18]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v17+28]");
					object obj21 = 0 & 0x80000000L;
					bool flag5 = obj21 == null;
					object obj22 = !flag5;
					if (obj22 == null)
					{
						obj8 = obj8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v15+28]");
					object obj23 = 0 & 0x80000000L;
					bool flag6 = obj23 == null;
					object obj24 = !flag6;
					if (obj24 == null)
					{
						obj12 = obj12;
					}
					object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
					object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 89));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X1_v2 (TSource2)+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
					bool flag7 = obj27 != null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8+18]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-59]");
					ex = (NullReferenceException)0;
					if (!flag7)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-59]");
						return false;
					}
					goto IL_026e;
				}
			}
			ex = new NullReferenceException();
			goto IL_026e;
			IL_026e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			bool result = default(bool);
			return result;
		}
	}

	private sealed class <Chunk>d__20<T> : IEnumerable<IEnumerable<T>>, IEnumerable, IEnumerator<IEnumerable<T>>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private IEnumerable<T> <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<T> source;

		public IEnumerable<T> <>3__source;

		private int size;

		public int <>3__size;

		private int <pos>5__2;

		IEnumerable<T> IEnumerator<IEnumerable<T>>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Chunk>d__20(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0080: Expected I4, but got I8
			//IL_003b: Expected O, but got I4
			//IL_0058: Expected I4, but got I8
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			int count;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_00fd;
				}
				<>1__state = -1;
				<pos>5__2 = 0;
				count = 0;
			}
			else
			{
				<>1__state = -1;
				count = (<pos>5__2 = size + <pos>5__2);
			}
			IEnumerable<object> enumerable = Enumerable.Skip((IEnumerable<object>)source, count);
			if (Enumerable.Any(enumerable))
			{
				IEnumerable<object> enumerable2 = Enumerable.Skip((IEnumerable<object>)source, <pos>5__2);
				nint num = 0;
				IEnumerable<object> enumerable3 = Enumerable.Take(enumerable2, size);
				object obj2 = this + 24;
				obj2 = enumerable3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return true;
			}
			goto IL_00fd;
			IL_00fd:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<IEnumerable<T>> IEnumerable<IEnumerable<T>>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0111;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0111;
			IL_0111:
			object obj8 = obj3 + 40;
			obj8 = <>3__source;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = <>3__size;
			return (IEnumerator<IEnumerable<T>>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FE2EC8");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	private sealed class <DistinctBy>d__21<TSource, TKey> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private TSource <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<TSource> source;

		public IEnumerable<TSource> <>3__source;

		private Func<TSource, TKey> keySelector;

		public Func<TSource, TKey> <>3__keySelector;

		private HashSet<TKey> <seenKeys>5__2;

		private IEnumerator<TSource> <>7__wrap2;

		TSource IEnumerator<TSource>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <DistinctBy>d__21(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0182: Expected I4, but got I8
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_0094: Expected I, but got O
			//IL_00a4: Expected O, but got I
			//IL_00df: Expected O, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			while (true)
			{
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				<>1__state = -1;
				IEnumerator<TSource> enumerator = <>7__wrap2;
				if (<>7__wrap2 == null)
				{
					break;
				}
				object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+B0]");
					object obj8 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj8 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_0120;
					}
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v187 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_0120;
				IL_0120:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v174 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private bool MoveNext()
		{
			//IL_082e: Expected O, but got I4
			//IL_026b: Expected I4, but got I8
			//IL_0920: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Expected O, but got Unknown
			//IL_0021: Expected O, but got I4
			//IL_0a8c: Expected O, but got I
			//IL_0730: Expected O, but got I
			//IL_003e: Expected I4, but got I8
			//IL_0054: Expected O, but got I
			//IL_006a: Expected O, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0092: Expected O, but got I4
			//IL_02b8: Expected O, but got I
			//IL_079e: Expected O, but got I4
			//IL_0383: Expected O, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00f9: Expected O, but got I
			//IL_097b: Expected O, but got I
			//IL_098e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0993: Expected O, but got Unknown
			//IL_02f3: Expected O, but got I
			//IL_093d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0942: Expected O, but got Unknown
			//IL_012e: Expected O, but got I
			//IL_013e: Expected O, but got I
			//IL_014e: Expected O, but got I
			//IL_0164: Expected O, but got I
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_018c: Expected O, but got I4
			//IL_0acb: Expected O, but got I
			//IL_03c8: Expected O, but got I
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			//IL_086a: Expected O, but got I
			//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b54: Expected O, but got Unknown
			//IL_0b5d: Expected O, but got I4
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031c: Expected O, but got Unknown
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Expected O, but got Unknown
			//IL_0257: Expected O, but got I4
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Expected O, but got Unknown
			//IL_0665: Expected O, but got I
			//IL_03fd: Expected O, but got I
			//IL_040d: Expected O, but got I
			//IL_041d: Expected O, but got I
			//IL_0433: Expected O, but got I
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Expected O, but got Unknown
			//IL_045b: Expected O, but got I4
			//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e8: Expected O, but got Unknown
			//IL_08f0: Expected O, but got I
			//IL_01c7: Expected O, but got I
			//IL_06f4: Expected O, but got I4
			//IL_09c8: Expected O, but got I
			//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a7: Expected O, but got Unknown
			//IL_06a0: Expected O, but got I
			//IL_0526: Expected O, but got I4
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected O, but got Unknown
			//IL_0a3d: Expected O, but got I
			//IL_0a57: Expected O, but got I
			//IL_0496: Expected O, but got I
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
			//IL_070f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Expected O, but got Unknown
			//IL_09ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a04: Expected O, but got Unknown
			//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b3: Expected O, but got Unknown
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected O, but got Unknown
			//IL_056b: Expected O, but got I
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Expected O, but got Unknown
			//IL_0746: Expected O, but got I4
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Expected O, but got Unknown
			//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Expected O, but got Unknown
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cf: Expected O, but got Unknown
			//IL_05aa: Expected O, but got I
			//IL_05ba: Expected O, but got I
			//IL_05ca: Expected O, but got I
			//IL_05df: Expected O, but got I
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Expected O, but got Unknown
			object obj = <>1__state - 1;
			object obj8 = default(object);
			bool flag5 = default(bool);
			NullReferenceException ex;
			HashSet<int> hashSet2;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj2 = !flag;
				if (obj2 != null)
				{
					goto IL_0719;
				}
				<>1__state = -1;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v43 (Il2CppRgctx<ArraysExtensions+<DistinctBy>d__21`2>)+10]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v43 (Il2CppRgctx<ArraysExtensions+<DistinctBy>d__21`2>)+10]");
				object obj4 = (nint)0 + (nint)309;
				object obj5 = obj4 & 1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				HashSet<int> hashSet = default(HashSet<int>);
				hashSet..ctor();
				object obj7 = obj8 + 72;
				obj7 = hashSet;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+28]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v51+C0]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v52+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v52+20]");
					object obj13 = (nint)0 + (nint)309;
					object obj14 = obj13 & 1;
					bool flag3 = obj14 == null;
					object obj15 = !flag3;
					if (obj15 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj16 = default(object);
						obj12 = obj16;
					}
					object obj17 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v55+12E]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v55+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0244;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v55+B0]");
					object obj19 = (nint)0 + (nint)8;
					bool flag4 = flag5;
					object obj20;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v28-8]");
						obj = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v28-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj20 = obj19 + 16;
						obj18--;
						obj = obj18 - 1;
						bool flag6 = obj == null;
						flag5 = (nint)obj18 != 1;
						flag4 = flag5;
						obj19 = obj20;
						if (flag5)
						{
							continue;
						}
						goto IL_0244;
					}
					object obj21 = obj17 + obj19;
					object obj22 = obj21 + 312;
					flag5 = flag4;
					obj20 = obj19;
					goto IL_08d0;
				}
				ex = new NullReferenceException();
				hashSet2 = hashSet;
				goto IL_0783;
			}
			<>1__state = -3;
			goto IL_0911;
			IL_0244:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj23 = 0;
			goto IL_08d0;
			IL_0b46:
			object obj24 = obj8 + 80;
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0719;
			IL_08d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v519 @ X0_v69] (should have been resolved before IL gen)");
			object obj25 = obj8 + 80;
			IntPtr intPtr = default(IntPtr);
			obj25 = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 4294967293L;
			nint num2 = intPtr;
			goto IL_0911;
			IL_074b:
			ex = new NullReferenceException();
			goto IL_0783;
			IL_0911:
			object obj26 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj34 = default(object);
			object obj42 = default(object);
			int num3 = default(int);
			object obj52 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
				if ((nint)0 == 0)
				{
					break;
				}
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v9+12E]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v9+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0370;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v9+B0]");
				object obj30 = (nint)0 + (nint)8;
				bool flag7 = flag5;
				object obj20;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X10_v20-8]");
					obj = 0 - obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X10_v20-8]");
					if (0 == (nint)obj26)
					{
						break;
					}
					obj20 = obj30 + 16;
					obj29--;
					obj = obj29 - 1;
					bool flag6 = obj == null;
					flag5 = (nint)obj29 != 1;
					flag7 = flag5;
					obj30 = obj20;
					if (flag5)
					{
						continue;
					}
					goto IL_0370;
				}
				object obj31 = obj28 + obj30;
				object obj32 = obj31 + 312;
				flag5 = flag7;
				obj20 = obj30;
				goto IL_096b;
				IL_0370:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj23 = 0;
				goto IL_096b;
				IL_096b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v5+8]");
				hashSet2 = (HashSet<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v384 @ X0_v5] (should have been resolved before IL gen)");
				object obj33 = obj34 & 1;
				if (obj33 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
					if ((nint)0 == 0)
					{
						goto IL_074b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X8_v24+C0]");
					object obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v25+30]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v25+30]");
					object obj39 = (nint)0 + (nint)309;
					object obj40 = obj39 & 1;
					bool flag8 = obj40 == null;
					object obj41 = !flag8;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						obj38 = obj42;
					}
					object obj43 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v28+12E]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v28+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0513;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v28+B0]");
					object obj45 = (nint)0 + (nint)8;
					bool flag9 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v15-8]");
						obj = 0 - obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v15-8]");
						if (0 == (nint)obj38)
						{
							break;
						}
						obj20 = obj45 + 16;
						obj44--;
						obj = obj44 - 1;
						bool flag6 = obj == null;
						flag5 = (nint)obj44 != 1;
						flag9 = flag5;
						obj45 = obj20;
						if (flag5)
						{
							continue;
						}
						goto IL_0513;
					}
					object obj46 = obj43 + obj45;
					object obj47 = obj46 + 312;
					flag5 = flag9;
					obj20 = obj45;
					goto IL_0a2d;
				}
				goto IL_0ab1;
				IL_0513:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj23 = 0;
				goto IL_0a2d;
				IL_0a2d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v24+8]");
				hashSet2 = (HashSet<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v635 @ X0_v24] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+38]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v31+28]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v367 @ X8_v31+18] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+48]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
						object obj49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v33+C0]");
						object obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v34+60]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+48]");
						bool flag10 = ((HashSet<int>)0).Add(num3);
						bool flag11 = !flag10;
						num2 = num3;
						if (!flag11)
						{
							object obj51 = obj8 + 24;
							obj51 = obj52;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							return true;
						}
						continue;
					}
					goto IL_0735;
				}
				goto IL_0759;
			}
			ex = new NullReferenceException();
			hashSet2 = (HashSet<int>)num2;
			goto IL_0783;
			IL_0b14:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v644 @ X0_v13] (should have been resolved before IL gen)");
			goto IL_0b46;
			IL_0ab1:
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ stack_-38_v2+50]");
			if ((nint)0 != 0)
			{
				object obj54 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj55 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v18+12E]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06e1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v18+B0]");
				object obj57 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X10_v9-8]");
					if (0 == (nint)obj54)
					{
						break;
					}
					obj57 += 16;
					obj56--;
					if ((nint)obj56 != 1)
					{
						continue;
					}
					goto IL_06e1;
				}
				object obj58 = obj55 + obj57;
				object obj59 = obj58 + 312;
				goto IL_0b14;
			}
			goto IL_0b46;
			IL_06e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj23 = 0;
			goto IL_0b14;
			IL_0719:
			return false;
			IL_0783:
			bool flag12 = (nint)hashSet2 != 1;
			object obj60 = 0;
			NullReferenceException ex2 = ex;
			if (!flag12)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj61 = default(object);
				if (obj61 == null)
				{
					goto IL_0719;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA7F5C");
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj60 = obj61;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DA7820");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_0759:
			ex = new NullReferenceException();
			goto IL_0783;
			IL_0735:
			ex = new NullReferenceException();
			hashSet2 = (HashSet<int>)num3;
			goto IL_0783;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_00f6: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			while (true)
			{
				<>1__state = -1;
				IEnumerator<TSource> enumerator = <>7__wrap2;
				if (<>7__wrap2 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TSource>>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
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
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X0_v3] (should have been resolved before IL gen)");
				break;
			}
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<TSource> IEnumerable<TSource>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0111;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0111;
			IL_0111:
			object obj8 = obj3 + 40;
			obj8 = <>3__source;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj3 + 56;
			obj9 = <>3__keySelector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator<TSource>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FEAB28");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	private sealed class <GetCycledRange>d__29<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private T <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<T> enumerable;

		public IEnumerable<T> <>3__enumerable;

		private int count;

		public int <>3__count;

		private int startIndex;

		public int <>3__startIndex;

		private T[] <array>5__2;

		private int <arrayLength>5__3;

		private int <direction>5__4;

		private int <i>5__5;

		T IEnumerator<T>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <GetCycledRange>d__29(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_013c: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_034a: Expected O, but got I4
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_0359: Expected O, but got Unknown
			//IL_036a: Expected O, but got I4
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Expected I4, but got Unknown
			//IL_0395: Expected O, but got I4
			//IL_03bd: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_0490: Expected I4, but got O
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected O, but got Unknown
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Expected O, but got Unknown
			//IL_03f5: Expected O, but got I
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_0079: Expected O, but got I
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_01ac: Expected O, but got I4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00e6: Expected O, but got I
			//IL_0112: Expected O, but got I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_0213: Expected I, but got O
			//IL_021b: Expected I, but got O
			//IL_02bd: Expected I4, but got I8
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Expected O, but got Unknown
			//IL_04f7: Expected O, but got I4
			//IL_02ab: Expected I4, but got I8
			nint num2;
			int num4;
			object obj6;
			nint num3;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj == null)
				{
					<>1__state = -1;
					if (enumerable != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v18 (Il2CppRgctx<ArraysExtensions+<GetCycledRange>d__29`1>)+10]");
						object obj2 = (nint)0 + (nint)309;
						object obj3 = obj2 & 1;
						if (obj3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							IntPtr intPtr = default(IntPtr);
							bool flag2 = intPtr == (IntPtr)0;
							num2 = intPtr;
							if (!flag2)
							{
								goto IL_00d3;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							IntPtr intPtr2 = default(IntPtr);
							bool flag3 = intPtr2 == (IntPtr)0;
							object obj4 = !flag3;
							num2 = intPtr2;
							if (obj4 != null)
							{
								goto IL_00d3;
							}
						}
						object[] array = Enumerable.ToArray((IEnumerable<object>)enumerable);
						object obj5 = this + 72;
						obj5 = array;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj6 = obj5;
						bool flag4 = obj5 == null;
						num2 = (nint)array;
						num3 = (nint)array;
						if (!flag4)
						{
							goto IL_0229;
						}
						goto IL_0411;
					}
					object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 648;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj8 = "destinationTimeZone" + 2536;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					ArgumentNullException ex = default(ArgumentNullException);
					string paramName = default(string);
					ex..ctor(paramName);
					OutOfMemoryException ex2 = new OutOfMemoryException();
					goto IL_0482;
				}
			}
			else
			{
				<>1__state = -1;
				num4 = ++<i>5__5;
				if (num4 < count)
				{
					goto IL_0312;
				}
			}
			goto IL_040b;
			IL_040b:
			return false;
			IL_0411:
			throw new NullReferenceException();
			IL_00d3:
			object obj9 = this + 72;
			obj9 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj6 = obj9;
			bool flag5 = obj9 == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0229;
			}
			num3 = num2;
			goto IL_0411;
			IL_0312:
			T[] array2 = <array>5__2;
			if (<array>5__2 == null)
			{
				goto IL_0411;
			}
			object obj11 = <direction>5__4 * num4;
			object obj12 = <direction>5__4 + obj11;
			object obj13 = startIndex + <arrayLength>5__3;
			object obj14 = obj13 + obj12;
			int num5 = obj14 / <arrayLength>5__3;
			object obj15 = num5 * <arrayLength>5__3;
			object obj16 = obj14 - obj15;
			bool flag6 = (nint)obj16 < array2.Length;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				object obj18 = (object)<array>5__2 + obj16;
				object obj19 = this + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v12+20]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return true;
			}
			goto IL_0482;
			IL_0229:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v21+18]");
			<arrayLength>5__3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v21+18]");
			if ((nint)0 != 0 && count != 0)
			{
				int num6 = (int)((count < 1) ? 4294967295L : (-4294967295L));
				<direction>5__4 = num6;
				object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v24+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num7 = (count = ((count >= 0) ? count : (-count)));
				<i>5__5 = 0;
				bool flag8 = 0 >= num7;
				num3 = num2;
				num4 = 0;
				if (!flag8)
				{
					goto IL_0312;
				}
			}
			goto IL_040b;
			IL_0482:
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			return (byte)(int)ex3 != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0111;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0111;
			IL_0111:
			object obj8 = obj3 + 40;
			obj8 = <>3__enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = <>3__startIndex;
			_ = <>3__count;
			return (IEnumerator<T>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @449F328");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	private sealed class <GetIEnumerable>d__8<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private T <>2__current;

		private int <>l__initialThreadId;

		private T[] array;

		public T[] <>3__array;

		private int maxIterations;

		public int <>3__maxIterations;

		private int <i>5__2;

		private int <j>5__3;

		T IEnumerator<T>.Current
		{
			get
			{
				//IL_0010: Expected O, but got I
				//IL_0020: Expected O, but got I
				//IL_0030: Expected O, but got I
				//IL_004e: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X2+20]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1+C0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2+10]");
				object obj3 = 0;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v3+80]");
				object obj5 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB1828");
				T result = default(T);
				return result;
			}
		}

		unsafe object IEnumerator.Current
		{
			get
			{
				//IL_0008: Expected O, but got Ref
				//IL_0018: Expected O, but got I
				//IL_0033: Expected O, but got I
				//IL_0049: Expected O, but got I
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Expected O, but got Unknown
				//IL_0068: Expected O, but got Ref
				//IL_0086: Expected O, but got I
				//IL_00bf: Expected O, but got I
				object obj2 = default(object);
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj3 = 0;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>)+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X9_v1+FC]");
				object obj5 = (nint)0 + (nint)15;
				object obj6 = obj5 & 0x1FFFFFFF0L;
				object obj8 = default(object);
				object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
				IntPtr intPtr = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj9 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				object result = default(object);
				if (obj10 == null)
				{
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
				object result2 = default(object);
				return result2;
			}
		}

		public <GetIEnumerable>d__8(int <>1__state)
		{
			//IL_0024: Expected O, but got I
			//IL_0045: Expected O, but got I4
			//IL_007b: Expected O, but got I
			//IL_0091: Expected O, but got I
			//IL_00b6: Expected O, but got I
			//IL_00c8: Expected O, but got I4
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v3 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj2 = <>1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			nint num2 = 0;
			IntPtr intPtr2 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj4 = (nint)0 + (nint)64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj5 = (nint)0 + (nint)64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj6 = currentManagedThreadId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0018: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0068: Expected O, but got Ref
			//IL_0080: Expected O, but got I
			//IL_01cd: Expected O, but got I
			//IL_01f3: Expected O, but got I8
			//IL_0221: Expected O, but got I
			//IL_00c1: Expected O, but got I4
			//IL_0254: Expected O, but got I
			//IL_0728: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_06a3: Expected I4, but got O
			//IL_0299: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_0113: Expected O, but got I8
			//IL_013b: Expected O, but got I
			//IL_0151: Expected O, but got I
			//IL_036d: Expected O, but got I
			//IL_0395: Expected O, but got I
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			//IL_03b9: Expected O, but got I
			//IL_0176: Expected O, but got I
			//IL_0189: Expected O, but got I4
			//IL_03de: Expected O, but got I
			//IL_02df: Expected O, but got I
			//IL_02f5: Expected O, but got I
			//IL_0315: Expected O, but got I
			//IL_01a1: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			//IL_0423: Expected O, but got I
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_043b: Expected O, but got Unknown
			//IL_0444: Expected O, but got I4
			//IL_0331: Expected O, but got I8
			//IL_0344: Expected O, but got I4
			//IL_06c1: Expected O, but got I
			//IL_06d7: Expected O, but got I
			//IL_06f7: Expected O, but got I
			//IL_046d: Expected O, but got I
			//IL_049b: Expected O, but got I
			//IL_04c4: Expected O, but got I4
			//IL_04f6: Expected O, but got I
			//IL_052c: Expected O, but got I
			//IL_0579: Expected O, but got I4
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Expected O, but got Unknown
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Expected O, but got Unknown
			//IL_05ed: Expected O, but got I
			//IL_061a: Expected O, but got I
			//IL_063c: Expected O, but got I4
			//IL_064f: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>)+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X9_v1+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj8 = default(object);
			object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj10 = default(object);
			object obj19;
			if ((nint)obj10 != 1)
			{
				bool flag = obj10 == null;
				object obj11 = !flag;
				if (obj11 != null)
				{
					goto IL_0665;
				}
				nint num2 = 0;
				IntPtr intPtr2 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v76 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj13 = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num3 = 0;
				IntPtr intPtr3 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v80 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v80 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj15 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v80 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj16 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				object obj18 = 0;
				obj19 = 0;
			}
			else
			{
				nint num4 = 0;
				IntPtr intPtr4 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v46 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj21 = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num5 = 0;
				IntPtr intPtr5 = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v50 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj22 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				nint num6 = 0;
				IntPtr intPtr6 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v54 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj23 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj25 = default(object);
				object obj24 = obj25;
				if (obj25 == null)
				{
					goto IL_0687;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v56+18]");
				object obj26 = -1;
				object obj27 = default(object);
				bool flag2 = obj27 != obj26;
				object obj28 = 0;
				if (!flag2)
				{
					nint num7 = 0;
					IntPtr intPtr7 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v72 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v72 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
					object obj30 = (nint)0 + (nint)256;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v72 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
					object obj31 = (nint)0 + (nint)256;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
					object obj32 = 4294967295L;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
					obj28 = 0;
				}
				nint num8 = 0;
				IntPtr intPtr8 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v62 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj33 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				nint num9 = 0;
				IntPtr intPtr9 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj34 = 0;
				object obj36 = default(object);
				object obj35 = obj36 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj37 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj38 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj39 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num10 = 0;
				IntPtr intPtr10 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v67 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj40 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj41 = default(object);
				obj19 = obj41 + 1;
				object obj18 = 0;
			}
			nint num11 = 0;
			IntPtr intPtr11 = num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj43 = (nint)0 + (nint)256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj44 = (nint)0 + (nint)256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj45 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num12 = 0;
			IntPtr intPtr12 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj46 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			nint num13 = 0;
			IntPtr intPtr13 = num13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v20 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			obj9 = (nint)0 + (nint)160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj47 = default(object);
			object obj48 = default(object);
			bool flag3 = obj47 >= obj48;
			object obj49 = 0;
			if (flag3)
			{
				goto IL_0665;
			}
			nint num14 = 0;
			IntPtr intPtr14 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v25 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj50 = (nint)0 + (nint)96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj52 = default(object);
			object obj51 = obj52;
			nint num15 = 0;
			IntPtr intPtr15 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v29 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj53 = (nint)0 + (nint)256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			if (obj52 == null)
			{
				goto IL_0687;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X23_v5+18]");
			object obj54 = default(object);
			bool flag4 = (nint)obj54 < 0;
			object obj55 = !flag4;
			if (obj55 != null)
			{
				goto IL_0695;
			}
			object obj56 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X9_v9+104]");
			object obj57 = 0 * obj54;
			object obj58 = obj52 + obj57;
			object obj59 = obj58 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			nint num16 = 0;
			IntPtr intPtr16 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v35 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj60 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17E0");
			nint num17 = 0;
			IntPtr intPtr17 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v39 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj62 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			obj49 = 0;
			bool result = true;
			obj9 = obj62;
			goto IL_0718;
			IL_0665:
			result = false;
			goto IL_0718;
			IL_0718:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			if (obj63 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			goto IL_0687;
			IL_0687:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0695;
			IL_0695:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//IL_001e: Expected O, but got I
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0050: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_015a: Expected O, but got I4
			//IL_0197: Expected O, but got I
			//IL_0082: Expected O, but got I
			//IL_0302: Expected O, but got I
			//IL_01cc: Expected O, but got I
			//IL_01e2: Expected O, but got I
			//IL_0202: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0247: Expected O, but got I
			//IL_00f9: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_0274: Expected O, but got I
			//IL_028a: Expected O, but got I
			//IL_02aa: Expected O, but got I
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v3 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj3 = default(object);
			object obj2 = obj3 + 2;
			bool flag = obj2 == null;
			object obj4 = !flag;
			IEnumerator<T> enumerator;
			object obj8;
			if (obj4 == null)
			{
				nint num2 = 0;
				IntPtr intPtr2 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v31 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				obj = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				object obj5 = default(object);
				if ((nint)obj5 == currentManagedThreadId)
				{
					nint num3 = 0;
					IntPtr intPtr3 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v35 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
					obj8 = 0;
					enumerator = this;
					goto IL_02de;
				}
			}
			nint num4 = 0;
			IntPtr intPtr4 = num4;
			object obj9 = num4 + 309;
			object obj10 = obj9 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v27 (Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>)+18]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X2_v1] (should have been resolved before IL gen)");
			IEnumerator<T> enumerator2 = default(IEnumerator<T>);
			enumerator = enumerator2;
			goto IL_02de;
			IL_02de:
			nint num6 = 0;
			IntPtr intPtr5 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
			object obj12 = (nint)0 + (nint)128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			if (enumerator != null)
			{
				nint num7 = 0;
				IntPtr intPtr6 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj14 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj15 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj17 = default(object);
				object obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num8 = 0;
				IntPtr intPtr7 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v15 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj18 = (nint)0 + (nint)192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				nint num9 = 0;
				IntPtr intPtr8 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj20 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>>)+80]");
				object obj21 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj23 = default(object);
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				return enumerator;
			}
			return (IEnumerator<T>)new NullReferenceException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_0016: Expected O, but got I
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v2 (Il2CppRgctx<ArraysExtensions+<GetIEnumerable>d__8`1>)+28]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <PingPong>d__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private T <>2__current;

		private int <>l__initialThreadId;

		private T[] array;

		public T[] <>3__array;

		private int maxIterations;

		public int <>3__maxIterations;

		private int <i>5__2;

		private int <direction>5__3;

		private int <iteration>5__4;

		T IEnumerator<T>.Current
		{
			get
			{
				//IL_0010: Expected O, but got I
				//IL_0020: Expected O, but got I
				//IL_0030: Expected O, but got I
				//IL_004e: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X2+20]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1+C0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v2+10]");
				object obj3 = 0;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v3+80]");
				object obj5 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB1828");
				T result = default(T);
				return result;
			}
		}

		unsafe object IEnumerator.Current
		{
			get
			{
				//IL_0008: Expected O, but got Ref
				//IL_0018: Expected O, but got I
				//IL_0033: Expected O, but got I
				//IL_0049: Expected O, but got I
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Expected O, but got Unknown
				//IL_0068: Expected O, but got Ref
				//IL_0086: Expected O, but got I
				//IL_00bf: Expected O, but got I
				object obj2 = default(object);
				object obj = (object)(&obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj3 = 0;
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>)+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X9_v1+FC]");
				object obj5 = (nint)0 + (nint)15;
				object obj6 = obj5 & 0x1FFFFFFF0L;
				object obj8 = default(object);
				object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
				IntPtr intPtr = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj9 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				object result = default(object);
				if (obj10 == null)
				{
					return result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
				object result2 = default(object);
				return result2;
			}
		}

		public <PingPong>d__7(int <>1__state)
		{
			//IL_0024: Expected O, but got I
			//IL_0045: Expected O, but got I4
			//IL_007b: Expected O, but got I
			//IL_0091: Expected O, but got I
			//IL_00b6: Expected O, but got I
			//IL_00c8: Expected O, but got I4
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v3 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj2 = <>1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			nint num2 = 0;
			IntPtr intPtr2 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj4 = (nint)0 + (nint)64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj5 = (nint)0 + (nint)64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj6 = currentManagedThreadId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0018: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0068: Expected O, but got Ref
			//IL_0080: Expected O, but got I
			//IL_0243: Expected O, but got I
			//IL_0269: Expected O, but got I8
			//IL_0297: Expected O, but got I
			//IL_00c1: Expected O, but got I4
			//IL_02ca: Expected O, but got I
			//IL_02f2: Expected O, but got I
			//IL_0315: Expected O, but got I
			//IL_033a: Expected O, but got I
			//IL_0851: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_037f: Expected O, but got I
			//IL_03ad: Expected O, but got I
			//IL_0113: Expected O, but got I8
			//IL_013b: Expected O, but got I
			//IL_0151: Expected O, but got I
			//IL_0176: Expected O, but got I
			//IL_0189: Expected O, but got I4
			//IL_07cc: Expected I4, but got O
			//IL_01b6: Expected O, but got I
			//IL_01cc: Expected O, but got I
			//IL_01ec: Expected O, but got I
			//IL_03f7: Expected O, but got I
			//IL_0204: Expected O, but got I4
			//IL_0217: Expected O, but got I4
			//IL_0220: Expected O, but got I4
			//IL_0496: Expected O, but got I
			//IL_04be: Expected O, but got I
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Expected O, but got Unknown
			//IL_04e2: Expected O, but got I
			//IL_07ea: Expected O, but got I
			//IL_0800: Expected O, but got I
			//IL_0820: Expected O, but got I
			//IL_0507: Expected O, but got I
			//IL_052c: Expected O, but got I4
			//IL_0437: Expected O, but got I
			//IL_045b: Expected O, but got I4
			//IL_0464: Expected O, but got I4
			//IL_0596: Expected O, but got I
			//IL_05c4: Expected O, but got I
			//IL_0555: Expected O, but got I
			//IL_0568: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Expected O, but got Unknown
			//IL_05ed: Expected O, but got I4
			//IL_061f: Expected O, but got I
			//IL_0655: Expected O, but got I
			//IL_06a2: Expected O, but got I4
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Expected O, but got Unknown
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e8: Expected O, but got Unknown
			//IL_0716: Expected O, but got I
			//IL_0743: Expected O, but got I
			//IL_0765: Expected O, but got I4
			//IL_0778: Expected O, but got I4
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X8_v5 (Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>)+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X9_v1+FC]");
			object obj5 = (nint)0 + (nint)15;
			object obj6 = obj5 & 0x1FFFFFFF0L;
			object obj8 = default(object);
			object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj10 = default(object);
			object obj23;
			if ((nint)obj10 != 1)
			{
				bool flag = obj10 == null;
				object obj11 = !flag;
				if (obj11 != null)
				{
					goto IL_078e;
				}
				nint num2 = 0;
				IntPtr intPtr2 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v87 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj13 = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num3 = 0;
				IntPtr intPtr3 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v91 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v91 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj15 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v91 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj16 = (nint)0 + (nint)224;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num4 = 0;
				IntPtr intPtr4 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v94 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v94 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj19 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v94 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj20 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj21 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				object obj22 = 0;
				obj23 = 0;
				goto IL_07cc;
			}
			nint num5 = 0;
			IntPtr intPtr5 = num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v46 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj25 = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num6 = 0;
			IntPtr intPtr6 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v50 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj26 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			nint num7 = 0;
			IntPtr intPtr7 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v54 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj27 = (nint)0 + (nint)256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			nint num8 = 0;
			IntPtr intPtr8 = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj28 = 0;
			object obj30 = default(object);
			object obj31 = default(object);
			object obj29 = obj30 + obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj32 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X9_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj33 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj34 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num9 = 0;
			IntPtr intPtr9 = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v59 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj35 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			nint num10 = 0;
			IntPtr intPtr10 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v63 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj36 = (nint)0 + (nint)96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj38 = default(object);
			object obj37 = obj38;
			if (obj38 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v65+18]");
				object obj39 = -1;
				object obj40 = default(object);
				object obj22;
				if (obj40 != obj39)
				{
					nint num11 = 0;
					IntPtr intPtr11 = num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v82 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
					object obj41 = (nint)0 + (nint)224;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
					object obj42 = default(object);
					bool flag2 = obj42 == null;
					object obj43 = !flag2;
					obj22 = 0;
					if (obj43 != null)
					{
						goto IL_0531;
					}
				}
				nint num12 = 0;
				IntPtr intPtr12 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v77 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj44 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				nint num13 = 0;
				IntPtr intPtr13 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v20 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj45 = 0;
				object obj47 = default(object);
				object obj46 = 0 - obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v20 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj48 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X9_v20 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj49 = (nint)0 + (nint)256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj50 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				obj22 = 0;
				goto IL_0531;
			}
			goto IL_07b0;
			IL_07cc:
			nint num14 = 0;
			IntPtr intPtr14 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj52 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v13 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj53 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj54 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num15 = 0;
			IntPtr intPtr15 = num15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v16 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj55 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			nint num16 = 0;
			IntPtr intPtr16 = num16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v20 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			obj9 = (nint)0 + (nint)160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj56 = default(object);
			object obj57 = default(object);
			bool flag3 = obj56 >= obj57;
			object obj58 = 0;
			if (flag3)
			{
				goto IL_078e;
			}
			nint num17 = 0;
			IntPtr intPtr17 = num17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v25 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj59 = (nint)0 + (nint)96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj61 = default(object);
			object obj60 = obj61;
			nint num18 = 0;
			IntPtr intPtr18 = num18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v29 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj62 = (nint)0 + (nint)224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			if (obj61 == null)
			{
				goto IL_07b0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X23_v5+18]");
			object obj63 = default(object);
			bool flag4 = (nint)obj63 < 0;
			object obj64 = !flag4;
			if (obj64 != null)
			{
				goto IL_07be;
			}
			object obj65 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X9_v9+104]");
			object obj66 = 0 * obj63;
			object obj67 = obj61 + obj66;
			object obj68 = obj67 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			nint num19 = 0;
			IntPtr intPtr19 = num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v35 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj69 = (nint)0 + (nint)32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17E0");
			nint num20 = 0;
			IntPtr intPtr20 = num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v39 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj71 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			obj58 = 0;
			bool result = true;
			obj9 = obj71;
			goto IL_0841;
			IL_0841:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			if (obj72 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			goto IL_07b0;
			IL_07b0:
			NullReferenceException ex = new NullReferenceException();
			goto IL_07be;
			IL_07be:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
			IL_0531:
			nint num21 = 0;
			IntPtr intPtr21 = num21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v71 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj73 = (nint)0 + (nint)288;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj74 = default(object);
			obj23 = obj74 + 1;
			goto IL_07cc;
			IL_078e:
			result = false;
			goto IL_0841;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//IL_001e: Expected O, but got I
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0050: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected O, but got Unknown
			//IL_015a: Expected O, but got I4
			//IL_0197: Expected O, but got I
			//IL_0082: Expected O, but got I
			//IL_0302: Expected O, but got I
			//IL_01cc: Expected O, but got I
			//IL_01e2: Expected O, but got I
			//IL_0202: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0247: Expected O, but got I
			//IL_00f9: Expected O, but got I4
			//IL_010c: Expected O, but got I4
			//IL_0274: Expected O, but got I
			//IL_028a: Expected O, but got I
			//IL_02aa: Expected O, but got I
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v3 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj3 = default(object);
			object obj2 = obj3 + 2;
			bool flag = obj2 == null;
			object obj4 = !flag;
			IEnumerator<T> enumerator;
			object obj8;
			if (obj4 == null)
			{
				nint num2 = 0;
				IntPtr intPtr2 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v31 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				obj = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				object obj5 = default(object);
				if ((nint)obj5 == currentManagedThreadId)
				{
					nint num3 = 0;
					IntPtr intPtr3 = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v35 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
					obj8 = 0;
					enumerator = this;
					goto IL_02de;
				}
			}
			nint num4 = 0;
			IntPtr intPtr4 = num4;
			object obj9 = num4 + 309;
			object obj10 = obj9 & 1;
			bool flag2 = obj10 == null;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v27 (Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>)+18]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X2_v1] (should have been resolved before IL gen)");
			IEnumerator<T> enumerator2 = default(IEnumerator<T>);
			enumerator = enumerator2;
			goto IL_02de;
			IL_02de:
			nint num6 = 0;
			IntPtr intPtr5 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
			object obj12 = (nint)0 + (nint)128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			if (enumerator != null)
			{
				nint num7 = 0;
				IntPtr intPtr6 = num7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj14 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj15 = (nint)0 + (nint)96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj17 = default(object);
				object obj16 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				nint num8 = 0;
				IntPtr intPtr7 = num8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v15 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj18 = (nint)0 + (nint)192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				nint num9 = 0;
				IntPtr intPtr8 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj20 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v19 (Il2CppClass<Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>>)+80]");
				object obj21 = (nint)0 + (nint)160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				object obj23 = default(object);
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
				return enumerator;
			}
			return (IEnumerator<T>)new NullReferenceException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_0016: Expected O, but got I
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v2 (Il2CppRgctx<ArraysExtensions+<PingPong>d__7`1>)+28]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <Rotate>d__5<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private T <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<T> enumerable;

		public IEnumerable<T> <>3__enumerable;

		private int offset;

		public int <>3__offset;

		private List<T> <list>5__2;

		private int <count>5__3;

		private int <i>5__4;

		T IEnumerator<T>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Rotate>d__5(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01b0: Expected I4, but got I8
			//IL_003b: Expected O, but got I4
			//IL_029f: Expected I4, but got O
			//IL_0058: Expected I4, but got I8
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0223: Expected O, but got I4
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected I4, but got Unknown
			//IL_023d: Expected O, but got I4
			//IL_024a: Expected I4, but got O
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_00eb: Expected O, but got I
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Expected O, but got Unknown
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected I4, but got Unknown
			//IL_0139: Expected O, but got I
			//IL_0146: Expected I4, but got O
			int num;
			int num6;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj == null)
				{
					<>1__state = -1;
					List<object> list = Enumerable.ToList((IEnumerable<object>)enumerable);
					object obj2 = this + 64;
					obj2 = list;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj3 = obj2;
					if (obj2 == null)
					{
						goto IL_0291;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					num = 0;
					int num2 = offset;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					int num3 = (int)((nint)num2 / (nint)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					object obj4 = (nint)num3 * (nint)0;
					object obj5 = offset - obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					object obj6 = obj5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					int num4 = obj6 / 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					object obj7 = (nint)num4 * (nint)0;
					int num5 = obj6 - obj7;
					offset = num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					<count>5__3 = 0;
					<i>5__4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v11+18]");
					bool flag2 = (nint)0 < (nint)0;
					num6 = 0;
					if (flag2)
					{
						goto IL_01f5;
					}
				}
			}
			else
			{
				<>1__state = -1;
				num = <count>5__3;
				num6 = ++<i>5__4;
				if (num6 < <count>5__3)
				{
					goto IL_01f5;
				}
			}
			return false;
			IL_01f5:
			if (<list>5__2 != null)
			{
				object obj8 = offset + num6;
				int num7 = obj8 / num;
				object obj9 = num7 * num;
				int index = obj8 - obj9;
				nint num8 = 0;
				object obj10 = ((List<object>)(object)<list>5__2).get_Item(index);
				object obj11 = this + 24;
				obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return true;
			}
			goto IL_0291;
			IL_0291:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0111;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0111;
			IL_0111:
			object obj8 = obj3 + 40;
			obj8 = <>3__enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = <>3__offset;
			return (IEnumerator<T>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B6A10");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	private sealed class <RunningGroupBy>d__27<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable, IEnumerator<IGrouping<TKey, TElement>>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private IGrouping<TKey, TElement> <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<TElement> source;

		public IEnumerable<TElement> <>3__source;

		private Func<TElement, TKey> keySelector;

		public Func<TElement, TKey> <>3__keySelector;

		private IEnumerator<TElement> <enumerator>5__2;

		private TKey <newKey>5__3;

		IGrouping<TKey, TElement> IEnumerator<IGrouping<TKey, TElement>>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RunningGroupBy>d__27(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			<>l__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0055: Expected O, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_01b6: Expected I4, but got I8
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d3: Expected I, but got O
			//IL_00e3: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			object obj = <>1__state + 3;
			bool flag = (nint)obj < 5;
			object obj2 = !flag;
			object obj3 = obj - 5;
			bool flag2 = obj3 == null;
			object obj4 = 1 << (int)obj;
			object obj5 = obj4 & 0x31;
			object obj6 = ~obj2;
			object obj7 = obj6 | flag2;
			object obj8 = ~obj7;
			bool flag3 = obj8 != null || obj5 == null;
			while (!flag3)
			{
				<>1__state = -1;
				IEnumerator<TElement> enumerator = <enumerator>5__2;
				if (<enumerator>5__2 == null)
				{
					break;
				}
				object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+B0]");
					object obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj9)
						{
							break;
						}
						obj11 += 16;
						obj10--;
						if ((nint)obj10 != 1)
						{
							continue;
						}
						goto IL_015f;
					}
					object obj12 = num + obj11;
					object obj13 = obj12 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v186 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_015f;
				IL_015f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v173 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_1819: Expected O, but got I4
			//IL_1829: Expected O, but got I4
			//IL_0483: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0035: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_1bc0: Expected I4, but got I8
			//IL_0223: Expected I4, but got I8
			//IL_0243: Expected O, but got I
			//IL_0259: Expected O, but got I
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Expected O, but got Unknown
			//IL_0281: Expected O, but got I4
			//IL_02b8: Expected O, but got I
			//IL_02c8: Expected O, but got I
			//IL_02d8: Expected O, but got I
			//IL_0085: Expected O, but got I4
			//IL_1713: Expected O, but got Ref
			//IL_0983: Unknown result type (might be due to invalid IL or missing references)
			//IL_0988: Expected O, but got Unknown
			//IL_0990: Expected I, but got O
			//IL_09a0: Expected O, but got I
			//IL_1734: Unknown result type (might be due to invalid IL or missing references)
			//IL_1739: Expected O, but got Unknown
			//IL_0a73: Expected O, but got I4
			//IL_0f70: Expected I4, but got O
			//IL_00af: Expected I4, but got I8
			//IL_09db: Expected O, but got I
			//IL_0326: Expected O, but got I
			//IL_0336: Expected O, but got I
			//IL_0346: Expected O, but got I
			//IL_035c: Expected O, but got I
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_036a: Expected O, but got Unknown
			//IL_0384: Expected O, but got I4
			//IL_0f4b: Expected I4, but got I8
			//IL_1c10: Expected O, but got I4
			//IL_1c20: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c25: Expected O, but got Unknown
			//IL_1969: Expected I, but got O
			//IL_00ee: Expected O, but got I
			//IL_0104: Expected O, but got I
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Expected O, but got Unknown
			//IL_012c: Expected O, but got I4
			//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Expected O, but got Unknown
			//IL_0a8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a93: Expected O, but got Unknown
			//IL_046f: Expected O, but got I4
			//IL_1863: Expected I, but got O
			//IL_1873: Expected O, but got I
			//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ee: Expected O, but got Unknown
			//IL_09f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09fc: Expected O, but got Unknown
			//IL_0a16: Expected O, but got I4
			//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a24: Expected O, but got Unknown
			//IL_1031: Expected O, but got I
			//IL_1041: Expected O, but got I
			//IL_1051: Expected O, but got I
			//IL_1067: Expected O, but got I
			//IL_1070: Unknown result type (might be due to invalid IL or missing references)
			//IL_1075: Expected O, but got Unknown
			//IL_108f: Expected O, but got I4
			//IL_1a06: Expected I4, but got O
			//IL_03bf: Expected O, but got I
			//IL_020f: Expected O, but got I4
			//IL_1d70: Expected I, but got O
			//IL_19c0: Expected O, but got I4
			//IL_19d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19d5: Expected O, but got Unknown
			//IL_190b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1910: Expected O, but got Unknown
			//IL_193c: Expected O, but got I
			//IL_0167: Expected O, but got I
			//IL_117a: Expected O, but got I4
			//IL_0615: Expected O, but got I
			//IL_0625: Expected O, but got I
			//IL_064b: Expected O, but got I
			//IL_05d5: Expected I4, but got O
			//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e2: Expected O, but got Unknown
			//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f0: Expected O, but got Unknown
			//IL_0f93: Expected I4, but got I8
			//IL_0f9b: Expected I4, but got O
			//IL_18ba: Expected O, but got I4
			//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cf: Expected O, but got Unknown
			//IL_1e0d: Expected I4, but got O
			//IL_10ca: Expected O, but got I
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Expected O, but got Unknown
			//IL_040a: Expected O, but got I4
			//IL_0418: Expected O, but got I4
			//IL_04cd: Expected I, but got O
			//IL_049d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a2: Expected O, but got Unknown
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b0: Expected O, but got Unknown
			//IL_1dc7: Expected O, but got I4
			//IL_1dd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ddc: Expected O, but got Unknown
			//IL_06b3: Expected O, but got I4
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Expected O, but got Unknown
			//IL_05c8: Expected O, but got I4
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01aa: Expected O, but got I4
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_11de: Expected O, but got I
			//IL_11ee: Expected O, but got I
			//IL_1208: Expected O, but got I
			//IL_1218: Expected O, but got I
			//IL_1187: Expected I4, but got O
			//IL_118f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1194: Expected O, but got Unknown
			//IL_119d: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a2: Expected O, but got Unknown
			//IL_0763: Expected O, but got I
			//IL_0773: Expected O, but got I
			//IL_0783: Expected O, but got I
			//IL_1a95: Expected I4, but got O
			//IL_1ab8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1abd: Expected O, but got Unknown
			//IL_0518: Expected O, but got I
			//IL_1234: Expected O, but got I
			//IL_1265: Expected O, but got I4
			//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e5: Expected O, but got Unknown
			//IL_1115: Expected O, but got I4
			//IL_1123: Expected O, but got I4
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0702: Expected O, but got Unknown
			//IL_0721: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Expected O, but got Unknown
			//IL_072f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0734: Expected O, but got Unknown
			//IL_1a4f: Expected O, but got I4
			//IL_1a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a64: Expected O, but got Unknown
			//IL_1d46: Expected I, but got O
			//IL_07a5: Expected I4, but got O
			//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b2: Expected O, but got Unknown
			//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c0: Expected O, but got Unknown
			//IL_1785: Expected I4, but got O
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Expected O, but got Unknown
			//IL_0563: Expected O, but got I4
			//IL_0571: Expected O, but got I4
			//IL_17cd: Expected O, but got I4
			//IL_158f: Expected O, but got I
			//IL_0821: Expected O, but got I
			//IL_0831: Expected O, but got I
			//IL_0841: Expected O, but got I
			//IL_0857: Expected O, but got I
			//IL_0860: Unknown result type (might be due to invalid IL or missing references)
			//IL_0865: Expected O, but got Unknown
			//IL_087f: Expected O, but got I4
			//IL_12c2: Expected O, but got I
			//IL_12d2: Expected O, but got I
			//IL_12e2: Expected O, but got I
			//IL_12f8: Expected O, but got I
			//IL_1301: Unknown result type (might be due to invalid IL or missing references)
			//IL_1306: Expected O, but got Unknown
			//IL_1320: Expected O, but got I4
			//IL_168a: Expected O, but got I4
			//IL_1aea: Expected I, but got O
			//IL_1e41: Expected I, but got O
			//IL_1e51: Expected O, but got I
			//IL_1fec: Expected O, but got I4
			//IL_15da: Expected O, but got I
			//IL_096a: Expected O, but got I4
			//IL_1403: Expected O, but got I4
			//IL_1f7c: Expected O, but got I4
			//IL_1f8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f91: Expected O, but got Unknown
			//IL_1b87: Expected I4, but got O
			//IL_08ba: Expected O, but got I
			//IL_1ef0: Expected O, but got I
			//IL_1f00: Expected O, but got I
			//IL_1f26: Expected O, but got I
			//IL_135b: Expected O, but got I
			//IL_16d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d5: Expected O, but got Unknown
			//IL_1706: Expected I, but got O
			//IL_16a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_16aa: Expected O, but got Unknown
			//IL_16ba: Expected I4, but got O
			//IL_1b41: Expected O, but got I4
			//IL_1b51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b56: Expected O, but got Unknown
			//IL_1e98: Expected O, but got I4
			//IL_1ea8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ead: Expected O, but got Unknown
			//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f5: Expected O, but got Unknown
			//IL_1625: Expected O, but got I4
			//IL_1633: Expected O, but got I4
			//IL_0aef: Expected O, but got I
			//IL_0aff: Expected O, but got I
			//IL_0b0f: Expected O, but got I
			//IL_0b25: Expected O, but got I
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b33: Expected O, but got Unknown
			//IL_0b4d: Expected O, but got I4
			//IL_0aa5: Expected I4, but got O
			//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab2: Expected O, but got Unknown
			//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac0: Expected O, but got Unknown
			//IL_1474: Expected O, but got I4
			//IL_1489: Unknown result type (might be due to invalid IL or missing references)
			//IL_148e: Expected O, but got Unknown
			//IL_1410: Unknown result type (might be due to invalid IL or missing references)
			//IL_1415: Expected O, but got Unknown
			//IL_141e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1423: Expected O, but got Unknown
			//IL_142c: Expected O, but got I4
			//IL_0b84: Expected O, but got I
			//IL_0b94: Expected O, but got I
			//IL_0ba4: Expected O, but got I
			//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d5: Expected O, but got Unknown
			//IL_0905: Expected O, but got I4
			//IL_0913: Expected O, but got I4
			//IL_1531: Expected O, but got I
			//IL_1541: Expected O, but got I
			//IL_1551: Expected O, but got I
			//IL_1371: Unknown result type (might be due to invalid IL or missing references)
			//IL_1376: Expected O, but got Unknown
			//IL_137f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1384: Expected O, but got Unknown
			//IL_139e: Expected O, but got I4
			//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ac: Expected O, but got Unknown
			//IL_14be: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c3: Expected O, but got Unknown
			//IL_14e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14e7: Expected O, but got Unknown
			//IL_14f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_14f5: Expected O, but got Unknown
			//IL_0ff9: Expected I4, but got O
			//IL_0bf2: Expected O, but got I
			//IL_0c02: Expected O, but got I
			//IL_0c12: Expected O, but got I
			//IL_0c28: Expected O, but got I
			//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c36: Expected O, but got Unknown
			//IL_0c50: Expected O, but got I4
			//IL_1c75: Expected I, but got O
			//IL_0d3b: Expected O, but got I4
			//IL_1d12: Expected I4, but got O
			//IL_0c8b: Expected O, but got I
			//IL_1ccc: Expected O, but got I4
			//IL_1cdc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce1: Expected O, but got Unknown
			//IL_0d88: Expected O, but got I
			//IL_0d98: Expected O, but got I
			//IL_0dbe: Expected O, but got I
			//IL_0d48: Expected I4, but got O
			//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d55: Expected O, but got Unknown
			//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d63: Expected O, but got Unknown
			//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca6: Expected O, but got Unknown
			//IL_0cd6: Expected O, but got I4
			//IL_0ce4: Expected O, but got I4
			//IL_0e25: Expected O, but got I4
			//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3f: Expected O, but got Unknown
			//IL_0edd: Expected O, but got I
			//IL_0eed: Expected O, but got I
			//IL_0efd: Expected O, but got I
			//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e74: Expected O, but got Unknown
			//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e98: Expected O, but got Unknown
			//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea6: Expected O, but got Unknown
			bool flag = <>1__state < 2;
			object obj = !flag;
			object obj2 = <>1__state - 2;
			object obj3;
			IntPtr intPtr = default(IntPtr);
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__;
			NullReferenceException ex;
			TKey val;
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__2 = default(<RunningGroupBy>d__27<TKey, TElement>);
			object obj28 = default(object);
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__3 = default(<RunningGroupBy>d__27<TKey, TElement>);
			nint num;
			bool flag6 = default(bool);
			object obj19;
			bool flag9;
			IGrouping<TKey, TElement> grouping2;
			int num7;
			int num4;
			if (<>1__state != 2)
			{
				obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				bool flag2 = <>1__state < 1;
				obj = !flag2;
				obj2 = <>1__state - 1;
				if (<>1__state != 1)
				{
					bool flag3 = <>1__state == 0;
					object obj4 = !flag3;
					num = intPtr;
					<RunningGroupBy>d__ = this;
					if (obj4 != null)
					{
						goto IL_184d;
					}
					<>1__state = -1;
					IEnumerable<TElement> enumerable = source;
					if (source != null)
					{
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v100 (Il2CppRgctx<ArraysExtensions+<RunningGroupBy>d__27`2>)+10]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v100 (Il2CppRgctx<ArraysExtensions+<RunningGroupBy>d__27`2>)+10]");
						object obj6 = (nint)0 + (nint)309;
						object obj7 = obj6 & 1;
						bool flag4 = obj7 == null;
						object obj8 = !flag4;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj9 = default(object);
							obj5 = obj9;
						}
						nint num3 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v103 (Il2CppClass<System.Collections.Generic.IEnumerable`1<TElement>>)+12E]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v103 (Il2CppClass<System.Collections.Generic.IEnumerable`1<TElement>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01fc;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v103 (Il2CppClass<System.Collections.Generic.IEnumerable`1<TElement>>)+B0]");
						IGrouping<TKey, TElement> grouping = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
						bool flag5 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v65 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							bool flag7 = 0 < (nint)obj5;
							obj = !flag7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v65 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							obj2 = 0 - obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v65 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							if (0 == (nint)obj5)
							{
								break;
							}
							grouping2 = (IGrouping<TKey, TElement>)(grouping + 16);
							obj10--;
							bool flag8 = (nint)obj10 < 1;
							obj = !flag8;
							obj2 = obj10 - 1;
							flag9 = obj2 == null;
							flag6 = (nint)obj10 != 1;
							flag5 = flag6;
							grouping = grouping2;
							if (flag6)
							{
								continue;
							}
							goto IL_01fc;
						}
						object obj11 = num3 + grouping;
						object obj12 = obj11 + 312;
						flag6 = flag5;
						grouping2 = grouping;
						goto IL_18f8;
					}
					ex = new NullReferenceException();
					num4 = -1;
					val = (TKey)source;
					<RunningGroupBy>d__ = this;
				}
				else
				{
					<>1__state = -3;
					val = <newKey>5__3;
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v74 (Il2CppRgctx<ArraysExtensions+<RunningGroupBy>d__27`2>)+50]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v74 (Il2CppRgctx<ArraysExtensions+<RunningGroupBy>d__27`2>)+50]");
					object obj14 = (nint)0 + (nint)309;
					object obj15 = obj14 & 1;
					bool flag10 = obj15 == null;
					object obj16 = !flag10;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v78+C0]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v79+58]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B59C50");
					IEnumerator<TElement> enumerator = <RunningGroupBy>d__2.<enumerator>5__2;
					if (<RunningGroupBy>d__2.<enumerator>5__2 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
						object obj20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v82+C0]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v83+20]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v83+20]");
						object obj23 = (nint)0 + (nint)309;
						object obj24 = obj23 & 1;
						bool flag11 = obj24 == null;
						object obj25 = !flag11;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj26 = default(object);
							obj22 = obj26;
						}
						nint num6 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v86 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
						num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v86 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_045c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v86 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+B0]");
						IGrouping<TKey, TElement> grouping3 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
						bool flag12 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v40 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							bool flag13 = 0 < (nint)obj22;
							obj = !flag13;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v40 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							obj2 = 0 - obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v40 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							if (0 == (nint)obj22)
							{
								break;
							}
							grouping2 = (IGrouping<TKey, TElement>)(grouping3 + 16);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v86 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
							num7 = (int)(-1);
							bool flag14 = num7 < 1;
							obj = !flag14;
							obj2 = num7 - 1;
							flag9 = obj2 == null;
							flag6 = num7 != 1;
							flag12 = flag6;
							grouping3 = grouping2;
							if (flag6)
							{
								continue;
							}
							goto IL_045c;
						}
						num7 = (int)grouping3;
						object obj27 = num6 + grouping3;
						obj28 = obj27 + 312;
						flag6 = flag12;
						grouping2 = grouping3;
						goto IL_19fe;
					}
					ex = new NullReferenceException();
					num4 = (int)<RunningGroupBy>d__2;
					<RunningGroupBy>d__ = <RunningGroupBy>d__3;
				}
				goto IL_200a;
			}
			<>1__state = -3;
			num = intPtr;
			<RunningGroupBy>d__ = this;
			goto IL_1bae;
			IL_1c4e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v16+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v663 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_184d;
			IL_05b5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1a8d;
			IL_1578:
			<RunningGroupBy>d__2.<newKey>5__3 = (TKey)null;
			goto IL_1d39;
			IL_1fba:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1182 @ X0_v63] (should have been resolved before IL gen)");
			int num9 = default(int);
			int num8 = num9 & 1;
			bool flag15 = num8 == 0;
			object obj29 = !flag15;
			ex = (NullReferenceException)(object)<RunningGroupBy>d__2;
			num4 = num9;
			bool result;
			if (obj29 == null)
			{
				object obj30 = <RunningGroupBy>d__2 + 24;
				obj30 = <RunningGroupBy>d__;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<RunningGroupBy>d__2.<>1__state = 2;
				result = true;
				num = (nint)<RunningGroupBy>d__;
				goto IL_0a98;
			}
			goto IL_200a;
			IL_1a8d:
			object obj31 = default(object);
			num4 = (int)obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v103+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v895 @ X0_v103] (should have been resolved before IL gen)");
			object obj33 = default(object);
			object obj32 = obj33 & 1;
			bool flag16 = obj32 == null;
			<RunningGroupBy>d__ = <RunningGroupBy>d__2;
			object obj42 = default(object);
			if (!flag16)
			{
				val = (TKey)<RunningGroupBy>d__2.<enumerator>5__2;
				if (<RunningGroupBy>d__2.<enumerator>5__2 != null)
				{
					<RunningGroupBy>d__ = (<RunningGroupBy>d__27<TKey, TElement>)(object)<RunningGroupBy>d__2.keySelector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v111+C0]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v112+20]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v112+20]");
					object obj37 = (nint)0 + (nint)309;
					object obj38 = obj37 & 1;
					bool flag17 = obj38 == null;
					object obj39 = !flag17;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj40 = default(object);
						obj36 = obj40;
					}
					nint num10 = (nint)val;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v115 (Il2CppClass<TKey>)+12E]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v115 (Il2CppClass<TKey>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0957;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v115 (Il2CppClass<TKey>)+B0]");
					IGrouping<TKey, TElement> grouping4 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
					bool flag18 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ X10_v55 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						bool flag19 = 0 < (nint)obj36;
						obj = !flag19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ X10_v55 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						obj2 = 0 - obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1042 @ X10_v55 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						if (0 == (nint)obj36)
						{
							break;
						}
						grouping2 = (IGrouping<TKey, TElement>)(grouping4 + 16);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v115 (Il2CppClass<TKey>)+12E]");
						num7 = (int)(-1);
						bool flag20 = num7 < 1;
						obj = !flag20;
						obj2 = num7 - 1;
						flag9 = obj2 == null;
						flag6 = num7 != 1;
						flag18 = flag6;
						grouping4 = grouping2;
						if (flag6)
						{
							continue;
						}
						goto IL_0957;
					}
					num7 = (int)grouping4;
					object obj41 = num10 + grouping4;
					obj42 = obj41 + 312;
					flag6 = flag18;
					grouping2 = grouping4;
					goto IL_1b7f;
				}
				ex = new NullReferenceException();
				<RunningGroupBy>d__ = <RunningGroupBy>d__2;
				goto IL_200a;
			}
			goto IL_1bae;
			IL_200a:
			object obj49 = default(object);
			object obj51 = default(object);
			TKey val2 = default(TKey);
			IntPtr intPtr2 = default(IntPtr);
			object objB = default(object);
			OutOfMemoryException ex2;
			object obj62 = default(object);
			nint num12;
			while (true)
			{
				string remoteStackTraceString = ((Exception)ex)._remoteStackTraceString;
				if (((Exception)ex)._remoteStackTraceString != null)
				{
					object stackTrace = ((Exception)ex)._stackTrace;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v26+C0]");
					object obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v27+20]");
					object obj46 = (nint)0 + (nint)309;
					object obj47 = obj46 & 1;
					bool flag21 = obj47 == null;
					object obj48 = !flag21;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						obj45 = obj49;
					}
					nint num11 = (nint)remoteStackTraceString;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v30 (Il2CppClass<System.String>)+12E]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v30 (Il2CppClass<System.String>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1167;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v30 (Il2CppClass<System.String>)+B0]");
					IGrouping<TKey, TElement> grouping5 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
					bool flag22 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v24 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						bool flag23 = 0 < (nint)obj45;
						obj = !flag23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v24 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						obj2 = 0 - obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v824 @ X10_v24 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						if (0 == (nint)obj45)
						{
							break;
						}
						grouping2 = (IGrouping<TKey, TElement>)(grouping5 + 16);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v30 (Il2CppClass<System.String>)+12E]");
						num7 = (int)(-1);
						bool flag24 = num7 < 1;
						obj = !flag24;
						obj2 = num7 - 1;
						flag9 = obj2 == null;
						flag6 = num7 != 1;
						flag22 = flag6;
						grouping5 = grouping2;
						if (flag6)
						{
							continue;
						}
						goto IL_1167;
					}
					num7 = (int)grouping5;
					object obj50 = num11 + grouping5;
					obj51 = obj50 + 312;
					flag6 = flag22;
					grouping2 = grouping5;
					goto IL_1e05;
				}
				ex = new NullReferenceException();
				continue;
				IL_13f0:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj19 = 0;
				goto IL_1ed6;
				IL_1e05:
				num4 = (int)obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v875 @ X0_v28] (should have been resolved before IL gen)");
				if (((Exception)ex)._stackTrace != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ X23_v7 (System.Object)+18] (should have been resolved before IL gen)");
					<RunningGroupBy>d__2.<newKey>5__3 = val2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v36+C0]");
					object obj53 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v41+C0]");
					object obj55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					bool flag25 = object.Equals((nint)intPtr2, objB);
					bool flag26 = !flag25;
					TKey val3 = <RunningGroupBy>d__2.<newKey>5__3;
					TKey val4 = val;
					obj19 = 0;
					ex2 = (OutOfMemoryException)(object)<RunningGroupBy>d__2;
					num12 = intPtr2;
					if (flag26)
					{
						break;
					}
					string remoteStackTraceString2 = ((Exception)(object)<RunningGroupBy>d__2)._remoteStackTraceString;
					if (((Exception)(object)<RunningGroupBy>d__2)._remoteStackTraceString != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1061 @ X8_v45+C0]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v46+20]");
						object obj58 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v46+20]");
						object obj59 = (nint)0 + (nint)309;
						object obj60 = obj59 & 1;
						bool flag27 = obj60 == null;
						object obj61 = !flag27;
						if (obj61 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							obj58 = obj62;
						}
						nint num13 = (nint)remoteStackTraceString2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X8_v49 (Il2CppClass<System.String>)+12E]");
						object obj63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X8_v49 (Il2CppClass<System.String>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_13f0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X8_v49 (Il2CppClass<System.String>)+B0]");
						IGrouping<TKey, TElement> grouping6 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
						bool flag28 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X10_v19 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							bool flag29 = 0 < (nint)obj58;
							obj = !flag29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X10_v19 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							obj2 = 0 - obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X10_v19 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
							if (0 == (nint)obj58)
							{
								break;
							}
							grouping2 = (IGrouping<TKey, TElement>)(grouping6 + 16);
							obj63--;
							bool flag30 = (nint)obj63 < 1;
							obj = !flag30;
							obj2 = obj63 - 1;
							flag9 = obj2 == null;
							flag6 = (nint)obj63 != 1;
							flag28 = flag6;
							grouping6 = grouping2;
							if (flag6)
							{
								continue;
							}
							goto IL_13f0;
						}
						object obj64 = num13 + grouping6;
						object obj65 = obj64 + 312;
						obj19 = 0;
						flag6 = flag28;
						grouping2 = grouping6;
						goto IL_1ed6;
					}
					ex = new NullReferenceException();
					val3 = <RunningGroupBy>d__2.<newKey>5__3;
					val4 = val;
					obj19 = 0;
					num4 = (flag25 ? 1 : 0);
					continue;
				}
				ex = new NullReferenceException();
				continue;
				IL_1167:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj19 = 0;
				goto IL_1e05;
				IL_1ed6:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1223 @ X0_v43] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ X8_v53+C0]");
				object obj67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v54+68]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X20_v3 (ArraysExtensions+<RunningGroupBy>d__27`2<TKey, TElement>)+1C]");
				object obj68 = (nint)0 + (nint)1;
				num7 = <RunningGroupBy>d__.<>1__state;
				if (<RunningGroupBy>d__.<>1__state == 0)
				{
					ex = new NullReferenceException();
					TKey val3 = <RunningGroupBy>d__2.<newKey>5__3;
					TKey val4 = val;
					continue;
				}
				goto IL_1441;
			}
			goto IL_172b;
			IL_1bae:
			<RunningGroupBy>d__.<>1__state = -1;
			IEnumerator<TElement> enumerator2 = <RunningGroupBy>d__.<enumerator>5__2;
			if (<RunningGroupBy>d__.<enumerator>5__2 == null)
			{
				goto IL_184d;
			}
			object obj69 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num14 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a60;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v18 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+B0]");
			IGrouping<TKey, TElement> grouping7 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v10 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
				bool flag31 = 0 < (nint)obj69;
				obj = !flag31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v10 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
				obj2 = 0 - obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X10_v10 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
				if (0 == (nint)obj69)
				{
					break;
				}
				grouping2 = (IGrouping<TKey, TElement>)(grouping7 + 16);
				obj70--;
				bool flag32 = (nint)obj70 < 1;
				obj = !flag32;
				obj2 = obj70 - 1;
				flag9 = obj2 == null;
				flag6 = (nint)obj70 != 1;
				grouping7 = grouping2;
				if (flag6)
				{
					continue;
				}
				goto IL_0a60;
			}
			object obj71 = num14 + grouping7;
			object obj72 = obj71 + 312;
			goto IL_1c4e;
			IL_0a98:
			return result;
			IL_1677:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1fba;
			IL_0a60:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1c4e;
			IL_1441:
			grouping2 = <RunningGroupBy>d__.<>2__current;
			IGrouping<TKey, TElement> grouping8 = <RunningGroupBy>d__.<>2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
			bool flag33 = (nint)grouping8 < 0;
			obj = !flag33;
			IGrouping<TKey, TElement> grouping9 = <RunningGroupBy>d__.<>2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
			obj2 = grouping9 - 0;
			flag9 = obj2 == null;
			object obj75 = default(object);
			if (obj == null)
			{
				IGrouping<TKey, TElement> grouping10 = (IGrouping<TKey, TElement>)(<RunningGroupBy>d__.<>2__current + 1);
				<RunningGroupBy>d__.<>2__current = grouping10;
				object obj73 = <RunningGroupBy>d__.<>1__state + <RunningGroupBy>d__.<>2__current;
				object obj74 = obj73 + 32;
				obj74 = obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TKey val3 = <RunningGroupBy>d__2.<newKey>5__3;
				TKey val4 = val;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v24 (System.Int32)+20]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1246 @ X8_v56+C0]");
				object obj77 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X8_v57+70]");
				obj19 = 0;
				((List<object>)(object)<RunningGroupBy>d__).AddWithResize(obj75);
				TKey val3 = <RunningGroupBy>d__2.<newKey>5__3;
				TKey val4 = val;
			}
			goto IL_1578;
			IL_1d39:
			num12 = (nint)<RunningGroupBy>d__2.<enumerator>5__2;
			if (<RunningGroupBy>d__2.<enumerator>5__2 != null)
			{
				object obj78 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v63+12E]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v63+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1677;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v63+B0]");
				IGrouping<TKey, TElement> grouping11 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
				bool flag34 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X10_v31 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					bool flag35 = 0 < (nint)obj3;
					obj = !flag35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X10_v31 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					obj2 = 0 - obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1118 @ X10_v31 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					grouping2 = (IGrouping<TKey, TElement>)(grouping11 + 16);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v63+12E]");
					num7 = (int)(-1);
					bool flag36 = num7 < 1;
					obj = !flag36;
					obj2 = num7 - 1;
					flag9 = obj2 == null;
					flag6 = num7 != 1;
					flag34 = flag6;
					grouping11 = grouping2;
					if (flag6)
					{
						continue;
					}
					goto IL_1677;
				}
				object obj79 = obj78 + (object)grouping11;
				object obj80 = obj79 + 312;
				flag6 = flag34;
				num7 = (int)grouping11;
				grouping2 = grouping11;
				goto IL_1fba;
			}
			ex = new NullReferenceException();
			num4 = (int)<RunningGroupBy>d__2;
			goto IL_200a;
			IL_172b:
			object obj81 = ex2 + 24;
			obj81 = <RunningGroupBy>d__;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<RunningGroupBy>d__2.<>1__state = 1;
			result = true;
			goto IL_0a98;
			IL_045c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_19fe;
			IL_19fe:
			num4 = (int)obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v785 @ X0_v80] (should have been resolved before IL gen)");
			if (<RunningGroupBy>d__3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v91+C0]");
				object obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X8_v92+68]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v77 (ArraysExtensions+<RunningGroupBy>d__27`2<TKey, TElement>)+1C]");
				object obj84 = (nint)0 + (nint)1;
				num7 = <RunningGroupBy>d__3.<>1__state;
				if (<RunningGroupBy>d__3.<>1__state != 0)
				{
					grouping2 = <RunningGroupBy>d__3.<>2__current;
					IGrouping<TKey, TElement> grouping12 = <RunningGroupBy>d__3.<>2__current;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
					bool flag37 = (nint)grouping12 < 0;
					obj = !flag37;
					IGrouping<TKey, TElement> grouping13 = <RunningGroupBy>d__3.<>2__current;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
					obj2 = grouping13 - 0;
					flag9 = obj2 == null;
					object obj87 = default(object);
					if (obj == null)
					{
						IGrouping<TKey, TElement> grouping14 = (IGrouping<TKey, TElement>)(<RunningGroupBy>d__3.<>2__current + 1);
						<RunningGroupBy>d__3.<>2__current = grouping14;
						object obj85 = <RunningGroupBy>d__3.<>1__state + <RunningGroupBy>d__3.<>2__current;
						object obj86 = obj85 + 32;
						obj86 = obj87;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						<RunningGroupBy>d__ = <RunningGroupBy>d__3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v24 (System.Int32)+20]");
						object obj88 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v94+C0]");
						object obj89 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v95+70]");
						obj19 = 0;
						((List<object>)(object)<RunningGroupBy>d__3).AddWithResize(obj87);
						<RunningGroupBy>d__ = <RunningGroupBy>d__3;
					}
					goto IL_1578;
				}
			}
			ex = new NullReferenceException();
			<RunningGroupBy>d__ = <RunningGroupBy>d__3;
			goto IL_200a;
			IL_1d0a:
			object obj90 = default(object);
			num4 = (int)obj90;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1310 @ X0_v119] (should have been resolved before IL gen)");
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__4 = default(<RunningGroupBy>d__27<TKey, TElement>);
			object obj97 = default(object);
			if (<RunningGroupBy>d__4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
				object obj91 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1318 @ X8_v138+C0]");
				object obj92 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1319 @ X8_v139+68]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X0_v116 (ArraysExtensions+<RunningGroupBy>d__27`2<TKey, TElement>)+1C]");
				object obj93 = (nint)0 + (nint)1;
				num7 = <RunningGroupBy>d__4.<>1__state;
				if (<RunningGroupBy>d__4.<>1__state != 0)
				{
					grouping2 = <RunningGroupBy>d__4.<>2__current;
					IGrouping<TKey, TElement> grouping15 = <RunningGroupBy>d__4.<>2__current;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
					bool flag38 = (nint)grouping15 < 0;
					obj = !flag38;
					IGrouping<TKey, TElement> grouping16 = <RunningGroupBy>d__4.<>2__current;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X9_v29 (System.Int32)+18]");
					obj2 = grouping16 - 0;
					flag9 = obj2 == null;
					object obj96 = default(object);
					if (obj == null)
					{
						IGrouping<TKey, TElement> grouping17 = (IGrouping<TKey, TElement>)(<RunningGroupBy>d__4.<>2__current + 1);
						<RunningGroupBy>d__4.<>2__current = grouping17;
						object obj94 = <RunningGroupBy>d__4.<>1__state + <RunningGroupBy>d__4.<>2__current;
						object obj95 = obj94 + 32;
						obj95 = obj96;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						val = (TKey)obj97;
						<RunningGroupBy>d__ = <RunningGroupBy>d__4;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v24 (System.Int32)+20]");
						object obj98 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1326 @ X8_v141+C0]");
						object obj99 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v142+70]");
						obj19 = 0;
						((List<object>)(object)<RunningGroupBy>d__4).AddWithResize(obj96);
						val = (TKey)obj97;
						<RunningGroupBy>d__ = <RunningGroupBy>d__4;
					}
					goto IL_1d39;
				}
			}
			ex = new NullReferenceException();
			val = (TKey)obj97;
			<RunningGroupBy>d__ = <RunningGroupBy>d__4;
			goto IL_200a;
			IL_0d28:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1d0a;
			IL_1b7f:
			num4 = (int)obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1102 @ X0_v108] (should have been resolved before IL gen)");
			if (<RunningGroupBy>d__ != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v272.<>2__current (System.Linq.IGrouping`2<TKey, TElement>) (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
				object obj100 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1141 @ X8_v120+C0]");
				object obj101 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X8_v121+50]");
				object obj102 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ X8_v121+50]");
				object obj103 = (nint)0 + (nint)309;
				object obj104 = obj103 & 1;
				bool flag39 = obj104 == null;
				object obj105 = !flag39;
				if (obj105 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
				object obj106 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v125+C0]");
				object obj107 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X8_v126+58]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B59C50");
				IEnumerator<TElement> enumerator3 = <RunningGroupBy>d__2.<enumerator>5__2;
				if (<RunningGroupBy>d__2.<enumerator>5__2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ stack_-50_v2+20]");
					object obj108 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1236 @ X8_v129+C0]");
					object obj109 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X8_v130+20]");
					object obj110 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1237 @ X8_v130+20]");
					object obj111 = (nint)0 + (nint)309;
					object obj112 = obj111 & 1;
					bool flag40 = obj112 == null;
					object obj113 = !flag40;
					if (obj113 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj114 = default(object);
						obj110 = obj114;
					}
					nint num15 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
					num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0d28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+B0]");
					IGrouping<TKey, TElement> grouping18 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
					bool flag41 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ X10_v50 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						bool flag42 = 0 < (nint)obj110;
						obj = !flag42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ X10_v50 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						obj2 = 0 - obj110;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ X10_v50 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
						if (0 == (nint)obj110)
						{
							break;
						}
						grouping2 = (IGrouping<TKey, TElement>)(grouping18 + 16);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
						num7 = (int)(-1);
						bool flag43 = num7 < 1;
						obj = !flag43;
						obj2 = num7 - 1;
						flag9 = obj2 == null;
						flag6 = num7 != 1;
						flag41 = flag6;
						grouping18 = grouping2;
						if (flag6)
						{
							continue;
						}
						goto IL_0d28;
					}
					num7 = (int)grouping18;
					object obj115 = num15 + grouping18;
					obj90 = obj115 + 312;
					flag6 = flag41;
					grouping2 = grouping18;
					goto IL_1d0a;
				}
				ex = new NullReferenceException();
				num4 = (int)<RunningGroupBy>d__2;
				val = (TKey)obj97;
				<RunningGroupBy>d__ = <RunningGroupBy>d__4;
			}
			else
			{
				ex = new NullReferenceException();
			}
			goto IL_200a;
			IL_184d:
			result = false;
			object obj116 = (object)(&<RunningGroupBy>d__2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF0EFC");
			ex2 = new OutOfMemoryException();
			goto IL_172b;
			IL_0957:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1b7f;
			IL_01fc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_18f8;
			IL_18f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v671 @ X0_v96] (should have been resolved before IL gen)");
			object obj117 = <RunningGroupBy>d__2 + 72;
			object obj118 = default(object);
			obj117 = obj118;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 4294967293L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-48_v2 (ArraysExtensions+<RunningGroupBy>d__27`2<TKey, TElement>)+48]");
			val = (TKey)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-48_v2 (ArraysExtensions+<RunningGroupBy>d__27`2<TKey, TElement>)+48]");
			if ((nint)0 != 0)
			{
				nint num16 = (nint)val;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v107 (Il2CppClass<TKey>)+12E]");
				num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v107 (Il2CppClass<TKey>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05b5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v107 (Il2CppClass<TKey>)+B0]");
				IGrouping<TKey, TElement> grouping19 = (IGrouping<TKey, TElement>)((nint)0 + (nint)8);
				bool flag44 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v60 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					bool flag45 = 0 < (nint)obj3;
					obj = !flag45;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v60 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					obj2 = 0 - obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v60 (System.Linq.IGrouping`2<TKey, TElement>)-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					grouping2 = (IGrouping<TKey, TElement>)(grouping19 + 16);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v107 (Il2CppClass<TKey>)+12E]");
					num7 = (int)(-1);
					bool flag46 = num7 < 1;
					obj = !flag46;
					obj2 = num7 - 1;
					flag9 = obj2 == null;
					flag6 = num7 != 1;
					flag44 = flag6;
					grouping19 = grouping2;
					if (flag6)
					{
						continue;
					}
					goto IL_05b5;
				}
				num7 = (int)grouping19;
				object obj119 = num16 + grouping19;
				obj31 = obj119 + 312;
				flag6 = flag44;
				grouping2 = grouping19;
				goto IL_1a8d;
			}
			ex = new NullReferenceException();
			num7 = -3;
			num4 = (int)<RunningGroupBy>d__2;
			<RunningGroupBy>d__ = this;
			goto IL_200a;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_00f6: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			while (true)
			{
				<>1__state = -1;
				IEnumerator<TElement> enumerator = <enumerator>5__2;
				if (<enumerator>5__2 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerator`1<TElement>>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
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
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X0_v3] (should have been resolved before IL gen)");
				break;
			}
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<IGrouping<TKey, TElement>> IEnumerable<IGrouping<TKey, TElement>>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I4
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected O, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (<>l__initialThreadId == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0111;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0111;
			IL_0111:
			object obj8 = obj3 + 40;
			obj8 = <>3__source;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj3 + 56;
			obj9 = <>3__keySelector;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerator<IGrouping<TKey, TElement>>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45B9E30");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	private sealed class <TakeSample>d__23<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private T <>2__current;

		private int <>l__initialThreadId;

		private IEnumerable<T> enumerable;

		public IEnumerable<T> <>3__enumerable;

		private int sampleSize;

		public int <>3__sampleSize;

		private List<T> <list>5__2;

		private List<T>.Enumerator <>7__wrap2;

		private int <i>5__4;

		T IEnumerator<T>.Current => (T)this;

		object IEnumerator.Current
		{
			get
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object result = default(object);
				return result;
			}
		}

		public <TakeSample>d__23(int <>1__state)
		{
			this.<>1__state = <>1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
		}

		unsafe void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_00a7: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0085: Expected I4, but got I8
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			object obj5 = !flag2;
			if (obj5 == null)
			{
				<>1__state = -1;
				List<Vector2>.Enumerator enumerator = (List<Vector2>.Enumerator)(this + 64);
				((List<Vector2>.Enumerator*)enumerator)->Dispose();
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_022f: Expected I4, but got I8
			//IL_0245: Expected O, but got I
			//IL_0402: Expected O, but got I4
			//IL_041c: Expected O, but got I4
			//IL_02a9: Expected O, but got I4
			//IL_01dc: Expected I4, but got I8
			//IL_04d2: Expected O, but got I
			//IL_04e2: Expected O, but got I
			//IL_04f2: Expected O, but got I
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0630: Expected O, but got Unknown
			//IL_064d: Expected O, but got I
			//IL_0069: Expected O, but got I4
			//IL_0679: Unknown result type (might be due to invalid IL or missing references)
			//IL_067e: Expected O, but got Unknown
			//IL_06a8: Expected O, but got I4
			//IL_02c3: Expected O, but got I
			//IL_02d3: Expected O, but got I
			//IL_02e3: Expected O, but got I
			//IL_02f3: Expected O, but got I
			//IL_030d: Expected O, but got I
			//IL_031d: Expected O, but got I
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Expected O, but got Unknown
			//IL_0344: Expected O, but got I
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
			//IL_048c: Invalid comparison between F8 and I4
			//IL_01f1: Expected O, but got I
			//IL_0086: Expected I4, but got I8
			//IL_04bd: Expected I4, but got F8
			//IL_061f: Expected O, but got I4
			//IL_06c6: Expected O, but got I
			//IL_06d6: Expected O, but got I
			//IL_06e6: Expected O, but got I
			//IL_06f5: Expected O, but got I4
			//IL_0709: Expected O, but got I
			//IL_0739: Expected O, but got I4
			//IL_074a: Expected O, but got I4
			//IL_04b0: Expected I4, but got I8
			//IL_00bb: Expected O, but got I4
			//IL_00d5: Expected O, but got I
			//IL_00fc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_0571: Expected I, but got O
			//IL_057a: Expected O, but got I4
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0389: Expected O, but got Unknown
			//IL_03a3: Expected O, but got I4
			//IL_03bd: Expected O, but got I4
			//IL_03c7: Expected O, but got I4
			//IL_03d8: Expected O, but got I4
			//IL_03ea: Expected I, but got O
			//IL_0166: Expected O, but got I4
			//IL_017a: Expected O, but got I
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Expected O, but got Unknown
			//IL_01b1: Expected O, but got I
			//IL_01c0: Expected I4, but got I8
			object obj2 = default(object);
			object obj = (object)(&obj2);
			List<Vector2> list2;
			object obj5;
			object obj7;
			IEnumerable<T> enumerable;
			nint num = default(nint);
			bool result;
			NullReferenceException ex;
			object obj6 = default(object);
			object obj8 = default(object);
			object obj11;
			IEnumerable<T> enumerable2 = default(IEnumerable<T>);
			List<Vector2> list3 = default(List<Vector2>);
			object obj9;
			if (<>1__state != 2)
			{
				if (<>1__state == 1)
				{
					<>1__state = -3;
					goto IL_0624;
				}
				bool flag = <>1__state == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					<>1__state = -1;
					bool flag2 = <>l__initialThreadId == 0;
					result = (byte)<>l__initialThreadId != 0;
					if (flag2)
					{
						goto IL_0616;
					}
					List<Vector2> list = Enumerable.ToList((IEnumerable<Vector2>)<>l__initialThreadId);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					object obj4 = (nint)0 + (nint)56;
					obj4 = list;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
					<TakeSample>d__23<T> <TakeSample>d__ = (<TakeSample>d__23<T>)0;
					list2 = (List<Vector2>)sampleSize;
					if (sampleSize == 0)
					{
						ex = new NullReferenceException();
						obj5 = obj6;
						obj7 = obj8;
						enumerable = enumerable2;
						num = (nint)list;
						obj9 = 0;
						goto IL_0585;
					}
					enumerable2 = <>3__enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X9_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
					if (0 < (nint)<>3__enumerable)
					{
						List<Vector2>.Enumerator enumerator = ((List<Vector2>)sampleSize).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						list3 = (List<Vector2>)0;
						object obj10 = list3 + 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
						<TakeSample>d__ = (<TakeSample>d__23<T>)0;
						<>1__state = -3;
						object obj12 = default(object);
						obj11 = obj12;
						goto IL_0624;
					}
					_ = 1;
					object obj13 = 1 - <>3__enumerable;
					bool flag3 = obj13 == null;
					obj6 = !flag3;
					bool flag4 = 1 > (nint)<>3__enumerable;
					obj8 = 1;
					list3 = (List<Vector2>)sampleSize;
					obj5 = obj6;
					obj7 = 1;
					enumerable = <>3__enumerable;
					num = (nint)list;
					if (!flag4)
					{
						goto IL_03f8;
					}
				}
			}
			else
			{
				<>1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v33 (ArraysExtensions+<TakeSample>d__23`1<T>)+58]");
				obj8 = (nint)0 + (nint)1;
				enumerable2 = <>3__enumerable;
				bool flag5 = obj8 <= <>3__enumerable;
				obj5 = obj6;
				obj7 = obj8;
				enumerable = <>3__enumerable;
				list2 = list3;
				if (flag5)
				{
					goto IL_03f8;
				}
			}
			result = false;
			obj9 = 0;
			goto IL_04c2;
			IL_04c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v8+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v9+C0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v10+68]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF4E6C");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			obj5 = obj6;
			obj7 = obj8;
			enumerable = enumerable2;
			list2 = list3;
			goto IL_053a;
			IL_0624:
			List<Vector2>.Enumerator enumerator2 = (List<Vector2>.Enumerator)(this + 64);
			bool flag6 = ((List<Vector2>.Enumerator*)enumerator2)->MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj17 = 0;
			if (flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v30+50]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v30+50]");
				_ = 0;
				_ = 1;
				result = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X9_v12+20]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X9_v13+C0]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X9_v14+8]");
				object obj21 = 0;
				_ = 4294967295L;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X9_v15+20]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X9_v16+C0]");
				list3 = (List<Vector2>)0;
				List<Vector2>.Enumerator enumerator3 = (List<Vector2>.Enumerator)(obj17 + 64);
				((List<Vector2>.Enumerator*)enumerator3)->Dispose();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
				object obj23 = 0;
				_ = 0;
				_ = 0;
				_ = 0;
				result = false;
			}
			goto IL_02ae;
			IL_053a:
			ex = new NullReferenceException();
			goto IL_0585;
			IL_03f8:
			List<Vector2> list4 = (List<Vector2>)sampleSize;
			bool flag7 = sampleSize == 0;
			obj9 = 0;
			if (flag7)
			{
				goto IL_053a;
			}
			object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X0_v21+E4]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X19_v8 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			object obj27 = 0 / enumerable;
			object obj28 = obj27 * obj7;
			double num2 = (double)obj28 + -1.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			int index = (int)((-1.0 != 2139095040.0) ? ((int)num2) : 2147483648L);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v18+20]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v19+C0]");
			object obj31 = 0;
			Vector2 vector = ((List<Vector2>)sampleSize).get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			object obj32 = 0;
			_ = 2139095040;
			_ = -1.0;
			_ = 2;
			obj6 = obj5;
			obj8 = obj7;
			obj11 = 2139095040;
			enumerable2 = enumerable;
			list3 = (List<Vector2>)2;
			result = true;
			goto IL_0616;
			IL_0585:
			if (num == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj33 = default(object);
				bool flag9 = obj33 == null;
				result = false;
				if (flag9)
				{
					goto IL_02ae;
				}
				obj6 = obj5;
				obj8 = obj7;
				enumerable2 = enumerable;
				list3 = list2;
				obj9 = obj33;
				goto IL_04c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF1E3C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result2 = default(bool);
			return result2;
			IL_0616:
			obj9 = 0;
			goto IL_02ae;
			IL_02ae:
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private unsafe void <>m__Finally1()
		{
			//IL_000f: Expected I4, but got I8
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			<>1__state = -1;
			List<Vector2>.Enumerator enumerator = (List<Vector2>.Enumerator)(this + 64);
			((List<Vector2>.Enumerator*)enumerator)->Dispose();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0099: Expected O, but got I
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00c1: Expected O, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			object obj = <>1__state + 2;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3;
			if (obj2 == null)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ArraysExtensions+<TakeSample>d__23`1<T>)+1C]");
				if ((nint)0 == currentManagedThreadId)
				{
					<>1__state = 0;
					obj3 = this;
					goto IL_0117;
				}
			}
			nint num = 0;
			IntPtr intPtr = num;
			object obj4 = num + 309;
			object obj5 = obj4 & 1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = default(object);
			obj7..ctor();
			_ = 0;
			int currentManagedThreadId2 = Environment.CurrentManagedThreadId;
			obj3 = obj7;
			goto IL_0117;
			IL_0117:
			object obj8 = obj3 + 32;
			obj8 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ArraysExtensions+<TakeSample>d__23`1<T>)+34]");
			_ = 0;
			return (IEnumerator<T>)obj3;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @46C1784");
			IEnumerator result = default(IEnumerator);
			return result;
		}
	}

	public static T Random<T>(IList<T> array)
	{
		//IL_001f: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_032b: Expected I, but got O
		//IL_033b: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_00ce: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		//IL_038c: Expected I, but got O
		//IL_039c: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0256: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_040d: Expected O, but got I
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0435: Expected O, but got I4
		//IL_01be: Expected O, but got I
		//IL_0451: Expected I, but got O
		//IL_0461: Expected O, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_04c2: Expected O, but got I
		//IL_02b3: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		bool flag = array == null;
		object obj = !flag;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_010f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v18-8]");
				if (0 == num)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_010f;
			}
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ X0_v29] (should have been resolved before IL gen)");
			object obj9 = default(object);
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0149;
			}
		}
		goto IL_0264;
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v26] (should have been resolved before IL gen)");
		object obj11 = default(object);
		bool flag4 = obj11 == null;
		object obj12 = 0;
		if (!flag4)
		{
			goto IL_0149;
		}
		goto IL_0264;
		IL_04aa:
		object obj14 = default(object);
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v13+8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0149:
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag5 = obj17 == null;
		object obj18 = !flag5;
		nint num3 = 0;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr2 = default(IntPtr);
			num3 = intPtr2;
		}
		nint num4 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v11 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v13-8]");
			if (0 == num3)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_01ff;
		}
		object obj21 = num4 + obj20;
		object obj22 = obj21 + 312;
		goto IL_03e5;
		IL_0264:
		return (T)null;
		IL_01ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 0;
		goto IL_03e5;
		IL_03e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X0_v7] (should have been resolved before IL gen)");
		int maxExclusive = default(int);
		int num5 = UnityEngine.Random.Range(0, maxExclusive);
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag6 = obj24 == null;
		object obj25 = !flag6;
		nint num6 = 0;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr3 = default(IntPtr);
			num6 = intPtr3;
		}
		nint num7 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02f4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v8-8]");
			if (0 == num6)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_02f4;
		}
		object obj28 = num7 + obj27;
		obj14 = obj28 + 312;
		goto IL_04aa;
		IL_02f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04aa;
	}

	public unsafe static IEnumerable<T> Shuffled<T>(IEnumerable<T> enumerable)
	{
		//IL_0034: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_0234: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_00ed: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0254: Expected O, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_04b3: Expected O, but got I4
		//IL_02b6: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_052d: Expected O, but got I
		//IL_0541: Expected O, but got I
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_04d7: Expected O, but got I
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04ff: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0324: Expected O, but got I4
		//IL_038c: Expected O, but got I
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03b4: Expected O, but got I4
		//IL_03ff: Expected O, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0427: Expected O, but got I4
		//IL_0467: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_044c: Expected O, but got I
		nint num3;
		nint num4;
		if (enumerable != null)
		{
			nint num = 0;
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v6 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+E4]");
				bool flag = (nint)0 == 0;
				nint num2 = 0;
				if (!flag)
				{
					goto IL_008a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v37 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_008a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag3 = obj5 == null;
			object obj6 = !flag3;
			num3 = 0;
			num4 = 0;
			if (obj6 != null)
			{
				goto IL_00cd;
			}
			goto IL_01e8;
		}
		return null;
		IL_02e7:
		object obj7 = <>c__1<T>.<>9;
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		nint num5 = 0;
		object obj11 = <>c__1<T>.<>9;
		nint num6 = 0;
		if (obj10 == null)
		{
			goto IL_0347;
		}
		goto IL_035e;
		IL_0347:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj11 = obj7;
		goto IL_035e;
		IL_0585:
		Func<object, float> keySelector;
		return (IEnumerable<T>)Enumerable.OrderBy((IEnumerable<object>)enumerable, keySelector);
		IL_0513:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v13+B8]");
		object obj12 = 0;
		obj7 = obj12;
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag5 = obj14 == null;
		num5 = 0;
		if (flag5)
		{
			goto IL_0347;
		}
		obj11 = obj12;
		num6 = 0;
		goto IL_035e;
		IL_02aa:
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag6 = obj16 == null;
		nint num7 = 0;
		if (!flag6)
		{
			goto IL_02e7;
		}
		goto IL_0513;
		IL_008a:
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag7 = obj18 == null;
		num3 = 0;
		num4 = 0;
		if (!flag7)
		{
			goto IL_00cd;
		}
		goto IL_01e8;
		IL_01e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v36+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v14+8]");
		keySelector = (Func<object, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X9_v14+8]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			goto IL_0242;
		}
		goto IL_0585;
		IL_00cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v41 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+B8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v18 (Il2CppStaticFields<ArraysExtensions+<>c__1`1<T>>)+8]");
		keySelector = (Func<object, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v18 (Il2CppStaticFields<ArraysExtensions+<>c__1`1<T>>)+8]");
		bool flag9 = (nint)0 == 0;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			goto IL_0242;
		}
		goto IL_0585;
		IL_0242:
		nint num9 = 0;
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+E4]");
			bool flag10 = (nint)0 == 0;
			nint num10 = 0;
			if (!flag10)
			{
				goto IL_02aa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v15 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+E4]");
			bool flag11 = (nint)0 == 0;
			object obj24 = !flag11;
			if (obj24 != null)
			{
				goto IL_02aa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag12 = obj26 == null;
		object obj27 = !flag12;
		num7 = 0;
		if (obj27 != null)
		{
			goto IL_02e7;
		}
		goto IL_0513;
		IL_035e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, float> func = default(Func<object, float>);
		func..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__1<T>.<Shuffled>b__1_0));
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag13 = obj29 == null;
		object obj30 = !flag13;
		nint num11 = 0;
		if (obj30 == null)
		{
			((Func<T, float>)0)..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__1<T>.<Shuffled>b__1_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v22 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+B8]");
		nint num12 = 0;
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag14 = obj32 == null;
		object obj33 = !flag14;
		nint num13 = 0;
		if (obj33 == null)
		{
			((Func<T, float>)0)..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__1<T>.<Shuffled>b__1_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v24 (Il2CppClass<ArraysExtensions+<>c__1`1<T>>)+B8]");
		Func<T, float> func2 = (Func<T, float>)((nint)0 + (nint)8);
		func2..ctor((object)func, (IntPtr)(nint)__ldftn(<>c__1<T>.<Shuffled>b__1_0));
		keySelector = func;
		goto IL_0585;
	}

	public unsafe static string ToPrettyString<T>(ICollection<T> array)
	{
		//IL_057a: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_0685: Expected I, but got O
		//IL_0695: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_04dc: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_06fe: Expected O, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_073e: Expected O, but got I4
		//IL_0500: Expected O, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0496: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_05ab: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0625: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_05cf: Expected O, but got I
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I4
		//IL_02ff: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_038f: Expected O, but got I
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I4
		//IL_0402: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_046a: Expected O, but got I
		//IL_03dc: Expected O, but got I
		//IL_044f: Expected O, but got I
		object obj8;
		if (array != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00dd;
			}
			object obj6 = num2 + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v52+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v52] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_0180;
			}
		}
		goto IL_056e;
		IL_060b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v18+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag2 = obj13 == null;
		nint num3 = 0;
		if (flag2)
		{
			goto IL_034a;
		}
		object obj14 = obj10;
		nint num4 = 0;
		goto IL_0361;
		IL_0236:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_06de;
		IL_01e8:
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		nint num5 = 0;
		nint num6 = 0;
		if (obj17 == null)
		{
			goto IL_0236;
		}
		goto IL_06de;
		IL_06de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v7 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+B8]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v5 (Il2CppStaticFields<ArraysExtensions+<>c__2`1<T>>)+8]");
		Func<object, object> selector = (Func<object, object>)0;
		object separator = "&action=sign-up" + 3408;
		object obj18 = "utf-32" + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v5 (Il2CppStaticFields<ArraysExtensions+<>c__2`1<T>>)+8]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		nint num10;
		if (obj19 == null)
		{
			nint num8 = 0;
			object obj20 = (nint)0 + (nint)309;
			object obj21 = obj20 & 1;
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v16 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+E4]");
				bool flag5 = (nint)0 == 0;
				nint num9 = 0;
				if (!flag5)
				{
					goto IL_02ad;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v20 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 != null)
				{
					goto IL_02ad;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag7 = obj24 == null;
			object obj25 = !flag7;
			num10 = 0;
			if (obj25 != null)
			{
				goto IL_02ea;
			}
			goto IL_060b;
		}
		goto IL_074c;
		IL_074c:
		IEnumerable<object> source = Enumerable.Select((IEnumerable<object>)array, selector);
		object[] value = Enumerable.ToArray(source);
		string text = string.Join((string)separator, (string[])value);
		object obj26 = (nint)0 + (nint)2800;
		return (string)obj18 + text + (string)obj26;
		IL_0361:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__2<T>.<ToPrettyString>b__2_0));
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag8 = obj28 == null;
		object obj29 = !flag8;
		nint num11 = 0;
		if (obj29 == null)
		{
			((Func<T, string>)0)..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__2<T>.<ToPrettyString>b__2_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v27 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+B8]");
		nint num12 = 0;
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag9 = obj31 == null;
		object obj32 = !flag9;
		nint num13 = 0;
		if (obj32 == null)
		{
			((Func<T, string>)0)..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__2<T>.<ToPrettyString>b__2_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v29 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+B8]");
		Func<T, string> func2 = (Func<T, string>)((nint)0 + (nint)8);
		func2..ctor((object)func, (IntPtr)(nint)__ldftn(<>c__2<T>.<ToPrettyString>b__2_0));
		selector = func;
		goto IL_074c;
		IL_056e:
		return (string)((nint)0 + (nint)2000);
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v49+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v49] (should have been resolved before IL gen)");
		object obj33 = default(object);
		bool flag10 = obj33 == null;
		object obj34 = !flag10;
		if (obj34 != null)
		{
			goto IL_0180;
		}
		goto IL_056e;
		IL_0180:
		nint num14 = 0;
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v6 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+E4]");
			bool flag11 = (nint)0 == 0;
			nint num15 = 0;
			if (!flag11)
			{
				goto IL_01e8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v40 (Il2CppClass<ArraysExtensions+<>c__2`1<T>>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			if (obj37 != null)
			{
				goto IL_01e8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38 & 1;
		bool flag13 = obj39 == null;
		num5 = 0;
		if (flag13)
		{
			goto IL_0236;
		}
		num6 = 0;
		goto IL_06de;
		IL_02ad:
		object obj40 = (nint)0 + (nint)309;
		object obj41 = obj40 & 1;
		bool flag14 = obj41 == null;
		num10 = 0;
		if (!flag14)
		{
			goto IL_02ea;
		}
		goto IL_060b;
		IL_02ea:
		obj11 = <>c__2<T>.<>9;
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag15 = obj43 == null;
		object obj44 = !flag15;
		num3 = 0;
		obj14 = <>c__2<T>.<>9;
		num4 = 0;
		if (obj44 == null)
		{
			goto IL_034a;
		}
		goto IL_0361;
		IL_034a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj14 = obj11;
		goto IL_0361;
	}

	public unsafe static string ToPrettyString<T, J>(IDictionary<T, J> dict)
	{
		//IL_057a: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_0685: Expected I, but got O
		//IL_0695: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_04dc: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_06fe: Expected O, but got I
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_073e: Expected O, but got I4
		//IL_0500: Expected O, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0496: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_05ab: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0625: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_05cf: Expected O, but got I
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I4
		//IL_02ff: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_038f: Expected O, but got I
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I4
		//IL_0402: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_046a: Expected O, but got I
		//IL_03dc: Expected O, but got I
		//IL_044f: Expected O, but got I
		object obj8;
		if (dict != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)dict;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.IDictionary`2<T, J>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.IDictionary`2<T, J>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v9 (Il2CppClass<System.Collections.Generic.IDictionary`2<T, J>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00dd;
			}
			object obj6 = num2 + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v52+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v52] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_0180;
			}
		}
		goto IL_056e;
		IL_060b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v18+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag2 = obj13 == null;
		nint num3 = 0;
		if (flag2)
		{
			goto IL_034a;
		}
		object obj14 = obj10;
		nint num4 = 0;
		goto IL_0361;
		IL_0236:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_06de;
		IL_01e8:
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		nint num5 = 0;
		nint num6 = 0;
		if (obj17 == null)
		{
			goto IL_0236;
		}
		goto IL_06de;
		IL_06de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v7 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+B8]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v5 (Il2CppStaticFields<ArraysExtensions+<>c__3`2<T, J>>)+8]");
		Func<KeyValuePair<object, object>, object> selector = (Func<KeyValuePair<object, object>, object>)0;
		object separator = "&action=sign-up" + 3408;
		object obj18 = "utf-32" + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X9_v5 (Il2CppStaticFields<ArraysExtensions+<>c__3`2<T, J>>)+8]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		nint num10;
		if (obj19 == null)
		{
			nint num8 = 0;
			object obj20 = (nint)0 + (nint)309;
			object obj21 = obj20 & 1;
			if (obj21 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X0_v16 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+E4]");
				bool flag5 = (nint)0 == 0;
				nint num9 = 0;
				if (!flag5)
				{
					goto IL_02ad;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v20 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj22 = !flag6;
				if (obj22 != null)
				{
					goto IL_02ad;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag7 = obj24 == null;
			object obj25 = !flag7;
			num10 = 0;
			if (obj25 != null)
			{
				goto IL_02ea;
			}
			goto IL_060b;
		}
		goto IL_074c;
		IL_074c:
		IEnumerable<object> source = Enumerable.Select((IEnumerable<KeyValuePair<object, object>>)dict, selector);
		object[] value = Enumerable.ToArray(source);
		string text = string.Join((string)separator, (string[])value);
		object obj26 = (nint)0 + (nint)2800;
		return (string)obj18 + text + (string)obj26;
		IL_0361:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
		func..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__3<T, J>.<ToPrettyString>b__3_0));
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag8 = obj28 == null;
		object obj29 = !flag8;
		nint num11 = 0;
		if (obj29 == null)
		{
			((Func<KeyValuePair<T, J>, string>)0)..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__3<T, J>.<ToPrettyString>b__3_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X0_v27 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+B8]");
		nint num12 = 0;
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag9 = obj31 == null;
		object obj32 = !flag9;
		nint num13 = 0;
		if (obj32 == null)
		{
			((Func<KeyValuePair<T, J>, string>)0)..ctor(obj14, (IntPtr)(nint)__ldftn(<>c__3<T, J>.<ToPrettyString>b__3_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v29 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+B8]");
		Func<KeyValuePair<T, J>, string> func2 = (Func<KeyValuePair<T, J>, string>)((nint)0 + (nint)8);
		func2..ctor((object)func, (IntPtr)(nint)__ldftn(<>c__3<T, J>.<ToPrettyString>b__3_0));
		selector = func;
		goto IL_074c;
		IL_056e:
		return (string)((nint)0 + (nint)2000);
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v49+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v49] (should have been resolved before IL gen)");
		object obj33 = default(object);
		bool flag10 = obj33 == null;
		object obj34 = !flag10;
		if (obj34 != null)
		{
			goto IL_0180;
		}
		goto IL_056e;
		IL_0180:
		nint num14 = 0;
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		if (obj36 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v6 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+E4]");
			bool flag11 = (nint)0 == 0;
			nint num15 = 0;
			if (!flag11)
			{
				goto IL_01e8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v40 (Il2CppClass<ArraysExtensions+<>c__3`2<T, J>>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj37 = !flag12;
			if (obj37 != null)
			{
				goto IL_01e8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38 & 1;
		bool flag13 = obj39 == null;
		num5 = 0;
		if (flag13)
		{
			goto IL_0236;
		}
		num6 = 0;
		goto IL_06de;
		IL_02ad:
		object obj40 = (nint)0 + (nint)309;
		object obj41 = obj40 & 1;
		bool flag14 = obj41 == null;
		num10 = 0;
		if (!flag14)
		{
			goto IL_02ea;
		}
		goto IL_060b;
		IL_02ea:
		obj11 = <>c__3<T, J>.<>9;
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag15 = obj43 == null;
		object obj44 = !flag15;
		num3 = 0;
		obj14 = <>c__3<T, J>.<>9;
		num4 = 0;
		if (obj44 == null)
		{
			goto IL_034a;
		}
		goto IL_0361;
		IL_034a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj14 = obj11;
		goto IL_0361;
	}

	public static bool Swap<T>(IList<T> array, int index1, int index2)
	{
		//IL_002e: Expected O, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		//IL_03cf: Expected I, but got O
		//IL_03df: Expected O, but got I
		//IL_0451: Expected I4, but got I8
		//IL_046b: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_048a: Expected I, but got O
		//IL_049a: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0329: Expected O, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_0351: Expected O, but got I4
		//IL_0522: Expected O, but got I
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_054a: Expected O, but got I4
		//IL_0574: Expected O, but got I
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_059c: Expected O, but got I4
		//IL_05c6: Expected O, but got I
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_05ee: Expected O, but got I4
		int num3;
		if (array != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v13-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d8;
			}
			object obj6 = num2 + obj5;
			object obj7 = obj6 + 312;
			num3 = index2;
			goto IL_0428;
		}
		bool result = false;
		goto IL_0275;
		IL_03c1:
		return false;
		IL_0234:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X0_v43] (should have been resolved before IL gen)");
		object obj8 = default(object);
		if (index1 < (nint)obj8)
		{
			num3 = 0;
			goto IL_02be;
		}
		goto IL_03c1;
		IL_0428:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ X0_v8] (should have been resolved before IL gen)");
		int num4 = index2 | index1;
		int num5 = (int)(num4 & 0x80000000L);
		bool flag2 = num5 == 0;
		object obj9 = !flag2;
		result = false;
		if (obj9 == null)
		{
			object obj10 = default(object);
			bool flag3 = obj10 == null;
			result = false;
			if (!flag3)
			{
				object obj11 = (nint)0 + (nint)309;
				object obj12 = obj11 & 1;
				bool flag4 = obj12 == null;
				object obj13 = !flag4;
				nint num6 = 0;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					IntPtr intPtr2 = default(IntPtr);
					num6 = intPtr2;
				}
				nint num7 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0234;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v13 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
				object obj15 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X10_v8-8]");
					if (0 == num6)
					{
						break;
					}
					obj15 += 16;
					obj14--;
					if ((nint)obj14 != 1)
					{
						continue;
					}
					goto IL_0234;
				}
				object obj16 = num7 + obj15;
				object obj17 = obj16 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ X0_v46] (should have been resolved before IL gen)");
				object obj18 = default(object);
				if (index1 < (nint)obj18)
				{
					goto IL_02be;
				}
				goto IL_03c1;
			}
		}
		goto IL_0275;
		IL_00d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 0;
		goto IL_0428;
		IL_02be:
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag5 = obj20 == null;
		object obj21 = !flag5;
		nint num8 = 0;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr3 = default(IntPtr);
			num8 = intPtr3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9DB58");
		object obj22 = default(object);
		if (index2 < (nint)obj22)
		{
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag6 = obj24 == null;
			object obj25 = !flag6;
			nint num9 = 0;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr4 = default(IntPtr);
				num9 = intPtr4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
			object obj26 = (nint)0 + (nint)309;
			object obj27 = obj26 & 1;
			bool flag7 = obj27 == null;
			object obj28 = !flag7;
			nint num10 = 0;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr5 = default(IntPtr);
				num10 = intPtr5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			bool flag8 = obj30 == null;
			object obj31 = !flag8;
			nint num11 = 0;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr6 = default(IntPtr);
				num11 = intPtr6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA880C");
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32 & 1;
			bool flag9 = obj33 == null;
			object obj34 = !flag9;
			nint num12 = 0;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr7 = default(IntPtr);
				num12 = intPtr7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA880C");
			return true;
		}
		goto IL_03c1;
		IL_0275:
		return result;
	}

	public static IEnumerable<T> Rotate<T>(IEnumerable<T> enumerable, int offset)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		((<Rotate>d__5<T>)enumerable2)..ctor(-2);
		if (enumerable2 != null)
		{
			<Rotate>d__5<T> <Rotate>d__ = (<Rotate>d__5<T>)(enumerable2 + 48);
			<Rotate>d__ = (<Rotate>d__5<T>)enumerable;
			<Rotate>d__..ctor((int)enumerable);
			return enumerable2;
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public unsafe static List<T> Shuffle<T>(IList<T> array)
	{
		//IL_001f: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_06e6: Expected I, but got O
		//IL_06f6: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_027b: Expected O, but got I
		//IL_029f: Expected O, but got I4
		//IL_01c4: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_035b: Expected O, but got I
		//IL_036b: Expected O, but got I
		//IL_038d: Expected O, but got I4
		//IL_02ff: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_021b: Expected O, but got I
		//IL_023d: Expected O, but got I4
		//IL_03ad: Expected O, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_060c: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_0686: Expected O, but got I
		//IL_069a: Expected O, but got I
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_0630: Expected O, but got I
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_0658: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_047d: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_050d: Expected O, but got I4
		//IL_0558: Expected O, but got I
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0580: Expected O, but got I4
		//IL_05c0: Expected O, but got I
		//IL_0532: Expected O, but got I
		//IL_05a5: Expected O, but got I
		bool flag = array == null;
		object obj = !flag;
		object obj9;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_010f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v6-8]");
				if (0 == num)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_010f;
			}
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v49+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ X0_v49] (should have been resolved before IL gen)");
			object obj10 = default(object);
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				goto IL_0150;
			}
		}
		goto IL_02ad;
		IL_0341:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v37+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v17+8]");
		Func<System.Int32Enum, float> keySelector = (Func<System.Int32Enum, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X9_v17+8]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			goto IL_039b;
		}
		goto IL_073f;
		IL_039b:
		nint num3 = 0;
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v12 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+E4]");
			bool flag5 = (nint)0 == 0;
			nint num4 = 0;
			if (!flag5)
			{
				goto IL_0403;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v16 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 != null)
			{
				goto IL_0403;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag7 = obj18 == null;
		object obj19 = !flag7;
		nint num5 = 0;
		if (obj19 != null)
		{
			goto IL_0440;
		}
		goto IL_066c;
		IL_01fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v42 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+B8]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X9_v21 (Il2CppStaticFields<ArraysExtensions+<>c__6`1<T>>)+8]");
		keySelector = (Func<System.Int32Enum, float>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X9_v21 (Il2CppStaticFields<ArraysExtensions+<>c__6`1<T>>)+8]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			goto IL_039b;
		}
		goto IL_073f;
		IL_04b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<System.Int32Enum, float> func = default(Func<System.Int32Enum, float>);
		object obj21;
		func..ctor(obj21, (IntPtr)(nint)__ldftn(<>c__6<T>.<Shuffle>b__6_0));
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag9 = obj23 == null;
		object obj24 = !flag9;
		nint num7 = 0;
		if (obj24 == null)
		{
			((Func<T, float>)0)..ctor(obj21, (IntPtr)(nint)__ldftn(<>c__6<T>.<Shuffle>b__6_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v23 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+B8]");
		nint num8 = 0;
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag10 = obj26 == null;
		object obj27 = !flag10;
		nint num9 = 0;
		if (obj27 == null)
		{
			((Func<T, float>)0)..ctor(obj21, (IntPtr)(nint)__ldftn(<>c__6<T>.<Shuffle>b__6_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X0_v25 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+B8]");
		Func<T, float> func2 = (Func<T, float>)((nint)0 + (nint)8);
		func2..ctor((object)func, (IntPtr)(nint)__ldftn(<>c__6<T>.<Shuffle>b__6_0));
		keySelector = func;
		goto IL_073f;
		IL_04a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj28;
		obj21 = obj28;
		goto IL_04b7;
		IL_0440:
		obj28 = <>c__6<T>.<>9;
		object obj29 = (nint)0 + (nint)309;
		object obj30 = obj29 & 1;
		bool flag11 = obj30 == null;
		object obj31 = !flag11;
		nint num10 = 0;
		obj21 = <>c__6<T>.<>9;
		nint num11 = 0;
		if (obj31 == null)
		{
			goto IL_04a0;
		}
		goto IL_04b7;
		IL_02ad:
		return null;
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v46+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X0_v46] (should have been resolved before IL gen)");
		object obj32 = default(object);
		if (obj32 != null)
		{
			goto IL_0150;
		}
		goto IL_02ad;
		IL_0150:
		nint num12 = 0;
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v6 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+E4]");
			bool flag12 = (nint)0 == 0;
			nint num13 = 0;
			if (!flag12)
			{
				goto IL_01b8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v38 (Il2CppClass<ArraysExtensions+<>c__6`1<T>>)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj35 = !flag13;
			if (obj35 != null)
			{
				goto IL_01b8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj36 = (nint)0 + (nint)309;
		object obj37 = obj36 & 1;
		bool flag14 = obj37 == null;
		object obj38 = !flag14;
		nint num14 = 0;
		nint num15 = 0;
		if (obj38 != null)
		{
			goto IL_01fb;
		}
		goto IL_0341;
		IL_073f:
		IOrderedEnumerable<System.Int32Enum> source = Enumerable.OrderBy((IEnumerable<System.Int32Enum>)array, keySelector);
		return (List<T>)(object)Enumerable.ToList(source);
		IL_066c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v14+B8]");
		object obj39 = 0;
		obj28 = obj39;
		object obj40 = (nint)0 + (nint)309;
		object obj41 = obj40 & 1;
		bool flag15 = obj41 == null;
		num10 = 0;
		if (flag15)
		{
			goto IL_04a0;
		}
		obj21 = obj39;
		num11 = 0;
		goto IL_04b7;
		IL_0403:
		object obj42 = (nint)0 + (nint)309;
		object obj43 = obj42 & 1;
		bool flag16 = obj43 == null;
		num5 = 0;
		if (!flag16)
		{
			goto IL_0440;
		}
		goto IL_066c;
		IL_01b8:
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag17 = obj45 == null;
		num14 = 0;
		num15 = 0;
		if (!flag17)
		{
			goto IL_01fb;
		}
		goto IL_0341;
	}

	public static IEnumerable<T> PingPong<T>(T[] array, int maxIterations)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0170: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X2_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		IEnumerable<T> enumerable = default(IEnumerable<T>);
		if (enumerable != null)
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			<PingPong>d__7<T> <PingPong>d__ = (<PingPong>d__7<T>)((nint)0 + (nint)128);
			<PingPong>d__..ctor(8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			int <>1__state = (int)((nint)0 + (nint)128);
			((<PingPong>d__7<T>)enumerable)..ctor(<>1__state);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			object obj6 = (nint)0 + (nint)192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<PingPong>d__7`1<T>>)+80]");
			object obj7 = (nint)0 + (nint)192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj8 = maxIterations;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			return enumerable;
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public static IEnumerable<T> GetIEnumerable<T>(T[] array, int maxIterations)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_0170: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ X2_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		IEnumerable<T> enumerable = default(IEnumerable<T>);
		if (enumerable != null)
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			<GetIEnumerable>d__8<T> <GetIEnumerable>d__ = (<GetIEnumerable>d__8<T>)((nint)0 + (nint)128);
			<GetIEnumerable>d__..ctor(8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v9 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			int <>1__state = (int)((nint)0 + (nint)128);
			((<GetIEnumerable>d__8<T>)enumerable)..ctor(<>1__state);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			object obj6 = (nint)0 + (nint)192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @313E4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11 (Il2CppClass<ArraysExtensions+<GetIEnumerable>d__8`1<T>>)+80]");
			object obj7 = (nint)0 + (nint)192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj8 = maxIterations;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1750");
			return enumerable;
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public static bool IsSubsetOf<T>(IList<T> array, IList<T> otherArray)
	{
		//IL_0066: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_008e: Expected O, but got I4
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0129: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00b7: Expected I, but got O
		//IL_00d2: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		bool flag = array == null;
		bool result = false;
		nint num3;
		IEnumerable<T> enumerable2;
		nint num5;
		if (!flag)
		{
			IList<T> list = default(IList<T>);
			bool flag2 = list == null;
			result = false;
			if (!flag2)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X2_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v105 @ X1_v3 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				object obj = (nint)0 + (nint)309;
				object obj2 = obj & 1;
				bool flag3 = obj2 == null;
				object obj3 = !flag3;
				num3 = 0;
				if (obj3 == null)
				{
					IEnumerable<T> enumerable = Enumerable.Intersect((IEnumerable<T>)0, (IEnumerable<T>)0);
					num3 = (nint)enumerable;
				}
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0113;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v6-8]");
					if (0 == num3)
					{
						break;
					}
					obj5 += 16;
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_0113;
				}
				object obj6 = num4 + obj5;
				enumerable2 = (IEnumerable<T>)(obj6 + 312);
				num5 = 0;
				goto IL_01e0;
			}
		}
		goto IL_017a;
		IL_0113:
		enumerable2 = Enumerable.Intersect(array, (IEnumerable<T>)num3);
		num5 = unchecked((nint)null);
		goto IL_01e0;
		IL_017a:
		return result;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ X0_v8 (System.Collections.Generic.IEnumerable`1<T>)] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj9 = default(object);
		object obj7 = obj8 - obj9;
		bool flag4 = obj7 == null;
		result = flag4;
		goto IL_017a;
	}

	public static bool ContainsAnyOf<T>(IList<T> array, IList<T> otherArray)
	{
		//IL_001f: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_01c3: Expected I, but got O
		//IL_01d3: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		bool flag = array == null;
		object obj = !flag;
		if (obj != null)
		{
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			nint num = 0;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_010f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v6-8]");
				if (0 == num)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_010f;
			}
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X0_v13] (should have been resolved before IL gen)");
			object obj9 = default(object);
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0140;
			}
		}
		goto IL_01b5;
		IL_01b5:
		return false;
		IL_0140:
		IEnumerable<object> source = (IEnumerable<object>)Enumerable.Intersect(array, otherArray);
		return Enumerable.Any(source);
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ X0_v10] (should have been resolved before IL gen)");
		object obj11 = default(object);
		if (obj11 != null)
		{
			goto IL_0140;
		}
		goto IL_01b5;
	}

	public static void RemoveList<T>(IList<T> array, IEnumerable<T> subtractingArray)
	{
		//IL_0033: Expected O, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_08a5: Expected I, but got O
		//IL_08b5: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_0165: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_08f2: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0234: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_092e: Expected I, but got O
		//IL_093e: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0309: Expected I, but got O
		//IL_09b4: Expected O, but got I
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_0275: Expected O, but got I
		//IL_097b: Expected O, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_083b: Expected O, but got I4
		//IL_03bb: Expected I, but got O
		//IL_03cb: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_049a: Expected I, but got O
		//IL_0a2a: Expected O, but got I
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0406: Expected O, but got I
		//IL_0701: Expected O, but got I4
		//IL_070a: Expected O, but got I4
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_0b89: Expected O, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0437: Expected O, but got I
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_072b: Expected I, but got O
		//IL_073b: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0528: Expected O, but got I4
		//IL_07d6: Expected I, but got O
		//IL_0a67: Expected I, but got O
		//IL_0a77: Expected O, but got I
		//IL_0bcb: Expected O, but got I
		//IL_0776: Expected O, but got I
		//IL_05f5: Expected I, but got O
		//IL_0af3: Expected O, but got I
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0b1b: Expected O, but got I4
		//IL_0569: Expected O, but got I
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_0c3f: Expected I, but got O
		//IL_0c4f: Expected O, but got I
		//IL_0ab4: Expected O, but got I
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_079f: Expected O, but got I
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_0657: Expected O, but got I
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_0b46: Expected O, but got I
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		if (array == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
		}
		nint num2 = (nint)array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0121;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X10_v42-8]");
			object obj6 = -num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X10_v42-8]");
			if (0 == num)
			{
				break;
			}
			obj7 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v7 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			obj4 = -1;
			obj6 = obj4 - 1;
			bool flag4 = obj6 == null;
			flag3 = (nint)obj4 != 1;
			flag2 = flag3;
			obj5 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0121;
		}
		obj4 = obj5;
		object obj8 = num2 + obj5;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v67+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v67] (should have been resolved before IL gen)");
		object obj11 = default(object);
		bool flag5 = obj11 == null;
		flag3 = flag2;
		obj7 = obj5;
		if (!flag5)
		{
			goto IL_01e3;
		}
		return;
		IL_09a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v27+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v413 @ X0_v27] (should have been resolved before IL gen)");
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		IEnumerable<T> enumerable = default(IEnumerable<T>);
		object obj16 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		object obj23 = default(object);
		IntPtr intPtr3 = default(IntPtr);
		object obj38 = default(object);
		IEnumerable<T> enumerable2;
		object obj31;
		nint num4;
		while (true)
		{
			if (enumerable != null)
			{
				nint num3 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_048b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				bool flag6 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v32-8]");
					object obj6 = 0 - obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v32-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					obj7 = obj13 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					obj4 = -1;
					obj6 = obj4 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj4 != 1;
					flag6 = flag3;
					obj13 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_048b;
				}
				obj4 = obj13;
				object obj14 = num3 + obj13;
				object obj15 = obj14 + 312;
				flag3 = flag6;
				obj7 = obj13;
				goto IL_0a19;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_05e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0add;
			IL_037d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_038c;
			IL_038c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X0_v43+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v43] (should have been resolved before IL gen)");
			obj10 = obj16;
			continue;
			IL_0add:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v734 @ X0_v38] (should have been resolved before IL gen)");
			object obj17 = (nint)0 + (nint)309;
			object obj18 = obj17 & 1;
			bool flag7 = obj18 == null;
			object obj19 = !flag7;
			nint num5 = 0;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				num5 = intPtr2;
			}
			nint num6 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v40 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X10_v22-8]");
					object obj6 = -num5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X10_v22-8]");
					if (0 == num5)
					{
						break;
					}
					obj7 += 16;
					obj4--;
					obj6 = obj4 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj4 != 1;
					if (flag3)
					{
						continue;
					}
					goto IL_037d;
				}
				obj4 = obj7 + 6;
				object obj20 = num6 + obj4;
				object obj21 = obj20 + 312;
				goto IL_038c;
			}
			goto IL_037d;
			IL_048b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0a19;
			IL_0a19:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v33+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v591 @ X0_v33] (should have been resolved before IL gen)");
			object obj22 = obj23 & 1;
			if (obj22 != null)
			{
				if (enumerable != null)
				{
					object obj24 = (nint)0 + (nint)309;
					object obj25 = obj24 & 1;
					bool flag8 = obj25 == null;
					object obj26 = !flag8;
					nint num7 = 0;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num7 = intPtr3;
					}
					nint num8 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v34 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					object obj27 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v34 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_05e6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v34 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
					object obj28 = (nint)0 + (nint)8;
					bool flag9 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X10_v27-8]");
						object obj6 = -num7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X10_v27-8]");
						if (0 == num7)
						{
							break;
						}
						obj7 = obj28 + 16;
						obj27--;
						obj6 = obj27 - 1;
						bool flag4 = obj6 == null;
						flag3 = (nint)obj27 != 1;
						flag9 = flag3;
						obj28 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_05e6;
					}
					object obj29 = num8 + obj28;
					object obj30 = obj29 + 312;
					flag3 = flag9;
					obj7 = obj28;
					goto IL_0add;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
			}
			enumerable2 = enumerable;
			obj31 = 0;
			object obj32 = 0;
			while (true)
			{
				if (enumerable2 == null)
				{
					goto IL_0b6f;
				}
				object obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num9 = (nint)enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07c7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj34 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X10_v9-8]");
					if (0 == (nint)obj33)
					{
						break;
					}
					obj7 = obj34 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					obj4 = -1;
					bool flag10 = (nint)obj4 != 1;
					obj34 = obj7;
					if (flag10)
					{
						continue;
					}
					goto IL_07c7;
				}
				obj4 = obj34;
				object obj35 = num9 + obj34;
				object obj36 = obj35 + 312;
				obj7 = obj34;
				goto IL_0bbb;
				IL_0b6f:
				bool flag11 = obj32 == null;
				object obj37 = !flag11;
				if (obj37 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)obj10 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj32 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj31 = obj38;
				continue;
				IL_07c7:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num4 = unchecked((nint)null);
				goto IL_0bbb;
				IL_0bbb:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X0_v7+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v656 @ X0_v7] (should have been resolved before IL gen)");
				goto IL_0b6f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		enumerable2 = enumerable;
		obj31 = 0;
		goto IL_091b;
		IL_0121:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v64+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v235 @ X0_v64] (should have been resolved before IL gen)");
		object obj39 = default(object);
		bool flag12 = obj39 == null;
		object obj40 = !flag12;
		num4 = unchecked((nint)null);
		if (obj40 == null)
		{
			return;
		}
		goto IL_01e3;
		IL_091b:
		throw new NullReferenceException();
		IL_01e3:
		if (subtractingArray == null)
		{
			goto IL_091b;
		}
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag13 = obj42 == null;
		object obj43 = !flag13;
		nint num10 = 0;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr4 = default(IntPtr);
			num10 = intPtr4;
		}
		nint num11 = (nint)subtractingArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02fa;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
		object obj44 = (nint)0 + (nint)8;
		bool flag14 = flag3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X10_v37-8]");
			object obj6 = -num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X10_v37-8]");
			if (0 == num10)
			{
				break;
			}
			obj7 = obj44 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
			obj4 = -1;
			obj6 = obj4 - 1;
			bool flag4 = obj6 == null;
			flag3 = (nint)obj4 != 1;
			flag14 = flag3;
			obj44 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_02fa;
		}
		obj4 = obj44;
		object obj45 = num11 + obj44;
		object obj46 = obj45 + 312;
		flag3 = flag14;
		obj7 = obj44;
		goto IL_09a4;
		IL_02fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_09a4;
	}

	public static IEnumerable<T> TakeLast<T>(IEnumerable<T> source, int n)
	{
		//IL_0039: Expected O, but got I
		//IL_004f: Expected I4, but got O
		List<DateTime> list = Enumerable.ToList((IEnumerable<DateTime>)source);
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2 (System.Collections.Generic.List`1<System.DateTime>)+18]");
			object obj = -n;
			object obj2 = ~obj;
			int count = obj & obj2;
			return (IEnumerable<T>)Enumerable.Skip(list, count);
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public static void ForEach<T>(IEnumerable<T> enumeration, Action<T> action)
	{
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0638: Expected I, but got O
		//IL_0648: Expected O, but got I
		//IL_0142: Expected I, but got O
		//IL_06be: Expected O, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_0685: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0598: Expected O, but got I4
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0266: Expected I, but got O
		//IL_0734: Expected O, but got I
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_0440: Expected O, but got I4
		//IL_0450: Expected O, but got I
		//IL_0459: Expected O, but got I4
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0856: Expected O, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_047a: Expected I, but got O
		//IL_048a: Expected O, but got I
		//IL_02cc: Expected O, but got I
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I4
		//IL_0525: Expected I, but got O
		//IL_0771: Expected I, but got O
		//IL_0781: Expected O, but got I
		//IL_0898: Expected O, but got I
		//IL_04c5: Expected O, but got I
		//IL_03c9: Expected I, but got O
		//IL_07f8: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_07be: Expected O, but got I
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0366: Expected O, but got I
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		if (enumeration == null)
		{
			goto IL_0625;
		}
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
		}
		nint num2 = (nint)enumeration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0133;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v29-8]");
			object obj6 = -num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v29-8]");
			if (0 == num)
			{
				break;
			}
			obj7 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v16 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
			obj4 = -1;
			obj6 = obj4 - 1;
			bool flag4 = obj6 == null;
			flag3 = (nint)obj4 != 1;
			flag2 = flag3;
			obj5 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0133;
		}
		obj4 = obj5;
		object obj8 = num2 + obj5;
		object obj9 = obj8 + 312;
		flag3 = flag2;
		obj7 = obj5;
		goto IL_06ae;
		IL_0625:
		throw new NullReferenceException();
		IL_06ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v23+8]");
		Action<T> action2 = (Action<T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ X0_v23] (should have been resolved before IL gen)");
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		IEnumerable<T> enumerable = default(IEnumerable<T>);
		object obj15 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		object obj29 = default(object);
		Action<T> action4 = default(Action<T>);
		IEnumerable<T> enumerable2;
		object obj22;
		Action<T> action3 = default(Action<T>);
		nint num4;
		while (true)
		{
			if (enumerable != null)
			{
				nint num3 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0257;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj11 = (nint)0 + (nint)8;
				bool flag5 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v24-8]");
					object obj6 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v24-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj7 = obj11 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					obj4 = -1;
					obj6 = obj4 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj4 != 1;
					flag5 = flag3;
					obj11 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_0257;
				}
				obj4 = obj11;
				object obj12 = num3 + obj11;
				object obj13 = obj12 + 312;
				flag3 = flag5;
				obj7 = obj11;
				goto IL_0723;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_0257:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0723;
			IL_03ba:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_07e7;
			IL_0723:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v29+8]");
			action2 = (Action<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v29] (should have been resolved before IL gen)");
			object obj14 = obj15 & 1;
			if (obj14 != null)
			{
				if (enumerable != null)
				{
					object obj16 = (nint)0 + (nint)309;
					object obj17 = obj16 & 1;
					bool flag6 = obj17 == null;
					object obj18 = !flag6;
					nint num5 = 0;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num5 = intPtr2;
					}
					nint num6 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03ba;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
					object obj19 = (nint)0 + (nint)8;
					bool flag7 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X10_v19-8]");
						object obj6 = -num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X10_v19-8]");
						if (0 == num5)
						{
							break;
						}
						obj7 = obj19 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
						obj4 = -1;
						obj6 = obj4 - 1;
						bool flag4 = obj6 == null;
						flag3 = (nint)obj4 != 1;
						flag7 = flag3;
						obj19 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_03ba;
					}
					obj4 = obj19;
					object obj20 = num6 + obj19;
					object obj21 = obj20 + 312;
					flag3 = flag7;
					obj7 = obj19;
					goto IL_07e7;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
			}
			enumerable2 = enumerable;
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v29+8]");
			action3 = (Action<T>)0;
			object obj23 = 0;
			while (true)
			{
				if (enumerable2 == null)
				{
					goto IL_083c;
				}
				object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num7 = (nint)enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0516;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj25 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X10_v7-8]");
					if (0 == (nint)obj24)
					{
						break;
					}
					obj7 = obj25 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v7 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					obj4 = -1;
					bool flag8 = (nint)obj4 != 1;
					obj25 = obj7;
					if (flag8)
					{
						continue;
					}
					goto IL_0516;
				}
				obj4 = obj25;
				object obj26 = num7 + obj25;
				object obj27 = obj26 + 312;
				obj7 = obj25;
				goto IL_0888;
				IL_083c:
				bool flag9 = obj23 == null;
				object obj28 = !flag9;
				if (obj28 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)action3 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj23 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj22 = obj29;
				continue;
				IL_0516:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num4 = unchecked((nint)null);
				goto IL_0888;
				IL_0888:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v4+8]");
				action3 = (Action<T>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v4] (should have been resolved before IL gen)");
				goto IL_083c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_07e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v34+8]");
			action2 = (Action<T>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v34] (should have been resolved before IL gen)");
			if (action3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X1_v2 (System.Action`1<T>)+18] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v34+8]");
				num4 = 0;
				action2 = action4;
				continue;
			}
			NullReferenceException ex4 = new NullReferenceException();
			break;
		}
		enumerable2 = enumerable;
		obj22 = 0;
		action3 = action2;
		goto IL_0625;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		goto IL_06ae;
	}

	public unsafe static T MaxBy<T>(IEnumerable<T> source, Func<T, IComparable> func)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		nint num2 = 0;
		<>c__DisplayClass14_0<T> <>c__DisplayClass14_2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass14_0<T> <>c__DisplayClass14_ = default(<>c__DisplayClass14_0<T>);
			<>c__DisplayClass14_..ctor();
			<>c__DisplayClass14_2 = <>c__DisplayClass14_;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass14_0<T> <>c__DisplayClass14_3 = default(<>c__DisplayClass14_0<T>);
			<>c__DisplayClass14_3..ctor();
			bool flag2 = <>c__DisplayClass14_3 == null;
			object obj3 = !flag2;
			<>c__DisplayClass14_2 = <>c__DisplayClass14_3;
			if (obj3 == null)
			{
				throw new NullReferenceException();
			}
		}
		object obj4 = <>c__DisplayClass14_2 + 16;
		obj4 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (source != null)
		{
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag3 = obj6 == null;
			object obj7 = !flag3;
			nint num3 = 0;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<T, T, T> func2 = default(Func<T, T, T>);
			func2..ctor((object)<>c__DisplayClass14_2, (IntPtr)(nint)__ldftn(<>c__DisplayClass14_0<T>.<MaxBy>b__0));
			return Enumerable.Aggregate(source, func2);
		}
		return (T)null;
	}

	public unsafe static T MinBy<T>(IEnumerable<T> source, Func<T, IComparable> func)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		nint num2 = 0;
		object obj3;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass15_0<T> <>c__DisplayClass15_ = default(<>c__DisplayClass15_0<T>);
			<>c__DisplayClass15_..ctor();
			obj3 = <>c__DisplayClass15_;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass15_0<T> <>c__DisplayClass15_2 = default(<>c__DisplayClass15_0<T>);
			<>c__DisplayClass15_2..ctor();
			bool flag2 = <>c__DisplayClass15_2 == null;
			object obj4 = !flag2;
			obj3 = <>c__DisplayClass15_2;
			if (obj4 == null)
			{
				throw new NullReferenceException();
			}
		}
		object obj5 = obj3 + 16;
		obj5 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (source != null)
		{
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag3 = obj7 == null;
			object obj8 = !flag3;
			nint num3 = 0;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, object, object> func2 = default(Func<object, object, object>);
			func2..ctor(obj3, (IntPtr)(nint)__ldftn(<>c__DisplayClass15_0<T>.<MinBy>b__0));
			return (T)Enumerable.Aggregate((IEnumerable<object>)source, func2);
		}
		return (T)null;
	}

	public unsafe static int FindIndex<T>(IEnumerable<T> items, Func<T, bool> predicate)
	{
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0831: Expected I, but got O
		//IL_0841: Expected O, but got I
		//IL_0142: Expected I, but got O
		//IL_08c6: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_0876: Expected O, but got I
		//IL_088d: Expected O, but got I
		//IL_07b0: Expected O, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0a51: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_026b: Expected I, but got O
		//IL_094f: Expected O, but got I
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I
		//IL_04f8: Expected O, but got I4
		//IL_0520: Expected O, but got I
		//IL_0529: Expected O, but got I4
		//IL_08fe: Expected O, but got I
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Expected O, but got Unknown
		//IL_0b96: Expected O, but got I4
		//IL_0ba3: Expected I4, but got I8
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0655: Expected O, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_06f0: Expected I, but got O
		//IL_056b: Expected I4, but got I8
		//IL_02d1: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I4
		//IL_0b12: Expected O, but got I
		//IL_0690: Expected O, but got I
		//IL_0a90: Expected O, but got I4
		//IL_099c: Expected O, but got I
		//IL_0ade: Expected O, but got I
		//IL_03ce: Expected I, but got O
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_033a: Expected O, but got I
		//IL_069e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a3: Expected O, but got Unknown
		//IL_06b9: Expected O, but got I
		//IL_09d1: Expected O, but got I
		//IL_09e8: Expected O, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_044d: Expected O, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_05a8: Expected O, but got I4
		//IL_05c9: Expected O, but got I4
		//IL_05e2: Expected O, but got I4
		//IL_061b: Expected O, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_036b: Expected O, but got I
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0483: Expected O, but got I4
		if (items == null)
		{
			goto IL_081e;
		}
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
		}
		nint num2 = (nint)items;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v17 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v17 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0133;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v17 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj6 = default(object);
		object obj8 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v31-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v31-8]");
			object obj7 = -num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v31-8]");
			if (0 == num)
			{
				break;
			}
			obj8 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v17 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
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
			goto IL_0133;
		}
		obj4 = obj5;
		object obj9 = num2 + obj5;
		object obj10 = obj9 + 312;
		flag3 = flag2;
		obj8 = obj5;
		goto IL_08b6;
		IL_0760:
		NullReferenceException ex = new NullReferenceException();
		object obj11;
		obj6 = obj11;
		object obj13 = default(object);
		object obj12 = obj13;
		nint num4;
		nint num3 = num4;
		object obj14;
		obj8 = obj14;
		Func<T, bool> func2 = default(Func<T, bool>);
		Func<T, bool> func = func2;
		goto IL_0796;
		IL_08b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v26+8]");
		func = (Func<T, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v262 @ X0_v26] (should have been resolved before IL gen)");
		if (obj13 == null)
		{
			goto IL_04c9;
		}
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj11 = obj6;
		object obj16 = obj13;
		num4 = num3;
		obj14 = obj8;
		int num5 = 0;
		object obj22 = default(object);
		object obj25;
		object obj34 = default(object);
		int result2 = default(int);
		object obj36 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		nint num6;
		object obj26;
		Func<T, bool> func3 = default(Func<T, bool>);
		while (true)
		{
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v24+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v24+12E]");
			if ((nint)0 == 0)
			{
				goto IL_025c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v24+B0]");
			object obj18 = (nint)0 + (nint)8;
			bool flag5 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v26-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v26-8]");
				object obj7 = 0 - obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v26-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj14 = obj18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v24+12E]");
				obj4 = -1;
				obj7 = obj4 - 1;
				bool flag4 = obj7 == null;
				flag3 = (nint)obj4 != 1;
				flag5 = flag3;
				obj18 = obj14;
				if (flag3)
				{
					continue;
				}
				goto IL_025c;
			}
			obj4 = obj18;
			object obj19 = obj17 + obj18;
			object obj20 = obj19 + 312;
			flag3 = flag5;
			obj14 = obj18;
			goto IL_093e;
			IL_0a11:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v674 @ X0_v38] (should have been resolved before IL gen)");
			if (func3 == null)
			{
				goto IL_0760;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v2 (System.Func`2<T, System.Boolean>)+28]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X1_v2 (System.Func`2<T, System.Boolean>)+18] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			bool flag6 = obj21 == null;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				num5++;
				bool flag7 = obj13 == null;
				object obj24 = !flag7;
				obj6 = obj11;
				obj12 = obj13;
				obj8 = obj14;
				func = func2;
				obj16 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v2 (System.Func`2<T, System.Boolean>)+28]");
				num4 = 0;
				if (obj24 != null)
				{
					continue;
				}
				goto IL_04c9;
			}
			bool flag8 = obj13 == null;
			obj25 = obj13;
			num6 = (nint)(&obj25);
			obj6 = obj11;
			obj26 = 0;
			obj12 = obj13;
			obj8 = obj14;
			object obj27 = obj13;
			object obj28 = 0;
			obj25 = obj13;
			nint num7 = (nint)(&obj25);
			obj26 = 0;
			object obj29 = obj15;
			object obj30 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X1_v2 (System.Func`2<T, System.Boolean>)+28]");
			nint num8 = 0;
			func3 = func2;
			int result = num5;
			object obj31 = 0;
			if (!flag8)
			{
				goto IL_0629;
			}
			goto IL_0a76;
			IL_0b7c:
			bool flag9 = obj25 == null;
			object obj32 = !flag9;
			num5 = -1;
			obj27 = obj25;
			if (obj32 != null)
			{
				goto IL_0629;
			}
			num7 = num6;
			obj11 = obj6;
			obj29 = obj15;
			obj30 = obj12;
			num8 = num3;
			obj14 = obj8;
			result = -1;
			obj31 = obj28;
			goto IL_0a76;
			IL_0a76:
			bool flag10 = obj31 == null;
			object obj33 = !flag10;
			num6 = num7;
			obj6 = obj11;
			obj15 = obj29;
			obj12 = obj30;
			num3 = num8;
			obj8 = obj14;
			if (obj33 == null)
			{
				return result;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)func3 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj28 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj26 = obj34;
				goto IL_0b7c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
			IL_025c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_093e;
			IL_093e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v33+8]");
			func = (Func<T, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v526 @ X0_v33] (should have been resolved before IL gen)");
			object obj35 = obj36 & 1;
			if (obj35 != null)
			{
				if (obj13 == null)
				{
					break;
				}
				object obj37 = (nint)0 + (nint)309;
				object obj38 = obj37 & 1;
				bool flag11 = obj38 == null;
				object obj39 = !flag11;
				nint num9 = 0;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					num9 = intPtr2;
				}
				object obj40 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v30+12E]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v30+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03bf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v30+B0]");
				object obj41 = (nint)0 + (nint)8;
				bool flag12 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X10_v21-8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X10_v21-8]");
					object obj7 = -num9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X10_v21-8]");
					if (0 == num9)
					{
						break;
					}
					obj14 = obj41 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v30+12E]");
					obj4 = -1;
					obj7 = obj4 - 1;
					bool flag4 = obj7 == null;
					flag3 = (nint)obj4 != 1;
					flag12 = flag3;
					obj41 = obj14;
					if (flag3)
					{
						continue;
					}
					goto IL_03bf;
				}
				obj4 = obj41;
				object obj42 = obj40 + obj41;
				object obj43 = obj42 + 312;
				flag3 = flag12;
				obj14 = obj41;
				goto IL_0a11;
			}
			obj25 = obj13;
			num6 = (nint)(&obj25);
			obj6 = obj11;
			obj26 = 0;
			obj12 = obj16;
			num3 = num4;
			obj8 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v33+8]");
			func3 = (Func<T, bool>)0;
			obj28 = 0;
			goto IL_0b7c;
			IL_03bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0a11;
			IL_0629:
			object obj44 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj45 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10+12E]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10+B0]");
			object obj46 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X10_v10-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X10_v10-8]");
				if (0 == (nint)obj44)
				{
					break;
				}
				obj8 = obj46 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v10+12E]");
				obj4 = -1;
				bool flag13 = (nint)obj4 != 1;
				obj46 = obj8;
				if (flag13)
				{
					continue;
				}
				goto IL_06e1;
			}
			obj4 = obj46;
			object obj47 = obj45 + obj46;
			object obj48 = obj47 + 312;
			num8 = num3;
			obj8 = obj46;
			goto IL_0b02;
			IL_0b02:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v19+8]");
			func3 = (Func<T, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v19] (should have been resolved before IL gen)");
			num7 = num6;
			obj11 = obj6;
			obj29 = obj15;
			obj30 = obj12;
			obj14 = obj8;
			result = num5;
			obj31 = obj28;
			goto IL_0a76;
			IL_06e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num8 = unchecked((nint)null);
			goto IL_0b02;
		}
		NullReferenceException ex3 = new NullReferenceException();
		obj6 = obj11;
		obj12 = obj13;
		num3 = num4;
		obj8 = obj14;
		goto IL_0796;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = unchecked((nint)null);
		goto IL_08b6;
		IL_04c9:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0796;
		IL_081e:
		throw new NullReferenceException();
		IL_0796:
		obj25 = obj13;
		num6 = (nint)(&obj25);
		obj26 = 0;
		func3 = func;
		goto IL_081e;
	}

	public unsafe static IEnumerable<IEnumerable<T>> GetPowerSet<T>(List<T> list)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		nint num2 = 0;
		object obj4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass17_0<T> <>c__DisplayClass17_ = default(<>c__DisplayClass17_0<T>);
			<>c__DisplayClass17_..ctor();
			bool flag2 = <>c__DisplayClass17_ == null;
			object obj3 = !flag2;
			obj4 = <>c__DisplayClass17_;
			if (obj3 != null)
			{
				goto IL_0134;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass17_0<T> <>c__DisplayClass17_2 = default(<>c__DisplayClass17_0<T>);
			<>c__DisplayClass17_2..ctor();
			bool flag3 = <>c__DisplayClass17_2 == null;
			obj4 = <>c__DisplayClass17_2;
			if (!flag3)
			{
				goto IL_0134;
			}
		}
		goto IL_0230;
		IL_0230:
		return (IEnumerable<IEnumerable<T>>)new NullReferenceException();
		IL_0134:
		object obj5 = obj4 + 16;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj5;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4+18]");
			int count = 1 << 0;
			IEnumerable<int> source = Enumerable.Range(0, count);
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag4 = obj8 == null;
			object obj9 = !flag4;
			nint num3 = 0;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<int, object> func = default(Func<int, object>);
			func..ctor(obj4, (IntPtr)(nint)__ldftn(<>c__DisplayClass17_0<T>.<GetPowerSet>b__0));
			return (IEnumerable<IEnumerable<T>>)Enumerable.Select(source, func);
		}
		goto IL_0230;
	}

	public unsafe static bool RemoveLast<T>(List<T> list, T item)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0154: Expected O, but got Ref
		//IL_0188: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01ba: Expected O, but got Ref
		//IL_01d3: Expected O, but got I4
		//IL_0068: Expected O, but got I8
		//IL_0082: Expected O, but got I4
		//IL_0224: Expected O, but got Ref
		//IL_0232: Expected O, but got Ref
		//IL_0256: Expected O, but got I8
		//IL_0270: Expected O, but got I4
		//IL_027e: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00e7: Expected I4, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+FC]");
		List<T> list2 = (List<T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+FC]");
		object obj4 = (nint)0 + (nint)15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default(object);
		object obj6 = (ref *(?*)(&obj7)) - (ref *(?*)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+28]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+28]");
		object obj8 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+28]");
		object obj9 = 0 & obj8;
		bool flag2 = (nint)obj9 < 0;
		T val = (T)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		bool flag3 = flag == flag2;
		object obj10 = !flag3;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			T val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		if (list != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<T>)+28]");
			object obj12 = 0 & 0x80000000L;
			bool flag4 = obj12 == null;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				obj6 = obj6;
			}
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 64));
			object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 68));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X1_v3 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-44]");
			object obj16 = 0 & 0x80000000L;
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			list2 = list;
			T val2 = (T)0;
			if (obj17 == null)
			{
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ X2_v5 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				list2 = (List<T>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-44]");
				val2 = (T)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-44]");
				object obj19 = ~(nint)0;
				return (byte)(obj19 >> 31) != 0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		bool result = default(bool);
		return result;
	}

	public unsafe static string JoinToString<T>(IEnumerable<T> list, string separator = ", ", string prefix = "[", string suffix = "]", Func<T, string> transform = null)
	{
		//IL_0024: Expected O, but got I4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		//IL_00d0: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_0252: Expected O, but got I4
		//IL_01c4: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_05e6: Expected O, but got I
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_0127: Expected O, but got I
		//IL_0149: Expected O, but got I4
		//IL_0ed1: Expected I, but got O
		//IL_028a: Expected O, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_0c6d: Expected O, but got I4
		//IL_0f66: Expected O, but got I
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected O, but got Unknown
		//IL_0f8d: Expected O, but got I4
		//IL_0f95: Expected O, but got Ref
		//IL_064f: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0f16: Expected O, but got I
		//IL_0f2d: Expected O, but got I
		//IL_0d02: Expected O, but got I
		//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0c91: Expected O, but got I
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		//IL_0cb9: Expected O, but got I4
		//IL_06f0: Expected I, but got O
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_0370: Expected O, but got I4
		//IL_0d9a: Expected O, but got Ref
		//IL_0da3: Expected O, but got I4
		//IL_072d: Expected I, but got O
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_0690: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0410: Expected O, but got I4
		//IL_1002: Expected O, but got I
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected O, but got Unknown
		//IL_0778: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_047c: Expected O, but got I4
		//IL_0a39: Expected O, but got Ref
		//IL_0a42: Expected O, but got I4
		//IL_0a63: Expected O, but got I4
		//IL_0a6c: Expected O, but got I4
		//IL_0a74: Expected O, but got Ref
		//IL_0a85: Expected O, but got I4
		//IL_0abe: Expected O, but got I4
		//IL_0ac7: Expected O, but got I4
		//IL_0faa: Expected O, but got I
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_04b5: Expected O, but got I
		//IL_04cd: Expected O, but got I
		//IL_04d3: Expected O, but got I
		//IL_1153: Expected O, but got I4
		//IL_0819: Expected I, but got O
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected O, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0af1: Expected I, but got O
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_07b9: Expected O, but got I
		//IL_0872: Expected O, but got I
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got Unknown
		//IL_089a: Expected O, but got I4
		//IL_11dd: Expected O, but got I
		//IL_0b3c: Expected O, but got I
		//IL_103f: Expected I, but got O
		//IL_0c10: Expected O, but got I4
		//IL_11a9: Expected O, but got I
		//IL_0e19: Expected O, but got I4
		//IL_0e32: Expected O, but got I4
		//IL_0ba9: Expected I, but got O
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Expected O, but got Unknown
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_10dc: Expected O, but got I
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected O, but got Unknown
		//IL_110e: Expected O, but got I4
		//IL_08db: Expected O, but got I
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4f: Expected O, but got Unknown
		//IL_1084: Expected O, but got I
		//IL_109b: Expected O, but got I
		//IL_0e89: Expected O, but got I4
		//IL_097c: Expected I, but got O
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_0a10: Expected O, but got I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected O, but got Unknown
		//IL_091c: Expected O, but got I
		bool flag = transform == null;
		object obj = !flag;
		IEnumerable<T> enumerable = null;
		string text = separator;
		string text2 = suffix;
		string text3 = prefix;
		enumerable = null;
		Func<T, string> func = transform;
		nint num3;
		nint num4;
		if (obj == null)
		{
			nint num = 0;
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v69 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+E4]");
				bool flag2 = (nint)0 == 0;
				nint num2 = 0;
				if (!flag2)
				{
					goto IL_00c4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v97 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00c4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag4 = obj6 == null;
			object obj7 = !flag4;
			num3 = 0;
			num4 = 0;
			if (obj7 != null)
			{
				goto IL_0107;
			}
			goto IL_0206;
		}
		goto IL_0531;
		IL_0ebe:
		throw new NullReferenceException();
		IL_03ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func2 = default(Func<object, object>);
		object obj8;
		func2..ctor(obj8, (IntPtr)(nint)__ldftn(<>c__19<T>.<JoinToString>b__19_0));
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		nint num5 = 0;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v82 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+B8]");
		nint num6 = 0;
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag6 = obj13 == null;
		object obj14 = !flag6;
		nint num7 = 0;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v84 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+B8]");
		object obj15 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		text = (string)(object)func2;
		text2 = (string)0;
		text3 = (string)0;
		func = (Func<T, string>)(object)func2;
		goto IL_0531;
		IL_039b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object <>;
		obj8 = <>;
		nint num9;
		nint num8 = num9;
		goto IL_03ba;
		IL_0323:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X0_v91 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+B8]");
		num9 = 0;
		<> = <>c__19<T>.<>9;
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		nint num10 = 0;
		obj8 = <>c__19<T>.<>9;
		num8 = num9;
		nint num11 = 0;
		if (obj18 == null)
		{
			goto IL_039b;
		}
		goto IL_03ba;
		IL_00c4:
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag8 = obj20 == null;
		num3 = 0;
		num4 = 0;
		if (!flag8)
		{
			goto IL_0107;
		}
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v96+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v73+8]");
		func = (Func<T, string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v73+8]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		text = separator;
		text2 = suffix;
		text3 = prefix;
		if (obj22 == null)
		{
			goto IL_0278;
		}
		goto IL_0531;
		IL_0107:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v101 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+B8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v80 (Il2CppStaticFields<ArraysExtensions+<>c__19`1<T>>)+8]");
		func = (Func<T, string>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v80 (Il2CppStaticFields<ArraysExtensions+<>c__19`1<T>>)+8]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		text = separator;
		text2 = suffix;
		text3 = prefix;
		if (obj23 == null)
		{
			goto IL_0278;
		}
		goto IL_0531;
		IL_0278:
		nint num13 = 0;
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v71 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+E4]");
			bool flag11 = (nint)0 == 0;
			nint num14 = 0;
			if (!flag11)
			{
				goto IL_02e0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v75 (Il2CppClass<ArraysExtensions+<>c__19`1<T>>)+E4]");
			bool flag12 = (nint)0 == 0;
			object obj26 = !flag12;
			if (obj26 != null)
			{
				goto IL_02e0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag13 = obj28 == null;
		object obj29 = !flag13;
		nint num15 = 0;
		nint num16 = 0;
		if (obj29 != null)
		{
			goto IL_0323;
		}
		goto IL_0cd3;
		IL_0f56:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v32+8]");
		string text4 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v437 @ X0_v32] (should have been resolved before IL gen)");
		string text5 = (string)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
		object obj30 = 1;
		object obj31 = (object)(&enumerable);
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		bool flag15 = default(bool);
		object obj33 = default(object);
		object obj35 = default(object);
		object obj37 = default(object);
		object obj51 = default(object);
		StringBuilder stringBuilder2 = default(StringBuilder);
		string text8 = default(string);
		IEnumerable<T> enumerable6 = default(IEnumerable<T>);
		string text9 = default(string);
		object obj56 = default(object);
		string result = default(string);
		IntPtr intPtr = default(IntPtr);
		object obj39;
		object obj58;
		IEnumerable<T> enumerable3;
		while (true)
		{
			if (enumerable2 != null)
			{
				nint num17 = (nint)enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07fd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj32 = (nint)0 + (nint)8;
				bool flag14 = flag15;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v24-8]");
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v24-8]");
					object obj34 = 0 - text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X10_v24-8]");
					if (0 == (nint)text5)
					{
						break;
					}
					obj35 = obj32 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					num8 = -1;
					obj34 = num8 - 1;
					bool flag16 = obj34 == null;
					flag15 = num8 != 1;
					flag14 = flag15;
					obj32 = obj35;
					if (flag15)
					{
						continue;
					}
					goto IL_07fd;
				}
				num8 = (nint)obj32;
				object obj36 = num17 + obj32;
				obj37 = obj36 + 312;
				flag15 = flag14;
				obj35 = obj32;
				goto IL_0fea;
			}
			NullReferenceException ex = new NullReferenceException();
			enumerable3 = enumerable2;
			break;
			IL_11cd:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v23+8]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v759 @ X0_v23] (should have been resolved before IL gen)");
			object obj38 = obj39;
			object obj40 = obj33;
			object obj41 = obj30;
			object obj42 = obj35;
			IEnumerable<T> enumerable4 = enumerable3;
			string text6 = text5;
			object obj44;
			object obj43 = obj44;
			object obj46;
			object obj45 = obj46;
			goto IL_1139;
			IL_0ad5:
			object obj47 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			IEnumerable<T> enumerable5;
			nint num18 = (nint)enumerable5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
			num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0b8d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
			object obj48 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X10_v9-8]");
				obj33 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X10_v9-8]");
				if (0 == (nint)obj47)
				{
					break;
				}
				obj35 = obj48 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v13 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				num8 = -1;
				bool flag17 = num8 != 1;
				obj48 = obj35;
				if (flag17)
				{
					continue;
				}
				goto IL_0b8d;
			}
			num8 = (nint)obj48;
			object obj49 = num18 + obj48;
			object obj50 = obj49 + 312;
			obj35 = obj48;
			string text7 = text3;
			goto IL_11cd;
			IL_10c4:
			obj31 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v43+8]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v846 @ X0_v43] (should have been resolved before IL gen)");
			object obj52 = obj30 & 1;
			bool flag18 = obj52 == null;
			object obj53 = !flag18;
			if (obj53 == null)
			{
				StringBuilder stringBuilder = stringBuilder2.Append(separator);
				text4 = separator;
				text3 = null;
			}
			if (func != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X23_v2 (System.Func`2<T, System.String>)+18] (should have been resolved before IL gen)");
				StringBuilder stringBuilder3 = stringBuilder2.Append(text8);
				obj30 = 0;
				text4 = text8;
				text3 = null;
				continue;
			}
			NullReferenceException ex2 = new NullReferenceException();
			enumerable3 = enumerable6;
			break;
			IL_1139:
			while (true)
			{
				bool flag19 = obj45 == null;
				object obj54 = !flag19;
				obj39 = obj38;
				obj33 = obj40;
				obj30 = obj41;
				obj35 = obj42;
				text3 = text7;
				enumerable3 = enumerable4;
				text5 = text6;
				if (obj54 == null)
				{
					if ((nint)obj43 != 7)
					{
						bool flag20 = obj43 == null;
						object obj55 = !flag20;
						if (obj55 != null)
						{
							return text9;
						}
					}
					StringBuilder stringBuilder4 = stringBuilder2.Append(suffix);
					return stringBuilder2.ToString();
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)text4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj46 = obj56;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag21 = enumerable == null;
					object obj57 = !flag21;
					obj58 = obj56;
					enumerable5 = enumerable;
					obj44 = 0;
					if (obj57 != null)
					{
						break;
					}
					obj38 = obj39;
					obj40 = obj33;
					obj58 = obj56;
					obj41 = obj30;
					obj42 = obj35;
					text7 = text3;
					enumerable4 = enumerable3;
					text6 = text5;
					obj43 = 0;
					obj45 = obj56;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result;
			}
			goto IL_0ad5;
			IL_07fd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text3 = null;
			goto IL_0fea;
			IL_0fea:
			obj31 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v766 @ X0_v38+8]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v766 @ X0_v38] (should have been resolved before IL gen)");
			object obj59 = text9 & 1;
			if (obj59 != null)
			{
				if (enumerable2 != null)
				{
					object obj60 = (nint)0 + (nint)309;
					object obj61 = obj60 & 1;
					bool flag22 = obj61 == null;
					object obj62 = !flag22;
					nint num19 = 0;
					if (obj62 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num19 = intPtr;
					}
					nint num20 = (nint)enumerable2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0960;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
					object obj63 = (nint)0 + (nint)8;
					bool flag23 = flag15;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X10_v19-8]");
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X10_v19-8]");
						object obj34 = -num19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X10_v19-8]");
						if (0 == num19)
						{
							break;
						}
						obj35 = obj63 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
						num8 = -1;
						obj34 = num8 - 1;
						bool flag16 = obj34 == null;
						flag15 = num8 != 1;
						flag23 = flag15;
						obj63 = obj35;
						if (flag15)
						{
							continue;
						}
						goto IL_0960;
					}
					num8 = (nint)obj63;
					object obj64 = num20 + obj63;
					obj51 = obj64 + 312;
					flag15 = flag23;
					obj35 = obj63;
					goto IL_10c4;
				}
				NullReferenceException ex4 = new NullReferenceException();
				enumerable3 = enumerable2;
				break;
			}
			bool flag24 = enumerable2 == null;
			obj39 = (object)(&enumerable);
			obj58 = 0;
			enumerable = enumerable2;
			enumerable3 = enumerable2;
			enumerable5 = enumerable2;
			obj44 = 7;
			obj46 = 0;
			obj38 = (object)(&enumerable);
			obj40 = obj33;
			obj58 = 0;
			obj41 = obj30;
			obj42 = obj35;
			text7 = text3;
			enumerable = enumerable2;
			enumerable4 = enumerable2;
			text6 = text5;
			obj43 = 7;
			obj45 = 0;
			if (!flag24)
			{
				goto IL_0ad5;
			}
			goto IL_1139;
			IL_0960:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text3 = null;
			goto IL_10c4;
			IL_0b8d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text7 = null;
			goto IL_11cd;
		}
		obj39 = (object)(&enumerable);
		obj58 = 0;
		enumerable = enumerable2;
		goto IL_0ebe;
		IL_0531:
		obj31 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		stringBuilder2..ctor();
		bool flag25 = stringBuilder2 == null;
		text4 = null;
		enumerable3 = list;
		text5 = prefix;
		if (!flag25)
		{
			StringBuilder stringBuilder5 = stringBuilder2.Append(prefix);
			bool flag26 = list == null;
			text4 = prefix;
			text3 = null;
			enumerable3 = list;
			text5 = prefix;
			if (!flag26)
			{
				object obj65 = (nint)0 + (nint)309;
				object obj66 = obj65 & 1;
				bool flag27 = obj66 == null;
				object obj67 = !flag27;
				nint num21 = 0;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					IntPtr intPtr2 = default(IntPtr);
					num21 = intPtr2;
				}
				nint num22 = (nint)list;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+B0]");
				object obj68 = (nint)0 + (nint)8;
				bool flag28 = flag15;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X10_v29-8]");
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X10_v29-8]");
					object obj34 = -num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X10_v29-8]");
					if (0 == num21)
					{
						break;
					}
					obj35 = obj68 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v20 (Il2CppClass<System.Collections.Generic.IEnumerable`1<T>>)+12E]");
					num8 = -1;
					obj34 = num8 - 1;
					bool flag16 = obj34 == null;
					flag15 = num8 != 1;
					flag28 = flag15;
					obj68 = obj35;
					if (flag15)
					{
						continue;
					}
					goto IL_06d4;
				}
				num8 = (nint)obj68;
				object obj69 = num22 + obj68;
				object obj70 = obj69 + 312;
				flag15 = flag28;
				obj35 = obj68;
				text3 = null;
				goto IL_0f56;
			}
		}
		goto IL_0ebe;
		IL_06d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text3 = null;
		goto IL_0f56;
		IL_02e0:
		object obj71 = (nint)0 + (nint)309;
		object obj72 = obj71 & 1;
		bool flag29 = obj72 == null;
		num15 = 0;
		num16 = 0;
		if (!flag29)
		{
			goto IL_0323;
		}
		goto IL_0cd3;
		IL_0cd3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v73+B8]");
		num9 = 0;
		<> = <>c__19<T>.<>9;
		object obj73 = (nint)0 + (nint)309;
		object obj74 = obj73 & 1;
		bool flag30 = obj74 == null;
		num10 = 0;
		if (flag30)
		{
			goto IL_039b;
		}
		obj8 = <>c__19<T>.<>9;
		num8 = num9;
		num11 = 0;
		goto IL_03ba;
	}

	public static IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> source, int size)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<IEnumerable<T>> enumerable = default(IEnumerable<IEnumerable<T>>);
		((<Chunk>d__20<T>)enumerable)..ctor(-2);
		if (enumerable != null)
		{
			<Chunk>d__20<T> <Chunk>d__ = (<Chunk>d__20<T>)(enumerable + 48);
			<Chunk>d__ = (<Chunk>d__20<T>)(object)source;
			<Chunk>d__..ctor((int)source);
			return enumerable;
		}
		return (IEnumerable<IEnumerable<T>>)new NullReferenceException();
	}

	public static IEnumerable<TSource> DistinctBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Expected I4, but got O
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e6: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<TSource> enumerable = default(IEnumerable<TSource>);
		((<DistinctBy>d__21<TSource, TKey>)enumerable)..ctor(-2);
		if (enumerable != null)
		{
			<DistinctBy>d__21<TSource, TKey> <DistinctBy>d__ = (<DistinctBy>d__21<TSource, TKey>)(enumerable + 48);
			<DistinctBy>d__ = (<DistinctBy>d__21<TSource, TKey>)source;
			<DistinctBy>d__..ctor((int)source);
			<DistinctBy>d__21<TSource, TKey> <DistinctBy>d__2 = (<DistinctBy>d__21<TSource, TKey>)(enumerable + 64);
			<DistinctBy>d__2 = (<DistinctBy>d__21<TSource, TKey>)(object)keySelector;
			<DistinctBy>d__2..ctor((int)keySelector);
			return enumerable;
		}
		return (IEnumerable<TSource>)new NullReferenceException();
	}

	public static bool IsNullOrEmpty<T>(IEnumerable<T> list)
	{
		IEnumerable<T> enumerable = default(IEnumerable<T>);
		if (enumerable != null)
		{
			bool flag = Enumerable.Any(enumerable);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		return true;
	}

	public static IEnumerable<T> TakeSample<T>(IEnumerable<T> enumerable, int sampleSize)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		((<TakeSample>d__23<T>)enumerable2)..ctor(-2);
		if (enumerable2 != null)
		{
			<TakeSample>d__23<T> <TakeSample>d__ = (<TakeSample>d__23<T>)(enumerable2 + 40);
			<TakeSample>d__ = (<TakeSample>d__23<T>)enumerable;
			<TakeSample>d__..ctor((int)enumerable);
			return enumerable2;
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public static bool CheckBounds<T>(ICollection<T> list, int index)
	{
		//IL_0124: Expected I4, but got O
		//IL_003d: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_012c: Expected I, but got O
		//IL_013c: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_01b1: Expected I4, but got O
		//IL_00a6: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		if (list != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v5-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00e7;
			}
			object obj6 = num2 + obj5;
			object obj7 = obj6 + 312;
			goto IL_0185;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0185;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v4] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag2 = index < (nint)obj8;
		object obj9 = !flag2;
		return (byte)(int)(~obj9) != 0;
	}

	public static IEnumerable<TSource1> Intersect<TSource1, TSource2>(IEnumerable<TSource1> source1, IEnumerable<TSource2> source2, Func<TSource1, TSource2, bool> predicate)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0112: Expected O, but got I4
		//IL_015d: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			goto IL_0053;
		}
		goto IL_0062;
		IL_0053:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0062;
		IL_0062:
		object obj4 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			if (obj4 != null)
			{
				object obj5 = obj4 + 16;
				obj5 = source2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj4 + 24;
				obj6 = predicate;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj7 = (nint)0 + (nint)309;
				object obj8 = obj7 & 1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				nint num4 = 0;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v119 @ X3_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
				nint num6 = 0;
				object obj10 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v94 @ X3_v2 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				object obj11 = (nint)0 + (nint)309;
				object obj12 = obj11 & 1;
				bool flag3 = obj12 == null;
				num = 0;
				if (flag3)
				{
					break;
				}
				num2 = 0;
				continue;
			}
			return (IEnumerable<TSource1>)new NullReferenceException();
		}
		goto IL_0053;
	}

	public static int GetNextRotatedIndex<T>(ICollection<T> list, int index, int offset)
	{
		//IL_0135: Expected I4, but got O
		//IL_003d: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_013d: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		int num3;
		if (list != null)
		{
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00e7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<System.Collections.Generic.ICollection`1<T>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X10_v5-8]");
				if (0 == num)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00e7;
			}
			object obj6 = num2 + obj5;
			object obj7 = obj6 + 312;
			num3 = offset;
			goto IL_0196;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_00e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = 0;
		goto IL_0196;
		IL_0196:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ X0_v4] (should have been resolved before IL gen)");
		int max = default(int);
		return IntegerExtensions.GetRotatedNextIndex(index, offset, 0, max);
	}

	public static IEnumerable<IGrouping<TKey, TElement>> RunningGroupBy<TKey, TElement>(IEnumerable<TElement> source, Func<TElement, TKey> keySelector)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c3: Expected I4, but got O
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e6: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<IGrouping<TKey, TElement>> enumerable = default(IEnumerable<IGrouping<TKey, TElement>>);
		((<RunningGroupBy>d__27<TKey, TElement>)enumerable)..ctor(-2);
		if (enumerable != null)
		{
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__ = (<RunningGroupBy>d__27<TKey, TElement>)(enumerable + 48);
			<RunningGroupBy>d__ = (<RunningGroupBy>d__27<TKey, TElement>)(object)source;
			<RunningGroupBy>d__..ctor((int)source);
			<RunningGroupBy>d__27<TKey, TElement> <RunningGroupBy>d__2 = (<RunningGroupBy>d__27<TKey, TElement>)(enumerable + 64);
			<RunningGroupBy>d__2 = (<RunningGroupBy>d__27<TKey, TElement>)(object)keySelector;
			<RunningGroupBy>d__2..ctor((int)keySelector);
			return enumerable;
		}
		return (IEnumerable<IGrouping<TKey, TElement>>)new NullReferenceException();
	}

	public static IEnumerable<T> GetCycledRange<T>(IEnumerable<T> enumerable, int startIndex, int count)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_007e: Expected I4, but got I8
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		((<GetCycledRange>d__29<T>)enumerable2)..ctor(-2);
		if (enumerable2 != null)
		{
			object obj4 = enumerable2 + 48;
			obj4 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerable2;
		}
		return (IEnumerable<T>)new NullReferenceException();
	}

	public unsafe static IEnumerable<T> GetCycledRangeInclusive<T>(IEnumerable<T> enumerable, int startIndex, int count)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_07ba: Expected O, but got I
		//IL_07c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_07d9: Expected O, but got Ref
		//IL_0042: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_0712: Expected O, but got I
		//IL_071a: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Expected O, but got Unknown
		//IL_0740: Expected O, but got I4
		//IL_00b9: Expected I4, but got I8
		//IL_00d3: Expected O, but got I4
		//IL_03ae: Expected O, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected I4, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05e6: Expected O, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0661: Expected O, but got I
		//IL_0830: Expected O, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		//IL_02d3: Expected O, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_0301: Expected O, but got I4
		//IL_0194: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected I, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_04db: Expected O, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0509: Expected O, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0363: Expected O, but got I8
		//IL_037d: Expected O, but got I4
		//IL_0285: Expected I4, but got O
		//IL_01ed: Expected O, but got I
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_056b: Expected O, but got I8
		//IL_0585: Expected O, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_046a: Expected I4, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj4 = (nint)0 + (nint)15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default(object);
		object obj6 = (ref *(?*)(&obj7)) - (ref *(?*)obj5);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj13;
		nint num7;
		int num10;
		int num11;
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		int num6 = default(int);
		object obj45 = default(object);
		int num24;
		int num25;
		NullReferenceException ex;
		nint num9;
		object obj14 = default(object);
		nint num8 = default(nint);
		if (obj8 != null)
		{
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag = obj10 == null;
			object obj11 = !flag;
			nint num3 = 0;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X1_v6 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			int num5 = (int)(num6 & 0x80000000L);
			bool flag2 = num5 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				bool flag3 = num6 == 0;
				obj13 = obj14;
				num7 = num8;
				num9 = 0;
				num10 = startIndex;
				num11 = num6;
				if (!flag3)
				{
					object obj15 = obj8 + 32;
					bool flag4 = enumerable2 == null;
					object obj16 = !flag4;
					int num12 = startIndex;
					int num13 = num6;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						int num14 = (int)((nint)startIndex / (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						object obj17 = (nint)num14 * (nint)0;
						nint num15 = (nint)(startIndex - obj17);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						bool flag5 = num15 < 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							object obj19 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X9_v27+104]");
							object obj20 = 0 * num15;
							object obj21 = obj15 + obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
							num12 = startIndex;
							num13 = num6;
							throw new NullReferenceException();
						}
					}
					else
					{
						while (true)
						{
							int num16 = num12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
							int num17 = (int)((nint)num16 / (nint)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
							object obj22 = (nint)num17 * (nint)0;
							object obj23 = num12 - obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
							bool flag6 = (nint)obj23 < 0;
							object obj24 = !flag6;
							if (obj24 != null)
							{
								break;
							}
							object obj25 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X9_v21+104]");
							object obj26 = 0 * obj23;
							object obj27 = obj15 + obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
							nint num18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X9_v23 (Il2CppClass<T>)+28]");
							object obj28 = 0 & 0x80000000L;
							bool flag7 = obj28 == null;
							object obj29 = !flag7;
							obj14 = obj6;
							if (obj29 == null)
							{
								obj14 = obj6;
							}
							nint num19 = 0;
							num8 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X1_v14 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
							num12++;
							num13--;
							bool flag8 = num13 == 1;
							obj13 = obj14;
							num7 = num8;
							num6 = (int)enumerable2;
							num9 = 0;
							num10 = num12;
							num11 = num13;
							if (!flag8)
							{
								continue;
							}
							goto IL_0651;
						}
					}
					goto IL_0790;
				}
			}
			else
			{
				object obj30 = -num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
				num11 = (int)((nint)startIndex + (nint)0);
				num10 = obj8 + 32;
				if (enumerable2 != null)
				{
					object obj31 = ~obj30;
					object obj32 = obj30 & obj31;
					object obj33 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					num9 = 0;
					while (true)
					{
						ex = (NullReferenceException)obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v9 (System.NullReferenceException)+E4]");
						bool flag9 = (nint)0 == 0;
						object obj34 = !flag9;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag10 = obj32 == null;
						obj13 = obj14;
						num7 = num8;
						if (flag10)
						{
							break;
						}
						int num20 = num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						int num21 = (int)((nint)num20 / (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						object obj35 = (nint)num21 * (nint)0;
						object obj36 = num11 - obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						bool flag11 = (nint)obj36 < 0;
						object obj37 = !flag11;
						if (obj37 == null)
						{
							object obj38 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X9_v15+104]");
							object obj39 = 0 * obj36;
							object obj40 = num10 + obj39;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
							nint num22 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X9_v17 (Il2CppClass<T>)+28]");
							object obj41 = 0 & 0x80000000L;
							bool flag12 = obj41 == null;
							object obj42 = !flag12;
							obj14 = obj6;
							if (obj42 == null)
							{
								obj14 = obj6;
							}
							nint num23 = 0;
							num8 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v378 @ X1_v10 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
							obj32--;
							num11--;
							num6 = (int)enumerable2;
							num9 = 0;
							continue;
						}
						goto IL_0790;
					}
				}
				else
				{
					object obj43 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					ex = (NullReferenceException)obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v9 (System.NullReferenceException)+E4]");
					bool flag13 = (nint)0 == 0;
					object obj44 = !flag13;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag14 = (nint)obj30 >= 1;
					obj13 = obj14;
					num7 = num8;
					num9 = 0;
					obj45 = obj8;
					num24 = num10;
					num25 = num11;
					if (flag14)
					{
						goto IL_06e8;
					}
				}
			}
			goto IL_0651;
		}
		ex = new NullReferenceException();
		num9 = 0;
		num24 = startIndex;
		num25 = num6;
		goto IL_06d9;
		IL_06e8:
		int num26 = num25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		int num27 = (int)((nint)num26 / (nint)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		object obj46 = (nint)num27 * (nint)0;
		object obj47 = num25 - obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X22_v2+18]");
		bool flag15 = (nint)obj47 < 0;
		object obj48 = !flag15;
		if (obj48 == null)
		{
			object obj49 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v6+104]");
			object obj50 = 0 * obj47;
			object obj51 = num24 + obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			NullReferenceException ex2 = new NullReferenceException();
		}
		goto IL_0790;
		IL_0651:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		bool flag16 = obj52 != null;
		obj14 = obj13;
		num8 = num7;
		obj45 = obj8;
		num24 = num10;
		num25 = num11;
		if (!flag16)
		{
			return enumerable2;
		}
		goto IL_06d9;
		IL_06d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		goto IL_06e8;
		IL_0790:
		return (IEnumerable<T>)(object)new IndexOutOfRangeException();
	}

	public unsafe static IEnumerable<T> GetCycledRangeExclusive<T>(IEnumerable<T> enumerable, int startIndex, int count)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_07dd: Expected O, but got I
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Expected O, but got Unknown
		//IL_07fc: Expected O, but got Ref
		//IL_0042: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_0635: Expected O, but got I4
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Expected O, but got Unknown
		//IL_068d: Expected O, but got I4
		//IL_00b9: Expected I4, but got I8
		//IL_00d3: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected I4, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected O, but got Unknown
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected O, but got Unknown
		//IL_0763: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_05b8: Expected O, but got I
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0867: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected O, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_042a: Expected O, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0458: Expected O, but got I4
		//IL_023e: Expected O, but got I
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_026c: Expected O, but got I4
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I8
		//IL_04d4: Expected O, but got I4
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I8
		//IL_02e8: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03c2: Expected I4, but got O
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01e8: Expected I4, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v1 (Il2CppClass<T>)+FC]");
		object obj4 = (nint)0 + (nint)15;
		object obj5 = obj4 & 0x1FFFFFFF0L;
		object obj7 = default(object);
		object obj6 = (ref *(?*)(&obj7)) - (ref *(?*)obj5);
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v72 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
		object obj8 = default(object);
		int num7;
		int num9;
		int num10;
		object obj13 = default(object);
		IEnumerable<T> enumerable2 = default(IEnumerable<T>);
		object obj14 = default(object);
		object obj16 = default(object);
		nint num13 = default(nint);
		int num22;
		int num23;
		NullReferenceException ex;
		nint num8;
		int num6 = default(int);
		if (obj8 != null)
		{
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag = obj10 == null;
			object obj11 = !flag;
			nint num3 = 0;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X1_v8 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			int num5 = (int)(num6 & 0x80000000L);
			bool flag2 = num5 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				bool flag3 = num6 == 0;
				num7 = num6;
				num8 = 0;
				num9 = startIndex;
				num10 = num6;
				if (!flag3)
				{
					obj13 = obj8 + 32;
					bool flag4 = enumerable2 == null;
					obj14 = obj8;
					num9 = startIndex;
					num10 = num6;
					if (flag4)
					{
						goto IL_0627;
					}
					int num11 = startIndex + 1;
					object obj15 = obj16;
					nint num12 = num13;
					object obj17 = 1;
					while (true)
					{
						int num14 = num11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						int num15 = (int)((nint)num14 / (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						object obj18 = (nint)num15 * (nint)0;
						object obj19 = num11 - obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						bool flag5 = (nint)obj19 < 0;
						object obj20 = !flag5;
						if (obj20 != null)
						{
							break;
						}
						object obj21 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X9_v27+104]");
						object obj22 = 0 * obj19;
						object obj23 = obj13 + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v29 (Il2CppClass<T>)+28]");
						object obj24 = 0 & 0x80000000L;
						bool flag6 = obj24 == null;
						object obj25 = !flag6;
						obj15 = obj6;
						if (obj25 == null)
						{
							obj15 = obj6;
						}
						nint num17 = 0;
						num12 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X1_v15 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
						obj17++;
						num11++;
						bool flag7 = (nint)obj17 > num6;
						obj16 = obj15;
						num7 = (int)enumerable2;
						num13 = num12;
						num8 = 0;
						num9 = num11;
						num10 = num6;
						if (!flag7)
						{
							continue;
						}
						goto IL_05a8;
					}
					goto IL_07b3;
				}
			}
			else
			{
				obj13 = -num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
				num9 = (int)((nint)startIndex + (nint)0);
				num10 = obj8 + 32;
				if (enumerable2 != null)
				{
					num9--;
					object obj26 = 1;
					num8 = 0;
					while (true)
					{
						object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
						ex = (NullReferenceException)obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v13 (System.NullReferenceException)+E4]");
						bool flag8 = (nint)0 == 0;
						object obj28 = !flag8;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						bool flag9 = obj26 > obj13;
						num7 = num6;
						if (flag9)
						{
							break;
						}
						int num18 = num9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						int num19 = (int)((nint)num18 / (nint)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						object obj29 = (nint)num19 * (nint)0;
						object obj30 = num9 - obj29;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
						bool flag10 = (nint)obj30 < 0;
						object obj31 = !flag10;
						if (obj31 == null)
						{
							object obj32 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X9_v21+104]");
							object obj33 = 0 * obj30;
							object obj34 = num10 + obj33;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
							nint num20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X9_v23 (Il2CppClass<T>)+28]");
							object obj35 = 0 & 0x80000000L;
							bool flag11 = obj35 == null;
							object obj36 = !flag11;
							obj16 = obj6;
							if (obj36 == null)
							{
								obj16 = obj6;
							}
							nint num21 = 0;
							num13 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ X1_v12 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
							obj26++;
							num9--;
							num6 = (int)enumerable2;
							num8 = 0;
							continue;
						}
						goto IL_07b3;
					}
				}
				else
				{
					object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					ex = (NullReferenceException)obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v13 (System.NullReferenceException)+E4]");
					bool flag12 = (nint)0 == 0;
					object obj38 = !flag12;
					if (obj38 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag13 = (nint)obj13 >= 1;
					num7 = num6;
					num8 = 0;
					object obj39 = obj16;
					IntPtr intPtr = num13;
					obj14 = obj8;
					num22 = num9;
					num23 = num10;
					if (flag13)
					{
						goto IL_06fd;
					}
				}
			}
			goto IL_05a8;
		}
		ex = new NullReferenceException();
		num8 = 0;
		num9 = startIndex;
		num10 = num6;
		goto IL_0618;
		IL_05a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		bool flag14 = obj40 != null;
		num6 = num7;
		obj14 = obj8;
		if (!flag14)
		{
			return enumerable2;
		}
		goto IL_0618;
		IL_0627:
		object obj41 = num9 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		object obj42 = obj41 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		object obj43 = obj42 * 0;
		object obj44 = obj41 - obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X22_v2+18]");
		bool flag15 = (nint)obj44 < 0;
		object obj45 = !flag15;
		if (obj45 == null)
		{
			object obj46 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X9_v12+104]");
			object obj47 = 0 * obj44;
			object obj48 = obj13 + obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			NullReferenceException ex2 = new NullReferenceException();
			object obj39 = obj16;
			IntPtr intPtr = num13;
			num22 = num9;
			num23 = num10;
			goto IL_06fd;
		}
		goto IL_07b3;
		IL_0618:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		goto IL_0627;
		IL_07b3:
		return (IEnumerable<T>)(object)new IndexOutOfRangeException();
		IL_06fd:
		object obj49 = num22 - 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		object obj50 = obj49 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+18]");
		object obj51 = obj50 * 0;
		object obj52 = obj49 - obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X22_v2+18]");
		bool flag16 = (nint)obj52 < 0;
		object obj53 = !flag16;
		if (obj53 == null)
		{
			object obj54 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X9_v7+104]");
			object obj55 = 0 * obj52;
			object obj56 = num23 + obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			NullReferenceException ex3 = new NullReferenceException();
		}
		goto IL_07b3;
	}

	public static int IndexOf<T>(IReadOnlyList<T> list, T elementToFind)
	{
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_04ab: Expected I4, but got O
		//IL_04b3: Expected I, but got O
		//IL_04c3: Expected O, but got I
		//IL_0172: Expected I, but got O
		//IL_01dd: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0515: Expected I, but got O
		//IL_0525: Expected O, but got I
		//IL_02cd: Expected O, but got I4
		//IL_042d: Expected I4, but got I8
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0362: Expected O, but got I
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0394: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I4
		//IL_03bc: Expected O, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03e1: Expected I, but got O
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0405: Expected O, but got I
		//IL_040d: Expected I, but got O
		int num2;
		object obj4;
		object obj6;
		nint num5;
		int num6;
		object obj5 = default(object);
		nint num4 = default(nint);
		nint num3;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			nint num = 0;
			num2 = 0;
			obj4 = obj5;
			num3 = num4;
			object obj7 = default(object);
			obj6 = obj7;
			num5 = 0;
			num6 = 0;
			if (obj3 == null)
			{
				goto IL_00b4;
			}
			goto IL_04ab;
		}
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = "java.io.FileOutputStream" + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentNullException ex = default(ArgumentNullException);
		string paramName = default(string);
		ex..ctor(paramName);
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
		IL_04ab:
		object obj14 = default(object);
		object obj16 = default(object);
		object obj18 = default(object);
		T val = default(T);
		object obj22 = default(object);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			nint num7 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_014b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v8 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v16-8]");
				if (0 == num5)
				{
					break;
				}
				obj6 = obj11 + 16;
				obj10--;
				bool flag2 = (nint)obj10 != 1;
				obj11 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_014b;
			}
			object obj12 = num7 + obj11;
			object obj13 = obj12 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ X0_v39] (should have been resolved before IL gen)");
			bool flag3 = num6 >= (nint)obj14;
			obj6 = obj11;
			if (!flag3)
			{
				goto IL_01d1;
			}
			goto IL_0420;
			IL_034a:
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v18+1C0]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X8_v18+1B8] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			bool flag4 = obj17 == null;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				num2 = num6 + 1;
				object obj20 = (nint)0 + (nint)309;
				object obj21 = obj20 & 1;
				bool flag5 = obj21 == null;
				num4 = (nint)val;
				nint num = 0;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v18+1C0]");
				obj4 = 0;
				num3 = (nint)val;
				num5 = 0;
				num6 = num2;
				continue;
			}
			goto IL_056f;
			IL_056f:
			return num6;
			IL_0432:
			obj5 = obj4;
			throw new NullReferenceException();
			IL_014b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X0_v36] (should have been resolved before IL gen)");
			bool flag6 = num6 < (nint)obj22;
			num3 = unchecked((nint)null);
			if (flag6)
			{
				goto IL_01d1;
			}
			goto IL_0420;
			IL_0420:
			num6 = -1;
			goto IL_056f;
			IL_01d1:
			object obj23 = (nint)0 + (nint)309;
			object obj24 = obj23 & 1;
			bool flag7 = obj24 == null;
			object obj25 = !flag7;
			nint num8 = 0;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				num8 = intPtr;
			}
			nint num9 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_028f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
			object obj27 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X10_v11-8]");
				if (0 == num8)
				{
					break;
				}
				obj6 = obj27 + 16;
				obj26--;
				bool flag8 = (nint)obj26 != 1;
				obj27 = obj6;
				if (flag8)
				{
					continue;
				}
				goto IL_028f;
			}
			object obj28 = num9 + obj27;
			object obj29 = obj28 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v30+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v30] (should have been resolved before IL gen)");
			bool flag9 = obj16 == null;
			obj6 = obj27;
			T val2 = (T)num6;
			if (!flag9)
			{
				goto IL_034a;
			}
			goto IL_0432;
			IL_028f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v27+8]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v398 @ X0_v27] (should have been resolved before IL gen)");
			bool flag10 = obj16 == null;
			object obj30 = !flag10;
			if (obj30 != null)
			{
				goto IL_034a;
			}
			val2 = (T)num6;
			goto IL_0432;
		}
		goto IL_00b4;
		IL_00b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj4 = obj5;
		num3 = num4;
		obj6 = obj6;
		IntPtr intPtr2 = default(IntPtr);
		num5 = intPtr2;
		num6 = num2;
		goto IL_04ab;
	}

	public unsafe static List<T> Flatten<T>(List<List<T>> @this)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_023b: Expected O, but got I4
		//IL_01ad: Expected O, but got I
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_025b: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_04ba: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0534: Expected O, but got I
		//IL_0548: Expected O, but got I
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_04de: Expected O, but got I
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_0506: Expected O, but got I4
		//IL_0303: Expected O, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_032b: Expected O, but got I4
		//IL_0393: Expected O, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I4
		//IL_0406: Expected O, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_042e: Expected O, but got I4
		//IL_046e: Expected O, but got I
		//IL_03e0: Expected O, but got I
		//IL_0453: Expected O, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		nint num = 0;
		nint num2 = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v32 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+E4]");
			if ((nint)0 != 0)
			{
				goto IL_006d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v32 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_006d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag3 = obj5 == null;
		object obj6 = !flag3;
		nint num3 = 0;
		nint num4 = 0;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_01ef;
		IL_058c:
		Func<object, IEnumerable<object>> selector;
		IEnumerable<object> source = Enumerable.SelectMany(@this, selector);
		return (List<T>)(object)Enumerable.ToList(source);
		IL_051a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag4 = obj10 == null;
		nint num5 = 0;
		if (flag4)
		{
			goto IL_034e;
		}
		object obj11 = obj7;
		nint num6 = 0;
		goto IL_0365;
		IL_02b1:
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag5 = obj13 == null;
		nint num7 = 0;
		if (!flag5)
		{
			goto IL_02ee;
		}
		goto IL_051a;
		IL_006d:
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		bool flag6 = obj15 == null;
		num3 = 0;
		num4 = 0;
		if (!flag6)
		{
			goto IL_00b0;
		}
		goto IL_01ef;
		IL_01ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v31+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v14+8]");
		selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v14+8]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			goto IL_0249;
		}
		goto IL_058c;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v40 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+B8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v18 (Il2CppStaticFields<ArraysExtensions+<>c__33`1<T>>)+8]");
		selector = (Func<object, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v18 (Il2CppStaticFields<ArraysExtensions+<>c__33`1<T>>)+8]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			goto IL_0249;
		}
		goto IL_058c;
		IL_0249:
		nint num9 = 0;
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+E4]");
			bool flag9 = (nint)0 == 0;
			nint num10 = 0;
			if (!flag9)
			{
				goto IL_02b1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v10 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			if (obj21 != null)
			{
				goto IL_02b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag11 = obj23 == null;
		object obj24 = !flag11;
		num7 = 0;
		if (obj24 != null)
		{
			goto IL_02ee;
		}
		goto IL_051a;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__33<T>.<Flatten>b__33_0));
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag12 = obj26 == null;
		object obj27 = !flag12;
		nint num11 = 0;
		if (obj27 == null)
		{
			((Func<List<T>, IEnumerable<T>>)0)..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__33<T>.<Flatten>b__33_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v17 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+B8]");
		nint num12 = 0;
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag13 = obj29 == null;
		object obj30 = !flag13;
		nint num13 = 0;
		if (obj30 == null)
		{
			((Func<List<T>, IEnumerable<T>>)0)..ctor(obj11, (IntPtr)(nint)__ldftn(<>c__33<T>.<Flatten>b__33_0));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v19 (Il2CppClass<ArraysExtensions+<>c__33`1<T>>)+B8]");
		Func<List<T>, IEnumerable<T>> func2 = (Func<List<T>, IEnumerable<T>>)((nint)0 + (nint)8);
		func2..ctor((object)func, (IntPtr)(nint)__ldftn(<>c__33<T>.<Flatten>b__33_0));
		selector = (Func<object, IEnumerable<object>>)func;
		goto IL_058c;
		IL_034e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj11 = obj8;
		goto IL_0365;
		IL_02ee:
		obj8 = <>c__33<T>.<>9;
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag14 = obj32 == null;
		object obj33 = !flag14;
		num5 = 0;
		obj11 = <>c__33<T>.<>9;
		num6 = 0;
		if (obj33 == null)
		{
			goto IL_034e;
		}
		goto IL_0365;
	}
}
