using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class Userbox : MonoBehaviour
{
	public enum UserBoxDirection
	{
		Bottom,
		Right,
		Top,
		Left
	}

	private sealed class <>c__DisplayClass115_0
	{
		public Userbox <>4__this;

		public bool isDealer;

		internal void <SetDealer>b__0()
		{
			Userbox userbox = <>4__this;
			userbox.dealerObject.SetActive(isDealer);
		}
	}

	private sealed class <>c__DisplayClass120_0
	{
		public Sprite defaultCardBack;

		internal void <ResetDefaultCardBacks>b__0(SpriteRenderer card)
		{
			card.sprite = defaultCardBack;
		}
	}

	private const float ShownCardsSpacing = 70f;

	private const float HiddenCardsSpacing = 30f;

	private const float CardExtraTilt = 8f;

	private bool isPlayerPrefab;

	public UserBoxDirection direction;

	protected SpritesStore spritesStore;

	protected CardsSprites cardsSprites;

	protected CardBacksSprites cardbackSprites;

	private GameObject emptyCaseObject;

	private GameObject filledCaseObject;

	private GameObject ownerBadge;

	private Button SitHereButton;

	private TextMeshProUGUI EnteringText;

	private AvatarInitializer avatarInitializer;

	private GameObject avatarImageBackground;

	private EmoteViewer emoteViewer;

	private GameObject emoteImage;

	private Image highlight;

	private SwipeWheel swipeWheel;

	private SpriteRenderer[] cardBacks;

	private Transform eatingPoint;

	protected CardsRevealer cardsRevealer;

	private GameEventsChannel gameEventsChannel;

	private Sprite <CurrentCardBack>k__BackingField;

	public GameObject betObject;

	public TextMeshProUGUI betText;

	public Image betImage;

	public RectTransform betContainer;

	protected Vector2 betContainerSize;

	public Timer timer;

	public GameObject dealerObject;

	public RectTransform dealerContainer;

	private Vector2 dealerContainerSize;

	public GameObject gameBubble;

	public TextMeshProUGUI bubbleText;

	public Image chatBubble;

	public TextMeshProUGUI chatBubbleText;

	private GameObject muteIndicator;

	private Image soundIndicator;

	private Image glowEffect;

	private GiftsShowcase giftsShowcase;

	private GameObject animatedGiftStoreParent;

	public GameObject giftsButtonHolder;

	public Button sendGiftButton;

	protected Canvas canvas;

	private Transform <handRoot>k__BackingField;

	protected SlideAnimationHelper uiSlider;

	private float _restingLocalScale = 1f;

	private Action m_OnUserRefreshed;

	private bool _isDealAnimating;

	private CardGamePlayer <player>k__BackingField;

	public Vector3 originalHandRootScale;

	protected CardGame game;

	protected CardGameVisualControls gameVisualControls;

	protected VivoxManager voiceChatManager;

	protected bool isMyUserbox;

	protected Image bubbleImage;

	private Sequence voiceIndicatorColorSequence;

	public Transform EatingPoint => eatingPoint;

	public SpriteRenderer[] BackCards => cardBacks;

	public CardsRevealer CardsRevealer => cardsRevealer;

	public EmoteViewer EmoteViewer => emoteViewer;

	public Sprite CurrentCardBack
	{
		get
		{
			return <CurrentCardBack>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 184;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Transform handRoot
	{
		get
		{
			return <handRoot>k__BackingField;
		}
		set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<handRoot>k__BackingField = value;
			object obj = this + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardGamePlayer player
	{
		get
		{
			return <player>k__BackingField;
		}
		private set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<player>k__BackingField = value;
			object obj = this + 408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public event Action<Userbox, Sprite> OnCardBackLoaded
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 792;
			object obj2 = this + 192;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 792;
			object obj2 = this + 192;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action OnUserRefreshed
	{
		add
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			Delegate obj2 = this.m_OnUserRefreshed;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				if ((object)obj3 == null || obj3 == obj)
				{
					object obj4 = this + 392;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj2;
					obj2 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			Delegate obj2 = this.m_OnUserRefreshed;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				if ((object)obj3 == null || obj3 == obj)
				{
					object obj4 = this + 392;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj2;
					obj2 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	protected virtual void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_05df: Expected O, but got I
		//IL_05eb: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_0621: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I
		//IL_01d3: Expected O, but got I
		//IL_01e9: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_02f8: Expected O, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_041a: Expected O, but got I4
		//IL_0449: Expected O, but got I
		//IL_037a: Expected O, but got I4
		//IL_047a: Expected O, but got I4
		//IL_04ae: Expected O, but got I4
		//IL_04b7: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_04d3: Expected O, but got I4
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_057d: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_05a8: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = (nint)0 + (nint)32;
		object obj4 = (nint)0 + (nint)248;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGame cardGame = default(CardGame);
		game = cardGame;
		object obj7 = this + 432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		CardGameVisualControls cardGameVisualControls = default(CardGameVisualControls);
		gameVisualControls = cardGameVisualControls;
		object obj8 = this + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		VivoxManager vivoxManager = default(VivoxManager);
		voiceChatManager = vivoxManager;
		object obj9 = this + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((bool)sendGiftButton)
		{
			GameObject gameObject = sendGiftButton.gameObject;
			gameObject.SetActive(value: false);
		}
		object obj10 = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Image image = default(Image);
		bubbleImage = image;
		object obj11 = this + 464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Vector3 localScale = <handRoot>k__BackingField.localScale;
		Vector3 vector = default(Vector3);
		originalHandRootScale = vector;
		bool flag2 = !isMyUserbox;
		object obj12 = !flag2;
		object obj16 = default(object);
		if (obj12 == null)
		{
			Transform transform = base.transform;
			object obj13 = typeof(UsageHint) + 816;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v26+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27+4]");
			obj16 = 0;
			vector = (Vector3)obj15;
			transform.localScale = (Vector3)0;
		}
		GameObject gameObject2 = timer.gameObject;
		gameObject2.SetActive(value: false);
		dealerObject.SetActive(value: false);
		ownerBadge.SetActive(value: false);
		GameObject gameObject3 = cardsRevealer.gameObject;
		gameObject3.SetActive(value: false);
		gameBubble.SetActive(value: false);
		GameObject gameObject4 = chatBubble.gameObject;
		gameObject4.SetActive(value: false);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
		Vector2 vector2;
		if ((nint)0 != 0)
		{
			bool flag3 = dealerContainer;
			bool flag4 = !flag3;
			object obj18 = !flag4;
			vector2 = (Vector2)0;
			if (obj18 == null)
			{
				goto IL_0306;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = dealerContainer;
			bool flag6 = !flag5;
			vector2 = (Vector2)0;
			if (flag6)
			{
				goto IL_0306;
			}
		}
		Rect rect = dealerContainer.rect;
		object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v56+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27+8]");
		dealerContainerSize = (Vector2)0;
		RectTransform rectTransform = UIExtensions.rectTransform(dealerContainer);
		vector = dealerContainerSize;
		rectTransform.sizeDelta = (Vector2)0;
		UnityEngine.Object obj22 = betContainer;
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v49+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		obj16 = 0;
		Vector3 vector3 = dealerContainerSize;
		object obj25 = 0;
		vector2 = (Vector2)0;
		UnityEngine.Object obj26 = betContainer;
		if (obj24 != null)
		{
			goto IL_0357;
		}
		goto IL_04eb;
		IL_0357:
		bool flag9 = obj22;
		bool flag10 = !flag9;
		object obj27 = !flag10;
		if (obj27 != null)
		{
			goto IL_0530;
		}
		goto IL_05ad;
		IL_05ad:
		bubbleText.isRightToLeftText = true;
		chatBubbleText.isRightToLeftText = true;
		return;
		IL_0306:
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v49+E4]");
		bool flag11 = (nint)0 == 0;
		obj22 = betContainer;
		vector3 = vector;
		obj25 = obj16;
		obj26 = betContainer;
		if (!flag11)
		{
			goto IL_0357;
		}
		goto IL_04eb;
		IL_04eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj26;
		bool flag13 = !flag12;
		vector = vector3;
		obj16 = obj25;
		if (!flag13)
		{
			goto IL_0530;
		}
		goto IL_05ad;
		IL_0530:
		Rect rect2 = betContainer.rect;
		object obj28 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v44+E4]");
		bool flag14 = (nint)0 == 0;
		object obj30 = !flag14;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27+8]");
		betContainerSize = (Vector2)0;
		RectTransform rectTransform2 = UIExtensions.rectTransform(betContainer);
		rectTransform2.sizeDelta = (Vector2)0;
		goto IL_05ad;
	}

	private void OnEnable()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0069: Expected I, but got O
		KGame kGame = game;
		if (kGame.<IsInitialized>k__BackingField)
		{
			OnGameInitialized();
			return;
		}
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = (nint)0 + (nint)464;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		kGame.OnGameInitialized += action;
	}

	private void OnDisable()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Userbox>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Userbox>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03ea: Expected I, but got O
		//IL_03ff: Expected I, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_008d: Expected I, but got O
		//IL_00b4: Expected O, but got I
		//IL_00e0: Expected I, but got O
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0131: Expected I, but got O
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0182: Expected I, but got O
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I
		//IL_01d3: Expected I, but got O
		//IL_01e4: Expected O, but got I
		//IL_0210: Expected I, but got O
		//IL_0221: Expected O, but got I
		//IL_024d: Expected I, but got O
		//IL_025e: Expected O, but got I
		//IL_028a: Expected I, but got O
		//IL_029b: Expected O, but got I
		//IL_02c7: Expected I, but got O
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_0318: Expected I, but got O
		//IL_0340: Expected I, but got O
		//IL_0367: Expected O, but got I
		//IL_0393: Expected I, but got O
		//IL_03a4: Expected O, but got I
		//IL_03d0: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		nint num = (nint)this;
		UnRegisterEventListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4 (Il2CppClass<Userbox>)+1E0]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj3 = (nint)0 + (nint)512;
		game.OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj3);
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v6 (Il2CppClass<Userbox>)+1D0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj4 = (nint)0 + (nint)496;
		game.OnRoundStart += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj6 = (nint)0 + (nint)504;
		game.OnRoundEnd += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
		object obj8 = (nint)0 + (nint)480;
		game.OnSawa += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj8);
		object obj9 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 696;
		object obj10 = (nint)0 + (nint)488;
		game.OnKasho += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, float?> action6 = default(Action<object, float?>);
		action6..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)544;
		voiceChatManager.OnSpeakingInChat += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)440;
		gameEventsChannel.ShowUi += action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)432;
		gameEventsChannel.HideUi += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action9 = default(Action);
		action9..ctor(this, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)552;
		gameEventsChannel.ShowGiftSelection += action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action10 = default(Action);
		action10..ctor(this, (IntPtr)obj14);
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj16 = (nint)0 + (nint)472;
		gameEventsChannel.HideGiftSelection += action10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action11 = default(Action<bool>);
		action11..ctor((object)this, (IntPtr)obj16);
		gameEventsChannel.OnGiftSelected += action11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v7 (Il2CppClass<Userbox>)+200]");
		Action<bool> action12 = default(Action<bool>);
		action12..ctor((object)this, (IntPtr)0);
		object obj17 = (nint)0 + (nint)456;
		gameEventsChannel.OnGamePerspectiveChanged += action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action13 = default(Action);
		action13..ctor(this, (IntPtr)obj17);
		object obj18 = (nint)0 + (nint)448;
		gameEventsChannel.OnDealBatchStarted += action13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action14 = default(Action);
		action14..ctor(this, (IntPtr)obj18);
		gameEventsChannel.OnDealBatchComplete += action14;
	}

	protected virtual void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_054d: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0085: Expected I, but got O
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_0114: Expected I, but got O
		//IL_013b: Expected O, but got I
		//IL_0167: Expected I, but got O
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Expected O, but got I
		//IL_01b8: Expected I, but got O
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I
		//IL_0209: Expected I, but got O
		//IL_0237: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_030b: Expected O, but got I
		//IL_0323: Expected I, but got O
		//IL_0334: Expected O, but got I
		//IL_0262: Expected O, but got I
		//IL_027a: Expected I, but got O
		//IL_0360: Expected I, but got O
		//IL_0371: Expected O, but got I
		//IL_02a2: Expected I, but got O
		//IL_039d: Expected I, but got O
		//IL_02d5: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_03da: Expected I, but got O
		//IL_03eb: Expected O, but got I
		//IL_0417: Expected I, but got O
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_043c: Expected O, but got I
		//IL_0468: Expected I, but got O
		//IL_0490: Expected I, but got O
		//IL_04b7: Expected O, but got I
		//IL_04e3: Expected I, but got O
		//IL_04f4: Expected O, but got I
		//IL_0520: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj2 = (nint)0 + (nint)528;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnPublicMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		game.OnGameInitialized -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v4 (Il2CppClass<Userbox>)+1E0]");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)0);
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj6 = (nint)0 + (nint)512;
		game.OnGameStateUpdated -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj6);
		game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v5 (Il2CppClass<Userbox>)+1D0]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		object obj7 = (nint)0 + (nint)496;
		game.OnRoundStart -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj9 = (nint)0 + (nint)504;
		game.OnRoundEnd -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj9);
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
		object obj11 = (nint)0 + (nint)480;
		game.OnSawa -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj11);
		game.OnKasho -= action7;
		bool flag = <player>k__BackingField == null;
		object obj12 = 0;
		Action action8 = (Action)(object)action7;
		object obj13 = 0;
		if (!flag)
		{
			object obj14 = (nint)0 + (nint)520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action9 = default(Action);
			action9..ctor(this, (IntPtr)obj14);
			<player>k__BackingField.OnUserChanged -= action9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v10 (Il2CppClass<Userbox>)+1F0]");
			Action action10 = default(Action);
			action10..ctor(this, (IntPtr)0);
			<player>k__BackingField.OnDidLastAction -= action10;
			obj12 = 0;
			action8 = action10;
			obj13 = 0;
		}
		object obj15 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 696;
		object obj16 = (nint)0 + (nint)488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, float?> action11 = default(Action<object, float?>);
		action11..ctor((object)this, (IntPtr)obj16);
		object obj17 = (nint)0 + (nint)544;
		voiceChatManager.OnSpeakingInChat -= action11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action12 = default(Action);
		action12..ctor(this, (IntPtr)obj17);
		object obj18 = (nint)0 + (nint)440;
		gameEventsChannel.ShowUi -= action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action13 = default(Action);
		action13..ctor(this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)432;
		gameEventsChannel.HideUi -= action13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action14 = default(Action);
		action14..ctor(this, (IntPtr)obj19);
		object obj20 = (nint)0 + (nint)552;
		gameEventsChannel.ShowGiftSelection -= action14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action15 = default(Action);
		action15..ctor(this, (IntPtr)obj20);
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj22 = (nint)0 + (nint)472;
		gameEventsChannel.HideGiftSelection -= action15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action16 = default(Action<bool>);
		action16..ctor((object)this, (IntPtr)obj22);
		gameEventsChannel.OnGiftSelected -= action16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v9 (Il2CppClass<Userbox>)+200]");
		Action<bool> action17 = default(Action<bool>);
		action17..ctor((object)this, (IntPtr)0);
		object obj23 = (nint)0 + (nint)456;
		gameEventsChannel.OnGamePerspectiveChanged -= action17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action18 = default(Action);
		action18..ctor(this, (IntPtr)obj23);
		object obj24 = (nint)0 + (nint)448;
		gameEventsChannel.OnDealBatchStarted -= action18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action19 = default(Action);
		action19..ctor(this, (IntPtr)obj24);
		gameEventsChannel.OnDealBatchComplete -= action19;
	}

	private void OnGameInitialized()
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011e: Expected I, but got O
		//IL_0141: Expected I, but got O
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_007f: Expected O, but got I4
		//IL_0169: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I
		//IL_01d0: Expected I, but got O
		//IL_01ea: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0219: Expected O, but got I
		//IL_0231: Expected I, but got O
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_0311: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_03a6: Expected I, but got O
		//IL_0344: Expected O, but got I
		//IL_0352: Expected I, but got O
		//IL_02d1: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_0407: Expected I, but got O
		//IL_0417: Expected O, but got I
		//IL_0427: Expected O, but got I
		KPlayer kPlayer = game.GetPlayer(this);
		if (kPlayer == null)
		{
			goto IL_00da;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 352;
		object obj2 = obj;
		nint num = (nint)kPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v9 (Il2CppClass<KPlayer>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X1_v28+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X9_v9 (Il2CppClass<KPlayer>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X1_v28+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X9_v11-8]");
			if (0 == (nint)obj2)
			{
				goto IL_00da;
			}
		}
		goto IL_0431;
		IL_0431:
		throw new InvalidCastException();
		IL_031f:
		Button button = sendGiftButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)416;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj6);
		button.m_OnClick.AddListener(unityAction);
		object obj7 = 0;
		goto IL_0377;
		IL_00da:
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)520;
		<player>k__BackingField = (CardGamePlayer)kPlayer;
		object obj10 = this + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num4 = (nint)this;
		RegisterEventListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		<player>k__BackingField.OnUserChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v7 (Il2CppClass<Userbox>)+1F0]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj12 = (nint)0 + (nint)528;
		<player>k__BackingField.OnDidLastAction += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj12);
		SFS.OnPublicMessage += action3;
		object obj13 = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj15 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj15);
		object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v23+100]");
		((UnityEvent)0).AddListener(unityAction2);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = sendGiftButton;
			bool flag3 = !flag2;
			object obj18 = !flag3;
			object obj19 = 0;
			if (obj18 != null)
			{
				goto IL_031f;
			}
			obj7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = sendGiftButton;
			bool flag5 = !flag4;
			object obj19 = 0;
			obj7 = 0;
			if (!flag5)
			{
				goto IL_031f;
			}
		}
		goto IL_0377;
		IL_0377:
		giftsShowcase.Setup(<player>k__BackingField);
		Button sitHereButton = SitHereButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num6 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v13 (Il2CppClass<Userbox>)+210]");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)0);
		sitHereButton.m_OnClick.AddListener(unityAction3);
		FixDirection();
		bool isCurrentPerspectiveTopDown = gameVisualControls.IsCurrentPerspectiveTopDown;
		OnGamePerspectiveChanged(isCurrentPerspectiveTopDown);
		OnThisUserChanged();
		nint num7 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15 (Il2CppClass<Userbox>)+1A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15 (Il2CppClass<Userbox>)+1B0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v281 @ X2_v16 (should have been resolved before IL gen)");
		goto IL_0431;
	}

	protected virtual void PlayPlayerPlayedCard()
	{
		//IL_0060: Expected O, but got I4
		CardGamePlayer cardGamePlayer = <player>k__BackingField;
		if (cardGamePlayer.<PlayedCard>k__BackingField != null)
		{
			gameVisualControls.PlayCard(cardGamePlayer.<PlayedCard>k__BackingField, cardGamePlayer, null, isEventFromServer: true, withCollision: false, (int?)(object)0, 0, playImmediately: false, hideStartingPoint: false);
		}
	}

	protected virtual void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_00e8: Expected O, but got I
		//IL_0114: Expected I, but got O
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0139: Expected O, but got I
		//IL_0165: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj2 = (nint)0 + (nint)528;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnPublicMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)440;
		gameEventsChannel.ShowUi -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)432;
		gameEventsChannel.HideUi -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		object obj7 = (nint)0 + (nint)552;
		gameEventsChannel.ShowGiftSelection -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj7);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj9 = (nint)0 + (nint)472;
		gameEventsChannel.HideGiftSelection -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action6 = default(Action<bool>);
		action6..ctor((object)this, (IntPtr)obj9);
		gameEventsChannel.OnGiftSelected -= action6;
	}

	protected virtual void OnRoundStart()
	{
		cardsRevealer.HideImmediate();
	}

	private void OnRoundEnd()
	{
		cardsRevealer.HideImmediate();
	}

	protected virtual void OnGameStatusUpdate()
	{
		//IL_007d: Expected F4, but got I4
		CardGamePlayer cardGamePlayer = <player>k__BackingField;
		if (cardGamePlayer.CanPlay)
		{
			ShowPlayerTurnIndicator();
		}
		else
		{
			HidePlayerTurnIndicator();
		}
		CardGamePlayer cardGamePlayer2 = <player>k__BackingField;
		bool canPlay = cardGamePlayer2.CanPlay;
		bool flag = !canPlay;
		float time = 0f;
		if (!flag)
		{
			CardGame cardGame = game;
			time = ((KGame)cardGame).<WatchDogTimer>k__BackingField;
		}
		StartTimer(time);
		CardGame cardGame2 = game;
		bool dealer;
		if (cardGame2.<Stage>k__BackingField.IsBidding)
		{
			bool isDealer = <player>k__BackingField.IsDealer;
			dealer = isDealer;
		}
		else
		{
			dealer = false;
		}
		SetDealer(dealer);
		RefreshShownCards();
		if (CanJoinGame())
		{
			ShowSitHereButton();
		}
		else
		{
			ShowNormalUserbox();
		}
	}

	private void OnThisUserChanged()
	{
		bool flag = direction == UserBoxDirection.Bottom && <player>k__BackingField.IsMe;
		isMyUserbox = flag;
		RefreshUser();
		RefreshCardBack();
		bool active;
		if (game.IsFastTrackGame)
		{
			active = false;
		}
		else
		{
			bool isRoomOwner = <player>k__BackingField.IsRoomOwner;
			active = isRoomOwner;
		}
		ownerBadge.SetActive(active);
		RefreshVoiceUI();
		RefreshGiftsControls();
		Actions.SafeInvoke(this.OnUserRefreshed);
	}

	private void OnSomePlayerSwitchSeat(int i, string s)
	{
		RefreshGiftsControls();
	}

	private void OnSawa(SawaInfo sawaInfo)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_0228: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_0136: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b6: Expected I, but got O
		//IL_02c6: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		int? gameActionItemId = sawaInfo.GameActionItemId;
		object obj = (??)gameActionItemId & 1;
		object obj2;
		object obj7;
		object obj9;
		if (obj != null)
		{
			int sawaPlayer = sawaInfo.SawaPlayer;
			CardGamePlayer cardGamePlayer = <player>k__BackingField;
			if (sawaPlayer == ((KPlayer)cardGamePlayer).<Index>k__BackingField)
			{
				obj2 = typeof(SqlSingle[]) + 3832;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						goto IL_00f1;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj5 = (nint)0 & (nint)1;
					bool flag = obj5 == null;
					object obj6 = !flag;
					if (obj6 != null)
					{
						goto IL_00f1;
					}
				}
				_ = 1;
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v35+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj9 = obj7;
				if (obj8 != null)
				{
					goto IL_0126;
				}
				goto IL_0206;
			}
		}
		goto IL_0351;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v35+B8]");
		object obj10 = 0;
		AnimatedItemController animatedItemController = (AnimatedItemController)obj10;
		int? gameActionItemId2 = sawaInfo.GameActionItemId;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0242;
		IL_0242:
		if (!animatedItemController.CreateCustomSawaAnimation(gameActionItemId2, out var animation))
		{
			goto IL_0351;
		}
		CardGamePlayer cardGamePlayer2 = <player>k__BackingField;
		List<Card> list = sawaInfo.Cards(((KPlayer)cardGamePlayer2).<Index>k__BackingField);
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2024;
		nint num = (nint)animation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v14 (Il2CppClass<ICustomSawaAnimation>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v14 (Il2CppClass<ICustomSawaAnimation>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0342;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v14 (Il2CppClass<ICustomSawaAnimation>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v5-8]");
			if (0 == (nint)obj12)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_0342;
		}
		object obj15 = num + obj14;
		object obj16 = obj15 + 312;
		goto IL_03e0;
		IL_0342:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03e0;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X0_v18] (should have been resolved before IL gen)");
		return;
		IL_0351:
		CardGamePlayer cardGamePlayer3 = <player>k__BackingField;
		List<Card> cards = sawaInfo.Cards(((KPlayer)cardGamePlayer3).<Index>k__BackingField);
		cardsRevealer.ShowCards(cards);
		return;
		IL_00f1:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v35+E4]");
		bool flag4 = (nint)0 == 0;
		obj9 = obj7;
		if (!flag4)
		{
			goto IL_0126;
		}
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v26+B8]");
		object obj18 = 0;
		animatedItemController = (AnimatedItemController)obj18;
		gameActionItemId2 = sawaInfo.GameActionItemId;
		goto IL_0242;
	}

	private void OnKasho(KashoInfo kashoInfo)
	{
		CardGamePlayer cardGamePlayer = <player>k__BackingField;
		List<Card> cards = kashoInfo.Cards(((KPlayer)cardGamePlayer).<Index>k__BackingField);
		cardsRevealer.ShowCards(cards);
	}

	protected virtual void OnPlayerDidLastAction()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		CardGameLastActionInfo lastAction = game.LastAction;
		object obj = "___# Content push apply failed [{0}]: {1}" + 2664;
		if (((LastActionInfo)lastAction).<Action>k__BackingField == (string)obj)
		{
			if (!<player>k__BackingField.IsMe || !<player>k__BackingField.IsHumanSeated || game.IsReplay)
			{
				CardGamePlayer cardGamePlayer = <player>k__BackingField;
				CardGameLastActionInfo lastAction2 = game.LastAction;
				gameVisualControls.PlayCard(cardGamePlayer.<PlayedCard>k__BackingField, <player>k__BackingField, null, isEventFromServer: true, withCollision: true, lastAction2.<GameActionItemId>k__BackingField, 0, playImmediately: false, hideStartingPoint: false);
			}
			cardsRevealer.HideGracefully();
		}
		else
		{
			CardGameLastActionInfo lastAction3 = game.LastAction;
			object obj2 = "___# Content push apply failed [{0}]: {1}" + 2680;
			if (((LastActionInfo)lastAction3).<Action>k__BackingField == (string)obj2)
			{
				gameVisualControls.EatCards(<player>k__BackingField, eatingPoint, <CurrentCardBack>k__BackingField, playImmediately: false);
			}
		}
	}

	private void OnNewVoiceChatUpdate(string userId, float? v)
	{
		//IL_0068: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		if (!<player>k__BackingField.IsHuman)
		{
			return;
		}
		string dBId = <player>k__BackingField.DBId;
		bool flag = userId != dBId;
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			object obj2 = (??)v & 1;
			if (obj2 != null)
			{
				float? num = default(float?);
				float value = num.Value;
				StartVoiceAnimation(value);
			}
		}
	}

	private unsafe void FixDirection()
	{
		//IL_0018: Expected O, but got I4
		//IL_06af: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_25d6: Expected O, but got I4
		//IL_25df: Expected O, but got I4
		//IL_06e5: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_12de: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e3: Expected O, but got Unknown
		//IL_12fb: Expected O, but got I
		//IL_132d: Expected O, but got I4
		//IL_1347: Expected O, but got I4
		//IL_134c: Expected I, but got O
		//IL_22cd: Expected O, but got I4
		//IL_22d6: Expected O, but got I4
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Expected O, but got Unknown
		//IL_0e91: Expected O, but got I
		//IL_0ec6: Expected O, but got I4
		//IL_0edf: Expected I, but got O
		//IL_2114: Expected O, but got I4
		//IL_211d: Expected O, but got I4
		//IL_260a: Expected O, but got I4
		//IL_260f: Expected I, but got O
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_074c: Expected O, but got I
		//IL_077e: Expected O, but got I4
		//IL_0798: Expected O, but got I4
		//IL_079d: Expected I, but got O
		//IL_2549: Expected I, but got O
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_0142: Expected I, but got O
		//IL_138c: Expected O, but got I
		//IL_1396: Expected F8, but got O
		//IL_13a4: Expected O, but got I4
		//IL_13be: Expected O, but got I4
		//IL_13c3: Expected I, but got O
		//IL_2303: Expected O, but got I4
		//IL_2308: Expected I, but got O
		//IL_0f1d: Expected O, but got I
		//IL_0f27: Expected F8, but got O
		//IL_0f35: Expected O, but got I4
		//IL_0f4e: Expected I, but got O
		//IL_017f: Expected O, but got I4
		//IL_0184: Expected I, but got O
		//IL_13fe: Expected O, but got I4
		//IL_1403: Expected I, but got O
		//IL_07dd: Expected O, but got I
		//IL_0804: Expected O, but got I4
		//IL_0809: Expected I, but got O
		//IL_01bf: Expected O, but got I4
		//IL_01c4: Expected I, but got O
		//IL_1425: Expected O, but got I4
		//IL_1449: Expected O, but got I4
		//IL_144e: Expected I, but got O
		//IL_1457: Expected F8, but got I4
		//IL_256c: Expected I, but got O
		//IL_0848: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_0875: Expected O, but got I8
		//IL_0f8c: Expected O, but got I
		//IL_0fbc: Expected O, but got I4
		//IL_0fe2: Expected I, but got O
		//IL_022a: Expected F8, but got I4
		//IL_1495: Expected O, but got I4
		//IL_149a: Expected I, but got O
		//IL_14a3: Expected F8, but got I4
		//IL_2343: Expected O, but got I4
		//IL_235d: Expected O, but got I4
		//IL_2362: Expected I, but got O
		//IL_236c: Expected O, but got I4
		//IL_0863: Expected O, but got I8
		//IL_2146: Expected O, but got I4
		//IL_14e7: Expected O, but got I4
		//IL_14ec: Expected I, but got O
		//IL_14f5: Expected F8, but got I4
		//IL_08a3: Expected O, but got I4
		//IL_08a8: Expected I, but got O
		//IL_08b2: Expected O, but got I4
		//IL_1015: Expected I, but got O
		//IL_2162: Expected O, but got I4
		//IL_217c: Expected O, but got I4
		//IL_2181: Expected I, but got O
		//IL_152f: Expected O, but got I4
		//IL_1534: Expected I, but got O
		//IL_153d: Expected F8, but got I4
		//IL_08ec: Expected O, but got I4
		//IL_08f1: Expected I, but got O
		//IL_08fb: Expected O, but got I4
		//IL_104e: Expected I, but got O
		//IL_0264: Expected O, but got I4
		//IL_0269: Expected I, but got O
		//IL_092e: Expected O, but got I4
		//IL_107d: Expected I, but got O
		//IL_02a5: Expected O, but got I4
		//IL_02aa: Expected I, but got O
		//IL_263b: Expected O, but got I4
		//IL_2640: Expected I, but got O
		//IL_2649: Expected F8, but got I4
		//IL_2395: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_157c: Expected O, but got I
		//IL_1586: Expected F8, but got O
		//IL_1594: Expected O, but got I4
		//IL_15b8: Expected O, but got I4
		//IL_15bd: Expected I, but got O
		//IL_258f: Expected I, but got O
		//IL_23b1: Expected O, but got I4
		//IL_23d5: Expected O, but got I4
		//IL_23da: Expected I, but got O
		//IL_23e5: Expected O, but got I4
		//IL_21a4: Expected O, but got I4
		//IL_21c8: Expected O, but got I4
		//IL_21cd: Expected I, but got O
		//IL_21d6: Expected F8, but got I4
		//IL_10b5: Expected O, but got I
		//IL_10bf: Expected F8, but got O
		//IL_10cd: Expected O, but got I4
		//IL_10f3: Expected I, but got O
		//IL_15f8: Expected O, but got I4
		//IL_15fd: Expected I, but got O
		//IL_099d: Expected O, but got I4
		//IL_09a2: Expected I, but got O
		//IL_09ac: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0331: Expected I, but got O
		//IL_033a: Expected F8, but got I4
		//IL_163f: Expected O, but got I4
		//IL_1644: Expected I, but got O
		//IL_1125: Expected I, but got O
		//IL_09ee: Expected O, but got I4
		//IL_09f3: Expected I, but got O
		//IL_09fd: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		//IL_0382: Expected I, but got O
		//IL_038b: Expected F8, but got I4
		//IL_167c: Expected O, but got I4
		//IL_1681: Expected I, but got O
		//IL_115e: Expected I, but got O
		//IL_0a35: Expected O, but got I4
		//IL_0a3a: Expected I, but got O
		//IL_0a44: Expected O, but got I4
		//IL_03c4: Expected O, but got I4
		//IL_03c9: Expected I, but got O
		//IL_03d2: Expected F8, but got I4
		//IL_16b9: Expected O, but got I4
		//IL_16be: Expected I, but got O
		//IL_118d: Expected I, but got O
		//IL_16df: Expected O, but got I4
		//IL_16ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f3: Expected O, but got Unknown
		//IL_2410: Expected O, but got I4
		//IL_2415: Expected I, but got O
		//IL_241f: Expected O, but got I4
		//IL_11bc: Expected I, but got O
		//IL_2203: Expected O, but got I4
		//IL_2208: Expected I, but got O
		//IL_2211: Expected F8, but got I4
		//IL_18d5: Expected I, but got O
		//IL_1745: Expected O, but got I4
		//IL_1753: Expected I, but got O
		//IL_0a81: Expected O, but got I
		//IL_0a8b: Expected F8, but got O
		//IL_0a99: Expected O, but got I4
		//IL_0abd: Expected O, but got I4
		//IL_0ac2: Expected I, but got O
		//IL_0acb: Expected O, but got I4
		//IL_11d8: Expected O, but got I4
		//IL_11e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ec: Expected O, but got Unknown
		//IL_1216: Expected O, but got I4
		//IL_0410: Expected O, but got I
		//IL_041a: Expected F8, but got O
		//IL_0428: Expected O, but got I4
		//IL_044c: Expected O, but got I4
		//IL_0451: Expected I, but got O
		//IL_1789: Expected O, but got I4
		//IL_17b9: Expected O, but got I4
		//IL_18fd: Expected O, but got I4
		//IL_1a75: Expected I, but got O
		//IL_0b06: Expected O, but got I4
		//IL_0b0b: Expected I, but got O
		//IL_0b14: Expected O, but got I4
		//IL_1277: Expected I, but got O
		//IL_048c: Expected O, but got I4
		//IL_0491: Expected I, but got O
		//IL_1962: Expected O, but got I4
		//IL_1962: Expected O, but got I4
		//IL_1996: Expected O, but got I4
		//IL_199f: Expected O, but got I4
		//IL_19a8: Expected O, but got I4
		//IL_19b1: Expected O, but got I4
		//IL_19ba: Expected O, but got I4
		//IL_19d8: Expected O, but got I4
		//IL_19e1: Expected O, but got I4
		//IL_19ea: Expected O, but got I4
		//IL_19f3: Expected O, but got I4
		//IL_1a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9f: Expected O, but got Unknown
		//IL_1ac9: Expected O, but got I4
		//IL_1819: Expected I, but got O
		//IL_0b56: Expected O, but got I4
		//IL_0b5b: Expected I, but got O
		//IL_0b64: Expected O, but got I4
		//IL_12bd: Expected O, but got Ref
		//IL_04d3: Expected O, but got I4
		//IL_04d8: Expected I, but got O
		//IL_1aff: Expected O, but got I4
		//IL_2287: Expected native int or pointer, but got O
		//IL_2295: Expected O, but got I4
		//IL_0b9c: Expected O, but got I4
		//IL_0ba1: Expected I, but got O
		//IL_0baa: Expected O, but got I4
		//IL_25b7: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_0515: Expected I, but got O
		//IL_0be4: Expected O, but got I4
		//IL_0be9: Expected I, but got O
		//IL_0bf2: Expected O, but got I4
		//IL_054f: Expected O, but got I4
		//IL_0554: Expected I, but got O
		//IL_1b8d: Expected O, but got I4
		//IL_0c2c: Expected O, but got I4
		//IL_0c31: Expected I, but got O
		//IL_0c3a: Expected O, but got I4
		//IL_058e: Expected O, but got I4
		//IL_0593: Expected I, but got O
		//IL_0c78: Expected O, but got I4
		//IL_05d1: Expected O, but got I4
		//IL_05fa: Expected F8, but got I4
		//IL_2440: Expected O, but got I4
		//IL_2464: Expected O, but got I4
		//IL_2469: Expected I, but got O
		//IL_2474: Expected O, but got I4
		//IL_2233: Expected O, but got I4
		//IL_2242: Unknown result type (might be due to invalid IL or missing references)
		//IL_2247: Expected O, but got Unknown
		//IL_2271: Expected O, but got I4
		//IL_0cb7: Expected I, but got O
		//IL_0cc0: Expected O, but got I4
		//IL_0cc9: Expected O, but got I4
		//IL_24d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24de: Expected O, but got Unknown
		//IL_0650: Expected O, but got I4
		//IL_0655: Expected I, but got O
		//IL_182d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Expected O, but got Unknown
		//IL_0ce8: Expected O, but got I4
		//IL_0690: Expected O, but got Ref
		//IL_1bc9: Expected I, but got O
		//IL_1885: Expected O, but got I4
		//IL_188a: Expected I, but got O
		//IL_1ca2: Expected O, but got I4
		//IL_1bf2: Expected O, but got I4
		//IL_0d7d: Expected O, but got I4
		//IL_0d8a: Expected I, but got O
		//IL_1cee: Expected O, but got I4
		//IL_1cfb: Expected I, but got O
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d54: Expected I4, but got Unknown
		//IL_1c56: Expected O, but got I4
		//IL_1c56: Expected O, but got I4
		//IL_1c5f: Expected O, but got I4
		//IL_1c68: Expected O, but got I4
		//IL_1c71: Expected O, but got I4
		//IL_1c83: Expected F8, but got I4
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected I4, but got Unknown
		//IL_24a7: Expected O, but got I4
		//IL_1d3d: Expected O, but got I4
		//IL_1d4a: Expected I, but got O
		//IL_0dd0: Expected O, but got I
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dde: Expected O, but got Unknown
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0e12: Expected O, but got I4
		//IL_0e1b: Expected O, but got I4
		//IL_0e24: Expected O, but got I4
		//IL_0e34: Expected O, but got I4
		//IL_1d75: Expected O, but got I4
		//IL_1d8f: Expected O, but got I4
		//IL_1d9c: Expected I, but got O
		//IL_1da5: Expected F8, but got I4
		//IL_1de9: Expected O, but got I4
		//IL_1df6: Expected I, but got O
		//IL_1dff: Expected F8, but got I4
		//IL_1e2a: Expected O, but got I4
		//IL_1e44: Expected O, but got I4
		//IL_1e51: Expected I, but got O
		//IL_1e5a: Expected F8, but got I4
		//IL_1e9e: Expected O, but got I4
		//IL_1eab: Expected I, but got O
		//IL_1eb4: Expected F8, but got I4
		//IL_1edf: Expected O, but got I4
		//IL_1ef9: Expected O, but got I4
		//IL_1f06: Expected I, but got O
		//IL_1f0f: Expected F8, but got I4
		//IL_1f53: Expected O, but got I4
		//IL_1f60: Expected I, but got O
		//IL_1f69: Expected F8, but got I4
		//IL_1f94: Expected O, but got I4
		//IL_1fae: Expected O, but got I4
		//IL_1fbb: Expected I, but got O
		//IL_1fc4: Expected F8, but got I4
		//IL_2676: Expected O, but got I4
		//IL_2683: Expected I, but got O
		//IL_268c: Expected F8, but got I4
		//IL_2016: Unknown result type (might be due to invalid IL or missing references)
		//IL_201b: Expected O, but got Unknown
		//IL_2033: Expected O, but got I
		//IL_2063: Expected O, but got I4
		//IL_207d: Expected O, but got I4
		//IL_208a: Expected I, but got O
		//IL_20aa: Expected O, but got I
		//IL_26c1: Expected O, but got I4
		//IL_20d6: Expected O, but got I4
		if (isPlayerPrefab)
		{
			return;
		}
		object obj = direction - 1;
		bool flag = obj == null;
		Userbox userbox;
		double num2 = default(double);
		float value;
		float? num4;
		float? num5 = default(float?);
		Transform transform6;
		UnityEngine.Object obj41;
		object obj44;
		float? num13;
		float? num14;
		float? num15;
		double num16;
		UnityEngine.Object obj45;
		float? num7 = default(float?);
		object obj42;
		object obj32 = default(object);
		float? num11 = default(float?);
		float? num12 = default(float?);
		float? num;
		object obj2;
		nint num3;
		if (direction <= UserBoxDirection.Right)
		{
			bool flag2 = direction == UserBoxDirection.Bottom;
			num = (float?)(object)0;
			userbox = this;
			if (flag2)
			{
				goto IL_2513;
			}
			obj = direction - 1;
			flag = obj == null;
			if (direction != UserBoxDirection.Right)
			{
				return;
			}
			bool flag3 = (object)eatingPoint == null;
			num = (float?)(object)0;
			obj2 = 146599936;
			userbox = this;
			if (!flag3)
			{
				obj2 = typeof(UsageHint) + 816;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X8_v142+B8]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X8_v143+30]");
				num2 = 0.0 * num2;
				eatingPoint.localPosition = (Vector3)0;
				bool flag4 = (object)cardsRevealer == null;
				num = (float?)(object)0;
				num3 = unchecked((nint)null);
				userbox = this;
				if (!flag4)
				{
					Transform transform = cardsRevealer.transform;
					bool flag5 = <player>k__BackingField == null;
					num = (float?)(object)0;
					num3 = unchecked((nint)null);
					userbox = this;
					if (!flag5)
					{
						bool areCardsShown = <player>k__BackingField.AreCardsShown;
						bool flag6 = (object)transform == null;
						num = (float?)(object)0;
						num3 = unchecked((nint)null);
						userbox = this;
						if (!flag6)
						{
							flag = !areCardsShown;
							object obj5 = !flag;
							object obj6 = ~obj5;
							num2 = ((obj6 != null) ? 0.0 : (-21.0));
							bool flag7 = !flag;
							object obj7 = !flag7;
							if (obj7 == null)
							{
							}
							transform.localPosition = (Vector3)0;
							bool flag8 = (object)cardsRevealer == null;
							num = (float?)(object)0;
							num3 = unchecked((nint)null);
							userbox = this;
							if (!flag8)
							{
								Transform transform2 = cardsRevealer.transform;
								bool flag9 = <player>k__BackingField == null;
								num = (float?)(object)0;
								num3 = unchecked((nint)null);
								userbox = this;
								if (!flag9)
								{
									bool areCardsShown2 = <player>k__BackingField.AreCardsShown;
									bool flag10 = (object)transform2 == null;
									num = (float?)(object)0;
									num3 = unchecked((nint)null);
									userbox = this;
									if (!flag10)
									{
										flag = !areCardsShown2;
										flag7 = !flag;
										obj7 = !flag7;
										if (obj7 == null)
										{
										}
										transform2.localEulerAngles = (Vector3)0;
										SpriteRenderer[] array = cardBacks;
										bool flag11 = cardBacks == null;
										num = (float?)(object)0;
										num3 = unchecked((nint)null);
										num2 = 0.0;
										userbox = this;
										if (!flag11)
										{
											bool flag12 = (object)array[0] == null;
											num = (float?)(object)0;
											num3 = unchecked((nint)null);
											num2 = 0.0;
											userbox = this;
											if (!flag12)
											{
												Transform transform3 = array[0].transform;
												bool flag13 = (object)transform3 == null;
												num = (float?)(object)0;
												num3 = unchecked((nint)null);
												num2 = 0.0;
												userbox = this;
												if (!flag13)
												{
													Transform parent = transform3.parent;
													bool flag14 = (object)parent == null;
													num = (float?)(object)0;
													num3 = unchecked((nint)null);
													num2 = 0.0;
													userbox = this;
													if (!flag14)
													{
														Transform parent2 = parent.parent;
														bool flag15 = (object)parent2 == null;
														num = (float?)(object)0;
														num3 = unchecked((nint)null);
														num2 = 0.0;
														userbox = this;
														if (!flag15)
														{
															object obj8 = obj2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X8_v150+B8]");
															object obj9 = 0;
															num2 = (double)obj9;
															parent2.localEulerAngles = (Vector3)0;
															SpriteRenderer[] array2 = cardBacks;
															bool flag16 = cardBacks == null;
															num = (float?)(object)0;
															num3 = unchecked((nint)null);
															userbox = this;
															if (!flag16)
															{
																bool flag17 = (object)array2[0] == null;
																num = (float?)(object)0;
																num3 = unchecked((nint)null);
																userbox = this;
																if (!flag17)
																{
																	Transform transform4 = array2[0].transform;
																	bool flag18 = (object)transform4 == null;
																	num = (float?)(object)0;
																	num3 = unchecked((nint)null);
																	userbox = this;
																	if (!flag18)
																	{
																		Transform parent3 = transform4.parent;
																		bool flag19 = (object)parent3 == null;
																		num = (float?)(object)0;
																		num3 = unchecked((nint)null);
																		userbox = this;
																		if (!flag19)
																		{
																			Transform parent4 = parent3.parent;
																			bool flag20 = <player>k__BackingField == null;
																			num = (float?)(object)0;
																			num3 = unchecked((nint)null);
																			userbox = this;
																			if (!flag20)
																			{
																				bool areCardsShown3 = <player>k__BackingField.AreCardsShown;
																				bool flag21 = (object)parent4 == null;
																				num = (float?)(object)0;
																				num3 = unchecked((nint)null);
																				userbox = this;
																				if (!flag21)
																				{
																					flag = !areCardsShown3;
																					flag7 = !flag;
																					obj7 = !flag7;
																					num2 = ((obj7 != null) ? 0.0 : (-10.0));
																					parent4.localPosition = (Vector3)0;
																					object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
																					object obj11 = obj10;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X0_v199+E4]");
																					bool flag22 = (nint)0 == 0;
																					object obj12 = !flag22;
																					if (obj12 == null)
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																					}
																					if (!animatedGiftStoreParent)
																					{
																						return;
																					}
																					bool flag23 = (object)animatedGiftStoreParent == null;
																					num = (float?)(object)0;
																					num3 = unchecked((nint)null);
																					userbox = this;
																					if (!flag23)
																					{
																						Transform transform5 = animatedGiftStoreParent.transform;
																						value = -30f;
																						num4 = (float?)(object)(&num5);
																						transform6 = transform5;
																						goto IL_227f;
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
		else
		{
			obj = direction - 2;
			if (direction != UserBoxDirection.Top)
			{
				obj = direction - 3;
				flag = obj == null;
				if (direction != UserBoxDirection.Left)
				{
					return;
				}
				bool flag24 = (object)eatingPoint == null;
				num = (float?)(object)0;
				obj2 = 146599936;
				userbox = this;
				if (!flag24)
				{
					obj2 = typeof(UsageHint) + 816;
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v83+B8]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X8_v84+3C]");
					num2 = 0.0 * num2;
					eatingPoint.localPosition = (Vector3)0;
					bool flag25 = (object)cardsRevealer == null;
					num = (float?)(object)0;
					num3 = unchecked((nint)null);
					userbox = this;
					if (!flag25)
					{
						Transform transform7 = cardsRevealer.transform;
						bool flag26 = <player>k__BackingField == null;
						num = (float?)(object)0;
						num3 = unchecked((nint)null);
						userbox = this;
						if (!flag26)
						{
							object obj15 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X8_v87+B8]");
							object obj16 = 0;
							bool areCardsShown4 = <player>k__BackingField.AreCardsShown;
							bool flag27 = (object)transform7 == null;
							num = (float?)(object)0;
							num3 = unchecked((nint)null);
							userbox = this;
							if (!flag27)
							{
								flag = !areCardsShown4;
								bool flag7 = !flag;
								object obj7 = !flag7;
								object obj17 = ((obj7 != null) ? ((object)3266576384L) : ((object)3255042048L));
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v880 @ X8_v88+48]");
								num2 = 0.0 * (double)obj17;
								transform7.localEulerAngles = (Vector3)0;
								bool flag28 = (object)cardsRevealer == null;
								num = (float?)(object)0;
								num3 = unchecked((nint)null);
								obj = areCardsShown4;
								userbox = this;
								if (!flag28)
								{
									Transform transform8 = cardsRevealer.transform;
									bool flag29 = <player>k__BackingField == null;
									num = (float?)(object)0;
									num3 = unchecked((nint)null);
									obj = areCardsShown4;
									userbox = this;
									if (!flag29)
									{
										bool areCardsShown5 = <player>k__BackingField.AreCardsShown;
										bool flag30 = (object)transform8 == null;
										num = (float?)(object)0;
										num3 = unchecked((nint)null);
										obj = areCardsShown4;
										userbox = this;
										if (!flag30)
										{
											flag = !areCardsShown5;
											object obj18 = !flag;
											object obj19 = ~obj18;
											num2 = ((obj19 != null) ? 5.0 : (-21.0));
											flag7 = !flag;
											obj7 = !flag7;
											if (obj7 == null)
											{
											}
											transform8.localPosition = (Vector3)0;
											SpriteRenderer[] array3 = cardBacks;
											bool flag31 = cardBacks == null;
											num = (float?)(object)0;
											num3 = unchecked((nint)null);
											obj = areCardsShown5;
											userbox = this;
											if (!flag31)
											{
												bool flag32 = (object)array3[0] == null;
												num = (float?)(object)0;
												num3 = unchecked((nint)null);
												obj = areCardsShown5;
												userbox = this;
												if (!flag32)
												{
													Transform transform9 = array3[0].transform;
													bool flag33 = (object)transform9 == null;
													num = (float?)(object)0;
													num3 = unchecked((nint)null);
													obj = areCardsShown5;
													userbox = this;
													if (!flag33)
													{
														Transform parent5 = transform9.parent;
														bool flag34 = (object)parent5 == null;
														num = (float?)(object)0;
														num3 = unchecked((nint)null);
														obj = areCardsShown5;
														userbox = this;
														if (!flag34)
														{
															Transform parent6 = parent5.parent;
															bool flag35 = (object)parent6 == null;
															num = (float?)(object)0;
															num3 = unchecked((nint)null);
															obj = areCardsShown5;
															userbox = this;
															if (!flag35)
															{
																object obj20 = obj2;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ X8_v95+B8]");
																object obj21 = 0;
																num2 = (double)obj21;
																parent6.localEulerAngles = (Vector3)0;
																SpriteRenderer[] array4 = cardBacks;
																bool flag36 = cardBacks == null;
																num = (float?)(object)0;
																num3 = unchecked((nint)null);
																obj = areCardsShown5;
																userbox = this;
																if (!flag36)
																{
																	bool flag37 = (object)array4[0] == null;
																	num = (float?)(object)0;
																	num3 = unchecked((nint)null);
																	obj = areCardsShown5;
																	userbox = this;
																	if (!flag37)
																	{
																		Transform transform10 = array4[0].transform;
																		bool flag38 = (object)transform10 == null;
																		num = (float?)(object)0;
																		num3 = unchecked((nint)null);
																		obj = areCardsShown5;
																		userbox = this;
																		if (!flag38)
																		{
																			Transform parent7 = transform10.parent;
																			bool flag39 = (object)parent7 == null;
																			num = (float?)(object)0;
																			num3 = unchecked((nint)null);
																			obj = areCardsShown5;
																			userbox = this;
																			if (!flag39)
																			{
																				Transform parent8 = parent7.parent;
																				bool flag40 = <player>k__BackingField == null;
																				num = (float?)(object)0;
																				num3 = unchecked((nint)null);
																				obj = areCardsShown5;
																				userbox = this;
																				if (!flag40)
																				{
																					bool areCardsShown6 = <player>k__BackingField.AreCardsShown;
																					bool flag41 = (object)parent8 == null;
																					num = (float?)(object)0;
																					num3 = unchecked((nint)null);
																					obj = areCardsShown5;
																					userbox = this;
																					if (!flag41)
																					{
																						flag = !areCardsShown6;
																						flag7 = !flag;
																						obj7 = !flag7;
																						num2 = ((obj7 != null) ? (-20.0) : (-10.0));
																						parent8.localPosition = (Vector3)0;
																						SpriteRenderer[] array5 = cardBacks;
																						bool flag42 = cardBacks == null;
																						num = (float?)(object)0;
																						num3 = unchecked((nint)null);
																						obj = areCardsShown6;
																						userbox = this;
																						if (!flag42)
																						{
																							float? num6 = num7;
																							nint num8 = unchecked((nint)null);
																							object obj22 = 0;
																							object obj23 = 0;
																							RectTransform rectTransform2 = default(RectTransform);
																							while (true)
																							{
																								obj = obj23 - array5.Length;
																								flag = obj == null;
																								if ((nint)obj23 < array5.Length)
																								{
																									bool flag43 = <player>k__BackingField == null;
																									num = (float?)(object)0;
																									num7 = num6;
																									obj2 = obj22;
																									userbox = this;
																									if (flag43)
																									{
																										break;
																									}
																									object obj24 = (object)array5 + obj23;
																									int num9;
																									if (<player>k__BackingField.AreCardsShown)
																									{
																										num9 = obj23 + 1;
																									}
																									else
																									{
																										SpriteRenderer[] array6 = cardBacks;
																										bool flag44 = cardBacks == null;
																										num = (float?)(object)0;
																										num7 = num6;
																										num3 = unchecked((nint)null);
																										obj2 = obj22;
																										userbox = this;
																										if (flag44)
																										{
																											break;
																										}
																										num9 = obj22 + array6.Length;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v130+20]");
																									bool flag45 = (nint)0 == 0;
																									num = (float?)(object)0;
																									num7 = num6;
																									obj2 = obj22;
																									userbox = this;
																									if (flag45)
																									{
																										break;
																									}
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X8_v130+20]");
																									((Renderer)0).sortingOrder = num9;
																									obj23++;
																									array5 = cardBacks;
																									obj2 = obj22 - 1;
																									bool flag46 = cardBacks == null;
																									object obj25 = !flag46;
																									num = (float?)(object)0;
																									num7 = (float?)(object)0;
																									userbox = this;
																									num6 = (float?)(object)0;
																									num8 = num9;
																									obj22 = obj2;
																									if (obj25 == null)
																									{
																										break;
																									}
																									continue;
																								}
																								object obj26 = typeof(MemberAchievementClanFeedData) + 2976;
																								object obj27 = obj26;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X8_v103+E4]");
																								if ((nint)0 != 0)
																								{
																									bool flag47 = animatedGiftStoreParent;
																									bool flag48 = !flag47;
																									object obj28 = !flag48;
																									num3 = unchecked((nint)null);
																									if (obj28 != null)
																									{
																										goto IL_1bd8;
																									}
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																									bool flag49 = animatedGiftStoreParent;
																									bool flag50 = !flag49;
																									num3 = unchecked((nint)null);
																									if (!flag50)
																									{
																										goto IL_1bd8;
																									}
																								}
																								goto IL_1c88;
																								IL_1c88:
																								bool flag51 = (object)chatBubble == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								obj2 = obj22;
																								userbox = this;
																								if (flag51)
																								{
																									break;
																								}
																								Transform transform11 = chatBubble.transform;
																								bool flag52 = (object)transform11 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								obj2 = obj22;
																								userbox = this;
																								if (flag52)
																								{
																									break;
																								}
																								Transform parent9 = transform11.parent;
																								bool flag53 = (object)parent9 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								obj2 = obj22;
																								userbox = this;
																								if (flag53)
																								{
																									break;
																								}
																								parent9.localEulerAngles = (Vector3)0;
																								bool flag54 = (object)gameBubble == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag54)
																								{
																									break;
																								}
																								Transform transform12 = gameBubble.transform;
																								bool flag55 = (object)transform12 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag55)
																								{
																									break;
																								}
																								transform12.localEulerAngles = (Vector3)0;
																								bool flag56 = (object)chatBubbleText == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag56)
																								{
																									break;
																								}
																								Transform transform13 = chatBubbleText.transform;
																								bool flag57 = (object)transform13 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag57)
																								{
																									break;
																								}
																								transform13.localEulerAngles = (Vector3)0;
																								bool flag58 = (object)bubbleText == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag58)
																								{
																									break;
																								}
																								Transform transform14 = bubbleText.transform;
																								bool flag59 = (object)transform14 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag59)
																								{
																									break;
																								}
																								transform14.localEulerAngles = (Vector3)0;
																								bool flag60 = (object)chatBubble == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag60)
																								{
																									break;
																								}
																								Transform transform15 = chatBubble.transform;
																								RectTransform rectTransform = UIExtensions.parentRt(transform15);
																								bool flag61 = (object)rectTransform == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								num2 = 0.0;
																								obj2 = obj22;
																								userbox = this;
																								if (flag61)
																								{
																									break;
																								}
																								obj2 = typeof(UsageHint) + 744;
																								object obj29 = obj2;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X8_v111+B8]");
																								object obj30 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1359 @ X8_v112+28]");
																								num2 = 0.0 * 1127481344.0;
																								rectTransform.anchoredPosition = (Vector2)0;
																								bool flag62 = (object)gameBubble == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								num3 = unchecked((nint)null);
																								userbox = this;
																								if (flag62)
																								{
																									break;
																								}
																								object obj31 = (nint)0 + (nint)1360;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
																								userbox = this;
																								bool flag63 = (object)rectTransform2 == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								if (flag63)
																								{
																									break;
																								}
																								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
																								rectTransform2.anchoredPosition = (Vector2)0;
																								return;
																								IL_1bd8:
																								bool flag64 = (object)animatedGiftStoreParent == null;
																								num = (float?)(object)0;
																								num7 = num6;
																								obj2 = obj22;
																								userbox = this;
																								if (flag64)
																								{
																									break;
																								}
																								Transform gObject = animatedGiftStoreParent.transform;
																								float? num10 = 70f;
																								UIExtensions.MoveTo(gObject, isWorldPositions: false, num10, (float?)(object)0, (float?)(object)0);
																								obj32 = 0;
																								num11 = (float?)(object)0;
																								num12 = (float?)(object)0;
																								num6 = num10;
																								num2 = 1116471296.0;
																								goto IL_1c88;
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
			}
			else
			{
				bool flag65 = (object)eatingPoint == null;
				num = (float?)(object)0;
				obj2 = 146599936;
				userbox = this;
				if (!flag65)
				{
					obj2 = typeof(UsageHint) + 816;
					object obj33 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v46+B8]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v47+24]");
					num2 = 0.0 * num2;
					eatingPoint.localPosition = (Vector3)0;
					bool flag66 = (object)cardsRevealer == null;
					num = (float?)(object)0;
					num3 = unchecked((nint)null);
					userbox = this;
					if (!flag66)
					{
						Transform transform16 = cardsRevealer.transform;
						bool flag67 = (object)transform16 == null;
						num = (float?)(object)0;
						num3 = unchecked((nint)null);
						userbox = this;
						if (!flag67)
						{
							object obj35 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v50+B8]");
							object obj36 = 0;
							num2 = (double)obj36;
							transform16.localPosition = (Vector3)0;
							bool flag68 = (object)cardsRevealer == null;
							num = (float?)(object)0;
							num3 = unchecked((nint)null);
							userbox = this;
							if (!flag68)
							{
								Transform transform17 = cardsRevealer.transform;
								bool flag69 = (object)transform17 == null;
								num = (float?)(object)0;
								num3 = unchecked((nint)null);
								userbox = this;
								if (!flag69)
								{
									transform17.localEulerAngles = (Vector3)0;
									SpriteRenderer[] array7 = cardBacks;
									bool flag70 = cardBacks == null;
									num = (float?)(object)0;
									num3 = unchecked((nint)null);
									num2 = 0.0;
									userbox = this;
									if (!flag70)
									{
										bool flag71 = (object)array7[0] == null;
										num = (float?)(object)0;
										num3 = unchecked((nint)null);
										num2 = 0.0;
										userbox = this;
										if (!flag71)
										{
											Transform transform18 = array7[0].transform;
											bool flag72 = (object)transform18 == null;
											num = (float?)(object)0;
											num3 = unchecked((nint)null);
											num2 = 0.0;
											userbox = this;
											if (!flag72)
											{
												Transform parent10 = transform18.parent;
												bool flag73 = (object)parent10 == null;
												num = (float?)(object)0;
												num3 = unchecked((nint)null);
												num2 = 0.0;
												userbox = this;
												if (!flag73)
												{
													Transform parent11 = parent10.parent;
													bool flag74 = (object)parent11 == null;
													num = (float?)(object)0;
													num3 = unchecked((nint)null);
													num2 = 0.0;
													userbox = this;
													if (!flag74)
													{
														object obj37 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v56+B8]");
														object obj38 = 0;
														num2 = (double)obj38;
														parent11.localEulerAngles = (Vector3)0;
														SpriteRenderer[] array8 = cardBacks;
														bool flag75 = cardBacks == null;
														num = (float?)(object)0;
														num3 = unchecked((nint)null);
														userbox = this;
														if (!flag75)
														{
															bool flag76 = (object)array8[0] == null;
															num = (float?)(object)0;
															num3 = unchecked((nint)null);
															userbox = this;
															if (!flag76)
															{
																Transform transform19 = array8[0].transform;
																bool flag77 = (object)transform19 == null;
																num = (float?)(object)0;
																num3 = unchecked((nint)null);
																userbox = this;
																if (!flag77)
																{
																	Transform parent12 = transform19.parent;
																	bool flag78 = (object)parent12 == null;
																	num = (float?)(object)0;
																	num3 = unchecked((nint)null);
																	userbox = this;
																	if (!flag78)
																	{
																		Transform parent13 = parent12.parent;
																		bool flag79 = (object)parent13 == null;
																		num = (float?)(object)0;
																		num3 = unchecked((nint)null);
																		userbox = this;
																		if (!flag79)
																		{
																			parent13.localPosition = (Vector3)0;
																			obj2 = typeof(MemberAchievementClanFeedData) + 2976;
																			object obj39 = obj2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1117 @ X0_v63+E4]");
																			if ((nint)0 != 0)
																			{
																				bool flag80 = animatedGiftStoreParent;
																				bool flag81 = !flag80;
																				object obj40 = !flag81;
																				bool flag82 = false;
																				num3 = unchecked((nint)null);
																				if (obj40 == null)
																				{
																					goto IL_1761;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																				bool flag83 = animatedGiftStoreParent;
																				bool flag84 = !flag83;
																				bool flag82 = false;
																				num3 = unchecked((nint)null);
																				if (flag84)
																				{
																					goto IL_1761;
																				}
																			}
																			bool flag85 = (object)animatedGiftStoreParent == null;
																			num = (float?)(object)0;
																			num2 = -9.0;
																			userbox = this;
																			if (!flag85)
																			{
																				Transform gObject2 = animatedGiftStoreParent.transform;
																				float? num10 = 18f;
																				UIExtensions.MoveTo(gObject2, isWorldPositions: false, num10, (float?)(object)0, (float?)(object)0);
																				obj41 = animatedGiftStoreParent;
																				obj42 = obj2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X0_v74+E4]");
																				bool flag86 = (nint)0 == 0;
																				object obj43 = !flag86;
																				obj32 = 0;
																				num11 = (float?)(object)0;
																				num = (float?)(object)0;
																				num12 = (float?)(object)0;
																				num7 = num10;
																				num2 = 18.0;
																				obj44 = 0;
																				num13 = (float?)(object)0;
																				num = (float?)(object)0;
																				num14 = (float?)(object)0;
																				num15 = num10;
																				bool flag82 = false;
																				num16 = 18.0;
																				obj45 = animatedGiftStoreParent;
																				if (obj43 != null)
																				{
																					goto IL_17ee;
																				}
																				goto IL_1a29;
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
		goto IL_0e52;
		IL_17ee:
		if (!obj41)
		{
			return;
		}
		num3 = unchecked((nint)null);
		goto IL_1a8b;
		IL_227f:
		*(float?*)(nint)num4 = value;
		float? y = (float?)(object)0;
		float? x = num5;
		bool isWorldPositions = false;
		Transform gObject3 = transform6;
		goto IL_259d;
		IL_1a29:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag87 = obj45;
		bool flag88 = !flag87;
		obj32 = obj44;
		num11 = num13;
		num12 = num14;
		num7 = num15;
		num3 = unchecked((nint)null);
		num2 = num16;
		if (flag88)
		{
			return;
		}
		goto IL_1a8b;
		IL_1761:
		obj42 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X0_v74+E4]");
		bool flag89 = (nint)0 == 0;
		num = (float?)(object)0;
		num2 = -9.0;
		obj41 = animatedGiftStoreParent;
		obj44 = obj32;
		num13 = num11;
		num = (float?)(object)0;
		num14 = num12;
		num15 = num7;
		num16 = -9.0;
		obj45 = animatedGiftStoreParent;
		if (!flag89)
		{
			goto IL_17ee;
		}
		goto IL_1a29;
		IL_1a8b:
		object obj46 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj47 = obj46;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1230 @ X0_v65+E4]");
		bool flag90 = (nint)0 == 0;
		object obj48 = !flag90;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		obj = currentGame - 2;
		flag = obj == null;
		if (currentGame != Games.Jackaroo)
		{
			return;
		}
		bool flag91 = (object)animatedGiftStoreParent == null;
		userbox = this;
		if (flag91)
		{
			goto IL_0e52;
		}
		gObject3 = animatedGiftStoreParent.transform;
		num = 70f;
		y = num;
		x = (float?)(object)0;
		isWorldPositions = false;
		goto IL_259d;
		IL_2513:
		if ((object)userbox.eatingPoint != null)
		{
			obj2 = typeof(UsageHint) + 816;
			object obj49 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v11+B8]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v12+18]");
			num2 = 0.0 * num2;
			userbox.eatingPoint.localPosition = (Vector3)0;
			bool flag92 = (object)userbox.cardsRevealer == null;
			num3 = unchecked((nint)null);
			if (!flag92)
			{
				Transform transform20 = userbox.cardsRevealer.transform;
				bool flag93 = (object)transform20 == null;
				num3 = unchecked((nint)null);
				if (!flag93)
				{
					object obj51 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v15+B8]");
					object obj52 = 0;
					num2 = (double)obj52;
					transform20.localEulerAngles = (Vector3)0;
					bool flag94 = (object)userbox.cardsRevealer == null;
					num3 = unchecked((nint)null);
					if (!flag94)
					{
						Transform transform21 = userbox.cardsRevealer.transform;
						bool flag95 = (object)transform21 == null;
						num3 = unchecked((nint)null);
						if (!flag95)
						{
							object obj53 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1019 @ X8_v19+B8]");
							object obj54 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v20+18]");
							num2 = 0.0 * num2;
							transform21.localPosition = (Vector3)0;
							SpriteRenderer[] array9 = userbox.cardBacks;
							bool flag96 = userbox.cardBacks == null;
							num3 = unchecked((nint)null);
							if (!flag96)
							{
								bool flag97 = (object)array9[0] == null;
								num3 = unchecked((nint)null);
								if (!flag97)
								{
									Transform transform22 = array9[0].transform;
									bool flag98 = (object)transform22 == null;
									num3 = unchecked((nint)null);
									if (!flag98)
									{
										Transform parent14 = transform22.parent;
										bool flag99 = (object)parent14 == null;
										num3 = unchecked((nint)null);
										if (!flag99)
										{
											Transform parent15 = parent14.parent;
											bool flag100 = (object)parent15 == null;
											num3 = unchecked((nint)null);
											if (!flag100)
											{
												object obj55 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X8_v24+B8]");
												object obj56 = 0;
												num2 = (double)obj56;
												parent15.localEulerAngles = (Vector3)0;
												SpriteRenderer[] array10 = userbox.cardBacks;
												bool flag101 = userbox.cardBacks == null;
												num3 = unchecked((nint)null);
												if (!flag101)
												{
													bool flag102 = (object)array10[0] == null;
													num3 = unchecked((nint)null);
													if (!flag102)
													{
														Transform transform23 = array10[0].transform;
														bool flag103 = (object)transform23 == null;
														num3 = unchecked((nint)null);
														if (!flag103)
														{
															Transform parent16 = transform23.parent;
															bool flag104 = (object)parent16 == null;
															num3 = unchecked((nint)null);
															if (!flag104)
															{
																Transform parent17 = parent16.parent;
																bool flag105 = (object)parent17 == null;
																num3 = unchecked((nint)null);
																if (!flag105)
																{
																	parent17.localPosition = (Vector3)0;
																	object obj57 = typeof(MemberAchievementClanFeedData) + 2976;
																	object obj58 = obj57;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v25+E4]");
																	bool flag106 = (nint)0 == 0;
																	object obj59 = !flag106;
																	if (obj59 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	if (!userbox.animatedGiftStoreParent)
																	{
																		return;
																	}
																	bool flag107 = (object)userbox.animatedGiftStoreParent == null;
																	num3 = unchecked((nint)null);
																	num2 = -9.0;
																	if (!flag107)
																	{
																		Transform transform24 = userbox.animatedGiftStoreParent.transform;
																		value = 18f;
																		num4 = (float?)(object)(&num5);
																		transform6 = transform24;
																		goto IL_227f;
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
		goto IL_0e52;
		IL_0e52:
		NullReferenceException ex = new NullReferenceException();
		goto IL_2513;
		IL_259d:
		UIExtensions.MoveTo(gObject3, isWorldPositions, x, y, (float?)(object)0);
	}

	public Vector3 GetUserBoxDirection()
	{
		//IL_0127: Expected O, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0113: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		Vector3 result;
		object obj2;
		if (direction != UserBoxDirection.Top)
		{
			if (direction != UserBoxDirection.Right)
			{
				bool flag = direction == UserBoxDirection.Bottom;
				object obj = !flag;
				if (obj == null)
				{
					obj2 = 146599936 + 219;
					object obj3 = obj2 & 1;
					if (obj3 == null)
					{
						goto IL_00f6;
					}
					result = (Vector3)this;
				}
				else
				{
					obj2 = 146599936 + 220;
					object obj4 = obj2 & 1;
					if (obj4 == null)
					{
						goto IL_00f6;
					}
					result = (Vector3)this;
				}
			}
			else
			{
				obj2 = 146599936 + 215;
				object obj5 = obj2 & 1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				result = (Vector3)this;
				if (obj6 == null)
				{
					goto IL_00f6;
				}
			}
		}
		else
		{
			obj2 = 146599936 + 201;
			object obj7 = obj2 & 1;
			if (obj7 == null)
			{
				goto IL_00f6;
			}
			result = (Vector3)this;
		}
		goto IL_01a0;
		IL_00f6:
		result = (Vector3)(typeof(UsageHint) + 816);
		obj2 = 1;
		goto IL_01a0;
		IL_01a0:
		return result;
	}

	private void RefreshUser()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_03c3: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_0434: Expected O, but got I
		if ((object)game != null)
		{
			Room room = game.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			if ((object)avatarInitializer != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				avatarInitializer.Initialize(<player>k__BackingField);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					bool flag = swipeWheel != null;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						goto IL_0108;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (swipeWheel != null)
					{
						goto IL_0108;
					}
				}
				goto IL_01de;
			}
		}
		goto IL_0435;
		IL_0108:
		if ((object)swipeWheel != null)
		{
			GameObject gameObject = swipeWheel.gameObject;
			if (<player>k__BackingField != null)
			{
				bool active;
				if (<player>k__BackingField.IsHuman)
				{
					if ((object)game == null)
					{
						goto IL_0435;
					}
					bool isReplay = game.IsReplay;
					active = (byte)((isReplay ? 1u : 0u) ^ 1u) != 0;
				}
				else
				{
					active = false;
				}
				if ((object)gameObject != null)
				{
					gameObject.SetActive(active);
					goto IL_01de;
				}
			}
		}
		goto IL_0435;
		IL_0443:
		throw new IndexOutOfRangeException();
		IL_01de:
		if ((object)game != null)
		{
			Room room2 = game.Room;
			if (!SFSKammelnaRoomExtensions.IsOffline(room2))
			{
				return;
			}
			if ((object)game != null)
			{
				bool isTutorial = game.IsTutorial;
				bool flag3 = !isTutorial;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					return;
				}
				if ((object)game != null)
				{
					bool isReplay2 = game.IsReplay;
					bool flag4 = !isReplay2;
					object obj5 = !flag4;
					if (obj5 != null)
					{
						return;
					}
					if (<player>k__BackingField != null)
					{
						if (<player>k__BackingField.IsHuman)
						{
							return;
						}
						SpritesStore spritesStore = this.spritesStore;
						if ((object)this.spritesStore != null)
						{
							CardGamePlayer cardGamePlayer = <player>k__BackingField;
							if (<player>k__BackingField != null)
							{
								Sprite[] aiAvatars = spritesStore.AiAvatars;
								if (spritesStore.AiAvatars != null)
								{
									object obj6 = ((KPlayer)cardGamePlayer).<Index>k__BackingField - 2;
									bool flag5 = (nint)obj6 < aiAvatars.Length;
									object obj7 = !flag5;
									if (obj7 != null)
									{
										goto IL_0443;
									}
									if ((object)avatarInitializer != null)
									{
										object obj8 = (object)spritesStore.AiAvatars + obj6;
										AvatarInitializer obj9 = avatarInitializer;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v9+20]");
										obj9.SetAvatar((Sprite)0);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0435;
		IL_0435:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0443;
	}

	private void SetAvatar()
	{
		Room room = game.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		avatarInitializer.Initialize(<player>k__BackingField);
	}

	protected void RefreshShownCards()
	{
		//IL_0038: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_00a4: Expected I, but got O
		//IL_00d8: Expected I, but got O
		//IL_036f: Expected I, but got O
		//IL_027c: Expected I, but got O
		//IL_0281: Expected I, but got O
		//IL_00fa: Expected I, but got O
		//IL_0393: Expected I, but got O
		//IL_05fb: Expected O, but got I4
		//IL_0600: Expected I, but got O
		//IL_0605: Expected I, but got O
		//IL_05ab: Expected O, but got I4
		//IL_05b0: Expected I, but got O
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected I4, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I4, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_03c0: Expected I, but got O
		//IL_05c3: Expected I, but got O
		//IL_03ee: Expected I, but got O
		//IL_0658: Expected O, but got I4
		//IL_0422: Expected I, but got O
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_0685: Expected O, but got I
		//IL_06a7: Expected O, but got I4
		//IL_044b: Expected I, but got O
		//IL_0724: Expected O, but got I4
		//IL_072c: Expected I, but got O
		//IL_0479: Expected I, but got O
		//IL_04a2: Expected O, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_052e: Expected I, but got O
		//IL_0554: Expected O, but got I
		if (_isDealAnimating)
		{
			return;
		}
		SpriteRenderer[] array = cardBacks;
		if (cardBacks != null)
		{
			object obj = 0;
			nint num = default(nint);
			while (true)
			{
				if ((nint)obj < array.Length)
				{
					object obj2 = (object)array + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v23+20]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v23+20]");
					GameObject gameObject = ((UnityEngine.Component)0).gameObject;
					CardGamePlayer cardGamePlayer = <player>k__BackingField;
					bool flag = <player>k__BackingField == null;
					num = unchecked((nint)null);
					if (flag)
					{
						break;
					}
					List<Card> <Cards>k__BackingField = cardGamePlayer.<Cards>k__BackingField;
					bool flag2 = cardGamePlayer.<Cards>k__BackingField == null;
					num = unchecked((nint)null);
					if (flag2)
					{
						break;
					}
					bool flag3 = (object)gameObject == null;
					num = unchecked((nint)null);
					if (flag3)
					{
						break;
					}
					object obj3 = obj - <Cards>k__BackingField._size;
					bool flag4 = (nint)obj3 < 0;
					int num2 = obj ^ <Cards>k__BackingField._size;
					object obj4 = obj ^ obj3;
					int num3 = num2 & obj4;
					bool flag5 = num3 < 0;
					bool flag6 = flag4 == flag5;
					bool flag7 = !flag6;
					gameObject.SetActive(flag7);
					array = cardBacks;
					obj++;
					bool flag8 = cardBacks == null;
					object obj5 = !flag8;
					object obj6 = 0;
					num = (flag7 ? 1 : 0);
					if (obj5 == null)
					{
						num = (flag7 ? 1 : 0);
						break;
					}
					continue;
				}
				bool flag9 = !isMyUserbox;
				nint num4 = num;
				if (!flag9)
				{
					if ((object)game == null)
					{
						break;
					}
					if (!game.IsReplay)
					{
						return;
					}
					array = cardBacks;
					bool flag10 = cardBacks == null;
					num4 = unchecked((nint)null);
					num = unchecked((nint)null);
					if (flag10)
					{
						break;
					}
				}
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				int num5 = 0;
				bool flag29;
				do
				{
					bool flag11 = num5 >= array.Length;
					num = num4;
					Sprite sprite2;
					SpriteRenderer spriteRenderer;
					object obj6;
					if (!flag11)
					{
						bool flag12 = <player>k__BackingField == null;
						num = num4;
						if (flag12)
						{
							break;
						}
						bool canCardsBeShown = <player>k__BackingField.CanCardsBeShown;
						bool flag13 = !canCardsBeShown;
						nint num6 = unchecked((nint)null);
						if (!flag13)
						{
							bool flag14 = <player>k__BackingField == null;
							num = unchecked((nint)null);
							if (flag14)
							{
								break;
							}
							bool areCardsShown = <player>k__BackingField.AreCardsShown;
							bool flag15 = !areCardsShown;
							num6 = unchecked((nint)null);
							if (!flag15)
							{
								CardGamePlayer cardGamePlayer2 = <player>k__BackingField;
								bool flag16 = <player>k__BackingField == null;
								num = unchecked((nint)null);
								if (flag16)
								{
									break;
								}
								List<object> <Cards>k__BackingField2 = (List<object>)(object)cardGamePlayer2.<Cards>k__BackingField;
								bool flag17 = cardGamePlayer2.<Cards>k__BackingField == null;
								num = unchecked((nint)null);
								if (flag17)
								{
									break;
								}
								bool flag18 = num5 >= <Cards>k__BackingField2._size;
								num4 = unchecked((nint)null);
								if (flag18)
								{
									goto IL_02c1;
								}
								SpriteRenderer[] array2 = cardBacks;
								bool flag19 = cardBacks == null;
								num = unchecked((nint)null);
								if (flag19)
								{
									break;
								}
								bool flag20 = num5 < array2.Length;
								object obj8 = !flag20;
								if (obj8 != null)
								{
									goto IL_06c7;
								}
								object obj9 = cardBacks + num5;
								object obj10 = ((List<object>)(object)cardGamePlayer2.<Cards>k__BackingField).get_Item(num5);
								bool flag21 = (object)cardsSprites == null;
								num = num5;
								if (flag21)
								{
									break;
								}
								Sprite sprite = cardsSprites.GetFor((Card)obj10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v19+20]");
								bool flag22 = (nint)0 == 0;
								num = (nint)obj10;
								if (flag22)
								{
									break;
								}
								sprite2 = sprite;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v19+20]");
								spriteRenderer = (SpriteRenderer)0;
								goto IL_070e;
							}
						}
						object obj11 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v15+E4]");
						if ((nint)0 != 0)
						{
							bool flag23 = <CurrentCardBack>k__BackingField != null;
							bool flag24 = !flag23;
							obj6 = 0;
							num4 = unchecked((nint)null);
							if (flag24)
							{
								goto IL_02c1;
							}
							num = unchecked((nint)null);
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag25 = <CurrentCardBack>k__BackingField != null;
							bool flag26 = !flag25;
							obj6 = 0;
							num4 = unchecked((nint)null);
							num = unchecked((nint)null);
							if (flag26)
							{
								goto IL_02c1;
							}
						}
						SpriteRenderer[] array3 = cardBacks;
						if (cardBacks == null)
						{
							break;
						}
						bool flag27 = num5 < array3.Length;
						object obj12 = !flag27;
						if (obj12 != null)
						{
							goto IL_06c7;
						}
						object obj13 = cardBacks + num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15+20]");
						spriteRenderer = (SpriteRenderer)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v15+20]");
						bool flag28 = (nint)0 == 0;
						object obj14 = !flag28;
						if (obj14 != null)
						{
							sprite2 = <CurrentCardBack>k__BackingField;
							goto IL_070e;
						}
						break;
					}
					ReorganizeCards();
					return;
					IL_02c1:
					num5++;
					array = cardBacks;
					flag29 = cardBacks == null;
					num = num4;
					continue;
					IL_070e:
					spriteRenderer.sprite = sprite2;
					obj6 = 0;
					num4 = (nint)sprite2;
					goto IL_02c1;
					IL_06c7:
					throw new IndexOutOfRangeException();
				}
				while (!flag29);
				break;
			}
		}
		throw new NullReferenceException();
	}

	private void RefreshCardBack()
	{
		//IL_0041: Expected O, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_0149: Expected O, but got I4
		Room room = game.Room;
		int num = SFSKammelnaRoomExtensions.GetCardbackID(room);
		bool flag = num <= 0;
		object obj = 0;
		if (!flag)
		{
			goto IL_004f;
		}
		if (<player>k__BackingField.IsHuman)
		{
			CardGamePlayer cardGamePlayer = <player>k__BackingField;
			int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(((KPlayer)cardGamePlayer).<User>k__BackingField);
			if (activeCardbackID >= 1)
			{
				CardGamePlayer cardGamePlayer2 = <player>k__BackingField;
				num = SFSKammelnaUserExtensions.GetActiveCardbackID(((KPlayer)cardGamePlayer2).<User>k__BackingField);
				bool flag2 = num >= 1;
				obj = 0;
				if (flag2)
				{
					goto IL_004f;
				}
			}
		}
		ResetDefaultCardBacks();
		return;
		IL_004f:
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj3 = (nint)0 + (nint)424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj3);
		UIExtensions.LoadItemImage(cardBacks, num, ImageCacher.ItemImageType.InGame, action);
	}

	private void RefreshGiftsControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6820]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = sendGiftButton;
			obj6 = sendGiftButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = sendGiftButton;
			obj6 = sendGiftButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_0286:
		throw new NullReferenceException();
		IL_00b7:
		GameObject gameObject = sendGiftButton.gameObject;
		bool active;
		if (<player>k__BackingField.IsHuman)
		{
			bool flag5 = (object)gameObject == null;
			object obj9 = !flag5;
			active = true;
			if (obj9 == null)
			{
				goto IL_0286;
			}
		}
		else if (!isMyUserbox || game.IsFastTrackGame)
		{
			bool flag6 = (object)gameObject == null;
			object obj10 = !flag6;
			active = false;
			if (obj10 == null)
			{
				goto IL_0286;
			}
		}
		else
		{
			Room room = game.Room;
			bool flag7 = SFSKammelnaRoomExtensions.IsOffline(room);
			active = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
		}
		gameObject.SetActive(active);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void RefreshOwnerBadge()
	{
		bool active;
		if (game.IsFastTrackGame)
		{
			active = false;
		}
		else
		{
			bool isRoomOwner = <player>k__BackingField.IsRoomOwner;
			active = isRoomOwner;
		}
		ownerBadge.SetActive(active);
	}

	private void RefreshVoiceUI()
	{
		//IL_02ff: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0176: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I
		//IL_02c1: Expected I, but got O
		//IL_0275: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2816;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(soundIndicator, (Color)0, 0.7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		VariableBinderExtensions.Unbind(muteIndicator);
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag3;
		object obj5;
		if (game.IsVoiceChatEnabled && <player>k__BackingField.IsHuman)
		{
			GameObject gameObject = soundIndicator.gameObject;
			gameObject.SetActive(value: true);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v11+E4]");
			if ((nint)0 != 0)
			{
				bool flag = glowEffect;
				bool flag2 = !flag;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_0241;
				}
				flag3 = false;
				obj5 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = glowEffect;
				bool flag5 = !flag4;
				flag3 = false;
				obj5 = 0;
				if (!flag5)
				{
					goto IL_0241;
				}
			}
			goto IL_027a;
		}
		GameObject gameObject2 = soundIndicator.gameObject;
		gameObject2.SetActive(value: false);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = glowEffect;
			bool flag7 = !flag6;
			object obj7 = !flag7;
			if (obj7 != null)
			{
				goto IL_01c0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)glowEffect)
			{
				goto IL_01c0;
			}
		}
		goto IL_01e7;
		IL_01e7:
		muteIndicator.SetActive(value: false);
		return;
		IL_01c0:
		GameObject gameObject3 = glowEffect.gameObject;
		gameObject3.SetActive(value: false);
		goto IL_01e7;
		IL_027a:
		CardGamePlayer cardGamePlayer = <player>k__BackingField;
		object obj8 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)536;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		object varName = "m_StencilDeferredPS" + 2112;
		VariableBinderExtensions.Bind(muteIndicator, ((KPlayer)cardGamePlayer).<User>k__BackingField, (string)varName, action);
		return;
		IL_0241:
		GameObject gameObject4 = glowEffect.gameObject;
		gameObject4.SetActive(value: true);
		flag3 = true;
		obj5 = 0;
		goto IL_027a;
	}

	private void RefreshMuteIndicator()
	{
		//IL_0111: Expected O, but got I4
		GameObject gameObject;
		bool active;
		if ((object)game != null)
		{
			if (!game.IsVoiceChatEnabled)
			{
				goto IL_0132;
			}
			if (<player>k__BackingField != null)
			{
				if (!<player>k__BackingField.IsHuman)
				{
					goto IL_0132;
				}
				CardGamePlayer cardGamePlayer = <player>k__BackingField;
				if (<player>k__BackingField != null)
				{
					if (((KPlayer)cardGamePlayer).<User>k__BackingField == null)
					{
						goto IL_0132;
					}
					bool flag = SFSKammelnaUserExtensions.IsVoiceMuted(((KPlayer)cardGamePlayer).<User>k__BackingField);
					gameObject = muteIndicator;
					bool flag2 = (object)muteIndicator == null;
					object obj = !flag2;
					active = flag;
					if (obj != null)
					{
						goto IL_0164;
					}
				}
			}
		}
		goto IL_0127;
		IL_0127:
		throw new NullReferenceException();
		IL_0164:
		gameObject.SetActive(active);
		return;
		IL_0132:
		gameObject = muteIndicator;
		bool flag3 = (object)muteIndicator == null;
		active = false;
		if (flag3)
		{
			goto IL_0127;
		}
		goto IL_0164;
	}

	private void RefreshSeatView()
	{
		if (CanJoinGame())
		{
			ShowSitHereButton();
		}
		else
		{
			ShowNormalUserbox();
		}
	}

	private void StartTimer(float time)
	{
		//IL_00f7: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_0099: Expected F4, but got I4
		//IL_0160: Expected O, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_029e: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_02e2: Expected O, but got I
		//IL_0358: Expected O, but got I
		bool flag = !isMyUserbox;
		float num = time;
		if (!flag)
		{
			CardGame cardGame = game;
			bool isWaitingForEating = cardGame.<Stage>k__BackingField.IsWaitingForEating;
			bool flag2 = !isWaitingForEating;
			object obj = !flag2;
			if (obj == null)
			{
				CardGame cardGame2 = game;
				bool isMoveNextRequired = cardGame2.<Stage>k__BackingField.IsMoveNextRequired;
				bool flag3 = !isMoveNextRequired;
				num = time;
				if (flag3)
				{
					goto IL_009e;
				}
			}
			num = 0f;
		}
		goto IL_009e;
		IL_009e:
		if (!<player>k__BackingField.IsHuman)
		{
			return;
		}
		bool flag4 = FloatExtensions.IsNearlyEqualTo(num, 0f);
		bool flag5 = !flag4;
		object obj2 = !flag5;
		object obj3 = ~obj2;
		double num2 = ((obj3 != null) ? 1.5 : 1.0);
		Sequence s;
		if (isMyUserbox)
		{
			EmoteViewer emoteViewer = this.emoteViewer;
			bool flag6 = !emoteViewer.<isEmotePlaying>k__BackingField;
			object obj4 = !flag6;
			if (obj4 == null)
			{
				object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v9+E4]");
				bool flag7 = (nint)0 == 0;
				object obj7 = !flag7;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				s = DOTween.Sequence();
				bool flag8 = FloatExtensions.IsNearlyEqualTo(num, 0f);
				if (!flag8)
				{
					object obj8 = 27;
				}
				else
				{
					object obj8 = 1;
				}
				if (flag8)
				{
					GameObject gameObject = timer.gameObject;
					bool activeSelf = gameObject.activeSelf;
					bool flag9 = !activeSelf;
					object obj9 = !flag9;
					if (obj9 != null)
					{
						goto IL_02ac;
					}
				}
				else
				{
					GameObject gameObject2 = timer.gameObject;
					bool activeSelf2 = gameObject2.activeSelf;
					bool flag10 = !activeSelf2;
					object obj10 = !flag10;
					if (obj10 == null)
					{
						goto IL_02ac;
					}
				}
			}
		}
		goto IL_0367;
		IL_02ac:
		Transform target = emoteImage.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, (float)num2, 0.2f);
		object obj11 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		Transform target2 = avatarImageBackground.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, (float)num2, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		object obj12 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		goto IL_0367;
		IL_0367:
		timer.StartTimer(num);
	}

	private void ProcessBubbleMessage(ChatMessageData messageData)
	{
		//IL_0049: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0147: Expected I8, but got I4
		//IL_016a: Expected O, but got I4
		//IL_010e: Expected I8, but got I4
		//IL_01af: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		string dBId = <player>k__BackingField.DBId;
		bool flag = messageData.<UserId>k__BackingField != dBId;
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Convert.ToInt32(messageData.<UserId>k__BackingField);
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			if (FriendsManager.IsBlocked(num))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = FriendsManager.IsBlocked(num);
			bool flag5 = !flag4;
			object obj7 = !flag5;
			if (obj7 != null)
			{
				return;
			}
		}
		ShowChatBubble(messageData.<Message>k__BackingField);
		bool chatActive = ChatHandler.ChatActive;
		bool flag6 = !chatActive;
		object obj8 = !flag6;
		if (obj8 != null)
		{
			return;
		}
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			if (!Preferences.ChatSound)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool chatSound = Preferences.ChatSound;
			bool flag7 = !chatSound;
			object obj11 = !flag7;
			if (obj11 == null)
			{
				return;
			}
		}
		GameSoundManager instance = GameSoundManager.Instance;
		instance.PlaySound(GameSoundEffect.CHAT_PING);
	}

	private void ShowChatBubble(string text)
	{
		//IL_008d: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0172: Expected O, but got I4
		int num = ShortcutExtensions.DOKill(chatBubble, complete: true);
		RectTransform rectTransform = chatBubble.rectTransform;
		int num2 = ShortcutExtensions.DOKill(rectTransform, complete: true);
		int num3 = ShortcutExtensions.DOKill(chatBubbleText, complete: true);
		GameObject gameObject = chatBubble.gameObject;
		gameObject.SetActive(value: true);
		RectTransform rectTransform2 = chatBubble.rectTransform;
		rectTransform2.localScale = (Vector3)0;
		object obj = (nint)0 + (nint)2904;
		RectTransform rectTransform3 = chatBubble.rectTransform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform3, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(chatBubble, 1f, 0f);
		TextMeshProExtensions.FixArabic(chatBubbleText, text);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ShortcutExtensionsTMPText.DOFade(chatBubbleText, 1f, 0f);
		object obj2 = (nint)0 + (nint)2736;
		object obj3 = text._stringLength * 1017370378;
		double num4 = (double)obj3 + 1.5;
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(chatBubble, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		TweenerCore<Color, Color, ColorOptions> tweenerCore5 = ShortcutExtensionsTMPText.DOFade(chatBubbleText, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void HideChatBubble(float delay = 0f)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2736;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(chatBubble, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ShortcutExtensionsTMPText.DOFade(chatBubbleText, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	public void ShowGameBubble(string text)
	{
		//IL_0026: Expected O, but got I
		//IL_006c: Expected O, but got I4
		//IL_007d: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_0166: Expected O, but got I4
		TextMeshProExtensions.Localize(bubbleText, text);
		gameBubble.SetActive(value: true);
		object obj = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		gameBubble.SetActive(value: true);
		Transform transform = gameBubble.transform;
		transform.localScale = (Vector3)0;
		object obj2 = (nint)0 + (nint)2904;
		Transform target = gameBubble.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		UnityEngine.Component target2 = default(UnityEngine.Component);
		int num = ShortcutExtensions.DOKill(target2, complete: true);
		int num2 = ShortcutExtensions.DOKill(bubbleText, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade((Image)target2, 1f, 0.1f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = ShortcutExtensionsTMPText.DOFade(bubbleText, 1f, 0.1f);
		object obj3 = (nint)0 + (nint)2736;
		object obj4 = text._stringLength * 1017370378;
		double num3 = (double)obj4 + 1.5;
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(bubbleImage, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		TweenerCore<Color, Color, ColorOptions> tweenerCore5 = ShortcutExtensionsTMPText.DOFade(bubbleText, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	protected void HideGameBubble(float delay = 0f)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2736;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(bubbleImage, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = ShortcutExtensionsTMPText.DOFade(bubbleText, 0f, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	protected void SetDealer(bool isDealer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00fe: Expected F4, but got O
		//IL_00fe: Expected O, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0131: Expected O, but got I
		//IL_0142: Expected I, but got O
		//IL_0153: Expected O, but got I
		//IL_00ca: Expected F4, but got O
		//IL_00ca: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (isMyUserbox)
		{
			dealerObject.SetActive(isDealer);
			return;
		}
		if (isDealer)
		{
			dealerObject.SetActive(value: true);
			int num = ShortcutExtensions.DOKill(dealerContainer);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(dealerContainer, (Vector2)0, (float)dealerContainerSize);
			return;
		}
		int num2 = ShortcutExtensions.DOKill(dealerContainer);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(dealerContainer, (Vector2)0, (float)dealerContainerSize);
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)2304;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void ShowPlayerTurnIndicator()
	{
		//IL_0038: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00b4: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(value: true);
		object obj = (nint)0 + (nint)696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj2 = (nint)0 + (nint)2816;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			object obj5 = 0;
			object obj6;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X22_v3+v180 @ X20_v5*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Image)0, 1f, 0.3f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				obj5++;
				obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+18]");
			}
			while ((nint)obj6 < 0);
		}
	}

	private void HidePlayerTurnIndicator()
	{
		//IL_0011: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0089: Expected O, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		object obj = (nint)0 + (nint)696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj2 = (nint)0 + (nint)2816;
			object obj4 = default(object);
			object obj3 = obj4 + 32;
			object obj5 = 0;
			object obj6;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X22_v3+v172 @ X20_v5*8]");
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Image)0, 0f, 0.3f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				obj5++;
				obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+18]");
			}
			while ((nint)obj6 < 0);
		}
	}

	private void StartVoiceAnimation(float value)
	{
		//IL_0030: Invalid comparison between F4 and I4
		//IL_009a: Expected O, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0225: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_0369: Expected O, but got I
		//IL_0383: Expected F4, but got I
		//IL_0383: Expected O, but got I4
		//IL_03d0: Expected O, but got I
		//IL_03e2: Expected F4, but got O
		//IL_03e2: Expected O, but got I4
		GameObject gameObject = soundIndicator.gameObject;
		gameObject.SetActive(value: true);
		if (value < 1.0354898E+09f)
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(soundIndicator, (Color)0, 0.7f);
			object obj = (nint)0 + (nint)2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
		else
		{
			bool flag = voiceIndicatorColorSequence == null;
			object obj2 = 0;
			bool flag2 = true;
			if (!flag)
			{
				TweenExtensions.Kill(voiceIndicatorColorSequence);
				obj2 = 0;
				flag2 = false;
			}
			double num = 1.0 - (double)value;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			voiceIndicatorColorSequence = sequence;
			object obj6 = this + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOColor(soundIndicator, (Color)0, 1f);
			object obj7 = (nint)0 + (nint)2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t = default(Tween);
			Sequence sequence2 = TweenSettingsExtensions.Join(voiceIndicatorColorSequence, t);
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v23+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = glowEffect;
				bool flag5 = !flag4;
				object obj10 = !flag5;
				if (obj10 != null)
				{
					goto IL_026f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)glowEffect)
				{
					goto IL_026f;
				}
			}
		}
		goto IL_0311;
		IL_026f:
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOColor(glowEffect, (Color)0, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(voiceIndicatorColorSequence, t2);
		Transform target = glowEffect.transform;
		object obj11 = typeof(UsageHint) + 744;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v21+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v22+8]");
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
		Sequence sequence4 = TweenSettingsExtensions.Join(voiceIndicatorColorSequence, t3);
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(glowEffect, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t4 = default(Tween);
		Sequence sequence5 = TweenSettingsExtensions.Append(voiceIndicatorColorSequence, t4);
		Transform target2 = glowEffect.transform;
		object obj14 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v27+B8]");
		object obj15 = 0;
		TweenerCore<Vector3, Vector3, VectorOptions> t5 = ShortcutExtensions.DOScale(target2, (Vector3)0, (float)obj15);
		Sequence sequence6 = TweenSettingsExtensions.Join(voiceIndicatorColorSequence, t5);
		goto IL_0311;
		IL_0311:
		GameObject gameObject2 = soundIndicator.gameObject;
		gameObject2.SetActive(value: true);
		TweenerCore<float, float, FloatOptions> tweenerCore5 = DOTweenModuleUI.DOFillAmount(soundIndicator, value, 0.3f);
	}

	private void StopVoiceAnimation()
	{
		//IL_000c: Expected O, but got I
		//IL_0026: Expected O, but got I4
		object obj = (nint)0 + (nint)2816;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(soundIndicator, (Color)0, 0.7f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ResetDefaultCardBacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0146: Expected I, but got O
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		bool isFastTrackGame = game.IsFastTrackGame;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		Sprite cardback = cardbackSprites.GetCardback(isFastTrackGame, fTLevel);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		object obj8 = (nint)0 + (nint)2312;
		object obj9 = (nint)0 + (nint)2344;
		object obj10 = obj2 + 16;
		obj10 = cardback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		ArraysExtensions.ForEach(cardBacks, action);
		object obj11 = Enumerable.First((IEnumerable<object>)cardBacks);
		Sprite sprite = ((SpriteRenderer)obj11).sprite;
		object obj12 = this + 184;
		obj12 = sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X20_v4+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X20_v4+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X8_v5+18] (should have been resolved before IL gen)");
		}
		RefreshShownCards();
	}

	private void ReorganizeCards()
	{
		//IL_0055: Expected O, but got I4
		//IL_0083: Expected F8, but got I4
		//IL_0e72: Expected O, but got I4
		//IL_0e82: Expected O, but got I4
		//IL_0eb0: Expected O, but got I4
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebf: Expected O, but got Unknown
		//IL_0075: Expected F8, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_042c: Expected F8, but got I4
		//IL_0435: Expected F8, but got I4
		//IL_02c8: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0344: Expected F8, but got I4
		//IL_034d: Expected F8, but got I4
		//IL_046e: Expected O, but got I4
		//IL_0499: Expected O, but got I4
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04cb: Expected F8, but got I4
		//IL_04d3: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_0f29: Expected I4, but got O
		//IL_0f34: Expected I4, but got O
		//IL_00bd: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0f11: Expected O, but got I4
		//IL_03ba: Expected F8, but got I4
		//IL_03c3: Expected F8, but got I4
		//IL_040d: Expected F8, but got I4
		//IL_0162: Expected F8, but got I4
		//IL_016b: Expected F8, but got I4
		//IL_0595: Expected O, but got I4
		//IL_05ab: Expected O, but got I
		//IL_05e7: Expected O, but got I
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_0201: Expected F8, but got I4
		//IL_0209: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0713: Expected I4, but got O
		//IL_071e: Expected I4, but got O
		//IL_0648: Expected O, but got I4
		//IL_065e: Expected O, but got I
		//IL_0684: Expected O, but got I
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Expected O, but got Unknown
		//IL_0893: Expected O, but got I4
		//IL_08a9: Expected O, but got I
		//IL_08dd: Expected O, but got I
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_0f97: Expected O, but got I
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected O, but got Unknown
		//IL_0fd4: Expected O, but got I4
		//IL_0fdd: Expected O, but got I4
		//IL_077a: Expected O, but got I
		//IL_0c9c: Expected O, but got I4
		//IL_0cc7: Expected O, but got I4
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected O, but got Unknown
		//IL_0cf9: Expected O, but got I4
		//IL_0a37: Expected I4, but got O
		//IL_0d22: Expected F8, but got I4
		//IL_10c6: Expected I4, but got O
		//IL_10d1: Expected I4, but got O
		//IL_10e7: Expected F8, but got I4
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff0: Expected O, but got Unknown
		//IL_1011: Expected O, but got I4
		//IL_1021: Unknown result type (might be due to invalid IL or missing references)
		//IL_1026: Expected O, but got Unknown
		//IL_104d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Expected O, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected O, but got Unknown
		//IL_0ae9: Expected I4, but got O
		//IL_0af4: Expected I4, but got O
		//IL_0d5a: Expected F8, but got I4
		//IL_086c: Expected F8, but got I4
		//IL_0b56: Expected O, but got I4
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected O, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected O, but got Unknown
		//IL_0d7a: Expected O, but got I
		//IL_0da3: Expected F8, but got I4
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected I4, but got Unknown
		//IL_0de4: Expected F8, but got I4
		//IL_0c1a: Expected O, but got I
		//IL_0c38: Expected O, but got I4
		//IL_0e12: Expected O, but got I4
		//IL_09e4: Expected O, but got I4
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected O, but got Unknown
		//IL_0a05: Expected O, but got I4
		//IL_0a0e: Expected F8, but got I4
		//IL_0a17: Expected F8, but got I4
		bool flag = isPlayerPrefab;
		if (isPlayerPrefab)
		{
			return;
		}
		FixDirection();
		object obj8;
		bool flag11;
		bool flag12;
		object obj9;
		object obj10;
		bool flag13;
		object obj11;
		object obj12;
		bool flag16;
		double num;
		object obj5;
		object obj4;
		object obj3;
		bool flag4;
		bool flag5;
		object obj6;
		object obj7;
		bool flag6;
		bool flag7;
		object obj2;
		double num4;
		double num2;
		double num3;
		if (<player>k__BackingField != null)
		{
			bool areCardsShown = <player>k__BackingField.AreCardsShown;
			bool flag2 = !areCardsShown;
			object obj = !flag2;
			obj2 = ~obj;
			num = ((obj2 != null) ? 1108869120.0 : 1116471296.0);
			flag = (byte)direction != 0;
			bool flag3 = direction < UserBoxDirection.Right;
			obj3 = !flag3;
			obj4 = direction - 1;
			flag4 = (nint)obj4 < 0;
			flag5 = obj4 == null;
			obj5 = direction ^ UserBoxDirection.Right;
			obj6 = direction ^ obj4;
			obj7 = obj5 & obj6;
			flag6 = (nint)obj7 < 0;
			flag7 = direction > UserBoxDirection.Right;
			if (!flag7)
			{
				if (~direction == UserBoxDirection.Bottom)
				{
					bool flag8 = direction < UserBoxDirection.Right;
					obj3 = !flag8;
					obj4 = direction - 1;
					flag4 = (nint)obj4 < 0;
					flag5 = obj4 == null;
					obj5 = direction ^ UserBoxDirection.Right;
					obj6 = direction ^ obj4;
					obj7 = obj5 & obj6;
					flag6 = (nint)obj7 < 0;
					flag7 = direction != UserBoxDirection.Right;
					if (flag7)
					{
						goto IL_03a9;
					}
					bool flag9 = <player>k__BackingField == null;
					num2 = 1116471296.0;
					num3 = 1108869120.0;
					if (flag9)
					{
						goto IL_0c49;
					}
					bool areCardsShown2 = <player>k__BackingField.AreCardsShown;
					bool flag10 = (areCardsShown2 ? 1 : 0) < (false ? 1 : 0);
					obj8 = !flag10;
					flag11 = (areCardsShown2 ? 1 : 0) < (false ? 1 : 0);
					flag12 = !areCardsShown2;
					obj9 = areCardsShown2 ^ areCardsShown2;
					obj10 = areCardsShown2 & obj9;
					flag13 = (nint)obj10 < 0;
					num2 = 30.0;
					num3 = 1115160576.0;
					obj11 = areCardsShown2;
					obj12 = areCardsShown2;
					goto IL_0efb;
				}
			}
			else
			{
				bool flag14 = direction < UserBoxDirection.Top;
				obj3 = !flag14;
				obj4 = direction - 2;
				flag4 = (nint)obj4 < 0;
				flag5 = direction == UserBoxDirection.Top;
				obj5 = direction ^ UserBoxDirection.Top;
				obj6 = direction ^ obj4;
				obj7 = obj5 & obj6;
				flag6 = (nint)obj7 < 0;
				if (!flag5)
				{
					bool flag15 = direction < UserBoxDirection.Left;
					obj3 = !flag15;
					obj4 = direction - 3;
					flag4 = (nint)obj4 < 0;
					flag5 = direction == UserBoxDirection.Left;
					obj5 = direction ^ UserBoxDirection.Left;
					obj6 = direction ^ obj4;
					obj7 = obj5 & obj6;
					flag6 = (nint)obj7 < 0;
					flag16 = flag7;
					num2 = 1116471296.0;
					num3 = 1108869120.0;
					flag13 = flag6;
					obj10 = obj7;
					obj9 = obj6;
					obj11 = obj5;
					flag12 = flag5;
					flag11 = flag4;
					obj12 = obj4;
					obj8 = obj3;
					num4 = 8.0;
					if (!flag5)
					{
						goto IL_03a9;
					}
					goto IL_0f1f;
				}
			}
			bool flag17 = <player>k__BackingField == null;
			num2 = 1116471296.0;
			num3 = 1108869120.0;
			if (!flag17)
			{
				bool areCardsShown3 = <player>k__BackingField.AreCardsShown;
				bool flag18 = (areCardsShown3 ? 1 : 0) < (false ? 1 : 0);
				obj8 = !flag18;
				flag11 = (areCardsShown3 ? 1 : 0) < (false ? 1 : 0);
				flag12 = !areCardsShown3;
				obj9 = areCardsShown3 ^ areCardsShown3;
				obj10 = areCardsShown3 & obj9;
				flag13 = (nint)obj10 < 0;
				num2 = 19.0;
				num3 = 1108082688.0;
				obj11 = areCardsShown3;
				obj12 = areCardsShown3;
				goto IL_0efb;
			}
		}
		goto IL_0c49;
		IL_0f1f:
		flag = (byte)(int)<player>k__BackingField != 0;
		bool flag19 = (byte)(int)(~<player>k__BackingField) != 0;
		flag7 = flag16;
		flag6 = flag13;
		obj7 = obj10;
		obj6 = obj9;
		obj5 = obj11;
		flag5 = flag12;
		flag4 = flag11;
		obj4 = obj12;
		obj3 = obj8;
		object obj13;
		object obj14;
		bool flag23;
		object obj15;
		object obj16;
		object obj17;
		double num6 = default(double);
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+58]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+58]");
			bool flag20 = (byte)(~(nuint)0u) != 0;
			flag7 = flag16;
			flag6 = flag13;
			obj7 = obj10;
			obj6 = obj9;
			obj5 = obj11;
			flag5 = flag12;
			flag4 = flag11;
			obj4 = obj12;
			obj3 = obj8;
			if (!flag20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
				bool flag21 = (nint)0 < (nint)1;
				obj3 = !flag21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
				obj4 = -1;
				flag4 = (nint)obj4 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
				flag5 = (nint)0 == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
				obj5 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
				obj6 = 0 ^ obj4;
				obj7 = obj5 & obj6;
				flag6 = (nint)obj7 < 0;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
					bool flag22 = (nint)0 < (nint)2;
					obj13 = !flag22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
					obj14 = -2;
					flag23 = obj14 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
					obj15 = (nint)0 ^ (nint)2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
					obj16 = 0 ^ obj14;
					obj17 = obj15 & obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
					if ((nint)0 == 2)
					{
						num *= 0.25;
						num4 = num * 0.5;
						double num5 = 0.5;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						bool flag24 = (nint)0 < (nint)1;
						obj3 = !flag24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						obj4 = -1;
						flag4 = (nint)obj4 < 0;
						flag5 = obj4 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						obj5 = (nint)0 ^ (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						obj6 = 0 ^ obj4;
						obj7 = obj5 & obj6;
						flag6 = (nint)obj7 < 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						if ((nint)0 < (nint)1)
						{
							goto IL_0c54;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
						double num5 = 0.0 + -1.0;
						num /= num5;
						num2 = -1.0;
						obj17 = obj7;
						obj16 = obj6;
						obj15 = obj5;
						flag23 = flag5;
						obj14 = obj4;
						obj13 = obj3;
					}
					goto IL_0f8b;
				}
				flag = (byte)(int)cardBacks != 0;
				bool flag25 = (byte)(int)(~cardBacks) != 0;
				flag7 = flag16;
				if (!flag25)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
					bool flag26 = (nint)0 == 0;
					flag7 = flag16;
					if (!flag26)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
						Transform transform = ((UnityEngine.Component)0).transform;
						bool flag27 = (object)transform == null;
						flag7 = flag16;
						if (!flag27)
						{
							Transform parent = transform.parent;
							bool flag28 = (object)parent == null;
							flag7 = flag16;
							if (!flag28)
							{
								Transform parent2 = parent.parent;
								bool flag29 = (object)parent2 == null;
								flag7 = flag16;
								if (!flag29)
								{
									Vector3 localEulerAngles = parent2.localEulerAngles;
									num4 = 0.0 - num6;
									flag7 = flag16;
									double num5 = num3;
									obj17 = obj7;
									obj16 = obj6;
									obj15 = obj5;
									flag23 = flag5;
									obj14 = obj4;
									obj13 = obj3;
									num = 0.0;
									goto IL_0f8b;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0c49;
		IL_0c49:
		throw new NullReferenceException();
		IL_0efb:
		flag16 = !flag12;
		obj2 = !flag16;
		num4 = ((obj2 != null) ? num2 : num3);
		goto IL_0f1f;
		IL_0f8b:
		object obj18 = (nint)0 + (nint)3792;
		object obj19 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj21 = default(object);
		object obj20 = obj21;
		double num7 = num6;
		double num8 = num2;
		UnityEngine.Object obj23 = default(UnityEngine.Object);
		UnityEngine.Object obj22 = obj23;
		object obj24 = 0;
		object obj25 = 0;
		UnityEngine.Object obj26 = default(UnityEngine.Object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DBF6DC");
			flag = (byte)(int)obj19 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+E4]");
			if ((nint)0 != 0)
			{
				if (obj26 != null)
				{
					obj23 = obj22;
					goto IL_0adf;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag30 = obj26 != null;
				bool flag31 = !flag30;
				obj23 = obj26;
				obj22 = obj26;
				if (!flag31)
				{
					goto IL_0adf;
				}
			}
			goto IL_0fe2;
			IL_0adf:
			flag = (byte)(int)cardBacks != 0;
			bool flag32 = (byte)(int)(~cardBacks) != 0;
			obj7 = obj17;
			obj6 = obj16;
			obj5 = obj15;
			flag5 = flag23;
			obj4 = obj14;
			obj3 = obj13;
			if (flag32)
			{
				break;
			}
			object obj27 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			bool flag33 = (nint)obj27 < 0;
			obj3 = !flag33;
			object obj28 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			obj4 = obj28 - 0;
			flag4 = (nint)obj4 < 0;
			flag5 = obj4 == null;
			object obj29 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			obj5 = obj29 ^ 0;
			obj6 = obj25 ^ obj4;
			obj7 = obj5 & obj6;
			flag6 = (nint)obj7 < 0;
			if (obj3 == null)
			{
				flag = (byte)(int)(flag + obj25) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
				Transform transform2 = ((UnityEngine.Component)0).transform;
				bool flag34 = (object)transform2 == null;
				object obj30 = !flag34;
				if (obj30 != null)
				{
					Transform parent3 = transform2.parent;
					double num9 = num * (double)obj24;
					num7 = num4 - num9;
					TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(parent3, (Vector3)0, 0f);
					obj24++;
					obj20 = 1045220557;
					num8 = 0.0;
					double num5 = 0.0;
					obj22 = obj23;
					goto IL_0fe2;
				}
				break;
			}
			throw new IndexOutOfRangeException();
			IL_0fe2:
			obj25++;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			bool flag35 = 0 < (nint)obj25;
			obj13 = !flag35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			obj14 = 0 - obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			flag23 = 0 == (nint)obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			obj15 = 0 ^ obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+18]");
			obj16 = 0 ^ obj14;
			obj17 = obj15 & obj16;
			obj7 = obj17;
			obj6 = obj16;
			obj5 = obj15;
			flag5 = flag23;
			obj4 = obj14;
			obj3 = obj13;
			obj23 = obj22;
			if (!flag23)
			{
				continue;
			}
			goto IL_0c54;
		}
		goto IL_0c49;
		IL_03a9:
		flag16 = flag7;
		num2 = 1116471296.0;
		num3 = 1108869120.0;
		flag13 = flag6;
		obj10 = obj7;
		obj9 = obj6;
		obj11 = obj5;
		flag12 = flag5;
		flag11 = flag4;
		obj12 = obj4;
		obj8 = obj3;
		num4 = 0.0;
		goto IL_0f1f;
		IL_0c54:
		if (<player>k__BackingField != null)
		{
			bool areCardsShown4 = <player>k__BackingField.AreCardsShown;
			bool flag36 = (areCardsShown4 ? 1 : 0) < (false ? 1 : 0);
			obj3 = !flag36;
			flag4 = (areCardsShown4 ? 1 : 0) < (false ? 1 : 0);
			flag5 = !areCardsShown4;
			obj6 = areCardsShown4 ^ areCardsShown4;
			obj7 = areCardsShown4 & obj6;
			flag6 = (nint)obj7 < 0;
			flag7 = !flag5;
			obj2 = !flag7;
			num4 = ((obj2 != null) ? 1080872141.0 : 4.0);
			flag = (byte)(int)cardBacks != 0;
			bool flag37 = (byte)(int)(~cardBacks) != 0;
			num2 = 4.0;
			num3 = 1080872141.0;
			if (!flag37)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
				bool flag38 = (nint)0 == 0;
				num2 = 4.0;
				num3 = 1080872141.0;
				if (!flag38)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v5 (System.Boolean)+20]");
					Transform transform3 = ((UnityEngine.Component)0).transform;
					bool flag39 = (object)transform3 == null;
					num2 = 4.0;
					num3 = 1080872141.0;
					if (!flag39)
					{
						Transform parent4 = transform3.parent;
						bool flag40 = (object)parent4 == null;
						num2 = 4.0;
						num3 = 1080872141.0;
						if (!flag40)
						{
							Transform parent5 = parent4.parent;
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(parent5, (Vector3)0, (float)num4);
							return;
						}
					}
				}
			}
		}
		goto IL_0c49;
	}

	public void OnGiftSelected(bool canBuy)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6829]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = sendGiftButton;
			obj6 = sendGiftButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = sendGiftButton;
			obj6 = sendGiftButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		if (canBuy)
		{
			EnableGiftButton();
		}
		else
		{
			sendGiftButton.interactable = false;
		}
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public void EnableGiftButton()
	{
		//IL_004c: Expected O, but got I
		//IL_0058: Expected O, but got I
		sendGiftButton.interactable = true;
		Transform target = sendGiftButton.transform;
		int num = ShortcutExtensions.DOKill(target, complete: true);
		object obj = (nint)0 + (nint)2440;
		object obj2 = (nint)0 + (nint)2904;
		Transform target2 = sendGiftButton.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target2, 0.8f, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void DisableGiftButton()
	{
		sendGiftButton.interactable = false;
	}

	public void DimUserbox()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E682B]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj5 = giftsButtonHolder;
			obj6 = giftsButtonHolder;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = giftsButtonHolder;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = giftsButtonHolder;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		return;
		IL_0160:
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			if (currentGame == Games.Jackaroo)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			if (currentGame2 == Games.Jackaroo)
			{
				return;
			}
		}
		object sortingLayerName = "AvailableVoices" + 808;
		canvas.sortingLayerName = (string)sortingLayerName;
		SpriteRenderer[] array = cardBacks;
		if (array.Length >= 1)
		{
			object obj11 = array + 32;
			object obj12 = 0;
			do
			{
				obj12++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X23_v5+v225 @ X22_v6*8]");
				((Renderer)0).sortingLayerName = (string)sortingLayerName;
			}
			while ((nint)obj12 < array.Length);
		}
		giftsButtonHolder.SetActive(value: true);
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj13 = !flag6;
		obj8 = 0;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0160;
	}

	public void UnDimUserbox()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0204: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E682C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = giftsButtonHolder;
			obj6 = giftsButtonHolder;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = giftsButtonHolder;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = giftsButtonHolder;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		object sortingLayerName = "Unsupported map type" + 856;
		canvas.sortingLayerName = (string)sortingLayerName;
		SpriteRenderer[] array = cardBacks;
		if (array.Length >= 1)
		{
			object obj9 = array + 32;
			object sortingLayerName2 = "HH:mm:ss.ffZ" + 656;
			object obj10 = 0;
			do
			{
				obj10++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X22_v5+v158 @ X21_v8*8]");
				((Renderer)0).sortingLayerName = (string)sortingLayerName2;
			}
			while ((nint)obj10 < array.Length);
		}
		giftsButtonHolder.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void ShowControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01d6: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E682D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_015e;
		IL_015e:
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		float num = default(float);
		if (num < _restingLocalScale)
		{
			Transform target = base.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, _restingLocalScale, 0.3f);
		}
		bool isCurrentPerspectiveTopDown = gameVisualControls.IsCurrentPerspectiveTopDown;
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v155 @ X8_v5 (Il2CppClass<Userbox>)+1F8] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_014e:
		uiSlider.SlideIn();
		goto IL_015e;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_014e;
		}
		goto IL_015e;
	}

	public void HideControls()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E682E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = uiSlider;
			obj6 = uiSlider;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_015e;
		IL_015e:
		Transform transform = base.transform;
		Vector3 localScale = transform.localScale;
		object obj8 = default(object);
		if ((nint)obj8 > 0)
		{
			Transform target = base.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, 0.3f);
		}
		return;
		IL_014e:
		uiSlider.SlideOut();
		goto IL_015e;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_014e;
		}
		goto IL_015e;
	}

	public void HideProjectCards()
	{
		cardsRevealer.HideImmediate();
	}

	protected virtual void OnGamePerspectiveChanged(bool isPerspectiveTopDown)
	{
	}

	private void OnDealBatchStarted()
	{
		_isDealAnimating = true;
	}

	private void OnDealBatchComplete()
	{
		_isDealAnimating = false;
		RefreshShownCards();
	}

	protected virtual void OnSitHereButtonClick()
	{
		ShowEnteringMessage();
		CardGamePlayer cardGamePlayer = <player>k__BackingField;
		game.SendSwitchRequest(((KPlayer)cardGamePlayer).<Index>k__BackingField);
	}

	private void ShowEnteringMessage()
	{
		filledCaseObject.SetActive(value: false);
		emptyCaseObject.SetActive(value: true);
		GameObject gameObject = EnteringText.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = SitHereButton.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void ShowSitHereButton()
	{
		filledCaseObject.SetActive(value: false);
		emptyCaseObject.SetActive(value: true);
		GameObject gameObject = EnteringText.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = SitHereButton.gameObject;
		gameObject2.SetActive(value: true);
	}

	private void ShowNormalUserbox()
	{
		filledCaseObject.SetActive(value: true);
		emptyCaseObject.SetActive(value: false);
		GameObject gameObject = EnteringText.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = SitHereButton.gameObject;
		gameObject2.SetActive(value: false);
	}

	protected virtual bool CanJoinGame()
	{
		//IL_013d: Expected I4, but got O
		//IL_0048: Expected O, but got I4
		if ((object)game != null)
		{
			bool isReplay = game.IsReplay;
			bool flag = !isReplay;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0129;
			}
			if ((object)game != null)
			{
				if (!game.IsSpectator)
				{
					goto IL_0129;
				}
				if (<player>k__BackingField != null)
				{
					if (!<player>k__BackingField.IsJoinable)
					{
						goto IL_0129;
					}
					if ((object)game != null)
					{
						Room room = game.Room;
						return SFSKammelnaRoomExtensions.IsJoinable(room);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0129:
		return false;
	}

	public void ShowMiniChat()
	{
		gameEventsChannel.TriggerShowMiniChat();
	}

	public void OpenGiftBoxForPlayer()
	{
		gameEventsChannel.TriggerShowGiftPanelAndActivatePlayer((int)direction);
	}

	public void OpenControls()
	{
		gameEventsChannel.TriggerPlayerClicked(<player>k__BackingField);
	}

	private void <OnGameInitialized>b__86_0()
	{
		gameEventsChannel.TriggerPlayerClicked(<player>k__BackingField);
	}

	private void <OnGameInitialized>b__86_1()
	{
		gameEventsChannel.TriggerPlayerGiftClicked(<player>k__BackingField);
	}

	private void <RefreshCardBack>b__103_0(bool success)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		if (success)
		{
			object obj = Enumerable.First((IEnumerable<object>)cardBacks);
			Sprite sprite = ((SpriteRenderer)obj).sprite;
			object obj2 = this + 184;
			obj2 = sprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v4+8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v4+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v79 @ X8_v5+18] (should have been resolved before IL gen)");
			}
			RefreshShownCards();
		}
		else
		{
			ResetDefaultCardBacks();
		}
	}
}
