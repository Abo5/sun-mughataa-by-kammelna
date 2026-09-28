using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Jackaroo;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class Topbar : MonoBehaviour
{
	private sealed class <>c__DisplayClass15_0
	{
		public Topbar <>4__this;

		public float roomMessageHiddenPosition;

		public float roomNameOriginalY;

		public float roomInfoOriginalY;

		public TweenCallback <>9__3;

		internal void <Init>b__0()
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_007f: Expected O, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00b7: Expected O, but got I
			//IL_00c5: Expected I, but got O
			Topbar topbar = <>4__this;
			object obj = (nint)0 + (nint)2904;
			object obj2 = (nint)0 + (nint)2504;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(topbar.roomMessage, roomMessageHiddenPosition, 0.5f, snapping: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj3 = this + 40;
			TweenCallback tweenCallback = (TweenCallback)obj3;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)3592;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj6);
				<>9__3 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			<>4__this.RoomInfoSlideIn(roomNameOriginalY, roomInfoOriginalY);
		}

		internal void <Init>b__3()
		{
			Topbar topbar = <>4__this;
			GameObject gameObject = topbar.roomMessage.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass15_1
	{
		public JackarooAllowedRules customRules;

		public <>c__DisplayClass15_0 CS$<>8__locals1;

		public Action<JackarooCustomRulesPreview> <>9__2;

		internal void <Init>b__1()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_00d9: Expected O, but got I
			//IL_00e7: Expected I, but got O
			//IL_010c: Expected O, but got I
			//IL_0136: Expected O, but got I4
			//IL_0067: Expected O, but got I
			<>c__DisplayClass15_0 cS$<>8__locals = CS$<>8__locals1;
			Topbar <>4__this = cS$<>8__locals.<>4__this;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = this + 32;
			Action<object> action = (Action<object>)obj2;
			Action<object> action2;
			object obj5;
			object obj3;
			if (obj2 != null)
			{
				obj3 = (nint)0 + (nint)2088;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				action2 = action;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_00a4;
				}
			}
			else
			{
				object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)3608;
				Action<object> action3 = default(Action<object>);
				action3..ctor((object)this, (IntPtr)obj7);
				<>9__2 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj3 = (nint)0 + (nint)2088;
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				action = action3;
				action2 = action3;
				obj5 = obj3;
				if (obj8 != null)
				{
					goto IL_00a4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			obj3 = obj5;
			goto IL_00a4;
			IL_00a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		}

		internal void <Init>b__2(JackarooCustomRulesPreview pop)
		{
			pop.Populate(customRules);
		}
	}

	private CardGame game;

	private RectTransform roomInfoContainer;

	private GameObject pingBars;

	private Transform roomMessage;

	private TextMeshProUGUI roomMessageText;

	private Button customRulesButton;

	private Button chatButton;

	private Image chatIcon;

	private GameObject chatBlocker;

	private SpritesStore spriteStore;

	private GameEventsChannel gameEventsChannel;

	private ComponentReference<JackarooCustomRulesPreview> jackarooCustomRulesPreview;

	private RectTransform pingBarsContainer;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 32;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		Init();
	}

	private void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_015f: Expected F4, but got I
		//IL_0182: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_0200: Expected I, but got O
		//IL_02d2: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0276: Expected O, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_0292: Expected O, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_054f: Expected O, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_05da: Expected F4, but got I
		//IL_05da: Expected F4, but got I
		//IL_03db: Expected O, but got I4
		//IL_060c: Expected O, but got I
		//IL_0627: Expected O, but got I
		//IL_064c: Expected O, but got I
		//IL_065d: Expected I, but got O
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_069b: Expected O, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_044c: Expected O, but got I
		//IL_045d: Expected I, but got O
		//IL_047d: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = pingBars.transform;
		RectTransform rectTransform = UIExtensions.parentRt(transform);
		object obj4 = this + 128;
		obj4 = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Vector2 anchoredPosition = ((RectTransform)obj4).anchoredPosition;
		Vector2 anchoredPosition2 = roomInfoContainer.anchoredPosition;
		Vector3 localPosition = roomMessage.localPosition;
		_ = 1149861888;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+1C]");
		float value = 0f + 1.1255153E+09f;
		UIExtensions.MoveTo(y: value, gObject: pingBarsContainer, isWorldPositions: false, x: (float?)(object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+20]");
		float value2 = 0f + 1.1255153E+09f;
		float? y = value2;
		UIExtensions.MoveTo(roomInfoContainer, isWorldPositions: false, (float?)(object)0, y);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+18]");
		y = 0f;
		UIExtensions.MoveTo(roomMessage, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
		GameObject go = base.gameObject;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)248;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2544;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		Room room = game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, room, (string)varName, action);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v7+E4]");
		object obj10;
		object obj12;
		Action action2;
		if ((nint)0 != 0)
		{
			bool flag = customRulesButton != null;
			bool flag2 = !flag;
			object obj9 = !flag2;
			obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (obj9 != null)
			{
				goto IL_02f6;
			}
			obj12 = 0;
			action2 = action;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = customRulesButton != null;
			bool flag4 = !flag3;
			obj10 = 0;
			UnityEngine.Object obj11 = null;
			obj12 = 0;
			action2 = action;
			if (!flag4)
			{
				goto IL_02f6;
			}
		}
		goto IL_0487;
		IL_0487:
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Room room2 = game.Room;
		string text = SFSKammelnaRoomExtensions.GetRoomMessage(room2);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v38+E4]");
		if ((nint)0 != 0)
		{
			if (!StringsExtensions.IsNullOrEmpty(text))
			{
				goto IL_055e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = StringsExtensions.IsNullOrEmpty(text);
			bool flag6 = !flag5;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				goto IL_055e;
			}
		}
		goto IL_05bc;
		IL_055e:
		TextMeshProExtensions.FixArabic(roomMessageText, text);
		GameObject gameObject = roomMessage.gameObject;
		gameObject.SetActive(value: true);
		if (ScreenUtility.IsTablet)
		{
			goto IL_05bc;
		}
		float endValue = default(float);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(roomMessage, endValue, 0.5f, snapping: true);
		object obj16 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj17 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)3584;
		Action action3 = default(Action);
		action3..ctor(obj2, (IntPtr)obj18);
		object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v54+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(5f, action3);
		return;
		IL_02f6:
		bool flag8 = jackarooCustomRulesPreview == null;
		obj12 = obj10;
		action2 = action;
		if (!flag8)
		{
			object obj22 = typeof(SkeletonBinary.SkeletonInput) + 3376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = default(object);
			obj23..ctor();
			object obj24 = obj23 + 24;
			obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			GameObject gameObject2 = customRulesButton.gameObject;
			gameObject2.SetActive(value: false);
			Room room3 = game.Room;
			JackarooAllowedRules jackarooCustomRules = SFSKammelnaRoomExtensions.GetJackarooCustomRules(room3);
			bool flag9 = jackarooCustomRules == JackarooAllowedRules.DEFAULT;
			obj12 = 0;
			action2 = action;
			if (!flag9)
			{
				GameObject gameObject3 = customRulesButton.gameObject;
				gameObject3.SetActive(value: true);
				Button button = customRulesButton;
				object obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj26 = (nint)0 + (nint)3600;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(obj23, (IntPtr)obj26);
				button.m_OnClick.AddListener(unityAction);
				obj12 = 0;
				action2 = null;
			}
		}
		goto IL_0487;
		IL_05bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+1C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+20]");
		RoomInfoSlideIn(num, 0f);
	}

	private void RoomInfoSlideIn(float roomNameOriginalY, float roomInfoOriginalY)
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		object obj = (nint)0 + (nint)2872;
		object obj2 = (nint)0 + (nint)2760;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		float endValue = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(pingBarsContainer, endValue, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(roomInfoContainer, roomInfoOriginalY, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = customRulesButton != null;
			bool flag2 = !flag;
			object obj5 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = customRulesButton != null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj5 = 0;
			if (obj6 == null)
			{
				return;
			}
		}
		object obj7 = typeof(SqlSingle[]) + 3912;
		RectTransform rectTransform = UIExtensions.rectTransform(customRulesButton);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		Transform rect = rectTransform;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		AnimationExtensions.AnimEmphasise(rect, 2);
	}

	private void UpdateChatButton()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_01dc: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Room room = game.Room;
		bool flag = SFSKammelnaRoomExtensions.IsChatEnabled(room);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v7+E4]");
		Sprite sprite;
		if ((nint)0 != 0)
		{
			bool flag2 = chatButton;
			bool flag3 = !flag2;
			object obj3 = !flag3;
			sprite = null;
			if (obj3 == null)
			{
				goto IL_009f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = chatButton;
			bool flag5 = !flag4;
			sprite = null;
			if (flag5)
			{
				goto IL_009f;
			}
		}
		SpritesStore spritesStore = spriteStore;
		if (flag)
		{
			object obj4 = 80;
		}
		else
		{
			object obj4 = 88;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7 (SpritesStore)+v53 @ X9_v4]");
		sprite = (Sprite)0;
		Image image = chatIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7 (SpritesStore)+v53 @ X9_v4]");
		image.sprite = (Sprite)0;
		UnityEngine.Object obj5 = chatBlocker;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj7 = !flag6;
		UnityEngine.Object obj8 = chatBlocker;
		if (obj7 != null)
		{
			goto IL_00e0;
		}
		goto IL_0228;
		IL_009f:
		obj5 = chatBlocker;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+E4]");
		bool flag7 = (nint)0 == 0;
		obj8 = chatBlocker;
		if (!flag7)
		{
			goto IL_00e0;
		}
		goto IL_0228;
		IL_0228:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj8;
		bool flag9 = !flag8;
		object obj9 = !flag9;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0106;
		IL_00e0:
		if ((bool)obj5)
		{
			goto IL_0106;
		}
		return;
		IL_0106:
		GameObject gameObject = chatBlocker.gameObject;
		bool active = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}

	public void ExitGame()
	{
		gameEventsChannel.TriggerExitGame();
	}
}
