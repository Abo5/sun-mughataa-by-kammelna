using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public abstract class BaseUserFeedItemUI : MonoBehaviour
{
	protected Button button;

	protected TextMeshProUGUI titleText;

	protected TextMeshProUGUI detailText;

	protected DateTimeText sinceText;

	protected UserFeedItemIconManager iconManager;

	protected ElegantLoadingIndicator iconLoading;

	protected CanvasGroup alphaGroup;

	protected RectTransform container;

	protected LayoutElement spacer;

	protected UserFeedEventsChannel eventsChannel;

	private ScrollRect _parentScroller;

	private LayoutElement _containerLayout;

	protected IEnumerable<UserFeedItem> _feedItems;

	private bool _ignoreSwipe;

	public IEnumerable<UserFeedItem> FeedItems => _feedItems;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_001d: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0081: Expected I, but got O
		//IL_00b1: Expected O, but got I
		object obj = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj2 = this + 112;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj5 = this + 120;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v6-58]");
		object obj7 = 0;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v7 (Il2CppClass<BaseUserFeedItemUI>)+180]");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private void OnEnable()
	{
		//IL_0033: Expected I, but got O
		//IL_0043: Expected O, but got I
		//IL_0053: Expected O, but got I
		if (_feedItems != null && Enumerable.Any((IEnumerable<object>)_feedItems))
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<BaseUserFeedItemUI>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6 (Il2CppClass<BaseUserFeedItemUI>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void Populate(IEnumerable<UserFeedItem> feedItems)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		object obj = this + 128;
		IEnumerable<UserFeedItem> enumerable = default(IEnumerable<UserFeedItem>);
		obj = enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object feedItem = Enumerable.First((IEnumerable<object>)obj);
		Populate((UserFeedItem)feedItem);
	}

	protected abstract void ShowPreview();

	protected abstract void UpdateSeenStatus();

	protected abstract void OnDismissFeed();

	protected virtual void OnPopulated()
	{
	}

	private void Populate(UserFeedItem feedItem)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00a0: Expected I, but got O
		//IL_00fd: Expected I, but got O
		//IL_010d: Expected O, but got I
		//IL_011d: Expected O, but got I
		LocalizableText title = feedItem.GetTitle();
		TextMeshProExtensions.Localize(titleText, title);
		LocalizableText details = feedItem.GetDetails();
		TextMeshProExtensions.Localize(detailText, details);
		sinceText.SetDate(feedItem.<DateCreated>k__BackingField);
		object obj = typeof(SqlSingle[]) + 2376;
		iconLoading.StartLoading();
		object obj2 = iconLoading;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4 (Il2CppClass<System.Object>)+190]");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)0);
		iconManager.Populate(feedItem, action);
		bool hasPreview = feedItem.HasPreview;
		button.interactable = hasPreview;
		UpdateSeenStatus();
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<BaseUserFeedItemUI>)+1A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<BaseUserFeedItemUI>)+1B0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v8 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void OnSwiping(SwipeGesture swipe)
	{
		//IL_0428: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_003e: Invalid comparison between F4 and I4
		//IL_010d: Expected O, but got I4
		//IL_0143: Expected I, but got O
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_033d: Invalid comparison between F4 and I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_027d: Invalid comparison between F4 and I4
		//IL_0595: Expected O, but got I
		//IL_05d1: Invalid comparison between F4 and I4
		//IL_05e0: Invalid comparison between F4 and I4
		//IL_05f3: Expected O, but got F8
		//IL_0600: Expected O, but got F4
		//IL_0635: Expected O, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_02a2: Invalid comparison between F4 and I4
		//IL_037b: Invalid comparison between F4 and I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0477: Expected O, but got I
		//IL_04b3: Invalid comparison between F4 and I4
		//IL_04c2: Invalid comparison between F4 and I4
		//IL_04d5: Expected O, but got F8
		//IL_04e2: Expected O, but got F4
		//IL_0517: Expected O, but got I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		bool flag = !_ignoreSwipe;
		object obj = !flag;
		if (obj == null && (!DirectionExtensions.IsVertical(swipe.CardinalDirection) || !(swipe.TravelDistance < 1.128792E+09f)))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (DOTween.IsTweening(container))
				{
					goto IL_00c2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = DOTween.IsTweening(container);
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00c2;
				}
			}
			_containerLayout.enabled = true;
			LayoutElement containerLayout = _containerLayout;
			nint num = (nint)containerLayout;
			containerLayout.ignoreLayout = true;
			Rect rect = container.rect;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float preferredHeight = default(float);
			spacer.preferredHeight = preferredHeight;
			_parentScroller.enabled = false;
			object obj8 = swipe.EndPosition - swipe.StartPosition;
			float scaleFactor = ScreenUtility.ScaleFactor;
			float value = (float)obj8 * scaleFactor;
			UIExtensions.MoveTo(x: value, gObject: container, isWorldPositions: false, y: (float?)(object)0);
			if (DirectionExtensions.IsHorizontal(swipe.CardinalDirection) && swipe.SwipeSameness > 1.06032006E+09f && swipe.TravelDistance > 1.128792E+09f)
			{
				float alpha = alphaGroup.alpha;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v40+B8]");
				object obj11 = 0;
				float num2 = alpha * 897988540f;
				double num3 = (double)obj11 * 8.0;
				float num4 = num2 - (float)num3;
				bool flag5 = num4 < 0f;
				bool flag6 = num4 == 0f;
				object obj12 = (double)num2 ^ num3;
				object obj13 = num2 ^ num4;
				object obj14 = obj12 & obj13;
				bool flag7 = (nint)obj14 < 0;
				bool flag8 = flag5 == flag7;
				object obj15 = !flag6;
				object obj16 = flag8 & obj15;
				object obj17 = ~obj16;
				double num5 = ((obj17 != null) ? num3 : ((double)num2));
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				if (1.0 < num5)
				{
					int num6 = ShortcutExtensions.DOKill(alphaGroup);
					TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(alphaGroup, 0.5f, 0.2f);
				}
			}
			bool flag9 = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
			if (!(swipe.TravelDistance > 1.128792E+09f) || !flag9 || !(swipe.SwipeSameness > 1.06032006E+09f))
			{
				float alpha2 = alphaGroup.alpha;
				object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v23+B8]");
				object obj20 = 0;
				float num7 = alpha2 * 897988540f;
				double num8 = (double)obj20 * 8.0;
				float num9 = num7 - (float)num8;
				bool flag10 = num9 < 0f;
				bool flag11 = num9 == 0f;
				object obj21 = (double)num7 ^ num8;
				object obj22 = num7 ^ num9;
				object obj23 = obj21 & obj22;
				bool flag12 = (nint)obj23 < 0;
				bool flag13 = flag10 == flag12;
				object obj24 = !flag11;
				object obj25 = flag13 & obj24;
				object obj26 = ~obj25;
				double num10 = ((obj26 != null) ? num8 : ((double)num7));
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				if (!(1.0 < num10))
				{
					int num11 = ShortcutExtensions.DOKill(alphaGroup);
					TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(alphaGroup, 1f, 0.2f);
				}
			}
			return;
		}
		goto IL_00c2;
		IL_00c2:
		_ignoreSwipe = true;
		CancelSwipe();
	}

	public void OnSwiped(SwipeGesture swipe)
	{
		//IL_0051: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0086: Invalid comparison between F4 and I4
		//IL_0095: Invalid comparison between F4 and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c0: Expected O, but got F4
		//IL_026b: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_011f: Invalid comparison between F4 and I4
		//IL_012e: Invalid comparison between F4 and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0159: Expected O, but got F4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I
		//IL_02ef: Invalid comparison between F4 and I4
		//IL_02fe: Invalid comparison between F4 and I4
		//IL_0311: Expected O, but got F8
		//IL_031e: Expected O, but got F4
		//IL_0353: Expected O, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		_ignoreSwipe = false;
		_parentScroller.enabled = true;
		bool flag = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		bool flag3;
		bool flag4;
		bool flag5;
		if (obj2 == null)
		{
			float num = swipe.SwipeSameness - 1.06032006E+09f;
			flag3 = num < 0f;
			flag4 = num == 0f;
			object obj3 = swipe.SwipeSameness ^ 0x3F333333;
			object obj4 = swipe.SwipeSameness ^ num;
			object obj5 = obj3 & obj4;
			flag5 = (nint)obj5 < 0;
		}
		else
		{
			flag5 = false;
			flag4 = true;
			flag3 = false;
		}
		bool flag6 = flag3 == flag5;
		object obj6 = !flag4;
		object obj7 = flag6 & obj6;
		object obj8 = ~obj7;
		bool flag7;
		bool flag8;
		bool flag9;
		if (obj8 == null)
		{
			float num2 = swipe.TravelDistance - 1.128792E+09f;
			flag7 = num2 < 0f;
			flag8 = num2 == 0f;
			object obj9 = swipe.TravelDistance ^ 0x43480000;
			object obj10 = swipe.TravelDistance ^ num2;
			object obj11 = obj9 & obj10;
			flag9 = (nint)obj11 < 0;
		}
		else
		{
			flag9 = false;
			flag8 = true;
			flag7 = false;
		}
		bool flag10 = flag7 == flag9;
		object obj12 = !flag10;
		object obj13 = obj12 | flag8;
		if (obj13 == null)
		{
			float alpha = alphaGroup.alpha;
			object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8+B8]");
			object obj16 = 0;
			float num3 = alpha * 897988540f;
			double num4 = (double)obj16 * 8.0;
			float num5 = num3 - (float)num4;
			bool flag11 = num5 < 0f;
			bool flag12 = num5 == 0f;
			object obj17 = (double)num3 ^ num4;
			object obj18 = num3 ^ num5;
			object obj19 = obj17 & obj18;
			bool flag13 = (nint)obj19 < 0;
			bool flag14 = flag11 == flag13;
			object obj20 = !flag12;
			object obj21 = flag14 & obj20;
			object obj22 = ~obj21;
			double num6 = ((obj22 != null) ? num4 : ((double)num3));
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			if (!(1.0 < num6))
			{
				object obj23 = swipe.CardinalDirection - 1;
				bool toRight = obj23 == null;
				DismissUserFeed(toRight);
				return;
			}
		}
		CancelSwipe();
	}

	private static bool WillDismiss(SwipeGesture swipe)
	{
		//IL_0039: Invalid comparison between F4 and I4
		//IL_006e: Invalid comparison between F4 and I4
		//IL_007d: Invalid comparison between F4 and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a8: Expected O, but got F4
		//IL_00dd: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected I4, but got Unknown
		bool flag = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
		if (flag)
		{
			if (!(swipe.SwipeSameness > 1.06032006E+09f))
			{
				return false;
			}
			float num = swipe.TravelDistance - 1.128792E+09f;
			bool flag2 = num < 0f;
			bool flag3 = num == 0f;
			object obj = swipe.TravelDistance ^ 0x43480000;
			object obj2 = swipe.TravelDistance ^ num;
			object obj3 = obj & obj2;
			bool flag4 = (nint)obj3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			flag = flag6;
		}
		return flag;
	}

	private void CancelSwipe()
	{
		//IL_005b: Expected O, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00a2: Expected I, but got O
		//IL_00b3: Expected O, but got I
		if (_containerLayout.enabled)
		{
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, 0f, 0.5f);
			object obj = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)3016;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj3);
			object obj4 = (nint)0 + (nint)2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}

	public void DismissUserFeed(bool toRight, bool collapse = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00be: Expected I, but got O
		//IL_00f6: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_01c8: Expected I, but got O
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_02dc: Expected O, but got I
		//IL_02f5: Expected F4, but got O
		//IL_02f5: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_022a: Expected I, but got O
		OnDismissFeed();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = container.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float preferredHeight = default(float);
		spacer.preferredHeight = preferredHeight;
		_containerLayout.enabled = true;
		LayoutElement containerLayout = _containerLayout;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		nint num = (nint)containerLayout;
		containerLayout.ignoreLayout = true;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		object obj7 = (nint)0 + (nint)2872;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj9 = (nint)0 + (nint)3000;
		Rect rect2 = container.rect;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num2 = default(float);
		float endValue = 0f - num2;
		bool flag4 = !toRight;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			endValue = num2;
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, endValue, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj9);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
		if (collapse)
		{
			object obj14 = typeof(UsageHint) + 744;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v14+B8]");
			object obj16 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOPreferredSize(spacer, (Vector2)0, (float)obj16);
			Sequence sequence = TweenSettingsExtensions.Append(s3, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)3008;
			TweenCallback tweenCallback2 = default(TweenCallback);
			tweenCallback2..ctor(this, (IntPtr)obj17);
			Sequence sequence2 = TweenSettingsExtensions.AppendCallback(s3, tweenCallback2);
		}
	}

	private void ResetSpacer()
	{
		//IL_003c: Expected I, but got O
		//IL_004c: Expected O, but got I
		//IL_005c: Expected O, but got I
		spacer.preferredHeight = 0f;
		_containerLayout.enabled = false;
		LayoutElement containerLayout = _containerLayout;
		nint num = (nint)containerLayout;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+2F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3 (Il2CppClass<UnityEngine.UI.LayoutElement>)+300]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <DismissUserFeed>b__28_0()
	{
		//IL_0015: Expected O, but got I4
		container.localScale = (Vector3)0;
	}

	private void <DismissUserFeed>b__28_1()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6315]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object obj5;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gameObject;
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = gameObject;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.Destroy(obj5);
	}
}
