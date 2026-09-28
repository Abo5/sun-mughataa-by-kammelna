using System;
using System.ComponentModel;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class CopyFromFieldButton : MonoBehaviour
{
	private TextMeshProUGUI textFieldToCopy;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		object obj = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj3 = (nint)0 + (nint)3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private void CopyField()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		TextMeshProUGUI textMeshProUGUI = textFieldToCopy;
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1976;
		nint num = (nint)textMeshProUGUI;
		string text = textMeshProUGUI.text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			GUIUtility.systemCopyBuffer = text;
			((CopyFromFieldButton)(object)text).ShowCopiedToolTip();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			GUIUtility.systemCopyBuffer = text;
			((CopyFromFieldButton)(object)text).ShowCopiedToolTip();
		}
	}

	private void ShowCopiedToolTip()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B6F]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = "Complete" + 1568;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Complete" + 1568;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = (string)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7C]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		string text2 = (string)obj6;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_01eb;
		IL_012b:
		LocalizableText localizableText;
		Vector2 displacement;
		Toast.Show(localizableText, displacement, 0f);
		return;
		IL_0255:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Vector2 vector;
		displacement = vector;
		LocalizableText localizableText2;
		localizableText = localizableText2;
		goto IL_012b;
		IL_00d7:
		localizableText = TextMeshProExtensions.Localize(text);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (!flag4)
		{
			goto IL_012b;
		}
		goto IL_0255;
		IL_0094:
		text = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7C]");
		object obj11 = (nint)0 & (nint)1;
		bool flag5 = obj11 == null;
		text2 = (string)obj4;
		if (!flag5)
		{
			goto IL_00d7;
		}
		goto IL_01eb;
		IL_01eb:
		_ = 1;
		localizableText = TextMeshProExtensions.Localize(text2);
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (obj12 != null)
		{
			goto IL_012b;
		}
		goto IL_0255;
	}
}
