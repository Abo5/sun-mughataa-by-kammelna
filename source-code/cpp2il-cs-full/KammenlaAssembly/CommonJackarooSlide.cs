using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;

public abstract class CommonJackarooSlide : AbstractSlideShowPage
{
	private bool _isVisible;

	private TextMeshProUGUI title;

	public float showTitleDelay = 0.17f;

	private TextMeshProUGUI subTitle;

	private Sequence sequence;

	private float fadePivot = 1.25f;

	public override bool isVisible => _isVisible;

	public abstract Sequence OnShow();

	public override void Show()
	{
		//IL_000c: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2784;
		object obj2 = this + 64;
		TweenExtensions.Kill((Tween)obj2);
		Sequence sequence = ((CommonJackarooSlide)obj2).DisplayTextBottomUp(title, 0f, 1f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		CommonJackarooSlide commonJackarooSlide = default(CommonJackarooSlide);
		Sequence t = commonJackarooSlide.DisplayTextBottomUp(subTitle, 0f, 1f);
		Sequence s = TweenSettingsExtensions.Append((Sequence)(object)commonJackarooSlide, t);
		Tween t2 = OnShow();
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		obj2 = sequence2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_isVisible = true;
	}

	public override void Hide()
	{
		//IL_000c: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_008e: Expected F4, but got I
		//IL_008e: Expected O, but got I
		//IL_00bd: Expected F4, but got I
		//IL_00bd: Expected O, but got I
		object obj = (nint)0 + (nint)2784;
		object obj2 = this + 64;
		TweenExtensions.Kill((Tween)obj2);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X19_v2-18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X19_v2+8]");
		Sequence sequence = ((CommonJackarooSlide)obj3).DisplayTextBottomUp((TextMeshProUGUI)num, 0f, 0f, 0.8f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X19_v2-8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X19_v2+8]");
		Sequence sequence2 = ((CommonJackarooSlide)(object)sequence).DisplayTextBottomUp((TextMeshProUGUI)num2, 0f, 0f, 0.8f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t);
		obj2 = sequence3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
	}

	private Sequence DisplayTextBottomUp(TextMeshProUGUI text, float pivot, float alpha, float durationScale = 1f)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E695D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence sequence = DOTween.Sequence();
		bool flag2 = (object)text == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a3;
		}
		goto IL_01a9;
		IL_00a3:
		RectTransform rectTransform = text.rectTransform;
		float duration = durationScale * 1.05360915E+09f;
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPivotY(rectTransform, pivot, duration);
		Sequence s = TweenSettingsExtensions.Append(sequence, t);
		float duration2 = durationScale * 1.0502537E+09f;
		TweenerCore<Color, Color, ColorOptions> t2 = ShortcutExtensionsTMPText.DOFade(text, alpha, duration2);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		return sequence;
		IL_01a9:
		return (Sequence)(object)new NullReferenceException();
		IL_007d:
		sequence = DOTween.Sequence();
		if ((object)text != null)
		{
			goto IL_00a3;
		}
		goto IL_01a9;
	}

	public override void SetHidden()
	{
		//IL_0047: Expected O, but got I4
		//IL_006e: Expected O, but got I4
		UIExtensions.SetAlpha(title, 0f);
		UIExtensions.SetAlpha(subTitle, 0f);
		RectTransform rectTransform = title.rectTransform;
		rectTransform.pivot = (Vector2)0;
		RectTransform rectTransform2 = subTitle.rectTransform;
		rectTransform2.pivot = (Vector2)0;
	}
}
