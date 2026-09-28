using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace ListView;

public abstract class NestedListViewItem<TData, TIndex> : ListViewItem<TData, TIndex>, INestedListViewItem<TData, TIndex>, INestedListViewItem, IListViewItem, IListViewItem<TData, TIndex> where TData : IListViewItemData<TIndex>
{
	public event Action<TData> toggleExpanded
	{
		add
		{
			//IL_005a: Expected O, but got I
			//IL_0070: Expected O, but got I
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_0098: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj2 = default(object);
			Delegate obj = (Delegate)obj2;
			object obj8 = default(object);
			object obj10 = default(object);
			bool flag3;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj, value);
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewItem`2>)+8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewItem`2>)+8]");
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag = obj6 == null;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					obj4 = obj8;
				}
				if ((object)obj3 == null)
				{
					object obj9 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = obj10 == null;
					object obj11 = !flag2;
					object obj9 = obj10;
					if (obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				nint num3 = 0;
				IntPtr intPtr2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag3 = (object)obj12 == obj;
				obj = obj12;
			}
			while (!flag3);
		}
		remove
		{
			//IL_005a: Expected O, but got I
			//IL_0070: Expected O, but got I
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_0098: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_00e1: Expected O, but got I4
			nint num = 0;
			IntPtr intPtr = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			object obj2 = default(object);
			Delegate obj = (Delegate)obj2;
			object obj8 = default(object);
			object obj10 = default(object);
			bool flag3;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj, value);
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewItem`2>)+8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v6 (Il2CppRgctx<ListView.NestedListViewItem`2>)+8]");
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag = obj6 == null;
				object obj7 = !flag;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					obj4 = obj8;
				}
				if ((object)obj3 == null)
				{
					object obj9 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = obj10 == null;
					object obj11 = !flag2;
					object obj9 = obj10;
					if (obj11 == null)
					{
						throw new InvalidCastException();
					}
				}
				nint num3 = 0;
				IntPtr intPtr2 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag3 = (object)obj12 == obj;
				obj = obj12;
			}
			while (!flag3);
		}
	}

	public unsafe void ToggleExpanded()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0068: Expected O, but got Ref
		//IL_0080: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0112: Expected O, but got Ref
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_0186: Expected O, but got I8
		//IL_01a0: Expected O, but got I4
		//IL_021f: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v5 (Il2CppRgctx<ListView.NestedListViewItem`2>)+20]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X9_v1+FC]");
		object obj5 = (nint)0 + (nint)15;
		object obj6 = obj5 & 0x1FFFFFFF0L;
		object obj8 = default(object);
		object obj7 = (ref *(?*)(&obj8)) - (ref *(?*)obj6);
		IntPtr intPtr = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v6 (Il2CppClass<Il2CppRgctx<ListView.NestedListViewItem`2>>)+80]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
		NullReferenceException ex = default(NullReferenceException);
		if (ex != null)
		{
			nint num2 = 0;
			IntPtr intPtr2 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v13 (Il2CppClass<Il2CppRgctx<ListView.NestedListViewItem`2>>)+80]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17DC");
			if ((object)this != null)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v16 (Il2CppRgctx<ListView.NestedListViewItem`2>)+18]");
				obj9 = 0;
				object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ X1_v3+10] (should have been resolved before IL gen)");
				object obj11 = default(object);
				bool flag = obj11 == null;
				object obj12 = obj7;
				NestedListViewItem<TData, TIndex> nestedListViewItem = this;
				if (!flag)
				{
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19 (Il2CppRgctx<ListView.NestedListViewItem`2>)+20]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v20+28]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v20+28]");
					object obj14 = 0 & 0x80000000L;
					bool flag2 = obj14 == null;
					object obj15 = !flag2;
					if (obj15 == null)
					{
						obj7 = obj7;
					}
					obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ X1_v3+10] (should have been resolved before IL gen)");
					obj12 = obj7;
					nestedListViewItem = (NestedListViewItem<TData, TIndex>)obj11;
					goto IL_01d5;
				}
			}
			ex = new NullReferenceException();
			goto IL_01ca;
		}
		goto IL_01d5;
		IL_01d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
		if (obj16 == null)
		{
			return;
		}
		goto IL_01ca;
		IL_01ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
	}

	protected NestedListViewItem()
	{
		//IL_0016: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v2 (Il2CppRgctx<ListView.NestedListViewItem`2>)+30]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
