using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using CardDistribution;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

namespace Jackaroo;

public class JackarooCardGameVisualControls : CardGameVisualControls
{
	private sealed class <>c__DisplayClass43_0
	{
		public Card card;

		public KPlayer player;

		public JackarooCardGameVisualControls <>4__this;

		internal void <HandleOrderedPlayedCards>b__0()
		{
			//IL_0104: Expected O, but got I4
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0052: Expected I, but got O
			//IL_007b: Expected O, but got I4
			//IL_00af: Expected O, but got I
			KPlayer kPlayer = player;
			if (player != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
				object obj2 = obj;
				nint num = (nint)kPlayer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v4 (Il2CppClass<KPlayer>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v10+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v4 (Il2CppClass<KPlayer>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v10+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v7-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00d6;
					}
				}
				InvalidCastException ex = new InvalidCastException();
				throw new NullReferenceException();
			}
			goto IL_00d6;
			IL_00d6:
			<>4__this.PlayCard(card, (CardGamePlayer)player, null, isEventFromServer: true, withCollision: true, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		}
	}

	private sealed class <>c__DisplayClass44_0
	{
		public int lastPlayerIndex;

		public JackarooCardGameVisualControls <>4__this;

		internal bool <HandleSinglePlayedCard>b__0(JackarooPlayer p)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (p != null)
			{
				object obj = ((KPlayer)p).<Index>k__BackingField - lastPlayerIndex;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass44_1
	{
		public JackarooPlayer player;

		public <>c__DisplayClass44_0 CS$<>8__locals1;

		internal void <HandleSinglePlayedCard>b__1()
		{
			//IL_0052: Expected O, but got I4
			<>c__DisplayClass44_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooPlayer jackarooPlayer = player;
			cS$<>8__locals.<>4__this.PlayCard(((CardGamePlayer)jackarooPlayer).<PlayedCard>k__BackingField, player, null, isEventFromServer: true, withCollision: true, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		}
	}

	private JackarooBoardMono <Board>k__BackingField;

	private SpriteRenderer <BoardEffectsSpriteRenderer>k__BackingField;

	private Camera <BoardEffectsCamera>k__BackingField;

	private float cardLandingPositionOffset;

	private float opponentCardSideRotationAnglePhone;

	private float opponentCardSideRotationAngleTablet;

	private JackarooCardDistributor _cardDistributor;

	private float _playedCardReplayDelay;

	private JackarooOptionsPanel _jackarooOptionsPanel;

	private BurnOtherCardPanel _burnOtherCardPanel;

	private JackarooActionTipPanel _jackarooActionTipPanel;

	private int <CardIndex>k__BackingField;

	public JackarooBoardMono Board
	{
		get
		{
			return <Board>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<Board>k__BackingField = value;
			object obj = this + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SpriteRenderer BoardEffectsSpriteRenderer
	{
		get
		{
			return <BoardEffectsSpriteRenderer>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<BoardEffectsSpriteRenderer>k__BackingField = value;
			object obj = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Camera BoardEffectsCamera
	{
		get
		{
			return <BoardEffectsCamera>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<BoardEffectsCamera>k__BackingField = value;
			object obj = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private int CardIndex
	{
		get
		{
			return <CardIndex>k__BackingField;
		}
		set
		{
			<CardIndex>k__BackingField = value;
		}
	}

	public override void HideControls()
	{
		//IL_004f: Expected I, but got O
		//IL_005f: Expected O, but got I
		//IL_006f: Expected O, but got I
		base.HideControls();
		_jackarooOptionsPanel.Hide();
		_burnOtherCardPanel.Dismiss();
		JackarooActionTipPanel jackarooActionTipPanel = _jackarooActionTipPanel;
		DOTweenAnimation fadeAnimation = jackarooActionTipPanel._fadeAnimation;
		nint num = (nint)fadeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v47 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ShowActionsOptionsPanel(List<JackarooMove> moves, Action<JackarooActions> onSelectedAction)
	{
		_jackarooOptionsPanel.ShowActionsOptions(moves, onSelectedAction);
	}

	public void HideActionsOptionsPanel()
	{
		_jackarooOptionsPanel.Hide();
	}

	public void ShowBurnOtherCardPanel(List<Card> cards, Userbox userbox, Action onCardClicked)
	{
		_burnOtherCardPanel.Show(cards, userbox, onCardClicked);
	}

	private void HideBurnOtherCardPanel()
	{
		_burnOtherCardPanel.Dismiss();
	}

	public void ShowActionTipPanel(string tip)
	{
		//IL_003b: Expected I, but got O
		//IL_004b: Expected O, but got I
		//IL_005b: Expected O, but got I
		JackarooActionTipPanel jackarooActionTipPanel = _jackarooActionTipPanel;
		TextMeshProExtensions.Localize(jackarooActionTipPanel._tipText, tip);
		DOTweenAnimation fadeAnimation = jackarooActionTipPanel._fadeAnimation;
		nint num = (nint)fadeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v37 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void HideActionTip()
	{
		//IL_0029: Expected I, but got O
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		JackarooActionTipPanel jackarooActionTipPanel = _jackarooActionTipPanel;
		DOTweenAnimation fadeAnimation = jackarooActionTipPanel._fadeAnimation;
		nint num = (nint)fadeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v2 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void ShowPickerPanel(JackarooMarbleMono hitMarble, List<JackarooMarbleMono> marbles, Action onDismiss)
	{
		gameEventChannel.TriggerDisplayZoomInPicker(hitMarble, marbles, onDismiss);
	}

	private void HidePickerPanel()
	{
		gameEventChannel.TriggerHideZoomInPicker();
	}

	public void ShowTipsPanel(Card card, JackarooAllowedRules allowedRules)
	{
		gameEventChannel.TriggerDisplayCardTip(card, allowedRules);
	}

	public void HideTipsPanel()
	{
		gameEventChannel.TriggerHideCardTip();
	}

	public void SetTheme(JackarooThemeData theme)
	{
		<Board>k__BackingField.SetThemeAndApply(theme);
	}

	public unsafe void SetTheme(Color? bottom = null, Color? left = null, Color? top = null, Color? right = null, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool? colorizeNodes = null, Color? nodeDefaultColor = null, Color? nodeSelectedColor = null, Color? highlightDefaultColor = null, bool? highlightLastNode = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0071: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_0095: Expected O, but got Ref
		//IL_00a3: Expected O, but got Ref
		//IL_00b1: Expected O, but got Ref
		//IL_00bf: Expected O, but got Ref
		//IL_0112: Expected O, but got Ref
		//IL_0112: Expected O, but got Ref
		//IL_0112: Expected O, but got Ref
		//IL_0112: Expected O, but got I
		//IL_0112: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bottom @ X1 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [left @ X2 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ X3 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [right @ X4 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+20]");
		bool? colorizeNodes2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+40]");
		bool? highlightLastNode2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Color? bottom2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Color? left2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		Color? top2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
		Color? right2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		JackarooBoardMono jackarooBoardMono = <Board>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+18]");
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		jackarooBoardMono.SetTheme(bottom2, left2, top2, right2, boardSprite, bottomMarble, leftMarble, (Sprite)num, (Sprite)0, colorizeNodes2, (Color?)(object)(&obj3), (Color?)(object)(&obj4), (Color?)(object)(&obj5), highlightLastNode2);
	}

	public unsafe void SetThemeAndApply(Color? bottom = null, Color? left = null, Color? top = null, Color? right = null, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool? colorizeNodes = null, Color? nodeDefaultColor = null, Color? nodeSelectedColor = null, Color? highlightDefaultColor = null, bool? highlightLastNode = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0042: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_00b1: Expected O, but got Ref
		//IL_00bf: Expected O, but got Ref
		//IL_00cd: Expected O, but got Ref
		//IL_00db: Expected O, but got Ref
		//IL_0131: Expected O, but got Ref
		//IL_0131: Expected O, but got Ref
		//IL_0131: Expected O, but got Ref
		//IL_0131: Expected O, but got I
		//IL_0131: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		JackarooBoardMono jackarooBoardMono = <Board>k__BackingField;
		JackarooTheme defaultTheme = jackarooBoardMono._defaultTheme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+40]");
		bool? highlightLastNode2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+20]");
		bool? colorizeNodes2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bottom @ X1 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [left @ X2 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ X3 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [right @ X4 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Color? bottom2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Color? left2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		Color? top2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
		Color? right2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		JackarooThemeData <ThemeData>k__BackingField = defaultTheme.<ThemeData>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+18]");
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		JackarooThemeData themeAndApply = JackarooThemeDataExtensions.With(<ThemeData>k__BackingField, bottom2, left2, top2, right2, boardSprite, bottomMarble, leftMarble, (Sprite)num, (Sprite)0, colorizeNodes2, (Color?)(object)(&obj3), (Color?)(object)(&obj4), (Color?)(object)(&obj5), highlightLastNode2);
		jackarooBoardMono.SetThemeAndApply(themeAndApply);
	}

	protected override void Init()
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0110: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_0139: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_007b: Expected O, but got I4
		//IL_01b6: Expected I, but got O
		//IL_01dc: Expected I, but got O
		//IL_00af: Expected O, but got I
		base.Init();
		bool flag = (object)_cardDistributor == null;
		CardGame cardGame = null;
		if (!flag)
		{
			cardGame = (CardGame)_game;
			if ((object)_game != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v4 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+130]");
				bool flag2 = num2 < 0;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v4 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v8+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X9_v6-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00d6;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_00d6;
		}
		goto IL_00f0;
		IL_00f0:
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)472;
		_game.OnRoundStart += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 672;
		object obj10 = (nint)0 + (nint)464;
		_game.OnGameInitialized += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ScriptableRenderContext, object> action3 = default(Action<ScriptableRenderContext, object>);
		action3..ctor((object)this, (IntPtr)obj10);
		RenderPipelineManager.beginCameraRendering -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ScriptableRenderContext, object> action4 = default(Action<ScriptableRenderContext, object>);
		action4..ctor((object)this, (IntPtr)obj10);
		RenderPipelineManager.beginCameraRendering += action4;
		return;
		IL_00d6:
		_cardDistributor.Setup(cardGame, allUserboxes);
		goto IL_00f0;
	}

	private void ClearBoardEffectsMask(ScriptableRenderContext context, Camera renderingCamera)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F5D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <BoardEffectsCamera>k__BackingField;
			obj6 = <BoardEffectsCamera>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = <BoardEffectsCamera>k__BackingField;
			obj6 = <BoardEffectsCamera>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = renderingCamera != obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			goto IL_0170;
		}
		return;
		IL_0170:
		RenderTexture targetTexture = <BoardEffectsCamera>k__BackingField.targetTexture;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (targetTexture == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = targetTexture == null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 != null)
			{
				return;
			}
		}
		RenderTexture active = RenderTexture.active;
		RenderTexture targetTexture2 = <BoardEffectsCamera>k__BackingField.targetTexture;
		RenderTexture.active = targetTexture2;
		GL.Clear(clearDepth: true, clearColor: true, (Color)0);
		RenderTexture.active = active;
		return;
		IL_0091:
		bool flag7 = renderingCamera != obj5;
		bool flag8 = !flag7;
		obj9 = 0;
		if (!flag8)
		{
			return;
		}
		goto IL_0170;
	}

	protected override void OnGameStateUpdated()
	{
		//IL_0063: Expected O, but got I4
		if ((object)_cardDistributor != null)
		{
			_cardDistributor.CheckAndTriggerNextBatch();
		}
		base.OnGameStateUpdated();
		bool isSpectator = _game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		KPlayer myPlayer = _game.MyPlayer;
		if (myPlayer == null)
		{
			return;
		}
		KPlayer myPlayer2 = _game.MyPlayer;
		SeatStatus seatStatus = myPlayer2.SeatStatus;
		if (seatStatus == SeatStatus.Idle)
		{
			KGame game = _game;
			LastActionInfo <LastAction>k__BackingField = game.<LastAction>k__BackingField;
			KPlayer myPlayer3 = game.MyPlayer;
			if (<LastAction>k__BackingField.<ActionPlayer>k__BackingField == myPlayer3.<Index>k__BackingField)
			{
				_jackarooOptionsPanel.Hide();
				_burnOtherCardPanel.Dismiss();
				JackarooActionTipPanel jackarooActionTipPanel = _jackarooActionTipPanel;
				jackarooActionTipPanel._fadeAnimation.DOPlayBackwards();
				gameEventChannel.TriggerHideZoomInPicker();
				gameEventChannel.TriggerHideCardTip();
			}
		}
	}

	private void OnGameInitialized()
	{
		//IL_0111: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_007b: Expected O, but got I4
		//IL_00af: Expected O, but got I
		bool flag = (object)_cardDistributor == null;
		IntPtr intPtr = default(IntPtr);
		CardGame cardGame = (CardGame)(nint)intPtr;
		if (!flag)
		{
			cardGame = (CardGame)_game;
			if ((object)_game != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v3 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+130]");
				bool flag2 = num2 < 0;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X9_v3 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v7+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v6-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00d6;
					}
				}
				throw new InvalidCastException();
			}
			goto IL_00d6;
		}
		goto IL_00ea;
		IL_00ea:
		PlayPlayersPlayedCard();
		return;
		IL_00d6:
		_cardDistributor.InitMidGame(cardGame);
		goto IL_00ea;
	}

