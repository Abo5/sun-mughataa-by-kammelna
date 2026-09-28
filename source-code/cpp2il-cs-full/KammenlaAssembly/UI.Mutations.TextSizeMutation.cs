using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

namespace UI.Mutations;

[Serializable]
public class TextSizeMutation : IMutation
{
	private TextMeshProUGUI textField;

	private bool alternateAutoSize;

	private float alternateFontSize;

	private float alternateFontSizeMin;

	private float alternateFontSizeMax;

	private bool _originalAutoSize;

	private float _originalFontSize;

	private float _originalFontSizeMin;

	private float _originalFontSizeMax;

	public void Setup(GameObject gm)
	{
		TextMeshProUGUI textMeshProUGUI = textField;
		_originalAutoSize = ((TMP_Text)textMeshProUGUI).m_enableAutoSizing;
		_originalFontSize = ((TMP_Text)textMeshProUGUI).m_fontSize;
		_originalFontSizeMin = ((TMP_Text)textMeshProUGUI).m_fontSizeMin;
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		textField.enableAutoSizing = alternateAutoSize;
		textField.fontSizeMin = alternateFontSizeMin;
		textField.fontSizeMax = alternateFontSizeMax;
		textField.fontSize = alternateFontSize;
	}

	public void UndoMutation()
	{
		textField.enableAutoSizing = _originalAutoSize;
		textField.fontSizeMin = _originalFontSizeMin;
		textField.fontSizeMax = _originalFontSizeMax;
		textField.fontSize = _originalFontSize;
	}

	public TextSizeMutation()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253250]");
		alternateFontSize = 0f;
		alternateFontSizeMax = 72f;
		base..ctor();
	}
}
