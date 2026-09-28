using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Server.Models;

public class ClientFilterProjection<T>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<T, FilterableClientModel, T> <>9__5_0;

		static <>c()
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c>)+10]");
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

		internal T <BuildFilter>b__5_0(T model, FilterableClientModel client)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			return model;
		}
	}

	private sealed class <>c__DisplayClass6_0<TItem> where TItem : IClientFilterable
	{
		public FilterableClientModel client;

		internal unsafe bool <FilterList>b__0(TItem item)
		{
			//IL_0008: Expected O, but got Ref
			//IL_0018: Expected O, but got I
			//IL_0046: Expected O, but got I
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0065: Expected O, but got Ref
			//IL_0099: Expected O, but got I
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00cb: Expected O, but got Ref
			//IL_00e4: Expected O, but got I4
			//IL_0110: Expected O, but got I
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c__DisplayClass6_0`1>>)+FC]");
			object obj4 = (nint)0 + (nint)15;
			object obj5 = obj4 & 0x1FFFFFFF0L;
			object obj7 = default(object);
			object obj6 = (ref *(?*)(&obj7)) - (ref *(?*)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c__DisplayClass6_0`1>>)+28]");
			bool flag = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c__DisplayClass6_0`1>>)+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c__DisplayClass6_0`1>>)+28]");
			object obj8 = num2 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<Il2CppRgctx<Server.Models.ClientFilterProjection`1+<>c__DisplayClass6_0`1>>)+28]");
			object obj9 = 0 & obj8;
			bool flag2 = (nint)obj9 < 0;
			TItem val = (TItem)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
			bool flag3 = flag == flag2;
			object obj10 = !flag3;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			IClientFilterable item2 = default(IClientFilterable);
			bool result = ClientFilterableExtensions.PassesFilters(item2, client);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			if (obj12 == null)
			{
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			bool result2 = default(bool);
			return result2;
		}
	}

	private static readonly Func<T, FilterableClientModel, T> FILTER;

	private T _projected;

	private int _projectedGeneration;

	private FilterableClientModel _projectedStamp;

	public T Project(T raw, int generation)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_015a: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_02eb: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0464: Expected O, but got I4
		//IL_0367: Expected O, but got I
		//IL_037d: Expected O, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_052a: Expected O, but got I4
		//IL_0492: Expected O, but got I
		//IL_04a8: Expected O, but got I
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_04d0: Expected O, but got I4
		//IL_04e0: Expected O, but got I
		//IL_0282: Expected O, but got I4
		//IL_028a: Expected I, but got O
		//IL_02a9: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X8_v2 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v41 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v41 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v41 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj9 = 0;
		if (obj8 != null)
		{
			goto IL_00e3;
		}
		goto IL_01e4;
		IL_0351:
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v31 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v31 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag3 = obj12 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v31 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj13 = 0;
		if (!flag3)
		{
			goto IL_03b8;
		}
		goto IL_04ee;
		IL_03ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X8_v23+18] (should have been resolved before IL gen)");
		object obj14 = this + 24;
		FilterableClientModel filterableClientModel;
		obj14 = filterableClientModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0423;
		IL_0423:
		return (T)(_projected & 1);
		IL_007c:
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v51 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v51 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag4 = obj16 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v51 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj9 = 0;
		if (!flag4)
		{
			goto IL_00e3;
		}
		goto IL_01e4;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v28+B8]");
		object obj17 = 0;
		if (obj17 == null)
		{
			goto IL_011b;
		}
		goto IL_021b;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v35+B8]");
		object obj18 = 0;
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			goto IL_011b;
		}
		goto IL_021b;
		IL_021b:
		filterableClientModel = FilterableClientModel.Current();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Server.Models.ClientFilterProjection`1<T>)+14]");
		bool flag6 = (nint)0 != generation;
		int num5 = generation;
		T val = raw;
		if (!flag6)
		{
			if (filterableClientModel == null)
			{
				goto IL_0538;
			}
			val = (T)_projectedGeneration;
			nint num6 = (nint)filterableClientModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v35 (Il2CppClass<Server.Models.FilterableClientModel>)+140]");
			num5 = 0;
			bool flag7 = filterableClientModel.Equals(_projectedGeneration);
			bool flag8 = !flag7;
			object obj20 = !flag8;
			if (obj20 != null)
			{
				goto IL_0423;
			}
		}
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v11 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0351;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v13+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = !flag9;
			if (obj24 != null)
			{
				goto IL_0351;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v19 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v19 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag10 = obj26 == null;
		object obj27 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v19 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj13 = 0;
		if (obj27 != null)
		{
			goto IL_03b8;
		}
		goto IL_04ee;
		IL_03b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v22+B8]");
		object obj28 = 0;
		object obj29 = obj28;
		if (obj28 != null)
		{
			goto IL_03ed;
		}
		goto IL_0538;
		IL_0538:
		return (T)new NullReferenceException();
		IL_04ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+B8]");
		object obj30 = 0;
		obj29 = obj30;
		bool flag11 = obj30 == null;
		object obj31 = !flag11;
		if (obj31 != null)
		{
			goto IL_03ed;
		}
		goto IL_0538;
		IL_011b:
		return (T)(raw & 1);
	}

	private static Func<T, FilterableClientModel, T> BuildFilter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1bca: Expected O, but got I4
		//IL_1bda: Expected O, but got I
		//IL_1bfc: Expected O, but got I4
		//IL_0041: Expected O, but got I
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_00f8: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_05cc: Expected O, but got I
		//IL_05dc: Expected O, but got I
		//IL_0603: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_034f: Expected O, but got I
		//IL_035f: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_0391: Expected O, but got I4
		//IL_03a1: Expected O, but got I
		//IL_0413: Expected O, but got I
		//IL_0429: Expected O, but got I
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0451: Expected O, but got I4
		//IL_0461: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_0161: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I
		//IL_0648: Expected I, but got O
		//IL_04bf: Expected O, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_049b: Expected O, but got I4
		//IL_0249: Expected O, but got I
		//IL_0259: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_029c: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_021b: Expected O, but got I4
		//IL_067a: Expected O, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_06a2: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_058c: Expected O, but got I
		//IL_0506: Expected O, but got I
		//IL_051c: Expected O, but got I
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0544: Expected O, but got I4
		//IL_0554: Expected O, but got I
		//IL_078e: Expected O, but got I
		//IL_079e: Expected O, but got I
		//IL_07c5: Expected O, but got I
		//IL_0b4d: Expected O, but got I
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected O, but got Unknown
		//IL_0b75: Expected O, but got I4
		//IL_02ba: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		//IL_06ca: Expected O, but got I
		//IL_06da: Expected O, but got I
		//IL_06ea: Expected O, but got I
		//IL_070c: Expected O, but got I4
		//IL_071c: Expected O, but got I
		//IL_0eeb: Expected O, but got I
		//IL_0f01: Expected O, but got I
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected O, but got Unknown
		//IL_0f29: Expected O, but got I4
		//IL_0f39: Expected O, but got I
		//IL_0760: Expected O, but got I4
		//IL_0b9d: Expected O, but got I
		//IL_0bad: Expected O, but got I
		//IL_0bc3: Expected O, but got I
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Expected O, but got Unknown
		//IL_0bf0: Expected O, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		//IL_0f97: Expected O, but got I
		//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa5: Expected O, but got Unknown
		//IL_0f73: Expected O, but got I4
		//IL_0c85: Expected O, but got I
		//IL_0c95: Expected O, but got I
		//IL_0cab: Expected O, but got I
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_0cd8: Expected O, but got I
		//IL_0c2f: Expected O, but got I
		//IL_0c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3d: Expected O, but got Unknown
		//IL_0c57: Expected O, but got I4
		//IL_1054: Expected O, but got I
		//IL_1068: Expected O, but got I
		//IL_1071: Unknown result type (might be due to invalid IL or missing references)
		//IL_1076: Expected O, but got Unknown
		//IL_0fde: Expected O, but got I
		//IL_0ff4: Expected O, but got I
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_101c: Expected O, but got I4
		//IL_102c: Expected O, but got I
		//IL_086f: Expected O, but got I
		//IL_0891: Expected O, but got I4
		//IL_0d68: Expected O, but got I
		//IL_0d78: Expected O, but got I
		//IL_0d8e: Expected O, but got I
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected O, but got Unknown
		//IL_0dc3: Expected O, but got I
		//IL_0cf6: Expected O, but got I
		//IL_0d0a: Expected O, but got I
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d18: Expected O, but got Unknown
		//IL_0d32: Expected O, but got I4
		//IL_08c7: Expected O, but got I
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_08ef: Expected O, but got I4
		//IL_10b7: Expected O, but got I
		//IL_10cd: Expected O, but got I
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Expected O, but got Unknown
		//IL_10f5: Expected O, but got I4
		//IL_110d: Expected O, but got I
		//IL_0923: Expected O, but got I
		//IL_1140: Expected O, but got I
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected O, but got Unknown
		//IL_0de7: Expected O, but got I
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected O, but got Unknown
		//IL_0e17: Expected O, but got I4
		//IL_0e5f: Expected O, but got I
		//IL_0e6f: Expected O, but got I
		//IL_0e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8d: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected O, but got Unknown
		//IL_11d5: Expected O, but got I4
		//IL_095a: Expected I, but got O
		//IL_096a: Expected O, but got I
		//IL_124d: Expected O, but got I
		//IL_1256: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Expected O, but got Unknown
		//IL_1275: Expected O, but got I4
		//IL_13f1: Expected O, but got I
		//IL_1407: Expected O, but got I
		//IL_1410: Unknown result type (might be due to invalid IL or missing references)
		//IL_1415: Expected O, but got Unknown
		//IL_142f: Expected O, but got I4
		//IL_143f: Expected O, but got I
		//IL_130e: Expected O, but got I
		//IL_131f: Expected O, but got I
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Expected O, but got Unknown
		//IL_1347: Expected O, but got I4
		//IL_129d: Expected O, but got I
		//IL_12ad: Expected O, but got I
		//IL_12c3: Expected O, but got I
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d1: Expected O, but got Unknown
		//IL_12f0: Expected O, but got I
		//IL_14bf: Expected O, but got I
		//IL_14d5: Expected O, but got I
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e3: Expected O, but got Unknown
		//IL_14fd: Expected O, but got I4
		//IL_150d: Expected O, but got I
		//IL_1467: Expected O, but got I
		//IL_1478: Expected O, but got I
		//IL_1481: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Expected O, but got Unknown
		//IL_1540: Expected O, but got I
		//IL_1375: Expected O, but got I
		//IL_1385: Expected O, but got I
		//IL_139b: Expected O, but got I
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected O, but got Unknown
		//IL_09f3: Expected I, but got O
		//IL_13d6: Expected O, but got I
		//IL_0a43: Expected O, but got I
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a51: Expected O, but got Unknown
		//IL_0a6b: Expected O, but got I4
		//IL_1565: Expected O, but got I
		//IL_1575: Expected O, but got I
		//IL_159c: Expected O, but got I
		//IL_0a93: Expected O, but got I
		//IL_0aa3: Expected O, but got I
		//IL_0ab3: Expected O, but got I
		//IL_0ad5: Expected O, but got I4
		//IL_0ae5: Expected O, but got I
		//IL_0b29: Expected O, but got I4
		//IL_15e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e8: Expected O, but got Unknown
		//IL_160d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Expected O, but got Unknown
		//IL_162d: Expected O, but got I
		//IL_1636: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Expected O, but got Unknown
		//IL_1655: Expected O, but got I4
		//IL_1689: Expected O, but got I
		//IL_16a5: Expected O, but got I4
		//IL_16c9: Expected I, but got O
		//IL_16d9: Expected O, but got I
		//IL_16fe: Expected O, but got I4
		//IL_172f: Expected O, but got I4
		//IL_175e: Expected O, but got I4
		//IL_179e: Expected O, but got I
		//IL_1827: Expected O, but got I4
		//IL_17b4: Expected I, but got O
		//IL_17c4: Expected O, but got I
		//IL_17e6: Expected O, but got I4
		//IL_17ff: Expected O, but got I
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Expected O, but got Unknown
		//IL_1888: Expected O, but got I4
		//IL_18b9: Expected I, but got O
		//IL_18e6: Expected O, but got I
		//IL_18ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f4: Expected O, but got Unknown
		//IL_190e: Expected O, but got I4
		//IL_1942: Expected O, but got I
		//IL_195e: Expected O, but got I4
		//IL_1979: Expected I, but got O
		//IL_1996: Expected O, but got I
		//IL_199f: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a4: Expected O, but got Unknown
		//IL_19be: Expected O, but got I4
		//IL_19cc: Expected O, but got I
		//IL_1ada: Expected O, but got I
		//IL_1aea: Expected O, but got I
		//IL_1b00: Expected O, but got I
		//IL_1b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e: Expected O, but got Unknown
		//IL_1b28: Expected O, but got I4
		//IL_1b38: Expected O, but got I
		//IL_19f4: Expected O, but got I
		//IL_1a04: Expected O, but got I
		//IL_1a1a: Expected O, but got I
		//IL_1a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a28: Expected O, but got Unknown
		//IL_1a4f: Expected O, but got I
		//IL_1b6a: Expected O, but got I4
		//IL_1a9e: Expected O, but got I4
		object handle = typeof(IAsyncEnumerable<>) + 72;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		bool flag3 = (object)typeFromHandle == null;
		Type type = null;
		RuntimeTypeHandle handle2;
		Type typeFromHandle3;
		BindingFlags bindingFlags;
		if (!flag3)
		{
			nint num2 = (nint)typeFromHandle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10 (Il2CppClass<System.Type>)+2C0]");
			bindingFlags = BindingFlags.Default;
			bool flag4 = typeFromHandle.IsAssignableFrom(typeFromHandle2);
			object obj7 = (nint)0 + (nint)309;
			if (flag4)
			{
				object obj8 = obj7 & 1;
				bool flag5 = obj8 == null;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v194+C0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v186+38]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v186+38]");
					object obj12 = (nint)0 + (nint)309;
					object obj13 = obj12 & 1;
					bool flag6 = obj13 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v186+38]");
					object obj14 = 0;
					if (!flag6)
					{
						goto IL_01c2;
					}
				}
				else
				{
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v172 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v172 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
					object obj15 = (nint)0 + (nint)309;
					object obj16 = obj15 & 1;
					bool flag7 = obj16 == null;
					object obj17 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v172 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
					object obj14 = 0;
					if (obj17 != null)
					{
						goto IL_01c2;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v181+E4]");
				bool flag8 = (nint)0 == 0;
				object obj18 = !flag8;
				if (obj18 != null)
				{
					goto IL_01e7;
				}
				goto IL_04a9;
			}
			object obj19 = obj7 & 1;
			bool flag9 = obj19 == null;
			object obj20 = !flag9;
			RuntimeTypeHandle handle3;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v112+C0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v77+28]");
				handle2 = (RuntimeTypeHandle)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v108+E4]");
				bool flag10 = (nint)0 == 0;
				object obj23 = !flag10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v77+28]");
				handle3 = (RuntimeTypeHandle)0;
				if (obj23 == null)
				{
					goto IL_03af;
				}
			}
			else
			{
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v74 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
				handle2 = (RuntimeTypeHandle)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v108+E4]");
				bool flag11 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v74 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
				handle3 = (RuntimeTypeHandle)0;
				if (flag11)
				{
					goto IL_03af;
				}
			}
			typeFromHandle3 = Type.GetTypeFromHandle(handle3);
			bool flag12 = (object)typeFromHandle3 == null;
			type = null;
			if (!flag12)
			{
				goto IL_0640;
			}
		}
		goto IL_1b82;
		IL_151b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_152a;
		IL_14a9:
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v90 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v90 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag13 = obj26 == null;
		object obj27 = !flag13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v90 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj28 = 0;
		if (obj27 == null)
		{
			goto IL_151b;
		}
		goto IL_152a;
		IL_1a5d:
		Delegate obj29;
		if ((object)obj29 != null)
		{
			goto IL_1a7a;
		}
		goto IL_1b80;
		IL_1b80:
		return null;
		IL_1a7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		Func<T, FilterableClientModel, T> func = default(Func<T, FilterableClientModel, T>);
		bool flag14 = func == null;
		object obj30 = !flag14;
		Func<T, FilterableClientModel, T> result = func;
		if (obj30 != null)
		{
			goto IL_05b1;
		}
		InvalidCastException ex = new InvalidCastException();
		Type type3;
		Type type2 = type3;
		goto IL_1aca;
		IL_1aca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X0_v70 (System.InvalidCastException)+C0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v52+8]");
		type3 = (Type)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v52+8]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag15 = obj33 == null;
		object obj34 = !flag15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v52+8]");
		Type type4 = (Type)0;
		if (obj34 != null)
		{
			goto IL_1a5d;
		}
		goto IL_1b46;
		IL_04a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		bool flag16 = obj36 == null;
		nint num6 = 0;
		if (flag16)
		{
			goto IL_022f;
		}
		goto IL_04f0;
		IL_01c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v181+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01e7;
		}
		goto IL_04a9;
		IL_1b46:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag17 = (object)obj29 == null;
		object obj37 = !flag17;
		Type type5 = default(Type);
		type3 = type5;
		if (obj37 != null)
		{
			goto IL_1a7a;
		}
		goto IL_1b80;
		IL_03af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		typeFromHandle3 = Type.GetTypeFromHandle(handle2);
		bool flag18 = (object)typeFromHandle3 == null;
		object obj38 = !flag18;
		if (obj38 != null)
		{
			goto IL_0640;
		}
		type = null;
		goto IL_1b82;
		IL_0640:
		nint num7 = (nint)typeFromHandle3;
		if (!typeFromHandle3.IsGenericType)
		{
			goto IL_1b80;
		}
		object obj39 = (nint)0 + (nint)309;
		object obj40 = obj39 & 1;
		bool flag19 = obj40 == null;
		object obj41 = !flag19;
		RuntimeTypeHandle handle4;
		RuntimeTypeHandle handle5;
		if (obj41 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v102+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v71+28]");
			handle4 = (RuntimeTypeHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v98+E4]");
			bool flag20 = (nint)0 == 0;
			object obj44 = !flag20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v71+28]");
			handle5 = (RuntimeTypeHandle)0;
			if (obj44 == null)
			{
				goto IL_072a;
			}
		}
		else
		{
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v68 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
			handle4 = (RuntimeTypeHandle)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v98+E4]");
			bool flag21 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v68 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
			handle5 = (RuntimeTypeHandle)0;
			if (flag21)
			{
				goto IL_072a;
			}
		}
		Type typeFromHandle4 = Type.GetTypeFromHandle(handle5);
		bool flag22 = (object)typeFromHandle4 == null;
		type = null;
		if (!flag22)
		{
			goto IL_0802;
		}
		goto IL_1b82;
		IL_04f0:
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v164 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v164 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj46 = (nint)0 + (nint)309;
		object obj47 = obj46 & 1;
		bool flag23 = obj47 == null;
		object obj48 = !flag23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v164 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj49 = 0;
		if (obj48 != null)
		{
			goto IL_02aa;
		}
		goto IL_0562;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v187+B8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v176+8]");
		result = (Func<T, FilterableClientModel, T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v176+8]");
		bool flag24 = (nint)0 == 0;
		object obj51 = !flag24;
		if (obj51 != null)
		{
			goto IL_05b1;
		}
		goto IL_0b41;
		IL_0562:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v178+B8]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v162+8]");
		result = (Func<T, FilterableClientModel, T>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v162+8]");
		if ((nint)0 != 0)
		{
			goto IL_05b1;
		}
		goto IL_0b41;
		IL_022f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v189+C0]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v178+38]");
		obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v178+38]");
		object obj54 = (nint)0 + (nint)309;
		object obj55 = obj54 & 1;
		bool flag25 = obj55 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v178+38]");
		obj49 = 0;
		if (!flag25)
		{
			goto IL_02aa;
		}
		goto IL_0562;
		IL_072a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		typeFromHandle4 = Type.GetTypeFromHandle(handle4);
		bool flag26 = (object)typeFromHandle4 == null;
		object obj56 = !flag26;
		if (obj56 != null)
		{
			goto IL_0802;
		}
		type = null;
		goto IL_1b82;
		IL_0802:
		Type genericTypeDefinition = typeFromHandle4.GetGenericTypeDefinition();
		object handle6 = typeof(IAsyncEnumerable<>) + 1464;
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)handle6);
		if (!(genericTypeDefinition == typeFromHandle5))
		{
			goto IL_1b80;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v33+E4]");
		bool flag27 = (nint)0 == 0;
		object obj58 = !flag27;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		object obj59 = (nint)0 + (nint)309;
		object obj60 = obj59 & 1;
		bool flag28 = obj60 == null;
		object obj61 = !flag28;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v25 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
		Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		bool flag29 = (object)typeFromHandle7 == null;
		bindingFlags = BindingFlags.Default;
		type = null;
		RuntimeTypeHandle handle7;
		Type typeFromHandle8;
		if (!flag29)
		{
			nint num11 = (nint)typeFromHandle7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v26 (Il2CppClass<System.Type>)+480]");
			type = (Type)0;
			Type[] genericArguments = typeFromHandle7.GetGenericArguments();
			bool flag30 = genericArguments == null;
			bindingFlags = BindingFlags.Default;
			if (!flag30)
			{
				bool flag31 = genericArguments.Length == 0;
				bindingFlags = BindingFlags.Default;
				if (flag31)
				{
					goto IL_1b90;
				}
				bool flag32 = (object)typeFromHandle6 == null;
				bindingFlags = BindingFlags.Default;
				if (!flag32)
				{
					nint num12 = (nint)typeFromHandle6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v28 (Il2CppClass<System.Type>)+2C0]");
					bindingFlags = BindingFlags.Default;
					if (!typeFromHandle6.IsAssignableFrom(genericArguments[0]))
					{
						goto IL_1b80;
					}
					object obj62 = (nint)0 + (nint)309;
					object obj63 = obj62 & 1;
					bool flag33 = obj63 == null;
					object obj64 = !flag33;
					RuntimeTypeHandle handle8;
					if (obj64 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v90+C0]");
						object obj65 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v65+50]");
						handle7 = (RuntimeTypeHandle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
						object obj66 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v64+E4]");
						bool flag34 = (nint)0 == 0;
						object obj67 = !flag34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v65+50]");
						handle8 = (RuntimeTypeHandle)0;
						if (obj67 == null)
						{
							goto IL_0af3;
						}
					}
					else
					{
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v62 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+50]");
						handle7 = (RuntimeTypeHandle)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v2+E0]");
						object obj66 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v64+E4]");
						bool flag35 = (nint)0 == 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v62 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+50]");
						handle8 = (RuntimeTypeHandle)0;
						if (flag35)
						{
							goto IL_0af3;
						}
					}
					typeFromHandle8 = Type.GetTypeFromHandle(handle8);
					bool flag36 = (object)typeFromHandle8 == null;
					type = null;
					if (!flag36)
					{
						goto IL_15d9;
					}
				}
			}
		}
		goto IL_1b82;
		IL_0b41:
		object obj68 = (nint)0 + (nint)309;
		object obj69 = obj68 & 1;
		bool flag37 = obj69 == null;
		object obj70 = !flag37;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v175+C0]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v158+38]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v158+38]");
			object obj73 = (nint)0 + (nint)309;
			object obj74 = obj73 & 1;
			bool flag38 = obj74 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v158+38]");
			object obj75 = 0;
			if (!flag38)
			{
				goto IL_0bfe;
			}
		}
		else
		{
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v133 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v133 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj76 = (nint)0 + (nint)309;
			object obj77 = obj76 & 1;
			bool flag39 = obj77 == null;
			object obj78 = !flag39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v133 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj75 = 0;
			if (obj78 != null)
			{
				goto IL_0bfe;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v152+E4]");
		bool flag40 = (nint)0 == 0;
		object obj79 = !flag40;
		if (obj79 != null)
		{
			goto IL_0c23;
		}
		goto IL_0f81;
		IL_01e7:
		object obj80 = (nint)0 + (nint)309;
		object obj81 = obj80 & 1;
		bool flag41 = obj81 == null;
		object obj82 = !flag41;
		num6 = 0;
		if (obj82 == null)
		{
			goto IL_022f;
		}
		goto IL_04f0;
		IL_1b82:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1b90;
		IL_0bfe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v152+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0c23;
		}
		goto IL_0f81;
		IL_05b1:
		return result;
		IL_0f81:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj83 = (nint)0 + (nint)309;
		object obj84 = obj83 & 1;
		bool flag42 = obj84 == null;
		nint num15 = 0;
		if (flag42)
		{
			goto IL_0c6b;
		}
		goto IL_0fc8;
		IL_0c23:
		object obj85 = (nint)0 + (nint)309;
		object obj86 = obj85 & 1;
		bool flag43 = obj86 == null;
		object obj87 = !flag43;
		num15 = 0;
		if (obj87 == null)
		{
			goto IL_0c6b;
		}
		goto IL_0fc8;
		IL_0fc8:
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v125 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v125 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj89 = (nint)0 + (nint)309;
		object obj90 = obj89 & 1;
		bool flag44 = obj90 == null;
		object obj91 = !flag44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v125 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
		object obj92 = 0;
		if (obj91 != null)
		{
			goto IL_0ce6;
		}
		goto IL_103a;
		IL_0c6b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v170+C0]");
		object obj93 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v150+38]");
		obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v150+38]");
		object obj94 = (nint)0 + (nint)309;
		object obj95 = obj94 & 1;
		bool flag45 = obj95 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v150+38]");
		obj92 = 0;
		if (!flag45)
		{
			goto IL_0ce6;
		}
		goto IL_103a;
		IL_103a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v148+B8]");
		object obj96 = 0;
		object obj97 = obj96;
		object obj98 = (nint)0 + (nint)309;
		object obj99 = obj98 & 1;
		bool flag46 = obj99 == null;
		nint num17 = 0;
		object obj100 = obj96;
		if (flag46)
		{
			goto IL_0d4e;
		}
		goto IL_10a1;
		IL_0d4e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v165+C0]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v142+8]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v142+8]");
		object obj103 = (nint)0 + (nint)309;
		object obj104 = obj103 & 1;
		bool flag47 = obj104 == null;
		obj100 = obj97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v142+8]");
		object obj105 = 0;
		if (!flag47)
		{
			goto IL_0dd1;
		}
		goto IL_111b;
		IL_10a1:
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v117 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+8]");
		obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v117 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+8]");
		object obj106 = (nint)0 + (nint)309;
		object obj107 = obj106 & 1;
		bool flag48 = obj107 == null;
		object obj108 = !flag48;
		obj97 = obj100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v117 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+8]");
		obj105 = 0;
		if (obj108 != null)
		{
			goto IL_0dd1;
		}
		goto IL_111b;
		IL_0ce6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X0_v167+B8]");
		object obj109 = 0;
		obj97 = obj109;
		object obj110 = (nint)0 + (nint)309;
		object obj111 = obj110 & 1;
		bool flag49 = obj111 == null;
		object obj112 = !flag49;
		num17 = 0;
		obj100 = obj109;
		if (obj112 == null)
		{
			goto IL_0d4e;
		}
		goto IL_10a1;
		IL_0af3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		typeFromHandle8 = Type.GetTypeFromHandle(handle7);
		bool flag50 = (object)typeFromHandle8 == null;
		object obj113 = !flag50;
		if (obj113 != null)
		{
			goto IL_15d9;
		}
		type = null;
		goto IL_1b82;
		IL_15d9:
		object name = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 24;
		MethodInfo method = typeFromHandle8.GetMethod((string)name, (BindingFlags)40);
		object obj114 = typeof(SqlSingle[]) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj115 = (nint)0 + (nint)309;
		object obj116 = obj115 & 1;
		bool flag51 = obj116 == null;
		object obj117 = !flag51;
		if (obj117 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v38 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+28]");
		Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		bool flag52 = (object)typeFromHandle9 == null;
		object obj118 = 0;
		bindingFlags = (BindingFlags)40;
		type = null;
		IndexOutOfRangeException ex3 = default(IndexOutOfRangeException);
		if (!flag52)
		{
			nint num20 = (nint)typeFromHandle9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v39 (Il2CppClass<System.Type>)+480]");
			type = (Type)0;
			Type[] genericArguments2 = typeFromHandle9.GetGenericArguments();
			bool flag53 = genericArguments2 == null;
			obj118 = 0;
			bindingFlags = (BindingFlags)40;
			if (!flag53)
			{
				bool flag54 = genericArguments2.Length == 0;
				obj118 = 0;
				bindingFlags = (BindingFlags)40;
				if (flag54)
				{
					goto IL_1b90;
				}
				Type[] array = default(Type[]);
				bool flag55 = array == null;
				obj118 = 0;
				bindingFlags = (BindingFlags)40;
				if (!flag55)
				{
					bool flag56 = (object)genericArguments2[0] == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v39 (Il2CppClass<System.Type>)+480]");
					Type type6 = (Type)0;
					if (!flag56)
					{
						nint num21 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v60 (Il2CppClass<System.Type[]>)+40]");
						type6 = (Type)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag57 = ex3 == null;
						obj118 = 0;
						bindingFlags = (BindingFlags)40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v60 (Il2CppClass<System.Type[]>)+40]");
						type = (Type)0;
						if (flag57)
						{
							goto IL_1b9e;
						}
					}
					bool flag58 = array.Length == 0;
					obj118 = 0;
					bindingFlags = (BindingFlags)40;
					type = type6;
					if (flag58)
					{
						goto IL_1b90;
					}
					object obj119 = array + 32;
					obj119 = genericArguments2[0];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag59 = (object)method == null;
					obj118 = 0;
					bindingFlags = (BindingFlags)40;
					type = genericArguments2[0];
					if (!flag59)
					{
						nint num22 = (nint)method;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v43 (Il2CppClass<System.Reflection.MethodInfo>)+400]");
						bindingFlags = BindingFlags.Default;
						MethodInfo methodInfo = method.MakeGenericMethod(array);
						object obj120 = (nint)0 + (nint)309;
						object obj121 = obj120 & 1;
						bool flag60 = obj121 == null;
						object obj122 = !flag60;
						if (obj122 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v46 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+58]");
						Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
						bool flag61 = (object)methodInfo == null;
						obj118 = 0;
						type = null;
						if (!flag61)
						{
							nint num24 = (nint)methodInfo;
							obj29 = methodInfo.CreateDelegate(typeFromHandle10);
							object obj123 = (nint)0 + (nint)309;
							object obj124 = obj123 & 1;
							bool flag62 = obj124 == null;
							object obj125 = !flag62;
							type2 = typeFromHandle10;
							ex = (InvalidCastException)0;
							if (obj125 != null)
							{
								goto IL_1aca;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X0_v77+C0]");
							object obj126 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v57+8]");
							type3 = (Type)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v57+8]");
							object obj127 = (nint)0 + (nint)309;
							object obj128 = obj127 & 1;
							bool flag63 = obj128 == null;
							type2 = typeFromHandle10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v57+8]");
							type4 = (Type)0;
							if (!flag63)
							{
								goto IL_1a5d;
							}
							goto IL_1b46;
						}
					}
				}
			}
		}
		goto IL_1b82;
		IL_1197:
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v113 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+40]");
		nint num26 = 0;
		object obj130;
		object obj129 = obj130 & 1;
		bool flag64 = obj129 == null;
		object obj131 = !flag64;
		obj97 = obj100;
		Func<bool, object, bool> func3;
		Func<bool, object, bool> func2 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v113 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+40]");
		nint method2 = 0;
		if (obj131 == null)
		{
			goto IL_1203;
		}
		goto IL_122a;
		IL_0dd1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj132 = (nint)0 + (nint)309;
		obj130 = obj132;
		object obj133 = obj132 & 1;
		bool flag65 = obj133 == null;
		object obj134 = !flag65;
		nint num27 = 0;
		Func<bool, object, bool> func4 = default(Func<bool, object, bool>);
		func2 = func4;
		obj100 = obj97;
		nint num28 = 0;
		func3 = func4;
		if (obj134 == null)
		{
			goto IL_0e49;
		}
		goto IL_1197;
		IL_0e49:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj135 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X0_v159+C0]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v138+40]");
		num26 = 0;
		object obj137 = obj135 & 1;
		bool flag66 = obj137 == null;
		num28 = 0;
		if (flag66)
		{
			goto IL_1203;
		}
		obj100 = obj97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X8_v138+40]");
		method2 = 0;
		func3 = func2;
		goto IL_122a;
		IL_1203:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj100 = obj97;
		method2 = num26;
		func3 = func2;
		goto IL_122a;
		IL_1b90:
		ex3 = new IndexOutOfRangeException();
		goto IL_1b9e;
		IL_122a:
		nint num29 = 0;
		func3..ctor(obj100, (IntPtr)method2);
		object obj138 = (nint)0 + (nint)309;
		object obj139 = obj138 & 1;
		bool flag67 = obj139 == null;
		object obj140 = !flag67;
		if (obj140 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v136+C0]");
			object obj141 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v108+38]");
			object obj142 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v108+38]");
			object obj143 = (nint)0 + (nint)309;
			object obj144 = obj143 & 1;
			bool flag68 = obj144 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v108+38]");
			object obj145 = 0;
			if (!flag68)
			{
				goto IL_12fe;
			}
		}
		else
		{
			nint num30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v97 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj142 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v97 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj146 = (nint)0 + (nint)309;
			object obj147 = obj146 & 1;
			bool flag69 = obj147 == null;
			object obj148 = !flag69;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v97 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+38]");
			object obj145 = 0;
			if (obj148 != null)
			{
				goto IL_12fe;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v128+B8]");
		object obj149 = 0;
		object obj150 = (nint)0 + (nint)309;
		object obj151 = obj150 & 1;
		bool flag70 = obj151 == null;
		nint num31 = 0;
		if (flag70)
		{
			goto IL_135b;
		}
		goto IL_14a9;
		IL_152a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X0_v119+B8]");
		object obj152 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (Func<T, FilterableClientModel, T>)(object)func3;
		IL_111b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj153 = (nint)0 + (nint)309;
		obj130 = obj153;
		object obj154 = obj153 & 1;
		bool flag71 = obj154 == null;
		obj97 = obj100;
		num27 = 0;
		Func<bool, object, bool> func5 = default(Func<bool, object, bool>);
		func2 = func5;
		num28 = 0;
		func3 = func5;
		if (flag71)
		{
			goto IL_0e49;
		}
		goto IL_1197;
		IL_1b9e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (Func<T, FilterableClientModel, T>)(object)new OutOfMemoryException();
		IL_12fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v134+B8]");
		object obj155 = 0;
		object obj156 = (nint)0 + (nint)309;
		object obj157 = obj156 & 1;
		bool flag72 = obj157 == null;
		object obj158 = !flag72;
		num31 = 0;
		if (obj158 == null)
		{
			goto IL_135b;
		}
		goto IL_14a9;
		IL_135b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X0_v132+C0]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v101+38]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v101+38]");
		object obj160 = (nint)0 + (nint)309;
		object obj161 = obj160 & 1;
		if (obj161 == null)
		{
			goto IL_151b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v101+38]");
		obj28 = 0;
		goto IL_152a;
	}

	private static List<TItem> FilterList<TItem>(List<TItem> model, FilterableClientModel client) where TItem : IClientFilterable
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
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
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ X1_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
			if (obj4 != null)
			{
				object obj5 = obj4 + 16;
				obj5 = client;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (model != null)
				{
					object obj6 = (nint)0 + (nint)309;
					object obj7 = obj6 & 1;
					bool flag2 = obj7 == null;
					object obj8 = !flag2;
					nint num4 = 0;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ X3_v1 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ X2_v2 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					nint num7 = 0;
					object obj9 = num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X2_v3 (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					object obj10 = (nint)0 + (nint)309;
					object obj11 = obj10 & 1;
					bool flag3 = obj11 == null;
					num = 0;
					if (flag3)
					{
						break;
					}
					num2 = 0;
					continue;
				}
				return null;
			}
			return (List<TItem>)(object)new NullReferenceException();
		}
		goto IL_0053;
	}

	public ClientFilterProjection()
	{
		_ = 4294967295L;
		base..ctor();
	}

	static ClientFilterProjection()
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0034: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_023e: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00c4: Expected O, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_02e0: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I4
		//IL_016a: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @439C4A0");
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4 & 1;
		if (obj5 != null)
		{
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v27 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v27 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag2 = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v27 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
			object obj9 = 0;
			if (!flag2)
			{
				goto IL_00ff;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v16+C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v15+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v15+10]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v15+10]");
			object obj9 = 0;
			if (obj13 != null)
			{
				goto IL_00ff;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v14+B8]");
		object obj14 = 0;
		object obj15 = default(object);
		obj14 = obj15;
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		nint num3 = 0;
		if (obj18 != null)
		{
			goto IL_0154;
		}
		goto IL_02b6;
		IL_02b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+C0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+10]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag5 = obj22 == null;
		object obj23 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8+10]");
		object obj24 = 0;
		if (obj23 != null)
		{
			goto IL_01bb;
		}
		goto IL_033c;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v23+B8]");
		object obj25 = 0;
		obj25 = obj15;
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		bool flag6 = obj27 == null;
		num3 = 0;
		if (!flag6)
		{
			goto IL_0154;
		}
		goto IL_02b6;
		IL_01bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_033c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0154:
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v20 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v20 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag7 = obj29 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v20 (Il2CppRgctx<Server.Models.ClientFilterProjection`1>)+10]");
		obj24 = 0;
		if (!flag7)
		{
			goto IL_01bb;
		}
		goto IL_033c;
	}
}
