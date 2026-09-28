using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class ChallengeHistoryListView : UiListView<IListViewItemData<int>, ListViewItem<IListViewItemData<int>, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ChallengeEntry, DateTime> <>9__0_0;

		public static Func<ChallengeEntry, DateTime> <>9__0_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <SetData>b__0_0(ChallengeEntry e)
		{
			return (DateTime)(((object?)e?.<Date>k__BackingField) ?? ((object)new NullReferenceException()));
		}

		internal DateTime <SetData>b__0_1(ChallengeEntry e)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0044: Expected O, but got I4
			if ((object)e != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime = default(DateTime);
				return dateTime.Date;
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public unsafe void SetData(ChallengeStateData challengeData)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_05ad: Expected O, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05d3: Expected O, but got I
		//IL_05f4: Expected O, but got Ref
		//IL_05fd: Expected O, but got I4
		//IL_0606: Expected O, but got I4
		//IL_0616: Expected O, but got Ref
		//IL_061f: Expected O, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0167: Expected O, but got I
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		//IL_067a: Expected O, but got I
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06ab: Expected O, but got I4
		//IL_06b4: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_1bd2: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_0474: Expected O, but got I
		//IL_0496: Expected O, but got I4
		//IL_04be: Expected O, but got I
		//IL_0197: Expected O, but got I4
		//IL_0747: Expected I, but got O
		//IL_026a: Expected I, but got O
		//IL_0293: Expected I, but got O
		//IL_01ed: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_170f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1714: Expected O, but got Unknown
		//IL_172a: Expected O, but got I
		//IL_173b: Expected I, but got O
		//IL_1759: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_188d: Expected O, but got I
		//IL_18a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a5: Expected O, but got Unknown
		//IL_04f6: Expected O, but got I4
		//IL_01c7: Expected O, but got I
		//IL_12b8: Expected O, but got Ref
		//IL_12e0: Expected O, but got I4
		//IL_1351: Expected O, but got I4
		//IL_1859: Expected O, but got I
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02cd: Expected I, but got O
		//IL_02dd: Expected O, but got I
		//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ed: Expected O, but got Unknown
		//IL_1803: Expected O, but got I
		//IL_1814: Expected I, but got O
		//IL_1814: Expected O, but got I
		//IL_181c: Expected I, but got O
		//IL_1832: Expected O, but got I
		//IL_1c2e: Expected O, but got I4
		//IL_0759: Expected O, but got I4
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected O, but got Unknown
		//IL_0393: Expected O, but got I
		//IL_03b7: Expected O, but got I4
		//IL_03bf: Expected O, but got Ref
		//IL_03c8: Expected O, but got I4
		//IL_03da: Expected I, but got O
		//IL_0533: Expected I, but got O
		//IL_0557: Expected O, but got I4
		//IL_0577: Expected I, but got O
		//IL_136e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1373: Expected O, but got Unknown
		//IL_138b: Expected O, but got I
		//IL_0708: Expected O, but got I
		//IL_1426: Expected I, but got O
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07d7: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		//IL_0409: Expected O, but got Ref
		//IL_0412: Expected O, but got I4
		//IL_0424: Expected I, but got O
		//IL_1780: Expected O, but got I
		//IL_1ca8: Expected O, but got I
		//IL_0882: Expected I, but got O
		//IL_1c74: Expected O, but got I
		//IL_1906: Expected O, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_1438: Expected O, but got I4
		//IL_1445: Unknown result type (might be due to invalid IL or missing references)
		//IL_144a: Expected O, but got Unknown
		//IL_1453: Unknown result type (might be due to invalid IL or missing references)
		//IL_1458: Expected O, but got Unknown
		//IL_18d2: Expected O, but got I
		//IL_15f1: Expected O, but got I4
		//IL_13ef: Expected O, but got I
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08f5: Expected O, but got I
		//IL_0894: Expected O, but got I4
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Expected O, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_09a0: Expected I, but got O
		//IL_0843: Expected O, but got I
		//IL_197a: Unknown result type (might be due to invalid IL or missing references)
		//IL_197f: Expected O, but got Unknown
		//IL_193d: Expected O, but got I
		//IL_09ef: Expected I, but got O
		//IL_09b2: Expected O, but got I4
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Expected O, but got Unknown
		//IL_0961: Expected O, but got I
		//IL_0a55: Expected O, but got I4
		//IL_0a75: Expected O, but got I4
		//IL_0aef: Expected O, but got I
		//IL_0aff: Expected O, but got I
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b4d: Expected O, but got I
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected O, but got Unknown
		//IL_0bf8: Expected I, but got O
		//IL_19fd: Expected O, but got I
		//IL_1a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a15: Expected O, but got Unknown
		//IL_1a2f: Expected O, but got I4
		//IL_0d32: Expected O, but got I
		//IL_19c9: Expected O, but got I
		//IL_0ddd: Expected I, but got O
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0f: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0c3a: Expected O, but got I4
		//IL_1aa9: Expected O, but got I
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac1: Expected O, but got Unknown
		//IL_0bb9: Expected O, but got I
		//IL_1a75: Expected O, but got I
		//IL_0def: Expected O, but got I4
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0f: Expected O, but got Unknown
		//IL_1564: Expected O, but got Ref
		//IL_156d: Expected O, but got I4
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Expected O, but got Unknown
		//IL_1087: Expected O, but got I
		//IL_0d9e: Expected O, but got I
		//IL_1132: Expected I, but got O
		//IL_0e59: Expected O, but got I
		//IL_1bab: Expected O, but got I
		//IL_0efc: Expected I, but got O
		//IL_1b77: Expected O, but got I
		//IL_1b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2a: Expected O, but got Unknown
		//IL_1b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4b: Expected O, but got Unknown
		//IL_1144: Expected O, but got I4
		//IL_1151: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Expected O, but got Unknown
		//IL_115f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1164: Expected O, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected O, but got Unknown
		//IL_0f63: Expected I, but got O
		//IL_1aee: Expected O, but got I
		//IL_10f3: Expected O, but got I
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Expected O, but got Unknown
		//IL_0f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f21: Expected O, but got Unknown
		//IL_0fc9: Expected O, but got I4
		//IL_0fe9: Expected O, but got I4
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Expected O, but got Unknown
		//IL_0c8b: Expected O, but got I
		//IL_0c9b: Expected O, but got I
		//IL_1029: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Expected O, but got Unknown
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_103c: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A0F]");
		nint num = 0;
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3616;
		object obj2 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (challengeData == null)
		{
			goto IL_058d;
		}
		object obj3 = typeof(CardUtils.<>c) + 96;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v133+E4]");
		IOrderedEnumerable<object> orderedEnumerable;
		object obj5;
		Func<object, DateTime> keySelector;
		IOrderedEnumerable<object> orderedEnumerable2;
		if ((nint)0 != 0)
		{
			orderedEnumerable = (IOrderedEnumerable<object>)((nint)0 + (nint)2368);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v133+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				orderedEnumerable2 = orderedEnumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
				Func<object, DateTime> func = (Func<object, DateTime>)0;
				goto IL_0175;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			orderedEnumerable2 = (IOrderedEnumerable<object>)((nint)0 + (nint)2368);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v133+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
			Func<object, DateTime> func = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			orderedEnumerable = orderedEnumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v99+8]");
			keySelector = (Func<object, DateTime>)0;
			if (obj7 == null)
			{
				goto IL_0175;
			}
		}
		goto IL_16bd;
		IL_065a:
		ChallengeHistoryListView challengeHistoryListView = (ChallengeHistoryListView)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
		IOrderedEnumerable<object> orderedEnumerable3 = (IOrderedEnumerable<object>)((nint)0 + (nint)2512);
		object obj8 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 376;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 528;
		object obj10 = 0;
		object obj11 = 0;
		object obj13 = default(object);
		object obj12 = obj13;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v18+12E]");
		object[] array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0738;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v18+B0]");
		int num2 = (int)((nint)0 + (nint)8);
		bool flag4 = default(bool);
		bool flag3 = flag4;
		object obj15 = default(object);
		int num3 = default(int);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v59 (System.Int32)-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v59 (System.Int32)-8]");
			if (0 == (nint)challengeHistoryListView)
			{
				break;
			}
			num3 = num2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v18+12E]");
			array = (object[])(-1);
			flag4 = (nint)array != 1;
			flag3 = flag4;
			num2 = num3;
			if (flag4)
			{
				continue;
			}
			goto IL_0738;
		}
		array = (object[])((int*)num2)->m_value;
		object obj16 = obj14 + ((int*)num2)->m_value;
		object obj17 = obj16 + 312;
		flag4 = flag3;
		num3 = num2;
		goto IL_187d;
		IL_1c14:
		object obj18;
		object obj21;
		object obj22;
		object obj23;
		IOrderedEnumerable<object> orderedEnumerable4;
		ChallengeHistoryListView challengeHistoryListView2;
		ChallengeHistoryListView challengeHistoryListView3;
		object obj24;
		object obj25 = default(object);
		object obj26;
		object obj30;
		ChallengeHistoryListView challengeHistoryListView4 = default(ChallengeHistoryListView);
		IOrderedEnumerable<object> orderedEnumerable5 = default(IOrderedEnumerable<object>);
		object obj32 = default(object);
		ChallengeHistoryListView challengeHistoryListView6;
		object obj20 = default(object);
		nint num5 = default(nint);
		IOrderedEnumerable<object> orderedEnumerable6;
		object obj33;
		ChallengeStateData challengeStateData;
		object obj29;
		object obj27;
		object obj31;
		int num4;
		ChallengeHistoryListView challengeHistoryListView5;
		nint num6;
		while (true)
		{
			bool flag5 = obj18 == null;
			object obj19 = !flag5;
			obj20 = obj21;
			obj9 = obj22;
			obj8 = obj23;
			orderedEnumerable3 = orderedEnumerable4;
			challengeHistoryListView = challengeHistoryListView2;
			if (obj19 == null)
			{
				challengeHistoryListView3.data = (List<IListViewItemData<int>>)(object)list;
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			if ((nint)challengeStateData == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj24 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj26 = obj27;
				bool flag6 = obj27 == null;
				object obj28 = !flag6;
				obj15 = obj29;
				obj30 = obj27;
				obj31 = obj25;
				num3 = num4;
				challengeHistoryListView4 = challengeHistoryListView5;
				orderedEnumerable5 = orderedEnumerable6;
				num5 = num6;
				obj32 = obj33;
				challengeHistoryListView6 = challengeHistoryListView5;
				if (obj28 != null)
				{
					break;
				}
				obj21 = obj20;
				obj22 = obj9;
				obj23 = obj8;
				obj31 = obj25;
				orderedEnumerable4 = orderedEnumerable3;
				challengeHistoryListView3 = challengeHistoryListView5;
				challengeHistoryListView2 = challengeHistoryListView;
				obj18 = obj25;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_135f;
		IL_1c98:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X0_v24+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1053 @ X0_v24] (should have been resolved before IL gen)");
		obj21 = obj20;
		obj29 = obj15;
		obj22 = obj9;
		obj23 = obj8;
		obj27 = obj30;
		num4 = num3;
		challengeHistoryListView5 = challengeHistoryListView4;
		orderedEnumerable6 = orderedEnumerable5;
		obj33 = obj32;
		orderedEnumerable4 = orderedEnumerable3;
		challengeHistoryListView3 = challengeHistoryListView6;
		challengeHistoryListView2 = challengeHistoryListView;
		obj18 = obj24;
		goto IL_1c14;
		IL_1417:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num6 = unchecked((nint)null);
		goto IL_1c98;
		IL_0175:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v133+E4]");
		bool flag7 = (nint)0 == 0;
		object obj34 = !flag7;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v105+B8]");
			obj5 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)2824;
		Func<object, DateTime> func2 = default(Func<object, DateTime>);
		func2..ctor(obj5, (IntPtr)obj37);
		object obj38 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v104+B8]");
		object obj39 = (nint)0 + (nint)8;
		obj39 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		orderedEnumerable = orderedEnumerable2;
		keySelector = func2;
		goto IL_16bd;
		IL_0738:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_187d;
		IL_1961:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1128 @ X0_v40] (should have been resolved before IL gen)");
		object obj40 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = default(object);
		obj41..ctor();
		object obj49 = default(object);
		if (list != null)
		{
			nint num7 = (nint)orderedEnumerable3;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				num4 = list._size;
				obj29 = items.Length;
				bool flag8 = list._size < items.Length;
				object obj42 = !flag8;
				if (obj42 == null)
				{
					int num8 = list._size + 1;
					list._size = num8;
					object obj43 = list._items + list._size;
					object obj44 = obj43 + 32;
					obj44 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X8_v35 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+20]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v66+C0]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ X8_v67+70]");
					num5 = 0;
					list.AddWithResize(obj41);
				}
				object obj47 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3008;
				object obj48 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v39+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v39+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0be9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v39+B0]");
				int num9 = (int)((nint)0 + (nint)8);
				bool flag9 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X10_v44 (System.Int32)-8]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ X10_v44 (System.Int32)-8]");
					if (0 == (nint)obj47)
					{
						break;
					}
					num4 = num9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v39+12E]");
					array = (object[])(-1);
					flag4 = (nint)array != 1;
					flag9 = flag4;
					num9 = num4;
					if (flag4)
					{
						continue;
					}
					goto IL_0be9;
				}
				object obj50 = obj48 + ((int*)num9)->m_value;
				object obj51 = obj50 + 312;
				flag4 = flag9;
				num4 = num9;
				array = (object[])((int*)num9)->m_value;
				goto IL_19ed;
			}
		}
		throw new NullReferenceException();
		IL_16bd:
		IOrderedEnumerable<object> orderedEnumerable7 = Enumerable.OrderByDescending(challengeData.History, keySelector);
		object obj52 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v114+E4]");
		nint num10;
		if ((nint)0 != 0)
		{
			obj33 = (nint)0 + (nint)2952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v114+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			bool flag10 = (nint)0 == 0;
			orderedEnumerable6 = orderedEnumerable7;
			orderedEnumerable5 = orderedEnumerable7;
			obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			object obj54 = 0;
			num10 = num;
			if (!flag10)
			{
				goto IL_0262;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj52 = obj3;
			obj33 = (nint)0 + (nint)2952;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v114+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			bool flag11 = (nint)0 == 0;
			object obj55 = !flag11;
			orderedEnumerable6 = orderedEnumerable7;
			orderedEnumerable5 = orderedEnumerable7;
			obj32 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+10]");
			object obj54 = 0;
			num10 = num;
			if (obj55 != null)
			{
				goto IL_0262;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v114+E4]");
		bool flag12 = (nint)0 == 0;
		object obj56 = !flag12;
		if (obj56 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj57 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X8_v87+B8]");
			num10 = 0;
		}
		object obj58 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj59 = (nint)0 + (nint)2832;
		Func<object, DateTime> func3 = default(Func<object, DateTime>);
		func3..ctor((object)num10, (IntPtr)obj59);
		num = (nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+B8]");
		object obj60 = (nint)0 + (nint)16;
		obj60 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num11 = (nint)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE9F3C");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag13 = ex2 == null;
		object obj61 = !flag13;
		orderedEnumerable6 = orderedEnumerable5;
		obj33 = obj32;
		orderedEnumerable = orderedEnumerable5;
		num5 = (nint)obj32;
		orderedEnumerable3 = orderedEnumerable5;
		if (obj61 != null)
		{
			goto IL_02b1;
		}
		goto IL_058d;
		IL_135f:
		object obj62 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj63 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v12+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1417;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v12+B0]");
		int num12 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X10_v10 (System.Int32)-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X10_v10 (System.Int32)-8]");
			if (0 == (nint)obj62)
			{
				break;
			}
			num3 = num12 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X8_v12+12E]");
			array = (object[])(-1);
			bool flag14 = (nint)array != 1;
			num12 = num3;
			if (flag14)
			{
				continue;
			}
			goto IL_1417;
		}
		array = (object[])((int*)num12)->m_value;
		object obj64 = obj63 + ((int*)num12)->m_value;
		object obj65 = obj64 + 312;
		num3 = num12;
		num6 = num5;
		goto IL_1c98;
		IL_18f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1045 @ X0_v36+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1045 @ X0_v36] (should have been resolved before IL gen)");
		if (obj49 != null)
		{
			object obj66 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1512;
			object obj67 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v29+12E]");
			object[] items = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v29+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0991;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v29+B0]");
			int num13 = (int)((nint)0 + (nint)8);
			bool flag15 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X10_v49 (System.Int32)-8]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X10_v49 (System.Int32)-8]");
				if (0 == (nint)obj66)
				{
					break;
				}
				num3 = num13 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v29+12E]");
				items = (object[])(-1);
				flag4 = (nint)items != 1;
				flag15 = flag4;
				num13 = num3;
				if (flag4)
				{
					continue;
				}
				goto IL_0991;
			}
			items = (object[])((int*)num13)->m_value;
			object obj68 = obj67 + ((int*)num13)->m_value;
			object obj69 = obj68 + 312;
			flag4 = flag15;
			num3 = num13;
			goto IL_1961;
		}
		throw new NullReferenceException();
		IL_187d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v32+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v721 @ X0_v32] (should have been resolved before IL gen)");
		object obj71 = default(object);
		object obj70 = obj71 & 1;
		object obj72 = default(object);
		if (obj70 != null)
		{
			if (obj72 != null)
			{
				object obj73 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4040;
				object obj74 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0873;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+B0]");
				int num14 = (int)((nint)0 + (nint)8);
				bool flag16 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v54 (System.Int32)-8]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ X10_v54 (System.Int32)-8]");
					if (0 == (nint)obj73)
					{
						break;
					}
					num3 = num14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X8_v24+12E]");
					array = (object[])(-1);
					flag4 = (nint)array != 1;
					flag16 = flag4;
					num14 = num3;
					if (flag4)
					{
						continue;
					}
					goto IL_0873;
				}
				array = (object[])((int*)num14)->m_value;
				object obj75 = obj74 + ((int*)num14)->m_value;
				object obj76 = obj75 + 312;
				flag4 = flag16;
				num3 = num14;
				goto IL_18f6;
			}
			throw new NullReferenceException();
		}
		object obj77 = (object)(&obj72);
		obj26 = obj77;
		bool flag17 = obj77 == null;
		challengeHistoryListView6 = challengeHistoryListView4;
		obj24 = 0;
		obj21 = obj20;
		obj29 = obj15;
		obj22 = obj9;
		obj23 = obj8;
		obj27 = obj30;
		num4 = num3;
		challengeHistoryListView5 = challengeHistoryListView4;
		orderedEnumerable6 = orderedEnumerable5;
		num6 = num5;
		obj33 = obj32;
		orderedEnumerable4 = orderedEnumerable3;
		challengeHistoryListView3 = challengeHistoryListView4;
		challengeHistoryListView2 = challengeHistoryListView;
		obj18 = 0;
		if (!flag17)
		{
			goto IL_135f;
		}
		goto IL_1c14;
		IL_0873:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_18f6;
		IL_19ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ X0_v47+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1242 @ X0_v47] (should have been resolved before IL gen)");
		obj11++;
		object obj78 = default(object);
		bool flag18 = obj78 == null;
		object obj79 = !flag18;
		object obj80 = default(object);
		obj33 = obj80;
		obj15 = obj29;
		num3 = num4;
		num6 = num5;
		object obj81 = obj78;
		if (obj79 != null)
		{
			object obj87 = default(object);
			object obj89 = default(object);
			bool flag21;
			object obj98 = default(object);
			do
			{
				object obj82 = obj81;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v44+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v44+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0dce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v44+B0]");
				int num15 = (int)((nint)0 + (nint)8);
				bool flag19 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ X10_v38 (System.Int32)-8]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ X10_v38 (System.Int32)-8]");
					if (0 == (nint)challengeHistoryListView)
					{
						break;
					}
					num3 = num15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X8_v44+12E]");
					array = (object[])(-1);
					flag4 = (nint)array != 1;
					flag19 = flag4;
					num15 = num3;
					if (flag4)
					{
						continue;
					}
					goto IL_0dce;
				}
				array = (object[])((int*)num15)->m_value;
				object obj83 = obj82 + ((int*)num15)->m_value;
				object obj84 = obj83 + 312;
				flag4 = flag19;
				num3 = num15;
				goto IL_1a99;
				IL_1b9b:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1503 @ X0_v57+8]");
				challengeStateData = (ChallengeStateData)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1503 @ X0_v57] (should have been resolved before IL gen)");
				goto IL_155c;
				IL_155c:
				obj20 = (object)(&obj10);
				object obj85 = 0;
				obj29 = obj15;
				obj27 = obj30;
				num4 = num3;
				challengeHistoryListView5 = challengeHistoryListView4;
				orderedEnumerable6 = orderedEnumerable5;
				obj33 = obj11;
				throw new OutOfMemoryException();
				IL_1b12:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1469 @ X0_v64] (should have been resolved before IL gen)");
				object obj86 = obj11 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj87..ctor();
				object obj88 = obj87 + 16;
				obj88 = obj89;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj90 = obj87 + 24;
				obj90 = challengeData;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num16 = (nint)orderedEnumerable3;
				int version2 = list._version + 1;
				list._version = version2;
				array = list._items;
				if (list._items != null)
				{
					num4 = list._size;
					obj29 = array.Length;
					bool flag20 = list._size < array.Length;
					object obj91 = !flag20;
					object obj94;
					if (obj91 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v57 (Il2CppClass<System.Linq.IOrderedEnumerable`1<System.Object>>)+20]");
						object obj92 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1521 @ X8_v60+C0]");
						object obj93 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1522 @ X8_v61+70]");
						num6 = 0;
						list.AddWithResize(obj87);
						obj94 = obj87;
					}
					else
					{
						int num17 = list._size + 1;
						list._size = num17;
						object obj95 = list._items + list._size;
						object obj96 = obj95 + 32;
						obj96 = obj87;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj94 = obj87;
					}
					flag21 = obj10 == null;
					num5 = num6;
					obj33 = obj11;
					challengeStateData = (ChallengeStateData)obj94;
					obj15 = obj29;
					num3 = num4;
					obj11 = obj86;
					obj81 = obj10;
					continue;
				}
				throw new NullReferenceException();
				IL_0dce:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num6 = unchecked((nint)null);
				goto IL_1a99;
				IL_1a99:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X0_v51+8]");
				challengeStateData = (ChallengeStateData)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1348 @ X0_v51] (should have been resolved before IL gen)");
				object obj97 = obj98 & 1;
				if (obj97 != null)
				{
					if (obj10 != null)
					{
						object obj99 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X8_v54+12E]");
						object obj100 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X8_v54+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0eed;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X8_v54+B0]");
						int num18 = (int)((nint)0 + (nint)8);
						bool flag22 = flag4;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ X10_v33 (System.Int32)-8]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ X10_v33 (System.Int32)-8]");
							if (0 == (nint)obj8)
							{
								break;
							}
							num3 = num18 + 16;
							obj100--;
							flag4 = (nint)obj100 != 1;
							flag22 = flag4;
							num18 = num3;
							if (flag4)
							{
								continue;
							}
							goto IL_0eed;
						}
						object obj101 = obj99 + ((int*)num18)->m_value;
						object obj102 = obj101 + 312;
						flag4 = flag22;
						num3 = num18;
						goto IL_1b12;
					}
					throw new NullReferenceException();
				}
				if (obj10 != null)
				{
					object obj103 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					object obj104 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v50+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v50+12E]");
					if ((nint)0 == 0)
					{
						goto IL_1123;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v50+B0]");
					int num19 = (int)((nint)0 + (nint)8);
					bool flag23 = flag4;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X10_v26 (System.Int32)-8]");
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1487 @ X10_v26 (System.Int32)-8]");
						if (0 == (nint)obj103)
						{
							break;
						}
						num3 = num19 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v50+12E]");
						array = (object[])(-1);
						flag4 = (nint)array != 1;
						flag23 = flag4;
						num19 = num3;
						if (flag4)
						{
							continue;
						}
						goto IL_1123;
					}
					array = (object[])((int*)num19)->m_value;
					object obj105 = obj104 + ((int*)num19)->m_value;
					object obj106 = obj105 + 312;
					flag4 = flag23;
					num3 = num19;
					goto IL_1b9b;
				}
				goto IL_155c;
				IL_0eed:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num6 = unchecked((nint)null);
				goto IL_1b12;
				IL_1123:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num6 = unchecked((nint)null);
				goto IL_1b9b;
			}
			while (!flag21);
		}
		throw new NullReferenceException();
		IL_0262:
		num11 = (nint)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE9F3C");
		bool flag24 = ex2 == null;
		orderedEnumerable5 = orderedEnumerable6;
		num5 = (nint)obj33;
		obj32 = obj33;
		orderedEnumerable3 = orderedEnumerable;
		if (!flag24)
		{
			goto IL_02b1;
		}
		goto IL_058d;
		IL_058d:
		ex2 = new NullReferenceException();
		goto IL_059b;
		IL_02b1:
		object obj107 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2672;
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj108 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0371;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v72 (Il2CppClass<System.NullReferenceException>)+B0]");
		int num20 = (int)((nint)0 + (nint)8);
		bool flag25 = flag4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v65 (System.Int32)-8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v65 (System.Int32)-8]");
			bool flag26 = 0 == (nint)obj107;
			flag4 = flag25;
			num3 = num20;
			challengeHistoryListView4 = this;
			orderedEnumerable5 = orderedEnumerable6;
			num5 = num11;
			obj32 = obj33;
			orderedEnumerable3 = orderedEnumerable;
			if (flag26)
			{
				break;
			}
			num3 = num20 + 16;
			obj108--;
			flag4 = (nint)obj108 != 1;
			flag25 = flag4;
			num20 = num3;
			if (flag4)
			{
				continue;
			}
			goto IL_0371;
		}
		goto IL_059b;
		IL_0991:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_1961;
		IL_14cb:
		throw new NullReferenceException();
		IL_059b:
		object obj109 = num + ((int*)num3)->m_value;
		object obj110 = obj109 + 312;
		array = (object[])obj110;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v74+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v189 @ X8_v74] (should have been resolved before IL gen)");
		bool flag27 = obj13 == null;
		obj30 = (object)(&obj72);
		obj31 = 0;
		obj10 = 0;
		obj29 = obj15;
		obj27 = (object)(&obj72);
		obj31 = 0;
		num4 = num3;
		challengeHistoryListView5 = challengeHistoryListView4;
		orderedEnumerable6 = orderedEnumerable5;
		num6 = num5;
		obj33 = obj32;
		challengeHistoryListView = this;
		if (!flag27)
		{
			goto IL_065a;
		}
		goto IL_14cb;
		IL_0be9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_19ed;
		IL_0371:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj111 = default(object);
		array = (object[])obj111;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v127+8]");
		challengeStateData = (ChallengeStateData)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v769 @ X0_v127] (should have been resolved before IL gen)");
		bool flag28 = obj13 == null;
		object obj112 = !flag28;
		obj30 = (object)(&obj72);
		obj31 = 0;
		challengeHistoryListView4 = this;
		orderedEnumerable5 = orderedEnumerable6;
		num5 = unchecked((nint)null);
		obj32 = obj33;
		if (obj112 != null)
		{
			goto IL_065a;
		}
		obj10 = 0;
		obj29 = obj15;
		obj27 = (object)(&obj72);
		obj31 = 0;
		num4 = num3;
		challengeHistoryListView5 = this;
		num6 = unchecked((nint)null);
		orderedEnumerable3 = orderedEnumerable;
		challengeHistoryListView = this;
		goto IL_14cb;
	}

	public ChallengeHistoryListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
