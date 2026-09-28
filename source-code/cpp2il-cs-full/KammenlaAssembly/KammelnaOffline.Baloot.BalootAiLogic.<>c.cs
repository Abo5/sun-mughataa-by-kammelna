using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using KammelnaOffline.Common;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace KammelnaOffline.Baloot;

public class BalootAiLogic : AbstractAiLogic
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<KeyValuePair<Suit, List<Card>>, IEnumerable<Card>> <>9__2_0;

		public static Func<BalootOfflinePlayer, bool> <>9__2_1;

		public static Func<Card, Suit> <>9__9_0;

		public static Func<IGrouping<Suit, Card>, Card> <>9__9_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal IEnumerable<Card> <PlayCard>b__2_0(KeyValuePair<Suit, List<Card>> pair)
		{
			//IL_000a: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<Card>)(nint)intPtr;
		}

		internal bool <PlayCard>b__2_1(BalootOfflinePlayer player)
		{
			//IL_0035: Expected I4, but got O
			if (player != null)
			{
				return player.HasEkkah;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Suit <GetEatingCards>b__9_0(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}

		internal Card <GetEatingCards>b__9_1(IGrouping<Suit, Card> cards)
		{
			return (Card)Enumerable.First((IEnumerable<object>)cards);
		}
	}

	protected BalootGameController _gameController;

	public BalootAiLogic(BalootGameController gameController)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override Card PlayCard(List<Card> cards, int playerIndex)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_05d1: Expected O, but got I
		//IL_05e2: Expected O, but got I
		//IL_05f2: Expected O, but got I
		//IL_0614: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_0150: Unsupported input type for neg.
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_064c: Expected O, but got I
		//IL_065d: Expected I, but got O
		//IL_067b: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_0721: Expected O, but got I
		//IL_0731: Expected O, but got I
		//IL_0753: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_0793: Expected O, but got I
		//IL_07a4: Expected I, but got O
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_07d6: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0200: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02be: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_031d: Expected O, but got I
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected I4, but got Unknown
		//IL_03d7: Expected O, but got I
		//IL_04f8: Invalid comparison between F4 and I4
		BalootGameController gameController = _gameController;
		if (_gameController != null)
		{
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = (nint)0 + (nint)264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v7+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v48+8]");
			Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>> selector = (Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v48+8]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v7+E4]");
				bool flag3 = (nint)0 == 0;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v54+B8]");
					obj5 = 0;
				}
				object obj9 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3704;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)616;
				Func<KeyValuePair<System.Int32Enum, object>, object> func = default(Func<KeyValuePair<System.Int32Enum, object>, object>);
				func..ctor(obj5, (IntPtr)obj10);
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v53+B8]");
				object obj12 = (nint)0 + (nint)8;
				obj12 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = (Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>>)func;
			}
			IEnumerable<object> source = Enumerable.SelectMany((IEnumerable<KeyValuePair<System.Int32Enum, object>>)gameController.AllPlayedCards, selector);
			object[] array = Enumerable.ToArray(source);
			object obj13 = playerIndex + 1;
			object obj14 = 0 - obj13;
			object obj15 = obj14 & 3;
			object obj16 = obj13 & 3;
			object obj17 = ((0 >= (nint)obj13) ? ((object)(0 - obj15)) : obj16);
			BalootGameController gameController2 = _gameController;
			if (_gameController != null)
			{
				object obj18 = (nint)0 + (nint)1144;
				IEnumerable<object> source2 = Enumerable.Cast<object>(((OfflineGameController)gameController2).Players);
				object[] source3 = Enumerable.ToArray(source2);
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					object obj20 = 152993792;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj19 = obj;
					object obj20 = 152993792;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v17+B8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v35+10]");
				Func<object, bool> selector2 = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v35+10]");
				bool flag4 = (nint)0 == 0;
				object obj22 = !flag4;
				object[] playedCards = array;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v17+E4]");
					bool flag5 = (nint)0 == 0;
					object obj23 = !flag5;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj24 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2536;
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v45+B8]");
						obj21 = 0;
					}
					object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 272;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj27 = (nint)0 + (nint)624;
					Func<object, bool> func2 = default(Func<object, bool>);
					func2..ctor(obj21, (IntPtr)obj27);
					object obj28 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2536;
					object obj29 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v42+B8]");
					object obj30 = (nint)0 + (nint)16;
					obj30 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					selector2 = func2;
					playedCards = array;
				}
				IEnumerable<bool> source4 = Enumerable.Select(source3, selector2);
				bool[] ekkahFlags = Enumerable.ToArray(source4);
				BalootGameController gameController3 = _gameController;
				if (_gameController != null)
				{
					List<Card> list = BalootUtils.PlayableCards(cards, gameController3.PlayedCards, gameController3.FirstPlayer, playerIndex, gameController3.GameMode, gameController3.CurrentSuit, gameController3.TrumpSuit, gameController3.IsHokomClose, ekkahFlags);
					BalootGameController gameController4 = _gameController;
					if (_gameController != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X21_v8+C0]");
						object obj31 = (nint)0 & (nint)1;
						bool flag6 = obj31 == null;
						object obj32 = !flag6;
						if (obj32 == null)
						{
							_ = 1;
						}
						IEnumerable<object> source5 = Enumerable.Cast<object>(((OfflineGameController)gameController4).Players);
						object[] array2 = Enumerable.ToArray(source5);
						if (array2 != null)
						{
							bool flag7 = (nint)obj17 < array2.Length;
							object obj33 = !flag7;
							if (obj33 != null)
							{
								goto IL_058e;
							}
							object obj34 = (object)array2 + obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v24+20]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v24+20]");
							if ((nint)0 != 0)
							{
								BalootGameController gameController5 = _gameController;
								if (_gameController != null)
								{
									bool firstPlayer = !gameController5.FirstPlayer;
									int playerIndex2 = obj17 + 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v7+18]");
									List<Card> playableCards = BalootUtils.PlayableCards((List<Card>)0, gameController5.PlayedCards, firstPlayer, playerIndex2, gameController5.GameMode, gameController5.CurrentSuit, gameController5.TrumpSuit, gameController5.IsHokomClose, ekkahFlags);
									BalootGameController gameController6 = _gameController;
									if (_gameController != null)
									{
										Suit type;
										if (gameController6.FirstPlayer)
										{
											List<Card> eatingCards = GetEatingCards(list, (Card[])playedCards);
											Card card = (Card)Enumerable.FirstOrDefault((IEnumerable<object>)eatingCards);
											if (card != null)
											{
												return card;
											}
											List<Card> eatingCards2 = GetEatingCards(playableCards, (Card[])playedCards);
											object obj36 = Enumerable.FirstOrDefault((IEnumerable<object>)eatingCards2);
											float value = UnityEngine.Random.value;
											if (value > 1.06199776E+09f && obj36 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X0_v44 (System.Object)+14]");
												type = Suit.SPADES;
											}
											else
											{
												Card maxCard = GetMaxCard(list);
												if (maxCard == null)
												{
													goto IL_0580;
												}
												type = maxCard.<Suit>k__BackingField;
											}
										}
										else
										{
											type = gameController6.CurrentSuit;
										}
										List<Card> suitCards = BalootUtils.GetSuitCards(list, type);
										if (suitCards != null)
										{
											List<Card> cards2 = ((suitCards._size != 0) ? suitCards : list);
											return GetMinCard(cards2);
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0580;
		IL_0580:
		NullReferenceException ex = new NullReferenceException();
		goto IL_058e;
		IL_058e:
		return (Card)(object)new IndexOutOfRangeException();
	}

	private static int GetTeammateIndex(int playerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0061: Unsupported input type for neg.
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected I4, but got Unknown
		object obj = playerIndex + 1;
		object obj2 = 0 - obj;
		object obj3 = obj2 & 3;
		object obj4 = obj & 3;
		if (0 >= (nint)obj)
		{
			obj4 = 0 - obj3;
		}
		return obj4 + 1;
	}

	private Card Bait(List<Card> playableCards)
	{
		List<Card> cards = default(List<Card>);
		Card maxCard = GetMaxCard(cards);
		if (maxCard != null)
		{
			List<Card> suitCards = BalootUtils.GetSuitCards(cards, maxCard.<Suit>k__BackingField);
			if (suitCards != null)
			{
				if (suitCards._size == 0)
				{
				}
				return GetMinCard(suitCards);
			}
		}
		return (Card)(object)new NullReferenceException();
	}

	private Card Starve(List<Card> playableCards)
	{
		BalootGameController gameController = _gameController;
		if (_gameController != null)
		{
			List<Card> cards = default(List<Card>);
			List<Card> suitCards = BalootUtils.GetSuitCards(cards, gameController.CurrentSuit);
			if (suitCards != null)
			{
				if (suitCards._size == 0)
				{
				}
				return GetMinCard(suitCards);
			}
		}
		return (Card)(object)new NullReferenceException();
	}

	private Card GetMinOfSuit(Suit suit, List<Card> _cards)
	{
		Suit type = default(Suit);
		List<Card> suitCards = BalootUtils.GetSuitCards(_cards, type);
		if (suitCards == null)
		{
			return (Card)(object)new NullReferenceException();
		}
		List<Card> cards = ((suitCards._size != 0) ? suitCards : _cards);
		return GetMinCard(cards);
	}

	private Card GetMinCard(List<Card> _cards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0076: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
		object obj2 = (nint)0 + (nint)1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor((object)_gameController, (IntPtr)obj2);
		if (_cards != null)
		{
			((List<object>)(object)_cards).Sort(comparison);
			return (Card)Enumerable.Last((IEnumerable<object>)_cards);
		}
		return (Card)(object)new NullReferenceException();
	}

	private Card GetMaxCard(List<Card> _cards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0076: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
		object obj2 = (nint)0 + (nint)1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor((object)_gameController, (IntPtr)obj2);
		if (_cards != null)
		{
			((List<object>)(object)_cards).Sort(comparison);
			return (Card)Enumerable.First((IEnumerable<object>)_cards);
		}
		return (Card)(object)new NullReferenceException();
	}

	private List<Card> GetEatingCards(List<Card> playableCards, Card[] playedCards)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_034b: Expected O, but got I
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0389: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a2: Expected I, but got O
		//IL_0190: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_01d2: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_042d: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_0470: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_03d2: Expected I, but got O
		//IL_03f0: Expected O, but got I
		//IL_040b: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_0243: Expected O, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I
		//IL_04b9: Expected I, but got O
		//IL_04d7: Expected O, but got I
		//IL_02fa: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1968;
		object obj2 = (nint)0 + (nint)3872;
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 456;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<Card> allBalootCards = BalootCardUtils.AllBalootCards;
		IEnumerable<object> source = Enumerable.Except((IEnumerable<object>)allBalootCards, (IEnumerable<object>)playedCards);
		object gameController = _gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7;
		IOrderedEnumerable<object> source2;
		object obj10;
		Func<object, System.Int32Enum> keySelector;
		object obj13;
		object obj12;
		object obj9;
		if (_gameController != null)
		{
			object obj6 = (nint)0 + (nint)2360;
			obj7 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2536;
			nint num = (nint)gameController;
			BalootGameController gameController2 = _gameController;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4 (Il2CppClass<System.Object>)+3C0]");
			Func<object, int> func = default(Func<object, int>);
			func..ctor((object)gameController2, (IntPtr)0);
			source2 = Enumerable.OrderByDescending(source, func);
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				obj9 = (nint)0 + (nint)1520;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v32+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v19+18]");
				keySelector = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v19+18]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				obj12 = 0;
				if (obj11 == null)
				{
					obj13 = obj9;
					goto IL_01f1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
				obj13 = (nint)0 + (nint)1520;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v32+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v19+18]");
				keySelector = (Func<object, System.Int32Enum>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v19+18]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				obj12 = 0;
				obj9 = obj13;
				if (obj14 == null)
				{
					goto IL_01f1;
				}
			}
			goto IL_0248;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_01f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v32+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v25+B8]");
			obj10 = 0;
		}
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)600;
		Func<object, System.Int32Enum> func2 = default(Func<object, System.Int32Enum>);
		func2..ctor(obj10, (IntPtr)obj18);
		object obj19 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v24+B8]");
		object obj20 = (nint)0 + (nint)24;
		obj20 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = 0;
		obj9 = obj13;
		keySelector = func2;
		goto IL_0248;
		IL_0248:
		IEnumerable<IGrouping<System.Int32Enum, object>> source3 = Enumerable.GroupBy(source2, keySelector);
		object obj21 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj7;
		}
		object obj23 = (nint)0 + (nint)1592;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+20]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v10+20]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v16+B8]");
				obj24 = 0;
			}
			object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)608;
			Func<object, object> func3 = default(Func<object, object>);
			func3..ctor(obj24, (IntPtr)obj29);
			object obj30 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v15+B8]");
			object obj31 = (nint)0 + (nint)32;
			obj31 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func3;
		}
		IEnumerable<object> enumerable = Enumerable.Select(source3, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC67D0");
		IEnumerable<object> source4 = default(IEnumerable<object>);
		return (List<Card>)(object)Enumerable.ToList(source4);
	}

	public unsafe override string Bid(int biddingState, List<Card> cards, int playerIndex)
	{
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0064: Expected O, but got I4
		//IL_0015: Expected O, but got Ref
		//IL_00a1: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_0534: Expected O, but got Ref
		//IL_019b: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_04d6: Expected O, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_03a2: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1960;
		object obj2;
		object obj3;
		if (biddingState == 3)
		{
			obj2 = obj;
			object obj4 = default(object);
			obj3 = (object)(&obj4);
			goto IL_040a;
		}
		object obj5 = (nint)0 + (nint)3168;
		BalootBiddingOption[] biddingOptionsFromState = BalootBiddingOptions.GetBiddingOptionsFromState(biddingState);
		bool flag = Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)13);
		bool flag2 = !flag;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
		}
		bool flag3 = Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)2);
		bool flag4 = !flag3;
		bool flag5 = flag;
		List<Card> cards2 = default(List<Card>);
		if (!flag4)
		{
			bool flag6 = !flag;
			object obj8 = !flag6;
			flag5 = flag;
			if (obj8 == null)
			{
				BalootGameController gameController = _gameController;
				if (_gameController == null)
				{
					goto IL_03c8;
				}
				bool flag7 = BalootUtils.CheckIfAiCouldBuySun(cards2, gameController.FloorCard);
				bool flag8 = !flag7;
				object obj9 = !flag8;
				object obj10 = ~obj9;
				flag5 = ((obj10 != null) ? flag7 : flag7);
			}
		}
		if (Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)7))
		{
			BalootGameController gameController2 = _gameController;
			if (_gameController == null)
			{
				goto IL_03c8;
			}
			bool flag9 = BalootUtils.CheckIfAiCouldBuyHokom1(cards2, gameController2.FloorCard);
			bool flag10 = !flag5;
			object obj11 = !flag10;
			object obj12 = ~obj11;
			if (obj12 == null)
			{
			}
			flag5 = flag9 || flag5;
			bool flag11 = !flag9;
			object obj13 = !flag11;
			object obj14 = ~obj13;
			if (obj14 != null)
			{
			}
		}
		if (Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)9))
		{
			bool flag12 = !flag5;
			object obj15 = !flag12;
			if (obj15 == null)
			{
				BalootGameController gameController3 = _gameController;
				if (_gameController == null)
				{
					goto IL_03c8;
				}
				KeyValuePair<bool, Suit> keyValuePair = BalootUtils.CheckIfAiCouldBuyHokom2(cards2, gameController3.FloorCard);
				object obj16 = keyValuePair & 1;
				bool flag13 = obj16 == null;
				object obj17 = !flag13;
				object obj18 = ~obj17;
				if (obj18 != null)
				{
				}
			}
		}
		List<Card> list = (List<Card>)obj5;
		List<Card> list2;
		if (Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)15))
		{
			if (!flag5)
			{
				goto IL_0308;
			}
			list2 = list;
		}
		else
		{
			list = (List<Card>)obj5;
			bool flag14 = Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)biddingOptionsFromState, (System.Int32Enum)16);
			object obj19 = !flag14;
			object obj20 = flag5 | obj19;
			object obj21 = obj20 & 1;
			bool flag15 = obj21 == null;
			object obj22 = !flag15;
			list2 = (List<Card>)obj5;
			if (obj22 == null)
			{
				goto IL_0308;
			}
		}
		goto IL_0524;
		IL_0308:
		BalootGameController gameController4 = _gameController;
		if (_gameController == null)
		{
			goto IL_03c8;
		}
		KeyValuePair<bool, Suit> keyValuePair2 = BalootUtils.CheckIfAiCouldBuyHokom2(cards2, gameController4.FloorCard);
		object obj23 = keyValuePair2 & 1;
		bool flag16 = obj23 == null;
		list2 = list;
		if (!flag16)
		{
			object obj24 = (object)keyValuePair2 >> 34;
			bool flag17 = obj24 == null;
			object obj25 = !flag17;
			list2 = list;
			if (obj25 == null)
			{
				list2 = list;
			}
		}
		goto IL_0524;
		IL_03c8:
		return (string)(object)new NullReferenceException();
		IL_0524:
		obj2 = obj;
		object obj26 = default(object);
		obj3 = (object)(&obj26);
		goto IL_040a;
		IL_040a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		return EnumExtensions.GetFriendlyName(enumeration);
	}

	public override string GetAction(int playerIndex)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return "___# Content push apply failed [{0}]: {1}" + 2664;
	}
}
