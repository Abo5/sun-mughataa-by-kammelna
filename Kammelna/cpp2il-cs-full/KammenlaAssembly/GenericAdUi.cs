using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Features.GameReplay;
using GoogleMobileAds.Ump.Api;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GenericAdUi : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public Action exitCallBack;

		internal void <LoadGenericAd>b__0(GenericAdUi instance)
		{
			instance.ShowAd(exitCallBack);
		}
	}

	private static readonly AddressReference<GenericAdUi> PrefabName;

	public const string GenericAdID = "Generic AD";

	private const string GenericAdURL = "misc/store_cards_ann";

	private Image adImage;

	private PopupUI popup;

	private Action _exitCallBack;

	public static void LoadGenericAd(Action exitCallBack = null)
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
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2296;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2112;
		object obj5 = (nint)0 + (nint)2064;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = exitCallBack;
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
		object obj10 = (nint)0 + (nint)2056;
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

	private void ShowAd(Action exitCallBack)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_0049: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_01e6: Expected I, but got O
		//IL_00a2: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = this + 48;
		Action action = default(Action);
		obj2 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				goto IL_0057;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 == null)
			{
				goto IL_0057;
			}
		}
		goto IL_012f;
		IL_012f:
		object obj7 = "m_StencilDeferredPS" + 1896;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj9 = (nint)0 + (nint)2552;
		object imageId = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2472;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v7+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+28]");
		string url = (string)0 + (string)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X20_v3-10]");
		UIExtensions.LoadImage((Image)0, (string)imageId, url, setNative: false, storeLocally: true, (DateTime?)(object)0);
		return;
		IL_0057:
		_ = 1;
		goto IL_012f;
	}

	public void Close()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E771A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AllowBackAction();
		PopupUI popupUI = popup;
		bool flag2 = (object)popup == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0091;
		IL_007d:
		ScreenManager.AllowBackAction();
		popupUI = popup;
		goto IL_0091;
		IL_0091:
		popupUI.SlideToBottom();
		Actions.SafeInvoke(_exitCallBack);
	}

	static GenericAdUi()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2472;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3040;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <ShowAd>b__7_0(bool success)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (success)
		{
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PreventBackAction();
			popup.SlideFromTop();
			return;
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Complete" + 2744;
		Actions.SafeInvoke(_exitCallBack);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Debug((string)message, (Vector2)0, 0f);
	}
}
