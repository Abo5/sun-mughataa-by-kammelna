using System;
using Cpp2ILInjected;

public class SelectableItemsList
{
	private ISelectable[] selectables;

	private ISelectable currentSelected;

	public void SetList(ISelectable[] selectables)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 16;
		obj = selectables;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetSelected(ISelectable target)
	{
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0292: Expected I, but got O
		//IL_02a2: Expected O, but got I
		//IL_000f: Expected O, but got I4
		//IL_032d: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_02dd: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 1064;
		ISelectable[] array = selectables;
		nint num2 = default(nint);
		if (selectables != null)
		{
			object obj2 = array.Length;
			if (array.Length >= 1)
			{
				object obj3 = selectables + 32;
				nint num = num2;
				object obj4 = 0;
				bool flag;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X25_v4+v166 @ X24_v5*8]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X25_v4+v166 @ X24_v5*8]");
					if (0 != (nint)target)
					{
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v17+12E]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v17+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0054;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v17+B0]");
						object obj8 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v22-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj8 += 16;
							obj7--;
							if ((nint)obj7 != 1)
							{
								continue;
							}
							goto IL_0054;
						}
						obj7 = obj8 + 1;
						object obj9 = obj6 + obj7;
						object obj10 = obj9 + 312;
						goto IL_006c;
					}
					goto IL_038f;
					IL_038f:
					obj4++;
					flag = obj4 >= obj2;
					num2 = num;
					continue;
					IL_0054:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num = 1;
					goto IL_006c;
					IL_006c:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v468 @ X0_v23] (should have been resolved before IL gen)");
					obj2 = array.Length;
					goto IL_038f;
				}
				while (!flag);
			}
		}
		object obj11 = this + 24;
		object obj12 = obj11;
		if (obj11 == null)
		{
			goto IL_028a;
		}
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0244;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0244;
		}
		object obj16 = obj15 + 1;
		object obj17 = obj13 + obj16;
		object obj18 = obj17 + 312;
		goto IL_040c;
		IL_028a:
		nint num3 = (nint)target;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6 (Il2CppClass<ISelectable>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6 (Il2CppClass<ISelectable>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_031e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6 (Il2CppClass<ISelectable>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v8-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_031e;
		}
		object obj21 = num3 + obj20;
		object obj22 = obj21 + 312;
		goto IL_043f;
		IL_043f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v440 @ X0_v6] (should have been resolved before IL gen)");
		obj11 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_040c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v14] (should have been resolved before IL gen)");
		goto IL_028a;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 1;
		goto IL_040c;
		IL_031e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_043f;
	}
}
