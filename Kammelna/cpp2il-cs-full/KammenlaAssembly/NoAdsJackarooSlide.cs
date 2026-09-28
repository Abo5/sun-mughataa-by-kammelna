using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

public class NoAdsJackarooSlide : CommonJackarooSlide
{
	private RectTransform orangeBubble;

	private RectTransform grayBubble;

	private Image blockSign;

	private AnimationCurve bounceCurve;

	private Sequence sequence;

	public override Sequence OnShow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_023e: Expected O, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_01a3: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)2904;
		object t = this + 112;
		TweenExtensions.Kill((Tween)t);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(grayBubble, 1f, 0.25f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Append(this.sequence, t2);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(orangeBubble, 1f, 0.25f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t3 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(this.sequence, t3);
		if ((object)blockSign != null)
		{
			RectTransform rectTransform = blockSign.rectTransform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(rectTransform, 1f, 0.7f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t4 = default(Tween);
			Sequence s = TweenSettingsExtensions.Append(this.sequence, t4);
			TweenerCore<Color, Color, ColorOptions> t5 = DOTweenModuleUI.DOFade(blockSign, 1f, 0.4f);
			Sequence s2 = TweenSettingsExtensions.Join(s, t5);
			if ((object)blockSign != null)
			{
				object obj5 = (nint)0 + (nint)2896;
				RectTransform rectTransform2 = blockSign.rectTransform;
				TweenerCore<Vector2, Vector2, VectorOptions> t6 = DOTweenModuleUI.DOPivotY(rectTransform2, 0f, 0.45f);
				Sequence s3 = TweenSettingsExtensions.Join(s2, t6);
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(grayBubble, 1.3f, 0.2f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				Tween t7 = default(Tween);
				Sequence sequence4 = TweenSettingsExtensions.Append(s3, t7);
				return this.sequence;
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_00cc: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		base.Hide();
		object t = this + 112;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(blockSign, 0f, 0.3f);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
		RectTransform rectTransform = blockSign.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOPivotY(rectTransform, 1.5f, 0.35f);
		Sequence s2 = TweenSettingsExtensions.Join(s, t3);
		object obj4 = (nint)0 + (nint)2904;
		RectTransform rectTransform2 = blockSign.rectTransform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform2, 2f, 0.35f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t4 = default(Tween);
		Sequence s3 = TweenSettingsExtensions.Join(s2, t4);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(orangeBubble, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t5 = default(Tween);
		Sequence s4 = TweenSettingsExtensions.Join(s3, t5);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(grayBubble, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t6 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s4, t6);
	}

	public override void SetHidden()
	{
		//IL_0015: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		//IL_0051: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		grayBubble.localScale = (Vector3)0;
		orangeBubble.localScale = (Vector3)0;
		RectTransform rectTransform = blockSign.rectTransform;
		rectTransform.localScale = (Vector3)0;
		RectTransform rectTransform2 = blockSign.rectTransform;
		rectTransform2.pivot = (Vector2)0;
		UIExtensions.SetAlpha(blockSign, 0f);
	}

	public NoAdsJackarooSlide()
	{
		showTitleDelay = 0.17f;
		base.fadePivot = 1.25f;
		((MonoBehaviour)this)..ctor();
	}
}
