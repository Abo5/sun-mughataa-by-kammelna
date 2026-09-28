using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

[Serializable]
public abstract class DateTimeFormat
{
	private DateTimeCondition condition;

	protected string template;

	public abstract bool IsCountDown { get; }

	public bool IsSatisfied(DateTime dateTime)
	{
		//IL_0045: Expected I4, but got O
		if (condition != null)
		{
			return condition.IsSatisfied(dateTime);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	protected abstract string FormatDate(DateTime dateTime);

	public string GetFormattedText(DateTime dateTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0120: Expected O, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019b: Expected I, but got O
		//IL_00bc: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_02fb: Expected O, but got I
		//IL_01eb: Expected I, but got O
		//IL_0214: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A07]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00e6;
		}
		string value = template;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v23+E4]");
		bool flag = (nint)0 == 0;
		string value2 = template;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0138;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (string)(object)new OutOfMemoryException();
		IL_0091:
		if (StringsExtensions.IsNullOrEmpty(value))
		{
			goto IL_00b7;
		}
		goto IL_0178;
		IL_00b7:
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v18 (Il2CppClass<DateTimeFormat>)+188]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v18 (Il2CppClass<DateTimeFormat>)+190]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v78 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00e6;
		IL_00e6:
		_ = 1;
		value = template;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		value2 = template;
		if (obj7 != null)
		{
			goto IL_0091;
		}
		goto IL_0138;
		IL_0138:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(value2);
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_0178;
		IL_0178:
		object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		nint num2 = (nint)this;
		DateTime dateTime2 = default(DateTime);
		string text = FormatDate(dateTime2);
		object[] array = default(object[]);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		DateTime dateTime3;
		if (array != null)
		{
			if (text != null)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
				dateTime3 = (DateTime)0;
				if (flag5)
				{
					goto IL_0300;
				}
			}
			if (array.Length != 0)
			{
				object obj10 = array + 32;
				obj10 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v16+E4]");
				bool flag6 = (nint)0 == 0;
				object obj13 = !flag6;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return LocalizationUtil.Localize(template, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
		}
		ex = new IndexOutOfRangeException();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
		dateTime3 = (DateTime)0;
		goto IL_0300;
	}
}
