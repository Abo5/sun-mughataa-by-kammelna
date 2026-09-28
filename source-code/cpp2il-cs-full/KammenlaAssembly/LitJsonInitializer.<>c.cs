using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using Util.JsonConvertors;

public static class LitJsonInitializer
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static ImporterFunc<string, TimeSpan> <>9__0_0;

		public static ExporterFunc<TimeSpan> <>9__0_1;

		public static ImporterFunc<string, Games> <>9__0_2;

		public static ImporterFunc<string, Color> <>9__0_3;

		public static ExporterFunc<Color> <>9__0_4;

		public static ExporterFunc<PlayerRank> <>9__0_5;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TimeSpan <RegisterImporters>b__0_0(string input)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00af: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0080: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan result;
			bool flag2 = TimeSpan.TryParse(input, out result);
			bool flag3 = !flag2;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				return result;
			}
			return (TimeSpan)0;
		}

		internal void <RegisterImporters>b__0_1(TimeSpan timeSpan, JsonWriter writer)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00cd: Expected O, but got I4
			//IL_0111: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F26]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TimeSpan timeSpan2 = default(TimeSpan);
			string str = timeSpan2.ToString();
			bool flag2 = writer == null;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_008f;
			IL_007d:
			str = timeSpan2.ToString();
			goto IL_008f;
			IL_008f:
			writer.Write(str);
		}

		internal Games <RegisterImporters>b__0_2(string s)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Expected O, but got I4
			//IL_002e: Expected O, but got I
			//IL_01b0: Expected O, but got I4
			//IL_01c0: Expected O, but got I
			//IL_01e2: Expected O, but got I4
			//IL_00c4: Expected O, but got I
			//IL_00e4: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0072: Expected O, but got I
			//IL_02a7: Expected O, but got I4
			//IL_02b0: Expected O, but got I4
			//IL_0123: Expected O, but got I4
			//IL_022c: Expected O, but got I
			//IL_024e: Expected O, but got I4
			//IL_0257: Expected O, but got I4
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_0155: Expected I, but got O
			//IL_02da: Expected I4, but got O
			//IL_0193: Expected I4, but got O
			object obj = 152981504;
			object obj2 = 147423232 + 3744;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F27]");
			object obj3 = (nint)0 & (nint)1;
			RuntimeTypeHandle handle;
			RuntimeTypeHandle handle2;
			if (obj3 != null)
			{
				handle = (RuntimeTypeHandle)obj2;
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v12+E0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				handle2 = (RuntimeTypeHandle)obj2;
				if (!flag)
				{
					goto IL_00a7;
				}
			}
			else
			{
				_ = 1;
				handle = (RuntimeTypeHandle)obj2;
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v12+E0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				handle2 = (RuntimeTypeHandle)obj2;
				if (obj7 != null)
				{
					goto IL_00a7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Type typeFromHandle = Type.GetTypeFromHandle(handle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X21_v6+98]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = 0;
			Type enumType = typeFromHandle;
			if (obj9 != null)
			{
				goto IL_00fa;
			}
			goto IL_026d;
			IL_02cc:
			InvalidCastException ex = new InvalidCastException();
			return (Games)ex;
			IL_0131:
			object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
			object obj12 = obj11;
			object obj13;
			nint num = (nint)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v12 (Il2CppClass<System.Object>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X1_v7+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj14 = default(object);
				return (Games)obj14;
			}
			goto IL_02cc;
			IL_02be:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_02cc;
			IL_00a7:
			typeFromHandle = Type.GetTypeFromHandle(handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v12+98]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = 0;
			enumType = typeFromHandle;
			if (!flag4)
			{
				goto IL_00fa;
			}
			goto IL_026d;
			IL_026d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = Enum.Parse(enumType, s);
			bool flag5 = obj13 == null;
			object obj15 = !flag5;
			object obj16 = 0;
			if (obj15 != null)
			{
				goto IL_0131;
			}
			goto IL_02be;
			IL_00fa:
			obj13 = Enum.Parse(typeFromHandle, s);
			bool flag6 = obj13 == null;
			obj16 = 0;
			if (!flag6)
			{
				goto IL_0131;
			}
			goto IL_02be;
		}

		internal Color <RegisterImporters>b__0_3(string s)
		{
			return (Color)ColorConverter.FromHtmlColor(s);
		}

		internal void <RegisterImporters>b__0_4(Color color, JsonWriter writer)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
			Color color2 = default(Color);
			string text = ColorUtility.ToHtmlStringRGB(ref color2);
			string str = (string)obj + text;
			((JsonWriter)color).Write(str);
		}

		internal void <RegisterImporters>b__0_5(PlayerRank rank, JsonWriter writer)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			object property_name = "Picking audio files is not supported on iOS" + 3904;
			writer.WriteObjectStart();
			writer.WritePropertyName((string)property_name);
			object property_name2 = "SetRoomVariables request error" + 3992;
			object property_name3 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1784;
			writer.Write((int)rank.<Rank>k__BackingField);
			writer.WritePropertyName((string)property_name2);
			writer.Write(rank.<SubRanksCount>k__BackingField);
			writer.WritePropertyName((string)property_name3);
			writer.Write(rank.<IsNew>k__BackingField);
			writer.WriteObjectEnd();
		}
	}

	private static void RegisterImporters()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1507: Expected O, but got I
		//IL_1516: Unknown result type (might be due to invalid IL or missing references)
		//IL_151b: Expected O, but got Unknown
		//IL_1527: Expected O, but got I
		//IL_1533: Expected O, but got I
		//IL_1542: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		//IL_1553: Expected O, but got I
		//IL_155f: Expected O, but got I
		//IL_156e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1573: Expected O, but got Unknown
		//IL_1582: Unknown result type (might be due to invalid IL or missing references)
		//IL_1587: Expected O, but got Unknown
		//IL_159d: Expected O, but got I
		//IL_15ab: Expected I, but got O
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bf: Expected O, but got Unknown
		//IL_15e9: Expected O, but got I4
		//IL_004e: Expected I, but got O
		//IL_0074: Expected I, but got O
		//IL_009d: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00b7: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_00fd: Expected I, but got O
		//IL_010e: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0154: Expected I, but got O
		//IL_0160: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01a6: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01ef: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_023e: Expected O, but got I
		//IL_024c: Expected I, but got O
		//IL_025d: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_02af: Expected O, but got I
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I
		//IL_02f5: Expected I, but got O
		//IL_0306: Expected O, but got I
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_033e: Expected O, but got I
		//IL_0346: Expected I, but got O
		//IL_0354: Expected I, but got O
		//IL_0360: Expected O, but got I
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a74: Expected O, but got I
		//IL_0a84: Expected O, but got I
		//IL_0aa6: Expected O, but got I4
		//IL_0410: Expected O, but got I
		//IL_0438: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03c7: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_0ade: Expected O, but got I4
		//IL_0be3: Expected O, but got I4
		//IL_1606: Unknown result type (might be due to invalid IL or missing references)
		//IL_160b: Expected O, but got Unknown
		//IL_1621: Expected O, but got I
		//IL_1629: Expected I, but got O
		//IL_163a: Expected I, but got O
		//IL_1658: Expected O, but got I
		//IL_04e5: Expected O, but got I
		//IL_04f5: Expected O, but got I
		//IL_0c3b: Expected O, but got I
		//IL_0c4b: Expected O, but got I
		//IL_0c6d: Expected O, but got I4
		//IL_0b1f: Expected O, but got I
		//IL_0b49: Expected O, but got I4
		//IL_0b5a: Expected O, but got I4
		//IL_0b73: Expected O, but got I4
		//IL_0b83: Expected I, but got O
		//IL_0b0e: Expected O, but got I
		//IL_0cbd: Expected O, but got I4
		//IL_0546: Expected O, but got I
		//IL_167e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1683: Expected O, but got Unknown
		//IL_1699: Expected O, but got I
		//IL_16a1: Expected I, but got O
		//IL_16b2: Expected I, but got O
		//IL_16d0: Expected O, but got I
		//IL_0cfe: Expected O, but got I
		//IL_0d28: Expected O, but got I4
		//IL_0d39: Expected O, but got I4
		//IL_0d52: Expected O, but got I4
		//IL_0d62: Expected I, but got O
		//IL_0ced: Expected O, but got I
		//IL_0dc2: Expected O, but got I4
		//IL_0611: Expected O, but got I
		//IL_0621: Expected O, but got I
		//IL_0e1a: Expected O, but got I
		//IL_0e2a: Expected O, but got I
		//IL_0e4c: Expected O, but got I4
		//IL_0e9c: Expected O, but got I4
		//IL_0672: Expected O, but got I
		//IL_16f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fb: Expected O, but got Unknown
		//IL_1711: Expected O, but got I
		//IL_1719: Expected I, but got O
		//IL_172a: Expected I, but got O
		//IL_1748: Expected O, but got I
		//IL_0edd: Expected O, but got I
		//IL_0f07: Expected O, but got I4
		//IL_0f18: Expected O, but got I4
		//IL_0f31: Expected O, but got I4
		//IL_0f41: Expected I, but got O
		//IL_0ecc: Expected O, but got I
		//IL_0fa1: Expected O, but got I4
		//IL_073d: Expected O, but got I
		//IL_074d: Expected O, but got I
		//IL_0ff9: Expected O, but got I
		//IL_1009: Expected O, but got I
		//IL_102b: Expected O, but got I4
		//IL_107b: Expected O, but got I4
		//IL_079e: Expected O, but got I
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Expected O, but got Unknown
		//IL_1789: Expected O, but got I
		//IL_1791: Expected I, but got O
		//IL_17a2: Expected I, but got O
		//IL_17c0: Expected O, but got I
		//IL_10bc: Expected O, but got I
		//IL_10e6: Expected O, but got I4
		//IL_10f7: Expected O, but got I4
		//IL_1110: Expected O, but got I4
		//IL_1120: Expected I, but got O
		//IL_10ab: Expected O, but got I
		//IL_1180: Expected O, but got I4
		//IL_0869: Expected O, but got I
		//IL_0879: Expected O, but got I
		//IL_11d8: Expected O, but got I
		//IL_11e8: Expected O, but got I
		//IL_120a: Expected O, but got I4
		//IL_125a: Expected O, but got I4
		//IL_08ca: Expected O, but got I
		//IL_17e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Expected O, but got Unknown
		//IL_1801: Expected O, but got I
		//IL_1809: Expected I, but got O
		//IL_1831: Expected O, but got I
		//IL_129b: Expected O, but got I
		//IL_12c5: Expected O, but got I4
		//IL_12d6: Expected O, but got I4
		//IL_12ef: Expected O, but got I4
		//IL_12ff: Expected I, but got O
		//IL_128a: Expected O, but got I
		//IL_1360: Expected O, but got I4
		//IL_0996: Expected O, but got I
		//IL_09a6: Expected O, but got I
		//IL_13b8: Expected O, but got I
		//IL_13c8: Expected O, but got I
		//IL_13ea: Expected O, but got I4
		//IL_143a: Expected O, but got I4
		//IL_09f7: Expected O, but got I
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_185c: Expected O, but got Unknown
		//IL_1872: Expected O, but got I
		//IL_187a: Expected I, but got O
		//IL_188b: Expected I, but got O
		//IL_18a9: Expected O, but got I
		//IL_147b: Expected O, but got I
		//IL_14a5: Expected O, but got I4
		//IL_14be: Expected O, but got I4
		//IL_146a: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2728;
		object obj2 = (nint)0 + (nint)1040;
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2672;
		object obj4 = (nint)0 + (nint)3128;
		object obj5 = (nint)0 + (nint)984;
		object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2736;
		object obj7 = (nint)0 + (nint)3088;
		object obj8 = (nint)0 + (nint)1048;
		object obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2688;
		object obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3056;
		ImporterFunc<object, int> importerFunc = default(ImporterFunc<object, int>);
		importerFunc..ctor((object)null, (IntPtr)obj11);
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JsonMapper.RegisterImporter(importerFunc);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ImporterFunc<int, object> importerFunc2 = default(ImporterFunc<int, object>);
		importerFunc2..ctor((object)null, (IntPtr)obj4);
		JsonMapper.RegisterImporter(importerFunc2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ImporterFunc<object, long> importerFunc3 = default(ImporterFunc<object, long>);
		importerFunc3..ctor((object)null, (IntPtr)obj7);
		JsonMapper.RegisterImporter(importerFunc3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3136;
		ImporterFunc<long, object> importerFunc4 = default(ImporterFunc<long, object>);
		importerFunc4..ctor((object)null, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)1000;
		JsonMapper.RegisterImporter(importerFunc4);
		object obj17 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)3080;
		ImporterFunc<int, long> importerFunc5 = default(ImporterFunc<int, long>);
		importerFunc5..ctor((object)null, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)968;
		JsonMapper.RegisterImporter(importerFunc5);
		object obj20 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)3040;
		ImporterFunc<long, int> importerFunc6 = default(ImporterFunc<long, int>);
		importerFunc6..ctor((object)null, (IntPtr)obj21);
		object obj22 = (nint)0 + (nint)992;
		JsonMapper.RegisterImporter(importerFunc6);
		object obj23 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)3008;
		ImporterFunc<int, double> importerFunc7 = default(ImporterFunc<int, double>);
		importerFunc7..ctor((object)null, (IntPtr)obj24);
		object obj25 = (nint)0 + (nint)960;
		JsonMapper.RegisterImporter(importerFunc7);
		object obj26 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)3032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4B9CE4C");
		object obj28 = (nint)0 + (nint)944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E934E0");
		object obj29 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)3120;
		ImporterFunc<int, float> importerFunc8 = default(ImporterFunc<int, float>);
		importerFunc8..ctor((object)null, (IntPtr)obj30);
		object obj31 = (nint)0 + (nint)976;
		JsonMapper.RegisterImporter(importerFunc8);
		object obj32 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)3048;
		ImporterFunc<float, int> importerFunc9 = default(ImporterFunc<float, int>);
		importerFunc9..ctor((object)null, (IntPtr)obj33);
		object obj34 = (nint)0 + (nint)1016;
		JsonMapper.RegisterImporter(importerFunc9);
		object obj35 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj36 = (nint)0 + (nint)3112;
		ImporterFunc<double, float> importerFunc10 = default(ImporterFunc<double, float>);
		importerFunc10..ctor((object)null, (IntPtr)obj36);
		object obj37 = (nint)0 + (nint)952;
		JsonMapper.RegisterImporter(importerFunc10);
		object obj38 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)3016;
		nint num = (nint)obj39;
		ImporterFunc<float, double> importerFunc11 = default(ImporterFunc<float, double>);
		importerFunc11..ctor((object)null, (IntPtr)obj39);
		object obj40 = (nint)0 + (nint)1008;
		ImporterFunc<object, TimeSpan> importerFunc12 = (ImporterFunc<object, TimeSpan>)obj40;
		JsonMapper.RegisterImporter(importerFunc11);
		object obj41 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v123+E4]");
		object obj42;
		object obj43;
		ImporterFunc<object, TimeSpan> importerFunc13;
		object obj44;
		if ((nint)0 != 0)
		{
			obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v123+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v133+8]");
			importerFunc13 = (ImporterFunc<object, TimeSpan>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v133+8]");
			bool flag2 = (nint)0 == 0;
			obj44 = obj42;
			if (!flag2)
			{
				goto IL_0404;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj41 = obj10;
			obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v123+B8]");
			obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v133+8]");
			importerFunc13 = (ImporterFunc<object, TimeSpan>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v133+8]");
			bool flag3 = (nint)0 == 0;
			object obj45 = !flag3;
			obj44 = obj42;
			if (obj45 != null)
			{
				goto IL_0404;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X0_v123+E4]");
		bool flag4 = (nint)0 == 0;
		object obj46 = !flag4;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj47 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v140+B8]");
			obj43 = 0;
		}
		object obj48 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj49 = (nint)0 + (nint)3936;
		num = (nint)obj49;
		ImporterFunc<object, TimeSpan> importerFunc14 = default(ImporterFunc<object, TimeSpan>);
		importerFunc14..ctor(obj43, (IntPtr)obj49);
		object obj50 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v138+B8]");
		object obj51 = (nint)0 + (nint)8;
		obj51 = importerFunc14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj52 = (nint)0 + (nint)1056;
		object obj53 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v119+E4]");
		bool flag5 = (nint)0 == 0;
		object obj54 = !flag5;
		obj42 = obj44;
		object obj55 = 0;
		importerFunc13 = importerFunc14;
		object obj56 = obj52;
		object obj57 = 0;
		importerFunc12 = importerFunc14;
		nint num2 = (nint)obj49;
		ImporterFunc<object, TimeSpan> importer = importerFunc14;
		if (obj54 != null)
		{
			goto IL_046f;
		}
		goto IL_0b99;
		IL_11b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj58 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v59+B8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v77+28]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v77+28]");
		bool flag6 = (nint)0 == 0;
		object obj61 = !flag6;
		obj42 = obj44;
		object obj62;
		obj55 = obj62;
		object obj64;
		object obj63 = obj64;
		nint num3;
		num = num3;
		if (obj61 != null)
		{
			goto IL_08be;
		}
		goto IL_1238;
		IL_07f3:
		object obj65;
		obj63 = obj65;
		ImporterFunc<object, Color> importerFunc15;
		JsonMapper.RegisterImporter(importerFunc15);
		obj58 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v59+E4]");
		bool flag7 = (nint)0 == 0;
		obj44 = obj42;
		obj62 = obj55;
		obj64 = obj65;
		num3 = num;
		object obj66 = obj58;
		if (!flag7)
		{
			goto IL_0859;
		}
		goto IL_11b6;
		IL_09eb:
		object obj67 = (nint)0 + (nint)928;
		object obj68 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X0_v41+E4]");
		bool flag8 = (nint)0 == 0;
		object obj69 = obj67;
		ExporterFunc<object> exporterFunc2;
		ExporterFunc<object> exporterFunc = exporterFunc2;
		if (!flag8)
		{
			goto IL_0a34;
		}
		goto IL_14dc;
		IL_1238:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v59+E4]");
		bool flag9 = (nint)0 == 0;
		object obj70 = !flag9;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj71 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v84+B8]");
			obj59 = 0;
		}
		object obj72 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj73 = (nint)0 + (nint)3968;
		num = (nint)obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A1E5A0");
		object obj74 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X8_v82+B8]");
		object obj75 = (nint)0 + (nint)40;
		object obj76 = default(object);
		obj75 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj77 = (nint)0 + (nint)920;
		object obj78 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v55+E4]");
		bool flag10 = (nint)0 == 0;
		object obj79 = !flag10;
		obj42 = obj44;
		obj55 = 0;
		obj60 = obj76;
		object obj80 = obj77;
		object obj81 = 0;
		obj63 = obj76;
		nint num4 = (nint)obj73;
		object obj82 = obj76;
		if (obj79 != null)
		{
			goto IL_091f;
		}
		goto IL_1315;
		IL_0859:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v59+B8]");
		obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v77+28]");
		obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X8_v77+28]");
		bool flag11 = (nint)0 == 0;
		obj44 = obj42;
		obj62 = obj55;
		obj64 = obj63;
		num3 = num;
		if (!flag11)
		{
			goto IL_08be;
		}
		goto IL_1238;
		IL_08be:
		obj77 = (nint)0 + (nint)920;
		obj78 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X0_v55+E4]");
		bool flag12 = (nint)0 == 0;
		obj80 = obj77;
		obj44 = obj42;
		obj81 = obj55;
		num4 = num;
		obj82 = obj60;
		if (!flag12)
		{
			goto IL_091f;
		}
		goto IL_1315;
		IL_14dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj67 = obj69;
		exporterFunc2 = exporterFunc;
		goto IL_0a34;
		IL_0404:
		obj52 = (nint)0 + (nint)1056;
		obj53 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X0_v119+E4]");
		bool flag13 = (nint)0 == 0;
		obj55 = 0;
		obj56 = obj52;
		obj44 = obj42;
		obj57 = 0;
		num2 = num;
		importer = importerFunc13;
		if (!flag13)
		{
			goto IL_046f;
		}
		goto IL_0b99;
		IL_0b99:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ExporterFunc<TimeSpan> exporterFunc3 = (ExporterFunc<TimeSpan>)obj56;
		JsonMapper.RegisterImporter(importer);
		object obj83 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v107+E4]");
		bool flag14 = (nint)0 == 0;
		object obj84 = !flag14;
		obj42 = obj44;
		obj55 = obj57;
		num = num2;
		ExporterFunc<TimeSpan> exporterFunc4 = (ExporterFunc<TimeSpan>)obj56;
		object obj85 = obj83;
		if (obj84 != null)
		{
			goto IL_04d5;
		}
		goto IL_0c19;
		IL_046f:
		exporterFunc3 = (ExporterFunc<TimeSpan>)obj52;
		JsonMapper.RegisterImporter(importerFunc13);
		obj83 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v107+E4]");
		bool flag15 = (nint)0 == 0;
		obj44 = obj42;
		obj57 = obj55;
		exporterFunc4 = (ExporterFunc<TimeSpan>)obj52;
		num2 = num;
		obj85 = obj83;
		if (!flag15)
		{
			goto IL_04d5;
		}
		goto IL_0c19;
		IL_0c19:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj83 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v107+B8]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v119+10]");
		ExporterFunc<TimeSpan> exporterFunc5 = (ExporterFunc<TimeSpan>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v119+10]");
		bool flag16 = (nint)0 == 0;
		object obj87 = !flag16;
		obj42 = obj44;
		obj55 = obj57;
		exporterFunc3 = exporterFunc4;
		num = num2;
		if (obj87 != null)
		{
			goto IL_053a;
		}
		goto IL_0c9b;
		IL_04d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v107+B8]");
		obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v119+10]");
		exporterFunc5 = (ExporterFunc<TimeSpan>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v119+10]");
		bool flag17 = (nint)0 == 0;
		obj44 = obj42;
		obj57 = obj55;
		exporterFunc4 = exporterFunc3;
		num2 = num;
		if (!flag17)
		{
			goto IL_053a;
		}
		goto IL_0c9b;
		IL_0c9b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X0_v107+E4]");
		bool flag18 = (nint)0 == 0;
		object obj88 = !flag18;
		if (obj88 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj89 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v126+B8]");
			obj86 = 0;
		}
		object obj90 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj91 = (nint)0 + (nint)3944;
		num = (nint)obj91;
		ExporterFunc<TimeSpan> exporterFunc6 = default(ExporterFunc<TimeSpan>);
		exporterFunc6..ctor(obj86, (IntPtr)obj91);
		object obj92 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v124+B8]");
		object obj93 = (nint)0 + (nint)16;
		obj93 = exporterFunc6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj94 = (nint)0 + (nint)936;
		object obj95 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v103+E4]");
		bool flag19 = (nint)0 == 0;
		object obj96 = !flag19;
		obj42 = obj44;
		obj55 = 0;
		exporterFunc5 = exporterFunc6;
		object obj97 = obj94;
		object obj98 = 0;
		exporterFunc3 = exporterFunc6;
		nint num5 = (nint)obj91;
		ExporterFunc<TimeSpan> exporter = exporterFunc6;
		if (obj96 != null)
		{
			goto IL_059b;
		}
		goto IL_0d78;
		IL_091f:
		ExporterFunc<object> exporterFunc7 = (ExporterFunc<object>)obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E92E4C");
		object obj99 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+E4]");
		bool flag20 = (nint)0 == 0;
		obj44 = obj42;
		obj81 = obj55;
		ExporterFunc<object> exporterFunc8 = (ExporterFunc<object>)obj77;
		num4 = num;
		object obj100 = obj99;
		if (!flag20)
		{
			goto IL_0986;
		}
		goto IL_1396;
		IL_1315:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		exporterFunc7 = (ExporterFunc<object>)obj80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E92E4C");
		obj99 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+E4]");
		bool flag21 = (nint)0 == 0;
		object obj101 = !flag21;
		obj42 = obj44;
		obj55 = obj81;
		num = num4;
		exporterFunc8 = (ExporterFunc<object>)obj80;
		obj100 = obj99;
		if (obj101 != null)
		{
			goto IL_0986;
		}
		goto IL_1396;
		IL_053a:
		obj94 = (nint)0 + (nint)936;
		obj95 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v103+E4]");
		bool flag22 = (nint)0 == 0;
		obj97 = obj94;
		obj44 = obj42;
		obj98 = obj55;
		num5 = num;
		exporter = exporterFunc5;
		if (!flag22)
		{
			goto IL_059b;
		}
		goto IL_0d78;
		IL_0d78:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ImporterFunc<object, System.Int32Enum> importerFunc16 = (ImporterFunc<object, System.Int32Enum>)obj97;
		JsonMapper.RegisterExporter(exporter);
		object obj102 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v91+E4]");
		bool flag23 = (nint)0 == 0;
		object obj103 = !flag23;
		obj42 = obj44;
		obj55 = obj98;
		num = num5;
		ImporterFunc<object, System.Int32Enum> importerFunc17 = (ImporterFunc<object, System.Int32Enum>)obj97;
		object obj104 = obj102;
		if (obj103 != null)
		{
			goto IL_0601;
		}
		goto IL_0df8;
		IL_059b:
		importerFunc16 = (ImporterFunc<object, System.Int32Enum>)obj94;
		JsonMapper.RegisterExporter(exporterFunc5);
		obj102 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v91+E4]");
		bool flag24 = (nint)0 == 0;
		obj44 = obj42;
		obj98 = obj55;
		importerFunc17 = (ImporterFunc<object, System.Int32Enum>)obj94;
		num5 = num;
		obj104 = obj102;
		if (!flag24)
		{
			goto IL_0601;
		}
		goto IL_0df8;
		IL_0df8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj102 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v91+B8]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v105+18]");
		ImporterFunc<object, System.Int32Enum> importerFunc18 = (ImporterFunc<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v105+18]");
		bool flag25 = (nint)0 == 0;
		object obj106 = !flag25;
		obj42 = obj44;
		obj55 = obj98;
		importerFunc16 = importerFunc17;
		num = num5;
		if (obj106 != null)
		{
			goto IL_0666;
		}
		goto IL_0e7a;
		IL_0601:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v91+B8]");
		obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v105+18]");
		importerFunc18 = (ImporterFunc<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X8_v105+18]");
		bool flag26 = (nint)0 == 0;
		obj44 = obj42;
		obj98 = obj55;
		importerFunc17 = importerFunc16;
		num5 = num;
		if (!flag26)
		{
			goto IL_0666;
		}
		goto IL_0e7a;
		IL_0e7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v91+E4]");
		bool flag27 = (nint)0 == 0;
		object obj107 = !flag27;
		if (obj107 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj108 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v112+B8]");
			obj105 = 0;
		}
		object obj109 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj110 = (nint)0 + (nint)3952;
		num = (nint)obj110;
		ImporterFunc<object, System.Int32Enum> importerFunc19 = default(ImporterFunc<object, System.Int32Enum>);
		importerFunc19..ctor(obj105, (IntPtr)obj110);
		object obj111 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v110+B8]");
		object obj112 = (nint)0 + (nint)24;
		obj112 = importerFunc19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj113 = (nint)0 + (nint)1032;
		object obj114 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v87+E4]");
		bool flag28 = (nint)0 == 0;
		object obj115 = !flag28;
		obj42 = obj44;
		obj55 = 0;
		importerFunc18 = importerFunc19;
		object obj116 = obj113;
		object obj117 = 0;
		importerFunc16 = importerFunc19;
		nint num6 = (nint)obj110;
		ImporterFunc<object, System.Int32Enum> importer2 = importerFunc19;
		if (obj115 != null)
		{
			goto IL_06c7;
		}
		goto IL_0f57;
		IL_0986:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+B8]");
		object obj118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v63+30]");
		exporterFunc2 = (ExporterFunc<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v63+30]");
		bool flag29 = (nint)0 == 0;
		obj44 = obj42;
		obj81 = obj55;
		exporterFunc8 = exporterFunc7;
		num4 = num;
		if (!flag29)
		{
			goto IL_09eb;
		}
		goto IL_1418;
		IL_1396:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj99 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+B8]");
		obj118 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v63+30]");
		exporterFunc2 = (ExporterFunc<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v63+30]");
		bool flag30 = (nint)0 == 0;
		object obj119 = !flag30;
		obj42 = obj44;
		obj55 = obj81;
		exporterFunc7 = exporterFunc8;
		num = num4;
		if (obj119 != null)
		{
			goto IL_09eb;
		}
		goto IL_1418;
		IL_0666:
		obj113 = (nint)0 + (nint)1032;
		obj114 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v87+E4]");
		bool flag31 = (nint)0 == 0;
		obj116 = obj113;
		obj44 = obj42;
		obj117 = obj55;
		num6 = num;
		importer2 = importerFunc18;
		if (!flag31)
		{
			goto IL_06c7;
		}
		goto IL_0f57;
		IL_0f57:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ImporterFunc<object, Color> importerFunc20 = (ImporterFunc<object, Color>)obj116;
		JsonMapper.RegisterImporter(importer2);
		object obj120 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+E4]");
		bool flag32 = (nint)0 == 0;
		object obj121 = !flag32;
		obj42 = obj44;
		obj55 = obj117;
		num = num6;
		ImporterFunc<object, Color> importerFunc21 = (ImporterFunc<object, Color>)obj116;
		object obj122 = obj120;
		if (obj121 != null)
		{
			goto IL_072d;
		}
		goto IL_0fd7;
		IL_06c7:
		importerFunc20 = (ImporterFunc<object, Color>)obj113;
		JsonMapper.RegisterImporter(importerFunc18);
		obj120 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+E4]");
		bool flag33 = (nint)0 == 0;
		obj44 = obj42;
		obj117 = obj55;
		importerFunc21 = (ImporterFunc<object, Color>)obj113;
		num6 = num;
		obj122 = obj120;
		if (!flag33)
		{
			goto IL_072d;
		}
		goto IL_0fd7;
		IL_0fd7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj120 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+B8]");
		object obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v91+20]");
		importerFunc15 = (ImporterFunc<object, Color>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v91+20]");
		bool flag34 = (nint)0 == 0;
		object obj124 = !flag34;
		obj42 = obj44;
		obj55 = obj117;
		importerFunc20 = importerFunc21;
		num = num6;
		if (obj124 != null)
		{
			goto IL_0792;
		}
		goto IL_1059;
		IL_072d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+B8]");
		obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v91+20]");
		importerFunc15 = (ImporterFunc<object, Color>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v91+20]");
		bool flag35 = (nint)0 == 0;
		obj44 = obj42;
		obj117 = obj55;
		importerFunc21 = importerFunc20;
		num6 = num;
		if (!flag35)
		{
			goto IL_0792;
		}
		goto IL_1059;
		IL_1059:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v75+E4]");
		bool flag36 = (nint)0 == 0;
		object obj125 = !flag36;
		if (obj125 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj126 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v98+B8]");
			obj123 = 0;
		}
		object obj127 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj128 = (nint)0 + (nint)3960;
		num = (nint)obj128;
		ImporterFunc<object, Color> importerFunc22 = default(ImporterFunc<object, Color>);
		importerFunc22..ctor(obj123, (IntPtr)obj128);
		object obj129 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v96+B8]");
		object obj130 = (nint)0 + (nint)32;
		obj130 = importerFunc22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj65 = (nint)0 + (nint)1024;
		object obj131 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v71+E4]");
		bool flag37 = (nint)0 == 0;
		object obj132 = !flag37;
		obj42 = obj44;
		obj55 = 0;
		importerFunc15 = importerFunc22;
		object obj133 = obj65;
		obj62 = 0;
		importerFunc20 = importerFunc22;
		num3 = (nint)obj128;
		ImporterFunc<object, Color> importer3 = importerFunc22;
		if (obj132 != null)
		{
			goto IL_07f3;
		}
		goto IL_1136;
		IL_0a34:
		JsonMapper.RegisterExporter(exporterFunc2);
		return;
		IL_1418:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1001 @ X0_v43+E4]");
		bool flag38 = (nint)0 == 0;
		object obj134 = !flag38;
		if (obj134 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj135 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X8_v70+B8]");
			obj118 = 0;
		}
		object obj136 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj137 = (nint)0 + (nint)3976;
		num = (nint)obj137;
		ExporterFunc<object> exporterFunc9 = default(ExporterFunc<object>);
		exporterFunc9..ctor(obj118, (IntPtr)obj137);
		object obj138 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X8_v68+B8]");
		object obj139 = (nint)0 + (nint)48;
		obj139 = exporterFunc9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj67 = (nint)0 + (nint)928;
		obj68 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1053 @ X0_v41+E4]");
		bool flag39 = (nint)0 == 0;
		object obj140 = !flag39;
		exporterFunc2 = exporterFunc9;
		obj69 = obj67;
		obj55 = 0;
		exporterFunc7 = exporterFunc9;
		exporterFunc = exporterFunc9;
		if (obj140 != null)
		{
			goto IL_0a34;
		}
		goto IL_14dc;
		IL_0792:
		obj65 = (nint)0 + (nint)1024;
		obj131 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X0_v71+E4]");
		bool flag40 = (nint)0 == 0;
		obj133 = obj65;
		obj44 = obj42;
		obj62 = obj55;
		num3 = num;
		importer3 = importerFunc15;
		if (!flag40)
		{
			goto IL_07f3;
		}
		goto IL_1136;
		IL_1136:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj63 = obj133;
		JsonMapper.RegisterImporter(importer3);
		obj58 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v59+E4]");
		bool flag41 = (nint)0 == 0;
		object obj141 = !flag41;
		obj42 = obj44;
		obj55 = obj62;
		num = num3;
		obj64 = obj133;
		obj66 = obj58;
		if (obj141 != null)
		{
			goto IL_0859;
		}
		goto IL_11b6;
	}
}