	private void PlayPlayersPlayedCard()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		JackarooGame game = (JackarooGame)_game;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj2 = obj;
		nint num = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v2 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v2 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v5-8]");
			if (0 == (nint)obj2)
			{
				List<Card> <OrderedPlayedCards>k__BackingField = ((CardGame)game).<OrderedPlayedCards>k__BackingField;
				if (((CardGame)game).<OrderedPlayedCards>k__BackingField != null && <OrderedPlayedCards>k__BackingField._size >= 1)
				{
					HandleOrderedPlayedCards(game);
				}
				else
				{
					HandleSinglePlayedCard(game);
				}
				return;
			}
		}
		InvalidCastException ex = new InvalidCastException();
		throw new NullReferenceException();
	}

	private void HandleOrderedPlayedCards(JackarooGame jackarooGame)
	{
		//IL_0024: Expected O, but got I
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c7: Expected I, but got O
		//IL_01d8: Expected I, but got O
		//IL_0207: Expected O, but got I4
		//IL_0083: Expected F4, but got I4
		List<int> <OrderedPlayIndex>k__BackingField = ((CardGame)jackarooGame).<OrderedPlayIndex>k__BackingField;
		object obj = (nint)0 + (nint)2760;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1744;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		JackarooGame jackarooGame2 = jackarooGame;
		int num2 = 0;
		<>c__DisplayClass43_0 <>c__DisplayClass43_ = default(<>c__DisplayClass43_0);
		Action action = default(Action);
		while (true)
		{
			int num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			if ((nint)num3 < (nint)0)
			{
				object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				<>c__DisplayClass43_..ctor();
				object obj6 = <>c__DisplayClass43_ + 32;
				obj6 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				int index = ((CardGame)jackarooGame).<OrderedPlayIndex>k__BackingField.get_Item(num2);
				KPlayer playerByIndex = jackarooGame.GetPlayerByIndex(index);
				object obj7 = <>c__DisplayClass43_ + 24;
				obj7 = playerByIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj8 = ((List<object>)(object)((CardGame)jackarooGame).<OrderedPlayedCards>k__BackingField).get_Item(num2);
				object obj9 = <>c__DisplayClass43_ + 16;
				obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				num = (nint)obj3;
				action..ctor(<>c__DisplayClass43_, (IntPtr)obj3);
				object obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v24+E4]");
				bool flag = (nint)0 == 0;
				object obj11 = !flag;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds(num2, action);
				int num4 = num2 + 1;
				<OrderedPlayIndex>k__BackingField = ((CardGame)jackarooGame).<OrderedPlayIndex>k__BackingField;
				jackarooGame2 = null;
				num2 = num4;
				continue;
			}
			break;
		}
	}

	private void HandleSinglePlayedCard(JackarooGame jackarooGame)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_018e: Expected O, but got I4
		//IL_0197: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_021a: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_0234: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0268: Expected I, but got O
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected I4, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected I4, but got Unknown
		//IL_02c2: Expected I, but got O
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0342: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_036d: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0426: Expected O, but got I4
		//IL_0444: Expected O, but got I
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_0462: Expected O, but got I
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected O, but got Unknown
		//IL_04dc: Expected I, but got O
		//IL_04ed: Expected I, but got O
		//IL_051c: Expected O, but got I4
		//IL_03a8: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass44_0 <>c__DisplayClass44_ = default(<>c__DisplayClass44_0);
		<>c__DisplayClass44_..ctor();
		JackarooPlayer[] <JackarooPlayers>k__BackingField;
		string text;
		object obj4;
		int lastPlayerIndex;
		IEnumerable<object> source;
		if (<>c__DisplayClass44_ != null)
		{
			object obj2 = <>c__DisplayClass44_ + 24;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)jackarooGame != null)
			{
				object obj3 = "___# Content push apply failed [{0}]: {1}" + 2672;
				JackarooLastActionInfo <LastAction>k__BackingField = jackarooGame.<LastAction>k__BackingField;
				JackarooPlayer[] <JackarooPlayers>k__BackingField2;
				if (jackarooGame.<LastAction>k__BackingField != null)
				{
					<JackarooPlayers>k__BackingField = jackarooGame.<JackarooPlayers>k__BackingField;
					text = (string)obj3;
					bool flag = ((LastActionInfo)<LastAction>k__BackingField).<Action>k__BackingField == (string)obj3;
					bool flag2 = !flag;
					obj4 = 0;
					object obj5 = 0;
					<JackarooPlayers>k__BackingField2 = jackarooGame.<JackarooPlayers>k__BackingField;
					string text2 = (string)obj3;
					if (!flag2)
					{
						goto IL_00fc;
					}
				}
				else
				{
					<JackarooPlayers>k__BackingField2 = jackarooGame.<JackarooPlayers>k__BackingField;
					text = (string)obj3;
					bool flag3 = null == (string)obj3;
					bool flag4 = !flag3;
					object obj6 = !flag4;
					obj4 = 0;
					<JackarooPlayers>k__BackingField = jackarooGame.<JackarooPlayers>k__BackingField;
					object obj5 = 0;
					string text2 = (string)obj3;
					if (obj6 != null)
					{
						goto IL_00fc;
					}
				}
				lastPlayerIndex = ((CardGame)jackarooGame).<Dealer>k__BackingField;
				bool flag5 = ((CardGame)jackarooGame).<Dealer>k__BackingField < 1;
				source = <JackarooPlayers>k__BackingField2;
				if (!flag5)
				{
					goto IL_01fa;
				}
				return;
			}
		}
		goto IL_053a;
		IL_053a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0548;
		IL_00fc:
		JackarooLastActionInfo <LastAction>k__BackingField2 = jackarooGame.<LastAction>k__BackingField;
		if (jackarooGame.<LastAction>k__BackingField != null)
		{
			lastPlayerIndex = ((LastActionInfo)<LastAction>k__BackingField2).<ActionPlayer>k__BackingField;
			object obj5 = obj4;
			source = <JackarooPlayers>k__BackingField;
			string text2 = text;
			goto IL_01fa;
		}
		goto IL_053a;
		IL_0548:
		throw new IndexOutOfRangeException();
		IL_01fa:
		object obj7 = typeof(List<Tween>) + 3296;
		object obj8 = (nint)0 + (nint)1752;
		object obj9 = (nint)0 + (nint)3496;
		object obj10 = (nint)0 + (nint)3152;
		object obj11 = (nint)0 + (nint)1360;
		<>c__DisplayClass44_.lastPlayerIndex = lastPlayerIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)<>c__DisplayClass44_, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3180C34");
		object obj12 = default(object);
		int count = obj12 + 1;
		IEnumerable<object> enumerable = Enumerable.Skip(source, count);
		int count2 = obj12 + 1;
		IEnumerable<object> enumerable2 = Enumerable.Take(source, count2);
		nint num = (nint)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D95D88");
		object obj13 = obj11;
		IEnumerable<object> source2 = default(IEnumerable<object>);
		object[] array = Enumerable.ToArray(source2);
		if (array != null)
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj14 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 488;
			object obj15 = (nint)0 + (nint)1760;
			object obj16 = array + 32;
			object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj18 = 0;
			object obj19 = 0;
			<>c__DisplayClass44_1 <>c__DisplayClass44_2 = default(<>c__DisplayClass44_1);
			Action action = default(Action);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				<>c__DisplayClass44_2..ctor();
				if (<>c__DisplayClass44_2 == null)
				{
					break;
				}
				object obj20 = <>c__DisplayClass44_2 + 24;
				obj20 = <>c__DisplayClass44_;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag6 = (nint)obj19 < array.Length;
				object obj21 = !flag6;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X28_v5+v100 @ X24_v8*8]");
					obj13 = 0;
					object obj22 = <>c__DisplayClass44_2 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X28_v5+v100 @ X24_v8*8]");
					obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj23 = obj22;
					if (obj22 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v12+40]");
					if ((nint)0 != 0)
					{
						object obj24 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						num = (nint)obj15;
						action..ctor(<>c__DisplayClass44_2, (IntPtr)obj15);
						object obj25 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v35+E4]");
						bool flag7 = (nint)0 == 0;
						object obj26 = !flag7;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						float seconds = _playedCardReplayDelay * 0f;
						Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
						obj18 = 0;
						obj13 = 0;
					}
					obj19++;
					if ((nint)obj19 >= array.Length)
					{
						return;
					}
					continue;
				}
				goto IL_0548;
			}
		}
		goto IL_053a;
	}

	protected override void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01a0: Expected I, but got O
		//IL_0165: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00de: Expected I, but got O
		//IL_010d: Expected O, but got I
		//IL_011b: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 672;
		object obj2 = (nint)0 + (nint)464;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		base.OnDestroy();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<ScriptableRenderContext, object> action = default(Action<ScriptableRenderContext, object>);
		action..ctor((object)this, (IntPtr)obj2);
		RenderPipelineManager.beginCameraRendering -= action;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _game != null;
			bool flag2 = !flag;
			UnityEngine.Object obj5 = null;
			object obj6 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _game != null;
			bool flag4 = !flag3;
			object obj7 = !flag4;
			UnityEngine.Object obj5 = null;
			object obj6 = 0;
			if (obj7 == null)
			{
				return;
			}
		}
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		_game.OnRoundStart -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)472;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		_game.OnGameInitialized -= action3;
	}

	private void RemoveCards()
	{
		//IL_02be: Expected I4, but got I8
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		<CardIndex>k__BackingField = -1;
		KGame game = _game;
		if ((object)_game == null)
		{
			goto IL_029a;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj2 = obj;
		nint num = (nint)game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X1_v3+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		Userbox activeUserbox;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X1_v3+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2 (KGame)+158]");
				int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(0, 1, 1, 5);
				if ((object)_game != null)
				{
					object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
					KPlayer playerByIndex = _game.GetPlayerByIndex(rotatedNextIndex);
					activeUserbox = GetActiveUserbox(playerByIndex);
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+E4]");
					if ((nint)0 != 0)
					{
						bool flag2 = _cardDistributor != null;
						bool flag3 = !flag2;
						object obj8 = !flag3;
						if (obj8 != null)
						{
							goto IL_01c8;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						if (_cardDistributor != null)
						{
							goto IL_01c8;
						}
					}
					goto IL_026b;
				}
				goto IL_029a;
			}
		}
		goto IL_02a8;
		IL_02a8:
		throw new InvalidCastException();
		IL_01c8:
		Transform eatingPoint;
		if ((object)_cardDistributor != null)
		{
			if (!_cardDistributor.GroundCardsGoToPile)
			{
				goto IL_026b;
			}
			if ((object)_cardDistributor != null)
			{
				Transform pileTopCardTransform = _cardDistributor.PileTopCardTransform;
				if ((object)activeUserbox != null)
				{
					eatingPoint = pileTopCardTransform;
					goto IL_02e7;
				}
			}
		}
		goto IL_029a;
		IL_026b:
		if ((object)activeUserbox == null)
		{
			goto IL_029a;
		}
		eatingPoint = activeUserbox.eatingPoint;
		goto IL_02e7;
		IL_029a:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02a8;
		IL_02e7:
		EatCards(activeUserbox.<player>k__BackingField, eatingPoint, activeUserbox.<CurrentCardBack>k__BackingField, playImmediately: false);
	}

	protected unsafe override void AdjustOpponentCardStart(ref Vector3 originalPosition, ref Vector3 originalRotation, Transform startingPoint, KPlayer player, float randSlide, bool isEventFromServer)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_02ef: Expected O, but got I
		//IL_0307: Expected F4, but got I
		//IL_032a: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0583: Expected O, but got I4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_05a9: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_0163: Expected F4, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0234: Expected O, but got I4
		//IL_0245: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_02a1: Expected O, but got I
		//IL_03fb: Expected Ref, but got F4
		//IL_00a7: Expected F4, but got I4
		//IL_0488: Expected O, but got I
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_02c1: Expected O, but got I4
		//IL_02d2: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_04ef: Expected O, but got I4
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected O, but got Unknown
		//IL_0517: Expected O, but got I4
		//IL_0520: Expected O, but got I4
		//IL_0531: Expected O, but got I4
		//IL_053a: Expected O, but got I4
		//IL_054b: Expected O, but got I4
		//IL_01a7: Expected O, but got I
		//IL_042b: Expected O, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0451: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_00eb: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		Userbox activeUserbox = GetActiveUserbox(player);
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v4+8]");
		float num = 0f;
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = !isTablet;
		object obj5 = !flag;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 360;
		}
		else
		{
			object obj7 = 356;
		}
		float num2;
		object obj11;
		float num5;
		object obj12;
		object obj9;
		object obj13;
		object obj14;
		ref Vector3 reference;
		if (activeUserbox.direction <= Userbox.UserBoxDirection.Right)
		{
			if (activeUserbox.direction != Userbox.UserBoxDirection.Bottom)
			{
				bool flag2 = activeUserbox.direction != Userbox.UserBoxDirection.Right;
				num2 = 0f;
				if (flag2)
				{
					goto IL_0341;
				}
				if (isEventFromServer)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooCardGameVisualControls)+v89 @ X8_v6]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalRotation @ X2 (UnityEngine.Vector3&)+8]");
					object obj8 = num3 + 0;
					reference = ref *(Vector3*)originalRotation;
				}
				float num4 = UnityEngine.Random.Range(-1.5f, 1.5f);
				obj9 = 146599936 + 215;
				object obj10 = obj9 & 1;
				bool flag3 = obj10 == null;
				obj11 = 60;
				num5 = num4;
				obj12 = 68;
				if (flag3)
				{
					goto IL_01be;
				}
				obj13 = 60;
				num2 = num4;
				obj14 = 68;
			}
			else
			{
				float num6 = UnityEngine.Random.Range(-1f, 1f);
				obj9 = 146599936 + 219;
				object obj15 = obj9 & 1;
				bool flag4 = obj15 == null;
				obj11 = 36;
				num5 = num6;
				obj12 = 44;
				if (flag4)
				{
					goto IL_01be;
				}
				obj13 = 36;
				num2 = num6;
				obj14 = 44;
			}
		}
		else if (activeUserbox.direction != Userbox.UserBoxDirection.Top)
		{
			bool flag5 = activeUserbox.direction != Userbox.UserBoxDirection.Left;
			num2 = 0f;
			if (flag5)
			{
				goto IL_0341;
			}
			if (isEventFromServer)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalRotation @ X2 (UnityEngine.Vector3&)+8]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooCardGameVisualControls)+v89 @ X8_v6]");
				object obj16 = num7 - 0;
				reference = ref *(Vector3*)originalRotation;
			}
			float num8 = UnityEngine.Random.Range(-1.5f, 1.5f);
			obj9 = 146599936 + 220;
			object obj17 = obj9 & 1;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			obj11 = 48;
			num5 = num8;
			obj12 = 56;
			obj13 = 48;
			num2 = num8;
			obj14 = 56;
			if (obj18 == null)
			{
				goto IL_01be;
			}
		}
		else
		{
			if (isEventFromServer)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalRotation @ X2 (UnityEngine.Vector3&)+8]");
				object obj19 = (nint)0 + (nint)1127481344;
				reference = ref *(Vector3*)originalRotation;
			}
			float num9 = UnityEngine.Random.Range(-1f, 1f);
			obj9 = 146599936 + 201;
			object obj20 = obj9 & 1;
			bool flag7 = obj20 == null;
			obj11 = 24;
			num5 = num9;
			obj12 = 32;
			if (flag7)
			{
				goto IL_01be;
			}
			obj13 = 24;
			num2 = num9;
			obj14 = 32;
		}
		goto IL_0470;
		IL_0470:
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10+v212 @ X26_v1]");
		object obj23 = default(object);
		obj4 = 0 * obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10+v239 @ X22_v2]");
		num = 0f * cardLandingPositionOffset;
		goto IL_0341;
		IL_01be:
		obj9 = 1;
		obj13 = obj11;
		num2 = num5;
		obj14 = obj12;
		goto IL_0470;
		IL_0341:
		float num10 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalPosition @ X1 (UnityEngine.Vector3&)+8]");
		float num11 = num10 + 0f;
		object obj24 = obj4 + (object)originalPosition;
		ref Vector3 reference2 = ref *(Vector3*)obj24;
		float num12 = randSlide * 0f;
		float num13 = randSlide * num2;
		float num14 = num12 * 0.5f;
		float num15 = num13 * 0.5f;
		float num16 = num15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [originalRotation @ X2 (UnityEngine.Vector3&)+8]");
		float num17 = num16 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		float num18 = num14 + (float)originalRotation;
		reference = ref *(Vector3*)num18;
	}

	protected override Vector3 GetServerEventStartingScale(Transform startingPoint)
	{
		return (Vector3)(((object?)startingPoint?.localScale) ?? ((object)new NullReferenceException()));
	}

	protected override int GetPlayerSlotIndex(KPlayer player)
	{
		return <CardIndex>k__BackingField;
	}

	public unsafe override void PlayCard(Card card, CardGamePlayer player, Transform startingPoint, bool isEventFromServer, bool withCollision, int? gameActionId, int floorLayer, bool playImmediately, bool hideStartingPoint)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0031: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		SpriteRenderer[] array = playingCardsSprites;
		int num = <CardIndex>k__BackingField;
		object obj3 = array.Length - 1;
		bool flag = <CardIndex>k__BackingField != (nint)obj3;
		CardGameVisualControls cardGameVisualControls = this;
		if (!flag)
		{
			RemoveCards();
			num = <CardIndex>k__BackingField;
			cardGameVisualControls = this;
		}
		object obj4 = num + 1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+11]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
		Card card2 = default(Card);
		CardGamePlayer player2 = default(CardGamePlayer);
		Transform startingPoint2 = default(Transform);
		bool isEventFromServer2 = default(bool);
		bool withCollision2 = default(bool);
		int? gameActionId2 = default(int?);
		int floorLayer2 = default(int);
		cardGameVisualControls.PlayCard(card2, player2, startingPoint2, isEventFromServer2, withCollision2, gameActionId2, floorLayer2, playImmediately, hideStartingPoint);
	}

	protected override SpriteRenderer GetCardSprite(KPlayer player)
	{
		//IL_0052: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		SpriteRenderer[] array = playingCardsSprites;
		int playerSlotIndex = GetPlayerSlotIndex(player);
		if (playingCardsSprites != null)
		{
			bool flag = playerSlotIndex < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = playingCardsSprites + playerSlotIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v4+20]");
				return (SpriteRenderer)0;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (SpriteRenderer)(object)new IndexOutOfRangeException();
	}

	protected override int FloorCardsNumber(int _)
	{
		return <CardIndex>k__BackingField;
	}

	protected override void ResetPlayedCards()
	{
		//IL_000f: Expected I4, but got I8
		<CardIndex>k__BackingField = -1;
		base.ResetPlayedCards();
	}

	protected override void OnGamePerspectiveChanged(bool isTopDown)
	{
		//IL_0085: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_00a5: Expected F8, but got I4
		//IL_00d3: Expected F8, but got I4
		//IL_0190: Expected O, but got I4
		//IL_00c5: Expected F8, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_00e1: Expected F8, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0101: Expected F4, but got I4
		//IL_0219: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		base.OnGamePerspectiveChanged(isTopDown);
		bool isTablet = ScreenUtility.IsTablet;
		bool isTablet2 = ScreenUtility.IsTablet;
		bool isTablet3 = ScreenUtility.IsTablet;
		bool isTablet4 = ScreenUtility.IsTablet;
		if ((object)_cardDistributor != null)
		{
			_cardDistributor.SetPerspective(isTopDown);
		}
		bool flag = !isTablet4;
		object obj = !flag;
		object obj2 = ~obj;
		double num = ((obj2 != null) ? 1.0 : 1066192077.0);
		bool flag2 = !isTablet2;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		double num2 = ((obj4 != null) ? 1125515264.0 : 1127153664.0);
		bool flag3 = !isTablet;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		double num3 = ((obj6 != null) ? 20.0 : 1110704128.0);
		int num4 = ShortcutExtensions.DOKill(base.playGround);
		bool flag4 = !isTopDown;
		object obj7 = !flag4;
		object obj8 = ~obj7;
		float duration = ((obj8 != null) ? 27f : 0f);
		object obj9 = !flag4;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			num2 = num3;
		}
		object obj11 = !flag4;
		object obj12 = ~obj11;
		double num5 = ((obj12 != null) ? num : 1.0);
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(base.playGround, (Vector3)0, duration);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOLocalMoveY(base.playGround, (float)num2, 0.2f);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(base.playGround, (float)num5, 0.2f);
	}

	public JackarooCardGameVisualControls()
	{
		//IL_0012: Expected F4, but got I
		//IL_0037: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72532A0]");
		cardLandingPositionOffset = 0f;
		opponentCardSideRotationAngleTablet = 90f;
		_playedCardReplayDelay = 0.5f;
		<CardIndex>k__BackingField = -1;
		base..ctor();
	}
}
