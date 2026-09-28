using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.Networking;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

namespace Social;

public static class TwitterRequests
{
	private delegate void LoginCallback(string userId, string email);

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static LoginCallback <>9__72_0;

		public static Action<JsonData> <>9__74_0;

		public static Action<ApiResponseModel> <>9__74_1;

		public static Action<JsonData> <>9__77_1;

		public static Action<ApiResponseModel> <>9__77_0;

		public static Action<ApiResponseModel> <>9__88_1;

		public static Func<KeyValuePair<string, string>, string> <>9__95_0;

		public static Func<KeyValuePair<string, string>, string> <>9__96_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Login>b__72_0(string userId, string email)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0097: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			//IL_0119: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			string accessToken = Prefs.GetString((string)key, (string)defaultValue);
			object key2 = "ThisIsFakeReceiptData" + 2752;
			string secret = Prefs.GetString((string)key2, (string)defaultValue);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SocialUtilities.TwitterLoginCallback(accessToken, secret, userId, email);
		}

		internal void <StartLoginFlow>b__74_0(JsonData userData)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_0078: Expected I, but got O
			//IL_0153: Expected O, but got I
			//IL_0163: Expected O, but got I
			//IL_0185: Expected O, but got I4
			//IL_0107: Expected O, but got I
			//IL_0117: Expected O, but got I
			//IL_0127: Expected O, but got I
			//IL_00c2: Expected O, but got I
			//IL_00d2: Expected O, but got I
			object prop_name = "https://www.kammelna.com/Home/Terms" + 424;
			JsonData jsonData = userData.get_Item((string)prop_name);
			object prop_name2 = "destinationTimeZone" + 1896;
			string text = jsonData.ToString();
			JsonData jsonData2 = userData.get_Item((string)prop_name2);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			nint num = (nint)jsonData2;
			string text2 = jsonData2.ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+E4]");
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v10+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+10]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+10]");
				if ((nint)0 != 0)
				{
					goto IL_00f7;
				}
				return;
			}
			goto IL_0131;
			IL_0131:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v13+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+10]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+10]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				return;
			}
			goto IL_00f7;
			IL_00f7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v87 @ X4_v1 (should have been resolved before IL gen)");
			goto IL_0131;
		}

		internal void <StartLoginFlow>b__74_1(ApiResponseModel response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Expected O, but got Unknown
			//IL_02a7: Expected O, but got I
			//IL_02c1: Expected O, but got I4
			//IL_009d: Expected O, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_00ec: Expected O, but got I4
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Expected O, but got Unknown
			//IL_021c: Expected O, but got I
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected O, but got Unknown
			//IL_030e: Expected O, but got I4
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Expected O, but got Unknown
			//IL_01a0: Expected O, but got I4
			//IL_0372: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HttpQSCollection httpQSCollection = default(HttpQSCollection);
			httpQSCollection..ctor(response.<PlainTextResponse>k__BackingField);
			Dictionary<string, string> dictionary = httpQSCollection.ToDictionary();
			object obj2 = "not" + 704;
			object obj3 = (nint)0 + (nint)744;
			if (((Dictionary<object, object>)(object)dictionary).ContainsKey(obj2))
			{
				object obj4 = (nint)0 + (nint)784;
				object obj5 = ((Dictionary<object, object>)(object)dictionary).get_Item(obj2);
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				string stringToEscape = (string)obj5;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					stringToEscape = (string)obj5;
				}
				string value = Uri.EscapeDataString(stringToEscape);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				HttpQSCollection httpQSCollection2 = default(HttpQSCollection);
				httpQSCollection2..ctor();
				((NameValueCollection)httpQSCollection2).set_Item((string)obj2, value);
				object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
				object arg = "getSecondRescanTask" + 3816;
				string url = string.Format((string)format, arg, httpQSCollection2);
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+B8]");
				object callbackUrl = 0;
				Browser.LaunchUrlWithCallback(url, (string)callbackUrl);
				return;
			}
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EDF]");
				object obj14 = (nint)0 & (nint)1;
				if (obj14 != null)
				{
					goto IL_0239;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EDF]");
				object obj15 = (nint)0 & (nint)1;
				bool flag3 = obj15 == null;
				object obj16 = !flag3;
				if (obj16 != null)
				{
					goto IL_0239;
				}
			}
			_ = 1;
			object obj17 = "UInt16" + 3176;
			object obj18 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			object message = obj17;
			if (obj19 != null)
			{
				goto IL_027d;
			}
			goto IL_0324;
			IL_0239:
			obj17 = "UInt16" + 3176;
			obj18 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			message = obj17;
			if (!flag5)
			{
				goto IL_027d;
			}
			goto IL_0324;
			IL_0324:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_027d:
			TwitterError((string)obj17);
		}

		internal void <GetAccessToken>b__77_0(ApiResponseModel response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_044b: Expected O, but got I
			//IL_0465: Expected O, but got I4
			//IL_009d: Expected O, but got I
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected O, but got Unknown
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_0244: Expected O, but got I
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Expected O, but got Unknown
			//IL_02de: Expected O, but got I
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Expected O, but got Unknown
			//IL_04b2: Expected O, but got I4
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_012e: Expected O, but got I4
			//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fd: Expected O, but got Unknown
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_051d: Expected O, but got Unknown
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Expected O, but got Unknown
			//IL_032a: Expected O, but got I
			//IL_033a: Expected O, but got I
			//IL_035c: Expected O, but got I4
			//IL_0167: Expected O, but got I
			//IL_0177: Expected O, but got I
			//IL_038c: Expected O, but got I4
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Expected O, but got Unknown
			//IL_059a: Expected O, but got I
			//IL_05a2: Expected I, but got O
			//IL_05b3: Expected I, but got O
			//IL_05d1: Expected O, but got I
			//IL_03eb: Expected O, but got I4
			//IL_03bc: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HttpQSCollection httpQSCollection = default(HttpQSCollection);
			httpQSCollection..ctor(response.<PlainTextResponse>k__BackingField);
			Dictionary<string, string> dictionary = httpQSCollection.ToDictionary();
			object key = "not" + 704;
			object obj2 = (nint)0 + (nint)744;
			object value;
			object obj4;
			object obj6;
			object key2;
			if (((Dictionary<object, object>)(object)dictionary).ContainsKey(key))
			{
				object obj3 = (nint)0 + (nint)784;
				value = ((Dictionary<object, object>)(object)dictionary).get_Item(key);
				obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v28+E4]");
				if ((nint)0 != 0)
				{
					obj6 = "ThisIsFakeReceiptData" + 2760;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED2]");
					object obj7 = (nint)0 & (nint)1;
					bool flag = obj7 == null;
					object obj8 = !flag;
					key2 = obj6;
					if (obj8 == null)
					{
						goto IL_0144;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = "ThisIsFakeReceiptData" + 2760;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED2]");
					object obj9 = (nint)0 & (nint)1;
					if (obj9 == null)
					{
						goto IL_0144;
					}
					key2 = obj6;
				}
				goto IL_04e1;
			}
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj12 = (nint)0 & (nint)1;
				if (obj12 != null)
				{
					goto IL_0261;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj13 = (nint)0 & (nint)1;
				bool flag2 = obj13 == null;
				object obj14 = !flag2;
				if (obj14 != null)
				{
					goto IL_0261;
				}
			}
			_ = 1;
			object obj15 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			object message = obj15;
			if (obj17 != null)
			{
				goto IL_02a5;
			}
			goto IL_04c8;
			IL_04e1:
			Prefs.SetString((string)key2, (string)value);
			object key3 = "not" + 712;
			object obj18 = ((Dictionary<object, object>)(object)dictionary).get_Item(key3);
			object key4 = "ThisIsFakeReceiptData" + 2752;
			Prefs.SetString((string)key4, (string)obj18);
			object obj19 = typeof(TrackedDeviceRaycaster.<>c) + 368;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v39+E4]");
			object obj21;
			Action<JsonData> action;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v39+B8]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v27+20]");
				action = (Action<JsonData>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v27+20]");
				if ((nint)0 != 0)
				{
					goto IL_019c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v39+B8]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v27+20]");
				action = (Action<JsonData>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v27+20]");
				bool flag4 = (nint)0 == 0;
				object obj22 = !flag4;
				if (obj22 != null)
				{
					goto IL_019c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v39+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v34+B8]");
				obj21 = 0;
			}
			object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj26 = (nint)0 + (nint)1040;
			nint num = (nint)obj26;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj21, (IntPtr)obj26);
			object obj27 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v32+B8]");
			object obj28 = (nint)0 + (nint)32;
			obj28 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj29 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v36+E4]");
			bool flag6 = (nint)0 == 0;
			object obj30 = !flag6;
			action = action2;
			string text = (string)(object)action2;
			Action<JsonData> callback = action2;
			if (obj30 != null)
			{
				goto IL_01e3;
			}
			goto IL_0412;
			IL_01e3:
			VerifyCredentials(action);
			return;
			IL_0412:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			VerifyCredentials(callback);
			return;
			IL_019c:
			obj29 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v36+E4]");
			bool flag7 = (nint)0 == 0;
			num = 0;
			text = (string)obj18;
			callback = action;
			if (!flag7)
			{
				goto IL_01e3;
			}
			goto IL_0412;
			IL_0261:
			obj15 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v10+E4]");
			bool flag8 = (nint)0 == 0;
			message = obj15;
			if (!flag8)
			{
				goto IL_02a5;
			}
			goto IL_04c8;
			IL_04c8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_02a5:
			TwitterError((string)obj15);
			return;
			IL_0144:
			_ = 1;
			key2 = obj6;
			goto IL_04e1;
		}

		internal void <GetAccessToken>b__77_1(JsonData userData)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			//IL_0046: Expected I, but got O
			//IL_007d: Expected O, but got I4
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c5: Expected I, but got O
			//IL_00ea: Expected O, but got I
			//IL_00fa: Expected O, but got I
			//IL_01c0: Expected O, but got I
			//IL_01d6: Expected O, but got I
			//IL_0150: Expected O, but got I
			//IL_0166: Expected O, but got I
			//IL_0180: Expected O, but got I4
			//IL_0244: Expected O, but got I
			//IL_0254: Expected O, but got I
			//IL_0264: Expected O, but got I
			object prop_name = "https://www.kammelna.com/Home/Terms" + 424;
			JsonData jsonData = userData.get_Item((string)prop_name);
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			nint num = (nint)jsonData;
			string value = jsonData.ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object prop_name2 = "destinationTimeZone" + 1896;
			object key = "ThisIsFakeReceiptData" + 2784;
			Prefs.SetString((string)key, value);
			JsonData jsonData2 = userData.get_Item((string)prop_name2);
			nint num2 = (nint)jsonData2;
			string text = jsonData2.ToString();
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+10]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v14+E4]");
			object obj7;
			object defaultValue;
			if ((nint)0 != 0)
			{
				obj7 = (nint)0 + (nint)2000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED5]");
				object obj8 = (nint)0 & (nint)1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				defaultValue = obj7;
				if (obj9 == null)
				{
					goto IL_0196;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj7 = (nint)0 + (nint)2000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED5]");
				object obj10 = (nint)0 & (nint)1;
				if (obj10 == null)
				{
					goto IL_0196;
				}
				defaultValue = obj7;
			}
			goto IL_0223;
			IL_0196:
			_ = 1;
			defaultValue = obj7;
			goto IL_0223;
			IL_0223:
			string text2 = Prefs.GetString((string)key, (string)defaultValue);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X20_v4+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X20_v4+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X20_v4+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <SendTweetRequest>b__88_1(ApiResponseModel response)
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected O, but got Unknown
			//IL_01d3: Expected O, but got I
			//IL_01ed: Expected O, but got I4
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0148: Expected O, but got I
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Expected O, but got Unknown
			//IL_023a: Expected O, but got I4
			//IL_0099: Expected I, but got O
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			bool succeeded = response.Succeeded;
			bool flag = !succeeded;
			string text = null;
			if (!flag)
			{
				object obj = "https://www.kammelna.com/Home/Terms" + 424;
				text = (string)obj;
				if (LitJsonExtensions.Contains(response.<JSONResponse>k__BackingField, (string)obj))
				{
					JsonData jsonData = response.<JSONResponse>k__BackingField.get_Item((string)obj);
					nint num = (nint)jsonData;
					string tweetID = jsonData.ToString();
					object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v16+E4]");
					if ((nint)0 != 0)
					{
						SocialUtilities.TwitterComposeCallback(tweetID);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					SocialUtilities.TwitterComposeCallback(tweetID);
					return;
				}
			}
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE3]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					goto IL_0165;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE3]");
				object obj7 = (nint)0 & (nint)1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				if (obj8 != null)
				{
					goto IL_0165;
				}
			}
			_ = 1;
			object obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 936;
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			object message = obj9;
			if (obj11 != null)
			{
				goto IL_01a9;
			}
			goto IL_0250;
			IL_0165:
			obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 936;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			message = obj9;
			if (!flag4)
			{
				goto IL_01a9;
			}
			goto IL_0250;
			IL_01a9:
			TwitterError((string)obj9);
			return;
			IL_0250:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
		}

		internal string <GetSignatureBaseString>b__95_0(KeyValuePair<string, string> pair)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_008d: Expected O, but got I4
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
			object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IntPtr intPtr = default(IntPtr);
			string text = Uri.EscapeDataString((string)(nint)intPtr);
			return (string)pair + (string)obj2 + text;
		}

		internal string <CreateOauthHeader>b__96_0(KeyValuePair<string, string> pair)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0038: Expected O, but got I
			object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 808;
			object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
			IntPtr intPtr = default(IntPtr);
			return (string)pair + (string)obj + (string)(nint)intPtr + (string)obj2;
		}
	}

	private sealed class <>c__DisplayClass78_0
	{
		public Action<JsonData> callback;

		internal void <VerifyCredentials>b__0(ApiResponseModel response)
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_018d: Expected O, but got I
			//IL_01a7: Expected O, but got I4
			//IL_00f7: Expected O, but got I
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected O, but got Unknown
			//IL_01f4: Expected O, but got I4
			//IL_0071: Expected O, but got I
			//IL_0081: Expected O, but got I
			//IL_0091: Expected O, but got I
			if (response.Succeeded)
			{
				Action<JsonData> action = callback;
				if (callback == null)
				{
					return;
				}
				JsonData <JSONResponse>k__BackingField = response.<JSONResponse>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v13 (System.Action`1<SFSLitJson.JsonData>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v13 (System.Action`1<SFSLitJson.JsonData>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v13 (System.Action`1<SFSLitJson.JsonData>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X3_v1 (should have been resolved before IL gen)");
			}
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Logout();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					goto IL_0114;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Logout();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj7 = (nint)0 & (nint)1;
				bool flag = obj7 == null;
				object obj8 = !flag;
				if (obj8 != null)
				{
					goto IL_0114;
				}
			}
			_ = 1;
			object obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			object message = obj9;
			if (obj11 != null)
			{
				goto IL_0158;
			}
			goto IL_020a;
			IL_020a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_0114:
			obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			message = obj9;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_020a;
			IL_0158:
			TwitterError((string)obj9);
		}
	}

	private sealed class <>c__DisplayClass79_0
	{
		public Action<bool> callback;

		internal void <AccessTwitter>b__0(string message)
		{
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0059: Expected O, but got I
			Action<bool> action = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			}
		}

		internal void <AccessTwitter>b__1(JsonData data)
		{
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0059: Expected O, but got I
			Action<bool> action = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			}
		}

		internal void <AccessTwitter>b__2(string name, string email)
		{
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0059: Expected O, but got I
			Action<bool> action = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public Action<string, string, bool> callback;

		internal void <SearchUser>b__0(ApiResponseModel response)
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_018e: Expected O, but got I
			//IL_019e: Expected O, but got I
			//IL_01ae: Expected O, but got I
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_012b: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_014b: Expected O, but got I
			if (response.Succeeded)
			{
				object obj = "https://www.kammelna.com/Home/Terms" + 424;
				if (LitJsonExtensions.Contains(response.<JSONResponse>k__BackingField, (string)obj))
				{
					JsonData jsonData = response.<JSONResponse>k__BackingField.get_Item((string)obj);
					string text = jsonData.ToString();
					object prop_name = "rightCtrl" + 1296;
					JsonData jsonData2 = response.<JSONResponse>k__BackingField.get_Item((string)prop_name);
					string text2 = jsonData2.ToString();
					object name = "placementId" + 1368;
					bool flag = LitJsonExtensions.Get(response.<JSONResponse>k__BackingField, (string)name, defaultValue: false);
					Action<string, string, bool> action = callback;
					if (callback == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12 (System.Action`3<System.String, System.String, System.Boolean>)+18]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12 (System.Action`3<System.String, System.String, System.Boolean>)+40]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v12 (System.Action`3<System.String, System.String, System.Boolean>)+28]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v99 @ X5_v2 (should have been resolved before IL gen)");
				}
			}
			Action<string, string, bool> action2 = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (System.Action`3<System.String, System.String, System.Boolean>)+18]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (System.Action`3<System.String, System.String, System.Boolean>)+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (System.Action`3<System.String, System.String, System.Boolean>)+28]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X5_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass81_0
	{
		public string userId;

		public string[] searchHash;

		public DateTime startDate;

		public DateTime expiryDate;

		public Action<bool> callback;

		public HttpQSCollection queryString;

		internal bool <SearchTweet>g__TweetMatched|0(TweetModel tweet)
		{
			//IL_026e: Expected I4, but got O
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c0: Expected O, but got I
			//IL_00d6: Expected I, but got O
			//IL_00e7: Expected O, but got I
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0239: Expected O, but got I4
			//IL_0242: Expected O, but got I4
			//IL_0180: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			object obj4;
			if (tweet != null)
			{
				if (tweet.UserId == userId)
				{
					if (tweet.Text == null)
					{
						goto IL_0260;
					}
					object value = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3600;
					if (tweet.Text.Contains((string)value))
					{
						object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj2 = (nint)0 + (nint)720;
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor((object)tweet.Text, (IntPtr)obj2);
						object obj3 = (nint)0 + (nint)1952;
						if (Enumerable.All(searchHash, func))
						{
							obj4 = typeof(DataRelation) + 712;
							object obj5 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v14+E4]");
							if ((nint)0 != 0)
							{
								bool flag = tweet.CreatedAt > startDate;
								bool flag2 = !flag;
								object obj6 = 0;
								DateTime dateTime = startDate;
								if (!flag2)
								{
									goto IL_0198;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								bool flag3 = tweet.CreatedAt > startDate;
								bool flag4 = !flag3;
								object obj7 = !flag4;
								object obj6 = 0;
								DateTime dateTime = startDate;
								if (obj7 != null)
								{
									goto IL_0198;
								}
							}
						}
					}
				}
				return false;
			}
			goto IL_0260;
			IL_0260:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0198:
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return tweet.CreatedAt < expiryDate;
		}

		internal void <SearchTweet>b__1(bool success)
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected O, but got Unknown
			//IL_003e: Expected O, but got I
			//IL_004e: Expected O, but got I
			//IL_005e: Expected O, but got I
			//IL_0199: Expected O, but got I
			//IL_01a7: Expected I, but got O
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_01e5: Expected O, but got I4
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			if (success)
			{
				Action<bool> action = callback;
				if (callback == null)
				{
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v28 (System.Action`1<System.Boolean>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v28 (System.Action`1<System.Boolean>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v28 (System.Action`1<System.Boolean>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v7 (should have been resolved before IL gen)");
			}
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HttpQSCollection httpQSCollection = default(HttpQSCollection);
			httpQSCollection..ctor();
			object name = "tournament_participate_warning_body_with_tickets_warning_daily" + 4016;
			((NameValueCollection)httpQSCollection).set_Item((string)name, userId);
			object name2 = "com.unity.services.authentication.profile" + 1440;
			object value = "1.2.840.113549.1.12.1.5" + 1192;
			((NameValueCollection)httpQSCollection).set_Item((string)name2, (string)value);
			object name3 = "https://www.kammelna.com/Home/Terms" + 856;
			object value2 = "destinationTimeZone" + 3848;
			((NameValueCollection)httpQSCollection).set_Item((string)name3, (string)value2);
			object name4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 616;
			object value3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 680;
			((NameValueCollection)httpQSCollection).set_Item((string)name4, (string)value3);
			object obj5 = this + 56;
			obj5 = httpQSCollection;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = typeof(List<Tween>) + 3592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)1136;
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor((object)this, (IntPtr)obj7);
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object apiEndpoint = "getSecondRescanTask" + 3792;
			SearchTweetInternal((string)apiEndpoint, (HttpQSCollection)obj5, predicate, callback);
		}
	}

	private sealed class <>c__DisplayClass82_0
	{
		public Predicate<TweetModel> tweetPredicate;

		public Action<bool> callback;

		internal void <SearchTweetInternal>b__0(ApiResponseModel response)
		{
			//IL_019f: Expected O, but got I4
			//IL_02a3: Expected O, but got I
			//IL_02b3: Expected O, but got I
			//IL_02c3: Expected O, but got I
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Expected O, but got Unknown
			//IL_011e: Expected O, but got I4
			//IL_01d6: Expected O, but got I4
			bool flag = response == null;
			JsonData jsonData = (JsonData)(object)response;
			if (!flag)
			{
				if (response.Succeeded && response.<JSONResponse>k__BackingField != null && response.<JSONResponse>k__BackingField.IsArray)
				{
					int count = response.<JSONResponse>k__BackingField.Count;
					if (count >= 1)
					{
						object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2384;
						int num = 0;
						TweetModel tweetModel = default(TweetModel);
						object obj2 = default(object);
						while (true)
						{
							JsonData jsonData2 = response.<JSONResponse>k__BackingField.get_Item(num);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							tweetModel..ctor(jsonData2);
							Predicate<TweetModel> predicate = tweetPredicate;
							bool flag2 = tweetPredicate == null;
							jsonData = jsonData2;
							if (flag2)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ X8_v10 (System.Predicate`1<Social.TweetModel>)+18] (should have been resolved before IL gen)");
							bool flag3 = obj2 == null;
							object obj3 = !flag3;
							if (obj3 == null)
							{
								num++;
								int count2 = response.<JSONResponse>k__BackingField.Count;
								if (num < count2)
								{
									continue;
								}
								goto IL_016d;
							}
							goto IL_01a4;
						}
						goto IL_01dc;
					}
				}
				goto IL_016d;
			}
			goto IL_01dc;
			IL_01a4:
			Action<bool> action = callback;
			if (callback != null)
			{
				object obj4 = 1;
				goto IL_0293;
			}
			return;
			IL_016d:
			action = callback;
			if (callback != null)
			{
				object obj4 = 0;
				goto IL_0293;
			}
			return;
			IL_01dc:
			throw new NullReferenceException();
			IL_0293:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (System.Action`1<System.Boolean>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (System.Action`1<System.Boolean>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v5 (System.Action`1<System.Boolean>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v225 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass84_0
	{
		public Action<bool> callback;

		internal void <CheckFollowing>b__0(ApiResponseModel response)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0164: Expected O, but got I4
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I4
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_01dc: Expected O, but got I4
			object obj;
			JsonData connections;
			if (response.Succeeded)
			{
				obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					if (<CheckFollowing>g__GetConnections|84_1(response.<JSONResponse>k__BackingField, out connections))
					{
						goto IL_009b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag = <CheckFollowing>g__GetConnections|84_1(response.<JSONResponse>k__BackingField, out connections);
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						goto IL_009b;
					}
				}
			}
			Action<bool> action = callback;
			if (callback == null)
			{
				return;
			}
			bool flag3 = false;
			goto IL_01f2;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ X8_v4 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			return;
			IL_009b:
			string text = connections.ToJson();
			object value = "fetch_products" + 904;
			bool flag4 = text.Contains((string)value);
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj5 = !flag5;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "ThisIsFakeReceiptData" + 2768;
			Prefs.SetBool((string)key, flag4);
			action = callback;
			bool flag6 = callback == null;
			object obj6 = !flag6;
			flag3 = flag4;
			if (obj6 == null)
			{
				return;
			}
			goto IL_01f2;
		}
	}

	private sealed class <>c__DisplayClass85_0
	{
		public Action callback;

		internal void <SendFollowAccount>b__0(ApiResponseModel response)
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0182: Expected O, but got I4
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_00dc: Expected O, but got I
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01cf: Expected O, but got I4
			if (response.Succeeded)
			{
				Action action = callback;
				if (callback == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_00f9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_00f9;
				}
			}
			_ = 1;
			object obj6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object message = obj6;
			if (obj8 != null)
			{
				goto IL_013d;
			}
			goto IL_01e5;
			IL_01e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_00f9:
			obj6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			message = obj6;
			if (!flag3)
			{
				goto IL_013d;
			}
			goto IL_01e5;
			IL_013d:
			TwitterError((string)obj6);
		}
	}

	private sealed class <>c__DisplayClass86_0
	{
		public Action callback;

		public string screenName;

		internal void <FollowAccount>b__0(bool isFollowing)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_00de: Expected O, but got I
			//IL_00be: Expected O, but got I
			if (isFollowing)
			{
				Action action = callback;
				if (callback == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			Action action2 = callback;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				SendFollowAccount((string)(nint)((Delegate)action2).invoke_impl, callback);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SendFollowAccount((string)(nint)((Delegate)action2).invoke_impl, callback);
		}
	}

	private sealed class <>c__DisplayClass87_0
	{
		public string tweetText;

		public string attachedImagePath;

		internal void <PostTweet>b__0(string userId, string email)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a9: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_012b: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
			string accessToken = Prefs.GetString((string)key, (string)defaultValue);
			object key2 = "ThisIsFakeReceiptData" + 2752;
			string secret = Prefs.GetString((string)key2, (string)defaultValue);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SocialUtilities.TwitterLinkCallback(accessToken, secret, userId);
			PostTweet(tweetText, attachedImagePath);
		}

		internal void <PostTweet>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f7: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EB3]");
			object obj3 = (nint)0 & (nint)1;
			string text;
			string text2;
			string text3;
			string text4;
			if (obj3 != null)
			{
				text = tweetText;
				text2 = attachedImagePath;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				text3 = tweetText;
				text4 = attachedImagePath;
				if (!flag)
				{
					goto IL_00a5;
				}
			}
			else
			{
				_ = 1;
				text = tweetText;
				text2 = attachedImagePath;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				text3 = tweetText;
				text4 = attachedImagePath;
				if (obj5 != null)
				{
					goto IL_00a5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SendTweetRequest(text3, text4);
			return;
			IL_00a5:
			SendTweetRequest(text, text2);
		}
	}

	private sealed class <>c__DisplayClass88_0
	{
		public string tweetText;

		internal void <SendTweetRequest>g__SendTweet|0(long mediaId = 0L)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0071: Expected O, but got I4
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_014e: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I4
			//IL_026c: Expected O, but got I
			//IL_027c: Expected O, but got I
			//IL_029e: Expected O, but got I4
			//IL_0205: Expected O, but got I
			//IL_0215: Expected O, but got I
			//IL_0237: Expected O, but got I4
			//IL_02ce: Expected O, but got I4
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Expected O, but got Unknown
			//IL_035b: Expected O, but got I
			//IL_036c: Expected I, but got O
			//IL_038a: Expected O, but got I
			//IL_02fe: Expected O, but got I
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HttpQSCollection httpQSCollection = default(HttpQSCollection);
			httpQSCollection..ctor();
			object name = "startPosition" + 184;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			string text = tweetText;
			((NameValueCollection)httpQSCollection).set_Item((string)name, tweetText);
			bool flag = mediaId < 1;
			object obj3 = 0;
			if (!flag)
			{
				object name2 = "m_StencilDeferredPS" + 1080;
				long num = default(long);
				string text2 = num.ToString();
				((NameValueCollection)httpQSCollection).set_Item((string)name2, text2);
				obj3 = 0;
				text = text2;
			}
			object method = "October" + 2264;
			object obj4 = "getSecondRescanTask" + 3784;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
			object obj5 = typeof(SqlSingle[]) + 1872;
			object obj6 = typeof(TrackedDeviceRaycaster.<>c) + 368;
			Dictionary<string, string> data = httpQSCollection.ToDictionary();
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj4, data);
			string signature = default(string);
			string timestamp = default(string);
			string nonce = default(string);
			Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
			string url = string.Format((string)format, obj4, httpQSCollection);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
			<>f__AnonymousType..ctor();
			object obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v22+E4]");
			object obj10;
			Action<ApiResponseModel> callback;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v22+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+30]");
				callback = (Action<ApiResponseModel>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+30]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					goto IL_02ac;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v22+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+30]");
				callback = (Action<ApiResponseModel>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+30]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					goto IL_02ac;
				}
			}
			goto IL_0303;
			IL_0303:
			WebRequest.SendPostHttpRequest(url, <>f__AnonymousType, callback, headers);
			return;
			IL_02ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v16+B8]");
				obj10 = 0;
			}
			object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1064;
			Action<object> action = default(Action<object>);
			action..ctor(obj10, (IntPtr)obj16);
			object obj17 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v15+B8]");
			object obj18 = (nint)0 + (nint)48;
			obj18 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			callback = action;
			goto IL_0303;
		}
	}

	private sealed class <>c__DisplayClass89_0
	{
		public string filePath;

		public Action<long> callback;

		internal void <UploadMedia>b__0(long mediaId)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_008f: Expected I, but got O
			//IL_00b9: Expected O, but got I4
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)1208;
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj6 = obj2 + 24;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj4);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MediaUploadAppend(filePath, mediaId, action);
		}
	}

	private sealed class <>c__DisplayClass89_1
	{
		public long mediaId;

		public <>c__DisplayClass89_0 CS$<>8__locals1;

		public Action <>9__2;

		internal void <UploadMedia>b__1()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			//IL_0138: Expected I8, but got I
			//IL_0152: Expected O, but got I4
			//IL_016a: Expected I8, but got I
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0073: Expected I8, but got I
			//IL_009a: Expected I8, but got I
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			//IL_01a2: Expected O, but got I
			//IL_01aa: Expected I, but got O
			//IL_01b8: Expected I, but got O
			//IL_01fb: Expected O, but got I4
			//IL_0213: Expected I, but got O
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EB6]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			Action action;
			long num;
			object obj5;
			long num2;
			if (obj2 != null)
			{
				obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj4 = this + 32;
				action = (Action)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num = 0L;
				bool flag = obj4 == null;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num2 = 0L;
				if (!flag)
				{
					goto IL_00a8;
				}
			}
			else
			{
				_ = 1;
				obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj4 = this + 32;
				action = (Action)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num = 0L;
				bool flag2 = obj4 == null;
				object obj6 = !flag2;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X22_v2-10]");
				num2 = 0L;
				if (obj6 != null)
				{
					goto IL_00a8;
				}
			}
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)1216;
			nint num3 = (nint)obj8;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj8);
			<>9__2 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			action = action2;
			num = num2;
			nint num4 = (nint)obj8;
			Action action3 = action2;
			if (obj10 != null)
			{
				goto IL_00ed;
			}
			goto IL_0229;
			IL_00ed:
			MediaUploadFinalize(num, action);
			return;
			IL_0229:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num3 = num4;
			action = action3;
			num = num2;
			goto IL_00ed;
			IL_00a8:
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v1+E4]");
			bool flag4 = (nint)0 == 0;
			num4 = num3;
			action3 = action;
			num2 = num;
			if (!flag4)
			{
				goto IL_00ed;
			}
			goto IL_0229;
		}

		internal void <UploadMedia>b__2()
		{
			//IL_0058: Expected O, but got I
			//IL_0068: Expected O, but got I
			//IL_0078: Expected O, but got I
			<>c__DisplayClass89_0 cS$<>8__locals = CS$<>8__locals1;
			Action<long> callback = cS$<>8__locals.callback;
			if (cS$<>8__locals.callback != null)
			{
				long num = mediaId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.Int64>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.Int64>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v2 (System.Action`1<System.Int64>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v27 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass90_0
	{
		public Action<long> callback;

		internal void <MediaUploadInit>b__0(ApiResponseModel response)
		{
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_01e3: Expected O, but got I
			//IL_01fd: Expected O, but got I4
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0158: Expected O, but got I
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_024a: Expected O, but got I4
			//IL_00d7: Expected O, but got I
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			bool succeeded = response.Succeeded;
			bool flag = !succeeded;
			string text = null;
			if (!flag)
			{
				object obj = "m_StencilDeferredPS" + 1072;
				text = (string)obj;
				if (LitJsonExtensions.Contains(response.<JSONResponse>k__BackingField, (string)obj))
				{
					Action<long> action = callback;
					if (callback == null)
					{
						return;
					}
					JsonData jsonData = response.<JSONResponse>k__BackingField.get_Item((string)obj);
					long num = (long)jsonData;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X20_v15 (System.Action`1<System.Int64>)+18]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X20_v15 (System.Action`1<System.Int64>)+40]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X20_v15 (System.Action`1<System.Int64>)+28]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v89 @ X3_v1 (should have been resolved before IL gen)");
				}
			}
			object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj7 = (nint)0 & (nint)1;
				if (obj7 != null)
				{
					goto IL_0175;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj8 = (nint)0 & (nint)1;
				bool flag2 = obj8 == null;
				object obj9 = !flag2;
				if (obj9 != null)
				{
					goto IL_0175;
				}
			}
			_ = 1;
			object obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object message = obj10;
			if (obj12 != null)
			{
				goto IL_01b9;
			}
			goto IL_0260;
			IL_01b9:
			TwitterError((string)obj10);
			return;
			IL_0260:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_0175:
			obj10 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			message = obj10;
			if (!flag4)
			{
				goto IL_01b9;
			}
			goto IL_0260;
		}
	}

	private sealed class <>c__DisplayClass91_0
	{
		public Action callback;

		internal void <MediaUploadAppend>b__0(ApiResponseModel response)
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0182: Expected O, but got I4
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_00dc: Expected O, but got I
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Expected O, but got Unknown
			//IL_01cf: Expected O, but got I4
			if (response.Succeeded)
			{
				Action action = callback;
				if (callback == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_00f9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_00f9;
				}
			}
			_ = 1;
			object obj6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object message = obj6;
			if (obj8 != null)
			{
				goto IL_013d;
			}
			goto IL_01e5;
			IL_01e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_00f9:
			obj6 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			message = obj6;
			if (!flag3)
			{
				goto IL_013d;
			}
			goto IL_01e5;
			IL_013d:
			TwitterError((string)obj6);
		}
	}

	private sealed class <>c__DisplayClass92_0
	{
		public Action callback;

		public long mediaId;

		internal void <MediaUploadFinalize>b__0(ApiResponseModel response)
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_024d: Expected O, but got I
			//IL_0267: Expected O, but got I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Expected O, but got Unknown
			//IL_02b4: Expected O, but got I4
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			object obj4 = default(object);
			if (response.Succeeded)
			{
				object obj = "placementId" + 1064;
				if (LitJsonExtensions.Contains(response.<JSONResponse>k__BackingField, (string)obj))
				{
					JsonData jsonData = response.<JSONResponse>k__BackingField.get_Item((string)obj);
					object prop_name = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3152;
					JsonData jsonData2 = jsonData.get_Item((string)prop_name);
					int delay = (int)jsonData2;
					object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v18+E4]");
					if ((nint)0 != 0)
					{
						GetMediaUploadStatus(mediaId, delay, callback);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					GetMediaUploadStatus(mediaId, delay, callback);
					return;
				}
				Action action = callback;
				if (callback == null)
				{
					return;
				}
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
			}
			else
			{
				obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
					object obj6 = (nint)0 & (nint)1;
					if (obj6 != null)
					{
						goto IL_0185;
					}
					goto IL_0275;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
			object obj7 = (nint)0 & (nint)1;
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_0185;
			}
			goto IL_0275;
			IL_0185:
			object obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object message = obj9;
			if (!flag2)
			{
				goto IL_01c9;
			}
			goto IL_02ca;
			IL_02ca:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			TwitterError((string)message);
			return;
			IL_0275:
			_ = 1;
			obj9 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			message = obj9;
			if (obj11 != null)
			{
				goto IL_01c9;
			}
			goto IL_02ca;
			IL_01c9:
			TwitterError((string)obj9);
		}
	}

	private sealed class <>c__DisplayClass93_0
	{
		public long mediaId;

		public Action callback;

		public Action<ApiResponseModel> <>9__1;

		internal unsafe void <GetMediaUploadStatus>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected I8, but got Unknown
			//IL_00f0: Expected O, but got I4
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_017c: Expected O, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I
			//IL_01c2: Expected I, but got O
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HttpQSCollection httpQSCollection = default(HttpQSCollection);
			httpQSCollection..ctor();
			object name = "com.unity.services.authentication.profile" + 120;
			object value = "SERVICE_DISABLED" + 760;
			object name2 = "m_StencilDeferredPS" + 1072;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object method = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1848;
			object obj3 = "getSecondRescanTask" + 4024;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
			((NameValueCollection)httpQSCollection).set_Item((string)name, (string)value);
			long num = this + 16;
			string value2 = ((long*)num)->ToString();
			((NameValueCollection)httpQSCollection).set_Item((string)name2, value2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj3);
			string signature = default(string);
			string timestamp = default(string);
			string nonce = default(string);
			Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
			string url = string.Format((string)format, obj3, httpQSCollection);
			object obj6 = this + 32;
			Action<object> action = (Action<object>)obj6;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1256;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj9);
				<>9__1 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action = action2;
			}
			WebRequest.SendGetHttpRequest(url, action, headers);
		}

		internal void <GetMediaUploadStatus>b__1(ApiResponseModel response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I
			//IL_03c8: Expected O, but got I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_0081: Expected I, but got O
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Expected O, but got Unknown
			//IL_0323: Expected O, but got I
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Expected O, but got Unknown
			//IL_0415: Expected O, but got I4
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0465: Expected O, but got I
			//IL_047f: Expected O, but got I4
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_0274: Expected O, but got I
			//IL_0214: Expected O, but got I4
			//IL_04bd: Expected O, but got I4
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected O, but got Unknown
			//IL_02db: Expected I, but got O
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			bool succeeded = response.Succeeded;
			bool flag = !succeeded;
			string text = null;
			nint num;
			object obj11;
			if (!flag)
			{
				object obj2 = "placementId" + 1064;
				text = (string)obj2;
				bool flag2 = LitJsonExtensions.Contains(response.<JSONResponse>k__BackingField, (string)obj2);
				bool flag3 = !flag2;
				num = unchecked((nint)null);
				if (!flag3)
				{
					JsonData jsonData = response.<JSONResponse>k__BackingField.get_Item((string)obj2);
					object prop_name = "startPosition" + 112;
					JsonData jsonData2 = jsonData.get_Item((string)prop_name);
					string text2 = jsonData2.ToString();
					object obj3 = "startPosition" + 1320;
					if (text2 == (string)obj3)
					{
						Action action = callback;
						if (callback == null)
						{
							return;
						}
						IntPtr invoke_impl = ((Delegate)action).invoke_impl;
						IntPtr method_code = ((Delegate)action).method_code;
						IntPtr method = ((Delegate)action).method;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v12 (System.IntPtr) (should have been resolved before IL gen)");
					}
					object obj4 = "https://www.kammelna.com/Home/Terms" + 792;
					text = (string)obj4;
					if (text2 == (string)obj4)
					{
						object prop_name2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3152;
						JsonData jsonData3 = jsonData.get_Item((string)prop_name2);
						int delay = (int)jsonData3;
						object obj5 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v36+E4]");
						bool flag4 = (nint)0 == 0;
						object obj6 = !flag4;
						if (obj6 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						GetMediaUploadStatus(mediaId, delay, callback);
						return;
					}
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v33+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
						object obj8 = (nint)0 & (nint)1;
						if (obj8 != null)
						{
							goto IL_0291;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
						object obj9 = (nint)0 & (nint)1;
						bool flag5 = obj9 == null;
						object obj10 = !flag5;
						if (obj10 != null)
						{
							goto IL_0291;
						}
					}
					_ = 1;
					obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v34+E4]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					if (obj12 != null)
					{
						goto IL_02be;
					}
					goto IL_04cb;
				}
			}
			goto IL_02e0;
			IL_042b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object message;
			TwitterError((string)message);
			return;
			IL_0340:
			object obj13 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v8+E4]");
			bool flag7 = (nint)0 == 0;
			message = obj13;
			if (!flag7)
			{
				goto IL_0384;
			}
			goto IL_042b;
			IL_04cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_02be;
			IL_02be:
			object message2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			TwitterError((string)message2);
			num = unchecked((nint)null);
			goto IL_02e0;
			IL_0291:
			obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02be;
			}
			goto IL_04cb;
			IL_02e0:
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj16 = (nint)0 & (nint)1;
				if (obj16 != null)
				{
					goto IL_0340;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
				object obj17 = (nint)0 & (nint)1;
				bool flag8 = obj17 == null;
				object obj18 = !flag8;
				if (obj18 != null)
				{
					goto IL_0340;
				}
			}
			_ = 1;
			obj13 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v8+E4]");
			bool flag9 = (nint)0 == 0;
			object obj19 = !flag9;
			message = obj13;
			if (obj19 != null)
			{
				goto IL_0384;
			}
			goto IL_042b;
			IL_0384:
			TwitterError((string)obj13);
		}
	}

	public static readonly string OauthCallbackScheme;

	public static readonly string OauthCallbackUrl;

	private const string OauthConsumerKey = "anoDsN7V6x0e3wTcNuETLJACI";

	private const string OauthConsumerSecret = "mXVKhNCuXFz8IlzuFXizcA1WKZLNxmaNE7arzMtHlpjbvOirJX";

	private const string KammelnaAccountHandle = "Kammelna";

	private const string RequestTokenUrl = "https://api.twitter.com/oauth/request_token";

	private const string AuthorizeUrl = "https://api.twitter.com/oauth/authorize";

	private const string AccessTokenUrl = "https://api.twitter.com/oauth/access_token";

	private const string VerifyCredentialsUrl = "https://api.twitter.com/1.1/account/verify_credentials.json";

	private const string UsersLookupUrl = "https://api.twitter.com/1.1/users/show.json";

	private const string UserTimelineLookupUrl = "https://api.twitter.com/1.1/statuses/user_timeline.json";

	private const string HomeTimelineLookupUrl = "https://api.twitter.com/1.1/statuses/home_timeline.json";

	private const string FriendshipsLookupUrl = "https://api.twitter.com/1.1/friendships/lookup.json";

	private const string FriendshipsRequestUrl = "https://api.twitter.com/1.1/friendships/create.json";

	private const string PostTweetUrl = "https://api.twitter.com/1.1/statuses/update.json";

	private const string MediaUploadUrl = "https://upload.twitter.com/1.1/media/upload.json";

	private const string ParamConsumerKey = "oauth_consumer_key";

	private const string ParamSignatureMethod = "oauth_signature_method";

	private const string ParamTimestamp = "oauth_timestamp";

	private const string ParamNonce = "oauth_nonce";

	private const string ParamOauthVersion = "oauth_version";

	private const string ParamOauthSignature = "oauth_signature";

	private const string ParamOauthCallback = "oauth_callback";

	private const string ParamRequestToken = "oauth_token";

	private const string ParamOauthVerifier = "oauth_verifier";

	private const string ParamDenied = "denied";

	private const string ParamAccessToken = "oauth_token";

	private const string ParamAccessSecret = "oauth_token_secret";

	private const string ParamUserId = "id_str";

	private const string ParamEmail = "email";

	private const string ParamIncludeEntities = "include_entities";

	private const string ParamSkipStatus = "skip_status";

	private const string ParamIncludeEmail = "include_email";

	private const string ParamTwitterId = "user_id";

	private const string ParamScreenName = "screen_name";

	private const string ParamProtected = "protected";

	private const string ParamConnections = "connections";

	private const string ParamFollowing = "following";

	private const string ParamCommand = "command";

	private const string ParamMediaId = "media_id";

	private const string ParamTotalBytes = "total_bytes";

	private const string ParamMediaType = "media_type";

	private const string ParamMediaData = "media";

	private const string ParamSegment = "segment_index";

	private const string ParamMediaCategory = "media_category";

	private const string ParamProcessingInfo = "processing_info";

	private const string ParamCheckSecs = "check_after_secs";

	private const string ParamState = "state";

	private const string StateSucceeded = "succeeded";

	private const string StateProcessing = "in_progress";

	private const string ParamStatus = "status";

	private const string ParamMediaIds = "media_ids";

	private const string ParamTweetId = "id_str";

	private const string SignatureMethod = "HMAC-SHA1";

	private const string OauthVersion = "1.0";

	private static LoginCallback loginCallback;

	private static Action<string> errorCallback;

	public static bool HasActiveSession
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0095: Expected O, but got I4
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0057: Expected O, but got I
			//IL_00de: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object key = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			string value = Prefs.GetString((string)key, (string)defaultValue);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = StringsExtensions.IsNullOrEmpty(value);
			return (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		}
	}

	private static string AccessToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object key = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			return Prefs.GetString((string)key, (string)defaultValue);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 2760;
			Prefs.SetString((string)key, value);
		}
	}

	private static string AccessSecret
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object key = "ThisIsFakeReceiptData" + 2752;
			object defaultValue = (nint)0 + (nint)2000;
			return Prefs.GetString((string)key, (string)defaultValue);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 2752;
			Prefs.SetString((string)key, value);
		}
	}

	public static string TwitterId
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object key = "ThisIsFakeReceiptData" + 2784;
			object defaultValue = (nint)0 + (nint)2000;
			return Prefs.GetString((string)key, (string)defaultValue);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 2784;
			Prefs.SetString((string)key, value);
		}
	}

	private static bool FollowingKammelna
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 2768;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "ThisIsFakeReceiptData" + 2768;
			Prefs.SetBool((string)key, value);
		}
	}

	public static void Login()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_0218: Expected O, but got I4
		//IL_01b6: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0396: Expected O, but got I
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_02e2: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0416: Expected O, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_0466: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E91]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00ca;
		}
		goto IL_01f6;
		IL_011b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v36+B8]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartLoginFlow();
		return;
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12;
		object obj11 = obj12;
		object obj13;
		obj8 = obj13;
		goto IL_011b;
		IL_03e4:
		object obj14 = 35893248 + 2076;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v13+B8]");
		object obj16 = (nint)0 + (nint)8;
		object obj17 = default(object);
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v36+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		obj8 = obj17;
		object obj19 = obj11;
		obj13 = obj17;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_0328;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v4+8]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		goto IL_01f6;
		IL_01f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v21+B8]");
			obj7 = 0;
		}
		object obj22 = typeof(TrackedDeviceRaycaster.<>c) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1056;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v2+8]");
		_ = 0;
		object obj25 = obj17 + 32;
		obj25 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj26 = default(object);
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v2+52]");
			if ((nint)0 != 2)
			{
				goto IL_0309;
			}
			object obj27 = 35893248 + 2204;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X21_v2+52]");
			if ((nint)0 != 1)
			{
				if (obj7 != null)
				{
					goto IL_0309;
				}
				object obj28 = 134782976 + 1449;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
				throw new OutOfMemoryException();
			}
			object obj29 = 35893248 + 2168;
		}
		goto IL_03e4;
		IL_0309:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7+20]");
		_ = 0;
		goto IL_03e4;
		IL_00ca:
		obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v36+E4]");
		bool flag6 = (nint)0 == 0;
		obj19 = obj11;
		obj13 = obj8;
		if (!flag6)
		{
			goto IL_011b;
		}
		goto IL_0328;
	}

	public static void Logout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_0058: Expected O, but got I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+B8]");
		object value = 0;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		object obj5;
		object key;
		if ((nint)0 != 0)
		{
			obj5 = "ThisIsFakeReceiptData" + 2784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED6]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			key = obj5;
			if (obj7 == null)
			{
				goto IL_006e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = "ThisIsFakeReceiptData" + 2784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED6]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 == null)
			{
				goto IL_006e;
			}
			key = obj5;
		}
		goto IL_0136;
		IL_006e:
		_ = 1;
		key = obj5;
		goto IL_0136;
		IL_0136:
		Prefs.SetString((string)key, (string)value);
		object key2 = "ThisIsFakeReceiptData" + 2752;
		Prefs.SetString((string)key2, (string)value);
		object key3 = "ThisIsFakeReceiptData" + 2760;
		Prefs.SetString((string)key3, (string)value);
		object key4 = "ThisIsFakeReceiptData" + 2768;
		Prefs.SetBool((string)key4, value: false);
	}

	private static void StartLoginFlow()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_00c2: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0478: Expected O, but got I
		//IL_0488: Expected O, but got I
		//IL_04aa: Expected O, but got I4
		//IL_0236: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_0355: Expected O, but got I
		//IL_0377: Expected O, but got I4
		//IL_04da: Expected O, but got I4
		//IL_0128: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_062b: Expected O, but got I
		//IL_0633: Expected I, but got O
		//IL_0644: Expected I, but got O
		//IL_0662: Expected O, but got I
		//IL_03a7: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_0552: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_05b3: Expected O, but got I
		//IL_05bb: Expected I, but got O
		//IL_05cc: Expected I, but got O
		//IL_05ea: Expected O, but got I
		//IL_0406: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_03d7: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E92]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(TrackedDeviceRaycaster.<>c) + 368;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v62+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(TrackedDeviceRaycaster.<>c) + 368;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v62+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool hasActiveSession = HasActiveSession;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+E4]");
		object obj10 = 0;
		bool flag3 = !hasActiveSession;
		object obj11 = !flag3;
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+E4]");
		object obj12 = 0;
		object obj13 = obj9;
		if (obj11 != null)
		{
			goto IL_00fb;
		}
		goto IL_027a;
		IL_0570:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Action<ApiResponseModel> callback;
		GetRequestToken(callback);
		return;
		IL_02dc:
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		Action<object> action2 = default(Action<object>);
		Action<object> action = action2;
		Action<ApiResponseModel> action3;
		callback = action3;
		if (!flag4)
		{
			goto IL_0319;
		}
		goto IL_0570;
		IL_043d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Action<JsonData> callback2;
		VerifyCredentials(callback2);
		return;
		IL_00a1:
		bool hasActiveSession2 = HasActiveSession;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+E4]");
		obj10 = 0;
		bool flag5 = !hasActiveSession2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+E4]");
		obj12 = 0;
		obj13 = obj9;
		obj7 = obj4;
		if (!flag5)
		{
			goto IL_00fb;
		}
		goto IL_027a;
		IL_027a:
		object obj15;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
			action3 = (Action<ApiResponseModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
			if ((nint)0 != 0)
			{
				goto IL_02dc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
			action3 = (Action<ApiResponseModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v5+18]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 != null)
			{
				goto IL_02dc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v12+B8]");
			obj15 = 0;
		}
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1080;
		nint num = (nint)obj20;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj15, (IntPtr)obj20);
		object obj21 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v10+B8]");
		object obj22 = (nint)0 + (nint)24;
		obj22 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v2+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		action2 = action4;
		action3 = action4;
		object obj24 = 0;
		action = action4;
		callback = action4;
		if (obj23 != null)
		{
			goto IL_0319;
		}
		goto IL_0570;
		IL_015d:
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v44+E4]");
		bool flag9 = (nint)0 == 0;
		Action<object> action5 = action2;
		Action<JsonData> action6;
		callback2 = action6;
		if (!flag9)
		{
			goto IL_019a;
		}
		goto IL_043d;
		IL_00fb:
		object obj26;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v26+10]");
			action6 = (Action<JsonData>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v26+10]");
			if ((nint)0 != 0)
			{
				goto IL_015d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v26+10]");
			action6 = (Action<JsonData>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v26+10]");
			bool flag10 = (nint)0 == 0;
			object obj27 = !flag10;
			if (obj27 != null)
			{
				goto IL_015d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v47+E4]");
		bool flag11 = (nint)0 == 0;
		object obj28 = !flag11;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v33+B8]");
			obj26 = 0;
		}
		object obj30 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)1072;
		num = (nint)obj31;
		Action<object> action7 = default(Action<object>);
		action7..ctor(obj26, (IntPtr)obj31);
		object obj32 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v31+B8]");
		object obj33 = (nint)0 + (nint)16;
		obj33 = action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v44+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		action2 = action7;
		action6 = action7;
		obj24 = 0;
		action5 = action7;
		callback2 = action7;
		if (obj34 != null)
		{
			goto IL_019a;
		}
		goto IL_043d;
		IL_0319:
		GetRequestToken(action3);
		return;
		IL_019a:
		VerifyCredentials(action6);
	}

	private static void GetRequestToken(Action<ApiResponseModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_010a: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		object obj2 = (nint)0 + (nint)688;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object key = "not" + 656;
		object method = "October" + 2264;
		object url = "getSecondRescanTask" + 3824;
		object obj6 = typeof(SqlSingle[]) + 1872;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X10_v1+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X10_v2+8]");
		dictionary.Add(key, 0);
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)url, (Dictionary<string, string>)(object)dictionary);
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v7+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v8+8]");
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
		<>f__AnonymousType..ctor();
		WebRequest.SendPostHttpRequest((string)url, <>f__AnonymousType, callback, headers);
	}

	public static void HandleAuthResponse(string responseUrl)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I
		//IL_03d0: Expected O, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0230: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_041d: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EDA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v44+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00ee;
		IL_024d:
		object obj5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 952;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v28+E4]");
		bool flag2 = (nint)0 == 0;
		object message = obj5;
		if (!flag2)
		{
			goto IL_0291;
		}
		goto IL_0433;
		IL_0291:
		TwitterError((string)obj5);
		return;
		IL_0433:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0074:
		bool flag3 = responseUrl == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00ee;
		IL_00ee:
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v5+8]");
		if (!responseUrl.StartsWith((string)0, StringComparison.InvariantCultureIgnoreCase))
		{
			return;
		}
		Browser.Dismiss();
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Uri uri = default(Uri);
		uri..ctor(responseUrl);
		string query = uri.Query;
		HttpQSCollection httpQSCollection = HttpUtility.ParseQueryString(query);
		Dictionary<string, string> dictionary = httpQSCollection.ToDictionary();
		object key = "com.unity.services.authentication.profile" + 3840;
		object obj11 = (nint)0 + (nint)744;
		if (((Dictionary<object, object>)(object)dictionary).ContainsKey(key))
		{
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v27+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE0]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					goto IL_024d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE0]");
				object obj14 = (nint)0 & (nint)1;
				bool flag4 = obj14 == null;
				object obj15 = !flag4;
				if (obj15 != null)
				{
					goto IL_024d;
				}
			}
			_ = 1;
			obj5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 952;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			message = obj5;
			if (obj16 != null)
			{
				goto IL_0291;
			}
			goto IL_0433;
		}
		object key2 = "not" + 704;
		if (!((Dictionary<object, object>)(object)dictionary).ContainsKey(key2))
		{
			return;
		}
		object key3 = "not" + 720;
		if (((Dictionary<object, object>)(object)dictionary).ContainsKey(key3))
		{
			object obj17 = (nint)0 + (nint)784;
			object requestToken = ((Dictionary<object, object>)(object)dictionary).get_Item(key2);
			object oauthVerifier = ((Dictionary<object, object>)(object)dictionary).get_Item(key3);
			object obj18 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			GetAccessToken((string)requestToken, (string)oauthVerifier);
		}
	}

	private static void GetAccessToken(string requestToken, string oauthVerifier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_030b: Expected O, but got I
		//IL_031c: Expected I, but got O
		//IL_033a: Expected O, but got I
		//IL_02ae: Expected O, but got I
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "not" + 704;
		object name2 = "not" + 720;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "October" + 2264;
		object obj3 = "getSecondRescanTask" + 3808;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj4 = typeof(SqlSingle[]) + 1872;
		object obj5 = typeof(TrackedDeviceRaycaster.<>c) + 368;
		((NameValueCollection)httpQSCollection).set_Item((string)name, requestToken);
		((NameValueCollection)httpQSCollection).set_Item((string)name2, oauthVerifier);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj3, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string url = string.Format((string)format, obj3, httpQSCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
		<>f__AnonymousType..ctor();
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v22+E4]");
		object obj9;
		Action<ApiResponseModel> callback;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v22+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v10+28]");
			callback = (Action<ApiResponseModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v10+28]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				goto IL_025c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v22+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v10+28]");
			callback = (Action<ApiResponseModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v10+28]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				goto IL_025c;
			}
		}
		goto IL_02b3;
		IL_025c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v22+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v16+B8]");
			obj9 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1032;
		Action<object> action = default(Action<object>);
		action..ctor(obj9, (IntPtr)obj15);
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v15+B8]");
		object obj17 = (nint)0 + (nint)40;
		obj17 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		callback = action;
		goto IL_02b3;
		IL_02b3:
		WebRequest.SendPostHttpRequest(url, <>f__AnonymousType, callback, headers);
	}

	private static void VerifyCredentials(Action<JsonData> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_01fb: Expected O, but got I
		//IL_020c: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "https://www.kammelna.com/Home/Terms" + 848;
		object value = "destinationTimeZone" + 3848;
		object name2 = "setMimeType" + 2904;
		object value2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 680;
		object name3 = "https://www.kammelna.com/Home/Terms" + 840;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1848;
		object obj6 = "getSecondRescanTask" + 3752;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		((NameValueCollection)httpQSCollection).set_Item((string)name, (string)value);
		((NameValueCollection)httpQSCollection).set_Item((string)name2, (string)value2);
		((NameValueCollection)httpQSCollection).set_Item((string)name3, (string)value2);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj6, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string url = string.Format((string)format, obj6, httpQSCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1088;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj10);
		WebRequest.SendGetHttpRequest(url, action, headers);
	}

	public static void AccessTwitter(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_01b8: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_00d0: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0154: Expected I, but got O
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_037e: Expected O, but got I4
		//IL_0443: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_03f0: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1096;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v10+B8]");
			object obj8 = (nint)0 + (nint)24;
			obj8 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool hasActiveSession = HasActiveSession;
			bool flag = !hasActiveSession;
			Action<object> action2 = action;
			Action<object> action3 = action;
			if (!flag)
			{
				goto IL_0119;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v28+B8]");
			object obj10 = (nint)0 + (nint)24;
			obj10 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool hasActiveSession2 = HasActiveSession;
			bool flag2 = !hasActiveSession2;
			object obj11 = !flag2;
			Action<object> action2 = action;
			Action<object> action3 = action;
			if (obj11 != null)
			{
				goto IL_0119;
			}
		}
		object obj12 = typeof(TrackedDeviceRaycaster.<>c) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1112;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X21_v5+8]");
		_ = 0;
		object obj16 = default(object);
		object obj15 = obj16 + 32;
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj17 = default(object);
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X21_v5+52]");
			if ((nint)0 != 2)
			{
				goto IL_0326;
			}
			object obj18 = 35893248 + 2204;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X21_v5+52]");
			if ((nint)0 != 1)
			{
				goto IL_0326;
			}
			object obj18 = 35893248 + 2168;
		}
		object obj19 = 35893248 + 2076;
		object obj20 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj21 = !flag3;
		object obj22;
		if (obj21 == null)
		{
			obj22 = obj20;
			goto IL_0394;
		}
		goto IL_042d;
		IL_0326:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v13+10]");
		_ = 0;
		object obj23 = 35893248 + 2076;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v13+20]");
		_ = 0;
		obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		obj20 = obj22;
		if (obj24 == null)
		{
			goto IL_0394;
		}
		goto IL_042d;
		IL_0394:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj20 = obj5;
		goto IL_042d;
		IL_042d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v18+B8]");
		object obj25 = (nint)0 + (nint)16;
		obj25 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartLoginFlow();
		return;
		IL_0119:
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)1104;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj2, (IntPtr)obj27);
		object obj28 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v36+E4]");
		if ((nint)0 != 0)
		{
			VerifyCredentials(action4);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		VerifyCredentials(action4);
	}

	public static void SearchUser(string twitterID, Action<string, string, bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_01a9: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "tournament_participate_warning_body_with_tickets_warning_daily" + 4016;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1848;
		object obj6 = "getSecondRescanTask" + 3800;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		object obj8 = (nint)0 + (nint)1120;
		((NameValueCollection)httpQSCollection).set_Item((string)name, twitterID);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj6, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string url = string.Format((string)format, obj6, httpQSCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		WebRequest.SendGetHttpRequest(url, action, headers);
	}

	public static void SearchTweet(string userId, string[] searchHash, DateTime startDate, DateTime expiryDate, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01cb: Expected I, but got O
		//IL_01eb: Expected I, but got O
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = searchHash;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 48;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "com.unity.services.authentication.profile" + 1440;
		object value = "1.2.840.113549.1.12.1.5" + 1192;
		object name2 = "https://www.kammelna.com/Home/Terms" + 848;
		object value2 = "destinationTimeZone" + 3848;
		object name3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 616;
		object value3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 680;
		object obj7 = typeof(List<Tween>) + 3592;
		object obj8 = (nint)0 + (nint)1136;
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj10 = (nint)0 + (nint)1128;
		((NameValueCollection)httpQSCollection).set_Item((string)name, (string)value);
		((NameValueCollection)httpQSCollection).set_Item((string)name2, (string)value2);
		((NameValueCollection)httpQSCollection).set_Item((string)name3, (string)value3);
		object obj11 = obj2 + 56;
		obj11 = httpQSCollection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj10);
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v26+E4]");
		bool flag = (nint)0 == 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object apiEndpoint = "getSecondRescanTask" + 3776;
		SearchTweetInternal((string)apiEndpoint, (HttpQSCollection)obj11, predicate, action);
	}

	private static void SearchTweetInternal(string apiEndpoint, HttpQSCollection queryString, Predicate<TweetModel> tweetPredicate, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_0201: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tweetPredicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1848;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj6 = (nint)0 + (nint)3064;
		object obj7 = (nint)0 + (nint)2336;
		object obj8 = typeof(DataRelation) + 856;
		Dictionary<string, string> data = queryString.ToDictionary();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		(string, string, string) tuple = CreateRequestSignature((string)method, apiEndpoint, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string text = string.Format((string)format, apiEndpoint, queryString);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9BF94");
		string text3 = default(string);
		string text2 = text + (string)obj7 + text3;
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		object message = text2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.Log(message);
		string url = string.Format((string)format, apiEndpoint, queryString);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1144;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj14);
		WebRequest.SendGetHttpRequest(url, action, headers);
	}

	public static void CheckFollowingKammelna(Action<bool> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E9A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object account;
		if (obj3 != null)
		{
			obj4 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3600;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			account = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3600;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			account = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CheckFollowing((string)account, callback);
		return;
		IL_0094:
		CheckFollowing((string)obj4, callback);
	}

	public static void CheckFollowing(string account, Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0358: Expected O, but got I
		//IL_0369: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0160;
		}
		object obj6 = "ThisIsFakeReceiptData" + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED7]");
		object obj7 = (nint)0 & (nint)1;
		bool flag = obj7 == null;
		object key = obj6;
		if (!flag)
		{
			goto IL_00c4;
		}
		goto IL_01bf;
		IL_01bf:
		_ = 1;
		bool flag2 = Prefs.GetBool((string)key);
		bool flag3 = !flag2;
		object obj8 = !flag3;
		object obj9 = 0;
		bool flag4 = false;
		if (obj8 != null)
		{
			goto IL_0101;
		}
		goto IL_0212;
		IL_00c4:
		bool flag5 = Prefs.GetBool((string)obj6);
		bool flag6 = !flag5;
		obj9 = 0;
		flag4 = false;
		if (!flag6)
		{
			goto IL_0101;
		}
		goto IL_0212;
		IL_0101:
		object obj10 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v25+18]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v25+40]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v25+28]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X3_v7 (should have been resolved before IL gen)");
			goto IL_0160;
		}
		return;
		IL_0212:
		object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "rightCtrl" + 1296;
		((NameValueCollection)httpQSCollection).set_Item((string)name, account);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object method = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1848;
		object obj17 = "getSecondRescanTask" + 3768;
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj17, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		string url = string.Format((string)format, obj17, httpQSCollection);
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1152;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj19);
		WebRequest.SendGetHttpRequest(url, action, headers);
		return;
		IL_0160:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = "ThisIsFakeReceiptData" + 2768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ED7]");
		object obj20 = (nint)0 & (nint)1;
		bool flag8 = obj20 == null;
		object obj21 = !flag8;
		key = obj6;
		if (obj21 != null)
		{
			goto IL_00c4;
		}
		goto IL_01bf;
	}

	private static void SendFollowAccount(string account, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_01d5: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "rightCtrl" + 1296;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "October" + 2264;
		object obj6 = "getSecondRescanTask" + 3760;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj7 = typeof(SqlSingle[]) + 1872;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		object obj9 = (nint)0 + (nint)1160;
		((NameValueCollection)httpQSCollection).set_Item((string)name, account);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj6, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string url = string.Format((string)format, obj6, httpQSCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
		<>f__AnonymousType..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		WebRequest.SendPostHttpRequest(url, <>f__AnonymousType, action, headers);
	}

	public static void FollowAccount(string screenName, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00dc: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)1168;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = screenName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CheckFollowing((string)obj7, action);
	}

	public static void PostTweet(string tweetText, string attachedImagePath = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_019b: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_03c7: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_0374: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj4 = obj2 + 16;
		obj4 = tweetText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = attachedImagePath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			if (HasActiveSession)
			{
				goto IL_00c5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool hasActiveSession = HasActiveSession;
			bool flag = !hasActiveSession;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00c5;
			}
		}
		object obj8 = typeof(TrackedDeviceRaycaster.<>c) + 504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1176;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X21_v2+8]");
		_ = 0;
		object obj12 = default(object);
		object obj11 = obj12 + 32;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj13 = default(object);
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X21_v2+52]");
			if ((nint)0 != 2)
			{
				goto IL_02c3;
			}
			object obj14 = 35893248 + 2204;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X21_v2+52]");
			if ((nint)0 != 1)
			{
				goto IL_02c3;
			}
			object obj14 = 35893248 + 2168;
		}
		object obj15 = 35893248 + 2076;
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v19+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		object obj18;
		if (obj17 == null)
		{
			obj18 = obj16;
			goto IL_0331;
		}
		goto IL_03b1;
		IL_02c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v14+10]");
		_ = 0;
		object obj19 = 35893248 + 2076;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v14+20]");
		_ = 0;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		obj16 = obj18;
		if (obj20 == null)
		{
			goto IL_0331;
		}
		goto IL_03b1;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj3;
		goto IL_03b1;
		IL_03b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v19+B8]");
		object obj21 = (nint)0 + (nint)16;
		obj21 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartLoginFlow();
		return;
		IL_00c5:
		object obj22 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)1184;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj23);
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v33+E4]");
		bool flag4 = (nint)0 == 0;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object screenName = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3600;
		FollowAccount((string)screenName, action);
	}

	private static void SendTweetRequest(string tweetText, string attachedImagePath = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_00bb: Expected I8, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj4 = obj2 + 16;
		obj4 = tweetText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(attachedImagePath);
			bool flag2 = !flag;
			object obj6 = 0;
			if (!flag2)
			{
				goto IL_00ad;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(attachedImagePath);
			bool flag4 = !flag3;
			object obj7 = !flag4;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_00ad;
			}
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)1192;
		Action<long> action = default(Action<long>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v12+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object mimeType = "https://www.kammelna.com/Home/Terms" + 656;
		UploadMedia(attachedImagePath, (string)mimeType, action);
		return;
		IL_00ad:
		((<>c__DisplayClass88_0)obj2).<SendTweetRequest>g__SendTweet|0(0L);
	}

	private static void UploadMedia(string filePath, string mimeType, Action<long> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00dc: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2424;
		object obj4 = (nint)0 + (nint)1200;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj6 = obj2 + 16;
		obj6 = filePath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<long> action = default(Action<long>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MediaUploadInit((string)obj6, mimeType, action);
	}

	private static void MediaUploadInit(string filePath, string mimeType, Action<long> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_029b: Expected O, but got I
		//IL_02ac: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "com.unity.services.authentication.profile" + 120;
		object value = "HH:mm:ss.ffZ" + 2680;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 400;
		((NameValueCollection)httpQSCollection).set_Item((string)name, (string)value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FileInfo fileInfo = default(FileInfo);
		fileInfo..ctor(filePath);
		object name2 = "startPosition" + 3736;
		object name3 = "m_StencilDeferredPS" + 1088;
		object name4 = "m_StencilDeferredPS" + 1064;
		object value2 = "ThisIsFakeReceiptData" + 2720;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "October" + 2264;
		object obj7 = "getSecondRescanTask" + 4024;
		long length = fileInfo.Length;
		long num = default(long);
		string value3 = num.ToString();
		((NameValueCollection)httpQSCollection).set_Item((string)name2, value3);
		((NameValueCollection)httpQSCollection).set_Item((string)name3, mimeType);
		((NameValueCollection)httpQSCollection).set_Item((string)name4, (string)value2);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v23+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj7, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		string url = string.Format((string)format, obj7, httpQSCollection);
		object obj10 = typeof(SqlSingle[]) + 1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
		<>f__AnonymousType..ctor();
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1224;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj12);
		WebRequest.SendPostHttpRequest(url, <>f__AnonymousType, action, headers);
	}

	private static void MediaUploadAppend(string filePath, long mediaId, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_017d: Expected O, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0332: Expected O, but got I4
		//IL_03b7: Expected O, but got I
		//IL_03c7: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0487: Expected O, but got I4
		//IL_04fc: Expected O, but got I
		//IL_050c: Expected O, but got I
		//IL_051c: Expected O, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_0596: Expected I, but got O
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_0625: Expected O, but got I
		//IL_0645: Expected O, but got I4
		//IL_06ca: Expected O, but got I
		//IL_06da: Expected O, but got I
		//IL_06ea: Expected O, but got I
		//IL_071f: Expected I, but got O
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "October" + 2264;
		object url = "getSecondRescanTask" + 4024;
		object obj4 = typeof(List<AdaptivePerformanceScaler>) + 1528;
		object obj5 = (nint)0 + (nint)64;
		object obj6 = typeof(MemberAchievementClanFeedData) + 1800;
		object name = "com.unity.services.authentication.profile" + 120;
		object obj7 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2664;
		object obj8 = obj2 + 16;
		obj8 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)url);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text = (string)obj7;
		MultipartFormDataSection multipartFormDataSection = default(MultipartFormDataSection);
		multipartFormDataSection..ctor((string)name, (string)obj7);
		object obj11 = (nint)0 + (nint)72;
		object obj12 = obj11;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object name2 = "m_StencilDeferredPS" + 1072;
		bool flag2 = list._size < items.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj14 = items + list._size;
			object obj15 = obj14 + 32;
			obj15 = multipartFormDataSection;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v6+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v24+C0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v25+70]");
			text = (string)0;
			list.AddWithResize((object)multipartFormDataSection);
		}
		long num = default(long);
		string text2 = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MultipartFormDataSection multipartFormDataSection2 = default(MultipartFormDataSection);
		multipartFormDataSection2..ctor((string)name2, text2);
		object obj18 = obj11;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		object name3 = "rightCtrl" + 1712;
		object obj19 = ", stale={0}" + 3424;
		bool flag3 = list._size < items2.Length;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj21 = items2 + list._size;
			object obj22 = obj21 + 32;
			obj22 = multipartFormDataSection2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string text3 = text2;
			object obj23 = multipartFormDataSection2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v8+20]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v21+C0]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v22+70]");
			string text3 = (string)0;
			list.AddWithResize((object)multipartFormDataSection2);
			object obj23 = multipartFormDataSection2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text4 = (string)obj19;
		MultipartFormDataSection multipartFormDataSection3 = default(MultipartFormDataSection);
		multipartFormDataSection3..ctor((string)name3, (string)obj19);
		object obj26 = obj11;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		object obj27 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 400;
		bool flag4 = list._size < items3.Length;
		object obj28 = !flag4;
		if (obj28 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj29 = items3 + list._size;
			object obj30 = obj29 + 32;
			obj30 = multipartFormDataSection3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v10+20]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v18+C0]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v19+70]");
			text4 = (string)0;
			list.AddWithResize((object)multipartFormDataSection3);
		}
		byte[] array = File.ReadAllBytes(filePath);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FileInfo fileInfo = default(FileInfo);
		fileInfo..ctor(filePath);
		object obj33 = typeof(MemberAchievementClanFeedData) + 1808;
		object name4 = "m_StencilDeferredPS" + 1024;
		object contentType = "alignContent" + 2136;
		nint num2 = (nint)fileInfo;
		string name5 = fileInfo.Name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MultipartFormFileSection multipartFormFileSection = default(MultipartFormFileSection);
		multipartFormFileSection..ctor((string)name4, array, name5, (string)contentType);
		object obj34 = obj11;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		object obj35 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		object obj36 = (nint)0 + (nint)1232;
		bool flag5 = list._size < items4.Length;
		object obj37 = !flag5;
		if (obj37 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj38 = items4 + list._size;
			object obj39 = obj38 + 32;
			obj39 = multipartFormFileSection;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			byte[] array2 = array;
			object obj40 = multipartFormFileSection;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v13+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v15+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v16+70]");
			byte[] array2 = (byte[])0;
			list.AddWithResize((object)multipartFormFileSection);
			object obj40 = multipartFormFileSection;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj36);
		WebRequest.SendPostHttpRequest((string)url, list, action, headers);
	}

	private unsafe static void MediaUploadFinalize(long mediaId, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I8, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_0231: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 280;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		long num = obj2 + 24;
		((long*)num)->m_value = mediaId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HttpQSCollection httpQSCollection = default(HttpQSCollection);
		httpQSCollection..ctor();
		object name = "com.unity.services.authentication.profile" + 120;
		object value = "Error reading data from socket: " + 2480;
		object name2 = "m_StencilDeferredPS" + 1072;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object method = "October" + 2264;
		object obj6 = "getSecondRescanTask" + 4024;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1176;
		object obj7 = typeof(SqlSingle[]) + 1872;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1128;
		((NameValueCollection)httpQSCollection).set_Item((string)name, (string)value);
		string value2 = ((long*)num)->ToString();
		((NameValueCollection)httpQSCollection).set_Item((string)name2, value2);
		Dictionary<string, string> data = httpQSCollection.ToDictionary();
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		(string, string, string) tuple = CreateRequestSignature((string)method, (string)obj6, data);
		string signature = default(string);
		string timestamp = default(string);
		string nonce = default(string);
		Dictionary<string, string> headers = CreateOauthHeader(signature, timestamp, nonce);
		string url = string.Format((string)format, obj6, httpQSCollection);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>f__AnonymousType6 <>f__AnonymousType = default(<>f__AnonymousType6);
		<>f__AnonymousType..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1240;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		WebRequest.SendPostHttpRequest(url, <>f__AnonymousType, action, headers);
	}

	private static void GetMediaUploadStatus(long mediaId, int delay, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0092: Expected I, but got O
		//IL_00bc: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1248;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj6 = obj2 + 24;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float seconds = (float)delay + 1f;
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
	}

	private unsafe static (string, string, string) CreateRequestSignature(string method, string url, Dictionary<string, string> data = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		//IL_00ce: Expected native int or pointer, but got O
		//IL_00dc: Expected O, but got I4
		//IL_00ec: Expected native int or pointer, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = StringUtil.GenerateNonce();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string timeStamp = GetTimeStamp();
		string signingKey = GetSigningKey();
		string signatureBaseString = GetSignatureBaseString(method, url, text, timeStamp, data);
		string sha1Hash = GetSha1Hash(signingKey, signatureBaseString);
		_ = 0;
		(string, string, string) tuple = default((string, string, string));
		System.Runtime.CompilerServices.Unsafe.Write(&((ValueTuple<string, string, string>*)(nint)tuple)->Item1, null);
		tuple = ((string, string, string))0;
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (ValueTuple<object, object, object>)(sha1Hash, text, timeStamp));
		return tuple;
	}

	private static string GetSignatureBaseString(string method, string url, string nonce, string timeStamp, Dictionary<string, string> data = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_0531: Expected O, but got I
		//IL_056c: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_04e0: Expected O, but got I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_036a: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_0638: Expected O, but got I
		//IL_0648: Expected O, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0679: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_028a: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_044b: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05ae: Expected O, but got I
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_06b1: Expected O, but got I
		//IL_06c2: Expected I, but got O
		//IL_06e0: Expected O, but got I
		//IL_06fb: Expected O, but got I4
		//IL_03e1: Expected O, but got I
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 4016;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		object obj3 = typeof(Queue<string>) + 920;
		object obj4 = (nint)0 + (nint)2296;
		string text2 = default(string);
		string text = text2 + (string)obj;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text3 = Uri.EscapeDataString(url);
		string text4 = (string)obj;
		string text5 = text + text3 + (string)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEEF4C");
		IEnumerable<KeyValuePair<object, object>> enumerable = default(IEnumerable<KeyValuePair<object, object>>);
		object obj9;
		string text6;
		object obj18;
		Dictionary<object, object> dictionary;
		object obj25;
		if (enumerable != null)
		{
			object obj8 = "not" + 672;
			obj9 = (nint)0 + (nint)2304;
			object obj10 = "not" + 696;
			object obj11 = "not" + 728;
			object obj12 = ", stale={0}" + 3784;
			object obj13 = "not" + 664;
			object obj14 = "alignContent" + 536;
			object obj15 = "not" + 688;
			object obj16 = "HH:mm:ss.ffZ" + 200;
			object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			obj7 = obj15;
			text6 = (string)obj16;
			obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			object obj19 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v53+E4]");
			if ((nint)0 != 0)
			{
				bool hasActiveSession = HasActiveSession;
				bool flag2 = !hasActiveSession;
				object obj20 = !flag2;
				if (obj20 == null)
				{
					goto IL_01ea;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!HasActiveSession)
				{
					goto IL_01ea;
				}
			}
			object obj21 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v62+E4]");
			bool flag3 = (nint)0 == 0;
			object obj22 = !flag3;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			string text7 = Prefs.GetString((string)key, (string)defaultValue);
			object obj23 = "not" + 704;
			obj7 = obj23;
			object obj24 = (nint)0 + (nint)2312;
			obj18 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF294");
			bool flag4 = data == null;
			text6 = text7;
			dictionary = (Dictionary<object, object>)(object)data;
			obj25 = obj24;
			text4 = text7;
			if (!flag4)
			{
				goto IL_02c7;
			}
			goto IL_032c;
		}
		NullReferenceException ex = new NullReferenceException();
		bool flag5 = (nint)obj4 != 1;
		NullReferenceException ex2 = ex;
		Dictionary<object, object>.Enumerator enumerator = default(Dictionary<object, object>.Enumerator);
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj7 = obj;
			enumerator.Dispose();
			object obj26 = default(object);
			bool flag6 = obj26 == null;
			obj25 = 0;
			if (flag6)
			{
				goto IL_032c;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj27 = obj26;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F21BAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result = default(string);
		return result;
		IL_01ea:
		bool flag7 = data == null;
		object obj28 = !flag7;
		dictionary = (Dictionary<object, object>)(object)data;
		if (obj28 != null)
		{
			goto IL_02c7;
		}
		obj25 = obj18;
		text4 = text6;
		goto IL_032c;
		IL_032c:
		object obj29 = typeof(TrackedDeviceRaycaster.<>c) + 368;
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj31 = !flag8;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj30 = obj29;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v26+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v11+38]");
		Func<KeyValuePair<object, object>, object> selector = (Func<KeyValuePair<object, object>, object>)0;
		object separator = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v11+38]");
		bool flag9 = (nint)0 == 0;
		object obj33 = !flag9;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v26+E4]");
			bool flag10 = (nint)0 == 0;
			object obj34 = !flag10;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj35 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v17+B8]");
				obj32 = 0;
			}
			object obj36 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj37 = (nint)0 + (nint)1048;
			Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
			func..ctor(obj32, (IntPtr)obj37);
			object obj38 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v16+B8]");
			object obj39 = (nint)0 + (nint)56;
			obj39 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj25 = 0;
			selector = func;
		}
		IEnumerable<object> values = Enumerable.Select(enumerable, selector);
		string stringToEscape = string.Join((string)separator, (IEnumerable<string>)values);
		object obj40 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v10+E4]");
		bool flag11 = (nint)0 == 0;
		object obj42 = !flag11;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text8 = Uri.EscapeDataString(stringToEscape);
		return text5 + text8;
		IL_02c7:
		object obj43 = (nint)0 + (nint)3208;
		Dictionary<object, object>.Enumerator enumerator2 = dictionary.GetEnumerator();
		string text9 = default(string);
		while (enumerator.MoveNext())
		{
			obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEF7B8");
			text6 = text9;
		}
		obj7 = obj43;
		enumerator.Dispose();
		obj25 = obj18;
		text4 = text6;
		goto IL_032c;
	}

	private static Dictionary<string, string> CreateOauthHeader(string signature, string timestamp, string nonce, string callbackUrl = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_027c: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_0520: Expected O, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0558: Expected O, but got I
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_0332: Expected O, but got I
		//IL_0342: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_068f: Expected O, but got I
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_06e1: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_0604: Expected O, but got I
		//IL_0615: Expected I, but got O
		//IL_0633: Expected O, but got I
		//IL_064e: Expected O, but got I4
		//IL_03c4: Expected O, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj15;
		object obj17;
		object obj22;
		object obj25;
		object obj26;
		object obj27;
		object obj29;
		object obj6;
		object obj5;
		object obj23;
		object obj28;
		object obj7;
		if (dictionary != null)
		{
			object key = "not" + 672;
			object obj2 = (nint)0 + (nint)728;
			object key2 = "not" + 696;
			object key3 = "not" + 680;
			object key4 = "not" + 728;
			object value = ", stale={0}" + 3784;
			object key5 = "not" + 664;
			object value2 = "alignContent" + 536;
			object obj3 = "not" + 688;
			object obj4 = "HH:mm:ss.ffZ" + 200;
			dictionary.Add(key, nonce);
			dictionary.Add(key2, timestamp);
			dictionary.Add(key3, signature);
			dictionary.Add(key4, value);
			dictionary.Add(key5, value2);
			obj5 = obj3;
			obj6 = obj4;
			obj7 = obj2;
			dictionary.Add(obj3, obj4);
			if (callbackUrl != null)
			{
				object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
				object obj9 = "not" + 656;
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v58+E4]");
				bool flag = (nint)0 == 0;
				object obj11 = !flag;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = Uri.EscapeDataString(callbackUrl);
				obj5 = obj9;
				object obj12 = (nint)0 + (nint)800;
				obj7 = obj12;
				dictionary.set_Item(obj9, (object)text);
				obj6 = text;
			}
			object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				obj15 = typeof(TrackedDeviceRaycaster.<>c) + 368;
				bool hasActiveSession = HasActiveSession;
				bool flag2 = !hasActiveSession;
				object obj16 = !flag2;
				obj17 = obj15;
				if (obj16 == null)
				{
					goto IL_0292;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = typeof(TrackedDeviceRaycaster.<>c) + 368;
				bool hasActiveSession2 = HasActiveSession;
				bool flag3 = !hasActiveSession2;
				obj17 = obj15;
				if (flag3)
				{
					goto IL_0292;
				}
			}
			object obj18 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key6 = "ThisIsFakeReceiptData" + 2760;
			object defaultValue = (nint)0 + (nint)2000;
			string text2 = Prefs.GetString((string)key6, (string)defaultValue);
			object obj20 = "not" + 704;
			obj5 = obj20;
			object obj21 = (nint)0 + (nint)800;
			obj7 = obj21;
			dictionary.set_Item(obj20, (object)text2);
			obj22 = "&action=sign-up" + 3424;
			obj23 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v34+E4]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			obj6 = text2;
			obj15 = obj17;
			obj25 = text2;
			obj26 = obj21;
			obj27 = obj20;
			obj28 = obj23;
			obj29 = obj22;
			if (obj24 != null)
			{
				goto IL_02fe;
			}
			goto IL_055d;
		}
		goto IL_059c;
		IL_055d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj23 = obj17;
		obj6 = obj25;
		obj7 = obj26;
		obj15 = obj17;
		obj5 = obj27;
		obj22 = obj29;
		goto IL_02fe;
		IL_0292:
		obj22 = "&action=sign-up" + 3424;
		obj23 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v34+E4]");
		bool flag6 = (nint)0 == 0;
		obj25 = obj6;
		obj26 = obj7;
		obj17 = obj15;
		obj27 = obj5;
		obj28 = obj23;
		obj29 = obj22;
		if (!flag6)
		{
			goto IL_02fe;
		}
		goto IL_055d;
		IL_059c:
		return (Dictionary<string, string>)(object)new NullReferenceException();
		IL_02fe:
		object obj30 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1568;
		object scheme = "Network Authentication Required" + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v34+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+40]");
		Func<KeyValuePair<object, object>, object> selector = (Func<KeyValuePair<object, object>, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v28+40]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v34+E4]");
			bool flag8 = (nint)0 == 0;
			object obj33 = !flag8;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj34 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v34+B8]");
				obj31 = 0;
			}
			object obj35 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj36 = (nint)0 + (nint)1024;
			Func<KeyValuePair<object, object>, object> func = default(Func<KeyValuePair<object, object>, object>);
			func..ctor(obj31, (IntPtr)obj36);
			object obj37 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v33+B8]");
			object obj38 = (nint)0 + (nint)64;
			obj38 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = 0;
			selector = func;
		}
		IEnumerable<object> values = Enumerable.Select(dictionary, selector);
		string parameter = string.Join((string)obj22, (IEnumerable<string>)values);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AuthenticationHeaderValue authenticationHeaderValue = default(AuthenticationHeaderValue);
		authenticationHeaderValue..ctor((string)scheme, parameter);
		object obj39 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		dictionary2..ctor();
		if (authenticationHeaderValue != null)
		{
			object value3 = authenticationHeaderValue.ToString();
			if (dictionary2 != null)
			{
				object key7 = "Added Tournament Prizes And Features" + 3864;
				dictionary2.Add(key7, value3);
				return (Dictionary<string, string>)(object)dictionary2;
			}
		}
		goto IL_059c;
	}

	private unsafe static string GetSha1Hash(string key, string message)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0047: Expected I, but got O
		//IL_0057: Expected O, but got I
		//IL_00a3: Expected O, but got Ref
		//IL_00ac: Expected O, but got I4
		//IL_00b1: Expected I, but got O
		//IL_00f8: Expected O, but got Ref
		//IL_0101: Expected O, but got I4
		//IL_0106: Expected I, but got O
		//IL_0117: Expected O, but got I4
		//IL_013f: Expected O, but got Ref
		//IL_0148: Expected O, but got I4
		//IL_014d: Expected I, but got O
		//IL_0167: Expected O, but got I4
		//IL_04dd: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0199: Expected I, but got O
		//IL_01a9: Expected O, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_0244: Expected I, but got O
		//IL_0547: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_0379: Expected O, but got I4
		//IL_0382: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_0513: Expected O, but got I
		//IL_0429: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_020d: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ASCIIEncoding aSCIIEncoding = default(ASCIIEncoding);
		aSCIIEncoding..ctor();
		HMACSHA1 hMACSHA2;
		object obj5;
		nint num3;
		HMACSHA1 hMACSHA3;
		object obj6;
		byte[] array3;
		object obj7;
		object obj8 = default(object);
		object obj9;
		object obj10 = default(object);
		object obj3;
		nint num2;
		object obj11;
		object obj12;
		byte[] inArray;
		byte[] array;
		object obj2;
		if (aSCIIEncoding != null)
		{
			obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3576;
			byte[] bytes = aSCIIEncoding.GetBytes(key);
			nint num = (nint)aSCIIEncoding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v21 (Il2CppClass<System.Text.ASCIIEncoding>)+258]");
			obj2 = 0;
			byte[] bytes2 = aSCIIEncoding.GetBytes(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HMACSHA1 hMACSHA = default(HMACSHA1);
			hMACSHA..ctor(bytes);
			bool flag = hMACSHA == null;
			hMACSHA2 = hMACSHA;
			obj3 = (object)(&hMACSHA2);
			object obj4 = 0;
			num2 = unchecked((nint)null);
			array = bytes;
			if (!flag)
			{
				byte[] array2 = hMACSHA.ComputeHash(bytes2);
				bool flag2 = hMACSHA == null;
				hMACSHA2 = hMACSHA;
				obj5 = (object)(&hMACSHA2);
				obj4 = 0;
				num3 = unchecked((nint)null);
				hMACSHA3 = hMACSHA;
				obj6 = 0;
				array3 = array2;
				obj7 = obj8;
				obj9 = obj10;
				hMACSHA2 = hMACSHA;
				obj3 = (object)(&hMACSHA2);
				obj4 = 0;
				num2 = unchecked((nint)null);
				array = bytes2;
				obj11 = obj;
				obj12 = 0;
				inArray = array2;
				if (!flag2)
				{
					goto IL_017d;
				}
				goto IL_04c3;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
			array = null;
		}
		throw new NullReferenceException();
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = unchecked((nint)null);
		goto IL_0537;
		IL_04c3:
		object obj20 = default(object);
		string result = default(string);
		while (true)
		{
			bool flag3 = obj12 == null;
			object obj13 = !flag3;
			obj8 = obj7;
			obj10 = obj9;
			obj = obj11;
			string text;
			if (obj13 == null)
			{
				object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
				object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v16+E4]");
				string text2;
				if ((nint)0 != 0)
				{
					text = Convert.ToBase64String(inArray);
					object obj17 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v8+E4]");
					bool flag4 = (nint)0 == 0;
					object obj18 = 0;
					text2 = text;
					if (!flag4)
					{
						goto IL_0321;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					text = Convert.ToBase64String(inArray);
					object obj17 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v8+E4]");
					bool flag5 = (nint)0 == 0;
					object obj19 = !flag5;
					object obj18 = 0;
					text2 = text;
					if (obj19 != null)
					{
						goto IL_0321;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				text = text2;
				goto IL_0321;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if ((nint)array == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj6 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag6 = hMACSHA2 == null;
				object obj21 = !flag6;
				obj5 = obj3;
				object obj4 = obj20;
				num3 = num2;
				hMACSHA3 = hMACSHA2;
				array3 = null;
				if (obj21 != null)
				{
					break;
				}
				obj7 = obj8;
				obj9 = obj10;
				obj4 = obj20;
				obj11 = obj;
				obj12 = obj20;
				inArray = null;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
			IL_0321:
			return Uri.EscapeDataString(text);
		}
		goto IL_017d;
		IL_017d:
		object obj22 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num4 = (nint)hMACSHA3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Security.Cryptography.HMACSHA1>)+12E]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Security.Cryptography.HMACSHA1>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0235;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Security.Cryptography.HMACSHA1>)+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X10_v8-8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X10_v8-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj10 = obj23 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16 (Il2CppClass<System.Security.Cryptography.HMACSHA1>)+12E]");
			obj2 = -1;
			bool flag7 = (nint)obj2 != 1;
			obj23 = obj10;
			if (flag7)
			{
				continue;
			}
			goto IL_0235;
		}
		obj2 = obj23;
		object obj24 = num4 + obj23;
		object obj25 = obj24 + 312;
		obj10 = obj23;
		num2 = num3;
		goto IL_0537;
		IL_0537:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v32+8]");
		array = (byte[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X0_v32] (should have been resolved before IL gen)");
		obj7 = obj8;
		obj9 = obj10;
		obj3 = obj5;
		obj11 = obj;
		obj12 = obj6;
		inArray = array3;
		goto IL_04c3;
	}

	private static string GetSigningKey()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = "java.io.FileOutputStream" + 3680;
		object key = "ThisIsFakeReceiptData" + 2752;
		object defaultValue = (nint)0 + (nint)2000;
		string text = Prefs.GetString((string)key, (string)defaultValue);
		return (string)obj4 + text;
	}

	private static string GetTimeStamp()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EA6]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(DataRelation) + 824;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = DateTime.UtcNow;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		DateTime dateTime2 = dateTime;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_01ad;
		IL_00d7:
		long num = DateTimeUtil.ToTimestamp(dateTime);
		long num2 = default(long);
		return num2.ToString();
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		dateTime = dateTime2;
		goto IL_00d7;
		IL_0099:
		dateTime = DateTime.UtcNow;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		dateTime2 = dateTime;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_01ad;
	}

	private static void TwitterErrorUnknown()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EDF]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "UInt16" + 3176;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "UInt16" + 3176;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0094:
		TwitterError((string)obj4);
	}

	private static void TwitterErrorDenied()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE0]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 952;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 952;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0094:
		TwitterError((string)obj4);
	}

	private static void TwitterErrorAuth()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE1]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0094:
		TwitterError((string)obj4);
	}

	private static void TwitterErrorImage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE2]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 928;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0094:
		TwitterError((string)obj4);
	}

	private static void TwitterErrorTweeting()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00dd: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EE3]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object message;
		if (obj3 != null)
		{
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 936;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			message = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 936;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			message = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TwitterError((string)message);
		return;
		IL_0094:
		TwitterError((string)obj4);
	}

	private static void TwitterError(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_01cf: Expected O, but got I
		//IL_01f1: Expected O, but got I4
		//IL_0112: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		string exceptionMessage = LocalizationUtil.Localize(message);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		if ((nint)0 == 0)
		{
			goto IL_013c;
		}
		SocialUtilities.TwitterException(exceptionMessage);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = 0;
		object obj9 = obj7;
		if (!flag2)
		{
			goto IL_00bd;
		}
		goto IL_019d;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SocialUtilities.TwitterException(exceptionMessage);
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj8 = 0;
		obj9 = obj7;
		if (obj10 != null)
		{
			goto IL_00bd;
		}
		goto IL_019d;
		IL_0102:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v101 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_013c;
		IL_019d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v9+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v7+18]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v7+18]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0102;
		IL_00bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v12+18]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v12+18]");
		if ((nint)0 != 0)
		{
			goto IL_0102;
		}
	}

	static TwitterRequests()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_00a9: Expected O, but got I
		object obj = "java.io.FileOutputStream" + 528;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2408;
		object obj3 = "1.2.840.113549.1.12.1.5" + 1792;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object obj5 = 0;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4+B8]");
		object obj7 = 0;
		string text = (string)obj7 + (string)obj3;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v6+B8]");
		object obj9 = (nint)0 + (nint)8;
		obj9 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	internal unsafe static bool <CheckFollowing>g__GetConnections|84_1(JsonData data, out JsonData connections)
	{
		//IL_00fc: Expected I4, but got O
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0072: Expected I, but got O
		//IL_00c5: Expected I, but got O
		if (data == null)
		{
			goto IL_00ee;
		}
		JsonData jsonData4;
		bool result;
		if (data.IsArray)
		{
			JsonData jsonData = data.get_Item(0);
			object obj = "com.unity.services.authentication.profile" + 640;
			bool flag = LitJsonExtensions.Contains(jsonData, (string)obj);
			bool flag2 = !flag;
			nint num = unchecked((nint)null);
			if (!flag2)
			{
				JsonData jsonData2 = data.get_Item(0);
				if (jsonData2 == null)
				{
					goto IL_00ee;
				}
				JsonData jsonData3 = jsonData2.get_Item((string)obj);
				num = unchecked((nint)null);
				jsonData4 = jsonData3;
				result = true;
				goto IL_0119;
			}
		}
		jsonData4 = null;
		result = false;
		goto IL_0119;
		IL_0119:
		ref JsonData reference = ref *(JsonData*)jsonData4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return result;
		IL_00ee:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
