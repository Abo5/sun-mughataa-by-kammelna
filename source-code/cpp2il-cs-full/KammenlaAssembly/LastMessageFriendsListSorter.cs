using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class LastMessageFriendsListSorter : FriendsListSorter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PrivateMessageModel, long> <>9__0_1;

		public static Func<FriendProfile, long> <>9__0_0;

		public static Func<FriendProfile, bool> <>9__1_0;

		public static Func<FriendProfile, long> <>9__1_1;

		public static Func<FriendProfile, bool> <>9__1_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal long <GetSortedList>b__0_0(FriendProfile f)
		{
			//IL_01be: Expected I8, but got O
			//IL_0011: Expected O, but got I
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_00fe: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0130: Expected O, but got I4
			//IL_0046: Expected I8, but got I4
			//IL_01a1: Expected O, but got I
			//IL_0097: Expected O, but got I
			//IL_00a7: Expected O, but got I
			//IL_00c9: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_0205: Expected O, but got I
			//IL_0216: Expected I, but got O
			//IL_0234: Expected O, but got I
			//IL_0190: Expected O, but got I
			object obj2;
			object obj4;
			Func<object, long> func;
			if (f != null)
			{
				object obj = (nint)0 + (nint)2696;
				if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)f.Messages))
				{
					return 0L;
				}
				obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1568;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+8]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						goto IL_013e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+8]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+8]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						goto IL_013e;
					}
				}
				goto IL_0195;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
			IL_0195:
			object obj7 = (nint)0 + (nint)1880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAABC");
			long result = default(long);
			return result;
			IL_013e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v16+B8]");
				obj4 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3472;
			Func<object, long> func2 = default(Func<object, long>);
			func2..ctor(obj4, (IntPtr)obj11);
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v15+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
			goto IL_0195;
		}

		internal long <GetSortedList>b__0_1(PrivateMessageModel m)
		{
			//IL_0035: Expected I8, but got O
			if (m != null)
			{
				return m.timestamp;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal bool <GetSortedListWithHeaders>b__1_0(FriendProfile f)
		{
			//IL_0039: Expected I4, but got O
			if (f != null)
			{
				bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)f.Messages);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal long <GetSortedListWithHeaders>b__1_1(FriendProfile f)
		{
			//IL_0050: Expected I8, but got O
			//IL_0042: Expected I8, but got I
			if (f != null)
			{
				object obj = Enumerable.Last((IEnumerable<object>)f.Messages);
				if (obj != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v5 (System.Object)+20]");
					return 0L;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal bool <GetSortedListWithHeaders>b__1_2(FriendProfile f)
		{
			//IL_002b: Expected I4, but got O
			if (f != null)
			{
				return ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)f.Messages);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override IEnumerable<FriendProfile> GetSortedList(IEnumerable<FriendProfile> friendList)
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
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0241: Expected O, but got I
		//IL_0252: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6188]");
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
		object obj7 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+10]");
		Func<object, long> keySelector = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+10]");
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
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3464;
		Func<object, long> func = default(Func<object, long>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)16;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		keySelector = func;
		goto IL_0201;
		IL_0201:
		return (IEnumerable<FriendProfile>)Enumerable.OrderByDescending(friendList, keySelector);
		IL_0085:
		obj10 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+10]");
		keySelector = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4+10]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}

	public override IEnumerable<FriendListSection> GetSortedListWithHeaders(IEnumerable<FriendProfile> friendList)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		//IL_015c: Expected O, but got I4
		//IL_00a4: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_00c4: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_01a8: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01ea: Expected O, but got I4
		//IL_08aa: Expected O, but got I
		//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08be: Expected O, but got Unknown
		//IL_08ce: Expected O, but got I
		//IL_08de: Expected O, but got I
		//IL_0900: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_035e: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_0837: Expected O, but got I
		//IL_0848: Expected I, but got O
		//IL_0866: Expected O, but got I
		//IL_0881: Expected O, but got I4
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_0938: Expected O, but got I
		//IL_0949: Expected I, but got O
		//IL_0967: Expected O, but got I
		//IL_0982: Expected O, but got I4
		//IL_025a: Expected O, but got I
		//IL_0311: Expected O, but got I
		//IL_03b6: Expected O, but got I
		//IL_042d: Expected O, but got I4
		//IL_04ff: Expected O, but got I
		//IL_050f: Expected O, but got I
		//IL_051f: Expected O, but got I
		//IL_0556: Expected O, but got I4
		//IL_056e: Expected O, but got I
		//IL_099c: Expected O, but got I
		//IL_09ac: Expected O, but got I
		//IL_09bc: Expected O, but got I
		//IL_09de: Expected O, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I4
		//IL_0654: Expected O, but got I4
		//IL_05d5: Expected O, but got I4
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		//IL_0a16: Expected O, but got I
		//IL_0a27: Expected I, but got O
		//IL_0a45: Expected O, but got I
		//IL_0a60: Expected O, but got I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_0605: Expected O, but got I
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_073e: Expected O, but got I4
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1112;
		object obj2 = typeof(TypeConverter<ushort, char>) + 2488;
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object[] array = default(object[]);
		object[] array2;
		object[] array3;
		object obj5;
		if (array != null)
		{
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v70+E4]");
			bool flag = (nint)0 == 0;
			array2 = array;
			object obj6 = obj4;
			object obj7 = obj5;
			array3 = array;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			object obj8 = (nint)0 + (nint)1272;
			obj4 = obj8;
			object[] array4 = Enumerable.ToArray((IEnumerable<object>)friendList);
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v70+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			array2 = array4;
			object obj6 = obj8;
			object obj7 = obj5;
			array3 = array4;
			if (obj9 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj5 = obj3;
		object obj10 = (nint)0 + (nint)3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v70+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v43+18]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v43+18]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		object obj13 = obj10;
		array2 = array3;
		if (obj12 == null)
		{
			goto IL_0208;
		}
		goto IL_025f;
		IL_025f:
		IEnumerable<object> source = Enumerable.Where(array2, predicate);
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj3;
		}
		object obj16 = (nint)0 + (nint)2416;
		object obj17 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1400;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v10+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v34+20]");
		Func<object, long> keySelector = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v34+20]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		object obj26;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v10+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj21 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v40+B8]");
				obj18 = 0;
			}
			object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)3488;
			Func<object, long> func = default(Func<object, long>);
			func..ctor(obj18, (IntPtr)obj23);
			object obj24 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v39+B8]");
			object obj25 = (nint)0 + (nint)32;
			obj25 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj26 = 0;
			keySelector = func;
		}
		object obj27 = obj16;
		IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderByDescending(source, keySelector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = default(object);
		obj28..ctor();
		object obj29 = obj28 + 16;
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj30 = obj28 + 24;
		obj30 = orderedEnumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj39;
		object obj40;
		object obj36;
		object obj38;
		if (list != null)
		{
			object obj31 = (nint)0 + (nint)2280;
			object obj32 = obj31;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag7 = list._size < items.Length;
				object obj33 = !flag7;
				if (obj33 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj34 = list._items + list._size;
					object obj35 = obj34 + 32;
					obj35 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj36 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v24+E4]");
					bool flag8 = (nint)0 == 0;
					object obj37 = !flag8;
					obj38 = obj28;
					if (obj37 == null)
					{
						obj39 = obj27;
						obj40 = obj28;
						object obj41 = obj36;
						goto IL_058c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v8+20]");
					object obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v28+C0]");
					object obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v29+70]");
					obj39 = 0;
					list.AddWithResize(obj28);
					object obj41 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v51+E4]");
					bool flag9 = (nint)0 == 0;
					object obj44 = !flag9;
					obj40 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v29+70]");
					obj27 = 0;
					obj38 = obj28;
					obj36 = obj41;
					if (obj44 == null)
					{
						goto IL_058c;
					}
				}
				goto IL_098f;
			}
		}
		goto IL_07c1;
		IL_098f:
		object obj45 = (nint)0 + (nint)2568;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v24+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v19+28]");
		Func<object, bool> predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v19+28]");
		bool flag10 = (nint)0 == 0;
		object obj47 = !flag10;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v24+E4]");
			bool flag11 = (nint)0 == 0;
			object obj48 = !flag11;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj49 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v25+B8]");
				obj46 = 0;
			}
			object obj50 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj51 = (nint)0 + (nint)3496;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj46, (IntPtr)obj51);
			object obj52 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v24+B8]");
			object obj53 = (nint)0 + (nint)40;
			obj53 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj26 = 0;
			predicate2 = func2;
		}
		IEnumerable<object> source2 = Enumerable.Where(array2, predicate2);
		List<object> list2 = Enumerable.ToList(source2);
		bool flag12 = ArraysExtensions.IsNullOrEmpty(list2);
		bool flag13 = !flag12;
		object obj54 = !flag13;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj55 = "Network Authentication Required" + 2104;
			object obj56 = default(object);
			obj56..ctor();
			object obj57 = obj56 + 16;
			obj57 = obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj58 = obj56 + 24;
			obj58 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int version2 = list._version + 1;
			list._version = version2;
			object[] items2 = list._items;
			if (list._items == null)
			{
				goto IL_07c1;
			}
			bool flag14 = list._size < items2.Length;
			object obj59 = !flag14;
			if (obj59 == null)
			{
				int size2 = list._size + 1;
				list._size = size2;
				object obj60 = list._items + list._size;
				object obj61 = obj60 + 32;
				obj61 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize(obj56);
			}
		}
		return (IEnumerable<FriendListSection>)list;
		IL_058c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj36 = obj3;
		obj27 = obj39;
		obj38 = obj40;
		goto IL_098f;
		IL_0098:
		obj13 = (nint)0 + (nint)3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v70+B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v43+18]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v43+18]");
		bool flag15 = (nint)0 == 0;
		object obj62 = !flag15;
		if (obj62 == null)
		{
			obj10 = obj13;
			object obj6 = obj4;
			array3 = array2;
			goto IL_0208;
		}
		goto IL_025f;
		IL_07c1:
		return (IEnumerable<FriendListSection>)new NullReferenceException();
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v70+E4]");
		bool flag16 = (nint)0 == 0;
		object obj63 = !flag16;
		if (obj63 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj64 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v49+B8]");
			obj11 = 0;
		}
		object obj65 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj66 = (nint)0 + (nint)3480;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj11, (IntPtr)obj66);
		object obj67 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v48+B8]");
		object obj68 = (nint)0 + (nint)24;
		obj68 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj26 = 0;
		obj13 = obj10;
		array2 = array3;
		predicate = func3;
		goto IL_025f;
	}
}
