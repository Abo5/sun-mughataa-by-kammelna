using System;
using System.Data;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class DateTimeCondition
{
	public enum Relativity
	{
		Past,
		Future
	}

	public int amount;

	public DateTimeUnit unit;

	public Relativity relativity;

	public bool IsSatisfied(DateTime dateTime)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_0021: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_01cc: Expected I4, but got O
		if (relativity != Relativity.Future)
		{
			bool flag = relativity == Relativity.Past;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = typeof(DataRelation) + 712;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v22+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				TimeSpan duration = GetDuration();
				DateTime dateTime2 = now - duration;
				return dateTime <= dateTime2;
			}
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj6 = (nint)0 + (nint)4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (byte)(int)ex2 != 0;
		}
		object obj7 = typeof(DataRelation) + 712;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		TimeSpan duration2 = GetDuration();
		DateTime dateTime3 = now2 + duration2;
		return dateTime >= dateTime3;
	}

	private TimeSpan GetDuration()
	{
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_039b: Expected F8, but got I4
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I4
		//IL_0337: Expected F8, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0355: Expected F8, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I4
		//IL_0263: Expected F8, but got I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0378: Expected F8, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_0180: Expected F8, but got I4
		//IL_00cb: Expected F8, but got I4
		if (unit <= DateTimeUnit.Days)
		{
			if (unit == DateTimeUnit.Years)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v29+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double value = (double)amount * 365.0;
				return TimeSpan.FromDays(value);
			}
			if (unit == DateTimeUnit.Months)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num = amount << 5;
				double value2 = (double)num - (double)amount;
				return TimeSpan.FromDays(value2);
			}
			if (unit == DateTimeUnit.Days)
			{
				object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v39+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return TimeSpan.FromDays(amount);
			}
		}
		else
		{
			if (unit == DateTimeUnit.Hours)
			{
				object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					return TimeSpan.FromHours(amount);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return TimeSpan.FromHours(amount);
			}
			if (unit == DateTimeUnit.Minutes)
			{
				object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					return TimeSpan.FromMinutes(amount);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return TimeSpan.FromMinutes(amount);
			}
			if (unit == DateTimeUnit.Seconds)
			{
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					return TimeSpan.FromSeconds(amount);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return TimeSpan.FromSeconds(amount);
			}
		}
		object obj16 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj17 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (TimeSpan)new OutOfMemoryException();
	}
}
