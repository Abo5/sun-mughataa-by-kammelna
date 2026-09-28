using System;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Spine;
using TMPro;
using UnityEngine;

public class SlideShowOverviewPage : AbstractSlideShowPage
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Transform> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <SetHidden>b__8_0(Transform feature)
		{
			//IL_0013: Expected O, but got I4
			feature.localScale = (Vector3)0;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public DG.Tweening.Sequence seq;

		internal void <Show>b__0(Transform t)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2776;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(t, 1f, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t2 = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(seq, t2);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public DG.Tweening.Sequence seq;

		internal void <Hide>b__0(Transform t)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)0 + (nint)2776;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(t, 0f, 0.3f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			Tween t2 = default(Tween);
			DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(seq, t2);
		}
	}

	private TextMeshProUGUI title;

	private Transform[] features;

	private DG.Tweening.Sequence _mainSequence;

	private bool _isVisible;

	public override bool isVisible => _isVisible;

	public override void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_01b9: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 288;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object t = this + 48;
		_ = 1;
		TweenExtensions.Kill((Tween)t);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence mainSequence = DOTween.Sequence();
		_mainSequence = mainSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RectTransform rectTransform = title.rectTransform;
		rectTransform.pivot = (Vector2)0;
		RectTransform rectTransform2 = title.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOPivotX(rectTransform2, 0.5f, 0.4f);
		DG.Tweening.Sequence s = TweenSettingsExtensions.Append(_mainSequence, t2);
		TweenerCore<Color, Color, ColorOptions> t3 = ShortcutExtensionsTMPText.DOFade(title, 1f, 0.3f);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(s, t3);
		DG.Tweening.Sequence sequence2 = DOTween.Sequence();
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		object obj7 = (nint)0 + (nint)3960;
		object obj8 = (nint)0 + (nint)2784;
		object obj9 = (nint)0 + (nint)2408;
		object obj10 = obj3 + 16;
		obj10 = sequence2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj3, (IntPtr)obj7);
		ArraysExtensions.ForEach(features, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t4 = default(Tween);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(_mainSequence, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0131: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_017e: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 296;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object t = this + 48;
		_ = 0;
		TweenExtensions.Kill((Tween)t);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence mainSequence = DOTween.Sequence();
		_mainSequence = mainSequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RectTransform rectTransform = title.rectTransform;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOPivotX(rectTransform, 0f, 0.4f);
		DG.Tweening.Sequence s = TweenSettingsExtensions.Append(_mainSequence, t2);
		TweenerCore<Color, Color, ColorOptions> t3 = ShortcutExtensionsTMPText.DOFade(title, 0f, 0.3f);
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.Join(s, t3);
		DG.Tweening.Sequence sequence2 = DOTween.Sequence();
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		object obj7 = (nint)0 + (nint)3968;
		object obj8 = (nint)0 + (nint)2408;
		object obj9 = obj3 + 16;
		obj9 = sequence2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj3, (IntPtr)obj7);
		ArraysExtensions.ForEach(features, action);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Join(_mainSequence, (Tween)obj9);
		GameObject gameObject = base.gameObject;
		TweenCallback callback = TweenHelpers.Disable(gameObject);
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.AppendCallback(_mainSequence, callback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
	}

	public override void SetHidden()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I
		//IL_01d7: Expected I, but got O
		//IL_01f5: Expected O, but got I
		//IL_014a: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 280;
		UIExtensions.SetAlpha(title, 0f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2400;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_00f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2400;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_00f8;
			}
		}
		goto IL_014f;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3952;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		action = action2;
		goto IL_014f;
		IL_014f:
		ArraysExtensions.ForEach(features, action);
	}
}
