using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

public class FlashingTxt : MonoBehaviour
{
	private Color flashingColor;

	private float flashInterval;

	private TextMeshProUGUI textField;

	private float time;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0069: Expected F4, but got I
		//IL_0069: Expected O, but got I4
		object obj = (nint)0 + (nint)152;
		object obj2 = (nint)0 + (nint)3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = this + 56;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object target = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X19_v2-18]");
		TweenerCore<Color, Color, ColorOptions> tweenerCore = ShortcutExtensionsTMPText.DOColor((TMP_Text)target, (Color)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
	}

	public void Redo()
	{
		//IL_0011: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0034: Expected F4, but got O
		//IL_0034: Expected O, but got I4
		int num = ShortcutExtensions.DOKill(textField, complete: true);
		object obj = (nint)0 + (nint)3024;
		textField.color = (Color)0;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = ShortcutExtensionsTMPText.DOColor(textField, (Color)0, (float)flashingColor);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
	}

	public FlashingTxt()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E1320]");
		flashingColor = (Color)0;
		flashInterval = 2f;
		base..ctor();
	}
}
