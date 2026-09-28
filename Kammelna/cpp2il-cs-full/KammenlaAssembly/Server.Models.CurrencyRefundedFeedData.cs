using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class CurrencyRefundedFeedData : UserFeedData
{
	private int <Amount>k__BackingField;

	private RefundReason <Reason>k__BackingField;

	public int Amount
	{
		get
		{
			return <Amount>k__BackingField;
		}
		set
		{
			<Amount>k__BackingField = value;
		}
	}

	public RefundReason Reason
	{
		get
		{
			return <Reason>k__BackingField;
		}
		set
		{
			<Reason>k__BackingField = value;
		}
	}

	public override bool HasPreview => true;

	public override bool ForcedPreview => true;

	public override LocalizableText GetTitle()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "placementId" + 2816;
		return TextMeshProExtensions.Localize((string)text);
	}

	public unsafe override LocalizableText GetDetails()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0242: Expected O, but got Ref
		//IL_0270: Expected O, but got I4
		//IL_02a5: Expected O, but got I4
		//IL_005d: Expected O, but got Ref
		//IL_0073: Expected I, but got O
		//IL_0083: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0181: Expected O, but got I8
		//IL_0126: Expected I, but got O
		//IL_0136: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = default(object);
		string input = ((Enum)(&obj3)).ToString();
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize(input);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj6 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		if (array != null)
		{
			object obj7 = default(object);
			bool flag2 = obj7 == null;
			int num = default(int);
			object obj8 = (object)(&num);
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj9;
			if (!flag2)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj9 = 0;
				if (flag3)
				{
					goto IL_01fe;
				}
			}
			if (array.Length != 0)
			{
				object obj10 = array + 32;
				obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag4 = text == null;
				obj8 = obj7;
				if (!flag4)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					obj9 = 0;
					if (flag5)
					{
						goto IL_01fe;
					}
				}
				object obj11 = array.Length & 0xFFFFFFFEL;
				if (obj11 != null)
				{
					object text2 = "placementId" + 2808;
					object obj12 = array + 40;
					obj12 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text2, array);
				}
			}
			ex = new IndexOutOfRangeException();
			obj9 = obj8;
			goto IL_01fe;
		}
		goto IL_0216;
		IL_0216:
		return (LocalizableText)(object)new NullReferenceException();
		IL_01fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0216;
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BE0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00c8;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_0106;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RefundPopup.ShowPopup(this);
		bool flag = markSeen == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			return;
		}
		goto IL_0097;
		IL_0074:
		RefundPopup.ShowPopup(this);
		if (markSeen != null)
		{
			goto IL_0097;
		}
		return;
		IL_0097:
		IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
		IntPtr method_code = ((Delegate)markSeen).method_code;
		IntPtr method = ((Delegate)markSeen).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v66 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00c8;
		IL_00c8:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_0074;
		}
		goto IL_0106;
	}
}
