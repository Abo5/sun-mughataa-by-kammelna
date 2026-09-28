using System;
using Cpp2ILInjected;
using Unity.Properties;

namespace Server.Models;

[Serializable]
public class ClanArchivedUserFeedData : UserFeedData, IClanFeedData
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
				object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3480;
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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
