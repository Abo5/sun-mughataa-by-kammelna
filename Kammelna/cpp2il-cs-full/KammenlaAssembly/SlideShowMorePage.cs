using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class SlideShowMorePage : SlideShowCommonsPage
{
	private RectTransform badge;

	private Transform icons;

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_0042: Expected O, but got I
		//IL_0052: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		if ((object)badge != null)
		{
			object obj4 = (nint)0 + (nint)2776;
			badge.localScale = (Vector3)0;
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPivot(badge, (Vector2)0, 0.5f);
			Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(icons, 1f, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t2 = default(Tween);
			Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
			return sequence;
		}
		return (Tween)(object)new NullReferenceException();
	}

	protected override Tween AnimateHideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)2776;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPivot(badge, (Vector2)0, 2.5f);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(icons, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
		return sequence;
	}

	public override void SetHidden()
	{
		//IL_001b: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		base.SetHidden();
		badge.pivot = (Vector2)0;
		icons.localScale = (Vector3)0;
	}
}
