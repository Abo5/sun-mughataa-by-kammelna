using System;
using System.Data;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using Util;

[Serializable]
public class InstantFormat : DateTimeFormat
{
	public enum Format
	{
		DateAndTime,
		DateOnly,
		TimeOnly,
		DateAndTimeAndDayOfWeek
	}

	private Format format;

	private bool withSeconds;

	private readonly bool <IsCountDown>k__BackingField;

	public override bool IsCountDown => <IsCountDown>k__BackingField;

	protected override string FormatDate(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_0782: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_006b: Expected O, but got I4
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0648: Expected O, but got I4
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected O, but got Unknown
		//IL_0589: Expected O, but got I4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_052e: Expected O, but got I4
		//IL_0727: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05ed: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_029d: Expected O, but got I4
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_0301: Expected O, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_034e: Expected O, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 824;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)3072;
		string partOfDay = DateTimeUtil.GetPartOfDay(dateTime);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize(partOfDay);
		string text2 = (string)obj5 + text;
		DateTime dateTime2 = default(DateTime);
		object obj21;
		CultureInfo cultureInfo;
		if (format <= Format.DateOnly)
		{
			if (format != Format.DateAndTime)
			{
				if (format == Format.DateOnly)
				{
					object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v70+E4]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object obj11 = typeof(DataRelation) + 712;
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v74+E4]");
					bool flag4 = (nint)0 == 0;
					object obj13 = !flag4;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj14 = "utf-32" + 3016;
					return dateTime2.ToString((string)obj14, invariantCulture);
				}
				goto IL_06e5;
			}
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj16 = obj15;
			if (withSeconds)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v55+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				object obj18 = typeof(DataRelation) + 712;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v66+E4]");
				bool flag6 = (nint)0 == 0;
				object obj20 = !flag6;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj21 = "utf-32" + 3056;
				cultureInfo = invariantCulture2;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v55+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
				object obj23 = typeof(DataRelation) + 712;
				object obj24 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v59+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj21 = "utf-32" + 3040;
				cultureInfo = invariantCulture3;
			}
		}
		else
		{
			if (format != Format.TimeOnly)
			{
				if (format == Format.DateAndTimeAndDayOfWeek)
				{
					object obj26 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v38+E4]");
					bool flag9 = (nint)0 == 0;
					object obj27 = !flag9;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object separator = "{0} color encoding is currently unsupported for outputting to HDR." + 2176;
					string dayOfWeekTimeFormat = DateTimeUtil.GetDayOfWeekTimeFormat(dateTime, (string)separator, withSeconds);
					object obj28 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v42+E4]");
					bool flag10 = (nint)0 == 0;
					object obj30 = !flag10;
					if (obj30 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture4 = CultureInfo.InvariantCulture;
					object obj31 = typeof(DataRelation) + 712;
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v46+E4]");
					bool flag11 = (nint)0 == 0;
					object obj33 = !flag11;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj34 = "utf-32" + 3016;
					string text3 = dateTime2.ToString((string)obj34, invariantCulture4);
					object obj35 = (nint)0 + (nint)3488;
					return dayOfWeekTimeFormat + (string)obj35 + text3;
				}
				goto IL_06e5;
			}
			object obj36 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj37 = obj36;
			if (withSeconds)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v23+E4]");
				bool flag12 = (nint)0 == 0;
				object obj38 = !flag12;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture5 = CultureInfo.InvariantCulture;
				object obj39 = typeof(DataRelation) + 712;
				object obj40 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v34+E4]");
				bool flag13 = (nint)0 == 0;
				object obj41 = !flag13;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj21 = "getSecondRescanTask" + 2720;
				cultureInfo = invariantCulture5;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v23+E4]");
				bool flag14 = (nint)0 == 0;
				object obj42 = !flag14;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture6 = CultureInfo.InvariantCulture;
				object obj43 = typeof(DataRelation) + 712;
				object obj44 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v27+E4]");
				bool flag15 = (nint)0 == 0;
				object obj45 = !flag15;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj21 = "getSecondRescanTask" + 2696;
				cultureInfo = invariantCulture6;
			}
		}
		string text4 = dateTime2.ToString((string)obj21, cultureInfo);
		return text4 + text2;
		IL_06e5:
		object obj46 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj47 = (nint)0 + (nint)2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}
}
