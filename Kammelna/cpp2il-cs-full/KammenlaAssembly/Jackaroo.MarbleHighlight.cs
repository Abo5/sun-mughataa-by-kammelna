using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Jackaroo;

public class MarbleHighlight : MonoBehaviour
{
	private Image _highlightImage;

	private Color _defaultColor;

	private DOTweenAnimation _animation;

	private GameObject _gameObject;

	public void SetColor(Color color)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		Image highlightImage = _highlightImage;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void RestoreDefaultColor()
	{
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		Image highlightImage = _highlightImage;
		Color defaultColor = _defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+34]");
		object obj3 = 0;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v9 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ApplyTheme(Color defaultColor)
	{
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0050: Expected O, but got I
		Color defaultColor2 = default(Color);
		_defaultColor = defaultColor2;
		Image highlightImage = _highlightImage;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void StartHighlightAnimation()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		DOTweenAnimation animation = _animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void HideHighlightAnimation()
	{
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		_animation.DORewind();
		DOTweenAnimation animation = _animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ShowHighlight()
	{
		_gameObject.SetActive(value: true);
	}

	public void HideHighlight()
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0061: Expected I, but got O
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		_gameObject.SetActive(value: false);
		Image highlightImage = _highlightImage;
		Color defaultColor = _defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+34]");
		object obj3 = 0;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v43 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void Awake()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_008b: Expected I, but got O
		//IL_009b: Expected O, but got I
		//IL_00ab: Expected O, but got I
		GameObject gameObject = base.gameObject;
		object obj = this + 64;
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((GameObject)obj).SetActive(value: false);
		Image highlightImage = _highlightImage;
		Color defaultColor = _defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+2C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+30]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.MarbleHighlight)+34]");
		object obj4 = 0;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
