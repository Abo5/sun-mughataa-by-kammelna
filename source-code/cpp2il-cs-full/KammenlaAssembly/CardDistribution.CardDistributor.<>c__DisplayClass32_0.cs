using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace CardDistribution;

public class CardDistributor : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Userbox, bool> <>9__41_0;

		public static Comparison<Userbox> <>9__41_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <BuildDealOrder>b__41_0(Userbox box)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e4: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_01c7: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EC8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = box != null;
			if (!flag2)
			{
				goto IL_00af;
			}
			goto IL_0128;
			IL_00af:
			return flag2;
			IL_0128:
			if ((object)box != null)
			{
				GameObject gameObject = box.gameObject;
				if ((object)gameObject != null)
				{
					flag2 = gameObject.activeInHierarchy;
					if (flag2)
					{
						bool flag3 = box.<player>k__BackingField == null;
						return !flag3;
					}
					goto IL_00af;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_007d:
			flag2 = box != null;
			bool flag4 = !flag2;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				goto IL_00af;
			}
			goto IL_0128;
		}

		internal unsafe int <BuildDealOrder>b__41_1(Userbox a, Userbox b)
		{
			//IL_0008: Expected O, but got Ref
			//IL_00e1: Expected I4, but got O
			object obj2 = default(object);
			object obj = (object)(&obj2);
			if ((object)a != null)
			{
				CardGamePlayer <player>k__BackingField = a.<player>k__BackingField;
				if (a.<player>k__BackingField != null)
				{
					_ = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
					if ((object)b != null)
					{
						CardGamePlayer <player>k__BackingField2 = b.<player>k__BackingField;
						if (b.<player>k__BackingField != null)
						{
							int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
							return ((int*)num)->CompareTo(((KPlayer)<player>k__BackingField2).<Index>k__BackingField);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public CardDistributor <>4__this;

		public int rotatedDealer;

		internal void <DealFrom>b__0()
		{
			<>4__this.RefreshDealerCardBack(rotatedDealer);
		}

		internal void <DealFrom>b__1()
		{
			CardDistributor cardDistributor = <>4__this;
			List<Tween> activeTweens = cardDistributor._activeTweens;
			int version = activeTweens._version + 1;
			activeTweens._size = 0;
			activeTweens._version = version;
			if (activeTweens._size >= 1)
			{
				Array.Clear(activeTweens._items, 0, activeTweens._size);
				cardDistributor = <>4__this;
			}
			cardDistributor._gameEventChannel.TriggerDealBatchComplete();
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public CardDistributor <>4__this;

		public int rotatedDealer;

		internal unsafe void <OnRoundStart>g__DoDeal|0()
		{
			//IL_0077: Expected O, but got Ref
			CardDistributor cardDistributor = <>4__this;
			if ((object)<>4__this != null)
			{
				DealBatch[] dealBatches = cardDistributor._dealBatches;
				if (cardDistributor._dealBatches != null)
				{
					<>4__this.DealFrom(rotatedDealer, (DealBatch)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dealBatches[0]));
					return;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass38_0
	{
		public Userbox.UserBoxDirection dir;

		internal bool <GetUserboxByRotatedIndex>b__0(Userbox box)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_01c2: Expected I4, but got O
			//IL_01a0: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7ECA]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = box != null;
			if (!flag2)
			{
				goto IL_00a6;
			}
			goto IL_011f;
			IL_00a6:
			return flag2;
			IL_011f:
			if ((object)box != null)
			{
				GameObject gameObject = box.gameObject;
				if ((object)gameObject != null)
				{
					flag2 = gameObject.activeInHierarchy;
					if (flag2)
					{
						object obj5 = box.direction - dir;
						return obj5 == null;
					}
					goto IL_00a6;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0074:
			flag2 = box != null;
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				goto IL_00a6;
			}
			goto IL_011f;
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public Userbox userbox;

		public Vector3 targetPosition;

		public Quaternion targetRotation;

		public CardDistributor <>4__this;

		internal void <InsertCardTweens>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_00e2: Expected O, but got I4
			//IL_0218: Expected O, but got I4
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_02f4: Expected F4, but got O
			//IL_02f4: Expected O, but got I4
			//IL_0309: Expected O, but got I
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected O, but got Unknown
			//IL_0342: Expected O, but got I
			//IL_0353: Expected I, but got O
			//IL_035f: Expected O, but got I
			//IL_0382: Expected O, but got I
			//IL_03dc: Expected O, but got I4
			//IL_0451: Expected O, but got I
			//IL_0461: Expected O, but got I
			//IL_0471: Expected O, but got I
			//IL_0417: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Expected O, but got Unknown
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Expected O, but got Unknown
			//IL_04c0: Expected F4, but got O
			//IL_04c0: Expected O, but got I4
			//IL_04d5: Expected O, but got I
			//IL_0537: Expected O, but got I4
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Expected O, but got Unknown
			//IL_0580: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass40_1 <>c__DisplayClass40_ = default(<>c__DisplayClass40_1);
			<>c__DisplayClass40_..ctor();
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = <>c__DisplayClass40_ + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				if (this.userbox == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = this.userbox == null;
				bool flag2 = !flag;
				object obj5 = !flag2;
				if (obj5 != null)
				{
					return;
				}
			}
			GameObject gameObject = this.userbox.gameObject;
			if (!gameObject.activeInHierarchy)
			{
				return;
			}
			GameSoundManager instance = GameSoundManager.Instance;
			instance.PlaySound(GameSoundEffect.CARD, withDelay: false);
			Userbox userbox = this.userbox;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				if (userbox.<CurrentCardBack>k__BackingField != null)
				{
					goto IL_01b7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = userbox.<CurrentCardBack>k__BackingField != null;
				bool flag4 = !flag3;
				object obj7 = !flag4;
				if (obj7 != null)
				{
					goto IL_01b7;
				}
			}
			CardDistributor cardDistributor = <>4__this;
			object cardBackSprite = <>4__this + 80;
			goto IL_024a;
			IL_024a:
			Transform topCardTransform = cardDistributor._pile.TopCardTransform;
			Image image = cardDistributor._pool.Get((Sprite)cardBackSprite, topCardTransform);
			object obj8 = <>c__DisplayClass40_ + 16;
			obj8 = image;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			CardDistributor cardDistributor2 = <>4__this;
			CardDistributorSO cardDistributorSo = cardDistributor2._cardDistributorSo;
			List<object> activeTweens = (List<object>)(object)cardDistributor2._activeTweens;
			Transform transform = ((Component)obj8).transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOMove(transform, (Vector3)0, (float)targetPosition);
			object obj9 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2400;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(<>c__DisplayClass40_, (IntPtr)obj11);
			object obj12 = (nint)0 + (nint)2504;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			object obj14 = (nint)0 + (nint)1896;
			object obj15 = obj14;
			int version = activeTweens._version + 1;
			activeTweens._version = version;
			object[] items = activeTweens._items;
			bool flag5 = activeTweens._size < items.Length;
			object obj16 = !flag5;
			object obj19 = default(object);
			if (obj16 == null)
			{
				int size = activeTweens._size + 1;
				activeTweens._size = size;
				object obj17 = items + activeTweens._size;
				object obj18 = obj17 + 32;
				obj18 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v17+20]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+C0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v27+70]");
				obj13 = 0;
				activeTweens.AddWithResize(obj19);
			}
			CardDistributor cardDistributor3 = <>4__this;
			List<object> activeTweens2 = (List<object>)(object)cardDistributor3._activeTweens;
			Transform transform2 = ((Component)obj8).transform;
			TweenerCore<Quaternion, Quaternion, NoOptions> tweenerCore2 = ShortcutExtensions.DORotateQuaternion(transform2, (Quaternion)0, (float)targetRotation);
			object obj22 = (nint)0 + (nint)2832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			int version2 = activeTweens2._version + 1;
			activeTweens2._version = version2;
			object[] items2 = activeTweens2._items;
			bool flag6 = activeTweens2._size < items2.Length;
			object obj23 = !flag6;
			object obj26 = default(object);
			if (obj23 == null)
			{
				int size2 = activeTweens2._size + 1;
				activeTweens2._size = size2;
				object obj24 = items2 + activeTweens2._size;
				object obj25 = obj24 + 32;
				obj25 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				activeTweens2.AddWithResize(obj26);
			}
			return;
			IL_01b7:
			cardDistributor = <>4__this;
			cardBackSprite = this.userbox + 184;
			goto IL_024a;
		}
	}

	private sealed class <>c__DisplayClass40_1
	{
		public Image flyingCard;

		public <>c__DisplayClass40_0 CS$<>8__locals1;

		internal void <InsertCardTweens>b__1()
		{
			//IL_0044: Expected O, but got I
			<>c__DisplayClass40_0 cS$<>8__locals = CS$<>8__locals1;
			CardDistributor <>4__this = cS$<>8__locals.<>4__this;
			FlyingCardPool pool = <>4__this._pool;
			object obj = (nint)0 + (nint)3816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C36B4");
		}
	}

	private CardDistributorSO _cardDistributorSo;

	private DealerPileVisuals _pile;

	private FlyingCardPool _pool;

	private GameEventsChannel _gameEventChannel;

	private Sequence _activeSequence;

	private List<Tween> _activeTweens;

	private Sprite _dealerCardBack;

	private CardGame _game;

	private Userbox[] _allUserboxes;

	private int _lastTrackedMoveNumber;

	private int _batchIndex;

	private bool _ignoreHighMoveNumbers;

	private Action _pendingFirstDeal;

	private bool _matchMakingPopupDone;

	private DealBatch[] _dealBatches;

	private List<Userbox> _cachedDealOrder;

	public Transform PileTopCardTransform
	{
		get
		{
			if ((object)_pile != null)
			{
				return _pile.TopCardTransform;
			}
			return (Transform)(object)new NullReferenceException();
		}
	}

	public bool GroundCardsGoToPile
	{
		get
		{
			//IL_0041: Expected I4, but got O
			CardDistributorSO cardDistributorSo = _cardDistributorSo;
			if ((object)_cardDistributorSo != null)
			{
				return cardDistributorSo.<GroundCardsGoToPile>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int[] CardsPerBatch
	{
		get
		{
			if ((object)_pile != null)
			{
				return _pile.CardsPerBatch;
			}
			return (int[])(object)new NullReferenceException();
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EB8]");
		object obj2 = (nint)0 & (nint)1;
		DealerPileVisuals dealerPileVisuals;
		DealerPileVisuals pile;
		if (obj2 != null)
		{
			dealerPileVisuals = _pile;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			pile = _pile;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			dealerPileVisuals = _pile;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			pile = _pile;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
		bool flag3 = (object)pile == null;
		object obj5 = !flag3;
		dealerPileVisuals = pile;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0096;
		IL_0088:
		isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
		goto IL_0096;
		IL_0096:
		dealerPileVisuals.SetPerspective(isPerspectiveTopDown);
	}

	private void OnDisable()
	{
		KillSequence();
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a3: Expected I, but got O
		//IL_024a: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_02d2: Expected O, but got I
		//IL_02e0: Expected I, but got O
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_0438: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_0323: Expected O, but got I
		//IL_0331: Expected I, but got O
		//IL_01ac: Expected O, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0475: Expected O, but got I
		//IL_0483: Expected I, but got O
		//IL_04bb: Expected O, but got I4
		//IL_04c4: Expected O, but got I4
		//IL_0360: Expected O, but got I
		//IL_036e: Expected I, but got O
		//IL_03b6: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0527: Expected O, but got I
		//IL_0530: Expected O, but got I4
		//IL_05fd: Expected O, but got I
		//IL_061a: Expected O, but got I4
		//IL_0628: Expected O, but got I4
		//IL_05a3: Expected O, but got I
		//IL_05bb: Expected O, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0653: Expected I, but got O
		//IL_05d7: Expected O, but got I4
		//IL_066d: Expected O, but got I
		//IL_0676: Expected O, but got I4
		//IL_067f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EB9]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object game;
		UnityEngine.Object game2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			game = _game;
			game2 = _game;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			game = _game;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			game2 = _game;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = game2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00df;
		}
		goto IL_026b;
		IL_04da:
		Userbox[] allUserboxes;
		if (allUserboxes.Length < 1)
		{
			return;
		}
		object obj10 = allUserboxes + 32;
		object obj11 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 792;
		object obj12 = (nint)0 + (nint)3256;
		object obj13 = 0;
		Action<object, object> action2 = default(Action<object, object>);
		Action action;
		object obj18 = default(object);
		object obj15;
		do
		{
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v4+v197 @ X24_v5*8]");
				bool flag5 = (UnityEngine.Object)0 != null;
				bool flag6 = !flag5;
				obj15 = 0;
				action = null;
				if (flag6)
				{
					goto IL_0535;
				}
				object obj16 = 0;
				UnityEngine.Object obj17 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v4+v197 @ X24_v5*8]");
				bool flag7 = (UnityEngine.Object)0 != null;
				bool flag8 = !flag7;
				obj15 = 0;
				action = null;
				object obj16 = 0;
				UnityEngine.Object obj17 = null;
				if (flag8)
				{
					goto IL_0535;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj12);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X25_v4+v197 @ X24_v5*8]");
			((Userbox)0).OnCardBackLoaded -= action2;
			obj18 = 0;
			obj15 = 0;
			action = (Action)(object)action2;
			goto IL_0535;
			IL_0535:
			obj13++;
		}
		while ((nint)obj13 < allUserboxes.Length);
		return;
		IL_0186:
		allUserboxes = _allUserboxes;
		bool flag9 = _allUserboxes == null;
		object obj19 = !flag9;
		UnityEngine.Object obj20;
		action = (Action)(object)obj20;
		if (obj19 == null)
		{
			return;
		}
		goto IL_04da;
		IL_044b:
		object obj21 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3280;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj22);
		_gameEventChannel.OnMatchMakingPopupHideComplete -= action3;
		allUserboxes = _allUserboxes;
		bool flag10 = _allUserboxes == null;
		obj18 = 0;
		obj15 = 0;
		action = action3;
		if (!flag10)
		{
			goto IL_04da;
		}
		return;
		IL_0091:
		bool flag11 = game != null;
		bool flag12 = !flag11;
		object obj23 = !flag12;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		obj9 = null;
		if (obj23 == null)
		{
			goto IL_00df;
		}
		goto IL_026b;
		IL_026b:
		object obj24 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)3296;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj25);
		_game.OnRoundStart -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)3288;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj26);
		_game.OnRoundEnd -= action5;
		object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)3264;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj28);
		_game.OnGameEnd -= action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)3272;
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj29);
		_game.OnGameInitialized -= action7;
		UnityEngine.Object gameEventChannel = _gameEventChannel;
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v21+E4]");
		bool flag13 = (nint)0 == 0;
		object obj31 = !flag13;
		obj18 = 0;
		object obj32 = 0;
		obj6 = 0;
		Action action8 = action7;
		UnityEngine.Object gameEventChannel2 = _gameEventChannel;
		if (obj31 != null)
		{
			goto IL_0130;
		}
		goto IL_03f1;
		IL_00df:
		obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v21+E4]");
		bool flag14 = (nint)0 == 0;
		gameEventChannel = _gameEventChannel;
		obj32 = obj18;
		action8 = (Action)(object)obj7;
		gameEventChannel2 = _gameEventChannel;
		if (!flag14)
		{
			goto IL_0130;
		}
		goto IL_03f1;
		IL_03f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = gameEventChannel2 != null;
		bool flag16 = !flag15;
		obj18 = obj32;
		obj15 = 0;
		obj20 = null;
		object obj33 = 0;
		UnityEngine.Object obj34 = null;
		if (flag16)
		{
			goto IL_0186;
		}
		goto IL_044b;
		IL_0130:
		bool flag17 = gameEventChannel != null;
		bool flag18 = !flag17;
		object obj35 = !flag18;
		obj15 = 0;
		obj20 = null;
		obj32 = obj18;
		obj33 = 0;
		obj34 = null;
		if (obj35 == null)
		{
			goto IL_0186;
		}
		goto IL_044b;
	}

	public void Setup(CardGame game, Userbox[] allUserboxes)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected O, but got Unknown
		//IL_0033: Expected I, but got O
		//IL_0044: Expected O, but got I
		//IL_006e: Expected I, but got O
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00bf: Expected I, but got O
		//IL_00d0: Expected O, but got I
		//IL_00fd: Expected I, but got O
		//IL_013e: Expected O, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0482: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0193: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_04cd: Expected O, but got I
		//IL_04db: Expected I, but got O
		//IL_02ac: Expected O, but got I
		//IL_02cf: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_0309: Expected I, but got O
		//IL_0323: Expected O, but got I
		//IL_03b3: Expected O, but got I
		//IL_03d0: Expected O, but got I4
		//IL_0362: Expected O, but got I
		//IL_037a: Expected O, but got I4
		//IL_03f8: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_041f: Expected O, but got I4
		//IL_042f: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3296;
		object obj3 = this + 88;
		CardGame cardGame = default(CardGame);
		obj3 = cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 96;
		obj4 = allUserboxes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = (nint)0 + (nint)3288;
		((KGame)obj3).OnRoundStart += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj7 = (nint)0 + (nint)3264;
		_game.OnRoundEnd += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)3280;
		_game.OnGameEnd += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj8);
		_gameEventChannel.OnMatchMakingPopupHideComplete += action4;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v9+18]");
		bool flag = (nint)0 < (nint)1;
		object obj10 = 0;
		Sprite sprite = null;
		if (!flag)
		{
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 792;
			object obj13 = obj9 + 32;
			object obj14 = (nint)0 + (nint)3256;
			object obj15 = 0;
			Sprite sprite2 = null;
			Action action5 = action4;
			object obj16 = 0;
			Action<object, object> action6 = default(Action<object, object>);
			bool flag10;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
				UnityEngine.Object obj17 = (UnityEngine.Object)0;
				object obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v31+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
					bool flag2 = (UnityEngine.Object)0 == null;
					bool flag3 = !flag2;
					object obj19 = !flag3;
					sprite2 = null;
					action5 = null;
					if (obj19 != null)
					{
						goto IL_01b7;
					}
					Sprite sprite3 = null;
					UnityEngine.Object obj20 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
					bool flag4 = (UnityEngine.Object)0 == null;
					bool flag5 = !flag4;
					object obj21 = !flag5;
					sprite2 = null;
					action5 = null;
					Sprite sprite3 = null;
					UnityEngine.Object obj20 = null;
					if (obj21 != null)
					{
						goto IL_01b7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action6..ctor((object)this, (IntPtr)obj14);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
				((Userbox)0).OnCardBackLoaded += action6;
				object obj22 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v36+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X20_v12 (UnityEngine.Object)+B8]");
					bool flag6 = (UnityEngine.Object)0 != null;
					bool flag7 = !flag6;
					obj15 = 0;
					sprite2 = null;
					action5 = null;
					if (flag7)
					{
						goto IL_01b7;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X20_v12 (UnityEngine.Object)+B8]");
					bool flag8 = (UnityEngine.Object)0 != null;
					bool flag9 = !flag8;
					obj15 = 0;
					sprite2 = null;
					action5 = null;
					if (flag9)
					{
						goto IL_01b7;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X20_v12 (UnityEngine.Object)+B8]");
				sprite2 = (Sprite)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X20_v12 (UnityEngine.Object)+B8]");
				OnCardBackLoaded((Userbox)num, (Sprite)0);
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X27_v5+v195 @ X24_v14*8]");
				action5 = (Action)0;
				goto IL_01b7;
				IL_01b7:
				obj16++;
				object obj23 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v9+18]");
				flag10 = (nint)obj23 >= 0;
				obj10 = obj15;
				sprite = sprite2;
			}
			while (!flag10);
		}
		int[] cardsPerBatch = _pile.CardsPerBatch;
		DealBatch[] array = DealBatch.BuildFromConfig(cardsPerBatch);
		object obj24 = this + 136;
		obj24 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X20_v7-30]");
		CardGame cardGame2 = (CardGame)0;
		if (((KGame)cardGame2).<IsInitialized>k__BackingField)
		{
			InitMidGame(cardGame2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)3272;
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj25);
		cardGame2.OnGameInitialized += action7;
	}

	public void CheckAndTriggerNextBatch()
	{
		//IL_0334: Expected I4, but got I8
		//IL_034e: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_02bf: Expected O, but got I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I
		int num = (int)(_batchIndex & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = _dealerCardBack == null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 != null)
			{
				goto IL_00b7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (_dealerCardBack == null)
			{
				goto IL_00b7;
			}
		}
		goto IL_0107;
		IL_0107:
		CardGame game = _game;
		if ((object)_game != null)
		{
			if (_ignoreHighMoveNumbers)
			{
				if (game.<MoveNumber>k__BackingField != 1)
				{
					return;
				}
				_ignoreHighMoveNumbers = false;
			}
			if (_lastTrackedMoveNumber < 2 || game.<MoveNumber>k__BackingField != 1)
			{
				goto IL_02f7;
			}
			DealBatch[] dealBatches = _dealBatches;
			if (_dealBatches != null)
			{
				int num2 = _batchIndex + 1;
				if (num2 >= dealBatches.Length)
				{
					goto IL_02f7;
				}
				_batchIndex = num2;
				if ((object)_gameEventChannel != null)
				{
					_gameEventChannel.TriggerDealBatchStarted();
					CardGame game2 = _game;
					if ((object)_game != null)
					{
						int rotatedPlayerIndex = _game.GetRotatedPlayerIndex(game2.<Dealer>k__BackingField);
						DealBatch[] dealBatches2 = _dealBatches;
						if (_dealBatches != null)
						{
							bool flag4 = num2 < dealBatches2.Length;
							object obj5 = !flag4;
							if (obj5 == null)
							{
								object obj6 = _dealBatches + num2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v17+20]");
								DealFrom(rotatedPlayerIndex, (DealBatch)0);
								goto IL_02f7;
							}
							goto IL_0319;
						}
					}
				}
			}
		}
		goto IL_030b;
		IL_02f7:
		_lastTrackedMoveNumber = game.<MoveNumber>k__BackingField;
		return;
		IL_030b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0319;
		IL_00b7:
		CardGame game3 = _game;
		if ((object)_game != null)
		{
			int rotatedPlayerIndex2 = _game.GetRotatedPlayerIndex(game3.<Dealer>k__BackingField);
			RefreshDealerCardBack(rotatedPlayerIndex2);
			goto IL_0107;
		}
		goto IL_030b;
		IL_0319:
		throw new IndexOutOfRangeException();
	}

	public void InitMidGame(CardGame game)
	{
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected I4, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected I4, but got Unknown
		//IL_006f: Expected O, but got I4
		_matchMakingPopupDone = true;
		int? num = ResolveMidGamePileState(game);
		object obj = (??)num & 1;
		if (obj == null)
		{
			return;
		}
		int? num2 = default(int?);
		int value = num2.Value;
		if (value >= 1)
		{
			int value2 = num2.Value;
			int batchIndex = value2 - 1;
			_batchIndex = batchIndex;
			bool flag = (object)game == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			_batchIndex = 0;
		}
		_lastTrackedMoveNumber = game.<MoveNumber>k__BackingField;
		object obj3 = game.<MoveNumber>k__BackingField - 1;
		bool flag2 = (nint)obj3 < 0;
		bool flag3 = obj3 == null;
		int num3 = game.<MoveNumber>k__BackingField ^ 1;
		int num4 = game.<MoveNumber>k__BackingField ^ obj3;
		int num5 = num3 & num4;
		bool flag4 = num5 < 0;
		bool flag5 = flag2 == flag4;
		object obj4 = !flag3;
		bool ignoreHighMoveNumbers = (byte)((flag5 & obj4) ? 1 : 0) != 0;
		_ignoreHighMoveNumbers = ignoreHighMoveNumbers;
		int rotatedPlayerIndex = game.GetRotatedPlayerIndex(game.<Dealer>k__BackingField);
		int value3 = num2.Value;
		CompleteSequence();
		RefreshDealerCardBack(rotatedPlayerIndex);
		_pile.SnapToDealerInstant(rotatedPlayerIndex);
		_pile.ApplyState(value3);
	}

	public void DealFrom(int rotatedDealer, DealBatch batch)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_027c: Expected I, but got O
		//IL_02ab: Expected O, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected I4, but got Unknown
		//IL_0393: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_03ab: Expected O, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected I4, but got Unknown
		//IL_044e: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CompleteSequence();
		if (_allUserboxes != null)
		{
			DealerPileVisuals pile = _pile;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
			pile.SnapToDealerInstant(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
			int num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
			RefreshDealerCardBack(0);
			List<Userbox> list = _cachedDealOrder;
			bool flag = _cachedDealOrder == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
				List<Userbox> list2 = BuildDealOrder(0);
				list = list2;
			}
			CardDistributorSO cardDistributorSo = _cardDistributorSo;
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			object obj8 = this + 64;
			obj8 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			DealBatch batch2 = default(DealBatch);
			if (batch2.IsFirstBatch)
			{
				_pile.ApplyState(0);
				DealerPileVisuals pile2 = _pile;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+18]");
				Sequence t = pile2.BuildMoveSequence(0);
				Sequence sequence2 = TweenSettingsExtensions.Append(_activeSequence, t);
				CardDistributorSO cardDistributorSo2 = _cardDistributorSo;
				Sequence sequence3 = TweenSettingsExtensions.AppendInterval((Sequence)obj8, cardDistributorSo2.<FirstDealDelay>k__BackingField);
			}
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj10 = (nint)0 + (nint)2360;
			float num2 = TweenExtensions.Duration(_activeSequence);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj10);
			Sequence sequence4 = TweenSettingsExtensions.InsertCallback(_activeSequence, num2, tweenCallback);
			object obj11 = list._size - 1;
			object obj12 = batch - 1;
			float num3 = cardDistributorSo.<DelayBetweenCards>k__BackingField * (float)batch;
			float num4 = num3 * (float)obj11;
			float num5 = cardDistributorSo.<DelayBetweenCards>k__BackingField * (float)obj12;
			float num6 = num4 + num5;
			float num7 = cardDistributorSo.<CardFlightDuration>k__BackingField + num6;
			float num8 = num7 - cardDistributorSo.<CardFlightDuration>k__BackingField;
			object obj13 = default(object);
			int nextBatchIndex = obj13 + 1;
			Sequence sequence5 = _pile.BuildBatchSequence(nextBatchIndex, num7, num8);
			if (sequence5 != null)
			{
				Sequence sequence6 = TweenSettingsExtensions.Insert((Sequence)obj8, num2, sequence5);
			}
			object obj14 = (nint)0 + (nint)2368;
			object obj15 = (nint)0 + (nint)2512;
			object obj16 = (nint)0 + (nint)2408;
			int nextBatchIndex2 = obj13 + 1;
			Sequence sequence7 = _pile.BuildPlayerBatchSequence(nextBatchIndex2);
			if (sequence7 != null)
			{
				float atPosition = num8 + num2;
				Sequence sequence8 = TweenSettingsExtensions.Insert((Sequence)obj8, atPosition, sequence7);
			}
			InsertCardTweens(_activeSequence, batch2, list, num3, num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback2 = default(TweenCallback);
			tweenCallback2..ctor(obj2, (IntPtr)obj14);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		}
	}

	public void SnapToDealer(int rotatedDealer, int batchIndex)
	{
		CompleteSequence();
		RefreshDealerCardBack(rotatedDealer);
		_pile.SnapToDealerInstant(rotatedDealer);
		_pile.ApplyState(batchIndex);
	}

	public void SetPerspective(bool isTopDown)
	{
		if ((object)_pile != null)
		{
			_pile.SetPerspective(isTopDown);
		}
	}

	private void OnMatchMakingPopupHideComplete()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = this + 120;
		object obj2 = obj;
		_ = 1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2 @ X9_v1+18] (should have been resolved before IL gen)");
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private unsafe void OnRoundStart()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_009b: Expected I4, but got I8
		//IL_00b5: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0125: Expected O, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0264: Expected I, but got O
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_0228: Expected O, but got Ref
		//IL_0228: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		CardGame game;
		int playerIndex;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ignoreHighMoveNumbers = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
			_lastTrackedMoveNumber = 0;
			if ((object)_gameEventChannel != null)
			{
				_gameEventChannel.TriggerDealBatchStarted();
				game = _game;
				int num = (int)(_batchIndex & 0x80000000L);
				bool flag = num == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					if ((object)_game != null)
					{
						int nextPlayerIndex = _game.GetNextPlayerIndex(game.<Dealer>k__BackingField);
						game = _game;
						bool flag2 = (object)_game == null;
						object obj5 = !flag2;
						playerIndex = nextPlayerIndex;
						if (obj5 != null)
						{
							goto IL_02cc;
						}
					}
				}
				else if ((object)_game != null)
				{
					playerIndex = game.<Dealer>k__BackingField;
					goto IL_02cc;
				}
			}
		}
		goto IL_0287;
		IL_02cc:
		int rotatedPlayerIndex = game.GetRotatedPlayerIndex(playerIndex);
		List<Userbox> list = BuildDealOrder(rotatedPlayerIndex);
		object obj6 = this + 144;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X21_v7-10]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
			CardDistributor cardDistributor = (CardDistributor)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
			if ((nint)0 != 0)
			{
				DealBatch[] dealBatches = cardDistributor._dealBatches;
				if (cardDistributor._dealBatches != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
					((CardDistributor)num2).DealFrom(0, (DealBatch)System.Runtime.CompilerServices.Unsafe.AsPointer(ref dealBatches[0]));
					return;
				}
			}
			goto IL_0287;
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2376;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj8);
		object obj9 = this + 120;
		obj9 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0287:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void OnGameEnd(ISFSObject _)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		_lastTrackedMoveNumber = -1;
		_ignoreHighMoveNumbers = false;
		_matchMakingPopupDone = false;
		CompleteSequence();
		_pile.ApplyState(0);
		object obj = this + 144;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnGameInitialized()
	{
		InitMidGame(_game);
	}

	private void OnRoundEnded()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		CompleteSequence();
		_pile.ApplyState(0);
		object obj = this + 144;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnCardBackLoaded(Userbox userbox, Sprite sprite)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0231: Expected O, but got I4
		//IL_023a: Expected O, but got I4
		//IL_01e8: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_027f: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EBF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object game;
		UnityEngine.Object game2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			game = _game;
			game2 = _game;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			game = _game;
			game2 = _game;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = game2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		CardGame game3 = _game;
		int rotatedPlayerIndex = _game.GetRotatedPlayerIndex(game3.<Dealer>k__BackingField);
		Userbox userboxByRotatedIndex = GetUserboxByRotatedIndex(rotatedPlayerIndex);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = userbox != userboxByRotatedIndex;
			bool flag6 = !flag5;
			object obj8 = 0;
			if (!flag6)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = userbox != userboxByRotatedIndex;
			bool flag8 = !flag7;
			object obj9 = !flag8;
			object obj8 = 0;
			if (obj9 != null)
			{
				return;
			}
		}
		object obj10 = this + 80;
		obj10 = sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X19_v4-28]");
		((DealerPileVisuals)0).SetDealerCardBack((Sprite)obj10);
		return;
		IL_0091:
		if (game == null)
		{
			return;
		}
		goto IL_0158;
	}

	private void RefreshDealerCardBack(int rotatedDealer)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0168: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_01c3: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7EC0]");
		object obj3 = (nint)0 & (nint)1;
		int rotatedIndex = default(int);
		Userbox userbox;
		Userbox userbox2;
		if (obj3 != null)
		{
			Userbox userboxByRotatedIndex = GetUserboxByRotatedIndex(rotatedIndex);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			userbox = userboxByRotatedIndex;
			userbox2 = userboxByRotatedIndex;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			Userbox userboxByRotatedIndex2 = GetUserboxByRotatedIndex(rotatedIndex);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			userbox = userboxByRotatedIndex2;
			userbox2 = userboxByRotatedIndex2;
			if (obj5 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = userbox2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		userbox = userbox2;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0187;
		IL_0187:
		object obj8 = this + 80;
		obj8 = userbox.<CurrentCardBack>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X19_v3-28]");
		((DealerPileVisuals)0).SetDealerCardBack((Sprite)obj8);
		return;
		IL_009b:
		bool flag5 = userbox == null;
		bool flag6 = !flag5;
		obj7 = 0;
		if (!flag6)
		{
			return;
		}
		goto IL_0187;
	}

	private Userbox GetUserboxByRotatedIndex(int rotatedIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0027: Expected O, but got I4
		//IL_0041: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_009b: Expected O, but got I
		//IL_00ac: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (_allUserboxes != null)
		{
			object obj3 = rotatedIndex - 1;
			bool flag = (nint)obj3 < 4;
			object obj4 = !flag;
			if (obj4 == null)
			{
				if (obj2 != null)
				{
					object obj5 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = (nint)0 + (nint)2384;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj6);
					return (Userbox)Enumerable.FirstOrDefault(_allUserboxes, func);
				}
				return (Userbox)(object)new NullReferenceException();
			}
			object obj7 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "WhiteSmoke" + 2848;
			object arg = default(object);
			string text = string.Format((string)format, arg);
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			object obj11 = text;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = text;
			}
			KLogger.Log(obj11);
		}
		return null;
	}

	private float CalculateBatchDuration(DealBatch batch, int playerCount, float playerOverlap)
	{
		//IL_001d: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		CardDistributorSO cardDistributorSo = _cardDistributorSo;
		object obj = playerCount - 1;
		float num = playerOverlap * (float)obj;
		object obj2 = batch - 1;
		float num2 = cardDistributorSo.<DelayBetweenCards>k__BackingField * (float)obj2;
		float num3 = num + num2;
		return cardDistributorSo.<CardFlightDuration>k__BackingField + num3;
	}

	private unsafe void InsertCardTweens(Sequence sequence, DealBatch batch, List<Userbox> dealOrder, float playerOverlap, float timeOffset)
	{
		//IL_04ef: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0067: Expected O, but got I
		//IL_02bf: Expected O, but got Ref
		//IL_02c7: Expected F4, but got O
		//IL_02d0: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_054f: Expected O, but got I
		//IL_0589: Expected O, but got I
		//IL_05b4: Expected O, but got I4
		//IL_02e7: Expected O, but got Ref
		//IL_02ef: Expected F4, but got O
		//IL_02f8: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_039b: Expected O, but got I4
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_03f8: Expected native int or pointer, but got O
		//IL_041d: Expected F4, but got O
		//IL_03bf: Expected F4, but got O
		//IL_0438: Expected O, but got Ref
		//IL_0441: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_035f: Expected F4, but got O
		//IL_0344: Expected F4, but got O
		//IL_01af: Expected I, but got O
		//IL_031e: Expected O, but got I4
		//IL_01ff: Expected O, but got F4
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0241: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		List<Userbox> list = default(List<Userbox>);
		bool flag = list == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		DealBatch dealBatch2 = default(DealBatch);
		DealBatch dealBatch = dealBatch2;
		float num = timeOffset;
		if (!flag)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)(object)list).GetEnumerator();
			DealBatch dealBatch3;
			List<object>.Enumerator enumerator5;
			object obj11;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			if ((nint)dealBatch2 > 0)
			{
				object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3928;
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				object obj3 = (nint)0 + (nint)2392;
				dealBatch3 = dealBatch2;
				List<object>.Enumerator enumerator3 = enumerator4;
				num = timeOffset;
				List<Userbox> list2 = default(List<Userbox>);
				object obj5 = default(object);
				TweenCallback tweenCallback2 = default(TweenCallback);
				object obj8 = default(object);
				Sequence s = default(Sequence);
				float num3 = default(float);
				while (true)
				{
					object obj4 = (nint)0 + (nint)3048;
					TweenCallback tweenCallback = (TweenCallback)obj4;
					if (!enumerator.MoveNext())
					{
						break;
					}
					float num2;
					Sequence sequence2;
					if (list2 != null)
					{
						num2 = num;
						DealBatch dealBatch4 = dealBatch2;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj5..ctor();
							bool flag2 = obj5 == null;
							sequence2 = null;
							if (flag2)
							{
								break;
							}
							object obj6 = obj5 + 56;
							obj6 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj7 = obj5 + 16;
							obj7 = list2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Transform transform = ((Component)(object)list2).transform;
							if ((object)transform != null)
							{
								Vector3 position = transform.position;
								Transform transform2 = ((Component)(object)list2).transform;
								if ((object)transform2 != null)
								{
									Quaternion rotation = transform2.rotation;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									tweenCallback2..ctor(obj5, (IntPtr)obj3);
									Sequence sequence3 = TweenSettingsExtensions.InsertCallback(s, num2, tweenCallback2);
									CardDistributorSO cardDistributorSo = _cardDistributorSo;
									if ((object)_cardDistributorSo != null)
									{
										enumerator3 = (List<object>.Enumerator)cardDistributorSo.<DelayBetweenCards>k__BackingField;
										num2 += cardDistributorSo.<DelayBetweenCards>k__BackingField;
										dealBatch4 = (DealBatch)(dealBatch4 - 1);
										bool flag3 = (nint)dealBatch4 != 1;
										list = null;
										dealBatch3 = (DealBatch)0;
										tweenCallback = tweenCallback2;
										if (!flag3)
										{
											goto IL_0257;
										}
										continue;
									}
									goto IL_0307;
								}
								goto IL_0333;
							}
							goto IL_034e;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj8..ctor();
						bool flag4 = obj8 == null;
						object obj9 = !flag4;
						sequence2 = null;
						if (obj9 != null)
						{
							object obj10 = obj8 + 56;
							obj10 = this;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							dealBatch = (DealBatch)(obj8 + 16);
							((DealBatch*)(nint)dealBatch)-><CardsPerPlayer>k__BackingField = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							NullReferenceException ex = new NullReferenceException();
							num3 = (float)enumerator3;
							sequence2 = null;
							goto IL_0427;
						}
					}
					NullReferenceException ex2 = new NullReferenceException();
					num3 = (float)enumerator3;
					goto IL_0427;
					IL_0333:
					NullReferenceException ex3 = new NullReferenceException();
					num3 = (float)enumerator3;
					sequence2 = null;
					goto IL_0427;
					IL_034e:
					NullReferenceException ex4 = new NullReferenceException();
					num3 = (float)enumerator3;
					sequence2 = null;
					goto IL_0427;
					IL_0427:
					dealBatch2 = dealBatch3;
					enumerator5 = (List<object>.Enumerator)(&enumerator);
					enumerator4 = (List<object>.Enumerator)0;
					s = sequence2;
					goto IL_05ca;
					IL_0257:
					num = num3 + num;
					list = null;
					dealBatch3 = (DealBatch)0;
					continue;
					IL_0307:
					NullReferenceException ex5 = new NullReferenceException();
					list = null;
					dealBatch3 = (DealBatch)0;
					num3 = num2;
					sequence2 = (Sequence)(object)tweenCallback2;
					goto IL_0427;
				}
				enumerator5 = (List<object>.Enumerator)(&enumerator);
				num3 = (float)enumerator3;
				enumerator4 = (List<object>.Enumerator)0;
				obj11 = 0;
			}
			else
			{
				object obj12;
				do
				{
					bool flag5 = enumerator.MoveNext();
					bool flag6 = !flag5;
					obj12 = !flag6;
				}
				while (obj12 != null);
				dealBatch3 = dealBatch2;
				enumerator5 = (List<object>.Enumerator)(&enumerator);
				float num3 = (float)enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				obj11 = 0;
			}
			object obj15 = default(object);
			while (true)
			{
				object obj13 = (nint)0 + (nint)3040;
				Sequence s = (Sequence)obj13;
				((List<object>.Enumerator*)enumerator5)->Dispose();
				bool flag7 = obj11 == null;
				object obj14 = !flag7;
				dealBatch2 = dealBatch3;
				if (obj14 == null)
				{
					return;
				}
				OutOfMemoryException ex6 = new OutOfMemoryException();
				if ((nint)s != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj11 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				dealBatch3 = dealBatch2;
				enumerator4 = (List<object>.Enumerator)obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B908");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		goto IL_05ca;
		IL_05ca:
		throw new NullReferenceException();
	}

	private unsafe List<Userbox> BuildDealOrder(int rotatedDealer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_03c5: Expected I, but got O
		//IL_03df: Expected I4, but got I8
		//IL_08e2: Expected O, but got I
		//IL_08ee: Expected O, but got I
		//IL_090e: Expected O, but got I
		//IL_0930: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_01d2: Expected I, but got O
		//IL_040c: Expected I4, but got I8
		//IL_009f: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0226: Expected I, but got O
		//IL_094b: Expected O, but got I4
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_0975: Expected O, but got I
		//IL_098b: Expected I, but got O
		//IL_098b: Expected O, but got I4
		//IL_0993: Expected I4, but got O
		//IL_09a9: Expected O, but got I
		//IL_09c4: Expected O, but got I4
		//IL_00ea: Expected I4, but got O
		//IL_0114: Expected O, but got I4
		//IL_011c: Expected I, but got O
		//IL_043d: Expected O, but got I
		//IL_044d: Expected O, but got I
		//IL_046f: Expected O, but got I4
		//IL_047f: Expected O, but got I
		//IL_033e: Expected O, but got I
		//IL_034e: Expected O, but got I
		//IL_0370: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_0506: Expected O, but got I
		//IL_050f: Expected O, but got I4
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0a38: Expected O, but got I
		//IL_0a49: Expected I, but got O
		//IL_0a67: Expected O, but got I
		//IL_038e: Expected O, but got I
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected I4, but got Unknown
		//IL_04ed: Expected O, but got I4
		//IL_04df: Expected O, but got I
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0607: Expected I4, but got Unknown
		//IL_0619: Expected O, but got I4
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected I4, but got Unknown
		//IL_0873: Expected O, but got I4
		//IL_0880: Expected I4, but got O
		//IL_0679: Expected O, but got I
		//IL_0682: Expected O, but got I4
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected I4, but got Unknown
		//IL_06fd: Expected O, but got I4
		//IL_070a: Expected I4, but got O
		//IL_0723: Expected I4, but got O
		//IL_079a: Expected O, but got I4
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 216;
		object obj2 = (nint)0 + (nint)3032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (_allUserboxes == null)
		{
			goto IL_0849;
		}
		object obj3 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3896;
		int rotatedIndex = default(int);
		Userbox userboxByRotatedIndex = GetUserboxByRotatedIndex(rotatedIndex);
		CardGamePlayer <player>k__BackingField = default(CardGamePlayer);
		object obj4 = default(object);
		int num2;
		int num4;
		Userbox[] allUserboxes;
		object obj6;
		nint num3;
		int <Index>k__BackingField;
		IEnumerable<object> source;
		if ((object)userboxByRotatedIndex != null)
		{
			<player>k__BackingField = userboxByRotatedIndex.<player>k__BackingField;
			if (userboxByRotatedIndex.<player>k__BackingField != null)
			{
				obj4 = (nint)0 + (nint)3136;
				int? num = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
				object obj5 = (??)num & 1;
				if (obj5 != null)
				{
					num2 = (object?)num >> 32;
					obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v8+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = !flag;
					num3 = (nint)obj4;
					<Index>k__BackingField = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
					source = _allUserboxes;
					if (obj7 == null)
					{
						object obj8 = obj6;
						num4 = num2;
						allUserboxes = _allUserboxes;
						goto IL_020c;
					}
					goto IL_08d6;
				}
			}
		}
		CardGame game = _game;
		if ((object)_game != null)
		{
			num4 = game.<Dealer>k__BackingField;
			allUserboxes = _allUserboxes;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			num3 = (nint)obj4;
			<Index>k__BackingField = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
			obj6 = obj8;
			num2 = game.<Dealer>k__BackingField;
			source = _allUserboxes;
			if (obj9 == null)
			{
				goto IL_020c;
			}
		}
		else
		{
			obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			num3 = (nint)obj4;
			<Index>k__BackingField = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
			num2 = -1;
			source = _allUserboxes;
			if (obj10 == null)
			{
				object obj8 = obj6;
				num4 = -1;
				allUserboxes = _allUserboxes;
				goto IL_020c;
			}
		}
		goto IL_08d6;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj3;
		num3 = (nint)obj4;
		<Index>k__BackingField = ((KPlayer)<player>k__BackingField).<Index>k__BackingField;
		num2 = num4;
		source = allUserboxes;
		goto IL_08d6;
		IL_0849:
		return (List<Userbox>)(object)list;
		IL_05e8:
		List<object> list2;
		int size = list2._size;
		int num5 = obj2 / list2._size;
		object obj11 = num5 * list2._size;
		obj2 -= obj11;
		if (list2._size >= 1)
		{
			goto IL_0648;
		}
		goto IL_0849;
		IL_08d6:
		object obj12 = (nint)0 + (nint)3888;
		object obj13 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v8+B8]");
		size = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v20 (System.Int32)+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v20 (System.Int32)+8]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		object obj20;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj16 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v46+B8]");
				size = 0;
			}
			obj2 = ((int*)size)->m_value;
			object obj17 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)2344;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)((int*)size)->m_value, (IntPtr)obj18);
			size = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v20 (System.Int32)+B8]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			predicate = func;
		}
		IEnumerable<object> source2 = Enumerable.Where(source, predicate);
		list2 = Enumerable.ToList(source2);
		if (list2 == null)
		{
			goto IL_084e;
		}
		if (list2._size == 0)
		{
			goto IL_0849;
		}
		object obj21 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v32+E4]");
		object obj22;
		Comparison<object> comparison;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v32+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
			comparison = (Comparison<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
				Comparison<object> comparison2 = (Comparison<object>)0;
				goto IL_048d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v32+B8]");
			obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
			Comparison<object> comparison2 = (Comparison<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v30+10]");
			comparison = (Comparison<object>)0;
			if (obj24 == null)
			{
				goto IL_048d;
			}
		}
		goto IL_09d1;
		IL_09d1:
		list2.Sort(comparison);
		size = list2._size;
		if (list2._size < 1)
		{
			goto IL_0849;
		}
		predicate = (Func<object, bool>)((nint)0 + (nint)3072);
		obj2 = 1;
		while (true)
		{
			int index = obj2 - 1;
			object obj25 = list2.get_Item(index);
			bool flag8 = obj25 == null;
			source = list2;
			if (flag8)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v24 (System.Object)+198]");
			size = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v24 (System.Object)+198]");
			bool flag9 = (nint)0 == 0;
			source = list2;
			if (flag9)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v20 (System.Int32)+10]");
			if ((nint)0 != num2)
			{
				size = list2._size;
				object obj26 = obj2 + 1;
				bool flag10 = (nint)obj2 < list2._size;
				obj2 = obj26;
				if (flag10)
				{
					continue;
				}
				goto IL_05b9;
			}
			goto IL_05e8;
		}
		goto IL_084e;
		IL_05b9:
		bool flag11 = list2._size >= 1;
		obj2 = null;
		if (flag11)
		{
			goto IL_0648;
		}
		goto IL_0849;
		IL_084e:
		throw new NullReferenceException();
		IL_048d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v32+E4]");
		bool flag12 = (nint)0 == 0;
		object obj27 = !flag12;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v36+B8]");
			obj22 = 0;
		}
		object obj29 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)2352;
		Comparison<object> comparison3 = default(Comparison<object>);
		comparison3..ctor(obj22, (IntPtr)obj30);
		object obj31 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v35+B8]");
		object obj32 = (nint)0 + (nint)16;
		obj32 = comparison3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj20 = 0;
		comparison = comparison3;
		goto IL_09d1;
		IL_0648:
		bool flag13 = list == null;
		source = list2;
		if (!flag13)
		{
			object obj33 = (nint)0 + (nint)3040;
			object obj34 = 0;
			while (true)
			{
				int num6 = obj2 / size;
				object obj35 = num6 * size;
				int index2 = obj2 - obj35;
				object obj36 = list2.get_Item(index2);
				size = (int)obj33;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag14 = list._items == null;
				source = list2;
				if (flag14)
				{
					break;
				}
				bool flag15 = list._size < items.Length;
				object obj37 = !flag15;
				if (obj37 != null)
				{
					list.AddWithResize(obj36);
					obj34++;
					size = list2._size;
					obj2++;
					if ((nint)obj34 < list2._size)
					{
						continue;
					}
				}
				else
				{
					int size2 = list._size + 1;
					list._size = size2;
					object obj38 = list._items + list._size;
					object obj39 = obj38 + 32;
					obj39 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj34++;
					size = list2._size;
					obj2++;
					if ((nint)obj34 < list2._size)
					{
						continue;
					}
				}
				goto IL_0849;
			}
			goto IL_084e;
		}
		int num7 = obj2 / size;
		object obj40 = num7 * size;
		int index3 = obj2 - obj40;
		object obj41 = ((List<object>)source).get_Item(index3);
		return (List<Userbox>)(object)new NullReferenceException();
	}

	private void CompleteSequence()
	{
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		//IL_001c: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		object obj = this + 64;
		if (obj != null)
		{
			TweenExtensions.Complete((Tween)obj, withCallbacks: true);
			object obj2 = 0;
		}
		_activeSequence = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = _activeTweens == null;
		object obj3 = 0;
		object obj4 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			obj4 = (nint)0 + (nint)2752;
			List<object>.Enumerator enumerator = ((List<object>)(object)_activeTweens).GetEnumerator();
			while (enumerator2.MoveNext())
			{
			}
			obj3 = obj4;
			enumerator2.Dispose();
			object obj5 = 0;
			goto IL_00bb;
		}
		goto IL_0156;
		IL_00bb:
		List<Tween> activeTweens = _activeTweens;
		if (_activeTweens != null)
		{
			int version = activeTweens._version + 1;
			activeTweens._size = 0;
			activeTweens._version = version;
			if (activeTweens._size >= 1)
			{
				Array.Clear(activeTweens._items, 0, activeTweens._size);
			}
			return;
		}
		goto IL_0156;
		IL_0156:
		NullReferenceException ex = new NullReferenceException();
		bool flag2 = (nint)obj3 != 1;
		NullReferenceException ex2 = ex;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj4;
			enumerator2.Dispose();
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			object obj5 = obj6;
			if (flag3)
			{
				goto IL_00bb;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj5 = obj6;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B948");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void KillSequence()
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_004c: Expected O, but got I4
		//IL_001c: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		object obj = this + 64;
		if (obj != null)
		{
			TweenExtensions.Kill((Tween)obj);
			object obj2 = 0;
		}
		_activeSequence = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = _activeTweens == null;
		object obj3 = 0;
		object obj4 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			obj4 = (nint)0 + (nint)2752;
			List<object>.Enumerator enumerator = ((List<object>)(object)_activeTweens).GetEnumerator();
			while (enumerator2.MoveNext())
			{
			}
			obj3 = obj4;
			enumerator2.Dispose();
			object obj5 = 0;
			goto IL_00bb;
		}
		goto IL_0185;
		IL_00bb:
		List<Tween> activeTweens = _activeTweens;
		if (_activeTweens != null)
		{
			int version = activeTweens._version + 1;
			activeTweens._size = 0;
			activeTweens._version = version;
			if (activeTweens._size >= 1)
			{
				Array.Clear(activeTweens._items, 0, activeTweens._size);
			}
			if ((object)_pool != null)
			{
				_pool.ReturnAll();
			}
			return;
		}
		goto IL_0185;
		IL_0185:
		NullReferenceException ex = new NullReferenceException();
		bool flag2 = (nint)obj3 != 1;
		NullReferenceException ex2 = ex;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj4;
			enumerator2.Dispose();
			object obj6 = default(object);
			bool flag3 = obj6 == null;
			object obj5 = obj6;
			if (flag3)
			{
				goto IL_00bb;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj5 = obj6;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B948");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	protected virtual int? ResolveMidGamePileState(CardGame game)
	{
		//IL_0006: Expected O, but got I4
		return (int?)(object)0;
	}

	public CardDistributor()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object typeFromHandle = typeof(List<Tween>);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj = this + 72;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_lastTrackedMoveNumber = -1;
		base..ctor();
	}
}
