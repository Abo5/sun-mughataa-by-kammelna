using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Pool;

public class PooledObjectList<T> where T : class
{
	private readonly ObjectPool<T> _pool;

	private readonly HashSet<T> _active;

	private readonly List<T> _releaseBuffer;

	public PooledObjectList(Func<T> createFunction, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, int capacity = 5)
	{
		//IL_001c: Expected O, but got I
		//IL_0032: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v2 (Il2CppRgctx<PooledObjectList`1>)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v2 (Il2CppRgctx<PooledObjectList`1>)+10]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3989138");
		object obj5 = this + 16;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9 (Il2CppRgctx<PooledObjectList`1>)+28]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v9 (Il2CppRgctx<PooledObjectList`1>)+28]");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag2 = obj9 == null;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = 0;
		HashSet<object> hashSet = default(HashSet<object>);
		hashSet..ctor(capacity);
		object obj11 = this + 24;
		obj11 = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v15 (Il2CppRgctx<PooledObjectList`1>)+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v15 (Il2CppRgctx<PooledObjectList`1>)+38]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag3 = obj14 == null;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num6 = 0;
		List<object> list = default(List<object>);
		list..ctor(capacity);
		object obj16 = this + 32;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public T GetPooledObject()
	{
		if (_pool != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D49814");
			if (_active != null)
			{
				object obj = default(object);
				bool flag = ((HashSet<object>)(object)_active).Add(obj);
				return (T)obj;
			}
		}
		return (T)(object)new NullReferenceException();
	}

	public void ReleasePooledObject(T pooledObject)
	{
		if (((HashSet<object>)(object)_active).Remove((object)pooledObject))
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
		}
	}

	public unsafe void ReleasePooledObjects()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0149: Expected I, but got O
		//IL_00e5: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_00f3: Expected I, but got O
		//IL_03a9: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_01e5: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_0436: Expected O, but got I
		//IL_0446: Expected O, but got I
		//IL_0456: Expected O, but got I
		//IL_0489: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01bc: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_024a: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		List<T> releaseBuffer = _releaseBuffer;
		if (_releaseBuffer != null)
		{
			int size = releaseBuffer._size;
			int version = releaseBuffer._version + 1;
			releaseBuffer._size = 0;
			releaseBuffer._version = version;
			bool flag = releaseBuffer._size < 1;
			object obj4 = default(object);
			object obj3 = obj4;
			List<object> releaseBuffer2 = (List<object>)(object)_releaseBuffer;
			nint num;
			if (!flag)
			{
				Array.Clear(releaseBuffer._items, 0, releaseBuffer._size);
				releaseBuffer2 = (List<object>)(object)_releaseBuffer;
				bool flag2 = _releaseBuffer == null;
				obj3 = 0;
				obj4 = 0;
				num = unchecked((nint)null);
				if (flag2)
				{
					goto IL_038e;
				}
			}
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v14 (Il2CppRgctx<PooledObjectList`1>)+78]");
			size = 0;
			releaseBuffer2.AddRange(_active);
			bool flag3 = _releaseBuffer == null;
			obj4 = obj3;
			num = (nint)_active;
			if (!flag3)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)_releaseBuffer).GetEnumerator();
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				object obj17 = default(object);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1-18]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v20+20]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v21+C0]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v22+A8]");
					num = 0;
					object obj11;
					if (enumerator2.MoveNext())
					{
						if (_pool != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1-18]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v23+20]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v24+C0]");
							object obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v25+68]");
							size = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D498F4");
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						obj11 = 0;
						obj4 = obj3;
						break;
					}
					obj11 = 0;
					object obj12 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1-18]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v2+20]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v3+C0]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+B0]");
						num = 0;
						enumerator2.Dispose();
						bool flag4 = obj12 == null;
						object obj16 = !flag4;
						obj4 = obj3;
						if (obj16 != null)
						{
							OutOfMemoryException ex2 = new OutOfMemoryException();
							if (num == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
								obj12 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
								obj11 = obj17;
								obj3 = obj4;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D553D0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
							return;
						}
						break;
					}
					bool flag5 = _active == null;
					obj4 = obj3;
					if (flag5)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1-18]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v5+20]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v6+C0]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v7+B8]");
					num = 0;
					((HashSet<object>)(object)_active).Clear();
					List<T> releaseBuffer3 = _releaseBuffer;
					bool flag6 = _releaseBuffer == null;
					obj4 = obj3;
					if (flag6)
					{
						break;
					}
					int version2 = releaseBuffer3._version + 1;
					releaseBuffer3._size = 0;
					releaseBuffer3._version = version2;
					if (releaseBuffer3._size >= 1)
					{
						Array.Clear(releaseBuffer3._items, 0, releaseBuffer3._size);
					}
					return;
				}
			}
		}
		goto IL_038e;
		IL_038e:
		throw new NullReferenceException();
	}
}
