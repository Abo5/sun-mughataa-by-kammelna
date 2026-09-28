using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Spine;
using UI.Popups;
using UnityEngine;
using Util.Extensions;

public class SlideAnimationHelper : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<RectTransform> <>9__33_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShowImmediate>b__33_0(RectTransform rt)
		{
			//IL_002b: Expected O, but got I4
			float? y = 0f;
			UIExtensions.MoveTo(rt, isWorldPositions: false, (float?)(object)0, y);
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public SlideAnimationHelper <>4__this;

		public Action onComplete;

		internal void <SlideOut>b__0()
		{
			//IL_002e: Expected O, but got I4
			SlideAnimationHelper slideAnimationHelper = <>4__this;
			bool flag = !slideAnimationHelper.<IsShown>k__BackingField;
			object obj = !flag;
			if (obj == null)
			{
				ComponentListsExtensions.SetActive(slideAnimationHelper.slideUpObjects, active: false);
				ComponentListsExtensions.SetActive(slideAnimationHelper.slideDownObjects, active: false);
			}
			Action action = onComplete;
			if (onComplete != null)
			{
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v45 @ X2_v2 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public float upDistance;

		public float downDistance;

		internal void <HideImmediate>b__0(RectTransform rt)
		{
			//IL_002c: Expected O, but got I4
			float? y = upDistance;
			UIExtensions.MoveTo(rt, isWorldPositions: false, (float?)(object)0, y);
		}

		internal void <HideImmediate>b__1(RectTransform rt)
		{
			//IL_002c: Expected O, but got I4
			float? y = downDistance;
			UIExtensions.MoveTo(rt, isWorldPositions: false, (float?)(object)0, y);
		}
	}

	private bool startHidden;

	private float duration = 0.4f;

	private bool partOfNavigation;

	private bool useObjectSize;

	private float slideUpDistance;

	private float slideDownDistance;

	private RectTransform popupParent;

	private RectTransform[] slideUpObjects;

	private RectTransform[] slideDownObjects;

	private bool <IsShown>k__BackingField;

	public float Duration
	{
		get
		{
			return duration;
		}
		set
		{
			duration = value;
		}
	}

	public float SlideUpDistance
	{
		get
		{
			return slideUpDistance;
		}
		set
		{
			slideUpDistance = value;
		}
	}

	public float SlideDownDistance
	{
		get
		{
			return slideDownDistance;
		}
		set
		{
			slideDownDistance = value;
		}
	}

	public bool IsShown
	{
		get
		{
			return <IsShown>k__BackingField;
		}
		private set
		{
			<IsShown>k__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !<IsShown>k__BackingField;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = (byte)((startHidden ? 1u : 0u) ^ 1u) != 0;
			<IsShown>k__BackingField = flag2;
			if (startHidden)
			{
				HideImmediate();
				ComponentListsExtensions.SetActive(slideUpObjects, active: false);
				ComponentListsExtensions.SetActive(slideDownObjects, active: false);
			}
		}
	}

	private void Init()
	{
		//IL_001c: Expected O, but got I4
		bool flag = !<IsShown>k__BackingField;
		object obj = !flag;
		if (obj == null)
		{
			bool flag2 = (byte)((startHidden ? 1u : 0u) ^ 1u) != 0;
			<IsShown>k__BackingField = flag2;
			if (startHidden)
			{
				HideImmediate();
				ComponentListsExtensions.SetActive(slideUpObjects, active: false);
				ComponentListsExtensions.SetActive(slideDownObjects, active: false);
			}
		}
	}

	public void ToggleSlide()
	{
		if (<IsShown>k__BackingField)
		{
			SlideOut(null);
		}
		else
		{
			SlideIn(null);
		}
	}

	public GameObject GetContentObject()
	{
		//IL_0084: Expected O, but got I4
		object obj = Enumerable.FirstOrDefault((IEnumerable<object>)slideUpObjects);
		bool flag = obj == null;
		object obj2 = !flag;
		Component component = (Component)obj;
		if (obj2 == null)
		{
			object obj3 = Enumerable.First((IEnumerable<object>)slideDownObjects);
			bool flag2 = obj3 == null;
			component = (Component)obj3;
			if (flag2)
			{
				return (GameObject)(object)new NullReferenceException();
			}
		}
		return component.gameObject;
	}

	public void SlideIn(Action onComplete)
	{
		//IL_012b: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0173: Expected O, but got I4
		//IL_0064: Expected O, but got I
		//IL_0072: Expected I, but got O
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_034e: Expected O, but got I
		//IL_037d: Expected O, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_019f: Expected F4, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_03dd: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0227: Expected F4, but got I4
		<IsShown>k__BackingField = true;
		if (partOfNavigation)
		{
			object obj = Enumerable.FirstOrDefault((IEnumerable<object>)slideUpObjects);
			bool flag = obj == null;
			object obj2 = !flag;
			Component component = (Component)obj;
			if (obj2 == null)
			{
				object obj3 = Enumerable.First((IEnumerable<object>)slideDownObjects);
				component = (Component)obj3;
			}
			GameObject popup = component.gameObject;
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)888;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj5);
			object obj6 = typeof(RegisteredWaitHandle) + 3136;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PushPopup(popup, action);
		}
		MoveObjectsToFreeLayer();
		ComponentListsExtensions.SetActive(slideUpObjects, active: true);
		ComponentListsExtensions.SetActive(slideDownObjects, active: true);
		RectTransform[] array = slideUpObjects;
		object obj9 = (nint)0 + (nint)2872;
		bool flag3 = array.Length < 1;
		object obj10 = 0;
		bool flag4 = true;
		if (!flag3)
		{
			object obj11 = array + 32;
			object obj12 = 0;
			bool flag5;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X25_v7+v228 @ X24_v10*8]");
				int num = ShortcutExtensions.DOKill((Component)0);
				float num2 = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X25_v7+v228 @ X24_v10*8]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY((RectTransform)0, 0f, duration);
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				obj12++;
				flag5 = (nint)obj12 < array.Length;
				float num3 = 0f;
				flag4 = true;
			}
			while (flag5);
		}
		RectTransform[] array2 = slideDownObjects;
		if (array2.Length >= 1)
		{
			object obj13 = array2 + 32;
			object obj14 = 0;
			bool flag6;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X25_v6+v363 @ X24_v7*8]");
				int num4 = ShortcutExtensions.DOKill((Component)0);
				float num2 = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X25_v6+v363 @ X24_v7*8]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY((RectTransform)0, 0f, duration);
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				obj14++;
				flag6 = (nint)obj14 < array2.Length;
				float num3 = 0f;
				flag4 = true;
			}
			while (flag6);
		}
		if (onComplete != null)
		{
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj17 = !flag7;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(duration, onComplete);
		}
	}

	public void SlideOut(Action onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0098: Expected I4, but got O
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_0165: Expected I, but got O
		//IL_01f3: Expected O, but got I
		//IL_0221: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0248: Expected I, but got O
		//IL_0194: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0145: Expected O, but got I4
		//IL_0275: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02ca: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsShown>k__BackingField = false;
		float endValue = GetSlideUpDistance();
		RectTransform[] array = slideUpObjects;
		bool flag = array.Length < 1;
		bool flag2 = (byte)(int)onComplete != 0;
		if (!flag)
		{
			object obj5 = array + 32;
			object obj6 = 0;
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X24_v5+v237 @ X23_v7*8]");
				int num = ShortcutExtensions.DOKill((Component)0);
				float num2 = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X24_v5+v237 @ X23_v7*8]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY((RectTransform)0, endValue, duration);
				obj6++;
				flag3 = (nint)obj6 < array.Length;
				nint num3 = unchecked((nint)null);
				flag2 = false;
			}
			while (flag3);
		}
		float endValue2 = GetSlideDownDistance();
		RectTransform[] array2 = slideDownObjects;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3856;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		if (array2.Length >= 1)
		{
			object obj10 = array2 + 32;
			object obj11 = 0;
			bool flag4;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X27_v3+v309 @ X26_v4*8]");
				int num4 = ShortcutExtensions.DOKill((Component)0);
				float num2 = duration;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X27_v3+v309 @ X26_v4*8]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY((RectTransform)0, endValue2, duration);
				obj11++;
				flag4 = (nint)obj11 < array2.Length;
				nint num3 = unchecked((nint)null);
				flag2 = false;
			}
			while (flag4);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(duration, action);
	}

	private void MoveObjectsToFreeLayer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6377]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = popupParent;
			obj6 = popupParent;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = popupParent;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = popupParent;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_00c6:
		object obj11 = typeof(Queue<string>) + 712;
		object obj12 = (nint)0 + (nint)1944;
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		BlurLayersManager blurLayersManager = default(BlurLayersManager);
		blurLayersManager.AppendToLayer(popupParent);
		return;
		IL_0091:
		bool flag6 = obj5 != null;
		bool flag7 = !flag6;
		obj9 = 0;
		obj10 = null;
		if (!flag7)
		{
			goto IL_00c6;
		}
	}

	public void SlideIn()
	{
		SlideIn(null);
	}

	public void SlideOut()
	{
		SlideOut(null);
	}

	private float GetSlideUpDistance()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_00c2: Expected F4, but got I4
		//IL_00cb: Expected F4, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0075: Expected F4, but got I4
		//IL_007e: Expected F4, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0130: Expected I, but got O
		//IL_0141: Expected O, but got I
		object obj = (nint)0 + (nint)2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6378]");
		object obj2 = (nint)0 & (nint)1;
		float result;
		if (obj2 != null)
		{
			object obj3 = obj;
			bool flag = Enumerable.Any((IEnumerable<object>)slideUpObjects);
			bool flag2 = !flag;
			object obj4 = !flag2;
			result = 0f;
			float num = 0f;
			if (obj4 == null)
			{
				goto IL_008c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			bool flag3 = Enumerable.Any((IEnumerable<object>)slideUpObjects);
			bool flag4 = !flag3;
			result = 0f;
			float num = 0f;
			if (flag4)
			{
				goto IL_008c;
			}
		}
		float num2;
		if (useObjectSize)
		{
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1984;
			Func<object, float> func = default(Func<object, float>);
			func..ctor((object)null, (IntPtr)obj6);
			object obj7 = (nint)0 + (nint)1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAB10");
			float num3 = default(float);
			num2 = num3;
		}
		else
		{
			num2 = slideUpDistance;
		}
		float topCutoutSize = ScreenUtility.TopCutoutSize;
		return num2 + topCutoutSize;
		IL_008c:
		return result;
	}

	private float GetSlideDownDistance()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_00c2: Expected F4, but got I4
		//IL_00cb: Expected F4, but got I4
		//IL_006c: Expected O, but got I4
		//IL_0075: Expected F4, but got I4
		//IL_007e: Expected F4, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0130: Expected I, but got O
		//IL_0141: Expected O, but got I
		object obj = (nint)0 + (nint)2352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6379]");
		object obj2 = (nint)0 & (nint)1;
		float result;
		if (obj2 != null)
		{
			object obj3 = obj;
			bool flag = Enumerable.Any((IEnumerable<object>)slideDownObjects);
			bool flag2 = !flag;
			object obj4 = !flag2;
			result = 0f;
			float num = 0f;
			if (obj4 == null)
			{
				goto IL_008c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			bool flag3 = Enumerable.Any((IEnumerable<object>)slideDownObjects);
			bool flag4 = !flag3;
			result = 0f;
			float num = 0f;
			if (flag4)
			{
				goto IL_008c;
			}
		}
		float num2;
		if (useObjectSize)
		{
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1976;
			Func<object, float> func = default(Func<object, float>);
			func..ctor((object)null, (IntPtr)obj6);
			object obj7 = (nint)0 + (nint)1888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAB10");
			float num3 = default(float);
			num2 = num3;
		}
		else
		{
			num2 = slideDownDistance;
		}
		float bottomCutoutSize = ScreenUtility.BottomCutoutSize;
		float num4 = num2 + bottomCutoutSize;
		return 0f - num4;
		IL_008c:
		return result;
	}

	public void ShowImmediate()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0073: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I
		//IL_01e6: Expected I, but got O
		//IL_0204: Expected O, but got I
		//IL_0156: Expected O, but got I
		object obj = (nint)0 + (nint)3032;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 200;
		IEnumerable<object> enumeration = Enumerable.Union((IEnumerable<object>)slideUpObjects, (IEnumerable<object>)slideDownObjects);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v7+E4]");
		object obj5;
		Action<object> action;
		object obj7;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v7+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				goto IL_0104;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v7+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			if (obj8 == null)
			{
				goto IL_0104;
			}
		}
		goto IL_015b;
		IL_0104:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v12+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3848;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		action = action2;
		goto IL_015b;
		IL_015b:
		ArraysExtensions.ForEach(enumeration, action);
	}

	public void HideImmediate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0085: Expected I, but got O
		//IL_00b4: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		float num = GetSlideUpDistance();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3256;
		object obj4 = (nint)0 + (nint)3864;
		object obj5 = (nint)0 + (nint)2304;
		object obj6 = (nint)0 + (nint)3872;
		float num2 = GetSlideDownDistance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		ArraysExtensions.ForEach(slideUpObjects, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj6);
		ArraysExtensions.ForEach(slideDownObjects, action2);
	}

	public void EnableAll()
	{
		ComponentListsExtensions.SetActive(slideUpObjects, active: true);
		ComponentListsExtensions.SetActive(slideDownObjects, active: true);
	}

	public void DisableAll()
	{
		ComponentListsExtensions.SetActive(slideUpObjects, active: false);
		ComponentListsExtensions.SetActive(slideDownObjects, active: false);
	}

	private void SetActive(bool active)
	{
		ComponentListsExtensions.SetActive(slideUpObjects, active);
		ComponentListsExtensions.SetActive(slideDownObjects, active);
	}

	private static string ValidateInput(RectTransform rectTransform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0150: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E637C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = rectTransform == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			goto IL_0127;
		}
		goto IL_01ba;
		IL_01ba:
		return "LAK" + 3520;
		IL_01d0:
		return (string)(object)new NullReferenceException();
		IL_0127:
		if ((object)rectTransform != null)
		{
			object obj6 = (nint)0 + (nint)1088;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
			object obj7 = default(object);
			if (obj7 != null)
			{
				ScreenCutoutFixer screenCutoutFixer = default(ScreenCutoutFixer);
				if ((object)screenCutoutFixer == null)
				{
					goto IL_01d0;
				}
				if (screenCutoutFixer.WillChangePosition())
				{
					goto IL_01ba;
				}
			}
			return null;
		}
		goto IL_01d0;
		IL_0074:
		if (!(rectTransform == null))
		{
			goto IL_0127;
		}
		goto IL_01ba;
	}
}
