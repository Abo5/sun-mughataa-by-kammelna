using System;
using System.Data;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class DigitalContDownFormat : DateTimeFormat
{
	public enum Format
	{
		HoursMinutesSeconds,
		HoursMinutes,
		MinutesSeconds
	}

	private const string PocketCalculatorFont = "PocketCalculator SDF";

	public bool OverrideFont = true;

	private Format format;

	private readonly bool <IsCountDown>k__BackingField = true;

	public override bool IsCountDown => <IsCountDown>k__BackingField;

	protected override string FormatDate(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_01c9: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0243: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		TimeSpan timeLeft = timeSpan2.Duration();
		string text = GetFormattedString(timeLeft);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v14+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag3 = StringsExtensions.IsNullOrEmpty(template);
			bool flag4 = !flag3;
			obj9 = 0;
			if (!flag4)
			{
				goto IL_0124;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringsExtensions.IsNullOrEmpty(template);
			bool flag6 = !flag5;
			object obj10 = !flag6;
			obj9 = 0;
			if (obj10 != null)
			{
				goto IL_0124;
			}
		}
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v22+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		string value = text;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = text;
		}
		text = StringsExtensions.Reverse(value);
		bool flag8 = !OverrideFont;
		obj9 = 0;
		string content = text;
		if (flag8)
		{
			goto IL_014b;
		}
		goto IL_01f6;
		IL_0124:
		bool flag9 = OverrideFont;
		content = text;
		if (!flag9)
		{
			goto IL_014b;
		}
		goto IL_01f6;
		IL_01f6:
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object font = "Picking audio files is not supported on iOS" + 648;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v9+E4]");
		bool flag10 = (nint)0 == 0;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return StringUtil.Font(content, (string)font);
		IL_014b:
		return text;
	}

	private string GetFormattedString(TimeSpan timeLeft)
	{
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		object obj6;
		object obj8;
		if (format != Format.MinutesSeconds)
		{
			if (format != Format.HoursMinutes)
			{
				bool flag = format == Format.HoursMinutesSeconds;
				object obj = !flag;
				if (obj != null)
				{
					object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj3 = (nint)0 + (nint)3368;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (string)(object)new OutOfMemoryException();
				}
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj5 = obj4;
				obj6 = "getSecondRescanTask" + 2760;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					obj8 = obj6;
					goto IL_0119;
				}
			}
			else
			{
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj5 = obj9;
				obj8 = "getSecondRescanTask" + 2752;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v6+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				obj6 = obj8;
				if (obj10 == null)
				{
					goto IL_0119;
				}
			}
		}
		else
		{
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj5 = obj11;
			obj6 = "m_StencilDeferredPS" + 2120;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				obj8 = obj6;
				goto IL_0119;
			}
		}
		goto IL_0130;
		IL_0119:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj8;
		goto IL_0130;
		IL_0130:
		TimeSpan timeSpan = default(TimeSpan);
		return timeSpan.ToString((string)obj6);
	}
}
