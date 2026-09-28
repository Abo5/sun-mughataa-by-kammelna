using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Balaso;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public static class IdfaPermission
{
	private const string AlreadyRequestedKey = "Did_Request_IOS_IDFA_Permission";

	private const string AdsCountKey = "Successful_Ads_Watched_Count_With_No_IDFA_On_IOS";

	private const int Threshold1 = 30;

	private const int Threshold2 = 60;

	private const int Threshold3 = 120;

	private static bool lastAdSkipped;

	private static Action _resume;

	private static bool AlreadyRequested
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "DNQUALIFIER" + 3088;
			return Prefs.GetBool((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "DNQUALIFIER" + 3088;
			Prefs.SetBool((string)key, value);
		}
	}

	public static int AdsCount
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SubscribeGroup request Error" + 160;
			return Prefs.GetInt((string)key);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SubscribeGroup request Error" + 160;
			Prefs.SetInt((string)key, value);
		}
	}

	public static void RegisterIOSAppAttribution()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F7B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AppTrackingTransparency.RegisterAppForAdNetworkAttribution();
		return;
		IL_0074:
		AppTrackingTransparency.RegisterAppForAdNetworkAttribution();
	}

	public static void UpdateConversionValue()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F7C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AppTrackingTransparency.UpdateConversionValue(1);
		return;
		IL_0074:
		AppTrackingTransparency.UpdateConversionValue(1);
	}

	public unsafe static void Check(Action resume)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0374: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_016b: Expected O, but got Ref
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_0329: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 2392;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = resume;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Platform platform = KUtil.GetPlatform();
			if (platform == Platform.IOS)
			{
				goto IL_0056;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 == Platform.IOS)
			{
				goto IL_0056;
			}
		}
		Actions.SafeInvoke(resume);
		return;
		IL_0056:
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AppTrackingTransparency.AuthorizationStatus trackingAuthorizationStatus = AppTrackingTransparency.TrackingAuthorizationStatus;
		object obj9 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "___# Content push apply failed [{0}]: {1}" + 928;
		object arg = default(object);
		string message = string.Format((string)format, arg);
		object obj10 = typeof(DataRelation) + 856;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.Log(message);
		object obj13 = default(object);
		string idfaStatus = ((Enum)(&obj13)).ToString();
		ITrackEvent trackEvent = TrackerLibrary.DevIOSRequestingAdWhileIdfaStatus(idfaStatus);
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v26+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		object obj17 = trackingAuthorizationStatus - 1;
		bool flag4 = (nint)obj17 < 2;
		object obj18 = !flag4;
		object obj19 = ~obj18;
		if (obj19 == null)
		{
			if (trackingAuthorizationStatus == AppTrackingTransparency.AuthorizationStatus.NOT_DETERMINED)
			{
				ShowPermissionPopup();
				return;
			}
			if (trackingAuthorizationStatus != AppTrackingTransparency.AuthorizationStatus.AUTHORIZED)
			{
				object obj20 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v32+E4]");
				bool flag5 = (nint)0 == 0;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = "___# Content push apply failed [{0}]: {1}" + 360;
				Debug.LogError(obj22);
				trackEvent = (ITrackEvent)obj22;
			}
		}
		else
		{
			bool flag6 = ShouldShowGoToSettingsPopup();
			bool flag7 = !flag6;
			trackEvent = (ITrackEvent)flag6;
			if (!flag7)
			{
				ShowGoToSettingsPopup();
				return;
			}
		}
		ResumeShowingAd();
	}

	private static void ResumeShowingAd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015d: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1584;
		object format = "___# Content push apply failed [{0}]: {1}" + 680;
		object obj3 = typeof(DataRelation) + 856;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = typeof(System.IOAsyncCallback) + 2392;
		AppTrackingTransparency.AuthorizationStatus trackingAuthorizationStatus = AppTrackingTransparency.TrackingAuthorizationStatus;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object message = text;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6+8]");
		Actions.SafeInvoke((Action)0);
	}

	private static void ShowPermissionPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_05ba: Expected I, but got O
		//IL_05f4: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0598: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b5: Expected I, but got O
		//IL_00c5: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_066c: Expected I, but got O
		//IL_027b: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected I, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected I, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_035d: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_03f3: Expected I, but got O
		//IL_041d: Expected O, but got I4
		//IL_0398: Expected O, but got I
		//IL_0433: Expected I, but got O
		//IL_0443: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_050e: Expected I, but got O
		//IL_0532: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_047e: Expected O, but got I
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_06ca: Expected O, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2128;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Action action = default(Action);
		object obj11 = default(object);
		object obj13 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr = default(IntPtr);
		Action action2 = default(Action);
		object obj16 = default(object);
		object obj25 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		object obj37 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(null, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.OnDismissed += action;
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			bool flag2 = popupWindowBuilderNeedsTitle == null;
			object obj6 = 0;
			object obj10;
			if (!flag2)
			{
				object obj7 = typeof(System.IOAsyncCallback) + 392;
				object obj8 = "https://www.kammelna.com/Home/Terms" + 1280;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0149;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v11-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj11 = obj10 + 16;
					obj9--;
					bool flag3 = (nint)obj9 != 1;
					obj10 = obj11;
					if (flag3)
					{
						continue;
					}
					goto IL_0149;
				}
				object obj12 = num2 + obj10;
				num = (nint)(obj12 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag4 = obj13 == null;
				obj11 = obj10;
				obj6 = 0;
				if (!flag4)
				{
					goto IL_01f6;
				}
			}
			goto IL_0549;
			IL_0549:
			ex = new NullReferenceException();
			goto IL_0557;
			IL_042b:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj15;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v1-8]");
					bool flag5 = 0 == (nint)obj15;
					obj6 = 0;
					if (flag5)
					{
						break;
					}
					obj11 += 16;
					obj14--;
					if ((nint)obj14 != 1)
					{
						continue;
					}
					goto IL_04bf;
				}
				goto IL_0557;
			}
			goto IL_04bf;
			IL_02c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = intPtr;
			goto IL_064a;
			IL_064a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(null, (IntPtr)obj2);
			object label;
			PopupButton popupButton = PopupButton.Neutral((string)label, action2, dismiss: true);
			bool flag6 = obj16 == null;
			obj11 = obj10;
			obj6 = 0;
			object obj17;
			if (!flag6)
			{
				obj15 = typeof(System.IOAsyncCallback) + 368;
				obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03e1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v16+B0]");
				obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v1-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj10 = obj11 + 16;
					obj18--;
					bool flag7 = (nint)obj18 != 1;
					obj11 = obj10;
					if (flag7)
					{
						continue;
					}
					goto IL_03e1;
				}
				goto IL_04eb;
			}
			goto IL_0549;
			IL_0557:
			object obj19 = obj11 + 9;
			object obj20 = num + obj19;
			object obj21 = obj20 + 312;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v6+8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v286 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_04bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X0_v20+8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v345 @ X2_v12 (should have been resolved before IL gen)");
			goto IL_04eb;
			IL_0149:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v31 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj13 == null;
			object obj27 = !flag8;
			obj10 = obj11;
			if (obj27 != null)
			{
				goto IL_01f6;
			}
			obj6 = 0;
			num = intPtr2;
			goto IL_0549;
			IL_04eb:
			object obj28 = obj17 + obj11;
			object obj29 = obj28 + 312;
			num = (nint)obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v496 @ X0_v26] (should have been resolved before IL gen)");
			bool flag9 = ex == null;
			object obj30 = !flag9;
			obj6 = 0;
			if (obj30 != null)
			{
				goto IL_042b;
			}
			goto IL_0549;
			IL_01f6:
			object obj31 = typeof(System.IOAsyncCallback) + 384;
			object obj32 = "ThisIsFakeReceiptData" + 472;
			label = "com.unity.services.authentication.profile" + 944;
			object obj33 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+12E]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v14+B0]");
			object obj35 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X10_v19-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj10 = obj35 + 16;
				obj34--;
				bool flag10 = (nint)obj34 != 1;
				obj35 = obj10;
				if (flag10)
				{
					continue;
				}
				goto IL_02c4;
			}
			object obj36 = obj33 + obj35;
			num = (nint)(obj36 + 312);
			obj10 = obj35;
			goto IL_064a;
			IL_03e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v481 @ X0_v23] (should have been resolved before IL gen)");
			bool flag11 = ex == null;
			obj11 = obj10;
			obj6 = 0;
			if (!flag11)
			{
				goto IL_042b;
			}
			goto IL_0549;
		}
	}

	private static void RequestPermission()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_020b: Expected I, but got O
		//IL_0235: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0269: Expected I, but got O
		//IL_0143: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2128;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = typeof(DataRelation) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 672;
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		PopupWindow.OnDismissed -= action;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = 0;
			if (!flag2)
			{
				goto IL_00e0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			object obj10 = 0;
			if (obj11 != null)
			{
				goto IL_00e0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00e0;
		IL_00e0:
		object obj12 = (nint)0 + (nint)2136;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		AppTrackingTransparency.RequestTrackingAuthorization();
		object key = "DNQUALIFIER" + 3088;
		Prefs.SetBool((string)key, value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj12);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action2);
	}

	private static void ShowGoToSettingsPopup()
	{
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_06f2: Expected O, but got I
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Expected O, but got Unknown
		//IL_087f: Expected I, but got O
		//IL_003f: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06c8: Expected O, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c9: Expected I, but got O
		//IL_00d9: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_0784: Expected I, but got O
		//IL_029b: Expected O, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected I, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected I, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_038c: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_07cb: Expected I, but got O
		//IL_07ed: Expected I, but got O
		//IL_03c7: Expected O, but got I
		//IL_0467: Expected O, but got I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0523: Expected I, but got O
		//IL_054d: Expected O, but got I4
		//IL_04c8: Expected O, but got I
		//IL_0563: Expected I, but got O
		//IL_0573: Expected O, but got I
		//IL_0611: Expected O, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_063e: Expected I, but got O
		//IL_0662: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_05ae: Expected O, but got I
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_084b: Expected O, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		Action action = default(Action);
		object obj11 = default(object);
		object obj13 = default(object);
		Action action2 = default(Action);
		object obj15 = default(object);
		object obj21 = default(object);
		IntPtr intPtr = default(IntPtr);
		NullReferenceException ex = default(NullReferenceException);
		object obj26 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		Action action3 = default(Action);
		object obj35 = default(object);
		object obj43 = default(object);
		while (true)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)2120;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object key = "DNQUALIFIER" + 3088;
			Prefs.SetBool((string)key, value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(null, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.OnDismissed += action;
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			bool flag2 = popupWindowBuilderNeedsTitle == null;
			object obj6 = 0;
			object obj10;
			if (!flag2)
			{
				object obj7 = typeof(System.IOAsyncCallback) + 392;
				object obj8 = "https://www.kammelna.com/Home/Terms" + 1280;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_015d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj10 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v12-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj11 = obj10 + 16;
					obj9--;
					bool flag3 = (nint)obj9 != 1;
					obj10 = obj11;
					if (flag3)
					{
						continue;
					}
					goto IL_015d;
				}
				object obj12 = num2 + obj10;
				num = (nint)(obj12 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ X8_v6 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag4 = obj13 == null;
				obj11 = obj10;
				obj6 = 0;
				if (!flag4)
				{
					goto IL_020a;
				}
			}
			goto IL_0679;
			IL_0762:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v323 @ X8_v6 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14;
			action2..ctor(null, (IntPtr)obj14);
			object label;
			PopupButton popupButton = PopupButton.Positive((string)label, action2);
			bool flag5 = obj15 == null;
			obj11 = obj10;
			obj6 = 0;
			if (flag5)
			{
				goto IL_0679;
			}
			object obj16 = typeof(System.IOAsyncCallback) + 368;
			object label2 = "com.unity.services.authentication.profile" + 944;
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v18+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0410;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v18+B0]");
			object obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X10_v20-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj10 = obj19 + 16;
				obj18--;
				bool flag6 = (nint)obj18 != 1;
				obj19 = obj10;
				if (flag6)
				{
					continue;
				}
				goto IL_0410;
			}
			object obj20 = obj17 + obj19;
			obj21 = obj20 + 312;
			obj10 = obj19;
			goto IL_07c3;
			IL_02e4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = intPtr;
			goto IL_0762;
			IL_061b:
			object obj23;
			object obj22 = obj23 + obj11;
			object obj24 = obj22 + 312;
			num = (nint)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v614 @ X0_v35] (should have been resolved before IL gen)");
			bool flag7 = ex == null;
			object obj25 = !flag7;
			obj6 = 0;
			if (obj25 != null)
			{
				goto IL_055b;
			}
			goto IL_0679;
			IL_0511:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v599 @ X0_v32] (should have been resolved before IL gen)");
			bool flag8 = ex == null;
			obj11 = obj10;
			obj6 = 0;
			if (!flag8)
			{
				goto IL_055b;
			}
			goto IL_0679;
			IL_055b:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v1-8]");
					bool flag9 = 0 == (nint)obj16;
					obj6 = 0;
					if (flag9)
					{
						break;
					}
					obj11 += 16;
					obj27--;
					if ((nint)obj27 != 1)
					{
						continue;
					}
					goto IL_05ef;
				}
				goto IL_0687;
			}
			goto IL_05ef;
			IL_0679:
			ex = new NullReferenceException();
			goto IL_0687;
			IL_015d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X0_v43 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag10 = obj13 == null;
			object obj28 = !flag10;
			obj10 = obj11;
			if (obj28 != null)
			{
				goto IL_020a;
			}
			obj6 = 0;
			num = intPtr2;
			goto IL_0679;
			IL_0410:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_07c3;
			IL_020a:
			object obj29 = typeof(System.IOAsyncCallback) + 384;
			object obj30 = "ThisIsFakeReceiptData" + 464;
			obj14 = (nint)0 + (nint)1888;
			label = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3216;
			object obj31 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v16+12E]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02e4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v16+B0]");
			object obj33 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X10_v25-8]");
				if (0 == (nint)obj29)
				{
					break;
				}
				obj10 = obj33 + 16;
				obj32--;
				bool flag11 = (nint)obj32 != 1;
				obj33 = obj10;
				if (flag11)
				{
					continue;
				}
				goto IL_02e4;
			}
			object obj34 = obj31 + obj33;
			num = (nint)(obj34 + 312);
			obj10 = obj33;
			goto IL_0762;
			IL_07c3:
			num = (nint)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ X0_v21] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action3..ctor(null, (IntPtr)obj2);
			PopupButton popupButton2 = PopupButton.Neutral((string)label2, action3, dismiss: true);
			bool flag12 = obj35 == null;
			obj11 = obj10;
			obj6 = 0;
			if (!flag12)
			{
				obj23 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v21+12E]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v21+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0511;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v21+B0]");
				obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v1-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj10 = obj11 + 16;
					obj36--;
					bool flag13 = (nint)obj36 != 1;
					obj11 = obj10;
					if (flag13)
					{
						continue;
					}
					goto IL_0511;
				}
				goto IL_061b;
			}
			goto IL_0679;
			IL_0687:
			object obj37 = obj11 + 9;
			object obj38 = num + obj37;
			object obj39 = obj38 + 312;
			object obj40 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v8+8]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v330 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_05ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj42 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v29+8]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v395 @ X2_v17 (should have been resolved before IL gen)");
			goto IL_061b;
		}
	}

	private static bool ShouldShowGoToSettingsPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0189: Expected O, but got I8
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_01e3: Expected I4, but got O
		object obj = typeof(System.IOAsyncCallback) + 2392;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3 & 1;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object key = "DNQUALIFIER" + 3088;
			if (Prefs.GetBool((string)key))
			{
				object key2 = "SubscribeGroup request Error" + 160;
				int num = Prefs.GetInt((string)key2);
				if (num != 30)
				{
					int num2 = Prefs.GetInt((string)key2);
					if (num2 != 60)
					{
						int num3 = Prefs.GetInt((string)key2);
						if (num3 < 1)
						{
							return false;
						}
						int num4 = Prefs.GetInt((string)key2);
						object obj6 = num4 * 4008636143L;
						object obj7 = 143165576 + obj6;
						object obj8 = obj7 >> 3;
						object obj9 = obj7 << 29;
						object obj10 = obj8 | obj9;
						bool flag2 = (nint)obj10 < 35791395;
						object obj11 = !flag2;
						return (byte)(int)(~obj11) != 0;
					}
				}
			}
		}
		return true;
	}

	public static void AdOpened()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_0146: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F80]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.IOS)
		{
			return;
		}
		goto IL_0111;
		IL_0111:
		object obj5 = typeof(System.IOAsyncCallback) + 2392;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5+B8]");
		object obj7 = 0;
		obj7 = 1;
		return;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.IOS)
		{
			return;
		}
		goto IL_0111;
	}

	public static void AdCompleted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.IOS)
		{
			goto IL_0115;
		}
		return;
		IL_0115:
		object obj5 = typeof(System.IOAsyncCallback) + 2392;
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6+B8]");
		object obj8 = 0;
		obj8 = 0;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			AppTrackingTransparency.AuthorizationStatus trackingAuthorizationStatus = AppTrackingTransparency.TrackingAuthorizationStatus;
			if (trackingAuthorizationStatus == AppTrackingTransparency.AuthorizationStatus.AUTHORIZED)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			AppTrackingTransparency.AuthorizationStatus trackingAuthorizationStatus2 = AppTrackingTransparency.TrackingAuthorizationStatus;
			if (trackingAuthorizationStatus2 == AppTrackingTransparency.AuthorizationStatus.AUTHORIZED)
			{
				return;
			}
		}
		object key = "SubscribeGroup request Error" + 160;
		int num = Prefs.GetInt((string)key);
		int value = num + 1;
		Prefs.SetInt((string)key, value);
		return;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.IOS)
		{
			return;
		}
		goto IL_0115;
	}

	internal static void <ShowGoToSettingsPopup>g___continue|19_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		//IL_009e: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2120;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.OnDismissed -= action;
		ResumeShowingAd();
	}
}
