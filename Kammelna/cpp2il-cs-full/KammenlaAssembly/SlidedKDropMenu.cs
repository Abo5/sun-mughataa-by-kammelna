using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SlidedKDropMenu : KDropMenu
{
	private sealed class <>c__DisplayClass10_0
	{
		public SlidedKDropMenu <>4__this;

		public Action moveBlocker;

		internal void <OnHideMenu>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0096: Expected O, but got I
			//IL_00b9: Expected O, but got I4
			//IL_0058: Expected O, but got I
			//IL_00e7: Expected O, but got I
			//IL_011e: Expected O, but got I
			while (true)
			{
				SlidedKDropMenu slidedKDropMenu = <>4__this;
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (SlidedKDropMenu)+48]");
					if ((UnityEngine.Object)0 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (SlidedKDropMenu)+48]");
					bool flag = (UnityEngine.Object)0 == null;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						break;
					}
				}
				SlidedKDropMenu slidedKDropMenu2 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6 (SlidedKDropMenu)+48]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
				SlidedKDropMenu slidedKDropMenu3 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7 (SlidedKDropMenu)+40]");
				GameObject gameObject2 = ((Component)0).gameObject;
				gameObject2.SetActive(value: false);
				Action action = moveBlocker;
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v94 @ X2_v5 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private Transform dropArrowImage;

	private Image listBackground;

	private AnimationCurve listFadeCurve;

	private float slideListDuration;

	private float rotateArrowDuration;

	protected LayoutElement parentLayoutElement;

	private Tween slideTweanInstance;

	private float lastPrefferedHeight;

	private new void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_001e: Expected O, but got I
		//IL_002e: Expected O, but got I
		while (true)
		{
			((BaseDropMenu<object>)(object)this).Awake();
			LayoutElement layoutElement = parentLayoutElement;
			nint num = (nint)layoutElement;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+358]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+360]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v49 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public override void OnShowMenu()
	{
		//IL_0025: Expected O, but got I
		//IL_0041: Expected I, but got O
		//IL_0087: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_00fa: Expected I, but got O
		object obj5 = default(object);
		while (true)
		{
			int num = ShortcutExtensions.DOKill(dropArrowImage);
			parentLayoutElement.preferredHeight = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlidedKDropMenu)+48]");
			object obj = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ X8_v5+358] (should have been resolved before IL gen)");
			nint num2 = (nint)this;
			SlideListPanel(0f, slideListDuration);
			UIExtensions.SetAlpha(listBackground, 1f);
			Transform transform = base.transform;
			object obj3 = (nint)0 + (nint)2848;
			Vector3 forward = transform.forward;
			float duration = 1f * 1.1274813E+09f;
			float num3 = slideListDuration * 1.1274813E+09f;
			object obj4 = obj5 * 1127481344;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DORotate(dropArrowImage, (Vector3)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v111 @ X8_v8 (Il2CppClass<SlidedKDropMenu>)+1B8] (should have been resolved before IL gen)");
		}
	}

	public override void OnHideMenu(Action moveBlocker)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_017a: Expected F4, but got O
		//IL_017a: Expected O, but got I4
		//IL_00ba: Expected O, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_010c: Expected I, but got O
		//IL_0127: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 312;
		object obj2 = default(object);
		TweenCallback tweenCallback = default(TweenCallback);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = (nint)0 + (nint)2848;
			object obj4 = (nint)0 + (nint)2808;
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 24;
			obj6 = moveBlocker;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = ShortcutExtensions.DOKill(dropArrowImage);
			object obj7 = typeof(UsageHint) + 816;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v6+B8]");
			object obj9 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DORotate(dropArrowImage, (Vector3)0, (float)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(listBackground, 0f, 0.35f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlidedKDropMenu)+48]");
			object obj10 = 0;
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj12 = (nint)0 + (nint)3984;
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X8_v10+358] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			tweenCallback..ctor(obj2, (IntPtr)obj12);
			float num2 = 0f * 1.0227391E+09f;
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v154 @ X8_v13 (Il2CppClass<SlidedKDropMenu>)+208] (should have been resolved before IL gen)");
		}
	}

	private void Update()
	{
		//IL_0010: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_007f: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlidedKDropMenu)+48]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ X8_v2+358] (should have been resolved before IL gen)");
		float num = default(float);
		if (num == lastPrefferedHeight)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SlidedKDropMenu)+48]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v106 @ X8_v3+358] (should have been resolved before IL gen)");
		lastPrefferedHeight = num;
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v98 @ X8_v4 (Il2CppClass<SlidedKDropMenu>)+1A8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void SlideListPanel(float height, float duration = 0.5f, Ease ease = Ease.Linear, TweenCallback onComplete = null)
	{
		//IL_0011: Expected O, but got I
		//IL_0039: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2872;
		float preferredWidth = parentLayoutElement.preferredWidth;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(parentLayoutElement, (Vector2)0, height);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj3 = default(object);
		object obj2 = obj3 + 128;
		obj2 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public SlidedKDropMenu()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num = default(float);
		slideListDuration = num;
		((BaseDropMenu<object>)(object)this)..ctor();
	}
}
