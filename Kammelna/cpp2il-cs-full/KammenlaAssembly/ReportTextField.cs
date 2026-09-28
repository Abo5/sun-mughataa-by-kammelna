using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using ReportEnums;
using UnityEngine;

public class ReportTextField : MonoBehaviour, IReportElement<string>, IDummyReportElement, IReportElement<object>
{
	private ReportElementType type;

	private InputFieldTMProUGUI textField;

	private bool isRequired;

	private GameObject emphasise;

	public ReportElementType Type => type;

	public bool IsReportElementActive
	{
		get
		{
			//IL_00b2: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if ((object)textField != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				string text = textField.Text;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
				if ((nint)0 != 0)
				{
					bool flag = StringsExtensions.IsNullOrEmpty(text);
					return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = StringsExtensions.IsNullOrEmpty(text);
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsRequired => isRequired;

	object IReportElement<object>.Value
	{
		get
		{
			if ((object)textField != null)
			{
				return textField.Text;
			}
			return new NullReferenceException();
		}
	}

	public string Value
	{
		get
		{
			if ((object)textField != null)
			{
				return textField.Text;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public void HighlightRequired()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		if (isRequired)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = textField.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool active = StringsExtensions.IsNullOrEmpty(text);
			emphasise.SetActive(active);
		}
	}
}
