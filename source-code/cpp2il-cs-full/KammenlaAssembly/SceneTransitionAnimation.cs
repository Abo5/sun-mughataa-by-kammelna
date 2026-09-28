using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class SceneTransitionAnimation : MonoBehaviour
{
	private SlideAnimationHelper slider;

	private CanvasGroup[] backgrounds;

	private bool manualTransition;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
		object obj2 = (nint)0 + (nint)896;
		slider.HideImmediate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(backgrounds, action);
		if (SplashAnimation.IsDone && !manualTransition)
		{
			TransitionIn();
		}
	}

	public void TransitionIn(bool withSlider = true)
	{
		//IL_01e7: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019e: Expected O, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_0077: Expected O, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_00d5: Expected I, but got O
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		bool isDone = SplashAnimation.IsDone;
		bool flag = !isDone;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		bool flag2 = default(bool);
		object obj = flag2;
		if (!flag)
		{
			if (flag2)
			{
				slider.SlideIn();
			}
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)880;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			object obj4 = (nint)0 + (nint)2080;
			ArraysExtensions.ForEach(backgrounds, action);
			SlideAnimationHelper slideAnimationHelper = slider;
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1880;
			num = (nint)obj6;
			Action action2 = default(Action);
			action2..ctor(null, (IntPtr)obj6);
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSecondsPermanently(slideAnimationHelper.duration, action2);
			manualTransition = false;
			obj = null;
		}
		if (ScreenUtility.IsTablet)
		{
			object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(this);
		}
	}

	public void TransitionOut(Action callback = null)
	{
		//IL_0021: Expected O, but got I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_00c1: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		if (SplashAnimation.IsDone)
		{
			bool flag = !manualTransition;
			object obj = !flag;
			if (obj == null)
			{
				SlideAnimationHelper slideAnimationHelper = slider;
				if (slideAnimationHelper.<IsShown>k__BackingField)
				{
					SplashAnimation.StartLoading();
					slider.SlideOut();
					object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1360;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj3 = (nint)0 + (nint)888;
					Action<object> action = default(Action<object>);
					action..ctor((object)this, (IntPtr)obj3);
					object obj4 = (nint)0 + (nint)2080;
					ArraysExtensions.ForEach(backgrounds, action);
					SlideAnimationHelper slideAnimationHelper2 = slider;
					object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v10+E4]");
					if ((nint)0 != 0)
					{
						Coroutine coroutine = CoroutineDummy.WaitForSecondsPermanently(slideAnimationHelper2.duration, callback);
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Coroutine coroutine2 = CoroutineDummy.WaitForSecondsPermanently(slideAnimationHelper2.duration, callback);
					return;
				}
			}
		}
		if (callback != null)
		{
			IntPtr invoke_impl = ((Delegate)callback).invoke_impl;
			IntPtr method_code = ((Delegate)callback).method_code;
			IntPtr method = ((Delegate)callback).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v95 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void Hide(CanvasGroup canvas)
	{
		canvas.alpha = 0f;
		canvas.interactable = false;
	}

	private void FadeIn(CanvasGroup canvas)
	{
		//IL_002e: Expected O, but got I
		canvas.interactable = true;
		SlideAnimationHelper slideAnimationHelper = slider;
		object obj = (nint)0 + (nint)2752;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvas, 1f, slideAnimationHelper.duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void FadeOut(CanvasGroup canvas)
	{
		canvas.interactable = false;
		SlideAnimationHelper slideAnimationHelper = slider;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvas, 0f, slideAnimationHelper.duration);
	}
}
