using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public sealed class ChatMessagesListView : UiListView<ChatMessageDataHolder, ChatMessageStrip>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ChatMessageDataHolder, bool> <>9__24_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <EnsureSize>b__24_0(ChatMessageDataHolder message)
		{
			//IL_0035: Expected I4, but got O
			if (message != null)
			{
				return message.<IsHighlighted>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public int roomId;

		internal bool <ScrollToTournamentCard>b__0(ChatMessageDataHolder holder)
		{
			//IL_014e: Expected I4, but got O
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_007f: Expected I, but got O
			//IL_008f: Expected O, but got I
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Expected O, but got Unknown
			//IL_00ca: Expected O, but got I
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Expected O, but got Unknown
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			if (holder != null)
			{
				ChatMessageData <message>k__BackingField = holder.<message>k__BackingField;
				if (holder.<message>k__BackingField != null)
				{
					Room <TournamentRoom>k__BackingField = <message>k__BackingField.<TournamentRoom>k__BackingField;
					if (<message>k__BackingField.<TournamentRoom>k__BackingField != null)
					{
						object obj = typeof(RegisteredWaitHandle) + 1376;
						nint num = (nint)<TournamentRoom>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_010b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						object obj3 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X10_v5-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj3 += 16;
							obj2--;
							if ((nint)obj2 != 1)
							{
								continue;
							}
							goto IL_010b;
						}
						object obj4 = num + obj3;
						object obj5 = obj4 + 312;
						goto IL_018f;
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_018f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v183 @ X0_v4] (should have been resolved before IL gen)");
			object obj7 = default(object);
			object obj6 = obj7 - roomId;
			return obj6 == null;
			IL_010b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_018f;
		}
	}

	private static int _index;

	private RectTransform hiddenParent;

	private Button scrollButton;

	private RectTransform childContent;

	private float cachedHeight;

	private readonly Dictionary<string, ChatMessageStrip> m_DummyItems;

	private bool IsInitialized;

	private bool StickyToEnd
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			float num = base.listHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
			object obj2 = default(object);
			object obj = obj2 + 0;
			object obj3 = obj - 1140457472;
			return (nint)obj3 < 0;
		}
	}

	private bool ShowButton
	{
		get
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_009b: Expected O, but got I4
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected I4, but got Unknown
			float num = base.listHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
			object obj2 = default(object);
			object obj = obj2 + 0;
			object obj3 = obj - 1140457472;
			bool flag = (nint)obj3 < 0;
			bool flag2 = obj3 == null;
			object obj4 = obj ^ 0x43FA0000;
			object obj5 = obj ^ obj3;
			object obj6 = obj4 & obj5;
			bool flag3 = (nint)obj6 < 0;
			bool flag4 = flag == flag3;
			object obj7 = !flag2;
			return (byte)((flag4 & obj7) ? 1 : 0) != 0;
		}
	}

	protected override void Awake()
	{
		Awake();
		Initialize();
	}

	private void Initialize()
	{
		//IL_02b4: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014f: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_01d0: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_0233: Expected I, but got O
		//IL_0243: Expected O, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		bool flag = !IsInitialized;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object message = (nint)0 + (nint)3072;
		object obj3 = ", stale={0}" + 3424;
		string text = (string)obj3;
		object obj4 = (nint)0 + (nint)2000;
		string text2 = (string)obj4;
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor((string)message, (string)obj3, (string)obj4, (DateTime?)(object)0);
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		_ = 0;
		object obj7 = obj6 + 24;
		obj7 = chatMessageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6 + 32;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X25_v3+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj10 = obj9 + 32;
			object obj11 = 0;
			object value = default(object);
			bool flag3;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X27_v5+v278 @ X26_v6*8]");
				string key = ((UnityEngine.Object)0).name;
				object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = (nint)0 + (nint)920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				object obj16 = (nint)0 + (nint)1184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				((Dictionary<object, object>)(object)m_DummyItems).set_Item((object)key, value);
				object obj17 = ((Dictionary<object, object>)(object)m_DummyItems).get_Item((object)key);
				nint num = (nint)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v29 (Il2CppClass<System.Object>)+310]");
				text2 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X8_v29 (Il2CppClass<System.Object>)+308] (should have been resolved before IL gen)");
				obj11++;
				object obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X25_v3+18]");
				flag3 = (nint)obj18 < 0;
				text = (string)1;
			}
			while (flag3);
		}
		IsInitialized = true;
	}

	protected override void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0189: Expected O, but got I
		//IL_01a1: Expected I, but got O
		object obj = 152989696;
		object obj2 = (nint)0 + (nint)432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E754A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		List<object> list;
		if (obj3 != null)
		{
			list = (List<object>)obj2;
			Start();
			obj4 = this + 152;
			bool flag = obj4 == null;
			List<object> list2 = (List<object>)obj2;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			list = (List<object>)obj2;
			Start();
			obj4 = this + 152;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			List<object> list2 = (List<object>)obj2;
			if (obj5 != null)
			{
				goto IL_0086;
			}
		}
		object obj6 = typeof(List<AdaptivePerformanceScaler>) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		obj4 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Button button = scrollButton;
		list = list3;
		goto IL_0169;
		IL_0169:
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_0086:
		button = scrollButton;
		bool flag3 = (object)scrollButton == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0169;
	}

	protected override void ComputeConditions()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_0060: Expected F4, but got I
		//IL_0086: Expected O, but got I4
		//IL_00b6: Invalid comparison between F4 and I4
		object obj = (nint)0 + (nint)424;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		ComputeConditions();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (childContent != null)
			{
				goto IL_004e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = childContent != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_004e;
			}
		}
		goto IL_008b;
		IL_008b:
		float num = base.listHeight;
		float num3 = default(float);
		float num2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
		float num4 = num2 + 0f;
		if (num4 > 1.1404575E+09f)
		{
			ShowScrollButton();
		}
		else
		{
			HideScrollButton();
		}
		return;
		IL_004e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
		num3 = -0;
		UIExtensions.MoveTo(y: num3, gObject: childContent, isWorldPositions: false, x: (float?)(object)0);
		goto IL_008b;
	}

	private void ShowScrollButton()
	{
		Button button = scrollButton;
		Color color = ((Selectable)button).m_TargetGraphic.color;
		object obj = default(object);
		if ((nint)obj <= 0)
		{
			Button button2 = scrollButton;
			int num = ShortcutExtensions.DOKill(((Selectable)button2).m_TargetGraphic, complete: true);
			Button button3 = scrollButton;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(((Selectable)button3).m_TargetGraphic, 1f, 0.2f);
			RectTransform rectTransform = UIExtensions.rectTransform(scrollButton);
			int num2 = ShortcutExtensions.DOKill(rectTransform, complete: true);
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			float endValue = 1.04522054E+09f + 1.1339039E+09f;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(rectTransform, endValue, 0.3f);
		}
	}

	private void HideScrollButton()
	{
		//IL_002e: Invalid comparison between O and F8
		Button button = scrollButton;
		Color color = ((Selectable)button).m_TargetGraphic.color;
		object obj = default(object);
		if (obj >= (object)1.0)
		{
			Button button2 = scrollButton;
			int num = ShortcutExtensions.DOKill(((Selectable)button2).m_TargetGraphic, complete: true);
			Button button3 = scrollButton;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(((Selectable)button3).m_TargetGraphic, 0f, 0.2f);
			RectTransform rectTransform = UIExtensions.rectTransform(scrollButton);
			int num2 = ShortcutExtensions.DOKill(rectTransform, complete: true);
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			float endValue = 1.04522054E+09f + 3.2813875E+09f;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(rectTransform, endValue, 0.5f);
		}
	}

	private void HideScrollButtonImmediate()
	{
		//IL_0051: Expected O, but got I4
		Button button = scrollButton;
		UIExtensions.SetAlpha(((Selectable)button).m_TargetGraphic, 0f);
		RectTransform rectTransform = UIExtensions.rectTransform(scrollButton);
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		rectTransform.anchoredPosition = (Vector2)0;
	}

	private void ScrollToEnd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_01d8: Expected I, but got O
		//IL_0067: Expected I, but got O
		//IL_006c: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		//IL_00c1: Unsupported input type for neg.
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected F4, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_012b: Expected I, but got O
		//IL_01b5: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		object obj2 = (nint)0 + (nint)368;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		object obj4 = (nint)0 + (nint)376;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<float> dOGetter = default(DOGetter<float>);
		dOGetter..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<float> dOSetter = default(DOSetter<float>);
		dOSetter..ctor((object)this, (IntPtr)obj4);
		nint num = (nint)this;
		float num2 = base.listHeight;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = default(object);
		float endValue = 0 - obj8;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, endValue, 0.2f);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)384;
		object a = tweenerCore + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Delegate obj11 = Delegate.Combine((Delegate)a, tweenCallback);
		if ((object)obj11 != null)
		{
			if (obj11 == obj9)
			{
				a = obj11;
				if (obj11 == obj9)
				{
					goto IL_01e7;
				}
			}
			throw new InvalidCastException();
		}
		a = 0;
		goto IL_01e7;
		IL_01e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ScrollToTournamentCard(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Expected I, but got O
		//IL_0068: Expected I, but got O
		//IL_0091: Expected I4, but got I8
		//IL_00ab: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(List<Tween>) + 3136;
		object obj4 = (nint)0 + (nint)3240;
		nint num = (nint)this;
		List<ChatMessageDataHolder> list = base.data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj4);
		int num2 = ((List<object>)(object)list).FindIndex(predicate);
		int num3 = (int)(num2 & 0x80000000L);
		bool flag = num3 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			((UiListView<object, object>)(object)this).AnimateCenteredScrollTo(num2, 0.3f, (Action)null);
		}
	}

	private bool CanRender(ChatMessageDataHolder message)
	{
		//IL_0058: Expected I4, but got O
		if (message != null)
		{
			string matchingTemplate = message.GetMatchingTemplate();
			if (m_DummyItems != null)
			{
				return ((Dictionary<object, object>)(object)m_DummyItems).ContainsKey((object)matchingTemplate);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public void SetData(List<ChatMessageData> messages)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_008c: Expected I, but got O
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_01b0: Expected I, but got O
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 576;
		object obj2 = (nint)0 + (nint)392;
		object obj3 = (nint)0 + (nint)3048;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 584;
		object obj5 = (nint)0 + (nint)408;
		object obj6 = (nint)0 + (nint)3304;
		Initialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)this, (IntPtr)obj2);
		IEnumerable<object> source = Enumerable.Select(messages, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)this, (IntPtr)obj5);
		IEnumerable<object> source2 = Enumerable.Where(source, func2);
		List<object> list = Enumerable.ToList(source2);
		object obj7 = this + 152;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshMessages(force: true);
		Button button = scrollButton;
		UIExtensions.SetAlpha(((Selectable)button).m_TargetGraphic, 0f);
		RectTransform rectTransform = UIExtensions.rectTransform(scrollButton);
		object obj8 = (nint)0 + (nint)2480;
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		object obj10 = default(object);
		object obj9 = obj10 + 3281387520L;
		rectTransform.anchoredPosition = (Vector2)0;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, object>>)m_DummyItems))
		{
			object obj11 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)400;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj12);
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj15 = !flag;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy.WaitForEndOfFrame(action);
		}
		else
		{
			cachedHeight = 0f;
			float num = ComputeListHeight();
			double num2 = 0.0 - -15.0;
			if (-15.0 < -15.0)
			{
				double num3 = 15.0;
			}
			else
			{
				double num3 = num2;
			}
		}
	}

	public void RemoveLastMessage()
	{
		//IL_006e: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		List<ChatMessageDataHolder> list = base.data;
		if (list == null)
		{
			return;
		}
		List<ChatMessageDataHolder> list2 = base.data;
		if (list2._size >= 1)
		{
			List<ChatMessageDataHolder> list3 = base.data;
			List<ChatMessageDataHolder> list4 = base.data;
			int index = list4._size - 1;
			object obj = (nint)0 + (nint)3080;
			((List<object>)(object)list3).RemoveAt(index);
			object obj2 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)360;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj3);
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				CoroutineDummy.WaitForEndOfFrame(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(action);
		}
	}

	public void Clear()
	{
		List<ChatMessageDataHolder> list = base.data;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
		RefreshMessages(force: true);
	}

	private void EnsureSize()
	{
		//IL_03e5: Expected O, but got I
		//IL_03ff: Expected O, but got I4
		//IL_003b: Expected I, but got O
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0437: Expected O, but got I
		//IL_0448: Expected I, but got O
		//IL_0466: Expected O, but got I
		//IL_01fd: Expected O, but got I4
		//IL_01ce: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_02f9: Expected I, but got O
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0383: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_0249: Expected I, but got O
		//IL_0259: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+70]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null)
		{
			return;
		}
		List<ChatMessageDataHolder> list = base.data;
		if (list._size < 201)
		{
			return;
		}
		nint num = (nint)this;
		IEnumerable<object> enumerable = base.data;
		object obj3 = typeof(CardUtils.<>c) + 384;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v21+E4]");
		object obj5;
		Func<object, bool> predicate;
		IEnumerable<object> source;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v21+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v16+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v16+8]");
			bool flag2 = (nint)0 == 0;
			source = enumerable;
			if (!flag2)
			{
				goto IL_00d3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v21+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v16+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X9_v16+8]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			source = enumerable;
			if (obj6 != null)
			{
				goto IL_00d3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v30+B8]");
			obj5 = 0;
		}
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)3232;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj5, (IntPtr)obj10);
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v27+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = Enumerable.Any(source, func);
		bool flag6 = !flag5;
		object obj13 = 0;
		if (!flag6)
		{
			return;
		}
		goto IL_020c;
		IL_00d3:
		bool flag7 = Enumerable.Any(enumerable, predicate);
		bool flag8 = !flag7;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			goto IL_020c;
		}
		return;
		IL_020c:
		List<ChatMessageDataHolder> list2 = base.data;
		object obj15 = (nint)0 + (nint)200;
		List<ChatMessageDataHolder> list3 = list2;
		object obj19 = default(object);
		while (true)
		{
			if (list3._size <= 200)
			{
				return;
			}
			List<object> list4 = (List<object>)(object)base.data;
			object obj16 = list4.get_Item(0);
			string matchingTemplate = ((ChatMessageDataHolder)obj16).GetMatchingTemplate();
			object obj17 = ((Dictionary<object, object>)(object)m_DummyItems).get_Item((object)matchingTemplate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v15 (System.Object)+18]");
			object obj18 = 0;
			nint num2 = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X8_v16 (Il2CppClass<System.Object>)+318] (should have been resolved before IL gen)");
			float num3 = cachedHeight - (float)obj19;
			cachedHeight = num3;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
			obj19 = obj20 + 0;
			List<object> list5 = (List<object>)(object)base.data;
			list5.RemoveAt(0);
			obj13 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v15 (System.Object)+10]");
			if (((Dictionary<int, object>)num4).TryGetValue(0, out var value))
			{
				bool flag9 = value == null;
				object obj21 = !flag9;
				if (obj21 == null)
				{
					break;
				}
				string template = ((UnityEngine.Object)value).name;
				nint num5 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v20 (Il2CppClass<ChatMessagesListView>)+2E0]");
				obj13 = 0;
				base.RecycleItem(template, (ChatMessageStrip)value);
			}
			list3 = base.data;
		}
		throw new NullReferenceException();
	}

	public void AddMessage(ChatMessageData messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0335: Expected O, but got I
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_01f3: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_028e: Expected I, but got O
		//IL_02e7: Expected O, but got F8
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 904;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 896;
		Initialize();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+B8]");
		object obj4 = 0;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 24;
		obj7 = messageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6 + 32;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string matchingTemplate = ((ChatMessageDataHolder)obj6).GetMatchingTemplate();
		object obj9 = (nint)0 + (nint)2216;
		if (!((Dictionary<object, object>)(object)m_DummyItems).ContainsKey((object)matchingTemplate))
		{
			return;
		}
		EnsureSize();
		List<object> list = (List<object>)(object)base.data;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj10 = !flag;
		if (obj10 == null)
		{
			int num = list._size + 1;
			list._size = num;
			object obj11 = items + list._size;
			object obj12 = obj11 + 32;
			obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			RefreshMessages();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+70]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				return;
			}
		}
		else
		{
			list.AddWithResize(obj6);
			RefreshMessages();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+70]");
			object obj14 = (nint)0 & (nint)1;
			bool flag2 = obj14 == null;
			object obj15 = !flag2;
			if (obj15 != null)
			{
				return;
			}
		}
		float num2 = base.listHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
		object obj17 = default(object);
		object obj16 = obj17 + 0;
		if ((nint)obj16 < 1140457472)
		{
			string matchingTemplate2 = ((ChatMessageDataHolder)obj6).GetMatchingTemplate();
			object obj18 = ((Dictionary<object, object>)(object)m_DummyItems).get_Item((object)matchingTemplate2);
			nint num3 = (nint)obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X8_v20 (Il2CppClass<System.Object>)+318] (should have been resolved before IL gen)");
			float num4 = (cachedHeight = (float)obj16 + cachedHeight);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+80]");
			float num5 = num4 - 0f;
			double num6 = (double)num5 + -15.0;
			object obj19 = 0.0 - num6;
			if (num6 < -15.0)
			{
				_ = 1097859072;
			}
		}
	}

	public void AddChallengeMessage(FriendlyChallengeData challenge)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		int num = default(int);
		string text = num.ToString();
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 552;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		string text2 = num.ToString();
		string message = text + (string)obj + text2;
		MonoBehaviour.print(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor(challenge);
		AddMessage(chatMessageData);
	}

	private void RefreshMessages(bool force = false)
	{
		//IL_1255: Expected I, but got O
		//IL_1288: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0057: Expected I, but got O
		//IL_006a: Expected I4, but got O
		//IL_0db7: Expected O, but got I
		//IL_0dc8: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00ab: Expected I, but got O
		//IL_00be: Expected I4, but got O
		//IL_00e3: Expected O, but got I4
		//IL_0e08: Expected O, but got I
		//IL_00fc: Expected I, but got O
		//IL_012f: Expected O, but got I4
		//IL_0f55: Expected O, but got I
		//IL_0f61: Expected O, but got I
		//IL_0f6d: Expected O, but got I
		//IL_136d: Expected I4, but got O
		//IL_0e3e: Expected O, but got I
		//IL_0e4a: Expected O, but got I
		//IL_0e56: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_016f: Expected O, but got I4
		//IL_133f: Expected I4, but got O
		//IL_129b: Expected I, but got O
		//IL_0199: Expected I, but got O
		//IL_01cc: Expected O, but got I4
		//IL_0f9f: Expected I, but got O
		//IL_0fb4: Expected O, but got I
		//IL_1310: Expected O, but got I4
		//IL_01ea: Expected I, but got O
		//IL_0214: Expected O, but got I4
		//IL_11b9: Expected O, but got I4
		//IL_0e88: Expected I, but got O
		//IL_0e9d: Expected O, but got I
		//IL_0712: Expected I, but got O
		//IL_074c: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_0ed0: Expected I, but got O
		//IL_0ee0: Expected O, but got I
		//IL_0f0d: Expected I, but got O
		//IL_0f15: Expected I4, but got O
		//IL_11f0: Expected I4, but got O
		//IL_1018: Expected O, but got I
		//IL_0772: Expected I, but got O
		//IL_0788: Expected I, but got O
		//IL_07ba: Expected O, but got I4
		//IL_0292: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_1166: Expected I4, but got O
		//IL_0f2b: Expected I, but got O
		//IL_0f40: Expected O, but got I
		//IL_1069: Expected O, but got I4
		//IL_1072: Expected O, but got I4
		//IL_07e0: Expected I, but got O
		//IL_0816: Expected O, but got I4
		//IL_02df: Expected I, but got O
		//IL_109b: Expected I, but got O
		//IL_10ab: Expected O, but got I
		//IL_10d8: Expected I, but got O
		//IL_10e0: Expected I4, but got O
		//IL_086b: Expected O, but got I4
		//IL_10f6: Expected I, but got O
		//IL_110b: Expected O, but got I
		//IL_08a1: Expected O, but got I
		//IL_08a6: Expected I, but got O
		//IL_08d8: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_039a: Expected I, but got O
		//IL_08f6: Expected I, but got O
		//IL_092c: Expected O, but got I4
		//IL_03eb: Expected I, but got O
		//IL_041a: Expected I, but got O
		//IL_0979: Expected O, but got I4
		//IL_044c: Expected I, but got O
		//IL_09b4: Expected O, but got I
		//IL_09b4: Expected O, but got I
		//IL_09cc: Expected I, but got O
		//IL_09d4: Expected O, but got I4
		//IL_0492: Expected I, but got O
		//IL_0a04: Expected I, but got O
		//IL_0a33: Expected I, but got O
		//IL_0a3b: Expected O, but got I4
		//IL_0a59: Expected I, but got O
		//IL_0a6f: Expected I, but got O
		//IL_0aa1: Expected O, but got I4
		//IL_0525: Expected O, but got I
		//IL_0534: Expected I, but got O
		//IL_0abf: Expected I, but got O
		//IL_0af5: Expected O, but got I4
		//IL_0b42: Expected O, but got I4
		//IL_05d1: Expected I, but got O
		//IL_0b70: Expected O, but got I
		//IL_0b75: Expected I, but got O
		//IL_0ba7: Expected O, but got I4
		//IL_0bc5: Expected I, but got O
		//IL_0bfb: Expected O, but got I4
		//IL_0671: Expected O, but got I
		//IL_0671: Expected O, but got I
		//IL_0689: Expected I, but got O
		//IL_0c48: Expected O, but got I4
		//IL_06c1: Expected I, but got O
		//IL_0c83: Expected O, but got I
		//IL_0c83: Expected O, but got I
		//IL_0c9b: Expected I, but got O
		//IL_0ca3: Expected O, but got I4
		//IL_0cd3: Expected I, but got O
		//IL_0cfc: Expected O, but got I4
		//IL_0d16: Expected O, but got I4
		//IL_0d1b: Expected I, but got O
		//IL_0d28: Expected I, but got O
		//IL_0d30: Expected I4, but got O
		//IL_0d40: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
		int num2 = 0;
		List<ChatMessageDataHolder> list = base.data;
		bool flag = list == null;
		object obj = 152989696;
		object obj4;
		string text;
		nint num3 = default(nint);
		if (!flag)
		{
			num = list._size;
			bool flag2 = list._size < 1;
			obj = 152989696;
			if (flag2)
			{
				goto IL_0d7a;
			}
			obj = (nint)0 + (nint)3952;
			num = (nint)this;
			IEnumerable<object> source = base.data;
			num2 = (int)obj;
			object obj2 = Enumerable.First(source);
			if (obj2 != null)
			{
				text = (string)((nint)0 + (nint)1632);
				_ = 1;
				num = (nint)this;
				IEnumerable<object> source2 = base.data;
				num2 = (int)text;
				object obj3 = Enumerable.Last(source2);
				bool flag3 = obj3 == null;
				string text2 = (string)1;
				if (!flag3)
				{
					_ = 1;
					num = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
					num2 = 0;
					List<ChatMessageDataHolder> list2 = base.data;
					bool flag4 = list2 == null;
					text2 = (string)1;
					if (!flag4)
					{
						obj4 = (nint)0 + (nint)3096;
						flag2 = list2._size < 2;
						text2 = (string)1;
						if (flag2)
						{
							goto IL_1296;
						}
						IEnumerable<object> source3 = base.data;
						object obj5 = Enumerable.First(source3);
						num = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
						num2 = 0;
						List<object> list3 = (List<object>)(object)base.data;
						bool flag5 = list3 == null;
						text2 = (string)1;
						obj = obj5;
						if (!flag5)
						{
							num3 = (nint)obj4;
							object obj6 = list3.get_Item(0);
							bool flag6 = obj6 == null;
							text2 = (string)1;
							num2 = 0;
							obj = obj5;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v104 (System.Object)+18]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v104 (System.Object)+18]");
								bool flag7 = (nint)0 == 0;
								text2 = (string)1;
								num2 = 0;
								obj = obj5;
								if (!flag7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
									text2 = (string)0;
									num = (nint)this;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
									num2 = 0;
									List<object> list4 = (List<object>)(object)base.data;
									bool flag8 = list4 == null;
									obj = obj5;
									if (!flag8)
									{
										num3 = (nint)obj4;
										object obj7 = list4.get_Item(1);
										bool flag9 = obj7 == null;
										num2 = 1;
										obj = obj5;
										if (!flag9)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v107 (System.Object)+18]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v107 (System.Object)+18]");
											bool flag10 = (nint)0 == 0;
											num2 = 1;
											obj = obj5;
											if (!flag10)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
												nint num4 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
												bool flag11 = (string)num4 != (string)0;
												bool flag12 = obj5 == null;
												num3 = unchecked((nint)null);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
												num2 = 0;
												obj = obj5;
												if (!flag12)
												{
													IEnumerable<object> source4 = base.data;
													object obj8 = Enumerable.Last(source4);
													List<ChatMessageDataHolder> list5 = base.data;
													num = (nint)this;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
													num2 = 0;
													List<ChatMessageDataHolder> list6 = base.data;
													bool flag13 = list6 == null;
													num3 = unchecked((nint)null);
													text2 = (string)(object)list5;
													obj = obj8;
													if (!flag13)
													{
														bool flag14 = list5 == null;
														num3 = unchecked((nint)null);
														text2 = (string)(object)list5;
														obj = obj8;
														if (!flag14)
														{
															num = list6._size;
															num2 = list6._size - 1;
															num3 = (nint)obj4;
															object obj9 = ((List<object>)(object)list5).get_Item(num2);
															bool flag15 = obj9 == null;
															text2 = (string)(object)list5;
															obj = obj8;
															if (!flag15)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v118 (System.Object)+18]");
																num = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v118 (System.Object)+18]");
																bool flag16 = (nint)0 == 0;
																text2 = (string)(object)list5;
																obj = obj8;
																if (!flag16)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																	text2 = (string)0;
																	List<ChatMessageDataHolder> list7 = base.data;
																	num = (nint)this;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
																	num2 = 0;
																	List<ChatMessageDataHolder> list8 = base.data;
																	bool flag17 = list8 == null;
																	text = (string)(object)list7;
																	obj = obj8;
																	if (!flag17)
																	{
																		bool flag18 = list7 == null;
																		text = (string)(object)list7;
																		obj = obj8;
																		if (!flag18)
																		{
																			num = list8._size;
																			num2 = list8._size - 2;
																			num3 = (nint)obj4;
																			object obj10 = ((List<object>)(object)list7).get_Item(num2);
																			bool flag19 = obj10 == null;
																			text = (string)(object)list7;
																			obj = obj8;
																			if (!flag19)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v124 (System.Object)+18]");
																				num = 0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v124 (System.Object)+18]");
																				bool flag20 = (nint)0 == 0;
																				text = (string)(object)list7;
																				obj = obj8;
																				if (!flag20)
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																					nint num5 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																					bool flag21 = (string)num5 != (string)0;
																					bool flag22 = obj8 == null;
																					num3 = unchecked((nint)null);
																					text = (string)(object)list7;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																					num2 = 0;
																					obj = obj8;
																					if (!flag22)
																					{
																						num3 = unchecked((nint)null);
																						text = (string)(object)list7;
																						obj = obj8;
																						goto IL_1296;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0d6f;
		IL_0d6f:
		throw new NullReferenceException();
		IL_1123:
		NullReferenceException ex = new NullReferenceException();
		goto IL_119e;
		IL_1296:
		num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
		num2 = 0;
		List<ChatMessageDataHolder> list9 = base.data;
		if (list9 == null)
		{
			goto IL_0d6f;
		}
		nint num6 = num3;
		int num7 = 1;
		string text3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
		int num8 = 0;
		object obj11 = obj;
		while (true)
		{
			num = list9._size - 1;
			bool flag2 = num7 >= num;
			num3 = num6;
			string text2 = (string)num7;
			text = text3;
			num2 = num8;
			obj = obj11;
			if (flag2)
			{
				break;
			}
			num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
			num2 = 0;
			List<object> list10 = (List<object>)(object)base.data;
			bool flag23 = list10 == null;
			num3 = num6;
			text2 = (string)num7;
			text = text3;
			obj = obj11;
			if (!flag23)
			{
				num3 = (nint)obj4;
				object obj12 = list10.get_Item(num7);
				num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
				num2 = 0;
				List<object> list11 = (List<object>)(object)base.data;
				bool flag24 = list11 == null;
				text2 = (string)num7;
				text = text3;
				obj = obj12;
				if (!flag24)
				{
					num3 = (nint)obj4;
					int num9 = num7 - 1;
					object obj13 = list11.get_Item(num9);
					bool flag25 = obj13 == null;
					text2 = (string)num9;
					text = text3;
					num2 = num9;
					obj = obj12;
					if (!flag25)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v80 (System.Object)+18]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v80 (System.Object)+18]");
						bool flag26 = (nint)0 == 0;
						text2 = (string)num9;
						text = text3;
						num2 = num9;
						obj = obj12;
						if (!flag26)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
							text = (string)0;
							num = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
							num2 = 0;
							List<object> list12 = (List<object>)(object)base.data;
							bool flag27 = list12 == null;
							text2 = (string)num9;
							obj = obj12;
							if (!flag27)
							{
								num3 = (nint)obj4;
								int num10 = num9 + 1;
								object obj14 = list12.get_Item(num10);
								bool flag28 = obj14 == null;
								text2 = (string)num10;
								num2 = num10;
								obj = obj12;
								if (!flag28)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v83 (System.Object)+18]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v83 (System.Object)+18]");
									bool flag29 = (nint)0 == 0;
									text2 = (string)num10;
									num2 = num10;
									obj = obj12;
									if (!flag29)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
										nint num11 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
										bool flag30 = (string)num11 != (string)0;
										bool flag31 = obj12 == null;
										num3 = unchecked((nint)null);
										text2 = (string)num10;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
										num2 = 0;
										obj = obj12;
										if (!flag31)
										{
											num = (nint)this;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
											num2 = 0;
											List<object> list13 = (List<object>)(object)base.data;
											bool flag32 = list13 == null;
											num3 = unchecked((nint)null);
											text2 = (string)num10;
											obj = obj12;
											if (!flag32)
											{
												num3 = (nint)obj4;
												object obj15 = list13.get_Item(num10);
												num = (nint)this;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
												num2 = 0;
												List<object> list14 = (List<object>)(object)base.data;
												bool flag33 = list14 == null;
												text2 = (string)num10;
												obj = obj15;
												if (!flag33)
												{
													num3 = (nint)obj4;
													int num12 = num10 + 1;
													object obj16 = list14.get_Item(num12);
													bool flag34 = obj16 == null;
													text2 = (string)num12;
													num2 = num12;
													obj = obj15;
													if (!flag34)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v91 (System.Object)+18]");
														num = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v91 (System.Object)+18]");
														bool flag35 = (nint)0 == 0;
														text2 = (string)num12;
														num2 = num12;
														obj = obj15;
														if (!flag35)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
															text = (string)0;
															num = (nint)this;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
															num2 = 0;
															List<object> list15 = (List<object>)(object)base.data;
															bool flag36 = list15 == null;
															text2 = (string)num12;
															obj = obj15;
															if (!flag36)
															{
																num3 = (nint)obj4;
																int num13 = num12 - 1;
																object obj17 = list15.get_Item(num13);
																bool flag37 = obj17 == null;
																text2 = (string)num13;
																num2 = num13;
																obj = obj15;
																if (!flag37)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v94 (System.Object)+18]");
																	num = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v94 (System.Object)+18]");
																	bool flag38 = (nint)0 == 0;
																	text2 = (string)num13;
																	num2 = num13;
																	obj = obj15;
																	if (!flag38)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																		nint num14 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																		bool flag39 = (string)num14 != (string)0;
																		bool flag40 = obj15 == null;
																		num3 = unchecked((nint)null);
																		text2 = (string)num13;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																		num2 = 0;
																		obj = obj15;
																		if (!flag40)
																		{
																			num = (nint)this;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
																			num2 = 0;
																			List<ChatMessageDataHolder> list16 = base.data;
																			text2 = (string)(num13 + 1);
																			bool flag41 = list16 == null;
																			object obj18 = !flag41;
																			num3 = unchecked((nint)null);
																			obj = obj15;
																			num6 = unchecked((nint)null);
																			num7 = (int)text2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+10]");
																			text3 = (string)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v4 (Il2CppClass<ChatMessagesListView>)+2A0]");
																			num8 = 0;
																			list9 = list16;
																			obj11 = obj15;
																			if (obj18 != null)
																			{
																				continue;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_0d6f;
		}
		goto IL_0d7a;
		IL_116b:
		ex = new NullReferenceException();
		int num16 = default(int);
		int num15 = num16;
		goto IL_119e;
		IL_1155:
		ex = new NullReferenceException();
		string matchingTemplate;
		num15 = (int)matchingTemplate;
		goto IL_119e;
		IL_0d7a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
		object obj19;
		List<int>.Enumerator enumerator2 = default(List<int>.Enumerator);
		if ((nint)0 != 0)
		{
			num = (nint)0 + (nint)216;
			obj = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
			Dictionary<int, object>.KeyCollection keys = ((Dictionary<int, object>)0).Keys;
			List<int> list17 = Enumerable.ToList(keys);
			if (list17 != null)
			{
				obj19 = (nint)0 + (nint)2384;
				List<int>.Enumerator enumerator = list17.GetEnumerator();
				if (force)
				{
					object obj20 = (nint)0 + (nint)2392;
					object obj21 = (nint)0 + (nint)208;
					object obj22 = (nint)0 + (nint)192;
					while (true)
					{
						num15 = (int)obj20;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
						if ((nint)0 == 0)
						{
							goto IL_1123;
						}
						num3 = (nint)obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
						object obj23 = ((Dictionary<int, object>)0).get_Item(num16);
						if (obj23 != null)
						{
							string text4 = ((UnityEngine.Object)obj23).name;
							nint num17 = (nint)this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v20 (Il2CppClass<ChatMessagesListView>)+2E0]");
							object obj24 = 0;
							base.RecycleItem(text4, (ChatMessageStrip)obj23);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
							bool flag42 = (nint)0 == 0;
							num3 = (nint)obj23;
							num15 = (int)text4;
							if (!flag42)
							{
								num3 = (nint)obj22;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
								bool flag43 = ((Dictionary<int, object>)0).Remove(num16);
								continue;
							}
							goto IL_1131;
						}
						goto IL_113f;
					}
				}
				else
				{
					object obj25 = (nint)0 + (nint)2392;
					object obj26 = (nint)0 + (nint)208;
					object obj27 = (nint)0 + (nint)192;
					while (true)
					{
						num15 = (int)obj25;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
						if ((nint)0 == 0)
						{
							goto IL_1123;
						}
						num3 = (nint)obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
						object obj28 = ((Dictionary<int, object>)0).get_Item(num16);
						if (obj28 == null)
						{
							goto IL_116b;
						}
						string text5 = ((UnityEngine.Object)obj28).name;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v32 (System.Object)+40]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v32 (System.Object)+40]");
							matchingTemplate = ((ChatMessageDataHolder)0).GetMatchingTemplate();
							if (text5 != null)
							{
								bool flag44 = text5.Equals(matchingTemplate, StringComparison.Ordinal);
								bool flag45 = !flag44;
								object obj29 = !flag45;
								object obj24 = 0;
								num3 = 4;
								if (obj29 != null)
								{
									continue;
								}
								string text6 = ((UnityEngine.Object)obj28).name;
								nint num18 = (nint)this;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v18 (Il2CppClass<ChatMessagesListView>)+2E0]");
								obj24 = 0;
								base.RecycleItem(text6, (ChatMessageStrip)obj28);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
								bool flag46 = (nint)0 == 0;
								num3 = (nint)obj28;
								num15 = (int)text6;
								if (!flag46)
								{
									num3 = (nint)obj27;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+B0]");
									bool flag47 = ((Dictionary<int, object>)0).Remove(num16);
									continue;
								}
								goto IL_1131;
							}
							goto IL_1155;
						}
						goto IL_1181;
					}
				}
				enumerator2.Dispose();
				return;
			}
		}
		goto IL_0d6f;
		IL_1181:
		ex = new NullReferenceException();
		num15 = 0;
		goto IL_119e;
		IL_113f:
		ex = new NullReferenceException();
		num15 = num16;
		goto IL_119e;
		IL_1131:
		ex = new NullReferenceException();
		goto IL_119e;
		IL_119e:
		bool flag48 = num15 != 1;
		List<int>.Enumerator enumerator3 = (List<int>.Enumerator)0;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag48)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num15 = (int)obj19;
			enumerator2.Dispose();
			object obj30 = default(object);
			if (obj30 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			enumerator3 = (List<int>.Enumerator)obj30;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBC9E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	protected override float ComputeListHeight()
	{
		//IL_01c2: Invalid comparison between F4 and I4
		//IL_01f2: Invalid comparison between F4 and I4
		//IL_0201: Invalid comparison between F4 and I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0222: Expected O, but got F4
		//IL_0257: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0025: Expected F4, but got I4
		//IL_0193: Expected F4, but got I4
		//IL_003f: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_0071: Expected F4, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b7: Expected I, but got O
		//IL_00c8: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		float num;
		if (cachedHeight == 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+98]");
			bool flag = (nint)0 == 0;
			num = 0f;
			if (!flag)
			{
				object obj = (nint)0 + (nint)2480;
				bool flag2 = ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, object>>)m_DummyItems);
				bool flag3 = !flag2;
				object obj2 = !flag3;
				num = 0f;
				if (obj2 == null)
				{
					object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 592;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj4 = (nint)0 + (nint)352;
					Func<object, float> func = default(Func<object, float>);
					func..ctor((object)this, (IntPtr)obj4);
					object obj5 = (nint)0 + (nint)696;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+98]");
					float num2 = Enumerable.Sum((IEnumerable<object>)0, func);
					RectTransform rectTransform = UIExtensions.rectTransform(this);
					Rect rect = rectTransform.rect;
					object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v12+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj9 = default(object);
					num = num2 - (float)obj9;
				}
			}
		}
		else
		{
			float num3 = cachedHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+80]");
			num = num3 - 0f;
		}
		float num4 = num - 2.139095E+09f;
		bool flag5 = num4 < 0f;
		bool flag6 = num4 == 0f;
		object obj10 = num ^ 0x7F7FFFFF;
		object obj11 = num ^ num4;
		object obj12 = obj10 & obj11;
		bool flag7 = (nint)obj12 < 0;
		bool flag8 = flag5 == flag7;
		object obj13 = !flag6;
		object obj14 = flag8 & obj13;
		object obj15 = ~obj14;
		float result = ((obj15 != null) ? num : 2.139095E+09f);
		if ((double)num < 1.0)
		{
			result = 1f;
		}
		return result;
	}

	protected override void UpdateItems()
	{
		//IL_02bb: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_0298: Expected O, but got I4
		//IL_0049: Expected F4, but got I4
		//IL_00c9: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0114: Expected I, but got O
		//IL_0164: Invalid comparison between F4 and I4
		//IL_0175: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_01a4: Invalid comparison between F4 and I4
		//IL_01b3: Invalid comparison between F4 and I4
		//IL_01c6: Expected O, but got F4
		//IL_01d3: Expected O, but got F4
		//IL_0082: Expected O, but got I4
		//IL_02c5: Expected I, but got O
		//IL_0240: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+98]");
		object obj = 0;
		cachedHeight = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+18]");
		if ((nint)0 >= (nint)1)
		{
			bool doneSettling = true;
			float num = 0f;
			int num2 = 0;
			int num3 = 0;
			float num8 = default(float);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+98]");
				object obj2 = ((List<object>)0).get_Item(num3);
				string matchingTemplate = ((ChatMessageDataHolder)obj2).GetMatchingTemplate();
				object obj3 = ((Dictionary<object, object>)(object)m_DummyItems).get_Item((object)matchingTemplate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v10 (System.Object)+18]");
				object obj4 = 0;
				nint num4 = (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v345 @ X8_v12 (Il2CppClass<System.Object>)+318] (should have been resolved before IL gen)");
				float num5 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
				float num6 = num5 + 0f;
				float num7 = num8 + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+80]");
				float num9 = 0f + num8;
				bool flag = num7 < 0f;
				object obj5 = !flag;
				object obj6 = ~obj5;
				bool flag2;
				bool flag3;
				bool flag4;
				if (obj6 == null)
				{
					float num10 = num6 - num9;
					flag2 = num10 < 0f;
					flag3 = num10 == 0f;
					object obj7 = num6 ^ num9;
					object obj8 = num6 ^ num10;
					object obj9 = obj7 & obj8;
					flag4 = (nint)obj9 < 0;
				}
				else
				{
					flag4 = false;
					flag3 = false;
					flag2 = false;
				}
				bool flag5 = flag2 == flag4;
				object obj10 = !flag5;
				object obj11 = obj10 | flag3;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v10 (System.Object)+2A]");
					bool flag6 = (nint)0 == 0;
					object obj12 = !flag6;
					object obj13 = ~obj12;
					int order = ((obj13 != null) ? num2 : 1000);
					nint num11 = (nint)this;
					base.UpdateVisibleItem((ChatMessageDataHolder)obj2, order, num6, ref doneSettling);
					num2++;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v10 (System.Object)+10]");
					base.Recycle(0);
				}
				num += num8;
				num8 = (cachedHeight = num8 + cachedHeight);
				num3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v4+18]");
			}
			while ((nint)0 != num3);
			bool num12 = doneSettling;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+48]");
			object obj14 = (nint)(num12 ? 1 : 0) & (nint)0;
			if (obj14 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+48]");
			object obj15 = (nint)1 & (nint)0;
			bool flag7 = obj15 == null;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				return;
			}
		}
		base.EndSettling();
	}

	public ChatMessagesListView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		m_DummyItems = (Dictionary<string, ChatMessageStrip>)(object)dictionary;
		object obj2 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((UiListView<object, object>)(object)this)..ctor();
	}

	private float <ScrollToEnd>b__18_0()
	{
		//IL_000d: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ChatMessagesListView)+20]");
		return 0f;
	}

	private void <ScrollToEnd>b__18_1(float value)
	{
	}

	private void <ScrollToEnd>b__18_2()
	{
		//IL_000e: Unsupported input type for neg.
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		float num = base.listHeight;
		object obj2 = default(object);
		object obj = 0 - obj2;
		_ = 0;
	}

	private ChatMessageDataHolder <SetData>b__21_0(ChatMessageData message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 904;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 896;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object obj4 = 0;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 24;
		obj7 = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj6 + 32;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (ChatMessageDataHolder)obj6;
	}

	private void <SetData>g__ScrollToEndImmediate|21_1()
	{
		cachedHeight = 0f;
		float num = ComputeListHeight();
		object obj = default(object);
		double num2 = (double)obj + -15.0;
		double num3 = 0.0 - num2;
		if (num2 < -15.0)
		{
			double num4 = 15.0;
		}
		else
		{
			double num4 = num3;
		}
	}

	private void <RemoveLastMessage>b__22_0()
	{
		RefreshMessages(force: true);
	}

	private float <ComputeListHeight>b__28_0(ChatMessageDataHolder message)
	{
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		string matchingTemplate = message.GetMatchingTemplate();
		object obj = ((Dictionary<object, object>)(object)m_DummyItems).get_Item((object)matchingTemplate);
		ChatMessageData <message>k__BackingField = message.<message>k__BackingField;
		string <Message>k__BackingField = <message>k__BackingField.<Message>k__BackingField;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7 (Il2CppClass<System.Object>)+318]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v7 (Il2CppClass<System.Object>)+320]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
