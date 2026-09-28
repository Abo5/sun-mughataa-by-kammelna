using System;
using Cpp2ILInjected;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class ClanInviteReceivedUserFeedData : UserFeedData, IAvatarFeedData, IClanFeedData
{
	private int <ClanId>k__BackingField;

	private string <ClanName>k__BackingField;

	private int <ClanTier>k__BackingField;

	private long <InviterId>k__BackingField;

	private DateTime? <InviterAvatarDate>k__BackingField;

	private string <InviterName>k__BackingField;

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

	public int ClanTier
	{
		get
		{
			return <ClanTier>k__BackingField;
		}
		set
		{
			<ClanTier>k__BackingField = value;
		}
	}

	public long InviterId
	{
		get
		{
			return <InviterId>k__BackingField;
		}
		set
		{
			<InviterId>k__BackingField = value;
		}
	}

	public DateTime? InviterAvatarDate
	{
		get
		{
			return <InviterAvatarDate>k__BackingField;
		}
		set
		{
			<InviterAvatarDate>k__BackingField = value;
		}
	}

	public string InviterName
	{
		get
		{
			return <InviterName>k__BackingField;
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

	long IAvatarFeedData.Id => <InviterId>k__BackingField;

	string IAvatarFeedData.Name => <InviterName>k__BackingField;

	DateTime? IAvatarFeedData.AvatarDate => <InviterAvatarDate>k__BackingField;

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<ClanName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_015d: Expected O, but got I8
		//IL_0102: Expected I, but got O
		//IL_0112: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag = <InviterName>k__BackingField == null;
			string text = (string)2;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (!flag)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag2 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag2)
				{
					goto IL_01dc;
				}
			}
			if (array.Length != 0)
			{
				object obj2 = array + 32;
				obj2 = <InviterName>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = <ClanName>k__BackingField == null;
				text = <InviterName>k__BackingField;
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag4)
					{
						goto IL_01dc;
					}
				}
				object obj3 = array.Length & 0xFFFFFFFEL;
				if (obj3 != null)
				{
					object text3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3640;
					object obj4 = array + 40;
					obj4 = <ClanName>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text3, array);
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_01dc;
		}
		goto IL_01f4;
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_01f4;
		IL_01f4:
		return (LocalizableText)(object)new NullReferenceException();
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
