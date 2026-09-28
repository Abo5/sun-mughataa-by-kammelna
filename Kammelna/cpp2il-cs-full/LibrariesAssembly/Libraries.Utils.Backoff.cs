using System;
using System.Data;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

namespace Libraries.Utils;

public static class Backoff
{
	public const float BASE_DELAY = 1f;

	public const float MAX_DELAY = 30f;

	public static float ResolveDelay(int attempt, string retryAfterHeader = null)
	{
		if (TryParseRetryAfter(retryAfterHeader, out var seconds))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
			return seconds;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB16B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
		float num = UnityEngine.Random.Range(0.5f, 1.5f);
		object obj = default(object);
		return (float)obj * num;
	}

	public unsafe static bool TryParseRetryAfter(string value, out float seconds)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_00bd: Invalid comparison between F4 and I4
		//IL_00da: Expected O, but got F4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0216: Expected O, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0290: Expected O, but got I4
		//IL_02c2: Expected Ref, but got F8
		//IL_02cb: Invalid comparison between F8 and I4
		//IL_02da: Invalid comparison between F8 and I4
		//IL_02ed: Expected O, but got F8
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0322: Expected O, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected I4, but got Unknown
		ref float reference = ref *(float*)null;
		bool flag;
		if (string.IsNullOrEmpty(value))
		{
			flag = false;
		}
		else
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (float.TryParse(value, NumberStyles.Float, invariantCulture, out seconds))
			{
				bool flag3 = seconds < 0f;
				object obj4 = seconds ^ seconds;
				object obj5 = seconds & obj4;
				bool flag4 = (nint)obj5 < 0;
				return flag3 == flag4;
			}
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v11+E4]");
			bool flag5 = (nint)0 == 0;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			object obj8 = typeof(DataRelation) + 712;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			flag = DateTime.TryParse(value, invariantCulture2, DateTimeStyles.AdjustToUniversal, out var result);
			if (flag)
			{
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v19+E4]");
				bool flag7 = (nint)0 == 0;
				object obj12 = !flag7;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan timeSpan = result - utcNow;
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v25+E4]");
				bool flag8 = (nint)0 == 0;
				object obj15 = !flag8;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan2 = default(TimeSpan);
				double totalSeconds = timeSpan2.TotalSeconds;
				reference = ref *(float*)totalSeconds;
				bool flag9 = totalSeconds < 0.0;
				bool flag10 = totalSeconds == 0.0;
				object obj16 = totalSeconds ^ totalSeconds;
				object obj17 = totalSeconds & obj16;
				bool flag11 = (nint)obj17 < 0;
				bool flag12 = flag9 == flag11;
				object obj18 = !flag10;
				return (byte)((flag12 & obj18) ? 1 : 0) != 0;
			}
		}
		return flag;
	}
}
