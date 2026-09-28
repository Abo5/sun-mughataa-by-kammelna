using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using TMPro;
using Unity.Properties;
using UnityEngine;

public abstract class NumberFormatter : ScriptableObject
{
	public abstract void AssignValue(TextMeshProUGUI label, int value);

	protected static void SetText(TextMeshProUGUI text, string template, object value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_0230: Expected I, but got O
		//IL_0240: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A1F]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(template);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_01be;
		IL_00b0:
		if (value == null)
		{
			goto IL_0342;
		}
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v17+48]");
		object obj9 = 0;
		nint num = (nint)value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v17+48]");
		if (value != null)
		{
			string text2 = value.ToString();
			TextMeshProExtensions.FixArabic(text, text2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v18 (Il2CppClass<System.Object>)+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X1_v14+40]");
		if (num2 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			object obj10 = "Material with texture name \"" + 3224;
			int num3 = default(int);
			string text3 = num3.ToString((string)obj10);
			TextMeshProExtensions.FixArabic(text, text3);
			return;
		}
		goto IL_0376;
		IL_0350:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_035e;
		IL_0376:
		throw new InvalidCastException();
		IL_007d:
		bool flag4 = StringsExtensions.IsNullOrEmpty(template);
		bool flag5 = !flag4;
		obj7 = 0;
		if (!flag5)
		{
			goto IL_00b0;
		}
		goto IL_01be;
		IL_01be:
		object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag6 = array == null;
		obj7 = 1;
		if (flag6)
		{
			goto IL_0342;
		}
		bool flag7 = value == null;
		object obj12 = 1;
		if (!flag7)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag8 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
			obj7 = 0;
			if (flag8)
			{
				goto IL_035e;
			}
		}
		bool flag9 = array.Length == 0;
		obj7 = obj12;
		if (!flag9)
		{
			object obj13 = array + 32;
			obj13 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(text, template, array);
			return;
		}
		goto IL_0350;
		IL_035e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0376;
		IL_0342:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0350;
	}
}
