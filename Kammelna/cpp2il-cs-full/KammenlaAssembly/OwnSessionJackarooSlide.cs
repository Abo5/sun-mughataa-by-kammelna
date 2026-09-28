using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

public class OwnSessionJackarooSlide : CommonJackarooSlide
{
	private Image chair;

	private RectTransform chairBorder;

	private Image crown;

	private Sequence sequence;

	public override Sequence OnShow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02c3: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_01f2: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)2904;
		object obj3 = this + 104;
		TweenExtensions.Kill((Tween)obj3);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(chairBorder, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t);
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(chair, 1f, 0.4f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t2);
		if ((object)chair != null)
		{
			Transform target = chair.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target, 1f, 0.4f);
			Sequence s3 = TweenSettingsExtensions.Join(s2, t3);
			if ((object)chair != null)
			{
				RectTransform rectTransform = chair.rectTransform;
				TweenerCore<Vector2, Vector2, VectorOptions> t4 = DOTweenModuleUI.DOPivotY(rectTransform, 0.5f, 0.4f);
				Sequence s4 = TweenSettingsExtensions.Join(s3, t4);
				TweenerCore<Color, Color, ColorOptions> t5 = DOTweenModuleUI.DOFade(crown, 1f, 0.48000002f);
				Sequence sequence2 = TweenSettingsExtensions.Append(s4, t5);
				Sequence sequence3 = DOTween.Sequence();
				if ((object)crown != null)
				{
					object obj6 = (nint)0 + (nint)2912;
					object obj7 = (nint)0 + (nint)3064;
					RectTransform rectTransform2 = crown.rectTransform;
					TweenerCore<Vector2, Vector2, VectorOptions> t6 = DOTweenModuleUI.DOPivotY(rectTransform2, 0.65f, 1.5f);
					Sequence sequence4 = TweenSettingsExtensions.Append(sequence3, t6);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
					Sequence sequence5 = TweenSettingsExtensions.Append((Sequence)obj3, sequence3);
					return (Sequence)obj3;
				}
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		base.Hide();
		object t = this + 104;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(crown, 0f, 0.2f);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
		RectTransform rectTransform = crown.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOPivotY(rectTransform, 0.45f, 0.2f);
		Sequence s2 = TweenSettingsExtensions.Join(s, t3);
		TweenerCore<Color, Color, ColorOptions> t4 = DOTweenModuleUI.DOFade(chair, 0f, 0.25f);
		Sequence s3 = TweenSettingsExtensions.Append(s2, t4);
		Transform target = chair.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> t5 = ShortcutExtensions.DOScale(target, 0f, 0.25f);
		Sequence s4 = TweenSettingsExtensions.Join(s3, t5);
		RectTransform rectTransform2 = chair.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t6 = DOTweenModuleUI.DOPivotY(rectTransform2, 4f, 0.25f);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t6);
		TweenerCore<Vector3, Vector3, VectorOptions> t7 = ShortcutExtensions.DOScale(chairBorder, 0f, 0.25f);
		Sequence sequence2 = TweenSettingsExtensions.Append(s5, t7);
	}

	public override void SetHidden()
	{
		//IL_001b: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		base.SetHidden();
		chairBorder.localScale = (Vector3)0;
		Transform transform = chair.transform;
		transform.localScale = (Vector3)0;
		RectTransform rectTransform = chair.rectTransform;
		rectTransform.pivot = (Vector2)0;
		RectTransform rectTransform2 = crown.rectTransform;
		rectTransform2.pivot = (Vector2)0;
		UIExtensions.SetAlpha(chair, 0f);
		UIExtensions.SetAlpha(crown, 0f);
	}
}
