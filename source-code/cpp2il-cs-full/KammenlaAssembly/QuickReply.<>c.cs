using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class QuickReply : MonoBehaviour
{
	private enum QuickReplyState
	{
		closed,
		closing,
		opened,
		opening,
		expanded,
		expanding
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Tweener> <>9__46_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <FinishAnimations>b__46_0(Tweener t)
		{
			TweenExtensions.Kill(t);
		}
	}

	private float animationDuration;

	private float quickAnimationDuration;

	private ReplyButton replyButtonPrefab;

	private Button quickBtn;

	private Image overlay;

	private RectTransform quickRepliesTop;

	private RectTransform quickRepliesAll;

	private RectTransform mainPanel;

	private RectTransform forSubscribersLabel;

	private RectTransform buttonsContiner;

	private Sprite moreBtnSprite;

	private GameEventsChannel gameEventsChannel;

	private QuickReplyState <State>k__BackingField;

	private TextMeshProUGUI btnText;

	private Image btnImage;

	private Sprite quickBtnSprite;

	private RectTransform btnTransform;

	private List<Tweener> tweeners;

	private CardGame game;

	private QuickReplyState State
	{
		get
		{
			return <State>k__BackingField;
		}
		set
		{
			<State>k__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_020e: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0312: Expected I, but got O
		//IL_0323: Expected O, but got I
		//IL_034d: Expected I, but got O
		//IL_035e: Expected O, but got I
		//IL_038a: Expected I, but got O
		<State>k__BackingField = QuickReplyState.closed;
		Button button = quickBtn;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		object obj3 = (nint)0 + (nint)288;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object obj5 = this + 128;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj5;
			bool flag2 = !flag;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				goto IL_0103;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(UnityEngine.Object)obj5)
			{
				goto IL_0103;
			}
		}
		object text = "Picking audio files is not supported on iOS" + 4080;
		TextMeshProExtensions.Localize((TextMeshProUGUI)obj5, (string)text);
		Button button2 = quickBtn;
		object obj9 = 0;
		goto IL_01ae;
		IL_01ae:
		object obj10 = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj11 = this + 136;
		object obj12 = default(object);
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj11;
		object obj14 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11+D8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = (nint)0 + (nint)4040;
		object obj16 = (nint)0 + (nint)24;
		object obj17 = typeof(SqlSingle[]) + 2376;
		object obj18 = (nint)0 + (nint)992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj19 = this + 152;
		object obj20 = default(object);
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetupRepliesButtons();
		object obj21 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj22 = !flag3;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj23 = this + 168;
		object obj24 = default(object);
		obj23 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj18);
		object obj25 = (nint)0 + (nint)984;
		((KGame)obj23).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj25);
		object obj26 = (nint)0 + (nint)1000;
		gameEventsChannel.CloseQuickReplies += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj26);
		gameEventsChannel.ShowQuickRepliesForSubscribersMessage += action3;
		return;
		IL_0103:
		button2 = quickBtn;
		bool flag4 = (object)quickBtn == null;
		object obj27 = !flag4;
		obj9 = 0;
		if (obj27 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01ae;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1000;
		gameEventsChannel.CloseQuickReplies -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		gameEventsChannel.ShowQuickRepliesForSubscribersMessage -= action2;
	}

	private void ButtonClicked()
	{
		//IL_001c: Expected O, but got I4
		//IL_0047: Expected O, but got I8
		bool flag = <State>k__BackingField < QuickReplyState.expanded;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = (long)<State>k__BackingField & 0xFFFFFFFEL;
			if ((nint)obj3 == 4)
			{
				Close();
			}
		}
		else
		{
			Expand();
		}
	}

	private void OnGameStateUpdated()
	{
		//IL_0029: Expected O, but got I4
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			CardGame cardGame = game;
			if (cardGame.<Stage>k__BackingField.IsBidding)
			{
				DisableButton();
				Close();
				return;
			}
		}
		EnableButton();
	}

	public void OnSwipe(SwipeGesture swipe)
	{
		if (swipe.CardinalDirection == GestureDirection.Up && <State>k__BackingField == QuickReplyState.opened)
		{
			Expand();
		}
	}

	private void SwipeUp()
	{
		if (<State>k__BackingField == QuickReplyState.opened)
		{
			Expand();
		}
	}

	private void SetupRepliesButtons()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_00ef: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_0060: Expected I, but got O
		//IL_0098: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2080;
		object obj2 = (nint)0 + (nint)808;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1680;
		object obj4 = (nint)0 + (nint)960;
		object obj5 = (nint)0 + (nint)2104;
		object obj6 = (nint)0 + (nint)968;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<CommonWord> words = CommonWordDictionary.Words;
		IEnumerable<object> enumeration = Enumerable.Take((IEnumerable<object>)words, 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ArraysExtensions.ForEach(enumeration, action);
		IEnumerable<CommonWord> words2 = CommonWordDictionary.Words;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		ArraysExtensions.ForEach(words2, action2);
	}

	private void Open()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_02a3: Expected O, but got I
		//IL_02b9: Expected O, but got I
		//IL_02ef: Expected O, but got I4
		//IL_02f8: Expected O, but got I4
		//IL_0391: Expected O, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I
		//IL_03bd: Expected O, but got I
		//IL_03ff: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76AB]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			obj5 = btnText;
			obj6 = btnText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = btnText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = btnText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			goto IL_00c2;
		}
		goto IL_0182;
		IL_022a:
		QuickReplyState quickReplyState;
		if (quickReplyState == QuickReplyState.expanded)
		{
			goto IL_024a;
		}
		goto IL_0333;
		IL_024a:
		HideMainPanel();
		ShowButton();
		goto IL_035b;
		IL_035b:
		ExpandQuickReplies();
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(buttonsContiner, 180f, animationDuration);
		object obj8 = (nint)0 + (nint)1736;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)952;
		object obj11 = (nint)0 + (nint)2528;
		gameEventsChannel.TriggerPanelShow();
		<State>k__BackingField = QuickReplyState.opening;
		object obj12 = Enumerable.Last((IEnumerable<object>)tweeners);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			goto IL_00c2;
		}
		goto IL_0182;
		IL_0182:
		object text = "Material with texture name \"" + 2544;
		TextMeshProExtensions.Localize(btnText, (string)text);
		Image image = btnImage;
		goto IL_01af;
		IL_00c2:
		image = btnImage;
		bool flag5 = (object)btnImage == null;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01af;
		IL_01af:
		Sprite sprite = moreBtnSprite;
		image.sprite = moreBtnSprite;
		Button button = quickBtn;
		Sprite sprite2;
		if (!((Selectable)button).m_Interactable)
		{
			quickReplyState = <State>k__BackingField;
			bool flag6 = <State>k__BackingField == QuickReplyState.closing;
			sprite2 = sprite;
			if (!flag6)
			{
				goto IL_022a;
			}
		}
		else
		{
			int num = ShortcutExtensions.DOKill(btnTransform, complete: true);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(btnTransform, 0.8f, 0.5f);
			object obj15 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			object obj16 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			quickReplyState = <State>k__BackingField;
			bool flag7 = <State>k__BackingField != QuickReplyState.closing;
			sprite = (Sprite)27;
			sprite2 = (Sprite)27;
			if (flag7)
			{
				goto IL_022a;
			}
		}
		FinishAnimations();
		bool flag8 = <State>k__BackingField == QuickReplyState.expanded;
		sprite = sprite2;
		if (flag8)
		{
			goto IL_024a;
		}
		goto IL_0333;
		IL_0333:
		GameObject gameObject = overlay.gameObject;
		gameObject.SetActive(value: true);
		goto IL_035b;
	}

	private void Expand()
	{
		//IL_00c9: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0068: Expected O, but got I
		//IL_00ad: Expected I, but got O
		object obj = (nint)0 + (nint)1736;
		object obj2 = (nint)0 + (nint)2528;
		if (<State>k__BackingField == QuickReplyState.opening)
		{
			object obj3 = Enumerable.Last((IEnumerable<object>)tweeners);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
		HideButton();
		ExpandMainPanel();
		GameObject gameObject = overlay.gameObject;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)944;
		gameObject.SetActive(value: true);
		<State>k__BackingField = QuickReplyState.expanding;
		object obj6 = Enumerable.Last((IEnumerable<object>)tweeners);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void Close()
	{
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I4
		//IL_030c: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_0015: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00c8: Expected O, but got I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0247: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_02b7: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = <State>k__BackingField - 5;
		bool flag = obj2 == null;
		object obj3 = !flag;
		object obj4 = ~obj3;
		bool flag2;
		if (obj4 == null)
		{
			object obj5 = <State>k__BackingField - 3;
			flag2 = obj5 == null;
		}
		else
		{
			flag2 = true;
		}
		object obj6 = !flag2;
		if (obj6 == null)
		{
			FinishAnimations();
		}
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = btnText;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				goto IL_00a2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!btnText)
			{
				goto IL_00a2;
			}
		}
		object text = "Picking audio files is not supported on iOS" + 4080;
		TextMeshProExtensions.Localize(btnText, (string)text);
		Image image = btnImage;
		goto IL_013f;
		IL_013f:
		image.sprite = quickBtnSprite;
		Button button = quickBtn;
		if (((Selectable)button).m_Interactable)
		{
			int num = ShortcutExtensions.DOKill(btnTransform, complete: true);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(btnTransform, 0.8f, 0.5f);
			object obj9 = (nint)0 + (nint)2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			object obj10 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
		RetractQuickReplies();
		HideMainPanel();
		ShowButton();
		GameObject gameObject = overlay.gameObject;
		object obj11 = (nint)0 + (nint)1800;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj13 = (nint)0 + (nint)936;
		object obj14 = (nint)0 + (nint)2528;
		gameObject.SetActive(value: false);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(buttonsContiner, 0f, animationDuration);
		<State>k__BackingField = QuickReplyState.closing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC8C54");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_00a2:
		image = btnImage;
		bool flag5 = (object)btnImage == null;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013f;
	}

	private void ExpandQuickReplies()
	{
		//IL_00ee: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(quickRepliesTop, (Vector2)0, 0f);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	private void RetractQuickReplies()
	{
		//IL_00ee: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(quickRepliesTop, (Vector2)0, 0f);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	private void ExpandMainPanel()
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(mainPanel, 830f, animationDuration);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	private void HideMainPanel()
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(mainPanel, 0f, animationDuration);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	public void ShowForSubscribersLabel()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2760;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(forSubscribersLabel, 0f, animationDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void ShowButton()
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(btnTransform, 0f, quickAnimationDuration);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	private void HideButton()
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		List<object> list = (List<object>)(object)tweeners;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(btnTransform, -380f, quickAnimationDuration);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = tweenerCore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)tweenerCore);
		}
	}

	private void EnableButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		quickBtn.interactable = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)btnText)
			{
				goto IL_007e;
			}
			return;
		}
		goto IL_00bf;
		IL_00bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag = btnText;
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			return;
		}
		goto IL_007e;
		IL_007e:
		TextMeshProUGUI textMeshProUGUI = btnText;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_00bf;
	}

	private void DisableButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		quickBtn.interactable = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)btnText)
			{
				goto IL_007e;
			}
			return;
		}
		goto IL_00bf;
		IL_00bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag = btnText;
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			return;
		}
		goto IL_007e;
		IL_007e:
		TextMeshProUGUI textMeshProUGUI = btnText;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_00bf;
	}

	private void ShowOverlay()
	{
		GameObject gameObject = overlay.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideOverlay()
	{
		GameObject gameObject = overlay.gameObject;
		gameObject.SetActive(value: false);
	}

	private void ShowPlaying()
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(buttonsContiner, 0f, animationDuration);
	}

	private void HidePlaying()
	{
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(buttonsContiner, 180f, animationDuration);
	}

	private void FinishAnimations()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0155: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0307: Expected O, but got I
		//IL_0318: Expected I, but got O
		//IL_0336: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_0231: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76B7]");
		object obj3 = (nint)0 & (nint)1;
		List<Tweener> list;
		List<Tweener> list2;
		object obj4;
		if (obj3 != null)
		{
			list = tweeners;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = tweeners;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = tweeners;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = tweeners;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01df;
		IL_024b:
		List<object> list3;
		list3.ForEach(action);
		List<Tweener> list4 = tweeners;
		int version = list4._version + 1;
		list4._size = 0;
		list4._version = version;
		if (list4._size >= 1)
		{
			Array.Clear(list4._items, 0, list4._size);
		}
		return;
		IL_00e6:
		bool flag4 = list == null;
		object obj9 = !flag4;
		list3 = (List<object>)(object)list;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_024b;
		IL_01df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v14+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3032;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v13+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		list3 = (List<object>)(object)list2;
		goto IL_024b;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+8]");
		bool flag6 = (nint)0 == 0;
		list2 = list;
		if (!flag6)
		{
			goto IL_00e6;
		}
		goto IL_01df;
	}

	public QuickReply()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 160;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SetupRepliesButtons>b__29_0(CommonWord word)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_0080: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)1016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		ReplyButton replyButton = default(ReplyButton);
		replyButton.Populate(word, isTop4: true);
	}

	private void <SetupRepliesButtons>b__29_1(CommonWord word)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_0080: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)1016;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		ReplyButton replyButton = default(ReplyButton);
		replyButton.Populate(word, isTop4: false);
	}

	private void <Open>b__30_0()
	{
		<State>k__BackingField = QuickReplyState.opened;
	}

	private void <Expand>b__31_0()
	{
		<State>k__BackingField = QuickReplyState.expanded;
	}

	private void <Close>b__32_0()
	{
		<State>k__BackingField = QuickReplyState.closed;
	}
}
