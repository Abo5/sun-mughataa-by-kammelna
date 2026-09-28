using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooNodeMono : MonoBehaviour
{
	private Transform <Transform>k__BackingField;

	private Color _selectedColor;

	private Color _defaultColor;

	private Image _nodeImage;

	private MarbleHighlight _marbleHighlight;

	private Image _blockedImage;

	private TweenerCore<Color, Color, ColorOptions> _fadeIn;

	private TweenerCore<Color, Color, ColorOptions> _fadeOut;

	public Transform Transform
	{
		get
		{
			return <Transform>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Vector3 Position
	{
		get
		{
			if ((object)<Transform>k__BackingField != null)
			{
				return <Transform>k__BackingField.position;
			}
			return (Vector3)new NullReferenceException();
		}
	}

	private void Awake()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		Transform transform = base.transform;
		object obj = this + 32;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v2+28]");
		object obj2 = 0;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ X8_v1+298] (should have been resolved before IL gen)");
		Color defaultColor = default(Color);
		_defaultColor = defaultColor;
	}

	public void SetDefaultColor(Color color)
	{
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0050: Expected O, but got I
		Color defaultColor = default(Color);
		_defaultColor = defaultColor;
		Image nodeImage = _nodeImage;
		nint num = (nint)nodeImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SetThemeSelectedColor(Color color)
	{
		Color selectedColor = default(Color);
		_selectedColor = selectedColor;
	}

	public void SetSelectedColor()
	{
		//IL_0029: Expected O, but got I
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		Image nodeImage = _nodeImage;
		Color selectedColor = _selectedColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+34]");
		object obj3 = 0;
		nint num = (nint)nodeImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v9 @ X2_v1 (should have been resolved before IL gen)");
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
		Image nodeImage = _nodeImage;
		Color defaultColor = _defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooNodeMono)+44]");
		object obj3 = 0;
		nint num = (nint)nodeImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v9 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void SetColor(Color color)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		Image nodeImage = _nodeImage;
		nint num = (nint)nodeImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ShowHighlight()
	{
		MarbleHighlight marbleHighlight = _marbleHighlight;
		marbleHighlight._gameObject.SetActive(value: true);
	}

	public void HideHighlight()
	{
		//IL_0051: Expected O, but got I
		//IL_0061: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_0099: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		marbleHighlight._gameObject.SetActive(value: false);
		Image highlightImage = marbleHighlight._highlightImage;
		Color defaultColor = marbleHighlight._defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X19_v1 (Jackaroo.MarbleHighlight)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X19_v1 (Jackaroo.MarbleHighlight)+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X19_v1 (Jackaroo.MarbleHighlight)+34]");
		object obj3 = 0;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SetHighlightColor(Color color)
	{
		//IL_0029: Expected I, but got O
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		Image highlightImage = marbleHighlight._highlightImage;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SetHighlightDefaultColor()
	{
		//IL_003e: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_0076: Expected O, but got I
		//IL_0086: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		Image highlightImage = marbleHighlight._highlightImage;
		Color defaultColor = marbleHighlight._defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Jackaroo.MarbleHighlight)+2C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Jackaroo.MarbleHighlight)+30]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (Jackaroo.MarbleHighlight)+34]");
		object obj3 = 0;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v34 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ApplyHighlightTheme(Color defaultColor)
	{
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		Color defaultColor2 = default(Color);
		marbleHighlight._defaultColor = defaultColor2;
		Image highlightImage = marbleHighlight._highlightImage;
		nint num = (nint)highlightImage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void StartHighlightAnimation()
	{
		//IL_0029: Expected I, but got O
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		DOTweenAnimation animation = marbleHighlight._animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1D8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void HideHighlightAnimation()
	{
		//IL_0037: Expected I, but got O
		//IL_0047: Expected O, but got I
		//IL_0057: Expected O, but got I
		MarbleHighlight marbleHighlight = _marbleHighlight;
		marbleHighlight._animation.DORewind();
		DOTweenAnimation animation = marbleHighlight._animation;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ShowBlocked(float duration, float delay)
	{
		//IL_006f: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2736;
		if (_fadeOut != null)
		{
			TweenExtensions.Kill(_fadeOut);
		}
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(_blockedImage, 1f, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj2 = this + 96;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void HideBlocked(float duration)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (_fadeIn != null)
		{
			TweenExtensions.Kill(_fadeIn);
		}
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(_blockedImage, 0f, duration);
		object obj = this + 104;
		obj = tweenerCore;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
