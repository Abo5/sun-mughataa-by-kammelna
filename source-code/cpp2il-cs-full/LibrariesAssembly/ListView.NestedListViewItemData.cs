using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace ListView;

public abstract class NestedListViewItemData<TChild, TIndex> : INestedListViewItemData<TChild, TIndex>, IListViewItemData<TIndex>
{
	protected List<TChild> m_Children;

	public abstract TIndex index { get; }

	public abstract string template { get; }

	public List<TChild> children
	{
		get
		{
			return m_Children;
		}
		set
		{
			//IL_0010: Expected O, but got I
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_008d: Expected O, but got I
			//IL_0045: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj = 0;
			if (this.childrenChanging != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (Il2CppRgctx<ListView.NestedListViewItemData`2>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ X1_v3+10] (should have been resolved before IL gen)");
			}
			object obj3 = this + 16;
			obj3 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
			object obj4 = 0;
			if (obj4 != obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
			}
		}
	}

	public event Action<NestedListViewItemData<TChild, TIndex>, List<TChild>> childrenChanging
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_004d: Expected O, but got I
			//IL_0063: Expected O, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_008b: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_00d4: Expected O, but got I4
			object obj = this + 24;
			Delegate obj2 = (Delegate)obj;
			object obj8 = default(object);
			object obj10 = default(object);
			bool flag3;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (Il2CppRgctx<ListView.NestedListViewItemData`2>)+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (Il2CppRgctx<ListView.NestedListViewItemData`2>)+10]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag3 = (object)obj12 == obj2;
				obj2 = obj12;
			}
			while (!flag3);
		}
		remove
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_004d: Expected O, but got I
			//IL_0063: Expected O, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_008b: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_00d4: Expected O, but got I4
			object obj = this + 24;
			Delegate obj2 = (Delegate)obj;
			object obj8 = default(object);
			object obj10 = default(object);
			bool flag3;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (Il2CppRgctx<ListView.NestedListViewItemData`2>)+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3 (Il2CppRgctx<ListView.NestedListViewItemData`2>)+10]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag3 = (object)obj12 == obj2;
				obj2 = obj12;
			}
			while (!flag3);
		}
	}
}
