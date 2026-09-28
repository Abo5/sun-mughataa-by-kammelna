using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

public class DisconnectionPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<DisconnectionPopup> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Show>b__17_0(DisconnectionPopup instance)
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			PopupUI popup = instance.popup;
			if (!popup.<IsCurrentlyShown>k__BackingField)
			{
				popup.SlideFromTop();
				object obj = typeof(DataRelation) + 856;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "___# Content push apply failed [{0}]: {1}" + 40;
				Debug.Log(message);
			}
		}
	}

	private static readonly AddressReference<DisconnectionPopup> Address;

	private PopupUI popup;

	private ConnectionIndicator connectionIndicator;

	private GameObject errorNotch;

	private GameObject successNotch;

	private TextMeshProUGUI txtBody;

	private RectTransform ButtonsSection;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_025d: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0077: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_019d: Expected I, but got O
		//IL_010e: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0136: Expected O, but got I4
		//IL_01c8: Expected I, but got O
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 856;
		object obj2 = (nint)0 + (nint)2216;
		SetLoading();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj6 = (nint)0 + (nint)3448;
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
		object obj8 = (nint)0 + (nint)3440;
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+38]");
		bool flag2 = (nint)0 < (nint)9;
		object obj10 = !flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+38]");
		object obj11 = -9;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		object obj13 = obj10 & obj12;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+38]");
			object obj14 = 1 << 0;
			object obj15 = obj14 & 0x330;
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				object obj17 = obj14 & 0x46;
				if (obj17 != null)
				{
					SetLoading();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+38]");
					if ((nint)0 == 7)
					{
						ShowSuccess();
					}
				}
			}
			else
			{
				ShowError();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj6);
		SfsConnectionManager.OnConnectionStateChange += (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj8);
		SfsConnectionManager.OnLoginError += action2;
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.PreventBackAction();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.PreventBackAction();
	}

	private void Initialize()
	{
		SetLoading();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a9: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj2 = (nint)0 + (nint)3448;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2584;
		object obj4 = (nint)0 + (nint)3440;
		object obj5 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj2);
		SfsConnectionManager.OnConnectionStateChange -= (Action<LoginStatus>)(object)action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SfsConnectionManager.OnLoginError -= action2;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.AllowBackAction();
	}

	private void ShowPopup()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		PopupUI popupUI = popup;
		if (!popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.SlideFromTop();
			object obj = typeof(DataRelation) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "___# Content push apply failed [{0}]: {1}" + 40;
			Debug.Log(message);
		}
	}

	private void OnLoginStatusChange(LoginStatus loginStatus)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		bool flag = loginStatus < LoginStatus.ConnectionLost;
		object obj = !flag;
		object obj2 = loginStatus - 9;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 != null)
		{
			return;
		}
		object obj5 = 1 << (int)loginStatus;
		object obj6 = obj5 & 0x330;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = obj5 & 0x46;
			if (obj8 != null)
			{
				SetLoading();
			}
			else if (loginStatus == LoginStatus.LoggedIn)
			{
				ShowSuccess();
			}
		}
		else
		{
			ShowError();
		}
	}

	private void OnLoginError(LoginError loginError)
	{
		//IL_0018: Expected O, but got I4
		//IL_0032: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_016b: Expected I, but got O
		object obj = loginError.<Error>k__BackingField + 1;
		bool flag = (nint)obj < 11;
		object obj2 = !flag;
		object obj3 = obj - 11;
		bool flag2 = obj3 == null;
		object obj4 = 1 << (int)obj;
		object obj5 = obj4 & 0x84D;
		object obj6 = ~obj2;
		object obj7 = obj6 | flag2;
		object obj8 = ~obj7;
		if (obj8 == null && obj5 != null)
		{
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3080;
			object format = "DNQUALIFIER" + 3368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string reason = string.Format((string)format, arg);
			Authentication.Clear(reason);
			object obj10 = typeof(SqlSingle[]) + 2376;
			object obj11 = (nint)0 + (nint)3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj11);
			popup.ShrinkToParent(action);
			SfsConnectionManager.ShowErrorInLoginScene();
		}
	}

	private void SetLoading()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76F1]");
		object obj2 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		RectTransform buttonsSection;
		if (obj2 != null)
		{
			rectTransform = ButtonsSection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF15A]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			buttonsSection = ButtonsSection;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			rectTransform = ButtonsSection;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF15A]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			buttonsSection = ButtonsSection;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		rectTransform = buttonsSection;
		goto IL_011b;
		IL_011b:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		rectTransform.anchoredPosition = (Vector2)0;
		successNotch.SetActive(value: false);
		errorNotch.SetActive(value: true);
		connectionIndicator.StartLoading();
		GameObject gameObject = txtBody.gameObject;
		object text = "ThisIsFakeReceiptData" + 2152;
		gameObject.SetActive(value: true);
		TextMeshProExtensions.Localize(txtBody, (string)text);
		return;
		IL_0083:
		bool flag3 = (object)rectTransform == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011b;
	}

	private void ShowError()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Cannot populate JSON object onto type '{0}'." + 2432;
		TextMeshProExtensions.Localize(txtBody, (string)text);
		connectionIndicator.ConnectionFail();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		AnimateFailureButtons();
	}

	private void ShowSuccess()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_009e: Expected I, but got O
		errorNotch.SetActive(value: false);
		successNotch.SetActive(value: true);
		GameObject gameObject = txtBody.gameObject;
		gameObject.SetActive(value: false);
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3432;
		connectionIndicator.ConnectionSuccess();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Coroutine coroutine = UIExtensions.WaitForSeconds(this, 1f, action);
	}

	private void Dismiss()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.ShrinkToParent(action);
	}

	public static void Show()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02d5: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_0307: Expected O, but got I4
		//IL_0247: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_0439: Expected O, but got I
		//IL_044a: Expected I, but got O
		//IL_0468: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_037f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76F4]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(DebugUI.BitField) + 832;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
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
			obj4 = typeof(DebugUI.BitField) + 832;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+E4]");
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
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v17+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj7;
		object obj14 = obj12;
		object obj15 = obj10;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_0167:
		object obj16 = (nint)0 + (nint)2032;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = obj16;
		obj15 = obj11;
		Action<object> action2;
		Action<object> action = action2;
		if (!flag4)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
		IL_03e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj19;
		obj11 = obj15;
		action2 = action;
		goto IL_01b8;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
		return;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v43+B8]");
		object obj20 = 0;
		obj11 = obj20;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		obj7 = obj4;
		obj15 = obj20;
		if (!flag5)
		{
			goto IL_00fe;
		}
		goto IL_029f;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj7;
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		obj11 = obj15;
		object obj23 = obj18;
		obj4 = obj7;
		if (obj22 != null)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_00fe:
		obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		action2 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v4+8]");
		bool flag7 = (nint)0 == 0;
		obj23 = obj18;
		obj15 = obj11;
		if (!flag7)
		{
			goto IL_0167;
		}
		goto IL_032d;
		IL_032d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v3+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v11+B8]");
			obj21 = 0;
		}
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)2208;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj21, (IntPtr)obj27);
		object obj28 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v9+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = (nint)0 + (nint)2032;
		obj17 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v1+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		obj11 = obj15;
		action2 = action3;
		obj19 = obj16;
		action = action3;
		if (obj30 != null)
		{
			goto IL_01b8;
		}
		goto IL_03e8;
	}

	private void AnimateFailureButtons(float delay = 0f)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007c: Expected F4, but got O
		//IL_007c: Expected O, but got I4
		object obj = (nint)0 + (nint)2760;
		object obj2 = (nint)0 + (nint)2872;
		int num = ShortcutExtensions.DOKill(ButtonsSection);
		object obj3 = typeof(UsageHint) + 744;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+B8]");
		object obj5 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(ButtonsSection, (Vector2)0, (float)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void OnTryConnectingClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76F6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2216;
			SetLoading();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2216;
			SetLoading();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SfsConnectionManager sfsConnectionManager = default(SfsConnectionManager);
		bool flag3 = (object)sfsConnectionManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a6;
		IL_0097:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a6;
		IL_00a6:
		sfsConnectionManager.Login();
	}

	public void OnPlayOfflineClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.ShrinkToParent(action);
	}

	static DisconnectionPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "DNQUALIFIER" + 3360;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3032;
		object obj3 = typeof(DataRelation) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Dismiss>b__16_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76F8]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object obj5;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gameObject;
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = gameObject;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.Destroy(obj5);
	}
}
