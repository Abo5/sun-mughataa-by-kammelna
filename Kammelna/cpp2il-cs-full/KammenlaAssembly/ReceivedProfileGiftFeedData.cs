using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Properties;

public class ReceivedProfileGiftFeedData : UserFeedData, IAvatarFeedData
{
	private long <SenderId>k__BackingField;

	private DateTime? <SenderAvatarDate>k__BackingField;

	private string <SenderName>k__BackingField;

	private int <GiftId>k__BackingField;

	private string <Message>k__BackingField;

	public long SenderId
	{
		get
		{
			return <SenderId>k__BackingField;
		}
		set
		{
			<SenderId>k__BackingField = value;
		}
	}

	public DateTime? SenderAvatarDate
	{
		get
		{
			return <SenderAvatarDate>k__BackingField;
		}
		set
		{
			<SenderAvatarDate>k__BackingField = value;
		}
	}

	public string SenderName
	{
		get
		{
			return <SenderName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int GiftId
	{
		get
		{
			return <GiftId>k__BackingField;
		}
		set
		{
			<GiftId>k__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return <Message>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override bool HasPreview => true;

	public override bool ForcedPreview => true;

	long IAvatarFeedData.Id => <SenderId>k__BackingField;

	string IAvatarFeedData.Name => <SenderName>k__BackingField;

	DateTime? IAvatarFeedData.AvatarDate => <SenderAvatarDate>k__BackingField;

	public override LocalizableText GetTitle()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj3;
		if (array != null)
		{
			bool flag = <SenderName>k__BackingField == null;
			obj2 = 1;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				if (flag2)
				{
					goto IL_0146;
				}
			}
			if (array.Length != 0)
			{
				object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
				object text = "utf-32" + 4040;
				object obj5 = array + 32;
				obj5 = <SenderName>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				LocalizableText localizableText = default(LocalizableText);
				localizableText..ctor((string)text, array);
				return localizableText;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj2 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj3 = obj2;
		goto IL_0146;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public override LocalizableText GetDetails()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_025a: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_033c: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02ba: Expected O, but got I
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I4
		//IL_0302: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016b: Expected O, but got I
		//IL_017b: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		object obj = 152989696;
		object obj2 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71B4]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		object obj6;
		string text2;
		object obj4;
		if (obj3 != null)
		{
			text = <Message>k__BackingField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			text2 = <Message>k__BackingField;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			text = <Message>k__BackingField;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			text2 = <Message>k__BackingField;
			if (obj7 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v3+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		text = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_0112;
		}
		goto IL_0310;
		IL_0147:
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v17+B8]");
		object arguments = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(text, LocalizableText.Mode.FixOnly, (object[])arguments);
		return localizableText;
		IL_035a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj6;
		text = text2;
		goto IL_0147;
		IL_0112:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		obj6 = obj4;
		text2 = text;
		if (!flag5)
		{
			goto IL_0147;
		}
		goto IL_035a;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v18+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v18+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag6 = obj21 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v18+10]");
		obj13 = 0;
		obj6 = obj4;
		text2 = text;
		if (!flag6)
		{
			goto IL_0112;
		}
		goto IL_0310;
		IL_0310:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		obj4 = obj6;
		text = text2;
		if (obj22 != null)
		{
			goto IL_0147;
		}
		goto IL_035a;
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71B5]");
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
		ProfileGiftReceivedPopup.PopupReceived(this);
		bool flag = markSeen == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			return;
		}
		goto IL_0097;
		IL_0074:
		ProfileGiftReceivedPopup.PopupReceived(this);
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
