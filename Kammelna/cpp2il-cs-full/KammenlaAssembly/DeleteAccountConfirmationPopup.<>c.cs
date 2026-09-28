using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DeleteAccountConfirmationPopup : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__7_1;

		public static Action<KammelnaResponseModel<bool>> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <DeleteAccount>b__7_0(KammelnaResponseModel<bool> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_0169: Expected O, but got I
			//IL_0241: Expected O, but got I
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_02a8: Expected O, but got I
			//IL_02b8: Expected O, but got I
			//IL_02da: Expected O, but got I4
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_0715: Expected O, but got Unknown
			//IL_071d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0722: Expected O, but got Unknown
			//IL_072b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0730: Expected O, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected O, but got Unknown
			//IL_01f0: Expected O, but got I
			//IL_0200: Expected O, but got I
			//IL_0222: Expected O, but got I4
			//IL_0749: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected O, but got Unknown
			//IL_0764: Expected O, but got I
			//IL_0775: Expected I, but got O
			//IL_077d: Expected I, but got O
			//IL_0793: Expected O, but got I
			//IL_030a: Expected O, but got I4
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected O, but got Unknown
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Expected O, but got Unknown
			//IL_03a7: Expected I, but got O
			//IL_03b7: Expected O, but got I
			//IL_0469: Expected O, but got I4
			//IL_033a: Expected O, but got I
			//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Expected O, but got Unknown
			//IL_050e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0513: Expected O, but got Unknown
			//IL_052b: Expected O, but got I
			//IL_03f2: Expected O, but got I
			//IL_0566: Expected O, but got I
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Expected O, but got Unknown
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Expected I, but got Unknown
			//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0604: Expected O, but got Unknown
			//IL_060c: Expected I, but got O
			//IL_061c: Expected O, but got I
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Expected O, but got Unknown
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Expected O, but got Unknown
			//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c7: Expected I, but got Unknown
			//IL_06eb: Expected O, but got I4
			//IL_0657: Expected O, but got I
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Expected O, but got Unknown
			//IL_0582: Unknown result type (might be due to invalid IL or missing references)
			//IL_0587: Expected O, but got Unknown
			//IL_0665: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Expected O, but got Unknown
			//IL_0673: Unknown result type (might be due to invalid IL or missing references)
			//IL_0678: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E687E]");
			object obj2 = (nint)0 & (nint)1;
			nint num;
			nint num2;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				num2 = 0;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v38+E4]");
				num2 = 0;
				if (obj4 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			bool flag3 = response == null;
			num = num2;
			if (!flag3)
			{
				goto IL_015d;
			}
			goto IL_06f9;
			IL_073a:
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)2120;
			Action action = default(Action);
			object obj7 = default(object);
			action..ctor(obj7, (IntPtr)obj6);
			object obj8 = default(object);
			num = (nint)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+B8]");
			object obj9 = (nint)0 + (nint)8;
			obj9 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action action2 = action;
			goto IL_033f;
			IL_0707:
			object obj11 = default(object);
			object obj10 = obj11 + 9;
			object obj12 = num + obj10;
			object obj13 = obj12 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v237 @ X8_v4] (should have been resolved before IL gen)");
			goto IL_073a;
			IL_06f9:
			NullReferenceException ex = new NullReferenceException();
			goto IL_0707;
			IL_0094:
			PopupWindow.DismissMessage();
			bool flag4 = response == null;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_015d;
			}
			goto IL_06f9;
			IL_015d:
			object obj15 = (nint)0 + (nint)1048;
			if (response.Succeeded)
			{
				obj8 = typeof(DebugUI.BitField) + 704;
				object obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v28+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v28+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v28+B8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v30+8]");
					action2 = (Action)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v30+8]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 == null)
					{
						goto IL_02e8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj16 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v28+B8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v30+8]");
					action2 = (Action)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X9_v30+8]");
					bool flag6 = (nint)0 == 0;
					object obj18 = !flag6;
					if (obj18 == null)
					{
						goto IL_02e8;
					}
				}
				goto IL_033f;
			}
			object obj19 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(errorMessage);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError(errorMessage);
			return;
			IL_04f0:
			object obj21 = typeof(System.IOAsyncCallback) + 384;
			object obj22 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3272;
			object obj24 = default(object);
			object obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v24+12E]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v24+12E]");
			if ((nint)0 == 0)
			{
				goto IL_05af;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v24+B0]");
			obj11 = (nint)0 + (nint)8;
			object obj26;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v15-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				obj26 = obj11 + 16;
				obj25--;
				bool flag7 = (nint)obj25 != 1;
				obj11 = obj26;
				if (flag7)
				{
					continue;
				}
				goto IL_05af;
			}
			goto IL_06ac;
			IL_043b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v24 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj24 == null;
			object obj27 = !flag8;
			obj26 = obj11;
			if (obj27 != null)
			{
				goto IL_04f0;
			}
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
			goto IL_06f9;
			IL_0698:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v523 @ X0_v18] (should have been resolved before IL gen)");
			goto IL_06ac;
			IL_033f:
			object buttonText = "Error reading data from socket: " + 1016;
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(action2, (string)buttonText);
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj28 = typeof(System.IOAsyncCallback) + 392;
				object obj29 = "DNQUALIFIER" + 3784;
				nint num3 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_043b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v18 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X10_v10-8]");
					if (0 == (nint)obj28)
					{
						break;
					}
					obj11 = obj26 + 16;
					obj30--;
					bool flag9 = (nint)obj30 != 1;
					obj26 = obj11;
					if (flag9)
					{
						continue;
					}
					goto IL_043b;
				}
				object obj31 = num3 + obj26;
				num = (nint)(obj31 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag10 = obj24 == null;
				obj11 = obj26;
				if (!flag10)
				{
					goto IL_04f0;
				}
			}
			goto IL_06f9;
			IL_05af:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v473 @ X0_v20 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag11 = ex == null;
			obj11 = obj26;
			IntPtr intPtr2 = default(IntPtr);
			num = intPtr2;
			if (!flag11)
			{
				goto IL_05f0;
			}
			goto IL_06f9;
			IL_05f0:
			object obj32 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0698;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+B0]");
			obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v15-8]");
				if (0 == (nint)obj32)
				{
					break;
				}
				obj11 += 16;
				obj33--;
				if ((nint)obj33 != 1)
				{
					continue;
				}
				goto IL_0698;
			}
			goto IL_0707;
			IL_02e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v28+E4]");
			bool flag12 = (nint)0 == 0;
			object obj34 = !flag12;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj35 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v43+B8]");
				obj7 = 0;
			}
			goto IL_073a;
			IL_06ac:
			object obj36 = obj23 + obj11;
			num = (nint)(obj36 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ X8_v2 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag13 = ex == null;
			object obj37 = !flag13;
			if (obj37 != null)
			{
				goto IL_05f0;
			}
			goto IL_06f9;
		}

		internal void <DeleteAccount>b__7_1()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Complete" + 3512;
			Prefs.DeleteKey((string)key);
			SFS.Logout();
		}
	}

	private PopupUI popup;

	private TextMeshProUGUI pinLabel;

	private InputFieldTMProUGUI pinInput;

	private Button confirmButton;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007b: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		pinInput.OnValueChanged += action;
		Button button = confirmButton;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj4 = (nint)0 + (nint)2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj4);
		button.m_OnClick.AddListener(unityAction);
	}

	private void PinInputOnValueChanged(string newValue)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E687A]");
		object obj3 = (nint)0 & (nint)1;
		InputFieldTMProUGUI inputFieldTMProUGUI;
		InputFieldTMProUGUI inputFieldTMProUGUI2;
		if (obj3 != null)
		{
			inputFieldTMProUGUI = pinInput;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			inputFieldTMProUGUI2 = pinInput;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			inputFieldTMProUGUI = pinInput;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			inputFieldTMProUGUI2 = pinInput;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = StringUtil.HinduToArabicNumber(newValue);
		inputFieldTMProUGUI = inputFieldTMProUGUI2;
		goto IL_0146;
		IL_0146:
		inputFieldTMProUGUI.Text = text;
		string text2 = pinInput.Text;
		string text3 = pinLabel.text;
		bool interactable = text2 == text3;
		confirmButton.interactable = interactable;
		return;
		IL_0091:
		text = StringUtil.HinduToArabicNumber(newValue);
		bool flag3 = (object)inputFieldTMProUGUI == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0146;
	}

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		object obj = ", stale={0}" + 3560;
		popup.PopFromCenter();
		int num = UnityEngine.Random.Range(0, 10000);
		int num2 = default(int);
		string text = num2.ToString((string)obj);
		pinLabel.text = text;
		object text2 = (nint)0 + (nint)2000;
		pinInput.Text = (string)text2;
		confirmButton.interactable = false;
	}

	private void DeleteAccount()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_013a: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_0216: Expected I, but got O
		//IL_0234: Expected O, but got I
		//IL_01cc: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj2 = typeof(DebugUI.BitField) + 704;
		popup.ShrinkToParent();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
		object obj6;
		Action<KammelnaResponseModel<bool>> callback;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v2+10]");
			callback = (Action<KammelnaResponseModel<bool>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v2+10]");
			if ((nint)0 != 0)
			{
				goto IL_010e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v2+10]");
			callback = (Action<KammelnaResponseModel<bool>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X9_v2+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_010e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v12+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2112;
		Action<object> action = default(Action<object>);
		action..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		KammelnaRequests.DeleteAccount(action);
		return;
		IL_010e:
		KammelnaRequests.DeleteAccount(callback);
	}
}
