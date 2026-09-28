using System;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UI.Popups.Chat;
using Unity.Properties;
using Unity.Services.Authentication.Shared;

namespace Server.Models;

[Serializable]
public class BombClaimedFeedData : UserFeedData, IAvatarFeedData
{
	private long <SenderId>k__BackingField;

	private DateTime? <SenderAvatarDate>k__BackingField;

	private string <SenderName>k__BackingField;

	private GiftBombType <BombType>k__BackingField;

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

	public GiftBombType BombType
	{
		get
		{
			return <BombType>k__BackingField;
		}
		set
		{
			<BombType>k__BackingField = value;
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
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "AvailableVoices" + 2384;
		return TextMeshProExtensions.Localize((string)text);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I4
		//IL_006f: Expected I8, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00cd: Expected I, but got O
		//IL_00dd: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I8
		//IL_0182: Expected I, but got O
		//IL_0192: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		object obj = "AvailableVoices" + 3920;
		object obj2 = "SERVICE_DISABLED" + 1344;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
		object key = ((<BombType>k__BackingField != GiftBombType.Currency) ? obj2 : obj);
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
		if (array != null)
		{
			bool flag2 = text == null;
			string text2 = (string)2;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text3;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				if (flag3)
				{
					goto IL_025c;
				}
			}
			if (array.Length != 0)
			{
				object obj7 = array + 32;
				obj7 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag4 = <SenderName>k__BackingField == null;
				text2 = text;
				if (!flag4)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag5)
					{
						goto IL_025c;
					}
				}
				object obj8 = array.Length & 0xFFFFFFFEL;
				if (obj8 != null)
				{
					object text4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 720;
					object obj9 = array + 40;
					obj9 = <SenderName>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text4, array);
				}
			}
			ex = new IndexOutOfRangeException();
			text3 = text2;
			goto IL_025c;
		}
		goto IL_0274;
		IL_025c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0274;
		IL_0274:
		return (LocalizableText)(object)new NullReferenceException();
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I4
		//IL_0021: Expected O, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		if (<BombType>k__BackingField != GiftBombType.Subscription)
		{
			bool flag = <BombType>k__BackingField == GiftBombType.Currency;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0168;
			}
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3648;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CurrencyBombSuccessfullyClaimedPopup.Show(this);
			bool flag3 = markSeen == null;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				return;
			}
		}
		else
		{
			object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2976;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SubBombNotifyClientPopup.InitializePopup(this);
			if (markSeen == null)
			{
				return;
			}
		}
		IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
		IntPtr method_code = ((Delegate)markSeen).method_code;
		IntPtr method = ((Delegate)markSeen).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0168;
		IL_0168:
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj10 = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
