using System;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using Util;

namespace Server.Models;

[Serializable]
public class MonthlyStatsReportFeedData : UserFeedData
{
	private PersonalizedStatReport <Report>k__BackingField;

	public PersonalizedStatReport Report
	{
		get
		{
			return <Report>k__BackingField;
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

	public MonthlyStatsReportFeedData()
	{
	}

	public MonthlyStatsReportFeedData(PersonalizedStatReport report)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = report;
		_ = 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override LocalizableText GetTitle()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00da: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		PersonalizedStatReport personalizedStatReport = <Report>k__BackingField;
		bool flag = <Report>k__BackingField == null;
		object obj2 = 1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj3 = typeof(DataRelation) + 824;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string monthName = DateTimeUtil.GetMonthName(personalizedStatReport.<Date>k__BackingField);
			object[] array = default(object[]);
			bool flag3 = array == null;
			obj2 = 0;
			if (!flag3)
			{
				bool flag4 = monthName == null;
				object obj6 = 0;
				if (!flag4)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					obj2 = 0;
					if (flag5)
					{
						goto IL_01ae;
					}
				}
				bool flag6 = array.Length == 0;
				obj2 = obj6;
				if (!flag6)
				{
					object text = "m_StencilDeferredPS" + 2368;
					object obj7 = array + 32;
					obj7 = monthName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeArguments((string)text, array);
				}
				goto IL_01a0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01a0;
		IL_01a0:
		ex = new IndexOutOfRangeException();
		goto IL_01ae;
		IL_01ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
	}

	public override LocalizableText GetDetails()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "m_StencilDeferredPS" + 2360;
		return TextMeshProExtensions.Localize((string)text);
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		while (true)
		{
			object obj2 = (nint)0 + (nint)192;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			if (obj5 != null)
			{
				((PersonalizedStatsManager)obj5).FetchConfigsThenShowReport(<Report>k__BackingField);
				bool flag2 = markSeen == null;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					break;
				}
			}
			else
			{
				object obj7 = typeof(DataRelation) + 856;
				object message = "October" + 3856;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v9+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message);
				if (markSeen == null)
				{
					break;
				}
			}
			IntPtr invoke_impl = ((Delegate)markSeen).invoke_impl;
			IntPtr method_code = ((Delegate)markSeen).method_code;
			IntPtr method = ((Delegate)markSeen).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
