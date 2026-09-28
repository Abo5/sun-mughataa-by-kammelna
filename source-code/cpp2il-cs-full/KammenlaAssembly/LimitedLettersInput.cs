using System;
using System.Diagnostics;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class LimitedLettersInput : MonoBehaviour
{
	private TextMeshProUGUI lettersLeft;

	private InputFieldTMProUGUI inputField;

	private int maximumLetters;

	private unsafe void Start()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected I4, but got Unknown
		//IL_001c: Expected I, but got O
		//IL_002c: Expected O, but got I
		//IL_003c: Expected O, but got I
		object obj = ", stale={0}" + 3528;
		while (true)
		{
			TextMeshProUGUI textMeshProUGUI = lettersLeft;
			int num = this + 48;
			string text = ((int*)num)->ToString();
			string text2 = (string)obj + text;
			nint num2 = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c4: Expected I, but got O
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = inputField + 96;
		Delegate obj4 = (Delegate)obj3;
		object obj7 = default(object);
		bool flag2;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj5 = Delegate.Combine(obj4, action);
			if ((object)obj5 == null)
			{
				object obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj7 == null;
				object obj8 = !flag;
				object obj6 = obj7;
				if (obj8 == null)
				{
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag2 = (object)obj9 == obj4;
			obj4 = obj9;
		}
		while (!flag2);
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c4: Expected I, but got O
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = inputField + 96;
		Delegate obj4 = (Delegate)obj3;
		object obj7 = default(object);
		bool flag2;
		Delegate obj9 = default(Delegate);
		do
		{
			Delegate obj5 = Delegate.Remove(obj4, action);
			if ((object)obj5 == null)
			{
				object obj6 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj7 == null;
				object obj8 = !flag;
				object obj6 = obj7;
				if (obj8 == null)
				{
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag2 = (object)obj9 == obj4;
			obj4 = obj9;
		}
		while (!flag2);
	}

	private unsafe void InputValueChanged(string val)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		int num = this + 48;
		if (val._stringLength < ((int*)num)->m_value)
		{
			lettersLeft.fontStyle = FontStyles.Normal;
		}
		else
		{
			CutExceededValue(val);
		}
		object obj = ", stale={0}" + 2920;
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = ((int*)num)->ToString();
		string text3 = text + (string)obj + text2;
		lettersLeft.text = text3;
	}

	private void CutExceededValue(string val)
	{
		InputFieldTMProUGUI inputFieldTMProUGUI = inputField;
		string text = val.Substring(0, maximumLetters);
		inputFieldTMProUGUI.input.text = text;
		lettersLeft.fontStyle = FontStyles.Bold;
	}

	private bool LimitExceeded(int num)
	{
		//IL_000f: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected I4, but got Unknown
		object obj = num - maximumLetters;
		bool flag = (nint)obj < 0;
		int num2 = num ^ maximumLetters;
		int num3 = num ^ obj;
		int num4 = num2 & num3;
		bool flag2 = num4 < 0;
		return flag == flag2;
	}

	private void SetStyleToExceeded()
	{
		lettersLeft.fontStyle = FontStyles.Bold;
	}

	private void SetStyleToNormal()
	{
		lettersLeft.fontStyle = FontStyles.Normal;
	}

	private unsafe void SetLettersLeftText(int lettersAmount)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		object obj = ", stale={0}" + 2920;
		int num = default(int);
		string text = num.ToString();
		int num2 = this + 48;
		string text2 = ((int*)num2)->ToString();
		string text3 = text + (string)obj + text2;
		lettersLeft.text = text3;
	}
}
