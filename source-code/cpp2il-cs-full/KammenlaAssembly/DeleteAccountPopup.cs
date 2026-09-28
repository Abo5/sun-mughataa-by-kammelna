using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class DeleteAccountPopup : MonoBehaviour
{
	private AssetReferenceGameObject deleteConfirmationPopup;

	public void DeleteAccount()
	{
		//IL_063b: Expected O, but got I4
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0048: Expected I, but got O
		//IL_0058: Expected O, but got I
		//IL_074e: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_07af: Expected O, but got I
		//IL_0597: Expected O, but got I
		//IL_06c6: Expected I, but got O
		//IL_0233: Expected O, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected I, but got Unknown
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected I, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0343: Expected O, but got I
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_03d9: Expected I, but got O
		//IL_03fb: Expected O, but got I4
		//IL_037e: Expected O, but got I
		//IL_0429: Expected I, but got O
		//IL_0439: Expected O, but got I
		//IL_04c8: Expected O, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0508: Expected I, but got O
		//IL_052c: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_0474: Expected O, but got I
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_070e: Expected O, but got I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6880]");
		nint num = 0;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		bool flag = popupWindowBuilderNeedsTitle == null;
		object obj = 152985600;
		object obj5;
		object obj6 = default(object);
		object obj8 = default(object);
		if (!flag)
		{
			object obj2 = typeof(System.IOAsyncCallback) + 392;
			object obj3 = "DNQUALIFIER" + 2328;
			obj = obj3;
			nint num2 = (nint)popupWindowBuilderNeedsTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v18-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6 = obj5 + 16;
				obj4--;
				bool flag2 = (nint)obj4 != 1;
				obj5 = obj6;
				if (flag2)
				{
					continue;
				}
				goto IL_00dc;
			}
			object obj7 = num2 + obj5;
			num = (nint)(obj7 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X8_v7 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = obj8 == null;
			obj6 = obj5;
			if (!flag3)
			{
				goto IL_017f;
			}
		}
		goto IL_0553;
		IL_0691:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X8_v7 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		object label;
		PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj9;
		action..ctor(this, (IntPtr)obj9);
		object label2;
		PopupButton popupButton2 = PopupButton.Negative((string)label2, action);
		object obj10 = default(object);
		bool flag4 = obj10 == null;
		object obj11 = 0;
		Action action2 = action;
		PopupButton popupButton3 = popupButton;
		obj6 = obj5;
		obj = obj10;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag4)
		{
			action2 = (Action)(typeof(System.IOAsyncCallback) + 368);
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v19+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v19+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03c7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v19+B0]");
			obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X10_v8-8]");
				if (0 == (nint)action2)
				{
					break;
				}
				obj5 = obj6 + 16;
				obj13--;
				bool flag5 = (nint)obj13 != 1;
				obj6 = obj5;
				if (flag5)
				{
					continue;
				}
				goto IL_03c7;
			}
			object obj14 = obj12 + obj6;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v570 @ X0_v30] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			object obj16 = !flag6;
			obj11 = 0;
			popupButton3 = popupButton;
			obj = obj10;
			if (obj16 != null)
			{
				goto IL_0421;
			}
		}
		goto IL_0553;
		IL_04b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj11 = 0;
		popupButton3 = popupButton;
		object obj18 = default(object);
		object obj17 = obj18;
		obj = obj10;
		goto IL_072c;
		IL_0553:
		ex = new NullReferenceException();
		goto IL_0561;
		IL_05d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0797;
		IL_072c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X8_v3] (should have been resolved before IL gen)");
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v4+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v4+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05d8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v4+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v6-8]");
			if (0 == (nint)action2)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_05d8;
		}
		object obj22 = obj21 + 9;
		object obj23 = obj19 + obj22;
		object obj24 = obj23 + 312;
		goto IL_0797;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X0_v35 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag7 = obj8 == null;
		object obj25 = !flag7;
		obj5 = obj6;
		if (obj25 != null)
		{
			goto IL_017f;
		}
		popupButton3 = (PopupButton)popupWindowBuilderNeedsTitle;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_0553;
		IL_017f:
		object obj26 = typeof(System.IOAsyncCallback) + 384;
		object obj27 = "___# Content push apply failed [{0}]: {1}" + 2912;
		label = "Network Authentication Required" + 248;
		object obj28 = typeof(SqlSingle[]) + 2376;
		obj9 = (nint)0 + (nint)2920;
		label2 = "Complete" + 264;
		object obj29 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v26-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj5 = obj31 + 16;
			obj30--;
			bool flag8 = (nint)obj30 != 1;
			obj31 = obj5;
			if (flag8)
			{
				continue;
			}
			goto IL_027c;
		}
		object obj32 = obj29 + obj31;
		num = (nint)(obj32 + 312);
		obj5 = obj31;
		goto IL_0691;
		IL_0797:
		object obj33 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v6+8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v498 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_03c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj35 = default(object);
		num = (nint)obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v27] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		obj11 = 0;
		popupButton3 = popupButton;
		obj6 = obj5;
		obj = obj10;
		if (!flag9)
		{
			goto IL_0421;
		}
		goto IL_0553;
		IL_0421:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04b5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X10_v8-8]");
			bool flag10 = 0 == (nint)action2;
			obj11 = 0;
			popupButton3 = popupButton;
			obj = obj10;
			if (flag10)
			{
				break;
			}
			obj6 += 16;
			obj36--;
			if ((nint)obj36 != 1)
			{
				continue;
			}
			goto IL_04b5;
		}
		goto IL_0561;
		IL_0561:
		object obj37 = num + obj6;
		obj17 = obj37 + 312;
		goto IL_072c;
		IL_027c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_0691;
	}

	private void DeleteConfirm()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_004a: Expected I, but got O
		//IL_0074: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2912;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.4f, action);
	}

	private void <DeleteConfirm>b__2_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(deleteConfirmationPopup, CanvasLayer.SecondaryCanvas);
	}
}
