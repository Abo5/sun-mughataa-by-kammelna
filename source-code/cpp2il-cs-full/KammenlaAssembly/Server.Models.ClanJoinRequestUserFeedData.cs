using System;
using System.Threading;
using Cpp2ILInjected;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class ClanJoinRequestUserFeedData : UserFeedData, IAvatarFeedData, IClanFeedData
{
	private long <RequesterId>k__BackingField;

	private DateTime? <RequesterAvatarDate>k__BackingField;

	private string <RequesterName>k__BackingField;

	private int <ClanId>k__BackingField;

	public long RequesterId
	{
		get
		{
			return <RequesterId>k__BackingField;
		}
		set
		{
			<RequesterId>k__BackingField = value;
		}
	}

	public DateTime? RequesterAvatarDate
	{
		get
		{
			return <RequesterAvatarDate>k__BackingField;
		}
		set
		{
			<RequesterAvatarDate>k__BackingField = value;
		}
	}

	public string RequesterName
	{
		get
		{
			return <RequesterName>k__BackingField;
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

	long IAvatarFeedData.Id => <RequesterId>k__BackingField;

	string IAvatarFeedData.Name => <RequesterName>k__BackingField;

	DateTime? IAvatarFeedData.AvatarDate => <RequesterAvatarDate>k__BackingField;

	public override bool HasPreview => true;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<RequesterName>k__BackingField);
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
			bool flag = <RequesterName>k__BackingField == null;
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
				object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3664;
				object obj4 = array + 32;
				obj4 = <RequesterName>k__BackingField;
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
		//IL_0106: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BDD]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00d6;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			goto IL_007d;
		}
		goto IL_0114;
		IL_0114:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RoutingManager.TriggerRoute(RoutingCommand.ClanJoinRequest, null);
		bool flag = markSeen == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00a5;
		IL_007d:
		RoutingManager.TriggerRoute(RoutingCommand.ClanJoinRequest, null);
		if (markSeen != null)
		{
			goto IL_00a5;
		}
		return;
		IL_00a5:
		IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
		IntPtr method_code = ((Delegate)markSeen).method_code;
		IntPtr method = ((Delegate)markSeen).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v4 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_00d6;
		IL_00d6:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_007d;
		}
		goto IL_0114;
	}
}
