using System;
using System.Data;
using Cpp2ILInjected;
using Unity.Properties;
using Util;

namespace Server.Models;

[Serializable]
public class QualifiedForTournamentFeedData : UserFeedData
{
	private string <TournamentName>k__BackingField;

	private DateTime <StartTime>k__BackingField;

	public string TournamentName
	{
		get
		{
			return <TournamentName>k__BackingField;
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

	public DateTime StartTime
	{
		get
		{
			return <StartTime>k__BackingField;
		}
		set
		{
			<StartTime>k__BackingField = value;
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
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
			bool flag = <TournamentName>k__BackingField == null;
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
				object text = "tournament_participate_warning_body_with_tickets_warning_daily" + 48;
				object obj4 = array + 32;
				obj4 = <TournamentName>k__BackingField;
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

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0084: Expected O, but got I4
		//IL_009a: Expected I, but got O
		//IL_00aa: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 824;
		object separator = "{0} color encoding is currently unsupported for outputting to HDR." + 2176;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string dayOfWeekTimeFormat = DateTimeUtil.GetDayOfWeekTimeFormat(<StartTime>k__BackingField, (string)separator);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj5;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj6;
		if (array != null)
		{
			bool flag2 = dayOfWeekTimeFormat == null;
			obj5 = 1;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<System.Object[]>)+40]");
				obj6 = 0;
				if (flag3)
				{
					goto IL_0177;
				}
			}
			if (array.Length != 0)
			{
				object text = "tournament_participate_warning_body_with_tickets_warning_daily" + 40;
				object obj7 = array + 32;
				obj7 = dayOfWeekTimeFormat;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return TextMeshProExtensions.LocalizeWith((string)text, array);
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj5 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj6 = obj5;
		goto IL_0177;
		IL_0177:
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
		object obj2 = (nint)0 + (nint)784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
