using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class PopupWindow : MonoBehaviour
{
	public enum MessageType
	{
		Info,
		Action,
		Waiting,
		Error
	}

	public enum Theme
	{
		Light,
		Dark,
		InGame
	}

	private sealed class <>c__DisplayClass31_0
	{
		public PopupWindowData popup;

		internal void <Show>b__0(PopupWindow instance)
		{
			instance.ShowPopup(popup);
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public PopupWindow <>4__this;

		public PopupWindowData popupData;

		internal void <SetupButtonsLayout>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00d5: Expected O, but got I4
			PopupWindow popupWindow = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!popupWindow.gridButtonsContainer)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = popupWindow.gridButtonsContainer;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			PopupWindowData popupWindowData = popupData;
			<>4__this.UpdateGridCellSize(popupWindowData.gridButtonColumns, popupWindowData.gridButtonHeight);
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public PopupWindowInputData inputData;

		public PopupWindow <>4__this;

		internal void <SetupInput>b__0()
		{
			PopupWindowInputData popupWindowInputData = inputData;
			PopupWindow popupWindow = <>4__this;
			string text = popupWindow.inputField.Text;
			Actions.SafeInvoke((Action<object>)popupWindowInputData.callback, text);
		}

		internal void <SetupInput>b__1()
		{
			PopupWindow popupWindow = <>4__this;
			popupWindow.inputField.ShowKeyboard();
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public PopupButton actionButton;

		internal void <InitializeButtons>b__1()
		{
			PopupButton popupButton = actionButton;
			Action action = popupButton.Action;
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v29 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private static readonly AddressReference<PopupWindow> LightAddress;

	private static readonly AddressReference<PopupWindow> DarkAddress;

	private static readonly AddressReference<PopupWindow> InGameAddress;

	private PopupUI popup;

	private GameObject loadingIndicator;

	private TextMeshProUGUI txtMessageTitle;

	private TextMeshProUGUI txtMessageBody;

	private InputFieldTMProUGUI inputField;

	private RectTransform extraContentContainer;

	private LinearLayoutGroup buttonsContainer;

	private Image inputIcon;

	private Image textField;

	private GameObject errorContainer;

	private TextMeshProUGUI errorText;

	private PopupWindowButton posButton;

	private PopupWindowButton negButton;

	private PopupWindowButton normalButton;

	private PopupWindowButton purchaseButton;

	private GenericSoundAlbum soundAlbum;

	private PopupButton[] buttonsList;

	private Button primaryButton;

	private GridLayoutGroup gridButtonsContainer;

	private static PopupWindow Active;

	private static AddressReference<PopupWindow> ActiveLoading;

	public static event Action OnDismissed
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private static AddressReference<PopupWindow> GetAddress(Theme theme)
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_014e: Expected O, but got I4
		//IL_0289: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_026e: Expected O, but got I
		//IL_003c: Expected O, but got I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0209: Expected O, but got I
		switch (theme)
		{
		default:
		{
			bool flag2 = theme == Theme.Light;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v30+B8]");
				return (AddressReference<PopupWindow>)0;
			}
			object obj8 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = "startPosition" + 2984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj11 = (nint)0 + (nint)1520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (AddressReference<PopupWindow>)(object)new OutOfMemoryException();
		}
		case Theme.Dark:
		{
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+B8]");
			return (AddressReference<PopupWindow>)((nint)0 + (nint)8);
		}
		case Theme.InGame:
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+B8]");
			return (AddressReference<PopupWindow>)((nint)0 + (nint)16);
		}
		}
	}

	private void Update()
	{
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField && inputField.IsSubmitted() && !primaryButton.Equals(null))
		{
			Button button = primaryButton;
			button.m_OnClick.Invoke();
		}
	}

	public static void Show(PopupWindowData popup)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_00e1: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_018d: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = popup;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3048;
		object obj7 = (nint)0 + (nint)1320;
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+28]");
		AddressReference<PopupWindow> address = GetAddress(Theme.Light);
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+B8]");
		object obj13 = (nint)0 + (nint)40;
		obj13 = address;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v7+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private unsafe void ShowPopup(PopupWindowData popupData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0a68: Expected I, but got O
		//IL_0a8a: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_0aae: Expected O, but got I
		//IL_0ad6: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_0396: Expected O, but got I4
		//IL_039b: Expected I, but got O
		//IL_015e: Expected O, but got I4
		//IL_0163: Expected I, but got O
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_0196: Expected I, but got O
		//IL_0246: Expected O, but got I4
		//IL_0566: Expected O, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_01c3: Expected I, but got O
		//IL_0466: Expected O, but got I4
		//IL_046b: Expected I, but got O
		//IL_05bb: Expected I, but got O
		//IL_05c0: Expected I, but got O
		//IL_030e: Expected O, but got I4
		//IL_0313: Expected I, but got O
		//IL_096e: Expected O, but got I
		//IL_0274: Expected O, but got I4
		//IL_0615: Expected O, but got I4
		//IL_04a4: Expected O, but got I4
		//IL_04a9: Expected I, but got O
		//IL_033f: Expected O, but got I
		//IL_0634: Expected O, but got I
		//IL_04fb: Expected O, but got I4
		//IL_0500: Expected I, but got O
		//IL_067b: Expected O, but got I4
		//IL_09d4: Expected I, but got O
		//IL_0513: Expected I, but got O
		//IL_06c1: Expected O, but got I4
		//IL_06c6: Expected I, but got O
		//IL_06ce: Expected O, but got I4
		//IL_06f6: Expected O, but got I
		//IL_0702: Expected O, but got I
		//IL_0719: Expected I, but got O
		//IL_080e: Expected I, but got O
		//IL_0817: Expected O, but got I4
		//IL_07a6: Expected O, but got I4
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_0885: Expected O, but got I
		//IL_08b3: Expected I, but got O
		//IL_0922: Expected O, but got I4
		//IL_08cd: Expected O, but got I
		//IL_077e: Expected I, but got O
		string text = (string)(typeof(RegisteredWaitHandle) + 3136);
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2 (Il2CppClass<System.String>)+E4]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PreventBackAction();
		ResetMessage();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+B8]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = popupData == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		PopupWindow popupWindow = this;
		PopupWindow popupWindow2 = this;
		PopupWindowData popupWindowData;
		List<object>.Enumerator enumerator2;
		nint num2;
		if (!flag3)
		{
			bool flag4 = popupData.buttons == null;
			enumerator = (List<object>.Enumerator)0;
			popupWindow = this;
			popupWindow2 = this;
			if (!flag4)
			{
				object[] array = ((List<object>)(object)popupData.buttons).ToArray();
				object obj6 = this + 160;
				obj6 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				SetupButtonsLayout(popupData);
				InitializeButtons();
				bool flag5 = !popupData.disabledPrimaryButton;
				popupWindow = (PopupWindow)(object)popupData;
				if (!flag5)
				{
					bool flag6 = object.Equals(primaryButton, null);
					bool flag7 = !flag6;
					object obj7 = !flag7;
					num2 = unchecked((nint)null);
					popupWindow = null;
					if (obj7 == null)
					{
						bool flag8 = (object)primaryButton == null;
						enumerator = (List<object>.Enumerator)0;
						num2 = unchecked((nint)null);
						popupWindow = null;
						popupWindow2 = this;
						if (flag8)
						{
							goto IL_0aee;
						}
						primaryButton.interactable = false;
						num2 = unchecked((nint)null);
						popupWindow = null;
					}
				}
				bool flag9 = popupData.type < MessageType.Waiting;
				object obj8 = !flag9;
				object obj9 = ~obj8;
				if (obj9 != null)
				{
					goto IL_0357;
				}
				if (popupData.type != MessageType.Error)
				{
					bool flag10 = popupData.type != MessageType.Waiting;
					enumerator2 = (List<object>.Enumerator)0;
					popupWindow2 = this;
					if (flag10)
					{
						object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
						ex..ctor();
						object obj11 = (nint)0 + (nint)1536;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
						OutOfMemoryException ex2 = new OutOfMemoryException();
						IntPtr intPtr = default(IntPtr);
						bool flag11 = intPtr != (IntPtr)1;
						nint num3 = intPtr;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							num3 = (nint)text;
							enumerator2.Dispose();
							object obj12 = default(object);
							bool flag12 = obj12 == null;
							enumerator = enumerator2;
							List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj12;
							popupWindowData = (PopupWindowData)(object)ex;
							if (flag12)
							{
								goto IL_07b8;
							}
							ex2 = new OutOfMemoryException();
							enumerator3 = (List<object>.Enumerator)obj12;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					bool flag13 = (object)loadingIndicator == null;
					enumerator = (List<object>.Enumerator)0;
					popupWindow2 = this;
					if (!flag13)
					{
						loadingIndicator.SetActive(value: true);
						goto IL_0357;
					}
				}
				else
				{
					bool flag14 = (object)errorContainer == null;
					enumerator = (List<object>.Enumerator)0;
					popupWindow2 = this;
					if (!flag14)
					{
						errorContainer.SetActive(value: true);
						TextMeshProExtensions.Localize(errorText, popupData.title);
						bool flag15 = (object)soundAlbum == null;
						enumerator = (List<object>.Enumerator)0;
						num2 = unchecked((nint)null);
						popupWindow = (PopupWindow)(object)popupData.title;
						popupWindow2 = this;
						if (!flag15)
						{
							object obj13 = (nint)0 + (nint)2424;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
							SingleSound singleSound = default(SingleSound);
							SoundChannel.PlaySFXSound(singleSound);
							goto IL_0357;
						}
					}
				}
			}
		}
		goto IL_0aee;
		IL_05db:
		PopupWindowInputData inputData;
		SetupInput(inputData);
		nint num4;
		num2 = num4;
		popupWindow = (PopupWindow)(object)inputData;
		goto IL_05fa;
		IL_044d:
		UnityEngine.Component component;
		bool flag16 = (object)component == null;
		enumerator = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		popupWindow2 = this;
		if (!flag16)
		{
			GameObject gameObject = component.gameObject;
			bool flag17 = (object)gameObject == null;
			enumerator = (List<object>.Enumerator)0;
			num2 = unchecked((nint)null);
			popupWindow = null;
			popupWindow2 = this;
			if (!flag17)
			{
				gameObject.SetActive(value: false);
				inputData = popupData.inputData;
				bool flag18 = popupData.inputData == null;
				object obj14 = !flag18;
				num4 = unchecked((nint)null);
				if (obj14 != null)
				{
					goto IL_05db;
				}
				num2 = unchecked((nint)null);
				popupWindow = (PopupWindow)(object)popupData.inputData;
				goto IL_05fa;
			}
		}
		goto IL_0aee;
		IL_0aee:
		enumerator2 = enumerator;
		throw new NullReferenceException();
		IL_0357:
		TextMeshProExtensions.Localize(txtMessageTitle, popupData.title);
		LocalizableText body = popupData.body;
		bool flag19 = popupData.body == null;
		enumerator = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		popupWindow = (PopupWindow)(object)popupData.title;
		popupWindow2 = this;
		if (!flag19)
		{
			object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			text = body.Text;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v53+E4]");
			TextMeshProUGUI textMesh;
			if ((nint)0 != 0)
			{
				bool flag20 = StringsExtensions.IsNullOrEmpty(body.Text);
				component = txtMessageBody;
				bool flag21 = !flag20;
				popupWindow = null;
				textMesh = txtMessageBody;
				if (!flag21)
				{
					goto IL_044d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag22 = StringsExtensions.IsNullOrEmpty(body.Text);
				component = txtMessageBody;
				bool flag23 = !flag22;
				object obj17 = !flag23;
				popupWindow = null;
				textMesh = txtMessageBody;
				if (obj17 != null)
				{
					goto IL_044d;
				}
			}
			TextMeshProExtensions.Localize(textMesh, popupData.body);
			inputData = popupData.inputData;
			bool flag24 = popupData.inputData == null;
			num4 = unchecked((nint)null);
			num2 = unchecked((nint)null);
			popupWindow = (PopupWindow)(object)popupData.inputData;
			if (!flag24)
			{
				goto IL_05db;
			}
			goto IL_05fa;
		}
		goto IL_0aee;
		IL_07b8:
		GameObject gameObject2 = popupWindow2.gameObject;
		bool flag25 = (object)gameObject2 == null;
		popupWindow = null;
		if (!flag25)
		{
			gameObject2.SetActive(value: true);
			bool flag26 = (object)popupWindow2.popup == null;
			num2 = unchecked((nint)null);
			popupWindow = (PopupWindow)1;
			if (!flag26)
			{
				popupWindow2.popup.SlideFromTop();
				System.Int32Enum? int32Enum = (System.Int32Enum?)(object)(popupWindowData + 80);
				object obj18 = (??)int32Enum & 1;
				if (obj18 == null)
				{
					return;
				}
				popupWindow2 = (PopupWindow)(object)popupWindow2.soundAlbum;
				object obj19 = (nint)0 + (nint)2816;
				popupWindow = (PopupWindow)obj19;
				System.Int32Enum value = ((System.Int32Enum?*)int32Enum)->Value;
				bool flag27 = (object)popupWindow2.soundAlbum == null;
				num2 = unchecked((nint)null);
				if (!flag27)
				{
					object obj20 = (nint)0 + (nint)2424;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
					SingleSound singleSound2 = default(SingleSound);
					SoundChannel.PlaySFXSound(singleSound2);
					return;
				}
			}
		}
		goto IL_0aee;
		IL_05fa:
		bool flag28 = (object)extraContentContainer == null;
		enumerator = (List<object>.Enumerator)0;
		popupWindow2 = this;
		if (!flag28)
		{
			object obj21 = (nint)0 + (nint)2168;
			GameObject gameObject3 = extraContentContainer.gameObject;
			popupWindow = (PopupWindow)obj21;
			bool flag29 = Enumerable.Any((IEnumerable<object>)popupData.extraContent);
			bool flag30 = (object)gameObject3 == null;
			enumerator = (List<object>.Enumerator)0;
			text = (string)(object)gameObject3;
			popupWindow2 = this;
			if (!flag30)
			{
				gameObject3.SetActive(flag29);
				bool flag31 = popupData.extraContent == null;
				enumerator = (List<object>.Enumerator)0;
				num2 = unchecked((nint)null);
				popupWindow = (PopupWindow)flag29;
				text = (string)(object)gameObject3;
				popupWindow2 = this;
				if (!flag31)
				{
					object obj22 = (nint)0 + (nint)1048;
					text = (string)((nint)0 + (nint)1040);
					List<object>.Enumerator enumerator4 = ((List<object>)(object)popupData.extraContent).GetEnumerator();
					num2 = unchecked((nint)null);
					GameObject gameObject4 = default(GameObject);
					List<object>.Enumerator enumerator5;
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					while (true)
					{
						popupWindow = (PopupWindow)obj22;
						if (!enumerator.MoveNext())
						{
							break;
						}
						if ((object)gameObject4 != null)
						{
							Transform transform = gameObject4.transform;
							if ((object)transform != null)
							{
								transform.SetParent(extraContentContainer, worldPositionStays: false);
								num2 = unchecked((nint)null);
								continue;
							}
							NullReferenceException ex3 = new NullReferenceException();
							popupWindow = null;
						}
						else
						{
							NullReferenceException ex4 = new NullReferenceException();
						}
						enumerator = enumerator3;
						enumerator5 = enumerator3;
						enumerator3 = (List<object>.Enumerator)0;
						popupWindow2 = this;
						goto IL_0aee;
					}
					enumerator.Dispose();
					enumerator = enumerator3;
					enumerator5 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					popupWindow2 = this;
					popupWindowData = popupData;
					goto IL_07b8;
				}
			}
		}
		goto IL_0aee;
	}

	private void SetupButtonsLayout(PopupWindowData popupData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0a4e: Expected I, but got O
		//IL_0a5e: Expected O, but got I
		//IL_00fa: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_0a82: Expected I, but got O
		//IL_0a92: Expected O, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_0b5d: Expected I, but got O
		//IL_0242: Expected I, but got O
		//IL_01e0: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_020e: Expected I, but got O
		//IL_021e: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02db: Expected I, but got O
		//IL_0320: Expected I, but got O
		//IL_0362: Expected I, but got O
		//IL_0381: Expected O, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03dc: Expected I, but got O
		//IL_0425: Expected I, but got O
		//IL_042e: Expected O, but got I4
		//IL_0459: Expected I, but got O
		//IL_0462: Expected O, but got I4
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_04dd: Expected O, but got I4
		//IL_0501: Expected O, but got I4
		//IL_0540: Expected O, but got I4
		//IL_0557: Expected I, but got O
		//IL_0587: Expected O, but got I4
		//IL_059e: Expected I, but got O
		//IL_05d1: Expected O, but got I4
		//IL_05f6: Expected O, but got I4
		//IL_060d: Expected I, but got O
		//IL_065f: Expected O, but got I4
		//IL_0676: Expected I, but got O
		//IL_067f: Expected O, but got I4
		//IL_06ba: Expected O, but got I4
		//IL_06d1: Expected I, but got O
		//IL_06da: Expected O, but got I4
		//IL_06f8: Expected F8, but got I
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0bb3: Expected O, but got I4
		//IL_0733: Invalid comparison between F8 and I4
		//IL_0be1: Expected F8, but got I4
		//IL_0bea: Expected O, but got I4
		//IL_0c01: Expected I, but got O
		//IL_0c0a: Expected O, but got I4
		//IL_0757: Expected F8, but got I8
		//IL_0789: Expected F8, but got I4
		//IL_0792: Expected O, but got I4
		//IL_07a9: Expected I, but got O
		//IL_07b2: Expected O, but got I4
		//IL_07e5: Expected F8, but got I4
		//IL_07ee: Expected O, but got I4
		//IL_0805: Expected I, but got O
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_084e: Expected F8, but got I4
		//IL_0857: Expected O, but got I4
		//IL_086e: Expected I, but got O
		//IL_0903: Expected O, but got I4
		//IL_091a: Expected I, but got O
		//IL_0923: Expected O, but got I4
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_0951: Expected O, but got I
		//IL_0960: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_0983: Expected F4, but got I
		//IL_09a3: Expected I, but got O
		//IL_09cd: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		PopupWindowData popupWindowData = null;
		InvalidCastException ex = default(InvalidCastException);
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = popupData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			bool flag2 = obj4 == null;
			popupWindowData = popupData;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+40]");
				if ((nint)0 != 0)
				{
					bool flag3 = (object)buttonsContainer == null;
					popupWindowData = popupData;
					if (!flag3)
					{
						buttonsContainer.LayoutOrientation = LinearLayoutGroup.Orientation.Vertical;
						bool flag4 = (object)buttonsContainer == null;
						nint num = unchecked((nint)null);
						popupWindowData = (PopupWindowData)1;
						if (!flag4)
						{
							object obj6 = typeof(SqlSingle[]) + 392;
							object handle = typeof(IAsyncEnumerable<>) + 3032;
							buttonsContainer.reverseArrangement = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							object obj7 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v11+E0]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v12+E4]");
							bool flag5 = (nint)0 == 0;
							object obj9 = !flag5;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
							Type[] array = default(Type[]);
							bool flag6 = array == null;
							num = unchecked((nint)null);
							popupWindowData = null;
							if (!flag6)
							{
								bool flag7 = (object)typeFromHandle == null;
								PopupWindowData popupWindowData2 = null;
								if (!flag7)
								{
									nint num2 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v30 (Il2CppClass<System.Type[]>)+40]");
									popupWindowData2 = (PopupWindowData)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag8 = ex == null;
									num = unchecked((nint)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v30 (Il2CppClass<System.Type[]>)+40]");
									popupWindowData = (PopupWindowData)0;
									if (flag8)
									{
										goto IL_0af1;
									}
								}
								bool flag9 = array.Length == 0;
								num = unchecked((nint)null);
								popupWindowData = popupWindowData2;
								if (flag9)
								{
									goto IL_0ad5;
								}
								object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
								object obj11 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3640;
								object obj12 = array + 32;
								obj12 = typeFromHandle;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								GameObject gameObject = default(GameObject);
								gameObject..ctor((string)obj11, array);
								bool flag10 = (object)gameObject == null;
								int num3 = 0;
								num = (nint)array;
								popupWindowData = (PopupWindowData)obj11;
								if (!flag10)
								{
									Transform transform = gameObject.transform;
									bool flag11 = (object)buttonsContainer == null;
									num3 = 0;
									num = (nint)array;
									popupWindowData = null;
									if (!flag11)
									{
										Transform parent = buttonsContainer.transform;
										bool flag12 = (object)transform == null;
										num3 = 0;
										num = (nint)array;
										popupWindowData = null;
										if (!flag12)
										{
											object obj13 = (nint)0 + (nint)720;
											transform.SetParent(parent, worldPositionStays: false);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
											object obj14 = this + 176;
											PopupWindowData popupWindowData3 = default(PopupWindowData);
											obj14 = popupWindowData3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											bool flag13 = obj14 == null;
											num3 = 0;
											num = unchecked((nint)null);
											popupWindowData = popupWindowData3;
											if (!flag13)
											{
												((GridLayoutGroup)obj14).constraint = GridLayoutGroup.Constraint.FixedColumnCount;
												object obj15 = obj4;
												bool flag14 = obj4 == null;
												num3 = 0;
												num = unchecked((nint)null);
												popupWindowData = (PopupWindowData)1;
												if (!flag14)
												{
													bool flag15 = obj14 == null;
													num3 = 0;
													num = unchecked((nint)null);
													popupWindowData = (PopupWindowData)1;
													if (!flag15)
													{
														object obj16 = typeof(System.Buffers.Text.ParserHelpers) + 3568;
														object obj17 = obj14;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v15+48]");
														((GridLayoutGroup)obj17).constraintCount = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														RectOffset rectOffset = default(RectOffset);
														rectOffset..ctor(40, 40, 0, 0);
														bool flag16 = obj14 == null;
														object obj18 = 0;
														int num4 = 0;
														num3 = 0;
														num = 40;
														popupWindowData = (PopupWindowData)40;
														if (!flag16)
														{
															((LayoutGroup)obj14).padding = rectOffset;
															LinearLayoutGroup linearLayoutGroup = buttonsContainer;
															bool flag17 = (object)buttonsContainer == null;
															obj18 = 0;
															num4 = 0;
															num3 = 0;
															num = unchecked((nint)null);
															popupWindowData = (PopupWindowData)(object)rectOffset;
															if (!flag17)
															{
																bool flag18 = (object)gridButtonsContainer == null;
																obj18 = 0;
																num4 = 0;
																num3 = 0;
																num = unchecked((nint)null);
																popupWindowData = (PopupWindowData)(object)rectOffset;
																if (!flag18)
																{
																	double num5 = ((HorizontalOrVerticalLayoutGroup)linearLayoutGroup).m_Spacing;
																	gridButtonsContainer.spacing = (Vector2)0;
																	bool flag19 = obj14 == null;
																	double num6 = 20.0;
																	obj18 = 0;
																	num4 = 0;
																	num3 = 0;
																	num = unchecked((nint)null);
																	popupWindowData = null;
																	if (!flag19)
																	{
																		((LayoutGroup)obj14).childAlignment = TextAnchor.UpperCenter;
																		PopupButton[] array2 = buttonsList;
																		bool flag20 = buttonsList == null;
																		num6 = 20.0;
																		obj18 = 0;
																		num4 = 0;
																		num3 = 0;
																		num = unchecked((nint)null);
																		popupWindowData = (PopupWindowData)1;
																		if (!flag20)
																		{
																			object obj19 = obj4;
																			bool flag21 = obj4 == null;
																			num6 = 20.0;
																			obj18 = 0;
																			num4 = 0;
																			num3 = 0;
																			num = unchecked((nint)null);
																			popupWindowData = (PopupWindowData)1;
																			if (!flag21)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X9_v7+48]");
																				num6 = 0.0;
																				object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
																				object obj21 = obj20;
																				double num7 = array2.Length;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X9_v7+48]");
																				double num8 = num7 / 0.0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X0_v49+E4]");
																				bool flag22 = (nint)0 == 0;
																				object obj22 = !flag22;
																				if (obj22 == null)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
																				double num9 = ((num6 != 2139095040.0) ? num8 : 2147483648.0);
																				object obj23 = obj4;
																				bool flag23 = obj4 == null;
																				num5 = 2139095040.0;
																				obj18 = 0;
																				num4 = 0;
																				num3 = 0;
																				num = unchecked((nint)null);
																				popupWindowData = (PopupWindowData)1;
																				if (!flag23)
																				{
																					object obj24 = obj14;
																					bool flag24 = obj14 == null;
																					num5 = 2139095040.0;
																					obj18 = 0;
																					num4 = 0;
																					num3 = 0;
																					num = unchecked((nint)null);
																					popupWindowData = (PopupWindowData)1;
																					if (!flag24)
																					{
																						Transform transform2 = gameObject.transform;
																						bool flag25 = (object)transform2 == null;
																						num5 = 2139095040.0;
																						obj18 = 0;
																						num4 = 0;
																						num3 = 0;
																						num = unchecked((nint)null);
																						popupWindowData = null;
																						if (!flag25)
																						{
																							object obj25 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
																							popupWindowData = (PopupWindowData)obj25;
																							bool flag26 = transform2 != obj25;
																							num5 = 2139095040.0;
																							obj18 = 0;
																							num4 = 0;
																							num3 = 0;
																							num = unchecked((nint)null);
																							if (flag26)
																							{
																								goto IL_0ae3;
																							}
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22+4C]");
																							double num10 = 0.0 * num9;
																							double num11 = num9 - 1.0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X9_v10+74]");
																							num5 = 0.0 * num11;
																							float num12 = (float)num10 + (float)num5;
																							((RectTransform)transform2).SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num12);
																							object obj26 = obj4;
																							bool flag27 = obj4 == null;
																							num6 = num12;
																							obj18 = 0;
																							num4 = 0;
																							num3 = 0;
																							num = unchecked((nint)null);
																							popupWindowData = (PopupWindowData)1;
																							if (!flag27)
																							{
																								object obj27 = typeof(SqlSingle[]) + 2376;
																								object obj28 = (nint)0 + (nint)1328;
																								object obj29 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27+48]");
																								nint num13 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v27+4C]");
																								UpdateGridCellSize((int)num13, 0f);
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																								Action action = default(Action);
																								action..ctor(obj2, (IntPtr)obj28);
																								object obj30 = obj29;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v56+E4]");
																								bool flag28 = (nint)0 == 0;
																								object obj31 = !flag28;
																								if (obj31 == null)
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																								}
																								CoroutineDummy.WaitForEndOfFrame(action);
																								return;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag29 = (object)buttonsContainer == null;
					popupWindowData = popupData;
					if (!flag29)
					{
						LinearLayoutGroup linearLayoutGroup2 = buttonsContainer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+44]");
						linearLayoutGroup2.LayoutOrientation = LinearLayoutGroup.Orientation.Horizontal;
						object obj32 = obj4;
						bool flag30 = obj4 == null;
						nint num = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+44]");
						popupWindowData = (PopupWindowData)0;
						if (!flag30)
						{
							bool flag31 = (object)buttonsContainer == null;
							num = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+44]");
							popupWindowData = (PopupWindowData)0;
							if (!flag31)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v8+44]");
								bool reverseArrangement = (nint)0 == 0;
								buttonsContainer.reverseArrangement = reverseArrangement;
								return;
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ad5;
		IL_0af1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0ae3:
		ex = new InvalidCastException();
		goto IL_0af1;
		IL_0ad5:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		goto IL_0ae3;
	}

	private void UpdateGridCellSize(int columns, float buttonHeight)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		PopupUI popupUI = popup;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = popupUI.content.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
		object obj3 = default(object);
		if ((nint)0 != 0)
		{
			bool flag = (nint)obj3 < 0;
			object obj4 = !flag;
			bool flag2 = obj3 == null;
			object obj5 = ~obj4;
			object obj6 = obj5 | flag2;
			if (obj6 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (nint)obj3 < 0;
			object obj7 = !flag3;
			bool flag4 = obj3 == null;
			object obj8 = !flag4;
			object obj9 = obj7 & obj8;
			if (obj9 == null)
			{
				return;
			}
		}
		LinearLayoutGroup linearLayoutGroup = buttonsContainer;
		int horizontal = ((LayoutGroup)linearLayoutGroup).m_Padding.horizontal;
		GridLayoutGroup gridLayoutGroup = gridButtonsContainer;
		int horizontal2 = ((LayoutGroup)gridLayoutGroup).m_Padding.horizontal;
		gridButtonsContainer.cellSize = (Vector2)0;
	}

	private void SetupInput(PopupWindowInputData inputData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_016f: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I
		//IL_01fd: Expected I, but got O
		//IL_0236: Expected O, but got I4
		//IL_0250: Expected O, but got I4
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0278: Expected O, but got I4
		//IL_02ec: Expected F4, but got I4
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0390: Expected O, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03bf: Expected I, but got O
		//IL_031b: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = inputData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = textField.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = inputField.gameObject;
		gameObject2.SetActive(value: true);
		object obj5 = obj3;
		InputFieldTMProUGUI inputFieldTMProUGUI = inputField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v4+18]");
		inputFieldTMProUGUI.SetPlaceholder((LocalizableText)0);
		object obj6 = obj3;
		InputFieldTMProUGUI inputFieldTMProUGUI2 = inputField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v5+10]");
		inputFieldTMProUGUI2.ContentType = InputField.ContentType.Standard;
		object obj7 = obj3;
		Image image = inputIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v6+20]");
		image.sprite = (Sprite)0;
		GameObject gameObject3 = inputIcon.gameObject;
		object obj8 = obj3;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v20+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v7+20]");
		bool active = (UnityEngine.Object)0;
		gameObject3.SetActive(active);
		Button button = primaryButton;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj13 = (nint)0 + (nint)1336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj13);
		button.m_OnClick.AddListener(unityAction);
		InputField.ContentType contentType = inputField.ContentType;
		object obj14 = contentType - 7;
		bool flag2 = (nint)obj14 < 1;
		object obj15 = !flag2;
		object obj16 = obj14 - 1;
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		object obj18 = obj15 & obj17;
		InputFieldTMProUGUI inputFieldTMProUGUI3;
		float characterSpacing;
		if (obj18 == null)
		{
			inputField.FontSize = 70f;
			inputFieldTMProUGUI3 = inputField;
			characterSpacing = 5f;
		}
		else
		{
			inputField.FontSize = 48f;
			inputFieldTMProUGUI3 = inputField;
			characterSpacing = 0f;
		}
		inputFieldTMProUGUI3.CharacterSpacing = characterSpacing;
		object obj19 = typeof(SqlSingle[]) + 2376;
		object obj20 = (nint)0 + (nint)1344;
		object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj20);
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X0_v34+E4]");
		bool flag4 = (nint)0 == 0;
		object obj23 = !flag4;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
	}

	private void InitializeButtons()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_0458: Expected I, but got O
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_03bf: Expected I, but got O
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_0239: Expected O, but got I
		//IL_024a: Expected I, but got O
		//IL_0340: Expected O, but got I
		//IL_034e: Expected I, but got O
		//IL_02a3: Expected O, but got I4
		//IL_0398: Expected O, but got I4
		PopupButton[] array = buttonsList;
		if (buttonsList == null)
		{
			goto IL_03e9;
		}
		if (array.Length < 1)
		{
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = buttonsList + 32;
		object obj3 = 0;
		object obj5 = default(object);
		UnityEvent unityEvent2 = default(UnityEvent);
		UnityAction unityAction2 = default(UnityAction);
		UnityAction unityAction4 = default(UnityAction);
		while (true)
		{
			object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj5..ctor();
			bool flag = (nint)obj3 < array.Length;
			object obj6 = !flag;
			if (obj6 != null)
			{
				break;
			}
			object obj7;
			PopupWindowButton popupWindowButton;
			PopupButton popupButton;
			UnityEvent unityEvent;
			if (obj5 != null)
			{
				obj7 = obj5 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X27_v5+v113 @ X26_v6*8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				popupWindowButton = <InitializeButtons>g__CreateButton|36_0((PopupButton)obj7);
				if ((object)popupWindowButton != null)
				{
					GameObject gameObject = popupWindowButton.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: true);
						popupButton = (PopupButton)obj7;
						if (obj7 != null)
						{
							bool flag2 = popupButton.Action == null;
							UnityAction unityAction = (UnityAction)1;
							unityEvent = (UnityEvent)(object)gameObject;
							if (flag2)
							{
								goto IL_02c6;
							}
							Button <Button>k__BackingField = popupWindowButton.<Button>k__BackingField;
							if ((object)popupWindowButton.<Button>k__BackingField != null)
							{
								unityEvent2 = <Button>k__BackingField.m_OnClick;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj8 = (nint)0 + (nint)1352;
								unityAction2..ctor(obj5, (IntPtr)obj8);
								if (<Button>k__BackingField.m_OnClick != null)
								{
									<Button>k__BackingField.m_OnClick.AddListener(unityAction2);
									popupButton = (PopupButton)obj7;
									bool flag3 = obj7 == null;
									object obj9 = 0;
									unityAction = unityAction2;
									unityEvent = <Button>k__BackingField.m_OnClick;
									if (!flag3)
									{
										goto IL_02c6;
									}
								}
							}
						}
					}
				}
			}
			goto IL_03e9;
			IL_02c6:
			bool flag4 = !popupButton.Dismiss;
			UnityAction unityAction3 = (UnityAction)(object)unityEvent2;
			PopupWindow popupWindow = (PopupWindow)(object)unityEvent;
			if (!flag4)
			{
				Button <Button>k__BackingField2 = popupWindowButton.<Button>k__BackingField;
				if ((object)popupWindowButton.<Button>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = (nint)0 + (nint)1504;
					unityAction4..ctor(this, (IntPtr)obj10);
					if (<Button>k__BackingField2.m_OnClick != null)
					{
						<Button>k__BackingField2.m_OnClick.AddListener(unityAction4);
						popupButton = (PopupButton)obj7;
						object obj9 = 0;
						unityAction3 = unityAction4;
						popupWindow = (PopupWindow)(object)<Button>k__BackingField2.m_OnClick;
						goto IL_0427;
					}
				}
				goto IL_03e9;
			}
			goto IL_0427;
			IL_0427:
			popupWindow.InitializeLabels(popupWindowButton, popupButton);
			bool flag5 = object.Equals(primaryButton, null);
			bool flag6 = !flag5;
			nint num = unchecked((nint)null);
			if (!flag6)
			{
				num = (nint)popupWindowButton.<Button>k__BackingField;
				primaryButton = popupWindowButton.<Button>k__BackingField;
				object obj11 = this + 168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			obj3++;
			bool flag7 = (nint)obj3 >= array.Length;
			unityEvent2 = (UnityEvent)(object)unityAction3;
			if (!flag7)
			{
				continue;
			}
			return;
		}
		goto IL_03f7;
		IL_03e9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03f7;
		IL_03f7:
		throw new IndexOutOfRangeException();
	}

	private void InitializeLabels(PopupWindowButton popupButton, PopupButton actionButton)
	{
		//IL_001f: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		PopupButton popupButton2 = default(PopupButton);
		bool flag = popupButton2.Type < PopupButton.ButtonType.Purchase;
		object obj = !flag;
		object obj2 = ~obj;
		PopupWindowButton popupWindowButton = default(PopupWindowButton);
		if (obj2 == null)
		{
			if (popupButton2.Type != PopupButton.ButtonType.Purchase)
			{
				object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = "ThisIsFakeReceiptData" + 2840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				ex..ctor(paramName);
				object obj5 = (nint)0 + (nint)1528;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
			if ((object)popupWindowButton._label != null)
			{
				TextMeshProExtensions.Localize(popupWindowButton._label, popupButton2.Label);
			}
			if ((object)popupWindowButton._price != null)
			{
				TextMeshProExtensions.SetPriceText(popupWindowButton._price, popupButton2.Price, useCommas: true);
			}
		}
		else if ((object)popupWindowButton._label != null)
		{
			TextMeshProExtensions.Localize(popupWindowButton._label, popupButton2.Label);
		}
	}

	public static void SetLoading(bool loading)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0216: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_0250: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_02c8: Expected O, but got I
		//IL_0191: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7953]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v27+E4]");
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
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v27+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v8+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v5+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_026e;
		IL_012d:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v19+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v11+20]");
		((PopupWindow)0).SetPopupLoading(loading);
		return;
		IL_00fe:
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj18 = 0;
		if (!flag6)
		{
			goto IL_012d;
		}
		return;
		IL_026e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj14;
		bool flag8 = !flag7;
		object obj19 = !flag8;
		obj18 = 0;
		if (obj19 == null)
		{
			return;
		}
		goto IL_012d;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v27+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v14+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v14+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag9)
		{
			goto IL_00fe;
		}
		goto IL_026e;
	}

	private void SetPopupLoading(bool loading)
	{
		//IL_0018: Expected O, but got I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_016a: Expected O, but got I4
		loadingIndicator.SetActive(loading);
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A44]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = primaryButton;
			obj6 = primaryButton;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = primaryButton;
			obj6 = primaryButton;
			if (obj7 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c7;
		IL_00c7:
		bool interactable = (byte)((loading ? 1u : 0u) ^ 1u) != 0;
		primaryButton.interactable = interactable;
		return;
		IL_00a0:
		if (obj5 != null)
		{
			goto IL_00c7;
		}
	}

	public static void EnablePrimaryButton(bool interactable)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_01d9: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_021b: Expected O, but got I
		//IL_0259: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_0434: Expected O, but got I
		//IL_0444: Expected O, but got I
		//IL_02c7: Expected O, but got I4
		//IL_02dd: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03c4: Expected O, but got I4
		//IL_03d4: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_0415: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A43]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v41+E4]");
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
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v41+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v29+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v16+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v16+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_0106;
		}
		goto IL_0229;
		IL_036e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5+A8]");
		((Selectable)0).interactable = interactable;
		return;
		IL_0347:
		UnityEngine.Object obj15;
		if (obj15 != null)
		{
			goto IL_036e;
		}
		return;
		IL_026f:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v4+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v5+20]");
		object obj19 = 0;
		object obj20 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A44]");
		object obj21 = (nint)0 & (nint)1;
		UnityEngine.Object obj23;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5+A8]");
			obj15 = (UnityEngine.Object)0;
			object obj22 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v7+E4]");
			bool flag5 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5+A8]");
			obj23 = (UnityEngine.Object)0;
			if (!flag5)
			{
				goto IL_0347;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5+A8]");
			obj15 = (UnityEngine.Object)0;
			object obj22 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v5+A8]");
			obj23 = (UnityEngine.Object)0;
			if (obj24 != null)
			{
				goto IL_0347;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj23 != null;
		bool flag8 = !flag7;
		object obj25 = !flag8;
		if (obj25 == null)
		{
			return;
		}
		goto IL_036e;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v41+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v22+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v22+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag9)
		{
			goto IL_0106;
		}
		goto IL_0229;
		IL_0229:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = obj14;
		bool flag11 = !flag10;
		object obj27 = 0;
		obj4 = obj7;
		if (!flag11)
		{
			goto IL_026f;
		}
		return;
		IL_0106:
		bool flag12 = obj11;
		bool flag13 = !flag12;
		object obj28 = !flag13;
		obj27 = 0;
		if (obj28 == null)
		{
			return;
		}
		goto IL_026f;
	}

	private void SetPrimaryButtonEnabled(bool interactable)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A44]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = primaryButton;
			obj6 = primaryButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = primaryButton;
			obj6 = primaryButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		primaryButton.interactable = interactable;
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
	}

	public static void SetError(string error, bool localize = true)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_021a: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0254: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_02a4: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_02cc: Expected O, but got I
		//IL_0195: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7954]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v27+E4]");
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
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v27+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v8+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_0272;
		IL_012d:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v19+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+20]");
		((PopupWindow)0).SetPopupError(error, localize);
		return;
		IL_00fe:
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj18 = 0;
		if (!flag6)
		{
			goto IL_012d;
		}
		return;
		IL_0272:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj14;
		bool flag8 = !flag7;
		object obj19 = !flag8;
		obj18 = 0;
		if (obj19 == null)
		{
			return;
		}
		goto IL_012d;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v27+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v14+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v14+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag9)
		{
			goto IL_00fe;
		}
		goto IL_0272;
	}

	private void SetPopupError(string error, bool localize = true)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0162: Expected O, but got I4
		//IL_018b: Expected O, but got I
		errorContainer.SetActive(value: true);
		bool flag = !localize;
		string text = error;
		if (!flag)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = LocalizationUtil.Localize(error);
			text = text2;
		}
		TextMeshProExtensions.FixArabic(errorText, text);
		PopupUI popupUI = popup;
		int num = ShortcutExtensions.DOKill(popupUI.content, complete: true);
		PopupUI popupUI2 = popup;
		object obj4 = typeof(UsageHint) + 744;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v11+B8]");
		object obj6 = 0;
		popupUI2.content.anchoredPosition = (Vector2)0;
		PopupUI popupUI3 = popup;
		object obj7 = typeof(SqlSingle[]) + 3912;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.ErrorFeedback(popupUI3.content, 10f, 1f);
		object obj10 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public static void ClearError()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01d7: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0217: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0251: Expected O, but got I4
		//IL_0261: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_02c9: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_0192: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7956]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v28+E4]");
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
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v28+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v8+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_026f;
		IL_012d:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v11+20]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v12+68]");
		((GameObject)0).SetActive(value: false);
		return;
		IL_00fe:
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj19 = 0;
		if (!flag6)
		{
			goto IL_012d;
		}
		return;
		IL_026f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj14;
		bool flag8 = !flag7;
		object obj20 = !flag8;
		obj19 = 0;
		if (obj20 == null)
		{
			return;
		}
		goto IL_012d;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v28+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v15+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v15+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag9)
		{
			goto IL_00fe;
		}
		goto IL_026f;
	}

	private void ClearPopupError()
	{
		errorContainer.SetActive(value: false);
	}

	public static void DismissMessage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_0222: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_025c: Expected O, but got I
		//IL_029c: Expected O, but got I4
		//IL_02a5: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_02c4: Expected O, but got I
		//IL_018d: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7957]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+E4]");
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
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v8+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_026a;
		IL_012d:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v11+20]");
		((PopupWindow)0).Dismiss();
		return;
		IL_00fe:
		bool flag5 = obj11;
		bool flag6 = !flag5;
		object obj18 = 0;
		if (!flag6)
		{
			goto IL_012d;
		}
		return;
		IL_026a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = obj14;
		bool flag8 = !flag7;
		object obj19 = !flag8;
		obj18 = 0;
		if (obj19 == null)
		{
			return;
		}
		goto IL_012d;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v27+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v14+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v14+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag9)
		{
			goto IL_00fe;
		}
		goto IL_026a;
	}

	private void Dismiss()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0221: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7958]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
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
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AllowBackAction();
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj8;
		obj4 = obj6;
		if (obj9 != null)
		{
			goto IL_00d3;
		}
		goto IL_01c3;
		IL_00d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v20+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v11+18]");
		Actions.SafeInvoke((Action)0);
		PopupUI popupUI = popup;
		goto IL_0103;
		IL_0103:
		popupUI.SlideToBottom();
		return;
		IL_01c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+18]");
		Actions.SafeInvoke((Action)0);
		popupUI = popup;
		bool flag4 = (object)popup == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0103;
		IL_0099:
		ScreenManager.AllowBackAction();
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag5)
		{
			goto IL_00d3;
		}
		goto IL_01c3;
	}

	private void ResetMessage()
	{
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_0692: Expected O, but got I4
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_06b0: Expected O, but got I4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_003e: Expected O, but got I
		//IL_0418: Expected O, but got I
		//IL_0428: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0466: Expected O, but got I4
		//IL_0476: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I
		//IL_04d8: Expected O, but got I
		//IL_04e8: Expected O, but got I
		//IL_04fe: Expected O, but got I
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_0157: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_0539: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0201: Expected O, but got I
		//IL_024f: Expected O, but got I
		//IL_0558: Expected O, but got I
		//IL_0568: Expected O, but got I
		//IL_057e: Expected O, but got I
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_05a6: Expected O, but got I4
		//IL_05b6: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_029a: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_0618: Expected O, but got I
		//IL_0628: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_05f0: Expected O, but got I4
		//IL_030a: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0330: Expected O, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_0368: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_0679: Expected O, but got I
		object obj = this + 160;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 168;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 176;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3-60]");
		Transform transform = ((UnityEngine.Component)0).transform;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v2+38]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v2+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v4+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v4+10]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag = obj9 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v4+10]");
			object obj10 = 0;
			if (!flag)
			{
				goto IL_00c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v2+38]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+10]");
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag2 = obj13 == null;
			object obj14 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+10]");
			object obj10 = 0;
			if (obj14 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		if (obj15 != null)
		{
			goto IL_00e9;
		}
		goto IL_04be;
		IL_02d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v30+E4]");
		if ((nint)0 != 0)
		{
			goto IL_02fa;
		}
		goto IL_05fe;
		IL_0385:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v38+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(extraContentContainer, (GameObject[])except);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		errorContainer.SetActive(value: false);
		GameObject gameObject2 = txtMessageBody.gameObject;
		gameObject2.SetActive(value: true);
		return;
		IL_02fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v34+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v34+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag4 = obj19 == null;
		object obj20 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v34+10]");
		object obj21 = 0;
		if (obj20 == null)
		{
			goto IL_0376;
		}
		goto IL_0385;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00e9;
		}
		goto IL_04be;
		IL_04be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v2+38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+10]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+10]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		if (obj25 == null)
		{
			goto IL_0165;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v6+10]");
		object obj26 = 0;
		goto IL_0174;
		IL_05fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v22+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v22+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		if (obj29 == null)
		{
			goto IL_0376;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v22+10]");
		obj21 = 0;
		goto IL_0385;
		IL_00e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X21_v2+38]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v43+10]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v43+10]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag5 = obj32 == null;
		object obj33 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v43+10]");
		obj26 = 0;
		if (obj33 == null)
		{
			goto IL_0165;
		}
		goto IL_0174;
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0174;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v22+B8]");
		object except2 = 0;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])except2);
		loadingIndicator.SetActive(value: false);
		GameObject gameObject3 = inputField.gameObject;
		gameObject3.SetActive(value: false);
		object obj34 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v17+90]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v18+B8]");
		object text = 0;
		inputField.Text = (string)text;
		GameObject gameObject4 = textField.gameObject;
		gameObject4.SetActive(value: false);
		object obj36 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3+38]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+10]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+10]");
			object obj39 = (nint)0 + (nint)309;
			object obj40 = obj39 & 1;
			bool flag6 = obj40 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v20+10]");
			object obj41 = 0;
			if (!flag6)
			{
				goto IL_02d5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X21_v3+38]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v27+10]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v27+10]");
			object obj43 = (nint)0 + (nint)309;
			object obj44 = obj43 & 1;
			bool flag7 = obj44 == null;
			object obj45 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v27+10]");
			object obj41 = 0;
			if (obj45 != null)
			{
				goto IL_02d5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v30+E4]");
		bool flag8 = (nint)0 == 0;
		object obj46 = !flag8;
		if (obj46 != null)
		{
			goto IL_02fa;
		}
		goto IL_05fe;
		IL_0376:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0385;
	}

	public static void ShowInfo(string title, string body, string buttonText = "OK")
	{
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03da: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_00e8: Expected I, but got O
		//IL_010c: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014a: Expected I, but got O
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0286: Expected I, but got O
		//IL_0296: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected I, but got Unknown
		//IL_037d: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E795A]");
		nint num = 0;
		object obj4 = default(object);
		object obj7 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr = default(IntPtr);
		object obj15 = default(object);
		object obj21 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(MessageType.Info);
			PopupButton button = PopupButton.Neutral(buttonText, null, dismiss: true);
			object obj3;
			if (popupWindowBuilder != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 392;
				IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
				nint num2 = (nint)popupWindowBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X10_v10-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag)
					{
						continue;
					}
					goto IL_00d6;
				}
				object obj5 = num2 + obj3;
				object obj6 = obj5 + 312;
				num = (nint)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v294 @ X0_v23] (should have been resolved before IL gen)");
				bool flag2 = obj7 == null;
				obj4 = obj3;
				if (!flag2)
				{
					goto IL_0179;
				}
			}
			goto IL_038b;
			IL_0229:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X0_v15 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			obj4 = obj3;
			num = intPtr;
			if (!flag3)
			{
				goto IL_026a;
			}
			goto IL_038b;
			IL_026a:
			object obj8 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v1-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj4 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_0312;
				}
				goto IL_0399;
			}
			goto IL_0312;
			IL_038b:
			ex = new NullReferenceException();
			goto IL_0399;
			IL_0399:
			object obj10 = obj4 + 9;
			object obj11 = num + obj10;
			object obj12 = obj11 + 312;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v5+8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v210 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_00d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X0_v20] (should have been resolved before IL gen)");
			bool flag4 = obj7 == null;
			object obj16 = !flag4;
			obj3 = obj4;
			if (obj16 != null)
			{
				goto IL_0179;
			}
			goto IL_038b;
			IL_0179:
			object obj17 = typeof(System.IOAsyncCallback) + 384;
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0229;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v1-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj3 = obj4 + 16;
				obj19--;
				bool flag5 = (nint)obj19 != 1;
				obj4 = obj3;
				if (flag5)
				{
					continue;
				}
				goto IL_0229;
			}
			goto IL_033e;
			IL_0312:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v13+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v261 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_033e;
			IL_033e:
			object obj23 = obj18 + obj4;
			num = (nint)(obj23 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v201 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			object obj24 = !flag6;
			if (obj24 != null)
			{
				goto IL_026a;
			}
			goto IL_038b;
		}
	}

	public static void ShowError(string message = "Internal error, please try again later.", Action callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Drop Menu Toggle" + 3600;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ShowError((string)title, message, (string)buttonText, callback);
	}

	public static void ShowError(string title, string message, string buttonText = "OK", Action callback = null)
	{
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_0095: Expected O, but got I
		//IL_012b: Expected I, but got O
		//IL_00d0: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_016e: Expected I, but got O
		//IL_017e: Expected O, but got I
		//IL_021c: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0249: Expected I, but got O
		//IL_026d: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E795B]");
		nint num = 0;
		object obj4 = default(object);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj12 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(callback, buttonText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				LocalizableText localizableText = TextMeshProExtensions.Localize(title);
				if (popupWindowBuilder._instance != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					object obj2 = popupWindowBuilder._instance + 24;
					obj2 = localizableText;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2 = (nint)popupWindowBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0119;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj4 + 16;
						obj3--;
						bool flag = (nint)obj3 != 1;
						obj4 = obj5;
						if (flag)
						{
							continue;
						}
						goto IL_0119;
					}
					goto IL_0226;
				}
			}
			goto IL_0283;
			IL_0283:
			ex = new NullReferenceException();
			goto IL_0291;
			IL_0291:
			object obj6 = obj5 + 9;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v5+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v172 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_01fa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v12+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v193 @ X2_v6 (should have been resolved before IL gen)");
			goto IL_0226;
			IL_0226:
			object obj14 = num2 + obj4;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v269 @ X0_v18] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj5 = obj4;
			if (obj16 != null)
			{
				goto IL_0152;
			}
			goto IL_0283;
			IL_0119:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ X0_v15] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_0152;
			}
			goto IL_0283;
			IL_0152:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj5 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_01fa;
				}
				goto IL_0291;
			}
			goto IL_01fa;
		}
	}

	public static void ShowConfirm(string msgTitle, string msgBody, Action confirmAction)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0462: Expected O, but got I4
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_04fd: Expected O, but got I
		//IL_0089: Expected I, but got O
		//IL_0099: Expected O, but got I
		//IL_012f: Expected I, but got O
		//IL_0153: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_02b6: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019a: Expected I, but got O
		//IL_01c4: Expected O, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e8: Expected I, but got O
		//IL_02f8: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0387: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected I, but got Unknown
		//IL_03d3: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_0333: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_04d7: Expected O, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E795C]");
		nint num = 0;
		object label = "Complete" + 256;
		object label2 = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(MessageType.Action);
		PopupButton button = PopupButton.Positive((string)label, confirmAction);
		bool flag = popupWindowBuilder == null;
		object obj = 0;
		object obj4;
		object obj5 = default(object);
		object obj8 = default(object);
		if (!flag)
		{
			object obj2 = typeof(System.IOAsyncCallback) + 392;
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
			PopupButton button2 = PopupButton.Neutral((string)label2, null, dismiss: true);
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes2 = popupWindowBuilder.AddButton(button2);
			nint num2 = (nint)popupWindowBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_011d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X10_v11-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 = obj4 + 16;
				obj3--;
				bool flag2 = (nint)obj3 != 1;
				obj4 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_011d;
			}
			object obj6 = num2 + obj4;
			object obj7 = obj6 + 312;
			num = (nint)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X0_v28] (should have been resolved before IL gen)");
			bool flag3 = obj8 == null;
			obj5 = obj4;
			obj = 0;
			if (!flag3)
			{
				goto IL_01d2;
			}
		}
		goto IL_03ea;
		IL_02cc:
		object obj9 = typeof(System.IOAsyncCallback) + 368;
		NullReferenceException ex = default(NullReferenceException);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0374;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v16-8]");
			bool flag4 = 0 == (nint)obj9;
			obj = 0;
			if (flag4)
			{
				break;
			}
			obj5 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0374;
		}
		goto IL_03f8;
		IL_04e5:
		object obj12;
		object obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v3+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v273 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_03f8:
		object obj14 = obj5 + 9;
		object obj15 = num + obj14;
		obj12 = obj15 + 312;
		goto IL_04e5;
		IL_0282:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X0_v20 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag5 = ex == null;
		obj5 = obj4;
		obj = 0;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag5)
		{
			goto IL_02cc;
		}
		goto IL_03ea;
		IL_03ea:
		ex = new NullReferenceException();
		goto IL_03f8;
		IL_011d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj16 = default(object);
		num = (nint)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X0_v25] (should have been resolved before IL gen)");
		bool flag6 = obj8 == null;
		object obj17 = !flag6;
		obj4 = obj5;
		if (obj17 != null)
		{
			goto IL_01d2;
		}
		obj = 0;
		goto IL_03ea;
		IL_01d2:
		object obj18 = typeof(System.IOAsyncCallback) + 384;
		object obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v12+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0282;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v12+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v16-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj4 = obj5 + 16;
			obj20--;
			bool flag7 = (nint)obj20 != 1;
			obj5 = obj4;
			if (flag7)
			{
				continue;
			}
			goto IL_0282;
		}
		object obj21 = obj19 + obj5;
		num = (nint)(obj21 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag8 = ex == null;
		object obj22 = !flag8;
		obj = 0;
		if (obj22 != null)
		{
			goto IL_02cc;
		}
		goto IL_03ea;
		IL_0374:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj = 0;
		object obj23 = default(object);
		obj12 = obj23;
		goto IL_04e5;
	}

	public static void ShowNegativeConfirm(string msgTitle = "Confirm", string msgBody = "Are you sure?", Action action = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02f0: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_00ee: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018c: Expected I, but got O
		//IL_019c: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0267: Expected I, but got O
		//IL_028b: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E795D]");
		nint num = 0;
		object confirmText = "WhiteSmoke" + 1504;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		object obj4 = default(object);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj12 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)confirmText, (string)cancelText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				LocalizableText localizableText = TextMeshProExtensions.Localize(msgTitle);
				if (popupWindowBuilder._instance != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					object obj2 = popupWindowBuilder._instance + 24;
					obj2 = localizableText;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2 = (nint)popupWindowBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0137;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj4 + 16;
						obj3--;
						bool flag = (nint)obj3 != 1;
						obj4 = obj5;
						if (flag)
						{
							continue;
						}
						goto IL_0137;
					}
					goto IL_0244;
				}
			}
			goto IL_02a1;
			IL_02a1:
			ex = new NullReferenceException();
			goto IL_02af;
			IL_02af:
			object obj6 = obj5 + 9;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v5+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v182 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_0218:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v12+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v201 @ X2_v7 (should have been resolved before IL gen)");
			goto IL_0244;
			IL_0244:
			object obj14 = num2 + obj4;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X0_v18] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj5 = obj4;
			if (obj16 != null)
			{
				goto IL_0170;
			}
			goto IL_02a1;
			IL_0137:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ X0_v15] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_0170;
			}
			goto IL_02a1;
			IL_0170:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj5 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0218;
				}
				goto IL_02af;
			}
			goto IL_0218;
		}
	}

	public static void ShowNegativeConfirmWithAction(string msgTitle = "Confirm", string msgBody = "Are you sure?", Action confirmAction = null, Action dismissAction = null)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_00ee: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018c: Expected I, but got O
		//IL_019c: Expected O, but got I
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0252: Expected I, but got O
		//IL_0276: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E795E]");
		nint num = 0;
		object confirmText = "WhiteSmoke" + 1504;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirmWithNegativeAction(confirmAction, dismissAction, (string)confirmText, (string)cancelText);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		if (popupWindowBuilder != null)
		{
			LocalizableText localizableText = TextMeshProExtensions.Localize(msgTitle);
			if (popupWindowBuilder._instance != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 384;
				object obj2 = popupWindowBuilder._instance + 24;
				obj2 = localizableText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num2 = (nint)popupWindowBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0137;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8 (Il2CppClass<PopupWindowBuilder>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj4 + 16;
					obj3--;
					bool flag = (nint)obj3 != 1;
					obj4 = obj5;
					if (flag)
					{
						continue;
					}
					goto IL_0137;
				}
				object obj6 = num2 + obj4;
				object obj7 = obj6 + 312;
				num = (nint)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v19] (should have been resolved before IL gen)");
				bool flag2 = ex == null;
				object obj8 = !flag2;
				obj5 = obj4;
				if (obj8 != null)
				{
					goto IL_0170;
				}
			}
		}
		goto IL_028c;
		IL_0137:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		num = (nint)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v16] (should have been resolved before IL gen)");
		if (ex != null)
		{
			goto IL_0170;
		}
		goto IL_028c;
		IL_028c:
		ex = new NullReferenceException();
		goto IL_029a;
		IL_0170:
		object obj10 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0218;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X10_v10-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj5 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0218;
		}
		goto IL_029a;
		IL_029a:
		object obj12 = obj5 + 9;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_0346;
		IL_0346:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v222 @ X8_v3] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0218:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = default(object);
		obj14 = obj15;
		goto IL_0346;
	}

	public static void AskForPassword(string title, Sprite icon, Action<string> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AskFor(InputField.ContentType.Password, title, icon, callback);
	}

	public static void AskForPin(string title, Sprite icon, Action<string> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AskFor(InputField.ContentType.Pin, title, icon, callback);
	}

	private static void AskFor(InputField.ContentType contentType, string title, Sprite icon, Action<string> callback)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		object text = "October" + 3392;
		LocalizableText placeholder = TextMeshProExtensions.Localize((string)text);
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.From(contentType, callback, placeholder);
		object obj = typeof(System.IOAsyncCallback) + 376;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)popupWindowBuilderInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X10_v5-8]");
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
			goto IL_00d0;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_0178;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj7 = default(object);
		obj6 = obj7;
		goto IL_0178;
		IL_0178:
		object msgBody = "ThisIsFakeReceiptData" + 3008;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X8_v6] (should have been resolved before IL gen)");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPopupWindowBuilderInput inputData = default(IPopupWindowBuilderInput);
		ShowPrompt(title, (string)msgBody, inputData, (string)primaryText);
	}

	public static void ShowPrompt(string msgTitle, string msgBody, IPopupWindowBuilderInput inputData, string primaryText = "OK")
	{
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected I, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026d: Expected I, but got O
		//IL_027d: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected I, but got Unknown
		//IL_0364: Expected O, but got I4
		//IL_02b8: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7961]");
		nint num = 0;
		object obj4 = default(object);
		object obj6 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		object obj21 = default(object);
		while (true)
		{
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreatePrompt(inputData, primaryText);
			object obj3;
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 392;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00c5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X10_v10-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 = obj3 + 16;
					obj2--;
					bool flag = (nint)obj2 != 1;
					obj3 = obj4;
					if (flag)
					{
						continue;
					}
					goto IL_00c5;
				}
				object obj5 = num2 + obj3;
				num = (nint)(obj5 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj6 == null;
				obj4 = obj3;
				if (!flag2)
				{
					goto IL_0160;
				}
			}
			goto IL_0372;
			IL_0325:
			object obj8;
			object obj7 = obj8 + obj4;
			num = (nint)(obj7 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v216 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_0251;
			}
			goto IL_0372;
			IL_0210:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X0_v11 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag4 = ex == null;
			obj4 = obj3;
			num = intPtr;
			if (!flag4)
			{
				goto IL_0251;
			}
			goto IL_0372;
			IL_0251:
			object obj10 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v1-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj4 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_02f9;
				}
				goto IL_0380;
			}
			goto IL_02f9;
			IL_0372:
			ex = new NullReferenceException();
			goto IL_0380;
			IL_00c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ X0_v15 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag5 = obj6 == null;
			object obj12 = !flag5;
			obj3 = obj4;
			if (obj12 != null)
			{
				goto IL_0160;
			}
			num = intPtr2;
			goto IL_0372;
			IL_0380:
			object obj13 = obj4 + 9;
			object obj14 = num + obj13;
			object obj15 = obj14 + 312;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v5+8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v225 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0160:
			object obj18 = typeof(System.IOAsyncCallback) + 384;
			obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v13+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0210;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v13+B0]");
			obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v1-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				obj3 = obj4 + 16;
				obj19--;
				bool flag6 = (nint)obj19 != 1;
				obj4 = obj3;
				if (flag6)
				{
					continue;
				}
				goto IL_0210;
			}
			goto IL_0325;
			IL_02f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v9+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v255 @ X2_v7 (should have been resolved before IL gen)");
			goto IL_0325;
		}
	}

	public static void ShowLoading(string msgBody = "Loading", bool dismissible = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_018e: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_02f0: Expected O, but got I
		//IL_0312: Expected O, but got I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_036b: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0245: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_03df: Expected O, but got I
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_0523: Expected O, but got I4
		//IL_0280: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateBuilder(MessageType.Waiting);
		object obj = typeof(System.IOAsyncCallback) + 392;
		object obj2 = "Picking audio files is not supported on iOS" + 616;
		nint num = (nint)popupWindowBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<PopupWindowBuilder>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<PopupWindowBuilder>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<PopupWindowBuilder>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v24-8]");
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
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X8_v28] (should have been resolved before IL gen)");
		goto IL_0127;
		IL_01cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = default(object);
		object obj7 = obj8;
		goto IL_047e;
		IL_047e:
		object obj9 = typeof(System.IOAsyncCallback) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v151 @ X8_v11] (should have been resolved before IL gen)");
		object obj11 = default(object);
		if (dismissible)
		{
			object label = "Network Authentication Required" + 3128;
			PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v18+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v18+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v18+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X10_v14-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_02c1;
			}
			object obj14 = obj10 + obj13;
			object obj15 = obj14 + 312;
			goto IL_04d9;
		}
		object obj16 = obj9;
		object obj17 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+12E]");
		bool flag = (nint)0 == 0;
		object obj19 = !flag;
		if (obj19 != null)
		{
			goto IL_0355;
		}
		object obj21 = default(object);
		object obj20 = obj21;
		object obj22 = obj9;
		goto IL_03bd;
		IL_04d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ X0_v18] (should have been resolved before IL gen)");
		obj16 = obj9;
		obj17 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+12E]");
		obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+12E]");
		bool flag2 = (nint)0 == 0;
		obj20 = 0;
		obj22 = obj9;
		if (!flag2)
		{
			goto IL_0355;
		}
		goto IL_03bd;
		IL_041c:
		throw new NullReferenceException();
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v26] (should have been resolved before IL gen)");
		object obj23 = default(object);
		bool flag3 = obj23 == null;
		object obj24 = !flag3;
		if (obj24 != null)
		{
			goto IL_0127;
		}
		goto IL_041c;
		IL_0127:
		object obj25 = typeof(System.IOAsyncCallback) + 384;
		object obj26 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v10+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v10+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X10_v19-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_01cf;
		}
		object obj29 = obj26 + obj28;
		obj7 = obj29 + 312;
		goto IL_047e;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v13+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v8-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj30 += 16;
			obj18--;
			bool flag4 = (nint)obj18 != 1;
			obj20 = 0;
			obj22 = obj16;
			if (flag4)
			{
				continue;
			}
			goto IL_03bd;
		}
		goto IL_03e9;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04d9;
		IL_03e9:
		object obj31 = obj30 + 9;
		object obj32 = obj17 + obj31;
		object obj33 = obj32 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v480 @ X0_v14] (should have been resolved before IL gen)");
		goto IL_041c;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj35 = default(object);
		object obj34 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X0_v11+8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v201 @ X2_v7 (should have been resolved before IL gen)");
		goto IL_03e9;
	}

	static PopupWindow()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00b7: Expected O, but got I
		object obj = "Picking audio files is not supported on iOS" + 888;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3136;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = "Picking audio files is not supported on iOS" + 896;
		object obj5 = "Picking audio files is not supported on iOS" + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj6 = obj3;
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+B8]");
		object obj10 = (nint)0 + (nint)8;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+B8]");
		object obj13 = (nint)0 + (nint)16;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private PopupWindowButton <InitializeButtons>g__CreateButton|36_0(PopupButton actionButton)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0436: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0276: Expected O, but got I4
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0359: Expected O, but got I4
		//IL_04b4: Expected O, but got I
		//IL_02b8: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7964]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gridButtonsContainer;
			obj6 = gridButtonsContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = gridButtonsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = gridButtonsContainer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		object obj10 = 0;
		if (obj8 != null)
		{
			goto IL_00cd;
		}
		goto IL_01b6;
		IL_0413:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindowButton popupWindowButton2;
		PopupWindowButton popupWindowButton = popupWindowButton2;
		goto IL_042a;
		IL_042a:
		object obj11 = (nint)0 + (nint)584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		PopupWindowButton result = default(PopupWindowButton);
		return result;
		IL_0450:
		object obj12 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = "ThisIsFakeReceiptData" + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		ex..ctor(paramName);
		object obj14 = (nint)0 + (nint)1496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (PopupWindowButton)(object)new OutOfMemoryException();
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = 0;
		if (!flag6)
		{
			goto IL_00cd;
		}
		goto IL_01b6;
		IL_01b6:
		UnityEngine.Component component = buttonsContainer;
		if ((object)buttonsContainer != null)
		{
			goto IL_01df;
		}
		goto IL_0445;
		IL_00cd:
		component = gridButtonsContainer;
		bool flag7 = (object)gridButtonsContainer == null;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			goto IL_01df;
		}
		obj10 = obj9;
		goto IL_0445;
		IL_01df:
		Transform transform = component.transform;
		bool flag8 = actionButton == null;
		obj10 = 0;
		if (!flag8)
		{
			if (actionButton.Type <= PopupButton.ButtonType.Negative)
			{
				if (actionButton.Type != PopupButton.ButtonType.Positive)
				{
					bool flag9 = actionButton.Type != PopupButton.ButtonType.Negative;
					obj10 = 0;
					if (flag9)
					{
						goto IL_0450;
					}
					popupWindowButton = negButton;
					object obj16 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v22+E4]");
					bool flag10 = (nint)0 == 0;
					object obj17 = !flag10;
					if (obj17 == null)
					{
						popupWindowButton2 = negButton;
						goto IL_0413;
					}
				}
				else
				{
					popupWindowButton = posButton;
					object obj16 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v22+E4]");
					bool flag11 = (nint)0 == 0;
					object obj18 = !flag11;
					if (obj18 == null)
					{
						popupWindowButton2 = posButton;
						goto IL_0413;
					}
				}
			}
			else if (actionButton.Type != PopupButton.ButtonType.Neutral)
			{
				bool flag12 = actionButton.Type != PopupButton.ButtonType.Purchase;
				obj10 = 0;
				if (flag12)
				{
					goto IL_0450;
				}
				popupWindowButton = purchaseButton;
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v22+E4]");
				bool flag13 = (nint)0 == 0;
				object obj19 = !flag13;
				if (obj19 == null)
				{
					popupWindowButton2 = purchaseButton;
					goto IL_0413;
				}
			}
			else
			{
				popupWindowButton2 = normalButton;
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v22+E4]");
				bool flag14 = (nint)0 == 0;
				object obj20 = !flag14;
				popupWindowButton = normalButton;
				if (obj20 == null)
				{
					goto IL_0413;
				}
			}
			goto IL_042a;
		}
		goto IL_0445;
		IL_0445:
		throw new NullReferenceException();
	}
}
