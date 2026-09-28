using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UnityEngine;

public class OnBoardingScreen : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<OnBoardingBackgroundsAnimation> <>9__11_0;

		public static Action<OnBoardingBackgroundsAnimation> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1592;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Show>b__11_0(OnBoardingBackgroundsAnimation animation)
		{
			animation.Exit();
			animation.Play();
		}

		internal void <Hide>b__12_0(OnBoardingBackgroundsAnimation animation)
		{
			animation.Exit();
		}
	}

	private RectTransform container;

	private RectTransform title;

	private RectTransform description;

	private Animation phoneAnimator;

	private Animation extraAnimator;

	private OnBoardingBackgroundsAnimation[] onBoardingBackgroundsAnimation;

	private float mainTime = 0.3f;

	private float containerWidth;

	private void Awake()
	{
		Vector2 sizeDelta = container.sizeDelta;
		float num = default(float);
		containerWidth = num;
		HideImmediately();
	}

	private void HideImmediately()
	{
		//IL_0054: Expected O, but got I4
		//IL_0016: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		UIExtensions.MoveTo(x: containerWidth, gObject: container, isWorldPositions: false, y: (float?)(object)0);
		title.localScale = (Vector3)0;
		description.localScale = (Vector3)0;
	}

	public void PrepareToShow()
	{
		//IL_002d: Expected O, but got I4
		UIExtensions.MoveTo(x: 0f, gObject: container, isWorldPositions: false, y: (float?)(object)0);
	}

	public void Show(bool isNextSlide)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_05f0: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_032d: Expected O, but got I4
		//IL_0336: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		//IL_04d4: Expected O, but got I
		//IL_04e4: Expected O, but got I
		//IL_0506: Expected O, but got I4
		//IL_0516: Expected O, but got I
		//IL_03f5: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_045d: Expected O, but got I
		//IL_046d: Expected O, but got I
		//IL_048f: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_0630: Expected O, but got I
		//IL_0641: Expected I, but got O
		//IL_065f: Expected O, but got I
		//IL_04ad: Expected O, but got I
		//IL_0576: Expected O, but got I
		int num = ShortcutExtensions.DOKill(container);
		int num2 = ShortcutExtensions.DOKill(title);
		int num3 = ShortcutExtensions.DOKill(description);
		object obj = (nint)0 + (nint)2712;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Vector3 localPosition = container.localPosition;
		float num4 = default(float);
		bool flag = FloatExtensions.IsNearlyEqualTo(num4, 0f);
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			float value = containerWidth;
			float num5 = 0f - containerWidth;
			bool flag3 = !isNextSlide;
			object obj4 = !flag3;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				value = num5;
			}
			UIExtensions.MoveTo(x: value, gObject: container, isWorldPositions: false, y: (float?)(object)0);
		}
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMoveX(container, 0f, mainTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(title, 1f, mainTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(description, 1f, mainTime);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v24+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			bool flag4 = phoneAnimator;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			obj9 = 0;
			if (obj8 == null)
			{
				goto IL_01c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = phoneAnimator;
			bool flag7 = !flag6;
			obj9 = 0;
			if (flag7)
			{
				goto IL_01c4;
			}
		}
		int num6 = ShortcutExtensions.DOKill(phoneAnimator);
		bool flag8 = phoneAnimator.Play();
		UnityEngine.Object obj10 = extraAnimator;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v46+E4]");
		bool flag9 = (nint)0 == 0;
		object obj12 = !flag9;
		obj6 = 0;
		object obj13 = 0;
		obj9 = 0;
		UnityEngine.Object obj14 = extraAnimator;
		if (obj12 != null)
		{
			goto IL_020d;
		}
		goto IL_034e;
		IL_020d:
		bool flag10 = obj10;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		if (obj15 == null)
		{
			goto IL_023e;
		}
		goto IL_038b;
		IL_023e:
		object obj16 = (nint)0 + (nint)2688;
		object obj17 = obj16;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)onBoardingBackgroundsAnimation))
		{
			return;
		}
		goto IL_040c;
		IL_038b:
		int num7 = ShortcutExtensions.DOKill(extraAnimator);
		bool flag12 = extraAnimator.Play();
		object obj18 = (nint)0 + (nint)2688;
		obj17 = obj18;
		bool flag13 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)onBoardingBackgroundsAnimation);
		bool flag14 = !flag13;
		object obj19 = !flag14;
		obj6 = 0;
		if (obj19 != null)
		{
			return;
		}
		goto IL_040c;
		IL_034e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj14;
		bool flag16 = !flag15;
		obj6 = obj13;
		if (flag16)
		{
			goto IL_023e;
		}
		goto IL_038b;
		IL_05f5:
		Action<object> action;
		ArraysExtensions.ForEach(onBoardingBackgroundsAnimation, action);
		return;
		IL_0524:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v29+E4]");
		bool flag17 = (nint)0 == 0;
		object obj20 = !flag17;
		object obj22;
		object obj23;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v20+B8]");
			obj23 = 0;
		}
		object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)32;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj23, (IntPtr)obj25);
		object obj26 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v19+B8]");
		object obj27 = (nint)0 + (nint)8;
		obj27 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_05f5;
		IL_040c:
		obj22 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1592;
		object obj28 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v29+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
			bool flag18 = (nint)0 == 0;
			object obj29 = !flag18;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
				Action<object> action3 = (Action<object>)0;
				goto IL_0524;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X0_v29+B8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
			Action<object> action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
			bool flag19 = (nint)0 == 0;
			object obj30 = !flag19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v14+8]");
			action = (Action<object>)0;
			if (obj30 == null)
			{
				goto IL_0524;
			}
		}
		goto IL_05f5;
		IL_01c4:
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v46+E4]");
		bool flag20 = (nint)0 == 0;
		obj10 = extraAnimator;
		obj13 = obj6;
		obj14 = extraAnimator;
		if (!flag20)
		{
			goto IL_020d;
		}
		goto IL_034e;
	}

	public void Hide(bool isNextSlide)
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02a3: Expected O, but got I
		//IL_02b4: Expected I, but got O
		//IL_02d2: Expected O, but got I
		//IL_01e2: Expected O, but got I
		object obj = (nint)0 + (nint)2712;
		object obj2 = (nint)0 + (nint)2688;
		float endValue = containerWidth;
		float num = 0f - containerWidth;
		bool flag = !isNextSlide;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			endValue = num;
		}
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMoveX(container, endValue, mainTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C58");
		int num2 = ShortcutExtensions.DOSmoothRewind(title);
		int num3 = ShortcutExtensions.DOSmoothRewind(description);
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)onBoardingBackgroundsAnimation))
		{
			return;
		}
		object obj5 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1592;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v14+E4]");
		object obj8;
		Action<object> action;
		object obj10;
		object obj7;
		if ((nint)0 != 0)
		{
			obj7 = (nint)0 + (nint)2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v14+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				obj10 = obj7;
				goto IL_0190;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			obj10 = (nint)0 + (nint)2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v14+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v6+10]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			obj7 = obj10;
			if (obj11 == null)
			{
				goto IL_0190;
			}
		}
		goto IL_01e7;
		IL_0190:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v12+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)24;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v11+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7 = obj10;
		action = action2;
		goto IL_01e7;
		IL_01e7:
		ArraysExtensions.ForEach(onBoardingBackgroundsAnimation, action);
	}
}
