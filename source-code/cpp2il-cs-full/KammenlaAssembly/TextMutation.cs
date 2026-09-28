using System;
using Cpp2ILInjected;
using TMPro;
using UI.Mutations;
using UnityEngine;

[Serializable]
public class TextMutation : IMutation
{
	private string alternateText;

	private TextMeshProUGUI textField;

	private bool Localize;

	private string originalText;

	public void Setup(GameObject go)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		string text = textField.text;
		object obj = this + 40;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_004e: Expected I, but got O
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		TextMeshProUGUI textMeshProUGUI = textField;
		if (Localize)
		{
			TextMeshProExtensions.Localize(textMeshProUGUI, alternateText);
			return;
		}
		string text = alternateText;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v19 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void UndoMutation()
	{
		//IL_004e: Expected I, but got O
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		TextMeshProUGUI textMeshProUGUI = textField;
		if (Localize)
		{
			TextMeshProExtensions.Localize(textMeshProUGUI, originalText);
			return;
		}
		string text = originalText;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v2 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v19 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public TextMutation()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "Added Tournament Prizes And Features" + 656;
		object obj2 = this + 16;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Localize = true;
		base..ctor();
	}
}
