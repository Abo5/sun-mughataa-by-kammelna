using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class ClanJoinedUserFeedData : UserFeedData, IClanFeedData
{
	private int <ClanId>k__BackingField;

	private string <ClanName>k__BackingField;

	public int ClanId
	{
		get
		{
			return <ClanId>k__BackingField;
		}
		set
		{
			<ClanId>k__BackingField = value;
		}
	}

	public string ClanName
	{
		get
		{
			return <ClanName>k__BackingField;
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

	public override bool HasPreview => true;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<ClanName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj3;
		if (array != null)
		{
			bool flag = <ClanName>k__BackingField == null;
			obj2 = 1;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v7 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				if (flag2)
				{
					goto IL_0128;
				}
			}
			if (array.Length != 0)
			{
				object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3688;
				object obj4 = array + 32;
				obj4 = <ClanName>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj2 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj3 = obj2;
		goto IL_0128;
		IL_0128:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BDB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00e8;
		}
		int clanId = <ClanId>k__BackingField;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		int clanId2 = <ClanId>k__BackingField;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_013a;
		IL_013a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ClanCardPopup.Show(clanId2);
		bool flag2 = markSeen == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_0091:
		ClanCardPopup.Show(clanId);
		if (markSeen != null)
		{
			goto IL_00b7;
		}
		return;
		IL_00b7:
		IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
		IntPtr method_code = ((Delegate)markSeen).method_code;
		IntPtr method = ((Delegate)markSeen).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00e8;
		IL_00e8:
		_ = 1;
		clanId = <ClanId>k__BackingField;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		clanId2 = <ClanId>k__BackingField;
		if (obj6 != null)
		{
			goto IL_0091;
		}
		goto IL_013a;
	}
}
