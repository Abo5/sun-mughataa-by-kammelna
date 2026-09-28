using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public static class ClanJoinRequestFlow
{
	private sealed class <>c__DisplayClass1_0
	{
		public Action onSuccess;

		public int clanId;

		internal void <RequestJoinClan>b__0(bool succeeded, KammelnaError error)
		{
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if (succeeded)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3672;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show((string)message, (Vector2)0, 0f);
				Action action = onSuccess;
				if (onSuccess == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object operation = "Read object reference Id '{0}' for {1}." + 2488;
			ReportFailure(clanId, error, (string)operation);
		}
	}

	private sealed class <>c__DisplayClass2_0
	{
		public Action onSuccess;

		public int clanId;

		internal void <CancelJoinRequest>b__0(bool succeeded, KammelnaError error)
		{
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0082: Expected O, but got I4
			if (succeeded)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object message = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3648;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show((string)message, (Vector2)0, 0f);
				Action action = onSuccess;
				if (onSuccess == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v83 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object operation = "COORDINATE_TYPE_GCJ_02" + 1872;
			ReportFailure(clanId, error, (string)operation);
		}
	}

	private const string ERROR_TITLE_KEY = "apologies";

	public static void RequestJoinClan(int clanId, Action onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_022c: Expected O, but got I4
		//IL_0110: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_015a: Expected I, but got O
		//IL_0172: Expected O, but got I4
		//IL_017a: Expected I, but got O
		//IL_029b: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		//IL_035c: Expected O, but got I4
		//IL_02e9: Expected I, but got O
		//IL_02f9: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_0334: Expected O, but got I
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03fe: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = null;
		object obj12;
		nint num;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1232;
			object obj5 = obj2 + 16;
			obj5 = onSuccess;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v13+E4]");
			TimeSpan retryAfter;
			if ((nint)0 != 0)
			{
				if (ClanJoinRequestRateLimiter.TryConsume(out retryAfter))
				{
					goto IL_00a9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = ClanJoinRequestRateLimiter.TryConsume(out retryAfter);
				bool flag3 = !flag2;
				object obj7 = !flag3;
				if (obj7 != null)
				{
					goto IL_00a9;
				}
			}
			object obj8 = typeof(DataRelation) + 824;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string durationText = DateTimeUtil.GetDurationText(retryAfter, 1, DateTimeUnit.Seconds);
			object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag5 = array == null;
			obj12 = 0;
			num = 5;
			obj3 = 1;
			if (!flag5)
			{
				bool flag6 = durationText == null;
				object obj13 = 1;
				if (!flag6)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex == null;
					obj12 = 0;
					num = 5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					obj3 = 0;
					if (flag7)
					{
						goto IL_0437;
					}
				}
				bool flag8 = array.Length == 0;
				obj12 = 0;
				num = 5;
				obj3 = obj13;
				if (!flag8)
				{
					object obj14 = array + 32;
					obj14 = durationText;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3656;
					LocalizableText text2 = TextMeshProExtensions.LocalizeWith((string)text, array);
					object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v18+E4]");
					bool flag9 = (nint)0 == 0;
					object obj17 = !flag9;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Toast.Show(text2, (Vector2)0, 0f);
					return;
				}
				goto IL_0429;
			}
		}
		goto IL_041b;
		IL_0437:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_00a9:
		object obj18 = typeof(Queue<string>) + 728;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v38+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj22 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)3816;
		Action<bool, System.Int32Enum> action = default(Action<bool, System.Int32Enum>);
		action..ctor(obj2, (IntPtr)obj23);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		bool flag11 = (object)clanServerConnector == null;
		obj12 = 0;
		num = (nint)obj23;
		obj3 = obj2;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
			clanServerConnector.RequestJoinClan(0, (Action<bool, KammelnaError>)(object)action);
			return;
		}
		goto IL_041b;
		IL_041b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0429;
		IL_0429:
		ex = new IndexOutOfRangeException();
		goto IL_0437;
	}

	public static void CancelJoinRequest(int clanId, Action onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_00ef: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 256;
		object obj6 = (nint)0 + (nint)3824;
		object obj7 = obj2 + 16;
		obj7 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool, System.Int32Enum> action = default(Action<bool, System.Int32Enum>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.CancelJoinRequest(0, (Action<bool, KammelnaError>)(object)action);
	}

	private unsafe static void ReportFailure(int clanId, KammelnaError error, string operation)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected O, but got Unknown
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_0041: Expected O, but got I4
		//IL_0057: Expected I, but got O
		//IL_0067: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0112: Expected O, but got Ref
		//IL_0183: Expected O, but got I8
		//IL_0128: Expected I, but got O
		//IL_0138: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01fa: Expected O, but got Ref
		//IL_0273: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0210: Expected I, but got O
		//IL_0220: Expected O, but got I
		//IL_0249: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02fc: Expected O, but got Ref
		//IL_036d: Expected O, but got I8
		//IL_0312: Expected I, but got O
		//IL_0322: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03fa: Expected I, but got O
		//IL_041c: Expected O, but got I4
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0474: Expected I, but got O
		//IL_0484: Expected O, but got I
		//IL_08cb: Expected O, but got I
		//IL_04bf: Expected O, but got I
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected I, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I
		//IL_0643: Expected I, but got O
		//IL_0653: Expected O, but got I
		//IL_067c: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_06a6: Expected I, but got O
		//IL_06b6: Expected O, but got I
		//IL_0745: Expected O, but got I4
		//IL_0768: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_0775: Expected I, but got O
		//IL_0785: Expected O, but got I
		//IL_07a9: Expected O, but got I4
		//IL_07c1: Expected O, but got I
		//IL_06f1: Expected O, but got I
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87A3]");
		nint num = 0;
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array == null)
		{
			goto IL_07cf;
		}
		string text = default(string);
		bool flag = text == null;
		object obj2 = 4;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj3;
		if (!flag)
		{
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v40 (Il2CppClass<System.Object[]>)+40]");
			obj3 = 0;
			if (flag2)
			{
				goto IL_0821;
			}
		}
		object obj26 = default(object);
		if (array.Length != 0)
		{
			object obj4 = array + 32;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			int num3 = default(int);
			obj2 = (object)(&num3);
			if (!flag3)
			{
				nint num4 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
				obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v39 (Il2CppClass<System.Object[]>)+40]");
				obj3 = 0;
				if (flag4)
				{
					goto IL_0821;
				}
			}
			object obj7 = array.Length & 0xFFFFFFFEL;
			if (obj7 != null)
			{
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
				object obj9 = array + 40;
				obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj10 = default(object);
				bool flag5 = obj10 == null;
				KammelnaError kammelnaError = default(KammelnaError);
				obj2 = (object)(&kammelnaError);
				if (!flag5)
				{
					nint num5 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
					obj3 = 0;
					if (flag6)
					{
						goto IL_0821;
					}
				}
				bool flag7 = array.Length < 2;
				object obj11 = !flag7;
				object obj12 = array.Length - 2;
				bool flag8 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag8;
				if (obj14 == null)
				{
					object obj15 = array + 48;
					obj15 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj16 = default(object);
					bool flag9 = obj16 == null;
					KammelnaError kammelnaError2 = default(KammelnaError);
					obj2 = (object)(&kammelnaError2);
					if (!flag9)
					{
						nint num6 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
						obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag10 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v37 (Il2CppClass<System.Object[]>)+40]");
						obj3 = 0;
						if (flag10)
						{
							goto IL_0821;
						}
					}
					object obj17 = array.Length & 0xFFFFFFFCL;
					if (obj17 != null)
					{
						object format = "WhiteSmoke" + 2864;
						object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
						object buttonText = "Network Authentication Required" + 3128;
						object obj19 = array + 56;
						obj19 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						string text2 = string.Format((string)format, array);
						num = (nint)obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+E4]");
						bool flag11 = (nint)0 == 0;
						object obj20 = !flag11;
						object obj21 = text2;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj21 = text2;
						}
						KLogger.Log(obj21);
						IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(null, (string)buttonText);
						bool flag12 = popupWindowBuilderNeedsTitle == null;
						text = null;
						if (flag12)
						{
							goto IL_07cf;
						}
						object obj22 = typeof(System.IOAsyncCallback) + 392;
						object obj23 = "alignContent" + 1960;
						nint num7 = (nint)popupWindowBuilderNeedsTitle;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						object obj24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0508;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v21 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
						object obj25 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X10_v19-8]");
							if (0 == (nint)obj22)
							{
								break;
							}
							obj26 = obj25 + 16;
							obj24--;
							bool flag13 = (nint)obj24 != 1;
							obj25 = obj26;
							if (flag13)
							{
								continue;
							}
							goto IL_0508;
						}
						object obj27 = num7 + obj25;
						num = (nint)(obj27 + 312);
						obj26 = obj25;
						goto IL_08bb;
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		obj3 = obj2;
		goto IL_0821;
		IL_068a:
		object obj28 = typeof(System.IOAsyncCallback) + 368;
		NullReferenceException ex2 = default(NullReferenceException);
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0732;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj26 = (nint)0 + (nint)8;
		string text3;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X10_v11-8]");
			bool flag14 = 0 == (nint)obj28;
			text = text3;
			if (flag14)
			{
				break;
			}
			obj26 += 16;
			obj29--;
			if ((nint)obj29 != 1)
			{
				continue;
			}
			goto IL_0732;
		}
		goto IL_07dd;
		IL_07dd:
		object obj30 = obj26 + 9;
		object obj31 = num + obj30;
		object obj32 = obj31 + 312;
		goto IL_094e;
		IL_094e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X8_v3] (should have been resolved before IL gen)");
		return;
		IL_0821:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0732:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text = (string)9;
		object obj33 = default(object);
		obj32 = obj33;
		goto IL_094e;
		IL_0508:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_08bb;
		IL_08bb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		LocalizableText localizableText = TextMeshProExtensions.Localize(friendlyName);
		object obj34 = default(object);
		if (localizableText != null && obj34 != null)
		{
			object obj35 = typeof(System.IOAsyncCallback) + 384;
			object obj36 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v25+12E]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v25+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0631;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ X8_v25+B0]");
			object obj38 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X10_v14-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj26 = obj38 + 16;
				obj37--;
				bool flag15 = (nint)obj37 != 1;
				obj38 = obj26;
				if (flag15)
				{
					continue;
				}
				goto IL_0631;
			}
			object obj39 = obj36 + obj38;
			object obj40 = obj39 + 312;
			num = (nint)obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v54+8]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v601 @ X0_v54] (should have been resolved before IL gen)");
			bool flag16 = ex2 == null;
			object obj41 = !flag16;
			obj26 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X0_v54+8]");
			text = (string)0;
			if (obj41 != null)
			{
				goto IL_068a;
			}
		}
		goto IL_07cf;
		IL_07cf:
		ex2 = new NullReferenceException();
		goto IL_07dd;
		IL_0631:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj42 = default(object);
		num = (nint)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v51+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v586 @ X0_v51] (should have been resolved before IL gen)");
		bool flag17 = ex2 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X0_v51+8]");
		text = (string)0;
		if (!flag17)
		{
			goto IL_068a;
		}
		goto IL_07cf;
	}
}
