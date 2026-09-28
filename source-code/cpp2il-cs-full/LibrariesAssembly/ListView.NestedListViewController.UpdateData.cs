using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace ListView;

public abstract class NestedListViewController<TData, TItem, TIndex> : ListViewController<TData, TItem, TIndex> where TData : INestedListViewItemData<TData, TIndex> where TItem : INestedListViewItem<TData, TIndex>
{
	protected struct UpdateData
	{
		public List<TData> data;

		public int depth;

		public int index;
	}

	protected float m_ExpandedDataLength;

	protected readonly Dictionary<TIndex, bool> m_ExpandStates;

	private Action<TData> m_ToggleExpanded;

	protected readonly Stack<UpdateData> m_UpdateStack;

	protected override float listHeight
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+E8]");
			return 0f;
		}
	}

	public unsafe override List<TData> data
	{
		get
		{
			//IL_0030: Expected O, but got I
			if ((object)this != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v2 (Il2CppRgctx<ListView.NestedListViewController`3>)+8]");
				object obj = 0;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X2_v1 (should have been resolved before IL gen)");
			}
			return (List<TData>)(object)new NullReferenceException();
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			//IL_001a: Expected O, but got I
			//IL_003a: Expected O, but got I
			//IL_004a: Expected O, but got I
			//IL_0067: Expected O, but got I
			//IL_0077: Expected O, but got I
			//IL_0087: Expected O, but got I
			//IL_00aa: Expected O, but got I
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00d2: Expected O, but got I4
			//IL_010f: Expected O, but got I
			//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b38: Expected O, but got Unknown
			//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b46: Expected O, but got Unknown
			//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b58: Expected O, but got Unknown
			//IL_0b65: Expected O, but got Ref
			//IL_0b80: Expected O, but got I
			//IL_0b96: Expected O, but got I
			//IL_0ba4: Expected O, but got Ref
			//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb7: Expected O, but got Unknown
			//IL_0bd1: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0139: Expected O, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected O, but got Unknown
			//IL_0166: Expected O, but got Ref
			//IL_0181: Expected O, but got I
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_01a5: Expected O, but got Ref
			//IL_01b2: Expected O, but got Ref
			//IL_01c8: Expected O, but got I
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_01e7: Expected O, but got Ref
			//IL_0207: Expected O, but got I
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_0226: Expected O, but got Ref
			//IL_0233: Expected O, but got Ref
			//IL_0249: Expected O, but got I
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			//IL_0268: Expected O, but got Ref
			//IL_0283: Expected O, but got I
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_02a2: Expected O, but got Ref
			//IL_02af: Expected O, but got Ref
			//IL_02c2: Expected O, but got Ref
			//IL_02e6: Expected O, but got Ref
			//IL_0302: Expected O, but got Ref
			//IL_0326: Expected O, but got Ref
			//IL_034a: Expected O, but got Ref
			//IL_0367: Expected O, but got Ref
			//IL_037d: Expected O, but got I
			//IL_038d: Expected O, but got I
			//IL_03b1: Expected O, but got I
			//IL_03bf: Expected O, but got Ref
			//IL_03dc: Expected O, but got I
			//IL_03ec: Expected O, but got I
			//IL_03fc: Expected O, but got I
			//IL_040c: Expected O, but got I
			//IL_0422: Expected O, but got I
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Expected O, but got Unknown
			//IL_044a: Expected O, but got I4
			//IL_0481: Expected O, but got I
			//IL_0491: Expected O, but got I
			//IL_04a1: Expected O, but got I
			//IL_04b1: Expected O, but got I
			//IL_04bf: Expected O, but got Ref
			//IL_04cf: Expected O, but got I
			//IL_0506: Expected O, but got I
			//IL_0516: Expected O, but got I
			//IL_0526: Expected O, but got I
			//IL_0536: Expected O, but got I
			//IL_0546: Expected O, but got I
			//IL_0561: Expected O, but got Ref
			//IL_0579: Expected O, but got Ref
			//IL_0589: Expected O, but got I
			//IL_05a1: Expected O, but got Ref
			//IL_05ba: Expected O, but got Ref
			//IL_05c8: Expected O, but got Ref
			//IL_0bef: Expected O, but got I
			//IL_0bff: Expected O, but got I
			//IL_0c0f: Expected O, but got I
			//IL_0c1f: Expected O, but got I
			//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c37: Expected O, but got Unknown
			//IL_09f0: Expected O, but got I4
			//IL_0dc1: Expected O, but got I
			//IL_0dd1: Expected O, but got I
			//IL_0de1: Expected O, but got I
			//IL_0df1: Expected O, but got I
			//IL_0e07: Expected O, but got I
			//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e15: Expected O, but got Unknown
			//IL_0e2f: Expected O, but got I4
			//IL_0639: Expected O, but got I
			//IL_0649: Expected O, but got I
			//IL_0659: Expected O, but got I
			//IL_0669: Expected O, but got I
			//IL_067c: Expected O, but got Ref
			//IL_06a0: Expected O, but got I
			//IL_06b0: Expected O, but got I
			//IL_06c0: Expected O, but got I
			//IL_06d0: Expected O, but got I
			//IL_06e3: Expected O, but got Ref
			//IL_0b13: Expected O, but got Ref
			//IL_0d48: Expected O, but got I
			//IL_0d58: Expected O, but got I
			//IL_0d68: Expected O, but got I
			//IL_0d8c: Expected O, but got I4
			//IL_070c: Expected O, but got I
			//IL_072e: Expected O, but got I
			//IL_073e: Expected O, but got I
			//IL_074e: Expected O, but got I
			//IL_075e: Expected O, but got I
			//IL_076e: Expected O, but got I
			//IL_0788: Expected O, but got I8
			//IL_07a2: Expected O, but got I4
			//IL_0aa6: Expected O, but got I4
			//IL_0aaf: Expected O, but got I4
			//IL_0a0f: Expected O, but got I
			//IL_0a1f: Expected O, but got I
			//IL_0a2f: Expected O, but got I
			//IL_0c64: Expected O, but got I
			//IL_0c81: Expected O, but got Ref
			//IL_0caf: Expected O, but got I
			//IL_0cbf: Expected O, but got I
			//IL_0ccf: Expected O, but got I
			//IL_0a44: Expected O, but got I
			//IL_0a66: Expected O, but got I4
			//IL_0a6f: Expected O, but got I4
			//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d3: Expected O, but got Unknown
			//IL_0960: Expected O, but got I
			//IL_0970: Expected O, but got I
			//IL_0980: Expected O, but got I
			//IL_0990: Expected O, but got I
			//IL_09aa: Expected O, but got I8
			//IL_09c4: Expected O, but got I4
			//IL_05ef: Expected O, but got I
			//IL_060c: Expected O, but got I
			//IL_061a: Expected O, but got Ref
			//IL_0800: Expected O, but got I
			//IL_0810: Expected O, but got I
			//IL_0820: Expected O, but got I
			//IL_0830: Expected O, but got I
			//IL_084b: Expected O, but got Ref
			//IL_087e: Expected O, but got I
			//IL_088e: Expected O, but got I
			//IL_089e: Expected O, but got I
			//IL_08ae: Expected O, but got I
			//IL_08c4: Expected O, but got I
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d2: Expected O, but got Unknown
			//IL_08ec: Expected O, but got I4
			//IL_0cee: Expected O, but got I
			//IL_0d08: Expected O, but got I8
			//IL_0d22: Expected O, but got I4
			//IL_0e60: Expected O, but got Ref
			//IL_0e78: Expected O, but got Ref
			//IL_0e86: Expected O, but got Ref
			//IL_0e96: Expected O, but got I
			//IL_0ea6: Expected O, but got I
			//IL_0914: Expected O, but got I
			//IL_0924: Expected O, but got I
			//IL_0934: Expected O, but got I
			object obj2 = default(object);
			object obj = (object)(&obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj3 = 0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+40]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+58]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X10_v1+FC]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v2+FC]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+40]");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag = obj10 == null;
			object obj11 = !flag;
			object obj12;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v81+FC]");
				obj12 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v1+FC]");
				obj12 = 0;
			}
			object obj13 = obj12 + 16;
			object obj14 = obj13 + 15;
			object obj15 = obj14 & 0x1FFFFFFF0L;
			object obj17 = default(object);
			object obj16 = (ref *(?*)(&obj17)) - (ref *(?*)obj15);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
			object obj19 = (nint)0 + (nint)309;
			object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			object obj21 = obj19 & 1;
			bool flag2 = obj21 == null;
			object obj22 = !flag2;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+FC]");
			object obj23 = (nint)0 + (nint)16;
			object obj24 = obj23 + 15;
			object obj25 = obj24 & 0x1FFFFFFF0L;
			object obj26 = (ref *(?*)(&obj17)) - (ref *(?*)obj25);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X10_v4+FC]");
			object obj27 = (nint)0 + (nint)15;
			object obj28 = obj27 & 0x1FFFFFFF0L;
			object obj29 = (ref *(?*)(&obj17)) - (ref *(?*)obj28);
			object obj30 = (ref *(?*)(&obj17)) - (ref *(?*)obj28);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F0]");
			object obj31 = (nint)0 + (nint)15;
			object obj32 = obj31 & 0x1FFFFFFF0L;
			object obj33 = (ref *(?*)(&obj17)) - (ref *(?*)obj32);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X10_v3+FC]");
			object obj34 = (nint)0 + (nint)15;
			object obj35 = obj34 & 0x1FFFFFFF0L;
			object obj36 = (ref *(?*)(&obj17)) - (ref *(?*)obj35);
			object obj37 = (ref *(?*)(&obj17)) - (ref *(?*)obj35);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v1+FC]");
			object obj38 = (nint)0 + (nint)15;
			object obj39 = obj38 & 0x1FFFFFFF0L;
			object obj40 = (ref *(?*)(&obj17)) - (ref *(?*)obj39);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
			object obj41 = (nint)0 + (nint)15;
			object obj42 = obj41 & 0x1FFFFFFF0L;
			object obj43 = (ref *(?*)(&obj17)) - (ref *(?*)obj42);
			object obj44 = (ref *(?*)(&obj17)) - (ref *(?*)obj39);
			object obj45 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X0_v1+FC]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			object obj46 = (ref *(?*)(&obj17)) - (ref *(?*)obj42);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			object obj47 = (ref *(?*)(&obj17)) - (ref *(?*)obj35);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E0]");
			object obj48 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj17, 0));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D0]");
			object obj49 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj17, 0));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
			object obj51 = (nint)0 + (nint)152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v29-100]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
			object obj52 = 0;
			object obj53 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v30+B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v32+20]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v33+C0]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v34+20]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v34+20]");
			object obj58 = (nint)0 + (nint)309;
			object obj59 = obj58 & 1;
			bool flag3 = obj59 == null;
			object obj60 = !flag3;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
			object obj61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v37+20]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v38+C0]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v39+28]");
			object obj64 = 0;
			object obj65 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X9_v24-100]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v386 @ X2_v2] (should have been resolved before IL gen)");
			object obj67 = default(object);
			object obj137;
			object obj73;
			if (obj67 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
				object obj68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v52+20]");
				object obj69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v53+C0]");
				object obj70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v54+38]");
				object obj71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-100]");
				object obj72 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-100]");
				_ = 0;
				obj73 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X1_v12+10] (should have been resolved before IL gen)");
				object obj74 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v56-100]");
				obj64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				object obj75 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
				_ = 0;
				object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
				object obj77 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
				object obj78 = obj67;
				object obj83 = default(object);
				object obj108 = default(object);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
					object obj79 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v60+20]");
					object obj80 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v61+C0]");
					object obj81 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v62+C0]");
					obj66 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ X1_v8] (should have been resolved before IL gen)");
					object obj82 = obj83 & 1;
					if (obj82 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
					object obj84 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v64+20]");
					object obj85 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v65+C0]");
					object obj86 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v66+48]");
					object obj87 = 0;
					object obj88 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X1_v16+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
					object obj89 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v68+20]");
					object obj90 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v69+C0]");
					object obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v70+60]");
					object obj92 = 0;
					object obj93 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ X1_v18+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D0]");
					object obj94 = 0;
					obj78 = obj94;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
					object obj95 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v73+20]");
					object obj96 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v74+C0]");
					object obj97 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X9_v35+70]");
					object obj98 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v75+28]");
					obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v75+28]");
					object obj99 = 0 & 0x80000000L;
					bool flag4 = obj99 == null;
					object obj100 = !flag4;
					object obj101 = obj37;
					if (obj100 == null)
					{
						obj101 = obj37;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X9_v35+78]");
					object obj102 = 0;
					object obj103 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X1_v21+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
					object obj104 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v79+20]");
					object obj105 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v80+C0]");
					object obj106 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A38");
					object obj107 = obj108 & 1;
					if (obj107 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
						object obj109 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v89+20]");
						object obj110 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v90+C0]");
						object obj111 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v91+98]");
						object obj112 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D8]");
						_ = 0;
						object obj113 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v495 @ X1_v27+10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
						object obj114 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v93+20]");
						object obj115 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v94+C0]");
						object obj116 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v96+A0]");
						object obj117 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v96+A0]");
						object obj118 = (nint)0 + (nint)309;
						object obj119 = obj118 & 1;
						bool flag5 = obj119 == null;
						object obj120 = !flag5;
						if (obj120 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
							object obj121 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v98+20]");
							object obj122 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v99+C0]");
							obj116 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v96+90]");
						object obj123 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X9_v38+28]");
						object obj124 = 0 & 0x80000000L;
						bool flag6 = obj124 == null;
						object obj125 = !flag6;
						object obj126 = obj29;
						if (obj125 == null)
						{
							obj126 = obj29;
						}
						_ = 0;
						object obj127 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 153));
						obj72 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
						object obj128 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 153));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F8]");
						obj64 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E0]");
						obj73 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
						object obj129 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v82+20]");
						object obj130 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v83+C0]");
						object obj131 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v84+70]");
						object obj132 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v85+28]");
						object obj133 = 0 & 0x80000000L;
						bool flag7 = obj133 == null;
						object obj134 = !flag7;
						obj72 = obj36;
						if (obj134 == null)
						{
							obj72 = obj36;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
						obj64 = 0;
						object obj135 = obj64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v87+2D0]");
						object obj136 = 0;
						obj73 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X1_v26+10] (should have been resolved before IL gen)");
					}
				}
				obj137 = 0;
				goto IL_0db1;
			}
			NullReferenceException ex = new NullReferenceException();
			OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
			goto IL_0d9a;
			IL_0db1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
			object obj138 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v42+20]");
			object obj139 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v43+C0]");
			object obj140 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v45+40]");
			object obj141 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v45+40]");
			object obj142 = (nint)0 + (nint)309;
			object obj143 = obj142 & 1;
			bool flag8 = obj143 == null;
			object obj144 = !flag8;
			if (obj144 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
				object obj145 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v47+20]");
				object obj146 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v48+C0]");
				obj140 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v45+C8]");
			obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
			obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
			bool flag9 = obj137 == null;
			object obj147 = !flag9;
			if (obj147 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj148 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
				bool flag10 = obj148 != null;
				object obj128 = 0;
				object obj72 = 0;
				if (!flag10)
				{
					return;
				}
			}
			else
			{
				ex2 = new OutOfMemoryException();
				object obj128 = 0;
				object obj72 = 0;
			}
			goto IL_0d9a;
			IL_0d9a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			object obj150 = default(object);
			object obj149 = obj150;
			object obj152 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				if ((nint)obj66 == 1)
				{
					break;
				}
				object obj151 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D3AB8C");
				obj149 = obj152;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj153 = default(object);
			obj137 = obj153;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			goto IL_0db1;
		}
	}

	protected override void Awake()
	{
		//IL_0016: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v2 (Il2CppRgctx<ListView.NestedListViewController`3>)+D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ X1_v1] (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v5 (Il2CppRgctx<ListView.NestedListViewController`3>)+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v5 (Il2CppRgctx<ListView.NestedListViewController`3>)+E0]");
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v9 (Il2CppRgctx<ListView.NestedListViewController`3>)+E8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ X3_v1] (should have been resolved before IL gen)");
		object obj7 = this + 248;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe static TData GetRowRecursive(List<TData> data, TIndex index)
	{
		//IL_0008: Expected O, but got Ref
		//IL_001d: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_023e: Expected O, but got Ref
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0139: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00d7: Expected O, but got Ref
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0353: Expected O, but got I
		//IL_0363: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03ab: Expected O, but got I4
		//IL_03d1: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_02c3: Expected O, but got I
		//IL_02d3: Expected O, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_030b: Expected O, but got I4
		//IL_041c: Expected O, but got I
		//IL_0432: Expected O, but got I
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_045a: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04ba: Expected O, but got Ref
		//IL_04cb: Expected O, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I4
		//IL_0526: Expected O, but got I
		//IL_053c: Expected O, but got I
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_0564: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_0597: Expected O, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05c4: Expected O, but got Ref
		//IL_05d9: Expected O, but got I
		//IL_05e9: Expected O, but got I
		//IL_05ff: Expected O, but got I
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0627: Expected O, but got I4
		//IL_0654: Expected O, but got I
		//IL_0664: Expected O, but got I
		//IL_067a: Expected O, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_06a2: Expected O, but got I4
		//IL_06d5: Expected O, but got I
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_0702: Expected O, but got Ref
		//IL_0717: Expected O, but got I
		//IL_0727: Expected O, but got I
		//IL_073d: Expected O, but got I
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Expected O, but got Unknown
		//IL_0765: Expected O, but got I4
		//IL_0792: Expected O, but got I
		//IL_07a2: Expected O, but got I
		//IL_07b8: Expected O, but got I
		//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c6: Expected O, but got Unknown
		//IL_07e0: Expected O, but got I4
		//IL_0813: Expected O, but got I
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0840: Expected O, but got Ref
		//IL_0853: Expected O, but got I
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_0872: Expected O, but got Ref
		//IL_087f: Expected O, but got Ref
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08b1: Expected O, but got Ref
		//IL_08be: Expected O, but got Ref
		//IL_08cc: Expected O, but got I
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_08eb: Expected O, but got Ref
		//IL_08f8: Expected O, but got Ref
		//IL_0947: Expected O, but got Ref
		//IL_0968: Expected O, but got Ref
		//IL_09b4: Expected O, but got I
		//IL_09c4: Expected O, but got I
		//IL_09da: Expected O, but got I
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got Unknown
		//IL_0a02: Expected O, but got I4
		//IL_0ad0: Expected O, but got I
		//IL_0ae0: Expected O, but got I
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected O, but got Unknown
		//IL_0b10: Expected O, but got I4
		//IL_0b28: Expected O, but got I
		//IL_0b5d: Expected O, but got I
		//IL_0b6d: Expected O, but got I
		//IL_0ba2: Expected O, but got Ref
		//IL_0bbb: Expected O, but got Ref
		//IL_0bc9: Expected O, but got Ref
		//IL_0a2a: Expected O, but got I
		//IL_0a3a: Expected O, but got I
		//IL_0a50: Expected O, but got I
		//IL_0a60: Expected O, but got I
		//IL_0a70: Expected O, but got I
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_1f2c: Expected O, but got Ref
		//IL_2249: Expected O, but got I
		//IL_2259: Expected O, but got I
		//IL_226f: Expected O, but got I
		//IL_2278: Unknown result type (might be due to invalid IL or missing references)
		//IL_227d: Expected O, but got Unknown
		//IL_2297: Expected O, but got I4
		//IL_0cd0: Expected O, but got I
		//IL_0ce0: Expected O, but got I
		//IL_0cf8: Expected O, but got I
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d06: Expected O, but got Unknown
		//IL_0d20: Expected O, but got I4
		//IL_0d38: Expected O, but got I
		//IL_0d48: Expected O, but got I
		//IL_0abb: Expected O, but got I
		//IL_1e4e: Expected O, but got I
		//IL_1e66: Expected O, but got I
		//IL_1e7c: Expected O, but got I
		//IL_1e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8a: Expected O, but got Unknown
		//IL_1ea2: Expected O, but got I4
		//IL_0d85: Expected O, but got I
		//IL_0da8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Expected O, but got Unknown
		//IL_0c0a: Expected O, but got I
		//IL_0c1a: Expected O, but got I
		//IL_0c30: Expected O, but got I
		//IL_0c40: Expected O, but got I
		//IL_0c50: Expected O, but got I
		//IL_0c68: Expected O, but got I
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_19b3: Expected O, but got I
		//IL_19cb: Expected O, but got I
		//IL_19e1: Expected O, but got I
		//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ef: Expected O, but got Unknown
		//IL_1a09: Expected O, but got I4
		//IL_1a12: Expected O, but got I4
		//IL_1a63: Expected O, but got I4
		//IL_1a83: Expected O, but got I
		//IL_1b08: Expected O, but got I
		//IL_1b18: Expected O, but got I
		//IL_1b2e: Expected O, but got I
		//IL_1b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3c: Expected O, but got Unknown
		//IL_1b56: Expected O, but got I4
		//IL_1ef9: Expected O, but got I4
		//IL_1f19: Expected O, but got I
		//IL_0dda: Expected O, but got I
		//IL_0dea: Expected O, but got I
		//IL_0e00: Expected O, but got I
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected O, but got Unknown
		//IL_0e28: Expected O, but got I4
		//IL_0cab: Expected O, but got I
		//IL_0cbb: Expected O, but got I
		//IL_2488: Expected O, but got I
		//IL_249e: Expected O, but got I
		//IL_24a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ac: Expected O, but got Unknown
		//IL_24c6: Expected O, but got I4
		//IL_0ef6: Expected O, but got I
		//IL_0f06: Expected O, but got I
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1c: Expected O, but got Unknown
		//IL_0f36: Expected O, but got I4
		//IL_0f4e: Expected O, but got I
		//IL_1b9a: Expected O, but got I
		//IL_1bba: Expected O, but got I
		//IL_1bca: Expected O, but got I
		//IL_1bd2: Expected I, but got O
		//IL_1bda: Expected I, but got O
		//IL_1bf4: Expected O, but got I
		//IL_1c16: Expected O, but got I4
		//IL_0f83: Expected O, but got I
		//IL_0f93: Expected O, but got I
		//IL_0fa6: Expected O, but got Ref
		//IL_0fca: Expected O, but got I
		//IL_0fda: Expected O, but got I
		//IL_0ff0: Expected O, but got I
		//IL_0ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected O, but got Unknown
		//IL_1018: Expected O, but got I4
		//IL_0e50: Expected O, but got I
		//IL_0e60: Expected O, but got I
		//IL_0e76: Expected O, but got I
		//IL_0e86: Expected O, but got I
		//IL_0e96: Expected O, but got I
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eac: Expected O, but got Unknown
		//IL_1dcc: Expected O, but got I4
		//IL_1dd5: Expected O, but got I4
		//IL_1045: Expected O, but got I
		//IL_1055: Expected O, but got I
		//IL_106b: Expected O, but got I
		//IL_1074: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Expected O, but got Unknown
		//IL_1093: Expected O, but got I4
		//IL_1f53: Expected O, but got I
		//IL_1f63: Expected O, but got I
		//IL_1f79: Expected O, but got I
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f87: Expected O, but got Unknown
		//IL_1fa1: Expected O, but got I4
		//IL_0ee1: Expected O, but got I
		//IL_1c94: Expected O, but got Ref
		//IL_10d7: Expected O, but got I
		//IL_10ea: Expected O, but got Ref
		//IL_1cbb: Expected O, but got I
		//IL_1113: Expected O, but got I
		//IL_1123: Expected O, but got I
		//IL_1139: Expected O, but got I
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_1147: Expected O, but got Unknown
		//IL_1161: Expected O, but got I4
		//IL_1d76: Expected O, but got I4
		//IL_1d7f: Expected O, but got I4
		//IL_1cfd: Expected O, but got Ref
		//IL_1d27: Expected O, but got I
		//IL_1fbf: Expected O, but got I
		//IL_1fcf: Expected O, but got I
		//IL_2003: Expected O, but got I
		//IL_2013: Unknown result type (might be due to invalid IL or missing references)
		//IL_2018: Expected O, but got Unknown
		//IL_2035: Expected O, but got Ref
		//IL_204e: Expected O, but got I4
		//IL_1c78: Expected O, but got I4
		//IL_1189: Expected O, but got I
		//IL_207f: Expected O, but got I
		//IL_2095: Expected O, but got I
		//IL_209e: Unknown result type (might be due to invalid IL or missing references)
		//IL_20a3: Expected O, but got Unknown
		//IL_20bd: Expected O, but got I4
		//IL_119e: Expected O, but got I
		//IL_11cf: Expected O, but got I
		//IL_11e9: Expected O, but got I
		//IL_11f9: Expected O, but got I
		//IL_120f: Expected O, but got I
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected O, but got Unknown
		//IL_1237: Expected O, but got I4
		//IL_1264: Expected O, but got I
		//IL_1274: Expected O, but got I
		//IL_128a: Expected O, but got I
		//IL_1293: Unknown result type (might be due to invalid IL or missing references)
		//IL_1298: Expected O, but got Unknown
		//IL_12b2: Expected O, but got I4
		//IL_20db: Expected O, but got I
		//IL_20eb: Expected O, but got I
		//IL_2101: Expected O, but got I
		//IL_210a: Unknown result type (might be due to invalid IL or missing references)
		//IL_210f: Expected O, but got Unknown
		//IL_2129: Expected O, but got I4
		//IL_12f6: Expected O, but got I
		//IL_1309: Expected O, but got Ref
		//IL_1317: Expected O, but got Ref
		//IL_1337: Expected O, but got I
		//IL_1351: Expected O, but got I4
		//IL_215b: Expected O, but got I
		//IL_2173: Expected O, but got I
		//IL_2189: Expected O, but got I
		//IL_2192: Unknown result type (might be due to invalid IL or missing references)
		//IL_2197: Expected O, but got Unknown
		//IL_21bf: Expected O, but got I4
		//IL_137f: Expected O, but got I
		//IL_138f: Expected O, but got I
		//IL_13a5: Expected O, but got I
		//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b3: Expected O, but got Unknown
		//IL_13cd: Expected O, but got I4
		//IL_197e: Expected O, but got I4
		//IL_199e: Expected O, but got I
		//IL_13fa: Expected O, but got I
		//IL_140a: Expected O, but got I
		//IL_1420: Expected O, but got I
		//IL_1429: Unknown result type (might be due to invalid IL or missing references)
		//IL_142e: Expected O, but got Unknown
		//IL_1448: Expected O, but got I4
		//IL_21dd: Expected O, but got I
		//IL_21ed: Expected O, but got I
		//IL_2203: Expected O, but got I
		//IL_220c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2211: Expected O, but got Unknown
		//IL_222b: Expected O, but got I4
		//IL_148c: Expected O, but got I
		//IL_149c: Expected O, but got I
		//IL_14aa: Expected O, but got Ref
		//IL_14f4: Expected O, but got I4
		//IL_151a: Expected O, but got I
		//IL_152a: Expected O, but got I
		//IL_1540: Expected O, but got I
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_154e: Expected O, but got Unknown
		//IL_1568: Expected O, but got I4
		//IL_22b5: Expected O, but got I
		//IL_22c5: Expected O, but got I
		//IL_22f9: Expected O, but got I
		//IL_2309: Unknown result type (might be due to invalid IL or missing references)
		//IL_230e: Expected O, but got Unknown
		//IL_232b: Expected O, but got Ref
		//IL_2344: Expected O, but got I4
		//IL_1590: Expected O, but got I
		//IL_2375: Expected O, but got I
		//IL_238b: Expected O, but got I
		//IL_239c: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a1: Expected O, but got Unknown
		//IL_23bb: Expected O, but got I4
		//IL_15a5: Expected O, but got I
		//IL_16ea: Expected O, but got I
		//IL_16fa: Expected O, but got I
		//IL_170b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Expected O, but got Unknown
		//IL_172a: Expected O, but got I4
		//IL_1742: Expected O, but got I
		//IL_167a: Expected O, but got I
		//IL_168a: Expected O, but got I
		//IL_1693: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected O, but got Unknown
		//IL_15d1: Expected O, but got I
		//IL_15e1: Expected O, but got I
		//IL_15f7: Expected O, but got I
		//IL_160f: Expected O, but got I
		//IL_161f: Expected O, but got I
		//IL_1630: Unknown result type (might be due to invalid IL or missing references)
		//IL_1635: Expected O, but got Unknown
		//IL_165c: Expected O, but got I
		//IL_176a: Expected O, but got I
		//IL_177a: Expected O, but got I
		//IL_1790: Expected O, but got I
		//IL_17a0: Expected O, but got I
		//IL_17b0: Expected O, but got I
		//IL_17b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17be: Expected O, but got Unknown
		//IL_17d8: Expected O, but got I4
		//IL_17f0: Expected O, but got I
		//IL_1800: Expected O, but got I
		//IL_183d: Expected O, but got I
		//IL_184d: Expected O, but got I
		//IL_1867: Expected O, but got I8
		//IL_1881: Expected O, but got I4
		//IL_16cd: Expected O, but got I
		//IL_2414: Expected O, but got I
		//IL_2424: Expected O, but got I
		//IL_243a: Expected O, but got I
		//IL_2443: Unknown result type (might be due to invalid IL or missing references)
		//IL_2448: Expected O, but got Unknown
		//IL_2462: Expected O, but got I4
		//IL_18c3: Expected O, but got I
		//IL_18d3: Expected O, but got I
		//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18eb: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		object obj4 = (nint)0 + (nint)309;
		object obj5 = obj4;
		object obj6 = obj4 & 1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		nint num;
		nint num3;
		nint num2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj8 = (nint)0 + (nint)309;
			obj5 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v183+C0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v211+F8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v212+FC]");
			num = 0;
			object obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			object obj12 = obj8 & 1;
			bool flag2 = obj12 == null;
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v212+FC]");
			num3 = 0;
			nint num4 = 0;
			if (!flag2)
			{
				goto IL_0123;
			}
		}
		else
		{
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v201 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v202+FC]");
			num = 0;
			object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			object obj15 = obj4 & 1;
			bool flag3 = obj15 == null;
			object obj16 = !flag3;
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v202+FC]");
			num3 = 0;
			nint num4 = 0;
			if (obj16 != null)
			{
				goto IL_0123;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj17 = (nint)0 + (nint)309;
		obj5 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v179+C0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v199+90]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v200+FC]");
		nint num6 = 0;
		object obj20 = obj17 & 1;
		bool flag4 = obj20 == null;
		object obj21 = !flag4;
		num = num3;
		num2 = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v200+FC]");
		nint num8 = 0;
		if (obj21 != null)
		{
			goto IL_0194;
		}
		goto IL_033d;
		IL_0b4d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X0_v60+C0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v84+F0]");
		object obj23 = 0;
		nint num9 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v390 @ X1_v16+10] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
		_ = 0;
		object obj25 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
		object obj28;
		object obj27 = obj28;
		nint num10 = num3;
		object obj29 = obj28;
		object obj58;
		object obj66 = default(object);
		object obj67;
		nint num11;
		nint num12;
		object obj70 = default(object);
		object obj99 = default(object);
		object obj118 = default(object);
		object obj135 = default(object);
		object obj142 = default(object);
		nint num14;
		object obj145 = default(object);
		object obj156 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v89+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v89+20]");
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32 & 1;
			bool flag5 = obj33 == null;
			object obj34 = !flag5;
			object obj39;
			object obj40;
			object obj42;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v52+20]");
				obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v52+20]");
				object obj36 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v160+C0]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v184+138]");
				object obj38 = 0;
				obj39 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
				obj40 = 0;
				object obj41 = obj36 & 1;
				if (obj41 == null)
				{
					goto IL_0d56;
				}
				obj28 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X9_v52+20]");
				object obj43 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v158+C0]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v181+138]");
				object obj45 = 0;
				obj39 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
				obj40 = 0;
				object obj46 = obj32 & 1;
				bool flag6 = obj46 == null;
				object obj47 = !flag6;
				obj28 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X8_v89+20]");
				object obj43 = 0;
				if (obj47 == null)
				{
					goto IL_0d56;
				}
			}
			goto IL_0d75;
			IL_180e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj48;
			obj28 = obj48;
			object obj50;
			object obj49 = obj50;
			goto IL_182d;
			IL_0f5c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj52;
			object obj51 = obj52;
			goto IL_0f73;
			IL_182d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1095 @ X0_v119+C0]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1097 @ X8_v153+70]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ X8_v154+28]");
			object obj55 = 0 & 0x80000000L;
			bool flag7 = obj55 == null;
			object obj56 = !flag7;
			object obj57 = obj58;
			if (obj56 == null)
			{
				obj57 = obj58;
			}
			num9 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X21_v25+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v158+20]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X8_v158+20]");
			object obj61 = (nint)0 + (nint)309;
			object obj62 = obj61 & 1;
			bool flag8 = obj62 == null;
			object obj63 = !flag8;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X0_v127+C0]");
			object obj64 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D0]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A38");
			object obj65 = obj66 & 1;
			bool flag9 = obj65 == null;
			obj27 = obj67;
			num10 = num8;
			if (flag9)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F0]");
			num11 = 0;
			obj27 = obj67;
			goto IL_2137;
			IL_0d56:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj28 = obj39;
			obj42 = obj40;
			goto IL_0d75;
			IL_0d75:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v67+C0]");
			object obj68 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v92+138]");
			num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v636 @ X27_v6 (should have been resolved before IL gen)");
			object obj69 = obj70 & 1;
			if (obj69 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v96+20]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v96+20]");
			object obj73 = (nint)0 + (nint)309;
			object obj74 = obj73 & 1;
			bool flag10 = obj74 == null;
			object obj75 = !flag10;
			if (obj75 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj76 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X9_v48+20]");
				obj72 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X9_v48+20]");
				object obj77 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v156+C0]");
				object obj78 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v178+100]");
				object obj79 = 0;
				obj52 = obj79;
				object obj80 = obj77 & 1;
				if (obj80 == null)
				{
					goto IL_0f5c;
				}
				obj51 = obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X9_v48+20]");
				object obj81 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v154+C0]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v175+100]");
				object obj83 = 0;
				obj52 = obj83;
				object obj84 = obj73 & 1;
				bool flag11 = obj84 == null;
				object obj85 = !flag11;
				obj51 = obj83;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v96+20]");
				object obj81 = 0;
				if (obj85 == null)
				{
					goto IL_0f5c;
				}
			}
			goto IL_0f73;
			IL_0f73:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X0_v72+C0]");
			object obj86 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X8_v99+100]");
			object obj87 = 0;
			object obj88 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X1_v20+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj89 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v101+20]");
			object obj90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v101+20]");
			object obj91 = (nint)0 + (nint)309;
			object obj92 = obj91 & 1;
			bool flag12 = obj92 == null;
			object obj93 = !flag12;
			if (obj93 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v78+C0]");
			object obj94 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v104+90]");
			object obj95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v104+90]");
			object obj96 = (nint)0 + (nint)309;
			object obj97 = obj96 & 1;
			bool flag13 = obj97 == null;
			object obj98 = !flag13;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				obj95 = obj99;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v107+20]");
			object obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v107+20]");
			object obj102 = (nint)0 + (nint)309;
			object obj103 = obj102 & 1;
			bool flag14 = obj103 == null;
			object obj104 = !flag14;
			if (obj104 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v81+C0]");
			object obj105 = 0;
			object obj106 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj107 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X21_v16+20]");
			object obj108 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X21_v16+20]");
			object obj109 = (nint)0 + (nint)309;
			object obj110 = obj109 & 1;
			bool flag15 = obj110 == null;
			object obj111 = !flag15;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				obj107 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v87+C0]");
			object obj112 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v113+70]");
			object obj113 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v114+28]");
			bool flag16 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v114+28]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v114+28]");
			object obj114 = num13 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v114+28]");
			object obj115 = 0 & obj114;
			bool flag17 = (nint)obj115 < 0;
			object obj116 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
			bool flag18 = flag16 == flag17;
			object obj117 = !flag18;
			obj118 = ~obj117;
			if (obj118 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
				object obj119 = 0;
			}
			else
			{
				object obj119 = obj116;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X21_v16+20]");
			object obj120 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X21_v16+20]");
			object obj121 = (nint)0 + (nint)309;
			object obj122 = obj121 & 1;
			bool flag19 = obj122 == null;
			object obj123 = !flag19;
			if (obj123 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v91+C0]");
			object obj124 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj125 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v120+20]");
			object obj126 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v120+20]");
			object obj127 = (nint)0 + (nint)309;
			object obj128 = obj127 & 1;
			bool flag20 = obj128 == null;
			object obj129 = !flag20;
			if (obj129 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X0_v95+C0]");
			object obj130 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X8_v123+70]");
			object obj131 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X8_v123+70]");
			object obj132 = (nint)0 + (nint)309;
			object obj133 = obj132 & 1;
			bool flag21 = obj133 == null;
			object obj134 = !flag21;
			if (obj134 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				obj131 = obj135;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj136 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v126+20]");
			object obj137 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X8_v126+20]");
			object obj138 = (nint)0 + (nint)309;
			object obj139 = obj138 & 1;
			bool flag22 = obj139 == null;
			object obj140 = !flag22;
			if (obj140 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X0_v98+C0]");
			object obj141 = 0;
			obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			obj142 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 153));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-99]");
			object obj143 = (nint)0 & (nint)1;
			bool flag23 = obj143 == null;
			object obj144 = !flag23;
			num9 = num14;
			obj28 = obj145;
			object obj177;
			object obj175;
			object obj195;
			if (obj144 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj146 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v135+20]");
				object obj147 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X8_v135+20]");
				object obj148 = (nint)0 + (nint)309;
				object obj149 = obj148 & 1;
				bool flag24 = obj149 == null;
				object obj150 = !flag24;
				if (obj150 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v108+C0]");
				object obj151 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v138+90]");
				object obj152 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v138+90]");
				object obj153 = (nint)0 + (nint)309;
				object obj154 = obj153 & 1;
				bool flag25 = obj154 == null;
				object obj155 = !flag25;
				if (obj155 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					obj152 = obj156;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj157 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v141+20]");
				object obj158 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X8_v141+20]");
				object obj159 = (nint)0 + (nint)309;
				object obj160 = obj159 & 1;
				bool flag26 = obj160 == null;
				object obj161 = !flag26;
				if (obj161 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X0_v111+C0]");
				object obj162 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v144+130]");
				obj29 = 0;
				obj142 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
				num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
				bool flag27 = (nint)0 == 0;
				obj27 = 0;
				num9 = num11;
				if (flag27)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj163 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X21_v24+20]");
				object obj164 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X21_v24+20]");
				object obj165 = (nint)0 + (nint)309;
				object obj166 = obj165 & 1;
				bool flag28 = obj166 == null;
				object obj167 = !flag28;
				if (obj167 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
					obj163 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X0_v115+C0]");
				object obj168 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ X8_v147+70]");
				object obj169 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v148+28]");
				bool flag29 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v148+28]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v148+28]");
				object obj170 = num15 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1026 @ X8_v148+28]");
				object obj171 = 0 & obj170;
				bool flag30 = (nint)obj171 < 0;
				object obj172 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
				bool flag31 = flag29 == flag30;
				object obj173 = !flag31;
				obj118 = ~obj173;
				if (obj118 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
					object obj174 = 0;
				}
				else
				{
					object obj174 = obj172;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X21_v24+20]");
				obj175 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X21_v24+20]");
				object obj176 = (nint)0 + (nint)309;
				obj177 = obj176;
				object obj178 = obj176 & 1;
				bool flag32 = obj178 == null;
				object obj179 = !flag32;
				if (obj179 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
					object obj180 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X9_v44+20]");
					obj175 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X9_v44+20]");
					object obj181 = (nint)0 + (nint)309;
					obj177 = obj181;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v137+C0]");
					object obj182 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v172+78]");
					object obj183 = 0;
					obj48 = obj183;
					object obj184 = obj181 & 1;
					bool flag33 = obj184 == null;
					obj28 = obj183;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X9_v44+20]");
					object obj185 = 0;
					if (!flag33)
					{
						goto IL_166a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X0_v131+C0]");
					object obj186 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X8_v167+78]");
					object obj187 = 0;
					obj48 = obj187;
					object obj188 = obj176 & 1;
					bool flag34 = obj188 == null;
					object obj189 = !flag34;
					obj28 = obj187;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X21_v24+20]");
					object obj185 = 0;
					if (obj189 != null)
					{
						goto IL_166a;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj190 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X9_v40+20]");
				obj175 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X9_v40+20]");
				object obj191 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X0_v134+C0]");
				object obj192 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v166+78]");
				obj50 = 0;
				object obj193 = obj191 & 1;
				bool flag35 = obj193 == null;
				object obj194 = !flag35;
				obj48 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v166+78]");
				obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X9_v40+20]");
				obj195 = 0;
				if (obj194 == null)
				{
					goto IL_180e;
				}
				goto IL_182d;
			}
			goto IL_2137;
			IL_166a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1090 @ X0_v131+C0]");
			object obj196 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v170+78]");
			obj50 = 0;
			object obj197 = obj177 & 1;
			if (obj197 == null)
			{
				goto IL_180e;
			}
			obj28 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v170+78]");
			obj49 = 0;
			obj195 = obj175;
			goto IL_182d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
		object obj198 = 0;
		object obj199 = obj198;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v93+20]");
		object obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v93+20]");
		object obj201 = (nint)0 + (nint)309;
		object obj202 = obj201 & 1;
		bool flag36 = obj202 == null;
		object obj203 = !flag36;
		object obj204 = 6;
		object obj205 = obj118;
		object obj206 = obj142;
		object obj207 = obj27;
		IntPtr intPtr = num10;
		IntPtr intPtr2 = num9;
		IntPtr intPtr3 = num11;
		object obj208 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v92+138]");
		nint num16 = 0;
		object obj209 = 6;
		object obj210 = obj198;
		IntPtr intPtr4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X8_v93+20]");
		object obj211 = 0;
		if (obj203 == null)
		{
			goto IL_1a91;
		}
		goto IL_1af8;
		IL_1d5b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		obj118 = obj205;
		obj142 = 0;
		obj27 = 0;
		num11 = intPtr3;
		obj28 = obj208;
		num3 = intPtr4;
		goto IL_1d9c;
		IL_0b36:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj213;
		object obj212 = obj213;
		goto IL_0b4d;
		IL_0123:
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v208 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj214 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v209+FC]");
		num6 = 0;
		object obj215 = obj5 & 1;
		bool flag37 = obj215 == null;
		num3 = num;
		num7 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v209+FC]");
		num8 = 0;
		if (!flag37)
		{
			goto IL_0194;
		}
		goto IL_033d;
		IL_033d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj216 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v176+C0]");
		object obj217 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v195+70]");
		object obj218 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v196+FC]");
		object obj219 = 0;
		object obj220 = obj216 & 1;
		bool flag38 = obj220 == null;
		object obj221 = !flag38;
		num = num3;
		num2 = 0;
		num6 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v196+FC]");
		object obj222 = 0;
		if (obj221 == null)
		{
			goto IL_03df;
		}
		goto IL_0406;
		IL_0194:
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v205 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj223 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v206+FC]");
		obj219 = 0;
		object obj224 = obj5 & 1;
		if (obj224 == null)
		{
			goto IL_03df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v206+FC]");
		obj222 = 0;
		num3 = num;
		num8 = num6;
		goto IL_0406;
		IL_03df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj222 = obj219;
		num3 = num;
		num8 = num6;
		goto IL_0406;
		IL_1df2:
		OutOfMemoryException ex2;
		OutOfMemoryException ex = ex2;
		OutOfMemoryException ex3 = default(OutOfMemoryException);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			if (num12 == 1)
			{
				break;
			}
			object obj225 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D3AC08");
			ex = ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
		obj198 = 0;
		object obj226 = obj198;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v60+20]");
		obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v60+20]");
		object obj227 = (nint)0 + (nint)309;
		object obj228 = obj227 & 1;
		bool flag39 = obj228 == null;
		obj204 = 0;
		if (flag39)
		{
			goto IL_1a91;
		}
		obj205 = obj118;
		obj206 = obj142;
		obj207 = obj27;
		intPtr = num10;
		intPtr2 = num9;
		intPtr3 = num11;
		obj208 = obj28;
		num16 = num12;
		obj209 = 0;
		obj210 = obj198;
		intPtr4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v60+20]");
		obj211 = 0;
		goto IL_1af8;
		IL_0406:
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj229 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj230 = (nint)0 + (nint)309;
		object obj231 = obj230 & 1;
		bool flag40 = obj231 == null;
		object obj232 = !flag40;
		if (obj232 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v4+FC]");
		object obj233 = (nint)0 + (nint)16;
		object obj234 = obj233 + 15;
		object obj235 = obj234 & 0x1FFFFFFF0L;
		object obj237 = default(object);
		object obj236 = (ref *(?*)(&obj237)) - (ref *(?*)obj235);
		object obj238 = (nint)0 + (nint)309;
		object obj239 = obj238 & 1;
		bool flag41 = obj239 == null;
		object obj240 = !flag41;
		if (obj240 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj241 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v16 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj242 = (nint)0 + (nint)309;
		object obj243 = obj242 & 1;
		bool flag42 = obj243 == null;
		object obj244 = !flag42;
		if (obj244 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v8+FC]");
		object obj245 = (nint)0 + (nint)16;
		object obj246 = obj245 + 15;
		object obj247 = obj246 & 0x1FFFFFFF0L;
		object obj248 = (ref *(?*)(&obj237)) - (ref *(?*)obj247);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
		object obj249 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v24+20]");
		object obj250 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v24+20]");
		object obj251 = (nint)0 + (nint)309;
		object obj252 = obj251 & 1;
		bool flag43 = obj252 == null;
		object obj253 = !flag43;
		if (obj253 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v10+C0]");
		object obj254 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v27+70]");
		object obj255 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v27+70]");
		object obj256 = (nint)0 + (nint)309;
		object obj257 = obj256 & 1;
		bool flag44 = obj257 == null;
		object obj258 = !flag44;
		if (obj258 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v12+FC]");
		object obj259 = (nint)0 + (nint)16;
		object obj260 = obj259 + 15;
		object obj261 = obj260 & 0x1FFFFFFF0L;
		object obj262 = (ref *(?*)(&obj237)) - (ref *(?*)obj261);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
		object obj263 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v35+20]");
		object obj264 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v35+20]");
		object obj265 = (nint)0 + (nint)309;
		object obj266 = obj265 & 1;
		bool flag45 = obj266 == null;
		object obj267 = !flag45;
		if (obj267 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v14+C0]");
		object obj268 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v38+90]");
		object obj269 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v38+90]");
		object obj270 = (nint)0 + (nint)309;
		object obj271 = obj270 & 1;
		bool flag46 = obj271 == null;
		object obj272 = !flag46;
		if (obj272 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v16+FC]");
		object obj273 = (nint)0 + (nint)16;
		object obj274 = obj273 + 15;
		object obj275 = obj274 & 0x1FFFFFFF0L;
		object obj276 = (ref *(?*)(&obj237)) - (ref *(?*)obj275);
		object obj277 = num8 + 15;
		object obj278 = obj277 & 0x1FFFFFFF0L;
		obj67 = (ref *(?*)(&obj237)) - (ref *(?*)obj278);
		object obj279 = (ref *(?*)(&obj237)) - (ref *(?*)obj278);
		object obj280 = obj222 + 15;
		object obj281 = obj280 & 0x1FFFFFFF0L;
		obj58 = (ref *(?*)(&obj237)) - (ref *(?*)obj281);
		object obj282 = (ref *(?*)(&obj237)) - (ref *(?*)obj281);
		object obj283 = num3 + 15;
		object obj284 = obj283 & 0x1FFFFFFF0L;
		obj28 = (ref *(?*)(&obj237)) - (ref *(?*)obj284);
		object obj285 = (ref *(?*)(&obj237)) - (ref *(?*)obj284);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		num11 = (ref *(?*)(&obj237)) - (ref *(?*)obj278);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		num14 = (ref *(?*)(&obj237)) - (ref *(?*)obj281);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		object obj286 = (ref *(?*)(&obj237)) - (ref *(?*)obj278);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		object obj287 = (ref *(?*)(&obj237)) - (ref *(?*)obj278);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F8]");
		bool flag47 = (nint)0 == 0;
		num12 = num8;
		if (!flag47)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj288 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v81+20]");
			object obj289 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v81+20]");
			object obj290 = (nint)0 + (nint)309;
			object obj291 = obj290 & 1;
			bool flag48 = obj291 == null;
			object obj292 = !flag48;
			if (obj292 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
				object obj293 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X9_v56+20]");
				obj289 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X9_v56+20]");
				object obj294 = (nint)0 + (nint)309;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v164+C0]");
				object obj295 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v190+F0]");
				object obj296 = 0;
				obj213 = obj296;
				object obj297 = obj294 & 1;
				if (obj297 == null)
				{
					goto IL_0b36;
				}
				obj212 = obj296;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X9_v56+20]");
				object obj298 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v162+C0]");
				object obj299 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v187+F0]");
				object obj300 = 0;
				obj213 = obj300;
				object obj301 = obj290 & 1;
				bool flag49 = obj301 == null;
				object obj302 = !flag49;
				obj212 = obj300;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v81+20]");
				object obj298 = 0;
				if (obj302 == null)
				{
					goto IL_0b36;
				}
			}
			goto IL_0b4d;
		}
		goto IL_1d9c;
		IL_1cab:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj303 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
		bool flag50 = obj303 != null;
		TData val2;
		TData val = val2;
		if (!flag50)
		{
			goto IL_1cea;
		}
		goto IL_1d5b;
		IL_1af8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X0_v38+C0]");
		object obj304 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v65+F8]");
		object obj305 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v65+F8]");
		object obj306 = (nint)0 + (nint)309;
		object obj307 = obj306 & 1;
		bool flag51 = obj307 == null;
		object obj308 = !flag51;
		if (obj308 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj309 = default(object);
			obj305 = obj309;
		}
		object obj310 = obj210;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v68+20]");
		object obj311 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v68+20]");
		object obj312 = (nint)0 + (nint)309;
		object obj313 = obj312 & 1;
		bool flag52 = obj313 == null;
		object obj314 = !flag52;
		if (obj314 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X0_v41+C0]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v71+140]");
		num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
		object obj316 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
		object obj317 = 0;
		num10 = (nint)obj316;
		num9 = (nint)obj317;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
		val2 = (TData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
		bool flag53 = (nint)0 == 0;
		object obj318 = !flag53;
		if (obj318 == null)
		{
			if ((nint)obj209 != 6)
			{
				if ((nint)obj209 == 5)
				{
					object obj319 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-100]");
					num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
					object obj320 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
					bool flag54 = obj320 == null;
					num10 = num8;
					val = val2;
					if (flag54)
					{
						goto IL_1cea;
					}
					goto IL_1d5b;
				}
				bool flag55 = obj209 == null;
				object obj321 = !flag55;
				if (obj321 != null)
				{
					goto IL_1cab;
				}
			}
			object obj322 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
			num12 = num8;
			goto IL_1cab;
		}
		ex2 = new OutOfMemoryException();
		obj118 = obj205;
		obj142 = 0;
		obj27 = 0;
		num11 = intPtr3;
		obj28 = obj208;
		num3 = intPtr4;
		goto IL_1df2;
		IL_2137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
		obj198 = 0;
		object obj323 = obj198;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v132+20]");
		obj200 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v132+20]");
		object obj324 = (nint)0 + (nint)309;
		object obj325 = obj324 & 1;
		bool flag56 = obj325 == null;
		num10 = num8;
		num12 = num11;
		obj204 = 5;
		if (flag56)
		{
			goto IL_1a91;
		}
		obj205 = obj118;
		obj206 = obj142;
		obj207 = obj27;
		intPtr = num8;
		intPtr2 = num9;
		intPtr3 = num11;
		obj208 = obj28;
		num16 = num11;
		obj209 = 5;
		obj210 = obj198;
		intPtr4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1008 @ X8_v132+20]");
		obj211 = 0;
		goto IL_1af8;
		IL_1cea:
		return val2;
		IL_1d9c:
		NullReferenceException ex4 = new NullReferenceException();
		ex2 = (OutOfMemoryException)(object)ex4;
		goto IL_1df2;
		IL_1a91:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj205 = obj118;
		obj206 = obj142;
		obj207 = obj27;
		intPtr = num10;
		intPtr2 = num9;
		intPtr3 = num11;
		obj208 = obj28;
		num16 = num12;
		obj209 = obj204;
		obj210 = obj198;
		intPtr4 = num3;
		goto IL_1af8;
	}

	protected unsafe void RecycleRecursively(TData datum)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_011c: Expected O, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_060b: Expected O, but got Ref
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_0633: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_0c59: Expected O, but got I
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected O, but got Unknown
		//IL_0c74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c79: Expected O, but got Unknown
		//IL_0c86: Expected O, but got Ref
		//IL_0c96: Expected O, but got I
		//IL_0cac: Expected O, but got I
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected O, but got Unknown
		//IL_0cd9: Expected O, but got I4
		//IL_0657: Expected O, but got I
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected O, but got Unknown
		//IL_0684: Expected O, but got Ref
		//IL_069f: Expected O, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_06be: Expected O, but got Ref
		//IL_06cb: Expected O, but got Ref
		//IL_06e1: Expected O, but got I
		//IL_06f7: Expected O, but got I
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_0716: Expected O, but got Ref
		//IL_072c: Expected O, but got I
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_074b: Expected O, but got Ref
		//IL_0758: Expected O, but got Ref
		//IL_077d: Expected O, but got I
		//IL_0793: Expected O, but got I
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07c3: Expected O, but got I4
		//IL_0186: Expected O, but got I
		//IL_07e1: Expected O, but got I
		//IL_0815: Expected O, but got I
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_0847: Expected O, but got Ref
		//IL_0860: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_088a: Expected O, but got Ref
		//IL_01a1: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_01e3: Expected O, but got I8
		//IL_01fd: Expected O, but got I4
		//IL_08b3: Expected I, but got O
		//IL_08c8: Expected O, but got I
		//IL_08d6: Expected O, but got Ref
		//IL_08f6: Expected O, but got I
		//IL_090c: Expected O, but got I
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_093c: Expected O, but got I4
		//IL_025b: Expected O, but got I
		//IL_0b91: Expected O, but got Ref
		//IL_095a: Expected O, but got I
		//IL_098e: Expected O, but got I
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_09c0: Expected O, but got Ref
		//IL_09d9: Expected O, but got I4
		//IL_0240: Expected O, but got I
		//IL_09fe: Expected O, but got Ref
		//IL_0a18: Expected O, but got I
		//IL_0a38: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bc8: Expected O, but got I
		//IL_0bd8: Expected O, but got I
		//IL_0be8: Expected O, but got I
		//IL_0bfe: Expected O, but got I
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected O, but got Unknown
		//IL_0c26: Expected O, but got I4
		//IL_048c: Expected O, but got I
		//IL_0ab5: Expected O, but got I
		//IL_0ac5: Expected O, but got I
		//IL_0ad5: Expected O, but got I
		//IL_0af9: Expected O, but got I4
		//IL_0b02: Expected O, but got I4
		//IL_0b0b: Expected O, but got I4
		//IL_0b1c: Expected O, but got I4
		//IL_0b35: Expected O, but got I4
		//IL_0b45: Expected O, but got I
		//IL_0b55: Expected O, but got I
		//IL_0b65: Expected O, but got I
		//IL_029e: Expected O, but got I
		//IL_02b1: Expected O, but got Ref
		//IL_02cb: Expected O, but got I
		//IL_02e3: Expected O, but got Ref
		//IL_02fc: Expected O, but got Ref
		//IL_030a: Expected O, but got Ref
		//IL_0457: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_0477: Expected O, but got I
		//IL_0cfd: Expected O, but got I
		//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_0339: Expected O, but got I
		//IL_0349: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_0369: Expected O, but got I
		//IL_037c: Expected O, but got Ref
		//IL_03a0: Expected O, but got I
		//IL_03b0: Expected O, but got I
		//IL_03c0: Expected O, but got I
		//IL_03d0: Expected O, but got I
		//IL_03ea: Expected O, but got I8
		//IL_0404: Expected O, but got I4
		//IL_0a5e: Expected O, but got I
		//IL_0a71: Expected O, but got Ref
		//IL_0a9b: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6;
		object obj8 = obj6 & 1;
		bool flag = obj8 == null;
		object obj9 = !flag;
		object obj10;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v55+FC]");
			obj10 = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v72 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v72 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj11 = (nint)0 + (nint)309;
			obj7 = obj11;
			nint num3 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
			obj10 = 0;
			nint num3 = 0;
		}
		object obj12 = obj10 + 16;
		object obj13 = obj12 + 15;
		object obj14 = obj13 & 0x1FFFFFFF0L;
		object obj15 = default(object);
		NestedListViewController<TData, TItem, TIndex> nestedListViewController = (NestedListViewController<TData, TItem, TIndex>)((ref *(?*)(&obj15)) - (ref *(?*)obj14));
		object obj16 = obj7 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
		object obj18 = (nint)0 + (nint)16;
		object obj19 = obj18 + 15;
		object obj20 = obj19 & 0x1FFFFFFF0L;
		object obj21 = (ref *(?*)(&obj15)) - (ref *(?*)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag3 = obj24 == null;
		object obj25 = !flag3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+FC]");
		object obj26 = (nint)0 + (nint)16;
		object obj27 = obj26 + 15;
		object obj28 = obj27 & 0x1FFFFFFF0L;
		object obj29 = (ref *(?*)(&obj15)) - (ref *(?*)obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
		object obj30 = (nint)0 + (nint)15;
		object obj31 = obj30 & 0x1FFFFFFF0L;
		object obj32 = (ref *(?*)(&obj15)) - (ref *(?*)obj31);
		object obj33 = (ref *(?*)(&obj15)) - (ref *(?*)obj31);
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v16 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v17+FC]");
		object obj35 = (nint)0 + (nint)15;
		object obj36 = obj35 & 0x1FFFFFFF0L;
		object obj37 = (ref *(?*)(&obj15)) - (ref *(?*)obj36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
		object obj38 = (nint)0 + (nint)15;
		object obj39 = obj38 & 0x1FFFFFFF0L;
		object obj40 = (ref *(?*)(&obj15)) - (ref *(?*)obj39);
		object obj41 = (ref *(?*)(&obj15)) - (ref *(?*)obj39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X9_v17 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X9_v17 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj43 = (nint)0 + (nint)309;
		object obj44 = obj43;
		object obj45 = obj43 & 1;
		bool flag4 = obj45 == null;
		object obj46 = !flag4;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v37 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj42 = 0;
			nint num7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X9_v17 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj47 = 0;
			nint num7 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X9_v18 (Il2CppRgctx<ListView.NestedListViewController`3>)+118]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v24+28]");
		bool flag5 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v24+28]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v24+28]");
		object obj49 = num8 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v24+28]");
		object obj50 = 0 & obj49;
		bool flag6 = (nint)obj50 < 0;
		object obj51 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
		bool flag7 = flag5 == flag6;
		object obj52 = !flag7;
		object obj53 = ~obj52;
		object obj54;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			obj54 = 0;
		}
		else
		{
			obj54 = obj51;
		}
		object obj55 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		object obj59;
		object obj67;
		object obj72;
		NestedListViewController<TData, TItem, TIndex> nestedListViewController2;
		object obj74;
		nint num15;
		IntPtr intPtr = default(IntPtr);
		object obj93;
		NestedListViewController<TData, TItem, TIndex> nestedListViewController3;
		object obj73;
		if ((object)this != null)
		{
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v40 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v41+28]");
			object obj57 = 0 & 0x80000000L;
			bool flag8 = obj57 == null;
			object obj58 = !flag8;
			obj59 = obj37;
			if (obj58 == null)
			{
				obj59 = obj37;
			}
			nint num10 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v43 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+2D0]");
			object obj60 = 0;
			object obj61 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X1_v8+10] (should have been resolved before IL gen)");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X9_v29 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X9_v29 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj63 = (nint)0 + (nint)309;
			obj44 = obj63;
			object obj64 = obj63 & 1;
			bool flag9 = obj64 == null;
			object obj65 = !flag9;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X9_v36 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				obj62 = 0;
				nint num13 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X9_v29 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				object obj66 = 0;
				nint num13 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X9_v30 (Il2CppRgctx<ListView.NestedListViewController`3>)+130]");
			obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v47+28]");
			bool flag10 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v47+28]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v47+28]");
			object obj68 = num14 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v47+28]");
			object obj69 = 0 & obj68;
			bool flag11 = (nint)obj69 < 0;
			object obj70 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
			bool flag12 = flag10 == flag11;
			object obj71 = !flag12;
			obj53 = ~obj71;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				obj72 = 0;
			}
			else
			{
				obj72 = obj70;
			}
			obj73 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
			nestedListViewController2 = (NestedListViewController<TData, TItem, TIndex>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
			bool flag13 = (nint)0 == 0;
			obj74 = 0;
			num15 = intPtr;
			if (flag13)
			{
				goto IL_047c;
			}
			nint num16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v51 (Il2CppRgctx<ListView.NestedListViewController`3>)+F0]");
			object obj75 = 0;
			obj54 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ X1_v10+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
			nestedListViewController3 = (NestedListViewController<TData, TItem, TIndex>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			object obj76 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
			_ = 0;
			object obj77 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
			object obj78 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 160));
			obj55 = obj40;
			num15 = intPtr;
			object obj80 = default(object);
			while (true)
			{
				nint num17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v57 (Il2CppRgctx<ListView.NestedListViewController`3>)+138]");
				obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v457 @ X1_v3] (should have been resolved before IL gen)");
				object obj79 = obj80 & 1;
				if (obj79 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				object obj81 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v59+20]");
				object obj82 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v60+C0]");
				object obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v61+100]");
				object obj84 = 0;
				object obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v476 @ X1_v14+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v63+20]");
				object obj87 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v64+C0]");
				object obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v65+90]");
				object obj89 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X9_v34+28]");
				object obj90 = 0 & 0x80000000L;
				bool flag14 = obj90 == null;
				object obj91 = !flag14;
				obj55 = obj33;
				if (obj91 == null)
				{
					obj55 = obj33;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v65+148]");
				object obj92 = 0;
				obj54 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X1_v16+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
				obj41 = 0;
				nestedListViewController3 = this;
			}
			obj37 = obj59;
			obj93 = 0;
			goto IL_0ba8;
		}
		NullReferenceException ex = new NullReferenceException();
		obj73 = obj37;
		nestedListViewController3 = nestedListViewController;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		num15 = intPtr;
		goto IL_0577;
		IL_0ba8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v28+20]");
		object obj95 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v29+C0]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31+F8]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31+F8]");
		object obj98 = (nint)0 + (nint)309;
		object obj99 = obj98 & 1;
		bool flag15 = obj99 == null;
		object obj100 = !flag15;
		if (obj100 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			object obj101 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v32+20]");
			object obj102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v33+C0]");
			obj96 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31+140]");
		obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
		obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
		nestedListViewController2 = (NestedListViewController<TData, TItem, TIndex>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		bool flag16 = obj93 == null;
		object obj103 = !flag16;
		obj73 = 0;
		obj74 = 0;
		obj59 = obj37;
		object obj104 = 0;
		object obj105 = obj53;
		object obj106 = obj41;
		obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v31+140]");
		obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
		nestedListViewController3 = (NestedListViewController<TData, TItem, TIndex>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
		obj54 = 0;
		object obj107 = obj44;
		IntPtr intPtr2 = num15;
		if (obj103 == null)
		{
			goto IL_047c;
		}
		goto IL_0541;
		IL_047c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		if (obj108 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		obj104 = obj73;
		obj105 = obj53;
		obj106 = obj41;
		obj55 = obj74;
		obj48 = obj67;
		nestedListViewController3 = nestedListViewController2;
		obj37 = obj59;
		obj54 = obj72;
		obj107 = obj44;
		intPtr2 = num15;
		goto IL_0541;
		IL_0577:
		OutOfMemoryException ex3 = ex2;
		OutOfMemoryException ex4 = default(OutOfMemoryException);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			if ((nint)obj48 == 1)
			{
				break;
			}
			object obj109 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D3ACE4");
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		object obj110 = default(object);
		obj93 = obj110;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		goto IL_0ba8;
		IL_0541:
		ex2 = new OutOfMemoryException();
		obj73 = obj104;
		obj53 = obj105;
		obj41 = obj106;
		obj44 = obj107;
		num15 = intPtr2;
		goto IL_0577;
	}

	protected override void UpdateItems()
	{
		//IL_0031: Expected O, but got I
		int order = default(int);
		float offset = default(float);
		bool doneSettling = default(bool);
		UpdateNestedItems(ref order, ref offset, ref doneSettling, 0);
		bool num = doneSettling;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+48]");
		object obj = (nint)(num ? 1 : 0) & (nint)0;
		if (obj != null)
		{
			base.EndSettling();
		}
	}

	protected unsafe virtual void UpdateNestedItems(ref int order, ref float offset, ref bool doneSettling, int depth = 0)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0016: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_0043: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_0125: Expected O, but got I
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected O, but got Unknown
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected O, but got Unknown
		//IL_0e40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e45: Expected O, but got Unknown
		//IL_0e52: Expected O, but got Ref
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Expected O, but got Unknown
		//IL_0e7f: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0ea3: Expected O, but got I
		//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0ebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0ed0: Expected O, but got Ref
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected O, but got Unknown
		//IL_0efd: Expected O, but got I4
		//IL_014a: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_01d4: Expected O, but got Ref
		//IL_01e2: Expected O, but got Ref
		//IL_01fd: Expected O, but got I
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0232: Expected O, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025e: Expected O, but got Ref
		//IL_028f: Expected O, but got Ref
		//IL_02da: Expected O, but got Ref
		//IL_0334: Expected O, but got I
		//IL_034f: Expected O, but got Ref
		//IL_038a: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_040f: Expected O, but got I
		//IL_0da6: Expected O, but got I
		//IL_059c: Expected O, but got Ref
		//IL_05bf: Expected O, but got I
		//IL_0672: Expected O, but got I
		//IL_0685: Expected O, but got Ref
		//IL_069d: Expected O, but got Ref
		//IL_06c7: Expected O, but got I
		//IL_06dd: Expected O, but got I
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_0705: Expected O, but got I4
		//IL_0424: Expected O, but got I
		//IL_07a1: Expected O, but got I
		//IL_07b1: Expected O, but got I
		//IL_07cb: Expected O, but got I8
		//IL_07e5: Expected O, but got I4
		//IL_0f51: Expected O, but got I
		//IL_0f5f: Expected O, but got Ref
		//IL_0fa5: Expected O, but got I
		//IL_0fbf: Expected O, but got I4
		//IL_1278: Expected O, but got I
		//IL_12a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Expected O, but got Unknown
		//IL_12c0: Expected O, but got I4
		//IL_103f: Expected O, but got I4
		//IL_1047: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected O, but got Unknown
		//IL_0a19: Expected O, but got I
		//IL_0a31: Expected O, but got Ref
		//IL_0a41: Expected O, but got I
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0a6d: Expected O, but got I
		//IL_0a7d: Expected O, but got I
		//IL_0a97: Expected O, but got I8
		//IL_0ab1: Expected O, but got I4
		//IL_0885: Expected O, but got I
		//IL_0895: Expected O, but got I
		//IL_08af: Expected O, but got I8
		//IL_08c9: Expected O, but got I4
		//IL_1091: Expected O, but got Ref
		//IL_10a3: Expected I, but got O
		//IL_10b6: Expected O, but got Ref
		//IL_10c9: Expected O, but got Ref
		//IL_10dc: Expected O, but got Ref
		//IL_10ef: Expected O, but got Ref
		//IL_111c: Expected O, but got I
		//IL_09a2: Expected O, but got I
		//IL_09b2: Expected O, but got I
		//IL_09cc: Expected O, but got I8
		//IL_09e6: Expected O, but got I4
		//IL_0fdd: Expected O, but got I
		//IL_0ff6: Expected O, but got Ref
		//IL_12e5: Expected O, but got Ref
		//IL_12ff: Expected O, but got I
		//IL_130f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1314: Expected O, but got Unknown
		//IL_1332: Expected O, but got I
		//IL_1348: Expected O, but got I
		//IL_1351: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Expected O, but got Unknown
		//IL_1370: Expected O, but got I4
		//IL_105f: Expected I, but got O
		//IL_1074: Expected O, but got I
		//IL_112a: Unknown result type (might be due to invalid IL or missing references)
		//IL_112f: Expected O, but got Unknown
		//IL_0bb0: Expected O, but got Ref
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_0bd6: Expected O, but got Ref
		//IL_0b33: Expected O, but got I
		//IL_0b4d: Expected O, but got I8
		//IL_0b67: Expected O, but got I4
		//IL_0c44: Expected O, but got I
		//IL_0c54: Expected O, but got I
		//IL_0c6f: Expected O, but got Ref
		//IL_0c82: Expected O, but got Ref
		//IL_0c90: Expected O, but got Ref
		//IL_0cbc: Expected O, but got I
		//IL_0cd2: Expected O, but got I
		//IL_0cec: Expected O, but got I4
		//IL_0635: Expected O, but got I
		//IL_119e: Expected O, but got I
		//IL_11ba: Expected O, but got Ref
		//IL_11ff: Expected O, but got Ref
		//IL_1217: Expected O, but got Ref
		//IL_122d: Expected O, but got I
		//IL_0d3b: Expected O, but got I
		//IL_0d56: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj5 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8;
		object obj10 = obj8 & 1;
		bool flag = obj10 == null;
		object obj11 = !flag;
		object obj12;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v80+FC]");
			obj12 = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v51 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v51 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj13 = (nint)0 + (nint)309;
			obj9 = obj13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+FC]");
			obj12 = 0;
		}
		object obj14 = obj12 + 16;
		object obj15 = obj14 + 15;
		object obj16 = obj15 & 0x1FFFFFFF0L;
		object obj18 = default(object);
		object obj17 = (ref *(?*)(&obj18)) - (ref *(?*)obj16);
		object obj19 = obj9 & 1;
		bool flag2 = obj19 == null;
		object obj20 = !flag2;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v47 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X9_v47 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj21 = (nint)0 + (nint)309;
			obj9 = obj21;
			object obj23 = default(object);
			object obj22 = obj23;
		}
		else
		{
			object obj22 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v15+FC]");
		object obj24 = (nint)0 + (nint)16;
		object obj25 = obj24 + 15;
		object obj26 = obj25 & 0x1FFFFFFF0L;
		object obj27 = (ref *(?*)(&obj18)) - (ref *(?*)obj26);
		object obj28 = obj9 & 1;
		bool flag3 = obj28 == null;
		object obj29 = !flag3;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+FC]");
		object obj30 = (nint)0 + (nint)16;
		object obj31 = obj30 + 15;
		object obj32 = obj31 & 0x1FFFFFFF0L;
		object obj33 = (ref *(?*)(&obj18)) - (ref *(?*)obj32);
		object obj34 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+FC]");
		object obj35 = (nint)0 + (nint)15;
		object obj36 = obj35 & 0x1FFFFFFF0L;
		int num4 = (ref *(?*)(&obj18)) - (ref *(?*)obj36);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+FC]");
		object obj37 = (nint)0 + (nint)15;
		object obj38 = obj37 & 0x1FFFFFFF0L;
		nint num5 = (ref *(?*)(&obj18)) - (ref *(?*)obj38);
		object obj39 = (ref *(?*)(&obj18)) - (ref *(?*)obj38);
		ref bool reference = ref *(bool*)((ref *(?*)(&obj18)) - (ref *(?*)obj36));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v4+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		object obj40 = (ref *(?*)(&obj18)) - (ref *(?*)obj38);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+98]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+98]");
		_ = 0;
		_ = 0;
		object obj41 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 208));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
		NullReferenceException ex = default(NullReferenceException);
		if ((nint)0 != 0)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v34 (Il2CppRgctx<ListView.NestedListViewController`3>)+168]");
			num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
			_ = 0;
			object obj43 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
			ref bool reference2 = ref System.Runtime.CompilerServices.Unsafe.As<object, bool>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
			int num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-F0]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
			bool flag4 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
			ref float reference3 = ref *(float*)null;
			if (!flag4)
			{
				Action<TData> action2 = default(Action<TData>);
				Action<TData> action = action2;
				nint num10 = default(nint);
				nint num9 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
				ref float reference4 = ref *(float*)null;
				int num11 = num8;
				ref bool reference5 = ref reference2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
				object obj46 = 0;
				object obj49 = default(object);
				object obj122 = default(object);
				while (true)
				{
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v39 (Il2CppRgctx<ListView.NestedListViewController`3>)+1B0]");
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
					if ((nint)ex <= 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
					reference3 = ref *(float*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
					bool flag5 = (nint)0 == 0;
					action2 = action;
					num10 = num9;
					num8 = num11;
					reference2 = ref reference5;
					obj42 = obj46;
					object obj50;
					if (!flag5)
					{
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v43 (Il2CppRgctx<ListView.NestedListViewController`3>)+170]");
						num6 = 0;
						num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
						bool flag6 = (nint)0 == 0;
						action2 = action;
						num10 = num9;
						reference2 = ref *(bool*)null;
						obj42 = obj46;
						if (!flag6)
						{
							object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-A8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-A8]");
							object obj48 = (nint)0 >> 32;
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X8_v47 (Il2CppRgctx<ListView.NestedListViewController`3>)+1A8]");
							num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
							if (obj49 <= obj48)
							{
								action2 = action;
								num10 = num9;
								reference5 = ref *(bool*)null;
								obj42 = obj46;
								obj50 = obj45;
								goto IL_0414;
							}
							while (true)
							{
								nint num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v51 (Il2CppRgctx<ListView.NestedListViewController`3>)+178]");
								object obj51 = 0;
								object obj52 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
								object obj53 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X1_v12+10] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v55 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
								object obj54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v55 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
								object obj55 = (nint)0 + (nint)309;
								object obj56 = obj55 & 1;
								bool flag7 = obj56 == null;
								object obj57 = !flag7;
								nint num17 = 0;
								if (obj57 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
									num17 = 0;
								}
								num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
								bool flag8 = (nint)0 == 0;
								action2 = action;
								num10 = num5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+FC]");
								reference3 = ref *(float*)null;
								reference2 = ref reference;
								obj42 = obj46;
								num6 = num5;
								if (flag8)
								{
									break;
								}
								nint num18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v58 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
								object obj58 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X9_v18+28]");
								obj37 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X9_v18+28]");
								object obj59 = 0 & 0x80000000L;
								bool flag9 = obj59 == null;
								object obj60 = !flag9;
								object obj61 = obj39;
								if (obj60 == null)
								{
									obj61 = obj39;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v58 (Il2CppRgctx<ListView.NestedListViewController`3>)+188]");
								object obj62 = 0;
								object obj63 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 209));
								reference2 = ref System.Runtime.CompilerServices.Unsafe.As<object, bool>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
								num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v581 @ X1_v17+10] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-88]");
								object obj64 = (nint)0 & (nint)1;
								bool flag10 = obj64 == null;
								object obj65 = !flag10;
								if (obj65 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-E0]");
									num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
									bool flag11 = (nint)0 == 0;
									action2 = action;
									num10 = num5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8+FC]");
									reference3 = ref *(float*)null;
									obj42 = obj46;
									if (flag11)
									{
										break;
									}
									nint num19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X9_v42 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
									object obj66 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v110+28]");
									obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v110+28]");
									object obj67 = 0 & 0x80000000L;
									bool flag12 = obj67 == null;
									object obj68 = !flag12;
									IntPtr intPtr = num5;
									if (obj68 == null)
									{
										intPtr = num5;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X9_v42 (Il2CppRgctx<ListView.NestedListViewController`3>)+190]");
									object obj69 = 0;
									_ = 0;
									object obj70 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
									reference2 = ref System.Runtime.CompilerServices.Unsafe.As<object, bool>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
									num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v598 @ X1_v35+10] (should have been resolved before IL gen)");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-E8]");
								object obj71 = 0;
								action2 = m_ToggleExpanded;
								object obj72 = obj71 + (object)m_ToggleExpanded;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+60]");
								object obj73 = 0 + obj72;
								bool flag13 = (nint)obj73 < 0;
								object obj74 = !flag13;
								object obj75 = ~obj74;
								bool flag14;
								bool flag15;
								bool flag16;
								if (obj75 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+84]");
									object obj76 = obj72 - 0;
									flag14 = (nint)obj76 < 0;
									flag15 = obj76 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+84]");
									object obj77 = obj72 ^ 0;
									object obj78 = obj72 ^ obj76;
									object obj79 = obj77 & obj78;
									flag16 = (nint)obj79 < 0;
								}
								else
								{
									flag16 = false;
									flag15 = false;
									flag14 = false;
								}
								bool flag17 = flag14 == flag16;
								object obj80 = !flag17;
								object obj81 = obj80 | flag15;
								if (obj81 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
									nint num20 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v105 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
									object obj82 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-F0]");
									obj50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v106+28]");
									object obj83 = 0 & 0x80000000L;
									bool flag18 = obj83 == null;
									object obj84 = !flag18;
									nint num21 = num5;
									if (obj84 == null)
									{
										num21 = num5;
									}
									nint num22 = (nint)this;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v108 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+2D0]");
									object obj85 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-F0]");
									obj50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
									object obj86 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v99-100]");
									object obj87 = 0;
									object obj88 = obj87 + 1;
									obj87 = obj88;
									nint num23 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X9_v33 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
									object obj89 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X9_v34+28]");
									obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X9_v34+28]");
									object obj90 = 0 & 0x80000000L;
									bool flag19 = obj90 == null;
									object obj91 = !flag19;
									int num24 = num4;
									if (obj91 == null)
									{
										num24 = ((int*)num4)->m_value;
									}
									object obj92 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v101-100]");
									_ = 0;
									nint num25 = (nint)this;
									object obj93 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
									object obj94 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 180));
									object obj95 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
									object obj96 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X9_v40-100]");
									nint num21 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X9_v40-100]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v103 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+350]");
									object obj85 = 0;
								}
								object obj97 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v702 @ X1_v19+10] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-E8]");
								object obj98 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+60]");
								obj42 = 0 + obj98;
								obj98 = obj42;
								nint num26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v68 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
								object obj99 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v68 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
								object obj100 = (nint)0 + (nint)309;
								object obj101 = obj100 & 1;
								bool flag20 = obj101 == null;
								object obj102 = !flag20;
								nint num27 = 0;
								if (obj102 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
									num27 = 0;
								}
								num10 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-100]");
								reference3 = ref *(float*)null;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
								bool flag21 = (nint)0 == 0;
								num8 = 0;
								reference5 = ref reference;
								if (!flag21)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D1]");
									if ((nint)0 == 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
										_ = 0;
										_ = 0;
										object obj103 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 208));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object obj104 = obj48 + 1;
										object obj105 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X9_v26-100]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
										bool flag22 = (nint)0 == 0;
										num8 = 0;
										reference2 = ref reference;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
										num6 = 0;
										if (flag22)
										{
											break;
										}
										nint num28 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v78 (Il2CppRgctx<ListView.NestedListViewController`3>)+168]");
										object obj106 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
										obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
										_ = 0;
										object obj107 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
										object obj108 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
										object obj109 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X1_v24+10] (should have been resolved before IL gen)");
										_ = 0;
										_ = 0;
										nint num29 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X8_v82 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
										object obj110 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X0_v53+135]");
										object obj111 = (nint)0 & (nint)1;
										bool flag23 = obj111 == null;
										object obj112 = !flag23;
										nint num30 = 0;
										if (obj112 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
											num30 = 0;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-F0]");
										obj50 = 0;
										num10 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
										object obj113 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 32));
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v84-100]");
										reference3 = ref *(float*)null;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
										num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-B0]");
										_ = 0;
										object obj114 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 208));
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object obj115 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v85-100]");
										object obj116 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
										bool flag24 = (nint)0 == 0;
										num8 = 0;
										reference2 = ref reference;
										if (flag24)
										{
											break;
										}
										nint num31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v89 (Il2CppRgctx<ListView.NestedListViewController`3>)+168]");
										num6 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
										obj42 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-D0]");
										_ = 0;
										object obj117 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
										reference5 = ref System.Runtime.CompilerServices.Unsafe.As<object, bool>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
										num8 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)+10] (should have been resolved before IL gen)");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
										reference3 = ref *(float*)null;
										goto IL_0414;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
									nint num32 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v95 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
									object obj118 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X9_v29+28]");
									object obj119 = 0 & 0x80000000L;
									bool flag25 = obj119 == null;
									object obj120 = !flag25;
									num8 = num4;
									if (obj120 == null)
									{
										num8 = ((int*)num4)->m_value;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ X8_v95 (Il2CppRgctx<ListView.NestedListViewController`3>)+1A0]");
									object obj121 = 0;
									reference5 = ref System.Runtime.CompilerServices.Unsafe.As<object, bool>(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v745 @ X1_v29+10] (should have been resolved before IL gen)");
									reference3 = ref *(float*)this;
								}
								obj48++;
								nint num33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v73 (Il2CppRgctx<ListView.NestedListViewController`3>)+1A8]");
								num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v375 @ X1_v4 (Il2CppMethodInfo)] (should have been resolved before IL gen)");
								bool flag26 = obj48 >= obj122;
								action = action2;
								num9 = num10;
								obj46 = obj42;
								obj45 = obj50;
								if (!flag26)
								{
									continue;
								}
								goto IL_0414;
							}
						}
					}
					goto IL_0dfe;
					IL_0414:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
					obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+100]");
					bool flag27 = (nint)0 == 0;
					action = action2;
					num9 = num10;
					reference4 = ref reference3;
					num11 = num8;
					obj46 = obj42;
					obj45 = obj50;
					reference2 = ref reference5;
					if (!flag27)
					{
						continue;
					}
					goto IL_0dfe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj123 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-80]");
				bool flag28 = obj123 != null;
				action2 = action;
				num10 = num9;
				reference3 = ref reference4;
				num8 = num11;
				reference2 = ref reference5;
				obj42 = obj46;
				if (!flag28)
				{
					return;
				}
				goto IL_0e0c;
			}
		}
		goto IL_0dfe;
		IL_0dfe:
		ex = new NullReferenceException();
		goto IL_0e0c;
		IL_0e0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected unsafe virtual void UpdateNestedItem(TData datum, int order, float offset, int depth, ref bool doneSettling)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_00b1: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00e3: Expected O, but got Ref
		//IL_00fc: Expected O, but got I4
		//IL_013f: Expected O, but got I8
		//IL_0159: Expected O, but got I4
		//IL_01c1: Expected I, but got O
		//IL_01cf: Expected O, but got Ref
		//IL_01e7: Expected O, but got Ref
		//IL_0201: Expected O, but got I
		//IL_0229: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+FC]");
		NestedListViewController<TData, TItem, TIndex> nestedListViewController = (NestedListViewController<TData, TItem, TIndex>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default(object);
		object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+28]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+28]");
		object obj9 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+28]");
		object obj10 = 0 & obj9;
		bool flag2 = (nint)obj10 < 0;
		TData val = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
		bool flag3 = flag == flag2;
		object obj11 = !flag3;
		object obj12 = ~obj11;
		if (obj12 != null)
		{
			TData val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v6+28]");
			object obj13 = 0 & 0x80000000L;
			bool flag4 = obj13 == null;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				obj7 = obj7;
			}
			nint num3 = (nint)this;
			object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 108));
			object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v9 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+2F0]");
			TData val2 = (TData)0;
			int num4 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ X1_v2 (TData)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
			bool flag5 = obj17 != null;
			nestedListViewController = this;
			if (!flag5)
			{
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected unsafe void RecycleChildren(TData datum)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_0757: Expected O, but got Ref
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_0792: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected O, but got Unknown
		//IL_0be5: Expected O, but got Ref
		//IL_0c00: Expected O, but got I
		//IL_0c16: Expected O, but got I
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected O, but got Unknown
		//IL_0c46: Expected O, but got I4
		//IL_0159: Expected O, but got I
		//IL_07b6: Expected O, but got I
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_07e3: Expected O, but got Ref
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_080b: Expected O, but got I4
		//IL_0112: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_0c6a: Expected O, but got I
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c78: Expected O, but got Unknown
		//IL_0c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8a: Expected O, but got Unknown
		//IL_0c97: Expected O, but got Ref
		//IL_0cad: Expected O, but got I
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected O, but got Unknown
		//IL_0ccc: Expected O, but got Ref
		//IL_0cdc: Expected O, but got I
		//IL_0cf2: Expected O, but got I
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected O, but got Unknown
		//IL_0d11: Expected O, but got Ref
		//IL_0d27: Expected O, but got I
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d39: Expected O, but got Unknown
		//IL_0d46: Expected O, but got Ref
		//IL_0d53: Expected O, but got Ref
		//IL_0d6f: Expected O, but got Ref
		//IL_0d8f: Expected O, but got I
		//IL_0da5: Expected O, but got I
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Expected O, but got Unknown
		//IL_0dcd: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_0831: Expected O, but got I
		//IL_0865: Expected O, but got I
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_0897: Expected O, but got Ref
		//IL_08b0: Expected O, but got I4
		//IL_018d: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_01bd: Expected O, but got I
		//IL_08d5: Expected O, but got Ref
		//IL_08ef: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_0679: Expected O, but got I4
		//IL_020f: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0252: Expected O, but got Ref
		//IL_0274: Expected O, but got Ref
		//IL_028d: Expected O, but got Ref
		//IL_029b: Expected O, but got Ref
		//IL_02bd: Expected O, but got I
		//IL_0924: Expected O, but got I
		//IL_0934: Expected O, but got I
		//IL_0944: Expected O, but got I
		//IL_0954: Expected O, but got I
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected O, but got Unknown
		//IL_05ab: Expected O, but got I4
		//IL_0b17: Expected O, but got I
		//IL_0b27: Expected O, but got I
		//IL_0b37: Expected O, but got I
		//IL_0b47: Expected O, but got I
		//IL_0b5d: Expected O, but got I
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected O, but got Unknown
		//IL_0b85: Expected O, but got I4
		//IL_0309: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_0329: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_034c: Expected O, but got Ref
		//IL_0370: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03b6: Expected O, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03de: Expected O, but got I4
		//IL_0705: Expected O, but got Ref
		//IL_0a9e: Expected O, but got I
		//IL_0aae: Expected O, but got I
		//IL_0abe: Expected O, but got I
		//IL_0ae2: Expected O, but got I4
		//IL_0999: Expected O, but got I
		//IL_09ac: Expected O, but got Ref
		//IL_0698: Expected O, but got I4
		//IL_06a1: Expected O, but got I4
		//IL_05ca: Expected O, but got I
		//IL_05da: Expected O, but got I
		//IL_05ea: Expected O, but got I
		//IL_0406: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_05ff: Expected O, but got I
		//IL_0621: Expected O, but got I4
		//IL_062a: Expected O, but got I4
		//IL_043b: Expected O, but got I
		//IL_044b: Expected O, but got I
		//IL_045b: Expected O, but got I
		//IL_046b: Expected O, but got I
		//IL_0485: Expected O, but got I8
		//IL_049f: Expected O, but got I4
		//IL_09d5: Expected I, but got O
		//IL_09ea: Expected O, but got I
		//IL_09f8: Expected O, but got Ref
		//IL_0a12: Expected O, but got I
		//IL_0a22: Expected O, but got I
		//IL_0a32: Expected O, but got I
		//IL_0a42: Expected O, but got I
		//IL_0a58: Expected O, but got I
		//IL_0a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a80: Expected O, but got I4
		//IL_0de9: Expected O, but got Ref
		//IL_0e13: Expected O, but got I4
		//IL_04dc: Expected O, but got I
		//IL_04ec: Expected O, but got I
		//IL_04fc: Expected O, but got I
		//IL_051b: Expected O, but got I
		//IL_052b: Expected O, but got I
		//IL_053b: Expected O, but got I
		//IL_054b: Expected O, but got I
		//IL_0565: Expected O, but got I8
		//IL_057f: Expected O, but got I4
		//IL_02d2: Expected O, but got I
		//IL_02e5: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj6 = (nint)0 + (nint)309;
		object obj7 = obj6 & 1;
		bool flag = obj7 == null;
		object obj8 = !flag;
		object obj9;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v65+FC]");
			obj9 = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v14 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
			obj4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v5+FC]");
			obj9 = 0;
		}
		object obj10 = obj9 + 16;
		object obj11 = obj10 + 15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj14 = default(object);
		object obj13 = (ref *(?*)(&obj14)) - (ref *(?*)obj12);
		object obj15 = obj4 + 309;
		object obj16 = obj15 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
		object obj18 = (nint)0 + (nint)16;
		object obj19 = obj18 + 15;
		object obj20 = obj19 & 0x1FFFFFFF0L;
		object obj21 = (ref *(?*)(&obj14)) - (ref *(?*)obj20);
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23;
		object obj25 = obj23 & 1;
		bool flag3 = obj25 == null;
		object obj26 = !flag3;
		nint num5;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v32 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v32 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj27 = (nint)0 + (nint)309;
			obj24 = obj27;
			num5 = 0;
			object obj29 = default(object);
			object obj28 = obj29;
		}
		else
		{
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj28 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v19+FC]");
		object obj30 = (nint)0 + (nint)16;
		object obj31 = obj30 + 15;
		object obj32 = obj31 & 0x1FFFFFFF0L;
		NestedListViewController<TData, TItem, TIndex> nestedListViewController = (NestedListViewController<TData, TItem, TIndex>)((ref *(?*)(&obj14)) - (ref *(?*)obj32));
		object obj33 = obj24 & 1;
		bool flag4 = obj33 == null;
		object obj34 = !flag4;
		nint num6 = num5;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			num6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+FC]");
		object obj35 = (nint)0 + (nint)16;
		object obj36 = obj35 + 15;
		object obj37 = obj36 & 0x1FFFFFFF0L;
		NestedListViewController<TData, TItem, TIndex> nestedListViewController2 = (NestedListViewController<TData, TItem, TIndex>)((ref *(?*)(&obj14)) - (ref *(?*)obj37));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X8_v5+FC]");
		object obj38 = (nint)0 + (nint)15;
		object obj39 = obj38 & 0x1FFFFFFF0L;
		object obj40 = (ref *(?*)(&obj14)) - (ref *(?*)obj39);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v30+FC]");
		object obj42 = (nint)0 + (nint)15;
		object obj43 = obj42 & 0x1FFFFFFF0L;
		object obj44 = (ref *(?*)(&obj14)) - (ref *(?*)obj43);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
		object obj45 = (nint)0 + (nint)15;
		object obj46 = obj45 & 0x1FFFFFFF0L;
		object obj47 = (ref *(?*)(&obj14)) - (ref *(?*)obj46);
		object obj48 = (ref *(?*)(&obj14)) - (ref *(?*)obj46);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		object obj49 = (ref *(?*)(&obj14)) - (ref *(?*)obj39);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v10 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v10 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj51 = (nint)0 + (nint)309;
		object obj52 = obj51 & 1;
		bool flag5 = obj52 == null;
		object obj53 = !flag5;
		if (obj53 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v94+20]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v95+C0]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj50 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v10 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj56 = 0;
			nint num8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+130]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v39+28]");
		bool flag6 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v39+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v39+28]");
		object obj58 = num9 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v39+28]");
		object obj59 = 0 & obj58;
		bool flag7 = (nint)obj59 < 0;
		object obj60 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 136));
		bool flag8 = flag6 == flag7;
		object obj61 = !flag8;
		object obj62 = ~obj61;
		object obj63;
		if (obj62 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
			obj63 = 0;
		}
		else
		{
			obj63 = obj60;
		}
		object obj64 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
		NestedListViewController<TData, TItem, TIndex> nestedListViewController3 = (NestedListViewController<TData, TItem, TIndex>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
		object obj117;
		object obj72;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v53+20]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v54+C0]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v55+F0]");
			object obj68 = 0;
			obj63 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X1_v8+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			object obj69 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
			_ = 0;
			object obj70 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
			object obj71 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 160));
			obj72 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+FC]");
			nestedListViewController3 = (NestedListViewController<TData, TItem, TIndex>)0;
			object obj77 = default(object);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v60+20]");
				object obj74 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v61+C0]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v62+138]");
				obj57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v383 @ X1_v4] (should have been resolved before IL gen)");
				object obj76 = obj77 & 1;
				if (obj76 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				object obj78 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v64+20]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v65+C0]");
				object obj80 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v66+100]");
				object obj81 = 0;
				object obj82 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X1_v12+10] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
				object obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v68+20]");
				object obj84 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v69+C0]");
				object obj85 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v71+90]");
				object obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v71+90]");
				object obj87 = (nint)0 + (nint)309;
				object obj88 = obj87 & 1;
				bool flag9 = obj88 == null;
				object obj89 = !flag9;
				if (obj89 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
					object obj90 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v91+20]");
					object obj91 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v92+C0]");
					obj85 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v71+118]");
				obj57 = 0;
				obj72 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
				if ((object)this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
					object obj92 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v72+20]");
					object obj93 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v73+C0]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v74+70]");
					object obj95 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v75+28]");
					object obj96 = 0 & 0x80000000L;
					bool flag10 = obj96 == null;
					object obj97 = !flag10;
					object obj98 = obj44;
					if (obj97 == null)
					{
						obj98 = obj44;
					}
					nint num10 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v77 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+2D0]");
					object obj99 = 0;
					object obj100 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ X1_v15+10] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
					object obj101 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v79+20]");
					object obj102 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v80+C0]");
					object obj103 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v82+90]");
					object obj104 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v82+90]");
					object obj105 = (nint)0 + (nint)309;
					object obj106 = obj105 & 1;
					bool flag11 = obj106 == null;
					object obj107 = !flag11;
					if (obj107 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
						object obj108 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v88+20]");
						object obj109 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v89+C0]");
						obj103 = 0;
					}
					obj64 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
					bool flag12 = (nint)0 == 0;
					obj72 = 0;
					nestedListViewController3 = nestedListViewController2;
					obj63 = obj49;
					if (!flag12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
						object obj110 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v84+20]");
						object obj111 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v85+C0]");
						object obj112 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v86+90]");
						object obj113 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X9_v27+28]");
						object obj114 = 0 & 0x80000000L;
						bool flag13 = obj114 == null;
						object obj115 = !flag13;
						obj72 = obj40;
						if (obj115 == null)
						{
							obj72 = obj40;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v86+1A0]");
						object obj116 = 0;
						obj63 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X1_v18+10] (should have been resolved before IL gen)");
						nestedListViewController3 = this;
					}
					continue;
				}
				goto IL_0639;
			}
			obj117 = 0;
			goto IL_0b07;
		}
		NullReferenceException ex = new NullReferenceException();
		obj72 = 0;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		goto IL_0af0;
		IL_0639:
		NullReferenceException ex3 = new NullReferenceException();
		obj64 = obj44;
		nestedListViewController3 = nestedListViewController;
		obj63 = obj49;
		ex2 = (OutOfMemoryException)(object)ex3;
		goto IL_0af0;
		IL_0af0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		object obj119 = default(object);
		object obj118 = obj119;
		object obj121 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			if ((nint)obj57 == 1)
			{
				break;
			}
			object obj120 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D3ACE4");
			obj118 = obj121;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		object obj122 = default(object);
		obj117 = obj122;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		goto IL_0b07;
		IL_0b07:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
		object obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v43+20]");
		object obj124 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v44+C0]");
		object obj125 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v46+F8]");
		object obj126 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v46+F8]");
		object obj127 = (nint)0 + (nint)309;
		object obj128 = obj127 & 1;
		bool flag14 = obj128 == null;
		object obj129 = !flag14;
		if (obj129 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			object obj130 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v48+20]");
			object obj131 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v49+C0]");
			obj125 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v46+140]");
		obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
		obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
		nestedListViewController3 = (NestedListViewController<TData, TItem, TIndex>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		bool flag15 = obj117 == null;
		object obj132 = !flag15;
		if (obj132 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj133 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			bool flag16 = obj133 != null;
			obj64 = 0;
			obj72 = 0;
			if (!flag16)
			{
				return;
			}
		}
		else
		{
			ex2 = new OutOfMemoryException();
			obj64 = 0;
			obj72 = 0;
		}
		goto IL_0af0;
	}

	protected unsafe bool GetExpanded(TIndex index)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_00b7: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00e9: Expected O, but got Ref
		//IL_0102: Expected O, but got I4
		//IL_013b: Expected O, but got I
		//IL_0155: Expected O, but got I8
		//IL_016f: Expected O, but got I4
		//IL_01f1: Expected O, but got Ref
		//IL_0209: Expected O, but got Ref
		//IL_0217: Expected O, but got Ref
		//IL_0231: Expected O, but got I
		//IL_025a: Expected O, but got I
		//IL_026a: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X21_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+FC]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default(object);
		object obj8 = (ref *(?*)(&obj9)) - (ref *(?*)obj7);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+28]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+28]");
		object obj10 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+28]");
		object obj11 = 0 & obj10;
		bool flag2 = (nint)obj11 < 0;
		TIndex val = (TIndex)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
		bool flag3 = flag == flag2;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			TIndex val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X21_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+188]");
			TIndex val2 = (TIndex)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+28]");
			object obj14 = 0 & 0x80000000L;
			bool flag4 = obj14 == null;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				obj8 = obj8;
			}
			object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 73));
			object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
			object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 57));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v95 @ X1_v2 (TIndex)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			bool flag5 = obj19 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-49]");
			NullReferenceException ex = (NullReferenceException)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
			obj5 = 0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-49]");
				return false;
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

	protected unsafe void SetExpanded(TIndex index, bool expanded)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_00b1: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00e3: Expected O, but got Ref
		//IL_00fc: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_014f: Expected O, but got I8
		//IL_0169: Expected O, but got I4
		//IL_01e0: Expected O, but got Ref
		//IL_0206: Expected O, but got Ref
		//IL_0215: Expected I, but got O
		//IL_0225: Expected O, but got I
		//IL_023c: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X23_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+FC]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+FC]");
		object obj6 = (nint)0 + (nint)15;
		object obj7 = obj6 & 0x1FFFFFFF0L;
		object obj9 = default(object);
		object obj8 = (ref *(?*)(&obj9)) - (ref *(?*)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+28]");
		bool flag = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+28]");
		object obj10 = num2 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+28]");
		object obj11 = 0 & obj10;
		bool flag2 = (nint)obj11 < 0;
		TIndex val = (TIndex)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		bool flag3 = flag == flag2;
		object obj12 = !flag3;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			TIndex val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X23_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+190]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X8_v5+28]");
			object obj15 = 0 & 0x80000000L;
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				obj8 = obj8;
			}
			object obj17 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 73));
			nint num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
			object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 73));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X1_v3+10] (should have been resolved before IL gen)");
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v10 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+280]");
			obj5 = 0;
			base.StartSettling();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			bool flag5 = obj19 != null;
			TIndex val2 = (TIndex)null;
			if (!flag5)
			{
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected unsafe void ScrollToIndex(TData container, TIndex targetIndex, ref float scrollHeight)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0042: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_0117: Expected O, but got I
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Expected O, but got Unknown
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_08a3: Expected O, but got Ref
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08d9: Expected O, but got I4
		//IL_00e0: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_10eb: Expected O, but got I
		//IL_10f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected O, but got Unknown
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Expected O, but got Unknown
		//IL_1118: Expected O, but got Ref
		//IL_1128: Expected O, but got I
		//IL_113e: Expected O, but got I
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected O, but got Unknown
		//IL_116b: Expected O, but got I4
		//IL_08fd: Expected O, but got I
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_090b: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_092a: Expected O, but got Ref
		//IL_093a: Expected O, but got I
		//IL_0950: Expected O, but got I
		//IL_095e: Expected O, but got Ref
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected O, but got Unknown
		//IL_098b: Expected O, but got I4
		//IL_118f: Expected O, but got I
		//IL_1198: Unknown result type (might be due to invalid IL or missing references)
		//IL_119d: Expected O, but got Unknown
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11af: Expected O, but got Unknown
		//IL_11bc: Expected O, but got Ref
		//IL_11e4: Expected O, but got I
		//IL_11f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Expected O, but got Unknown
		//IL_1203: Expected O, but got Ref
		//IL_1210: Expected O, but got Ref
		//IL_1226: Expected O, but got I
		//IL_1233: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238: Expected O, but got Unknown
		//IL_1245: Expected O, but got Ref
		//IL_1252: Expected O, but got Ref
		//IL_1268: Expected O, but got I
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_127a: Expected O, but got Unknown
		//IL_1287: Expected O, but got Ref
		//IL_1295: Expected O, but got Ref
		//IL_12a7: Expected O, but got Ref
		//IL_12c3: Expected O, but got Ref
		//IL_12d6: Expected O, but got Ref
		//IL_12fb: Expected O, but got I
		//IL_1311: Expected O, but got I
		//IL_1322: Unknown result type (might be due to invalid IL or missing references)
		//IL_1327: Expected O, but got Unknown
		//IL_1341: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_09cd: Expected O, but got I
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09ff: Expected O, but got Ref
		//IL_0a18: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_0a42: Expected O, but got Ref
		//IL_0a64: Expected O, but got I
		//IL_0a7c: Expected O, but got I
		//IL_0a8c: Expected O, but got I
		//IL_0ac0: Expected O, but got I
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected O, but got Unknown
		//IL_0af2: Expected O, but got Ref
		//IL_0b0b: Expected O, but got I4
		//IL_0b3c: Expected O, but got I
		//IL_0b4c: Expected O, but got I
		//IL_0b5c: Expected O, but got I
		//IL_0b8e: Expected O, but got I
		//IL_0ba4: Expected O, but got I
		//IL_0bad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Expected O, but got Unknown
		//IL_0bcc: Expected O, but got I4
		//IL_01dd: Expected O, but got I
		//IL_0bea: Expected O, but got I
		//IL_0bfd: Expected O, but got Ref
		//IL_0c0b: Expected O, but got Ref
		//IL_0c1b: Expected O, but got I
		//IL_0c2b: Expected O, but got I
		//IL_02f8: Expected O, but got I
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0335: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_035f: Expected O, but got I8
		//IL_0379: Expected O, but got I4
		//IL_0c70: Expected O, but got Ref
		//IL_0c7e: Expected O, but got Ref
		//IL_0214: Expected O, but got I
		//IL_022d: Expected O, but got I
		//IL_076f: Expected O, but got I
		//IL_02b9: Unsupported input type for neg.
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_03b2: Expected O, but got I
		//IL_03c8: Expected O, but got I
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I4
		//IL_0259: Expected O, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0297: Expected O, but got I
		//IL_0441: Expected O, but got I
		//IL_0cd8: Expected O, but got I
		//IL_0d0c: Expected O, but got I
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected O, but got Unknown
		//IL_0d3e: Expected O, but got Ref
		//IL_0d57: Expected O, but got I4
		//IL_0426: Expected O, but got I
		//IL_102f: Expected O, but got Ref
		//IL_0d7c: Expected O, but got Ref
		//IL_0d8a: Expected O, but got Ref
		//IL_0da4: Expected O, but got I
		//IL_0dcc: Expected O, but got I4
		//IL_045c: Expected O, but got I
		//IL_104e: Expected O, but got I
		//IL_105e: Expected O, but got I
		//IL_106e: Expected O, but got I
		//IL_107e: Expected O, but got I
		//IL_1094: Expected O, but got I
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_10bc: Expected O, but got I4
		//IL_0484: Expected O, but got I
		//IL_0492: Expected O, but got Ref
		//IL_04a2: Expected O, but got I
		//IL_04bd: Expected O, but got Ref
		//IL_04d5: Expected O, but got Ref
		//IL_04e5: Expected O, but got I
		//IL_04f3: Expected O, but got Ref
		//IL_0503: Expected O, but got I
		//IL_051b: Expected O, but got Ref
		//IL_0534: Expected O, but got Ref
		//IL_0542: Expected O, but got Ref
		//IL_055a: Expected O, but got Ref
		//IL_056a: Expected O, but got I
		//IL_0f3b: Expected O, but got I
		//IL_0f4b: Expected O, but got I
		//IL_0f5b: Expected O, but got I
		//IL_0f7f: Expected O, but got I4
		//IL_0f88: Expected O, but got I4
		//IL_0f99: Expected O, but got I4
		//IL_0fda: Expected O, but got I4
		//IL_0fe3: Expected O, but got I4
		//IL_0ff3: Expected O, but got I
		//IL_1003: Expected O, but got I
		//IL_1013: Expected O, but got I
		//IL_0ef6: Expected O, but got I
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Expected O, but got Unknown
		//IL_073a: Expected O, but got I
		//IL_074a: Expected O, but got I
		//IL_075a: Expected O, but got I
		//IL_071b: Expected O, but got I4
		//IL_058f: Expected O, but got I
		//IL_059f: Expected O, but got I
		//IL_05af: Expected O, but got I
		//IL_05bf: Expected O, but got I
		//IL_05d2: Expected O, but got Ref
		//IL_05f6: Expected O, but got I
		//IL_0606: Expected O, but got I
		//IL_0616: Expected O, but got I
		//IL_0626: Expected O, but got I
		//IL_065a: Expected O, but got I
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0697: Expected O, but got I4
		//IL_0dfc: Expected O, but got I
		//IL_0e0c: Expected O, but got I
		//IL_0e1c: Expected O, but got I
		//IL_0e36: Expected O, but got I8
		//IL_0e50: Expected O, but got I4
		//IL_0e76: Expected O, but got I
		//IL_0e86: Expected O, but got I
		//IL_0e96: Expected O, but got I
		//IL_0eb0: Expected O, but got I8
		//IL_0eca: Expected O, but got I4
		//IL_136c: Expected O, but got Ref
		//IL_1396: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v3+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v5+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+135]");
		object obj7 = (nint)0 & (nint)1;
		bool flag = obj7 == null;
		object obj8 = !flag;
		object obj9;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v74+FC]");
			obj9 = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v40 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
			obj4 = 0;
			nint num3 = 0;
		}
		else
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+FC]");
			obj9 = 0;
		}
		object obj10 = obj9 + 16;
		object obj11 = obj10 + 15;
		object obj12 = obj11 & 0x1FFFFFFF0L;
		object obj14 = default(object);
		object obj13 = (ref *(?*)(&obj14)) - (ref *(?*)obj12);
		object obj15 = obj4 + 309;
		object obj16 = obj15 & 1;
		bool flag2 = obj16 == null;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v3+FC]");
		object obj18 = (nint)0 + (nint)16;
		object obj19 = obj18 + 15;
		object obj20 = obj19 & 0x1FFFFFFF0L;
		object obj21 = (ref *(?*)(&obj14)) - (ref *(?*)obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag3 = obj24 == null;
		object obj25 = !flag3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+FC]");
		object obj26 = (nint)0 + (nint)16;
		object obj27 = obj26 + 15;
		object obj28 = obj27 & 0x1FFFFFFF0L;
		object obj29 = (ref *(?*)(&obj14)) - (ref *(?*)obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+F8]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
		object obj33 = obj31 & 1;
		bool flag4 = obj33 == null;
		object obj34 = !flag4;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v7+FC]");
		object obj35 = (nint)0 + (nint)16;
		object obj36 = obj35 + 15;
		object obj37 = obj36 & 0x1FFFFFFF0L;
		object obj38 = (ref *(?*)(&obj14)) - (ref *(?*)obj37);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v7+FC]");
		object obj39 = (nint)0 + (nint)15;
		object obj40 = obj39 & 0x1FFFFFFF0L;
		object obj41 = (ref *(?*)(&obj14)) - (ref *(?*)obj40);
		object obj42 = (ref *(?*)(&obj14)) - (ref *(?*)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C8]");
		object obj43 = (nint)0 + (nint)15;
		object obj44 = obj43 & 0x1FFFFFFF0L;
		object obj45 = (ref *(?*)(&obj14)) - (ref *(?*)obj44);
		object obj46 = (ref *(?*)(&obj14)) - (ref *(?*)obj44);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E0]");
		object obj47 = (nint)0 + (nint)15;
		object obj48 = obj47 & 0x1FFFFFFF0L;
		object obj49 = (ref *(?*)(&obj14)) - (ref *(?*)obj48);
		object obj50 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
		object obj51 = (ref *(?*)(&obj14)) - (ref *(?*)obj44);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		object obj52 = (ref *(?*)(&obj14)) - (ref *(?*)obj48);
		object obj53 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0EB0");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj55 = (nint)0 + (nint)309;
		object obj56 = obj55;
		object obj57 = obj55 & 1;
		bool flag5 = obj57 == null;
		object obj58 = !flag5;
		TData val;
		if (obj58 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X9_v37 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
			val = (TData)0;
			nint num6 = 0;
		}
		else
		{
			val = container;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj59 = 0;
			nint num6 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v42+28]");
		bool flag6 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v42+28]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v42+28]");
		object obj60 = num7 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v42+28]");
		object obj61 = 0 & obj60;
		bool flag7 = (nint)obj61 < 0;
		TData val2 = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 160));
		bool flag8 = flag6 == flag7;
		object obj62 = !flag8;
		object obj63 = ~obj62;
		if (obj63 == null)
		{
			TData val3 = val;
		}
		else
		{
			TData val3 = val2;
		}
		object obj64 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		nint num8 = default(nint);
		object obj65 = num8 + 32;
		object obj66 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X22_v2+C0]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v45+70]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v46+28]");
		bool flag9 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v46+28]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v46+28]");
		object obj69 = num9 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v46+28]");
		object obj70 = 0 & obj69;
		bool flag10 = (nint)obj70 < 0;
		object obj71 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
		bool flag11 = flag9 == flag10;
		object obj72 = !flag11;
		object obj73 = ~obj72;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
			object obj74 = 0;
		}
		else
		{
			object obj74 = obj71;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X22_v2+C0]");
		object obj75 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F8]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-F0]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj78 = obj65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v50+C0]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v52 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v52 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj80 = (nint)0 + (nint)309;
		object obj81 = obj80 & 1;
		bool flag12 = obj81 == null;
		object obj82 = !flag12;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			num10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v52 (Il2CppRgctx<ListView.NestedListViewController`3>)+120]");
		object obj83 = 0;
		object obj84 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
		object obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-100]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-D8]");
		object obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
		object obj89;
		object obj91;
		object obj92 = default(object);
		object obj93;
		nint num11;
		object obj121;
		object obj122;
		nint num18;
		object obj150;
		object obj151;
		object obj152;
		object obj153;
		object obj154;
		object obj155;
		object obj123;
		object obj149;
		object obj111;
		object obj116;
		object obj112;
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+20]");
			object obj88 = 0;
			obj89 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+20]");
			object obj90 = -0;
			if (obj76 >= obj90)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+84]");
				obj90 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+84]");
				obj88 = 0 - obj88;
				bool flag13 = obj88 >= obj76;
				obj91 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+84]");
				obj92 = 0;
				obj93 = obj88;
				num11 = num8;
				if (flag13)
				{
					goto IL_075f;
				}
			}
			obj89 = 0 - obj89;
			obj91 = obj46;
			obj92 = obj90;
			obj93 = obj88;
			num11 = num8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+60]");
			obj93 = 0;
			object obj94 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X22_v3+60]");
			obj89 = obj94 + 0;
			obj76 = obj89;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v66 (Il2CppRgctx<ListView.NestedListViewController`3>)+1C0]");
			obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v66 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
			object obj95 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v67+28]");
			object obj96 = 0 & 0x80000000L;
			bool flag14 = obj96 == null;
			object obj97 = !flag14;
			object obj98 = obj45;
			if (obj97 == null)
			{
				obj98 = obj45;
			}
			obj87 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
			obj84 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X1_v11+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-78]");
			bool flag15 = (nint)0 != 1;
			obj91 = obj46;
			obj86 = obj77;
			num11 = num8;
			if (!flag15)
			{
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v25 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				object obj99 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v25 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				object obj100 = (nint)0 + (nint)309;
				obj56 = obj100;
				object obj101 = obj100 & 1;
				bool flag16 = obj101 == null;
				object obj102 = !flag16;
				if (obj102 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					nint num14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X9_v35 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
					obj99 = 0;
					nint num15 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v25 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
					object obj103 = 0;
					nint num15 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X9_v26 (Il2CppRgctx<ListView.NestedListViewController`3>)+130]");
				obj83 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v74+28]");
				bool flag17 = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v74+28]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v74+28]");
				object obj104 = num16 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v74+28]");
				object obj105 = 0 & obj104;
				bool flag18 = (nint)obj105 < 0;
				object obj106 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 160));
				bool flag19 = flag17 == flag18;
				object obj107 = !flag19;
				obj73 = ~obj107;
				if (obj73 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A0]");
					obj87 = 0;
				}
				else
				{
					obj87 = obj106;
				}
				obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
				object obj108 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 16));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
				obj86 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-98]");
				bool flag20 = (nint)0 == 0;
				obj91 = obj46;
				obj84 = 0;
				num11 = num8;
				if (!flag20)
				{
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v79 (Il2CppRgctx<ListView.NestedListViewController`3>)+F0]");
					object obj109 = 0;
					object obj110 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v80-100]");
					obj111 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v80-100]");
					_ = 0;
					obj112 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X1_v15+10] (should have been resolved before IL gen)");
					object obj113 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 24));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v82-100]");
					object obj114 = 0;
					object obj115 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 8));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E0]");
					obj116 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
					object obj117 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 176));
					_ = 0;
					object obj118 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
					object obj119 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
					object obj120 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 168));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-E8]");
					obj121 = 0;
					obj122 = obj46;
					num18 = num8;
					object obj125 = default(object);
					while (true)
					{
						nint num19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v88 (Il2CppRgctx<ListView.NestedListViewController`3>)+138]");
						obj123 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X1_v8] (should have been resolved before IL gen)");
						object obj124 = obj125 & 1;
						if (obj124 == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
						object obj126 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v90+20]");
						object obj127 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v91+C0]");
						object obj128 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v92+100]");
						object obj129 = 0;
						object obj130 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v673 @ X1_v19+10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
						obj122 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X21_v2+20]");
						object obj131 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v94+C0]");
						object obj132 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v95+70]");
						object obj133 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v96+28]");
						bool flag21 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v96+28]");
						nint num20 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v96+28]");
						object obj134 = num20 ^ 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v96+28]");
						object obj135 = 0 & obj134;
						bool flag22 = (nint)obj135 < 0;
						bool flag23 = flag21 == flag22;
						object obj136 = !flag23;
						obj73 = ~obj136;
						if (obj73 == null)
						{
							object obj137 = obj121;
						}
						else
						{
							object obj137 = obj120;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X21_v2+20]");
						object obj138 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v98+C0]");
						object obj139 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X9_v30+90]");
						object obj140 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v99+28]");
						object obj141 = 0 & 0x80000000L;
						bool flag24 = obj141 == null;
						object obj142 = !flag24;
						object obj143 = obj42;
						if (obj142 == null)
						{
							obj143 = obj42;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X9_v30+1C8]");
						object obj144 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X9_v30+70]");
						object obj145 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X9_v31+28]");
						obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X9_v31+28]");
						object obj146 = 0 & 0x80000000L;
						bool flag25 = obj146 == null;
						object obj147 = !flag25;
						object obj148 = obj45;
						if (obj147 == null)
						{
							obj148 = obj45;
						}
						obj112 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ X1_v22+10] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
						num18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
						obj114 = 0;
						obj111 = obj76;
						obj116 = obj77;
					}
					obj149 = obj85;
					obj150 = obj92;
					obj151 = obj89;
					obj152 = obj93;
					obj153 = obj73;
					obj154 = obj56;
					obj155 = 0;
					goto IL_103e;
				}
			}
		}
		goto IL_075f;
		IL_080e:
		OutOfMemoryException ex = new OutOfMemoryException();
		if ((nint)obj123 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj156 = default(object);
			obj155 = obj156;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			goto IL_103e;
		}
		object obj157 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 152));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D3ACE4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		return;
		IL_103e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
		object obj158 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v55+20]");
		object obj159 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v56+C0]");
		object obj160 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v58+F8]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v58+F8]");
		object obj162 = (nint)0 + (nint)309;
		object obj163 = obj162 & 1;
		bool flag26 = obj163 == null;
		object obj164 = !flag26;
		if (obj164 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
			object obj165 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v59+20]");
			object obj166 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v60+C0]");
			obj160 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v58+140]");
		obj83 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
		obj87 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
		obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		bool flag27 = obj155 == null;
		object obj167 = !flag27;
		obj85 = 0;
		obj91 = obj122;
		obj84 = 0;
		obj92 = obj150;
		obj89 = obj151;
		obj93 = obj152;
		obj73 = obj153;
		obj56 = obj154;
		obj65 = obj121;
		num11 = num18;
		obj149 = 0;
		obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
		obj116 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
		obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v58+140]");
		obj123 = 0;
		if (obj167 == null)
		{
			goto IL_075f;
		}
		goto IL_080e;
		IL_075f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj168 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
		if (obj168 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		obj149 = obj85;
		obj122 = obj91;
		obj111 = obj84;
		obj150 = obj92;
		obj151 = obj89;
		obj152 = obj93;
		obj153 = obj73;
		obj116 = obj86;
		obj112 = obj87;
		obj123 = obj83;
		obj154 = obj56;
		obj121 = obj65;
		num18 = num11;
		goto IL_080e;
	}

	protected unsafe override bool GetNewItem(TData datum, out TItem item)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_022c: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0259: Expected O, but got Ref
		//IL_026f: Expected O, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028e: Expected O, but got Ref
		//IL_02c2: Expected O, but got I
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02f4: Expected O, but got Ref
		//IL_030d: Expected O, but got I4
		//IL_00ac: Expected O, but got I
		//IL_0202: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00f3: Expected O, but got I8
		//IL_010d: Expected O, but got I4
		//IL_036e: Expected O, but got Ref
		//IL_01b5: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		//IL_03b5: Expected O, but got I
		//IL_03d0: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X26_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+135]");
		object obj6 = (nint)0 & (nint)1;
		bool flag = obj6 == null;
		object obj7 = !flag;
		nint num2 = 0;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X26_v5 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj4 = 0;
			num2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+FC]");
		object obj8 = (nint)0 + (nint)16;
		object obj9 = obj8 + 15;
		object obj10 = obj9 & 0x1FFFFFFF0L;
		object obj11 = default(object);
		NestedListViewController<TData, TItem, TIndex> nestedListViewController = (NestedListViewController<TData, TItem, TIndex>)((ref *(?*)(&obj11)) - (ref *(?*)obj10));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+FC]");
		object obj12 = (nint)0 + (nint)15;
		object obj13 = obj12 & 0x1FFFFFFF0L;
		object obj14 = (ref *(?*)(&obj11)) - (ref *(?*)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
		bool flag2 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
		object obj15 = num4 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
		object obj16 = 0 & obj15;
		bool flag3 = (nint)obj16 < 0;
		TData val = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 120));
		bool flag4 = flag2 == flag3;
		object obj17 = !flag4;
		object obj18 = ~obj17;
		if (obj18 != null)
		{
			TData val2 = val;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		if ((object)this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X26_v2 (Il2CppRgctx<ListView.NestedListViewController`3>)+1D8]");
			TData val2 = (TData)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+28]");
			object obj19 = 0 & 0x80000000L;
			bool flag5 = obj19 == null;
			object obj20 = !flag5;
			if (obj20 == null)
			{
				obj14 = obj14;
			}
			nint num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
			object obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 105));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ X1_v2 (TData)+10] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-69]");
			bool flag6 = (nint)0 != 1;
			NestedListViewController<TData, TItem, TIndex> nestedListViewController2 = this;
			if (!flag6)
			{
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v13 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v13 (Il2CppRgctx<ListView.NestedListViewController`3>)+A0]");
				object obj23 = (nint)0 + (nint)309;
				object obj24 = obj23 & 1;
				bool flag7 = obj24 == null;
				object obj25 = !flag7;
				nint num7 = 0;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					num7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v14 (Il2CppRgctx<ListView.NestedListViewController`3>)+1E8]");
				val2 = (TData)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F8]");
				_ = 0;
				obj21 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
				num5 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref item);
				nestedListViewController2 = nestedListViewController;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-69]");
				return false;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v6+FC]");
			NestedListViewController<TData, TItem, TIndex> nestedListViewController2 = (NestedListViewController<TData, TItem, TIndex>)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		bool result = default(bool);
		return result;
	}

	private unsafe void ToggleExpanded(TData datum)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0342: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036f: Expected O, but got Ref
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0397: Expected O, but got I4
		//IL_00ac: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_03bb: Expected O, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03e8: Expected O, but got Ref
		//IL_03f8: Expected O, but got I
		//IL_040e: Expected O, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_042d: Expected O, but got Ref
		//IL_043a: Expected O, but got Ref
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0468: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_012e: Expected O, but got I
		//IL_0486: Expected O, but got I
		//IL_04ba: Expected O, but got I
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04ec: Expected O, but got Ref
		//IL_0505: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_052f: Expected O, but got Ref
		//IL_01c6: Expected O, but got I
		//IL_01d6: Expected O, but got I
		//IL_01f0: Expected O, but got I8
		//IL_020a: Expected O, but got I4
		//IL_057c: Expected O, but got Ref
		//IL_0594: Expected O, but got Ref
		//IL_05a2: Expected O, but got Ref
		//IL_05c2: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected O, but got Unknown
		//IL_0600: Expected O, but got I4
		//IL_0268: Expected O, but got I
		//IL_061e: Expected O, but got I
		//IL_0652: Expected O, but got I
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0684: Expected O, but got Ref
		//IL_069d: Expected O, but got I4
		//IL_024d: Expected O, but got I
		//IL_06c7: Expected O, but got Ref
		//IL_0283: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_02bb: Expected O, but got I
		//IL_02d5: Expected O, but got I8
		//IL_02ef: Expected O, but got I4
		//IL_071c: Expected O, but got I
		//IL_072f: Expected O, but got Ref
		//IL_0747: Expected O, but got Ref
		//IL_0755: Expected O, but got Ref
		//IL_0764: Expected I, but got O
		//IL_0774: Expected O, but got I
		//IL_078b: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
		object obj5 = (nint)0 + (nint)309;
		object obj6 = obj5;
		object obj7 = obj5 & 1;
		bool flag = obj7 == null;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v24 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v24 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj9 = (nint)0 + (nint)309;
			obj6 = obj9;
			nint num3 = 0;
			object obj11 = default(object);
			object obj10 = obj11;
		}
		else
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X9_v1 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj10 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+FC]");
		object obj12 = (nint)0 + (nint)16;
		object obj13 = obj12 + 15;
		object obj14 = obj13 & 0x1FFFFFFF0L;
		object obj16 = default(object);
		object obj15 = (ref *(?*)(&obj16)) - (ref *(?*)obj14);
		object obj17 = obj6 & 1;
		bool flag2 = obj17 == null;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v22 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v22 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj19 = (nint)0 + (nint)309;
			obj6 = obj19;
			nint num3 = 0;
			object obj21 = default(object);
			object obj20 = obj21;
		}
		else
		{
			object obj20 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v11+FC]");
		object obj22 = (nint)0 + (nint)16;
		object obj23 = obj22 + 15;
		object obj24 = obj23 & 0x1FFFFFFF0L;
		object obj25 = (ref *(?*)(&obj16)) - (ref *(?*)obj24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v16+FC]");
		object obj27 = (nint)0 + (nint)15;
		object obj28 = obj27 & 0x1FFFFFFF0L;
		object obj29 = (ref *(?*)(&obj16)) - (ref *(?*)obj28);
		object obj30 = (ref *(?*)(&obj16)) - (ref *(?*)obj28);
		_ = 0;
		object obj31 = obj6 & 1;
		bool flag3 = obj31 == null;
		object obj32 = !flag3;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v20 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			obj4 = 0;
			object obj34 = default(object);
			object obj33 = obj34;
			nint num3 = 0;
		}
		else
		{
			object obj33 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X9_v4 (Il2CppRgctx<ListView.NestedListViewController`3>)+118]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+28]");
		bool flag4 = (nint)0 < (nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+28]");
		object obj35 = num6 ^ 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v4+28]");
		object obj36 = 0 & obj35;
		bool flag5 = (nint)obj36 < 0;
		TData val = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
		bool flag6 = flag4 == flag5;
		object obj37 = !flag6;
		object obj38 = ~obj37;
		if (obj38 == null)
		{
			TData val2 = datum;
		}
		else
		{
			TData val2 = val;
		}
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
		bool flag7 = (nint)0 == 0;
		object obj40 = obj29;
		object obj41 = obj15;
		if (!flag7)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v26 (Il2CppRgctx<ListView.NestedListViewController`3>)+188]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v26 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v27+28]");
			object obj44 = 0 & 0x80000000L;
			bool flag8 = obj44 == null;
			object obj45 = !flag8;
			object obj46 = obj29;
			if (obj45 == null)
			{
				obj46 = obj29;
			}
			object obj47 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 105));
			object obj48 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			object obj49 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 89));
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ X1_v4+10] (should have been resolved before IL gen)");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
			object obj51 = (nint)0 + (nint)309;
			object obj52 = obj51 & 1;
			bool flag9 = obj52 == null;
			object obj53 = !flag9;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X9_v18 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				obj50 = 0;
				nint num10 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X9_v7 (Il2CppRgctx<ListView.NestedListViewController`3>)+90]");
				object obj54 = 0;
				nint num10 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X9_v8 (Il2CppRgctx<ListView.NestedListViewController`3>)+118]");
			action = (Action)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v33+28]");
			bool flag10 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v33+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v33+28]");
			object obj55 = num11 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v33+28]");
			object obj56 = 0 & obj55;
			bool flag11 = (nint)obj56 < 0;
			TData val3 = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
			bool flag12 = flag10 == flag11;
			object obj57 = !flag12;
			object obj58 = ~obj57;
			if (obj58 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-68]");
				TData val2 = (TData)0;
			}
			else
			{
				TData val2 = val3;
			}
			obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC2574");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ListView.NestedListViewController`3<TData, TItem, TIndex>)+F0]");
			bool flag13 = (nint)0 == 0;
			obj40 = obj30;
			obj41 = obj25;
			if (!flag13)
			{
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+190]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X9_v11 (Il2CppRgctx<ListView.NestedListViewController`3>)+70]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X9_v12+28]");
				object obj61 = 0 & 0x80000000L;
				bool flag14 = obj61 == null;
				object obj62 = !flag14;
				object obj63 = obj30;
				if (obj62 == null)
				{
					obj63 = obj30;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-69]");
				object obj64 = (nint)0 ^ (nint)1;
				object obj65 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 89));
				TData val2 = (TData)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
				obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 89));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X1_v6+10] (should have been resolved before IL gen)");
				nint num13 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v40 (Il2CppClass<ListView.NestedListViewController`3<TData, TItem, TIndex>>)+280]");
				obj41 = 0;
				base.StartSettling();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				bool flag15 = obj66 != null;
				obj40 = obj30;
				action = null;
				if (!flag15)
				{
					return;
				}
				goto IL_0321;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0321;
		IL_0321:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected NestedListViewController()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_014e: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_018d: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<ListView.NestedListViewController`3>)+180]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<ListView.NestedListViewController`3>)+180]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewController`3>)+1F0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ X1_v1] (should have been resolved before IL gen)");
		object obj6 = this + 240;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v9 (Il2CppRgctx<ListView.NestedListViewController`3>)+158]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v9 (Il2CppRgctx<ListView.NestedListViewController`3>)+158]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag2 = obj10 == null;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v13 (Il2CppRgctx<ListView.NestedListViewController`3>)+1F8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X1_v3] (should have been resolved before IL gen)");
		object obj13 = this + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v16 (Il2CppRgctx<ListView.NestedListViewController`3>)+200]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v76 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
