using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class ReceivedGiftFeedData : UserFeedData, IAvatarFeedData
{
	private long <SenderId>k__BackingField;

	private DateTime? <SenderAvatarDate>k__BackingField;

	private string <SenderName>k__BackingField;

	private GiftsHandler.GiftType <GiftType>k__BackingField;

	private int <Amount>k__BackingField;

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

	public GiftsHandler.GiftType GiftType
	{
		get
		{
			return <GiftType>k__BackingField;
		}
		set
		{
			<GiftType>k__BackingField = value;
		}
	}

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

	long IAvatarFeedData.Id => <SenderId>k__BackingField;

	string IAvatarFeedData.Name => <SenderName>k__BackingField;

	DateTime? IAvatarFeedData.AvatarDate => <SenderAvatarDate>k__BackingField;

	public override bool HasPreview => true;

	public override bool ForcedPreview => true;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<SenderName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0227: Expected O, but got I4
		//IL_006f: Expected I8, but got I4
		//IL_018f: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00cd: Expected I, but got O
		//IL_00dd: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		object obj = "AvailableVoices" + 3920;
		object obj2 = "SERVICE_DISABLED" + 1344;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		object key = ((<GiftType>k__BackingField != GiftsHandler.GiftType.Coins) ? obj2 : obj);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText((string)key, <Amount>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj7;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj8;
		if (array != null)
		{
			bool flag2 = text == null;
			obj7 = 1;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
				obj8 = 0;
				if (flag3)
				{
					goto IL_01aa;
				}
			}
			if (array.Length != 0)
			{
				object text2 = "getSecondRescanTask" + 1616;
				object obj9 = array + 32;
				obj9 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text2, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj7 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj8 = obj7;
		goto IL_01aa;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public override void ShowPreview(Action markSeen)
	{
		GiftsHandler.ShowGiftReceivedPopup(this);
		if (markSeen != null)
		{
			IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
			IntPtr method_code = ((Delegate)markSeen).method_code;
			IntPtr method = ((Delegate)markSeen).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v15 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
