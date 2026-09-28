using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PoorConnectionPopup : PopupUI
{
	private sealed class <>c__DisplayClass4_0
	{
		public Action<bool> callback;

		internal void <ShowPoorConnectionPopup>b__0(PoorConnectionPopup instance)
		{
			instance.ShowPopup(callback);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public Action<bool> callback;

		internal void <ShowPopup>b__0()
		{
			//IL_001f: Expected O, but got I
			//IL_002f: Expected O, but got I
			//IL_003f: Expected O, but got I
			Action<bool> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <ShowPopup>b__1()
		{
			//IL_001f: Expected O, but got I
			//IL_002f: Expected O, but got I
			//IL_003f: Expected O, but got I
			Action<bool> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.Boolean>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private static readonly AddressReference<PoorConnectionPopup> Address;

	private Button confirm;

	private Button cancel;

	public static bool HasBeenShown;

	public static void ShowPoorConnectionPopup(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1392;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3032;
		object obj5 = (nint)0 + (nint)1288;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void ShowPopup(Action<bool> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		//IL_03fb: Expected F4, but got I
		//IL_040c: Expected F4, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_044e: Expected O, but got I4
		//IL_0499: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_0262: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02bc: Expected O, but got I
		//IL_02cd: Expected I, but got O
		//IL_0318: Expected O, but got I4
		//IL_0329: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_033b: Expected O, but got I4
		//IL_038e: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_01e3: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		Action<bool> action = default(Action<bool>);
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UnityEngine.Object obj6;
		float num;
		UnityEngine.Object obj7;
		float num2 = default(float);
		if (base.<IsCurrentlyShown>k__BackingField)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			obj6 = confirm;
			num = num2;
			obj7 = confirm;
			if (!flag)
			{
				goto IL_00b5;
			}
		}
		else
		{
			SlideFromBottom();
			object obj8 = typeof(RegisteredWaitHandle) + 1880;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v17+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v18+100]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v18+100]");
			ITrackEvent trackEvent = TrackerLibrary.MenuPoorConnectionViewed(0f);
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			obj6 = confirm;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			num = num2;
			obj7 = confirm;
			if (obj14 != null)
			{
				goto IL_00b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = obj7 != null;
		bool flag5 = !flag4;
		num2 = num;
		object obj15 = 0;
		UnityEngine.Object obj16 = null;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		if (flag5)
		{
			goto IL_010b;
		}
		goto IL_0283;
		IL_035b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj19;
		bool flag6 = obj19 != null;
		bool flag7 = !flag6;
		object obj20 = !flag7;
		num2 = num;
		object obj22;
		object obj21 = obj22;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		if (obj20 == null)
		{
			return;
		}
		goto IL_0199;
		IL_0199:
		Button button = cancel;
		object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)1304;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj26);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_0164:
		UnityEngine.Object obj27;
		bool flag8 = obj27 != null;
		bool flag9 = !flag8;
		obj23 = 0;
		obj24 = null;
		if (!flag9)
		{
			goto IL_0199;
		}
		return;
		IL_010b:
		obj27 = cancel;
		object obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v6+E4]");
		bool flag10 = (nint)0 == 0;
		num = num2;
		obj22 = obj21;
		UnityAction unityAction2 = (UnityAction)(object)obj16;
		obj19 = cancel;
		if (!flag10)
		{
			goto IL_0164;
		}
		goto IL_035b;
		IL_0283:
		Button button2 = confirm;
		object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)1296;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(obj2, (IntPtr)obj30);
		button2.m_OnClick.AddListener(unityAction3);
		obj27 = cancel;
		obj28 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v6+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		num2 = num;
		obj21 = 0;
		obj22 = 0;
		obj15 = 0;
		unityAction2 = unityAction3;
		obj19 = cancel;
		if (obj31 != null)
		{
			goto IL_0164;
		}
		goto IL_035b;
		IL_00b5:
		bool flag12 = obj6 != null;
		bool flag13 = !flag12;
		object obj32 = !flag13;
		obj15 = 0;
		obj16 = null;
		num = num2;
		obj17 = 0;
		obj18 = null;
		if (obj32 == null)
		{
			goto IL_010b;
		}
		goto IL_0283;
	}

	private void Close()
	{
		Button button = confirm;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = cancel;
		button2.m_OnClick.RemoveAllListeners();
		SlideToBottom();
	}

	private void resetButtons()
	{
		Button button = confirm;
		button.m_OnClick.RemoveAllListeners();
		Button button2 = cancel;
		button2.m_OnClick.RemoveAllListeners();
	}

	public void OnConfirm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1392;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
		object obj4 = 0;
		_ = 1;
		Close();
	}

	public void OnCancel()
	{
		Close();
	}

	static PoorConnectionPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		object obj = "Picking audio files is not supported on iOS" + 856;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3128;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+B8]");
		object obj8 = 0;
		_ = 1;
	}
}
