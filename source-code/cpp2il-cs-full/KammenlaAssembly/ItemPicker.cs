using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class ItemPicker<T> where T : ISelectable
{
	private readonly bool <AllowDeselect>k__BackingField;

	private List<T> <Items>k__BackingField;

	private T _selectedItem;

	public bool AllowDeselect => <AllowDeselect>k__BackingField;

	public List<T> Items
	{
		get
		{
			return <Items>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public T SelectedItem
	{
		get
		{
			return _selectedItem;
		}
		set
		{
			//IL_0044: Expected O, but got I4
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00d2: Expected O, but got I
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected O, but got Unknown
			//IL_01c0: Expected O, but got I
			//IL_010d: Expected O, but got I
			//IL_01fb: Expected O, but got I
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Expected O, but got Unknown
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
			while (true)
			{
				nint num2;
				if (value != null)
				{
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v18 (Il2CppRgctx<ItemPicker`1>)+28]");
					num2 = 0;
					bool flag = ((List<object>)(object)<Items>k__BackingField).Contains((object)value);
					bool flag2 = !flag;
					object obj = !flag2;
					if (obj == null)
					{
						break;
					}
				}
				else if (!<AllowDeselect>k__BackingField)
				{
					break;
				}
				object obj2 = this + 32;
				object obj3 = obj2;
				if (obj2 == null)
				{
					goto IL_0293;
				}
				object obj4 = typeof(System.IOAsyncCallback) + 1064;
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+12E]");
				if ((nint)0 == 0)
				{
					goto IL_014e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v12-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_014e;
				}
				object obj8 = obj7 + 1;
				object obj9 = obj5 + obj8;
				object obj10 = obj9 + 312;
				goto IL_02ee;
				IL_0293:
				obj2 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = obj2;
				if (obj2 == null)
				{
					break;
				}
				object obj12 = typeof(System.IOAsyncCallback) + 1064;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v8+B0]");
					object obj15 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v6-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						obj15 += 16;
						obj14--;
						if ((nint)obj14 != 1)
						{
							continue;
						}
						goto IL_023c;
					}
					object obj16 = obj13 + obj15;
					object obj17 = obj16 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v305 @ X0_v10] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_023c;
				IL_023c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v292 @ X0_v8] (should have been resolved before IL gen)");
				break;
				IL_02ee:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X0_v12] (should have been resolved before IL gen)");
				goto IL_0293;
				IL_014e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = 1;
				goto IL_02ee;
			}
		}
	}

	public ItemPicker(bool allowDeselect)
	{
		<AllowDeselect>k__BackingField = allowDeselect;
	}
}
