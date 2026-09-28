using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Device;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class Hand : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameCard, bool> <>9__61_0;

		public static Func<GameCard, bool> <>9__63_0;

		public static Func<GameCard, Card> <>9__63_1;

		public static Func<Card, bool> <>9__63_2;

		public static Func<Card, bool> <>9__63_5;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <DoPendingAction>b__61_0(GameCard gameCard)
		{
			//IL_0080: Expected I4, but got O
			//IL_0056: Expected O, but got I4
			if ((object)gameCard != null)
			{
				bool flag = gameCard.isActiveAndEnabled;
				if (flag)
				{
					object obj = gameCard.<CardStatus>k__BackingField - 3;
					bool flag2 = obj == null;
					flag = flag2;
				}
				return flag;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ShowActualHandCards>b__63_0(GameCard gameCard)
		{
			//IL_0067: Expected I4, but got O
			if ((object)gameCard != null)
			{
				GameObject gameObject = gameCard.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <ShowActualHandCards>b__63_1(GameCard gameCard)
		{
			if ((object)gameCard != null)
			{
				return ((UiCard)gameCard).card;
			}
			return (Card)(object)new NullReferenceException();
		}

		internal bool <ShowActualHandCards>b__63_2(Card card)
		{
			return card == null;
		}

		internal bool <ShowActualHandCards>b__63_5(Card card)
		{
			bool flag = card == null;
			return !flag;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public IEnumerable<Card> activeCardsInHand;

		public List<Card> allCards;

		internal bool <ShowActualHandCards>b__3(Card serverCard)
		{
			return Enumerable.Contains((IEnumerable<object>)activeCardsInHand, (object)serverCard);
		}

		internal bool <ShowActualHandCards>b__4(Card handCard)
		{
			//IL_002c: Expected I4, but got O
			if (allCards != null)
			{
				return ((List<object>)(object)allCards).Contains((object)handCard);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass69_0
	{
		public Card card;

		internal bool <CardClicked>b__0(GameCard gc)
		{
			//IL_0073: Expected I4, but got O
			if ((object)gc != null)
			{
				bool isActiveAndEnabled = gc.isActiveAndEnabled;
				if (isActiveAndEnabled)
				{
					return object.Equals(((UiCard)gc).card, card);
				}
				return isActiveAndEnabled;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass71_0
	{
		public Card card;

		internal bool <DoPlayCard>b__0(GameCard gc)
		{
			//IL_0073: Expected I4, but got O
			if ((object)gc != null)
			{
				bool isActiveAndEnabled = gc.isActiveAndEnabled;
				if (isActiveAndEnabled)
				{
					return object.Equals(((UiCard)gc).card, card);
				}
				return isActiveAndEnabled;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass73_0
	{
		public Vector3 flippedRotation;

		internal bool <AnimateFlipCardsToTheirBack>b__0(GameCard card)
		{
			//IL_00fe: Expected I4, but got O
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			if ((object)card != null)
			{
				Transform transform = card.transform;
				if ((object)transform != null)
				{
					Vector3 localEulerAngles = transform.localEulerAngles;
					object obj2 = default(object);
					object obj = obj2 - (object)flippedRotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Hand+<>c__DisplayClass73_0)+14]");
					object obj4 = default(object);
					object obj3 = obj4 - 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Hand+<>c__DisplayClass73_0)+18]");
					object obj6 = default(object);
					object obj5 = obj6 - 0;
					object obj7 = obj * obj;
					object obj8 = obj3 * obj3;
					object obj9 = obj7 + obj8;
					object obj10 = obj5 * obj5;
					object obj11 = obj10 + obj9;
					object obj12 = obj11 - 786163454;
					return (nint)obj12 < 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const float OriginalYPos = 1960f;

	protected CardGamePlayer player;

	protected bool playedCardThisTurn;

	public int maxCardsInBottomRow;

	protected CardGameVisualControls gameVisualControls;

	protected CardGame game;

	private GameCard <CardHit>k__BackingField;

	private Vector2 _initialMousePosition;

	public GameCard[] gameCardsSprite;

	private TextMeshPro specialPlayPriceTagText;

	private GameObject specialPlayPriceTag;

	private bool _isFireModeActive;

	protected GameEventsChannel gameEventsChannel;

	protected GameSoundAlbum gameSoundAlbum;

	private const float swipeActivationDistance = 100f;

	protected Ray _ray;

	private bool SwipedUp;

	private bool ReturnedCardWithSwipeDown;

	protected bool IsCardBeingAnimated;

	private bool IsNotAClick;

	private List<RaycastResult> raycastResults;

	private string gameCardHash;

	private StoreItem _specialPlayItem;

	protected Camera _mainCamera;

	protected CardsOrganizer<GameCard> _organizer;

	private Action m_OnHandChanged;

	protected bool _cardChanged;

	protected const string NotEnoughAcesString = "not_enough_aces";

	protected GameCard CardHit
	{
		get
		{
			return <CardHit>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected bool IsFireModeActive
	{
		get
		{
			return _isFireModeActive;
		}
		set
		{
			//IL_000f: Expected I, but got O
			//IL_001f: Expected O, but got I
			//IL_002f: Expected O, but got I
			_isFireModeActive = value;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Hand>)+288]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Hand>)+290]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected bool CanAffordSpecialPlay
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_013a: Expected I4, but got O
			//IL_00ce: Expected O, but got I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected I4, but got Unknown
			if (_specialPlayItem != null)
			{
				object obj = typeof(Queue<string>) + 848;
				object obj2 = (nint)0 + (nint)2200;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					int aces = SFSKammelnaUserExtensions.GetAces(localUser);
					int num = StorePricing.EffectivePrice(_specialPlayItem);
					object obj5 = aces - num;
					bool flag2 = (nint)obj5 < 0;
					int num2 = aces ^ num;
					int num3 = aces ^ obj5;
					int num4 = num2 & num3;
					bool flag3 = num4 < 0;
					return flag2 == flag3;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
	}

	protected virtual float SwipeOffset => 1.1204035E+09f;

	public event Action OnHandChanged
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_016b: Expected O, but got I
		//IL_0177: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = (nint)0 + (nint)32;
		object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 2752;
		object obj5 = (nint)0 + (nint)1192;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 56;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj10 = this + 48;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @438A0FC");
		object obj13 = default(object);
		object obj12 = obj13 + 48;
		obj12 = gameCardsSprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj13 + 40;
		obj14 = this;
		_ = 1050253722;
		_ = 1156907008;
		_ = maxCardsInBottomRow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		object obj15 = this + 192;
		obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Camera main = Camera.main;
		object obj16 = this + 184;
		obj16 = main;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006c: Expected I, but got O
		//IL_002a: Expected I, but got O
		//IL_003a: Expected O, but got I
		//IL_004a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)600;
		Action action = default(Action);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			StorePricing.OnPricingChanged += action;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<Hand>)+188]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<Hand>)+190]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
	}

	protected virtual void FetchSpecialPlayFromStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)576;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	private void RefreshSpecialPlayPrice()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_007e: Expected I, but got O
		//IL_00a3: Expected I, but got O
		if (_specialPlayItem != null)
		{
			object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 680;
			TextMeshPro textMeshPro = specialPlayPriceTagText;
			int num = StorePricing.EffectivePrice(_specialPlayItem);
			int num2 = default(int);
			string text = num2.ToString();
			string text2 = text + (string)obj;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
			object obj3 = (nint)0 + (nint)584;
			nint num3 = (nint)textMeshPro;
			textMeshPro.text = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj3);
			ArraysExtensions.ForEach(gameCardsSprite, action);
		}
	}

	private void OnEnable()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Hand>)+1E8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Hand>)+1F0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDisable()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Hand>)+1F8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<Hand>)+200]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Update()
	{
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_009a: Expected I, but got O
		//IL_00aa: Expected O, but got I
		//IL_00ba: Expected O, but got I
		if (!InputUtil.PointerHeld || IsCardBeingAnimated)
		{
			if (!InputUtil.PointerReleasedThisFrame)
			{
				return;
			}
			object obj = 440;
			object obj2 = 448;
		}
		else
		{
			object obj = 424;
			object obj2 = 432;
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v1 (Il2CppClass<Hand>)+v51 @ X9_v1]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X10_v1 (Il2CppClass<Hand>)+v62 @ X8_v1]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected unsafe virtual void OnMouseButton()
	{
		//IL_0059: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_013e: Expected O, but got I4
		//IL_016d: Expected O, but got Ref
		//IL_034a: Expected O, but got I4
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0224: Expected O, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0283: Expected O, but got I4
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected O, but got Unknown
		//IL_0a39: Invalid comparison between F4 and I4
		//IL_02e5: Expected O, but got F4
		//IL_030d: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_0394: Expected I4, but got O
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected I4, but got Unknown
		//IL_03be: Expected O, but got I4
		//IL_03c7: Expected O, but got I4
		//IL_03cf: Expected I4, but got O
		//IL_052c: Invalid comparison between F8 and I4
		//IL_03f4: Expected O, but got I4
		//IL_07bf: Invalid comparison between F8 and I4
		//IL_0657: Expected O, but got F8
		//IL_04b7: Invalid comparison between F8 and I4
		//IL_04c9: Expected F4, but got I4
		//IL_081a: Expected F8, but got I4
		//IL_0a70: Expected O, but got I4
		//IL_08f2: Invalid comparison between F8 and I8
		//IL_04ec: Expected O, but got I4
		//IL_0a9c: Expected O, but got I4
		//IL_0aa5: Expected F8, but got I4
		//IL_070d: Expected O, but got I4
		//IL_0515: Expected F4, but got I4
		//IL_0922: Expected O, but got I8
		//IL_0622: Expected O, but got I4
		//IL_062b: Expected O, but got I4
		//IL_08ce: Expected O, but got I4
		//IL_08ce: Expected O, but got I4
		//IL_08d7: Expected O, but got I4
		//IL_07a3: Expected O, but got I4
		//IL_07a3: Expected O, but got I4
		//IL_0985: Expected O, but got I4
		//IL_07b1: Expected O, but got I4
		CardGame cardGame = game;
		if (!((KGame)cardGame).<GamePhase>k__BackingField.IsGameStarted)
		{
			return;
		}
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		CardGamePlayer myPlayer = game.MyPlayer;
		if (!myPlayer.IsHumanSeated || !CanClickGoThrough())
		{
			return;
		}
		_cardChanged = false;
		Vector2 pointerPosition = InputUtil.PointerPosition;
		Ray ray = CameraInputExtensions.ScreenPointToRayThroughRenderTexture(_mainCamera, (Vector3)0);
		Ray ray2 = default(Ray);
		_ray = ray2;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 400;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Ray ray3 = default(Ray);
		object obj5;
		double num8;
		float num9;
		if (Physics.Raycast((Ray)(&ray3), out var hitInfo, 250000f))
		{
			Collider collider = hitInfo.collider;
			GameObject gameObject = collider.gameObject;
			object tag = "Cannot populate JSON object onto type '{0}'." + 1648;
			if (gameObject.CompareTag((string)tag))
			{
				obj5 = this + 64;
				Collider collider2 = hitInfo.collider;
				GameObject gameObject2 = collider2.gameObject;
				object obj6 = (nint)0 + (nint)1272;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				object obj7 = default(object);
				obj5 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v22+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (_cardChanged = (UnityEngine.Object)obj5 != (UnityEngine.Object)obj5)
				{
					ReturnedCardWithSwipeDown = false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4E9BE04");
				float num = (float)_initialMousePosition - 1.215571E+09f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Hand)+4C]");
				object obj12 = default(object);
				object obj11 = 0 - obj12;
				float num2 = num * num;
				object obj13 = obj11 * obj11;
				float num3 = num2 + (float)obj13;
				if (num3 < 786163460f || _cardChanged)
				{
					Vector2 pointerPosition2 = InputUtil.PointerPosition;
					_initialMousePosition = (Vector2)num3;
					_ = 786163454;
				}
				GameCard gameCard = (GameCard)obj5;
				bool flag4 = !gameCard._isDimmed;
				float? num4 = (float?)(object)0;
				if (flag4)
				{
					bool flag5 = gameCard.<CardStatus>k__BackingField == CardStatus.InHand;
					object obj14 = !flag5;
					num4 = (float?)(object)0;
					CardStatus cardStatus = (CardStatus)obj5;
					if (obj14 == null)
					{
						bool flag6 = !ReturnedCardWithSwipeDown;
						object obj15 = !flag6;
						num4 = (float?)(object)0;
						cardStatus = (CardStatus)obj5;
						if (obj15 == null)
						{
							gameCard.SetStatus(CardStatus.Prepared);
							num4 = (float?)(object)0;
							cardStatus = CardStatus.Prepared;
						}
					}
					Vector2 pointerPosition3 = InputUtil.PointerPosition;
					double num5 = 786163454.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Hand)+4C]");
					double num6 = num5 - 0.0;
					int height = UnityEngine.Device.Screen.height;
					int num7 = (int)(num6 / height);
					num8 = (double)num7 * 1156579328.0;
					if (num8 > 20.0 || (num8 > 0.0 && IsNotAClick))
					{
						SwipedUp = true;
						GameCard gameCard2 = <CardHit>k__BackingField;
						GameCard gameCard3;
						CardStatus status;
						if (gameCard2.<CardStatus>k__BackingField != CardStatus.InHand)
						{
							bool flag7 = !(num8 > 1120403456.0);
							num9 = 1.1204035E+09f;
							if (flag7)
							{
								goto IL_0687;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2844D90");
							_initialMousePosition = (Vector2)1120403456;
							_ = 1156579328;
							IsNotAClick = false;
							gameCard3 = <CardHit>k__BackingField;
							num9 = 1.1204035E+09f;
							status = CardStatus.Preplay;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2844D90");
							_initialMousePosition = (Vector2)20.0;
							_ = 1156579328;
							gameCard3 = <CardHit>k__BackingField;
							num9 = 20f;
							status = CardStatus.Prepared;
						}
						gameCard3.SetStatus(status);
						num4 = (float?)(object)0;
						goto IL_0687;
					}
					if (num8 < -20.0 || (num8 < 0.0 && IsNotAClick))
					{
						SwipedUp = false;
						GameCard gameCard4 = <CardHit>k__BackingField;
						double num10;
						bool flag10;
						if (gameCard4.<CardStatus>k__BackingField != CardStatus.InHand)
						{
							IsNotAClick = true;
							if (gameCard4.<CardStatus>k__BackingField == CardStatus.Preplay)
							{
								gameCard4.SetStatus(CardStatus.PreparedForClick);
								gameCard4 = (GameCard)obj5;
								bool flag8 = obj5 == null;
								object obj16 = !flag8;
								num4 = (float?)(object)0;
								if (obj16 == null)
								{
									throw new NullReferenceException();
								}
							}
						}
						else
						{
							bool flag9 = !IsNotAClick;
							num10 = 1156579328.0;
							flag10 = (byte)cardStatus != 0;
							if (flag9)
							{
								goto IL_08e5;
							}
							IsNotAClick = IsNotAClick;
						}
						bool isAnimating = gameCard4.IsAnimating;
						bool flag11 = !isAnimating;
						object obj17 = !flag11;
						num10 = 1156579328.0;
						flag10 = false;
						if (obj17 == null)
						{
							Transform gObject = ((Component)obj5).transform;
							object obj18 = obj5;
							float swipeOffset = SwipeOffset;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v35+30]");
							double num11 = 0.0 + -20.0;
							num10 = num8 * 0.5;
							float value = (float)num10 + (float)num11;
							float? y = value;
							UIExtensions.MoveTo(gObject, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
							num4 = (float?)(object)0;
							flag10 = false;
						}
						goto IL_08e5;
					}
				}
				goto IL_031b;
			}
		}
		bool flag12 = !SwipedUp;
		object obj19 = !flag12;
		if (obj19 == null)
		{
			ReturnCardsToHand();
		}
		return;
		IL_0687:
		GameCard gameCard5 = (GameCard)obj5;
		if (gameCard5.<CardStatus>k__BackingField != CardStatus.Preplay || IsNotAClick)
		{
			IsNotAClick = true;
			bool isAnimating2 = gameCard5.IsAnimating;
			bool flag13 = !isAnimating2;
			object obj20 = !flag13;
			if (obj20 == null)
			{
				Transform gObject2 = ((Component)obj5).transform;
				object obj21 = obj5;
				float swipeOffset2 = SwipeOffset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v54+30]");
				float num12 = 0f + num9;
				double num13 = num8 * 0.5;
				float value2 = (float)num13 + num12;
				float? y = value2;
				UIExtensions.MoveTo(gObject2, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
				float? num4 = (float?)(object)0;
			}
		}
		goto IL_031b;
		IL_031b:
		ReturnCardsToHandExcept(<CardHit>k__BackingField);
		UpdatePriceTag();
		return;
		IL_08e5:
		if (num8 < 3259498496.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2844D90");
			_initialMousePosition = (Vector2)3259498496L;
			ReturnedCardWithSwipeDown = true;
			IsNotAClick = false;
			GameCard gameCard6 = <CardHit>k__BackingField;
			if (gameCard6.<CardStatus>k__BackingField != CardStatus.InHand)
			{
				gameCard6.SetStatus(CardStatus.InHand);
				float? num4 = (float?)(object)0;
			}
		}
		goto IL_031b;
	}

	private void ReturnCardsToHandExcept(GameCard exceptCard)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		//IL_0185: Expected O, but got I
		//IL_0064: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		GameCard[] array = gameCardsSprite;
		object obj = gameCardsSprite + 32;
		if ((object)exceptCard != null)
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj2 = 0;
			do
			{
				string text = exceptCard.name;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X23_v2+v51 @ X24_v5*8]");
				string text2 = ((UnityEngine.Object)0).name;
				bool flag = text == text2;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X23_v2+v51 @ X24_v5*8]");
					((GameCard)0).SetStatus(CardStatus.InHand);
				}
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		else
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj4 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X23_v2+v49 @ X20_v5*8]");
				string text3 = ((UnityEngine.Object)0).name;
				bool flag3 = null == text3;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X23_v2+v49 @ X20_v5*8]");
					((GameCard)0).SetStatus(CardStatus.InHand);
				}
				obj4++;
			}
			while ((nint)obj4 < array.Length);
		}
	}

	private void ReturnCardsToHand()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameCard)0).SetStatus(CardStatus.InHand);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	protected virtual void OnMouseButtonUp()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0228: Expected I, but got O
		//IL_0238: Expected O, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0279: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_02d3: Expected O, but got I
		//IL_02ae: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6707]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		UnityEngine.Object obj5;
		UnityEngine.Object obj7;
		object obj8;
		if (obj3 != null)
		{
			obj4 = this + 64;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (!flag)
			{
				goto IL_00a0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 64;
			obj5 = (UnityEngine.Object)obj4;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = (UnityEngine.Object)obj4;
			obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00a0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7 != null;
		bool flag4 = !flag3;
		object obj10 = 0;
		obj4 = obj8;
		if (flag4)
		{
			goto IL_00e3;
		}
		goto IL_0223;
		IL_0158:
		_ = 1;
		object obj11 = obj10;
		object obj13;
		object obj12 = obj13;
		obj8 = obj4;
		goto IL_02bb;
		IL_00e3:
		SwipedUp = false;
		obj13 = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj14 = (nint)0 & (nint)1;
		bool flag5 = obj14 == null;
		object obj15 = !flag5;
		obj11 = obj10;
		obj12 = obj13;
		obj8 = obj4;
		if (obj15 == null)
		{
			goto IL_0158;
		}
		goto IL_02bb;
		IL_02bb:
		object obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v3+B8]");
		object initialMousePosition = 0;
		_initialMousePosition = (Vector2)initialMousePosition;
		<CardHit>k__BackingField = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_00a0:
		bool flag6 = obj5 != null;
		bool flag7 = !flag6;
		object obj17 = !flag7;
		obj10 = 0;
		obj8 = obj4;
		if (obj17 == null)
		{
			goto IL_00e3;
		}
		goto IL_0223;
		IL_0223:
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (Il2CppClass<Hand>)+1D0]");
		obj10 = 0;
		OnTouchUp(<CardHit>k__BackingField);
		SwipedUp = false;
		obj13 = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj18 = (nint)0 & (nint)1;
		bool flag8 = obj18 == null;
		obj4 = obj8;
		if (flag8)
		{
			goto IL_0158;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v6 (Il2CppClass<Hand>)+1D0]");
		obj11 = 0;
		obj12 = obj13;
		goto IL_02bb;
	}

	protected virtual void OnTouchUp(GameCard gameCard)
	{
		//IL_005c: Expected O, but got I8
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_00a6: Expected I, but got O
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		ReturnCardsToHandExcept(<CardHit>k__BackingField);
		if (gameCard.<CardStatus>k__BackingField == CardStatus.Prepared)
		{
			gameCard.SetStatus(CardStatus.PreparedForClick);
			return;
		}
		object obj = (long)gameCard.<CardStatus>k__BackingField & 0xFFFFFFFEL;
		if (IsNotAClick)
		{
			if ((nint)obj != 2)
			{
				return;
			}
			nint num = (nint)gameCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (Il2CppClass<GameCard>)+188]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (Il2CppClass<GameCard>)+190]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v90 @ X2_v2 (should have been resolved before IL gen)");
		}
		if ((nint)obj == 2)
		{
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v3 (Il2CppClass<Hand>)+1D8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v3 (Il2CppClass<Hand>)+1E0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnCardClicked(GameCard clickedGameCard)
	{
		//IL_0012: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0032: Expected O, but got I
		Card card = ((UiCard)clickedGameCard).card;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Hand>)+268]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<Hand>)+270]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected bool CanClickGoThrough()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_051e: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0130: Expected O, but got I
		//IL_04a1: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_023a: Expected I4, but got O
		//IL_028a: Expected O, but got I
		//IL_0296: Expected O, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I
		//IL_03ec: Expected I4, but got O
		//IL_0427: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_0360: Expected O, but got I4
		//IL_0393: Expected I, but got O
		object obj = typeof(DataRelation) + 3776;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1224;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		EventSystem current = EventSystem.current;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PointerEventData pointerEventData = default(PointerEventData);
		pointerEventData..ctor(current);
		Vector2 pointerPosition = InputUtil.PointerPosition;
		bool flag2 = pointerEventData == null;
		List<RaycastResult>.Enumerator enumerator = (List<RaycastResult>.Enumerator)0;
		List<RaycastResult>.Enumerator enumerator2 = (List<RaycastResult>.Enumerator)0;
		int num = 0;
		EventSystem eventSystem = current;
		EventSystem eventSystem2 = current;
		bool result;
		if (!flag2)
		{
			pointerEventData.<position>k__BackingField = (Vector2)0;
			List<RaycastResult> list = raycastResults;
			bool flag3 = raycastResults == null;
			enumerator = (List<RaycastResult>.Enumerator)0;
			enumerator2 = (List<RaycastResult>.Enumerator)0;
			num = 0;
			eventSystem = current;
			eventSystem2 = current;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+1C]");
				object obj5 = (nint)0 + (nint)1;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+18]");
				bool flag4 = (nint)0 < (nint)1;
				eventSystem = current;
				if (!flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+18]");
					Array.Clear((Array)num2, 0, 0);
					object obj6 = 0;
					eventSystem = null;
				}
				EventSystem current2 = EventSystem.current;
				bool flag5 = (object)current2 == null;
				enumerator = (List<RaycastResult>.Enumerator)0;
				enumerator2 = (List<RaycastResult>.Enumerator)0;
				eventSystem2 = current;
				if (!flag5)
				{
					List<RaycastResult> list2 = raycastResults;
					current2.RaycastAll(pointerEventData, raycastResults);
					List<RaycastResult> list3 = raycastResults;
					bool flag6 = raycastResults == null;
					enumerator = (List<RaycastResult>.Enumerator)0;
					enumerator2 = (List<RaycastResult>.Enumerator)0;
					object obj6 = 0;
					num = (int)raycastResults;
					eventSystem = (EventSystem)(object)pointerEventData;
					eventSystem2 = current;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v30 (System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)+18]");
						if ((nint)0 < (nint)1)
						{
							goto IL_04af;
						}
						object obj7 = (nint)0 + (nint)480;
						object obj8 = (nint)0 + (nint)1312;
						object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
						eventSystem2 = (EventSystem)((nint)0 + (nint)472);
						List<RaycastResult>.Enumerator enumerator3 = raycastResults.GetEnumerator();
						bool flag7;
						List<RaycastResult>.Enumerator enumerator4 = default(List<RaycastResult>.Enumerator);
						object obj10 = default(object);
						UnityEngine.Object obj13 = default(UnityEngine.Object);
						object obj15 = default(object);
						List<RaycastResult>.Enumerator enumerator6 = default(List<RaycastResult>.Enumerator);
						List<RaycastResult>.Enumerator enumerator5 = default(List<RaycastResult>.Enumerator);
						while (true)
						{
							eventSystem = (EventSystem)obj7;
							flag7 = enumerator4.MoveNext();
							if (!flag7)
							{
								break;
							}
							if (obj10 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
								object obj11 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X0_v41+E4]");
								bool flag8 = (nint)0 == 0;
								object obj12 = !flag8;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag9 = obj13 == null;
								bool flag10 = !flag9;
								object obj14 = !flag10;
								if (obj14 != null)
								{
									break;
								}
								if ((object)obj13 != null)
								{
									nint num3 = (nint)obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v439 @ X8_v17 (Il2CppClass<UnityEngine.Object>)+298] (should have been resolved before IL gen)");
									bool flag11 = obj15 == null;
									list2 = null;
									if (!flag11)
									{
										break;
									}
									continue;
								}
								NullReferenceException ex = new NullReferenceException();
								num = 0;
								eventSystem = null;
							}
							else
							{
								NullReferenceException ex2 = new NullReferenceException();
								num = (int)list2;
							}
							enumerator = enumerator5;
							enumerator2 = enumerator6;
							enumerator5 = (List<RaycastResult>.Enumerator)0;
							obj6 = 0;
							goto IL_052c;
						}
						result = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
						enumerator4.Dispose();
						goto IL_056c;
					}
				}
			}
		}
		goto IL_052c;
		IL_052c:
		NullReferenceException ex3 = new NullReferenceException();
		bool flag12 = (nint)eventSystem != 1;
		NullReferenceException ex4 = ex3;
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			eventSystem = eventSystem2;
			enumerator.Dispose();
			object obj16 = default(object);
			bool flag13 = obj16 == null;
			object obj17 = !flag13;
			if (obj17 == null)
			{
				goto IL_04af;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			List<RaycastResult>.Enumerator enumerator5 = (List<RaycastResult>.Enumerator)obj16;
			ex4 = (NullReferenceException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238494");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result2 = default(bool);
		return result2;
		IL_04af:
		result = true;
		goto IL_056c;
		IL_056c:
		return result;
	}

	protected virtual void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		//IL_013a: Expected I, but got O
		//IL_003c: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_008f: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_00f5: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		nint num = (nint)this;
		UnRegisterEventListeners();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4 (Il2CppClass<Hand>)+210]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		game.OnGameInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6 (Il2CppClass<Hand>)+220]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj2 = (nint)0 + (nint)592;
		game.OnGameStateUpdated += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj2);
		game.OnRoundEnd += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7 (Il2CppClass<Hand>)+230]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		gameEventsChannel.OnActivateFireMode += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v8 (Il2CppClass<Hand>)+240]");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)0);
		gameEventsChannel.OnDeactivateFireMode += action5;
	}

	protected virtual void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012f: Expected I, but got O
		//IL_003c: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_008f: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_00f5: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<Hand>)+210]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		game.OnGameInitialized -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5 (Il2CppClass<Hand>)+220]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj2 = (nint)0 + (nint)592;
		game.OnGameStateUpdated -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj2);
		game.OnRoundEnd -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v6 (Il2CppClass<Hand>)+230]");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)0);
		gameEventsChannel.OnActivateFireMode -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7 (Il2CppClass<Hand>)+240]");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)0);
		gameEventsChannel.OnDeactivateFireMode -= action5;
	}

	protected virtual void OnGameInitialized()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		CardGamePlayer myPlayer = game.MyPlayer;
		object obj = this + 32;
		obj = myPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected virtual void OnGameStatusUpdate()
	{
		//IL_0050: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_0070: Expected O, but got I
		playedCardThisTurn = false;
		ShowHandCards();
		DoPendingAction();
		GameEventsChannel gameEventsChannel = this.gameEventsChannel;
		if (gameEventsChannel.isFireModeActive)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Hand>)+228]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5 (Il2CppClass<Hand>)+230]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v50 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private void OnRoundEnd()
	{
		//IL_0097: Expected I, but got O
		//IL_00a7: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004b: Expected O, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		ResetFlipCards();
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X22_v4+v41 @ X21_v5*8]");
				((GameCard)0).SetStatus(CardStatus.InHand);
			}
			while ((nint)obj2 < array.Length);
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4 (Il2CppClass<Hand>)+288]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v4 (Il2CppClass<Hand>)+290]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void OnActivateFireMode()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (_specialPlayItem == null)
		{
			return;
		}
		_isFireModeActive = true;
		UpdatePriceTag();
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X23_v4+v117 @ X22_v5*8]");
				GameCard gameCard = (GameCard)0;
				obj2++;
				bool isFireActive = game.SpecialPlayAllowed(((UiCard)gameCard).card);
				gameCard.IsFireActive = isFireActive;
			}
			while ((nint)obj2 < array.Length);
		}
	}

	protected virtual void OnDeactivateFireMode()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_007f: Expected O, but got I
		_isFireModeActive = false;
		UpdatePriceTag();
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X21_v4+v53 @ X20_v5*8]");
				((GameCard)0).IsFireActive = false;
			}
			while ((nint)obj2 < array.Length);
		}
	}

	public virtual void DoPendingAction()
	{
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_029c: Expected O, but got I
		//IL_02ac: Expected O, but got I
		//IL_02ce: Expected O, but got I4
		//IL_02de: Expected O, but got I
		//IL_038e: Expected I, but got O
		//IL_039e: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_0267: Expected O, but got I4
		//IL_01f4: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_0384: Expected O, but got I
		//IL_030e: Expected O, but got I4
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0428: Expected O, but got I
		//IL_0439: Expected I, but got O
		//IL_0457: Expected O, but got I
		//IL_033e: Expected O, but got I
		if (!player.IsMe || !player.CanPlay)
		{
			return;
		}
		CardGame cardGame = game;
		if (!cardGame.<Stage>k__BackingField.IsPlaying || !player.IsHumanSeated || gameVisualControls.IsTooEarlyToPlayCard())
		{
			return;
		}
		CardGamePlayer cardGamePlayer = player;
		IEnumerable<object> <Cards>k__BackingField = cardGamePlayer.<Cards>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v15 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj2;
		if ((nint)0 == 1)
		{
			object obj = Enumerable.First(<Cards>k__BackingField);
			obj2 = obj;
			goto IL_03b8;
		}
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(<CardHit>k__BackingField == null))
		{
			return;
		}
		object obj6 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1256;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v23+E4]");
		object obj8;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v23+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			bool flag2 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (!flag2)
			{
				goto IL_0239;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v23+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v17+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			if (obj9 != null)
			{
				goto IL_0239;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v23+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v25+B8]");
			obj8 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3128;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj8, (IntPtr)obj13);
		object obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v22+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = Enumerable.FirstOrDefault(gameCardsSprite, func2);
		if (obj16 == null)
		{
			return;
		}
		goto IL_0374;
		IL_03b8:
		while (obj2 != null)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10 (Il2CppClass<Hand>)+268]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10 (Il2CppClass<Hand>)+270]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v177 @ X4_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0239:
		obj16 = Enumerable.FirstOrDefault(gameCardsSprite, predicate);
		bool flag5 = obj16 == null;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			return;
		}
		goto IL_0374;
		IL_0374:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v22 (System.Object)+28]");
		obj2 = 0;
		goto IL_03b8;
	}

	protected virtual void ShowHandCards()
	{
		//IL_015c: Expected O, but got I4
		if (player.IsMe)
		{
			CardGamePlayer myPlayer = game.MyPlayer;
			if (myPlayer.IsHumanSeated)
			{
				CardGamePlayer cardGamePlayer = player;
				CardGame cardGame = game;
				bool animateNow = cardGame.<MoveNumber>k__BackingField == 0;
				ShowActualHandCards(cardGamePlayer.<Cards>k__BackingField, cardGamePlayer.<PlayableCards>k__BackingField, animateNow);
				return;
			}
		}
		if (player.CanCardsBeShown)
		{
			goto IL_00e2;
		}
		if (game.IsReplay)
		{
			bool areCardsShown = player.AreCardsShown;
			bool flag = !areCardsShown;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00e2;
			}
		}
		CardGamePlayer cardGamePlayer2 = player;
		List<Card> <Cards>k__BackingField = cardGamePlayer2.<Cards>k__BackingField;
		ShowHandCardsBacks(<Cards>k__BackingField._size);
		return;
		IL_00e2:
		CardGamePlayer cardGamePlayer3 = player;
		ShowActualHandCards(cardGamePlayer3.<Cards>k__BackingField, cardGamePlayer3.<Cards>k__BackingField, animateNow: false);
	}

	public unsafe void ShowActualHandCards(List<Card> allCards, List<Card> playableCard, bool animateNow)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_030e: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_0389: Expected O, but got I
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected I4, but got Unknown
		//IL_03bd: Expected I4, but got O
		//IL_0275: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_02a7: Expected O, but got I4
		//IL_234d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2352: Expected O, but got Unknown
		//IL_2368: Expected O, but got I
		//IL_2379: Expected I, but got O
		//IL_2397: Expected O, but got I
		//IL_03d8: Expected O, but got I
		//IL_0407: Expected O, but got I4
		//IL_0348: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_09c6: Expected I4, but got O
		//IL_23d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23db: Expected O, but got Unknown
		//IL_23f1: Expected O, but got I
		//IL_2402: Expected I, but got O
		//IL_2420: Expected O, but got I
		//IL_0378: Expected O, but got I
		//IL_0550: Expected O, but got I
		//IL_0560: Expected O, but got I
		//IL_0582: Expected O, but got I4
		//IL_0592: Expected O, but got I
		//IL_250e: Expected O, but got I4
		//IL_251e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2523: Expected O, but got Unknown
		//IL_2551: Unknown result type (might be due to invalid IL or missing references)
		//IL_2556: Expected I4, but got Unknown
		//IL_2563: Expected I4, but got O
		//IL_04c1: Expected O, but got I4
		//IL_04d3: Expected O, but got I4
		//IL_0463: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_049a: Expected O, but got I
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_06d1: Expected O, but got I
		//IL_06e2: Expected I, but got O
		//IL_05cc: Expected O, but got I4
		//IL_08ef: Expected O, but got I
		//IL_08ff: Expected O, but got I
		//IL_0921: Expected O, but got I4
		//IL_06f4: Expected O, but got I4
		//IL_0709: Expected O, but got I
		//IL_0519: Expected O, but got I4
		//IL_2457: Unknown result type (might be due to invalid IL or missing references)
		//IL_245c: Expected O, but got Unknown
		//IL_2472: Expected O, but got I
		//IL_2483: Expected I, but got O
		//IL_24a1: Expected O, but got I
		//IL_1201: Expected O, but got I4
		//IL_121e: Expected O, but got I4
		//IL_10ea: Expected O, but got I
		//IL_10fa: Expected O, but got I
		//IL_111c: Expected O, but got I4
		//IL_061a: Expected O, but got I4
		//IL_062c: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_0689: Expected O, but got I4
		//IL_05fc: Expected O, but got I
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0a60: Expected O, but got I4
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected I4, but got Unknown
		//IL_0aaf: Expected I4, but got O
		//IL_0769: Expected O, but got I
		//IL_077a: Expected I, but got O
		//IL_1e95: Expected I4, but got O
		//IL_11be: Expected O, but got I4
		//IL_078c: Expected O, but got I4
		//IL_07a1: Expected O, but got I
		//IL_25b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ba: Expected O, but got Unknown
		//IL_25d0: Expected O, but got I
		//IL_25e1: Expected I, but got O
		//IL_25ff: Expected O, but got I
		//IL_0afc: Expected O, but got I4
		//IL_0b09: Expected I4, but got O
		//IL_0b94: Expected I4, but got O
		//IL_1edd: Expected O, but got I4
		//IL_1ef4: Expected I4, but got O
		//IL_11ee: Expected O, but got I
		//IL_0801: Expected O, but got I4
		//IL_0891: Expected O, but got I4
		//IL_2826: Expected O, but got I4
		//IL_2836: Unknown result type (might be due to invalid IL or missing references)
		//IL_283b: Expected O, but got Unknown
		//IL_2869: Unknown result type (might be due to invalid IL or missing references)
		//IL_286e: Expected I4, but got Unknown
		//IL_287b: Expected I4, but got O
		//IL_127c: Expected I4, but got O
		//IL_129a: Expected O, but got I4
		//IL_12cc: Expected I4, but got O
		//IL_0b39: Expected O, but got I
		//IL_0b43: Expected I4, but got O
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected O, but got Unknown
		//IL_0b6d: Expected O, but got I4
		//IL_0bf0: Expected O, but got I
		//IL_0bfd: Expected O, but got I4
		//IL_0c0f: Expected I4, but got O
		//IL_142f: Expected O, but got I4
		//IL_1445: Expected O, but got I
		//IL_1489: Unknown result type (might be due to invalid IL or missing references)
		//IL_148e: Expected I4, but got Unknown
		//IL_0cb8: Expected O, but got I4
		//IL_0ccd: Expected O, but got I
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected I4, but got Unknown
		//IL_26d9: Expected O, but got I4
		//IL_26ee: Expected O, but got I
		//IL_2729: Unknown result type (might be due to invalid IL or missing references)
		//IL_272e: Expected I4, but got Unknown
		//IL_20f9: Expected O, but got I4
		//IL_13ba: Expected I, but got O
		//IL_13da: Expected O, but got I
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14df: Expected O, but got Unknown
		//IL_14eb: Expected O, but got I
		//IL_1561: Expected O, but got I4
		//IL_0d7e: Expected O, but got I4
		//IL_1f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f63: Expected O, but got Unknown
		//IL_1f9e: Expected O, but got I4
		//IL_1fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb0: Expected O, but got Unknown
		//IL_1fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Expected I4, but got Unknown
		//IL_1fed: Expected I4, but got O
		//IL_16bc: Expected O, but got I
		//IL_2117: Expected O, but got I4
		//IL_1350: Expected O, but got I
		//IL_135a: Expected I4, but got O
		//IL_1384: Expected O, but got I4
		//IL_203a: Expected O, but got I4
		//IL_2047: Expected I4, but got O
		//IL_214a: Expected I4, but got O
		//IL_2164: Expected O, but got I4
		//IL_2171: Expected I4, but got O
		//IL_0e3f: Expected O, but got I
		//IL_0e5d: Expected O, but got I4
		//IL_0e6d: Expected O, but got I
		//IL_13b0: Expected I4, but got O
		//IL_206f: Expected O, but got I4
		//IL_2079: Expected I4, but got O
		//IL_2082: Unknown result type (might be due to invalid IL or missing references)
		//IL_2087: Expected O, but got Unknown
		//IL_20a3: Expected O, but got I4
		//IL_20cf: Expected I4, but got O
		//IL_21ae: Expected I4, but got O
		//IL_17db: Expected O, but got I
		//IL_0c35: Expected I4, but got O
		//IL_0c71: Expected I4, but got O
		//IL_1b31: Expected O, but got I
		//IL_0e85: Expected I4, but got O
		//IL_0eb7: Expected O, but got I
		//IL_2202: Expected O, but got I4
		//IL_2218: Expected O, but got I
		//IL_225c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2261: Expected I4, but got Unknown
		//IL_2296: Expected O, but got I4
		//IL_229e: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a3: Expected I4, but got Unknown
		//IL_22ab: Expected O, but got I4
		//IL_182a: Expected O, but got I4
		//IL_1840: Expected O, but got I
		//IL_1884: Unknown result type (might be due to invalid IL or missing references)
		//IL_1889: Expected I4, but got Unknown
		//IL_18b6: Expected O, but got I
		//IL_0eee: Expected O, but got I4
		//IL_0f03: Expected O, but got I
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected I4, but got Unknown
		//IL_22bc: Expected O, but got I
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected O, but got Unknown
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Expected O, but got Unknown
		//IL_15e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ec: Expected I4, but got Unknown
		//IL_15f9: Expected I4, but got O
		//IL_1931: Expected O, but got I4
		//IL_0fba: Expected O, but got I
		//IL_0fe2: Expected O, but got I
		//IL_19be: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c3: Expected O, but got Unknown
		//IL_19dd: Expected O, but got I4
		//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ea: Expected O, but got Unknown
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f8: Expected O, but got Unknown
		//IL_157f: Expected O, but got I
		//IL_27aa: Expected O, but got I4
		//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Expected O, but got Unknown
		//IL_1c03: Expected O, but got I4
		//IL_1c11: Expected O, but got I4
		//IL_1c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4a: Expected I4, but got Unknown
		//IL_1a86: Expected O, but got I4
		//IL_1a94: Expected O, but got I4
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Expected I4, but got Unknown
		//IL_1d04: Expected O, but got I4
		//IL_1d5e: Expected O, but got I
		//IL_1d7c: Expected O, but got I4
		//IL_1dab: Expected O, but got I
		//IL_1e05: Expected I4, but got O
		//IL_1e74: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E670D]");
		int num = 0;
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		List<Card> list = playableCard;
		Card card = null;
		object obj3 = obj2;
		bool flag2 = false;
		bool flag4 = default(bool);
		bool flag3 = flag4;
		object obj6;
		Func<object, bool> predicate;
		object obj8;
		object obj4;
		Func<object, bool> func = default(Func<object, bool>);
		if (!flag)
		{
			obj = obj2 + 24;
			obj = allCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (flag4)
			{
				AnimateFlipCards();
				obj4 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1256;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v144+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v144+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v117+10]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v117+10]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					obj8 = func;
					if (obj7 == null)
					{
						goto IL_01b8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v144+B8]");
					obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v117+10]");
					predicate = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v117+10]");
					bool flag6 = (nint)0 == 0;
					object obj9 = !flag6;
					obj8 = func;
					if (obj9 == null)
					{
						goto IL_01b8;
					}
				}
				goto IL_0219;
			}
			bool flag7 = (object)gameVisualControls == null;
			card = (Card)(object)allCards;
			flag2 = false;
			if (!flag7)
			{
				gameVisualControls.AddReorganizeHandToActionsBuffer((List<Card>)obj, playableCard);
				return;
			}
		}
		goto IL_20e5;
		IL_268f:
		func = (Func<object, bool>)(object)gameCardsSprite;
		object obj12;
		bool flag12 = default(bool);
		bool flag11 = default(bool);
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		bool flag10 = default(bool);
		bool flag9 = default(bool);
		object obj11 = default(object);
		object obj10 = default(object);
		if (gameCardsSprite != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			bool flag8 = (nint)0 < (nint)1;
			obj10 = !flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			obj11 = -1;
			flag9 = (nint)obj11 < 0;
			flag10 = obj11 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			num2 = (int)((nint)0 ^ (nint)1);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			num3 = 0 ^ obj11;
			num4 = num2 & num3;
			flag11 = num4 < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			flag12 = (nint)0 < (nint)1;
			if (flag12)
			{
				obj12 = 0;
				goto IL_2771;
			}
			obj4 = gameCardsSprite + 32;
			object obj13 = (nint)0 + (nint)2672;
			bool flag13 = flag12;
			bool flag14 = flag11;
			int num5 = num4;
			int num6 = num3;
			int num7 = num2;
			bool flag15 = flag10;
			bool flag16 = flag9;
			object obj14 = obj11;
			Func<object, bool> func2 = null;
			List<Card> list2 = list;
			Card card2 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
			int num8 = 0;
			bool flag17 = flag2;
			object obj15 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X27_v1+v259 @ X26_v8 (System.Func`2<System.Object, System.Boolean>)*8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X27_v1+v259 @ X26_v8 (System.Func`2<System.Object, System.Boolean>)*8]");
				bool flag18 = (nint)0 == 0;
				flag12 = flag13;
				flag11 = flag14;
				num4 = num5;
				num3 = num6;
				num2 = num7;
				flag10 = flag15;
				flag9 = flag16;
				obj11 = obj14;
				list = list2;
				card = card2;
				num = num8;
				flag2 = flag17;
				if (flag18)
				{
					break;
				}
				bool flag19 = obj == null;
				flag12 = flag13;
				flag11 = flag14;
				num4 = num5;
				num3 = num6;
				num2 = num7;
				flag10 = flag15;
				flag9 = flag16;
				obj11 = obj14;
				list = list2;
				card = card2;
				num = num8;
				flag2 = flag17;
				if (flag19)
				{
					break;
				}
				list = (List<Card>)obj13;
				object obj16 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+28]");
				bool flag21;
				bool flag26;
				GameCard gameCard;
				if (((List<object>)obj16).Contains((object)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+6C]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+6C]");
					bool flag20 = (nint)0 < (nint)3;
					obj10 = !flag20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+6C]");
					obj11 = -3;
					flag9 = (nint)obj11 < 0;
					flag21 = obj11 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+6C]");
					num2 = (int)((nint)0 ^ (nint)3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+6C]");
					num3 = 0 ^ obj11;
					num4 = num2 & num3;
					flag11 = num4 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X27_v1+v259 @ X26_v8 (System.Func`2<System.Object, System.Boolean>)*8]");
					GameObject gameObject = ((Component)0).gameObject;
					bool flag22 = (object)gameObject == null;
					flag12 = flag13;
					flag10 = flag21;
					card = null;
					flag2 = flag21;
					if (flag22)
					{
						break;
					}
					gameObject.SetActive(value: true);
					bool flag23 = (object)game == null;
					flag12 = flag13;
					flag10 = flag21;
					list = null;
					card = (Card)1;
					flag2 = flag21;
					if (flag23)
					{
						break;
					}
					Room room = game.Room;
					TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
					bool flag24 = TutorialTypeExtensions.IsCatchTutorial(tutorialType);
					bool flag25 = (object)game == null;
					flag12 = flag13;
					flag10 = flag21;
					list = null;
					card = null;
					flag2 = flag21;
					if (flag25)
					{
						break;
					}
					obj15 = flag21 | obj15;
					bool isTutorial = game.IsTutorial;
					object obj17 = !isTutorial;
					object obj18 = flag24 | obj17;
					object obj19 = obj18 & 1;
					if (obj19 == null)
					{
						flag26 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X27_v1+v259 @ X26_v8 (System.Func`2<System.Object, System.Boolean>)*8]");
						gameCard = (GameCard)0;
						goto IL_2790;
					}
					object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X0_v51+E4]");
					if ((nint)0 != 0)
					{
						bool cardDimming = Preferences.CardDimming;
						num = ((flag24 || cardDimming) ? 1 : 0);
						bool flag27 = num < 1;
						obj10 = !flag27;
						obj11 = num - 1;
						flag9 = (nint)obj11 < 0;
						flag10 = obj11 == null;
						num2 = num ^ 1;
						num3 = num ^ obj11;
						num4 = num2 & num3;
						flag11 = num4 < 0;
						flag12 = num != 1;
						list2 = null;
						card2 = null;
						flag17 = flag21;
						if (flag12)
						{
							goto IL_1584;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool cardDimming2 = Preferences.CardDimming;
						num = ((flag24 || cardDimming2) ? 1 : 0);
						bool flag28 = num < 1;
						obj10 = !flag28;
						obj11 = num - 1;
						flag9 = (nint)obj11 < 0;
						flag10 = obj11 == null;
						num2 = num ^ 1;
						num3 = num ^ obj11;
						num4 = num2 & num3;
						flag11 = num4 < 0;
						flag12 = num != 1;
						list2 = null;
						card2 = null;
						flag17 = flag21;
						if (flag12)
						{
							goto IL_1584;
						}
					}
					bool flag29 = (object)game == null;
					list = null;
					card = null;
					flag2 = flag21;
					if (flag29)
					{
						break;
					}
					Room room2 = game.Room;
					bool flag30 = SFSKammelnaRoomExtensions.IsCheatingAllowed(room2);
					bool flag31 = !flag30;
					object obj22 = !flag31;
					if (obj22 == null)
					{
						bool flag32 = playableCard == null;
						list = null;
						card = null;
						flag2 = flag21;
						if (flag32)
						{
							break;
						}
						list = (List<Card>)obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+28]");
						bool flag33 = ((List<object>)(object)playableCard).Contains((object)0);
						bool flag34 = !flag33;
						object obj23 = !flag34;
						if (obj23 == null)
						{
							bool flag35 = player == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X22_v2 (System.Object)+28]");
							card = (Card)0;
							flag2 = flag21;
							if (flag35)
							{
								break;
							}
							if (!player.PlayedThisTurn)
							{
								num = (int)game;
								bool flag36 = (object)game == null;
								card = null;
								flag2 = flag21;
								if (flag36)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+120]");
								bool flag37 = (nint)0 == 0;
								card = null;
								flag2 = flag21;
								if (flag37)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+120]");
								bool isBidding = ((CardGameStage)0).IsBidding;
								flag26 = (byte)((isBidding ? 1u : 0u) ^ 1u) != 0;
								goto IL_27b7;
							}
						}
					}
					flag26 = false;
					goto IL_27b7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X27_v1+v259 @ X26_v8 (System.Func`2<System.Object, System.Boolean>)*8]");
				GameObject gameObject2 = ((Component)0).gameObject;
				bool flag38 = (object)gameObject2 == null;
				flag12 = flag13;
				flag11 = flag14;
				num4 = num5;
				num3 = num6;
				num2 = num7;
				flag10 = flag15;
				flag9 = flag16;
				obj11 = obj14;
				card = null;
				num = num8;
				flag2 = flag17;
				if (flag38)
				{
					break;
				}
				gameObject2.SetActive(value: false);
				list2 = null;
				card2 = null;
				goto IL_1584;
				IL_27b7:
				gameCard = (GameCard)obj3;
				goto IL_2790;
				IL_1584:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
				num8 = 0;
				func2 = (Func<object, bool>)(func2 + 1);
				Func<object, bool> func3 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
				obj14 = func3 - 0;
				flag16 = (nint)obj14 < 0;
				flag15 = obj14 == null;
				Func<object, bool> func4 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
				num7 = func4 ^ 0;
				num6 = (object)func2 ^ obj14;
				num5 = num7 & num6;
				flag14 = num5 < 0;
				Func<object, bool> func5 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
				flag13 = (nint)func5 >= 0;
				flag12 = flag13;
				flag11 = flag14;
				num4 = num5;
				num3 = num6;
				num2 = num7;
				flag10 = flag15;
				flag9 = flag16;
				obj11 = obj14;
				list = list2;
				card = card2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v945 @ X25_v15 (System.Func`2<System.Object, System.Boolean>)+18]");
				num = 0;
				flag2 = flag17;
				obj12 = obj15;
				if (!flag13)
				{
					continue;
				}
				goto IL_2771;
				IL_2790:
				gameCard.IsDimmed = flag26;
				list2 = null;
				card2 = (Card)flag26;
				flag17 = flag21;
				goto IL_1584;
			}
		}
		goto IL_20e5;
		IL_1192:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v82+E4]");
		bool flag39 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v82+E4]");
		bool flag40 = (byte)(~(nuint)0u) != 0;
		object obj24 = !flag40;
		object obj26;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X8_v64+B8]");
			obj26 = 0;
		}
		object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)3160;
		Func<object, bool> func6 = default(Func<object, bool>);
		func6..ctor(obj26, (IntPtr)obj28);
		object obj29 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1011 @ X8_v63+B8]");
		object obj30 = (nint)0 + (nint)40;
		obj30 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag41;
		flag12 = flag41;
		bool flag42;
		flag11 = flag42;
		int num9;
		num4 = num9;
		int num10;
		num3 = num10;
		int num11;
		num2 = num11;
		bool flag43;
		flag10 = flag43;
		bool flag44;
		flag9 = flag44;
		object obj31;
		obj11 = obj31;
		object obj32;
		obj10 = obj32;
		Func<object, bool> func7 = (Func<object, bool>)obj26;
		flag4 = false;
		object obj33;
		obj3 = obj33;
		bool flag45;
		flag2 = flag45;
		Func<object, bool> predicate2 = func6;
		bool flag46;
		flag3 = flag46;
		goto IL_11f3;
		IL_11f3:
		IEnumerable<object> enumerable = Enumerable.Where((IEnumerable<object>)flag3, predicate2);
		num = (int)((nint)0 + (nint)448);
		list = (List<Card>)((int*)num)->m_value;
		int num12;
		List<Card> list3;
		IEnumerable<object> enumerable2;
		object obj34;
		bool flag51 = default(bool);
		if (Enumerable.SequenceEqual((IEnumerable<object>)obj3, enumerable))
		{
			bool flag47 = !flag2;
			card = (Card)enumerable;
			if (flag47)
			{
				goto IL_268f;
			}
			num12 = (int)gameCardsSprite;
			bool flag48 = gameCardsSprite == null;
			list3 = (List<Card>)((int*)num)->m_value;
			enumerable2 = enumerable;
			obj34 = obj3;
			bool flag49 = flag3;
			func = func7;
			card = (Card)enumerable;
			num = (int)gameCardsSprite;
			if (!flag48)
			{
				goto IL_12da;
			}
		}
		else
		{
			num = (int)gameCardsSprite;
			bool flag50 = gameCardsSprite == null;
			func = func7;
			card = (Card)enumerable;
			if (!flag50)
			{
				flag2 = (byte)((nuint)0u + (nuint)2760u) != 0;
				list3 = (List<Card>)((int*)num)->m_value;
				Card card3 = (Card)enumerable;
				obj34 = null;
				num12 = (int)gameCardsSprite;
				bool flag49 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
					flag51 = false;
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
					bool flag52 = (nint)obj35 < 0;
					obj10 = !flag52;
					object obj36 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
					obj11 = obj36 - 0;
					flag9 = (nint)obj11 < 0;
					flag10 = obj11 == null;
					object obj37 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
					num2 = obj37 ^ 0;
					num3 = obj34 ^ obj11;
					num4 = num2 & num3;
					flag11 = num4 < 0;
					object obj38 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
					flag12 = (nint)obj38 >= 0;
					enumerable2 = (IEnumerable<object>)card3;
					if (flag12)
					{
						break;
					}
					List<object> list4 = (List<object>)obj;
					bool flag53 = obj == null;
					func = func7;
					list = list3;
					card = card3;
					obj3 = obj34;
					num = num12;
					flag3 = flag49;
					if (!flag53)
					{
						object obj39 = num12 + obj34;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X8_v48+20]");
						flag3 = false;
						num = list4._size;
						bool flag54 = (nint)obj34 < list4._size;
						obj10 = !flag54;
						obj11 = obj34 - list4._size;
						flag9 = (nint)obj11 < 0;
						flag10 = obj11 == null;
						num2 = obj34 ^ list4._size;
						num3 = obj34 ^ obj11;
						num4 = num2 & num3;
						flag11 = num4 < 0;
						if ((nint)obj34 < list4._size)
						{
							list3 = (List<Card>)((bool*)(flag2 ? 1 : 0))->m_value;
							object obj40 = ((List<object>)obj).get_Item((int)obj34);
							card = (Card)obj40;
						}
						else
						{
							card = null;
						}
						bool flag55 = !flag3;
						func = func7;
						list = list3;
						obj3 = obj34;
						if (!flag55)
						{
							((UiCard)flag3).Card = card;
							num = (int)gameCardsSprite;
							obj3 = obj34 + 1;
							bool flag56 = gameCardsSprite == null;
							object obj41 = !flag56;
							func = func7;
							list = null;
							list3 = null;
							card3 = card;
							obj34 = obj3;
							num12 = (int)gameCardsSprite;
							flag49 = flag3;
							if (obj41 != null)
							{
								continue;
							}
						}
					}
					goto IL_20e5;
				}
				goto IL_12da;
			}
		}
		goto IL_20e5;
		IL_20e5:
		throw new NullReferenceException();
		IL_0ff9:
		obj3 = obj;
		flag3 = ((bool*)(flag3 ? 1 : 0))->m_value;
		object obj42 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v99+E4]");
		bool flag57 = (nint)0 == 0;
		Func<object, bool> func8 = (Func<object, bool>)(object)card;
		flag2 = true;
		flag41 = flag12;
		flag42 = flag11;
		num9 = num4;
		num10 = num3;
		num11 = num2;
		flag43 = flag10;
		flag44 = flag9;
		obj31 = obj11;
		obj32 = obj10;
		flag39 = flag51;
		func7 = func;
		bool flag58 = flag4;
		List<Card> list5 = list;
		obj33 = obj;
		object obj43 = obj42;
		flag45 = true;
		flag46 = ((bool*)(flag3 ? 1 : 0))->m_value;
		if (flag57)
		{
			goto IL_08cd;
		}
		goto IL_10da;
		IL_2771:
		if (_organizer != null)
		{
			num = (int)((nint)0 + (nint)1224);
			card = (Card)((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
			if (player != null)
			{
				flag2 = (byte)(int)_organizer != 0;
				bool isMover = player.IsMover;
				object obj44 = !isMover;
				num = obj12 | obj44;
				if ((num & 1) != 0)
				{
					card = null;
				}
				else
				{
					num = (int)obj;
					bool flag59 = obj == null;
					card = null;
					if (flag59)
					{
						goto IL_20e5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
					bool flag60 = (nint)0 < (nint)1;
					obj10 = !flag60;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
					obj11 = -1;
					flag9 = (nint)obj11 < 0;
					flag10 = obj11 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
					num2 = (int)((nint)0 ^ (nint)1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
					num3 = 0 ^ obj11;
					num4 = num2 & num3;
					flag11 = num4 < 0;
					bool flag61 = flag9 == flag11;
					object obj45 = !flag10;
					flag12 = (byte)((flag61 & obj45) ? 1 : 0) != 0;
					card = (Card)flag12;
				}
				if (flag2)
				{
					object obj46 = (nint)0 + (nint)1216;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389E04");
					UpdatePriceTag();
					UpdateCardsHash();
					return;
				}
			}
		}
		goto IL_20e5;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v144+E4]");
		flag51 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v144+E4]");
		bool flag62 = (byte)(~(nuint)0u) != 0;
		object obj47 = !flag62;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj48 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v123+B8]");
			obj6 = 0;
		}
		obj8 = obj6;
		object obj49 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)3136;
		Func<object, bool> func9 = default(Func<object, bool>);
		func9..ctor(obj6, (IntPtr)obj50);
		object obj51 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v122+B8]");
		object obj52 = (nint)0 + (nint)16;
		obj52 = func9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		flag4 = false;
		predicate = func9;
		goto IL_0219;
		IL_04a8:
		bool flag63 = (byte)((nuint)0u + (nuint)1816u) != 0;
		List<Card> list6 = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
		Func<object, bool> func10;
		bool flag64 = Enumerable.All((IEnumerable<object>)((bool*)(flag3 ? 1 : 0))->m_value, func10);
		bool flag65 = !flag64;
		flag39 = flag51;
		bool flag66 = flag4;
		if (flag65)
		{
			goto IL_06a7;
		}
		func = (Func<object, bool>)obj8;
		list = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
		card = (Card)(object)func10;
		flag2 = flag63;
		goto IL_09bc;
		IL_12da:
		card = (Card)enumerable2;
		flag2 = false;
		while (true)
		{
			bool num13 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
			bool flag67 = (nint)(num13 ? 1 : 0) < (nint)0;
			obj10 = !flag67;
			bool num14 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
			obj11 = (nint)(num14 ? 1 : 0) - (nint)0;
			flag9 = (nint)obj11 < 0;
			flag10 = obj11 == null;
			bool num15 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
			num2 = (int)((nint)(num15 ? 1 : 0) ^ (nint)0);
			num3 = ((flag2 ^ obj11) ? 1 : 0);
			num4 = num2 & num3;
			flag11 = num4 < 0;
			bool num16 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ X8_v52 (System.Int32)+18]");
			if ((nint)(num16 ? 1 : 0) >= (nint)0)
			{
				break;
			}
			num = num12 + (flag2 ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+20]");
			bool flag68 = (nint)0 == 0;
			func = func7;
			list = list3;
			obj3 = obj34;
			if (!flag68)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+20]");
				((GameCard)0).SetStatus(CardStatus.InHand);
				num12 = (int)gameCardsSprite;
				flag2 = (byte)((flag2 ? 1u : 0u) + 1u) != 0;
				bool flag69 = gameCardsSprite == null;
				object obj53 = !flag69;
				list3 = null;
				card = null;
				if (obj53 != null)
				{
					continue;
				}
				list = null;
				card = null;
				num = (int)gameCardsSprite;
			}
			goto IL_20e5;
		}
		nint num17 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v53 (Il2CppClass<Hand>)+288]");
		flag39 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1064 @ X8_v53 (Il2CppClass<Hand>)+290]");
		card = (Card)0;
		UpdatePriceTag();
		list = list3;
		obj3 = obj34;
		num = (int)num17;
		goto IL_268f;
		IL_0219:
		object obj54 = (nint)0 + (nint)3448;
		IEnumerable<object> enumerable3 = Enumerable.Where(gameCardsSprite, predicate);
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v134+E4]");
		object obj56;
		Func<object, object> selector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v134+B8]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v106+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v106+18]");
			bool flag70 = (nint)0 == 0;
			object obj57 = !flag70;
			if (obj57 == null)
			{
				goto IL_031c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v134+B8]");
			obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v106+18]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v106+18]");
			bool flag71 = (nint)0 == 0;
			object obj58 = !flag71;
			if (obj58 == null)
			{
				goto IL_031c;
			}
		}
		goto IL_037d;
		IL_09bc:
		num = (int)gameCardsSprite;
		bool flag72 = gameCardsSprite == null;
		obj3 = obj2;
		if (!flag72)
		{
			flag2 = (byte)((nuint)0u + (nuint)2760u) != 0;
			obj3 = null;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
				flag51 = false;
				object obj59 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
				bool flag73 = (nint)obj59 < 0;
				obj10 = !flag73;
				object obj60 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
				obj11 = obj60 - 0;
				flag9 = (nint)obj11 < 0;
				flag10 = obj11 == null;
				object obj61 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
				num2 = obj61 ^ 0;
				num3 = obj3 ^ obj11;
				num4 = num2 & num3;
				flag11 = num4 < 0;
				object obj62 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
				flag12 = (nint)obj62 >= 0;
				if (flag12)
				{
					break;
				}
				List<object> list7 = (List<object>)obj;
				if (obj != null)
				{
					object obj63 = num + obj3;
					num = list7._size;
					bool flag74 = (nint)obj3 < list7._size;
					obj10 = !flag74;
					obj11 = obj3 - list7._size;
					flag9 = (nint)obj11 < 0;
					flag10 = obj11 == null;
					num2 = obj3 ^ list7._size;
					num3 = obj3 ^ obj11;
					num4 = num2 & num3;
					flag11 = num4 < 0;
					if ((nint)obj3 < list7._size)
					{
						list = (List<Card>)((bool*)(flag2 ? 1 : 0))->m_value;
						object obj64 = ((List<object>)obj).get_Item((int)obj3);
						card = (Card)obj64;
					}
					else
					{
						card = null;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v73+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X8_v73+20]");
						((UiCard)0).Card = card;
						num = (int)gameCardsSprite;
						obj3++;
						bool flag75 = gameCardsSprite == null;
						object obj65 = !flag75;
						list = null;
						if (obj65 != null)
						{
							continue;
						}
						list = null;
					}
				}
				goto IL_20e5;
			}
			goto IL_0ff9;
		}
		goto IL_20e5;
		IL_06a7:
		Func<object, bool> func11 = (Func<object, bool>)(typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj66 = (nint)0 + (nint)3168;
		Func<object, bool> func12 = default(Func<object, bool>);
		func12..ctor(obj2, (IntPtr)obj66);
		list = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		bool flag76 = Enumerable.All((IEnumerable<object>)0, func12);
		bool flag77 = !flag76;
		flag51 = flag39;
		func = func12;
		flag4 = false;
		card = (Card)(object)func12;
		flag2 = flag63;
		if (flag77)
		{
			goto IL_09bc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj67 = (nint)0 + (nint)3176;
		Func<object, bool> func13 = default(Func<object, bool>);
		func13..ctor(obj2, (IntPtr)obj67);
		list = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		if (Enumerable.All((IEnumerable<object>)0, func13))
		{
			obj3 = obj;
			flag3 = ((bool*)(flag3 ? 1 : 0))->m_value;
			obj42 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X0_v99+E4]");
			bool flag78 = (nint)0 == 0;
			object obj68 = !flag78;
			flag51 = flag39;
			func = func13;
			flag4 = false;
			func8 = func13;
			flag2 = false;
			flag41 = flag12;
			flag42 = flag11;
			num9 = num4;
			num10 = num3;
			num11 = num2;
			flag43 = flag10;
			flag44 = flag9;
			obj31 = obj11;
			obj32 = obj10;
			func7 = func13;
			flag58 = false;
			list5 = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
			card = (Card)(object)func13;
			obj33 = obj;
			obj43 = obj42;
			flag45 = false;
			flag46 = ((bool*)(flag3 ? 1 : 0))->m_value;
			if (obj68 == null)
			{
				goto IL_08cd;
			}
			goto IL_10da;
		}
		num = (int)gameCardsSprite;
		bool flag79 = gameCardsSprite == null;
		flag51 = flag39;
		func = func13;
		flag4 = false;
		card = (Card)(object)func13;
		obj3 = obj2;
		flag2 = flag63;
		if (!flag79)
		{
			obj3 = (nint)0 + (nint)2672;
			List<Card> list8 = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
			Card card4 = (Card)(object)func13;
			int num18 = (int)gameCardsSprite;
			bool flag80 = false;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v85 (System.Int32)+18]");
				flag51 = false;
				bool num19 = flag80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v85 (System.Int32)+18]");
				bool flag81 = (nint)(num19 ? 1 : 0) < (nint)0;
				obj10 = !flag81;
				bool num20 = flag80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v85 (System.Int32)+18]");
				obj11 = (nint)(num20 ? 1 : 0) - (nint)0;
				flag9 = (nint)obj11 < 0;
				flag10 = obj11 == null;
				bool num21 = flag80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v85 (System.Int32)+18]");
				num2 = (int)((nint)(num21 ? 1 : 0) ^ (nint)0);
				num3 = ((flag80 ^ obj11) ? 1 : 0);
				num4 = num2 & num3;
				flag11 = num4 < 0;
				bool num22 = flag80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ X8_v85 (System.Int32)+18]");
				flag12 = (nint)(num22 ? 1 : 0) >= (nint)0;
				func = func13;
				flag4 = false;
				list = list8;
				card = card4;
				if (flag12)
				{
					break;
				}
				object obj69 = num18 + (flag80 ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v86+20]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ X8_v86+20]");
				bool flag82 = (nint)0 == 0;
				func = func13;
				flag4 = false;
				list = list8;
				card = card4;
				flag2 = flag80;
				if (!flag82)
				{
					bool flag83 = obj == null;
					func = func13;
					flag4 = false;
					list = list8;
					card = card4;
					flag2 = flag80;
					if (!flag83)
					{
						list = (List<Card>)obj3;
						object obj70 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+28]");
						bool flag84 = ((List<object>)obj70).Contains((object)0);
						bool flag85 = !flag84;
						object obj71 = !flag85;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+28]");
						card4 = (Card)0;
						if (obj71 != null)
						{
							goto IL_0c1d;
						}
						num = (int)gameCardsSprite;
						bool flag86 = gameCardsSprite == null;
						func = func13;
						flag4 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+28]");
						card = (Card)0;
						flag2 = flag80;
						if (!flag86)
						{
							bool num23 = flag80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
							bool flag87 = (nint)(num23 ? 1 : 0) < (nint)0;
							obj10 = !flag87;
							bool num24 = flag80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
							obj11 = (nint)(num24 ? 1 : 0) - (nint)0;
							flag9 = (nint)obj11 < 0;
							flag10 = obj11 == null;
							bool num25 = flag80;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+18]");
							num2 = (int)((nint)(num25 ? 1 : 0) ^ (nint)0);
							num3 = ((flag80 ^ obj11) ? 1 : 0);
							num4 = num2 & num3;
							flag11 = num4 < 0;
							if (obj10 != null)
							{
								throw new IndexOutOfRangeException();
							}
							num += (flag80 ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+20]");
							bool flag88 = (nint)0 == 0;
							flag51 = flag80;
							func = func13;
							flag4 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+28]");
							card = (Card)0;
							flag2 = flag80;
							if (!flag88)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v72 (System.Int32)+20]");
								((UiCard)0).Card = null;
								flag51 = flag80;
								list = null;
								card4 = null;
								goto IL_0c1d;
							}
						}
					}
				}
				goto IL_20e5;
				IL_0c1d:
				flag80 = (byte)((flag80 ? 1u : 0u) + 1u) != 0;
				num18 = (int)gameCardsSprite;
				bool flag89 = gameCardsSprite == null;
				list8 = list;
				func = func13;
				flag4 = false;
				card = card4;
				num = (int)gameCardsSprite;
				flag2 = flag80;
				if (!flag89)
				{
					continue;
				}
				goto IL_20e5;
			}
			goto IL_0ff9;
		}
		goto IL_20e5;
		IL_031c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v134+E4]");
		flag51 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X0_v134+E4]");
		bool flag90 = (byte)(~(nuint)0u) != 0;
		object obj72 = !flag90;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj73 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v112+B8]");
			obj56 = 0;
		}
		obj8 = obj56;
		object obj74 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj75 = (nint)0 + (nint)3144;
		Func<object, object> func14 = default(Func<object, object>);
		func14..ctor(obj56, (IntPtr)obj75);
		object obj76 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v111+B8]");
		object obj77 = (nint)0 + (nint)24;
		obj77 = func14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		flag4 = false;
		selector = func14;
		goto IL_037d;
		IL_08cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj43 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v82+B8]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v58+28]");
		predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v58+28]");
		bool flag91 = (nint)0 == 0;
		object obj78 = !flag91;
		flag39 = flag51;
		func7 = func;
		if (obj78 == null)
		{
			flag41 = flag12;
			flag42 = flag11;
			num9 = num4;
			num10 = num3;
			num11 = num2;
			flag43 = flag10;
			flag44 = flag9;
			obj31 = obj11;
			obj32 = obj10;
			flag58 = flag4;
			list5 = list;
			card = (Card)(object)func8;
			obj33 = obj3;
			flag45 = flag2;
			flag46 = flag3;
			goto IL_1192;
		}
		goto IL_11f3;
		IL_10da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v82+B8]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v58+28]");
		predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X8_v58+28]");
		bool flag92 = (nint)0 == 0;
		object obj79 = !flag92;
		flag12 = flag41;
		flag11 = flag42;
		num4 = num9;
		num3 = num10;
		num2 = num11;
		flag10 = flag43;
		flag9 = flag44;
		obj11 = obj31;
		obj10 = obj32;
		flag4 = flag58;
		obj3 = obj33;
		flag2 = flag45;
		flag3 = flag46;
		if (obj79 == null)
		{
			goto IL_1192;
		}
		goto IL_11f3;
		IL_037d:
		object obj80 = (nint)0 + (nint)3328;
		list = (List<Card>)obj80;
		IEnumerable<object> enumerable4 = Enumerable.Select(enumerable3, selector);
		flag3 = (byte)(obj2 + 16) != 0;
		((bool*)(flag3 ? 1 : 0))->m_value = (byte)(int)enumerable4 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj81 = (nint)0 + (nint)2576;
		card = (Card)obj81;
		bool flag93 = ArraysExtensions.IsNullOrEmpty(enumerable3);
		bool flag94 = !flag93;
		object obj82 = !flag94;
		func = (Func<object, bool>)obj8;
		flag2 = false;
		if (obj82 == null)
		{
			object obj83 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v119+E4]");
			object obj84;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v119+B8]");
				obj84 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				func10 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				bool flag95 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				Func<object, bool> func15 = (Func<object, bool>)0;
				if (!flag95)
				{
					goto IL_04a8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj83 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v119+B8]");
				obj84 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				func10 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				bool flag96 = (nint)0 == 0;
				object obj85 = !flag96;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v94+20]");
				Func<object, bool> func15 = (Func<object, bool>)0;
				if (obj85 != null)
				{
					goto IL_04a8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v119+E4]");
			flag39 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v119+E4]");
			bool flag97 = (byte)(~(nuint)0u) != 0;
			object obj86 = !flag97;
			if (obj86 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj87 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X8_v100+B8]");
				obj84 = 0;
			}
			object obj88 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj89 = (nint)0 + (nint)3152;
			Func<object, bool> func16 = default(Func<object, bool>);
			func16..ctor(obj84, (IntPtr)obj89);
			object obj90 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v99+B8]");
			object obj91 = (nint)0 + (nint)32;
			obj91 = func16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			flag63 = (byte)((nuint)0u + (nuint)1816u) != 0;
			list6 = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
			bool flag98 = Enumerable.All((IEnumerable<object>)((bool*)(flag3 ? 1 : 0))->m_value, func16);
			bool flag99 = !flag98;
			object obj92 = !flag99;
			flag66 = false;
			func10 = func16;
			flag51 = flag39;
			func = (Func<object, bool>)obj84;
			func11 = func16;
			flag4 = false;
			list = (List<Card>)((bool*)(flag63 ? 1 : 0))->m_value;
			card = (Card)(object)func16;
			flag2 = flag63;
			if (obj92 == null)
			{
				goto IL_06a7;
			}
		}
		goto IL_09bc;
	}

	public void PlayItsMyTurnSound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayItsMyTurnVibration()
	{
		if (UnityEngine.SystemInfo.supportsVibration)
		{
			Vibration.VibrateIOS(ImpactFeedbackStyle.Soft);
		}
	}

	private void UpdateCardsHash()
	{
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0034: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_009f: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		//IL_00f6: Expected O, but got I
		GameCard[] array = gameCardsSprite;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v3+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+B8]");
		object obj3 = 0;
		string text = (string)obj3;
		if (array.Length >= 1)
		{
			object obj4 = array + 32;
			object obj5 = ", stale={0}" + 120;
			object obj6 = 0;
			string text2 = (string)obj3;
			bool flag2;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X25_v5+v86 @ X24_v6*8]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X25_v5+v86 @ X24_v6*8]");
				GameObject gameObject = ((Component)0).gameObject;
				bool activeInHierarchy = gameObject.activeInHierarchy;
				bool flag = !activeInHierarchy;
				object obj7 = obj5;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X23_v3+90]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14+B8]");
					obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X21_v8 (UnityEngine.Component)+38]");
				Sprite sprite = ((SpriteRenderer)0).sprite;
				obj6++;
				string text3 = sprite.name;
				string text4 = text2 + text3 + (string)obj7;
				flag2 = (nint)obj6 < array.Length;
				text = text4;
				text2 = text4;
			}
			while (flag2);
		}
		object obj9 = this + 168;
		if (text != (string)obj9)
		{
			gameCardHash = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action onHandChanged = this.OnHandChanged;
			if (this.OnHandChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private void ShowHandCardsBacks(int cardsCount)
	{
		//IL_0200: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_001a: Expected O, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected I4, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected I4, but got Unknown
		//IL_01ac: Expected I, but got O
		//IL_01bc: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I4, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I4, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		while (true)
		{
			AnimateFlipCardsToTheirBack();
			GameCard[] array = gameCardsSprite;
			bool flag = gameCardsSprite == null;
			object obj = 152985600;
			if (flag)
			{
				break;
			}
			obj = (nint)0 + (nint)1224;
			object obj2 = 0;
			GameCard[] array2 = gameCardsSprite;
			while (true)
			{
				object obj3 = obj2 - array2.Length;
				bool flag2 = (nint)obj3 < 0;
				int num = obj2 ^ array2.Length;
				object obj4 = obj2 ^ obj3;
				int num2 = num & obj4;
				bool flag3 = num2 < 0;
				bool flag4 = (nint)obj2 >= array2.Length;
				object obj5 = obj2;
				array = array2;
				if (flag4)
				{
					break;
				}
				array = (GameCard[])(object)((object)array2 + obj2);
				bool flag5 = (object)array[0] == null;
				obj5 = obj2;
				if (flag5)
				{
					goto end_IL_01d6;
				}
				GameObject gameObject = array[0].gameObject;
				bool flag6 = (object)gameObject == null;
				obj5 = obj2;
				if (flag6)
				{
					goto end_IL_01d6;
				}
				obj3 = obj2 - cardsCount;
				flag2 = (nint)obj3 < 0;
				num = obj2 ^ cardsCount;
				obj4 = obj2 ^ obj3;
				num2 = num & obj4;
				flag3 = num2 < 0;
				bool flag7 = flag2 == flag3;
				flag4 = !flag7;
				gameObject.SetActive(flag4);
				array = gameCardsSprite;
				obj5 = obj2 + 1;
				bool flag8 = gameCardsSprite == null;
				object obj6 = !flag8;
				obj2 = obj5;
				array2 = gameCardsSprite;
				if (obj6 == null)
				{
					goto end_IL_01d6;
				}
			}
			if (_organizer == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5 (Il2CppClass<Hand>)+288]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5 (Il2CppClass<Hand>)+290]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v145 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			end_IL_01d6:
			break;
		}
		throw new NullReferenceException();
	}

	public virtual void CardClicked(Card card, bool clickedByUser)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_014e: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		//IL_0537: Expected O, but got I
		//IL_0288: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_04a8: Expected O, but got I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_043b: Expected O, but got I4
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_050b: Expected O, but got I
		//IL_038f: Expected F8, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		object obj4 = (nint)0 + (nint)3184;
		object obj5 = (nint)0 + (nint)824;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = obj2 + 16;
		obj7 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj8 = Enumerable.FirstOrDefault(gameCardsSprite, func);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj8 == null;
			bool flag2 = !flag;
			object obj10 = 0;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj8 == null;
			bool flag4 = !flag3;
			object obj11 = !flag4;
			object obj10 = 0;
			if (obj11 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+68]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			return;
		}
		if (player.CanPlayCard)
		{
			bool flag5 = !playedCardThisTurn;
			object obj13 = !flag5;
			if (obj13 == null && !gameVisualControls.IsTooEarlyToPlayCard())
			{
				Room room = game.Room;
				bool flag6 = SFSKammelnaRoomExtensions.IsCheatingAllowed(room);
				bool flag7 = !flag6;
				object obj14 = !flag7;
				if (obj14 == null)
				{
					CardGamePlayer cardGamePlayer = player;
					object obj15 = (nint)0 + (nint)2672;
					object obj10 = obj15;
					if (!((List<object>)(object)cardGamePlayer.<PlayableCards>k__BackingField).Contains(obj7))
					{
						if (game.IsTutorial)
						{
							gameEventsChannel.TriggerTutorialCardPreventedToPlay((Card)obj7);
						}
						return;
					}
				}
				bool canAffordSpecialPlay = CanAffordSpecialPlay;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+58]");
				if ((nint)0 == 1)
				{
					if (canAffordSpecialPlay)
					{
						ITrackEvent trackEvent = TrackerLibrary.GameCardSlapClicked(canBuy: true);
						object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
						object obj17 = obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v30+E4]");
						bool flag8 = (nint)0 == 0;
						object obj18 = !flag8;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Tracker.DesignEvent(trackEvent);
						string itemId = Tracker.ItemId(ResourceItemId.CardSlap);
						int num = StorePricing.EffectivePrice(_specialPlayItem);
						Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Gameplay, itemId, num, ResourceCurrency.Aces);
					}
					else
					{
						object message = "not" + 88;
						gameEventsChannel.TriggerDisplayMessage((string)message);
						ITrackEvent trackEvent2 = TrackerLibrary.GameCardSlapClicked(canBuy: false);
						object obj19 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
						object obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v27+E4]");
						bool flag9 = (nint)0 == 0;
						object obj21 = !flag9;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Tracker.DesignEvent(trackEvent2);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+58]");
				if ((nint)0 == 1)
				{
					CardGame cardGame = game;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+28]");
					bool flag10 = cardGame.SpecialPlayAllowed((Card)0);
					object obj22 = canAffordSpecialPlay && flag10;
					object obj23 = obj22 & 1;
					if (obj23 != null)
					{
						StoreItem specialPlayItem = _specialPlayItem;
						int? gameActionItemId = specialPlayItem.<id>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+28]");
						DoPlayCard((Card)0, gameActionItemId);
						gameEventsChannel.TriggerDeactivateFireMode();
						goto IL_059d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v11 (System.Object)+28]");
				DoPlayCard((Card)0, (int?)(object)0);
				goto IL_059d;
			}
		}
		((GameCard)obj8).SetStatus(CardStatus.Preplay);
		return;
		IL_059d:
		if (clickedByUser)
		{
			IsCardBeingAnimated = true;
		}
	}

	private void NotifyHandChanged()
	{
		Action onHandChanged = this.OnHandChanged;
		if (this.OnHandChanged != null)
		{
			IntPtr invoke_impl = ((Delegate)onHandChanged).invoke_impl;
			IntPtr method_code = ((Delegate)onHandChanged).method_code;
			IntPtr method = ((Delegate)onHandChanged).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	protected virtual void DoPlayCard(Card card, int? gameActionItemId = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ba: Expected O, but got I
		//IL_00d5: Expected I, but got O
		//IL_013e: Expected O, but got I4
		//IL_019d: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		playedCardThisTurn = true;
		CardGame cardGame = game;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		object obj5 = (nint)0 + (nint)3192;
		object obj6 = (nint)0 + (nint)824;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)cardGame;
		CardGamePlayer cardGamePlayer = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3 (System.Object)+10]");
		cardGame.PlayCard(cardGamePlayer, (Card)0, gameActionItemId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj8 = Enumerable.FirstOrDefault(gameCardsSprite, func);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj8 != null;
			bool flag2 = !flag;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!((UnityEngine.Object)obj8 != null))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v13 (System.Object)+38]");
		int num2 = ShortcutExtensions.DOKill((Component)0);
		Transform target = ((Component)obj8).transform;
		int num3 = ShortcutExtensions.DOKill(target);
		Transform startingPoint = ((Component)obj8).transform;
		gameVisualControls.PlayCard((Card)obj3, player, startingPoint, isEventFromServer: false, withCollision: true, gameActionItemId, 0, playImmediately: false, hideStartingPoint: false);
	}

	public void AnimateFlipCards()
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017e: Expected O, but got I
		//IL_018a: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_0267: Expected O, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_01d5: Expected F4, but got O
		//IL_01d5: Expected O, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		if (!player.CanCardsBeShown)
		{
			return;
		}
		CardGame cardGame = game;
		if (!((KGame)cardGame).<GamePhase>k__BackingField.IsGameStarted || (game.IsReplay && !player.AreCardsShown))
		{
			return;
		}
		if (game.IsReplay)
		{
			CardGameVisualControls cardGameVisualControls = gameVisualControls;
			bool flag = !cardGameVisualControls.<AreOthersCardsVisible>k__BackingField;
			object obj = !flag;
			if (obj == null)
			{
				CardGamePlayer cardGamePlayer = player;
				if (((KPlayer)cardGamePlayer).<Index>k__BackingField != 1)
				{
					return;
				}
			}
		}
		GameCard[] array = gameCardsSprite;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = (nint)0 + (nint)2848;
		object obj4 = (nint)0 + (nint)2744;
		object obj5 = 0;
		while ((nint)obj5 < array.Length)
		{
			object obj6 = (object)array + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v9+20]");
			Transform target = ((Component)0).transform;
			object obj7 = obj5 * 1028443341;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+B8]");
			object obj9 = 0;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(target, (Vector3)0, (float)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			double num = (double)obj7 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			array = gameCardsSprite;
			obj5++;
		}
	}

	public void AnimateFlipCardsToTheirBack()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0068: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00ce: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0127: Expected F4, but got I
		//IL_0127: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0191: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1288;
		object obj4 = (nint)0 + (nint)3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CB0]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		if (Enumerable.All(gameCardsSprite, func))
		{
			return;
		}
		GameCard[] array = gameCardsSprite;
		object obj5 = (nint)0 + (nint)2848;
		object obj6 = (nint)0 + (nint)2744;
		object obj7 = 0;
		object obj10;
		do
		{
			if ((nint)obj7 >= array.Length)
			{
				return;
			}
			object obj8 = (object)array + obj7;
			object obj9 = obj7 * 1028443341;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v8+20]");
			Transform target = ((Component)0).transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3 (System.Object)+10]");
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(target, (Vector3)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			double num = (double)obj9 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			array = gameCardsSprite;
			obj7++;
			bool flag = gameCardsSprite == null;
			obj10 = !flag;
		}
		while (obj10 != null);
		throw new NullReferenceException();
	}

	public void ResetFlipCards()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		if (!player.IsMe)
		{
			return;
		}
		GameCard[] array = gameCardsSprite;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X21_v4+v34 @ X20_v5*8]");
				Transform transform = ((Component)0).transform;
				obj2++;
				transform.localEulerAngles = (Vector3)0;
			}
			while ((nint)obj2 < array.Length);
		}
	}

	protected virtual void UpdatePriceTag()
	{
		//IL_09c9: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_055b: Expected O, but got I4
		//IL_040d: Expected O, but got I
		//IL_0a26: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_0126: Expected O, but got I
		//IL_0443: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_070b: Expected O, but got I
		//IL_07cb: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0864: Expected O, but got I8
		//IL_01d5: Expected O, but got I4
		//IL_0a92: Expected O, but got I
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aca: Expected O, but got Unknown
		//IL_0af4: Expected O, but got I4
		//IL_05f8: Expected O, but got I
		//IL_060d: Expected O, but got I
		//IL_04eb: Expected I, but got O
		//IL_04fb: Expected O, but got I
		//IL_0513: Expected O, but got I
		//IL_0531: Expected O, but got I4
		//IL_0780: Expected O, but got I
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_065b: Expected O, but got I4
		//IL_0991: Expected O, but got I4
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_0841: Expected O, but got I4
		//IL_021c: Expected I, but got O
		//IL_022c: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_067f: Expected O, but got I
		//IL_06a1: Expected O, but got I
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I4
		//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Expected O, but got Unknown
		//IL_0937: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_02cb: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0392: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_0367: Expected O, but got I
		//IL_0375: Expected O, but got I4
		List<float> list = default(List<float>);
		object obj3;
		object obj8 = default(object);
		if ((object)specialPlayPriceTag != null)
		{
			specialPlayPriceTag.SetActive(value: false);
			if (!_isFireModeActive)
			{
				return;
			}
			object obj = typeof(List<AdaptivePerformanceScaler>) + 3320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			GameCard[] array = gameCardsSprite;
			if (gameCardsSprite != null)
			{
				object obj2 = gameCardsSprite + 32;
				if (list != null)
				{
					if (array.Length < 1)
					{
						obj3 = 0;
						goto IL_09fe;
					}
					object obj4 = 0;
					object obj5 = 0;
					object obj6 = 0;
					object obj7 = 0;
					float item = default(float);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v138 @ X26_v9*8]");
						Component component = (Component)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v138 @ X26_v9*8]");
						bool flag = (nint)0 == 0;
						obj8 = obj6;
						if (flag)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v138 @ X26_v9*8]");
						GameObject gameObject = ((Component)0).gameObject;
						bool flag2 = (object)gameObject == null;
						obj8 = obj6;
						if (flag2)
						{
							break;
						}
						if (gameObject.activeSelf)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v11 (UnityEngine.Component)+6C]");
							bool flag3 = (nint)0 == 0;
							object obj9 = !flag3;
							if (obj9 != null)
							{
								return;
							}
							CardGame cardGame = game;
							bool flag4 = (object)game == null;
							obj8 = obj6;
							if (flag4)
							{
								break;
							}
							nint num = (nint)cardGame;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v59 (Il2CppClass<CardGame>)+318]");
							object obj10 = 0;
							CardGame cardGame2 = game;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X22_v11 (UnityEngine.Component)+28]");
							if (!cardGame2.SpecialPlayAllowed((Card)0))
							{
								obj4 = obj5 | obj4;
							}
							else
							{
								bool flag5 = _organizer == null;
								obj8 = obj6;
								if (flag5)
								{
									break;
								}
								object obj11 = (nint)0 + (nint)1200;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389310");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+1C]");
								object obj12 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
								obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
								bool flag6 = (nint)0 == 0;
								obj8 = obj6;
								if (flag6)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X9_v13+18]");
								bool flag7 = num2 < 0;
								object obj13 = !flag7;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
									object obj14 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
									object obj15 = num3 + 0;
									obj5 = 1;
								}
								else
								{
									list.AddWithResize(item);
									obj5 = 1;
								}
							}
							obj6++;
						}
						obj7++;
						bool flag8 = (nint)obj7 >= array.Length;
						obj3 = obj4;
						obj8 = obj6;
						if (!flag8)
						{
							continue;
						}
						goto IL_09fe;
					}
				}
				else if (array.Length >= 1)
				{
					object obj16 = 0;
					obj8 = 0;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v126 @ X25_v8*8]");
						Component component2 = (Component)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v126 @ X25_v8*8]");
						if ((nint)0 == 0)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X24_v5+v126 @ X25_v8*8]");
						GameObject gameObject2 = ((Component)0).gameObject;
						if ((object)gameObject2 == null)
						{
							break;
						}
						if (gameObject2.activeSelf)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X22_v8 (UnityEngine.Component)+6C]");
							bool flag9 = (nint)0 == 0;
							object obj17 = !flag9;
							if (obj17 != null)
							{
								return;
							}
							CardGame cardGame3 = game;
							if ((object)game == null)
							{
								break;
							}
							nint num4 = (nint)cardGame3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v47 (Il2CppClass<CardGame>)+318]");
							object obj10 = 0;
							CardGame cardGame4 = game;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X22_v8 (UnityEngine.Component)+28]");
							bool flag10 = cardGame4.SpecialPlayAllowed((Card)0);
							bool flag11 = !flag10;
							object obj18 = !flag11;
							if (obj18 != null)
							{
								goto IL_096b;
							}
							obj8++;
						}
						obj16++;
						if ((nint)obj16 < array.Length)
						{
							continue;
						}
						goto IL_07a5;
					}
				}
				else if (ArraysExtensions.IsNullOrEmpty(list))
				{
					return;
				}
			}
		}
		goto IL_09a7;
		IL_09a7:
		NullReferenceException ex = new NullReferenceException();
		object obj19 = obj8;
		goto IL_09bd;
		IL_0560:
		object obj31 = default(object);
		object obj27;
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
			if ((nint)0 < (nint)3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
				if ((nint)0 == 1)
				{
					float item2 = list.get_Item(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+1C]");
					object obj20 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X9_v10+18]");
						bool flag12 = num5 < 0;
						object obj22 = !flag12;
						object obj28 = default(object);
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
							object obj23 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+10]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
							object obj24 = num6 + 0;
							object obj25 = obj3 & 1;
							bool flag13 = obj25 == null;
							object obj26 = !flag13;
							if (obj26 != null)
							{
								goto IL_0755;
							}
							obj27 = obj28;
						}
						else
						{
							list.AddWithResize(item2);
							object obj29 = obj3 & 1;
							bool flag14 = obj29 == null;
							object obj30 = !flag14;
							obj27 = obj28;
							if (obj30 != null)
							{
								goto IL_0755;
							}
						}
						goto IL_0857;
					}
					goto IL_09a7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v9 (System.Collections.Generic.List`1<System.Single>)+18]");
				int count = (int)(-2);
				obj31 = (nint)0 + (nint)1400;
				list.RemoveRange(1, count);
			}
			object obj32 = obj3 & 1;
			bool flag15 = obj32 == null;
			obj27 = obj31;
			if (!flag15)
			{
				goto IL_0755;
			}
			goto IL_0857;
		}
		goto IL_09a7;
		IL_09fe:
		bool flag16 = ArraysExtensions.IsNullOrEmpty(list);
		bool flag17 = !flag16;
		object obj33 = !flag17;
		if (obj33 != null)
		{
			return;
		}
		goto IL_0560;
		IL_0755:
		if (_organizer == null)
		{
			goto IL_09a7;
		}
		object obj34 = (nint)0 + (nint)1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389120");
		object obj36 = default(object);
		object obj35 = 1075503432 - obj36;
		obj27 = obj31;
		goto IL_0a86;
		IL_0a86:
		obj8 = (nint)0 + (nint)1432;
		float num7 = list.get_Item(0);
		float num8 = list.get_Item(1);
		object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X0_v14+E4]");
		bool flag18 = (nint)0 == 0;
		object obj39 = !flag18;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float angleA = num7 + 1.0755035E+09f;
		float angleB = (float)obj35 + num8;
		float num9 = KUtil.AverageAngle(angleA, angleB);
		if ((object)specialPlayPriceTag != null)
		{
			Transform transform = specialPlayPriceTag.transform;
			if ((object)transform != null)
			{
				Transform parent = transform.parent;
				if (_organizer != null)
				{
					TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(parent, (Vector3)0, 0f);
					if ((object)specialPlayPriceTag != null)
					{
						specialPlayPriceTag.SetActive(value: true);
						return;
					}
				}
			}
		}
		goto IL_09a7;
		IL_07a5:
		bool flag19 = ArraysExtensions.IsNullOrEmpty(list);
		bool flag20 = !flag19;
		obj3 = 0;
		if (!flag20)
		{
			return;
		}
		goto IL_0560;
		IL_096b:
		ex = (NullReferenceException)(object)_organizer;
		bool flag21 = _organizer == null;
		object obj40 = !flag21;
		obj19 = obj8;
		if (obj40 == null)
		{
			goto IL_09a7;
		}
		goto IL_09bd;
		IL_0857:
		obj35 = 3222987080L;
		goto IL_0a86;
		IL_09bd:
		object obj41 = (nint)0 + (nint)1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389310");
		throw new NullReferenceException();
	}

	public Hand()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2912;
		maxCardsInBottomRow = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<RaycastResult> list = default(List<RaycastResult>);
		list..ctor();
		object obj2 = this + 160;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <FetchSpecialPlayFromStore>b__41_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(GameAction.SpecialPlay);
		object obj4 = this + 176;
		obj4 = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshSpecialPlayPrice();
	}

	private void <RefreshSpecialPlayPrice>b__42_0(GameCard c)
	{
		int specialPlayPrice = StorePricing.EffectivePrice(_specialPlayItem);
		c.SetSpecialPlayPrice(specialPlayPrice);
	}
}
