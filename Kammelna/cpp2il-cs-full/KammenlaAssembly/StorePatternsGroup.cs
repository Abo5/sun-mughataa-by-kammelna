using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using ListView;
using UnityEngine.AdaptivePerformance;

public class StorePatternsGroup : UiGridView<StoreDataHolder, ListViewItem<StoreDataHolder, int>>
{
	public void Populate(List<StoreItem> patterns)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected O, but got Unknown
		//IL_0536: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_047d: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01d4: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_0234: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I4
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0310: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3576;
		object obj2 = (nint)0 + (nint)2800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		_ = 0;
		_ = 4;
		_ = 4294967295L;
		object obj5 = obj4 + 72;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((StoreDataHolder)obj4).SetTemplate();
		bool flag = list == null;
		object obj6 = null;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator4;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj7 = (nint)0 + (nint)2808;
			object obj8 = obj7;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag2 = list._items == null;
			obj6 = null;
			if (!flag2)
			{
				bool flag3 = list._size < items.Length;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					int num = list._size + 1;
					list._size = num;
					object obj10 = list._items + list._size;
					object obj11 = obj10 + 32;
					obj11 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj6 = obj4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v15+20]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v34+C0]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v35+70]");
					nint num2 = 0;
					list.AddWithResize(obj4);
					obj6 = obj4;
				}
				if (patterns != null)
				{
					object obj14 = (nint)0 + (nint)1800;
					List<object>.Enumerator enumerator = ((List<object>)(object)patterns).GetEnumerator();
					object obj15 = 0;
					object obj16 = default(object);
					object obj19 = default(object);
					while (true)
					{
						obj6 = obj14;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (obj16 == null)
						{
							goto IL_03d6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ stack_-88 (System.Object)+88]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ stack_-88 (System.Object)+58]");
						object obj17 = (nint)0 & (nint)1;
						bool flag4 = obj17 == null;
						object obj18 = !flag4;
						if (obj18 != null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj19..ctor();
						object obj20 = obj19 + 72;
						obj20 = obj16;
						_ = 0;
						_ = 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						((StoreDataHolder)obj19).SetTemplate();
						object obj21 = obj7;
						int version2 = list._version + 1;
						list._version = version2;
						object[] items2 = list._items;
						bool flag5 = list._items == null;
						enumerator2 = enumerator3;
						enumerator4 = enumerator3;
						enumerator3 = (List<object>.Enumerator)0;
						obj6 = obj16;
						if (!flag5)
						{
							obj15++;
							bool flag6 = list._size < items2.Length;
							object obj22 = !flag6;
							if (obj22 == null)
							{
								int num3 = list._size + 1;
								list._size = num3;
								object obj23 = list._items + list._size;
								object obj24 = obj23 + 32;
								obj24 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v29+20]");
								object obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v30+C0]");
								object obj26 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v31+70]");
								nint num2 = 0;
								list.AddWithResize(obj19);
							}
							continue;
						}
						goto IL_0414;
					}
					enumerator2.Dispose();
					goto IL_03cb;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		goto IL_0414;
		IL_0414:
		NullReferenceException ex2 = new NullReferenceException();
		List<object>.Enumerator enumerator5 = enumerator2;
		goto IL_0430;
		IL_03d6:
		ex2 = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_0430;
		IL_03cb:
		base.data = (List<StoreDataHolder>)(object)list;
		return;
		IL_0430:
		bool flag7 = (nint)obj6 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj27 = (nint)0 + (nint)1792;
			obj6 = obj27;
			enumerator5.Dispose();
			object obj28 = default(object);
			if (obj28 == null)
			{
				goto IL_03cb;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj28;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238594");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public StorePatternsGroup()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
