using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class RequestCache<TKey, TValue> where TValue : class
{
	private sealed class <>c__DisplayClass5_0
	{
		public RequestCache<TKey, TValue> <>4__this;

		public TKey key;

		internal void <Get>b__0(TValue value)
		{
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected O, but got I
			//IL_011f: Expected O, but got I4
			//IL_0127: Expected I, but got O
			//IL_0151: Expected O, but got I4
			//IL_0159: Expected I, but got O
			//IL_0191: Expected I4, but got O
			//IL_00e4: Expected I4, but got O
			//IL_00ee: Expected I4, but got O
			//IL_021e: Expected I4, but got O
			//IL_0294: Expected O, but got I4
			//IL_029e: Expected O, but got I4
			//IL_0370: Expected O, but got I
			//IL_0393: Expected O, but got I4
			//IL_0265: Expected O, but got I4
			bool flag = value == null;
			int num = (int)value;
			IntPtr intPtr = default(IntPtr);
			(object, float) tuple = ((object, float))(nint)intPtr;
			if (flag)
			{
				goto IL_00fc;
			}
			RequestCache<TKey, TValue> requestCache = <>4__this;
			bool flag2 = <>4__this == null;
			TValue val = value;
			nint num2 = intPtr;
			if (!flag2)
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v24 (Il2CppRgctx<RequestCache`2+<>c__DisplayClass5_0>)+30]");
				num2 = 0;
				(object, float) tuple2 = (value, realtimeSinceStartup);
				bool flag3 = requestCache._cache == null;
				val = value;
				if (!flag3)
				{
					nint num4 = 0;
					((Dictionary<int, (object, float)>)(object)requestCache._cache).set_Item((int)key, tuple2);
					num = (int)key;
					tuple = tuple2;
					goto IL_00fc;
				}
			}
			goto IL_02a4;
			IL_02a4:
			throw new NullReferenceException();
			IL_00fc:
			RequestCache<TKey, TValue> requestCache2 = <>4__this;
			bool flag4 = <>4__this == null;
			val = (TValue)num;
			num2 = (nint)tuple;
			if (!flag4)
			{
				bool flag5 = requestCache2._inFlight == null;
				val = (TValue)num;
				num2 = (nint)tuple;
				if (!flag5)
				{
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v10 (Il2CppRgctx<RequestCache`2+<>c__DisplayClass5_0>)+48]");
					num2 = 0;
					object obj = ((Dictionary<int, object>)(object)requestCache2._inFlight).get_Item((int)key);
					RequestCache<TKey, TValue> requestCache3 = <>4__this;
					bool flag6 = <>4__this == null;
					val = (TValue)key;
					if (!flag6)
					{
						bool flag7 = requestCache3._inFlight == null;
						val = (TValue)key;
						if (!flag7)
						{
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v13 (Il2CppRgctx<RequestCache`2+<>c__DisplayClass5_0>)+58]");
							num2 = 0;
							bool flag8 = ((Dictionary<int, object>)(object)requestCache3._inFlight).Remove((int)key);
							bool flag9 = obj == null;
							val = (TValue)key;
							if (!flag9)
							{
								List<object>.Enumerator enumerator = ((List<object>)obj).GetEnumerator();
								List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
								while (enumerator2.MoveNext())
								{
									object obj2 = 0;
								}
								(object, float) tuple2 = ((object, float))0;
								(object, float) tuple3 = ((object, float))0;
								object obj4 = default(object);
								while (true)
								{
									nint num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4 (Il2CppRgctx<RequestCache`2+<>c__DisplayClass5_0>)+98]");
									val = (TValue)0;
									enumerator2.Dispose();
									bool flag10 = (object)tuple3 == null;
									object obj3 = !flag10;
									if (obj3 == null)
									{
										return;
									}
									OutOfMemoryException ex = new OutOfMemoryException();
									if ((nint)val != 1)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
									tuple3 = ((object, float))obj4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
									tuple2 = ((object, float))obj4;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CC1060");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
								return;
							}
						}
					}
				}
			}
			goto IL_02a4;
		}
	}

	private readonly float _ttlSeconds;

	private readonly Action<TKey, Action<TValue>> _fetch;

	private readonly Dictionary<TKey, (TValue, float)> _cache;

	private readonly Dictionary<TKey, List<Action<TValue>>> _inFlight;

	public RequestCache(float ttlSeconds, Action<TKey, Action<TValue>> fetch)
	{
		//IL_001c: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0044: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		nint num = 0;
		IntPtr intPtr = num;
		if ((object)((object)((object)(num + 309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, (object, float)> dictionary = default(Dictionary<int, (object, float)>);
		dictionary..ctor();
		object obj = this + 32;
		obj = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8 (Il2CppRgctx<RequestCache`2>)+18]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8 (Il2CppRgctx<RequestCache`2>)+18]");
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary2 = default(Dictionary<int, object>);
		dictionary2..ctor();
		object obj6 = this + 40;
		obj6 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj7 = this + 24;
		obj7 = fetch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Get(TKey key, Action<TValue> callback)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00d0: Expected I4, but got O
		//IL_0250: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_028e: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_0318: Expected O, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0424: Expected O, but got I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v2 (Il2CppRgctx<RequestCache`2>)+30]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v2 (Il2CppRgctx<RequestCache`2>)+30]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31EAB8C");
		object obj6 = default(object);
		object obj5 = obj6 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		if (((Dictionary<int, (object, float)>)(object)_cache).TryGetValue((int)key, out (object, float) _))
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			if (realtimeSinceStartup < _ttlSeconds)
			{
				if (callback != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [callback @ X2 (System.Action`1<TValue>)+18] (should have been resolved before IL gen)");
				}
				return;
			}
		}
		nint num4 = 0;
		Dictionary<TKey, List<Action<TValue>>> inFlight = _inFlight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		if (((Dictionary<int, object>)(object)inFlight).TryGetValue(0, out object value2))
		{
			int version = ((List<object>)value2)._version + 1;
			((List<object>)value2)._version = version;
			object[] items = ((List<object>)value2)._items;
			bool flag2 = ((List<object>)value2)._size < items.Length;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				int size = ((List<object>)value2)._size + 1;
				((List<object>)value2)._size = size;
				object obj8 = items + ((List<object>)value2)._size;
				object obj9 = obj8 + 32;
				obj9 = callback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)value2).AddWithResize((object)callback);
			}
			return;
		}
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v14 (Il2CppRgctx<RequestCache`2>)+88]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v14 (Il2CppRgctx<RequestCache`2>)+88]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag4 = list._size < items2.Length;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj15 = items2 + list._size;
			object obj16 = obj15 + 32;
			obj16 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)callback);
		}
		nint num6 = 0;
		Dictionary<TKey, List<Action<TValue>>> inFlight2 = _inFlight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		((Dictionary<int, object>)(object)inFlight2).set_Item(0, (object)list);
		Action<TKey, Action<TValue>> fetch = _fetch;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v26 (Il2CppRgctx<RequestCache`2>)+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v26 (Il2CppRgctx<RequestCache`2>)+60]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v30 (Il2CppRgctx<RequestCache`2>)+A8]");
		Action<object> action = default(Action<object>);
		action..ctor(obj6, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X23_v6 (System.Action`2<TKey, System.Action`1<TValue>>)+18] (should have been resolved before IL gen)");
	}

	public void Clear()
	{
		((Dictionary<int, (object, float)>)(object)_cache).Clear();
	}
}
