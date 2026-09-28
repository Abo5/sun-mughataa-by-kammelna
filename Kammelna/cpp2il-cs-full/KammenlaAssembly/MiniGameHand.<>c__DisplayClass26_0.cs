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
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class MiniGameHand : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MiniGameCard, bool> <>9__22_0;

		public static Action<MiniGameCard> <>9__26_2;

		public static Func<MiniGameCard, bool> <>9__26_3;

		public static Func<MiniGameCard, int> <>9__28_1;

		public static Action<MiniGameCard> <>9__29_0;

		public static Action<MiniGameCard> <>9__32_0;

		public static Func<MiniGameCard, bool> <>9__36_0;

		public static Func<MiniGameCard, Card> <>9__38_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_SelectedCards>b__22_0(MiniGameCard c)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if ((object)c != null)
			{
				object obj = c.<CardStatus>k__BackingField - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <AnimateDrawCards>b__26_2(MiniGameCard card)
		{
			Transform transform = card.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(transform, ((UiCard)card)._cardPositionY, 0.1f, snapping: true);
		}

		internal bool <AnimateDrawCards>b__26_3(MiniGameCard card)
		{
			//IL_0067: Expected I4, but got O
			if ((object)card != null)
			{
				GameObject gameObject = card.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <HighlightRewards>b__28_1(MiniGameCard card)
		{
			//IL_0091: Expected I4, but got O
			if ((object)card != null)
			{
				Transform transform = card.transform;
				if ((object)transform != null)
				{
					Transform parent = transform.parent;
					if ((object)parent != null)
					{
						return parent.GetSiblingIndex();
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <OnFinishedCardsAnimation>b__29_0(MiniGameCard card)
		{
			card.<intractable>k__BackingField = true;
		}

		internal void <OnMoveSent>b__32_0(MiniGameCard card)
		{
			card.<intractable>k__BackingField = false;
		}

		internal bool <ReturnRewardCards>b__36_0(MiniGameCard card)
		{
			//IL_005d: Expected I4, but got O
			if ((object)card != null)
			{
				if (card.<CardStatus>k__BackingField != MiniGameCardStatus.InHand)
				{
					return false;
				}
				return card._isPartOfProject;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Card <SendMove>b__38_0(MiniGameCard card)
		{
			if ((object)card != null)
			{
				return ((UiCard)card).card;
			}
			return (Card)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public MiniGameCard selectedCard;

		public Func<MiniGameCard, bool> <>9__0;

		internal bool <CardSelected>b__0(MiniGameCard gameCard)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return gameCard != selectedCard;
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public Card card;

		internal bool <AnimateDrawCards>b__4(MiniGameCard gameCard)
		{
			//IL_0048: Expected I4, but got O
			if ((object)gameCard != null)
			{
				return object.Equals(((UiCard)gameCard).card, card);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass26_1
	{
		public MiniGameCard gameCard;

		internal void <AnimateDrawCards>b__5()
		{
			gameCard.ToggleCardFace(show: true);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public MiniGameReward reward;

		internal bool <HighlightRewards>b__0(MiniGameCard gameCard)
		{
			//IL_0073: Expected I4, but got O
			MiniGameReward miniGameReward = reward;
			if (reward != null && (object)gameCard != null && miniGameReward.<Cards>k__BackingField != null)
			{
				return ((List<object>)(object)miniGameReward.<Cards>k__BackingField).Contains((object)((UiCard)gameCard).card);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass28_1
	{
		public MiniGameCard gameCard;

		internal void <HighlightRewards>b__2()
		{
			gameCard.isPartOfProject = true;
		}
	}

	private GameObject rewardTemplate;

	private MiniGameCard[] gameCards;

	private Action<List<MiniGameCard>> m_OnCardSelected;

	private Action m_OnFinishedDrawingCard;

	private MiniGame miniGame;

	private CardsOrganizer<MiniGameCard> organizer;

	private AnimationCurve lateOutBack;

	private AnimationCurve inQuad;

	private float cardSpacing;

	private float moveSpeed;

	private float organizeSpeed;

	private float organizeSpacing;

	private float organizeDelay;

	private float scaleSpeed;

	private float rotateSpeed;

	private float rotateDelay;

	private float flipDelay;

	private List<MiniGameCard> SelectedCards
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			//IL_01a5: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0113: Expected O, but got I
			//IL_0124: Expected I, but got O
			//IL_0142: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1808;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source = Enumerable.Where(gameCards, predicate);
			return (List<MiniGameCard>)(object)Enumerable.ToList(source);
		}
	}

	public event Action<List<MiniGameCard>> OnCardSelected
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 840;
			object obj2 = this + 48;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 840;
			object obj2 = this + 48;
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

	public event Action OnFinishedDrawingCard
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 56;
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
			object obj2 = this + 56;
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
		//IL_0286: Expected O, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_00f8: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0135: Expected I, but got O
		//IL_0146: Expected O, but got I
		//IL_0172: Expected I, but got O
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		//IL_01a3: Expected O, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I
		//IL_01ef: Expected I, but got O
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)184;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2696;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2760;
		object obj10 = (nint)0 + (nint)2688;
		((MiniGame)obj7).OnInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)2712;
		miniGame.OnGameStart += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)2704;
		miniGame.OnMoveSent += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)2672;
		miniGame.OnMove += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj13);
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
		object obj15 = (nint)0 + (nint)2640;
		object obj16 = (nint)0 + (nint)2200;
		object obj17 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 2760;
		object obj18 = (nint)0 + (nint)1240;
		miniGame.OnClaim += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj15);
		ArraysExtensions.ForEach(gameCards, action6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @438A0FC");
		object obj20 = default(object);
		object obj19 = obj20 + 48;
		obj19 = gameCards;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7136758]");
		_ = 0;
		_ = 1156743168;
		object obj21 = this + 72;
		obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetUi();
	}

	private void ResetUi()
	{
		//IL_00f1: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003b: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		MiniGameCard[] array = gameCards;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+v72 @ X22_v5*8]");
				MiniGameCard miniGameCard = (MiniGameCard)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+v72 @ X22_v5*8]");
				((MiniGameCard)0).isPartOfProject = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+v72 @ X22_v5*8]");
				((MiniGameCard)0).SetStatus(MiniGameCardStatus.InHand);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+v72 @ X22_v5*8]");
				((UiCard)0).Card = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X23_v4+v72 @ X22_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				obj2++;
				gameObject.SetActive(value: false);
				miniGameCard.<intractable>k__BackingField = false;
			}
			while ((nint)obj2 < array.Length);
		}
		object obj3 = (nint)0 + (nint)1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
	}

	private unsafe void CardSelected(MiniGameCard selectedCard)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0b7c: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_0226: Expected O, but got I
		//IL_022e: Expected I, but got O
		//IL_0257: Expected O, but got I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01f0: Expected I, but got O
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0289: Expected I, but got O
		//IL_0299: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_0360: Expected I, but got O
		//IL_0bf2: Expected I4, but got O
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected O, but got Unknown
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c3c: Expected O, but got Ref
		//IL_02d4: Expected O, but got I
		//IL_0baa: Expected O, but got I
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected O, but got Unknown
		//IL_0a2a: Expected O, but got I4
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0a54: Expected O, but got Ref
		//IL_0a65: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0484: Expected I, but got O
		//IL_0ca9: Expected O, but got I
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I
		//IL_063a: Expected O, but got Ref
		//IL_064b: Expected O, but got I4
		//IL_0654: Expected O, but got I4
		//IL_0665: Expected O, but got I4
		//IL_066d: Expected O, but got Ref
		//IL_067e: Expected O, but got I4
		//IL_06a7: Expected O, but got I4
		//IL_06c0: Expected O, but got I4
		//IL_0c51: Expected O, but got I
		//IL_0c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected O, but got Unknown
		//IL_0da4: Expected O, but got I4
		//IL_0491: Expected I4, but got O
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_0795: Expected I, but got O
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0841: Expected O, but got I
		//IL_0e36: Expected O, but got I
		//IL_0735: Expected O, but got I
		//IL_05c5: Expected I, but got O
		//IL_0809: Expected O, but got I4
		//IL_0dfa: Expected O, but got I
		//IL_0d46: Expected O, but got I
		//IL_0531: Expected O, but got I
		//IL_0ad3: Expected O, but got I4
		//IL_0ae4: Expected O, but got I4
		//IL_07a2: Expected I4, but got O
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_0cee: Expected O, but got I
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_08b8: Expected O, but got I
		//IL_08ed: Expected I4, but got O
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_0615: Expected I, but got O
		//IL_05d2: Expected I4, but got O
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_0b33: Expected O, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0572: Expected O, but got I4
		//IL_0975: Expected O, but got I4
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63E3]");
		MiniGame miniGame = (MiniGame)0;
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		object obj3 = 0;
		MiniGameCard miniGameCard = null;
		bool flag6;
		List<MiniGameCard> arg;
		object obj16;
		object obj13 = default(object);
		object obj14 = default(object);
		object obj9 = default(object);
		object obj5;
		int size;
		nint num;
		if (!flag)
		{
			obj = obj2 + 16;
			obj = selectedCard;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ReturnRewardCards();
			List<MiniGameCard> selectedCards = SelectedCards;
			bool flag2 = selectedCards == null;
			obj3 = 0;
			miniGameCard = selectedCard;
			if (!flag2)
			{
				miniGame = this.miniGame;
				bool flag3 = (object)this.miniGame == null;
				obj3 = 0;
				miniGameCard = selectedCard;
				if (!flag3)
				{
					miniGame = (MiniGame)(object)miniGame.<State>k__BackingField;
					bool flag4 = miniGame.<State>k__BackingField == null;
					obj3 = 0;
					miniGameCard = selectedCard;
					if (!flag4)
					{
						size = selectedCards._size;
						int size2 = selectedCards._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v3 (MiniGame)+14]");
						object obj4 = (nint)size2 - (nint)0;
						bool flag5 = obj4 == null;
						int size3 = selectedCards._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v3 (MiniGame)+14]");
						flag6 = (nint)size3 <= (nint)0;
						arg = selectedCards;
						if (flag6)
						{
							goto IL_0a03;
						}
						obj5 = obj2 + 24;
						Func<object, bool> func = (Func<object, bool>)obj5;
						bool flag7 = obj5 == null;
						object obj6 = !flag7;
						if (obj6 == null)
						{
							object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj8 = (nint)0 + (nint)1816;
							Func<object, bool> func2 = default(Func<object, bool>);
							func2..ctor(obj2, (IntPtr)obj8);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj9 = 0;
							func = func2;
						}
						miniGame = (MiniGame)((nint)0 + (nint)3616);
						num = (nint)miniGame;
						IEnumerable<object> enumerable = Enumerable.Where(selectedCards, func);
						bool flag8 = enumerable == null;
						obj3 = 0;
						miniGameCard = (MiniGameCard)(object)func;
						if (!flag8)
						{
							object obj10 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3512;
							nint num2 = (nint)enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v35 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v35 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0351;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v35 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
							object obj12 = (nint)0 + (nint)8;
							bool flag9 = flag6;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X10_v32-8]");
								obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X10_v32-8]");
								obj4 = 0 - obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X10_v32-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								obj14 = obj12 + 16;
								obj11--;
								obj4 = obj11 - 1;
								flag5 = obj4 == null;
								flag6 = (nint)obj11 != 1;
								obj12 = obj14;
								flag9 = flag6;
								if (flag6)
								{
									continue;
								}
								goto IL_0351;
							}
							object obj15 = num2 + obj12;
							obj16 = obj15 + 312;
							obj14 = obj12;
							flag6 = flag9;
							goto IL_0bea;
						}
					}
				}
			}
		}
		goto IL_0b8f;
		IL_06ce:
		object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj19;
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v23+12E]");
		size = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v23+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0786;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v23+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v12-8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v12-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj14 = obj20 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v23+12E]");
			size = (int)(-1);
			bool flag10 = size != 1;
			obj20 = obj14;
			if (flag10)
			{
				continue;
			}
			goto IL_0786;
		}
		size = (int)obj20;
		object obj21 = obj18 + obj20;
		object obj22 = obj21 + 312;
		obj14 = obj20;
		nint num3 = num;
		goto IL_0e1e;
		IL_0b8f:
		throw new NullReferenceException();
		IL_0e1e:
		miniGame = (MiniGame)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v28+8]");
		miniGameCard = (MiniGameCard)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v556 @ X0_v28] (should have been resolved before IL gen)");
		MiniGame miniGame3;
		MiniGame miniGame2 = miniGame3;
		object obj23 = obj13;
		object obj24 = obj14;
		object obj25 = obj9;
		object obj27;
		object obj26 = obj27;
		object obj28 = obj5;
		object obj29 = obj;
		object obj31;
		object obj30 = obj31;
		goto IL_0d8a;
		IL_0d8a:
		object obj33 = default(object);
		object obj35;
		while (true)
		{
			bool flag11 = obj30 == null;
			object obj32 = !flag11;
			miniGame3 = miniGame2;
			obj13 = obj23;
			obj14 = obj24;
			obj9 = obj25;
			num = num3;
			obj5 = obj28;
			obj = obj29;
			if (obj32 != null)
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)miniGameCard == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj31 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag12 = obj3 == null;
					object obj34 = !flag12;
					obj35 = obj33;
					obj27 = 0;
					obj19 = obj3;
					if (obj34 == null)
					{
						miniGame2 = miniGame3;
						obj35 = obj33;
						obj23 = obj13;
						obj24 = obj14;
						obj25 = obj9;
						num3 = num;
						obj26 = 0;
						obj28 = obj5;
						obj29 = obj;
						obj30 = obj33;
						continue;
					}
					goto IL_06ce;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		if ((nint)obj26 != 6)
		{
			bool flag13 = obj26 == null;
			object obj36 = !flag13;
			if (obj36 != null)
			{
				return;
			}
		}
		object obj37 = typeof(List<AdaptivePerformanceScaler>) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		miniGame = (MiniGame)((nint)0 + (nint)416);
		miniGameCard = (MiniGameCard)(object)miniGame;
		List<object> list = default(List<object>);
		list..ctor();
		bool flag14 = list == null;
		miniGame3 = miniGame2;
		obj13 = obj23;
		obj14 = obj24;
		obj9 = obj25;
		num = num3;
		obj5 = obj28;
		obj = obj29;
		if (!flag14)
		{
			object obj38 = (nint)0 + (nint)424;
			miniGame = (MiniGame)obj38;
			int version = ((List<MiniGameCard>)(object)list)._version + 1;
			((List<MiniGameCard>)(object)list)._version = version;
			size = (int)((List<MiniGameCard>)(object)list)._items;
			bool flag15 = ((List<MiniGameCard>)(object)list)._items == null;
			miniGame3 = miniGame2;
			obj13 = obj23;
			obj14 = obj24;
			obj9 = obj25;
			num = num3;
			obj5 = obj28;
			miniGameCard = (MiniGameCard)obj29;
			obj = obj29;
			if (!flag15)
			{
				int size4 = ((List<MiniGameCard>)(object)list)._size;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v1 (System.Int32)+18]");
				bool flag16 = (nint)size4 < (nint)0;
				object obj39 = !flag16;
				if (obj39 == null)
				{
					int size5 = ((List<MiniGameCard>)(object)list)._size + 1;
					((List<MiniGameCard>)(object)list)._size = size5;
					object obj40 = ((List<MiniGameCard>)(object)list)._items + ((List<MiniGameCard>)(object)list)._size;
					object obj41 = obj40 + 32;
					obj41 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					arg = (List<MiniGameCard>)(object)list;
				}
				else
				{
					list.AddWithResize(obj29);
					arg = (List<MiniGameCard>)(object)list;
				}
				goto IL_0a03;
			}
		}
		goto IL_0b8f;
		IL_0351:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = unchecked((nint)null);
		object obj42 = default(object);
		obj16 = obj42;
		goto IL_0bea;
		IL_0786:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num3 = unchecked((nint)null);
		goto IL_0e1e;
		IL_0bea:
		size = (int)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v36+8]");
		MiniGameCardStatus miniGameCardStatus = MiniGameCardStatus.InHand;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v630 @ X8_v36] (should have been resolved before IL gen)");
		object obj43 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj44 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 936;
		miniGame = (MiniGame)(&obj3);
		object obj45 = default(object);
		object obj49 = default(object);
		object obj51 = default(object);
		object obj55 = default(object);
		MiniGameCard miniGameCard2 = default(MiniGameCard);
		while (true)
		{
			if (obj45 != null)
			{
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v40+12E]");
				size = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v40+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0475;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v40+B0]");
				object obj47 = (nint)0 + (nint)8;
				bool flag17 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v27-8]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v27-8]");
					object obj4 = 0 - obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v27-8]");
					if (0 == (nint)obj43)
					{
						break;
					}
					obj14 = obj47 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v40+12E]");
					size = (int)(-1);
					obj4 = size - 1;
					bool flag5 = obj4 == null;
					flag6 = size != 1;
					obj47 = obj14;
					flag17 = flag6;
					if (flag6)
					{
						continue;
					}
					goto IL_0475;
				}
				size = (int)obj47;
				object obj48 = obj46 + obj47;
				obj49 = obj48 + 312;
				obj14 = obj47;
				flag6 = flag17;
				goto IL_0c91;
			}
			NullReferenceException ex2 = new NullReferenceException();
			miniGameCard = (MiniGameCard)miniGameCardStatus;
			goto IL_0a4b;
			IL_0c91:
			miniGame = (MiniGame)obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v47+8]");
			miniGameCard = (MiniGameCard)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v47] (should have been resolved before IL gen)");
			object obj50 = obj51 & 1;
			if (obj50 == null)
			{
				break;
			}
			if (obj45 != null)
			{
				object obj52 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v43+12E]");
				size = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v43+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v43+B0]");
				object obj53 = (nint)0 + (nint)8;
				bool flag18 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X10_v22-8]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X10_v22-8]");
					object obj4 = 0 - obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X10_v22-8]");
					if (0 == (nint)obj44)
					{
						break;
					}
					obj14 = obj53 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v43+12E]");
					size = (int)(-1);
					obj4 = size - 1;
					bool flag5 = obj4 == null;
					flag6 = size != 1;
					obj53 = obj14;
					flag18 = flag6;
					if (flag6)
					{
						continue;
					}
					goto IL_05b6;
				}
				size = (int)obj53;
				object obj54 = obj52 + obj53;
				obj55 = obj54 + 312;
				obj14 = obj53;
				flag6 = flag18;
				goto IL_0d2e;
			}
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_0a4b;
			IL_05b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = unchecked((nint)null);
			goto IL_0d2e;
			IL_0d2e:
			miniGame = (MiniGame)obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v51+8]");
			miniGameCard = (MiniGameCard)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v811 @ X0_v51] (should have been resolved before IL gen)");
			if ((object)miniGameCard2 != null)
			{
				miniGameCard2.SetStatus(MiniGameCardStatus.InHand);
				num = unchecked((nint)null);
				miniGameCardStatus = MiniGameCardStatus.InHand;
				continue;
			}
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_0a4b;
			IL_0a4b:
			miniGame3 = (MiniGame)(&obj3);
			obj3 = obj45;
			obj35 = 0;
			goto IL_0b8f;
			IL_0475:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = unchecked((nint)null);
			goto IL_0c91;
		}
		bool flag19 = obj45 == null;
		miniGame3 = (MiniGame)(&obj3);
		obj3 = obj45;
		obj35 = 0;
		obj27 = 6;
		obj19 = obj45;
		obj31 = 0;
		miniGame2 = (MiniGame)(&obj3);
		obj3 = obj45;
		obj35 = 0;
		obj23 = obj13;
		obj24 = obj14;
		obj25 = obj9;
		num3 = num;
		obj26 = 6;
		obj28 = obj5;
		obj29 = obj;
		obj30 = 0;
		if (!flag19)
		{
			goto IL_06ce;
		}
		goto IL_0d8a;
		IL_0a03:
		Actions.SafeInvoke((Action<object>)this.OnCardSelected, arg);
	}

	private unsafe void AnimateDrawCards()
	{
		//IL_214d: Expected O, but got I
		//IL_2156: Expected O, but got I4
		//IL_0046: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_2041: Expected O, but got I
		//IL_2062: Unknown result type (might be due to invalid IL or missing references)
		//IL_2067: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_20bc: Expected O, but got I
		//IL_20ca: Expected I, but got O
		//IL_20f6: Expected O, but got I
		//IL_20fe: Expected I, but got O
		//IL_209b: Expected O, but got I
		//IL_20a3: Expected I, but got O
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_016c: Expected O, but got I
		//IL_017a: Expected I, but got O
		//IL_018b: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I
		//IL_01f7: Expected I, but got O
		//IL_0208: Expected O, but got I
		//IL_0210: Expected I, but got O
		//IL_0253: Expected O, but got I4
		//IL_028f: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_02b9: Expected O, but got I
		//IL_030f: Expected O, but got I4
		//IL_036c: Expected O, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03d9: Expected O, but got I4
		//IL_03f7: Invalid comparison between F4 and I4
		//IL_0406: Invalid comparison between F4 and I4
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected I4, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected O, but got Unknown
		//IL_08ec: Expected O, but got I
		//IL_08fa: Expected I, but got O
		//IL_090b: Expected O, but got I
		//IL_0913: Expected I, but got O
		//IL_093c: Expected O, but got I4
		//IL_0944: Expected I4, but got O
		//IL_04bf: Expected O, but got I4
		//IL_0978: Expected O, but got I
		//IL_098e: Expected O, but got I
		//IL_04e9: Expected O, but got I
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Expected O, but got Unknown
		//IL_09c2: Expected I, but got O
		//IL_221e: Expected I, but got O
		//IL_22a7: Expected O, but got I4
		//IL_22b0: Expected O, but got I4
		//IL_22d1: Expected O, but got I4
		//IL_0a5f: Expected I, but got O
		//IL_0a7f: Expected O, but got I
		//IL_0aa1: Expected O, but got I4
		//IL_0aaa: Expected O, but got I4
		//IL_0b13: Expected O, but got I
		//IL_0b1b: Expected I, but got O
		//IL_0b3f: Expected I4, but got O
		//IL_0a07: Expected O, but got I
		//IL_0a29: Expected O, but got I4
		//IL_0a32: Expected O, but got I4
		//IL_05e5: Expected O, but got I4
		//IL_05ee: Expected O, but got I4
		//IL_05f7: Expected F4, but got O
		//IL_0aea: Expected O, but got I4
		//IL_0b77: Expected I, but got O
		//IL_22ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f3: Expected O, but got Unknown
		//IL_2309: Expected O, but got I
		//IL_231b: Expected I, but got O
		//IL_231b: Expected O, but got I4
		//IL_2323: Expected I, but got O
		//IL_2339: Expected O, but got I
		//IL_2354: Expected O, but got I4
		//IL_2365: Expected F4, but got I4
		//IL_0c0b: Expected I, but got O
		//IL_0c2b: Expected O, but got I
		//IL_0c4d: Expected O, but got I4
		//IL_06b2: Expected O, but got I4
		//IL_06b7: Expected I, but got O
		//IL_06c0: Expected O, but got I4
		//IL_06c9: Expected F4, but got O
		//IL_0cb6: Expected O, but got I
		//IL_0cbe: Expected I, but got O
		//IL_0cdb: Expected O, but got I
		//IL_0bbc: Expected O, but got I
		//IL_0bde: Expected O, but got I4
		//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Expected O, but got Unknown
		//IL_0d33: Expected O, but got I4
		//IL_0c8d: Expected O, but got I4
		//IL_0d70: Expected I4, but got O
		//IL_2379: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Expected O, but got Unknown
		//IL_2394: Expected O, but got I
		//IL_23a6: Expected I, but got O
		//IL_23a6: Expected O, but got I4
		//IL_23ae: Expected I, but got O
		//IL_23c4: Expected O, but got I
		//IL_23df: Expected O, but got I4
		//IL_23f0: Expected F4, but got I4
		//IL_21dc: Expected O, but got I4
		//IL_21e1: Expected I, but got O
		//IL_21ea: Expected O, but got I4
		//IL_21f3: Expected F4, but got O
		//IL_0da5: Expected O, but got I4
		//IL_0dc3: Invalid comparison between F4 and I4
		//IL_0dd2: Invalid comparison between F4 and I4
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected I4, but got Unknown
		//IL_0706: Expected I, but got O
		//IL_0726: Expected F4, but got I
		//IL_0736: Expected F4, but got I
		//IL_073f: Expected F4, but got I4
		//IL_074d: Expected O, but got I4
		//IL_19c6: Expected I4, but got O
		//IL_079c: Expected O, but got I4
		//IL_07b9: Invalid comparison between F4 and I4
		//IL_07c8: Invalid comparison between F4 and I4
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected I4, but got Unknown
		//IL_0821: Expected I, but got O
		//IL_082a: Expected O, but got I4
		//IL_0833: Expected F4, but got O
		//IL_0844: Expected F4, but got I4
		//IL_0854: Expected F4, but got I
		//IL_0864: Expected F4, but got I
		//IL_08b4: Expected F4, but got O
		//IL_19e8: Expected O, but got I
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_2729: Expected O, but got I4
		//IL_2743: Invalid comparison between F4 and I4
		//IL_2752: Invalid comparison between F4 and I4
		//IL_276f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2774: Expected I4, but got Unknown
		//IL_27cf: Expected F4, but got I4
		//IL_1192: Expected O, but got I
		//IL_119a: Expected I, but got O
		//IL_124e: Expected I4, but got O
		//IL_1256: Expected F4, but got I4
		//IL_125f: Expected O, but got I4
		//IL_1267: Expected O, but got I4
		//IL_1a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Expected O, but got Unknown
		//IL_1a5e: Expected F4, but got I4
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected O, but got Unknown
		//IL_1338: Expected I4, but got O
		//IL_1340: Expected F4, but got I4
		//IL_1349: Expected O, but got I4
		//IL_1a85: Expected O, but got I
		//IL_1ac4: Expected F4, but got I4
		//IL_140f: Expected I4, but got O
		//IL_1417: Expected F4, but got I4
		//IL_1420: Expected O, but got I4
		//IL_1b27: Expected F4, but got I4
		//IL_14e3: Expected I4, but got O
		//IL_14eb: Expected F4, but got I4
		//IL_14f4: Expected O, but got I4
		//IL_1b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5f: Expected O, but got Unknown
		//IL_1b89: Expected O, but got I4
		//IL_15b7: Expected I4, but got O
		//IL_15bf: Expected F4, but got I4
		//IL_15c8: Expected O, but got I4
		//IL_1bf6: Expected F4, but got I4
		//IL_167d: Expected I, but got O
		//IL_1691: Expected I4, but got O
		//IL_1699: Expected F4, but got I4
		//IL_16a2: Expected O, but got I4
		//IL_1c36: Expected O, but got I4
		//IL_1c50: Invalid comparison between F4 and I4
		//IL_1c5f: Invalid comparison between F4 and I4
		//IL_1c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c81: Expected I4, but got Unknown
		//IL_1cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cba: Expected O, but got Unknown
		//IL_1cca: Expected O, but got I
		//IL_1d0d: Expected F4, but got I4
		//IL_2403: Expected O, but got I4
		//IL_2416: Expected O, but got I4
		//IL_2440: Expected I, but got O
		//IL_2460: Expected F4, but got I
		//IL_2469: Invalid comparison between F4 and I4
		//IL_247a: Expected O, but got I4
		//IL_2483: Invalid comparison between F4 and I4
		//IL_2492: Invalid comparison between F4 and I4
		//IL_24a5: Expected I4, but got F4
		//IL_24ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_24b2: Expected I4, but got Unknown
		//IL_24e5: Expected O, but got I4
		//IL_1d99: Expected F4, but got I4
		//IL_1d9e: Expected I, but got O
		//IL_1db2: Expected F4, but got I4
		//IL_16eb: Expected O, but got I4
		//IL_253e: Expected O, but got I4
		//IL_257f: Expected I4, but got F4
		//IL_2594: Expected I, but got O
		//IL_25a8: Expected I4, but got O
		//IL_25b0: Expected F4, but got I4
		//IL_25b9: Expected O, but got I4
		//IL_25c2: Expected O, but got I4
		//IL_16dd: Expected O, but got I8
		//IL_1ded: Expected O, but got I4
		//IL_1e07: Invalid comparison between F4 and I4
		//IL_1e16: Invalid comparison between F4 and I4
		//IL_1e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e38: Expected I4, but got Unknown
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e71: Expected O, but got Unknown
		//IL_1e81: Expected O, but got I
		//IL_1ea1: Expected F4, but got I4
		//IL_1ea6: Expected I, but got O
		//IL_1eba: Expected F4, but got I4
		//IL_25e6: Expected O, but got I4
		//IL_2604: Expected O, but got I4
		//IL_2621: Invalid comparison between F4 and I4
		//IL_2630: Invalid comparison between F4 and I4
		//IL_2655: Unknown result type (might be due to invalid IL or missing references)
		//IL_265a: Expected I4, but got Unknown
		//IL_17a1: Expected O, but got I4
		//IL_17b1: Expected O, but got I
		//IL_17b9: Expected I, but got O
		//IL_1eef: Expected F4, but got I
		//IL_1723: Expected O, but got I4
		//IL_1733: Expected O, but got I
		//IL_173b: Expected I, but got O
		//IL_26a6: Expected O, but got I
		//IL_26c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cc: Expected O, but got Unknown
		//IL_26f6: Expected O, but got I4
		//IL_1763: Expected F4, but got I4
		//IL_1f81: Expected O, but got I4
		//IL_1f8a: Expected F4, but got I4
		//IL_1f8f: Expected I, but got O
		//IL_1f9b: Expected F4, but got I4
		//IL_1fb4: Expected F4, but got I4
		//IL_1fb9: Expected I, but got O
		//IL_1807: Expected I, but got O
		//IL_183a: Expected I4, but got O
		//IL_1842: Expected F4, but got I4
		//IL_184b: Expected O, but got I4
		//IL_1881: Expected F4, but got I
		//IL_1891: Expected O, but got I
		//IL_1902: Expected O, but got I
		//IL_193e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1943: Expected O, but got Unknown
		//IL_195e: Expected O, but got I
		//IL_196f: Expected I, but got O
		//IL_0efd: Expected I, but got O
		//IL_0f1d: Expected F4, but got I
		//IL_0f3f: Expected F4, but got I4
		//IL_0f3f: Expected O, but got I4
		//IL_0f4f: Expected O, but got I
		//IL_0f6a: Expected O, but got I
		//IL_0fa7: Expected O, but got I
		//IL_0fe4: Invalid comparison between F4 and I4
		//IL_0ff5: Expected O, but got I4
		//IL_1012: Invalid comparison between F4 and I4
		//IL_1026: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Expected I4, but got Unknown
		//IL_1038: Expected I4, but got F4
		//IL_1061: Invalid comparison between F4 and I4
		//IL_1082: Expected F4, but got I4
		//IL_108b: Expected O, but got I4
		//IL_1090: Expected I, but got O
		//IL_10a8: Expected I4, but got F4
		//IL_10d2: Expected F4, but got I
		//IL_1123: Expected O, but got I4
		//IL_1128: Expected I, but got O
		MiniGame miniGame = this.miniGame;
		bool flag = (object)this.miniGame == null;
		float num2 = default(float);
		float num = num2;
		float num4 = default(float);
		float num3 = num4;
		float num6 = default(float);
		float num5 = num6;
		IntPtr intPtr = default(IntPtr);
		Tween tween = (Tween)(nint)intPtr;
		Transform transform = (Transform)152985600;
		Sequence s = default(Sequence);
		List<object> list2;
		Sequence sequence = default(Sequence);
		Transform transform2;
		int num7;
		nint num8;
		object obj8;
		int num20;
		IEnumerable<object> enumerable;
		float num22 = default(float);
		if (!flag)
		{
			MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
			bool flag2 = miniGame.<State>k__BackingField == null;
			num = num2;
			num3 = num4;
			num5 = num6;
			tween = (Tween)(nint)intPtr;
			transform = (Transform)152985600;
			if (!flag2)
			{
				num7 = (int)((nint)0 + (nint)2520);
				tween = (Tween)((int*)num7)->m_value;
				if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)<State>k__BackingField.<HandCards>k__BackingField))
				{
					OnFinishedCardsAnimation();
					return;
				}
				MiniGame miniGame2 = this.miniGame;
				bool flag3 = (object)this.miniGame == null;
				num = num2;
				num3 = num4;
				num5 = num6;
				transform = (Transform)152985600;
				if (!flag3)
				{
					MiniGameState <State>k__BackingField2 = miniGame2.<State>k__BackingField;
					bool flag4 = miniGame2.<State>k__BackingField == null;
					num = num2;
					num3 = num4;
					num5 = num6;
					transform = (Transform)152985600;
					if (!flag4)
					{
						object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj2 = (nint)0 + (nint)2624;
						Func<object, bool> func = default(Func<object, bool>);
						func..ctor((object)this, (IntPtr)obj2);
						object obj3 = (nint)0 + (nint)3280;
						IEnumerable<object> source = Enumerable.Where(<State>k__BackingField2.<HandCards>k__BackingField, func);
						object obj4 = (nint)0 + (nint)1896;
						List<object> list = Enumerable.ToList(source);
						object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = (nint)0 + (nint)2632;
						Func<object, bool> func2 = default(Func<object, bool>);
						func2..ctor((object)this, (IntPtr)obj6);
						object obj7 = (nint)0 + (nint)3616;
						num8 = (nint)obj7;
						IEnumerable<object> source2 = Enumerable.Where(gameCards, func2);
						bool flag5 = list == null;
						num = num2;
						num3 = num4;
						num5 = num6;
						obj8 = 0;
						s = (Sequence)(object)func2;
						enumerable = list;
						tween = (Tween)(object)func2;
						transform = (Transform)(object)gameCards;
						if (!flag5)
						{
							object obj9 = (nint)0 + (nint)864;
							num8 = (nint)obj9;
							IEnumerable<object> source3 = Enumerable.Take(source2, list._size);
							object obj10 = (nint)0 + (nint)2432;
							tween = (Tween)obj10;
							list2 = Enumerable.ToList(source3);
							MiniGame miniGame3 = this.miniGame;
							bool flag6 = (object)this.miniGame == null;
							num = num2;
							num3 = num4;
							num5 = num6;
							obj8 = 0;
							s = (Sequence)(object)func2;
							enumerable = list;
							transform = (Transform)(object)gameCards;
							if (!flag6)
							{
								bool flag7 = (object)miniGame3.visuals == null;
								num = num2;
								num3 = num4;
								num5 = num6;
								obj8 = 0;
								s = (Sequence)(object)list2;
								enumerable = list;
								transform = (Transform)(object)gameCards;
								if (!flag7)
								{
									Vector3 drawPosition = miniGame3.visuals.GetDrawPosition();
									transform = (Transform)(typeof(UsageHint) + 816);
									bool flag8 = list._size < 1;
									object obj11 = !flag8;
									float num9 = (float)list._size - 1f;
									bool flag9 = num9 < 0f;
									bool flag10 = num9 == 0f;
									int num10 = list._size ^ 1;
									int num11 = list._size ^ num9;
									int num12 = num10 & num11;
									bool flag11 = num12 < 0;
									bool flag12 = list._size < 1;
									num = num2;
									num3 = num4;
									num5 = num6;
									Card card = (Card)obj10;
									if (flag12)
									{
										goto IL_08c2;
									}
									bool flag13 = list2 == null;
									num = num2;
									num3 = num4;
									num5 = num6;
									obj8 = 0;
									s = (Sequence)(object)list2;
									enumerable = list;
									if (!flag13)
									{
										transform2 = (Transform)((nint)0 + (nint)448);
										float num13 = num2;
										float num14 = num4;
										float num15 = num6;
										bool flag14 = flag12;
										bool flag15 = flag11;
										int num16 = num12;
										int num17 = num11;
										int num18 = num10;
										bool flag16 = flag10;
										bool flag17 = flag9;
										float num19 = num9;
										object obj12 = obj11;
										num20 = 0;
										float num21 = num22;
										while (true)
										{
											num8 = (nint)transform2;
											object obj13 = list2.get_Item(num20);
											bool flag18 = obj13 == null;
											num = num13;
											num3 = num14;
											num5 = num15;
											flag12 = flag14;
											flag11 = flag15;
											num12 = num16;
											num11 = num17;
											num10 = num18;
											flag10 = flag16;
											flag9 = flag17;
											num9 = num19;
											obj11 = obj12;
											obj8 = 0;
											sequence = (Sequence)1;
											num22 = num21;
											s = (Sequence)(object)list2;
											enumerable = list;
											tween = (Tween)num20;
											if (flag18)
											{
												break;
											}
											GameObject gameObject = ((Component)obj13).gameObject;
											bool flag19 = (object)gameObject == null;
											num = num13;
											num3 = num14;
											num5 = num15;
											flag12 = flag14;
											flag11 = flag15;
											num12 = num16;
											num11 = num17;
											num10 = num18;
											flag10 = flag16;
											flag9 = flag17;
											num9 = num19;
											obj11 = obj12;
											obj8 = 0;
											sequence = (Sequence)1;
											num22 = (float)obj13;
											s = (Sequence)(object)list2;
											enumerable = list;
											tween = null;
											if (flag19)
											{
												break;
											}
											gameObject.SetActive(value: true);
											Transform transform3 = ((Component)obj13).transform;
											bool flag20 = (object)transform3 == null;
											num = num13;
											num3 = num14;
											num5 = num15;
											flag12 = flag14;
											flag11 = flag15;
											num12 = num16;
											num11 = num17;
											num10 = num18;
											flag10 = flag16;
											flag9 = flag17;
											num9 = num19;
											obj11 = obj12;
											obj8 = 0;
											num8 = unchecked((nint)null);
											sequence = (Sequence)1;
											num22 = (float)obj13;
											s = (Sequence)(object)list2;
											enumerable = list;
											tween = null;
											if (flag20)
											{
												break;
											}
											Transform parent = transform3.parent;
											bool flag21 = (object)parent == null;
											num = num13;
											num3 = num14;
											num5 = num15;
											flag12 = flag14;
											flag11 = flag15;
											num12 = num16;
											num11 = num17;
											num10 = num18;
											flag10 = flag16;
											flag9 = flag17;
											num9 = num19;
											obj11 = obj12;
											obj8 = 0;
											num8 = unchecked((nint)null);
											sequence = (Sequence)1;
											num22 = (float)obj13;
											s = (Sequence)(object)list2;
											enumerable = list;
											tween = null;
											if (flag21)
											{
												break;
											}
											nint num23 = (nint)transform;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v171 (Il2CppClass<UnityEngine.Transform>)+B8]");
											nint num24 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v172 (Il2CppStaticFields<UnityEngine.Transform>)+4]");
											num5 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v172 (Il2CppStaticFields<UnityEngine.Transform>)+8]");
											num3 = 0f;
											num = UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
											parent.localEulerAngles = (Vector3)0;
											object obj14 = (((UiCard)obj13).Card = (Card)list.get_Item(num20));
											num20++;
											bool flag22 = num20 < list._size;
											obj11 = !flag22;
											num9 = (float)num20 - (float)list._size;
											flag9 = num9 < 0f;
											flag10 = num9 == 0f;
											num10 = num20 ^ list._size;
											num11 = num20 ^ num9;
											num12 = num10 & num11;
											flag11 = num12 < 0;
											flag12 = num20 < list._size;
											num8 = unchecked((nint)null);
											sequence = (Sequence)1;
											num22 = (float)obj13;
											card = (Card)obj14;
											num13 = UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v172 (Il2CppStaticFields<UnityEngine.Transform>)+8]");
											num14 = 0f;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X8_v172 (Il2CppStaticFields<UnityEngine.Transform>)+4]");
											num15 = 0f;
											flag14 = flag12;
											flag15 = flag11;
											num16 = num12;
											num17 = num11;
											num18 = num10;
											flag16 = flag10;
											flag17 = flag9;
											num19 = num9;
											obj12 = obj11;
											num21 = (float)obj13;
											if (flag12)
											{
												continue;
											}
											goto IL_08c2;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_1fcf;
		IL_0caa:
		object obj15 = (nint)0 + (nint)3576;
		num8 = (nint)obj15;
		Func<object, bool> predicate;
		int num25 = Enumerable.Count(enumerable, predicate);
		object obj16 = (nint)0 + (nint)2992;
		tween = (Tween)obj16;
		List<object> list3 = ArraysExtensions.Shuffle(list2);
		object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X0_v49+E4]");
		bool flag23 = (nint)0 == 0;
		object obj19 = !flag23;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence2 = DOTween.Sequence();
		bool flag24 = list3 == null;
		num20 = (int)list3;
		s = (Sequence)(object)list2;
		if (!flag24)
		{
			bool flag25 = list3._size < 1;
			object obj11 = !flag25;
			float num9 = (float)list3._size - 1f;
			bool flag9 = num9 < 0f;
			bool flag10 = num9 == 0f;
			int num10 = list3._size ^ 1;
			int num11 = list3._size ^ num9;
			int num12 = num10 & num11;
			bool flag11 = num12 < 0;
			bool flag12 = list3._size < 1;
			if (flag12)
			{
				goto IL_19a3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj21 = default(object);
			object obj20 = obj21;
			object obj23 = default(object);
			object obj22 = obj23;
			float num27 = default(float);
			float num26 = num27;
			float num28 = num;
			float num29 = num3;
			float num30 = num5;
			bool flag26 = flag12;
			bool flag27 = flag11;
			int num31 = num12;
			int num32 = num11;
			int num33 = num10;
			bool flag28 = flag9;
			float num34 = num9;
			object obj24 = obj11;
			object obj25 = obj8;
			nint num35 = num8;
			Sequence sequence3 = sequence;
			Transform transform4 = transform2;
			int num36 = 0;
			Tween tween2 = tween;
			int num37 = num7;
			object obj27 = default(object);
			Tween t = default(Tween);
			TweenCallback tweenCallback = default(TweenCallback);
			Tween t4 = default(Tween);
			while (true)
			{
				object obj26 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj27..ctor();
				object obj28 = (nint)0 + (nint)448;
				num8 = (nint)obj28;
				object obj29 = list3.get_Item(num36);
				bool flag29 = obj27 == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				sequence = sequence3;
				transform2 = transform4;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = (Tween)num36;
				num7 = num37;
				if (flag29)
				{
					break;
				}
				sequence = (Sequence)(obj27 + 16);
				sequence = (Sequence)obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag30 = sequence == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				transform2 = transform4;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = (Tween)obj29;
				num7 = num37;
				if (flag30)
				{
					break;
				}
				Transform transform5 = ((Component)(object)sequence).transform;
				bool flag31 = (object)transform5 == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				transform2 = transform4;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = null;
				num7 = num37;
				if (flag31)
				{
					break;
				}
				Transform parent2 = transform5.parent;
				bool flag32 = sequence == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				transform2 = transform5;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = null;
				num7 = num37;
				if (flag32)
				{
					break;
				}
				GameObject gameObject2 = ((Component)(object)sequence).gameObject;
				bool flag33 = (object)gameObject2 == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				transform2 = transform5;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = null;
				num7 = num37;
				if (flag33)
				{
					break;
				}
				gameObject2.SetActive(value: false);
				bool flag34 = sequence == null;
				obj21 = obj20;
				obj23 = obj22;
				num27 = num26;
				num = num28;
				num3 = num29;
				num5 = num30;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = obj25;
				num8 = unchecked((nint)null);
				transform2 = transform5;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = null;
				num7 = num37;
				if (flag34)
				{
					break;
				}
				((MiniGameCard)(object)sequence).ToggleCardFace(show: false);
				transform5.position = (Vector3)0;
				transform5.localScale = (Vector3)0;
				float value = UnityEngine.Random.value;
				float num38 = value + -0.5f;
				nint num39 = (nint)transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X8_v101 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v102 (Il2CppStaticFields<UnityEngine.Transform>)+20]");
				num27 = 0f;
				bool flag35 = num38 < 0f;
				obj11 = !flag35;
				flag9 = num38 < 0f;
				flag10 = num38 == 0f;
				num11 = num38 ^ num38;
				num12 = num38 & num11;
				flag11 = num12 < 0;
				bool flag36 = flag9 == flag11;
				flag12 = !flag36;
				obj21 = !flag12;
				obj23 = ((obj21 != null) ? ((object)1127415808) : ((object)3274899456L));
				float num41 = (float)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v102 (Il2CppStaticFields<UnityEngine.Transform>)+18]");
				float num42 = num41 * 0f;
				float num43 = (float)obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v102 (Il2CppStaticFields<UnityEngine.Transform>)+1C]");
				float num44 = num43 * 0f;
				float num45 = (float)obj23 * num27;
				transform5.localEulerAngles = (Vector3)0;
				int num46 = ShortcutExtensions.DOKill(parent2, complete: true);
				bool flag37 = (object)parent2 == null;
				num = num42;
				num3 = num45;
				num5 = num44;
				num10 = (int)num38;
				num9 = num38;
				obj8 = obj25;
				num8 = unchecked((nint)null);
				transform2 = transform5;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				tween = (Tween)1;
				num7 = num37;
				if (flag37)
				{
					break;
				}
				Vector3 localEulerAngles = parent2.localEulerAngles;
				parent2.localEulerAngles = (Vector3)0;
				bool flag38 = list2._size < num25;
				obj11 = !flag38;
				num9 = (float)list2._size - (float)num25;
				flag9 = num9 < 0f;
				flag10 = num9 == 0f;
				num10 = list2._size ^ num25;
				num11 = list2._size ^ num9;
				num12 = num10 & num11;
				flag11 = num12 < 0;
				if (list2._size < num25)
				{
					num27 = moveSpeed;
					TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(parent2, (Vector3)0, num42);
					object obj30 = (nint)0 + (nint)2848;
					num8 = (nint)obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					num = organizeDelay * (float)num36;
					num5 = num36;
				}
				else
				{
					float num47 = organizeSpacing * (float)num36;
					num27 = organizeSpeed - num47;
					TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(parent2, (Vector3)0, num42);
					object obj31 = (nint)0 + (nint)2840;
					num8 = (nint)obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
					num = organizeDelay * (float)num36;
					num5 = num44;
				}
				object obj32 = (nint)0 + (nint)2744;
				tween = (Tween)obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				object obj33 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X0_v104+E4]");
				bool flag39 = (nint)0 == 0;
				object obj35 = !flag39;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Sequence sequence4 = DOTween.Sequence();
				nint num48 = (nint)sequence;
				bool flag40 = sequence == null;
				num3 = num45;
				obj8 = obj25;
				transform2 = transform5;
				num20 = (int)list3;
				num22 = num36;
				s = (Sequence)146599936;
				num7 = num25;
				if (flag40)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v117 (Il2CppClass<DG.Tweening.Sequence>)+30]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMoveY(transform5, 0f, moveSpeed);
				object obj36 = (nint)0 + (nint)2896;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
				Sequence sequence5 = TweenSettingsExtensions.Join(sequence4, t);
				TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(transform5, 1f, scaleSpeed);
				Sequence sequence6 = TweenSettingsExtensions.Join(sequence4, t2);
				Sequence s2 = DOTween.Sequence();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1066 @ X0_v78 (System.Object)+10]");
				TweenCallback callback = TweenHelpers.Enable((Component)0);
				Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, callback);
				Sequence sequence7 = TweenSettingsExtensions.AppendInterval(s3, flipDelay);
				object obj37 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj38 = (nint)0 + (nint)1832;
				tweenCallback..ctor(obj27, (IntPtr)obj38);
				Sequence t3 = TweenSettingsExtensions.AppendCallback(sequence7, tweenCallback);
				Sequence sequence8 = TweenSettingsExtensions.Join(sequence4, t3);
				num37 = num25;
				nint num49 = (nint)transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v128 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X8_v129 (Il2CppStaticFields<UnityEngine.Transform>)+8]");
				num29 = 0f;
				num26 = rotateSpeed;
				TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore4 = ShortcutExtensions.DOLocalRotate(transform5, (Vector3)0, UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject);
				object obj39 = (nint)0 + (nint)2848;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				object obj40 = (nint)0 + (nint)2744;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence sequence9 = TweenSettingsExtensions.Join(sequence4, t4);
				num28 = cardSpacing * (float)num36;
				object obj41 = (nint)0 + (nint)2784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence sequence10 = TweenSettingsExtensions.Join(sequence2, sequence4);
				num22 = (float)num36 + 1f;
				bool flag41 = num22 < (float)list3._size;
				obj24 = !flag41;
				num34 = num22 - (float)list3._size;
				flag28 = num34 < 0f;
				num33 = num22 ^ list3._size;
				num32 = num22 ^ num34;
				num31 = num33 & num32;
				flag27 = num31 < 0;
				flag26 = !(num22 < (float)list3._size);
				obj20 = obj21;
				obj22 = obj23;
				num30 = num36;
				obj25 = 0;
				num35 = unchecked((nint)null);
				sequence3 = sequence7;
				transform4 = transform5;
				num36 = (int)num22;
				tween2 = sequence4;
				num27 = rotateSpeed;
				num = num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X8_v129 (Il2CppStaticFields<UnityEngine.Transform>)+8]");
				num3 = 0f;
				num5 = num22;
				flag12 = flag26;
				flag11 = flag27;
				num12 = num31;
				num11 = num32;
				num10 = num33;
				flag9 = flag28;
				num9 = num34;
				obj11 = obj24;
				obj8 = 0;
				num8 = unchecked((nint)null);
				sequence = sequence7;
				transform2 = transform5;
				tween = sequence4;
				num7 = num25;
				if (!flag26)
				{
					continue;
				}
				goto IL_19a3;
			}
		}
		goto IL_1fcf;
		IL_0c5b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v159 (Il2CppClass<UnityEngine.Transform>)+E4]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v159 (Il2CppClass<UnityEngine.Transform>)+E4]");
		bool flag42 = (nint)0 == 0;
		object obj42 = !flag42;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj44 = (nint)0 + (nint)1760;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor((object)UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject, (IntPtr)obj44);
		nint num51 = (nint)transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ X8_v151 (Il2CppClass<UnityEngine.Transform>)+B8]");
		object obj45 = (nint)0 + (nint)24;
		obj45 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		predicate = func3;
		num22 = UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
		goto IL_0caa;
		IL_19a3:
		MiniGameCard[] array = gameCards;
		bool flag43 = gameCards == null;
		num20 = (int)list3;
		s = sequence2;
		if (flag43)
		{
			goto IL_1fcf;
		}
		transform2 = (Transform)((nint)0 + (nint)2784);
		float num52 = num;
		float num53 = num5;
		nint num54 = num8;
		int num55 = 0;
		Tween t7 = default(Tween);
		while (true)
		{
			num7 = array.Length;
			bool flag44 = num55 < array.Length;
			object obj11 = !flag44;
			float num9 = (float)num55 - (float)array.Length;
			bool flag9 = num9 < 0f;
			bool flag10 = num9 == 0f;
			int num10 = num55 ^ array.Length;
			int num11 = num55 ^ num9;
			int num12 = num10 & num11;
			bool flag11 = num12 < 0;
			bool flag12 = num55 >= array.Length;
			num = num52;
			num5 = num53;
			num8 = num54;
			num20 = num55;
			num22 = 1.05360915E+09f;
			s = sequence2;
			if (flag12)
			{
				break;
			}
			object obj46 = array + num55;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v69+20]");
			bool flag45 = (nint)0 == 0;
			num = num52;
			num5 = num53;
			num8 = num54;
			num20 = num55;
			num22 = 1.05360915E+09f;
			s = sequence2;
			if (!flag45)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v69+20]");
				Transform transform6 = ((Component)0).transform;
				bool flag46 = (object)transform6 == null;
				num = num52;
				num5 = num53;
				num8 = num54;
				num20 = num55;
				num22 = 1.05360915E+09f;
				s = sequence2;
				tween = null;
				if (!flag46)
				{
					Transform parent3 = transform6.parent;
					bool flag47 = (object)parent3 == null;
					num = num52;
					num5 = num53;
					num8 = num54;
					num20 = num55;
					num22 = 1.05360915E+09f;
					s = sequence2;
					tween = null;
					if (!flag47)
					{
						parent3.SetAsLastSibling();
						object obj47 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
						object obj48 = obj47;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1091 @ X0_v58+E4]");
						bool flag48 = (nint)0 == 0;
						object obj49 = !flag48;
						if (obj49 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Sequence s4 = DOTween.Sequence();
						MiniGameCard[] array2 = gameCards;
						bool flag49 = gameCards == null;
						num = num52;
						num5 = num53;
						num8 = num54;
						num20 = num55;
						num22 = 1.05360915E+09f;
						s = sequence2;
						tween = null;
						if (!flag49)
						{
							num7 = array2.Length;
							bool flag50 = num55 < array2.Length;
							obj11 = !flag50;
							num9 = (float)num55 - (float)array2.Length;
							flag9 = num9 < 0f;
							flag10 = num9 == 0f;
							num10 = num55 ^ array2.Length;
							num11 = num55 ^ num9;
							num12 = num10 & num11;
							flag11 = num12 < 0;
							if (obj11 != null)
							{
								goto IL_210b;
							}
							object obj50 = gameCards + num55;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v75+20]");
							object obj51 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v75+20]");
							bool flag51 = (nint)0 == 0;
							num = num52;
							num5 = num53;
							num8 = num54;
							num20 = num55;
							num22 = 1.05360915E+09f;
							s = sequence2;
							tween = null;
							if (!flag51)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v76+30]");
								num = 0f + 10f;
								TweenerCore<Vector3, Vector3, VectorOptions> t5 = ShortcutExtensions.DOLocalMoveY(transform6, num, 0.4f);
								Sequence s5 = TweenSettingsExtensions.Append(s4, t5);
								MiniGameCard[] array3 = gameCards;
								bool flag52 = gameCards == null;
								num5 = 1.05360915E+09f;
								num8 = unchecked((nint)null);
								num20 = num55;
								num22 = 1.05360915E+09f;
								s = sequence2;
								if (!flag52)
								{
									num7 = array3.Length;
									bool flag53 = num55 < array3.Length;
									obj11 = !flag53;
									num9 = (float)num55 - (float)array3.Length;
									flag9 = num9 < 0f;
									flag10 = num9 == 0f;
									num10 = num55 ^ array3.Length;
									num11 = num55 ^ num9;
									num12 = num10 & num11;
									flag11 = num12 < 0;
									if (obj11 != null)
									{
										goto IL_210b;
									}
									object obj52 = gameCards + num55;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v78+20]");
									object obj53 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v78+20]");
									bool flag54 = (nint)0 == 0;
									num5 = 1.05360915E+09f;
									num8 = unchecked((nint)null);
									num20 = num55;
									num22 = 1.05360915E+09f;
									s = sequence2;
									if (!flag54)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v79+30]");
										TweenerCore<Vector3, Vector3, VectorOptions> t6 = ShortcutExtensions.DOLocalMoveY(transform6, 0f, 0.4f);
										Sequence sequence11 = TweenSettingsExtensions.Append(s5, t6);
										float num56 = (float)num55 * 1.03280544E+09f;
										num = num56 + 1f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
										Sequence sequence12 = TweenSettingsExtensions.Join(sequence2, t7);
										num20 = num55 + 1;
										array = gameCards;
										bool flag55 = gameCards == null;
										object obj54 = !flag55;
										num5 = 1.03280544E+09f;
										num8 = unchecked((nint)null);
										num22 = 1.05360915E+09f;
										s = sequence2;
										num52 = num;
										num53 = 1.03280544E+09f;
										num54 = unchecked((nint)null);
										num55 = num20;
										if (obj54 != null)
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
			goto IL_1fcf;
			IL_210b:
			throw new IndexOutOfRangeException();
		}
		goto IL_1fdd;
		IL_1fcf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1fdd;
		IL_1fdd:
		MiniGame miniGame4 = this.miniGame;
		if ((object)this.miniGame != null)
		{
			MiniGameState <State>k__BackingField3 = miniGame4.<State>k__BackingField;
			if (miniGame4.<State>k__BackingField != null)
			{
				object obj55 = (nint)0 + (nint)2272;
				bool flag56 = Enumerable.Any((IEnumerable<object>)<State>k__BackingField3.<Rewards>k__BackingField);
				object obj56 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint method;
				TweenCallback callback2;
				TweenCallback tweenCallback2 = default(TweenCallback);
				if (flag56)
				{
					object obj57 = (nint)0 + (nint)2664;
					method = (nint)obj57;
					callback2 = tweenCallback2;
				}
				else
				{
					object obj58 = (nint)0 + (nint)2680;
					tweenCallback2..ctor(this, (IntPtr)obj58);
					Sequence sequence13 = TweenSettingsExtensions.AppendCallback(s, tweenCallback2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj59 = (nint)0 + (nint)2720;
					method = (nint)obj59;
					callback2 = tweenCallback2;
				}
				tweenCallback2..ctor(this, method);
				Sequence sequence14 = TweenSettingsExtensions.AppendCallback(s, callback2);
				return;
			}
		}
		goto IL_1fcf;
		IL_0b07:
		object obj60 = (nint)0 + (nint)2200;
		num8 = (nint)obj60;
		IEnumerable<object> enumerable2;
		Action<object> action;
		ArraysExtensions.ForEach(enumerable2, action);
		bool flag57 = list2 == null;
		num20 = (int)action;
		s = (Sequence)(object)list2;
		enumerable = enumerable2;
		tween = (Tween)(object)action;
		if (!flag57)
		{
			enumerable = gameCards;
			nint num57 = (nint)transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X0_v43 (Il2CppClass<UnityEngine.Transform>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X0_v43 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v155 (Il2CppStaticFields<UnityEngine.Transform>)+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v155 (Il2CppStaticFields<UnityEngine.Transform>)+18]");
				bool flag58 = (nint)0 == 0;
				object obj61 = !flag58;
				if (obj61 == null)
				{
					nint num59 = num57;
					goto IL_0c5b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num59 = (nint)transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ X0_v159 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v154 (Il2CppStaticFields<UnityEngine.Transform>)+18]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v154 (Il2CppStaticFields<UnityEngine.Transform>)+18]");
				bool flag59 = (nint)0 == 0;
				object obj62 = !flag59;
				if (obj62 == null)
				{
					goto IL_0c5b;
				}
			}
			goto IL_0caa;
		}
		goto IL_1fcf;
		IL_08c2:
		object obj63 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj64 = (nint)0 + (nint)2728;
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor((object)null, (IntPtr)obj64);
		object obj65 = (nint)0 + (nint)3992;
		num8 = (nint)obj65;
		Array.Sort(gameCards, comparison);
		bool flag60 = organizer == null;
		obj8 = 0;
		num20 = (int)comparison;
		s = (Sequence)(object)list2;
		enumerable = gameCards;
		tween = (Tween)(object)comparison;
		if (!flag60)
		{
			object obj66 = (nint)0 + (nint)1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4389544");
			object obj67 = (nint)0 + (nint)3880;
			enumerable2 = Enumerable.Except(gameCards, list2);
			transform2 = (Transform)(typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680);
			nint num61 = (nint)transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v40 (Il2CppClass<UnityEngine.Transform>)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X0_v40 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v166 (Il2CppStaticFields<UnityEngine.Transform>)+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v166 (Il2CppStaticFields<UnityEngine.Transform>)+10]");
				bool flag61 = (nint)0 == 0;
				object obj68 = !flag61;
				obj8 = 0;
				if (obj68 == null)
				{
					nint num63 = num61;
					goto IL_0ab8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				nint num63 = (nint)transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v169 (Il2CppClass<UnityEngine.Transform>)+B8]");
				nint num64 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v165 (Il2CppStaticFields<UnityEngine.Transform>)+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X8_v165 (Il2CppStaticFields<UnityEngine.Transform>)+10]");
				bool flag62 = (nint)0 == 0;
				object obj69 = !flag62;
				obj8 = 0;
				if (obj69 == null)
				{
					goto IL_0ab8;
				}
			}
			goto IL_0b07;
		}
		goto IL_1fcf;
		IL_0ab8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v169 (Il2CppClass<UnityEngine.Transform>)+E4]");
		num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X0_v169 (Il2CppClass<UnityEngine.Transform>)+E4]");
		bool flag63 = (nint)0 == 0;
		object obj70 = !flag63;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj71 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj72 = (nint)0 + (nint)1752;
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject, (IntPtr)obj72);
		nint num65 = (nint)transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X8_v162 (Il2CppClass<UnityEngine.Transform>)+B8]");
		object obj73 = (nint)0 + (nint)16;
		obj73 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = 0;
		action = action2;
		num22 = UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
		goto IL_0b07;
	}

	private void OnNoRewards()
	{
		//IL_0032: Expected O, but got I
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	private void HighlightRewards()
	{
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Expected O, but got Unknown
		//IL_101e: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_0fa3: Expected O, but got I
		//IL_0fb4: Expected I, but got O
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_012a: Expected I, but got O
		//IL_015e: Expected I, but got O
		//IL_0185: Expected I, but got O
		//IL_019f: Expected O, but got I
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0231: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_024e: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_0285: Expected I, but got O
		//IL_02bc: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_0458: Expected O, but got I4
		//IL_039d: Expected O, but got I
		//IL_03e4: Expected O, but got I4
		//IL_049c: Expected O, but got I4
		//IL_04d6: Expected F4, but got O
		//IL_04df: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_0764: Expected O, but got I4
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_078d: Expected O, but got I
		//IL_07b7: Expected O, but got I4
		//IL_07bf: Expected I, but got O
		//IL_0f16: Expected O, but got I4
		//IL_0f1b: Expected I, but got O
		//IL_07d9: Expected O, but got I
		//IL_07e1: Expected I, but got O
		//IL_080b: Expected O, but got I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_0543: Expected O, but got I
		//IL_0f32: Expected O, but got I4
		//IL_082e: Expected O, but got I
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_0ec9: Expected O, but got I4
		//IL_0ece: Expected I, but got O
		//IL_08f8: Expected O, but got I
		//IL_092a: Expected O, but got I4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_1062: Expected O, but got I
		//IL_108c: Expected O, but got I4
		//IL_0891: Expected O, but got I
		//IL_08c3: Expected O, but got I4
		//IL_05d8: Expected I, but got O
		//IL_095a: Expected O, but got I4
		//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Expected O, but got Unknown
		//IL_10cc: Expected O, but got I
		//IL_10dd: Expected I, but got O
		//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f1: Expected O, but got Unknown
		//IL_110f: Expected O, but got I
		//IL_0ee5: Expected O, but got I4
		//IL_0eee: Expected O, but got I4
		//IL_0ef7: Expected O, but got I4
		//IL_0eff: Expected I, but got O
		//IL_09f5: Expected O, but got I4
		//IL_09fe: Expected O, but got I4
		//IL_0a03: Expected I, but got O
		//IL_09ab: Expected I, but got O
		//IL_09b4: Expected O, but got I4
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_099e: Expected O, but got I
		//IL_0e9b: Expected O, but got I4
		//IL_0ea4: Expected O, but got I4
		//IL_0ead: Expected O, but got I4
		//IL_0eb2: Expected I, but got O
		//IL_113e: Expected O, but got I4
		//IL_1147: Expected O, but got I4
		//IL_114c: Expected I, but got O
		//IL_0f51: Expected F4, but got I4
		//IL_0f5a: Expected O, but got I4
		//IL_0f63: Expected O, but got I4
		//IL_0f6c: Expected O, but got I4
		//IL_0f74: Expected I, but got O
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Expected O, but got Unknown
		//IL_0a61: Expected O, but got I
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Expected O, but got Unknown
		//IL_0ac4: Expected O, but got I4
		//IL_06ea: Expected F4, but got I4
		//IL_06f3: Expected F4, but got I4
		//IL_06fc: Expected O, but got I4
		//IL_0705: Expected O, but got I4
		//IL_0af6: Expected O, but got I4
		//IL_0aff: Expected O, but got I4
		//IL_0b04: Expected I, but got O
		//IL_0b20: Expected O, but got I4
		//IL_1169: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_1186: Expected O, but got I
		//IL_1196: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Expected O, but got Unknown
		//IL_11bc: Expected O, but got I4
		//IL_11cc: Expected O, but got I
		//IL_0b6e: Expected O, but got I4
		//IL_0b83: Expected O, but got I
		//IL_0bec: Expected F4, but got I4
		//IL_0bf5: Expected F4, but got I4
		//IL_0bfe: Expected F4, but got I4
		//IL_0c07: Expected O, but got I4
		//IL_0c10: Expected O, but got I4
		//IL_0c15: Expected I, but got O
		//IL_0c50: Expected F4, but got I4
		//IL_0c59: Expected F4, but got I4
		//IL_0c62: Expected F4, but got I4
		//IL_0c6b: Expected O, but got I4
		//IL_0c74: Expected O, but got I4
		//IL_0c79: Expected I, but got O
		//IL_0cbe: Expected F4, but got I4
		//IL_0cc7: Expected F4, but got I4
		//IL_0cd0: Expected F4, but got I4
		//IL_0cd9: Expected O, but got I4
		//IL_0ce2: Expected O, but got I4
		//IL_0ce7: Expected I, but got O
		//IL_0d1f: Expected F4, but got I4
		//IL_0d28: Expected F4, but got I4
		//IL_0d31: Expected F4, but got I4
		//IL_0d3a: Expected O, but got I4
		//IL_0d43: Expected O, but got I4
		//IL_0d48: Expected I, but got O
		//IL_0daa: Expected O, but got I
		//IL_0e04: Expected O, but got I4
		//IL_0e1a: Expected F4, but got I4
		//IL_0e23: Expected F4, but got I4
		//IL_0e2c: Expected O, but got I4
		//IL_0e35: Expected O, but got I4
		//IL_0e3d: Expected I, but got O
		//IL_0e61: Expected F4, but got I4
		//IL_0e6a: Expected F4, but got I4
		//IL_0e73: Expected O, but got I4
		//IL_0e7c: Expected O, but got I4
		//IL_0e84: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		MiniGame miniGame = this.miniGame;
		IntPtr intPtr = default(IntPtr);
		TweenCallback tweenCallback2 = default(TweenCallback);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore;
		float num4;
		object obj16;
		object obj9;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num2;
		if ((object)this.miniGame != null)
		{
			object obj4 = (nint)0 + (nint)3520;
			object obj5 = (nint)0 + (nint)1848;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			int num = 0;
			MiniGameHand miniGameHand = this;
			object obj7 = default(object);
			Func<object, bool> func = default(Func<object, bool>);
			TweenCallback tweenCallback = default(TweenCallback);
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			object obj26 = default(object);
			GameObject gameObject = default(GameObject);
			TextMeshProUGUI textMesh = default(TextMeshProUGUI);
			Func<object, int> func2 = default(Func<object, int>);
			int siblingIndex = default(int);
			object obj54 = default(object);
			object obj55 = default(object);
			float num8 = default(float);
			object obj60 = default(object);
			Tween t2 = default(Tween);
			Tween t3 = default(Tween);
			while (true)
			{
				MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
				if (miniGame.<State>k__BackingField == null)
				{
					break;
				}
				List<MiniGameReward> <Rewards>k__BackingField = <State>k__BackingField.<Rewards>k__BackingField;
				if (<State>k__BackingField.<Rewards>k__BackingField == null)
				{
					break;
				}
				object obj11;
				List<object> list;
				Sequence sequence2;
				if (num < <Rewards>k__BackingField._size)
				{
					object obj6 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3712;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj7..ctor();
					MiniGame miniGame2 = miniGameHand.miniGame;
					bool flag2 = (object)miniGameHand.miniGame == null;
					num2 = unchecked((nint)null);
					if (flag2)
					{
						break;
					}
					MiniGameState <State>k__BackingField2 = miniGame2.<State>k__BackingField;
					bool flag3 = miniGame2.<State>k__BackingField == null;
					num2 = unchecked((nint)null);
					if (flag3)
					{
						break;
					}
					bool flag4 = <State>k__BackingField2.<Rewards>k__BackingField == null;
					num2 = unchecked((nint)null);
					if (flag4)
					{
						break;
					}
					object obj8 = (nint)0 + (nint)488;
					obj9 = obj8;
					object obj10 = ((List<object>)(object)<State>k__BackingField2.<Rewards>k__BackingField).get_Item(num);
					bool flag5 = obj7 == null;
					num2 = num;
					if (flag5)
					{
						break;
					}
					obj11 = obj7 + 16;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)1840;
					func..ctor(obj7, (IntPtr)obj13);
					object obj14 = (nint)0 + (nint)3616;
					obj9 = obj14;
					IEnumerable<object> source = Enumerable.Where(miniGameHand.gameCards, func);
					object obj15 = (nint)0 + (nint)2432;
					num2 = (nint)obj15;
					list = Enumerable.ToList(source);
					MiniGame miniGame3 = miniGameHand.miniGame;
					bool flag6 = (object)miniGameHand.miniGame == null;
					obj16 = 0;
					if (flag6)
					{
						break;
					}
					object obj17 = obj11;
					bool flag7 = obj11 == null;
					obj16 = 0;
					if (flag7)
					{
						break;
					}
					bool flag8 = (object)miniGame3.visuals == null;
					obj16 = 0;
					if (flag8)
					{
						break;
					}
					MiniGameVisuals visuals = miniGame3.visuals;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X9_v6+18]");
					visuals.PlayRewardSound(0);
					object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
					object obj19 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ X0_v31+E4]");
					Sequence sequence3;
					if ((nint)0 != 0)
					{
						Sequence sequence = DOTween.Sequence();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
						object obj20 = (nint)0 & (nint)1;
						bool flag9 = obj20 == null;
						sequence2 = sequence;
						sequence3 = sequence;
						if (!flag9)
						{
							goto IL_03ca;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Sequence sequence4 = DOTween.Sequence();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
						object obj21 = (nint)0 & (nint)1;
						bool flag10 = obj21 == null;
						object obj22 = !flag10;
						sequence2 = sequence4;
						sequence3 = sequence4;
						if (obj22 != null)
						{
							goto IL_03ca;
						}
					}
					_ = 1;
					bool flag11 = list == null;
					sequence2 = sequence3;
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X9_v6+18]");
					num2 = 0;
					if (flag11)
					{
						break;
					}
					goto IL_04ba;
				}
				object obj23 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)2680;
				tweenCallback..ctor(miniGameHand, (IntPtr)obj24);
				Sequence sequence5 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
				return;
				IL_04ba:
				List<object>.Enumerator enumerator = list.GetEnumerator();
				float num3 = (float)enumerator2;
				obj16 = 0;
				while (enumerator3.MoveNext())
				{
					object obj25 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3720;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj26..ctor();
					if (obj26 == null)
					{
						goto IL_0f04;
					}
					object obj27 = obj26 + 16;
					obj27 = (nint)intPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj27 == null)
					{
						goto IL_0f20;
					}
					Transform transform = ((Component)obj27).transform;
					if ((object)transform == null)
					{
						goto IL_0eb7;
					}
					Vector3 position = transform.position;
					object obj28 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					tweenCallback2..ctor(obj26, (IntPtr)obj5);
					Sequence sequence6 = TweenSettingsExtensions.PrependCallback(sequence2, tweenCallback2);
					if (obj27 == null)
					{
						goto IL_0ed3;
					}
					Transform target = ((Component)obj27).transform;
					object obj29 = obj27;
					if (obj27 == null)
					{
						goto IL_0e89;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v108+30]");
					num3 = 0f + 30f;
					tweenerCore = ShortcutExtensions.DOLocalMoveY(target, num3, 0.7f);
					Sequence sequence7 = TweenSettingsExtensions.Join(sequence2, tweenerCore);
					if (obj27 != null)
					{
						Transform target2 = ((Component)obj27).transform;
						TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(target2, 1.1f, 0.7f);
						Sequence sequence8 = TweenSettingsExtensions.Join(sequence2, t);
						num4 = 1.06032006E+09f;
						num3 = 1.06619206E+09f;
						obj16 = 0;
						obj9 = 0;
						continue;
					}
					goto IL_0f3f;
				}
				enumerator3.Dispose();
				Transform transform2 = miniGameHand.transform;
				object obj30 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v41+E4]");
				bool flag12 = (nint)0 == 0;
				object obj32 = !flag12;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj33 = (nint)0 + (nint)544;
				obj9 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				bool flag13 = (object)gameObject == null;
				enumerator2 = (List<object>.Enumerator)0;
				num2 = (nint)transform2;
				if (flag13)
				{
					break;
				}
				object obj34 = (nint)0 + (nint)1560;
				num2 = (nint)obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
				object obj35 = obj11;
				bool flag14 = obj11 == null;
				enumerator2 = (List<object>.Enumerator)0;
				if (flag14)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v56+10]");
				TextMeshProExtensions.Localize(textMesh, (string)0);
				Transform transform3 = gameObject.transform;
				object obj36 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
				object obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v94+E4]");
				object obj38;
				nint num5;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v94+B8]");
					obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v90+20]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v90+20]");
					bool flag15 = (nint)0 == 0;
					object obj39 = !flag15;
					if (obj39 == null)
					{
						goto IL_0938;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v94+B8]");
					obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v90+20]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v90+20]");
					bool flag16 = (nint)0 == 0;
					object obj40 = !flag16;
					if (obj40 == null)
					{
						goto IL_0938;
					}
				}
				goto IL_1056;
				IL_0938:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v94+E4]");
				bool flag17 = (nint)0 == 0;
				object obj41 = !flag17;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj42 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
					object obj43 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v100+B8]");
					obj38 = 0;
				}
				object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj45 = (nint)0 + (nint)1768;
				func2..ctor(obj38, (IntPtr)obj45);
				object obj46 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X8_v97+B8]");
				object obj48 = (nint)0 + (nint)32;
				obj48 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num5 = (nint)func2;
				obj16 = 0;
				miniGameHand = this;
				goto IL_1056;
				IL_1056:
				object obj49 = (nint)0 + (nint)1928;
				obj9 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCB9C8");
				bool flag18 = (object)transform3 == null;
				enumerator2 = (List<object>.Enumerator)0;
				num2 = num5;
				if (flag18)
				{
					break;
				}
				transform3.SetSiblingIndex(siblingIndex);
				Transform transform4 = gameObject.transform;
				bool flag19 = (object)transform4 == null;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag19)
				{
					break;
				}
				Vector3 lossyScale = transform4.lossyScale;
				Transform transform5 = gameObject.transform;
				bool flag20 = (object)transform5 == null;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag20)
				{
					break;
				}
				object obj50 = typeof(UsageHint) + 816;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v65+B8]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v66+14]");
				float num6 = 0f * 1.06032006E+09f;
				float num7 = num6 / num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v66+C]");
				object obj53 = 0 * obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num3 = (float)obj53 / (float)obj55;
				transform5.localScale = (Vector3)0;
				Transform transform6 = gameObject.transform;
				bool flag21 = (object)transform6 == null;
				num4 = num8;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag21)
				{
					break;
				}
				transform6.position = (Vector3)0;
				Sequence sequence9 = TweenSettingsExtensions.AppendInterval(sequence2, 0.1f);
				Transform target3 = gameObject.transform;
				object obj56 = typeof(UsageHint) + 816;
				object obj57 = obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v73+B8]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v831 @ X8_v74+C]");
				object obj59 = 0 * obj60;
				float duration = (float)obj59 / (float)obj55;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target3, (Vector3)0, duration);
				object obj61 = (nint)0 + (nint)2904;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Sequence sequence10 = TweenSettingsExtensions.Append(sequence2, t2);
				Transform target4 = gameObject.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMove(target4, (Vector3)0, 0f);
				object obj62 = (nint)0 + (nint)3096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059474");
				Sequence sequence11 = TweenSettingsExtensions.Join(sequence2, t3);
				Sequence sequence12 = TweenSettingsExtensions.AppendInterval(sequence2, 0.3f);
				MiniGame miniGame4 = miniGameHand.miniGame;
				bool flag22 = (object)miniGameHand.miniGame == null;
				double num9 = 0.5;
				num7 = 0f;
				num4 = 1.1329208E+09f;
				num3 = 1.0502537E+09f;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag22)
				{
					break;
				}
				object obj63 = obj11;
				bool flag23 = obj11 == null;
				num9 = 0.5;
				num7 = 0f;
				num4 = 1.1329208E+09f;
				num3 = 1.0502537E+09f;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag23)
				{
					break;
				}
				MiniGameVisuals visuals2 = miniGame4.visuals;
				bool flag24 = (object)miniGame4.visuals == null;
				num9 = 0.5;
				num7 = 0f;
				num4 = 1.1329208E+09f;
				num3 = 1.0502537E+09f;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag24)
				{
					break;
				}
				bool flag25 = (object)visuals2.controls == null;
				num9 = 0.5;
				num7 = 0f;
				num4 = 1.1329208E+09f;
				num3 = 1.0502537E+09f;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = unchecked((nint)null);
				if (flag25)
				{
					break;
				}
				MiniGameControls controls = visuals2.controls;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v83+18]");
				Tween t4 = controls.AnimateReward(gameObject, 0);
				Sequence sequence13 = TweenSettingsExtensions.Append(sequence2, t4);
				num3 = (float)num * 1.06032006E+09f;
				object obj64 = (nint)0 + (nint)2784;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				Sequence sequence14 = TweenSettingsExtensions.Join(s, sequence2);
				num++;
				miniGame = miniGameHand.miniGame;
				bool flag26 = (object)miniGameHand.miniGame == null;
				object obj65 = !flag26;
				num9 = 0.5;
				num7 = 0f;
				num4 = 1.06032006E+09f;
				enumerator2 = (List<object>.Enumerator)0;
				obj9 = 0;
				num2 = (nint)sequence2;
				if (obj65 == null)
				{
					num9 = 0.5;
					num7 = 0f;
					num4 = 1.06032006E+09f;
					enumerator2 = (List<object>.Enumerator)0;
					obj9 = 0;
					num2 = (nint)sequence2;
					break;
				}
				continue;
				IL_03ca:
				bool flag27 = list == null;
				object obj66 = !flag27;
				if (obj66 == null)
				{
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X9_v6+18]");
					num2 = 0;
					break;
				}
				goto IL_04ba;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_121b;
		IL_0eb7:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		goto IL_121b;
		IL_0e89:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		obj16 = 0;
		obj9 = 0;
		num2 = unchecked((nint)null);
		goto IL_121b;
		IL_0f20:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		num2 = intPtr;
		goto IL_121b;
		IL_121b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237E6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0f3f:
		ex = new NullReferenceException();
		num4 = 1.06032006E+09f;
		enumerator2 = (List<object>.Enumerator)0;
		obj16 = 0;
		obj9 = 0;
		num2 = (nint)tweenerCore;
		goto IL_121b;
		IL_0ed3:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		obj16 = 0;
		obj9 = 0;
		num2 = (nint)tweenCallback2;
		goto IL_121b;
		IL_0f04:
		ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		num2 = unchecked((nint)null);
		goto IL_121b;
	}

	private void OnFinishedCardsAnimation()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0143: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0209: Expected O, but got I
		//IL_021a: Expected I, but got O
		//IL_0238: Expected O, but got I
		//IL_01ab: Expected O, but got I
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		object obj;
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if (<State>k__BackingField.<RemainingMoves>k__BackingField >= 1)
		{
			obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+28]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+28]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0159;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+28]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v11+28]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0159;
				}
			}
			goto IL_01b0;
		}
		goto IL_01c4;
		IL_01b0:
		ArraysExtensions.ForEach(gameCards, action);
		goto IL_01c4;
		IL_01c4:
		Actions.SafeInvoke(this.OnFinishedDrawingCard);
		return;
		IL_0159:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v17+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1776;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v16+B8]");
		object obj13 = (nint)0 + (nint)40;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		obj3 = obj6;
		goto IL_01b0;
	}

	private void OnInitialized()
	{
		ResetUi();
	}

	private void OnGameStart(MiniGameState state)
	{
		//IL_0028: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0099: Expected I, but got O
		//IL_00dd: Expected O, but got I
		//IL_00fd: Expected I, but got O
		//IL_0117: Expected O, but got I
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		MiniGame miniGame2 = this.miniGame;
		MiniGameVisuals visuals2 = miniGame2.visuals;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		visuals2.Playground.CallWhenReady(action);
		MiniGame miniGame3 = this.miniGame;
		object visuals3 = miniGame3.visuals;
		object obj4 = (nint)0 + (nint)2928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(miniGame3.visuals, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v5 (System.Object)+60]");
		((OneShotEvent)0).CallWhenReady(action2);
	}

	private void OnMoveSent()
	{
		//IL_0032: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0257: Expected O, but got I
		//IL_0268: Expected I, but got O
		//IL_0286: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_01ee: Expected O, but got I
		UnmarkRewardCards();
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		List<MiniGameCard> selectedCards = SelectedCards;
		object obj = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
		visuals.playground.DiscardCards(selectedCards);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v14+E4]");
		object obj5;
		Action<object> action;
		object obj7;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v14+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
				Action<object> action2 = (Action<object>)0;
				goto IL_019c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v14+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
			Action<object> action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v12+30]");
			action = (Action<object>)0;
			if (obj8 == null)
			{
				goto IL_019c;
			}
		}
		goto IL_021d;
		IL_019c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v18+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1784;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v17+B8]");
		object obj14 = (nint)0 + (nint)48;
		obj14 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		action = action3;
		goto IL_021d;
		IL_021d:
		ArraysExtensions.ForEach(gameCards, action);
	}

	private void OnMove(MiniGameState state)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		//IL_004f: Expected I, but got O
		//IL_0093: Expected O, but got I
		//IL_00b3: Expected I, but got O
		//IL_00cd: Expected O, but got I
		MiniGame miniGame = this.miniGame;
		MiniGameVisuals visuals = miniGame.visuals;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		visuals.Playground.CallWhenReady(action);
		MiniGame miniGame2 = this.miniGame;
		object visuals2 = miniGame2.visuals;
		object obj3 = (nint)0 + (nint)2936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(miniGame2.visuals, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X20_v4 (System.Object)+60]");
		((OneShotEvent)0).CallWhenReady(action2);
	}

	private void OnClaim(MiniGameState state)
	{
		MiniGame miniGame = this.miniGame;
		MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
		if (Enumerable.Any((IEnumerable<object>)<State>k__BackingField.<Rewards>k__BackingField))
		{
			HighlightRewardCards();
		}
	}

	public void HighlightRewardCards()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0114: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		MiniGameCard[] array = gameCards;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array + 32;
		object obj2 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X22_v4+v64 @ X21_v5*8]");
			MiniGameCard miniGameCard = (MiniGameCard)0;
			if (miniGameCard._isPartOfProject)
			{
				miniGameCard.isPartOfProject = true;
				Transform target = miniGameCard.transform;
				float endValue = ((UiCard)miniGameCard)._cardPositionY + 30f;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, endValue, 0.1f, snapping: true);
				Transform target2 = miniGameCard.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1.1f, 0.1f);
				obj2++;
				miniGameCard.<intractable>k__BackingField = false;
				if ((nint)obj2 >= array.Length)
				{
					break;
				}
			}
			else
			{
				miniGameCard.SetStatus(MiniGameCardStatus.InHand);
				obj2++;
				miniGameCard.<intractable>k__BackingField = false;
				if ((nint)obj2 >= array.Length)
				{
					break;
				}
			}
		}
	}

	public void ReturnRewardCards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_029f: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_02df: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0339: Expected O, but got I
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected O, but got Unknown
		//IL_0a1f: Expected O, but got I
		//IL_0a30: Expected I, but got O
		//IL_0a30: Expected O, but got I
		//IL_0a38: Expected I, but got O
		//IL_0a4e: Expected O, but got I
		//IL_03e9: Expected O, but got I4
		//IL_03f2: Expected O, but got I4
		//IL_03fb: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0175: Expected I, but got O
		//IL_0185: Expected O, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0250: Expected O, but got I4
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b9: Expected O, but got Unknown
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09e5: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_0929: Expected O, but got I
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_045f: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0542: Expected O, but got I4
		//IL_0ac6: Expected O, but got I
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Expected O, but got Unknown
		//IL_04aa: Expected O, but got I
		//IL_0767: Expected O, but got I4
		//IL_0770: Expected O, but got I4
		//IL_0a75: Expected O, but got I
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_0ba2: Expected O, but got I4
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04db: Expected O, but got I
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected O, but got Unknown
		//IL_078d: Expected O, but got I
		//IL_05bc: Expected O, but got I
		//IL_082c: Expected O, but got I4
		//IL_068f: Expected O, but got I4
		//IL_0be4: Expected O, but got I
		//IL_07c8: Expected O, but got I
		//IL_0b5c: Expected O, but got I
		//IL_05f7: Expected O, but got I
		//IL_06f8: Expected F4, but got I
		//IL_0b0b: Expected O, but got I
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b7: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_07f1: Expected O, but got I
		//IL_074f: Expected O, but got I4
		//IL_0758: Expected O, but got I4
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0628: Expected O, but got I
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63E9]");
		object obj2 = (nint)0 & (nint)1;
		MiniGameCard[] array;
		MiniGameCard[] array2;
		object obj3;
		if (obj2 != null)
		{
			array = gameCards;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			array2 = gameCards;
			if (!flag)
			{
				goto IL_0092;
			}
		}
		else
		{
			_ = 1;
			array = gameCards;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v48+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			array2 = gameCards;
			if (obj5 != null)
			{
				goto IL_0092;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		object obj6 = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v48+B8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		IEnumerable<object> source = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		Func<object, bool> func = (Func<object, bool>)0;
		object obj8 = obj6;
		nint num2 = num;
		IEnumerable<object> source2 = array2;
		if (obj7 != null)
		{
			goto IL_0113;
		}
		goto IL_035f;
		IL_0991:
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 936;
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v2+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v2] (should have been resolved before IL gen)");
		object obj15 = default(object);
		object obj19 = default(object);
		object obj21 = default(object);
		bool flag6 = default(bool);
		object obj27;
		object obj30 = default(object);
		object obj36;
		object obj28;
		Component component = default(Component);
		while (true)
		{
			object obj18;
			object obj20;
			object obj17;
			object obj26;
			if (obj15 != null)
			{
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v13+12E]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v13+12E]");
				bool flag4 = (nint)0 == 0;
				obj18 = obj19;
				obj20 = obj21;
				if (flag4)
				{
					goto IL_052f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v13+B0]");
				object obj22 = (nint)0 + (nint)8;
				bool flag5 = flag6;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v23-8]");
					obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v23-8]");
					object obj23 = 0 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v23-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj20 = obj22 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v13+12E]");
					obj17 = -1;
					obj23 = obj17 - 1;
					bool flag7 = obj23 == null;
					flag6 = (nint)obj17 != 1;
					flag5 = flag6;
					obj22 = obj20;
					if (flag6)
					{
						continue;
					}
					goto IL_052f;
				}
				obj17 = obj22;
				object obj24 = obj16 + obj22;
				object obj25 = obj24 + 312;
				flag6 = flag5;
				obj20 = obj22;
				obj26 = obj27;
				goto IL_0ab5;
			}
			throw new NullReferenceException();
			IL_052f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj26 = 0;
			goto IL_0ab5;
			IL_0ab5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v24+8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v448 @ X0_v24] (should have been resolved before IL gen)");
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				if (obj15 != null)
				{
					object obj31 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v16+12E]");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v16+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v16+B0]");
						object obj32 = (nint)0 + (nint)8;
						bool flag8 = flag6;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v18-8]");
							obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v18-8]");
							object obj23 = 0 - obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v18-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj20 = obj32 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v16+12E]");
							obj17 = -1;
							obj23 = obj17 - 1;
							bool flag7 = obj23 == null;
							flag6 = (nint)obj17 != 1;
							flag8 = flag6;
							obj32 = obj20;
							if (flag6)
							{
								continue;
							}
							goto IL_067c;
						}
						obj17 = obj32;
						object obj33 = obj31 + obj32;
						object obj34 = obj33 + 312;
						flag6 = flag8;
						obj20 = obj32;
						goto IL_0b4b;
					}
					goto IL_067c;
				}
				throw new NullReferenceException();
			}
			object obj35 = 0;
			obj36 = 0;
			break;
			IL_067c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj26 = 0;
			goto IL_0b4b;
			IL_0b4b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X0_v28+8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v652 @ X0_v28] (should have been resolved before IL gen)");
			Transform target = component.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X0_v30 (UnityEngine.Component)+30]");
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, 0f, 0.1f, snapping: true);
			Transform target2 = component.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.1f);
			obj19 = obj18;
			obj21 = obj20;
			obj12 = obj17;
			obj27 = 0;
			obj14 = 0;
		}
		object obj42 = default(object);
		while (true)
		{
			if (obj15 == null)
			{
				goto IL_0b88;
			}
			object obj37 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v8+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0819;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v8+B0]");
			object obj38 = (nint)0 + (nint)8;
			object obj20;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X10_v10-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj20 = obj38 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v8+12E]");
				obj17 = -1;
				bool flag9 = (nint)obj17 != 1;
				obj38 = obj20;
				if (flag9)
				{
					continue;
				}
				goto IL_0819;
			}
			obj17 = obj38;
			object obj39 = obj37 + obj38;
			object obj40 = obj39 + 312;
			obj20 = obj38;
			goto IL_0bd4;
			IL_0b88:
			bool flag10 = obj36 == null;
			object obj41 = !flag10;
			if (obj41 == null)
			{
				return;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)obj28 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj36 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj35 = obj42;
			continue;
			IL_0819:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj26 = 0;
			goto IL_0bd4;
			IL_0bd4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v16+8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v711 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_0b88;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0159:
		object obj43 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3512;
		IEnumerable<object> enumerable;
		num = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_023d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj45 = (nint)0 + (nint)8;
		bool flag11 = flag6;
		object obj46;
		object obj48;
		object obj47 = default(object);
		NullReferenceException ex2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v30-8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v30-8]");
			object obj23 = 0 - obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X10_v30-8]");
			bool flag7 = 0 == (nint)obj43;
			obj46 = obj47;
			flag6 = flag11;
			obj21 = obj45;
			obj27 = obj48;
			ex2 = (NullReferenceException)enumerable;
			if (flag7)
			{
				break;
			}
			obj21 = obj45 + 16;
			obj44--;
			obj23 = obj44 - 1;
			flag7 = obj23 == null;
			flag6 = (nint)obj44 != 1;
			flag11 = flag6;
			obj45 = obj21;
			if (flag6)
			{
				continue;
			}
			goto IL_023d;
		}
		goto IL_041f;
		IL_0411:
		ex2 = new NullReferenceException();
		goto IL_041f;
		IL_0092:
		obj6 = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v48+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		bool flag12 = (nint)0 == 0;
		source = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+38]");
		func = (Func<object, bool>)0;
		obj8 = obj6;
		num2 = num;
		source2 = array;
		if (!flag12)
		{
			goto IL_0113;
		}
		goto IL_035f;
		IL_035f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v48+E4]");
		bool flag13 = (nint)0 == 0;
		object obj49 = !flag13;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj50 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v33+B8]");
			num2 = 0;
		}
		object obj51 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)1792;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)num2, (IntPtr)obj52);
		num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
		object obj53 = (nint)0 + (nint)56;
		obj53 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj48 = obj8;
		enumerable = Enumerable.Where(source2, func2);
		bool flag14 = enumerable == null;
		object obj54 = !flag14;
		obj47 = 0;
		obj46 = 0;
		obj27 = obj8;
		if (obj54 != null)
		{
			goto IL_0159;
		}
		goto IL_0411;
		IL_041f:
		object obj55 = num + obj21;
		obj13 = obj55 + 312;
		obj47 = obj46;
		goto IL_0991;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj27 = 0;
		ex2 = (NullReferenceException)enumerable;
		object obj56 = default(object);
		obj13 = obj56;
		goto IL_0991;
		IL_0113:
		obj48 = obj6;
		enumerable = Enumerable.Where(source, predicate);
		bool flag15 = enumerable == null;
		obj46 = obj47;
		obj27 = obj6;
		if (!flag15)
		{
			goto IL_0159;
		}
		goto IL_0411;
	}

	private void UnmarkRewardCards()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00b9: Expected O, but got I
		MiniGameCard[] array = gameCards;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v4+v60 @ X21_v5*8]");
				MiniGameCard miniGameCard = (MiniGameCard)0;
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v4+v60 @ X21_v5*8]");
				((MiniGameCard)0).isPartOfProject = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v4+v60 @ X21_v5*8]");
				Transform target = ((Component)0).transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, ((UiCard)miniGameCard)._cardPositionY, 0.1f, snapping: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v4+v60 @ X21_v5*8]");
				Transform target2 = ((Component)0).transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.1f);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	public void SendMove()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_0238: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01f7: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02df: Expected O, but got I
		//IL_02f0: Expected I, but got O
		//IL_030e: Expected O, but got I
		//IL_0298: Expected O, but got I4
		//IL_0268: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63EA]");
		object obj3 = (nint)0 & (nint)1;
		MiniGame miniGame;
		List<MiniGameCard> list;
		List<MiniGameCard> list2;
		MiniGame miniGame2;
		object obj4;
		if (obj3 != null)
		{
			miniGame = this.miniGame;
			List<MiniGameCard> selectedCards = SelectedCards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			list = selectedCards;
			list2 = selectedCards;
			object obj5 = obj4;
			miniGame2 = this.miniGame;
			if (!flag)
			{
				goto IL_00b3;
			}
		}
		else
		{
			_ = 1;
			miniGame = this.miniGame;
			List<MiniGameCard> selectedCards2 = SelectedCards;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			list = selectedCards2;
			list2 = selectedCards2;
			object obj5 = obj4;
			miniGame2 = this.miniGame;
			if (obj6 != null)
			{
				goto IL_00b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+40]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+40]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		miniGame = miniGame2;
		if (obj8 != null)
		{
			goto IL_010a;
		}
		goto IL_0216;
		IL_0120:
		IEnumerable<object> cards;
		miniGame.SendMove((IEnumerable<Card>)cards);
		return;
		IL_010a:
		cards = Enumerable.Select(list, selector);
		goto IL_0120;
		IL_0216:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1800;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)64;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		cards = Enumerable.Select(list2, func);
		bool flag5 = (object)miniGame2 == null;
		object obj15 = !flag5;
		miniGame = miniGame2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0120;
		IL_00b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+40]");
		selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v4+40]");
		bool flag6 = (nint)0 == 0;
		list2 = list;
		miniGame2 = miniGame;
		if (!flag6)
		{
			goto IL_010a;
		}
		goto IL_0216;
	}

	private static int OriginalCardOrder(MiniGameCard card1, MiniGameCard card2)
	{
		//IL_0126: Expected I4, but got O
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		if ((object)card1 == null || (object)card2 == null)
		{
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		object obj = (object)((UiCard)card1).card | (object)((UiCard)card2).card;
		int num = ((obj != null) ? (-1) : 0);
		int result = ((((UiCard)card1).card != null) ? 1 : num);
		if (((UiCard)card1).card != null && ((UiCard)card2).card != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return CardUtils.OriginalCardOrder(((UiCard)card1).card, ((UiCard)card2).card);
		}
		return result;
	}

	private static int OriginalCardOrder(Card card1, Card card2)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		object obj = (object)card1 | (object)card2;
		int num = ((obj != null) ? (-1) : 0);
		int result = ((card1 != null) ? 1 : num);
		if (card1 != null && card2 != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return CardUtils.OriginalCardOrder(card1, card2);
		}
		return result;
	}

	public MiniGameHand()
	{
		//IL_0012: Expected F4, but got I
		//IL_0024: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B50]");
		cardSpacing = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B60]");
		organizeDelay = 0f;
		flipDelay = 0.17f;
		base..ctor();
	}

	private void <Awake>b__23_0(MiniGameCard card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004b: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
		object obj2 = (nint)0 + (nint)2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		card.OnSelected += action;
	}

	private bool <AnimateDrawCards>b__26_0(Card card)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2456;
			object obj4 = (nint)0 + (nint)1824;
			object obj5 = obj2 + 16;
			obj5 = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			bool flag = Enumerable.Any(gameCards, func);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool <AnimateDrawCards>b__26_1(MiniGameCard gameCard)
	{
		//IL_00b0: Expected I4, but got O
		MiniGame miniGame = this.miniGame;
		if ((object)this.miniGame != null)
		{
			MiniGameState <State>k__BackingField = miniGame.<State>k__BackingField;
			if (miniGame.<State>k__BackingField != null && (object)gameCard != null && <State>k__BackingField.<HandCards>k__BackingField != null)
			{
				bool flag = ((List<object>)(object)<State>k__BackingField.<HandCards>k__BackingField).Contains((object)((UiCard)gameCard).card);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
