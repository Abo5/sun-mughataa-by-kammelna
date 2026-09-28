using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine.AdaptivePerformance;

namespace Libraries.AppCheck;

public class TokenRequestCoalescer
{
	private readonly object _gate;

	private readonly Dictionary<(string, string), List<AppCheckResult>> _inFlight;

	public unsafe bool Join(string userKey, string requestHash, AppCheckResult callback)
	{
		//IL_0686: Expected O, but got I
		//IL_06b9: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0019: Expected I, but got O
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_0566: Expected O, but got I4
		//IL_05e6: Expected O, but got I4
		//IL_05fb: Expected O, but got Ref
		//IL_020c: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_074c: Expected O, but got Ref
		//IL_040c: Expected O, but got I4
		//IL_0282: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_03c0: Expected O, but got Ref
		//IL_042f: Expected O, but got I
		//IL_043f: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_036f: Expected O, but got I4
		//IL_0377: Expected O, but got Ref
		//IL_038a: Expected O, but got I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0492: Expected O, but got I
		//IL_049a: Expected I, but got O
		//IL_04c0: Expected O, but got I4
		//IL_04e4: Expected O, but got I4
		//IL_04fb: Expected O, but got I4
		//IL_051b: Expected I, but got O
		//IL_054f: Expected O, but got I4
		bool lockTaken = default(bool);
		Monitor.Enter(_gate, ref lockTaken);
		object obj = (nint)0 + (nint)3936;
		List<object> list = (List<object>)obj;
		(object, object) tuple = (userKey, requestHash);
		bool flag = _inFlight == null;
		object obj2 = 0;
		List<object> list2 = null;
		object obj3 = requestHash;
		object obj4 = userKey;
		ref object reference = ref *(object*)null;
		TokenRequestCoalescer tokenRequestCoalescer = this;
		if (flag)
		{
			goto IL_05b6;
		}
		object obj5 = (nint)0 + (nint)1344;
		nint num = (nint)obj5;
		object[] array = default(object[]);
		int num2 = default(int);
		object obj8 = default(object);
		ref object reference2;
		object obj14;
		(object, object) tuple2;
		bool flag7;
		object obj25;
		int num3;
		object[] array2;
		nint num4;
		List<object> list4;
		ref object reference3;
		TokenRequestCoalescer tokenRequestCoalescer2;
		bool result;
		object obj26;
		NullReferenceException ex;
		if (((Dictionary<(object, object), object>)(object)_inFlight).TryGetValue(tuple, out *(object*)null))
		{
			if (list2 != null)
			{
				object obj6 = (nint)0 + (nint)920;
				object obj7 = obj6;
				int version = list2._version + 1;
				list2._version = version;
				array = list2._items;
				if (list2._items != null)
				{
					num2 = list2._size;
					obj8 = array.Length;
					bool flag2 = list2._size < array.Length;
					object obj9 = !flag2;
					if (obj9 == null)
					{
						int size = list2._size + 1;
						list2._size = size;
						object obj10 = list2._items + list2._size;
						object obj11 = obj10 + 32;
						obj11 = callback;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						reference2 = ref *(object*)null;
						obj4 = callback;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v31+20]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v33+C0]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v34+70]");
						reference2 = ref *(object*)null;
						list2.AddWithResize((object)callback);
						obj4 = callback;
					}
					obj2 = 0;
					list = (List<object>)(&list2);
					reference = ref *(object*)null;
					tokenRequestCoalescer = this;
					obj14 = 0;
					goto IL_0709;
				}
			}
			ex = new NullReferenceException();
			obj2 = 0;
			reference2 = ref *(object*)null;
			tuple2 = tuple;
			list = (List<object>)(&list2);
			reference = ref *(object*)null;
			tokenRequestCoalescer = this;
		}
		else
		{
			tokenRequestCoalescer = (TokenRequestCoalescer)(object)_inFlight;
			list = (List<object>)obj;
			tuple = (userKey, requestHash);
			object obj15 = typeof(List<AdaptivePerformanceScaler>) + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)912;
			tuple2 = ((object, object))obj16;
			List<object> list3 = default(List<object>);
			list3..ctor();
			bool flag3 = list3 == null;
			reference2 = ref *(object*)requestHash;
			if (!flag3)
			{
				object obj17 = (nint)0 + (nint)920;
				object obj18 = obj17;
				int version2 = list3._version + 1;
				list3._version = version2;
				array = list3._items;
				bool flag4 = list3._items == null;
				reference2 = ref *(object*)requestHash;
				if (!flag4)
				{
					num2 = list3._size;
					obj8 = array.Length;
					bool flag5 = list3._size < array.Length;
					object obj19 = !flag5;
					if (obj19 == null)
					{
						int size2 = list3._size + 1;
						list3._size = size2;
						object obj20 = list3._items + list3._size;
						object obj21 = obj20 + 32;
						obj21 = callback;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						reference2 = ref *(object*)requestHash;
						tuple2 = ((object, object))callback;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v20+20]");
						object obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v25+C0]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v26+70]");
						reference2 = ref *(object*)null;
						list3.AddWithResize((object)callback);
						tuple2 = ((object, object))callback;
					}
					if (tokenRequestCoalescer != null)
					{
						object obj24 = (nint)0 + (nint)1352;
						num = (nint)obj24;
						((Dictionary<(object, object), object>)(object)tokenRequestCoalescer).set_Item(tuple, (object)null);
						bool flag6 = lockTaken;
						obj2 = 0;
						reference2 = ref *(object*)null;
						list = list3;
						reference = ref *(object*)null;
						flag7 = true;
						obj14 = 0;
						if (flag6)
						{
							goto IL_038f;
						}
						obj2 = 0;
						obj25 = obj8;
						num3 = num2;
						array2 = array;
						num4 = (nint)obj24;
						obj3 = null;
						obj4 = tuple;
						list4 = list3;
						reference3 = ref *(object*)null;
						tokenRequestCoalescer2 = tokenRequestCoalescer;
						result = true;
						obj26 = 0;
						goto IL_03f2;
					}
				}
			}
			ex = new NullReferenceException();
			obj2 = 0;
			reference = ref *(object*)null;
		}
		goto IL_0610;
		IL_038f:
		object obj27 = default(object);
		Monitor.Exit(obj27);
		obj25 = obj8;
		num3 = num2;
		array2 = array;
		num4 = num;
		obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		obj4 = null;
		list4 = list;
		reference3 = ref reference;
		tokenRequestCoalescer2 = tokenRequestCoalescer;
		result = flag7;
		obj26 = obj14;
		goto IL_03f2;
		IL_0709:
		bool flag8 = !lockTaken;
		flag7 = false;
		obj25 = obj8;
		num3 = num2;
		array2 = array;
		num4 = num;
		obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		list4 = list;
		reference3 = ref reference;
		tokenRequestCoalescer2 = tokenRequestCoalescer;
		result = false;
		obj26 = obj14;
		if (!flag8)
		{
			goto IL_038f;
		}
		goto IL_03f2;
		IL_0610:
		if ((nint)tuple2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj28 = default(object);
			obj14 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj2 = obj28;
			obj4 = tuple2;
			goto IL_0709;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C982FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result2 = default(bool);
		return result2;
		IL_05b6:
		ex = new NullReferenceException();
		reference2 = ref *(object*)obj3;
		tuple2 = ((object, object))obj4;
		goto IL_0610;
		IL_03f2:
		bool flag9 = obj26 == null;
		object obj29 = !flag9;
		if (obj29 == null)
		{
			return result;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj8 = obj25;
		num2 = num3;
		array = array2;
		num = num4;
		list = list4;
		reference = ref reference3;
		tokenRequestCoalescer = tokenRequestCoalescer2;
		goto IL_05b6;
	}

	public unsafe AppCheckResult[] Complete(string userKey, string requestHash)
	{
		//IL_036f: Expected O, but got I
		//IL_03a2: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0130: Expected O, but got Ref
		//IL_015a: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_017c: Expected O, but got Ref
		//IL_01a5: Expected O, but got I4
		//IL_03e9: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_01cc: Expected O, but got Ref
		//IL_0098: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		bool lockTaken = default(bool);
		Monitor.Enter(_gate, ref lockTaken);
		object obj = (nint)0 + (nint)3936;
		object obj2 = obj;
		(object, object) key = (userKey, requestHash);
		bool flag = _inFlight == null;
		object obj3 = 0;
		List<object> list = null;
		object obj4 = requestHash;
		object obj5 = userKey;
		ref object reference = ref *(object*)null;
		TokenRequestCoalescer tokenRequestCoalescer = this;
		if (flag)
		{
			goto IL_0229;
		}
		object obj6 = (nint)0 + (nint)1344;
		object obj7 = obj6;
		object[] array = default(object[]);
		ref object reference2;
		ref object reference3;
		(object, object) tuple;
		NullReferenceException ex;
		if (((Dictionary<(object, object), object>)(object)_inFlight).TryGetValue(key, out *(object*)null))
		{
			tokenRequestCoalescer = (TokenRequestCoalescer)(object)_inFlight;
			obj2 = obj;
			key = (userKey, requestHash);
			if (_inFlight != null)
			{
				object obj8 = (nint)0 + (nint)1336;
				obj2 = obj8;
				bool flag2 = ((Dictionary<(object, object), object>)(object)_inFlight).Remove(key);
				if (list != null)
				{
					object obj9 = (nint)0 + (nint)928;
					obj5 = obj9;
					array = list.ToArray();
					reference2 = ref *(object*)null;
					reference3 = ref *(object*)null;
					goto IL_013f;
				}
				ex = new NullReferenceException();
				obj3 = 0;
				obj4 = null;
				tuple = key;
				reference = ref *(object*)null;
			}
			else
			{
				ex = new NullReferenceException();
				obj3 = 0;
				obj4 = requestHash;
				tuple = ((object, object))userKey;
				reference = ref *(object*)null;
			}
			goto IL_029a;
		}
		object obj10 = typeof(TypeConverter<ushort, char>) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		reference2 = ref *(object*)null;
		obj5 = null;
		obj2 = (object)(&list);
		reference3 = ref *(object*)null;
		tokenRequestCoalescer = this;
		goto IL_013f;
		IL_0229:
		ex = new NullReferenceException();
		tuple = ((object, object))obj5;
		goto IL_029a;
		IL_013f:
		bool flag3 = !lockTaken;
		obj3 = 0;
		object obj11 = 0;
		obj3 = 0;
		object obj12 = obj7;
		obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		object obj13 = obj2;
		reference = ref reference3;
		AppCheckResult[] result = (AppCheckResult[])array;
		TokenRequestCoalescer tokenRequestCoalescer2 = tokenRequestCoalescer;
		object obj14 = 0;
		if (!flag3)
		{
			goto IL_01b3;
		}
		goto IL_03cf;
		IL_029a:
		if ((nint)tuple == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj15 = default(object);
			obj11 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag4 = lockTaken;
			obj3 = obj15;
			reference2 = ref *(object*)obj4;
			reference3 = ref reference;
			array = null;
			if (flag4)
			{
				goto IL_01b3;
			}
			obj3 = obj15;
			obj12 = obj7;
			obj5 = tuple;
			obj13 = obj2;
			result = null;
			tokenRequestCoalescer2 = tokenRequestCoalescer;
			obj14 = obj15;
			goto IL_03cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C982FC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		AppCheckResult[] result2 = default(AppCheckResult[]);
		return result2;
		IL_03cf:
		bool flag5 = obj14 == null;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			return result;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj7 = obj12;
		obj2 = obj13;
		tokenRequestCoalescer = tokenRequestCoalescer2;
		goto IL_0229;
		IL_01b3:
		object obj17 = default(object);
		Monitor.Exit(obj17);
		obj12 = obj7;
		obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		obj5 = null;
		obj13 = obj2;
		reference = ref reference3;
		result = (AppCheckResult[])array;
		tokenRequestCoalescer2 = tokenRequestCoalescer;
		obj14 = obj11;
		goto IL_03cf;
	}

	public TokenRequestCoalescer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2968;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = this + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<(object, object), object> dictionary = default(Dictionary<(object, object), object>);
		dictionary..ctor();
		object obj5 = this + 24;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
