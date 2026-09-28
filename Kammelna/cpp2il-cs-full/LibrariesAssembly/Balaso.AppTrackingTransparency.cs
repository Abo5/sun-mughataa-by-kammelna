using System;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Balaso;

public static class AppTrackingTransparency
{
	private delegate void AppTrackingTransparencyCallback(int result);

	public enum AuthorizationStatus
	{
		NOT_DETERMINED,
		RESTRICTED,
		DENIED,
		AUTHORIZED
	}

	private sealed class <>c__DisplayClass1_0
	{
		public int result;

		internal void <appTrackingTransparencyCallbackReceived>b__0(Task unused)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_01c6: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_009c: Expected O, but got I
			//IL_01fe: Expected O, but got I
			//IL_020e: Expected O, but got I
			//IL_0230: Expected O, but got I4
			//IL_038c: Expected O, but got I4
			//IL_03da: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_03ef: Expected O, but got I
			//IL_03ff: Expected O, but got I
			//IL_040f: Expected O, but got I
			//IL_03bc: Expected O, but got I
			//IL_03cc: Expected O, but got I
			//IL_0365: Expected O, but got I4
			//IL_02a2: Expected O, but got I4
			//IL_0347: Expected O, but got I
			//IL_0357: Expected O, but got I
			//IL_02f0: Expected O, but got I4
			//IL_0143: Expected O, but got I4
			//IL_02d2: Expected O, but got I
			//IL_02e2: Expected O, but got I
			//IL_0191: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D1E]");
			object obj2 = (nint)0 & (nint)1;
			object obj3;
			if (obj2 != null)
			{
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				return;
			}
			goto IL_00c1;
			IL_03df:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v19+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X3_v1 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Warning: Method ends with non empty stack (-30), the output could be wrong!");
			/*Error: End of method reached without returning.*/;
			IL_02f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v12+B8]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v13+8]");
				obj7 = 0;
			}
			object obj15 = 0;
			goto IL_03df;
			IL_00c1:
			if (result <= 1)
			{
				if (result == 0 || result != 1)
				{
					goto IL_02f5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj17 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v24+B8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v25+8]");
					obj7 = 0;
				}
				obj15 = 1;
			}
			else if (result != 2)
			{
				if (result != 3)
				{
					goto IL_02f5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj19 = !flag6;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v20+B8]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v21+8]");
					obj7 = 0;
				}
				obj15 = 3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v16+B8]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v17+8]");
					obj7 = 0;
				}
				obj15 = 2;
			}
			goto IL_03df;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v28+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v28+8]");
			if ((nint)0 != 0)
			{
				goto IL_00c1;
			}
		}
	}

	private static TaskScheduler currentSynchronizationContext;

	public static Action<AuthorizationStatus> OnAuthorizationRequestDone;

	public static AuthorizationStatus TrackingAuthorizationStatus
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00bb: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D4A]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A60");
			AuthorizationStatus result = default(AuthorizationStatus);
			return result;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A60");
			AuthorizationStatus result2 = default(AuthorizationStatus);
			return result2;
		}
	}

	private static void appTrackingTransparencyCallbackReceived(int result)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_020c: Expected O, but got I4
		//IL_0118: Expected I, but got O
		//IL_0142: Expected O, but got I4
		//IL_0177: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object format = "UInt16" + 2688;
		object obj3 = typeof(DataRelation) + 856;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		object obj5 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		object message = text;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		object obj9 = (nint)0 + (nint)3920;
		object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		Debug.Log(message);
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Task task = Task.Delay(1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v9+B8]");
		object scheduler = 0;
		Task task2 = task.ContinueWith(action, (TaskScheduler)scheduler);
	}

	[PreserveSig]
	private static extern void requestTrackingAuthorization(AppTrackingTransparencyCallback callback);

	[PreserveSig]
	private static extern string identifierForAdvertising();

	[PreserveSig]
	private static extern int trackingAuthorizationStatus();

	[PreserveSig]
	private static extern void registerAppForAdNetworkAttribution();

	[PreserveSig]
	private static extern void updateConversionValue(int value);

	static AppTrackingTransparency()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3976;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TaskScheduler taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
		object obj5 = obj2;
		object obj6 = taskScheduler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static void UpdateConversionValue(int value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_0358: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D1A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform == RuntimePlatform.IPhonePlayer;
		object obj7 = obj6;
		if (flag2)
		{
			goto IL_00c2;
		}
		goto IL_0223;
		IL_00c2:
		object format = "Unsupported map type" + 248;
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string message = string.Format((string)format, arg);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+E4]");
		object obj13;
		object obj12;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v43+E4]");
			bool flag3 = (nint)0 == 0;
			obj12 = 0;
			obj13 = 0;
			if (!flag3)
			{
				goto IL_0189;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj12 = 0;
			obj13 = 0;
			if (obj14 != null)
			{
				goto IL_0189;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj13;
		goto IL_0189;
		IL_0189:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A88");
		return;
		IL_0223:
		object obj15 = typeof(RegisteredWaitHandle) + 1744;
		object format2 = "Picking audio files is not supported on iOS" + 128;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform2 = Application.platform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string text = string.Format((string)format2, arg2);
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		object message2 = text;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text;
		}
		Debug.Log(message2);
		return;
		IL_007d:
		obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform3 = Application.platform;
		bool flag7 = platform3 != RuntimePlatform.IPhonePlayer;
		obj7 = obj6;
		if (!flag7)
		{
			goto IL_00c2;
		}
		goto IL_0223;
	}

	public static void RegisterAppForAdNetworkAttribution()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_019d: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0249: Expected O, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I4
		//IL_0328: Expected O, but got I4
		//IL_0331: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D1B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform == RuntimePlatform.IPhonePlayer;
		object obj7 = obj6;
		if (flag2)
		{
			goto IL_00c2;
		}
		goto IL_01fc;
		IL_00c2:
		object message = "Read object reference Id '{0}' for {1}." + 1224;
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v39+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v46+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = 0;
			object obj12 = 0;
			object obj13 = obj10;
			if (!flag3)
			{
				goto IL_0162;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v46+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj11 = 0;
			object obj12 = 0;
			object obj13 = obj10;
			if (obj14 != null)
			{
				goto IL_0162;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A7C");
		return;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A7C");
		return;
		IL_01fc:
		object obj15 = typeof(RegisteredWaitHandle) + 1744;
		object format = "Picking audio files is not supported on iOS" + 128;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform2 = Application.platform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		object message2 = text;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text;
		}
		Debug.Log(message2);
		return;
		IL_007d:
		obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform3 = Application.platform;
		bool flag7 = platform3 != RuntimePlatform.IPhonePlayer;
		obj7 = obj6;
		if (!flag7)
		{
			goto IL_00c2;
		}
		goto IL_01fc;
	}

	public static void RequestTrackingAuthorization()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_0381: Expected O, but got I
		//IL_03f0: Expected O, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0438: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D1C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform == RuntimePlatform.IPhonePlayer;
		object obj7 = obj6;
		if (flag2)
		{
			goto IL_00c2;
		}
		goto IL_0287;
		IL_00c2:
		object message = "Read object reference Id '{0}' for {1}." + 2600;
		object obj8 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1576;
		object obj9 = (nint)0 + (nint)2616;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v45+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v7+8]");
		_ = 0;
		object obj14 = default(object);
		object obj13 = obj14 + 32;
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj15 = default(object);
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X20_v7+52]");
			if ((nint)0 == 1)
			{
				object obj16 = 35909632 + 1120;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v49+10]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v49+20]");
				_ = 0;
			}
			object obj17 = 35909632 + 1036;
			object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v57+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @692C");
			return;
		}
		object obj21 = 134782976 + 1449;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
		throw new OutOfMemoryException();
		IL_0287:
		object obj22 = typeof(RegisteredWaitHandle) + 1744;
		object format = "Picking audio files is not supported on iOS" + 128;
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = !flag5;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform2 = Application.platform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj25 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		object message2 = text;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text;
		}
		Debug.Log(message2);
		return;
		IL_007d:
		obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform3 = Application.platform;
		bool flag7 = platform3 != RuntimePlatform.IPhonePlayer;
		obj7 = obj6;
		if (!flag7)
		{
			goto IL_00c2;
		}
		goto IL_0287;
	}

	public static string IdentifierForAdvertising()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0202: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_038d: Expected O, but got I4
		//IL_0396: Expected O, but got I4
		//IL_039f: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D1D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform = Application.platform;
		bool flag2 = platform == RuntimePlatform.IPhonePlayer;
		object obj7 = obj6;
		if (flag2)
		{
			goto IL_00c2;
		}
		goto IL_0261;
		IL_00c2:
		object message = "Network Authentication Required" + 3888;
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v40+E4]");
		object obj12;
		object obj11;
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v46+E4]");
			bool flag3 = (nint)0 == 0;
			obj11 = 0;
			obj12 = 0;
			object obj13 = obj10;
			if (!flag3)
			{
				goto IL_0162;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v46+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			obj11 = 0;
			obj12 = 0;
			object obj13 = obj10;
			if (obj14 != null)
			{
				goto IL_0162;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj12;
		goto IL_0162;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6994");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FA0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		string text = default(string);
		bool flag5 = string.IsNullOrEmpty(text);
		bool flag6 = !flag5;
		object obj15 = !flag6;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			return null;
		}
		return text;
		IL_0261:
		object obj17 = typeof(RegisteredWaitHandle) + 1744;
		object format = "Picking audio files is not supported on iOS" + 128;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v2+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RuntimePlatform platform2 = Application.platform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text2 = string.Format((string)format, arg);
		object obj20 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj21 = !flag8;
		object message2 = text2;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message2 = text2;
		}
		Debug.Log(message2);
		return null;
		IL_007d:
		obj6 = typeof(DataRelation) + 856;
		RuntimePlatform platform3 = Application.platform;
		bool flag9 = platform3 != RuntimePlatform.IPhonePlayer;
		obj7 = obj6;
		if (!flag9)
		{
			goto IL_00c2;
		}
		goto IL_0261;
	}
}
