using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using UI.Popups;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class PopupUI : MonoBehaviour
{
	private sealed class <>c__DisplayClass37_0
	{
		public PopupUI <>4__this;

		public Action onComplete;

		internal void <ShrinkToParent>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I4
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Expected O, but got Unknown
			//IL_0139: Expected O, but got I
			//IL_0149: Expected O, but got I
			//IL_0159: Expected O, but got I
			//IL_0169: Expected O, but got I
			//IL_017c: Expected O, but got I4
			PopupUI popupUI = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (popupUI.content == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = popupUI.content == null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					return;
				}
			}
			PopupUI popupUI2 = <>4__this;
			GameObject gameObject = popupUI2.content.gameObject;
			gameObject.SetActive(value: false);
			PopupUI popupUI3 = <>4__this;
			object obj4 = typeof(UsageHint) + 816;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v13+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v14+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v14+14]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v14+C]");
			object obj9 = 0;
			popupUI3.content.localScale = (Vector3)0;
			Action action = onComplete;
			if (onComplete != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X2_v5 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public RectTransform blocker;

	public RectTransform content;

	private BlurOptimized blur;

	private float fadeAlpha;

	public float animationSpeed;

	public float fadeDuration;

	public bool partOfNavigation;

	public bool startHidden;

	public bool enableBlur;

	public bool textureBlur;

	public bool blurOnlyOnce;

	public BlurLayerTexture blurLayer;

	private bool <IsCurrentlyShown>k__BackingField;

	private Action closeAction;

	private Graphic _blockerGraphics;

	private Transform ogParent;

	private float canvasWidth => ScreenUtility.CanvasWidth;

	private float canvasHeight => ScreenUtility.CanvasHeight;

	public bool IsCurrentlyShown
	{
		get
		{
			return <IsCurrentlyShown>k__BackingField;
		}
		set
		{
			<IsCurrentlyShown>k__BackingField = value;
		}
	}

	public virtual void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected I4, but got Unknown
		//IL_01bd: Expected I, but got O
		//IL_03ba: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03cc: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_0341: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7864]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v43+E4]");
			bool flag = (nint)0 == 0;
			obj5 = blocker;
			obj6 = blocker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = blocker;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = blocker;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_0471;
		IL_03e8:
		GameObject gameObject = content.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag7;
		bool flag6 = activeSelf && flag7;
		<IsCurrentlyShown>k__BackingField = flag6;
		GameObject gameObject2 = base.gameObject;
		Transform transform = gameObject2.transform;
		Transform parent = transform.parent;
		object obj8 = this + 112;
		obj8 = parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_034f:
		GameObject gameObject3 = blocker.gameObject;
		bool activeSelf2 = gameObject3.activeSelf;
		object obj10;
		object obj9 = obj10;
		flag7 = activeSelf2;
		goto IL_03e8;
		IL_02e7:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag8 = blocker != null;
			bool flag9 = !flag8;
			obj10 = 0;
			obj9 = 0;
			if (!flag9)
			{
				goto IL_034f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = blocker != null;
			bool flag11 = !flag10;
			object obj12 = !flag11;
			obj10 = 0;
			obj9 = 0;
			if (obj12 != null)
			{
				goto IL_034f;
			}
		}
		flag7 = true;
		goto IL_03e8;
		IL_0091:
		bool flag12 = obj5;
		bool flag13 = !flag12;
		object obj13 = !flag13;
		if (obj13 != null)
		{
			goto IL_0160;
		}
		flag5 = false;
		goto IL_0471;
		IL_0160:
		object obj14 = (nint)0 + (nint)992;
		object obj15 = obj14;
		flag5 = (byte)(this + 104) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj16 = default(object);
		if (obj16 != null)
		{
			Graphic blockerGraphics = _blockerGraphics;
			nint num = (nint)blockerGraphics;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v12 (Il2CppClass<UnityEngine.UI.Graphic>)+2A0]");
			flag5 = false;
			Color color = blockerGraphics.color;
			float num2 = default(float);
			fadeAlpha = num2;
		}
		goto IL_0471;
		IL_02ae:
		GameObject gameObject4 = content.gameObject;
		gameObject4.SetActive(value: false);
		obj15 = 0;
		flag5 = false;
		goto IL_02e7;
		IL_0287:
		GameObject gameObject5 = blocker.gameObject;
		gameObject5.SetActive(value: false);
		goto IL_02ae;
		IL_0471:
		if (startHidden)
		{
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				bool flag14 = blocker != null;
				bool flag15 = !flag14;
				object obj18 = !flag15;
				if (obj18 != null)
				{
					goto IL_0287;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (blocker != null)
				{
					goto IL_0287;
				}
			}
			goto IL_02ae;
		}
		goto IL_02e7;
	}

	public virtual void Show()
	{
		//IL_0016: Expected O, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_017b: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00c6: Expected O, but got I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_0316: Expected O, but got I4
		//IL_0463: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7865]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (!startHidden)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			if (!startHidden)
			{
				goto IL_0052;
			}
		}
		startHidden = false;
		if (!partOfNavigation)
		{
			goto IL_0071;
		}
		goto IL_012e;
		IL_0360:
		GameObject gameObject = blocker.gameObject;
		gameObject.SetActive(value: true);
		object obj3;
		object obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			if (_blockerGraphics != null)
			{
				goto IL_03d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = _blockerGraphics != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_03d9;
			}
		}
		goto IL_03f5;
		IL_028c:
		obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Component component;
		Transform target = component.transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = blocker;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_0360;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)blocker)
			{
				goto IL_0360;
			}
		}
		goto IL_03f5;
		IL_03d9:
		TransitionExtension.FadeIn(_blockerGraphics, fadeAlpha, fadeDuration);
		goto IL_03f5;
		IL_0052:
		if (!partOfNavigation)
		{
			goto IL_0071;
		}
		goto IL_012e;
		IL_012e:
		GameObject popup = content.gameObject;
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, closeAction);
		bool flag6 = !<IsCurrentlyShown>k__BackingField;
		object obj10 = 0;
		object obj11 = 0;
		Action action = closeAction;
		if (flag6)
		{
			goto IL_00a0;
		}
		goto IL_0198;
		IL_00a0:
		component = content;
		bool flag7 = (object)content == null;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_028c;
		IL_03f5:
		GameObject gameObject2 = content.gameObject;
		gameObject2.SetActive(value: true);
		ShowBlur();
		<IsCurrentlyShown>k__BackingField = true;
		return;
		IL_0071:
		bool flag8 = <IsCurrentlyShown>k__BackingField;
		obj11 = obj10;
		IntPtr intPtr = default(IntPtr);
		action = (Action)(nint)intPtr;
		if (!flag8)
		{
			goto IL_00a0;
		}
		goto IL_0198;
		IL_0198:
		object obj13 = typeof(Queue<string>) + 712;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = (nint)0 + (nint)1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Transform parent = content.parent;
		BlurLayersManager blurLayersManager = default(BlurLayersManager);
		if (blurLayersManager.IsOnTopLayer(parent))
		{
			Transform parent2 = content.parent;
			parent2.SetAsLastSibling();
			return;
		}
		HidePopup(hideContentNow: true);
		component = content;
		obj10 = obj11;
		goto IL_028c;
	}

	private void ShowBlur()
	{
		//IL_02b6: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_023b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0264: Expected O, but got I
		//IL_01b4: Expected O, but got I4
		//IL_01dd: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		bool flag = !textureBlur;
		IntPtr intPtr = default(IntPtr);
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		if (!flag)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				bool flag2 = blurLayer != null;
				bool flag3 = !flag2;
				object obj4 = 0;
				obj = null;
				if (!flag3)
				{
					goto IL_007d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = blurLayer != null;
				bool flag5 = !flag4;
				object obj5 = !flag5;
				object obj4 = 0;
				obj = null;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
		}
		object obj6 = typeof(Queue<string>) + 712;
		object obj7 = obj6;
		if (enableBlur)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Transform parent = content.parent;
			BlurLayersManager blurLayersManager = default(BlurLayersManager);
			blurLayersManager.AddBlurLayer(parent, fadeDuration);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj10 = !flag7;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Transform parent2 = content.parent;
			BlurLayersManager blurLayersManager2 = default(BlurLayersManager);
			blurLayersManager2.AppendToLayer(parent2, worldPositionStays: true);
		}
		return;
		IL_007d:
		blurLayer.StartBlur(blurOnlyOnce);
		BlurLayerTexture blurLayerTexture = blurLayer;
		Image image = blurLayerTexture.BlockerTint.image;
		BlurLayerTexture blurLayerTexture2 = blurLayer;
		TransitionExtension.FadeIn(image, blurLayerTexture2.<BlockerTintAlpha>k__BackingField, fadeDuration);
		BlurLayerTexture blurLayerTexture3 = blurLayer;
		TransitionExtension.FadeIn(blurLayerTexture3.BlurTexture, blurLayerTexture3.<BlurTextureAlpha>k__BackingField, fadeDuration);
	}

	public void ShowBlurOnly()
	{
		//IL_0231: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I4
		//IL_01dd: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		bool flag = !textureBlur;
		IntPtr intPtr = default(IntPtr);
		UnityEngine.Object obj = (UnityEngine.Object)(nint)intPtr;
		if (!flag)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				bool flag2 = blurLayer != null;
				bool flag3 = !flag2;
				object obj4 = 0;
				obj = null;
				if (!flag3)
				{
					goto IL_007d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = blurLayer != null;
				bool flag5 = !flag4;
				object obj5 = !flag5;
				object obj4 = 0;
				obj = null;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
		}
		if (enableBlur)
		{
			object obj6 = typeof(Queue<string>) + 712;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Transform parent = content.parent;
			BlurLayersManager blurLayersManager = default(BlurLayersManager);
			blurLayersManager.ShowBlur(parent, fadeDuration);
		}
		return;
		IL_007d:
		blurLayer.StartBlur(blurOnlyOnce);
		BlurLayerTexture blurLayerTexture = blurLayer;
		Image image = blurLayerTexture.BlockerTint.image;
		BlurLayerTexture blurLayerTexture2 = blurLayer;
		TransitionExtension.FadeIn(image, blurLayerTexture2.<BlockerTintAlpha>k__BackingField, fadeDuration);
		BlurLayerTexture blurLayerTexture3 = blurLayer;
		TransitionExtension.FadeIn(blurLayerTexture3.BlurTexture, blurLayerTexture3.<BlurTextureAlpha>k__BackingField, fadeDuration);
	}

	public virtual void HidePopup()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<PopupUI>)+1A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public virtual void HidePopup(bool hideContentNow)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_010e: Expected I4, but got O
		//IL_017f: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		if (!<IsCurrentlyShown>k__BackingField)
		{
			return;
		}
		Transform target = content.transform;
		int num = ShortcutExtensions.DOKill(target);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v8+E4]");
		UnityEngine.Object obj5;
		if ((nint)0 != 0)
		{
			bool flag = blocker != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			object obj4 = 0;
			obj5 = null;
			if (obj3 != null)
			{
				goto IL_00fb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = blocker != null;
			bool flag4 = !flag3;
			object obj4 = 0;
			obj5 = null;
			if (!flag4)
			{
				goto IL_00fb;
			}
		}
		goto IL_01b4;
		IL_00fb:
		bool flag5 = !hideContentNow;
		bool flag6 = (byte)(int)obj5 != 0;
		if (!flag5)
		{
			GameObject gameObject = blocker.gameObject;
			gameObject.SetActive(value: false);
			object obj4 = 0;
			flag6 = false;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj7 = !flag7;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if ((bool)_blockerGraphics)
		{
			TransitionExtension.FadeOut(_blockerGraphics, fadeDuration);
		}
		goto IL_01b4;
		IL_01b4:
		if (hideContentNow)
		{
			GameObject gameObject2 = content.gameObject;
			gameObject2.SetActive(value: false);
		}
		HideBlur();
		<IsCurrentlyShown>k__BackingField = false;
	}

	private void HideBlur(bool hideOnly = false)
	{
		//IL_02a6: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_011b: Expected I, but got O
		//IL_0067: Expected I, but got O
		//IL_0253: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		bool flag = !textureBlur;
		UnityEngine.Object obj = (UnityEngine.Object)hideOnly;
		if (!flag)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				bool flag2 = blurLayer != null;
				bool flag3 = !flag2;
				nint num = unchecked((nint)null);
				obj = null;
				if (!flag3)
				{
					goto IL_007a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = blurLayer != null;
				bool flag5 = !flag4;
				object obj4 = !flag5;
				nint num = unchecked((nint)null);
				obj = null;
				if (obj4 != null)
				{
					goto IL_007a;
				}
			}
		}
		if (!enableBlur)
		{
			return;
		}
		object obj5 = typeof(Queue<string>) + 712;
		object obj6 = obj5;
		if (hideOnly)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
			bool flag6 = (nint)0 == 0;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Transform parent = content.parent;
			BlurLayersManager blurLayersManager = default(BlurLayersManager);
			blurLayersManager.HideBlur(parent, fadeDuration);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v5+E4]");
			bool flag7 = (nint)0 == 0;
			object obj9 = !flag7;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Transform parent2 = content.parent;
			BlurLayersManager blurLayersManager2 = default(BlurLayersManager);
			blurLayersManager2.RemoveBlurLayer(parent2, fadeDuration);
		}
		return;
		IL_007a:
		blurLayer.EndBlurNow();
		BlurLayerTexture blurLayerTexture = blurLayer;
		Image image = blurLayerTexture.BlockerTint.image;
		TransitionExtension.FadeOut(image, fadeDuration);
		BlurLayerTexture blurLayerTexture2 = blurLayer;
		TransitionExtension.FadeOut(blurLayerTexture2.BlurTexture, fadeDuration);
	}

	public void HideBlurOnly()
	{
		HideBlur(hideOnly: true);
	}

	public void PopFromCenter()
	{
		PopFromCenter(1f);
	}

	public void PopFromCenter(float finalScaleVal)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008d: Expected I, but got O
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_004c: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		object obj4 = (nint)0 + (nint)2904;
		content.localScale = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(content, finalScaleVal, animationSpeed);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void PopFromCustomParent(Transform parent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00c1: Expected I, but got O
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_007b: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		content.localScale = (Vector3)0;
		Transform transform = base.transform;
		Vector3 position = parent.position;
		object obj4 = (nint)0 + (nint)2904;
		transform.position = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(content, 1f, animationSpeed);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void PopFromParent()
	{
		PopFromParent(1f);
	}

	public void PopFromParent(float finalScaleVal)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00be: Expected I, but got O
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_007d: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		content.localScale = (Vector3)0;
		Transform transform = base.transform;
		Vector3 position = ogParent.position;
		object obj4 = (nint)0 + (nint)2904;
		transform.position = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(content, finalScaleVal, animationSpeed);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void ShrinkToParent()
	{
		ShrinkToParent(null);
	}

	public void ShrinkToParent(Action onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00f6: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2904;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)1312;
		object obj6 = (nint)0 + (nint)2504;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		HidePopup(hideContentNow: false);
		float duration = animationSpeed * 0.5f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(content, 0f, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void ToggleFromParent(float finalScaleVal = 1f)
	{
		if (<IsCurrentlyShown>k__BackingField)
		{
			ShrinkToParent(null);
		}
		else
		{
			PopFromCenter(finalScaleVal);
		}
	}

	public void SlideFromRight()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006b: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		float speed = ScreenUtility.CanvasWidth;
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)obj2, speed, (Action)null);
	}

	public void SlideFromLeft()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0074: Expected I, but got O
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		float num = ScreenUtility.CanvasWidth;
		float speed = 0f - num;
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)obj2, speed, (Action)null);
	}

	public void SlideFromTop()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006c: Expected I, but got O
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		float num = ScreenUtility.CanvasHeight;
		TransitionExtension.DoTweenSlide(content, (Vector2)0, (Vector2)obj2, 0f, (Action)null);
	}

	public void SlideFromBottom()
	{
		SlideFromBottom(null);
	}

	public void SlideFromBottom(Action onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006b: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 96;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
		float num = ScreenUtility.CanvasHeight;
		TransitionExtension.DoTweenSlide(content, (Vector2)onComplete, (Vector2)obj2, 0f, (Action)null);
	}

	public void SlideToRight()
	{
		//IL_0005: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_003e: Expected O, but got I4
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasWidth;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public void SlideToRight(Action onComplete)
	{
		//IL_0005: Expected I, but got O
		//IL_003d: Expected O, but got I
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasWidth;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)onComplete, (Vector2)0, 0f, onFinish);
	}

	public void SlideToLeft()
	{
		//IL_0005: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_003e: Expected O, but got I4
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasWidth;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public void SlideToTop()
	{
		//IL_0005: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_003e: Expected O, but got I4
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasHeight;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public void SlideToBottom()
	{
		//IL_0005: Expected I, but got O
		//IL_003e: Expected O, but got I
		//IL_003e: Expected O, but got I4
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasHeight;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)0, (Vector2)0, 0f, onFinish);
	}

	public void SlideToBottom(Action onComplete)
	{
		//IL_0005: Expected I, but got O
		//IL_003d: Expected O, but got I
		nint num = (nint)this;
		HidePopup(hideContentNow: false);
		float num2 = ScreenUtility.CanvasHeight;
		RectTransform target = content;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v1 (Il2CppClass<PopupUI>)+1B0]");
		Action onFinish = default(Action);
		TransitionExtension.DoTweenSlide(target, (Vector2)onComplete, (Vector2)0, 0f, onFinish);
	}

	public PopupUI()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num = default(float);
		animationSpeed = num;
		enableBlur = true;
		base..ctor();
	}
}
