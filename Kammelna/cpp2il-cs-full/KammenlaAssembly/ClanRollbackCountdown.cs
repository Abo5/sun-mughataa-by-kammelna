using System;
using System.Data;
using Cpp2ILInjected;
using TMPro;
using Unity.Properties;
using UnityEngine.Purchasing.Telemetry;

public static class ClanRollbackCountdown
{
	private const string COUNTDOWN_KEY = "clan_rollback_countdown";

	public static bool TryApply(TextMeshProUGUI label, DateTime expiresAtUtc)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0084: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I4
		//IL_01dd: Invalid comparison between F8 and I8
		//IL_03f4: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_0399: Expected I4, but got O
		//IL_0289: Expected I, but got O
		//IL_0299: Expected O, but got I
		//IL_02c2: Expected O, but got I
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		TimeSpan timeSpan = expiresAtUtc - utcNow;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+E4]");
		bool flag4;
		bool flag5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+B8]");
			object obj6 = 0;
			TimeSpan timeSpan2 = (TimeSpan)obj6;
			bool flag2 = timeSpan <= (TimeSpan)obj6;
			bool flag3 = !flag2;
			object obj7 = 0;
			flag4 = flag2;
			if (flag3)
			{
				goto IL_0159;
			}
			flag5 = flag2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v19+B8]");
			object obj9 = 0;
			TimeSpan timeSpan2 = (TimeSpan)obj9;
			bool flag6 = timeSpan <= (TimeSpan)obj9;
			bool flag7 = !flag6;
			object obj10 = !flag7;
			object obj7 = 0;
			flag4 = flag6;
			flag5 = flag6;
			if (obj10 == null)
			{
				goto IL_0159;
			}
		}
		goto IL_033c;
		IL_0159:
		object format = "utf-32" + 3496;
		object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v11+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan3 = default(TimeSpan);
		double totalHours = timeSpan3.TotalHours;
		if (totalHours == 9.218868437227405E+18)
		{
		}
		object obj14 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		int minutes = timeSpan3.Minutes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		int seconds = timeSpan3.Seconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		object arg3 = default(object);
		string text = string.Format((string)format, arg, arg2, arg3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj15;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj16;
		if (array != null)
		{
			bool flag9 = text == null;
			obj15 = 1;
			if (!flag9)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag10 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
				obj16 = 0;
				if (flag10)
				{
					goto IL_037c;
				}
			}
			if (array.Length != 0)
			{
				object obj17 = array + 32;
				obj17 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3928;
				TextMeshProExtensions.Localize(label, (string)text2, array);
				flag5 = flag4;
				goto IL_033c;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			obj15 = 1;
		}
		ex = new IndexOutOfRangeException();
		obj16 = obj15;
		goto IL_037c;
		IL_033c:
		return (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
		IL_037c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex3 = new OutOfMemoryException();
		return (byte)(int)ex3 != 0;
	}
}
