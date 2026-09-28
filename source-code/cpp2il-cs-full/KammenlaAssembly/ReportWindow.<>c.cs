using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.WebRequests;
using ReportEnums;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

public class ReportWindow : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<IDummyReportElement> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <HighlightRequired>b__10_0(IDummyReportElement r)
		{
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
			object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2576;
			nint num = (nint)r;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IDummyReportElement>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IDummyReportElement>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<IDummyReportElement>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			goto IL_0124;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_0124:
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
			IL_00d9:
			object obj7 = obj3 + 4;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0124;
		}
	}

	private ProblemCategory problemCategory;

	private DummyBaseDropMenu serviceType;

	private GameObject ReportElementGroupsParent;

	private Reports Reports;

	private string mostRecentlySentContactEmail;

	private static bool isSending;

	private List<IDummyReportElement> reportElementsList
	{
		get
		{
			//IL_0011: Expected O, but got I
			if ((object)ReportElementGroupsParent != null)
			{
				object obj = (nint)0 + (nint)1704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33C3C");
				IEnumerable<object> source = default(IEnumerable<object>);
				return (List<IDummyReportElement>)(object)Enumerable.ToList(source);
			}
			return (List<IDummyReportElement>)(object)new NullReferenceException();
		}
	}

	public unsafe void SendReport()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_1619: Expected O, but got Ref
		//IL_1621: Expected O, but got Ref
		//IL_1651: Expected O, but got I
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1661: Expected O, but got Unknown
		//IL_0154: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_0108: Expected O, but got Ref
		//IL_0110: Expected O, but got Ref
		//IL_0121: Expected O, but got I4
		//IL_12ee: Expected O, but got Ref
		//IL_12f6: Expected O, but got Ref
		//IL_12ff: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_1a19: Expected O, but got Ref
		//IL_0274: Expected O, but got I
		//IL_029c: Expected O, but got Ref
		//IL_02b3: Expected O, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02d0: Expected O, but got I4
		//IL_02d9: Expected O, but got Ref
		//IL_02e2: Expected O, but got I4
		//IL_18bd: Expected O, but got Ref
		//IL_15f3: Expected O, but got I
		//IL_1603: Expected O, but got I
		//IL_160c: Expected O, but got I4
		//IL_07b6: Expected O, but got I
		//IL_07c6: Expected O, but got I
		//IL_07cf: Expected O, but got I4
		//IL_07d8: Expected O, but got I4
		//IL_1a34: Expected O, but got I
		//IL_1a67: Expected O, but got I4
		//IL_18f7: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_12cf: Expected O, but got I4
		//IL_0334: Expected O, but got I
		//IL_03ff: Expected O, but got I4
		//IL_093d: Expected O, but got I4
		//IL_094d: Expected O, but got I
		//IL_170d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1712: Expected O, but got Unknown
		//IL_036f: Expected O, but got I
		//IL_098c: Expected I, but got O
		//IL_099c: Expected O, but got I
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_128d: Expected O, but got I
		//IL_0588: Expected O, but got I
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected O, but got Unknown
		//IL_0a4c: Expected O, but got I4
		//IL_065b: Expected O, but got I4
		//IL_045a: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		//IL_135e: Expected O, but got Ref
		//IL_17f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Expected O, but got Unknown
		//IL_05c3: Expected O, but got I
		//IL_052d: Expected O, but got I4
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_1470: Expected O, but got I
		//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bd: Expected O, but got Unknown
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_1788: Expected O, but got Unknown
		//IL_0495: Expected O, but got I
		//IL_1374: Expected O, but got Ref
		//IL_06b6: Expected O, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_0809: Expected O, but got I
		//IL_0819: Expected O, but got I
		//IL_083b: Expected O, but got I4
		//IL_1742: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Expected O, but got Unknown
		//IL_0aa0: Expected I, but got O
		//IL_0ab0: Expected O, but got I
		//IL_0ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05f4: Expected O, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0867: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_1864: Expected O, but got I4
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected O, but got Unknown
		//IL_188c: Expected O, but got I4
		//IL_06f1: Expected O, but got I
		//IL_192e: Expected O, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_04c6: Expected O, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_138a: Expected O, but got Ref
		//IL_13e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13eb: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected O, but got Unknown
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_0899: Expected O, but got Unknown
		//IL_0b81: Expected I, but got O
		//IL_0b91: Expected O, but got I
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected O, but got Unknown
		//IL_148e: Expected O, but got Ref
		//IL_149e: Expected O, but got I
		//IL_1419: Expected O, but got I
		//IL_079c: Expected O, but got I
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_08ea: Expected O, but got I
		//IL_08f3: Expected O, but got I4
		//IL_0901: Expected O, but got I4
		//IL_0c22: Expected O, but got I
		//IL_0c3c: Expected O, but got I
		//IL_143a: Expected O, but got I4
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_071a: Expected O, but got I
		//IL_0c82: Expected I, but got O
		//IL_0c92: Expected O, but got I
		//IL_0cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Expected O, but got Unknown
		//IL_14bc: Expected O, but got Ref
		//IL_14cc: Expected O, but got I
		//IL_0d23: Expected O, but got I
		//IL_0d3d: Expected O, but got I
		//IL_0d83: Expected I, but got O
		//IL_0d93: Expected O, but got I
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_14f2: Expected O, but got I
		//IL_0e64: Expected I, but got O
		//IL_0e74: Expected O, but got I
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Expected O, but got Unknown
		//IL_1518: Expected O, but got I
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Expected O, but got Unknown
		//IL_0f52: Expected O, but got I4
		//IL_0f7b: Expected O, but got I
		//IL_1546: Expected O, but got I
		//IL_0fcf: Expected I8, but got I4
		//IL_194b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1950: Expected O, but got Unknown
		//IL_1966: Expected O, but got I
		//IL_1974: Expected I, but got O
		//IL_1007: Expected O, but got I4
		//IL_1084: Unknown result type (might be due to invalid IL or missing references)
		//IL_1089: Expected O, but got Unknown
		//IL_1091: Expected I, but got O
		//IL_10a1: Expected O, but got I
		//IL_1138: Expected O, but got I4
		//IL_19d4: Expected O, but got I
		//IL_19fd: Expected I8, but got I
		//IL_10dc: Expected O, but got I
		//IL_11ad: Expected O, but got I4
		//IL_114e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1153: Expected O, but got Unknown
		//IL_115b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Expected O, but got Unknown
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ef: Expected O, but got Unknown
		//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd: Expected O, but got Unknown
		//IL_1228: Expected O, but got I
		//IL_123e: Expected O, but got Ref
		//IL_1246: Expected native int or pointer, but got O
		//IL_125b: Expected O, but got I
		//IL_1270: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		object obj4 = typeof(RegisteredWaitHandle) + 656;
		object obj5 = default(object);
		string text = (string)(&obj5);
		string text2 = (string)(&obj5);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+B8]");
		object obj7 = 0;
		object obj8 = obj7 - 1;
		bool flag = obj8 == null;
		bool flag2 = (nint)obj7 != 1;
		string text3;
		SupportTicketRequestModel supportTicketRequestModel;
		SupportTicketRequestModel supportTicketRequestModel2;
		string text5;
		string text6;
		object obj45;
		object obj46;
		object obj16;
		Action action;
		string text4;
		NullReferenceException ex;
		object obj18;
		NullReferenceException ex2;
		if (!flag2)
		{
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v165+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = "Picking audio files is not supported on iOS" + 616;
			object obj13 = "Read object reference Id '{0}' for {1}." + 2616;
			text3 = (string)obj13;
			object obj14 = "Network Authentication Required" + 3128;
			text4 = (string)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj15 = 0;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			bool flag4 = obj15 != null;
			object obj17 = (object)(&obj5);
			obj18 = (object)(&obj5);
			ex = (NullReferenceException)obj12;
			supportTicketRequestModel = (SupportTicketRequestModel)152989696;
			if (!flag4)
			{
				PopupWindow.ShowInfo((string)obj12, (string)obj13, (string)obj14);
				return;
			}
		}
		else
		{
			_ = ref obj5;
			_ = ref obj5;
			obj7 = 1;
			object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v88+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgBody = "Read object reference Id '{0}' for {1}." + 2592;
			PopupWindow.ShowLoading((string)msgBody);
			supportTicketRequestModel2 = SupportTicketRequestModel.MakeDefaultInstance(problemCategory);
			HighlightRequired();
			bool flag6 = (object)ReportElementGroupsParent == null;
			text3 = null;
			object obj17;
			if (!flag6)
			{
				object obj22 = (nint)0 + (nint)1704;
				object obj23 = (nint)0 + (nint)2144;
				text4 = (string)obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33C3C");
				text3 = (string)obj23;
				IEnumerable<object> source = default(IEnumerable<object>);
				List<object> list = Enumerable.ToList(source);
				if (list != null)
				{
					List<object>.Enumerator enumerator = list.GetEnumerator();
					_ = ref obj5;
					_ = ref obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
					long? num = (long?)(object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-80]");
					_ = 0;
					object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
					_ = 0;
					object obj25 = (nint)0 + (nint)1600;
					object obj26 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2576;
					object obj27 = 119877632;
					obj17 = (object)(&obj5);
					obj16 = 1;
					object obj36 = default(object);
					object obj48 = default(object);
					object obj54 = default(object);
					object obj63 = default(object);
					while (true)
					{
						text3 = (string)obj25;
						List<object>.Enumerator enumerator2 = (List<object>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
						if (!((List<object>.Enumerator*)enumerator2)->MoveNext())
						{
							goto IL_07a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
						if ((nint)0 == 0)
						{
							break;
						}
						object obj29 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v74+12E]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v74+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03ec;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v74+B0]");
						object obj31 = (nint)0 + (nint)8;
						bool flag7 = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X10_v39-8]");
							obj8 = 0 - obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X10_v39-8]");
							if (0 == (nint)obj26)
							{
								break;
							}
							obj17 = obj31 + 16;
							obj30--;
							obj8 = obj30 - 1;
							flag = obj8 == null;
							flag2 = (nint)obj30 != 1;
							obj31 = obj17;
							flag7 = flag2;
							if (flag2)
							{
								continue;
							}
							goto IL_03ec;
						}
						object obj32 = obj31 + 2;
						object obj33 = obj29 + obj32;
						object obj34 = obj33 + 312;
						obj17 = obj31;
						flag2 = flag7;
						goto IL_16fa;
						IL_051a:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						text4 = (string)1;
						goto IL_1770;
						IL_1770:
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1076 @ X0_v131] (should have been resolved before IL gen)");
						object obj35 = obj36 & 1;
						if (obj35 == null)
						{
							obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
							object obj37 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
							text5 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
							text6 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1094 @ X0_v134+E4]");
							bool flag8 = (nint)0 == 0;
							object obj38 = !flag8;
							if (obj38 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object message = "Picking audio files is not supported on iOS" + 592;
							object obj39 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1159 @ X0_v137+E4]");
							bool flag9 = (nint)0 == 0;
							object obj40 = !flag9;
							if (obj40 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object title = "Drop Menu Toggle" + 3600;
							object obj41 = "Network Authentication Required" + 3128;
							text4 = (string)obj41;
							PopupWindow.ShowError((string)title, (string)message, (string)obj41);
							HighlightRequired();
							object obj42 = typeof(RegisteredWaitHandle) + 656;
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1240 @ X8_v102+B8]");
							object obj44 = 0;
							obj44 = 0;
							action = null;
							obj45 = 6;
							goto IL_18e7;
						}
						goto IL_0570;
						IL_18e7:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
						obj46 = 0;
						supportTicketRequestModel = supportTicketRequestModel2;
						goto IL_1a28;
						IL_0648:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						text4 = (string)1;
						goto IL_17e6;
						IL_07a6:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
						text5 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
						text6 = (string)0;
						obj18 = 119877632;
						obj45 = 33;
						goto IL_18e7;
						IL_03ec:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						text4 = (string)2;
						goto IL_16fa;
						IL_16fa:
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v910 @ X0_v106] (should have been resolved before IL gen)");
						object obj47 = obj48 & 1;
						if (obj47 == null)
						{
							goto IL_0570;
						}
						object obj49 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v87+12E]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v87+12E]");
						if ((nint)0 == 0)
						{
							goto IL_051a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v87+B0]");
						object obj50 = (nint)0 + (nint)8;
						bool flag10 = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X10_v34-8]");
							obj8 = 0 - obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X10_v34-8]");
							if (0 == (nint)obj26)
							{
								break;
							}
							obj17 = obj50 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ X8_v87+12E]");
							obj16 = -1;
							obj8 = obj16 - 1;
							flag = obj8 == null;
							flag2 = (nint)obj16 != 1;
							obj50 = obj17;
							flag10 = flag2;
							if (flag2)
							{
								continue;
							}
							goto IL_051a;
						}
						obj16 = obj50 + 1;
						object obj51 = obj49 + obj16;
						object obj52 = obj51 + 312;
						obj17 = obj50;
						flag2 = flag10;
						goto IL_1770;
						IL_0742:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						text4 = null;
						goto IL_1840;
						IL_17e6:
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1085 @ X0_v110] (should have been resolved before IL gen)");
						object obj53 = obj54 & 1;
						if (obj53 == null)
						{
							continue;
						}
						object obj55 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v81+12E]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v81+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0742;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v81+B0]");
						object obj56 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X10_v23-8]");
							if (0 == (nint)obj26)
							{
								break;
							}
							obj17 = obj56 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v81+12E]");
							obj16 = -1;
							bool flag11 = (nint)obj16 != 1;
							obj56 = obj17;
							if (flag11)
							{
								continue;
							}
							goto IL_0742;
						}
						obj16 = obj56;
						object obj57 = obj55 + obj56;
						object obj58 = obj57 + 312;
						obj17 = obj56;
						goto IL_1840;
						IL_0570:
						object obj59 = obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v78+12E]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v78+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0648;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v78+B0]");
						object obj60 = (nint)0 + (nint)8;
						bool flag12 = flag2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X10_v28-8]");
							obj8 = 0 - obj26;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X10_v28-8]");
							if (0 == (nint)obj26)
							{
								break;
							}
							obj17 = obj60 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v78+12E]");
							obj16 = -1;
							obj8 = obj16 - 1;
							flag = obj8 == null;
							flag2 = (nint)obj16 != 1;
							obj60 = obj17;
							flag12 = flag2;
							if (flag2)
							{
								continue;
							}
							goto IL_0648;
						}
						obj16 = obj60 + 1;
						object obj61 = obj59 + obj16;
						object obj62 = obj61 + 312;
						obj17 = obj60;
						flag2 = flag12;
						goto IL_17e6;
						IL_1840:
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1212 @ X0_v113] (should have been resolved before IL gen)");
						bool flag13 = (nint)obj63 < 17;
						object obj64 = !flag13;
						object obj65 = obj63 - 17;
						bool flag14 = obj65 == null;
						object obj66 = !flag14;
						object obj67 = obj64 & obj66;
						if (obj67 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X24_v7+v286 @ X0_v115*2]");
							object obj68 = (nint)85290000 + (nint)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v280 @ X9_v47 (should have been resolved before IL gen)");
							goto IL_07a6;
						}
						goto IL_13d7;
					}
					ex2 = new NullReferenceException();
					obj18 = 119877632;
					supportTicketRequestModel = supportTicketRequestModel2;
					goto IL_159d;
				}
			}
			ex = new NullReferenceException();
			obj17 = (object)(&obj5);
			obj18 = (object)(&obj5);
			obj16 = 1;
			supportTicketRequestModel = supportTicketRequestModel2;
		}
		goto IL_130c;
		IL_159d:
		while ((nint)text3 != 1)
		{
			object obj69 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223ABF8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
		object obj70 = default(object);
		obj46 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-C0]");
		text5 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B8]");
		text6 = (string)0;
		obj45 = 0;
		goto IL_1a28;
		IL_1125:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text4 = (string)6;
		object obj72 = default(object);
		object obj71 = obj72;
		goto IL_19c4;
		IL_19c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v43+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1335 @ X8_v43] (should have been resolved before IL gen)");
		object obj73 = default(object);
		bool flag15 = obj73 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v43+8]");
		long num2 = 0L;
		object obj75;
		if (!flag15)
		{
			object obj74 = obj75;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1413 @ X0_v57+E4]");
			bool flag16 = (nint)0 == 0;
			object obj76 = !flag16;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel == null)
			{
				ex2 = new NullReferenceException();
				goto IL_159d;
			}
			Room currentRoom = sessionModel.CurrentRoom;
			long gameID = SFSKammelnaRoomExtensions.GetGameID(currentRoom);
			_ = 0;
			_ = 0;
			object obj77 = (nint)0 + (nint)3184;
			text4 = (string)obj77;
			long? num3 = (long?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
			*(long?*)(nint)num3 = gameID;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			long? num = (long?)(object)0;
			SupportTicketRequestModel supportTicketRequestModel3 = supportTicketRequestModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-90]");
			supportTicketRequestModel3.<GameId>k__BackingField = (long?)(object)0;
			num2 = gameID;
		}
		goto IL_193c;
		IL_127d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj78 = 0;
		obj16 = obj78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
		if (obj78 == null)
		{
			return;
		}
		goto IL_130c;
		IL_1a28:
		object obj79 = (nint)0 + (nint)1592;
		text3 = (string)obj79;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
		((List<object>.Enumerator*)null)->Dispose();
		bool flag17 = obj46 == null;
		object obj80 = !flag17;
		if (obj80 == null)
		{
			if ((nint)obj45 != 33)
			{
				bool flag18 = obj45 == null;
				object obj81 = !flag18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-88]");
				ex = (NullReferenceException)0;
				if (obj81 != null)
				{
					goto IL_127d;
				}
			}
			DummyBaseDropMenu dummyBaseDropMenu = serviceType;
			if ((object)serviceType != null)
			{
				nint num4 = (nint)dummyBaseDropMenu;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X8_v13 (Il2CppClass<DummyBaseDropMenu>)+178]");
				obj16 = 0;
				object selectedItem = serviceType.selectedItem;
				object obj82 = typeof(List<Tween>) + 2512;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				text3 = (string)obj82;
				object obj83 = default(object);
				if (obj83 != null)
				{
					obj16 = obj83;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
					if (obj83 != null)
					{
						InvalidCastException ex3 = new InvalidCastException();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
						text3 = (string)0;
						ex2 = (NullReferenceException)(object)ex3;
						goto IL_159d;
					}
				}
				bool flag19 = supportTicketRequestModel == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
				bool flag20 = !flag19;
				object obj84 = !flag20;
				if (obj84 == null)
				{
					SupportTicketRequestModel supportTicketRequestModel4 = supportTicketRequestModel;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X26_v1 (System.String)+4]");
					supportTicketRequestModel4.<SuggestionsAndInquiriesType>k__BackingField = SuggestionsAndInquiriesType.None;
					DummyBaseDropMenu dummyBaseDropMenu2 = serviceType;
					if ((object)serviceType != null)
					{
						nint num5 = (nint)dummyBaseDropMenu2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X8_v16 (Il2CppClass<DummyBaseDropMenu>)+178]");
						obj16 = 0;
						object selectedItem2 = serviceType.selectedItem;
						object obj85 = typeof(List<Tween>) + 2504;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						text3 = (string)obj85;
						object obj86 = default(object);
						if (obj86 != null)
						{
							obj16 = obj86;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
							if (obj86 != null)
							{
								InvalidCastException ex4 = new InvalidCastException();
								text4 = (string)(&obj5);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
								text3 = (string)0;
								ex2 = (NullReferenceException)(object)ex4;
								goto IL_159d;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
						SupportTicketRequestModel supportTicketRequestModel5 = supportTicketRequestModel;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X25_v1 (System.String)+4]");
						supportTicketRequestModel5.<SubscriptionAndCoinsIssue>k__BackingField = SubscriptionAndCoinsIssues.None;
						DummyBaseDropMenu dummyBaseDropMenu3 = serviceType;
						if ((object)serviceType != null)
						{
							nint num6 = (nint)dummyBaseDropMenu3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v19 (Il2CppClass<DummyBaseDropMenu>)+178]");
							obj16 = 0;
							object selectedItem3 = serviceType.selectedItem;
							object obj87 = typeof(List<Tween>) + 2480;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							text3 = (string)obj87;
							object obj88 = default(object);
							if (obj88 != null)
							{
								obj16 = obj88;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
								if (obj88 != null)
								{
									InvalidCastException ex5 = new InvalidCastException();
									text4 = (string)(&obj5);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
									text3 = (string)0;
									ex2 = (NullReferenceException)(object)ex5;
									goto IL_159d;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
							text4 = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-A8]");
							object obj89 = 0;
							SupportTicketRequestModel supportTicketRequestModel6 = supportTicketRequestModel;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1220 @ X8_v21+4]");
							supportTicketRequestModel6.<PlayerReportType>k__BackingField = PlayerReportType.None;
							DummyBaseDropMenu dummyBaseDropMenu4 = serviceType;
							if ((object)serviceType != null)
							{
								nint num7 = (nint)dummyBaseDropMenu4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ X8_v23 (Il2CppClass<DummyBaseDropMenu>)+178]");
								obj16 = 0;
								object selectedItem4 = serviceType.selectedItem;
								object obj90 = typeof(List<Tween>) + 2408;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								text3 = (string)obj90;
								object obj91 = default(object);
								if (obj91 != null)
								{
									obj16 = obj91;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
									if (obj91 != null)
									{
										InvalidCastException ex6 = new InvalidCastException();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
										text3 = (string)0;
										ex2 = (NullReferenceException)(object)ex6;
										goto IL_159d;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
								text4 = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-B0]");
								object obj92 = 0;
								SupportTicketRequestModel supportTicketRequestModel7 = supportTicketRequestModel;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ X8_v25+4]");
								supportTicketRequestModel7.<GameProblem>k__BackingField = GameProblems.None;
								DummyBaseDropMenu dummyBaseDropMenu5 = serviceType;
								if ((object)serviceType != null)
								{
									nint num8 = (nint)dummyBaseDropMenu5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X8_v27 (Il2CppClass<DummyBaseDropMenu>)+178]");
									obj16 = 0;
									object selectedItem5 = serviceType.selectedItem;
									object obj93 = typeof(List<Tween>) + 2472;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									text3 = (string)obj93;
									object obj94 = default(object);
									if (obj94 != null)
									{
										obj16 = obj94;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
										if (obj94 != null)
										{
											InvalidCastException ex7 = new InvalidCastException();
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
											text3 = (string)0;
											ex2 = (NullReferenceException)(object)ex7;
											goto IL_159d;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
									SupportTicketRequestModel supportTicketRequestModel8 = supportTicketRequestModel;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X23_v2 (System.String)+4]");
									supportTicketRequestModel8.<MembershipProblems>k__BackingField = MembershipProblems.None;
									DummyBaseDropMenu dummyBaseDropMenu6 = serviceType;
									if ((object)serviceType != null)
									{
										nint num9 = (nint)dummyBaseDropMenu6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1287 @ X8_v30 (Il2CppClass<DummyBaseDropMenu>)+178]");
										obj16 = 0;
										object selectedItem6 = serviceType.selectedItem;
										object obj95 = typeof(List<Tween>) + 2560;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										text3 = (string)obj95;
										object obj96 = default(object);
										if (obj96 != null)
										{
											obj16 = obj96;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
											if (obj96 != null)
											{
												InvalidCastException ex8 = new InvalidCastException();
												text4 = text5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X1_v3 (System.String)+40]");
												text3 = (string)0;
												ex2 = (NullReferenceException)(object)ex8;
												goto IL_159d;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1964");
										SupportTicketRequestModel supportTicketRequestModel9 = supportTicketRequestModel;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X22_v1 (System.String)+4]");
										supportTicketRequestModel9.<WebOrdersIssues>k__BackingField = WebOrdersProblems.None;
										obj75 = typeof(Queue<string>) + 848;
										object obj97 = obj75;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ X0_v38+E4]");
										bool flag21 = (nint)0 == 0;
										object obj98 = !flag21;
										if (obj98 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj99 = (nint)0 + (nint)2200;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
										SessionModel sessionModel2 = default(SessionModel);
										if ((object)sessionModel2 != null)
										{
											Room currentRoom2 = sessionModel2.CurrentRoom;
											bool flag22 = currentRoom2 == null;
											text4 = text6;
											num2 = 0L;
											if (flag22)
											{
												goto IL_193c;
											}
											object obj100 = obj75;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X0_v48+E4]");
											bool flag23 = (nint)0 == 0;
											object obj101 = !flag23;
											if (obj101 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
											SessionModel sessionModel3 = default(SessionModel);
											if ((object)sessionModel3 != null)
											{
												Room currentRoom3 = sessionModel3.CurrentRoom;
												if (currentRoom3 != null)
												{
													object obj102 = typeof(RegisteredWaitHandle) + 1376;
													nint num10 = (nint)currentRoom3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
													object obj103 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
													if ((nint)0 == 0)
													{
														goto IL_1125;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1351 @ X8_v42 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
													object obj104 = (nint)0 + (nint)8;
													object obj17;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1384 @ X10_v9-8]");
														if (0 == (nint)obj102)
														{
															break;
														}
														obj17 = obj104 + 16;
														obj103--;
														bool flag24 = (nint)obj103 != 1;
														obj104 = obj17;
														if (flag24)
														{
															continue;
														}
														goto IL_1125;
													}
													object obj105 = obj104 + 6;
													object obj106 = num10 + obj105;
													obj71 = obj106 + 312;
													obj17 = obj104;
													text4 = text6;
													goto IL_19c4;
												}
												ex2 = new NullReferenceException();
												text4 = text6;
												text3 = null;
											}
											else
											{
												ex2 = new NullReferenceException();
												text4 = text6;
												text3 = null;
											}
										}
										else
										{
											ex2 = new NullReferenceException();
											text4 = text6;
										}
									}
									else
									{
										ex2 = new NullReferenceException();
										text4 = text5;
									}
								}
								else
								{
									ex2 = new NullReferenceException();
								}
							}
							else
							{
								ex2 = new NullReferenceException();
							}
						}
						else
						{
							ex2 = new NullReferenceException();
							text4 = (string)(&obj5);
						}
					}
					else
					{
						ex2 = new NullReferenceException();
						text4 = (string)(&obj5);
					}
				}
				else
				{
					ex2 = new NullReferenceException();
					text4 = (string)(&obj5);
				}
			}
			else
			{
				ex2 = new NullReferenceException();
			}
		}
		else
		{
			OutOfMemoryException ex9 = new OutOfMemoryException();
			ex2 = (NullReferenceException)(object)ex9;
		}
		goto IL_159d;
		IL_193c:
		object obj107 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj108 = (nint)0 + (nint)712;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj108);
		KammelnaRequests.SendReport(supportTicketRequestModel, action2);
		action = null;
		text4 = null;
		text3 = (string)(object)action2;
		ex = (NullReferenceException)(object)supportTicketRequestModel;
		goto IL_127d;
		IL_130c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		ex2 = new NullReferenceException();
		goto IL_159d;
		IL_13d7:
		object obj109 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex10 = default(ArgumentOutOfRangeException);
		ex10..ctor();
		object obj110 = (nint)0 + (nint)720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex11 = new OutOfMemoryException();
		obj18 = 119877632;
		string text7 = default(string);
		text3 = text7;
		ex2 = (NullReferenceException)(object)ex11;
		supportTicketRequestModel = supportTicketRequestModel2;
		goto IL_159d;
	}

	private void OnSubmissionComplete(KammelnaResponseModel<bool> response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0ce6: Expected O, but got I
		//IL_0cef: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_027e: Expected O, but got I
		//IL_0298: Expected O, but got I4
		//IL_0d44: Expected O, but got I
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_035b: Expected O, but got I
		//IL_0375: Expected O, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0407: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0462: Expected I, but got O
		//IL_0472: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017a: Expected I, but got O
		//IL_018a: Expected O, but got I
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de4: Expected O, but got Unknown
		//IL_0e06: Expected O, but got I4
		//IL_0e0f: Expected O, but got I4
		//IL_04ad: Expected O, but got I
		//IL_0244: Expected O, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_059b: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_06c3: Expected O, but got I4
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_0655: Expected O, but got I4
		//IL_025b: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0994: Expected O, but got I
		//IL_05d6: Expected O, but got I
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_054a: Expected O, but got I4
		//IL_06d9: Expected I, but got O
		//IL_06e9: Expected O, but got I
		//IL_070b: Expected O, but got I4
		//IL_071b: Expected O, but got I
		//IL_0b60: Expected O, but got I
		//IL_0b90: Expected O, but got I4
		//IL_066c: Expected O, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected O, but got Unknown
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected O, but got Unknown
		//IL_0c75: Expected O, but got I4
		//IL_0c7a: Expected I, but got O
		//IL_09cf: Expected O, but got I
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected O, but got Unknown
		//IL_093a: Expected O, but got I4
		//IL_07b8: Expected O, but got I4
		//IL_07bd: Expected I, but got O
		//IL_0ba7: Expected O, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		//IL_0bee: Expected O, but got I
		//IL_0c1c: Expected O, but got I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_07ff: Expected O, but got I
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I4
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected O, but got Unknown
		//IL_0aca: Expected O, but got I
		//IL_083a: Expected O, but got I
		//IL_08d0: Expected O, but got I4
		//IL_0b05: Expected O, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected O, but got Unknown
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_0a70: Expected O, but got I4
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected O, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 656;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = 0;
		bool flag = response == null;
		PopupButton popupButton = (PopupButton)(object)response;
		if (flag)
		{
			goto IL_0c9c;
		}
		object obj4 = (nint)0 + (nint)1048;
		object obj5 = "Network Authentication Required" + 3128;
		popupButton = (PopupButton)obj4;
		object obj8;
		object obj13 = default(object);
		object obj6;
		nint num;
		if (response.Succeeded)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			if ((nint)0 != 0)
			{
				if (mostRecentlySentContactEmail != null)
				{
					object value = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1256;
					bool flag2 = mostRecentlySentContactEmail.EndsWith((string)value);
					PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(PopupWindow.MessageType.Info);
					PopupButton popupButton2 = PopupButton.Neutral((string)obj5, null, dismiss: true);
					if (flag2)
					{
						bool flag3 = popupWindowBuilder == null;
						obj6 = 0;
						num = 1;
						popupButton = popupButton2;
						if (!flag3)
						{
							IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(popupButton2);
							object obj7 = typeof(System.IOAsyncCallback) + 392;
							obj8 = "DNQUALIFIER" + 3784;
							nint num2 = (nint)popupWindowBuilder;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v65 (Il2CppClass<PopupWindowBuilder>)+12E]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v65 (Il2CppClass<PopupWindowBuilder>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0206;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v65 (Il2CppClass<PopupWindowBuilder>)+B0]");
							object obj10 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v37-8]");
								if (0 == (nint)obj7)
								{
									break;
								}
								obj10 += 16;
								obj9--;
								if ((nint)obj9 != 1)
								{
									continue;
								}
								goto IL_0206;
							}
							object obj11 = num2 + obj10;
							object obj12 = obj11 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v88+8]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v88] (should have been resolved before IL gen)");
							bool flag4 = obj13 == null;
							obj6 = 0;
							popupButton = (PopupButton)obj8;
							if (!flag4)
							{
								goto IL_0560;
							}
						}
					}
					else
					{
						bool flag5 = popupWindowBuilder == null;
						obj6 = 0;
						num = 1;
						popupButton = popupButton2;
						if (!flag5)
						{
							IPopupWindowBuilderAttributes popupWindowBuilderAttributes2 = popupWindowBuilder.AddButton(popupButton2);
							object obj14 = typeof(System.IOAsyncCallback) + 392;
							object obj15 = "DNQUALIFIER" + 3784;
							nint num3 = (nint)popupWindowBuilder;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v40 (Il2CppClass<PopupWindowBuilder>)+12E]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v40 (Il2CppClass<PopupWindowBuilder>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_04ee;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v40 (Il2CppClass<PopupWindowBuilder>)+B0]");
							object obj17 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X10_v21-8]");
								if (0 == (nint)obj14)
								{
									break;
								}
								obj17 += 16;
								obj16--;
								if ((nint)obj16 != 1)
								{
									continue;
								}
								goto IL_04ee;
							}
							object obj18 = num3 + obj17;
							object obj19 = obj18 + 312;
							goto IL_0db6;
						}
					}
				}
				goto IL_0c9c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [response @ X1 (KammelnaResponseModel`1<System.Boolean>)+30]");
			object obj20 = (nint)0 & (nint)1;
			bool flag6 = obj20 == null;
			object obj21 = !flag6;
			if (obj21 != null)
			{
				goto IL_0d38;
			}
		}
		_ = 1001;
		goto IL_0d38;
		IL_0c9c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0caa;
		IL_0bb5:
		object obj23;
		object obj22 = obj23 + 9;
		object obj25;
		object obj24 = obj25 + obj22;
		object obj26 = obj24 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v33+8]");
		popupButton = (PopupButton)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v278 @ X8_v33] (should have been resolved before IL gen)");
		DummyBaseDropMenu dummyBaseDropMenu = serviceType;
		bool flag7 = (object)serviceType == null;
		obj6 = 0;
		nint num4;
		num = num4;
		if (!flag7)
		{
			goto IL_0c32;
		}
		goto IL_0c9c;
		IL_0db6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v52+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X0_v52] (should have been resolved before IL gen)");
		object obj27 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag8 = array == null;
		obj6 = 0;
		popupButton = (PopupButton)1;
		LocalizableText localizableText;
		object obj37 = default(object);
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		if (!flag8)
		{
			bool flag9 = mostRecentlySentContactEmail == null;
			PopupButton popupButton3 = (PopupButton)1;
			if (!flag9)
			{
				nint num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
				popupButton3 = (PopupButton)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag10 = ex2 == null;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v59 (Il2CppClass<System.Object[]>)+40]");
				popupButton = (PopupButton)0;
				if (flag10)
				{
					goto IL_0cb8;
				}
			}
			bool flag11 = array.Length == 0;
			obj6 = 0;
			popupButton = popupButton3;
			if (flag11)
			{
				goto IL_0caa;
			}
			object obj28 = array + 32;
			obj28 = mostRecentlySentContactEmail;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text = "Read object reference Id '{0}' for {1}." + 2328;
			localizableText = TextMeshProExtensions.LocalizeWith((string)text, array);
			object obj29 = default(object);
			bool flag12 = obj29 == null;
			obj6 = 0;
			num = unchecked((nint)null);
			popupButton = (PopupButton)(object)array;
			if (!flag12)
			{
				object obj30 = typeof(System.IOAsyncCallback) + 384;
				object obj31 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v51+12E]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v51+12E]");
				if ((nint)0 == 0)
				{
					goto IL_087b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ X8_v51+B0]");
				object obj33 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X10_v16-8]");
					if (0 == (nint)obj30)
					{
						break;
					}
					obj33 += 16;
					obj32--;
					if ((nint)obj32 != 1)
					{
						continue;
					}
					goto IL_087b;
				}
				object obj34 = obj33 + 1;
				object obj35 = obj31 + obj34;
				object obj36 = obj35 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v68+8]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v862 @ X0_v68] (should have been resolved before IL gen)");
				bool flag13 = obj37 == null;
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X0_v68+8]");
				num = 0;
				popupButton = (PopupButton)(object)localizableText;
				if (!flag13)
				{
					goto IL_0a96;
				}
			}
		}
		goto IL_0c9c;
		IL_04ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0db6;
		IL_0d38:
		object obj38 = (nint)0 + (nint)1024;
		object obj39 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		string errorMessage = response.ErrorMessage;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A45]");
			object obj41 = (nint)0 & (nint)1;
			if (obj41 != null)
			{
				goto IL_02e4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A45]");
			object obj42 = (nint)0 & (nint)1;
			bool flag14 = obj42 == null;
			object obj43 = !flag14;
			if (obj43 != null)
			{
				goto IL_02e4;
			}
		}
		_ = 1;
		object obj44 = "Drop Menu Toggle" + 3600;
		object obj45 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj46 = !flag15;
		object obj47 = obj44;
		if (obj46 != null)
		{
			goto IL_0328;
		}
		goto IL_03d8;
		IL_087b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v65+8]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v845 @ X0_v65] (should have been resolved before IL gen)");
		bool flag16 = obj37 == null;
		object obj48 = !flag16;
		if (obj48 != null)
		{
			goto IL_0a96;
		}
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v65+8]");
		num = 0;
		popupButton = (PopupButton)(object)localizableText;
		goto IL_0c9c;
		IL_0c32:
		string text2 = dummyBaseDropMenu.ToString();
		object action = "SubscribeGroup request Error" + 248;
		FirebaseTrack.Event((string)action, text2);
		bool flag17 = (object)Reports == null;
		obj6 = 0;
		num = unchecked((nint)null);
		popupButton = (PopupButton)(object)text2;
		if (!flag17)
		{
			Reports.CloseAll();
			return;
		}
		goto IL_0c9c;
		IL_0b46:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X0_v46+8]");
		popupButton = (PopupButton)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v761 @ X0_v46] (should have been resolved before IL gen)");
		dummyBaseDropMenu = serviceType;
		bool flag18 = (object)serviceType == null;
		object obj49 = !flag18;
		if (obj49 != null)
		{
			goto IL_0c32;
		}
		obj6 = 0;
		num = 9;
		goto IL_0c9c;
		IL_02e4:
		obj44 = "Drop Menu Toggle" + 3600;
		obj45 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v14+E4]");
		bool flag19 = (nint)0 == 0;
		obj47 = obj44;
		if (!flag19)
		{
			goto IL_0328;
		}
		goto IL_03d8;
		IL_03d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj44 = obj47;
		goto IL_0328;
		IL_0328:
		PopupWindow.ShowError((string)obj44, errorMessage, (string)obj5);
		return;
		IL_0560:
		object obj50 = typeof(System.IOAsyncCallback) + 384;
		object obj51 = "utf-32" + 2752;
		object obj52 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v71+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v71+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0617;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v71+B0]");
		object obj54 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X10_v32-8]");
			if (0 == (nint)obj50)
			{
				break;
			}
			obj54 += 16;
			obj53--;
			if ((nint)obj53 != 1)
			{
				continue;
			}
			goto IL_0617;
		}
		object obj55 = obj52 + obj54;
		object obj56 = obj55 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v78+8]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X8_v78] (should have been resolved before IL gen)");
		bool flag20 = obj37 == null;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v78+8]");
		num = 0;
		popupButton = (PopupButton)obj51;
		if (!flag20)
		{
			goto IL_0960;
		}
		goto IL_0c9c;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X0_v85+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v537 @ X0_v85] (should have been resolved before IL gen)");
		bool flag21 = obj13 == null;
		object obj57 = !flag21;
		if (obj57 != null)
		{
			goto IL_0560;
		}
		obj6 = 0;
		popupButton = (PopupButton)obj8;
		goto IL_0c9c;
		IL_0960:
		object obj58 = typeof(System.IOAsyncCallback) + 368;
		object obj59 = obj58;
		obj25 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+12E]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b46;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v5-8]");
			if (0 == (nint)obj59)
			{
				break;
			}
			obj23 += 16;
			obj60--;
			if ((nint)obj60 != 1)
			{
				continue;
			}
			goto IL_0b46;
		}
		goto IL_0bb5;
		IL_0a96:
		object obj61 = typeof(System.IOAsyncCallback) + 368;
		obj59 = obj61;
		obj25 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+12E]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b46;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v31+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v5-8]");
			if (0 == (nint)obj59)
			{
				break;
			}
			obj23 += 16;
			obj62--;
			if ((nint)obj62 != 1)
			{
				continue;
			}
			goto IL_0b46;
		}
		goto IL_0bb5;
		IL_0cb8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0617:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v80+8]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X0_v80] (should have been resolved before IL gen)");
		bool flag22 = obj37 == null;
		object obj63 = !flag22;
		if (obj63 != null)
		{
			goto IL_0960;
		}
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v80+8]");
		num = 0;
		popupButton = (PopupButton)obj51;
		goto IL_0c9c;
		IL_0caa:
		ex2 = new IndexOutOfRangeException();
		goto IL_0cb8;
	}

	private void HighlightRequired()
	{
		//IL_0016: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_01e3: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_017d: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_0245: Expected O, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02db: Expected O, but got I
		//IL_02ec: Expected I, but got O
		//IL_030a: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_0275: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A52]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A4F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A4F]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		GameObject reportElementGroupsParent = ReportElementGroupsParent;
		goto IL_00f8;
		IL_02aa:
		throw new NullReferenceException();
		IL_01b2:
		List<object> list;
		Action<object> action;
		list.ForEach(action);
		return;
		IL_00f8:
		object obj5 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 848;
		object obj6 = (nint)0 + (nint)1704;
		object obj7 = (nint)0 + (nint)2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E33C3C");
		IEnumerable<object> source = default(IEnumerable<object>);
		list = Enumerable.ToList(source);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+8]");
			if ((nint)0 != 0)
			{
				goto IL_01b2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 != null)
			{
				goto IL_01b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v14+B8]");
			obj9 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3952;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj9, (IntPtr)obj14);
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v13+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = list == null;
		object obj17 = !flag4;
		action = action2;
		if (obj17 != null)
		{
			goto IL_01b2;
		}
		goto IL_02aa;
		IL_0066:
		reportElementGroupsParent = ReportElementGroupsParent;
		bool flag5 = (object)ReportElementGroupsParent == null;
		object obj18 = !flag5;
		if (obj18 != null)
		{
			goto IL_00f8;
		}
		goto IL_02aa;
	}
}
