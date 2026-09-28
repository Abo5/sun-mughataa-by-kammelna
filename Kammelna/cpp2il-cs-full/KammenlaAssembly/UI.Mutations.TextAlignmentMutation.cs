using System;
using TMPro;
using UnityEngine;

namespace UI.Mutations;

[Serializable]
public class TextAlignmentMutation : IMutation
{
	private TextMeshProUGUI textField;

	private TextAlignmentOptions alternateAlignment;

	private TextAlignmentOptions _originalAlignment;

	public void Setup(GameObject gm)
	{
		TextAlignmentOptions alignment = textField.alignment;
		_originalAlignment = alignment;
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		textField.alignment = alternateAlignment;
	}

	public void UndoMutation()
	{
		textField.alignment = _originalAlignment;
	}
}
