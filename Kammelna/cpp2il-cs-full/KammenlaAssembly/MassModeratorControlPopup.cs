using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class MassModeratorControlPopup : MonoBehaviour
{
	private PopupUI popup;

	private TextMeshProUGUI infoText;

	private Button addTrailsBtn;

	private Button addPointsBtn;

	private int _userId;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = addTrailsBtn;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = addPointsBtn;
		object obj3 = (nint)0 + (nint)3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	public unsafe void ShowForUser(string userId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		bool flag = int.TryParse(userId, out *(int*)(this + 64));
		popup.SlideFromTop();
		LoadUserInfo();
	}

	private void LoadUserInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_00a5: Expected I, but got O
		//IL_00d4: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "___# Content push apply failed [{0}]: {1}" + 3144;
		object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj3 = (nint)0 + (nint)3200;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, 4);
		SFSExtensions.Put(sFSObject, (string)key2, _userId);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, sFSObject, keepListening: false, action);
	}

	private void AddTrails()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3232;
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.OfType(InputField.ContentType.IntegerNumber);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.IOAsyncCallback) + 376;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)popupWindowBuilderInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v5-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj7 = obj6 + 3;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0192;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0192;
		IL_0192:
		object msgTitle = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3984;
		object msgBody = "Drop Menu Toggle" + 3128;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v7] (should have been resolved before IL gen)");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPopupWindowBuilderInput inputData = default(IPopupWindowBuilderInput);
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private void AddTrailsAction(string trailsString)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0256: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_018d: Expected I, but got O
		//IL_01bc: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		int result;
		bool flag2 = int.TryParse(trailsString, out result);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		int num = ((obj5 == null) ? result : 0);
		if (num > 0)
		{
			object obj6 = typeof(RegisteredWaitHandle) + 2040;
			object key = "___# Content push apply failed [{0}]: {1}" + 3144;
			object key2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 808;
			object key3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj8 = (nint)0 + (nint)3192;
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
			object command = "m_StencilDeferredPS" + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSObject sFSObject = default(SFSObject);
			sFSObject..ctor();
			SFSExtensions.Put(sFSObject, (string)key, 5);
			SFSExtensions.Put(sFSObject, (string)key2, num);
			SFSExtensions.Put(sFSObject, (string)key3, _userId);
			GameObject go = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SfsRequestListener.SendRoomRequest(go, (string)command, sFSObject, keepListening: false, action);
		}
		else
		{
			object obj12 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 408;
			string message = (string)obj12 + trailsString;
			object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Debug(message, (Vector2)0, 0f);
		}
	}

	private void AddPoints()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3216;
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.OfType(InputField.ContentType.IntegerNumber);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.IOAsyncCallback) + 376;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)popupWindowBuilderInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v5-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj7 = obj6 + 3;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0192;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0192;
		IL_0192:
		object msgTitle = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3976;
		object msgBody = "Drop Menu Toggle" + 3120;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v7] (should have been resolved before IL gen)");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPopupWindowBuilderInput inputData = default(IPopupWindowBuilderInput);
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private void AddPointsAction(string pointsString)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0256: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_018d: Expected I, but got O
		//IL_01bc: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		int result;
		bool flag2 = int.TryParse(pointsString, out result);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		int num = ((obj5 == null) ? result : 0);
		if (num > 0)
		{
			object obj6 = typeof(RegisteredWaitHandle) + 2040;
			object key = "___# Content push apply failed [{0}]: {1}" + 3144;
			object key2 = "placementId" + 1528;
			object key3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1320;
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
			object obj8 = (nint)0 + (nint)3184;
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
			object command = "m_StencilDeferredPS" + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFSObject sFSObject = default(SFSObject);
			sFSObject..ctor();
			SFSExtensions.Put(sFSObject, (string)key, 6);
			SFSExtensions.Put(sFSObject, (string)key2, num);
			SFSExtensions.Put(sFSObject, (string)key3, _userId);
			GameObject go = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v23+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SfsRequestListener.SendRoomRequest(go, (string)command, sFSObject, keepListening: false, action);
		}
		else
		{
			object obj12 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 408;
			string message = (string)obj12 + pointsString;
			object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Debug(message, (Vector2)0, 0f);
		}
	}

	private void CloseWithError()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0050: Expected O, but got F4
		//IL_0078: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		PopupUI popupUI = popup;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object message = "placementId" + 208;
		nint num = (nint)popupUI;
		popupUI.HidePopup(hideContentNow: false);
		float canvasHeight = ScreenUtility.CanvasHeight;
		object obj2 = 0f - canvasHeight;
		RectTransform content = popupUI.content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)0, 0f, onFinish);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)message);
	}

	private void Close()
	{
		//IL_0017: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_0056: Expected O, but got I4
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		popupUI.HidePopup(hideContentNow: false);
		float canvasHeight = ScreenUtility.CanvasHeight;
		RectTransform content = popupUI.content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	private void <LoadUserInfo>b__7_0(ISFSObject response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v32+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X0_v32] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		if (obj10 != null)
		{
			goto IL_00fe;
		}
		goto IL_0171;
		IL_00fe:
		CloseWithError();
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v29+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X0_v29] (should have been resolved before IL gen)");
		object obj11 = default(object);
		if (obj11 != null)
		{
			goto IL_00fe;
		}
		goto IL_0171;
		IL_0171:
		MassTournamentPlayerState massTournamentPlayerState = MassTournamentPlayerState.FromSfsObject(response);
		object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor();
		object value = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 1032;
		StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
		StringBuilder stringBuilder3 = stringBuilder2.Append(massTournamentPlayerState.<IsRegistered>k__BackingField);
		object value2 = (nint)0 + (nint)2624;
		StringBuilder stringBuilder4 = stringBuilder3.Append((string)value2);
		StringBuilder stringBuilder5 = stringBuilder4.Append(massTournamentPlayerState.<TriesLeft>k__BackingField);
		object value3 = (nint)0 + (nint)2560;
		StringBuilder stringBuilder6 = stringBuilder5.Append((string)value3);
		int value4 = massTournamentPlayerState.<LastStageReached>k__BackingField + 1;
		StringBuilder stringBuilder7 = stringBuilder6.Append(value4);
		object value5 = (nint)0 + (nint)2592;
		StringBuilder stringBuilder8 = stringBuilder7.Append((string)value5);
		StringBuilder stringBuilder9 = stringBuilder8.Append(massTournamentPlayerState.<ChampionshipPoints>k__BackingField);
		object value6 = (nint)0 + (nint)2568;
		StringBuilder stringBuilder10 = stringBuilder9.Append((string)value6);
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value7 = default(object);
		StringBuilder stringBuilder11 = stringBuilder10.Append(value7);
		string text = stringBuilder11.ToString();
		infoText.text = text;
	}

	private void <AddTrailsAction>b__9_0(ISFSObject response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I
		//IL_01b9: Expected I, but got O
		//IL_007b: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v16+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v16] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		object obj11 = obj2;
		if (obj10 != null)
		{
			goto IL_0106;
		}
		goto IL_0181;
		IL_0106:
		CloseWithError();
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v13+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v13] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag2 = obj12 == null;
		obj11 = obj2;
		if (!flag2)
		{
			goto IL_0106;
		}
		goto IL_0181;
		IL_0181:
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3240;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj14);
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForEndOfFrame(action);
	}

	private void <AddPointsAction>b__11_0(ISFSObject response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I
		//IL_01b9: Expected I, but got O
		//IL_007b: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "destinationTimeZone" + 2696;
		nint num = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00bc;
		}
		object obj5 = obj4 + 1;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v16+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v217 @ X0_v16] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		object obj11 = obj2;
		if (obj10 != null)
		{
			goto IL_0106;
		}
		goto IL_0181;
		IL_0106:
		CloseWithError();
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v13+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v13] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag2 = obj12 == null;
		obj11 = obj2;
		if (!flag2)
		{
			goto IL_0106;
		}
		goto IL_0181;
		IL_0181:
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3240;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj14);
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy.WaitForEndOfFrame(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy.WaitForEndOfFrame(action);
	}
}
