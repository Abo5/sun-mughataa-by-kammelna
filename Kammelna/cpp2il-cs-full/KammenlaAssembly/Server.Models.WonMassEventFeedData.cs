using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

namespace Server.Models;

public class WonMassEventFeedData : UserFeedData
{
	private long <EventId>k__BackingField;

	private int <Place>k__BackingField;

	private string <EventName>k__BackingField;

	private string <PrizeDescription>k__BackingField;

	public long EventId
	{
		get
		{
			return <EventId>k__BackingField;
		}
		set
		{
			<EventId>k__BackingField = value;
		}
	}

	public int Place
	{
		get
		{
			return <Place>k__BackingField;
		}
		set
		{
			<Place>k__BackingField = value;
		}
	}

	public string EventName
	{
		get
		{
			return <EventName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string PrizeDescription
	{
		get
		{
			return <PrizeDescription>k__BackingField;
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

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<EventName>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0297: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I8
		//IL_014a: Expected I, but got O
		//IL_015a: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key = "Network Authentication Required" + 3288;
		object obj2 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string ordinalText = LocalizationText.GetOrdinalText((string)key, <Place>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag2 = ordinalText == null;
			string text = (string)2;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			string text2;
			if (!flag2)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag3)
				{
					goto IL_0224;
				}
			}
			if (array.Length != 0)
			{
				object obj5 = array + 32;
				obj5 = ordinalText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag4 = <PrizeDescription>k__BackingField == null;
				text = ordinalText;
				if (!flag4)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					if (flag5)
					{
						goto IL_0224;
					}
				}
				object obj6 = array.Length & 0xFFFFFFFEL;
				if (obj6 != null)
				{
					object text3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 80;
					object obj7 = array + 40;
					obj7 = <PrizeDescription>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeWith((string)text3, array);
				}
			}
			ex = new IndexOutOfRangeException();
			text2 = text;
			goto IL_0224;
		}
		goto IL_023c;
		IL_023c:
		return (LocalizableText)(object)new NullReferenceException();
		IL_0224:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_023c;
	}

	public override void ShowPreview(Action markSeen)
	{
		if (markSeen != null)
		{
			IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
			IntPtr method_code = ((Delegate)markSeen).method_code;
			IntPtr method = ((Delegate)markSeen).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
