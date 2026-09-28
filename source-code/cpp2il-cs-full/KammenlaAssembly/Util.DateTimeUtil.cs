using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

namespace Util;

public static class DateTimeUtil
{
	private static readonly DateTime Epoch;

	public unsafe static DateTime FromTimeStamp(double unixTimeStamp)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8571]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00c6;
		}
		goto IL_019a;
		IL_00c6:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v8+B8]");
		DateTime dateTime = ((DateTime*)null)->AddSeconds(unixTimeStamp);
		DateTime dateTime2 = default(DateTime);
		return dateTime2.ToLocalTime();
		IL_019a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00c6;
		IL_0099:
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00c6;
		}
		goto IL_019a;
	}

	public static long ToUniversalTimestamp(DateTime dateTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8572]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(DataRelation) + 824;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(DataRelation) + 824;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime2 = dateTime3.ToUniversalTime();
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = 0;
		DateTime date = dateTime2;
		if (obj9 != null)
		{
			goto IL_00e5;
		}
		goto IL_01b7;
		IL_00e5:
		return ToTimestamp(dateTime2);
		IL_01b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return ToTimestamp(date);
		IL_0099:
		dateTime2 = dateTime3.ToUniversalTime();
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = 0;
		date = dateTime2;
		if (!flag4)
		{
			goto IL_00e5;
		}
		goto IL_01b7;
	}

	public static long ToEpochMilli(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_00c1: Invalid comparison between F8 and I8
		//IL_00f2: Expected I8, but got F8
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(DataRelation) + 824;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime2 = dateTime3.ToUniversalTime();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+B8]");
		object obj8 = 0;
		TimeSpan timeSpan = dateTime2 - (DateTime)obj8;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalMilliseconds = timeSpan2.TotalMilliseconds;
		if (totalMilliseconds == 9.218868437227405E+18)
		{
			return -9223372036854775808L;
		}
		return (long)totalMilliseconds;
	}

	public static long ToTimestamp(DateTime date)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0125: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015c: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_00b1: Invalid comparison between F8 and I8
		//IL_00e2: Expected I8, but got F8
		object obj = typeof(DataRelation) + 824;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+B8]");
		object obj6 = 0;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = date - (DateTime)obj6;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		if (totalSeconds == 9.218868437227405E+18)
		{
			return -9223372036854775808L;
		}
		return (long)totalSeconds;
	}

	public static DateTime NextMidnight()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today = DateTime.Today;
		DateTime dateTime = default(DateTime);
		return dateTime.AddDays(1.0);
	}

	public static string GetPartOfDay(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		object obj = typeof(DataRelation) + 824;
		object result = "Material with texture name \"" + 2624;
		object result2 = "Error reading data from socket: " + 584;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = IsAM(dateTime);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return (string)result;
		}
		return (string)result2;
	}

	private static bool IsAM(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0079: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 792;
		object obj6 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2544;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = default(DateTime);
		string text = dateTime2.ToString((string)obj5, invariantCulture);
		return text == (string)obj6;
	}

	public unsafe static string GetDayOfWeekTimeFormat(DateTime dateTime, string separator = "، ", bool withSeconds = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0108: Expected O, but got Ref
		//IL_0115: Expected O, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0176: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_0203: Expected O, but got I4
		//IL_0379: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0491: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		//IL_0328: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		DateTime dateTime2 = default(DateTime);
		DateTime date = dateTime2.Date;
		DateTime today = DateTime.Today;
		string input;
		if (date == today)
		{
			object obj5 = "ThisIsFakeReceiptData" + 544;
			input = (string)obj5;
			DateTime dateTime3 = today;
		}
		else
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v53+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DayOfWeek dayOfWeek = dateTime2.DayOfWeek;
			object obj8 = default(object);
			input = ((Enum)(&obj8)).ToString();
			DateTime dateTime3 = (DateTime)0;
		}
		object obj9 = "getSecondRescanTask" + 2728;
		object obj10 = "getSecondRescanTask" + 2704;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize(input);
		bool flag4 = !withSeconds;
		object obj14 = !flag4;
		object obj15 = ~obj14;
		object obj16 = ((obj15 != null) ? obj10 : obj9);
		object obj17 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj19 = typeof(DataRelation) + 824;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v17+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = dateTime2.ToString((string)obj16, invariantCulture);
		object obj22 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E859B]");
			object obj23 = (nint)0 & (nint)1;
			bool flag7 = obj23 == null;
			object obj24 = !flag7;
			if (obj24 == null)
			{
				goto IL_02a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E859B]");
			object obj25 = (nint)0 & (nint)1;
			if (obj25 == null)
			{
				goto IL_02a0;
			}
		}
		goto IL_0449;
		IL_02a0:
		_ = 1;
		goto IL_0449;
		IL_0449:
		object obj26 = "Material with texture name \"" + 2624;
		object obj27 = "Error reading data from socket: " + 584;
		object obj28 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v23+E4]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = IsAM(dateTime2);
		object obj30 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v27+E4]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag11 = !flag9;
		object obj32 = !flag11;
		object obj33 = ~obj32;
		string input2 = (string)((obj33 != null) ? obj27 : obj26);
		string text3 = LocalizationUtil.Localize(input2);
		return text + separator + text2 + text3;
	}

	public static string GetDurationText(TimeSpan timeSpan, int activeUnits = 2, DateTimeUnit minUnit = DateTimeUnit.Minutes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TextCountdownFormat textCountdownFormat = default(TextCountdownFormat);
		textCountdownFormat..ctor(activeUnits, minUnit);
		if (textCountdownFormat != null)
		{
			return textCountdownFormat.Format(timeSpan);
		}
		return (string)(object)new NullReferenceException();
	}

	public static string AmPmTime(TimeSpan time, bool shortWords)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04a1: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_04be: Expected O, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected I4, but got Unknown
		//IL_051d: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_013b: Expected O, but got I8
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_022c: Expected O, but got I8
		//IL_0255: Expected O, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0369: Expected O, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_03e2: Expected O, but got I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_05a7: Expected O, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj2 = ", stale={0}" + 3536;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(SqlSingle[]) + 32;
		TimeSpan timeSpan = default(TimeSpan);
		int hours = timeSpan.Hours;
		int num = ((hours != 0) ? hours : 12);
		object obj6 = num - 13;
		bool flag2 = (nint)obj6 < 0;
		int num2 = num ^ 0xD;
		int num3 = num ^ obj6;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag2 == flag3;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
		}
		int num5 = default(int);
		string text = num5.ToString((string)obj2);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int minutes = timeSpan.Minutes;
		int num6 = default(int);
		string text2 = num6.ToString((string)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		string input;
		string text3;
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj11 = array + 32;
				obj11 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X23_v6-8]");
				object obj12 = 0 & 0xFFFFFFFEL;
				if (obj12 != null)
				{
					object obj13 = "1.2.840.113549.1.12.1.5" + 1488;
					object obj14 = array + 40;
					obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X21_v6-10]");
					bool flag6 = (nint)0 < (nint)2;
					object obj15 = !flag6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X21_v6-10]");
					object obj16 = -2;
					bool flag7 = obj16 == null;
					object obj17 = ~obj15;
					object obj18 = obj17 | flag7;
					if (obj18 == null)
					{
						object obj19 = array + 48;
						obj19 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X21_v8-18]");
						object obj20 = 0 & 0xFFFFFFFCL;
						if (obj20 != null)
						{
							object obj21 = (nint)0 + (nint)3072;
							object obj22 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj23 = array + 56;
							obj23 = obj21;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							int hours2 = timeSpan.Hours;
							object obj24 = obj22;
							if (hours2 < 12)
							{
								object obj25 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2544;
								object obj26 = "Material with texture name \"" + 2624;
								bool flag8 = !shortWords;
								object obj27 = !flag8;
								object obj28 = ~obj27;
								if (obj28 != null)
								{
									obj25 = obj26;
								}
								input = (string)obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v31+E4]");
								bool flag9 = (nint)0 == 0;
								object obj29 = !flag9;
								if (obj29 == null)
								{
									text3 = (string)obj25;
									goto IL_0392;
								}
							}
							else
							{
								object obj30 = "October" + 2088;
								object obj31 = "Error reading data from socket: " + 584;
								bool flag10 = !shortWords;
								object obj32 = !flag10;
								object obj33 = ~obj32;
								if (obj33 != null)
								{
									obj30 = obj31;
								}
								text3 = (string)obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v31+E4]");
								bool flag11 = (nint)0 == 0;
								object obj34 = !flag11;
								input = (string)obj30;
								if (obj34 == null)
								{
									goto IL_0392;
								}
							}
							goto IL_03a9;
						}
					}
				}
			}
			goto IL_044c;
		}
		goto IL_045a;
		IL_03a9:
		string text4 = LocalizationUtil.Localize(input);
		bool flag12 = array.Length < 4;
		object obj35 = !flag12;
		object obj36 = array.Length - 4;
		bool flag13 = obj36 == null;
		object obj37 = ~obj35;
		object obj38 = obj37 | flag13;
		if (obj38 == null)
		{
			object obj39 = array + 64;
			obj39 = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return string.Concat(array);
		}
		goto IL_044c;
		IL_044c:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_045a;
		IL_0392:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		input = text3;
		goto IL_03a9;
		IL_045a:
		return (string)(object)new NullReferenceException();
	}

	public static DateTime Max(DateTime dateTime1, DateTime dateTime2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime3 = default(DateTime);
		bool flag2 = dateTime3 > dateTime2;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
		}
		return dateTime2;
	}

	public static DateTime Min(DateTime dateTime1, DateTime dateTime2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0053: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime3 = default(DateTime);
		bool flag2 = dateTime3 < dateTime2;
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
		}
		return dateTime2;
	}

	public static int GetAmountForUnit(TimeSpan timeLeft, DateTimeUnit unit)
	{
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03cb: Expected O, but got I4
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0316: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_0352: Expected O, but got I8
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0388: Expected I4, but got O
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_0490: Expected O, but got I
		//IL_0259: Expected I4, but got I8
		//IL_00d7: Expected F8, but got I
		//IL_00e8: Expected O, but got I4
		//IL_04ad: Expected I4, but got O
		TimeSpan timeSpan = default(TimeSpan);
		int num2;
		switch (unit)
		{
		case DateTimeUnit.Days:
		{
			object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v50+E4]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int days2 = timeSpan.Days;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253580]");
			double num3 = 0.0;
			num2 = days2;
			object obj24 = 0;
			break;
		}
		case DateTimeUnit.Seconds:
		{
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return timeSpan.Seconds;
		}
		case DateTimeUnit.Months:
		{
			object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v45+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int days2 = timeSpan.Days;
			int num = days2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253580]");
			num2 = (int)((nint)num / (nint)0);
			double num3 = 8.000000000931323;
			object obj24 = 0;
			break;
		}
		case DateTimeUnit.Minutes:
		{
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return timeSpan.Minutes;
		}
		case DateTimeUnit.Years:
		{
			object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v34+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int days = timeSpan.Days;
			object obj17 = days * 3012360625L;
			object obj18 = obj17 >> 32;
			object obj19 = obj18 + days;
			object obj20 = obj19 >> 8;
			return (int)(obj20 + obj19);
		}
		case DateTimeUnit.Hours:
		{
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return timeSpan.Hours;
		}
		default:
		{
			object obj = typeof(DataRelation) + 816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (int)ex2;
		}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB1360");
		if (num2 == 9218868437227405312L)
		{
			return -2147483648;
		}
		return num2;
	}

	public static string GetMonthName(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00df: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = "LAK" + 2976;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = default(DateTime);
		return dateTime2.ToString((string)obj5, invariantCulture);
	}

	static DateTimeUtil()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		object obj = typeof(DataRelation) + 824;
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = dateTime;
	}
}
